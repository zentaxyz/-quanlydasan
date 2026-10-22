namespace quanlydatsan
{
    partial class UCQuanLyLichDat
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
            dtpLocTuNgay = new DateTimePicker();
            dtpLocDenNgay = new DateTimePicker();
            cboLocLoaiSan = new ComboBox();
            cboLocTrangThai = new ComboBox();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            mcLichDat = new MonthCalendar();
            dgvLichDat = new DataGridView();
            groupBox1 = new GroupBox();
            TxtThanhToan = new TextBox();
            TxtTrangThai = new TextBox();
            label11 = new Label();
            label10 = new Label();
            dtpThoiGianDen = new DateTimePicker();
            dtpThoiGianBatDau = new DateTimePicker();
            dtpNgaySuDung = new DateTimePicker();
            dtpNgayDat = new DateTimePicker();
            TxtLoaiSan = new TextBox();
            TxtSan = new TextBox();
            TxtMaPhieu = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            TxtTenKhach = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLichDat).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(249, 38);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Lịch Đặt";
            // 
            // dtpLocTuNgay
            // 
            dtpLocTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpLocTuNgay.Format = DateTimePickerFormat.Custom;
            dtpLocTuNgay.Location = new Point(61, 99);
            dtpLocTuNgay.Name = "dtpLocTuNgay";
            dtpLocTuNgay.Size = new Size(175, 27);
            dtpLocTuNgay.TabIndex = 1;
            // 
            // dtpLocDenNgay
            // 
            dtpLocDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpLocDenNgay.Format = DateTimePickerFormat.Custom;
            dtpLocDenNgay.Location = new Point(267, 99);
            dtpLocDenNgay.Name = "dtpLocDenNgay";
            dtpLocDenNgay.Size = new Size(175, 27);
            dtpLocDenNgay.TabIndex = 2;
            // 
            // cboLocLoaiSan
            // 
            cboLocLoaiSan.FormattingEnabled = true;
            cboLocLoaiSan.Location = new Point(475, 101);
            cboLocLoaiSan.Name = "cboLocLoaiSan";
            cboLocLoaiSan.Size = new Size(194, 28);
            cboLocLoaiSan.TabIndex = 3;
            // 
            // cboLocTrangThai
            // 
            cboLocTrangThai.FormattingEnabled = true;
            cboLocTrangThai.Location = new Point(717, 102);
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(188, 28);
            cboLocTrangThai.TabIndex = 4;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(959, 103);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(287, 27);
            txtTimKiem.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1264, 99);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(144, 42);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // mcLichDat
            // 
            mcLichDat.Location = new Point(44, 151);
            mcLichDat.Name = "mcLichDat";
            mcLichDat.TabIndex = 7;
            mcLichDat.DateSelected += mcLichDat_DateSelected;
            // 
            // dgvLichDat
            // 
            dgvLichDat.AllowUserToAddRows = false;
            dgvLichDat.AllowUserToDeleteRows = false;
            dgvLichDat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichDat.Location = new Point(489, 146);
            dgvLichDat.MultiSelect = false;
            dgvLichDat.Name = "dgvLichDat";
            dgvLichDat.ReadOnly = true;
            dgvLichDat.RowHeadersWidth = 51;
            dgvLichDat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichDat.Size = new Size(1113, 696);
            dgvLichDat.TabIndex = 8;
            dgvLichDat.CellClick += dgvLichDat_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtThanhToan);
            groupBox1.Controls.Add(TxtTrangThai);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dtpThoiGianDen);
            groupBox1.Controls.Add(dtpThoiGianBatDau);
            groupBox1.Controls.Add(dtpNgaySuDung);
            groupBox1.Controls.Add(dtpNgayDat);
            groupBox1.Controls.Add(TxtLoaiSan);
            groupBox1.Controls.Add(TxtSan);
            groupBox1.Controls.Add(TxtMaPhieu);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TxtTenKhach);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(2, 390);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 416);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // TxtThanhToan
            // 
            TxtThanhToan.Location = new Point(104, 326);
            TxtThanhToan.Name = "TxtThanhToan";
            TxtThanhToan.ReadOnly = true;
            TxtThanhToan.Size = new Size(344, 27);
            TxtThanhToan.TabIndex = 19;
            // 
            // TxtTrangThai
            // 
            TxtTrangThai.Location = new Point(104, 283);
            TxtTrangThai.Name = "TxtTrangThai";
            TxtTrangThai.ReadOnly = true;
            TxtTrangThai.Size = new Size(344, 27);
            TxtTrangThai.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 333);
            label11.Name = "label11";
            label11.Size = new Size(86, 20);
            label11.TabIndex = 17;
            label11.Text = "Thanh toán:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 286);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 16;
            label10.Text = "Trạng thái:";
            // 
            // dtpThoiGianDen
            // 
            dtpThoiGianDen.CustomFormat = "HH:mm";
            dtpThoiGianDen.Enabled = false;
            dtpThoiGianDen.Format = DateTimePickerFormat.Custom;
            dtpThoiGianDen.Location = new Point(296, 223);
            dtpThoiGianDen.Name = "dtpThoiGianDen";
            dtpThoiGianDen.Size = new Size(101, 27);
            dtpThoiGianDen.TabIndex = 15;
            // 
            // dtpThoiGianBatDau
            // 
            dtpThoiGianBatDau.CustomFormat = "HH:mm";
            dtpThoiGianBatDau.Enabled = false;
            dtpThoiGianBatDau.Format = DateTimePickerFormat.Custom;
            dtpThoiGianBatDau.Location = new Point(104, 223);
            dtpThoiGianBatDau.Name = "dtpThoiGianBatDau";
            dtpThoiGianBatDau.Size = new Size(101, 27);
            dtpThoiGianBatDau.TabIndex = 14;
            // 
            // dtpNgaySuDung
            // 
            dtpNgaySuDung.CustomFormat = "dd/MM/yyyy";
            dtpNgaySuDung.Enabled = false;
            dtpNgaySuDung.Format = DateTimePickerFormat.Custom;
            dtpNgaySuDung.Location = new Point(137, 184);
            dtpNgaySuDung.Name = "dtpNgaySuDung";
            dtpNgaySuDung.Size = new Size(181, 27);
            dtpNgaySuDung.TabIndex = 13;
            // 
            // dtpNgayDat
            // 
            dtpNgayDat.CustomFormat = "dd/MM/yyyy";
            dtpNgayDat.Enabled = false;
            dtpNgayDat.Format = DateTimePickerFormat.Custom;
            dtpNgayDat.Location = new Point(137, 151);
            dtpNgayDat.Name = "dtpNgayDat";
            dtpNgayDat.Size = new Size(181, 27);
            dtpNgayDat.TabIndex = 12;
            // 
            // TxtLoaiSan
            // 
            TxtLoaiSan.Location = new Point(104, 118);
            TxtLoaiSan.Name = "TxtLoaiSan";
            TxtLoaiSan.ReadOnly = true;
            TxtLoaiSan.Size = new Size(344, 27);
            TxtLoaiSan.TabIndex = 11;
            // 
            // TxtSan
            // 
            TxtSan.Location = new Point(104, 85);
            TxtSan.Name = "TxtSan";
            TxtSan.ReadOnly = true;
            TxtSan.Size = new Size(344, 27);
            TxtSan.TabIndex = 10;
            // 
            // TxtMaPhieu
            // 
            TxtMaPhieu.Location = new Point(104, 26);
            TxtMaPhieu.Name = "TxtMaPhieu";
            TxtMaPhieu.ReadOnly = true;
            TxtMaPhieu.Size = new Size(344, 27);
            TxtMaPhieu.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(231, 228);
            label9.Name = "label9";
            label9.Size = new Size(36, 20);
            label9.TabIndex = 8;
            label9.Text = "Đến";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 230);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 7;
            label8.Text = "Thời gian:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 152);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 6;
            label7.Text = "Ngày Đặt:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 184);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 5;
            label6.Text = "Ngày sử dụng";
            // 
            // TxtTenKhach
            // 
            TxtTenKhach.Location = new Point(104, 53);
            TxtTenKhach.Name = "TxtTenKhach";
            TxtTenKhach.ReadOnly = true;
            TxtTenKhach.Size = new Size(344, 27);
            TxtTenKhach.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 119);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 3;
            label5.Text = "Loại sân:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 86);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 2;
            label4.Text = "Sân:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 26);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã Phiếu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 0;
            label2.Text = "Khách hàng:";
            // 
            // UCQuanLyLichDat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(dgvLichDat);
            Controls.Add(mcLichDat);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(cboLocTrangThai);
            Controls.Add(cboLocLoaiSan);
            Controls.Add(dtpLocDenNgay);
            Controls.Add(dtpLocTuNgay);
            Controls.Add(label1);
            Name = "UCQuanLyLichDat";
            Size = new Size(1670, 845);
            ((System.ComponentModel.ISupportInitialize)dgvLichDat).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpLocTuNgay;
        private DateTimePicker dtpLocDenNgay;
        private ComboBox cboLocLoaiSan;
        private ComboBox cboLocTrangThai;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private MonthCalendar mcLichDat;
        private DataGridView dgvLichDat;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox TxtTenKhach;
        private Label label10;
        private DateTimePicker dtpThoiGianDen;
        private DateTimePicker dtpThoiGianBatDau;
        private DateTimePicker dtpNgaySuDung;
        private DateTimePicker dtpNgayDat;
        private TextBox TxtLoaiSan;
        private TextBox TxtSan;
        private TextBox TxtMaPhieu;
        private Label label11;
        private TextBox TxtThanhToan;
        private TextBox TxtTrangThai;
    }
}
