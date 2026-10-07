namespace quanlydatsan
{
    partial class TrangchuQTV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelCardsan = new Panel();
            label1 = new Label();
            lblTongsosan = new Label();
            panelCarddoanhthu = new Panel();
            label3 = new Label();
            lblDoanhthungay = new Label();
            panelCardphieu = new Panel();
            label2 = new Label();
            lblPhieuchoduyet = new Label();
            dgvLichhomnay = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            panelCardsan.SuspendLayout();
            panelCarddoanhthu.SuspendLayout();
            panelCardphieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichhomnay).BeginInit();
            SuspendLayout();
            // 
            // panelCardsan
            // 
            panelCardsan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCardsan.BackColor = Color.FromArgb(232, 240, 254);
            panelCardsan.BorderStyle = BorderStyle.Fixed3D;
            panelCardsan.Controls.Add(label1);
            panelCardsan.Controls.Add(lblTongsosan);
            panelCardsan.Location = new Point(12, 135);
            panelCardsan.Name = "panelCardsan";
            panelCardsan.Size = new Size(231, 116);
            panelCardsan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 31);
            label1.TabIndex = 1;
            label1.Text = "Tổng số sân:";
            // 
            // lblTongsosan
            // 
            lblTongsosan.AutoSize = true;
            lblTongsosan.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongsosan.Location = new Point(3, 41);
            lblTongsosan.Name = "lblTongsosan";
            lblTongsosan.Size = new Size(125, 54);
            lblTongsosan.TabIndex = 0;
            lblTongsosan.Text = "0 Sân";
            // 
            // panelCarddoanhthu
            // 
            panelCarddoanhthu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCarddoanhthu.BackColor = Color.FromArgb(232, 240, 254);
            panelCarddoanhthu.BorderStyle = BorderStyle.Fixed3D;
            panelCarddoanhthu.Controls.Add(label3);
            panelCarddoanhthu.Controls.Add(lblDoanhthungay);
            panelCarddoanhthu.Location = new Point(621, 135);
            panelCarddoanhthu.Name = "panelCarddoanhthu";
            panelCarddoanhthu.Size = new Size(231, 116);
            panelCarddoanhthu.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, -2);
            label3.Name = "label3";
            label3.Size = new Size(220, 31);
            label3.TabIndex = 3;
            label3.Text = "Doanh thu hôm nay:";
            // 
            // lblDoanhthungay
            // 
            lblDoanhthungay.AutoSize = true;
            lblDoanhthungay.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoanhthungay.Location = new Point(3, 41);
            lblDoanhthungay.Name = "lblDoanhthungay";
            lblDoanhthungay.Size = new Size(146, 54);
            lblDoanhthungay.TabIndex = 2;
            lblDoanhthungay.Text = "0 VNĐ";
            // 
            // panelCardphieu
            // 
            panelCardphieu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCardphieu.BackColor = Color.FromArgb(232, 240, 254);
            panelCardphieu.BorderStyle = BorderStyle.Fixed3D;
            panelCardphieu.Controls.Add(label2);
            panelCardphieu.Controls.Add(lblPhieuchoduyet);
            panelCardphieu.Location = new Point(321, 135);
            panelCardphieu.Name = "panelCardphieu";
            panelCardphieu.Size = new Size(231, 116);
            panelCardphieu.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 31);
            label2.TabIndex = 2;
            label2.Text = "Phiếu chờ duyệt:";
            // 
            // lblPhieuchoduyet
            // 
            lblPhieuchoduyet.AutoSize = true;
            lblPhieuchoduyet.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhieuchoduyet.Location = new Point(3, 41);
            lblPhieuchoduyet.Name = "lblPhieuchoduyet";
            lblPhieuchoduyet.Size = new Size(163, 54);
            lblPhieuchoduyet.TabIndex = 1;
            lblPhieuchoduyet.Text = "0 Phiếu";
            // 
            // dgvLichhomnay
            // 
            dgvLichhomnay.AllowUserToAddRows = false;
            dgvLichhomnay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLichhomnay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichhomnay.BackgroundColor = SystemColors.ActiveBorder;
            dgvLichhomnay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichhomnay.Location = new Point(12, 297);
            dgvLichhomnay.Name = "dgvLichhomnay";
            dgvLichhomnay.ReadOnly = true;
            dgvLichhomnay.RowHeadersWidth = 51;
            dgvLichhomnay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichhomnay.Size = new Size(840, 363);
            dgvLichhomnay.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 263);
            label4.Name = "label4";
            label4.Size = new Size(247, 31);
            label4.TabIndex = 2;
            label4.Text = "Lịch đặt sân hôm nay:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 43);
            label5.Name = "label5";
            label5.Size = new Size(413, 38);
            label5.TabIndex = 3;
            label5.Text = "TRANG CHỦ - QUẢN TRỊ VIÊN";
            // 
            // TrangchuQTV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(864, 672);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvLichhomnay);
            Controls.Add(panelCarddoanhthu);
            Controls.Add(panelCardphieu);
            Controls.Add(panelCardsan);
            ForeColor = Color.MidnightBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrangchuQTV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Trang Chủ Quản Trị";
            WindowState = FormWindowState.Maximized;
            Load += TrangchuQTV_Load;
            panelCardsan.ResumeLayout(false);
            panelCardsan.PerformLayout();
            panelCarddoanhthu.ResumeLayout(false);
            panelCarddoanhthu.PerformLayout();
            panelCardphieu.ResumeLayout(false);
            panelCardphieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichhomnay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCardsan;
        private Panel panelCarddoanhthu;
        private Panel panelCardphieu;
        private Label lblTongsosan;
        private Label lblDoanhthungay;
        private Label lblPhieuchoduyet;
        private DataGridView dgvLichhomnay;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}