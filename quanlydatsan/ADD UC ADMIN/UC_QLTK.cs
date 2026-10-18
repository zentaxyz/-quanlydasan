using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlydatsan.ADD_UC_ADMIN
{
    public partial class UC_QLTK : UserControl
    {
        Database db = new Database();
        public UC_QLTK()
        {
            InitializeComponent();
        }

        private void Khachhangvataikhoan_Load(object sender, EventArgs e)
        {

            txtMand.ReadOnly = false;
            txtMatk.ReadOnly = false;
            LoadDanhsachkhachhang();
            LoadDanhsachchusan();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                LoadDanhsachkhachhang();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                LoadDanhsachchusan();
            }
        }


        private void LoadDanhsachkhachhang()
        {
            string sql = "SELECT MaKhach AS [Mã Khách], TenKhach AS [Họ và Tên], SoDienThoai AS [SĐT], Email, GioiTinh AS [Giới tính], NgaySinh AS [Ngày sinh], Diachi AS [Địa chỉ] FROM KhachHang";
            dgvKhachhang.DataSource = db.ReadData(sql);
        }

        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachhang.Rows[e.RowIndex];
                txtMand.Text = row.Cells["Mã Khách"].Value?.ToString();
                txtHoten.Text = row.Cells["Họ và Tên"].Value?.ToString();
                txtSDT.Text = row.Cells["SĐT"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtDiachi.Text = row.Cells["Địa chỉ"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["Ngày sinh"].Value?.ToString(), out DateTime ngaySinh))
                    dtpNgaysinh.Value = ngaySinh;

                cboGioitinh.Text = row.Cells["Giới tính"].Value?.ToString();
            }
        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMand.Text) || string.IsNullOrWhiteSpace(txtHoten.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Khách, Họ tên và SĐT!");
                return;
            }

            string maKhach = txtMand.Text.Trim();
            string hoten = txtHoten.Text.Trim().Replace("'", "''");
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim().Replace("'", "''");
            string diachi = txtDiachi.Text.Trim().Replace("'", "''");
            string gioitinh = cboGioitinh.Text.Trim();
            string ngaysinh = dtpNgaysinh.Value.ToString("yyyy-MM-dd");
            string matkhauDefault = "123456";

            string sql = $@"INSERT INTO KhachHang (MaKhach, TenKhach, SoDienThoai, Email, MatKhau, GioiTinh, NgaySinh, Diachi) 
                            VALUES ('{maKhach}', N'{hoten}', '{sdt}', '{email}', '{matkhauDefault}', N'{gioitinh}', '{ngaysinh}', N'{diachi}')";

            if (db.WriteData(sql) > 0)
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                LoadDanhsachkhachhang();
                btnLammoi_MouseClick(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Mã khách hàng có thể đã tồn tại.");
            }
        }

        private void btnSua_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMand.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!");
                return;
            }

            string hoten = txtHoten.Text.Trim().Replace("'", "''");
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim().Replace("'", "''");
            string diachi = txtDiachi.Text.Trim().Replace("'", "''");
            string gioitinh = cboGioitinh.Text.Trim();
            string ngaysinh = dtpNgaysinh.Value.ToString("yyyy-MM-dd");

            string sql = $@"UPDATE KhachHang 
                            SET TenKhach=N'{hoten}', SoDienThoai='{sdt}', Email='{email}', Diachi=N'{diachi}', NgaySinh='{ngaysinh}', GioiTinh=N'{gioitinh}' 
                            WHERE MaKhach='{txtMand.Text.Trim()}'";

            if (db.WriteData(sql) > 0)
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công!");
                LoadDanhsachkhachhang();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnXoa_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMand.Text)) return;

            if (MessageBox.Show("Bạn có muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM KhachHang WHERE MaKhach='{txtMand.Text.Trim()}'";
                if (db.WriteData(sql) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadDanhsachkhachhang();
                    btnLammoi_MouseClick(sender, e);
                }
                else
                {
                    MessageBox.Show("Không thể xóa khách hàng đang có phiếu đặt sân liên kết!");
                }
            }
        }


        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimkiem.Text.Trim().Replace("'", "''");
            string sql = $@"SELECT MaKhach AS [Mã Khách], TenKhach AS [Họ và Tên], SoDienThoai AS [SĐT], Email, GioiTinh AS [Giới tính], NgaySinh AS [Ngày sinh], Diachi AS [Địa chỉ] 
                            FROM KhachHang 
                            WHERE TenKhach LIKE N'%{keyword}%' OR SoDienThoai LIKE '%{keyword}%' OR MaKhach LIKE '%{keyword}%'";
            dgvKhachhang.DataSource = db.ReadData(sql);
        }

        private void btnLammoi_MouseClick(object sender, MouseEventArgs e)
        {
            txtMand.Clear();
            txtHoten.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiachi.Clear();
            dtpNgaysinh.Value = DateTime.Now;
            cboGioitinh.SelectedIndex = -1;
            txtTimkiem.Clear();
            LoadDanhsachkhachhang();
        }




        private void LoadDanhsachchusan()
        {
            string sql = "SELECT MaChuSan AS [Mã TK], TenChuSan AS [Tên đăng nhập], MatKhau AS [Mật khẩu], Quyen AS [Loại tài khoản], SoDienThoai AS [SĐT], Email FROM ChuSan";
            DataTable dt = db.ReadData(sql);
            if (dt != null)
            {
                dgvTaikhoan.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Lỗi: Không tải được danh sách tài khoản chủ sân!");
            }
        }

        private void dgvTaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaikhoan.Rows[e.RowIndex];
                txtMatk.Text = row.Cells["Mã TK"].Value?.ToString();
                txtTendangnhap.Text = row.Cells["Tên đăng nhập"].Value?.ToString();
                cboLoaitk.Text = row.Cells["Loại tài khoản"].Value?.ToString();
                txtSDTCS.Text = row.Cells["SĐT"].Value?.ToString();
                txtEmailCS.Text = row.Cells["Email"].Value?.ToString();
                txtMatkhau.Clear();
            }
        }

        private void btnThemTK_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatk.Text) || string.IsNullOrWhiteSpace(txtTendangnhap.Text) || string.IsNullOrWhiteSpace(txtMatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã TK, Tên đăng nhập và Mật khẩu!");
                return;
            }

            string maCS = txtMatk.Text.Trim();
            string tenCS = txtTendangnhap.Text.Trim().Replace("'", "''");
            string matkhau = txtMatkhau.Text.Trim();
            string quyen = string.IsNullOrWhiteSpace(cboLoaitk.Text) ? "Admin" : cboLoaitk.Text.Trim();
            string sdt = txtSDTCS.Text.Trim();
            string email = txtEmailCS.Text.Trim().Replace("'", "''");

            string sql = $@"INSERT INTO ChuSan (MaChuSan, TenChuSan, SoDienThoai, Email, MatKhau, Quyen) 
                    VALUES ('{maCS}', N'{tenCS}', '{sdt}', '{email}', '{matkhau}', N'{quyen}')";

            if (db.WriteData(sql) > 0)
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                LoadDanhsachchusan();
                btnLammoiTK_MouseClick(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnXuaTK_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatk.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa!");
                return;
            }

            string tenCS = txtTendangnhap.Text.Trim().Replace("'", "''");
            string quyen = cboLoaitk.Text.Trim();
            string sdt = txtSDTCS.Text.Trim();
            string email = txtEmailCS.Text.Trim().Replace("'", "''");

            string sqlUpdatePass = string.IsNullOrWhiteSpace(txtMatkhau.Text)
                ? ""
                : $", MatKhau='{txtMatkhau.Text.Trim()}'";

            string sql = $@"UPDATE ChuSan 
                    SET TenChuSan=N'{tenCS}', SoDienThoai='{sdt}', Email='{email}', Quyen=N'{quyen}' {sqlUpdatePass} 
                    WHERE MaChuSan='{txtMatk.Text.Trim()}'";

            if (db.WriteData(sql) > 0)
            {
                MessageBox.Show("Sửa tài khoản thành công!");
                LoadDanhsachchusan();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoaTK_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatk.Text)) return;

            if (MessageBox.Show("Bạn có muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM ChuSan WHERE MaChuSan='{txtMatk.Text.Trim()}'";
                if (db.WriteData(sql) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadDanhsachchusan();
                    btnLammoiTK_MouseClick(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void txtTimkiemTK_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimkiemTK.Text.Trim().Replace("'", "''");

            string sql = $@"SELECT MaChuSan AS [Mã TK], TenChuSan AS [Tên đăng nhập], MatKhau AS [Mật khẩu], Quyen AS [Loại tài khoản], SoDienThoai AS [SĐT], Email 
                            FROM ChuSan 
                            WHERE TenChuSan LIKE N'%{keyword}%' OR MaChuSan LIKE '%{keyword}%'";

            DataTable dt = db.ReadData(sql);
            if (dt != null)
            {
                dgvTaikhoan.DataSource = dt;
            }
        }

        private void btnLammoiTK_MouseClick(object sender, MouseEventArgs e)
        {
            txtMatk.Clear();
            txtTendangnhap.Clear();
            txtMatkhau.Clear();
            txtSDTCS.Clear();
            txtEmailCS.Clear();
            cboLoaitk.SelectedIndex = -1;
            txtTimkiemTK.Clear();
            LoadDanhsachchusan();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
