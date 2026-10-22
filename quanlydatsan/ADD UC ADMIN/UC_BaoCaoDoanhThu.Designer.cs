namespace quanlydatsan
{
    partial class UC_BaoCaoDoanhThu
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlTopNav = new System.Windows.Forms.Panel();
            this.btnTopKhachHang = new System.Windows.Forms.Button();
            this.btnTheoSan = new System.Windows.Forms.Button();
            this.btnTheoThoiGian = new System.Windows.Forms.Button();
            this.pnlBaoCaoContainer = new System.Windows.Forms.Panel();
            this.pnlTopNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopNav
            // 
            this.pnlTopNav.BackColor = System.Drawing.Color.White;
            this.pnlTopNav.Controls.Add(this.btnTopKhachHang);
            this.pnlTopNav.Controls.Add(this.btnTheoSan);
            this.pnlTopNav.Controls.Add(this.btnTheoThoiGian);
            this.pnlTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopNav.Location = new System.Drawing.Point(0, 0);
            this.pnlTopNav.Name = "pnlTopNav";
            this.pnlTopNav.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlTopNav.Size = new System.Drawing.Size(950, 65);
            this.pnlTopNav.TabIndex = 0;
            // 
            // btnTopKhachHang
            // 
            this.btnTopKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnTopKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopKhachHang.FlatAppearance.BorderSize = 0;
            this.btnTopKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTopKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnTopKhachHang.Location = new System.Drawing.Point(440, 12);
            this.btnTopKhachHang.Name = "btnTopKhachHang";
            this.btnTopKhachHang.Size = new System.Drawing.Size(200, 40);
            this.btnTopKhachHang.TabIndex = 2;
            this.btnTopKhachHang.Text = "👥 Top Khách Hàng";
            this.btnTopKhachHang.UseVisualStyleBackColor = false;
            this.btnTopKhachHang.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // btnTheoSan
            // 
            this.btnTheoSan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnTheoSan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTheoSan.FlatAppearance.BorderSize = 0;
            this.btnTheoSan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheoSan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTheoSan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnTheoSan.Location = new System.Drawing.Point(230, 12);
            this.btnTheoSan.Name = "btnTheoSan";
            this.btnTheoSan.Size = new System.Drawing.Size(200, 40);
            this.btnTheoSan.TabIndex = 1;
            this.btnTheoSan.Text = "🏟️ Doanh Thu Theo Sân";
            this.btnTheoSan.UseVisualStyleBackColor = false;
            this.btnTheoSan.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // btnTheoThoiGian
            // 
            this.btnTheoThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnTheoThoiGian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTheoThoiGian.FlatAppearance.BorderSize = 0;
            this.btnTheoThoiGian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheoThoiGian.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTheoThoiGian.ForeColor = System.Drawing.Color.White;
            this.btnTheoThoiGian.Location = new System.Drawing.Point(20, 12);
            this.btnTheoThoiGian.Name = "btnTheoThoiGian";
            this.btnTheoThoiGian.Size = new System.Drawing.Size(200, 40);
            this.btnTheoThoiGian.TabIndex = 0;
            this.btnTheoThoiGian.Text = "📅 Doanh Thu Theo Ngày/Tháng";
            this.btnTheoThoiGian.UseVisualStyleBackColor = false;
            this.btnTheoThoiGian.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // pnlBaoCaoContainer
            // 
            this.pnlBaoCaoContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlBaoCaoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBaoCaoContainer.Location = new System.Drawing.Point(0, 65);
            this.pnlBaoCaoContainer.Name = "pnlBaoCaoContainer";
            this.pnlBaoCaoContainer.Size = new System.Drawing.Size(950, 555);
            this.pnlBaoCaoContainer.TabIndex = 1;
            // 
            // UC_BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlBaoCaoContainer);
            this.Controls.Add(this.pnlTopNav);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "UC_BaoCaoDoanhThu";
            this.Size = new System.Drawing.Size(950, 620);
            this.Load += new System.EventHandler(this.UC_BaoCaoDoanhThu_Load);
            this.pnlTopNav.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopNav;
        private System.Windows.Forms.Button btnTheoThoiGian;
        private System.Windows.Forms.Button btnTheoSan;
        private System.Windows.Forms.Button btnTopKhachHang;
        private System.Windows.Forms.Panel pnlBaoCaoContainer;
    }
}