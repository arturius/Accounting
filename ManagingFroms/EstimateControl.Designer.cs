namespace Accounting.ManagingFroms
{
    partial class EstimateControl
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
            combo_Tag = new ComboBox();
            cb_Esential = new CheckBox();
            num_Amount = new NumericUpDown();
            tb_Description = new TextBox();
            ((System.ComponentModel.ISupportInitialize)num_Amount).BeginInit();
            SuspendLayout();
            // 
            // combo_Tag
            // 
            combo_Tag.Dock = DockStyle.Left;
            combo_Tag.FormattingEnabled = true;
            combo_Tag.Location = new Point(0, 0);
            combo_Tag.Name = "combo_Tag";
            combo_Tag.Size = new Size(165, 28);
            combo_Tag.TabIndex = 0;
            combo_Tag.SelectedIndexChanged += combo_Tag_SelectedIndexChanged;
            // 
            // cb_Esential
            // 
            cb_Esential.AutoSize = true;
            cb_Esential.Dock = DockStyle.Right;
            cb_Esential.Location = new Point(449, 0);
            cb_Esential.Name = "cb_Esential";
            cb_Esential.Padding = new Padding(3, 0, 0, 0);
            cb_Esential.Size = new Size(21, 28);
            cb_Esential.TabIndex = 1;
            cb_Esential.UseVisualStyleBackColor = true;
            cb_Esential.CheckedChanged += cb_Esential_CheckedChanged;
            // 
            // num_Amount
            // 
            num_Amount.DecimalPlaces = 2;
            num_Amount.Dock = DockStyle.Right;
            num_Amount.Location = new Point(333, 0);
            num_Amount.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            num_Amount.Name = "num_Amount";
            num_Amount.Size = new Size(116, 27);
            num_Amount.TabIndex = 5;
            num_Amount.ThousandsSeparator = true;
            num_Amount.ValueChanged += num_Amount_ValueChanged;
            // 
            // tb_Description
            // 
            tb_Description.Dock = DockStyle.Fill;
            tb_Description.Location = new Point(165, 0);
            tb_Description.Name = "tb_Description";
            tb_Description.Size = new Size(168, 27);
            tb_Description.TabIndex = 6;
            tb_Description.KeyDown += tb_Description_KeyDown;
            tb_Description.Leave += tb_Description_Leave;
            // 
            // EstimateControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tb_Description);
            Controls.Add(num_Amount);
            Controls.Add(cb_Esential);
            Controls.Add(combo_Tag);
            Name = "EstimateControl";
            Size = new Size(470, 28);
            Load += EstimateControl_Load;
            MouseDown += EstimateControl_MouseDown;
            ((System.ComponentModel.ISupportInitialize)num_Amount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combo_Tag;
        private CheckBox cb_Esential;
        private NumericUpDown num_Amount;
        private TextBox tb_Description;
    }
}
