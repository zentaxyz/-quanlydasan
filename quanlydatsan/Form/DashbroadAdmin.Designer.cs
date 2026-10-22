namespace quanlydatsan
{
    partial class DashbroadAdmin
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
            btnTK = new Button();
            btnBC = new Button();
            btnQLLĐ = new Button();
            btnQLLS = new Button();
            btnLogout = new Button();
            btnNLe = new Button();
            btnQLKH = new Button();
            btnPĐS = new Button();
            btnDSS = new Button();
            btnDashboard = new Button();
            pnlAdminProfile = new Panel();
            lblAdminRole = new Label();
            lblAdminName = new Label();
            lblAdminAvatar = new Label();
            pnlBrand = new Panel();
            lblBrandSub = new Label();
            lblBrand = new Label();
            pnlHeader = new Panel();
            lblTime = new Label();
            lblTitle = new Label();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            pnlAdminProfile.SuspendLayout();
            pnlBrand.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(15, 23, 42);
            pnlSidebar.Controls.Add(btnTK);
            pnlSidebar.Controls.Add(btnBC);
            pnlSidebar.Controls.Add(btnQLLĐ);
            pnlSidebar.Controls.Add(btnQLLS);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnNLe);
            pnlSidebar.Controls.Add(btnQLKH);
            pnlSidebar.Controls.Add(btnPĐS);
            pnlSidebar.Controls.Add(btnDSS);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(pnlAdminProfile);
            pnlSidebar.Controls.Add(pnlBrand);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 761);
            pnlSidebar.TabIndex = 0;
            // 
            // btnTK
            // 
            btnTK.Cursor = Cursors.Hand;
            btnTK.Dock = DockStyle.Top;
            btnTK.FlatAppearance.BorderSize = 0;
            btnTK.FlatStyle = FlatStyle.Flat;
            btnTK.Font = new Font("Segoe UI", 10.5F);
            btnTK.ForeColor = Color.FromArgb(226, 232, 240);
            btnTK.Location = new Point(0, 600);
            btnTK.Name = "btnTK";
            btnTK.Padding = new Padding(25, 0, 0, 0);
            btnTK.Size = new Size(250, 50);
            btnTK.TabIndex = 10;
            btnTK.Text = "👤   Tài Khoản";
            btnTK.TextAlign = ContentAlignment.MiddleLeft;
            btnTK.UseVisualStyleBackColor = true;
            btnTK.Click += btnMenu_Click;
            // 
            // btnBC
            // 
            btnBC.Cursor = Cursors.Hand;
            btnBC.Dock = DockStyle.Top;
            btnBC.FlatAppearance.BorderSize = 0;
            btnBC.FlatStyle = FlatStyle.Flat;
            btnBC.Font = new Font("Segoe UI", 10.5F);
            btnBC.ForeColor = Color.FromArgb(226, 232, 240);
            btnBC.Location = new Point(0, 550);
            btnBC.Name = "btnBC";
            btnBC.Padding = new Padding(25, 0, 0, 0);
            btnBC.Size = new Size(250, 50);
            btnBC.TabIndex = 9;
            btnBC.Text = "📊   Báo Cáo Doanh Thu";
            btnBC.TextAlign = ContentAlignment.MiddleLeft;
            btnBC.UseVisualStyleBackColor = true;
            btnBC.Click += btnMenu_Click;
            // 
            // btnQLLĐ
            // 
            btnQLLĐ.Cursor = Cursors.Hand;
            btnQLLĐ.Dock = DockStyle.Top;
            btnQLLĐ.FlatAppearance.BorderSize = 0;
            btnQLLĐ.FlatStyle = FlatStyle.Flat;
            btnQLLĐ.Font = new Font("Segoe UI", 10.5F);
            btnQLLĐ.ForeColor = Color.FromArgb(226, 232, 240);
            btnQLLĐ.Location = new Point(0, 500);
            btnQLLĐ.Name = "btnQLLĐ";
            btnQLLĐ.Padding = new Padding(25, 0, 0, 0);
            btnQLLĐ.Size = new Size(250, 50);
            btnQLLĐ.TabIndex = 8;
            btnQLLĐ.Text = "🗓️   Quản Lý Lịch Dặt";
            btnQLLĐ.TextAlign = ContentAlignment.MiddleLeft;
            btnQLLĐ.UseVisualStyleBackColor = true;
            btnQLLĐ.Click += btnMenu_Click;
            // 
            // btnQLLS
            // 
            btnQLLS.Cursor = Cursors.Hand;
            btnQLLS.Dock = DockStyle.Top;
            btnQLLS.FlatAppearance.BorderSize = 0;
            btnQLLS.FlatStyle = FlatStyle.Flat;
            btnQLLS.Font = new Font("Segoe UI", 10.5F);
            btnQLLS.ForeColor = Color.FromArgb(226, 232, 240);
            btnQLLS.Location = new Point(0, 450);
            btnQLLS.Name = "btnQLLS";
            btnQLLS.Padding = new Padding(25, 0, 0, 0);
            btnQLLS.Size = new Size(250, 50);
            btnQLLS.TabIndex = 7;
            btnQLLS.Text = "🏷️   Quản Lý Loại sân";
            btnQLLS.TextAlign = ContentAlignment.MiddleLeft;
            btnQLLS.UseVisualStyleBackColor = true;
            btnQLLS.Click += btnMenu_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(220, 38, 38);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 711);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 50);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "🚪  Đăng Xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnNLe
            // 
            btnNLe.Cursor = Cursors.Hand;
            btnNLe.Dock = DockStyle.Top;
            btnNLe.FlatAppearance.BorderSize = 0;
            btnNLe.FlatStyle = FlatStyle.Flat;
            btnNLe.Font = new Font("Segoe UI", 10.5F);
            btnNLe.ForeColor = Color.FromArgb(226, 232, 240);
            btnNLe.Location = new Point(0, 400);
            btnNLe.Name = "btnNLe";
            btnNLe.Padding = new Padding(25, 0, 0, 0);
            btnNLe.Size = new Size(250, 50);
            btnNLe.TabIndex = 5;
            btnNLe.Text = "🎉   Quản lý Ngày Lễ";
            btnNLe.TextAlign = ContentAlignment.MiddleLeft;
            btnNLe.UseVisualStyleBackColor = true;
            btnNLe.Click += btnMenu_Click;
            // 
            // btnQLKH
            // 
            btnQLKH.Cursor = Cursors.Hand;
            btnQLKH.Dock = DockStyle.Top;
            btnQLKH.FlatAppearance.BorderSize = 0;
            btnQLKH.FlatStyle = FlatStyle.Flat;
            btnQLKH.Font = new Font("Segoe UI", 10.5F);
            btnQLKH.ForeColor = Color.FromArgb(226, 232, 240);
            btnQLKH.Location = new Point(0, 350);
            btnQLKH.Name = "btnQLKH";
            btnQLKH.Padding = new Padding(25, 0, 0, 0);
            btnQLKH.Size = new Size(250, 50);
            btnQLKH.TabIndex = 4;
            btnQLKH.Text = "👥   Quản Lý Khách Hàng";
            btnQLKH.TextAlign = ContentAlignment.MiddleLeft;
            btnQLKH.UseVisualStyleBackColor = true;
            btnQLKH.Click += btnMenu_Click;
            // 
            // btnPĐS
            // 
            btnPĐS.Cursor = Cursors.Hand;
            btnPĐS.Dock = DockStyle.Top;
            btnPĐS.FlatAppearance.BorderSize = 0;
            btnPĐS.FlatStyle = FlatStyle.Flat;
            btnPĐS.Font = new Font("Segoe UI", 10.5F);
            btnPĐS.ForeColor = Color.FromArgb(226, 232, 240);
            btnPĐS.Location = new Point(0, 300);
            btnPĐS.Name = "btnPĐS";
            btnPĐS.Padding = new Padding(25, 0, 0, 0);
            btnPĐS.Size = new Size(250, 50);
            btnPĐS.TabIndex = 3;
            btnPĐS.Text = "📑   Quản lý Phiếu Đặt Sân";
            btnPĐS.TextAlign = ContentAlignment.MiddleLeft;
            btnPĐS.UseVisualStyleBackColor = true;
            btnPĐS.Click += btnMenu_Click;
            // 
            // btnDSS
            // 
            btnDSS.Cursor = Cursors.Hand;
            btnDSS.Dock = DockStyle.Top;
            btnDSS.FlatAppearance.BorderSize = 0;
            btnDSS.FlatStyle = FlatStyle.Flat;
            btnDSS.Font = new Font("Segoe UI", 10.5F);
            btnDSS.ForeColor = Color.FromArgb(226, 232, 240);
            btnDSS.Location = new Point(0, 250);
            btnDSS.Name = "btnDSS";
            btnDSS.Padding = new Padding(25, 0, 0, 0);
            btnDSS.Size = new Size(250, 50);
            btnDSS.TabIndex = 2;
            btnDSS.Text = "🏟️   Quản Lý Danh Sách Sân";
            btnDSS.TextAlign = ContentAlignment.MiddleLeft;
            btnDSS.UseVisualStyleBackColor = true;
            btnDSS.Click += btnMenu_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(30, 41, 59);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 200);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(25, 0, 0, 0);
            btnDashboard.Size = new Size(250, 50);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "⚡   Tổng Quan Hệ Thống";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnMenu_Click;
            // 
            // pnlAdminProfile
            // 
            pnlAdminProfile.BackColor = Color.FromArgb(30, 41, 59);
            pnlAdminProfile.Controls.Add(lblAdminRole);
            pnlAdminProfile.Controls.Add(lblAdminName);
            pnlAdminProfile.Controls.Add(lblAdminAvatar);
            pnlAdminProfile.Dock = DockStyle.Top;
            pnlAdminProfile.Location = new Point(0, 75);
            pnlAdminProfile.Name = "pnlAdminProfile";
            pnlAdminProfile.Size = new Size(250, 125);
            pnlAdminProfile.TabIndex = 0;
            // 
            // lblAdminRole
            // 
            lblAdminRole.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblAdminRole.ForeColor = Color.FromArgb(56, 189, 248);
            lblAdminRole.Location = new Point(12, 94);
            lblAdminRole.Name = "lblAdminRole";
            lblAdminRole.Size = new Size(226, 20);
            lblAdminRole.TabIndex = 2;
            lblAdminRole.Text = "QUẢN TRỊ VIÊN HỆ THỐNG";
            lblAdminRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAdminName
            // 
            lblAdminName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAdminName.ForeColor = Color.White;
            lblAdminName.Location = new Point(12, 68);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(226, 24);
            lblAdminName.TabIndex = 1;
            lblAdminName.Text = "Quản Trị Viên";
            lblAdminName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAdminAvatar
            // 
            lblAdminAvatar.Font = new Font("Segoe UI", 32F);
            lblAdminAvatar.ForeColor = Color.White;
            lblAdminAvatar.Location = new Point(90, 8);
            lblAdminAvatar.Name = "lblAdminAvatar";
            lblAdminAvatar.Size = new Size(70, 58);
            lblAdminAvatar.TabIndex = 0;
            lblAdminAvatar.Text = "🛡️";
            lblAdminAvatar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = Color.FromArgb(2, 6, 23);
            pnlBrand.Controls.Add(lblBrandSub);
            pnlBrand.Controls.Add(lblBrand);
            pnlBrand.Dock = DockStyle.Top;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(250, 75);
            pnlBrand.TabIndex = 0;
            // 
            // lblBrandSub
            // 
            lblBrandSub.AutoSize = true;
            lblBrandSub.Font = new Font("Segoe UI", 8F);
            lblBrandSub.ForeColor = Color.FromArgb(148, 163, 184);
            lblBrandSub.Location = new Point(18, 43);
            lblBrandSub.Name = "lblBrandSub";
            lblBrandSub.Size = new Size(130, 13);
            lblBrandSub.TabIndex = 1;
            lblBrandSub.Text = "ADMIN CONTROL PANEL";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(16, 17);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(173, 25);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "🏟️ ARENA ADMIN";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTime);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(250, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(984, 60);
            pnlHeader.TabIndex = 1;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTime.Font = new Font("Segoe UI", 9.5F);
            lblTime.ForeColor = Color.FromArgb(100, 116, 139);
            lblTime.Location = new Point(684, 20);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(280, 20);
            lblTime.TabIndex = 1;
            lblTime.Text = "Hôm nay: ...";
            lblTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(231, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TỔNG QUAN HỆ THỐNG";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(241, 245, 249);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(250, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(20);
            pnlContent.Size = new Size(984, 701);
            pnlContent.TabIndex = 2;
            // 
            // DashbroadAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 761);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(1000, 650);
            Name = "DashbroadAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sport Arena - Quản Trị Hệ Thống";
            Load += DashbroadAdmin_Load;
            pnlSidebar.ResumeLayout(false);
            pnlAdminProfile.ResumeLayout(false);
            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.Panel pnlAdminProfile;
        private System.Windows.Forms.Label lblAdminAvatar;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblAdminRole;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnDSS;
        private System.Windows.Forms.Button btnPĐS;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnNLe;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnlContent;
        private Button btnBC;
        private Button btnQLLĐ;
        private Button btnQLLS;
        private Button btnTK;
    }
}