using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.Loader;
using System.Text;
using System.Windows.Forms;

namespace quanlydatsan
{
    public partial class Khachhangvataikhoan : Form
    {
        Database db = new Database();
        public Khachhangvataikhoan()
        {
            InitializeComponent();
        }

        private void Khachhangvataikhoan_Load(object sender, EventArgs e)
        {
            LoadDanhsachkhachhang();
            LoadComboboxmand();
            LoadDanhsachtaikhoan();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                LoadDanhsachkhachhang();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                LoadComboboxmand();
                LoadDanhsachtaikhoan();
            }
        }


        private void LoadDanhsachkhachhang()
        {
            string sql = "SELECT Manguoidung AS [Mã ND], Hoten AS [Họ và Tên], Sodienthoai AS [SĐT], Email, Diachi AS [Địa chỉ], Ngaysinh AS [Ngày sinh], Gioitinh AS [Giới tính] FROM Thongtinnguoidung";
            dgvKhachhang.DataSource = db.ReadData(sql);
        }

        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachhang.Rows[e.RowIndex];
                txtMand.Text = row.Cells["Mã ND"].Value?.ToString();
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
            if (string.IsNullOrWhiteSpace(txtHoten.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ tên và SĐT!");
                return;
            }
            string sql = $"INSERT INTO Thongtinnguoidung VALUES (N'{txtHoten.Text}', '{txtSDT.Text}', '{txtEmail.Text}', N'{txtDiachi.Text}', '{dtpNgaysinh.Value:yyyy-MM-dd}', N'{cboGioitinh.Text}')";
            if (db.WriteData(sql) > 0)
            {
                MessageBox.Show("Thêm thành công!");
                LoadDanhsachkhachhang();
                btnLammoi_MouseClick(sender, e);
            }
            else MessageBox.Show("Thêm thất bại!");
        }

