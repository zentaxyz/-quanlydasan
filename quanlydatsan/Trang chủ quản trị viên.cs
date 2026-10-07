using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlydatsan
{
    public partial class TrangchuQTV : Form
    {
        Database db = new Database();
        public TrangchuQTV()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TrangchuQTV_Load(object sender, EventArgs e)
        {
            LoadThongkeCards();
            LoadLichdathomnay();
        }

        private void LoadThongkeCards()
        {
            try
            {
                string sqlTongsan = "SELECT COUNT(*) FROM San";
                DataTable dtSan = db.ReadData(sqlTongsan);
                if(dtSan != null && dtSan.Rows.Count > 0)
                {
                    lblTongsosan.Text = dtSan.Rows[0][0].ToString() + " Sân";

                }


                string sqlPhieucho = "SELECT COUNT(*) FROM Phieudatsan WHERE Trangthaiduyet = N'Chờ duyệt'";
                DataTable dtPhieu = db.ReadData(sqlPhieucho);
                if(dtPhieu != null && dtPhieu.Rows.Count > 0)
                {
                    lblPhieuchoduyet.Text = dtPhieu.Rows[0][0].ToString() + " Phiếu";
                }

                string sqlDoanhthu = @"
                     SELECT ISNULL(SUM(Sotienthanhtoan), 0)
                     FROM Thanhtoan
                     WHERE CONVERT (date, Ngaythanhtoan) = CONVERT(date, GETDATE())";
                DataTable dtDoanhthu = db.ReadData(sqlDoanhthu);
                if(dtDoanhthu != null && dtDoanhthu.Rows.Count > 0)
                {
                    decimal doanhthu = Convert.ToDecimal(dtDoanhthu.Rows[0][0]);
                    lblDoanhthungay.Text = string.Format("{0:N0} VNĐ", doanhthu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadLichdathomnay()
        {
            try
            {
                string sqlLichhomnay = @"
                          SELECT
                          p.Maphieudat AS [Mã phiếu],
                          s.Tensan AS [Tên sân],
                          CONVERT(varchar(5), kg.Giobatdau, 108) + ' - ' + CONVERT(varchar(5), kg.Gioketthuc, 108) AS [Khung giờ],
                          u.Hoten AS [Khách hàng],
                          u.Sodienthoai AS [SĐT],
                          p.Trangthaiduyet AS [Trạng thái]
                          FROM Phieudatsan p
                          INNER JOIN San s ON p.Masan = s.Masan
                          INNER JOIN Khunggio kg ON p.Makhunggio = kg.Makhunggio
                          INNER JOIN Thongtinnguoidung u ON p.Mataikhoan = u.Mataikhoan
                          WHERE CONVERT(date, p.Ngaydat) = CONVERT(date, GETDATE())
                          ORDER BY kg.Giobatdau ASC";

                DataTable dtLich = db.ReadData(sqlLichhomnay);
                dgvLichhomnay.DataSource = dtLich;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch đặt hôm nay: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
