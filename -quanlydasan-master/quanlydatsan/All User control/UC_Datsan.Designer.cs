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
            this.pnlTopFilter = new System.Windows.Forms.Panel();
            this.lblGioKetThuc = new System.Windows.Forms.Label();
            this.dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblGioBatDau = new System.Windows.Forms.Label();
            this.dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblNgayChoi = new System.Windows.Forms.Label();
            this.dtpNgayChoi = new System.Windows.Forms.DateTimePicker();
            this.lblLoaiSan = new System.Windows.Forms.Label();
            this.cboLoaiSan = new System.Windows.Forms.ComboBox();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.lblLegendBooked = new System.Windows.Forms.Label();
            this.lblLegendEmpty = new System.Windows.Forms.Label();
            this.pnlRightBooking = new System.Windows.Forms.Panel();
            this.btnXacNhanDat = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTitleTongTien = new System.Windows.Forms.Label();
            this.lblThoiLuong = new System.Windows.Forms.Label();
            this.lblGiaGio = new System.Windows.Forms.Label();
            this.lblLoaiSanChon = new System.Windows.Forms.Label();
            this.lblTenSanChon = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.lblTitleBooking = new System.Windows.Forms.Label();
            this.flpDanhSachSan = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopFilter.SuspendLayout();
            this.pnlLegend.SuspendLayout();
            this.pnlRightBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopFilter
            // 
            this.pnlTopFilter.BackColor = System.Drawing.Color.White;
            this.pnlTopFilter.Controls.Add(this.lblGioKetThuc);
            this.pnlTopFilter.Controls.Add(this.dtpGioKetThuc);
            this.pnlTopFilter.Controls.Add(this.lblGioBatDau);
            this.pnlTopFilter.Controls.Add(this.dtpGioBatDau);
            this.pnlTopFilter.Controls.Add(this.lblNgayChoi);
            this.pnlTopFilter.Controls.Add(this.dtpNgayChoi);
            this.pnlTopFilter.Controls.Add(this.lblLoaiSan);
            this.pnlTopFilter.Controls.Add(this.cboLoaiSan);
            this.pnlTopFilter.Controls.Add(this.pnlLegend);
            this.pnlTopFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlTopFilter.Name = "pnlTopFilter";
            this.pnlTopFilter.Size = new System.Drawing.Size(840, 85);
            this.pnlTopFilter.TabIndex = 0;
            // 
            // lblGioKetThuc
            // 
            this.lblGioKetThuc.AutoSize = true;
            this.lblGioKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblGioKetThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblGioKetThuc.Location = new System.Drawing.Point(455, 14);
            this.lblGioKetThuc.Name = "lblGioKetThuc";
            this.lblGioKetThuc.Size = new System.Drawing.Size(54, 15);
            this.lblGioKetThuc.TabIndex = 6;
            this.lblGioKetThuc.Text = "Đến giờ:";
            // 
            // dtpGioKetThuc
            // 
            this.dtpGioKetThuc.CustomFormat = "HH:mm";
            this.dtpGioKetThuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(458, 35);
            this.dtpGioKetThuc.Name = "dtpGioKetThuc";
            this.dtpGioKetThuc.ShowUpDown = true;
            this.dtpGioKetThuc.Size = new System.Drawing.Size(90, 25);
            this.dtpGioKetThuc.TabIndex = 7;
            this.dtpGioKetThuc.ValueChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // lblGioBatDau
            // 
            this.lblGioBatDau.AutoSize = true;
            this.lblGioBatDau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblGioBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblGioBatDau.Location = new System.Drawing.Point(345, 14);
            this.lblGioBatDau.Name = "lblGioBatDau";
            this.lblGioBatDau.Size = new System.Drawing.Size(46, 15);
            this.lblGioBatDau.TabIndex = 4;
            this.lblGioBatDau.Text = "Từ giờ:";
            // 
            // dtpGioBatDau
            // 
            this.dtpGioBatDau.CustomFormat = "HH:mm";
            this.dtpGioBatDau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioBatDau.Location = new System.Drawing.Point(348, 35);
            this.dtpGioBatDau.Name = "dtpGioBatDau";
            this.dtpGioBatDau.ShowUpDown = true;
            this.dtpGioBatDau.Size = new System.Drawing.Size(90, 25);
            this.dtpGioBatDau.TabIndex = 5;
            this.dtpGioBatDau.ValueChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // lblNgayChoi
            // 
            this.lblNgayChoi.AutoSize = true;
            this.lblNgayChoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblNgayChoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblNgayChoi.Location = new System.Drawing.Point(185, 14);
            this.lblNgayChoi.Name = "lblNgayChoi";
            this.lblNgayChoi.Size = new System.Drawing.Size(64, 15);
            this.lblNgayChoi.TabIndex = 2;
            this.lblNgayChoi.Text = "Ngày chơi:";
            // 
            // dtpNgayChoi
            // 
            this.dtpNgayChoi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgayChoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChoi.Location = new System.Drawing.Point(188, 35);
            this.dtpNgayChoi.Name = "dtpNgayChoi";
            this.dtpNgayChoi.Size = new System.Drawing.Size(140, 25);
            this.dtpNgayChoi.TabIndex = 3;
            this.dtpNgayChoi.ValueChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // lblLoaiSan
            // 
            this.lblLoaiSan.AutoSize = true;
            this.lblLoaiSan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblLoaiSan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLoaiSan.Location = new System.Drawing.Point(17, 14);
            this.lblLoaiSan.Name = "lblLoaiSan";
            this.lblLoaiSan.Size = new System.Drawing.Size(53, 15);
            this.lblLoaiSan.TabIndex = 0;
            this.lblLoaiSan.Text = "Loại sân:";
            // 
            // cboLoaiSan
            // 
            this.cboLoaiSan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoaiSan.FormattingEnabled = true;
            this.cboLoaiSan.Location = new System.Drawing.Point(20, 35);
            this.cboLoaiSan.Name = "cboLoaiSan";
            this.cboLoaiSan.Size = new System.Drawing.Size(150, 25);
            this.cboLoaiSan.TabIndex = 1;
            this.cboLoaiSan.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // pnlLegend
            // 
            this.pnlLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLegend.Controls.Add(this.lblLegendBooked);
            this.pnlLegend.Controls.Add(this.lblLegendEmpty);
            this.pnlLegend.Location = new System.Drawing.Point(600, 25);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(225, 40);
            this.pnlLegend.TabIndex = 8;
            // 
            // lblLegendBooked
            // 
            this.lblLegendBooked.AutoSize = true;
            this.lblLegendBooked.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLegendBooked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblLegendBooked.Location = new System.Drawing.Point(120, 12);
            this.lblLegendBooked.Name = "lblLegendBooked";
            this.lblLegendBooked.Size = new System.Drawing.Size(89, 15);
            this.lblLegendBooked.TabIndex = 1;
            this.lblLegendBooked.Text = "🔴 ĐÃ KÍN SÂN";
            // 
            // lblLegendEmpty
            // 
            this.lblLegendEmpty.AutoSize = true;
            this.lblLegendEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLegendEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblLegendEmpty.Location = new System.Drawing.Point(10, 12);
            this.lblLegendEmpty.Name = "lblLegendEmpty";
            this.lblLegendEmpty.Size = new System.Drawing.Size(95, 15);
            this.lblLegendEmpty.TabIndex = 0;
            this.lblLegendEmpty.Text = "🟢 CÒN TRỐNG";
            // 
            // pnlRightBooking
            // 
            this.pnlRightBooking.BackColor = System.Drawing.Color.White;
            this.pnlRightBooking.Controls.Add(this.btnXacNhanDat);
            this.pnlRightBooking.Controls.Add(this.lblTongTien);
            this.pnlRightBooking.Controls.Add(this.lblTitleTongTien);
            this.pnlRightBooking.Controls.Add(this.lblThoiLuong);
            this.pnlRightBooking.Controls.Add(this.lblGiaGio);
            this.pnlRightBooking.Controls.Add(this.lblLoaiSanChon);
            this.pnlRightBooking.Controls.Add(this.lblTenSanChon);
            this.pnlRightBooking.Controls.Add(this.pnlLine);
            this.pnlRightBooking.Controls.Add(this.lblTitleBooking);
            this.pnlRightBooking.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightBooking.Location = new System.Drawing.Point(540, 85);
            this.pnlRightBooking.Name = "pnlRightBooking";
            this.pnlRightBooking.Padding = new System.Windows.Forms.Padding(20);
            this.pnlRightBooking.Size = new System.Drawing.Size(260, 515);
            this.pnlRightBooking.TabIndex = 2;
            // 
            // btnXacNhanDat
            // 
            this.btnXacNhanDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnXacNhanDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhanDat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnXacNhanDat.Enabled = false;
            this.btnXacNhanDat.FlatAppearance.BorderSize = 0;
            this.btnXacNhanDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanDat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanDat.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanDat.Location = new System.Drawing.Point(20, 447);
            this.btnXacNhanDat.Name = "btnXacNhanDat";
            this.btnXacNhanDat.Size = new System.Drawing.Size(260, 48);
            this.btnXacNhanDat.TabIndex = 8;
            this.btnXacNhanDat.Text = "XÁC NHẬN ĐẶT SÂN";
            this.btnXacNhanDat.UseVisualStyleBackColor = false;
            this.btnXacNhanDat.Click += new System.EventHandler(this.btnXacNhanDat_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTongTien.Location = new System.Drawing.Point(20, 315);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(260, 30);
            this.lblTongTien.TabIndex = 7;
            this.lblTongTien.Text = "0 VNĐ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleTongTien
            // 
            this.lblTitleTongTien.AutoSize = true;
            this.lblTitleTongTien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblTitleTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTitleTongTien.Location = new System.Drawing.Point(20, 290);
            this.lblTitleTongTien.Name = "lblTitleTongTien";
            this.lblTitleTongTien.Size = new System.Drawing.Size(126, 17);
            this.lblTitleTongTien.TabIndex = 6;
            this.lblTitleTongTien.Text = "Tổng tiền tạm tính:";
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.AutoSize = true;
            this.lblThoiLuong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblThoiLuong.Location = new System.Drawing.Point(20, 235);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(130, 17);
            this.lblThoiLuong.TabIndex = 5;
            this.lblThoiLuong.Text = "Thời lượng: Chưa chọn";
            // 
            // lblGiaGio
            // 
            this.lblGiaGio.AutoSize = true;
            this.lblGiaGio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGiaGio.Location = new System.Drawing.Point(20, 195);
            this.lblGiaGio.Name = "lblGiaGio";
            this.lblGiaGio.Size = new System.Drawing.Size(89, 17);
            this.lblGiaGio.TabIndex = 4;
            this.lblGiaGio.Text = "Đơn giá/giờ: --";
            // 
            // lblLoaiSanChon
            // 
            this.lblLoaiSanChon.AutoSize = true;
            this.lblLoaiSanChon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLoaiSanChon.Location = new System.Drawing.Point(20, 155);
            this.lblLoaiSanChon.Name = "lblLoaiSanChon";
            this.lblLoaiSanChon.Size = new System.Drawing.Size(107, 17);
            this.lblLoaiSanChon.TabIndex = 3;
            this.lblLoaiSanChon.Text = "Loại sân: Chưa chọn";
            // 
            // lblTenSanChon
            // 
            this.lblTenSanChon.AutoSize = true;
            this.lblTenSanChon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTenSanChon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTenSanChon.Location = new System.Drawing.Point(19, 115);
            this.lblTenSanChon.Name = "lblTenSanChon";
            this.lblTenSanChon.Size = new System.Drawing.Size(176, 21);
            this.lblTenSanChon.TabIndex = 2;
            this.lblTenSanChon.Text = "Chưa chọn sân nào";
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlLine.Location = new System.Drawing.Point(20, 85);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(260, 1);
            this.pnlLine.TabIndex = 1;
            // 
            // lblTitleBooking
            // 
            this.lblTitleBooking.AutoSize = true;
            this.lblTitleBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitleBooking.Location = new System.Drawing.Point(19, 30);
            this.lblTitleBooking.Name = "lblTitleBooking";
            this.lblTitleBooking.Size = new System.Drawing.Size(174, 21);
            this.lblTitleBooking.TabIndex = 0;
            this.lblTitleBooking.Text = "THÔNG TIN ĐẶT SÂN";
            // 
            // flpDanhSachSan
            // 
            this.flpDanhSachSan.AutoScroll = true;
            this.flpDanhSachSan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.flpDanhSachSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDanhSachSan.Location = new System.Drawing.Point(0, 85);
            this.flpDanhSachSan.Name = "flpDanhSachSan";
            this.flpDanhSachSan.Padding = new System.Windows.Forms.Padding(15);
            this.flpDanhSachSan.Size = new System.Drawing.Size(540, 515);
            this.flpDanhSachSan.TabIndex = 1;
            // 
            // UC_Datsan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpDanhSachSan);
            this.Controls.Add(this.pnlRightBooking);
            this.Controls.Add(this.pnlTopFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "UC_Datsan";
            this.Size = new System.Drawing.Size(840, 600);
            this.Load += new System.EventHandler(this.UC_Datsan_Load);
            this.pnlTopFilter.ResumeLayout(false);
            this.pnlTopFilter.PerformLayout();
            this.pnlLegend.ResumeLayout(false);
            this.pnlLegend.PerformLayout();
            this.pnlRightBooking.ResumeLayout(false);
            this.pnlRightBooking.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopFilter;
        private System.Windows.Forms.ComboBox cboLoaiSan;
        private System.Windows.Forms.Label lblLoaiSan;
        private System.Windows.Forms.Label lblNgayChoi;
        private System.Windows.Forms.DateTimePicker dtpNgayChoi;
        private System.Windows.Forms.Label lblGioBatDau;
        private System.Windows.Forms.DateTimePicker dtpGioBatDau;
        private System.Windows.Forms.Label lblGioKetThuc;
        private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
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
    }
}