        private void btnSua_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMand.Text)) return;
            string sql = $"UPDATE Thongtinnguoidung SET Hoten=N'{txtHoten.Text}', Sodienthoai='{txtSDT.Text}', Email='{txtEmail.Text}', Diachi=N'{txtDiachi.Text}', Ngaysinh='{dtpNgaysinh.Value:yyyy-MM-dd}', Gioitinh=N'{cboGioitinh.Text}' WHERE Manguoidung={txtMand.Text}";
            if (db.WriteData(sql) > 0)
            {
                MessageBox.Show("Sửa thành công!");
                LoadDanhsachkhachhang();
            }
        }

        private void btnXoa_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMand.Text)) return;
            if (MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM Thongtinnguoidung WHERE Manguoidung={txtMand.Text}";
                if (db.WriteData(sql) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadDanhsachkhachhang();
                    btnLammoi_MouseClick(sender, e);
                }
                else MessageBox.Show("Không thể xóa khách hàng đang có dữ liệu liên kết!");
            }
        }


        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string sql = $"SELECT Manguoidung AS [Mã ND], Hoten AS [Họ và Tên], Sodienthoai AS [SĐT], Email, Diachi AS [Địa chỉ], Ngaysinh AS [Ngày sinh], Gioitinh AS [Giới tính] FROM Thongtinnguoidung WHERE Hoten LIKE N'%{txtTimkiem.Text}%' OR Sodienthoai LIKE '%{txtTimkiem.Text}%'";
            dgvKhachhang.DataSource = db.ReadData(sql);
        }

        private void btnLammoi_MouseClick(object sender, EventArgs e)
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




        private void LoadComboboxmand()
        {
            string sql = "SELECT Manguoidung FROM Thongtinnguoidung";
            cboMand.DataSource = db.ReadData(sql);
            cboMand.DisplayMember = "Manguoidung";
            cboMand.ValueMember = "Manguoidung";
            cboMand.SelectedIndex = -1;
        }


        private void LoadDanhsachtaikhoan()
        {
            string sql = "SELECT Mataikhoan AS [Mã TK], Tendangnhap AS [Tên đăng nhập], Matkhau AS [Mật khẩu], " +
                 "Vaitro AS [Loại tài khoản], Trangthai AS [Trạng thái], Ngaytao AS [Ngày tạo] " +
                 "FROM Taikhoan";

            DataTable dt = db.ReadData(sql);
            if (dt != null)
            {
                dgvTaikhoan.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Lỗi: Không tải được danh sách Tài khoản thành viên!");
            }
        }

        private void dgvTaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaikhoan.Rows[e.RowIndex];
                txtMatk.Text = row.Cells["Mã TK"].Value?.ToString();
                txtTendangnhap.Text = row.Cells["Tên Đăng Nhập"].Value?.ToString();
                cboLoaitk.Text = row.Cells["Loại TK"].Value?.ToString();
                cboTrangthai.Text = row.Cells["Trạng Thái"].Value?.ToString();
                cboMand.SelectedValue = row.Cells["Mã ND"].Value;
                txtMatkhau.Clear();
            }
        }

        private void btnThemTK_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTendangnhap.Text) || string.IsNullOrWhiteSpace(txtMatkhau.Text) || cboMand.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!");
                return;
            }
            string sql = $"INSERT INTO Taikhoan VALUES ('{txtTendangnhap.Text}', '{txtMatkhau.Text}', '{cboLoaitk.Text}', '{cboTrangthai.Text}', {cboMand.SelectedValue})";
            if (db.WriteData(sql) > 0)
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                LoadDanhsachtaikhoan();
                btnLammoiTK_MouseClick(sender, e);
            }
            else MessageBox.Show("Thêm thất bại!");
        }

        private void btnXuaTK_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatk.Text)) return;
            string sql = string.IsNullOrWhiteSpace(txtMatkhau.Text)
                ? $"UPDATE Taikhoan SET Tendangnhap='{txtTendangnhap.Text}', Loaitaikhoan='{cboLoaitk.Text}', Trangthai='{cboTrangthai.Text}', Manguoidung={cboMand.SelectedValue} WHERE Mataikhoan={txtMatk.Text}"
                : $"UPDATE Taikhoan SET Tendangnhap='{txtTendangnhap.Text}', Matkhau='{txtMatkhau.Text}', Loaitaikhoan='{cboLoaitk.Text}', Trangthai='{cboTrangthai.Text}', Manguoidung={cboMand.SelectedValue} WHERE Mataikhoan={txtMatk.Text}";

            if (db.WriteData(sql) > 0)
            {
                MessageBox.Show("Sửa tài khoản thành công!");
                LoadDanhsachtaikhoan();
            }
        }

        private void btnXoaTK_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatk.Text)) return;
            if (MessageBox.Show("Bạn có muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM Taikhoan WHERE Mataikhoan={txtMatk.Text}";
                if (db.WriteData(sql) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadDanhsachtaikhoan();
                    btnLammoiTK_MouseClick(sender, e);
                }
            }
        }

        private void txtTimkiemTK_TextChanged(object sender, EventArgs e)
        {
            string sql = $"SELECT Mataikhoan AS [Mã TK], Tendangnhap AS [Tên Đăng Nhập], Loaitaikhoan AS [Loại TK], Trangthai AS [Trạng Thái], Manguoidung AS [Mã ND] FROM Taikhoan WHERE Tendangnhap LIKE '%{txtTimkiemTK.Text}%'";
            dgvTaikhoan.DataSource = db.ReadData(sql);
        }

        private void btnLammoiTK_MouseClick(object sender, MouseEventArgs e)
        {
            txtMatk.Clear(); 
            txtTendangnhap.Clear(); 
            txtMatkhau.Clear();
            cboLoaitk.SelectedIndex = -1; 
            cboTrangthai.SelectedIndex = -1; 
            cboMand.SelectedIndex = -1; 
            txtTimkiemTK.Clear();
            LoadDanhsachtaikhoan();
        }
    }
}
