using quanlydatsan.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlydatsan
{
    public partial class TrangChu : UserControl
    {
        Database db = new Database();
        public TrangChu()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
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
                if (dtSan != null && dtSan.Rows.Count > 0)
                {
                    lblTongsosan.Text = dtSan.Rows[0][0].ToString() + " Sân";
                }

                string sqlPhieucho = @"
             SELECT COUNT(*) 
             FROM PhieuDatSan 
             WHERE (XacNhanThanhToan = 0 OR XacNhanThanhToan IS NULL) 
             AND CONVERT(date, NgaySuDung) = CONVERT(date, GETDATE())";

                DataTable dtPhieu = db.ReadData(sqlPhieucho);
                if (dtPhieu != null && dtPhieu.Rows.Count > 0)
                {
                    lblPhieuchoduyet.Text = dtPhieu.Rows[0][0].ToString() + " Phiếu";
                }

               
                string sqlDoanhthu = @"
             SELECT ISNULL(SUM(TongTien), 0)
             FROM PhieuDatSan
             WHERE CONVERT(date, NgaySuDung) = CONVERT(date, GETDATE())";
                DataTable dtDoanhthu = db.ReadData(sqlDoanhthu);
                if (dtDoanhthu != null && dtDoanhthu.Rows.Count > 0)
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
                      p.MaPhieu AS [Mã phiếu],
                      s.TenSan AS [Tên sân],
                      CONVERT(varchar(5), p.ThoiGianBatDau, 108) + ' - ' + CONVERT(varchar(5), p.ThoiGianKetThuc, 108) AS [Khung giờ],
                      k.TenKhach AS [Khách hàng],
                      k.SoDienThoai AS [SĐT],
                      FORMAT(p.TongTien, 'N0') + ' VNĐ' AS [Số tiền],
                      CASE WHEN p.XacNhanThanhToan = 1 THEN N'Đã thanh toán' ELSE N'Chưa thanh toán' END AS [Trạng thái]
                  FROM PhieuDatSan p
                  INNER JOIN San s ON p.MaSan = s.MaSan
                  INNER JOIN KhachHang k ON p.MaKhach = k.MaKhach
                  WHERE CONVERT(date, p.NgaySuDung) = CONVERT(date, GETDATE())
                  ORDER BY p.ThoiGianBatDau ASC";

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
