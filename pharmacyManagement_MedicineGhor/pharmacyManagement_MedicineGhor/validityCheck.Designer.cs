namespace pharmacyManagement_MedicineGhor
{
    partial class validityCheck
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label15 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.medicineValidityGridview = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.validityCheckCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineValidityGridview)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(52, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(306, 32);
            this.label15.TabIndex = 6;
            this.label15.Text = "Medicine Validity Check";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Azure;
            this.panel10.Controls.Add(this.panel4);
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Controls.Add(this.label15);
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1042, 709);
            this.panel10.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.panel4.Controls.Add(this.medicineValidityGridview);
            this.panel4.Location = new System.Drawing.Point(34, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(969, 389);
            this.panel4.TabIndex = 9;
            // 
            // medicineValidityGridview
            // 
            this.medicineValidityGridview.BackgroundColor = System.Drawing.Color.White;
            this.medicineValidityGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medicineValidityGridview.DefaultCellStyle = dataGridViewCellStyle1;
            this.medicineValidityGridview.Location = new System.Drawing.Point(20, 19);
            this.medicineValidityGridview.Name = "medicineValidityGridview";
            this.medicineValidityGridview.RowHeadersVisible = false;
            this.medicineValidityGridview.RowHeadersWidth = 51;
            this.medicineValidityGridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.medicineValidityGridview.RowTemplate.Height = 24;
            this.medicineValidityGridview.Size = new System.Drawing.Size(927, 343);
            this.medicineValidityGridview.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(249, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 132);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.validityCheckCombo);
            this.panel2.Location = new System.Drawing.Point(20, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 95);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check";
            // 
            // validityCheckCombo
            // 
            this.validityCheckCombo.BackColor = System.Drawing.Color.Transparent;
            this.validityCheckCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.validityCheckCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.validityCheckCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.validityCheckCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.validityCheckCombo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validityCheckCombo.ForeColor = System.Drawing.Color.Black;
            this.validityCheckCombo.ItemHeight = 30;
            this.validityCheckCombo.Items.AddRange(new object[] {
            "Valid Medicine",
            "Expired Medicine",
            "All Medicine"});
            this.validityCheckCombo.Location = new System.Drawing.Point(61, 32);
            this.validityCheckCombo.Name = "validityCheckCombo";
            this.validityCheckCombo.Size = new System.Drawing.Size(459, 36);
            this.validityCheckCombo.TabIndex = 0;
            // 
            // validityCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel10);
            this.Name = "validityCheck";
            this.Size = new System.Drawing.Size(1042, 709);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicineValidityGridview)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel10;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox validityCheckCombo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView medicineValidityGridview;
    }
}
