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
    public partial class UCNgayLe : UserControl
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=quanlydatsan;Integrated Security=True;Trust Server Certificate=True";
        public UCNgayLe()
        {
            InitializeComponent();
            LoadDanhSachNgayLe();
        }
        private void LoadDanhSachNgayLe()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                SELECT Ngay as [Ngày lễ],
                       TenNgayLe as [Tên ngày lễ]
                FROM NgayLe
                ORDER BY Ngay ASC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvNgayLe.DataSource = dt;
                        dgvNgayLe.Columns["Ngày lễ"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách ngày lễ: " + ex.Message);
            }
        }
        private void dgvNgayLe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvNgayLe.Rows[e.RowIndex];
            dtpNgayLe.Value = Convert.ToDateTime(row.Cells["Ngày lễ"].Value);
            TxtNgayLe.Text = row.Cells["Tên ngày lễ"].Value.ToString();
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            string tenNgayLe = TxtNgayLe.Text.Trim();
            DateTime ngayLe = dtpNgayLe.Value.Date;

            if (tenNgayLe == "")
            {
                MessageBox.Show("Vui lòng nhập tên ngày lễ!");
                TxtNgayLe.Focus();
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                INSERT INTO NgayLe
                VALUES (@Ngay, @TenNgayLe)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@Ngay", SqlDbType.Date).Value = ngayLe;
                        cmd.Parameters.Add("@TenNgayLe", SqlDbType.NVarChar, 100).Value = tenNgayLe;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm ngày lễ thành công!");
                LoadDanhSachNgayLe();
                TxtNgayLe.Clear();
                dtpNgayLe.Value = DateTime.Today;
                dgvNgayLe.ClearSelection();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Ngày lễ này đã tồn tại!");
                else
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm ngày lễ: " + ex.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNgayLe.CurrentRow == null || dgvNgayLe.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn ngày lễ cần sửa!");
                return;
            }
            DateTime ngayLeCu = Convert.ToDateTime(dgvNgayLe.CurrentRow.Cells["Ngày lễ"].Value).Date;
            DateTime ngayLeMoi = dtpNgayLe.Value.Date;
            string tenNgayLe = TxtNgayLe.Text.Trim();

            if (tenNgayLe == "")
            {
                MessageBox.Show("Vui lòng nhập tên ngày lễ!");
                TxtNgayLe.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                UPDATE NgayLe
                SET Ngay = @NgayLeMoi,
                    TenNgayLe = @TenNgayLe
                WHERE Ngay = @NgayLeCu";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@NgayLeMoi", SqlDbType.Date).Value = ngayLeMoi;
                        cmd.Parameters.Add("@TenNgayLe", SqlDbType.NVarChar, 100).Value = tenNgayLe;
                        cmd.Parameters.Add("@NgayLeCu", SqlDbType.Date).Value = ngayLeCu;
                        conn.Open();
                        int ketQua = cmd.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show("Sửa ngày lễ thành công!");
                            LoadDanhSachNgayLe();
                            TxtNgayLe.Clear();
                            dtpNgayLe.Value = DateTime.Today;
                            dgvNgayLe.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy ngày lễ cần sửa!");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Ngày lễ mới đã tồn tại!");
                else
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa ngày lễ: " + ex.Message);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNgayLe.CurrentRow == null || dgvNgayLe.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn ngày lễ cần xóa!");
                return;
            }
            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn xóa ngày lễ này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacNhan != DialogResult.Yes)
                return;
            DateTime ngayLe = Convert.ToDateTime(dgvNgayLe.CurrentRow.Cells["Ngày lễ"].Value).Date;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "DELETE FROM NgayLe WHERE Ngay = @Ngay";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@Ngay", SqlDbType.Date).Value = ngayLe;
                        conn.Open();
                        int ketQua = cmd.ExecuteNonQuery();
                        if (ketQua > 0)
                        {
                            MessageBox.Show("Xóa ngày lễ thành công!");
                            LoadDanhSachNgayLe();
                            TxtNgayLe.Clear();
                            dtpNgayLe.Value = DateTime.Today;
                            dgvNgayLe.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy ngày lễ cần xóa!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa ngày lễ: " + ex.Message);
            }
        }
    }

}
