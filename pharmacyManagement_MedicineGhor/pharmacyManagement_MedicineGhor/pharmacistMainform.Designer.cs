namespace pharmacyManagement_MedicineGhor
{
    partial class pharmacistMainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pharmacistMainform));
            this.pnlbehind = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addMedicine1 = new pharmacyManagement_MedicineGhor.addMedicine();
            this.validityCheck1 = new pharmacyManagement_MedicineGhor.validityCheck();
            this.pnTopbar = new System.Windows.Forms.Panel();
            this.minibtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.crossbtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.projName = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnCross = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlsidebar = new System.Windows.Forms.Panel();
            this.vCheck_btn = new System.Windows.Forms.Button();
            this.addM_btn = new System.Windows.Forms.Button();
            this.dash_btn = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.w_pharma_txt = new System.Windows.Forms.Label();
            this.guna2PictureAdmin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pharmacistDashboard1 = new pharmacyManagement_MedicineGhor.pharmacistDashboard();
            this.pnlbehind.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnTopbar.SuspendLayout();
            this.pnlsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlbehind
            // 
            this.pnlbehind.Controls.Add(this.panel1);
            this.pnlbehind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbehind.Location = new System.Drawing.Point(238, 41);
            this.pnlbehind.Name = "pnlbehind";
            this.pnlbehind.Size = new System.Drawing.Size(1042, 709);
            this.pnlbehind.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pharmacistDashboard1);
            this.panel1.Controls.Add(this.addMedicine1);
            this.panel1.Controls.Add(this.validityCheck1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 709);
            this.panel1.TabIndex = 0;
            // 
            // addMedicine1
            // 
            this.addMedicine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMedicine1.Location = new System.Drawing.Point(0, 0);
            this.addMedicine1.Name = "addMedicine1";
            this.addMedicine1.Size = new System.Drawing.Size(1042, 709);
            this.addMedicine1.TabIndex = 1;
            // 
            // validityCheck1
            // 
            this.validityCheck1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.validityCheck1.Location = new System.Drawing.Point(0, 0);
            this.validityCheck1.Name = "validityCheck1";
            this.validityCheck1.Size = new System.Drawing.Size(1042, 709);
            this.validityCheck1.TabIndex = 0;
            // 
            // pnTopbar
            // 
            this.pnTopbar.BackColor = System.Drawing.Color.Lavender;
            this.pnTopbar.Controls.Add(this.minibtn);
            this.pnTopbar.Controls.Add(this.crossbtn);
            this.pnTopbar.Controls.Add(this.projName);
            this.pnTopbar.Controls.Add(this.btnMinimize);
            this.pnTopbar.Controls.Add(this.btnCross);
            this.pnTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopbar.Location = new System.Drawing.Point(238, 0);
            this.pnTopbar.Name = "pnTopbar";
            this.pnTopbar.Size = new System.Drawing.Size(1042, 41);
            this.pnTopbar.TabIndex = 3;
            this.pnTopbar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTopbar_Paint);
            // 
            // minibtn
            // 
            this.minibtn.BackColor = System.Drawing.Color.Transparent;
            this.minibtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minibtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minibtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minibtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minibtn.FillColor = System.Drawing.Color.Transparent;
            this.minibtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minibtn.ForeColor = System.Drawing.Color.White;
            this.minibtn.Image = ((System.Drawing.Image)(resources.GetObject("minibtn.Image")));
            this.minibtn.ImageSize = new System.Drawing.Size(26, 26);
            this.minibtn.Location = new System.Drawing.Point(926, 3);
            this.minibtn.Name = "minibtn";
            this.minibtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.minibtn.Size = new System.Drawing.Size(39, 32);
            this.minibtn.TabIndex = 5;
            this.minibtn.UseTransparentBackground = true;
            this.minibtn.Click += new System.EventHandler(this.minibtn_Click);
            // 
            // crossbtn
            // 
            this.crossbtn.BackColor = System.Drawing.Color.Transparent;
            this.crossbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.crossbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.crossbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.crossbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.crossbtn.FillColor = System.Drawing.Color.Transparent;
            this.crossbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.crossbtn.ForeColor = System.Drawing.Color.White;
            this.crossbtn.Image = ((System.Drawing.Image)(resources.GetObject("crossbtn.Image")));
            this.crossbtn.ImageSize = new System.Drawing.Size(25, 25);
            this.crossbtn.Location = new System.Drawing.Point(992, 3);
            this.crossbtn.Name = "crossbtn";
            this.crossbtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.crossbtn.Size = new System.Drawing.Size(39, 32);
            this.crossbtn.TabIndex = 4;
            this.crossbtn.UseTransparentBackground = true;
            this.crossbtn.Click += new System.EventHandler(this.crossbtn_Click);
            // 
            // projName
            // 
            this.projName.AutoSize = true;
            this.projName.BackColor = System.Drawing.Color.Transparent;
            this.projName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.projName.Location = new System.Drawing.Point(12, 9);
            this.projName.Name = "projName";
            this.projName.Size = new System.Drawing.Size(181, 23);
            this.projName.TabIndex = 4;
            this.projName.Text = "MEDICINE_GHOR";
            this.projName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageSize = new System.Drawing.Size(26, 26);
            this.btnMinimize.Location = new System.Drawing.Point(1163, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.Size = new System.Drawing.Size(39, 32);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseTransparentBackground = true;
            // 
            // btnCross
            // 
            this.btnCross.BackColor = System.Drawing.Color.Transparent;
            this.btnCross.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCross.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCross.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCross.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCross.FillColor = System.Drawing.Color.Transparent;
            this.btnCross.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCross.ForeColor = System.Drawing.Color.White;
            this.btnCross.Image = ((System.Drawing.Image)(resources.GetObject("btnCross.Image")));
            this.btnCross.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCross.Location = new System.Drawing.Point(1229, 5);
            this.btnCross.Name = "btnCross";
            this.btnCross.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCross.Size = new System.Drawing.Size(39, 32);
            this.btnCross.TabIndex = 2;
            this.btnCross.UseTransparentBackground = true;
            // 
            // pnlsidebar
            // 
            this.pnlsidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.pnlsidebar.Controls.Add(this.vCheck_btn);
            this.pnlsidebar.Controls.Add(this.addM_btn);
            this.pnlsidebar.Controls.Add(this.dash_btn);
            this.pnlsidebar.Controls.Add(this.btnLogout);
            this.pnlsidebar.Controls.Add(this.w_pharma_txt);
            this.pnlsidebar.Controls.Add(this.guna2PictureAdmin);
            this.pnlsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlsidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlsidebar.Name = "pnlsidebar";
            this.pnlsidebar.Size = new System.Drawing.Size(238, 750);
            this.pnlsidebar.TabIndex = 4;
            // 
            // vCheck_btn
            // 
            this.vCheck_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.vCheck_btn.FlatAppearance.BorderSize = 0;
            this.vCheck_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.vCheck_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.vCheck_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.vCheck_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vCheck_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vCheck_btn.ForeColor = System.Drawing.Color.White;
            this.vCheck_btn.Image = ((System.Drawing.Image)(resources.GetObject("vCheck_btn.Image")));
            this.vCheck_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vCheck_btn.Location = new System.Drawing.Point(0, 463);
            this.vCheck_btn.Name = "vCheck_btn";
            this.vCheck_btn.Size = new System.Drawing.Size(238, 35);
            this.vCheck_btn.TabIndex = 10;
            this.vCheck_btn.Text = "Validity Check";
            this.vCheck_btn.UseVisualStyleBackColor = false;
            this.vCheck_btn.Click += new System.EventHandler(this.vCheck_btn_Click);
            // 
            // addM_btn
            // 
            this.addM_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addM_btn.FlatAppearance.BorderSize = 0;
            this.addM_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.addM_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.addM_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.addM_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addM_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addM_btn.ForeColor = System.Drawing.Color.White;
            this.addM_btn.Image = ((System.Drawing.Image)(resources.GetObject("addM_btn.Image")));
            this.addM_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addM_btn.Location = new System.Drawing.Point(0, 356);
            this.addM_btn.Name = "addM_btn";
            this.addM_btn.Size = new System.Drawing.Size(241, 35);
            this.addM_btn.TabIndex = 9;
            this.addM_btn.Text = "Add Medicine";
            this.addM_btn.UseVisualStyleBackColor = false;
            this.addM_btn.Click += new System.EventHandler(this.addM_btn_Click);
            // 
            // dash_btn
            // 
            this.dash_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.dash_btn.FlatAppearance.BorderSize = 0;
            this.dash_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.dash_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.dash_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.dash_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_btn.ForeColor = System.Drawing.Color.White;
            this.dash_btn.Image = ((System.Drawing.Image)(resources.GetObject("dash_btn.Image")));
            this.dash_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash_btn.Location = new System.Drawing.Point(0, 261);
            this.dash_btn.Name = "dash_btn";
            this.dash_btn.Size = new System.Drawing.Size(238, 35);
            this.dash_btn.TabIndex = 8;
            this.dash_btn.Text = "Dashboard";
            this.dash_btn.UseVisualStyleBackColor = false;
            this.dash_btn.Click += new System.EventHandler(this.dash_btn_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(52, 646);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 39);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // w_pharma_txt
            // 
            this.w_pharma_txt.AutoSize = true;
            this.w_pharma_txt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w_pharma_txt.ForeColor = System.Drawing.Color.White;
            this.w_pharma_txt.Location = new System.Drawing.Point(20, 146);
            this.w_pharma_txt.Name = "w_pharma_txt";
            this.w_pharma_txt.Size = new System.Drawing.Size(198, 17);
            this.w_pharma_txt.TabIndex = 2;
            this.w_pharma_txt.Text = "WELCOME PHARMACIST";
            // 
            // guna2PictureAdmin
            // 
            this.guna2PictureAdmin.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureAdmin.Image")));
            this.guna2PictureAdmin.ImageRotate = 0F;
            this.guna2PictureAdmin.Location = new System.Drawing.Point(65, 20);
            this.guna2PictureAdmin.Name = "guna2PictureAdmin";
            this.guna2PictureAdmin.Size = new System.Drawing.Size(110, 114);
            this.guna2PictureAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureAdmin.TabIndex = 2;
            this.guna2PictureAdmin.TabStop = false;
            // 
            // pharmacistDashboard1
            // 
            this.pharmacistDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pharmacistDashboard1.Location = new System.Drawing.Point(0, 0);
            this.pharmacistDashboard1.Name = "pharmacistDashboard1";
            this.pharmacistDashboard1.Size = new System.Drawing.Size(1042, 709);
            this.pharmacistDashboard1.TabIndex = 2;
            // 
            // pharmacistMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 750);
            this.Controls.Add(this.pnlbehind);
            this.Controls.Add(this.pnTopbar);
            this.Controls.Add(this.pnlsidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pharmacistMainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlbehind.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnTopbar.ResumeLayout(false);
            this.pnTopbar.PerformLayout();
            this.pnlsidebar.ResumeLayout(false);
            this.pnlsidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlbehind;
        private System.Windows.Forms.Panel pnTopbar;
        private System.Windows.Forms.Label projName;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2CircleButton btnCross;
        private System.Windows.Forms.Panel pnlsidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label w_pharma_txt;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureAdmin;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton minibtn;
        private Guna.UI2.WinForms.Guna2CircleButton crossbtn;
        private System.Windows.Forms.Button vCheck_btn;
        private System.Windows.Forms.Button addM_btn;
        private System.Windows.Forms.Button dash_btn;
        private addMedicine addMedicine1;
        private validityCheck validityCheck1;
        private pharmacistDashboard pharmacistDashboard1;
    }
}
