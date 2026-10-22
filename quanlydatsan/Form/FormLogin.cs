using quanlydatsan.Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace quanlydatsan
{
    public partial class FormLogin : Form
    {
        // Khởi tạo kết nối CSDL từ class Database
        private readonly DatabaseC db = new DatabaseC();

        public FormLogin()
        {
            InitializeComponent();
            SwitchPanel(pnlLogin);
        }

        #region Chuyển đổi giao diện Panel
        private void SwitchPanel(Panel targetPanel)
        {
            pnlLogin.Visible = (targetPanel == pnlLogin);
            pnlRegister.Visible = (targetPanel == pnlRegister);
            pnlForgotPassword.Visible = (targetPanel == pnlForgotPassword);
            targetPanel.BringToFront();
        }

        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchPanel(pnlRegister);
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchPanel(pnlForgotPassword);
        }

        private void linkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchPanel(pnlLogin);
        }

        private void chkShowPasswordLogin_CheckedChanged(object sender, EventArgs e)
        {
            txtLoginPassword.UseSystemPasswordChar = !chkShowPasswordLogin.Checked;
        }
        #endregion

        #region 1. ĐĂNG NHẬP (Email / Số điện thoại / Username)
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = txtLoginUsername.Text.Trim();
            string password = txtLoginPassword.Text;

            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string safeAccount = account.Replace("'", "''");
            string safePassword = password.Replace("'", "''");

            // =========================================================================
            // 1. KIỂM TRA TRONG BẢNG ChuSan (ADMIN / QUẢN LÝ CHỦ SÂN)
            // =========================================================================
            string queryChuSan = $@"SELECT MaChuSan, TenChuSan, Email, SoDienThoai, Quyen 
                            FROM ChuSan 
                            WHERE (MaChuSan = '{safeAccount}' OR TenChuSan = N'{safeAccount}' OR Email = '{safeAccount}' OR SoDienThoai = '{safeAccount}') 
                              AND MatKhau = '{safePassword}'";

            DataSet dsChuSan = db.GetData(queryChuSan);
            if (dsChuSan != null && dsChuSan.Tables.Count > 0 && dsChuSan.Tables[0].Rows.Count > 0)
            {
                DataRow r = dsChuSan.Tables[0].Rows[0];
                Session.UserId = r["MaChuSan"].ToString();
                Session.FullName = r["TenChuSan"].ToString();
                Session.Email = r["Email"] != DBNull.Value ? r["Email"].ToString() : "";
                Session.Phone = r["SoDienThoai"] != DBNull.Value ? r["SoDienThoai"].ToString() : "";
                Session.Role = r["Quyen"] != DBNull.Value ? r["Quyen"].ToString() : "Admin";

                MessageBox.Show($"Đăng nhập thành công với quyền Quản Trị Viên: {Session.FullName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chuyển sang Dashboard dành cho ADMIN
                MoDashbroadAdmin();
                return;
            }

            // =========================================================================
            // 2. KIỂM TRA TRONG BẢNG KhachHang (KHÁCH ĐẶT SÂN)
            // =========================================================================
            string queryKhach = $@"SELECT MaKhach, TenKhach, Email, SoDienThoai 
                           FROM KhachHang 
                           WHERE (MaKhach = '{safeAccount}' OR TenKhach = N'{safeAccount}' OR Email = '{safeAccount}' OR SoDienThoai = '{safeAccount}') 
                             AND MatKhau = '{safePassword}'";

            DataSet dsKhach = db.GetData(queryKhach);
            if (dsKhach != null && dsKhach.Tables.Count > 0 && dsKhach.Tables[0].Rows.Count > 0)
            {
                DataRow r = dsKhach.Tables[0].Rows[0];
                Session.UserId = r["MaKhach"].ToString();
                Session.FullName = r["TenKhach"].ToString();
                Session.Email = r["Email"] != DBNull.Value ? r["Email"].ToString() : "";
                Session.Phone = r["SoDienThoai"] != DBNull.Value ? r["SoDienThoai"].ToString() : "";
                Session.Role = "KhachHang";

                MessageBox.Show($"Đăng nhập thành công! Chào mừng khách hàng: {Session.FullName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chuyển sang Dashboard dành cho KHÁCH HÀNG
                MoDashbroadKhachHang();
                return;
            }

            MessageBox.Show("Email, số điện thoại, tên tài khoản hoặc mật khẩu không chính xác!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Mở giao diện Admin
        private void MoDashbroadAdmin()
        {
            // Nếu bạn đặt tên form là dashbroadamin hoặc DashbroadAdmin, gọi đúng tên form đó:
            DashbroadAdmin adminForm = new DashbroadAdmin();
            adminForm.FormClosed += (s, args) => this.Close(); // Đóng hẳn app khi tắt Form Admin
            adminForm.Show();
            this.Hide(); // Ẩn form login
        }

        // Mở giao diện Khách hàng
        private void MoDashbroadKhachHang()
        {
            DashbroadKH userForm = new DashbroadKH();
            userForm.FormClosed += (s, args) => this.Close(); // Đóng hẳn app khi tắt Form User
            userForm.Show();
            this.Hide();
        }
        #endregion

        #region 2. ĐĂNG KÝ
        #region 2. ĐĂNG KÝ BẰNG GMAIL & SỐ ĐIỆN THOẠI
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtRegFullName.Text.Trim();
            string phone = txtRegPhone.Text.Trim();
            // Ô nhập Email/Gmail (nếu ô text cũ tên là txtRegUsername thì bạn có thể dùng hoặc đổi thành txtRegEmail)
            string email = txtRegUsername.Text.Trim();
            string password = txtRegPassword.Text;
            string confirmPass = txtRegConfirmPassword.Text;

            // 1. Kiểm tra để trống
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin: Họ tên, Số điện thoại, Email và Mật khẩu!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra định dạng Gmail cơ bản
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Địa chỉ Email không đúng định dạng (ví dụ: example@gmail.com)!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegUsername.Focus();
                return;
            }

            // 3. Kiểm tra khớp mật khẩu
            if (password != confirmPass)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegConfirmPassword.Focus();
                return;
            }

            string safeEmail = email.Replace("'", "''");
            string safePhone = phone.Replace("'", "''");

            // 4. Kiểm tra trùng lặp Email hoặc Số điện thoại
            string checkQuery = $@"SELECT MaKhach FROM KhachHang 
                          WHERE Email = '{safeEmail}' OR SoDienThoai = '{safePhone}'";
            DataSet dsCheck = db.GetData(checkQuery);

            if (dsCheck != null && dsCheck.Tables.Count > 0 && dsCheck.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Email hoặc Số điện thoại này đã được sử dụng bởi tài khoản khác!",
                                "Trùng thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Sinh mã khách hàng tự động dạng KH001, KH002...
            string maKhachMoi = TaoMaKhachTuDong();

            // 6. Lưu vào bảng KhachHang
            string insertQuery = $@"
            INSERT INTO KhachHang (MaKhach, TenKhach, SoDienThoai, Email, MatKhau) 
            VALUES ('{maKhachMoi}', N'{fullName.Replace("'", "''")}', '{safePhone}', '{safeEmail}', '{password.Replace("'", "''")}')";

            db.setData(insertQuery, $"Đăng ký thành công!\nMã khách hàng của bạn là: {maKhachMoi}\nHãy đăng nhập bằng Email/SĐT để tiếp tục.");

            // Dọn dẹp các ô nhập liệu
            txtRegFullName.Clear();
            txtRegPhone.Clear();
            txtRegUsername.Clear();
            txtRegPassword.Clear();
            txtRegConfirmPassword.Clear();

            // Chuyển về màn hình đăng nhập
            SwitchPanel(pnlLogin);
        }
        #endregion
        private string TaoMaKhachTuDong()
        {
            string sql = @"
                SELECT ISNULL(MAX(TRY_CAST(SUBSTRING(MaKhach, 3, LEN(MaKhach)) AS INT)), 0) + 1 
                FROM KhachHang
                WHERE MaKhach LIKE 'KH%'";

            DataSet ds = db.GetData(sql);
            int stt = (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                ? Convert.ToInt32(ds.Tables[0].Rows[0][0])
                : 1;

            return $"KH{stt:D3}";
        }
        #endregion

        #region 3. ĐỔI MẬT KHẨU
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string account = txtForgotAccount.Text.Trim();
            string newPass = txtForgotNewPass.Text;
            string confirmPass = txtForgotConfirmPass.Text;

            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản, mật khẩu mới và xác nhận mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không trùng khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtForgotConfirmPass.Focus();
                return;
            }

            string safeAccount = account.Replace("'", "''");
            string safeNewPass = newPass.Replace("'", "''");

            string checkExistQuery = $@"SELECT MaChuSan FROM ChuSan WHERE (MaChuSan = '{safeAccount}' OR Email = '{safeAccount}' OR SoDienThoai = '{safeAccount}')
                                        UNION
                                        SELECT MaKhach FROM KhachHang WHERE (MaKhach = '{safeAccount}' OR Email = '{safeAccount}' OR SoDienThoai = '{safeAccount}')";

            DataSet ds = db.GetData(checkExistQuery);
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy tài khoản, email hoặc số điện thoại này trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string updateQuery = $@"UPDATE ChuSan SET MatKhau = '{safeNewPass}' 
                                    WHERE (MaChuSan = '{safeAccount}' OR Email = '{safeAccount}' OR SoDienThoai = '{safeAccount}');

                                    UPDATE KhachHang SET MatKhau = '{safeNewPass}' 
                                    WHERE (MaKhach = '{safeAccount}' OR Email = '{safeAccount}' OR SoDienThoai = '{safeAccount}');";

            db.setData(updateQuery, "Đổi mật khẩu thành công! Vui lòng đăng nhập bằng mật khẩu mới.");

            txtForgotAccount.Clear();
            txtForgotNewPass.Clear();
            txtForgotConfirmPass.Clear();

            SwitchPanel(pnlLogin);
        }
        #endregion
    }
}