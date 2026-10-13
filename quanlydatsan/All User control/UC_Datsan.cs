using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace quanlydatsan.All_User_control
{
    public partial class UC_Datsan : UserControl
    {
        private readonly Database db = new Database();

        // Biến lưu thông tin sân đang được chọn
        private string selectedMaSan = "";
        private string selectedTenSan = "";
        private string selectedTenLoaiSan = "";
        private decimal selectedGiaGio = 0;
        private decimal tongTienTamTinh = 0;

        public UC_Datsan()
        {
            InitializeComponent();
        }

        private void UC_Datsan_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị mặc định cho thời gian chơi
            dtpNgayChoi.MinDate = DateTime.Today; // Không cho đặt ngày trong quá khứ
            dtpNgayChoi.Value = DateTime.Today;

            // Mặc định đặt từ 17:00 đến 18:30 (Khung giờ đá bóng/chơi thể thao phổ biến)
            dtpGioBatDau.Value = DateTime.Today.AddHours(17);
            dtpGioKetThuc.Value = DateTime.Today.AddHours(18).AddMinutes(30);

            // Nạp danh sách loại sân
            LoadLoaiSan();

            // Tải sơ đồ sân theo bộ lọc mặc định
            LoadDanhSachSan();
            flpDanhSachSan.SizeChanged += (s, args) => LoadDanhSachSan();
        }

        #region 1. Nạp danh mục Loại Sân vào ComboBox
        private void LoadLoaiSan()
        {
            cboLoaiSan.Items.Clear();
            cboLoaiSan.Items.Add("Tất cả loại sân");

            string query = "SELECT MaLoaiSan, TenLoaiSan FROM LoaiSan";
            DataSet ds = db.GetData(query);

            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cboLoaiSan.Items.Add(row["TenLoaiSan"].ToString());
                }
            }

            cboLoaiSan.SelectedIndex = 0;
        }
        #endregion

        #region 2. Lọc và Vẽ các Card Sân kèm Icon trạng thái
        private void Filter_Changed(object sender, EventArgs e)
        {
            // Reset thông tin sân chọn khi thay đổi bộ lọc ngày/giờ
            ResetSelection();
            LoadDanhSachSan();
        }

        public void LoadDanhSachSan()
        {
            flpDanhSachSan.Controls.Clear();
            flpDanhSachSan.FlowDirection = FlowDirection.LeftToRight;
            flpDanhSachSan.WrapContents = true;
            flpDanhSachSan.AutoScroll = true;

            // 1. Lấy thông tin ngày giờ lọc
            string ngayChoi = dtpNgayChoi.Value.ToString("yyyy-MM-dd");
            string gioBatDau = dtpGioBatDau.Value.ToString("HH:mm:ss");
            string gioKetThuc = dtpGioKetThuc.Value.ToString("HH:mm:ss");

            if (dtpGioKetThuc.Value <= dtpGioBatDau.Value)
            {
                lblThoiLuong.Text = "Thời lượng: Giờ kết thúc phải lớn hơn bắt đầu!";
                lblThoiLuong.ForeColor = Color.Red;
                btnXacNhanDat.Enabled = false;
                return;
            }
            else
            {
                lblThoiLuong.ForeColor = Color.FromArgb(30, 41, 59);
            }

            // 2. Truy vấn dữ liệu sân
            string filterLoaiSan = "";
            if (cboLoaiSan.SelectedIndex > 0)
            {
                filterLoaiSan = $" AND ls.TenLoaiSan = N'{cboLoaiSan.SelectedItem.ToString().Replace("'", "''")}'";
            }

            string query = $@"
        SELECT s.MaSan, s.TenSan, ls.TenLoaiSan, ls.GiaTheoGio,
               CASE 
                   WHEN EXISTS (
                       SELECT 1 FROM PhieuDatSan p
                       WHERE p.MaSan = s.MaSan 
                         AND CAST(p.NgaySuDung AS DATE) = '{ngayChoi}'
                         AND (p.ThoiGianBatDau < '{gioKetThuc}' AND p.ThoiGianKetThuc > '{gioBatDau}')
                   ) THEN 1 
                   ELSE 0 
               END AS DaDat
        FROM San s
        JOIN LoaiSan ls ON s.MaLoaiSan = ls.MaLoaiSan
        WHERE 1 = 1 {filterLoaiSan}
        ORDER BY s.TenSan ASC";

            DataSet ds = db.GetData(query);

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                Label lblEmpty = new Label
                {
                    Text = "Không có sân nào phù hợp với bộ lọc hiện tại!",
                    Font = new Font("Segoe UI", 11F, FontStyle.Italic),
                    ForeColor = Color.FromArgb(100, 116, 139),
                    AutoSize = true,
                    Padding = new Padding(20)
                };
                flpDanhSachSan.Controls.Add(lblEmpty);
                return;
            }

            // =========================================================================
            // 3. CÔNG THỨC TÍNH CHIỀU RỘNG CHUẨN XÁC ĐỂ BẮT BUỘC VỪA 2 CỘT / HÀNG
            // =========================================================================
            int totalWidth = flpDanhSachSan.ClientSize.Width;
            if (totalWidth <= 0) totalWidth = flpDanhSachSan.Width;

            // Trừ lề trái phải (Padding 10px * 2) và thanh cuộn dọc (Scrollbar ~ 25px)
            int availableWidth = totalWidth - 45;
            int cardWidth = (availableWidth / 2) - 8; // Trừ khoảng cách giữa 2 thẻ

            // Nếu màn hình quá nhỏ thì giữ tối thiểu 200px
            if (cardWidth < 200) cardWidth = 200;

            // 4. Vẽ các thẻ sân
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string maSan = row["MaSan"].ToString();
                string tenSan = row["TenSan"].ToString();
                string tenLoai = row["TenLoaiSan"].ToString();
                decimal giaGio = Convert.ToDecimal(row["GiaTheoGio"]);
                bool isBooked = Convert.ToInt32(row["DaDat"]) == 1;

                Panel card = CreateFieldCard(maSan, tenSan, tenLoai, giaGio, isBooked, cardWidth);
                flpDanhSachSan.Controls.Add(card);
            }
        }

        private Panel CreateFieldCard(string maSan, string tenSan, string tenLoai, decimal giaGio, bool isBooked, int cardWidth)
        {
            Panel card = new Panel
            {
                Size = new Size(cardWidth, 150),
                Margin = new Padding(4, 5, 4, 5), // Lề 4px mỗi bên để 2 thẻ vừa khít 1 hàng
                BackColor = Color.White,
                Cursor = isBooked ? Cursors.Default : Cursors.Hand
            };

            Color statusColor = isBooked ? Color.FromArgb(239, 68, 68) : Color.FromArgb(34, 197, 94);

            Panel pnlStatusBar = new Panel
            {
                Dock = DockStyle.Left,
                Width = 5,
                BackColor = statusColor
            };

            string iconSan = "🏟️";
            if (tenLoai.ToLower().Contains("bóng")) iconSan = "⚽";
            else if (tenLoai.ToLower().Contains("cầu lông")) iconSan = "🏸";
            else if (tenLoai.ToLower().Contains("tennis") || tenLoai.ToLower().Contains("pickleball")) iconSan = "🎾";

            Label lblTitle = new Label
            {
                Text = $"{iconSan}  {tenSan}",
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Location = new Point(12, 10),
                AutoSize = true
            };

            Label lblLoai = new Label
            {
                Text = $"Loại: {tenLoai}",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(100, 116, 139),
                Location = new Point(14, 34),
                AutoSize = true
            };

            Label lblGia = new Label
            {
                Text = $"Giá: {giaGio:N0} đ/giờ",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(14, 55),
                AutoSize = true
            };

            Label lblStatusBadge = new Label
            {
                Text = isBooked ? "🔴 ĐÃ KÍN SÂN" : "🟢 CÒN TRỐNG",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = statusColor,
                Location = new Point(14, 78),
                AutoSize = true
            };

            Button btnChon = new Button
            {
                Text = isBooked ? "Đã có người đặt" : "Chọn đặt sân",
                Enabled = !isBooked,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = isBooked ? Color.FromArgb(203, 213, 225) : Color.FromArgb(22, 163, 74),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(12, 105),
                Size = new Size(cardWidth - 24, 32),
                Cursor = isBooked ? Cursors.No : Cursors.Hand
            };
            btnChon.FlatAppearance.BorderSize = 0;

            EventHandler selectHandler = (s, e) =>
            {
                if (!isBooked)
                {
                    ChonSanDat(maSan, tenSan, tenLoai, giaGio);
                }
            };

            btnChon.Click += selectHandler;
            if (!isBooked) card.Click += selectHandler;

            card.Controls.AddRange(new Control[] { pnlStatusBar, lblTitle, lblLoai, lblGia, lblStatusBadge, btnChon });
            return card;
        }
        #endregion

        #region 3. Chọn sân và Tính tổng tiền
        private void ChonSanDat(string maSan, string tenSan, string tenLoai, decimal giaGio)
        {
            selectedMaSan = maSan;
            selectedTenSan = tenSan;
            selectedTenLoaiSan = tenLoai;
            selectedGiaGio = giaGio;

            // Tính số giờ chơi
            TimeSpan duration = dtpGioKetThuc.Value.TimeOfDay - dtpGioBatDau.Value.TimeOfDay;
            double totalHours = duration.TotalHours;

            if (totalHours <= 0)
            {
                MessageBox.Show("Giờ kết thúc phải lớn hơn giờ bắt đầu!", "Thời gian không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnXacNhanDat.Enabled = false;
                return;
            }

            // Tính tổng tiền = Số giờ * Giá mỗi giờ
            tongTienTamTinh = (decimal)totalHours * selectedGiaGio;

            // Hiển thị ra panel bên phải
            lblTenSanChon.Text = $"Sân: {selectedTenSan}";
            lblLoaiSanChon.Text = $"Loại sân: {selectedTenLoaiSan}";
            lblGiaGio.Text = $"Đơn giá: {selectedGiaGio:N0} đ/giờ";
            lblThoiLuong.Text = $"Thời lượng: {totalHours:0.##} giờ ({dtpGioBatDau.Value:HH:mm} - {dtpGioKetThuc.Value:HH:mm})";
            lblTongTien.Text = $"{tongTienTamTinh:N0} VNĐ";

            btnXacNhanDat.Enabled = true;
        }

        private void ResetSelection()
        {
            selectedMaSan = "";
            selectedTenSan = "";
            selectedTenLoaiSan = "";
            selectedGiaGio = 0;
            tongTienTamTinh = 0;

            lblTenSanChon.Text = "Chưa chọn sân nào";
            lblLoaiSanChon.Text = "Loại sân: Chưa chọn";
            lblGiaGio.Text = "Đơn giá/giờ: --";
            lblThoiLuong.Text = "Thời lượng: Chưa chọn";
            lblTongTien.Text = "0 VNĐ";
            btnXacNhanDat.Enabled = false;
        }
        #endregion

        #region 4. Xác nhận đặt sân & Lưu vào Database
        private void btnXacNhanDat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaSan))
            {
                MessageBox.Show("Vui lòng chọn một sân còn trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra Session khách hàng
            if (string.IsNullOrEmpty(Session.UserId))
            {
                MessageBox.Show("Phiên đăng nhập đã hết hạn hoặc không tìm thấy thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ngayChoi = dtpNgayChoi.Value.ToString("yyyy-MM-dd");
            string gioBatDau = dtpGioBatDau.Value.ToString("HH:mm:ss");
            string gioKetThuc = dtpGioKetThuc.Value.ToString("HH:mm:ss");

            // 1. Kiểm tra lại lần cuối xem trong lúc thao tác có ai vừa đặt sân đó chưa
            string checkConflictQuery = $@"
                SELECT MaPhieu FROM PhieuDatSan 
                WHERE MaSan = '{selectedMaSan}' 
                  AND CAST(NgaySuDung AS DATE) = '{ngayChoi}'
                  AND (ThoiGianBatDau < '{gioKetThuc}' AND ThoiGianKetThuc > '{gioBatDau}')";

            DataSet dsConflict = db.GetData(checkConflictQuery);
            if (dsConflict != null && dsConflict.Tables.Count > 0 && dsConflict.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show($"Rất tiếc! {selectedTenSan} vừa có người khác đặt trong khung giờ này. Vui lòng chọn sân hoặc khung giờ khác!", "Sân đã có người đặt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadDanhSachSan();
                return;
            }

            // 2. Tạo mã phiếu đặt sân tự động (Ví dụ: PDS + NămThángNgàyGiờPhútGiây)
            // Dùng tiền tố "P" + NgàyGiờPhútGiây (Tổng đúng 9 ký tự: ví dụ P13221530)
            string maPhieu = "P" + DateTime.Now.ToString("ddHHmmss");
            // 3. Thêm bản ghi vào bảng PhieuDatSan
            // MaTrangThai = 1 (Chờ duyệt / Đã đặt), XacNhanThanhToan = N'Chưa thanh toán'
            string insertQuery = $@"
                INSERT INTO PhieuDatSan (
                    MaPhieu, MaKhach, MaSan, NgayDat, NgaySuDung, 
                    ThoiGianBatDau, ThoiGianKetThuc, TongTien, MaTrangThai, XacNhanThanhToan
                )
                VALUES (
                    '{maPhieu}', 
                    '{Session.UserId}', 
                    '{selectedMaSan}', 
                    GETDATE(), 
                    '{ngayChoi}', 
                    '{gioBatDau}', 
                    '{gioKetThuc}', 
                    {tongTienTamTinh}, 
                    'TT01', 
                    0
                )";

            db.setData(insertQuery, $"Đặt sân {selectedTenSan} thành công!\nMã phiếu đặt: {maPhieu}\nTổng tiền: {tongTienTamTinh:N0} VNĐ");

            // 4. Làm mới lại trạng thái sơ đồ sân -> Sân vừa đặt sẽ tự đổi màu sang ĐÃ KÍN SÂN (🔴)
            ResetSelection();
            LoadDanhSachSan();
        }
        #endregion
    }
}