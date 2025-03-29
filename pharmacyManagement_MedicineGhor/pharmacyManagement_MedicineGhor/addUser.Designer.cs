namespace pharmacyManagement_MedicineGhor
{
    partial class addUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.userdataGridView = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addUsers_userStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.resetUserBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteUserBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateUserBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addUserBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addUsers_userEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addUsers_userRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addUsers_userName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addUsers_userPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userdataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 709);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.userdataGridView);
            this.panel3.Location = new System.Drawing.Point(374, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 600);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "User Data";
            // 
            // userdataGridView
            // 
            this.userdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.userdataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userdataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.userdataGridView.Location = new System.Drawing.Point(20, 53);
            this.userdataGridView.Name = "userdataGridView";
            this.userdataGridView.RowHeadersVisible = false;
            this.userdataGridView.RowHeadersWidth = 51;
            this.userdataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.userdataGridView.RowTemplate.Height = 24;
            this.userdataGridView.Size = new System.Drawing.Size(596, 520);
            this.userdataGridView.TabIndex = 0;
            this.userdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userdataGridView_CellClick);
            this.userdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userdataGridView_CellContentClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(27, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 32);
            this.label15.TabIndex = 9;
            this.label15.Text = "Add User";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.addUsers_userStatus);
            this.panel2.Controls.Add(this.resetUserBtn);
            this.panel2.Controls.Add(this.deleteUserBtn);
            this.panel2.Controls.Add(this.updateUserBtn);
            this.panel2.Controls.Add(this.addUserBtn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addUsers_userEmail);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addUsers_userRole);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.addUsers_userName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.addUsers_userPass);
            this.panel2.ForeColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(24, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 600);
            this.panel2.TabIndex = 0;
            // 
            // addUsers_userStatus
            // 
            this.addUsers_userStatus.BackColor = System.Drawing.Color.Transparent;
            this.addUsers_userStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.addUsers_userStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addUsers_userStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUsers_userStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUsers_userStatus.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.addUsers_userStatus.ForeColor = System.Drawing.Color.Black;
            this.addUsers_userStatus.ItemHeight = 30;
            this.addUsers_userStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addUsers_userStatus.Location = new System.Drawing.Point(20, 142);
            this.addUsers_userStatus.Name = "addUsers_userStatus";
            this.addUsers_userStatus.Size = new System.Drawing.Size(285, 36);
            this.addUsers_userStatus.TabIndex = 14;
            // 
            // resetUserBtn
            // 
            this.resetUserBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetUserBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetUserBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetUserBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetUserBtn.FillColor = System.Drawing.Color.White;
            this.resetUserBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetUserBtn.ForeColor = System.Drawing.Color.Black;
            this.resetUserBtn.Location = new System.Drawing.Point(169, 547);
            this.resetUserBtn.Name = "resetUserBtn";
            this.resetUserBtn.Size = new System.Drawing.Size(111, 38);
            this.resetUserBtn.TabIndex = 13;
            this.resetUserBtn.Text = "Reset";
            this.resetUserBtn.Click += new System.EventHandler(this.resetUserBtn_Click);
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteUserBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteUserBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteUserBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteUserBtn.FillColor = System.Drawing.Color.White;
            this.deleteUserBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteUserBtn.Location = new System.Drawing.Point(20, 547);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(111, 38);
            this.deleteUserBtn.TabIndex = 12;
            this.deleteUserBtn.Text = "Delete";
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // updateUserBtn
            // 
            this.updateUserBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateUserBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateUserBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateUserBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateUserBtn.FillColor = System.Drawing.Color.White;
            this.updateUserBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateUserBtn.ForeColor = System.Drawing.Color.Black;
            this.updateUserBtn.Location = new System.Drawing.Point(169, 486);
            this.updateUserBtn.Name = "updateUserBtn";
            this.updateUserBtn.Size = new System.Drawing.Size(111, 38);
            this.updateUserBtn.TabIndex = 11;
            this.updateUserBtn.Text = "Update";
            this.updateUserBtn.Click += new System.EventHandler(this.updateUserBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addUserBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addUserBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addUserBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addUserBtn.FillColor = System.Drawing.Color.White;
            this.addUserBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.ForeColor = System.Drawing.Color.Black;
            this.addUserBtn.Location = new System.Drawing.Point(21, 486);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(111, 38);
            this.addUserBtn.TabIndex = 10;
            this.addUserBtn.Text = "Add";
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status";
            // 
            // addUsers_userEmail
            // 
            this.addUsers_userEmail.BorderColor = System.Drawing.Color.DarkGray;
            this.addUsers_userEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addUsers_userEmail.DefaultText = "";
            this.addUsers_userEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addUsers_userEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addUsers_userEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUsers_userEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUsers_userEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUsers_userEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_userEmail.ForeColor = System.Drawing.Color.Black;
            this.addUsers_userEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUsers_userEmail.Location = new System.Drawing.Point(20, 424);
            this.addUsers_userEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addUsers_userEmail.Name = "addUsers_userEmail";
            this.addUsers_userEmail.PasswordChar = '\0';
            this.addUsers_userEmail.PlaceholderText = "";
            this.addUsers_userEmail.SelectedText = "";
            this.addUsers_userEmail.Size = new System.Drawing.Size(285, 40);
            this.addUsers_userEmail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Role";
            // 
            // addUsers_userRole
            // 
            this.addUsers_userRole.BackColor = System.Drawing.Color.Transparent;
            this.addUsers_userRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.addUsers_userRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addUsers_userRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUsers_userRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUsers_userRole.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.addUsers_userRole.ForeColor = System.Drawing.Color.Black;
            this.addUsers_userRole.ItemHeight = 30;
            this.addUsers_userRole.Items.AddRange(new object[] {
            "Admin",
            "Pharmacist",
            "Seller"});
            this.addUsers_userRole.Location = new System.Drawing.Point(20, 53);
            this.addUsers_userRole.Name = "addUsers_userRole";
            this.addUsers_userRole.Size = new System.Drawing.Size(285, 36);
            this.addUsers_userRole.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // addUsers_userName
            // 
            this.addUsers_userName.BorderColor = System.Drawing.Color.DarkGray;
            this.addUsers_userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addUsers_userName.DefaultText = "";
            this.addUsers_userName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addUsers_userName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addUsers_userName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUsers_userName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUsers_userName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUsers_userName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_userName.ForeColor = System.Drawing.Color.Black;
            this.addUsers_userName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUsers_userName.Location = new System.Drawing.Point(20, 236);
            this.addUsers_userName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addUsers_userName.Name = "addUsers_userName";
            this.addUsers_userName.PasswordChar = '\0';
            this.addUsers_userName.PlaceholderText = "";
            this.addUsers_userName.SelectedText = "";
            this.addUsers_userName.Size = new System.Drawing.Size(285, 40);
            this.addUsers_userName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // addUsers_userPass
            // 
            this.addUsers_userPass.BorderColor = System.Drawing.Color.DarkGray;
            this.addUsers_userPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addUsers_userPass.DefaultText = "";
            this.addUsers_userPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addUsers_userPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addUsers_userPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUsers_userPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUsers_userPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUsers_userPass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_userPass.ForeColor = System.Drawing.Color.Black;
            this.addUsers_userPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUsers_userPass.Location = new System.Drawing.Point(20, 333);
            this.addUsers_userPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addUsers_userPass.Name = "addUsers_userPass";
            this.addUsers_userPass.PasswordChar = '\0';
            this.addUsers_userPass.PlaceholderText = "";
            this.addUsers_userPass.SelectedText = "";
            this.addUsers_userPass.Size = new System.Drawing.Size(286, 40);
            this.addUsers_userPass.TabIndex = 0;
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "addUser";
            this.Size = new System.Drawing.Size(1042, 709);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userdataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox addUsers_userPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox addUsers_userName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox addUsers_userRole;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox addUsers_userEmail;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button resetUserBtn;
        private Guna.UI2.WinForms.Guna2Button deleteUserBtn;
        private Guna.UI2.WinForms.Guna2Button updateUserBtn;
        private Guna.UI2.WinForms.Guna2Button addUserBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView userdataGridView;
        private Guna.UI2.WinForms.Guna2ComboBox addUsers_userStatus;
    }
}
