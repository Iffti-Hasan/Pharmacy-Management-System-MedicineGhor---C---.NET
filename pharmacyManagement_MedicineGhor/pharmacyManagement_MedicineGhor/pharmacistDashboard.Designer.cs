namespace pharmacyManagement_MedicineGhor
{
    partial class pharmacistDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pharmacistDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.todays_revenue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.available_medicine = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.total_seller = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.load_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.out_of_stock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.load_chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.AliceBlue;
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Location = new System.Drawing.Point(27, 154);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(987, 167);
            this.panel6.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.todays_revenue);
            this.panel9.Controls.Add(this.guna2PictureBox4);
            this.panel9.Location = new System.Drawing.Point(33, 18);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(268, 130);
            this.panel9.TabIndex = 0;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(95, 59);
            this.guna2PictureBox4.TabIndex = 6;
            this.guna2PictureBox4.TabStop = false;
            // 
            // todays_revenue
            // 
            this.todays_revenue.AutoSize = true;
            this.todays_revenue.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todays_revenue.ForeColor = System.Drawing.Color.White;
            this.todays_revenue.Location = new System.Drawing.Point(157, 18);
            this.todays_revenue.Name = "todays_revenue";
            this.todays_revenue.Size = new System.Drawing.Size(28, 32);
            this.todays_revenue.TabIndex = 6;
            this.todays_revenue.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(45, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "Today\'s Revenue";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.panel7.Controls.Add(this.available_medicine);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.guna2PictureBox6);
            this.panel7.Location = new System.Drawing.Point(670, 21);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(289, 127);
            this.panel7.TabIndex = 2;
            // 
            // guna2PictureBox6
            // 
            this.guna2PictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox6.Image")));
            this.guna2PictureBox6.ImageRotate = 0F;
            this.guna2PictureBox6.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.Size = new System.Drawing.Size(95, 59);
            this.guna2PictureBox6.TabIndex = 8;
            this.guna2PictureBox6.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(62, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "Available Medicine";
            // 
            // available_medicine
            // 
            this.available_medicine.AutoSize = true;
            this.available_medicine.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available_medicine.ForeColor = System.Drawing.Color.White;
            this.available_medicine.Location = new System.Drawing.Point(185, 15);
            this.available_medicine.Name = "available_medicine";
            this.available_medicine.Size = new System.Drawing.Size(28, 32);
            this.available_medicine.TabIndex = 8;
            this.available_medicine.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.total_seller);
            this.panel5.Controls.Add(this.guna2PictureBox3);
            this.panel5.Location = new System.Drawing.Point(343, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(289, 130);
            this.panel5.TabIndex = 2;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(7, 3);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(95, 59);
            this.guna2PictureBox3.TabIndex = 4;
            this.guna2PictureBox3.TabStop = false;
            // 
            // total_seller
            // 
            this.total_seller.AutoSize = true;
            this.total_seller.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_seller.ForeColor = System.Drawing.Color.White;
            this.total_seller.Location = new System.Drawing.Point(194, 18);
            this.total_seller.Name = "total_seller";
            this.total_seller.Size = new System.Drawing.Size(28, 32);
            this.total_seller.TabIndex = 3;
            this.total_seller.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(89, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Seller";
            // 
            // load_chart
            // 
            this.load_chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.load_chart.BorderlineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.load_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.load_chart.Legends.Add(legend1);
            this.load_chart.Location = new System.Drawing.Point(558, 408);
            this.load_chart.Name = "load_chart";
            this.load_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.load_chart.Series.Add(series1);
            this.load_chart.Size = new System.Drawing.Size(303, 194);
            this.load_chart.TabIndex = 5;
            this.load_chart.Text = "chart1";
            title1.BackColor = System.Drawing.Color.Lavender;
            title1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Medicine Validity";
            this.load_chart.Titles.Add(title1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(52, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 32);
            this.label15.TabIndex = 6;
            this.label15.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.load_chart);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 709);
            this.panel1.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.panel10.Controls.Add(this.out_of_stock);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.guna2PictureBox7);
            this.panel10.Location = new System.Drawing.Point(150, 405);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(299, 194);
            this.panel10.TabIndex = 10;
            // 
            // out_of_stock
            // 
            this.out_of_stock.AutoSize = true;
            this.out_of_stock.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_of_stock.ForeColor = System.Drawing.Color.White;
            this.out_of_stock.Location = new System.Drawing.Point(183, 19);
            this.out_of_stock.Name = "out_of_stock";
            this.out_of_stock.Size = new System.Drawing.Size(28, 32);
            this.out_of_stock.TabIndex = 8;
            this.out_of_stock.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Out of Stock";
            // 
            // guna2PictureBox7
            // 
            this.guna2PictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox7.Image")));
            this.guna2PictureBox7.ImageRotate = 0F;
            this.guna2PictureBox7.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox7.Name = "guna2PictureBox7";
            this.guna2PictureBox7.Size = new System.Drawing.Size(95, 59);
            this.guna2PictureBox7.TabIndex = 8;
            this.guna2PictureBox7.TabStop = false;
            // 
            // pharmacistDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "pharmacistDashboard";
            this.Size = new System.Drawing.Size(1042, 709);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.load_chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label total_seller;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label available_medicine;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label todays_revenue;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart load_chart;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label out_of_stock;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox7;
    }
}
