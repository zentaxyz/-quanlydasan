namespace quanlydatsan
{
    partial class test
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
            // 1. KHỞI TẠO TẤT CẢ CONTROLS
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarDesc = new System.Windows.Forms.Label();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.lblSidebarLogo = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();

            // Login Controls
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblLoginSubtitle = new System.Windows.Forms.Label();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.lblLoginPass = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.chkShowPasswordLogin = new System.Windows.Forms.CheckBox();
            this.linkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkToRegister = new System.Windows.Forms.LinkLabel();

            // Register Controls
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.lblRegTitle = new System.Windows.Forms.Label();
            this.lblRegSubtitle = new System.Windows.Forms.Label();
            this.lblRegFullName = new System.Windows.Forms.Label();
            this.txtRegFullName = new System.Windows.Forms.TextBox();
            this.lblRegPhone = new System.Windows.Forms.Label();
            this.txtRegPhone = new System.Windows.Forms.TextBox();
            this.lblRegUser = new System.Windows.Forms.Label();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.lblRegPass = new System.Windows.Forms.Label();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.lblRegConfirmPass = new System.Windows.Forms.Label();
            this.txtRegConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.linkBackToLoginFromReg = new System.Windows.Forms.LinkLabel();

            // Forgot / Reset Password Controls (Không OTP)
            this.pnlForgotPassword = new System.Windows.Forms.Panel();
            this.lblForgotTitle = new System.Windows.Forms.Label();
            this.lblForgotSubtitle = new System.Windows.Forms.Label();
            this.lblForgotAccount = new System.Windows.Forms.Label();
            this.txtForgotAccount = new System.Windows.Forms.TextBox();
            this.lblForgotNewPass = new System.Windows.Forms.Label();
            this.txtForgotNewPass = new System.Windows.Forms.TextBox();
            this.lblForgotConfirmPass = new System.Windows.Forms.Label();
            this.txtForgotConfirmPass = new System.Windows.Forms.TextBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.linkBackToLoginFromForgot = new System.Windows.Forms.LinkLabel();

            this.pnlSidebar.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.pnlForgotPassword.SuspendLayout();
            this.SuspendLayout();

            // ==========================================
            // SIDEBAR TRÁI
            // ==========================================
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.pnlSidebar.Controls.Add(this.lblSidebarDesc);
            this.pnlSidebar.Controls.Add(this.lblSidebarTitle);
            this.pnlSidebar.Controls.Add(this.lblSidebarLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(280, 521);
            this.pnlSidebar.TabIndex = 0;

            this.lblSidebarLogo.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.lblSidebarLogo.ForeColor = System.Drawing.Color.White;
            this.lblSidebarLogo.Location = new System.Drawing.Point(12, 35);
            this.lblSidebarLogo.Name = "lblSidebarLogo";
            this.lblSidebarLogo.Size = new System.Drawing.Size(256, 85);
            this.lblSidebarLogo.TabIndex = 0;
            this.lblSidebarLogo.Text = "⚽ 🏸";
            this.lblSidebarLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.White;
            this.lblSidebarTitle.Location = new System.Drawing.Point(12, 135);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.Size = new System.Drawing.Size(256, 60);
            this.lblSidebarTitle.TabIndex = 1;
            this.lblSidebarTitle.Text = "SPORT ARENA\nQUẢN LÝ ĐẶT SÂN";
            this.lblSidebarTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            this.lblSidebarDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSidebarDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.lblSidebarDesc.Location = new System.Drawing.Point(20, 210);
            this.lblSidebarDesc.Name = "lblSidebarDesc";
            this.lblSidebarDesc.Size = new System.Drawing.Size(240, 80);
            this.lblSidebarDesc.TabIndex = 2;
            this.lblSidebarDesc.Text = "Hệ thống quản lý và đặt sân thể thao chuyên nghiệp, nhanh chóng và tiện lợi.";
            this.lblSidebarDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // ==========================================
            // CONTAINER CHÍNH
            // ==========================================
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Controls.Add(this.pnlLogin);
            this.pnlContainer.Controls.Add(this.pnlRegister);
            this.pnlContainer.Controls.Add(this.pnlForgotPassword);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(280, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.pnlContainer.Size = new System.Drawing.Size(524, 521);
            this.pnlContainer.TabIndex = 1;

            // ==========================================
            // PANEL ĐĂNG NHẬP
            // ==========================================
            this.pnlLogin.Controls.Add(this.lblLoginTitle);
            this.pnlLogin.Controls.Add(this.lblLoginSubtitle);
            this.pnlLogin.Controls.Add(this.lblLoginUser);
            this.pnlLogin.Controls.Add(this.txtLoginUsername);
            this.pnlLogin.Controls.Add(this.lblLoginPass);
            this.pnlLogin.Controls.Add(this.txtLoginPassword);
            this.pnlLogin.Controls.Add(this.chkShowPasswordLogin);
            this.pnlLogin.Controls.Add(this.linkForgotPassword);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.linkToRegister);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(30, 20);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(464, 481);
            this.pnlLogin.TabIndex = 0;

            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(15, 25);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(248, 30);
            this.lblLoginTitle.Text = "Đăng Nhập Tài Khoản";

            this.lblLoginSubtitle.AutoSize = true;
            this.lblLoginSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLoginSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lblLoginSubtitle.Location = new System.Drawing.Point(17, 62);
            this.lblLoginSubtitle.Name = "lblLoginSubtitle";
            this.lblLoginSubtitle.Size = new System.Drawing.Size(263, 17);
            this.lblLoginSubtitle.Text = "Vui lòng nhập thông tin để vào hệ thống";

            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLoginUser.Location = new System.Drawing.Point(17, 105);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(232, 17);
            this.lblLoginUser.Text = "Email / Số điện thoại / Tên đăng nhập";

            this.txtLoginUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtLoginUsername.Location = new System.Drawing.Point(20, 128);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(420, 27);
            this.txtLoginUsername.TabIndex = 1;

            this.lblLoginPass.AutoSize = true;
            this.lblLoginPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLoginPass.Location = new System.Drawing.Point(17, 175);
            this.lblLoginPass.Name = "lblLoginPass";
            this.lblLoginPass.Size = new System.Drawing.Size(62, 17);
            this.lblLoginPass.Text = "Mật khẩu";

            this.txtLoginPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtLoginPassword.Location = new System.Drawing.Point(20, 198);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(420, 27);
            this.txtLoginPassword.TabIndex = 2;
            this.txtLoginPassword.UseSystemPasswordChar = true;

            this.chkShowPasswordLogin.AutoSize = true;
            this.chkShowPasswordLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowPasswordLogin.Location = new System.Drawing.Point(20, 240);
            this.chkShowPasswordLogin.Name = "chkShowPasswordLogin";
            this.chkShowPasswordLogin.Size = new System.Drawing.Size(104, 19);
            this.chkShowPasswordLogin.TabIndex = 3;
            this.chkShowPasswordLogin.Text = "Hiện mật khẩu";
            this.chkShowPasswordLogin.UseVisualStyleBackColor = true;
            this.chkShowPasswordLogin.CheckedChanged += new System.EventHandler(this.chkShowPasswordLogin_CheckedChanged);

            this.linkForgotPassword.AutoSize = true;
            this.linkForgotPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.linkForgotPassword.Location = new System.Drawing.Point(340, 241);
            this.linkForgotPassword.Name = "linkForgotPassword";
            this.linkForgotPassword.Size = new System.Drawing.Size(94, 15);
            this.linkForgotPassword.TabIndex = 4;
            this.linkForgotPassword.TabStop = true;
            this.linkForgotPassword.Text = "Quên mật khẩu?";
            this.linkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPassword_LinkClicked);

            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(20, 280);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(420, 42);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.linkToRegister.AutoSize = true;
            this.linkToRegister.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.linkToRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.linkToRegister.Location = new System.Drawing.Point(125, 345);
            this.linkToRegister.Name = "linkToRegister";
            this.linkToRegister.Size = new System.Drawing.Size(199, 17);
            this.linkToRegister.TabIndex = 6;
            this.linkToRegister.TabStop = true;
            this.linkToRegister.Text = "Chưa có tài khoản? Đăng ký ngay";
            this.linkToRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToRegister_LinkClicked);

            // ==========================================
            // PANEL ĐĂNG KÝ
            // ==========================================
            this.pnlRegister.Controls.Add(this.lblRegTitle);
            this.pnlRegister.Controls.Add(this.lblRegSubtitle);
            this.pnlRegister.Controls.Add(this.lblRegFullName);
            this.pnlRegister.Controls.Add(this.txtRegFullName);
            this.pnlRegister.Controls.Add(this.lblRegPhone);
            this.pnlRegister.Controls.Add(this.txtRegPhone);
            this.pnlRegister.Controls.Add(this.lblRegUser);
            this.pnlRegister.Controls.Add(this.txtRegUsername);
            this.pnlRegister.Controls.Add(this.lblRegPass);
            this.pnlRegister.Controls.Add(this.txtRegPassword);
            this.pnlRegister.Controls.Add(this.lblRegConfirmPass);
            this.pnlRegister.Controls.Add(this.txtRegConfirmPassword);
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.linkBackToLoginFromReg);
            this.pnlRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegister.Location = new System.Drawing.Point(30, 20);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(464, 481);
            this.pnlRegister.TabIndex = 1;
            this.pnlRegister.Visible = false;

            this.lblRegTitle.AutoSize = true;
            this.lblRegTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblRegTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblRegTitle.Location = new System.Drawing.Point(15, 10);
            this.lblRegTitle.Name = "lblRegTitle";
            this.lblRegTitle.Size = new System.Drawing.Size(189, 28);
            this.lblRegTitle.Text = "Đăng Ký Tài Khoản";

            this.lblRegSubtitle.AutoSize = true;
            this.lblRegSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRegSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lblRegSubtitle.Location = new System.Drawing.Point(17, 40);
            this.lblRegSubtitle.Name = "lblRegSubtitle";
            this.lblRegSubtitle.Size = new System.Drawing.Size(232, 15);
            this.lblRegSubtitle.Text = "Tạo tài khoản đặt sân thể thao nhanh chóng";

            this.lblRegFullName.AutoSize = true;
            this.lblRegFullName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRegFullName.Location = new System.Drawing.Point(17, 68);
            this.lblRegFullName.Name = "lblRegFullName";
            this.lblRegFullName.Size = new System.Drawing.Size(58, 15);
            this.lblRegFullName.Text = "Họ và tên";

            this.txtRegFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRegFullName.Location = new System.Drawing.Point(20, 88);
            this.txtRegFullName.Name = "txtRegFullName";
            this.txtRegFullName.Size = new System.Drawing.Size(420, 25);
            this.txtRegFullName.TabIndex = 1;

            this.lblRegPhone.AutoSize = true;
            this.lblRegPhone.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRegPhone.Location = new System.Drawing.Point(17, 122);
            this.lblRegPhone.Name = "lblRegPhone";
            this.lblRegPhone.Size = new System.Drawing.Size(76, 15);
            this.lblRegPhone.Text = "Số điện thoại";

            this.txtRegPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRegPhone.Location = new System.Drawing.Point(20, 142);
            this.txtRegPhone.Name = "txtRegPhone";
            this.txtRegPhone.Size = new System.Drawing.Size(420, 25);
            this.txtRegPhone.TabIndex = 2;

            this.lblRegUser.AutoSize = true;
            this.lblRegUser.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRegUser.Location = new System.Drawing.Point(17, 178);
            this.lblRegUser.Name = "lblRegUser";
            this.lblRegUser.Size = new System.Drawing.Size(86, 15);
            this.lblRegUser.Text = "Tên đăng nhập";

            this.txtRegUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRegUsername.Location = new System.Drawing.Point(20, 198);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(420, 25);
            this.txtRegUsername.TabIndex = 3;

            this.lblRegPass.AutoSize = true;
            this.lblRegPass.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRegPass.Location = new System.Drawing.Point(17, 233);
            this.lblRegPass.Name = "lblRegPass";
            this.lblRegPass.Size = new System.Drawing.Size(57, 15);
            this.lblRegPass.Text = "Mật khẩu";

            this.txtRegPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRegPassword.Location = new System.Drawing.Point(20, 253);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(420, 25);
            this.txtRegPassword.TabIndex = 4;
            this.txtRegPassword.UseSystemPasswordChar = true;

            this.lblRegConfirmPass.AutoSize = true;
            this.lblRegConfirmPass.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRegConfirmPass.Location = new System.Drawing.Point(17, 288);
            this.lblRegConfirmPass.Name = "lblRegConfirmPass";
            this.lblRegConfirmPass.Size = new System.Drawing.Size(109, 15);
            this.lblRegConfirmPass.Text = "Xác nhận mật khẩu";

            this.txtRegConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRegConfirmPassword.Location = new System.Drawing.Point(20, 308);
            this.txtRegConfirmPassword.Name = "txtRegConfirmPassword";
            this.txtRegConfirmPassword.Size = new System.Drawing.Size(420, 25);
            this.txtRegConfirmPassword.TabIndex = 5;
            this.txtRegConfirmPassword.UseSystemPasswordChar = true;

            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(20, 355);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(420, 40);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "ĐĂNG KÝ";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            this.linkBackToLoginFromReg.AutoSize = true;
            this.linkBackToLoginFromReg.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.linkBackToLoginFromReg.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.linkBackToLoginFromReg.Location = new System.Drawing.Point(120, 415);
            this.linkBackToLoginFromReg.Name = "linkBackToLoginFromReg";
            this.linkBackToLoginFromReg.Size = new System.Drawing.Size(225, 17);
            this.linkBackToLoginFromReg.TabIndex = 7;
            this.linkBackToLoginFromReg.TabStop = true;
            this.linkBackToLoginFromReg.Text = "← Đã có tài khoản? Quay lại đăng nhập";
            this.linkBackToLoginFromReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBackToLogin_LinkClicked);

            // ==========================================
            // PANEL QUÊN / ĐỔI MẬT KHẨU (KHÔNG DÙNG OTP)
            // ==========================================
            this.pnlForgotPassword.Controls.Add(this.lblForgotTitle);
            this.pnlForgotPassword.Controls.Add(this.lblForgotSubtitle);
            this.pnlForgotPassword.Controls.Add(this.lblForgotAccount);
            this.pnlForgotPassword.Controls.Add(this.txtForgotAccount);
            this.pnlForgotPassword.Controls.Add(this.lblForgotNewPass);
            this.pnlForgotPassword.Controls.Add(this.txtForgotNewPass);
            this.pnlForgotPassword.Controls.Add(this.lblForgotConfirmPass);
            this.pnlForgotPassword.Controls.Add(this.txtForgotConfirmPass);
            this.pnlForgotPassword.Controls.Add(this.btnResetPassword);
            this.pnlForgotPassword.Controls.Add(this.linkBackToLoginFromForgot);
            this.pnlForgotPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForgotPassword.Location = new System.Drawing.Point(30, 20);
            this.pnlForgotPassword.Name = "pnlForgotPassword";
            this.pnlForgotPassword.Size = new System.Drawing.Size(464, 481);
            this.pnlForgotPassword.TabIndex = 2;
            this.pnlForgotPassword.Visible = false;

            this.lblForgotTitle.AutoSize = true;
            this.lblForgotTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblForgotTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblForgotTitle.Location = new System.Drawing.Point(15, 20);
            this.lblForgotTitle.Name = "lblForgotTitle";
            this.lblForgotTitle.Size = new System.Drawing.Size(224, 30);
            this.lblForgotTitle.Text = "Khôi Phục Mật Khẩu";

            this.lblForgotSubtitle.AutoSize = true;
            this.lblForgotSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblForgotSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lblForgotSubtitle.Location = new System.Drawing.Point(17, 55);
            this.lblForgotSubtitle.Name = "lblForgotSubtitle";
            this.lblForgotSubtitle.Size = new System.Drawing.Size(287, 17);
            this.lblForgotSubtitle.Text = "Nhập tài khoản để thiết lập mật khẩu mới trực tiếp";

            // Tài khoản cần đổi (Email / SĐT / Username)
            this.lblForgotAccount.AutoSize = true;
            this.lblForgotAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblForgotAccount.Location = new System.Drawing.Point(17, 95);
            this.lblForgotAccount.Name = "lblForgotAccount";
            this.lblForgotAccount.Size = new System.Drawing.Size(232, 17);
            this.lblForgotAccount.TabIndex = 1;
            this.lblForgotAccount.Text = "Email / Số điện thoại / Tên đăng nhập";

            this.txtForgotAccount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtForgotAccount.Location = new System.Drawing.Point(20, 118);
            this.txtForgotAccount.Name = "txtForgotAccount";
            this.txtForgotAccount.Size = new System.Drawing.Size(420, 27);
            this.txtForgotAccount.TabIndex = 2;

            // Mật khẩu mới
            this.lblForgotNewPass.AutoSize = true;
            this.lblForgotNewPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblForgotNewPass.Location = new System.Drawing.Point(17, 165);
            this.lblForgotNewPass.Name = "lblForgotNewPass";
            this.lblForgotNewPass.Size = new System.Drawing.Size(88, 17);
            this.lblForgotNewPass.TabIndex = 3;
            this.lblForgotNewPass.Text = "Mật khẩu mới";

            this.txtForgotNewPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtForgotNewPass.Location = new System.Drawing.Point(20, 188);
            this.txtForgotNewPass.Name = "txtForgotNewPass";
            this.txtForgotNewPass.Size = new System.Drawing.Size(420, 27);
            this.txtForgotNewPass.TabIndex = 4;
            this.txtForgotNewPass.UseSystemPasswordChar = true;

            // Xác nhận mật khẩu mới
            this.lblForgotConfirmPass.AutoSize = true;
            this.lblForgotConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblForgotConfirmPass.Location = new System.Drawing.Point(17, 235);
            this.lblForgotConfirmPass.Name = "lblForgotConfirmPass";
            this.lblForgotConfirmPass.Size = new System.Drawing.Size(144, 17);
            this.lblForgotConfirmPass.TabIndex = 5;
            this.lblForgotConfirmPass.Text = "Xác nhận mật khẩu mới";

            this.txtForgotConfirmPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtForgotConfirmPass.Location = new System.Drawing.Point(20, 258);
            this.txtForgotConfirmPass.Name = "txtForgotConfirmPass";
            this.txtForgotConfirmPass.Size = new System.Drawing.Size(420, 27);
            this.txtForgotConfirmPass.TabIndex = 6;
            this.txtForgotConfirmPass.UseSystemPasswordChar = true;

            // Nút Xác nhận đổi mật khẩu
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(20, 310);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(420, 42);
            this.btnResetPassword.TabIndex = 7;
            this.btnResetPassword.Text = "ĐỔI MẬT KHẨU";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);

            // Link quay lại Đăng nhập
            this.linkBackToLoginFromForgot.AutoSize = true;
            this.linkBackToLoginFromForgot.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.linkBackToLoginFromForgot.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.linkBackToLoginFromForgot.Location = new System.Drawing.Point(145, 370);
            this.linkBackToLoginFromForgot.Name = "linkBackToLoginFromForgot";
            this.linkBackToLoginFromForgot.Size = new System.Drawing.Size(176, 17);
            this.linkBackToLoginFromForgot.TabIndex = 8;
            this.linkBackToLoginFromForgot.TabStop = true;
            this.linkBackToLoginFromForgot.Text = "← Quay lại trang đăng nhập";
            this.linkBackToLoginFromForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBackToLogin_LinkClicked);

            // ==========================================
            // FORM CHÍNH
            // ==========================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 521);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Đặt Sân - Xác Thực";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.pnlForgotPassword.ResumeLayout(false);
            this.pnlForgotPassword.PerformLayout();
            this.ResumeLayout(false);
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