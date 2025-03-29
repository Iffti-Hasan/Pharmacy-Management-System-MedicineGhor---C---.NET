namespace pharmacyManagement_MedicineGhor
{
    partial class allOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.searchOrdName_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.allOrderGridview = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allOrderGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.searchOrdName_txt);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 709);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(845, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Search Orders";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchOrdName_txt
            // 
            this.searchOrdName_txt.BorderThickness = 3;
            this.searchOrdName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchOrdName_txt.DefaultText = "";
            this.searchOrdName_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchOrdName_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchOrdName_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchOrdName_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchOrdName_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchOrdName_txt.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.searchOrdName_txt.ForeColor = System.Drawing.Color.Black;
            this.searchOrdName_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchOrdName_txt.Location = new System.Drawing.Point(828, 38);
            this.searchOrdName_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchOrdName_txt.Name = "searchOrdName_txt";
            this.searchOrdName_txt.PasswordChar = '\0';
            this.searchOrdName_txt.PlaceholderText = "";
            this.searchOrdName_txt.SelectedText = "";
            this.searchOrdName_txt.Size = new System.Drawing.Size(181, 32);
            this.searchOrdName_txt.TabIndex = 23;
            this.searchOrdName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchOrdName_txt.TextChanged += new System.EventHandler(this.searchOrdName_txt_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 32);
            this.label15.TabIndex = 10;
            this.label15.Text = "All Orders";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.allOrderGridview);
            this.panel2.Location = new System.Drawing.Point(21, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 576);
            this.panel2.TabIndex = 0;
            // 
            // allOrderGridview
            // 
            this.allOrderGridview.BackgroundColor = System.Drawing.Color.White;
            this.allOrderGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allOrderGridview.DefaultCellStyle = dataGridViewCellStyle1;
            this.allOrderGridview.Location = new System.Drawing.Point(37, 27);
            this.allOrderGridview.Name = "allOrderGridview";
            this.allOrderGridview.RowHeadersVisible = false;
            this.allOrderGridview.RowHeadersWidth = 51;
            this.allOrderGridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.allOrderGridview.RowTemplate.Height = 24;
            this.allOrderGridview.Size = new System.Drawing.Size(914, 522);
            this.allOrderGridview.TabIndex = 1;
            // 
            // allOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "allOrders";
            this.Size = new System.Drawing.Size(1042, 709);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allOrderGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox searchOrdName_txt;
        private System.Windows.Forms.DataGridView allOrderGridview;
    }
}
