using System.Drawing.Printing;
using System.Xml.Linq;
using static Guna.UI2.WinForms.Suite.Descriptions;
//using static System.Net.Mime.MediaTypeNames;

namespace quanlydatsan
{
    partial class DashbroadLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashbroadLogin));
            panelSidebar = new Panel();
            btnDangxuat = new Button();
            btnLichsu = new Button();
            btnTk = new Button();
            btnDatsan = new Button();
            btnTrangchu = new Button();
            label1 = new Label();
            picAvatar = new PictureBox();
            uC_Datsan1 = new quanlydatsan.All_User_control.UC_Datsan();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.MidnightBlue;
            panelSidebar.Controls.Add(btnDangxuat);
            panelSidebar.Controls.Add(btnLichsu);
            panelSidebar.Controls.Add(btnTk);
            panelSidebar.Controls.Add(btnDatsan);
            panelSidebar.Controls.Add(btnTrangchu);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(picAvatar);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(3, 2, 3, 2);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(210, 539);
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
            btnDangxuat.Location = new Point(0, 505);
            btnDangxuat.Margin = new Padding(3, 2, 3, 2);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(210, 34);
            btnDangxuat.TabIndex = 2;
            btnDangxuat.Text = "Đăng Xuất";
            btnDangxuat.UseVisualStyleBackColor = false;
            btnDangxuat.Click += btnDangxuat_Click;
            // 
            // btnLichsu
            // 
            btnLichsu.FlatAppearance.BorderSize = 0;
            btnLichsu.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnLichsu.FlatStyle = FlatStyle.Flat;
            btnLichsu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLichsu.ForeColor = Color.White;
            btnLichsu.Location = new Point(12, 194);
            btnLichsu.Margin = new Padding(3, 2, 3, 2);
            btnLichsu.Name = "btnLichsu";
            btnLichsu.Size = new Size(190, 34);
            btnLichsu.TabIndex = 3;
            btnLichsu.Text = "  Lịch sử";
            btnLichsu.TextAlign = ContentAlignment.MiddleLeft;
            btnLichsu.UseVisualStyleBackColor = true;
            // 
            // btnTk
            // 
            btnTk.FlatAppearance.BorderSize = 0;
            btnTk.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnTk.FlatStyle = FlatStyle.Flat;
            btnTk.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTk.ForeColor = Color.White;
            btnTk.Location = new Point(12, 232);
            btnTk.Margin = new Padding(3, 2, 3, 2);
            btnTk.Name = "btnTk";
            btnTk.Size = new Size(190, 34);
            btnTk.TabIndex = 4;
            btnTk.Text = "  Tài Khoản";
            btnTk.TextAlign = ContentAlignment.MiddleLeft;
            btnTk.UseVisualStyleBackColor = true;
            // 
            // btnDatsan
            // 
            btnDatsan.FlatAppearance.BorderSize = 0;
            btnDatsan.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnDatsan.FlatStyle = FlatStyle.Flat;
            btnDatsan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatsan.ForeColor = Color.White;
            btnDatsan.Location = new Point(12, 156);
            btnDatsan.Margin = new Padding(3, 2, 3, 2);
            btnDatsan.Name = "btnDatsan";
            btnDatsan.Size = new Size(190, 34);
            btnDatsan.TabIndex = 2;
            btnDatsan.Text = "  Đặt Sân";
            btnDatsan.TextAlign = ContentAlignment.MiddleLeft;
            btnDatsan.UseVisualStyleBackColor = true;
            // 
            // btnTrangchu
            // 
            btnTrangchu.FlatAppearance.BorderSize = 0;
            btnTrangchu.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnTrangchu.FlatStyle = FlatStyle.Flat;
            btnTrangchu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrangchu.ForeColor = Color.White;
            btnTrangchu.Location = new Point(12, 118);
            btnTrangchu.Margin = new Padding(3, 2, 3, 2);
            btnTrangchu.Name = "btnTrangchu";
            btnTrangchu.Size = new Size(190, 34);
            btnTrangchu.TabIndex = 1;
            btnTrangchu.Text = "  Trang Chủ";
            btnTrangchu.TextAlign = ContentAlignment.MiddleLeft;
            btnTrangchu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(76, 101);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Xin chào";
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Image = (Image)resources.GetObject("picAvatar.Image");
            picAvatar.Location = new Point(56, 9);
            picAvatar.Margin = new Padding(3, 2, 3, 2);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(96, 83);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // uC_Datsan1
            // 
            uC_Datsan1.BorderStyle = BorderStyle.FixedSingle;
            uC_Datsan1.Location = new Point(208, 0);
            uC_Datsan1.Name = "uC_Datsan1";
            uC_Datsan1.Size = new Size(767, 536);
            uC_Datsan1.TabIndex = 1;
            // 
            // DashbroadLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 539);
            Controls.Add(uC_Datsan1);
            Controls.Add(panelSidebar);
            Name = "DashbroadLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Quản Trị";
            WindowState = FormWindowState.Minimized;
            Load += DashbroadLogin_Load;
            Leave += btnDangxuat_Click;
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
        private Button btnLichsu;
        private Button btnTk;
        private Button btnDatsan;
        private Button btnDangxuat;
        private Guna.UI2.WinForms.Guna2Panel MovingPanel;
        private All_User_control.UC_Datsan uC_Datsan1;
    }
}