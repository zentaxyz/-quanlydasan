using quanlydatsan.Class;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace quanlydatsan.All_User_control
{
    public partial class UC_Datsan : UserControl
    {
        private readonly DatabaseC db = new DatabaseC();
        private bool isLoading = false; // Cờ khóa chống đệ quy giao diện

        // Thông tin sân đang được chọn
        private string selectedMaSan = "";
        private string selectedTenSan = "";
        private decimal selectedGiaGio = 0;
        private decimal tongTienTamTinh = 0;

        public UC_Datsan()
        {
            InitializeComponent();
        }

        #region 1. Khởi tạo & Nạp danh mục Loại Sân
        private void UC_Datsan_Load(object sender, EventArgs e)
        {
            dtpNgayChoi.MinDate = DateTime.Today;
            dtpNgayChoi.Value = DateTime.Today;
            dtpGioBatDau.Value = DateTime.Today.AddHours(17);
            dtpGioKetThuc.Value = DateTime.Today.AddHours(18.5); // 18:30

            // Chỉ co giãn chiều rộng thẻ khi đổi kích thước màn hình (không gọi lại SQL)
            this.SizeChanged += (s, args) => CapNhatKichThuocThe();

            LoadLoaiSan();
            LoadDanhSachSan();
        }

        private void LoadLoaiSan()
        {
            cboLoaiSan.Items.Clear();
            cboLoaiSan.Items.Add("Tất cả loại sân");

            DataSet ds = db.GetData("SELECT TenLoaiSan FROM LoaiSan");
            if (ds?.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                    cboLoaiSan.Items.Add(row["TenLoaiSan"].ToString());
            }
            cboLoaiSan.SelectedIndex = 0;
        }
        #endregion

        #region 2. Truy vấn & Hiển thị Sơ đồ Sân (2 Cột)
        private void Filter_Changed(object sender, EventArgs e)
        {
            ResetSelection();
            LoadDanhSachSan();
        }

        public void LoadDanhSachSan()
        {
            if (isLoading) return;
            isLoading = true;
            flpDanhSachSan.SuspendLayout();

            try
            {
                flpDanhSachSan.Controls.Clear();

                // Kiểm tra hợp lệ thời gian
                if (dtpGioKetThuc.Value <= dtpGioBatDau.Value)
                {
                    lblThoiLuong.Text = "Thời lượng: Giờ kết thúc phải lớn hơn bắt đầu!";
                    lblThoiLuong.ForeColor = Color.Red;
                    btnXacNhanDat.Enabled = false;
                    return;
                }
                lblThoiLuong.ForeColor = Color.FromArgb(30, 41, 59);

                string ngay = dtpNgayChoi.Value.ToString("yyyy-MM-dd");
                string bd = dtpGioBatDau.Value.ToString("HH:mm:ss");
                string kt = dtpGioKetThuc.Value.ToString("HH:mm:ss");
                string locLoai = cboLoaiSan.SelectedIndex > 0
                    ? $" AND ls.TenLoaiSan = N'{cboLoaiSan.SelectedItem.ToString().Replace("'", "''")}'"
                    : "";

                // Kiểm tra trùng lịch (Bỏ qua các phiếu đã hủy 'TT04')
                string query = $@"
                    SELECT s.MaSan, s.TenSan, ls.TenLoaiSan, ls.GiaTheoGio,
                           CASE WHEN EXISTS (
                               SELECT 1 FROM PhieuDatSan p
                               WHERE p.MaSan = s.MaSan 
                                 AND CAST(p.NgaySuDung AS DATE) = '{ngay}'
                                 AND RTRIM(p.MaTrangThai) <> 'TT03'
                                 AND (p.ThoiGianBatDau < '{kt}' AND p.ThoiGianKetThuc > '{bd}')
                           ) THEN 1 ELSE 0 END AS DaDat
                    FROM San s
                    JOIN LoaiSan ls ON s.MaLoaiSan = ls.MaLoaiSan
                    WHERE 1 = 1 {locLoai}
                    ORDER BY s.TenSan ASC";

                DataSet ds = db.GetData(query);
                if (ds?.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    flpDanhSachSan.Controls.Add(new Label
                    {
                        Text = "Không có sân nào phù hợp với bộ lọc!",
                        Font = new Font("Segoe UI", 11F, FontStyle.Italic),
                        ForeColor = Color.Gray,
                        AutoSize = true,
                        Padding = new Padding(20)
                    });
                    return;
                }

                int cardWidth = TinhChieuRongThe();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Panel card = TaoTheSan(
                        row["MaSan"].ToString(),
                        row["TenSan"].ToString(),
                        row["TenLoaiSan"].ToString(),
                        Convert.ToDecimal(row["GiaTheoGio"]),
                        Convert.ToInt32(row["DaDat"]) == 1,
                        cardWidth
                    );
                    flpDanhSachSan.Controls.Add(card);
                }
            }
            finally
            {
                flpDanhSachSan.ResumeLayout();
                isLoading = false;
            }
        }

        private Panel TaoTheSan(string maSan, string tenSan, string tenLoai, decimal giaGio, bool isBooked, int cardWidth)
        {
            Color statusColor = isBooked ? Color.FromArgb(239, 68, 68) : Color.FromArgb(34, 197, 94);
            string icon = tenLoai.ToLower() switch
            {
                string s when s.Contains("bóng") => "⚽",
                string s when s.Contains("cầu lông") => "🏸",
                string s when s.Contains("tennis") || s.Contains("pickleball") => "🎾",
                _ => "🏟️"
            };

            Panel card = new Panel
            {
                Size = new Size(cardWidth, 150),
                Margin = new Padding(4, 5, 4, 5),
                BackColor = Color.White,
                Cursor = isBooked ? Cursors.Default : Cursors.Hand
            };

            Panel pnlBar = new Panel { Dock = DockStyle.Left, Width = 5, BackColor = statusColor };
            Label lblTitle = new Label { Text = $"{icon}  {tenSan}", Font = new Font("Segoe UI", 10.5F, FontStyle.Bold), ForeColor = Color.FromArgb(30, 41, 59), Location = new Point(12, 10), AutoSize = true };
            Label lblLoai = new Label { Text = $"Loại: {tenLoai}", Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(100, 116, 139), Location = new Point(14, 34), AutoSize = true };
            Label lblGia = new Label { Text = $"Giá: {giaGio:N0} đ/giờ", Font = new Font("Segoe UI", 9F, FontStyle.Bold), ForeColor = Color.FromArgb(15, 23, 42), Location = new Point(14, 55), AutoSize = true };
            Label lblBadge = new Label { Text = isBooked ? "🔴 ĐÃ KÍN SÂN" : "🟢 CÒN TRỐNG", Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), ForeColor = statusColor, Location = new Point(14, 78), AutoSize = true };

            Button btnChon = new Button
            {
                Text = isBooked ? "Đã có người đặt" : "Chọn đặt sân",
                Enabled = !isBooked,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = isBooked ? Color.FromArgb(203, 213, 225) : Color.FromArgb(22, 163, 74),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(12, 105),
                Size = new Size(cardWidth - 24, 32)
            };
            btnChon.FlatAppearance.BorderSize = 0;

            if (!isBooked)
            {
                EventHandler onSelect = (s, e) => ChonSanDat(maSan, tenSan, tenLoai, giaGio);
                btnChon.Click += onSelect;
                card.Click += onSelect;
            }

            card.Controls.AddRange(new Control[] { pnlBar, lblTitle, lblLoai, lblGia, lblBadge, btnChon });
            return card;
        }
        #endregion

        #region 3. Chọn Sân & Tính Tiền Tạm Tính
        private void ChonSanDat(string maSan, string tenSan, string tenLoai, decimal giaGio)
        {
            double totalHours = (dtpGioKetThuc.Value.TimeOfDay - dtpGioBatDau.Value.TimeOfDay).TotalHours;
            if (totalHours <= 0)
            {
                MessageBox.Show("Giờ kết thúc phải lớn hơn giờ bắt đầu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedMaSan = maSan;
            selectedTenSan = tenSan;
            selectedGiaGio = giaGio;
            tongTienTamTinh = (decimal)totalHours * giaGio;

            lblTenSanChon.Text = $"Sân: {tenSan}";
            lblLoaiSanChon.Text = $"Loại sân: {tenLoai}";
            lblGiaGio.Text = $"Đơn giá: {giaGio:N0} đ/giờ";
            lblThoiLuong.Text = $"Thời lượng: {totalHours:0.##} giờ ({dtpGioBatDau.Value:HH:mm} - {dtpGioKetThuc.Value:HH:mm})";
            lblTongTien.Text = $"{tongTienTamTinh:N0} VNĐ";
            btnXacNhanDat.Enabled = true;
        }

        private void ResetSelection()
        {
            selectedMaSan = "";
            tongTienTamTinh = 0;
            lblTenSanChon.Text = "Chưa chọn sân nào";
            lblLoaiSanChon.Text = "Loại sân: Chưa chọn";
            lblGiaGio.Text = "Đơn giá/giờ: --";
            lblThoiLuong.Text = "Thời lượng: Chưa chọn";
            lblTongTien.Text = "0 VNĐ";
            btnXacNhanDat.Enabled = false;
        }
        #endregion

        #region 4. Lưu Phiếu Đặt Sân & Xuất Biên Nhận
        /// <summary>
        /// Hàm tự động lấy số thứ tự lớn nhất sau chữ 'PD' rồi cộng thêm 1 (Ví dụ: PD01, PD02...)
        /// </summary>
        private string TaoMaPhieuTuDong()
        {
            string sql = @"
                SELECT ISNULL(MAX(TRY_CAST(SUBSTRING(MaPhieu, 3, LEN(MaPhieu)) AS INT)), 0) + 1 
                FROM PhieuDatSan 
                WHERE MaPhieu LIKE 'PD%'";

            DataSet ds = db.GetData(sql);
            int stt = (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                ? Convert.ToInt32(ds.Tables[0].Rows[0][0])
                : 1;

            return $"PD {stt:D3}"; // D2: PD01, PD02... (Nếu muốn PD1, PD2 thì đổi thành $"PD{stt}")
        }

        private void btnXacNhanDat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaSan) || string.IsNullOrEmpty(Session.UserId))
            {
                MessageBox.Show("Vui lòng chọn sân hoặc kiểm tra lại phiên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ngay = dtpNgayChoi.Value.ToString("yyyy-MM-dd");
            string bd = dtpGioBatDau.Value.ToString("HH:mm:ss");
            string kt = dtpGioKetThuc.Value.ToString("HH:mm:ss");

            // 1. Kiểm tra xung đột lần cuối trước khi INSERT
            string checkSql = $@"
                SELECT 1 FROM PhieuDatSan 
                WHERE MaSan = '{selectedMaSan}' AND CAST(NgaySuDung AS DATE) = '{ngay}'
                  AND RTRIM(MaTrangThai) <> 'TT03'
                  AND (ThoiGianBatDau < '{kt}' AND ThoiGianKetThuc > '{bd}')";

            if (db.GetData(checkSql)?.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Sân này vừa có người đặt! Vui lòng chọn khung giờ khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadDanhSachSan();
                return;
            }

            // 2. Sinh mã phiếu tự động (PD + số stt tăng dần: PD01, PD02...)
            string maPhieu = TaoMaPhieuTuDong();
            string tienSql = tongTienTamTinh.ToString(CultureInfo.InvariantCulture);

            // 3. Lưu vào bảng PhieuDatSan (TT01: Đã đặt sân, 0: Chưa thanh toán)
            string insertSql = $@"
                INSERT INTO PhieuDatSan (MaPhieu, MaKhach, MaSan, NgayDat, NgaySuDung, ThoiGianBatDau, ThoiGianKetThuc, TongTien, MaTrangThai, XacNhanThanhToan)
                VALUES ('{maPhieu}', '{Session.UserId}', '{selectedMaSan}', CAST(GETDATE() AS DATE), '{ngay}', '{bd}', '{kt}', {tienSql}, 'TT01', 0)";

            db.setData(insertSql, $"Đặt sân thành công! Mã phiếu: {maPhieu}");

            // 4. HIỂN THỊ HƯỚNG DẪN THANH TOÁN VÀ GỬI ẢNH ZALO
            FormThanhToan frmTT = new FormThanhToan(maPhieu, tongTienTamTinh);
            frmTT.ShowDialog();

            ResetSelection();
            LoadDanhSachSan();
        }
        #endregion

        #region 5. Tự động chia đều 2 cột khi phóng to / thu nhỏ
        private int TinhChieuRongThe()
        {
            int w = flpDanhSachSan.ClientSize.Width > 0 ? flpDanhSachSan.ClientSize.Width : flpDanhSachSan.Width;
            return Math.Max(200, ((w - 45) / 2) - 8);
        }

        private void CapNhatKichThuocThe()
        {
            if (isLoading || flpDanhSachSan.Controls.Count == 0) return;

            int cardWidth = TinhChieuRongThe();
            flpDanhSachSan.SuspendLayout();
            foreach (Control c in flpDanhSachSan.Controls)
            {
                if (c is Panel card)
                {
                    card.Width = cardWidth;
                    foreach (Control sub in card.Controls)
                        if (sub is Button btn) btn.Width = cardWidth - 24;
                }
            }
            flpDanhSachSan.ResumeLayout();
        }
        #endregion

        private void pnlTopFilter_Paint(object sender, PaintEventArgs e)
        {
            // Giữ lại sự kiện Paint đã được khai báo bên trong Designer để không báo lỗi biên dịch
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            LoadDanhSachSan();
        }
    }
}