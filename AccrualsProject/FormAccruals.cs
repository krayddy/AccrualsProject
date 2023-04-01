using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AccrualsProject
{
    public partial class FormAccruals : Form
    {
        private string login;
        private Dictionary<string, double> tariffs;
        private Dictionary<string, double> standards;
        private List<string> services;
        private int periodNumber;
        private Dictionary<string, double> dataToSave;
        private Dictionary<string, double> previousData;
        private List<string> keysForDB;
        private double[] historyArray;

        public FormAccruals(Form1 enterForm)
        {
            services = new List<string>();
            dataToSave = new Dictionary<string, double>();
            login = enterForm.GetLogin();
            SetKeysForDB();
            
            GetTariffs();
            
            using (var connection = new SqliteConnection("Data Source=accrualsDB.db"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                var commandText = $"CREATE TABLE IF NOT EXISTS[user_{ login}]([{keysForDB[0]}] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,";
                for (var i = 1; i < keysForDB.Count(); i++)
                {
                    commandText += $"[{keysForDB[i]}] REAL";
                    if (i + 1 != keysForDB.Count())
                        commandText += ",";
                }
                commandText += ")";
                command.CommandText = commandText;
                command.ExecuteNonQuery();
                command.CommandText = $"SELECT COUNT([Расчётный период]) FROM [user_{login}]";
                periodNumber = Convert.ToInt32(command.ExecuteScalar()) + 1;
            }
            GetDataForPreviousPeriod();
            historyArray = new double[keysForDB.Count];
            
            InitializeComponent();
            LoadHistory();

            labelLogin.Text = login;
            labelAccountingPeriod.Text = $"Расчётный период {periodNumber}";
        }

        private void SetKeysForDB()
        {
            keysForDB = new List<string>();
            keysForDB.Add("Расчётный период");
            keysForDB.Add("Показания ХВС");
            keysForDB.Add("Показания ГВС");
            keysForDB.Add("Показания ЭЭ день");
            keysForDB.Add("Показания ЭЭ ночь");
            keysForDB.Add("Начисления ХВС");
            keysForDB.Add("Начисления ГВС ТН");
            keysForDB.Add("Начисления ГВС ТЭ");
            keysForDB.Add("Начисления ГВС");
            keysForDB.Add("Начисления ЭЭ день");
            keysForDB.Add("Начисления ЭЭ ночь");
            keysForDB.Add("Начисления ЭЭ");
            keysForDB.Add("Итого");
        }

        private void GetDataForPreviousPeriod()
        {
            previousData = new Dictionary<string, double>();
            using (var connection = new SqliteConnection("Data Source=accrualsDB.db"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand($"SELECT * FROM [user_{login}] ORDER BY [{keysForDB[0]}] DESC LIMIT 1", connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            for (var i = 0; i < keysForDB.Count(); i++)
                            {
                                previousData[keysForDB[i]] = double.Parse(reader.GetValue(i).ToString());
                            }
                        }
                    }
                    else
                    {
                        for (var i = 0; i < keysForDB.Count(); i++)
                        {
                            previousData[keysForDB[i]] = 0;
                        }
                    }
                }
            }
        }

        private void buttonCalculateAccruals_Click(object sender, EventArgs e)
        {
            CalculateAccruals();
        }

        private void CalculateAccruals()
        {
            double personCountAverage = 0;
            var personCountText = textBoxPersonCount.Text.Split(',');
            personCountText[0] = "1 " + personCountText[0];
            var personCountChanges = new double[personCountText.Length];
            var personCountChangesDays = new double[personCountText.Length];
            if (personCountText.Length > 1)
            {
                for (var i = 0; i < personCountText.Length; i++)
                {
                    var dayAndCount = personCountText[i].Split(' ').Where(x => x != "").ToArray();
                    personCountChangesDays[i] = double.Parse(dayAndCount[0]);
                    personCountChanges[i] = double.Parse(dayAndCount[1]);
                }
                double daysInPeriod = 30;
                for (var i = 0; i < personCountChangesDays.Length; i++)
                {
                    var daysWithCurrentCount = 0.0;
                    if (i + 1 == personCountChangesDays.Length)
                        daysWithCurrentCount = daysInPeriod - personCountChangesDays[i] + 1;
                    else 
                        daysWithCurrentCount = personCountChangesDays[i + 1] - personCountChangesDays[i];
                    personCountAverage += personCountChanges[i] * 
                        daysWithCurrentCount / daysInPeriod;
                }
            }
            else
            {
                personCountAverage = double.Parse(personCountText[0].Split(' ')[1]);
            }
            if (textBoxColdWaterMeter.Text == null || textBoxColdWaterMeter.Text.Replace(" ", "").Length == 0)
            {
                var coldWaterAccruals = CalculationAlgorithms.GetColdWaterAccruals(
                    tariffs["ХВС"], standards["ХВС"], personCountAverage);
                dataToSave["Начисления ХВС"] = coldWaterAccruals;
                dataToSave["Показания ХВС"] = previousData["Показания ХВС"] + standards["ХВС"];
                labelColdWaterAccruals.Text = dataToSave["Начисления ХВС"].ToString();
            }
            else
            {
                var coldWaterAccruals = CalculationAlgorithms.GetColdWaterAccrualsWithMeter(
                        tariffs["ХВС"], double.Parse(textBoxColdWaterMeter.Text),
                        previousData["Показания ХВС"]);
                dataToSave["Начисления ХВС"] = coldWaterAccruals;
                dataToSave["Показания ХВС"] = double.Parse(textBoxColdWaterMeter.Text);
                labelColdWaterAccruals.Text = dataToSave["Начисления ХВС"].ToString();
            }
            if (textBoxHotWaterMeter.Text == null || textBoxHotWaterMeter.Text.Replace(" ", "").Length == 0)
            {
                var hotWaterAccruals = CalculationAlgorithms.GetHotWaterAccruals(
                    tariffs["ГВС ТН"], tariffs["ГВС ТЭ"], standards["ГВС ТЭ"], 
                    standards["ГВС ТН"], personCountAverage);
                labelHotWaterHCAccruals.Text = hotWaterAccruals.HeatCarrier.ToString();
                labelHotWaterHEAccruals.Text = hotWaterAccruals.HeatEnergy.ToString();
                labelHotWaterAccruals.Text = (hotWaterAccruals.HeatCarrier + hotWaterAccruals.HeatEnergy).ToString();
                dataToSave["Начисления ГВС ТН"] = hotWaterAccruals.HeatCarrier;
                dataToSave["Начисления ГВС ТЭ"] = hotWaterAccruals.HeatEnergy;
                dataToSave["Начисления ГВС"] = hotWaterAccruals.HeatCarrier + hotWaterAccruals.HeatEnergy;
                dataToSave["Показания ГВС"] = previousData["Показания ГВС"] + standards["ГВС ТН"];
            }
            else
            {
                var hotWaterAccruals = CalculationAlgorithms.GetHotWaterAccrualsWithMeter(
                    tariffs["ГВС ТН"], tariffs["ГВС ТЭ"], standards["ГВС ТЭ"],
                    double.Parse(textBoxHotWaterMeter.Text), previousData["Показания ГВС"]);
                labelHotWaterHCAccruals.Text = hotWaterAccruals.HeatCarrier.ToString();
                labelHotWaterHEAccruals.Text = hotWaterAccruals.HeatEnergy.ToString();
                labelHotWaterAccruals.Text = (hotWaterAccruals.HeatCarrier + hotWaterAccruals.HeatEnergy).ToString();
                dataToSave["Начисления ГВС ТН"] = hotWaterAccruals.HeatCarrier;
                dataToSave["Начисления ГВС ТЭ"] = hotWaterAccruals.HeatEnergy;
                dataToSave["Начисления ГВС"] = hotWaterAccruals.HeatCarrier + hotWaterAccruals.HeatEnergy;
                dataToSave["Показания ГВС"] = double.Parse(textBoxHotWaterMeter.Text);
                
            }
            if ((textBoxEnergyMeterDay.Text == null || textBoxEnergyMeterDay.Text.Replace(" ", "").Length == 0) &&
                (textBoxEnergyMeterNight.Text == null || textBoxEnergyMeterNight.Text.Replace(" ", "").Length == 0))
            {
                var energyAccruals = CalculationAlgorithms.GetEnergyAccruals(tariffs["ЭЭ"],
                    standards["ЭЭ"], personCountAverage);
                labelEnergyAccrualsDay.Text = "-";
                labelEnergyAccrualsNight.Text = "-";
                labelEnergyTotalAccruals.Text = energyAccruals.ToString();
                dataToSave["Показания ЭЭ день"] = -999;
                dataToSave["Показания ЭЭ ночь"] = -999;
                dataToSave["Начисления ЭЭ день"] = -999;
                dataToSave["Начисления ЭЭ ночь"] = -999;
                dataToSave["Начисления ЭЭ"] = previousData["Начисления ЭЭ"] + standards["ЭЭ"];
            }
            else
            {
                var energyAccruals = CalculationAlgorithms.GetEnergyAccrualsWithMeter(
                    tariffs["ЭЭ день"], tariffs["ЭЭ ночь"],
                    double.Parse(textBoxEnergyMeterDay.Text), previousData["Показания ЭЭ день"],
                    double.Parse(textBoxEnergyMeterNight.Text), previousData["Показания ЭЭ ночь"]);
                labelEnergyAccrualsDay.Text = energyAccruals.DayAccruals.ToString();
                labelEnergyAccrualsNight.Text = energyAccruals.NightAccruals.ToString();
                labelEnergyTotalAccruals.Text = (energyAccruals.DayAccruals + energyAccruals.NightAccruals).ToString();
                dataToSave["Показания ЭЭ день"] = double.Parse(textBoxEnergyMeterDay.Text);
                dataToSave["Показания ЭЭ ночь"] = double.Parse(textBoxEnergyMeterNight.Text);
                dataToSave["Начисления ЭЭ день"] = energyAccruals.DayAccruals;
                dataToSave["Начисления ЭЭ ночь"] = energyAccruals.NightAccruals;
                dataToSave["Начисления ЭЭ"] = energyAccruals.DayAccruals + energyAccruals.NightAccruals;
            }
            dataToSave["Итого"] = dataToSave["Начисления ХВС"] +
                dataToSave["Начисления ГВС"] + dataToSave["Начисления ЭЭ"] + dataToSave["Начисления ХВС"];
            labelTotalAccruals.Text = dataToSave["Итого"].ToString();
        }

        private void buttonPassAccruals_Click(object sender, EventArgs e)
        {
            CalculateAccruals();
            dataToSave["Расчётный период"] = previousData["Расчётный период"] + 1;
            var commandText = $"INSERT INTO [user_{login}] (";
            foreach (var key in keysForDB)
            {
                commandText += $"[{key}],";
            }
            commandText = commandText.Substring(0, commandText.Length - 1) + ") VALUES (";
            foreach (var key in keysForDB)
            {
                var nfi = new NumberFormatInfo();
                nfi.NumberDecimalSeparator = ".";
                commandText += dataToSave[key].ToString(nfi) + ",";
            }
            commandText = commandText.Substring(0, commandText.Length - 1) + ")";
            using (var connection = new SqliteConnection("Data Source=accrualsDB.db"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = commandText;
                command.ExecuteNonQuery();
            }
            labelColdWaterAccruals.Text = labelHotWaterAccruals.Text = labelHotWaterHCAccruals.Text =
                labelHotWaterHEAccruals.Text = labelEnergyTotalAccruals.Text = labelEnergyAccrualsDay.Text =
                labelEnergyAccrualsNight.Text = labelTotalAccruals.Text = "(ожидает расчёта)";
            labelAccountingPeriod.Text = "Расчётный период " + (dataToSave["Расчётный период"] + 1).ToString();
            textBoxPersonCount.Clear();
            textBoxColdWaterMeter.Clear();
            textBoxHotWaterMeter.Clear();
            textBoxEnergyMeterDay.Clear();
            textBoxEnergyMeterNight.Clear();

            GetDataForPreviousPeriod();
            LoadHistory();
        }

        private void LoadHistory()
        {
            dataGridViewHistory.Rows.Clear();
            using (var connection = new SqliteConnection("Data Source=accrualsDB.db"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand($"SELECT * FROM [user_{login}]", connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        var counter = 0;
                        while (reader.Read())
                        {
                            dataGridViewHistory.Rows.Add();
                            var row = dataGridViewHistory.Rows[counter];
                            for (var i = 0; i < keysForDB.Count(); i++)
                            {
                                row.Cells[i].Value = double.Parse(reader.GetValue(i).ToString());
                            }
                            
                            counter++;
                        }
                    }
                }
            }
            
        }

        private void GetTariffs()
        {
            tariffs = new Dictionary<string, double>();
            standards = new Dictionary<string, double>();
            using (var connection = new SqliteConnection("Data Source=accrualsDB.db"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand("SELECT * FROM [Тарифы]", connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var name = reader.GetValue(1);
                            var tariff = reader.GetValue(2);
                            var standard = reader.GetValue(3);
                            if (name != null)
                            {
                                services.Add(name.ToString());
                                if (tariff != null && standard.ToString() != "")
                                {
                                    tariffs[name.ToString()] = double.Parse(tariff.ToString());
                                }
                                if (standard != null && standard.ToString() != "")
                                {
                                    standards[name.ToString()] = double.Parse(standard.ToString());
                                }
                            }
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
