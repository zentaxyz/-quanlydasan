namespace TrangChu
{
    partial class TrangChu
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
            btnBaoCao = new Button();
            pnlNoiDung = new Panel();
            btnTopKhachHang = new Button();
            btnDTSan = new Button();
            btnDTThoiGian = new Button();
            pnlMenuBaoCao = new Panel();
            pnlMenuBaoCao.SuspendLayout();
            SuspendLayout();
            // 
            // btnBaoCao
            // 
            btnBaoCao.Location = new Point(12, 168);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(75, 23);
            btnBaoCao.TabIndex = 2;
            btnBaoCao.Text = "Báo cáo";
            btnBaoCao.UseVisualStyleBackColor = true;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // pnlNoiDung
            // 
            pnlNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlNoiDung.AutoScroll = true;
            pnlNoiDung.Location = new Point(248, 2);
            pnlNoiDung.Name = "pnlNoiDung";
            pnlNoiDung.Size = new Size(1000, 650);
            pnlNoiDung.TabIndex = 3;
            // 
            // btnTopKhachHang
            // 
            btnTopKhachHang.Location = new Point(3, 62);
            btnTopKhachHang.Name = "btnTopKhachHang";
            btnTopKhachHang.Size = new Size(141, 23);
            btnTopKhachHang.TabIndex = 2;
            btnTopKhachHang.Text = "Top Khách Hàng";
            btnTopKhachHang.UseVisualStyleBackColor = true;
            btnTopKhachHang.Click += btnTopKhachHang_Click;
            // 
            // btnDTSan
            // 
            btnDTSan.Location = new Point(3, 33);
            btnDTSan.Name = "btnDTSan";
            btnDTSan.Size = new Size(141, 23);
            btnDTSan.TabIndex = 1;
            btnDTSan.Text = "Doanh Thu Sân";
            btnDTSan.UseVisualStyleBackColor = true;
            btnDTSan.Click += btnDTSan_Click;
            // 
            // btnDTThoiGian
            // 
            btnDTThoiGian.Location = new Point(3, 4);
            btnDTThoiGian.Name = "btnDTThoiGian";
            btnDTThoiGian.Size = new Size(141, 23);
            btnDTThoiGian.TabIndex = 0;
            btnDTThoiGian.Text = "DT Ngày / Tháng / Quý";
            btnDTThoiGian.UseVisualStyleBackColor = true;
            btnDTThoiGian.Click += btnDTThoiGian_Click;
            // 
            // pnlMenuBaoCao
            // 
            pnlMenuBaoCao.Controls.Add(btnTopKhachHang);
            pnlMenuBaoCao.Controls.Add(btnDTThoiGian);
            pnlMenuBaoCao.Controls.Add(btnDTSan);
            pnlMenuBaoCao.Location = new Point(93, 168);
            pnlMenuBaoCao.Name = "pnlMenuBaoCao";
            pnlMenuBaoCao.Size = new Size(149, 89);
            pnlMenuBaoCao.TabIndex = 4;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 661);
            Controls.Add(pnlMenuBaoCao);
            Controls.Add(pnlNoiDung);
            Controls.Add(btnBaoCao);
            Name = "TrangChu";
            Text = "Form1";
            Load += TrangChu_Load;
            pnlMenuBaoCao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnBaoCao;
        private Panel pnlNoiDung;
        private Button btnTopKhachHang;
        private Button btnDTSan;
        private Button btnDTThoiGian;
        private Panel pnlMenuBaoCao;
    }
}
