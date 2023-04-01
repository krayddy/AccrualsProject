using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccrualsProject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var connection = new SqliteConnection("Data Source=accrualsDB.db"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = "CREATE TABLE IF NOT EXISTS [Тарифы](id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
                    "[Услуга] TEXT NOT NULL UNIQUE, [Тариф] REAL NOT NULL, [Норматив] REAL)";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT OR IGNORE INTO [Тарифы] ([Услуга], [Тариф], [Норматив])" +
                    "VALUES ('ХВС', 35.78, 4.85), ('ЭЭ', 4.28, 164), ('ЭЭ день', 4.9, -999), " +
                    "('ЭЭ ночь', 2.31, -999), ('ГВС ТН', 35.78, 4.01), ('ГВС ТЭ', 998.69, 0.05349)";
                command.ExecuteNonQuery();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
