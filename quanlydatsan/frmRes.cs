using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlydatsan
{
    public partial class frmRes : Form
    {
        Database dt = new Database();
        String query;
        public frmRes()
        {
            InitializeComponent();
        }

        private void frmRes_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDangky_Click(object sender, EventArgs e)
        {   
            string ten= txtName.Text.Trim();
            string tenDangNhap = txtLogin.Text.Trim();
            string matKhau = txtPass.Text.Trim();
            string soDienThoai = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string diaChi = txtLocation.Text.Trim();

            // 1. Kiểm tra hợp lệ các trường bắt buộc
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) ||
                string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin bắt buộc!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 2.Kiểm tra trùng dữ liệu 
            query = "SELECT COUNT(*) FROM Taikhoan t" +
                " FULL JOIN Thongtinnguoidung u ON t.Mataikhoan = u.Mataikhoan " +
                "WHERE t.Tendangnhap = '" + tenDangNhap + "'" +
                "OR u.Email = '" + email +"'" +
                "OR u.Sodienthoai = '" + soDienThoai +"'";

            DataSet ds = dt.GetData(query);
            if (Convert.ToInt32(ds.Tables[0].Rows[0][0]) != 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc Email hoặc số điện thoại đã được sử dụng", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                query = "INSERT INTO Taikhoan (Tendangnhap, Matkhau, Vaitro, Trangthai, Ngaytao) VALUES ('" + tenDangNhap + "','" + matKhau + "',N'Khách',1,getdate())"
                + "INSERT INTO Thongtinnguoidung (Mataikhoan, Hoten, Sodienthoai, Email, Diachi) VALUES (SCOPE_IDENTITY(),N'" + ten + "','" + soDienThoai + "','" + email + "',N'" + diaChi + "')";

                dt.setData(query, "Đăng ký thành công");
            }
        }
    }
}
