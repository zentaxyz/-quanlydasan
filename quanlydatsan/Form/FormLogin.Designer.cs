namespace quanlydatsan
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            lblSidebarDesc = new Label();
            lblSidebarTitle = new Label();
            lblSidebarLogo = new Label();
            pnlContainer = new Panel();
            pnlLogin = new Panel();
            lblLoginTitle = new Label();
            lblLoginSubtitle = new Label();
            lblLoginUser = new Label();
            txtLoginUsername = new TextBox();
            lblLoginPass = new Label();
            txtLoginPassword = new TextBox();
            chkShowPasswordLogin = new CheckBox();
            linkForgotPassword = new LinkLabel();
            btnLogin = new Button();
            linkToRegister = new LinkLabel();
            pnlRegister = new Panel();
            lblRegTitle = new Label();
            lblRegSubtitle = new Label();
            lblRegFullName = new Label();
            txtRegFullName = new TextBox();
            lblRegPhone = new Label();
            txtRegPhone = new TextBox();
            lblRegUser = new Label();
            txtRegUsername = new TextBox();
            lblRegPass = new Label();
            txtRegPassword = new TextBox();
            lblRegConfirmPass = new Label();
            txtRegConfirmPassword = new TextBox();
            btnRegister = new Button();
            linkBackToLoginFromReg = new LinkLabel();
            pnlForgotPassword = new Panel();
            lblForgotTitle = new Label();
            lblForgotSubtitle = new Label();
            lblForgotAccount = new Label();
            txtForgotAccount = new TextBox();
            lblForgotNewPass = new Label();
            txtForgotNewPass = new TextBox();
            lblForgotConfirmPass = new Label();
            txtForgotConfirmPass = new TextBox();
            btnResetPassword = new Button();
            linkBackToLoginFromForgot = new LinkLabel();
            pnlSidebar.SuspendLayout();
            pnlContainer.SuspendLayout();
            pnlLogin.SuspendLayout();
            pnlRegister.SuspendLayout();
            pnlForgotPassword.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(27, 94, 32);
            pnlSidebar.Controls.Add(lblSidebarDesc);
            pnlSidebar.Controls.Add(lblSidebarTitle);
            pnlSidebar.Controls.Add(lblSidebarLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(280, 521);
            pnlSidebar.TabIndex = 0;
            // 
            // lblSidebarDesc
            // 
            lblSidebarDesc.Font = new Font("Segoe UI", 9.5F);
            lblSidebarDesc.ForeColor = Color.FromArgb(200, 230, 201);
            lblSidebarDesc.Location = new Point(20, 210);
            lblSidebarDesc.Name = "lblSidebarDesc";
            lblSidebarDesc.Size = new Size(240, 80);
            lblSidebarDesc.TabIndex = 2;
            lblSidebarDesc.Text = "Hệ thống quản lý và đặt sân thể thao chuyên nghiệp, nhanh chóng và tiện lợi.";
            lblSidebarDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSidebarTitle
            // 
            lblSidebarTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblSidebarTitle.ForeColor = Color.White;
            lblSidebarTitle.Location = new Point(12, 135);
            lblSidebarTitle.Name = "lblSidebarTitle";
            lblSidebarTitle.Size = new Size(256, 60);
            lblSidebarTitle.TabIndex = 1;
            lblSidebarTitle.Text = "SPORT ARENA\nQUẢN LÝ ĐẶT SÂN";
            lblSidebarTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSidebarLogo
            // 
            lblSidebarLogo.Font = new Font("Segoe UI", 36F);
            lblSidebarLogo.ForeColor = Color.White;
            lblSidebarLogo.Location = new Point(12, 35);
            lblSidebarLogo.Name = "lblSidebarLogo";
            lblSidebarLogo.Size = new Size(256, 85);
            lblSidebarLogo.TabIndex = 0;
            lblSidebarLogo.Text = "⚽ 🏸";
            lblSidebarLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Controls.Add(pnlLogin);
            pnlContainer.Controls.Add(pnlRegister);
            pnlContainer.Controls.Add(pnlForgotPassword);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(280, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Padding = new Padding(30, 20, 30, 20);
            pnlContainer.Size = new Size(524, 521);
            pnlContainer.TabIndex = 1;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(lblLoginTitle);
            pnlLogin.Controls.Add(lblLoginSubtitle);
            pnlLogin.Controls.Add(lblLoginUser);
            pnlLogin.Controls.Add(txtLoginUsername);
            pnlLogin.Controls.Add(lblLoginPass);
            pnlLogin.Controls.Add(txtLoginPassword);
            pnlLogin.Controls.Add(chkShowPasswordLogin);
            pnlLogin.Controls.Add(linkForgotPassword);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(linkToRegister);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(30, 20);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(464, 481);
            pnlLogin.TabIndex = 0;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLoginTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblLoginTitle.Location = new Point(15, 25);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(236, 30);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.Text = "Đăng Nhập Tài Khoản";
            // 
            // lblLoginSubtitle
            // 
            lblLoginSubtitle.AutoSize = true;
            lblLoginSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblLoginSubtitle.ForeColor = Color.FromArgb(117, 117, 117);
            lblLoginSubtitle.Location = new Point(17, 62);
            lblLoginSubtitle.Name = "lblLoginSubtitle";
            lblLoginSubtitle.Size = new Size(245, 17);
            lblLoginSubtitle.TabIndex = 1;
            lblLoginSubtitle.Text = "Vui lòng nhập thông tin để vào hệ thống";
            // 
            // lblLoginUser
            // 
            lblLoginUser.AutoSize = true;
            lblLoginUser.Font = new Font("Segoe UI", 9.5F);
            lblLoginUser.Location = new Point(17, 105);
            lblLoginUser.Name = "lblLoginUser";
            lblLoginUser.Size = new Size(235, 17);
            lblLoginUser.TabIndex = 2;
            lblLoginUser.Text = "Email / Số điện thoại / Mã Khách Hàng";
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Font = new Font("Segoe UI", 11F);
            txtLoginUsername.Location = new Point(20, 128);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(420, 27);
            txtLoginUsername.TabIndex = 1;
            // 
            // lblLoginPass
            // 
            lblLoginPass.AutoSize = true;
            lblLoginPass.Font = new Font("Segoe UI", 9.5F);
            lblLoginPass.Location = new Point(17, 175);
            lblLoginPass.Name = "lblLoginPass";
            lblLoginPass.Size = new Size(62, 17);
            lblLoginPass.TabIndex = 3;
            lblLoginPass.Text = "Mật khẩu";
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Font = new Font("Segoe UI", 11F);
            txtLoginPassword.Location = new Point(20, 198);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(420, 27);
            txtLoginPassword.TabIndex = 2;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPasswordLogin
            // 
            chkShowPasswordLogin.AutoSize = true;
            chkShowPasswordLogin.Font = new Font("Segoe UI", 9F);
            chkShowPasswordLogin.Location = new Point(20, 240);
            chkShowPasswordLogin.Name = "chkShowPasswordLogin";
            chkShowPasswordLogin.Size = new Size(104, 19);
            chkShowPasswordLogin.TabIndex = 3;
            chkShowPasswordLogin.Text = "Hiện mật khẩu";
            chkShowPasswordLogin.UseVisualStyleBackColor = true;
            chkShowPasswordLogin.CheckedChanged += chkShowPasswordLogin_CheckedChanged;
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Font = new Font("Segoe UI", 9F);
            linkForgotPassword.LinkColor = Color.FromArgb(46, 125, 50);
            linkForgotPassword.Location = new Point(340, 241);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(94, 15);
            linkForgotPassword.TabIndex = 4;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Quên mật khẩu?";
            linkForgotPassword.LinkClicked += linkForgotPassword_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(46, 125, 50);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(20, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(420, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkToRegister
            // 
            linkToRegister.AutoSize = true;
            linkToRegister.Font = new Font("Segoe UI", 9.5F);
            linkToRegister.LinkColor = Color.FromArgb(46, 125, 50);
            linkToRegister.Location = new Point(125, 345);
            linkToRegister.Name = "linkToRegister";
            linkToRegister.Size = new Size(202, 17);
            linkToRegister.TabIndex = 6;
            linkToRegister.TabStop = true;
            linkToRegister.Text = "Chưa có tài khoản? Đăng ký ngay";
            linkToRegister.LinkClicked += linkToRegister_LinkClicked;
            // 
            // pnlRegister
            // 
            pnlRegister.Controls.Add(lblRegTitle);
            pnlRegister.Controls.Add(lblRegSubtitle);
            pnlRegister.Controls.Add(lblRegFullName);
            pnlRegister.Controls.Add(txtRegFullName);
            pnlRegister.Controls.Add(lblRegPhone);
            pnlRegister.Controls.Add(txtRegPhone);
            pnlRegister.Controls.Add(lblRegUser);
            pnlRegister.Controls.Add(txtRegUsername);
            pnlRegister.Controls.Add(lblRegPass);
            pnlRegister.Controls.Add(txtRegPassword);
            pnlRegister.Controls.Add(lblRegConfirmPass);
            pnlRegister.Controls.Add(txtRegConfirmPassword);
            pnlRegister.Controls.Add(btnRegister);
            pnlRegister.Controls.Add(linkBackToLoginFromReg);
            pnlRegister.Dock = DockStyle.Fill;
            pnlRegister.Location = new Point(30, 20);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(464, 481);
            pnlRegister.TabIndex = 1;
            pnlRegister.Visible = false;
            // 
            // lblRegTitle
            // 
            lblRegTitle.AutoSize = true;
            lblRegTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblRegTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblRegTitle.Location = new Point(15, 10);
            lblRegTitle.Name = "lblRegTitle";
            lblRegTitle.Size = new Size(190, 28);
            lblRegTitle.TabIndex = 0;
            lblRegTitle.Text = "Đăng Ký Tài Khoản";
            // 
            // lblRegSubtitle
            // 
            lblRegSubtitle.AutoSize = true;
            lblRegSubtitle.Font = new Font("Segoe UI", 9F);
            lblRegSubtitle.ForeColor = Color.FromArgb(117, 117, 117);
            lblRegSubtitle.Location = new Point(17, 40);
            lblRegSubtitle.Name = "lblRegSubtitle";
            lblRegSubtitle.Size = new Size(241, 15);
            lblRegSubtitle.TabIndex = 1;
            lblRegSubtitle.Text = "Tạo tài khoản đặt sân thể thao nhanh chóng";
            // 
            // lblRegFullName
            // 
            lblRegFullName.AutoSize = true;
            lblRegFullName.Font = new Font("Segoe UI", 8.5F);
            lblRegFullName.Location = new Point(17, 68);
            lblRegFullName.Name = "lblRegFullName";
            lblRegFullName.Size = new Size(58, 15);
            lblRegFullName.TabIndex = 2;
            lblRegFullName.Text = "Họ và tên";
            // 
            // txtRegFullName
            // 
            txtRegFullName.Font = new Font("Segoe UI", 10F);
            txtRegFullName.Location = new Point(20, 88);
            txtRegFullName.Name = "txtRegFullName";
            txtRegFullName.Size = new Size(420, 25);
            txtRegFullName.TabIndex = 1;
            // 
            // lblRegPhone
            // 
            lblRegPhone.AutoSize = true;
            lblRegPhone.Font = new Font("Segoe UI", 8.5F);
            lblRegPhone.Location = new Point(17, 122);
            lblRegPhone.Name = "lblRegPhone";
            lblRegPhone.Size = new Size(76, 15);
            lblRegPhone.TabIndex = 3;
            lblRegPhone.Text = "Số điện thoại";
            // 
            // txtRegPhone
            // 
            txtRegPhone.Font = new Font("Segoe UI", 10F);
            txtRegPhone.Location = new Point(20, 142);
            txtRegPhone.Name = "txtRegPhone";
            txtRegPhone.Size = new Size(420, 25);
            txtRegPhone.TabIndex = 2;
            // 
            // lblRegUser
            // 
            // Đổi nhãn từ "Tên đăng nhập" sang "Gmail / Email"
            this.lblRegUser.AutoSize = true;
            this.lblRegUser.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRegUser.Location = new System.Drawing.Point(17, 178);
            this.lblRegUser.Name = "lblRegUser";
            this.lblRegUser.Size = new System.Drawing.Size(89, 15);
            this.lblRegUser.TabIndex = 3;
            this.lblRegUser.Text = "Gmail / Email"; // <-- Sửa tại đây

            // Ô nhập Gmail (vẫn dùng biến txtRegUsername để không phải đổi khai báo)
            this.txtRegUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRegUsername.Location = new System.Drawing.Point(20, 198);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.PlaceholderText = "example@gmail.com"; // <-- Bổ sung gợi ý nhập Gmail
            this.txtRegUsername.Size = new System.Drawing.Size(420, 25);
            this.txtRegUsername.TabIndex = 3;
            // 
            // txtRegUsername
            // 
            txtRegUsername.Font = new Font("Segoe UI", 10F);
            txtRegUsername.Location = new Point(20, 198);
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.Size = new Size(420, 25);
            txtRegUsername.TabIndex = 3;
            // 
            // lblRegPass
            // 
            lblRegPass.AutoSize = true;
            lblRegPass.Font = new Font("Segoe UI", 8.5F);
            lblRegPass.Location = new Point(17, 233);
            lblRegPass.Name = "lblRegPass";
            lblRegPass.Size = new Size(57, 15);
            lblRegPass.TabIndex = 5;
            lblRegPass.Text = "Mật khẩu";
            // 
            // txtRegPassword
            // 
            txtRegPassword.Font = new Font("Segoe UI", 10F);
            txtRegPassword.Location = new Point(20, 253);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.Size = new Size(420, 25);
            txtRegPassword.TabIndex = 4;
            txtRegPassword.UseSystemPasswordChar = true;
            // 
            // lblRegConfirmPass
            // 
            lblRegConfirmPass.AutoSize = true;
            lblRegConfirmPass.Font = new Font("Segoe UI", 8.5F);
            lblRegConfirmPass.Location = new Point(17, 288);
            lblRegConfirmPass.Name = "lblRegConfirmPass";
            lblRegConfirmPass.Size = new Size(109, 15);
            lblRegConfirmPass.TabIndex = 6;
            lblRegConfirmPass.Text = "Xác nhận mật khẩu";
            // 
            // txtRegConfirmPassword
            // 
            txtRegConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtRegConfirmPassword.Location = new Point(20, 308);
            txtRegConfirmPassword.Name = "txtRegConfirmPassword";
            txtRegConfirmPassword.Size = new Size(420, 25);
            txtRegConfirmPassword.TabIndex = 5;
            txtRegConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(46, 125, 50);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(20, 355);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(420, 40);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "ĐĂNG KÝ";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // linkBackToLoginFromReg
            // 
            linkBackToLoginFromReg.AutoSize = true;
            linkBackToLoginFromReg.Font = new Font("Segoe UI", 9.5F);
            linkBackToLoginFromReg.LinkColor = Color.FromArgb(46, 125, 50);
            linkBackToLoginFromReg.Location = new Point(120, 415);
            linkBackToLoginFromReg.Name = "linkBackToLoginFromReg";
            linkBackToLoginFromReg.Size = new Size(238, 17);
            linkBackToLoginFromReg.TabIndex = 7;
            linkBackToLoginFromReg.TabStop = true;
            linkBackToLoginFromReg.Text = "← Đã có tài khoản? Quay lại đăng nhập";
            linkBackToLoginFromReg.LinkClicked += linkBackToLogin_LinkClicked;
            // 
            // pnlForgotPassword
            // 
            pnlForgotPassword.Controls.Add(lblForgotTitle);
            pnlForgotPassword.Controls.Add(lblForgotSubtitle);
            pnlForgotPassword.Controls.Add(lblForgotAccount);
            pnlForgotPassword.Controls.Add(txtForgotAccount);
            pnlForgotPassword.Controls.Add(lblForgotNewPass);
            pnlForgotPassword.Controls.Add(txtForgotNewPass);
            pnlForgotPassword.Controls.Add(lblForgotConfirmPass);
            pnlForgotPassword.Controls.Add(txtForgotConfirmPass);
            pnlForgotPassword.Controls.Add(btnResetPassword);
            pnlForgotPassword.Controls.Add(linkBackToLoginFromForgot);
            pnlForgotPassword.Dock = DockStyle.Fill;
            pnlForgotPassword.Location = new Point(30, 20);
            pnlForgotPassword.Name = "pnlForgotPassword";
            pnlForgotPassword.Size = new Size(464, 481);
            pnlForgotPassword.TabIndex = 2;
            pnlForgotPassword.Visible = false;
            // 
            // lblForgotTitle
            // 
            lblForgotTitle.AutoSize = true;
            lblForgotTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblForgotTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblForgotTitle.Location = new Point(15, 20);
            lblForgotTitle.Name = "lblForgotTitle";
            lblForgotTitle.Size = new Size(222, 30);
            lblForgotTitle.TabIndex = 0;
            lblForgotTitle.Text = "Khôi Phục Mật Khẩu";
            // 
            // lblForgotSubtitle
            // 
            lblForgotSubtitle.AutoSize = true;
            lblForgotSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblForgotSubtitle.ForeColor = Color.FromArgb(117, 117, 117);
            lblForgotSubtitle.Location = new Point(17, 55);
            lblForgotSubtitle.Name = "lblForgotSubtitle";
            lblForgotSubtitle.Size = new Size(303, 17);
            lblForgotSubtitle.TabIndex = 1;
            lblForgotSubtitle.Text = "Nhập tài khoản để thiết lập mật khẩu mới trực tiếp";
            // 
            // lblForgotAccount
            // 
            lblForgotAccount.AutoSize = true;
            lblForgotAccount.Font = new Font("Segoe UI", 9.5F);
            lblForgotAccount.Location = new Point(17, 95);
            lblForgotAccount.Name = "lblForgotAccount";
            lblForgotAccount.Size = new Size(229, 17);
            lblForgotAccount.TabIndex = 1;
            lblForgotAccount.Text = "Email / Số điện thoại / Tên đăng nhập";
            // 
            // txtForgotAccount
            // 
            txtForgotAccount.Font = new Font("Segoe UI", 11F);
            txtForgotAccount.Location = new Point(20, 118);
            txtForgotAccount.Name = "txtForgotAccount";
            txtForgotAccount.Size = new Size(420, 27);
            txtForgotAccount.TabIndex = 2;
            // 
            // lblForgotNewPass
            // 
            lblForgotNewPass.AutoSize = true;
            lblForgotNewPass.Font = new Font("Segoe UI", 9.5F);
            lblForgotNewPass.Location = new Point(17, 165);
            lblForgotNewPass.Name = "lblForgotNewPass";
            lblForgotNewPass.Size = new Size(88, 17);
            lblForgotNewPass.TabIndex = 3;
            lblForgotNewPass.Text = "Mật khẩu mới";
            // 
            // txtForgotNewPass
            // 
            txtForgotNewPass.Font = new Font("Segoe UI", 11F);
            txtForgotNewPass.Location = new Point(20, 188);
            txtForgotNewPass.Name = "txtForgotNewPass";
            txtForgotNewPass.Size = new Size(420, 27);
            txtForgotNewPass.TabIndex = 4;
            txtForgotNewPass.UseSystemPasswordChar = true;
            // 
            // lblForgotConfirmPass
            // 
            lblForgotConfirmPass.AutoSize = true;
            lblForgotConfirmPass.Font = new Font("Segoe UI", 9.5F);
            lblForgotConfirmPass.Location = new Point(17, 235);
            lblForgotConfirmPass.Name = "lblForgotConfirmPass";
            lblForgotConfirmPass.Size = new Size(144, 17);
            lblForgotConfirmPass.TabIndex = 5;
            lblForgotConfirmPass.Text = "Xác nhận mật khẩu mới";
            // 
            // txtForgotConfirmPass
            // 
            txtForgotConfirmPass.Font = new Font("Segoe UI", 11F);
            txtForgotConfirmPass.Location = new Point(20, 258);
            txtForgotConfirmPass.Name = "txtForgotConfirmPass";
            txtForgotConfirmPass.Size = new Size(420, 27);
            txtForgotConfirmPass.TabIndex = 6;
            txtForgotConfirmPass.UseSystemPasswordChar = true;
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.FromArgb(46, 125, 50);
            btnResetPassword.Cursor = Cursors.Hand;
            btnResetPassword.FlatAppearance.BorderSize = 0;
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(20, 310);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(420, 42);
            btnResetPassword.TabIndex = 7;
            btnResetPassword.Text = "ĐỔI MẬT KHẨU";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // linkBackToLoginFromForgot
            // 
            linkBackToLoginFromForgot.AutoSize = true;
            linkBackToLoginFromForgot.Font = new Font("Segoe UI", 9.5F);
            linkBackToLoginFromForgot.LinkColor = Color.FromArgb(46, 125, 50);
            linkBackToLoginFromForgot.Location = new Point(145, 370);
            linkBackToLoginFromForgot.Name = "linkBackToLoginFromForgot";
            linkBackToLoginFromForgot.Size = new Size(172, 17);
            linkBackToLoginFromForgot.TabIndex = 8;
            linkBackToLoginFromForgot.TabStop = true;
            linkBackToLoginFromForgot.Text = "← Quay lại trang đăng nhập";
            linkBackToLoginFromForgot.LinkClicked += linkBackToLogin_LinkClicked;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 521);
            Controls.Add(pnlContainer);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Quản Lý Đặt Sân - Xác Thực";
            pnlSidebar.ResumeLayout(false);
            pnlContainer.ResumeLayout(false);
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            pnlForgotPassword.ResumeLayout(false);
            pnlForgotPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // KHAI BÁO BIẾN THÀNH VIÊN
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSidebarDesc;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Label lblSidebarLogo;
        private System.Windows.Forms.Panel pnlContainer;

        // Login Controls
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblLoginSubtitle;
        private System.Windows.Forms.Label lblLoginUser;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.Label lblLoginPass;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.CheckBox chkShowPasswordLogin;
        private System.Windows.Forms.LinkLabel linkForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkToRegister;

        // Register Controls
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Label lblRegTitle;
        private System.Windows.Forms.Label lblRegSubtitle;
        private System.Windows.Forms.Label lblRegFullName;
        private System.Windows.Forms.TextBox txtRegFullName;
        private System.Windows.Forms.Label lblRegPhone;
        private System.Windows.Forms.TextBox txtRegPhone;
        private System.Windows.Forms.Label lblRegUser;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.Label lblRegPass;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.Label lblRegConfirmPass;
        private System.Windows.Forms.TextBox txtRegConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel linkBackToLoginFromReg;

        // Forgot / Reset Password Controls (Đã bỏ OTP)
        private System.Windows.Forms.Panel pnlForgotPassword;
        private System.Windows.Forms.Label lblForgotTitle;
        private System.Windows.Forms.Label lblForgotSubtitle;
        private System.Windows.Forms.Label lblForgotAccount;
        private System.Windows.Forms.TextBox txtForgotAccount;
        private System.Windows.Forms.Label lblForgotNewPass;
        private System.Windows.Forms.TextBox txtForgotNewPass;
        private System.Windows.Forms.Label lblForgotConfirmPass;
        private System.Windows.Forms.TextBox txtForgotConfirmPass;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.LinkLabel linkBackToLoginFromForgot;
    }
}