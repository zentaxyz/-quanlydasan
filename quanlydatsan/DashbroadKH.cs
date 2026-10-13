using System;
using System.Drawing;
using System.Windows.Forms;
using quanlydatsan.All_User_control; // Kết nối tới thư mục User Control của bạn

namespace quanlydatsan
{
    public partial class DashbroadKH : Form
    {
        private Button currentActiveButton;

        public DashbroadKH()
        {
            InitializeComponent();
        }

        private void DashbroadLogin_Load(object sender, EventArgs e)
        {
            // 1. Hiển thị thông tin người đăng nhập từ Session
            lblUserName.Text = string.IsNullOrEmpty(Session.FullName) ? "Khách Vãng Lai" : Session.FullName;
            lblUserRole.Text = Session.Role == "KhachHang" ? "Khách Hàng" : "Quản Lý / Chủ Sân";

            // 2. Hiển thị ngày giờ
            lblDateTime.Text = "Hôm nay: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // 3. Mặc định mở Trang Chủ
            SetActiveNavButton(btnHome, "TRANG CHỦ");
            LoadHomePageView();
        }

        #region Xử lý chuyển đổi Menu Điều hướng
        private void btnNav_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            if (btn == btnHome)
            {
                SetActiveNavButton(btn, "TRANG CHỦ");
                LoadHomePageView();
            }
            else if (btn == btnBooking)
            {
                SetActiveNavButton(btn, "ĐẶT SÂN THỂ THAO");
                // Nạp UC_Datsan đã có sẵn trong dự án của bạn
                try
                {
                    UC_Datsan ucDatsan = new UC_Datsan();
                    LoadUserControl(ucDatsan);
                }
                catch
                {
                    ShowPlaceholderPage("Giao diện Đặt Sân đang tải hoặc chưa cấu hình xong!");
                }
            }
            else if (btn == btnHistory)
            {
                SetActiveNavButton(btn, "LỊCH SỬ ĐẶT SÂN");
                ShowPlaceholderPage("Danh sách các đơn đặt sân của: " + Session.FullName);
            }
            else if (btn == btnProfile)
            {
                SetActiveNavButton(btn, "THÔNG TIN CÁ NHÂN");
                ShowPlaceholderPage($"Họ tên: {Session.FullName}\nSĐT: {Session.Phone}\nEmail: {Session.Email}\nVai trò: {Session.Role}");
            }
        }

        private void SetActiveNavButton(Button btn, string pageTitle)
        {
            // Reset màu nút cũ
            if (currentActiveButton != null)
            {
                currentActiveButton.BackColor = Color.FromArgb(21, 43, 29);
                currentActiveButton.ForeColor = Color.FromArgb(220, 235, 225);
            }

            // Đặt màu nút đang chọn
            currentActiveButton = btn;
            currentActiveButton.BackColor = Color.FromArgb(46, 125, 50);
            currentActiveButton.ForeColor = Color.White;

            // Di chuyển thanh vạch chỉ báo
            pnlNavIndicator.Top = btn.Top;
            pnlNavIndicator.BringToFront();

            // Cập nhật tiêu đề trang
            lblCurrentPage.Text = pageTitle;
        }

        // Hàm nạp bất kỳ UserControl nào vào màn hình chính
        private void LoadUserControl(UserControl uc)
        {
            pnlMainContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMainContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void LoadHomePageView()
        {
            pnlMainContainer.Controls.Clear();

            // Tạo khung Card chào mừng hiện đại
            Panel cardWelcome = new Panel
            {
                BackColor = Color.White,
                Location = new Point(20, 20),
                Size = new Size(pnlMainContainer.Width - 60, 140),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            Label lblTitle = new Label
            {
                Text = $"Chào mừng trở lại, {Session.FullName}!",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Location = new Point(20, 20),
                AutoSize = true
            };

            Label lblDesc = new Label
            {
                Text = "Hệ thống hỗ trợ tra cứu lịch trống, đặt sân bóng đá, cầu lông, pickleball và thanh toán tiện lợi.",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(100, 116, 139),
                Location = new Point(22, 60),
                AutoSize = true
            };

            Button btnGoBooking = new Button
            {
                Text = "Đặt sân ngay →",
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                BackColor = Color.FromArgb(46, 125, 50),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(22, 92),
                Size = new Size(130, 34),
                Cursor = Cursors.Hand
            };
            btnGoBooking.FlatAppearance.BorderSize = 0;
            btnGoBooking.Click += (s, e) => btnBooking.PerformClick();

            cardWelcome.Controls.AddRange(new Control[] { lblTitle, lblDesc, btnGoBooking });
            pnlMainContainer.Controls.Add(cardWelcome);
        }

        private void ShowPlaceholderPage(string message)
        {
            pnlMainContainer.Controls.Clear();
            Label lbl = new Label
            {
                Text = message,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                ForeColor = Color.FromArgb(71, 85, 105),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlMainContainer.Controls.Add(lbl);
        }
        #endregion

        #region Xử lý Đăng xuất
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                // Xóa phiên làm việc
                Session.UserId = null;
                Session.FullName = null;
                Session.Email = null;
                Session.Phone = null;
                Session.Role = null;

                // Mở lại Form Đăng nhập và đóng Form hiện tại
                test formLogin = new test();
                formLogin.Show();
                this.Dispose();
            }
        }
        #endregion
    }
}