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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnCustomerMgr = new System.Windows.Forms.Button();
            this.btnOrderMgr = new System.Windows.Forms.Button();
            this.btnFieldMgr = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlAdminProfile = new System.Windows.Forms.Panel();
            this.lblAdminRole = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblAdminAvatar = new System.Windows.Forms.Label();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.lblBrandSub = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlAdminProfile.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnRevenue);
            this.pnlSidebar.Controls.Add(this.btnCustomerMgr);
            this.pnlSidebar.Controls.Add(this.btnOrderMgr);
            this.pnlSidebar.Controls.Add(this.btnFieldMgr);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.pnlAdminProfile);
            this.pnlSidebar.Controls.Add(this.pnlBrand);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 720);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 670);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 50);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "🚪  Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevenue.FlatAppearance.BorderSize = 0;
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnRevenue.Location = new System.Drawing.Point(0, 400);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRevenue.Size = new System.Drawing.Size(250, 50);
            this.btnRevenue.TabIndex = 5;
            this.btnRevenue.Text = "📊   Báo Cáo Doanh Thu";
            this.btnRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnCustomerMgr
            // 
            this.btnCustomerMgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerMgr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerMgr.FlatAppearance.BorderSize = 0;
            this.btnCustomerMgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerMgr.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnCustomerMgr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnCustomerMgr.Location = new System.Drawing.Point(0, 350);
            this.btnCustomerMgr.Name = "btnCustomerMgr";
            this.btnCustomerMgr.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCustomerMgr.Size = new System.Drawing.Size(250, 50);
            this.btnCustomerMgr.TabIndex = 4;
            this.btnCustomerMgr.Text = "👥   Quản Lý Khách Hàng";
            this.btnCustomerMgr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerMgr.UseVisualStyleBackColor = true;
            this.btnCustomerMgr.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnOrderMgr
            // 
            this.btnOrderMgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderMgr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderMgr.FlatAppearance.BorderSize = 0;
            this.btnOrderMgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderMgr.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnOrderMgr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnOrderMgr.Location = new System.Drawing.Point(0, 300);
            this.btnOrderMgr.Name = "btnOrderMgr";
            this.btnOrderMgr.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnOrderMgr.Size = new System.Drawing.Size(250, 50);
            this.btnOrderMgr.TabIndex = 3;
            this.btnOrderMgr.Text = "📑   Duyệt Đặt Sân";
            this.btnOrderMgr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderMgr.UseVisualStyleBackColor = true;
            this.btnOrderMgr.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnFieldMgr
            // 
            this.btnFieldMgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFieldMgr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFieldMgr.FlatAppearance.BorderSize = 0;
            this.btnFieldMgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFieldMgr.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnFieldMgr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnFieldMgr.Location = new System.Drawing.Point(0, 250);
            this.btnFieldMgr.Name = "btnFieldMgr";
            this.btnFieldMgr.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnFieldMgr.Size = new System.Drawing.Size(250, 50);
            this.btnFieldMgr.TabIndex = 2;
            this.btnFieldMgr.Text = "🏟️   Quản Lý Danh Sách Sân";
            this.btnFieldMgr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFieldMgr.UseVisualStyleBackColor = true;
            this.btnFieldMgr.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 200);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(250, 50);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "⚡   Tổng Quan Hệ Thống";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlAdminProfile
            // 
            this.pnlAdminProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlAdminProfile.Controls.Add(this.lblAdminRole);
            this.pnlAdminProfile.Controls.Add(this.lblAdminName);
            this.pnlAdminProfile.Controls.Add(this.lblAdminAvatar);
            this.pnlAdminProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminProfile.Location = new System.Drawing.Point(0, 75);
            this.pnlAdminProfile.Name = "pnlAdminProfile";
            this.pnlAdminProfile.Size = new System.Drawing.Size(250, 125);
            this.pnlAdminProfile.TabIndex = 0;
            // 
            // lblAdminRole
            // 
            this.lblAdminRole.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAdminRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.lblAdminRole.Location = new System.Drawing.Point(12, 94);
            this.lblAdminRole.Name = "lblAdminRole";
            this.lblAdminRole.Size = new System.Drawing.Size(226, 20);
            this.lblAdminRole.TabIndex = 2;
            this.lblAdminRole.Text = "QUẢN TRỊ VIÊN HỆ THỐNG";
            this.lblAdminRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminName
            // 
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAdminName.ForeColor = System.Drawing.Color.White;
            this.lblAdminName.Location = new System.Drawing.Point(12, 68);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(226, 24);
            this.lblAdminName.TabIndex = 1;
            this.lblAdminName.Text = "Quản Trị Viên";
            this.lblAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminAvatar
            // 
            this.lblAdminAvatar.Font = new System.Drawing.Font("Segoe UI", 32F);
            this.lblAdminAvatar.ForeColor = System.Drawing.Color.White;
            this.lblAdminAvatar.Location = new System.Drawing.Point(90, 8);
            this.lblAdminAvatar.Name = "lblAdminAvatar";
            this.lblAdminAvatar.Size = new System.Drawing.Size(70, 58);
            this.lblAdminAvatar.TabIndex = 0;
            this.lblAdminAvatar.Text = "🛡️";
            this.lblAdminAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBrand
            // 
            this.pnlBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(23)))));
            this.pnlBrand.Controls.Add(this.lblBrandSub);
            this.pnlBrand.Controls.Add(this.lblBrand);
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(250, 75);
            this.pnlBrand.TabIndex = 0;
            // 
            // lblBrandSub
            // 
            this.lblBrandSub.AutoSize = true;
            this.lblBrandSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblBrandSub.Location = new System.Drawing.Point(18, 43);
            this.lblBrandSub.Name = "lblBrandSub";
            this.lblBrandSub.Size = new System.Drawing.Size(125, 13);
            this.lblBrandSub.TabIndex = 1;
            this.lblBrandSub.Text = "ADMIN CONTROL PANEL";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(16, 17);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(161, 25);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "🏟️ ARENA ADMIN";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTime);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(250, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(894, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTime.Location = new System.Drawing.Point(594, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(280, 20);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Hôm nay: ...";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TỔNG QUAN HỆ THỐNG";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(894, 660);
            this.pnlContent.TabIndex = 2;
            // 
            // DashbroadAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "DashbroadAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sport Arena - Quản Trị Hệ Thống";
            this.Load += new System.EventHandler(this.DashbroadAdmin_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlAdminProfile.ResumeLayout(false);
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnFieldMgr;
        private System.Windows.Forms.Button btnOrderMgr;
        private System.Windows.Forms.Button btnCustomerMgr;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnlContent;
    }
}