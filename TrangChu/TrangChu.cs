
using System;
using System.Windows.Forms;
using QuanLyDatSan;

namespace TrangChu
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();

            // Ẩn menu báo cáo con khi mở trang chủ
            pnlMenuBaoCao.Visible = false;
        }

        // Nhấn nút Báo cáo để hiện hoặc ẩn 3 mục con
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            pnlMenuBaoCao.Visible = !pnlMenuBaoCao.Visible;
        }

        // Xóa nội dung đang hiển thị trong Panel
        private void XoaNoiDungCu()
        {
            while (pnlNoiDung.Controls.Count > 0)
            {
                Control control = pnlNoiDung.Controls[0];

                pnlNoiDung.Controls.Remove(control);

                if (control is Form formCu)
                {
                    formCu.Close();
                    formCu.Dispose();
                }
                else
                {
                    control.Dispose();
                }
            }
        }

        // Mở một Form bên trong Panel nội dung
        private void MoFormVaoPanel(Form form)
        {
            XoaNoiDungCu();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(form);

            form.Show();
            form.BringToFront();
        }

        // Mục 1: Doanh thu theo ngày / tháng / quý
        private void btnDTThoiGian_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();

            UCDoanhThuTheoThoiGian uc = new UCDoanhThuTheoThoiGian ();
            uc.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(uc);
        }

        // Mục 2: Doanh thu sân
        private void btnDTSan_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();

            UCDoanhThuTheoSan uc = new UCDoanhThuTheoSan();
            uc.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(uc);
        }

        // Mục 3: Top khách hàng
        private void btnTopKhachHang_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();

            UCTopKhachHang uc = new UCTopKhachHang ();
            uc.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(uc);
        }

        // Hiển thị nội dung thông báo trong vùng bên phải
        private void HienThiThongBao(string noiDung)
        {
            XoaNoiDungCu();

            Label lblThongBao = new Label();

            lblThongBao.Text = noiDung;
            lblThongBao.Dock = DockStyle.Fill;
            lblThongBao.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;
            lblThongBao.Font =
                new System.Drawing.Font("Arial", 14);

            pnlNoiDung.Controls.Add(lblThongBao);
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void pnlNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
