namespace Accounting.ManagingFroms
{
    partial class Estimates
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
            estLst_OnceEstimates = new EstimateList();
            estLst_WeekEstimates = new EstimateList();
            estLst_MonthEstimates = new EstimateList();
            estLst_YearEstimates = new EstimateList();
            combo_TypeSelection = new ComboBox();
            label1 = new Label();
            num_Total = new NumericUpDown();
            num_Balance = new NumericUpDown();
            label2 = new Label();
            cb_Esentials = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)num_Total).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Balance).BeginInit();
            SuspendLayout();
            // 
            // estLst_OnceEstimates
            // 
            estLst_OnceEstimates.BackColor = Color.Coral;
            estLst_OnceEstimates.IsExpense = true;
            estLst_OnceEstimates.Location = new Point(12, 65);
            estLst_OnceEstimates.MinimumSize = new Size(480, 200);
            estLst_OnceEstimates.Name = "estLst_OnceEstimates";
            estLst_OnceEstimates.Range = EstimateRange.Once;
            estLst_OnceEstimates.Size = new Size(480, 836);
            estLst_OnceEstimates.TabIndex = 0;
            estLst_OnceEstimates.TotalAmountChanged += EstimateAmount_Changed;
            // 
            // estLst_WeekEstimates
            // 
            estLst_WeekEstimates.BackColor = Color.Coral;
            estLst_WeekEstimates.IsExpense = true;
            estLst_WeekEstimates.Location = new Point(498, 65);
            estLst_WeekEstimates.MinimumSize = new Size(480, 200);
            estLst_WeekEstimates.Name = "estLst_WeekEstimates";
            estLst_WeekEstimates.Range = EstimateRange.Weekly;
            estLst_WeekEstimates.Size = new Size(480, 836);
            estLst_WeekEstimates.TabIndex = 1;
            estLst_WeekEstimates.TotalAmountChanged += EstimateAmount_Changed;
            // 
            // estLst_MonthEstimates
            // 
            estLst_MonthEstimates.BackColor = Color.Coral;
            estLst_MonthEstimates.IsExpense = true;
            estLst_MonthEstimates.Location = new Point(984, 65);
            estLst_MonthEstimates.MinimumSize = new Size(480, 200);
            estLst_MonthEstimates.Name = "estLst_MonthEstimates";
            estLst_MonthEstimates.Range = EstimateRange.Monthly;
            estLst_MonthEstimates.Size = new Size(480, 836);
            estLst_MonthEstimates.TabIndex = 2;
            estLst_MonthEstimates.TotalAmountChanged += EstimateAmount_Changed;
            // 
            // estLst_YearEstimates
            // 
            estLst_YearEstimates.BackColor = Color.Coral;
            estLst_YearEstimates.IsExpense = true;
            estLst_YearEstimates.Location = new Point(1469, 65);
            estLst_YearEstimates.MinimumSize = new Size(480, 200);
            estLst_YearEstimates.Name = "estLst_YearEstimates";
            estLst_YearEstimates.Range = EstimateRange.Yearly;
            estLst_YearEstimates.Size = new Size(480, 836);
            estLst_YearEstimates.TabIndex = 3;
            estLst_YearEstimates.TotalAmountChanged += EstimateAmount_Changed;
            // 
            // combo_TypeSelection
            // 
            combo_TypeSelection.FormattingEnabled = true;
            combo_TypeSelection.Items.AddRange(new object[] { "Expenses", "Income" });
            combo_TypeSelection.Location = new Point(1754, 12);
            combo_TypeSelection.Name = "combo_TypeSelection";
            combo_TypeSelection.Size = new Size(186, 28);
            combo_TypeSelection.TabIndex = 4;
            combo_TypeSelection.SelectedIndexChanged += combo_TypeSelection_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 15);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 5;
            label1.Text = "Yearly Total Estimate:";
            // 
            // num_Total
            // 
            num_Total.DecimalPlaces = 2;
            num_Total.Location = new Point(199, 12);
            num_Total.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            num_Total.Minimum = new decimal(new int[] { 1410065408, 2, 0, int.MinValue });
            num_Total.Name = "num_Total";
            num_Total.ReadOnly = true;
            num_Total.Size = new Size(560, 27);
            num_Total.TabIndex = 6;
            num_Total.ThousandsSeparator = true;
            // 
            // num_Balance
            // 
            num_Balance.DecimalPlaces = 2;
            num_Balance.Location = new Point(1381, 12);
            num_Balance.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            num_Balance.Minimum = new decimal(new int[] { 1410065408, 2, 0, int.MinValue });
            num_Balance.Name = "num_Balance";
            num_Balance.ReadOnly = true;
            num_Balance.Size = new Size(344, 27);
            num_Balance.TabIndex = 8;
            num_Balance.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1170, 15);
            label2.Name = "label2";
            label2.Size = new Size(205, 20);
            label2.TabIndex = 7;
            label2.Text = "Yearly Total Balance Estimate:";
            // 
            // cb_Esentials
            // 
            cb_Esentials.AutoSize = true;
            cb_Esentials.Location = new Point(765, 14);
            cb_Esentials.Name = "cb_Esentials";
            cb_Esentials.Size = new Size(208, 24);
            cb_Esentials.TabIndex = 9;
            cb_Esentials.Text = "Show Essential Values Only";
            cb_Esentials.UseVisualStyleBackColor = true;
            cb_Esentials.CheckedChanged += cb_Esentials_CheckedChanged;
            // 
            // Estimates
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1952, 931);
            Controls.Add(cb_Esentials);
            Controls.Add(num_Balance);
            Controls.Add(label2);
            Controls.Add(num_Total);
            Controls.Add(label1);
            Controls.Add(combo_TypeSelection);
            Controls.Add(estLst_YearEstimates);
            Controls.Add(estLst_MonthEstimates);
            Controls.Add(estLst_WeekEstimates);
            Controls.Add(estLst_OnceEstimates);
            Name = "Estimates";
            Text = "Estimates";
            ((System.ComponentModel.ISupportInitialize)num_Total).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Balance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private EstimateList estLst_OnceEstimates;
        private EstimateList estLst_WeekEstimates;
        private EstimateList estLst_MonthEstimates;
        private EstimateList estLst_YearEstimates;
        private ComboBox combo_TypeSelection;
        private Label label1;
        private NumericUpDown num_Total;
        private NumericUpDown num_Balance;
        private Label label2;
        private CheckBox cb_Esentials;
    }
}