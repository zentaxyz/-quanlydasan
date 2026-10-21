using System;
using System.Data;
using System.Windows.Forms;

namespace quanlydatsan
{
    public partial class UC_ThongTinChuSan : UserControl
    {
        // Có thể dùng Database hoặc DatabaseKH tùy thuộc vào class DB bạn sử dụng cho Admin
        private readonly DatabaseC db = new DatabaseC();
        private string currentPasswordInDb = "";

        // Sự kiện callback để form DashbroadAdmin cập nhật lại tên hiển thị sau khi sửa
        public event Action<string> OnProfileUpdated;

        public UC_ThongTinChuSan()
        {
            InitializeComponent();
        }

        private void UC_ThongTinChuSan_Load(object sender, EventArgs e)
        {
            LoadThongTinChuSan();
        }

        #region 1. Tải thông tin chủ sân từ CSDL
        public void LoadThongTinChuSan()
        {
            if (string.IsNullOrEmpty(Session.UserId))
            {
                MessageBox.Show("Phiên làm việc đã hết hạn. Vui lòng đăng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string safeUserId = Session.UserId.Replace("'", "''");
            string query = $@"SELECT MaChuSan, TenChuSan, SoDienThoai, Email, MatKhau, Quyen 
                             FROM ChuSan 
                             WHERE MaChuSan = '{safeUserId}'";

            DataSet ds = db.GetData(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow r = ds.Tables[0].Rows[0];

                txtMaChuSan.Text = r["MaChuSan"].ToString();
                txtTenChuSan.Text = r["TenChuSan"].ToString();
                txtSoDienThoai.Text = r["SoDienThoai"] != DBNull.Value ? r["SoDienThoai"].ToString() : "";
                txtEmail.Text = r["Email"] != DBNull.Value ? r["Email"].ToString() : "";
                txtQuyen.Text = r["Quyen"] != DBNull.Value ? r["Quyen"].ToString() : "Admin";

                currentPasswordInDb = r["MatKhau"].ToString();

                // Cập nhật card bên trái
                lblCardTenChuSan.Text = txtTenChuSan.Text;
                lblCardMaChuSan.Text = $"Mã Admin: {txtMaChuSan.Text}";
            }

            // Đặt lại nhóm đổi mật khẩu
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
            string tenChuSan = txtTenChuSan.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(tenChuSan))
            {
                MessageBox.Show("Họ tên chủ sân không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChuSan.Focus();
                return;
            }

            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Số điện thoại không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            // Kiểm tra mật khẩu nếu admin chọn đổi mật khẩu
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

            string safeMaChuSan = txtMaChuSan.Text.Replace("'", "''");
            string updateQuery = $@"
                UPDATE ChuSan
                SET TenChuSan = N'{tenChuSan.Replace("'", "''")}',
                    SoDienThoai = '{sdt.Replace("'", "''")}',
                    Email = '{email.Replace("'", "''")}'
                    {updatePasswordClause}
                WHERE MaChuSan = '{safeMaChuSan}'";

            db.setData(updateQuery, "Cập nhật thông tin quản trị viên thành công!");

            // Cập nhật lại Session
            Session.FullName = tenChuSan;
            Session.Phone = sdt;
            Session.Email = email;

            // Bắn sự kiện ra ngoài form DashbroadAdmin
            OnProfileUpdated?.Invoke(tenChuSan);

            LoadThongTinChuSan();
        }
        #endregion

        #region 4. Nút Khôi Phục ban đầu
        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadThongTinChuSan();
        }
        #endregion
    }
}