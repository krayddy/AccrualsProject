
namespace AccrualsProject
{
    partial class FormAccruals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageAccruals = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAccountingPeriod = new System.Windows.Forms.Label();
            this.buttonPassAccruals = new System.Windows.Forms.Button();
            this.labelPersonCount = new System.Windows.Forms.Label();
            this.textBoxPersonCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCalculateAccruals = new System.Windows.Forms.Button();
            this.labelEnergyAccrualsNight = new System.Windows.Forms.Label();
            this.labelEnergyAccrualsDay = new System.Windows.Forms.Label();
            this.labelHotWaterHCAccruals = new System.Windows.Forms.Label();
            this.labelColdWaterAccruals = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxColdWaterMeter = new System.Windows.Forms.TextBox();
            this.textBoxEnergyMeterNight = new System.Windows.Forms.TextBox();
            this.textBoxEnergyMeterDay = new System.Windows.Forms.TextBox();
            this.textBoxHotWaterMeter = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.labelHotWaterHEAccruals = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelEnergyTotalAccruals = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelTotalAccruals = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelHotWaterAccruals = new System.Windows.Forms.Label();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColdWaterMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotWaterMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnergyDayMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnergyNightMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColdWaterAccruals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotWaterAccruals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnergyDayAccruals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnergyNightAccruals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnergyAccruals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAccruals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMenu.SuspendLayout();
            this.tabPageAccruals.SuspendLayout();
            this.tabPageHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPageAccruals);
            this.tabControlMenu.Controls.Add(this.tabPageHistory);
            this.tabControlMenu.Location = new System.Drawing.Point(0, 0);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(802, 450);
            this.tabControlMenu.TabIndex = 0;
            // 
            // tabPageAccruals
            // 
            this.tabPageAccruals.Controls.Add(this.labelHotWaterAccruals);
            this.tabPageAccruals.Controls.Add(this.label13);
            this.tabPageAccruals.Controls.Add(this.labelTotalAccruals);
            this.tabPageAccruals.Controls.Add(this.label12);
            this.tabPageAccruals.Controls.Add(this.labelEnergyTotalAccruals);
            this.tabPageAccruals.Controls.Add(this.label11);
            this.tabPageAccruals.Controls.Add(this.label10);
            this.tabPageAccruals.Controls.Add(this.labelHotWaterHEAccruals);
            this.tabPageAccruals.Controls.Add(this.label9);
            this.tabPageAccruals.Controls.Add(this.labelAccountingPeriod);
            this.tabPageAccruals.Controls.Add(this.buttonPassAccruals);
            this.tabPageAccruals.Controls.Add(this.labelPersonCount);
            this.tabPageAccruals.Controls.Add(this.textBoxPersonCount);
            this.tabPageAccruals.Controls.Add(this.label8);
            this.tabPageAccruals.Controls.Add(this.label7);
            this.tabPageAccruals.Controls.Add(this.label6);
            this.tabPageAccruals.Controls.Add(this.label5);
            this.tabPageAccruals.Controls.Add(this.buttonCalculateAccruals);
            this.tabPageAccruals.Controls.Add(this.labelEnergyAccrualsNight);
            this.tabPageAccruals.Controls.Add(this.labelEnergyAccrualsDay);
            this.tabPageAccruals.Controls.Add(this.labelHotWaterHCAccruals);
            this.tabPageAccruals.Controls.Add(this.labelColdWaterAccruals);
            this.tabPageAccruals.Controls.Add(this.label1);
            this.tabPageAccruals.Controls.Add(this.label4);
            this.tabPageAccruals.Controls.Add(this.label3);
            this.tabPageAccruals.Controls.Add(this.label2);
            this.tabPageAccruals.Controls.Add(this.textBoxColdWaterMeter);
            this.tabPageAccruals.Controls.Add(this.textBoxEnergyMeterNight);
            this.tabPageAccruals.Controls.Add(this.textBoxEnergyMeterDay);
            this.tabPageAccruals.Controls.Add(this.textBoxHotWaterMeter);
            this.tabPageAccruals.Controls.Add(this.labelLogin);
            this.tabPageAccruals.Location = new System.Drawing.Point(4, 25);
            this.tabPageAccruals.Name = "tabPageAccruals";
            this.tabPageAccruals.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccruals.Size = new System.Drawing.Size(794, 421);
            this.tabPageAccruals.TabIndex = 0;
            this.tabPageAccruals.Text = "Ввод показаний";
            this.tabPageAccruals.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(538, 51);
            this.label9.TabIndex = 25;
            this.label9.Text = "(если количество проживающих менялось в течение расчётного периода, \r\nуказать дан" +
    "ные в формате *день изменения* *новое значение* через запятую. \r\nПример: 1, 12 3" +
    ", 28 1)";
            // 
            // labelAccountingPeriod
            // 
            this.labelAccountingPeriod.AutoSize = true;
            this.labelAccountingPeriod.Location = new System.Drawing.Point(54, 42);
            this.labelAccountingPeriod.Name = "labelAccountingPeriod";
            this.labelAccountingPeriod.Size = new System.Drawing.Size(73, 17);
            this.labelAccountingPeriod.TabIndex = 24;
            this.labelAccountingPeriod.Text = "Undefined";
            // 
            // buttonPassAccruals
            // 
            this.buttonPassAccruals.Location = new System.Drawing.Point(610, 374);
            this.buttonPassAccruals.Name = "buttonPassAccruals";
            this.buttonPassAccruals.Size = new System.Drawing.Size(100, 39);
            this.buttonPassAccruals.TabIndex = 23;
            this.buttonPassAccruals.Text = "Передать";
            this.buttonPassAccruals.UseVisualStyleBackColor = true;
            this.buttonPassAccruals.Click += new System.EventHandler(this.buttonPassAccruals_Click);
            // 
            // labelPersonCount
            // 
            this.labelPersonCount.AutoSize = true;
            this.labelPersonCount.Location = new System.Drawing.Point(54, 76);
            this.labelPersonCount.Name = "labelPersonCount";
            this.labelPersonCount.Size = new System.Drawing.Size(181, 17);
            this.labelPersonCount.TabIndex = 22;
            this.labelPersonCount.Text = "Количество проживающих";
            // 
            // textBoxPersonCount
            // 
            this.textBoxPersonCount.Location = new System.Drawing.Point(245, 73);
            this.textBoxPersonCount.Name = "textBoxPersonCount";
            this.textBoxPersonCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxPersonCount.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Начисления ЭЭ (ночь)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Начисления ЭЭ (день)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Начисления ГВС ТН";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Начисления ХВС";
            // 
            // buttonCalculateAccruals
            // 
            this.buttonCalculateAccruals.Location = new System.Drawing.Point(533, 341);
            this.buttonCalculateAccruals.Name = "buttonCalculateAccruals";
            this.buttonCalculateAccruals.Size = new System.Drawing.Size(97, 27);
            this.buttonCalculateAccruals.TabIndex = 16;
            this.buttonCalculateAccruals.Text = "Рассчитать";
            this.buttonCalculateAccruals.UseVisualStyleBackColor = true;
            this.buttonCalculateAccruals.Click += new System.EventHandler(this.buttonCalculateAccruals_Click);
            // 
            // labelEnergyAccrualsNight
            // 
            this.labelEnergyAccrualsNight.AutoSize = true;
            this.labelEnergyAccrualsNight.Location = new System.Drawing.Point(625, 282);
            this.labelEnergyAccrualsNight.Name = "labelEnergyAccrualsNight";
            this.labelEnergyAccrualsNight.Size = new System.Drawing.Size(132, 17);
            this.labelEnergyAccrualsNight.TabIndex = 15;
            this.labelEnergyAccrualsNight.Text = "(ожидает расчёта)";
            // 
            // labelEnergyAccrualsDay
            // 
            this.labelEnergyAccrualsDay.AutoSize = true;
            this.labelEnergyAccrualsDay.Location = new System.Drawing.Point(625, 265);
            this.labelEnergyAccrualsDay.Name = "labelEnergyAccrualsDay";
            this.labelEnergyAccrualsDay.Size = new System.Drawing.Size(132, 17);
            this.labelEnergyAccrualsDay.TabIndex = 14;
            this.labelEnergyAccrualsDay.Text = "(ожидает расчёта)";
            // 
            // labelHotWaterHCAccruals
            // 
            this.labelHotWaterHCAccruals.AutoSize = true;
            this.labelHotWaterHCAccruals.Location = new System.Drawing.Point(624, 194);
            this.labelHotWaterHCAccruals.Name = "labelHotWaterHCAccruals";
            this.labelHotWaterHCAccruals.Size = new System.Drawing.Size(132, 17);
            this.labelHotWaterHCAccruals.TabIndex = 13;
            this.labelHotWaterHCAccruals.Text = "(ожидает расчёта)";
            // 
            // labelColdWaterAccruals
            // 
            this.labelColdWaterAccruals.AutoSize = true;
            this.labelColdWaterAccruals.Location = new System.Drawing.Point(625, 149);
            this.labelColdWaterAccruals.Name = "labelColdWaterAccruals";
            this.labelColdWaterAccruals.Size = new System.Drawing.Size(132, 17);
            this.labelColdWaterAccruals.TabIndex = 12;
            this.labelColdWaterAccruals.Text = "(ожидает расчёта)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "ХВС";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "ЭЭ (ночь)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "ЭЭ (день)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ГВС";
            // 
            // textBoxColdWaterMeter
            // 
            this.textBoxColdWaterMeter.Location = new System.Drawing.Point(245, 167);
            this.textBoxColdWaterMeter.Name = "textBoxColdWaterMeter";
            this.textBoxColdWaterMeter.Size = new System.Drawing.Size(100, 22);
            this.textBoxColdWaterMeter.TabIndex = 6;
            // 
            // textBoxEnergyMeterNight
            // 
            this.textBoxEnergyMeterNight.Location = new System.Drawing.Point(245, 289);
            this.textBoxEnergyMeterNight.Name = "textBoxEnergyMeterNight";
            this.textBoxEnergyMeterNight.Size = new System.Drawing.Size(100, 22);
            this.textBoxEnergyMeterNight.TabIndex = 4;
            // 
            // textBoxEnergyMeterDay
            // 
            this.textBoxEnergyMeterDay.Location = new System.Drawing.Point(245, 248);
            this.textBoxEnergyMeterDay.Name = "textBoxEnergyMeterDay";
            this.textBoxEnergyMeterDay.Size = new System.Drawing.Size(100, 22);
            this.textBoxEnergyMeterDay.TabIndex = 3;
            // 
            // textBoxHotWaterMeter
            // 
            this.textBoxHotWaterMeter.Location = new System.Drawing.Point(245, 206);
            this.textBoxHotWaterMeter.Name = "textBoxHotWaterMeter";
            this.textBoxHotWaterMeter.Size = new System.Drawing.Size(100, 22);
            this.textBoxHotWaterMeter.TabIndex = 2;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(54, 25);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(73, 17);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Undefined";
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Controls.Add(this.dataGridViewHistory);
            this.tabPageHistory.Location = new System.Drawing.Point(4, 25);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(794, 421);
            this.tabPageHistory.TabIndex = 1;
            this.tabPageHistory.Text = "История начислений";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Period,
            this.ColdWaterMeter,
            this.HotWaterMeter,
            this.EnergyDayMeter,
            this.EnergyNightMeter,
            this.ColdWaterAccruals,
            this.Column1,
            this.Column2,
            this.HotWaterAccruals,
            this.EnergyDayAccruals,
            this.EnergyNightAccruals,
            this.EnergyAccruals,
            this.TotalAccruals});
            this.dataGridViewHistory.Location = new System.Drawing.Point(8, 6);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.RowHeadersWidth = 51;
            this.dataGridViewHistory.RowTemplate.Height = 24;
            this.dataGridViewHistory.Size = new System.Drawing.Size(786, 415);
            this.dataGridViewHistory.TabIndex = 0;
            this.dataGridViewHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelHotWaterHEAccruals
            // 
            this.labelHotWaterHEAccruals.AutoSize = true;
            this.labelHotWaterHEAccruals.Location = new System.Drawing.Point(624, 211);
            this.labelHotWaterHEAccruals.Name = "labelHotWaterHEAccruals";
            this.labelHotWaterHEAccruals.Size = new System.Drawing.Size(132, 17);
            this.labelHotWaterHEAccruals.TabIndex = 26;
            this.labelHotWaterHEAccruals.Text = "(ожидает расчёта)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Начисления ГВС ТЭ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(459, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Начисления ЭЭ";
            // 
            // labelEnergyTotalAccruals
            // 
            this.labelEnergyTotalAccruals.AutoSize = true;
            this.labelEnergyTotalAccruals.Location = new System.Drawing.Point(625, 240);
            this.labelEnergyTotalAccruals.Name = "labelEnergyTotalAccruals";
            this.labelEnergyTotalAccruals.Size = new System.Drawing.Size(132, 17);
            this.labelEnergyTotalAccruals.TabIndex = 29;
            this.labelEnergyTotalAccruals.Text = "(ожидает расчёта)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(573, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Итого";
            // 
            // labelTotalAccruals
            // 
            this.labelTotalAccruals.AutoSize = true;
            this.labelTotalAccruals.Location = new System.Drawing.Point(625, 313);
            this.labelTotalAccruals.Name = "labelTotalAccruals";
            this.labelTotalAccruals.Size = new System.Drawing.Size(132, 17);
            this.labelTotalAccruals.TabIndex = 31;
            this.labelTotalAccruals.Text = "(ожидает расчёта)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(459, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Начисления ГВС";
            // 
            // labelHotWaterAccruals
            // 
            this.labelHotWaterAccruals.AutoSize = true;
            this.labelHotWaterAccruals.Location = new System.Drawing.Point(625, 177);
            this.labelHotWaterAccruals.Name = "labelHotWaterAccruals";
            this.labelHotWaterAccruals.Size = new System.Drawing.Size(132, 17);
            this.labelHotWaterAccruals.TabIndex = 33;
            this.labelHotWaterAccruals.Text = "(ожидает расчёта)";
            // 
            // Period
            // 
            this.Period.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Period.HeaderText = "Рассчётный период";
            this.Period.MinimumWidth = 6;
            this.Period.Name = "Period";
            this.Period.ReadOnly = true;
            // 
            // ColdWaterMeter
            // 
            this.ColdWaterMeter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColdWaterMeter.HeaderText = "Показания ХВС";
            this.ColdWaterMeter.MinimumWidth = 6;
            this.ColdWaterMeter.Name = "ColdWaterMeter";
            this.ColdWaterMeter.ReadOnly = true;
            // 
            // HotWaterMeter
            // 
            this.HotWaterMeter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HotWaterMeter.HeaderText = "Показания ГВС";
            this.HotWaterMeter.MinimumWidth = 6;
            this.HotWaterMeter.Name = "HotWaterMeter";
            this.HotWaterMeter.ReadOnly = true;
            // 
            // EnergyDayMeter
            // 
            this.EnergyDayMeter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EnergyDayMeter.HeaderText = "Показания ЭЭ (день)";
            this.EnergyDayMeter.MinimumWidth = 6;
            this.EnergyDayMeter.Name = "EnergyDayMeter";
            this.EnergyDayMeter.ReadOnly = true;
            // 
            // EnergyNightMeter
            // 
            this.EnergyNightMeter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EnergyNightMeter.HeaderText = "Показания ЭЭ (ночь)";
            this.EnergyNightMeter.MinimumWidth = 6;
            this.EnergyNightMeter.Name = "EnergyNightMeter";
            this.EnergyNightMeter.ReadOnly = true;
            // 
            // ColdWaterAccruals
            // 
            this.ColdWaterAccruals.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColdWaterAccruals.HeaderText = "Начисления ХВС";
            this.ColdWaterAccruals.MinimumWidth = 6;
            this.ColdWaterAccruals.Name = "ColdWaterAccruals";
            this.ColdWaterAccruals.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Начисления ГВС ТН";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Начисления ГВС ТЭ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // HotWaterAccruals
            // 
            this.HotWaterAccruals.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HotWaterAccruals.HeaderText = "Начисления ГВС";
            this.HotWaterAccruals.MinimumWidth = 6;
            this.HotWaterAccruals.Name = "HotWaterAccruals";
            this.HotWaterAccruals.ReadOnly = true;
            // 
            // EnergyDayAccruals
            // 
            this.EnergyDayAccruals.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EnergyDayAccruals.HeaderText = "Начисления ЭЭ (день)";
            this.EnergyDayAccruals.MinimumWidth = 6;
            this.EnergyDayAccruals.Name = "EnergyDayAccruals";
            this.EnergyDayAccruals.ReadOnly = true;
            // 
            // EnergyNightAccruals
            // 
            this.EnergyNightAccruals.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EnergyNightAccruals.HeaderText = "Начисления ЭЭ (ночь)";
            this.EnergyNightAccruals.MinimumWidth = 6;
            this.EnergyNightAccruals.Name = "EnergyNightAccruals";
            this.EnergyNightAccruals.ReadOnly = true;
            // 
            // EnergyAccruals
            // 
            this.EnergyAccruals.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EnergyAccruals.HeaderText = "Начисления ЭЭ";
            this.EnergyAccruals.MinimumWidth = 6;
            this.EnergyAccruals.Name = "EnergyAccruals";
            this.EnergyAccruals.ReadOnly = true;
            // 
            // TotalAccruals
            // 
            this.TotalAccruals.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalAccruals.HeaderText = "Итого";
            this.TotalAccruals.MinimumWidth = 6;
            this.TotalAccruals.Name = "TotalAccruals";
            this.TotalAccruals.ReadOnly = true;
            // 
            // FormAccruals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMenu);
            this.Name = "FormAccruals";
            this.Text = "FormAccruals";
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageAccruals.ResumeLayout(false);
            this.tabPageAccruals.PerformLayout();
            this.tabPageHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageAccruals;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.TextBox textBoxEnergyMeterNight;
        private System.Windows.Forms.TextBox textBoxEnergyMeterDay;
        private System.Windows.Forms.TextBox textBoxHotWaterMeter;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxColdWaterMeter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCalculateAccruals;
        private System.Windows.Forms.Label labelEnergyAccrualsNight;
        private System.Windows.Forms.Label labelEnergyAccrualsDay;
        private System.Windows.Forms.Label labelHotWaterHCAccruals;
        private System.Windows.Forms.Label labelColdWaterAccruals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAccountingPeriod;
        private System.Windows.Forms.Button buttonPassAccruals;
        private System.Windows.Forms.Label labelPersonCount;
        private System.Windows.Forms.TextBox textBoxPersonCount;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.Label labelHotWaterHEAccruals;
        private System.Windows.Forms.Label labelEnergyTotalAccruals;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelHotWaterAccruals;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelTotalAccruals;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColdWaterMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotWaterMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnergyDayMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnergyNightMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColdWaterAccruals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotWaterAccruals;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnergyDayAccruals;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnergyNightAccruals;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnergyAccruals;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAccruals;
    }
}