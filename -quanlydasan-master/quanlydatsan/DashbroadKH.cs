using System;
using System.Drawing;
using System.Windows.Forms;
using quanlydatsan.All_User_control;

namespace quanlydatsan
{
    public partial class DashbroadKH : Form
    {
        private Button currentActiveButton;

        // 1. Khai báo sẵn các biến lưu trữ UserControl (Mặc định là null)
        private UC_Datsan ucDatsan;
        private UC_LichSuDatSan ucLichSu;
        private UC_ThongTinCaNhan ucProfile;

        public DashbroadKH()
        {
            InitializeComponent();
        }

        private void DashbroadKH_Load(object sender, EventArgs e)
        {
            lblUserName.Text = string.IsNullOrEmpty(Session.FullName) ? "Khách Hàng" : Session.FullName;
            lblUserRole.Text = "Khách Hàng";
            lblDateTime.Text = "Hôm nay: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // Mặc định hiển thị trang Đặt Sân hoặc Trang Chủ
            btnBooking.PerformClick();
        }

        #region Xử lý chuyển tab không tạo mới liên tục
        private void btnNav_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            if (btn == btnBooking)
            {
                SetActiveNavButton(btn, "ĐẶT SÂN THỂ THAO");

                // Chỉ tạo mới nếu chưa từng mở lần nào
                if (ucDatsan == null)
                {
                    ucDatsan = new UC_Datsan();
                    ThemControlVaoPanel(ucDatsan);
                }
                else
                {
                    ucDatsan.BringToFront();
                    ucDatsan.LoadDanhSachSan(); // Cập nhật lại trạng thái sân mới nhất
                }
            }
            else if (btn == btnHistory)
            {
                SetActiveNavButton(btn, "LỊCH SỬ ĐẶT SÂN");

                if (ucLichSu == null)
                {
                    ucLichSu = new UC_LichSuDatSan();
                    ThemControlVaoPanel(ucLichSu);
                }
                else
                {
                    ucLichSu.BringToFront();
                    ucLichSu.LoadLichSu(); // Cập nhật lại danh sách đơn mới nhất
                }
            }
            else if (btn == btnProfile)
            {
                SetActiveNavButton(btn, "THÔNG TIN CÁ NHÂN");

                if (ucProfile == null)
                {
                    ucProfile = new UC_ThongTinCaNhan();
                    ucProfile.OnProfileUpdated += (newName) =>
                    {
                        lblUserName.Text = newName;
                    };
                    ThemControlVaoPanel(ucProfile);
                }
                else
                {
                    ucProfile.BringToFront();
                    ucProfile.LoadThongTinKhachHang();
                }
            }
        }

        // Hàm thêm UserControl vào Panel và co giãn vừa khít
        private void ThemControlVaoPanel(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlMainContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void SetActiveNavButton(Button btn, string pageTitle)
        {
            if (currentActiveButton != null)
            {
                currentActiveButton.BackColor = Color.FromArgb(21, 43, 29);
                currentActiveButton.ForeColor = Color.FromArgb(220, 235, 225);
            }

            currentActiveButton = btn;
            currentActiveButton.BackColor = Color.FromArgb(46, 125, 50);
            currentActiveButton.ForeColor = Color.White;

            pnlNavIndicator.Top = btn.Top;
            pnlNavIndicator.BringToFront();

            lblCurrentPage.Text = pageTitle;
        }
        #endregion

        #region Đăng xuất
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Session.UserId = null;
                Session.FullName = null;
                Session.Role = null;

                Form formLogin = Application.OpenForms["test"];
                if (formLogin != null)
                {
                    formLogin.Show();
                }
                else
                {
                    test newLogin = new test();
                    newLogin.Show();
                }

                this.Dispose();
            }
        }
        #endregion
    }
}