using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlydatsan
{
    public partial class DashbroadAdmin : Form
    {
        private Button activeBtn;

        public DashbroadAdmin()
        {
            InitializeComponent();
        }

        private void DashbroadAdmin_Load(object sender, EventArgs e)
        {
            // Hiển thị tên Admin từ Session
            lblAdminName.Text = string.IsNullOrEmpty(Session.FullName) ? "Admin" : Session.FullName;
            lblTime.Text = "Hôm nay: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // Chọn trang tổng quan mặc định
            HighlightButton(btnDashboard, "TỔNG QUAN HỆ THỐNG");
            ShowOverviewStats();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            if (btn == btnDashboard)
            {
                HighlightButton(btn, "TỔNG QUAN HỆ THỐNG");
                ShowOverviewStats();
            }
            else if (btn == btnFieldMgr)
            {
                HighlightButton(btn, "QUẢN LÝ DANH SÁCH SÂN THỂ THAO");
                ShowContentText("Chức năng thêm, sửa, xóa Sân và cập nhật Giá sân theo giờ.");
            }
            else if (btn == btnOrderMgr)
            {
                HighlightButton(btn, "DUYỆT & QUẢN LÝ PHIẾU ĐẶT SÂN");
                ShowContentText("Danh sách các yêu cầu đặt sân đang chờ duyệt và xác nhận thanh toán.");
            }
            else if (btn == btnCustomerMgr)
            {
                HighlightButton(btn, "QUẢN LÝ KHÁCH HÀNG");
                ShowContentText("Danh sách hồ sơ khách hàng, số điện thoại và lịch sử đặt sân.");
            }
            else if (btn == btnRevenue)
            {
                HighlightButton(btn, "BÁO CÁO THỐNG KÊ DOANH THU");
                ShowContentText("Thống kê tổng tiền thu theo ngày, tuần, tháng từ bảng LichSuThanhToan.");
            }
        }

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

        private void ShowOverviewStats()
        {
            pnlContent.Controls.Clear();
            Label lblWelcome = new Label
            {
                Text = $"Xin chào Quản Trị Viên: {Session.FullName}!\nChào mừng bạn đến với bảng điều khiển quản lý sân thể thao Sport Arena.",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                ForeColor = Color.FromArgb(51, 65, 85),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlContent.Controls.Add(lblWelcome);
        }

        private void ShowContentText(string desc)
        {
            pnlContent.Controls.Clear();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất quyền Quản Trị Viên không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Session.UserId = null;
                Session.FullName = null;
                Session.Role = null;

                test formLogin = new test();
                formLogin.Show();
                this.Dispose();
            }
        }
    }
}