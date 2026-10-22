using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace quanlydatsan
{
    public partial class UCPhieuDatSan : UserControl
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=quanlydatsan;Integrated Security=True;Trust Server Certificate=True";
        public UCPhieuDatSan()
        {
            InitializeComponent();
            LoadDanhSachPhieuDatSan();
            LoadComboBox();
        }
        private void LoadDanhSachPhieuDatSan()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                    SELECT
                    p.MaPhieu as [Mã phiếu],
                    p.MaKhach,
                    k.TenKhach as [Khách hàng],
                    p.MaSan,
                    s.TenSan as [Sân],
                    l.TenLoaiSan as [Loại sân],
                    p.NgayDat as [Ngày đặt],
                    p.NgaySuDung as [Ngày sử dụng],
                    p.ThoiGianBatDau as [Giờ bắt đầu],
                    p.ThoiGianKetThuc as [Giờ kết thúc],
                    p.TongTien as [Tổng tiền],
                    p.MaTrangThai ,
                    t.TenTrangThai as [Trạng thái],
                    p.XacNhanThanhToan,
                    CASE
                        WHEN p.XacNhanThanhToan = 1 THEN N'Đã thanh toán' ELSE N'Chưa thanh toán'
                    END AS [Thanh toán]
                    FROM PhieuDatSan p
                    JOIN KhachHang k ON p.MaKhach = k.MaKhach
                    JOIN San s ON p.MaSan = s.MaSan
                    JOIN LoaiSan l ON s.MaLoaiSan = l.MaLoaiSan
                    JOIN TrangThai t ON p.MaTrangThai = t.MaTrangThai
                    ORDER BY p.MaPhieu DESC";

                    using (SqlDataAdapter da =
                           new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvLichDat.AutoGenerateColumns = true;
                        dgvLichDat.DataSource = dt;
                        dgvLichDat.Columns["Giờ bắt đầu"].DefaultCellStyle.Format = @"hh\:mm";
                        dgvLichDat.Columns["Giờ kết thúc"].DefaultCellStyle.Format = @"hh\:mm";
                        dgvLichDat.Columns["Ngày đặt"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgvLichDat.Columns["Ngày sử dụng"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgvLichDat.Columns["Tổng tiền"].DefaultCellStyle.Format = "N0";
                        //Ẩn các cột ko cần thiết
                        dgvLichDat.Columns["MaKhach"].Visible = false;
                        dgvLichDat.Columns["MaSan"].Visible = false;
                        dgvLichDat.Columns["MaTrangThai"].Visible = false;
                        dgvLichDat.Columns["XacNhanThanhToan"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phiếu đặt sân:\n" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                SqlDataAdapter daKhach = new SqlDataAdapter(
                "SELECT MaKhach, TenKhach FROM KhachHang", conn);
                DataTable dtKhach = new DataTable();
                daKhach.Fill(dtKhach);
                cboKhach.DataSource = dtKhach;
                cboKhach.DisplayMember = "TenKhach";
                cboKhach.ValueMember = "MaKhach";

                SqlDataAdapter daSan = new SqlDataAdapter(
                "SELECT MaSan, TenSan FROM San", conn);
                DataTable dtSan = new DataTable();
                daSan.Fill(dtSan);
                cboSan.DataSource = dtSan;
                cboSan.DisplayMember = "TenSan";
                cboSan.ValueMember = "MaSan";

                SqlDataAdapter daTrangThai = new SqlDataAdapter(
                "SELECT MaTrangThai, TenTrangThai FROM TrangThai WHERE MaTrangThai <> 'TT04'", conn);
                DataTable dtTrangThai = new DataTable();
                daTrangThai.Fill(dtTrangThai);
                cboTrangthai.DataSource = dtTrangThai;
                cboTrangthai.DisplayMember = "TenTrangThai";
                cboTrangthai.ValueMember = "MaTrangThai";
            }
        }
        private bool KiemTraSanTrong(string maPhieuBoQua = null)
        {
            if (cboSan.SelectedValue == null || cboSan.SelectedValue is DataRowView)
            {
                txtTrangThaiSan.Text = "";
                return false;
            }
            TimeSpan gioBatDau = dtpGioBatDau.Value.TimeOfDay;
            TimeSpan gioKetThuc = dtpGioKetThuc.Value.TimeOfDay;
            if (gioBatDau >= gioKetThuc)
            {
                txtTrangThaiSan.Clear();
                return false;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                SELECT COUNT(*)
                FROM PhieuDatSan p
                JOIN TrangThai t ON p.MaTrangThai = t.MaTrangThai
                WHERE p.MaSan = @MaSan
                AND p.NgaySuDung = @NgaySuDung
                AND p.ThoiGianBatDau < @GioKetThuc
                AND p.ThoiGianKetThuc > @GioBatDau
                AND t.TenTrangThai <> N'Hủy'
                AND (@MaPhieu IS NULL OR p.MaPhieu <> @MaPhieu)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSan", cboSan.SelectedValue.ToString());
                        cmd.Parameters.Add("@NgaySuDung", SqlDbType.Date).Value = dtpNgaydung.Value.Date;
                        cmd.Parameters.Add("@GioBatDau", SqlDbType.Time).Value = gioBatDau;
                        cmd.Parameters.Add("@GioKetThuc", SqlDbType.Time).Value = gioKetThuc;
                        cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar, 10).Value = string.IsNullOrWhiteSpace(maPhieuBoQua) ? (object)DBNull.Value : maPhieuBoQua.Trim();
                        conn.Open();

                        int soPhieuTrung = Convert.ToInt32(cmd.ExecuteScalar());
                        if (soPhieuTrung > 0)
                        {
                            txtTrangThaiSan.Text = "sân full";
                            return false;
                        }
                        txtTrangThaiSan.Text = "sân trống";
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                txtTrangThaiSan.Text = "Không kiểm tra được";
                MessageBox.Show("Lỗi kiểm tra trạng thái sân: " + ex.Message);
                return false;
            }
        }
        private void dgvLichDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dgvLichDat.Rows[e.RowIndex];
            txtMaPhieu.Text = row.Cells["Mã phiếu"].Value?.ToString();
            cboKhach.SelectedValue = row.Cells["MaKhach"].Value;
            cboSan.SelectedValue = row.Cells["MaSan"].Value;
            TimeSpan gioBatDau = TimeSpan.Parse(row.Cells["Giờ bắt đầu"].Value.ToString());
            dtpGioBatDau.Value = DateTime.Today.Add(gioBatDau);
            dtpNgaydung.Value = Convert.ToDateTime(row.Cells["Ngày sử dụng"].Value);
            TimeSpan gioKetThuc = TimeSpan.Parse(row.Cells["Giờ kết thúc"].Value.ToString());
            dtpGioKetThuc.Value = DateTime.Today.Add(gioKetThuc);
            TxtTongTien.Text = Convert.ToDecimal(row.Cells["Tổng tiền"].Value).ToString("N0");
            cboTrangthai.SelectedValue = row.Cells["MaTrangThai"].Value;
            chkXacNhanThanhToan.Checked = Convert.ToBoolean(row.Cells["XacNhanThanhToan"].Value);
        }
        private void TinhTongTien()
        {
            if (cboSan.SelectedValue == null || dtpGioBatDau.Value.TimeOfDay >= dtpGioKetThuc.Value.TimeOfDay)
            {
                TxtTongTien.Text = "0";
                return;
            }
            TimeSpan gioBatDau = dtpGioBatDau.Value.TimeOfDay;
            TimeSpan gioKetThuc = dtpGioKetThuc.Value.TimeOfDay;
            double soGio = (gioKetThuc - gioBatDau).TotalMinutes / 60.0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                SELECT GiaTheoGio
                FROM LoaiSan l
                JOIN San s ON s.MaLoaiSan = l.MaLoaiSan
                WHERE s.MaSan = @MaSan";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        if (cboSan.SelectedValue == null || cboSan.SelectedValue is DataRowView)
                        {
                            return;
                        }
                        cmd.Parameters.AddWithValue("@MaSan", cboSan.SelectedValue.ToString());
                        conn.Open();
                        object ketQua = cmd.ExecuteScalar();
                        if (ketQua == null || ketQua == DBNull.Value)
                        {
                            TxtTongTien.Text = "0";
                            return;
                        }
                        decimal giaTheoGio = Convert.ToDecimal(ketQua);
                        string sqlNgayLe = @"
                        SELECT COUNT(*) FROM NgayLe
                        WHERE Ngay = @NgaySuDung";
                        using (SqlCommand cmdNgayLe = new SqlCommand(sqlNgayLe, conn))
                        {
                            cmdNgayLe.Parameters.Add("@NgaySuDung", SqlDbType.Date).Value = dtpNgaydung.Value.Date;
                            int laNgayLe = Convert.ToInt32(cmdNgayLe.ExecuteScalar());
                            if (laNgayLe > 0)
                            {
                                giaTheoGio += 15000;
                            }
                            decimal tongTien = (decimal)soGio * giaTheoGio;
                            TxtTongTien.Text = tongTien.ToString("N0");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính tổng tiền: " + ex.Message);
            }
        }
        private void CapNhatTongTien(object sender, EventArgs e)
        {
            TinhTongTien();
            KiemTraSanTrong();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu cần sửa!");
                return;
            }
            TimeSpan gioBatDau = dtpGioBatDau.Value.TimeOfDay;
            TimeSpan gioKetThuc = dtpGioKetThuc.Value.TimeOfDay;

            if (gioBatDau >= gioKetThuc)
            {
                MessageBox.Show("Giờ kết thúc phải sau giờ bắt đầu!");
                return;
            }
            if (!KiemTraSanTrong(txtMaPhieu.Text.Trim()))
            {
                MessageBox.Show(
                    "Sân đã được đặt trong khung giờ này hoặc thời gian không hợp lệ!", "Không thể lưu phiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                UPDATE PhieuDatSan
                SET MaKhach = @MaKhach,
                    MaSan = @MaSan,
                    NgaySuDung = @NgaySuDung,
                    ThoiGianBatDau = @GioBatDau,
                    ThoiGianKetThuc = @GioKetThuc,
                    MaTrangThai = @MaTrangThai,
                    XacNhanThanhToan = @XacNhanThanhToan
                WHERE MaPhieu = @MaPhieu";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar, 10).Value = txtMaPhieu.Text.Trim();
                        cmd.Parameters.Add("@MaKhach", SqlDbType.VarChar, 8).Value = cboKhach.SelectedValue;
                        cmd.Parameters.Add("@MaSan", SqlDbType.VarChar, 4).Value = cboSan.SelectedValue;
                        cmd.Parameters.Add("@NgaySuDung", SqlDbType.Date).Value = dtpNgaydung.Value.Date;
                        cmd.Parameters.Add("@GioBatDau", SqlDbType.Time).Value = gioBatDau;
                        cmd.Parameters.Add("@GioKetThuc", SqlDbType.Time).Value = gioKetThuc;
                        cmd.Parameters.Add("@MaTrangThai", SqlDbType.VarChar, 5).Value = cboTrangthai.SelectedValue;
                        cmd.Parameters.Add("@XacNhanThanhToan", SqlDbType.Bit).Value = chkXacNhanThanhToan.Checked;

                        conn.Open();
                        int soDong = cmd.ExecuteNonQuery();
                        if (soDong > 0)
                        {
                            MessageBox.Show("Cập nhật phiếu đặt sân thành công!");
                            LoadDanhSachPhieuDatSan();
                            KiemTraSanTrong(txtMaPhieu.Text.Trim());
                        }
                        else
                            MessageBox.Show("Không tìm thấy phiếu cần cập nhật!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu đặt sân cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu đặt sân " + txtMaPhieu.Text + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @" DELETE FROM PhieuDatSan WHERE MaPhieu = @MaPhieu";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar, 10).Value = txtMaPhieu.Text.Trim();
                        conn.Open();
                        int soDong = cmd.ExecuteNonQuery();
                        if (soDong > 0)
                        {
                            MessageBox.Show("Xóa phiếu đặt sân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachPhieuDatSan();
                            txtMaPhieu.Clear();
                            cboKhach.SelectedIndex = -1;
                            cboSan.SelectedIndex = -1;
                            cboTrangthai.SelectedIndex = -1;
                            TxtTongTien.Clear();
                            chkXacNhanThanhToan.Checked = false;
                        }
                        else
                            MessageBox.Show("Không tìm thấy phiếu cần xóa!");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể xóa phiếu đặt sân. Có thể phiếu đang được dữ liệu khác tham chiếu.\n" + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            DateTime ngaySuDung = dtpNgaydung.Value.Date;
            TimeSpan gioBatDau = dtpGioBatDau.Value.TimeOfDay;
            TimeSpan gioKetThuc = dtpGioKetThuc.Value.TimeOfDay;
            if (!KiemTraSanTrong(null))
            {
                MessageBox.Show("Sân đã được đặt trong khung giờ này hoặc thời gian không hợp lệ!", "Không thể tạo phiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string maPhieuMoi = "";
                decimal tongTien = 0;
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("ThemPhieuDatSan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaKhach", SqlDbType.VarChar, 8).Value = cboKhach.SelectedValue;
                    cmd.Parameters.Add("@MaSan", SqlDbType.VarChar, 4).Value = cboSan.SelectedValue;
                    cmd.Parameters.Add("@NgaySuDung", SqlDbType.Date).Value = ngaySuDung;
                    cmd.Parameters.Add("@ThoiGianBatDau", SqlDbType.Time).Value = gioBatDau;
                    cmd.Parameters.Add("@ThoiGianKetThuc", SqlDbType.Time).Value = gioKetThuc;
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maPhieuMoi = reader["MaPhieu"].ToString();
                            tongTien = Convert.ToDecimal(reader["TongTien"]);
                        }
                        else
                        {
                            MessageBox.Show("Không nhận được thông tin phiếu mới!");
                            return;
                        }
                    }
                }

                txtMaPhieu.Text = maPhieuMoi;
                TxtTongTien.Text = tongTien.ToString("N0");
                cboTrangthai.SelectedValue = "TT01";
                chkXacNhanThanhToan.Checked = false;
                LoadDanhSachPhieuDatSan();

                MessageBox.Show("Tạo phiếu đặt sân thành công!\n\n" + "Mã phiếu: " + maPhieuMoi + "\n" + "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Không thể tạo phiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTheoten_Click(object sender, EventArgs e)
        {
            string tenKhach = TxtTimten.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenKhach))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng cần tìm!");
                TxtTimten.Focus();
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                    SELECT
                        p.MaPhieu AS [Mã phiếu],
                        p.MaKhach,
                        k.TenKhach AS [Khách hàng],
                        p.MaSan,
                        s.TenSan AS [Sân],
                        l.TenLoaiSan AS [Loại sân],
                        p.NgayDat AS [Ngày đặt],
                        p.NgaySuDung AS [Ngày sử dụng],
                        p.ThoiGianBatDau AS [Giờ bắt đầu],
                        p.ThoiGianKetThuc AS [Giờ kết thúc],
                        p.TongTien AS [Tổng tiền],
                        p.MaTrangThai,
                        t.TenTrangThai AS [Trạng thái],
                        p.XacNhanThanhToan,
                        CASE
                            WHEN p.XacNhanThanhToan = 1 THEN N'Đã thanh toán' ELSE N'Chưa thanh toán'
                        END AS [Thanh toán]
                    FROM PhieuDatSan p
                    JOIN KhachHang k ON p.MaKhach = k.MaKhach
                    JOIN San s ON p.MaSan = s.MaSan
                    JOIN LoaiSan l ON s.MaLoaiSan = l.MaLoaiSan
                    JOIN TrangThai t ON p.MaTrangThai = t.MaTrangThai
                    WHERE k.TenKhach LIKE @TenKhach
                    ORDER BY p.NgayDat DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@TenKhach", SqlDbType.NVarChar, 100)
                            .Value = "%" + tenKhach + "%";

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvLichDat.DataSource = dt;
                        // Ẩn các cột mã không cần hiển thị
                        dgvLichDat.Columns["MaKhach"].Visible = false;
                        dgvLichDat.Columns["MaSan"].Visible = false;
                        dgvLichDat.Columns["MaTrangThai"].Visible = false;
                        dgvLichDat.Columns["XacNhanThanhToan"].Visible = false;
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy phiếu đặt sân của khách hàng này!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }
        private void btnHientatca_Click(object sender, EventArgs e)
        {
            TxtTimten.Clear();
            LoadDanhSachPhieuDatSan();
        }
        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (dgvLichDat.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu đặt sân!");
                return;
            }
            DataGridViewRow row = dgvLichDat.CurrentRow;
            string maPhieu = row.Cells["Mã phiếu"].Value.ToString();
            decimal tongTien = Convert.ToDecimal(row.Cells["Tổng tiền"].Value
            );
            FrmLichSuThanhToan frm = new FrmLichSuThanhToan(connectionString, maPhieu, tongTien);
            frm.ShowDialog();
            LoadDanhSachPhieuDatSan();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachPhieuDatSan();
            LoadComboBox();
        }
    }
}
