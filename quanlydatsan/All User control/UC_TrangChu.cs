using quanlydatsan.Class;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace quanlydatsan.All_User_control
{
    public partial class UC_TrangChu : UserControl
    {
        private readonly DatabaseC db = new DatabaseC();

        public UC_TrangChu()
        {
            InitializeComponent();
        }

        private void UC_TrangChu_Load(object sender, EventArgs e)
        {
            LoadThongTinChaoMung();
            LoadThongKeTongQuan();
        }

        public void LoadThongTinChaoMung()
        {
            string tenKhach = !string.IsNullOrEmpty(Session.FullName) ? Session.FullName : "Khách Hàng";
            lblBannerTitle.Text = $"Chào mừng trở lại, {tenKhach}!";
        }

        public void LoadThongKeTongQuan()
        {
            if (string.IsNullOrEmpty(Session.UserId)) return;

            try
            {
                // 1. Đếm tổng số sân trong hệ thống
                string querySan = "SELECT COUNT(*) FROM San";
                DataSet dsSan = db.GetData(querySan);
                if (dsSan != null && dsSan.Tables.Count > 0 && dsSan.Tables[0].Rows.Count > 0)
                {
                    int tongSan = Convert.ToInt32(dsSan.Tables[0].Rows[0][0]);
                    lblCard1Val.Text = $"{tongSan} Sân";
                }

                // 2. Đếm tổng số đơn đặt sân của riêng khách hàng hiện tại
                string safeUserId = Session.UserId.Replace("'", "''");
                string queryDon = $"SELECT COUNT(*) FROM PhieuDatSan WHERE MaKhach = '{safeUserId}'";
                DataSet dsDon = db.GetData(queryDon);
                if (dsDon != null && dsDon.Tables.Count > 0 && dsDon.Tables[0].Rows.Count > 0)
                {
                    int tongDon = Convert.ToInt32(dsDon.Tables[0].Rows[0][0]);
                    lblCard2Val.Text = $"{tongDon} Đơn";
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngầm nếu lỗi kết nối database để không làm crash form
                Console.WriteLine("Lỗi tải thống kê trang chủ: " + ex.Message);
            }
        }
    }
}