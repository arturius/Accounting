namespace Accounting.ManagingFroms
{
    partial class EstimateList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Title = new Label();
            panel2 = new Panel();
            btn_WeekExpDelete = new Button();
            btn_WeekExpAdd = new Button();
            panel8 = new Panel();
            num_ExpTotal = new NumericUpDown();
            label1 = new Label();
            flPnl_Data = new FlowLayoutPanel();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_ExpTotal).BeginInit();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Dock = DockStyle.Top;
            lbl_Title.Location = new Point(0, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(69, 20);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "Expenses";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_WeekExpDelete);
            panel2.Controls.Add(btn_WeekExpAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 771);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 64);
            panel2.TabIndex = 4;
            // 
            // btn_WeekExpDelete
            // 
            btn_WeekExpDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_WeekExpDelete.Location = new Point(388, 19);
            btn_WeekExpDelete.Name = "btn_WeekExpDelete";
            btn_WeekExpDelete.Size = new Size(80, 29);
            btn_WeekExpDelete.TabIndex = 6;
            btn_WeekExpDelete.Text = "Delete";
            btn_WeekExpDelete.UseVisualStyleBackColor = true;
            // 
            // btn_WeekExpAdd
            // 
            btn_WeekExpAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_WeekExpAdd.Location = new Point(302, 19);
            btn_WeekExpAdd.Name = "btn_WeekExpAdd";
            btn_WeekExpAdd.Size = new Size(80, 29);
            btn_WeekExpAdd.TabIndex = 5;
            btn_WeekExpAdd.Text = "Add";
            btn_WeekExpAdd.UseVisualStyleBackColor = true;
            btn_WeekExpAdd.Click += btn_WeekExpAdd_Click;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ControlLight;
            panel8.Controls.Add(num_ExpTotal);
            panel8.Controls.Add(label1);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 20);
            panel8.Name = "panel8";
            panel8.Size = new Size(480, 28);
            panel8.TabIndex = 8;
            // 
            // num_ExpTotal
            // 
            num_ExpTotal.DecimalPlaces = 2;
            num_ExpTotal.Dock = DockStyle.Right;
            num_ExpTotal.Location = new Point(205, 0);
            num_ExpTotal.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            num_ExpTotal.Minimum = new decimal(new int[] { 1410065408, 2, 0, int.MinValue });
            num_ExpTotal.MinimumSize = new Size(190, 0);
            num_ExpTotal.Name = "num_ExpTotal";
            num_ExpTotal.ReadOnly = true;
            num_ExpTotal.Size = new Size(275, 27);
            num_ExpTotal.TabIndex = 29;
            num_ExpTotal.ThousandsSeparator = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 3;
            label1.Text = "Total:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // flPnl_Data
            // 
            flPnl_Data.Dock = DockStyle.Fill;
            flPnl_Data.Location = new Point(0, 48);
            flPnl_Data.Name = "flPnl_Data";
            flPnl_Data.Size = new Size(480, 723);
            flPnl_Data.TabIndex = 10;
            // 
            // EstimateList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flPnl_Data);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Controls.Add(lbl_Title);
            MinimumSize = new Size(480, 200);
            Name = "EstimateList";
            Size = new Size(480, 835);
            Load += EstimateList_Load;
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_ExpTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title;
        private Panel panel2;
        private Button btn_WeekExpDelete;
        private Button btn_WeekExpAdd;
        private Panel panel8;
        private NumericUpDown num_ExpTotal;
        private Label label1;
        private FlowLayoutPanel flPnl_Data;
    }
}
