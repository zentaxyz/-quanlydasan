using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace quanlydatsan
{
    public partial class FormThanhToan : Form
    {
        private readonly DatabaseC db = new DatabaseC();
        private string maPhieu;
        private decimal tongTien;

        public FormThanhToan(string maPhieu, decimal tongTien)
        {
            InitializeComponent();
            this.maPhieu = maPhieu;
            this.tongTien = tongTien;
            HienThiThongTinThanhToan();
        }

        private void HienThiThongTinThanhToan()
        {
            string tenChuSan = "Chủ Sân";
            string soDienThoai = "Chưa cập nhật";
            string qrPath = Path.Combine(Application.StartupPath, "Resources", "qrCK.png");
            
            try
            {
                string query = "SELECT TOP 1 TenChuSan, SoDienThoai FROM ChuSan";
                DataSet ds = db.GetData(query);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    tenChuSan = row["TenChuSan"]?.ToString() ?? "Chủ Sân";
                    soDienThoai = row["SoDienThoai"]?.ToString() ?? "Chưa cập nhật";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy thông tin chủ sân: " + ex.Message);
            }

            lblInfo.Text = $"Mã phiếu đặt: {maPhieu}";
            lblTongtien.Text = $"{tongTien:N0} VNĐ";

            lblHuongDan.Text =
                "📌 HƯỚNG DẪN THANH TOÁN:\n" +
                "1. Mở app ngân hàng, quét mã QR chuyển khoản đúng số tiền: " + $"{tongTien:N0} VNĐ\n" +
                $"2. Nhội dung chuyển khoản ghi rõ: {maPhieu}\n" +
                "3. Chụp màn hình biên lai và gửi qua Zalo số điện thoại chủ sân:\n\n" +
                $"📱 SĐT / Zalo chủ sân: {soDienThoai} ({tenChuSan})\n\n" +
                "⚠️ Lưu ý: Đơn đặt sân sẽ tự động hủy nếu chưa thanh toán trong 30 phút.";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}