using quanlydatsan.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlydatsan.ADD_UC_ADMIN
{
    public partial class QLLS : UserControl
    {
        Database db = new Database();
        public QLLS()
        {
            InitializeComponent();
        }

        private void QLLS_Load(object sender, EventArgs e)
        {
            LoadDanhSachLoaiSan();
        }

        private void LoadDanhSachLoaiSan()
        {
            string sql = "SELECT MaLoaiSan AS [Mã Loại Sân], TenLoaiSan AS [Tên Loại Sân], GiaTheoGio AS [Giá Theo Giờ (VNĐ)] FROM LoaiSan";
            DataTable dt = db.ReadData(sql);
            if (dt != null)
            {
                dgvLoaiSan.DataSource = dt;
            }
        }

        private void dgvLoaiSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoaiSan.Rows[e.RowIndex];
                txtMaLoaiSan.Text = row.Cells["Mã Loại Sân"].Value?.ToString();
                txtTenLoaiSan.Text = row.Cells["Tên Loại Sân"].Value?.ToString();
                txtGiaTheoGio.Text = row.Cells["Giá Theo Giờ (VNĐ)"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoaiSan.Text) || string.IsNullOrWhiteSpace(txtGiaTheoGio.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên loại sân và Giá theo giờ!");
                return;
            }

            if (!decimal.TryParse(txtGiaTheoGio.Text.Trim(), out decimal giaTheoGio))
            {
                MessageBox.Show("Giá theo giờ phải là số!");
                return;
            }

            string tenLoaiSan = txtTenLoaiSan.Text.Trim().Replace("'", "''");
            string sql;

            if (!string.IsNullOrWhiteSpace(txtMaLoaiSan.Text) && int.TryParse(txtMaLoaiSan.Text.Trim(), out int maLoaiSan))
            {
                sql = $"INSERT INTO LoaiSan (MaLoaiSan, TenLoaiSan, GiaTheoGio) VALUES ({maLoaiSan}, N'{tenLoaiSan}', {giaTheoGio})";
            }
            else
            {
                sql = $"INSERT INTO LoaiSan (TenLoaiSan, GiaTheoGio) VALUES (N'{tenLoaiSan}', {giaTheoGio})";
            }

            if (db.WriteData(sql) > 0)
            {
                MessageBox.Show("Thêm loại sân thành công!");
                LoadDanhSachLoaiSan();
                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoaiSan.Text))
            {
                MessageBox.Show("Vui lòng chọn loại sân cần sửa!");
                return;
            }

            if (!decimal.TryParse(txtGiaTheoGio.Text.Trim(), out decimal giaTheoGio))
            {
                MessageBox.Show("Giá theo giờ phải là số!");
                return;
            }

            string tenLoaiSan = txtTenLoaiSan.Text.Trim().Replace("'", "''");
            int maLoaiSan = int.Parse(txtMaLoaiSan.Text.Trim());

            string sql = $"UPDATE LoaiSan SET TenLoaiSan=N'{tenLoaiSan}', GiaTheoGio={giaTheoGio} WHERE MaLoaiSan={maLoaiSan}";

            if (db.WriteData(sql) > 0)
            {
                MessageBox.Show("Cập nhật loại sân thành công!");
                LoadDanhSachLoaiSan();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoaiSan.Text))
            {
                MessageBox.Show("Vui lòng chọn loại sân cần xóa!");
                return;
            }

            int maLoaiSan = int.Parse(txtMaLoaiSan.Text.Trim());

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa loại sân này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM LoaiSan WHERE MaLoaiSan={maLoaiSan}";
                if (db.WriteData(sql) > 0)
                {
                    MessageBox.Show("Xóa loại sân thành công!");
                    LoadDanhSachLoaiSan();
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Không thể xóa loại sân đang liên kết ở bảng Sân!");
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().Replace("'", "''");
            string sql = $@"SELECT MaLoaiSan AS [Mã Loại Sân], TenLoaiSan AS [Tên Loại Sân], GiaTheoGio AS [Giá Theo Giờ (VNĐ)] 
                            FROM LoaiSan 
                            WHERE TenLoaiSan LIKE N'%{keyword}%' OR CAST(MaLoaiSan AS NVARCHAR) LIKE '%{keyword}%'";
            dgvLoaiSan.DataSource = db.ReadData(sql);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLoaiSan.Clear();
            txtTenLoaiSan.Clear();
            txtGiaTheoGio.Clear();
            txtTimKiem.Clear();
            LoadDanhSachLoaiSan();
        }
    }
}
