using System;
using System.Data;
using System.Windows.Forms;

namespace quanlydatsan.All_User_control
{
    public partial class UC_ThongTinCaNhan : UserControl
    {
        private readonly Database db = new Database();
        private string currentPasswordInDb = "";

        // Sự kiện callback để thông báo cho Form Dashbroad cập nhật lại tên hiển thị
        public event Action<string> OnProfileUpdated;

        public UC_ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void UC_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadThongTinKhachHang();
        }

        #region 1. Tải thông tin khách hàng từ Database
        public void LoadThongTinKhachHang()
        {
            if (string.IsNullOrEmpty(Session.UserId))
            {
                MessageBox.Show("Phiên đăng nhập đã hết hạn. Vui lòng đăng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string safeUserId = Session.UserId.Replace("'", "''");
            string query = $@"SELECT MaKhach, TenKhach, SoDienThoai, Email, MatKhau, GioiTinh, NgaySinh, Diachi 
                             FROM KhachHang 
                             WHERE MaKhach = '{safeUserId}'";

            DataSet ds = db.GetData(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow r = ds.Tables[0].Rows[0];

                txtMaKhach.Text = r["MaKhach"].ToString();
                txtTenKhach.Text = r["TenKhach"].ToString();
                txtSoDienThoai.Text = r["SoDienThoai"] != DBNull.Value ? r["SoDienThoai"].ToString() : "";
                txtEmail.Text = r["Email"] != DBNull.Value ? r["Email"].ToString() : "";
                txtDiaChi.Text = r["Diachi"] != DBNull.Value ? r["Diachi"].ToString() : "";

                // Giới tính
                string gioiTinh = r["GioiTinh"] != DBNull.Value ? r["GioiTinh"].ToString() : "Nam";
                int idx = cboGioiTinh.FindStringExact(gioiTinh);
                cboGioiTinh.SelectedIndex = idx >= 0 ? idx : 0;

                // Ngày sinh
                if (r["NgaySinh"] != DBNull.Value)
                {
                    dtpNgaySinh.Value = Convert.ToDateTime(r["NgaySinh"]);
                }
                else
                {
                    dtpNgaySinh.Value = new DateTime(2000, 1, 1);
                }

                // Mật khẩu hiện tại
                currentPasswordInDb = r["MatKhau"].ToString();

                // Cập nhật card bên trái
                lblCardTenKhach.Text = txtTenKhach.Text;
                lblCardMaKhach.Text = $"Mã KH: {txtMaKhach.Text}";
            }

            // Đặt lại trạng thái nhóm đổi mật khẩu
            chkDoiMatKhau.Checked = false;
            txtMatKhauCu.Clear();
            txtMatKhauMoi.Clear();
            txtXacNhanMatKhau.Clear();
        }
        #endregion

        #region 2. Bật / Tắt ô đổi mật khẩu
        private void chkDoiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkDoiMatKhau.Checked;
            txtMatKhauCu.Enabled = isChecked;
            txtMatKhauMoi.Enabled = isChecked;
            txtXacNhanMatKhau.Enabled = isChecked;

            if (!isChecked)
            {
                txtMatKhauCu.Clear();
                txtMatKhauMoi.Clear();
                txtXacNhanMatKhau.Clear();
            }
        }
        #endregion

        #region 3. Lưu thông tin chỉnh sửa
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenKhach = txtTenKhach.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string gioiTinh = cboGioiTinh.SelectedItem?.ToString() ?? "Nam";
            string ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");

            // Kiểm tra tính hợp lệ cơ bản
            if (string.IsNullOrEmpty(tenKhach))
            {
                MessageBox.Show("Họ và tên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhach.Focus();
                return;
            }

            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Số điện thoại không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            // Kiểm tra nếu có yêu cầu đổi mật khẩu
            string updatePasswordClause = "";
            if (chkDoiMatKhau.Checked)
            {
                string mkCu = txtMatKhauCu.Text;
                string mkMoi = txtMatKhauMoi.Text;
                string xacNhan = txtXacNhanMatKhau.Text;

                if (string.IsNullOrEmpty(mkCu) || string.IsNullOrEmpty(mkMoi) || string.IsNullOrEmpty(xacNhan))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các trường đổi mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (mkCu != currentPasswordInDb)
                {
                    MessageBox.Show("Mật khẩu hiện tại không chính xác!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhauCu.Focus();
                    return;
                }

                if (mkMoi.Length < 6)
                {
                    MessageBox.Show("Mật khẩu mới phải có tối thiểu 6 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhauMoi.Focus();
                    return;
                }

                if (mkMoi != xacNhan)
                {
                    MessageBox.Show("Xác nhận mật khẩu mới không khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtXacNhanMatKhau.Focus();
                    return;
                }

                updatePasswordClause = $", MatKhau = '{mkMoi.Replace("'", "''")}'";
            }

            // Cập nhật CSDL
            string safeMaKhach = txtMaKhach.Text.Replace("'", "''");
            string updateQuery = $@"
                UPDATE KhachHang
                SET TenKhach = N'{tenKhach.Replace("'", "''")}',
                    SoDienThoai = '{sdt.Replace("'", "''")}',
                    Email = '{email.Replace("'", "''")}',
                    GioiTinh = N'{gioiTinh.Replace("'", "''")}',
                    NgaySinh = '{ngaySinh}',
                    Diachi = N'{diaChi.Replace("'", "''")}'
                    {updatePasswordClause}
                WHERE MaKhach = '{safeMaKhach}'";

            db.setData(updateQuery, "Cập nhật thông tin cá nhân thành công!");

            // Cập nhật lại Session của ứng dụng
            Session.FullName = tenKhach;
            Session.Phone = sdt;
            Session.Email = email;

            // Kích hoạt sự kiện để Form cha cập nhật lại giao diện
            OnProfileUpdated?.Invoke(tenKhach);

            // Nạp lại dữ liệu
            LoadThongTinKhachHang();
        }
        #endregion

        #region 4. Nút Khôi Phục ban đầu
        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadThongTinKhachHang();
        }
        #endregion
    }
}