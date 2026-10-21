namespace quanlydatsan
{
    partial class UCPhieuDatSan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtTrangThaiSan = new TextBox();
            label10 = new Label();
            btnTao = new Button();
            chkXacNhanThanhToan = new CheckBox();
            dtpGioKetThuc = new DateTimePicker30Phut();
            dtpGioBatDau = new DateTimePicker30Phut();
            dtpNgaydung = new DateTimePicker();
            btnXoa = new Button();
            btnLuu = new Button();
            btnThanhtoan = new Button();
            cboTrangthai = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            TxtTongTien = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cboSan = new ComboBox();
            cboKhach = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtMaPhieu = new TextBox();
            dgvLichDat = new DataGridView();
            TxtTimten = new TextBox();
            btnTheoten = new Button();
            btnHientatca = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichDat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(24, 14);
            label1.Name = "label1";
            label1.Size = new Size(164, 31);
            label1.TabIndex = 0;
            label1.Text = "Phiếu Đặt Sân";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTrangThaiSan);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnTao);
            groupBox1.Controls.Add(chkXacNhanThanhToan);
            groupBox1.Controls.Add(dtpGioKetThuc);
            groupBox1.Controls.Add(dtpGioBatDau);
            groupBox1.Controls.Add(dtpNgaydung);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThanhtoan);
            groupBox1.Controls.Add(cboTrangthai);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(TxtTongTien);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboSan);
            groupBox1.Controls.Add(cboKhach);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaPhieu);
            groupBox1.Location = new Point(24, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1182, 344);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu đặt sân";
            // 
            // txtTrangThaiSan
            // 
            txtTrangThaiSan.Location = new Point(777, 238);
            txtTrangThaiSan.Name = "txtTrangThaiSan";
            txtTrangThaiSan.ReadOnly = true;
            txtTrangThaiSan.Size = new Size(192, 27);
            txtTrangThaiSan.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(768, 214);
            label10.Name = "label10";
            label10.Size = new Size(101, 20);
            label10.TabIndex = 25;
            label10.Text = "Trạng thái sân";
            // 
            // btnTao
            // 
            btnTao.Location = new Point(891, 301);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(166, 32);
            btnTao.TabIndex = 24;
            btnTao.Text = "Tạo";
            btnTao.UseVisualStyleBackColor = true;
            btnTao.Click += btnTao_Click;
            // 
            // chkXacNhanThanhToan
            // 
            chkXacNhanThanhToan.AutoSize = true;
            chkXacNhanThanhToan.Location = new Point(34, 261);
            chkXacNhanThanhToan.Name = "chkXacNhanThanhToan";
            chkXacNhanThanhToan.Size = new Size(166, 24);
            chkXacNhanThanhToan.TabIndex = 23;
            chkXacNhanThanhToan.Text = "Xác nhận thanh toán";
            chkXacNhanThanhToan.UseVisualStyleBackColor = true;
            // 
            // dtpGioKetThuc
            // 
            dtpGioKetThuc.CustomFormat = "HH:mm";
            dtpGioKetThuc.Format = DateTimePickerFormat.Custom;
            dtpGioKetThuc.Location = new Point(768, 169);
            dtpGioKetThuc.Name = "dtpGioKetThuc";
            dtpGioKetThuc.ShowUpDown = true;
            dtpGioKetThuc.Size = new Size(171, 27);
            dtpGioKetThuc.TabIndex = 22;
            dtpGioKetThuc.Value = new DateTime(2026, 10, 18, 8, 0, 0, 0);
            dtpGioKetThuc.ValueChanged += CapNhatTongTien;
            // 
            // dtpGioBatDau
            // 
            dtpGioBatDau.CustomFormat = "HH:mm";
            dtpGioBatDau.Format = DateTimePickerFormat.Custom;
            dtpGioBatDau.Location = new Point(511, 169);
            dtpGioBatDau.Name = "dtpGioBatDau";
            dtpGioBatDau.ShowUpDown = true;
            dtpGioBatDau.Size = new Size(171, 27);
            dtpGioBatDau.TabIndex = 21;
            dtpGioBatDau.Value = new DateTime(2026, 10, 18, 7, 0, 0, 0);
            dtpGioBatDau.ValueChanged += CapNhatTongTien;
            // 
            // dtpNgaydung
            // 
            dtpNgaydung.CustomFormat = "dd/MM/yyyy";
            dtpNgaydung.Format = DateTimePickerFormat.Custom;
            dtpNgaydung.Location = new Point(511, 115);
            dtpNgaydung.Name = "dtpNgaydung";
            dtpNgaydung.Size = new Size(171, 27);
            dtpNgaydung.TabIndex = 20;
            dtpNgaydung.ValueChanged += CapNhatTongTien;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(704, 299);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(178, 31);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(513, 298);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(163, 31);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThanhtoan
            // 
            btnThanhtoan.Location = new Point(34, 291);
            btnThanhtoan.Name = "btnThanhtoan";
            btnThanhtoan.Size = new Size(172, 31);
            btnThanhtoan.TabIndex = 17;
            btnThanhtoan.Text = "Thanh toán";
            btnThanhtoan.UseVisualStyleBackColor = true;
            btnThanhtoan.Click += btnThanhtoan_Click;
            // 
            // cboTrangthai
            // 
            cboTrangthai.FormattingEnabled = true;
            cboTrangthai.Location = new Point(511, 237);
            cboTrangthai.Name = "cboTrangthai";
            cboTrangthai.Size = new Size(257, 28);
            cboTrangthai.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(511, 214);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 14;
            label9.Text = "Trạng thái";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 163);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 13;
            label8.Text = "Tổng tiền";
            // 
            // TxtTongTien
            // 
            TxtTongTien.Location = new Point(34, 198);
            TxtTongTien.Name = "TxtTongTien";
            TxtTongTien.Size = new Size(354, 27);
            TxtTongTien.TabIndex = 12;
            TxtTongTien.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(768, 146);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 9;
            label7.Text = "Giờ kết thúc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(511, 146);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 8;
            label6.Text = "Giờ bắt đầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(511, 92);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 7;
            label5.Text = "Ngày sử dụng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 99);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 6;
            label4.Text = "Sân";
            // 
            // cboSan
            // 
            cboSan.FormattingEnabled = true;
            cboSan.Location = new Point(34, 122);
            cboSan.Name = "cboSan";
            cboSan.Size = new Size(354, 28);
            cboSan.TabIndex = 4;
            cboSan.SelectedIndexChanged += CapNhatTongTien;
            // 
            // cboKhach
            // 
            cboKhach.FormattingEnabled = true;
            cboKhach.Items.AddRange(new object[] { "Khách Vãng Lai", "adassa", "sdaxzxzc" });
            cboKhach.Location = new Point(511, 56);
            cboKhach.Name = "cboKhach";
            cboKhach.Size = new Size(428, 28);
            cboKhach.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 31);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Khách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 31);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã phiếu";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(34, 63);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.ReadOnly = true;
            txtMaPhieu.Size = new Size(352, 27);
            txtMaPhieu.TabIndex = 0;
            // 
            // dgvLichDat
            // 
            dgvLichDat.AllowUserToAddRows = false;
            dgvLichDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichDat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichDat.Location = new Point(24, 445);
            dgvLichDat.MultiSelect = false;
            dgvLichDat.Name = "dgvLichDat";
            dgvLichDat.ReadOnly = true;
            dgvLichDat.RowHeadersWidth = 51;
            dgvLichDat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichDat.Size = new Size(1503, 376);
            dgvLichDat.TabIndex = 8;
            dgvLichDat.CellClick += dgvLichDat_CellClick;
            // 
            // TxtTimten
            // 
            TxtTimten.Location = new Point(27, 412);
            TxtTimten.Name = "TxtTimten";
            TxtTimten.Size = new Size(583, 27);
            TxtTimten.TabIndex = 3;
            // 
            // btnTheoten
            // 
            btnTheoten.Location = new Point(641, 412);
            btnTheoten.Name = "btnTheoten";
            btnTheoten.Size = new Size(239, 28);
            btnTheoten.TabIndex = 4;
            btnTheoten.Text = "Tìm theo tên";
            btnTheoten.UseVisualStyleBackColor = true;
            btnTheoten.Click += btnTheoten_Click;
            // 
            // btnHientatca
            // 
            btnHientatca.Location = new Point(895, 412);
            btnHientatca.Name = "btnHientatca";
            btnHientatca.Size = new Size(284, 27);
            btnHientatca.TabIndex = 5;
            btnHientatca.Text = "Hiện tất cả";
            btnHientatca.UseVisualStyleBackColor = true;
            btnHientatca.Click += btnHientatca_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // UCPhieuDatSan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnHientatca);
            Controls.Add(btnTheoten);
            Controls.Add(TxtTimten);
            Controls.Add(dgvLichDat);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "UCPhieuDatSan";
            Size = new Size(1544, 883);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichDat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvLichDat;
        private ComboBox cboSan;
        private ComboBox cboKhach;
        private Label label3;
        private Label label2;
        private TextBox txtMaPhieu;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cboTrangthai;
        private Label label9;
        private Label label8;
        private TextBox TxtTongTien;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnThanhtoan;
        private TextBox TxtTimten;
        private Button btnTheoten;
        private Button btnHientatca;
        private DateTimePicker dtpNgaydung;
        private quanlydatsan.DateTimePicker30Phut dtpGioKetThuc;
        private quanlydatsan.DateTimePicker30Phut dtpGioBatDau;
        private CheckBox chkXacNhanThanhToan;
        private Button btnTao;
        private TextBox txtTrangThaiSan;
        private Label label10;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
