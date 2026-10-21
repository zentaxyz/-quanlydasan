using System;
using System.Drawing;
using System.Windows.Forms;
using quanlydatsan.ADD_UC_ADMIN; // Chứa các UserControl Admin

namespace quanlydatsan
{
    public partial class DashbroadAdmin : Form
    {
        private Button activeBtn;

        // Khai báo sẵn các UserControl Admin (chỉ new khi cần chuyển trang)
        private TrangChu ucTrangChu;
        private UCQuanLySan ucQuanLySan;
        private UCPhieuDatSan ucPhieuDatSan;
        private UC_QLTK ucQLTK;
        private UCNgayLe ucNgayLe;
        private QLLS ucLoaiSan;
        private UCQuanLyLichDat ucQuanLyLichDat;
        private UC_ThongTinChuSan ucThongTinChuSan;
        public DashbroadAdmin()
        {
            InitializeComponent();
        }

        private void DashbroadAdmin_Load(object sender, EventArgs e)
        {
            lblAdminName.Text = string.IsNullOrEmpty(Session.FullName) ? "Admin" : Session.FullName;
            lblTime.Text = "Hôm nay: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // Mở mặc định trang Tổng Quan Hệ Thống
            btnDashboard.PerformClick();
        }

        #region Xử lý chuyển trang Dashboard
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // 1. Tổng Quan Hệ Thống
            if (btn == btnDashboard)
            {
                HighlightButton(btn, "TỔNG QUAN HỆ THỐNG");
                if (ucTrangChu == null)
                {
                    ucTrangChu = new TrangChu();
                }
                HienThiUserControl(ucTrangChu);
            }
            // 2. Quản Lý Danh Sách Sân
            else if (btn == btnDSS)
            {
                HighlightButton(btn, "QUẢN LÝ DANH SÁCH SÂN THỂ THAO");
                if (ucQuanLySan == null)
                {
                    ucQuanLySan = new UCQuanLySan();
                }
                HienThiUserControl(ucQuanLySan);
            }
            // 3. Quản Lý Phiếu Đặt Sân
            else if (btn == btnPĐS || btn == btnPĐS)
            {
                HighlightButton(btn, "QUẢN LÝ PHIẾU ĐẶT SÂN");
                if (ucPhieuDatSan == null)
                {
                    ucPhieuDatSan = new UCPhieuDatSan();
                }
                HienThiUserControl(ucPhieuDatSan);
            }
            // 4. Quản Lý Khách Hàng (Tài khoản)
            else if (btn == btnQLKH)
            {
                HighlightButton(btn, "QUẢN LÝ KHÁCH HÀNG & TÀI KHOẢN");
                if (ucQLTK == null)
                {
                    ucQLTK = new UC_QLTK();
                }
                HienThiUserControl(ucQLTK);
            }
            // 5. Quản Lý Ngày Lễ
            else if (btn == btnNLe)
            {
                HighlightButton(btn, "QUẢN LÝ NGÀY LỄ & CHÍNH SÁCH GIÁ");
                if (ucNgayLe == null)
                {
                    ucNgayLe = new UCNgayLe();
                }
                HienThiUserControl(ucNgayLe);
            }
            // 6. Quản Lý Loại Sân (QLLS)
            else if (btn == btnQLLS)
            {
                HighlightButton(btn, "QUẢN LÝ LOẠI SÂN THỂ THAO");
                if (ucLoaiSan == null)
                {
                    ucLoaiSan = new QLLS();
                }
                HienThiUserControl(ucLoaiSan);
            }
            // 7. Quản Lý Lịch Đặt
            else if (btn == btnQLLĐ)
            {
                HighlightButton(btn, "QUẢN LÝ LỊCH ĐẶT SÂN");
                if (ucQuanLyLichDat == null)
                {
                    ucQuanLyLichDat = new UCQuanLyLichDat();
                }
                HienThiUserControl(ucQuanLyLichDat);
            }
            // 8. Báo Cáo Doanh Thu
            else if (btn == btnBC)
            {
                HighlightButton(btn, "BÁO CÁO THỐNG KÊ DOANH THU");
                ShowContentText("Thống kê doanh thu theo ngày, tuần, tháng từ bảng LichSuThanhToan.");
            }
            // 9. Quản Lý Tài Khoản
            else if (btn == btnTK)
            {
                HighlightButton(btn, "QUẢN LÝ TÀI KHOẢN");
                if (ucThongTinChuSan == null)
                {
                    ucThongTinChuSan = new UC_ThongTinChuSan();
                }
                HienThiUserControl(ucThongTinChuSan);
            }
        }

        // Đưa UC vào pnlContent, co giãn full và đưa lên trước
        private void HienThiUserControl(UserControl uc)
        {
            // Xóa bỏ các Label thông báo tạm nếu có
            for (int i = pnlContent.Controls.Count - 1; i >= 0; i--)
            {
                if (pnlContent.Controls[i] is Label)
                {
                    pnlContent.Controls.RemoveAt(i);
                }
            }

            if (!pnlContent.Controls.Contains(uc))
            {
                uc.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(uc);
            }

            uc.Visible = true;
            uc.BringToFront();
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
        #endregion

        #region Đăng xuất
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Bạn có muốn đăng xuất quyền Quản Trị Viên không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

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