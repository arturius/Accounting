namespace Accounting
{
    partial class WNABHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Import = new Button();
            comb_Import = new ComboBox();
            tb_FileSelect = new TextBox();
            btn_Browse = new Button();
            panel1 = new Panel();
            btn_TagEdit = new Button();
            num_PrimeCredit = new NumericUpDown();
            num_PrimeBalance = new NumericUpDown();
            num_PrimeDebit = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rb_Year = new RadioButton();
            rb_Month = new RadioButton();
            rb_Range = new RadioButton();
            dt_Year = new DateTimePicker();
            dt_Month = new DateTimePicker();
            dt_RangeEnd = new DateTimePicker();
            dt_RangeStart = new DateTimePicker();
            panel3 = new Panel();
            dt_EstimateDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            label23 = new Label();
            num_BaltoDate = new NumericUpDown();
            num_EstIncome = new NumericUpDown();
            label19 = new Label();
            label10 = new Label();
            label20 = new Label();
            num_EstExpenses = new NumericUpDown();
            num_BalPerWeek = new NumericUpDown();
            label11 = new Label();
            num_BalPerMonth = new NumericUpDown();
            num_EstBalance = new NumericUpDown();
            label17 = new Label();
            label12 = new Label();
            label18 = new Label();
            num_InPerMonth = new NumericUpDown();
            num_ExpPerWeek = new NumericUpDown();
            num_InPerWeek = new NumericUpDown();
            num_ExpPerMonth = new NumericUpDown();
            label15 = new Label();
            label16 = new Label();
            btn_EstimateRefresh = new Button();
            label13 = new Label();
            num_MonthExp = new NumericUpDown();
            label14 = new Label();
            num_MonthIn = new NumericUpDown();
            btn_Estimates = new Button();
            label9 = new Label();
            Num_YearExp = new NumericUpDown();
            chk_RealData = new CheckBox();
            label8 = new Label();
            num_YearIn = new NumericUpDown();
            num_WeekExp = new NumericUpDown();
            num_WeekIn = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            dgv_Display = new DataGridView();
            panel4 = new Panel();
            btn_Filter = new Button();
            tb_RegEx = new TextBox();
            label22 = new Label();
            combo_Group = new ComboBox();
            Combo_IDs = new ComboBox();
            label21 = new Label();
            cb_All = new CheckBox();
            comb_Selection = new ComboBox();
            lbl_Weeks = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_PrimeCredit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_PrimeBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_PrimeDebit).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_BaltoDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_EstIncome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_EstExpenses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_BalPerWeek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_BalPerMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_EstBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_InPerMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_ExpPerWeek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_InPerWeek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_ExpPerMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_MonthExp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_MonthIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_YearExp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_YearIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_WeekExp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_WeekIn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Display).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Import
            // 
            btn_Import.Enabled = false;
            btn_Import.Location = new Point(1517, 16);
            btn_Import.Name = "btn_Import";
            btn_Import.Size = new Size(94, 29);
            btn_Import.TabIndex = 0;
            btn_Import.Text = "Import";
            btn_Import.UseVisualStyleBackColor = true;
            btn_Import.Click += btn_Import_Click;
            // 
            // comb_Import
            // 
            comb_Import.FormattingEnabled = true;
            comb_Import.Location = new Point(1635, 14);
            comb_Import.Name = "comb_Import";
            comb_Import.Size = new Size(151, 28);
            comb_Import.TabIndex = 1;
            // 
            // tb_FileSelect
            // 
            tb_FileSelect.Location = new Point(12, 14);
            tb_FileSelect.Name = "tb_FileSelect";
            tb_FileSelect.Size = new Size(1368, 27);
            tb_FileSelect.TabIndex = 2;
            tb_FileSelect.TextChanged += tb_FileSelect_TextChanged;
            // 
            // btn_Browse
            // 
            btn_Browse.Location = new Point(1406, 16);
            btn_Browse.Name = "btn_Browse";
            btn_Browse.Size = new Size(94, 29);
            btn_Browse.TabIndex = 3;
            btn_Browse.Text = "Browse";
            btn_Browse.UseVisualStyleBackColor = true;
            btn_Browse.Click += btn_Browse_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_TagEdit);
            panel1.Controls.Add(num_PrimeCredit);
            panel1.Controls.Add(num_PrimeBalance);
            panel1.Controls.Add(num_PrimeDebit);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rb_Year);
            panel1.Controls.Add(rb_Month);
            panel1.Controls.Add(rb_Range);
            panel1.Controls.Add(comb_Import);
            panel1.Controls.Add(dt_Year);
            panel1.Controls.Add(dt_Month);
            panel1.Controls.Add(btn_Browse);
            panel1.Controls.Add(dt_RangeEnd);
            panel1.Controls.Add(btn_Import);
            panel1.Controls.Add(dt_RangeStart);
            panel1.Controls.Add(tb_FileSelect);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1832, 151);
            panel1.TabIndex = 4;
            // 
            // btn_TagEdit
            // 
            btn_TagEdit.Location = new Point(1509, 64);
            btn_TagEdit.Name = "btn_TagEdit";
            btn_TagEdit.Size = new Size(277, 67);
            btn_TagEdit.TabIndex = 19;
            btn_TagEdit.Text = "Modify and Add Tags and Tag Groups";
            btn_TagEdit.UseVisualStyleBackColor = true;
            btn_TagEdit.Click += btn_TagEdit_Click;
            // 
            // num_PrimeCredit
            // 
            num_PrimeCredit.DecimalPlaces = 2;
            num_PrimeCredit.Location = new Point(135, 109);
            num_PrimeCredit.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            num_PrimeCredit.Minimum = new decimal(new int[] { 1410065408, 2, 0, int.MinValue });
            num_PrimeCredit.Name = "num_PrimeCredit";
            num_PrimeCredit.ReadOnly = true;
            num_PrimeCredit.Size = new Size(253, 27);
            num_PrimeCredit.TabIndex = 18;
            num_PrimeCredit.ThousandsSeparator = true;
            // 
            // num_PrimeBalance
            // 
            num_PrimeBalance.DecimalPlaces = 2;
            num_PrimeBalance.Location = new Point(1079, 109);
            num_PrimeBalance.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            num_PrimeBalance.Minimum = new decimal(new int[] { 1410065408, 2, 0, int.MinValue });
            num_PrimeBalance.Name = "num_PrimeBalance";
            num_PrimeBalance.ReadOnly = true;
            num_PrimeBalance.Size = new Size(253, 27);
            num_PrimeBalance.TabIndex = 17;
            num_PrimeBalance.ThousandsSeparator = true;
            // 
            // num_PrimeDebit
            // 
            num_PrimeDebit.DecimalPlaces = 2;
            num_PrimeDebit.Location = new Point(646, 109);
            num_PrimeDebit.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            num_PrimeDebit.Minimum = new decimal(new int[] { 1410065408, 2, 0, int.MinValue });
            num_PrimeDebit.Name = "num_PrimeDebit";
            num_PrimeDebit.ReadOnly = true;
            num_PrimeDebit.Size = new Size(253, 27);
            num_PrimeDebit.TabIndex = 16;
            num_PrimeDebit.ThousandsSeparator = true;
            num_PrimeDebit.ValueChanged += num_Prime_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(952, 111);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 15;
            label4.Text = "Balance Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(531, 111);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 14;
            label3.Text = "Credit Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 111);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 13;
            label2.Text = "Debit Amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 12;
            label1.Text = "DateRange:";
            // 
            // rb_Year
            // 
            rb_Year.AutoSize = true;
            rb_Year.Checked = true;
            rb_Year.Location = new Point(1274, 64);
            rb_Year.Name = "rb_Year";
            rb_Year.Size = new Size(58, 24);
            rb_Year.TabIndex = 11;
            rb_Year.TabStop = true;
            rb_Year.Text = "Year";
            rb_Year.UseVisualStyleBackColor = true;
            rb_Year.CheckedChanged += rb_Year_CheckedChanged;
            // 
            // rb_Month
            // 
            rb_Month.AutoSize = true;
            rb_Month.Location = new Point(1070, 64);
            rb_Month.Name = "rb_Month";
            rb_Month.Size = new Size(73, 24);
            rb_Month.TabIndex = 10;
            rb_Month.Text = "Month";
            rb_Month.UseVisualStyleBackColor = true;
            rb_Month.CheckedChanged += rb_Year_CheckedChanged;
            // 
            // rb_Range
            // 
            rb_Range.AutoSize = true;
            rb_Range.Location = new Point(668, 66);
            rb_Range.Name = "rb_Range";
            rb_Range.Size = new Size(108, 24);
            rb_Range.TabIndex = 9;
            rb_Range.Text = "Date Range";
            rb_Range.UseVisualStyleBackColor = true;
            rb_Range.CheckedChanged += rb_Year_CheckedChanged;
            // 
            // dt_Year
            // 
            dt_Year.CustomFormat = "yyyy";
            dt_Year.Format = DateTimePickerFormat.Custom;
            dt_Year.Location = new Point(1147, 64);
            dt_Year.Name = "dt_Year";
            dt_Year.Size = new Size(101, 27);
            dt_Year.TabIndex = 8;
            dt_Year.ValueChanged += dt_Year_ValueChanged;
            // 
            // dt_Month
            // 
            dt_Month.CustomFormat = "MMMM yyyy";
            dt_Month.Format = DateTimePickerFormat.Custom;
            dt_Month.Location = new Point(796, 64);
            dt_Month.Name = "dt_Month";
            dt_Month.Size = new Size(250, 27);
            dt_Month.TabIndex = 7;
            dt_Month.ValueChanged += dt_Month_ValueChanged;
            // 
            // dt_RangeEnd
            // 
            dt_RangeEnd.Location = new Point(387, 66);
            dt_RangeEnd.Name = "dt_RangeEnd";
            dt_RangeEnd.Size = new Size(250, 27);
            dt_RangeEnd.TabIndex = 6;
            dt_RangeEnd.ValueChanged += dt_RangeStart_ValueChanged;
            // 
            // dt_RangeStart
            // 
            dt_RangeStart.Location = new Point(101, 66);
            dt_RangeStart.Name = "dt_RangeStart";
            dt_RangeStart.Size = new Size(250, 27);
            dt_RangeStart.TabIndex = 5;
            dt_RangeStart.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dt_RangeStart.ValueChanged += dt_RangeStart_ValueChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbl_Weeks);
            panel3.Controls.Add(dt_EstimateDate);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(btn_EstimateRefresh);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(num_MonthExp);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(num_MonthIn);
            panel3.Controls.Add(btn_Estimates);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(Num_YearExp);
            panel3.Controls.Add(chk_RealData);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(num_YearIn);
            panel3.Controls.Add(num_WeekExp);
            panel3.Controls.Add(num_WeekIn);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1509, 151);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 940);
            panel3.TabIndex = 10;
            // 
            // dt_EstimateDate
            // 
            dt_EstimateDate.Location = new Point(134, 38);
            dt_EstimateDate.Name = "dt_EstimateDate";
            dt_EstimateDate.Size = new Size(180, 27);
            dt_EstimateDate.TabIndex = 50;
            dt_EstimateDate.ValueChanged += num_Est_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(num_BaltoDate);
            groupBox1.Controls.Add(num_EstIncome);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(num_EstExpenses);
            groupBox1.Controls.Add(num_BalPerWeek);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(num_BalPerMonth);
            groupBox1.Controls.Add(num_EstBalance);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(num_InPerMonth);
            groupBox1.Controls.Add(num_ExpPerWeek);
            groupBox1.Controls.Add(num_InPerWeek);
            groupBox1.Controls.Add(num_ExpPerMonth);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label16);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 456);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 484);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yearly Estimates";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(15, 314);
            label23.Name = "label23";
            label23.Size = new Size(120, 20);
            label23.TabIndex = 49;
            label23.Text = "Balance To Date:";
            // 
            // num_BaltoDate
            // 
            num_BaltoDate.DecimalPlaces = 2;
            num_BaltoDate.Location = new Point(141, 312);
            num_BaltoDate.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            num_BaltoDate.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            num_BaltoDate.Name = "num_BaltoDate";
            num_BaltoDate.ReadOnly = true;
            num_BaltoDate.Size = new Size(173, 27);
            num_BaltoDate.TabIndex = 48;
            num_BaltoDate.ThousandsSeparator = true;
            // 
            // num_EstIncome
            // 
            num_EstIncome.DecimalPlaces = 2;
            num_EstIncome.Location = new Point(61, 66);
            num_EstIncome.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            num_EstIncome.Name = "num_EstIncome";
            num_EstIncome.ReadOnly = true;
            num_EstIncome.Size = new Size(253, 27);
            num_EstIncome.TabIndex = 25;
            num_EstIncome.ThousandsSeparator = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(76, 447);
            label19.Name = "label19";
            label19.Size = new Size(72, 20);
            label19.TabIndex = 47;
            label19.Text = "Per Week:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 31);
            label10.Name = "label10";
            label10.Size = new Size(179, 20);
            label10.TabIndex = 26;
            label10.Text = "Remaining Yearly Income:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(76, 414);
            label20.Name = "label20";
            label20.Size = new Size(79, 20);
            label20.TabIndex = 46;
            label20.Text = "Per Month:";
            // 
            // num_EstExpenses
            // 
            num_EstExpenses.DecimalPlaces = 2;
            num_EstExpenses.Location = new Point(61, 200);
            num_EstExpenses.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            num_EstExpenses.Minimum = new decimal(new int[] { 1410065408, 2, 0, int.MinValue });
            num_EstExpenses.Name = "num_EstExpenses";
            num_EstExpenses.ReadOnly = true;
            num_EstExpenses.Size = new Size(253, 27);
            num_EstExpenses.TabIndex = 28;
            num_EstExpenses.ThousandsSeparator = true;
            // 
            // num_BalPerWeek
            // 
            num_BalPerWeek.DecimalPlaces = 2;
            num_BalPerWeek.Location = new Point(161, 445);
            num_BalPerWeek.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            num_BalPerWeek.Minimum = new decimal(new int[] { 1410065408, 2, 0, int.MinValue });
            num_BalPerWeek.Name = "num_BalPerWeek";
            num_BalPerWeek.ReadOnly = true;
            num_BalPerWeek.Size = new Size(150, 27);
            num_BalPerWeek.TabIndex = 45;
            num_BalPerWeek.ThousandsSeparator = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 165);
            label11.Name = "label11";
            label11.Size = new Size(190, 20);
            label11.TabIndex = 29;
            label11.Text = "Remaining Yearly Expenses:";
            // 
            // num_BalPerMonth
            // 
            num_BalPerMonth.DecimalPlaces = 2;
            num_BalPerMonth.Location = new Point(161, 412);
            num_BalPerMonth.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            num_BalPerMonth.Minimum = new decimal(new int[] { 1410065408, 2, 0, int.MinValue });
            num_BalPerMonth.Name = "num_BalPerMonth";
            num_BalPerMonth.ReadOnly = true;
            num_BalPerMonth.Size = new Size(150, 27);
            num_BalPerMonth.TabIndex = 44;
            num_BalPerMonth.ThousandsSeparator = true;
            // 
            // num_EstBalance
            // 
            num_EstBalance.DecimalPlaces = 2;
            num_EstBalance.Location = new Point(60, 379);
            num_EstBalance.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            num_EstBalance.Name = "num_EstBalance";
            num_EstBalance.ReadOnly = true;
            num_EstBalance.Size = new Size(253, 27);
            num_EstBalance.TabIndex = 30;
            num_EstBalance.ThousandsSeparator = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(79, 268);
            label17.Name = "label17";
            label17.Size = new Size(72, 20);
            label17.TabIndex = 43;
            label17.Text = "Per Week:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 344);
            label12.Name = "label12";
            label12.Size = new Size(168, 20);
            label12.TabIndex = 31;
            label12.Text = "Estimate Yearly Balance:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(79, 235);
            label18.Name = "label18";
            label18.Size = new Size(79, 20);
            label18.TabIndex = 42;
            label18.Text = "Per Month:";
            // 
            // num_InPerMonth
            // 
            num_InPerMonth.DecimalPlaces = 2;
            num_InPerMonth.Location = new Point(164, 99);
            num_InPerMonth.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            num_InPerMonth.Minimum = new decimal(new int[] { 1410065408, 2, 0, int.MinValue });
            num_InPerMonth.Name = "num_InPerMonth";
            num_InPerMonth.ReadOnly = true;
            num_InPerMonth.Size = new Size(150, 27);
            num_InPerMonth.TabIndex = 36;
            num_InPerMonth.ThousandsSeparator = true;
            // 
            // num_ExpPerWeek
            // 
            num_ExpPerWeek.DecimalPlaces = 2;
            num_ExpPerWeek.Location = new Point(164, 266);
            num_ExpPerWeek.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            num_ExpPerWeek.Minimum = new decimal(new int[] { 1410065408, 2, 0, int.MinValue });
            num_ExpPerWeek.Name = "num_ExpPerWeek";
            num_ExpPerWeek.ReadOnly = true;
            num_ExpPerWeek.Size = new Size(150, 27);
            num_ExpPerWeek.TabIndex = 41;
            num_ExpPerWeek.ThousandsSeparator = true;
            // 
            // num_InPerWeek
            // 
            num_InPerWeek.DecimalPlaces = 2;
            num_InPerWeek.Location = new Point(164, 132);
            num_InPerWeek.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            num_InPerWeek.Minimum = new decimal(new int[] { 1410065408, 2, 0, int.MinValue });
            num_InPerWeek.Name = "num_InPerWeek";
            num_InPerWeek.ReadOnly = true;
            num_InPerWeek.Size = new Size(150, 27);
            num_InPerWeek.TabIndex = 37;
            num_InPerWeek.ThousandsSeparator = true;
            // 
            // num_ExpPerMonth
            // 
            num_ExpPerMonth.DecimalPlaces = 2;
            num_ExpPerMonth.Location = new Point(164, 233);
            num_ExpPerMonth.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            num_ExpPerMonth.Minimum = new decimal(new int[] { 1410065408, 2, 0, int.MinValue });
            num_ExpPerMonth.Name = "num_ExpPerMonth";
            num_ExpPerMonth.ReadOnly = true;
            num_ExpPerMonth.Size = new Size(150, 27);
            num_ExpPerMonth.TabIndex = 40;
            num_ExpPerMonth.ThousandsSeparator = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(79, 101);
            label15.Name = "label15";
            label15.Size = new Size(79, 20);
            label15.TabIndex = 38;
            label15.Text = "Per Month:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(79, 134);
            label16.Name = "label16";
            label16.Size = new Size(72, 20);
            label16.TabIndex = 39;
            label16.Text = "Per Week:";
            // 
            // btn_EstimateRefresh
            // 
            btn_EstimateRefresh.Location = new Point(20, 421);
            btn_EstimateRefresh.Name = "btn_EstimateRefresh";
            btn_EstimateRefresh.Size = new Size(291, 29);
            btn_EstimateRefresh.TabIndex = 48;
            btn_EstimateRefresh.Text = "Refresh Estimate Values";
            btn_EstimateRefresh.UseVisualStyleBackColor = true;
            btn_EstimateRefresh.Click += num_Est_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 227);
            label13.Name = "label13";
            label13.Size = new Size(142, 20);
            label13.TabIndex = 35;
            label13.Text = "Est Monthly Extra In:";
            // 
            // num_MonthExp
            // 
            num_MonthExp.DecimalPlaces = 2;
            num_MonthExp.Location = new Point(161, 274);
            num_MonthExp.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            num_MonthExp.Name = "num_MonthExp";
            num_MonthExp.ReadOnly = true;
            num_MonthExp.Size = new Size(150, 27);
            num_MonthExp.TabIndex = 34;
            num_MonthExp.ThousandsSeparator = true;
            num_MonthExp.ValueChanged += num_Est_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 276);
            label14.Name = "label14";
            label14.Size = new Size(153, 20);
            label14.TabIndex = 33;
            label14.Text = "Est Monthly Expenses:";
            // 
            // num_MonthIn
            // 
            num_MonthIn.DecimalPlaces = 2;
            num_MonthIn.Location = new Point(161, 225);
            num_MonthIn.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            num_MonthIn.Name = "num_MonthIn";
            num_MonthIn.ReadOnly = true;
            num_MonthIn.Size = new Size(150, 27);
            num_MonthIn.TabIndex = 32;
            num_MonthIn.ThousandsSeparator = true;
            num_MonthIn.ValueChanged += num_Est_ValueChanged;
            // 
            // btn_Estimates
            // 
            btn_Estimates.Location = new Point(20, 82);
            btn_Estimates.Name = "btn_Estimates";
            btn_Estimates.Size = new Size(291, 29);
            btn_Estimates.TabIndex = 27;
            btn_Estimates.Text = "Set Estimate Values";
            btn_Estimates.UseVisualStyleBackColor = true;
            btn_Estimates.Click += btn_Estimates_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 323);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 24;
            label9.Text = "Est Yearly Extra In:";
            // 
            // Num_YearExp
            // 
            Num_YearExp.DecimalPlaces = 2;
            Num_YearExp.Location = new Point(161, 370);
            Num_YearExp.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            Num_YearExp.Name = "Num_YearExp";
            Num_YearExp.ReadOnly = true;
            Num_YearExp.Size = new Size(150, 27);
            Num_YearExp.TabIndex = 23;
            Num_YearExp.ThousandsSeparator = true;
            Num_YearExp.ValueChanged += num_Est_ValueChanged;
            // 
            // chk_RealData
            // 
            chk_RealData.AutoSize = true;
            chk_RealData.Location = new Point(197, 6);
            chk_RealData.Name = "chk_RealData";
            chk_RealData.Size = new Size(124, 24);
            chk_RealData.TabIndex = 22;
            chk_RealData.Text = "Auto Estimate";
            chk_RealData.UseVisualStyleBackColor = true;
            chk_RealData.CheckedChanged += chk_RealData_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 372);
            label8.Name = "label8";
            label8.Size = new Size(138, 20);
            label8.TabIndex = 21;
            label8.Text = "Est Yearly Expenses:";
            // 
            // num_YearIn
            // 
            num_YearIn.DecimalPlaces = 2;
            num_YearIn.Location = new Point(161, 321);
            num_YearIn.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            num_YearIn.Name = "num_YearIn";
            num_YearIn.ReadOnly = true;
            num_YearIn.Size = new Size(150, 27);
            num_YearIn.TabIndex = 20;
            num_YearIn.ThousandsSeparator = true;
            num_YearIn.ValueChanged += num_Est_ValueChanged;
            // 
            // num_WeekExp
            // 
            num_WeekExp.DecimalPlaces = 2;
            num_WeekExp.Location = new Point(161, 175);
            num_WeekExp.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            num_WeekExp.Name = "num_WeekExp";
            num_WeekExp.ReadOnly = true;
            num_WeekExp.Size = new Size(150, 27);
            num_WeekExp.TabIndex = 19;
            num_WeekExp.ThousandsSeparator = true;
            num_WeekExp.ValueChanged += num_Est_ValueChanged;
            // 
            // num_WeekIn
            // 
            num_WeekIn.DecimalPlaces = 2;
            num_WeekIn.Location = new Point(161, 129);
            num_WeekIn.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            num_WeekIn.Name = "num_WeekIn";
            num_WeekIn.ReadOnly = true;
            num_WeekIn.Size = new Size(150, 27);
            num_WeekIn.TabIndex = 18;
            num_WeekIn.ThousandsSeparator = true;
            num_WeekIn.ValueChanged += num_Est_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 41);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 17;
            label7.Text = "Effective Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 177);
            label6.Name = "label6";
            label6.Size = new Size(146, 20);
            label6.TabIndex = 15;
            label6.Text = "Est Weekly Expenses:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 131);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 14;
            label5.Text = "Est Weekly Income:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgv_Display);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 151);
            panel2.Name = "panel2";
            panel2.Size = new Size(1509, 940);
            panel2.TabIndex = 11;
            // 
            // dgv_Display
            // 
            dgv_Display.AllowUserToAddRows = false;
            dgv_Display.AllowUserToDeleteRows = false;
            dgv_Display.AllowUserToOrderColumns = true;
            dgv_Display.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_Display.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Display.Dock = DockStyle.Fill;
            dgv_Display.Location = new Point(0, 61);
            dgv_Display.Name = "dgv_Display";
            dgv_Display.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgv_Display.Size = new Size(1509, 879);
            dgv_Display.TabIndex = 4;
            dgv_Display.CellDoubleClick += dgv_Display_CellDoubleClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_Filter);
            panel4.Controls.Add(tb_RegEx);
            panel4.Controls.Add(label22);
            panel4.Controls.Add(combo_Group);
            panel4.Controls.Add(Combo_IDs);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(cb_All);
            panel4.Controls.Add(comb_Selection);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1509, 61);
            panel4.TabIndex = 3;
            // 
            // btn_Filter
            // 
            btn_Filter.Location = new Point(961, 16);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new Size(144, 29);
            btn_Filter.TabIndex = 10;
            btn_Filter.Text = "RegEx Filter";
            btn_Filter.UseVisualStyleBackColor = true;
            btn_Filter.Click += btn_Filter_Click;
            // 
            // tb_RegEx
            // 
            tb_RegEx.Location = new Point(604, 17);
            tb_RegEx.Name = "tb_RegEx";
            tb_RegEx.Size = new Size(351, 27);
            tb_RegEx.TabIndex = 9;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(15, 17);
            label22.Name = "label22";
            label22.Size = new Size(80, 20);
            label22.TabIndex = 8;
            label22.Text = "Tag Group:";
            // 
            // combo_Group
            // 
            combo_Group.FormattingEnabled = true;
            combo_Group.Location = new Point(101, 15);
            combo_Group.Name = "combo_Group";
            combo_Group.Size = new Size(194, 28);
            combo_Group.TabIndex = 7;
            combo_Group.SelectedIndexChanged += combo_Group_SelectedIndexChanged;
            // 
            // Combo_IDs
            // 
            Combo_IDs.FormattingEnabled = true;
            Combo_IDs.Location = new Point(389, 17);
            Combo_IDs.Name = "Combo_IDs";
            Combo_IDs.Size = new Size(191, 28);
            Combo_IDs.TabIndex = 6;
            Combo_IDs.SelectedIndexChanged += Combo_IDs_SelectedIndexChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(301, 19);
            label21.Name = "label21";
            label21.Size = new Size(80, 20);
            label21.TabIndex = 5;
            label21.Text = "Active Tag:";
            // 
            // cb_All
            // 
            cb_All.AutoSize = true;
            cb_All.Location = new Point(1225, 19);
            cb_All.Name = "cb_All";
            cb_All.Size = new Size(93, 24);
            cb_All.TabIndex = 3;
            cb_All.Text = "Select All";
            cb_All.UseVisualStyleBackColor = true;
            cb_All.CheckedChanged += cb_All_CheckedChanged;
            // 
            // comb_Selection
            // 
            comb_Selection.FormattingEnabled = true;
            comb_Selection.Location = new Point(1332, 17);
            comb_Selection.Name = "comb_Selection";
            comb_Selection.Size = new Size(151, 28);
            comb_Selection.TabIndex = 2;
            comb_Selection.SelectedIndexChanged += comb_Selection_SelectedIndexChanged;
            // 
            // lbl_Weeks
            // 
            lbl_Weeks.AutoSize = true;
            lbl_Weeks.Location = new Point(20, 6);
            lbl_Weeks.Name = "lbl_Weeks";
            lbl_Weeks.Size = new Size(83, 20);
            lbl_Weeks.TabIndex = 51;
            lbl_Weeks.Text = "Weeks Left:";
            // 
            // WNABHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1832, 1091);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "WNABHome";
            Text = "WNAB";
            Load += WNABHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_PrimeCredit).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_PrimeBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_PrimeDebit).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_BaltoDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_EstIncome).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_EstExpenses).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_BalPerWeek).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_BalPerMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_EstBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_InPerMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_ExpPerWeek).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_InPerWeek).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_ExpPerMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_MonthExp).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_MonthIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_YearExp).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_YearIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_WeekExp).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_WeekIn).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Display).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Import;
        private ComboBox comb_Import;
        private TextBox tb_FileSelect;
        private Button btn_Browse;
        private Panel panel1;
        private DateTimePicker dt_RangeStart;
        private DateTimePicker dt_RangeEnd;
        private DateTimePicker dt_Month;
        private DateTimePicker dt_Year;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rb_Year;
        private RadioButton rb_Month;
        private RadioButton rb_Range;
        private Panel panel3;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private NumericUpDown num_PrimeBalance;
        private NumericUpDown num_PrimeDebit;
        private NumericUpDown num_WeekIn;
        private NumericUpDown num_PrimeCredit;
        private CheckBox chk_RealData;
        private Label label8;
        private NumericUpDown num_YearIn;
        private NumericUpDown num_WeekExp;
        private Button btn_Estimates;
        private Label label10;
        private NumericUpDown num_EstIncome;
        private Label label9;
        private NumericUpDown Num_YearExp;
        private DataGridView dgv_Display;
        private Panel panel4;
        private ComboBox comb_Selection;
        private Label label12;
        private NumericUpDown num_EstBalance;
        private Label label11;
        private NumericUpDown num_EstExpenses;
        private Label label13;
        private NumericUpDown num_MonthExp;
        private Label label14;
        private NumericUpDown num_MonthIn;
        private CheckBox cb_All;
        private Label label16;
        private Label label15;
        private NumericUpDown num_InPerWeek;
        private NumericUpDown num_InPerMonth;
        private Label label19;
        private Label label20;
        private NumericUpDown num_BalPerWeek;
        private NumericUpDown num_BalPerMonth;
        private Label label17;
        private Label label18;
        private NumericUpDown num_ExpPerWeek;
        private NumericUpDown num_ExpPerMonth;
        private Label label21;
        private NumericUpDown num_IDSelect;
        private ComboBox Combo_IDs;
        private ComboBox combo_Group;
        private Label label22;
        private Button btn_Filter;
        private TextBox tb_RegEx;
        private Button btn_TagEdit;
        private Button btn_EstimateRefresh;
        private GroupBox groupBox1;
        private DateTimePicker dt_EstimateDate;
        private Label label23;
        private NumericUpDown num_BaltoDate;
        private Label lbl_Weeks;
    }
}
