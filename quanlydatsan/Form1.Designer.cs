namespace quanlydatsan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            btnDangxuat = new Button();
            btnBaocao = new Button();
            btnSan = new Button();
            btnLoaisan = new Button();
            btnThanhtoan = new Button();
            btnTaikhoan = new Button();
            btnNgayle = new Button();
            btnLichdatsan = new Button();
            btnKhunggio = new Button();
            btnPhieudatsan = new Button();
            btnTrangchu = new Button();
            label1 = new Label();
            picAvatar = new PictureBox();
            panelMain = new Panel();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.MidnightBlue;
            panelSidebar.Controls.Add(btnDangxuat);
            panelSidebar.Controls.Add(btnBaocao);
            panelSidebar.Controls.Add(btnSan);
            panelSidebar.Controls.Add(btnLoaisan);
            panelSidebar.Controls.Add(btnThanhtoan);
            panelSidebar.Controls.Add(btnTaikhoan);
            panelSidebar.Controls.Add(btnNgayle);
            panelSidebar.Controls.Add(btnLichdatsan);
            panelSidebar.Controls.Add(btnKhunggio);
            panelSidebar.Controls.Add(btnPhieudatsan);
            panelSidebar.Controls.Add(btnTrangchu);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(picAvatar);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(240, 719);
            panelSidebar.TabIndex = 0;
            // 
            // btnDangxuat
            // 
            btnDangxuat.BackColor = Color.FromArgb(255, 128, 0);
            btnDangxuat.Dock = DockStyle.Bottom;
            btnDangxuat.FlatAppearance.BorderSize = 0;
            btnDangxuat.FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 54, 12);
            btnDangxuat.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 112, 67);
            btnDangxuat.FlatStyle = FlatStyle.Flat;
            btnDangxuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangxuat.ForeColor = Color.White;
            btnDangxuat.Location = new Point(0, 674);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(240, 45);
            btnDangxuat.TabIndex = 2;
            btnDangxuat.Text = "Đăng Xuất";
            btnDangxuat.UseVisualStyleBackColor = false;
            // 
            // btnBaocao
            // 
            btnBaocao.FlatAppearance.BorderSize = 0;
            btnBaocao.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnBaocao.FlatStyle = FlatStyle.Flat;
            btnBaocao.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaocao.ForeColor = Color.White;
            btnBaocao.Location = new Point(0, 617);
            btnBaocao.Name = "btnBaocao";
            btnBaocao.Size = new Size(209, 45);
            btnBaocao.TabIndex = 10;
            btnBaocao.Text = "  Báo Cáo Và Doanh Thu";
            btnBaocao.TextAlign = ContentAlignment.MiddleLeft;
            btnBaocao.UseVisualStyleBackColor = true;
            // 
            // btnSan
            // 
            btnSan.FlatAppearance.BorderSize = 0;
            btnSan.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnSan.FlatStyle = FlatStyle.Flat;
            btnSan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSan.ForeColor = Color.White;
            btnSan.Location = new Point(3, 260);
            btnSan.Name = "btnSan";
            btnSan.Size = new Size(174, 45);
            btnSan.TabIndex = 3;
            btnSan.Text = "  Quản Lý Sân";
            btnSan.TextAlign = ContentAlignment.MiddleLeft;
            btnSan.UseVisualStyleBackColor = true;
            // 
            // btnLoaisan
            // 
            btnLoaisan.FlatAppearance.BorderSize = 0;
            btnLoaisan.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnLoaisan.FlatStyle = FlatStyle.Flat;
            btnLoaisan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoaisan.ForeColor = Color.White;
            btnLoaisan.Location = new Point(0, 311);
            btnLoaisan.Name = "btnLoaisan";
            btnLoaisan.Size = new Size(174, 45);
            btnLoaisan.TabIndex = 4;
            btnLoaisan.Text = "  Loại Sân";
            btnLoaisan.TextAlign = ContentAlignment.MiddleLeft;
            btnLoaisan.UseVisualStyleBackColor = true;
            // 
            // btnThanhtoan
            // 
            btnThanhtoan.FlatAppearance.BorderSize = 0;
            btnThanhtoan.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnThanhtoan.FlatStyle = FlatStyle.Flat;
            btnThanhtoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhtoan.ForeColor = Color.White;
            btnThanhtoan.Location = new Point(0, 566);
            btnThanhtoan.Name = "btnThanhtoan";
            btnThanhtoan.Size = new Size(174, 45);
            btnThanhtoan.TabIndex = 9;
            btnThanhtoan.Text = "  Thanh Toán";
            btnThanhtoan.TextAlign = ContentAlignment.MiddleLeft;
            btnThanhtoan.UseVisualStyleBackColor = true;
            // 
            // btnTaikhoan
            // 
            btnTaikhoan.FlatAppearance.BorderSize = 0;
            btnTaikhoan.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnTaikhoan.FlatStyle = FlatStyle.Flat;
            btnTaikhoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaikhoan.ForeColor = Color.White;
            btnTaikhoan.Location = new Point(0, 515);
            btnTaikhoan.Name = "btnTaikhoan";
            btnTaikhoan.Size = new Size(240, 45);
            btnTaikhoan.TabIndex = 8;
            btnTaikhoan.Text = "  Khách Hàng Và Tài Khoản";
            btnTaikhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnTaikhoan.UseVisualStyleBackColor = true;
            btnTaikhoan.MouseClick += btnTaikhoan_MouseClick;
            // 
            // btnNgayle
            // 
            btnNgayle.FlatAppearance.BorderSize = 0;
            btnNgayle.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnNgayle.FlatStyle = FlatStyle.Flat;
            btnNgayle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNgayle.ForeColor = Color.White;
            btnNgayle.Location = new Point(0, 464);
            btnNgayle.Name = "btnNgayle";
            btnNgayle.Size = new Size(174, 45);
            btnNgayle.TabIndex = 7;
            btnNgayle.Text = "  Ngày Lễ";
            btnNgayle.TextAlign = ContentAlignment.MiddleLeft;
            btnNgayle.UseVisualStyleBackColor = true;
            // 
            // btnLichdatsan
            // 
            btnLichdatsan.FlatAppearance.BorderSize = 0;
            btnLichdatsan.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnLichdatsan.FlatStyle = FlatStyle.Flat;
            btnLichdatsan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLichdatsan.ForeColor = Color.White;
            btnLichdatsan.Location = new Point(0, 413);
            btnLichdatsan.Name = "btnLichdatsan";
            btnLichdatsan.Size = new Size(174, 45);
            btnLichdatsan.TabIndex = 6;
            btnLichdatsan.Text = "  Lịch Đặt Sân";
            btnLichdatsan.TextAlign = ContentAlignment.MiddleLeft;
            btnLichdatsan.UseVisualStyleBackColor = true;
            // 
            // btnKhunggio
            // 
            btnKhunggio.FlatAppearance.BorderSize = 0;
            btnKhunggio.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnKhunggio.FlatStyle = FlatStyle.Flat;
            btnKhunggio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKhunggio.ForeColor = Color.White;
            btnKhunggio.Location = new Point(0, 362);
            btnKhunggio.Name = "btnKhunggio";
            btnKhunggio.Size = new Size(174, 45);
            btnKhunggio.TabIndex = 5;
            btnKhunggio.Text = "  Khung Giờ";
            btnKhunggio.TextAlign = ContentAlignment.MiddleLeft;
            btnKhunggio.UseVisualStyleBackColor = true;
            // 
            // btnPhieudatsan
            // 
            btnPhieudatsan.FlatAppearance.BorderSize = 0;
            btnPhieudatsan.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnPhieudatsan.FlatStyle = FlatStyle.Flat;
            btnPhieudatsan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPhieudatsan.ForeColor = Color.White;
            btnPhieudatsan.Location = new Point(0, 209);
            btnPhieudatsan.Name = "btnPhieudatsan";
            btnPhieudatsan.Size = new Size(174, 45);
            btnPhieudatsan.TabIndex = 2;
            btnPhieudatsan.Text = "  Phiếu Đặt Sân";
            btnPhieudatsan.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieudatsan.UseVisualStyleBackColor = true;
            // 
            // btnTrangchu
            // 
            btnTrangchu.FlatAppearance.BorderSize = 0;
            btnTrangchu.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnTrangchu.FlatStyle = FlatStyle.Flat;
            btnTrangchu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrangchu.ForeColor = Color.White;
            btnTrangchu.Location = new Point(0, 158);
            btnTrangchu.Name = "btnTrangchu";
            btnTrangchu.Size = new Size(174, 45);
            btnTrangchu.TabIndex = 1;
            btnTrangchu.Text = "  Trang Chủ";
            btnTrangchu.TextAlign = ContentAlignment.MiddleLeft;
            btnTrangchu.UseVisualStyleBackColor = true;
            btnTrangchu.MouseClick += btnTrangchu_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(87, 135);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Xin chào";
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Image = Properties.Resources.pngtree_accountavataruser__flat_color_icon__vector_icon_banner_templ_png_image_1491720;
            picAvatar.Location = new Point(64, 12);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(110, 110);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(224, 224, 224);
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(240, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(878, 719);
            panelMain.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 719);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Quản Trị";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private PictureBox picAvatar;
        private Label label1;
        private Button btnTrangchu;
        private Button btnBaocao;
        private Button btnSan;
        private Button btnLoaisan;
        private Button btnThanhtoan;
        private Button btnTaikhoan;
        private Button btnNgayle;
        private Button btnLichdatsan;
        private Button btnKhunggio;
        private Button btnPhieudatsan;
        private Button btnDangxuat;
        private Panel panelMain;
    }
}
