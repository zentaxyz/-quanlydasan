using QuanLyDatSan;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quanlydatsan
{
    public partial class UC_BaoCaoDoanhThu : UserControl
    {
        private Button currentTabButton;

        // Lưu trữ sẵn 3 UserControl để không bị khởi tạo lại nhiều lần
        private UCDoanhThuTheoThoiGian ucThoiGian;
        private UCDoanhThuTheoSan ucSan;
        private UCTopKhachHang ucTopKH;

        public UC_BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void UC_BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            // Mặc định nạp báo cáo theo Thời Gian đầu tiên
            btnTheoThoiGian.PerformClick();
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            DatMauNutActive(btn);

            if (btn == btnTheoThoiGian)
            {
                if (ucThoiGian == null)
                {
                    ucThoiGian = new UCDoanhThuTheoThoiGian();
                    ThemControlVaoPanel(ucThoiGian);
                }
                else
                {
                    ucThoiGian.BringToFront();
                }
            }
            else if (btn == btnTheoSan)
            {
                if (ucSan == null)
                {
                    ucSan = new UCDoanhThuTheoSan();
                    ThemControlVaoPanel(ucSan);
                }
                else
                {
                    ucSan.BringToFront();
                }
            }
            else if (btn == btnTopKhachHang)
            {
                if (ucTopKH == null)
                {
                    ucTopKH = new UCTopKhachHang();
                    ThemControlVaoPanel(ucTopKH);
                }
                else
                {
                    ucTopKH.BringToFront();
                }
            }
        }

        private void ThemControlVaoPanel(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlBaoCaoContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void DatMauNutActive(Button btn)
        {
            if (currentTabButton != null)
            {
                currentTabButton.BackColor = Color.FromArgb(241, 245, 249);
                currentTabButton.ForeColor = Color.FromArgb(71, 85, 105);
            }

            currentTabButton = btn;
            currentTabButton.BackColor = Color.FromArgb(46, 125, 50); // Xanh lá phong cách admin
            currentTabButton.ForeColor = Color.White;
        }
    }
}