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
    public partial class UCQuanLySan : UserControl
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=quanlydatsan;Integrated Security=True;Trust Server Certificate=True";
        public UCQuanLySan()
        {
            InitializeComponent();
            LoadDanhSachSan();
            LoadComboBox();
        }
        private void LoadDanhSachSan()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                SELECT
                    s.MaSan as [Mã Sân],
                    s.TenSan as [Tên Sân],
                    l.TenLoaiSan as [Loại Sân],
                    s.MaLoaiSan as [Mã Loại Sân]
                FROM San s
                JOIN LoaiSan l ON s.MaLoaiSan = l.MaLoaiSan
                ORDER BY s.MaSan ASC";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvSan.DataSource = dt;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi tải danh sách Sân: " + ex.Message,"Lỗi SQL",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void LoadComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter daSan = new SqlDataAdapter(
                    "SELECT MaLoaiSan ,TenLoaiSan FROM LoaiSan", conn);
                DataTable dtSan = new DataTable();
                daSan.Fill(dtSan);
                cboLoaiSan.DataSource = dtSan;
                cboLoaiSan.DisplayMember = "TenLoaiSan";
                cboLoaiSan.ValueMember = "MaLoaiSan";
            }
        }
        private void dgvSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvSan.Rows[e.RowIndex];
            TxtMaSan.Text = row.Cells["Mã Sân"].Value?.ToString();
            TxtTenSan.Text = row.Cells["Tên Sân"].Value?.ToString();
            cboLoaiSan.SelectedValue = row.Cells["Mã Loại Sân"].Value;
        }
            private void btnSua_Click(object sender, EventArgs e)
        {   
            if (string.IsNullOrWhiteSpace(TxtMaSan.Text))
            {
                MessageBox.Show("Vui lòng chọn sân cần sửa!");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtTenSan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sân!");
                TxtTenSan.Focus();
                return;
            }

            if (cboLoaiSan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại sân!");
                cboLoaiSan.Focus();
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                UPDATE San
                SET TenSan = @TenSan,
                    MaLoaiSan = @MaLoaiSan
                WHERE MaSan = @MaSan";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaSan", SqlDbType.VarChar, 4).Value = TxtMaSan.Text.Trim();
                        cmd.Parameters.Add("@TenSan", SqlDbType.NVarChar, 100).Value = TxtTenSan.Text.Trim();
                        cmd.Parameters.Add("@MaLoaiSan", SqlDbType.Int).Value = Convert.ToInt32(cboLoaiSan.SelectedValue);
                        conn.Open();
                        int soDong = cmd.ExecuteNonQuery();
                        if (soDong > 0)
                        {
                            MessageBox.Show("Cập nhật sân thành công!");
                            LoadDanhSachSan();
                        }
                        else
                            MessageBox.Show("Không tìm thấy sân cần sửa!");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật sân: " + ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTenSan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sân!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                TxtTenSan.Focus();
                return;
            }
            if (cboLoaiSan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại sân!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                cboLoaiSan.Focus();
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("ThemSan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@TenSan", SqlDbType.NVarChar, 100).Value = TxtTenSan.Text.Trim();
                        cmd.Parameters.Add("@MaLoaiSan", SqlDbType.Int).Value = Convert.ToInt32(cboLoaiSan.SelectedValue);
                        conn.Open();

                        object ketQua = cmd.ExecuteScalar();

                        if (ketQua != null && ketQua != DBNull.Value)
                        {
                            string maSanMoi = ketQua.ToString();

                            MessageBox.Show("Thêm sân thành công!\nMã sân mới: " + maSanMoi,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

                            LoadDanhSachSan();
                            TxtMaSan.Clear();
                            TxtTenSan.Clear();
                            cboLoaiSan.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sân: " + ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtMaSan.Text))
            {
                MessageBox.Show("Vui lòng chọn sân cần xóa!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn xóa sân " + TxtMaSan.Text + " không?","Xác nhận xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (xacNhan != DialogResult.Yes)
                return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "DELETE FROM San WHERE MaSan = @MaSan";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaSan", SqlDbType.VarChar, 4).Value = TxtMaSan.Text.Trim();
                        conn.Open();
                        int soDong = cmd.ExecuteNonQuery();
                        if (soDong > 0)
                        {
                            MessageBox.Show("Xóa sân thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

                            LoadDanhSachSan();
                            TxtMaSan.Clear();
                            TxtTenSan.Clear();
                            cboLoaiSan.SelectedIndex = -1;
                        }
                        else
                            MessageBox.Show("Không tìm thấy sân cần xóa!");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể xóa sân. Có thể sân đang được sử dụng trong phiếu đặt.\nChi tiết: "+ ex.Message,"Lỗi SQL",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa sân: " + ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
