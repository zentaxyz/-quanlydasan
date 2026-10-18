using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace quanlydatsan.All_User_control
{
    public partial class UC_LichSuDatSan : UserControl
    {
        private readonly DatabaseKH db = new DatabaseKH();

        public UC_LichSuDatSan()
        {
            InitializeComponent();
        }

        private void UC_LichSuDatSan_Load(object sender, EventArgs e)
        {
            cboLocTrangThai.SelectedIndex = 0; // Mặc định: Tất cả trạng thái
            LoadLichSu();
        }

        #region 1. Tải dữ liệu lịch sử đặt sân từ SQL Server
        public void LoadLichSu()
        {
            if (string.IsNullOrEmpty(Session.UserId))
            {
                return;
            }

            string safeUserId = Session.UserId.Replace("'", "''");
            string filterStatus = "";
            if (cboLocTrangThai.SelectedIndex > 0)
            {
                filterStatus = $" AND tt.TenTrangThai = N'{cboLocTrangThai.SelectedItem.ToString().Replace("'", "''")}'";
            }

            string searchKey = txtTimKiem.Text.Trim().Replace("'", "''");
            string searchFilter = "";
            if (!string.IsNullOrEmpty(searchKey))
            {
                searchFilter = $" AND (p.MaPhieu LIKE '%{searchKey}%' OR s.TenSan LIKE N'%{searchKey}%')";
            }

            // Câu truy vấn lấy danh sách phiếu của khách hàng hiện tại
            string query = $@"
                SELECT 
                    p.MaPhieu AS [Mã Phiếu],
                    s.TenSan AS [Tên Sân],
                    ls.TenLoaiSan AS [Loại Sân],
                    CONVERT(VARCHAR(10), p.NgaySuDung, 103) AS [Ngày Chơi],
                    CONVERT(VARCHAR(5), p.ThoiGianBatDau, 108) + ' - ' + CONVERT(VARCHAR(5), p.ThoiGianKetThuc, 108) AS [Khung Giờ],
                    p.TongTien AS [Tổng Tiền],
                    ISNULL(tt.TenTrangThai, N'Đã đặt sân') AS [Trạng Thái],
                    CASE 
                        WHEN p.XacNhanThanhToan = 1 THEN N'Đã thanh toán' 
                        ELSE N'Chưa thanh toán' 
                    END AS [Thanh Toán],
                    p.MaTrangThai,
                    p.NgaySuDung
                FROM PhieuDatSan p
                JOIN San s ON p.MaSan = s.MaSan
                JOIN LoaiSan ls ON s.MaLoaiSan = ls.MaLoaiSan
                LEFT JOIN TrangThai tt ON RTRIM(p.MaTrangThai) = RTRIM(tt.MaTrangThai)
                WHERE p.MaKhach = '{safeUserId}' {filterStatus} {searchFilter}
                ORDER BY p.NgayDat DESC, p.MaPhieu DESC";

            DataSet ds = db.GetData(query);
            if (ds != null && ds.Tables.Count > 0)
            {
                dgvLichSu.DataSource = ds.Tables[0];

                // Ẩn 2 cột phụ dùng để kiểm tra logic
                if (dgvLichSu.Columns.Contains("MaTrangThai"))
                    dgvLichSu.Columns["MaTrangThai"].Visible = false;

                if (dgvLichSu.Columns.Contains("NgaySuDung"))
                    dgvLichSu.Columns["NgaySuDung"].Visible = false;

                // Định dạng hiển thị tiền tệ
                if (dgvLichSu.Columns.Contains("Tổng Tiền"))
                {
                    dgvLichSu.Columns["Tổng Tiền"].DefaultCellStyle.Format = "N0";
                    dgvLichSu.Columns["Tổng Tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                // Cập nhật thanh tóm tắt
                CapNhatThongKe(ds.Tables[0]);
            }
        }

        private void CapNhatThongKe(DataTable dt)
        {
            int count = dt.Rows.Count;
            decimal total = 0;

            foreach (DataRow row in dt.Rows)
            {
                // Chỉ cộng tiền các đơn không bị hủy
                string status = row["Trạng Thái"].ToString();
                if (!status.ToLower().Contains("hủy"))
                {
                    total += Convert.ToDecimal(row["Tổng Tiền"]);
                }
            }

            lblTongDon.Text = $"Tổng số phiếu: {count} đơn";
            lblTongChiTieu.Text = $"Tổng tiền đã đặt: {total:N0} VNĐ";
        }
        #endregion

        #region 2. Sự kiện Tìm kiếm và Lọc
        private void Filter_Changed(object sender, EventArgs e)
        {
            LoadLichSu();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboLocTrangThai.SelectedIndex = 0;
            LoadLichSu();
        }
        #endregion

        #region 3. Xem Vé / In Phiếu Đặt Sân
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            MoChiTietPhieu();
        }

        private void dgvLichSu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MoChiTietPhieu();
            }
        }

        private void MoChiTietPhieu()
        {
            if (dgvLichSu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu đặt sân từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maPhieu = dgvLichSu.CurrentRow.Cells["Mã Phiếu"].Value.ToString();

            // Mở lại FormPhieuDatSan đã tạo
           
        }
        #endregion

        #region 4. Hủy Đặt Sân (Khách Hàng)
        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            if (dgvLichSu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu đặt sân muốn hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maPhieu = dgvLichSu.CurrentRow.Cells["Mã Phiếu"].Value.ToString();
            string trangThai = dgvLichSu.CurrentRow.Cells["Trạng Thái"].Value.ToString();
            string maTrangThai = dgvLichSu.CurrentRow.Cells["MaTrangThai"].Value.ToString().Trim();

            // Kiểm tra trạng thái: Đã hủy hoặc Hoàn thành thì không thể hủy tiếp
            if (trangThai.ToLower().Contains("hủy"))
            {
                MessageBox.Show("Phiếu này đã được hủy trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (trangThai.ToLower().Contains("hoàn thành") || trangThai.ToLower().Contains("sử dụng"))
            {
                MessageBox.Show("Sân đang được sử dụng hoặc trận đấu đã kết thúc, bạn không thể hủy phiếu này!", "Không thể hủy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận hủy
            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn hủy phiếu đặt sân #{maPhieu} không?",
                "Xác nhận hủy đặt sân",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Cập nhật MaTrangThai thành 'TT04' (Đã hủy)
                string updateQuery = $@"UPDATE PhieuDatSan 
                                       SET MaTrangThai = 'TT04' 
                                       WHERE MaPhieu = '{maPhieu.Replace("'", "''")}'";

                db.setData(updateQuery, $"Hủy phiếu #{maPhieu} thành công!");
                LoadLichSu();
            }
        }
        #endregion

        #region 5. Tô màu trạng thái sinh động cho DataGridView
        private void dgvLichSu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            string colName = dgvLichSu.Columns[e.ColumnIndex].Name;

            // Tô màu cột Trạng Thái
            if (colName == "Trạng Thái")
            {
                string val = e.Value.ToString().ToLower();
                if (val.Contains("hủy"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38); // Đỏ
                    e.CellStyle.Font = new Font(dgvLichSu.Font, FontStyle.Bold);
                }
                else if (val.Contains("đã đặt"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(22, 163, 74); // Xanh lá
                    e.CellStyle.Font = new Font(dgvLichSu.Font, FontStyle.Bold);
                }
                else if (val.Contains("đang sử dụng"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(2, 132, 199); // Xanh dương
                    e.CellStyle.Font = new Font(dgvLichSu.Font, FontStyle.Bold);
                }
            }

            // Tô màu cột Thanh Toán
            if (colName == "Thanh Toán")
            {
                string val = e.Value.ToString().ToLower();
                if (val.Contains("chưa"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(202, 138, 4); // Cam đất
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(22, 163, 74); // Xanh lá
                    e.CellStyle.Font = new Font(dgvLichSu.Font, FontStyle.Bold);
                }
            }
        }
        #endregion
    }
}