
namespace quanlydatsan
{
    partial class FormThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThanhToan));
            lblTitle = new Label();
            pnlCard = new Panel();
            lblTongtien = new Label();
            btnDong = new Button();
            lblHuongDan = new Label();
            lblInfo = new Label();
            pictureBox1 = new PictureBox();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(22, 163, 74);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(484, 55);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "XÁC NHẬN ĐẶT SÂN THÀNH CÔNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(lblTongtien);
            pnlCard.Controls.Add(btnDong);
            pnlCard.Controls.Add(lblHuongDan);
            pnlCard.Controls.Add(lblInfo);
            pnlCard.Controls.Add(pictureBox1);
            pnlCard.Location = new Point(25, 60);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(434, 535);
            pnlCard.TabIndex = 1;
            // 
            // lblTongtien
            // 
            lblTongtien.AutoSize = true;
            lblTongtien.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongtien.ForeColor = Color.Red;
            lblTongtien.Location = new Point(20, 35);
            lblTongtien.Name = "lblTongtien";
            lblTongtien.Size = new Size(175, 43);
            lblTongtien.TabIndex = 5;
            lblTongtien.Text = "tong tien";
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.FromArgb(46, 125, 50);
            btnDong.Cursor = Cursors.Hand;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(20, 470);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(394, 42);
            btnDong.TabIndex = 3;
            btnDong.Text = "ĐÃ HOÀN TẤT & ĐÓNG";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // lblHuongDan
            // 
            lblHuongDan.Font = new Font("Segoe UI", 9.5F);
            lblHuongDan.ForeColor = Color.FromArgb(51, 65, 85);
            lblHuongDan.Location = new Point(20, 324);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new Size(394, 131);
            lblHuongDan.TabIndex = 2;
            lblHuongDan.Text = resources.GetString("lblHuongDan.Text");
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInfo.ForeColor = Color.FromArgb(30, 41, 59);
            lblInfo.Location = new Point(20, 15);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(74, 20);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Mã phiếu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(484, 611);
            Controls.Add(pnlCard);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hướng Dẫn Thanh Toán Chuyển Khoản";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.Button btnDong;
        private PictureBox pictureBox1;
        private Label lblTongtien;
    }
}