using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlydatsan
{
    public partial class FrmLichSuThanhToan : Form
    {
        private string connectionString;
        private string maPhieu;
        public FrmLichSuThanhToan(string connectionString, string maPhieu, decimal tongTien)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.maPhieu = maPhieu;
            TxtPhieuDatSan.Text = maPhieu;
            TxtSotien.Text = tongTien.ToString("N0");
            TxtPhieuDatSan.Text = maPhieu;
            LoadDgvLSThanhtoan();
            LoadSoTienPhieuDat();
        }

        private void LoadDgvLSThanhtoan()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                SELECT
                    LST.MaThanhToan as [Mã thanh toán],
                    LST.MaPhieu AS [Mã phiếu],
                    LST.ThoiGianThanhToan as [Thời gian thanh toán],
                    LST.PhuongThucThanhToan as [Phương thức thanh toán],
                    LST.SoTien as [Số tiền],
                    t.TenTrangThai as [Trạng thái]
                FROM LichSuThanhToan LST
                LEFT JOIN TrangThai t ON LST.MaTrangThai = t.MaTrangThai
                WHERE LST.MaPhieu = @MaPhieu
                ORDER BY LST.ThoiGianThanhToan DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar, 10).Value = maPhieu;
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        da.Fill(dt);
                        dgvLSThanhtoan.DataSource = dt;
                    }
                }
                if (dgvLSThanhtoan.Rows.Count > 0)
                {
                    dgvLSThanhtoan.Rows[0].Selected = true;
                    HienThiThongTinThanhToan(0);
                }
                else
                {
                    TxtMatt.Clear();
                    TxtSotien.Clear();
                    cboPTThanhtoan.SelectedIndex = -1;
                    dtpTGthanhtoan.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch sử thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HienThiThongTinThanhToan(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgvLSThanhtoan.Rows.Count)
                return;
            DataGridViewRow row = dgvLSThanhtoan.Rows[rowIndex];
            TxtMatt.Text = Convert.ToString(row.Cells["Mã thanh toán"].Value);
            TxtPhieuDatSan.Text = Convert.ToString(row.Cells["Mã phiếu"].Value);
            TxtSotien.Text = Convert.ToDecimal(row.Cells["Số tiền"].Value).ToString("N0");
            string phuongThuc = Convert.ToString(row.Cells["Phương thức thanh toán"].Value);
            cboPTThanhtoan.SelectedItem = phuongThuc;
            dtpTGthanhtoan.Value = Convert.ToDateTime(row.Cells["Thời gian thanh toán"].Value);
        }

        private void dgvLSThanhtoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                HienThiThongTinThanhToan(e.RowIndex);
        }
        private void LoadSoTienPhieuDat()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                SELECT TongTien
                FROM PhieuDatSan
                WHERE MaPhieu = @MaPhieu";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar, 10).Value = maPhieu;
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            TxtSotien.Text = Convert.ToDecimal(result).ToString("N0");
                        }
                        else
                        {
                            TxtSotien.Clear();
                            MessageBox.Show("Không tìm thấy tổng tiền của phiếu đặt sân!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải số tiền: " + ex.Message);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maPhieu))
            {
                MessageBox.Show("Không tìm thấy mã phiếu đặt sân!");
                return;
            }

            if (cboPTThanhtoan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán!");
                cboPTThanhtoan.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(TxtMatt.Text))
            {
                MessageBox.Show("Phiếu này đã có lịch sử thanh toán. Không thể tạo thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("XacNhanThanhToan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar, 10).Value = maPhieu;
                    cmd.Parameters.Add("@PhuongThucThanhToan", SqlDbType.NVarChar, 50).Value = cboPTThanhtoan.SelectedItem.ToString();
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TxtMatt.Text = reader["MaThanhToan"].ToString();
                            TxtPhieuDatSan.Text = reader["MaPhieu"].ToString();
                            TxtSotien.Text = Convert.ToDecimal(reader["SoTien"]).ToString("N0");
                            dtpTGthanhtoan.Value = Convert.ToDateTime(reader["ThoiGianThanhToan"]);
                            cboPTThanhtoan.SelectedItem = reader["PhuongThucThanhToan"].ToString();
                        }
                    }
                }
                LoadDgvLSThanhtoan();
                MessageBox.Show("Xác nhận thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Không thể thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTheoTen_Click(object sender, EventArgs e)
        {
            string tenKhach = TxtTheoten.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenKhach))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                TxtTheoten.Focus();
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                SELECT
                    LST.MaThanhToan as [Mã thanh toán],
                    LST.MaPhieu as [Mã phiếu],
                    LST.ThoiGianThanhToan as [Thời gian thanh toán],
                    LST.PhuongThucThanhToan as [Phương thức thanh toán],
                    LST.SoTien as [Số tiền],
                    t.TenTrangThai as [Trạng thái]
                FROM LichSuThanhToan LST
                JOIN PhieuDatSan p ON LST.MaPhieu = p.MaPhieu
                JOIN KhachHang k ON p.MaKhach = k.MaKhach
                LEFT JOIN TrangThai t ON LST.MaTrangThai = t.MaTrangThai
                WHERE LST.MaPhieu = @MaPhieu
                AND k.TenKhach LIKE @TenKhach
                ORDER BY LST.ThoiGianThanhToan DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar, 10).Value = maPhieu;
                        cmd.Parameters.Add("@TenKhach", SqlDbType.NVarChar, 100).Value = "%" + tenKhach + "%";
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        dgvLSThanhtoan.DataSource = dt;
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy lịch sử thanh toán phù hợp.");
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
            TxtTheoten.Clear();
            LoadDgvLSThanhtoan();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLSThanhtoan.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lịch sử thanh toán cần xóa!");
                return;
            }

            string maThanhToan = Convert.ToString(dgvLSThanhtoan.CurrentRow.Cells["Mã thanh toán"].Value);

            if (string.IsNullOrWhiteSpace(maThanhToan))
                return;
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa lịch sử thanh toán " + maThanhToan + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(@"
                DELETE FROM LichSuThanhToan
                WHERE MaThanhToan = @MaThanhToan
                AND MaPhieu = @MaPhieu", conn))
                {
                    cmd.Parameters.Add("@MaThanhToan", SqlDbType.VarChar, 10).Value = maThanhToan;
                    cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar, 10).Value = maPhieu;
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Đã xóa lịch sử thanh toán.");
                        LoadDgvLSThanhtoan();
                    }
                    else
                        MessageBox.Show("Không tìm thấy bản ghi cần xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa lịch sử thanh toán: " + ex.Message);
            }
        }
    }
}
