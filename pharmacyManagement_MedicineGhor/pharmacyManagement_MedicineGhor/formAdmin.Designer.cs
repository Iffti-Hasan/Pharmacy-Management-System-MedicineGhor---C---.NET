namespace pharmacyManagement_MedicineGhor
{
    partial class formAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdmin));
            this.pnTopbar = new System.Windows.Forms.Panel();
            this.panel_move = new System.Windows.Forms.Panel();
            this.mini_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cross_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.projName = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnCross = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlsidebar = new System.Windows.Forms.Panel();
            this.allOrderBtn = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.cusD_btn = new System.Windows.Forms.Button();
            this.adduser_btn = new System.Windows.Forms.Button();
            this.dashBoard_btn = new System.Windows.Forms.Button();
            this.w_Admin_txt = new System.Windows.Forms.Label();
            this.guna2PictureAdmin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlbehind = new System.Windows.Forms.Panel();
            this.adminDashboard1 = new pharmacyManagement_MedicineGhor.adminDashboard();
            this.addUser1 = new pharmacyManagement_MedicineGhor.addUser();
            this.customerDetails1 = new pharmacyManagement_MedicineGhor.customerDetails();
            this.allOrders1 = new pharmacyManagement_MedicineGhor.allOrders();
            this.pnTopbar.SuspendLayout();
            this.panel_move.SuspendLayout();
            this.pnlsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureAdmin)).BeginInit();
            this.pnlbehind.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTopbar
            // 
            this.pnTopbar.BackColor = System.Drawing.Color.Lavender;
            this.pnTopbar.Controls.Add(this.panel_move);
            this.pnTopbar.Controls.Add(this.projName);
            this.pnTopbar.Controls.Add(this.btnMinimize);
            this.pnTopbar.Controls.Add(this.btnCross);
            this.pnTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopbar.Location = new System.Drawing.Point(0, 0);
            this.pnTopbar.Name = "pnTopbar";
            this.pnTopbar.Size = new System.Drawing.Size(1280, 41);
            this.pnTopbar.TabIndex = 0;
            // 
            // panel_move
            // 
            this.panel_move.BackColor = System.Drawing.Color.Lavender;
            this.panel_move.Controls.Add(this.mini_btn);
            this.panel_move.Controls.Add(this.cross_btn);
            this.panel_move.Controls.Add(this.label1);
            this.panel_move.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_move.Location = new System.Drawing.Point(0, 0);
            this.panel_move.Name = "panel_move";
            this.panel_move.Size = new System.Drawing.Size(1280, 41);
            this.panel_move.TabIndex = 5;
            this.panel_move.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_move_Paint);
            // 
            // mini_btn
            // 
            this.mini_btn.BackColor = System.Drawing.Color.Transparent;
            this.mini_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.mini_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.mini_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.mini_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.mini_btn.FillColor = System.Drawing.Color.Transparent;
            this.mini_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mini_btn.ForeColor = System.Drawing.Color.White;
            this.mini_btn.Image = ((System.Drawing.Image)(resources.GetObject("mini_btn.Image")));
            this.mini_btn.ImageSize = new System.Drawing.Size(26, 26);
            this.mini_btn.Location = new System.Drawing.Point(1163, 5);
            this.mini_btn.Name = "mini_btn";
            this.mini_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.mini_btn.Size = new System.Drawing.Size(39, 32);
            this.mini_btn.TabIndex = 7;
            this.mini_btn.UseTransparentBackground = true;
            this.mini_btn.Click += new System.EventHandler(this.mini_btn_Click);
            // 
            // cross_btn
            // 
            this.cross_btn.BackColor = System.Drawing.Color.Transparent;
            this.cross_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cross_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cross_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cross_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cross_btn.FillColor = System.Drawing.Color.Transparent;
            this.cross_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cross_btn.ForeColor = System.Drawing.Color.White;
            this.cross_btn.Image = ((System.Drawing.Image)(resources.GetObject("cross_btn.Image")));
            this.cross_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.cross_btn.Location = new System.Drawing.Point(1229, 5);
            this.cross_btn.Name = "cross_btn";
            this.cross_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cross_btn.Size = new System.Drawing.Size(39, 32);
            this.cross_btn.TabIndex = 6;
            this.cross_btn.UseTransparentBackground = true;
            this.cross_btn.Click += new System.EventHandler(this.cross_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "MEDICINE_GHOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.projName.Click += new System.EventHandler(this.projName_Click);
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
            this.pnlsidebar.Controls.Add(this.allOrderBtn);
            this.pnlsidebar.Controls.Add(this.btnLogout);
            this.pnlsidebar.Controls.Add(this.cusD_btn);
            this.pnlsidebar.Controls.Add(this.adduser_btn);
            this.pnlsidebar.Controls.Add(this.dashBoard_btn);
            this.pnlsidebar.Controls.Add(this.w_Admin_txt);
            this.pnlsidebar.Controls.Add(this.guna2PictureAdmin);
            this.pnlsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlsidebar.Location = new System.Drawing.Point(0, 41);
            this.pnlsidebar.Name = "pnlsidebar";
            this.pnlsidebar.Size = new System.Drawing.Size(238, 709);
            this.pnlsidebar.TabIndex = 1;
            this.pnlsidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlsidebar_Paint);
            // 
            // allOrderBtn
            // 
            this.allOrderBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.allOrderBtn.FlatAppearance.BorderSize = 0;
            this.allOrderBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.allOrderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.allOrderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.allOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allOrderBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allOrderBtn.ForeColor = System.Drawing.Color.White;
            this.allOrderBtn.Image = ((System.Drawing.Image)(resources.GetObject("allOrderBtn.Image")));
            this.allOrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allOrderBtn.Location = new System.Drawing.Point(0, 492);
            this.allOrderBtn.Name = "allOrderBtn";
            this.allOrderBtn.Size = new System.Drawing.Size(238, 35);
            this.allOrderBtn.TabIndex = 9;
            this.allOrderBtn.Text = "All Orders";
            this.allOrderBtn.UseVisualStyleBackColor = false;
            this.allOrderBtn.Click += new System.EventHandler(this.allOrderBtn_Click);
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
            // cusD_btn
            // 
            this.cusD_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cusD_btn.FlatAppearance.BorderSize = 0;
            this.cusD_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.cusD_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.cusD_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.cusD_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusD_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusD_btn.ForeColor = System.Drawing.Color.White;
            this.cusD_btn.Image = ((System.Drawing.Image)(resources.GetObject("cusD_btn.Image")));
            this.cusD_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cusD_btn.Location = new System.Drawing.Point(0, 396);
            this.cusD_btn.Name = "cusD_btn";
            this.cusD_btn.Size = new System.Drawing.Size(238, 35);
            this.cusD_btn.TabIndex = 5;
            this.cusD_btn.Text = "Customer Details";
            this.cusD_btn.UseVisualStyleBackColor = false;
            this.cusD_btn.Click += new System.EventHandler(this.cusD_btn_Click);
            // 
            // adduser_btn
            // 
            this.adduser_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.adduser_btn.FlatAppearance.BorderSize = 0;
            this.adduser_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.adduser_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.adduser_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.adduser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adduser_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduser_btn.ForeColor = System.Drawing.Color.White;
            this.adduser_btn.Image = ((System.Drawing.Image)(resources.GetObject("adduser_btn.Image")));
            this.adduser_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adduser_btn.Location = new System.Drawing.Point(0, 307);
            this.adduser_btn.Name = "adduser_btn";
            this.adduser_btn.Size = new System.Drawing.Size(241, 35);
            this.adduser_btn.TabIndex = 3;
            this.adduser_btn.Text = "Add User";
            this.adduser_btn.UseVisualStyleBackColor = false;
            this.adduser_btn.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // dashBoard_btn
            // 
            this.dashBoard_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.dashBoard_btn.FlatAppearance.BorderSize = 0;
            this.dashBoard_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.dashBoard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.dashBoard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.dashBoard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashBoard_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoard_btn.ForeColor = System.Drawing.Color.White;
            this.dashBoard_btn.Image = ((System.Drawing.Image)(resources.GetObject("dashBoard_btn.Image")));
            this.dashBoard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashBoard_btn.Location = new System.Drawing.Point(0, 221);
            this.dashBoard_btn.Name = "dashBoard_btn";
            this.dashBoard_btn.Size = new System.Drawing.Size(238, 35);
            this.dashBoard_btn.TabIndex = 2;
            this.dashBoard_btn.Text = "Dashboard";
            this.dashBoard_btn.UseVisualStyleBackColor = false;
            this.dashBoard_btn.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // w_Admin_txt
            // 
            this.w_Admin_txt.AutoSize = true;
            this.w_Admin_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w_Admin_txt.ForeColor = System.Drawing.Color.White;
            this.w_Admin_txt.Location = new System.Drawing.Point(22, 137);
            this.w_Admin_txt.Name = "w_Admin_txt";
            this.w_Admin_txt.Size = new System.Drawing.Size(187, 23);
            this.w_Admin_txt.TabIndex = 2;
            this.w_Admin_txt.Text = "WELCOME ADMIN";
            this.w_Admin_txt.Click += new System.EventHandler(this.label1_Click);
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
            // pnlbehind
            // 
            this.pnlbehind.Controls.Add(this.adminDashboard1);
            this.pnlbehind.Controls.Add(this.addUser1);
            this.pnlbehind.Controls.Add(this.customerDetails1);
            this.pnlbehind.Controls.Add(this.allOrders1);
            this.pnlbehind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbehind.Location = new System.Drawing.Point(238, 41);
            this.pnlbehind.Name = "pnlbehind";
            this.pnlbehind.Size = new System.Drawing.Size(1042, 709);
            this.pnlbehind.TabIndex = 2;
            this.pnlbehind.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlbehind_Paint);
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminDashboard1.Location = new System.Drawing.Point(0, 0);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(1042, 709);
            this.adminDashboard1.TabIndex = 3;
            this.adminDashboard1.Load += new System.EventHandler(this.adminDashboard1_Load_1);
            // 
            // addUser1
            // 
            this.addUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUser1.Location = new System.Drawing.Point(0, 0);
            this.addUser1.Name = "addUser1";
            this.addUser1.Size = new System.Drawing.Size(1042, 709);
            this.addUser1.TabIndex = 2;
            // 
            // customerDetails1
            // 
            this.customerDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDetails1.Location = new System.Drawing.Point(0, 0);
            this.customerDetails1.Name = "customerDetails1";
            this.customerDetails1.Size = new System.Drawing.Size(1042, 709);
            this.customerDetails1.TabIndex = 1;
            // 
            // allOrders1
            // 
            this.allOrders1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allOrders1.Location = new System.Drawing.Point(0, 0);
            this.allOrders1.Name = "allOrders1";
            this.allOrders1.Size = new System.Drawing.Size(1042, 709);
            this.allOrders1.TabIndex = 0;
            // 
            // formAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 750);
            this.Controls.Add(this.pnlbehind);
            this.Controls.Add(this.pnlsidebar);
            this.Controls.Add(this.pnTopbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.pnTopbar.ResumeLayout(false);
            this.pnTopbar.PerformLayout();
            this.panel_move.ResumeLayout(false);
            this.panel_move.PerformLayout();
            this.pnlsidebar.ResumeLayout(false);
            this.pnlsidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureAdmin)).EndInit();
            this.pnlbehind.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTopbar;
        private System.Windows.Forms.Panel pnlsidebar;
        private Guna.UI2.WinForms.Guna2CircleButton btnCross;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private System.Windows.Forms.Label projName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureAdmin;
        private System.Windows.Forms.Label w_Admin_txt;
        private System.Windows.Forms.Button dashBoard_btn;
        private System.Windows.Forms.Button adduser_btn;
        private System.Windows.Forms.Button cusD_btn;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlbehind;
        private System.Windows.Forms.Panel panel_move;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button allOrderBtn;
        private Guna.UI2.WinForms.Guna2CircleButton mini_btn;
        private Guna.UI2.WinForms.Guna2CircleButton cross_btn;
        private adminDashboard adminDashboard1;
        private addUser addUser1;
        private customerDetails customerDetails1;
        private allOrders allOrders1;
    }
}

