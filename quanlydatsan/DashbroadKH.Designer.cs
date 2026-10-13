namespace quanlydatsan
{
    partial class DashbroadKH
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
            btnLogout = new Button();
            btnProfile = new Button();
            btnHistory = new Button();
            btnBooking = new Button();
            btnHome = new Button();
            pnlNavIndicator = new Panel();
            pnlUserProfile = new Panel();
            lblUserRole = new Label();
            lblUserName = new Label();
            lblAvatar = new Label();
            pnlBrand = new Panel();
            lblBrandSubtitle = new Label();
            lblBrandName = new Label();
            pnlHeader = new Panel();
            lblDateTime = new Label();
            lblCurrentPage = new Label();
            pnlMainContainer = new Panel();
            pnlSidebar.SuspendLayout();
            pnlUserProfile.SuspendLayout();
            pnlBrand.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(21, 43, 29);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnProfile);
            pnlSidebar.Controls.Add(btnHistory);
            pnlSidebar.Controls.Add(btnBooking);
            pnlSidebar.Controls.Add(btnHome);
            pnlSidebar.Controls.Add(pnlNavIndicator);
            pnlSidebar.Controls.Add(pnlUserProfile);
            pnlSidebar.Controls.Add(pnlBrand);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(240, 681);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(185, 28, 28);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 631);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(240, 50);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "🚪  Đăng Xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 10.5F);
            btnProfile.ForeColor = Color.FromArgb(220, 235, 225);
            btnProfile.Location = new Point(0, 345);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(25, 0, 0, 0);
            btnProfile.Size = new Size(240, 48);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "👤   Tài Khoản";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnNav_Click;
            // 
            // btnHistory
            // 
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.Dock = DockStyle.Top;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 10.5F);
            btnHistory.ForeColor = Color.FromArgb(220, 235, 225);
            btnHistory.Location = new Point(0, 297);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(25, 0, 0, 0);
            btnHistory.Size = new Size(240, 48);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "📋   Lịch Sử Đặt";
            btnHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnNav_Click;
            // 
            // btnBooking
            // 
            btnBooking.Cursor = Cursors.Hand;
            btnBooking.Dock = DockStyle.Top;
            btnBooking.FlatAppearance.BorderSize = 0;
            btnBooking.FlatStyle = FlatStyle.Flat;
            btnBooking.Font = new Font("Segoe UI", 10.5F);
            btnBooking.ForeColor = Color.FromArgb(220, 235, 225);
            btnBooking.Location = new Point(0, 249);
            btnBooking.Name = "btnBooking";
            btnBooking.Padding = new Padding(25, 0, 0, 0);
            btnBooking.Size = new Size(240, 48);
            btnBooking.TabIndex = 2;
            btnBooking.Text = "🏸   Đặt Sân";
            btnBooking.TextAlign = ContentAlignment.MiddleLeft;
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnNav_Click;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10.5F);
            btnHome.ForeColor = Color.FromArgb(220, 235, 225);
            btnHome.Location = new Point(0, 201);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(25, 0, 0, 0);
            btnHome.Size = new Size(240, 48);
            btnHome.TabIndex = 1;
            btnHome.Text = "🏠   Trang Chủ";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnNav_Click;
            // 
            // pnlNavIndicator
            // 
            pnlNavIndicator.BackColor = Color.FromArgb(74, 222, 128);
            pnlNavIndicator.Location = new Point(0, 201);
            pnlNavIndicator.Name = "pnlNavIndicator";
            pnlNavIndicator.Size = new Size(5, 48);
            pnlNavIndicator.TabIndex = 5;
            // 
            // pnlUserProfile
            // 
            pnlUserProfile.BackColor = Color.FromArgb(28, 58, 39);
            pnlUserProfile.Controls.Add(lblUserRole);
            pnlUserProfile.Controls.Add(lblUserName);
            pnlUserProfile.Controls.Add(lblAvatar);
            pnlUserProfile.Dock = DockStyle.Top;
            pnlUserProfile.Location = new Point(0, 75);
            pnlUserProfile.Name = "pnlUserProfile";
            pnlUserProfile.Size = new Size(240, 126);
            pnlUserProfile.TabIndex = 0;
            // 
            // lblUserRole
            // 
            lblUserRole.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblUserRole.ForeColor = Color.FromArgb(134, 239, 172);
            lblUserRole.Location = new Point(12, 94);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(216, 20);
            lblUserRole.TabIndex = 2;
            lblUserRole.Text = "Khách Hàng";
            lblUserRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            lblUserName.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(12, 68);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(216, 24);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Người Dùng";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAvatar
            // 
            lblAvatar.Font = new Font("Segoe UI", 30F);
            lblAvatar.ForeColor = Color.White;
            lblAvatar.Location = new Point(85, 10);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(70, 55);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "👤";
            lblAvatar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = Color.FromArgb(16, 34, 23);
            pnlBrand.Controls.Add(lblBrandSubtitle);
            pnlBrand.Controls.Add(lblBrandName);
            pnlBrand.Dock = DockStyle.Top;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(240, 75);
            pnlBrand.TabIndex = 0;
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.AutoSize = true;
            lblBrandSubtitle.Font = new Font("Segoe UI", 8F);
            lblBrandSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblBrandSubtitle.Location = new Point(18, 42);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(127, 13);
            lblBrandSubtitle.TabIndex = 1;
            lblBrandSubtitle.Text = "HỆ THỐNG ĐẶT SÂN 4.0";
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lblBrandName.ForeColor = Color.White;
            lblBrandName.Location = new Point(16, 17);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(155, 23);
            lblBrandName.TabIndex = 0;
            lblBrandName.Text = "⚽ SPORT ARENA";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblDateTime);
            pnlHeader.Controls.Add(lblCurrentPage);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(240, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(844, 60);
            pnlHeader.TabIndex = 1;
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateTime.Font = new Font("Segoe UI", 9.5F);
            lblDateTime.ForeColor = Color.FromArgb(100, 116, 139);
            lblDateTime.Location = new Point(544, 20);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(280, 20);
            lblDateTime.TabIndex = 1;
            lblDateTime.Text = "Hôm nay: ...";
            lblDateTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCurrentPage
            // 
            lblCurrentPage.AutoSize = true;
            lblCurrentPage.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCurrentPage.ForeColor = Color.FromArgb(30, 41, 59);
            lblCurrentPage.Location = new Point(20, 16);
            lblCurrentPage.Name = "lblCurrentPage";
            lblCurrentPage.Size = new Size(123, 25);
            lblCurrentPage.TabIndex = 0;
            lblCurrentPage.Text = "TRANG CHỦ";
            // 
            // pnlMainContainer
            // 
            pnlMainContainer.BackColor = Color.FromArgb(241, 245, 249);
            pnlMainContainer.Dock = DockStyle.Fill;
            pnlMainContainer.Location = new Point(240, 60);
            pnlMainContainer.Name = "pnlMainContainer";
            pnlMainContainer.Padding = new Padding(15);
            pnlMainContainer.Size = new Size(844, 621);
            pnlMainContainer.TabIndex = 2;
            // 
            // DashbroadKH
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 681);
            Controls.Add(pnlMainContainer);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(950, 600);
            Name = "DashbroadKH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sport Arena - Hệ Thống Quản Lý Đặt Sân";
            Load += DashbroadLogin_Load;
            pnlSidebar.ResumeLayout(false);
            pnlUserProfile.ResumeLayout(false);
            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Panel pnlUserProfile;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlNavIndicator;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel pnlMainContainer;
    }
}