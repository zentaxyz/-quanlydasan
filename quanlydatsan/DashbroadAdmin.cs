using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using quanlydatsan.ADD_UC_ADMIN; // Namespace chứa các UC Admin

namespace quanlydatsan
{
    public partial class DashbroadAdmin : Form
    {
        private Button activeBtn;

        // 1. Khai báo sẵn các biến lưu trữ UserControl (mặc định là null)
        private TrangChu ucTrangChu;
        private QLLS ucQLLS;
        private UC_QLTK ucQLTK;

        public DashbroadAdmin()
        {
            InitializeComponent();
        }

        private void DashbroadAdmin_Load(object sender, EventArgs e)
        {
            // Hiển thị tên Admin từ Session
            lblAdminName.Text = string.IsNullOrEmpty(Session.FullName) ? "Admin" : Session.FullName;
            lblTime.Text = "Hôm nay: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // Chọn trang tổng quan mặc định giống DashbroadKH
            btnDashboard.PerformClick();
        }

        #region Xử lý chuyển tab
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            if (btn == btnDashboard)
            {
                HighlightButton(btn, "TỔNG QUAN HỆ THỐNG");

                if (ucTrangChu == null)
                {
                    ucTrangChu = new TrangChu();
                }
                HienThiUserControl(ucTrangChu);
            }
            else if (btn == btnFieldMgr)
            {
                HighlightButton(btn, "QUẢN LÝ DANH SÁCH SÂN THỂ THAO");

                // Nếu bạn dùng QLLS cho mục Sân hoặc Lịch Sân:
                if (ucQLLS == null)
                {
                    ucQLLS = new QLLS();
                }
                HienThiUserControl(ucQLLS);
            }
            else if (btn == btnOrderMgr)
            {
                HighlightButton(btn, "DUYỆT & QUẢN LÝ ĐẶT SÂN");

                if (ucQLLS == null)
                {
                    ucQLLS = new QLLS();
                }
                HienThiUserControl(ucQLLS);
            }
            else if (btn == btnCustomerMgr)
            {
                HighlightButton(btn, "QUẢN LÝ KHÁCH HÀNG & TÀI KHOẢN");

                if (ucQLTK == null)
                {
                    ucQLTK = new UC_QLTK();
                }
                HienThiUserControl(ucQLTK);
            }
            else if (btn == btnRevenue)
            {
                HighlightButton(btn, "BÁO CÁO THỐNG KÊ DOANH THU");
                ShowContentText("Thống kê tổng tiền thu theo ngày, tuần, tháng từ bảng LichSuThanhToan.");
            }
        }

        // Hàm hiển thị UserControl đảm bảo xóa sạch control tĩnh/chữ cũ và kéo UC lên trên cùng
        private void HienThiUserControl(UserControl uc)
        {
            // 1. Xóa các label chữ tạm thời nếu có
            for (int i = pnlContent.Controls.Count - 1; i >= 0; i--)
            {
                if (pnlContent.Controls[i] is Label)
                {
                    pnlContent.Controls.RemoveAt(i);
                }
            }

            // 2. Nếu UserControl chưa có trong panel thì thêm vào
            if (!pnlContent.Controls.Contains(uc))
            {
                uc.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(uc);
            }

            // 3. Đưa UserControl lên lớp trên cùng và hiển thị
            uc.Visible = true;
            uc.BringToFront();
        }

        private void ShowContentText(string desc)
        {
            pnlContent.Controls.Clear(); // Xóa sạch để hiển thị chữ thông báo
            Label lbl = new Label
            {
                Text = desc,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                ForeColor = Color.FromArgb(71, 85, 105),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlContent.Controls.Add(lbl);
        }
        #endregion
        private void HighlightButton(Button btn, string title)
        {
            if (activeBtn != null)
            {
                activeBtn.BackColor = Color.FromArgb(15, 23, 42);
                activeBtn.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            }
            activeBtn = btn;
            activeBtn.BackColor = Color.FromArgb(30, 41, 59);
            activeBtn.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTitle.Text = title;
        }
        #region Đăng xuất
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất quyền Quản Trị Viên không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    test formNewLogin = new test();
                    formNewLogin.Show();
                }
                this.Dispose();
            }
        }
        #endregion
    }
}