namespace quanlydatsan.All_User_control
{
    partial class UC_Datsan
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
            pnlTopFilter = new Panel();
            btnRe = new Button();
            dtpGioKetThuc = new DateTimePicker30Phut();
            dtpGioBatDau = new DateTimePicker30Phut();
            lblGioKetThuc = new Label();
            lblGioBatDau = new Label();
            lblNgayChoi = new Label();
            dtpNgayChoi = new DateTimePicker();
            lblLoaiSan = new Label();
            cboLoaiSan = new ComboBox();
            pnlLegend = new Panel();
            lblLegendBooked = new Label();
            lblLegendEmpty = new Label();
            pnlRightBooking = new Panel();
            btnXacNhanDat = new Button();
            lblTongTien = new Label();
            lblTitleTongTien = new Label();
            lblThoiLuong = new Label();
            lblGiaGio = new Label();
            lblLoaiSanChon = new Label();
            lblTenSanChon = new Label();
            pnlLine = new Panel();
            lblTitleBooking = new Label();
            flpDanhSachSan = new FlowLayoutPanel();
            pnlTopFilter.SuspendLayout();
            pnlLegend.SuspendLayout();
            pnlRightBooking.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopFilter
            // 
            pnlTopFilter.BackColor = Color.White;
            pnlTopFilter.Controls.Add(btnRe);
            pnlTopFilter.Controls.Add(dtpGioKetThuc);
            pnlTopFilter.Controls.Add(dtpGioBatDau);
            pnlTopFilter.Controls.Add(lblGioKetThuc);
            pnlTopFilter.Controls.Add(lblGioBatDau);
            pnlTopFilter.Controls.Add(lblNgayChoi);
            pnlTopFilter.Controls.Add(dtpNgayChoi);
            pnlTopFilter.Controls.Add(lblLoaiSan);
            pnlTopFilter.Controls.Add(cboLoaiSan);
            pnlTopFilter.Controls.Add(pnlLegend);
            pnlTopFilter.Dock = DockStyle.Top;
            pnlTopFilter.Location = new Point(0, 0);
            pnlTopFilter.Name = "pnlTopFilter";
            pnlTopFilter.Size = new Size(840, 85);
            pnlTopFilter.TabIndex = 0;
            pnlTopFilter.Paint += pnlTopFilter_Paint;
            // 
            // btnRe
            // 
            btnRe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRe.Location = new Point(553, 35);
            btnRe.Name = "btnRe";
            btnRe.Size = new Size(27, 25);
            btnRe.TabIndex = 10;
            btnRe.Text = "🔄";
            btnRe.UseVisualStyleBackColor = true;
            btnRe.Click += btnRe_Click;
            // 
            // dtpGioKetThuc
            // 
            dtpGioKetThuc.CustomFormat = "HH:mm";
            dtpGioKetThuc.Format = DateTimePickerFormat.Custom;
            dtpGioKetThuc.Location = new Point(455, 35);
            dtpGioKetThuc.Name = "dtpGioKetThuc";
            dtpGioKetThuc.ShowUpDown = true;
            dtpGioKetThuc.Size = new Size(90, 24);
            dtpGioKetThuc.TabIndex = 9;
            // 
            // dtpGioBatDau
            // 
            dtpGioBatDau.CustomFormat = "HH:mm";
            dtpGioBatDau.Format = DateTimePickerFormat.Custom;
            dtpGioBatDau.Location = new Point(345, 35);
            dtpGioBatDau.Name = "dtpGioBatDau";
            dtpGioBatDau.ShowUpDown = true;
            dtpGioBatDau.Size = new Size(90, 24);
            dtpGioBatDau.TabIndex = 0;
            // 
            // lblGioKetThuc
            // 
            lblGioKetThuc.AutoSize = true;
            lblGioKetThuc.Font = new Font("Segoe UI", 9F);
            lblGioKetThuc.ForeColor = Color.FromArgb(71, 85, 105);
            lblGioKetThuc.Location = new Point(455, 14);
            lblGioKetThuc.Name = "lblGioKetThuc";
            lblGioKetThuc.Size = new Size(51, 15);
            lblGioKetThuc.TabIndex = 6;
            lblGioKetThuc.Text = "Đến giờ:";
            // 
            // lblGioBatDau
            // 
            lblGioBatDau.AutoSize = true;
            lblGioBatDau.Font = new Font("Segoe UI", 9F);
            lblGioBatDau.ForeColor = Color.FromArgb(71, 85, 105);
            lblGioBatDau.Location = new Point(345, 14);
            lblGioBatDau.Name = "lblGioBatDau";
            lblGioBatDau.Size = new Size(44, 15);
            lblGioBatDau.TabIndex = 4;
            lblGioBatDau.Text = "Từ giờ:";
            // 
            // lblNgayChoi
            // 
            lblNgayChoi.AutoSize = true;
            lblNgayChoi.Font = new Font("Segoe UI", 9F);
            lblNgayChoi.ForeColor = Color.FromArgb(71, 85, 105);
            lblNgayChoi.Location = new Point(185, 14);
            lblNgayChoi.Name = "lblNgayChoi";
            lblNgayChoi.Size = new Size(64, 15);
            lblNgayChoi.TabIndex = 2;
            lblNgayChoi.Text = "Ngày chơi:";
            // 
            // dtpNgayChoi
            // 
            dtpNgayChoi.CustomFormat = "dd/MM/yyyy";
            dtpNgayChoi.Font = new Font("Segoe UI", 10F);
            dtpNgayChoi.Format = DateTimePickerFormat.Custom;
            dtpNgayChoi.Location = new Point(188, 35);
            dtpNgayChoi.Name = "dtpNgayChoi";
            dtpNgayChoi.Size = new Size(140, 25);
            dtpNgayChoi.TabIndex = 3;
            dtpNgayChoi.ValueChanged += Filter_Changed;
            // 
            // lblLoaiSan
            // 
            lblLoaiSan.AutoSize = true;
            lblLoaiSan.Font = new Font("Segoe UI", 9F);
            lblLoaiSan.ForeColor = Color.FromArgb(71, 85, 105);
            lblLoaiSan.Location = new Point(17, 14);
            lblLoaiSan.Name = "lblLoaiSan";
            lblLoaiSan.Size = new Size(53, 15);
            lblLoaiSan.TabIndex = 0;
            lblLoaiSan.Text = "Loại sân:";
            // 
            // cboLoaiSan
            // 
            cboLoaiSan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSan.Font = new Font("Segoe UI", 10F);
            cboLoaiSan.FormattingEnabled = true;
            cboLoaiSan.Location = new Point(20, 35);
            cboLoaiSan.Name = "cboLoaiSan";
            cboLoaiSan.Size = new Size(150, 25);
            cboLoaiSan.TabIndex = 1;
            cboLoaiSan.SelectedIndexChanged += Filter_Changed;
            // 
            // pnlLegend
            // 
            pnlLegend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlLegend.Controls.Add(lblLegendBooked);
            pnlLegend.Controls.Add(lblLegendEmpty);
            pnlLegend.Location = new Point(600, 25);
            pnlLegend.Name = "pnlLegend";
            pnlLegend.Size = new Size(225, 40);
            pnlLegend.TabIndex = 8;
            // 
            // lblLegendBooked
            // 
            lblLegendBooked.AutoSize = true;
            lblLegendBooked.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLegendBooked.ForeColor = Color.FromArgb(220, 38, 38);
            lblLegendBooked.Location = new Point(120, 12);
            lblLegendBooked.Name = "lblLegendBooked";
            lblLegendBooked.Size = new Size(91, 15);
            lblLegendBooked.TabIndex = 1;
            lblLegendBooked.Text = "🔴 ĐÃ KÍN SÂN";
            // 
            // lblLegendEmpty
            // 
            lblLegendEmpty.AutoSize = true;
            lblLegendEmpty.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLegendEmpty.ForeColor = Color.FromArgb(22, 163, 74);
            lblLegendEmpty.Location = new Point(10, 12);
            lblLegendEmpty.Name = "lblLegendEmpty";
            lblLegendEmpty.Size = new Size(93, 15);
            lblLegendEmpty.TabIndex = 0;
            lblLegendEmpty.Text = "\U0001f7e2 CÒN TRỐNG";
            // 
            // pnlRightBooking
            // 
            pnlRightBooking.BackColor = Color.White;
            pnlRightBooking.Controls.Add(btnXacNhanDat);
            pnlRightBooking.Controls.Add(lblTongTien);
            pnlRightBooking.Controls.Add(lblTitleTongTien);
            pnlRightBooking.Controls.Add(lblThoiLuong);
            pnlRightBooking.Controls.Add(lblGiaGio);
            pnlRightBooking.Controls.Add(lblLoaiSanChon);
            pnlRightBooking.Controls.Add(lblTenSanChon);
            pnlRightBooking.Controls.Add(pnlLine);
            pnlRightBooking.Controls.Add(lblTitleBooking);
            pnlRightBooking.Dock = DockStyle.Right;
            pnlRightBooking.Location = new Point(580, 85);
            pnlRightBooking.Name = "pnlRightBooking";
            pnlRightBooking.Padding = new Padding(20);
            pnlRightBooking.Size = new Size(260, 515);
            pnlRightBooking.TabIndex = 2;
            // 
            // btnXacNhanDat
            // 
            btnXacNhanDat.BackColor = Color.FromArgb(22, 163, 74);
            btnXacNhanDat.Cursor = Cursors.Hand;
            btnXacNhanDat.Dock = DockStyle.Bottom;
            btnXacNhanDat.Enabled = false;
            btnXacNhanDat.FlatAppearance.BorderSize = 0;
            btnXacNhanDat.FlatStyle = FlatStyle.Flat;
            btnXacNhanDat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnXacNhanDat.ForeColor = Color.White;
            btnXacNhanDat.Location = new Point(20, 447);
            btnXacNhanDat.Name = "btnXacNhanDat";
            btnXacNhanDat.Size = new Size(220, 48);
            btnXacNhanDat.TabIndex = 8;
            btnXacNhanDat.Text = "XÁC NHẬN ĐẶT SÂN";
            btnXacNhanDat.UseVisualStyleBackColor = false;
            btnXacNhanDat.Click += btnXacNhanDat_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.FromArgb(220, 38, 38);
            lblTongTien.Location = new Point(20, 315);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(260, 30);
            lblTongTien.TabIndex = 7;
            lblTongTien.Text = "0 VNĐ";
            lblTongTien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitleTongTien
            // 
            lblTitleTongTien.AutoSize = true;
            lblTitleTongTien.Font = new Font("Segoe UI", 9.5F);
            lblTitleTongTien.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitleTongTien.Location = new Point(20, 290);
            lblTitleTongTien.Name = "lblTitleTongTien";
            lblTitleTongTien.Size = new Size(117, 17);
            lblTitleTongTien.TabIndex = 6;
            lblTitleTongTien.Text = "Tổng tiền tạm tính:";
            // 
            // lblThoiLuong
            // 
            lblThoiLuong.AutoSize = true;
            lblThoiLuong.Font = new Font("Segoe UI", 9.5F);
            lblThoiLuong.Location = new Point(20, 235);
            lblThoiLuong.Name = "lblThoiLuong";
            lblThoiLuong.Size = new Size(140, 17);
            lblThoiLuong.TabIndex = 5;
            lblThoiLuong.Text = "Thời lượng: Chưa chọn";
            // 
            // lblGiaGio
            // 
            lblGiaGio.AutoSize = true;
            lblGiaGio.Font = new Font("Segoe UI", 9.5F);
            lblGiaGio.Location = new Point(20, 195);
            lblGiaGio.Name = "lblGiaGio";
            lblGiaGio.Size = new Size(95, 17);
            lblGiaGio.TabIndex = 4;
            lblGiaGio.Text = "Đơn giá/giờ: --";
            // 
            // lblLoaiSanChon
            // 
            lblLoaiSanChon.AutoSize = true;
            lblLoaiSanChon.Font = new Font("Segoe UI", 9.5F);
            lblLoaiSanChon.Location = new Point(20, 155);
            lblLoaiSanChon.Name = "lblLoaiSanChon";
            lblLoaiSanChon.Size = new Size(125, 17);
            lblLoaiSanChon.TabIndex = 3;
            lblLoaiSanChon.Text = "Loại sân: Chưa chọn";
            // 
            // lblTenSanChon
            // 
            lblTenSanChon.AutoSize = true;
            lblTenSanChon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTenSanChon.ForeColor = Color.FromArgb(30, 41, 59);
            lblTenSanChon.Location = new Point(19, 115);
            lblTenSanChon.Name = "lblTenSanChon";
            lblTenSanChon.Size = new Size(155, 21);
            lblTenSanChon.TabIndex = 2;
            lblTenSanChon.Text = "Chưa chọn sân nào";
            // 
            // pnlLine
            // 
            pnlLine.BackColor = Color.FromArgb(226, 232, 240);
            pnlLine.Location = new Point(20, 85);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(260, 1);
            pnlLine.TabIndex = 1;
            // 
            // lblTitleBooking
            // 
            lblTitleBooking.AutoSize = true;
            lblTitleBooking.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitleBooking.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitleBooking.Location = new Point(19, 30);
            lblTitleBooking.Name = "lblTitleBooking";
            lblTitleBooking.Size = new Size(171, 21);
            lblTitleBooking.TabIndex = 0;
            lblTitleBooking.Text = "THÔNG TIN ĐẶT SÂN";
            // 
            // flpDanhSachSan
            // 
            flpDanhSachSan.AutoScroll = true;
            flpDanhSachSan.BackColor = Color.FromArgb(241, 245, 249);
            flpDanhSachSan.Dock = DockStyle.Fill;
            flpDanhSachSan.Location = new Point(0, 85);
            flpDanhSachSan.Name = "flpDanhSachSan";
            flpDanhSachSan.Padding = new Padding(15);
            flpDanhSachSan.Size = new Size(580, 515);
            flpDanhSachSan.TabIndex = 1;
            // 
            // UC_Datsan
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpDanhSachSan);
            Controls.Add(pnlRightBooking);
            Controls.Add(pnlTopFilter);
            Font = new Font("Segoe UI", 9.5F);
            Name = "UC_Datsan";
            Size = new Size(840, 600);
            Load += UC_Datsan_Load;
            pnlTopFilter.ResumeLayout(false);
            pnlTopFilter.PerformLayout();
            pnlLegend.ResumeLayout(false);
            pnlLegend.PerformLayout();
            pnlRightBooking.ResumeLayout(false);
            pnlRightBooking.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopFilter;
        private System.Windows.Forms.ComboBox cboLoaiSan;
        private System.Windows.Forms.Label lblLoaiSan;
        private System.Windows.Forms.Label lblNgayChoi;
        private System.Windows.Forms.DateTimePicker dtpNgayChoi;
        private System.Windows.Forms.Label lblGioBatDau;
        private System.Windows.Forms.Label lblGioKetThuc;
        private System.Windows.Forms.DateTimePicker dateTimePicker30Phut2;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Label lblLegendEmpty;
        private System.Windows.Forms.Label lblLegendBooked;
        private System.Windows.Forms.Panel pnlRightBooking;
        private System.Windows.Forms.Label lblTitleBooking;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Label lblTenSanChon;
        private System.Windows.Forms.Label lblLoaiSanChon;
        private System.Windows.Forms.Label lblGiaGio;
        private System.Windows.Forms.Label lblThoiLuong;
        private System.Windows.Forms.Label lblTitleTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnXacNhanDat;
        private System.Windows.Forms.FlowLayoutPanel flpDanhSachSan;
        private DateTimePicker30Phut dtpGioKetThuc;
        private DateTimePicker30Phut dtpGioBatDau;
        private Button btnRe;
    }
}