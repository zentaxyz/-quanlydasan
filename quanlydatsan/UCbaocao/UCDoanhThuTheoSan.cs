
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyDatSan
{
    public partial class UCDoanhThuTheoSan : UserControl
    {
        // 1. Chuỗi kết nối SQL Server
        private readonly string connectionString =
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=quanlydatsan;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public UCDoanhThuTheoSan()
        {
            InitializeComponent();

            // 2. Cấu hình ngày
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Format = DateTimePickerFormat.Short;

            dtpTuNgay.Value = new DateTime(
                DateTime.Today.Year,
                DateTime.Today.Month,
                1);

            dtpDenNgay.Value = DateTime.Today;

            // 3. Cấu hình ComboBox
            cboLoaiThongKe.Items.Clear();
            cboLoaiThongKe.Items.Add("-- CHỌN --");
            cboLoaiThongKe.Items.Add("Doanh Thu Theo Sân");
            cboLoaiThongKe.Items.Add("Doanh Thu Theo Thời Gian");
            cboLoaiThongKe.Items.Add("Phân Bố Sân Đặt");
            cboLoaiThongKe.SelectedIndex = 1;

            // Chỉ đăng ký sự kiện nút Xem một lần
            btnXem.Click -= btnXem_Click;
            btnXem.Click += btnXem_Click;

            // Hiển thị biểu đồ doanh thu theo sân khi mở Form
            ThongKeDoanhThuTheoSan();
        }

        // =====================================================
        // 4. HÀM KẾT NỐI VÀ LẤY DỮ LIỆU SQL
        // =====================================================
        private DataTable LayDuLieu(string sql)
        {
            DataTable bangDuLieu = new DataTable();

            using (SqlConnection conn =
                new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add(
                    "@TuNgay", SqlDbType.Date
                ).Value = dtpTuNgay.Value.Date;

                cmd.Parameters.Add(
                    "@DenNgay", SqlDbType.Date
                ).Value = dtpDenNgay.Value.Date;

                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(cmd))
                {
                    adapter.Fill(bangDuLieu);
                }
            }

            return bangDuLieu;
        }

        // Điều kiện dùng chung cho cả ba loại thống kê
        private string DieuKienNgay()
        {
            return @"
                WHERE XacNhanThanhToan = 1
                  AND NgayDat >= @TuNgay
                  AND NgayDat < DATEADD(DAY, 1, @DenNgay)
            ";
        }

        // =====================================================
        // 5. LẤY DOANH THU THEO SÂN
        // =====================================================
        private DataTable LayDoanhThuTheoSan()
        {
            string sql = @"
                SELECT
                    MaSan,
                    SUM(TongTien) AS DoanhThu
                FROM dbo.PhieuDatSan
            " + DieuKienNgay() + @"
                GROUP BY MaSan
                ORDER BY SUM(TongTien) DESC;";

            return LayDuLieu(sql);
        }

        // =====================================================
        // 6. LẤY DOANH THU THEO NGÀY
        // =====================================================
        private DataTable LayDoanhThuTheoThoiGian()
        {
            string sql = @"
                SELECT
                    NgayDat,
                    SUM(TongTien) AS DoanhThu
                FROM dbo.PhieuDatSan
            " + DieuKienNgay() + @"
                GROUP BY NgayDat
                ORDER BY NgayDat ASC;";

            return LayDuLieu(sql);
        }

        // =====================================================
        // 7. LẤY SỐ PHIẾU ĐẶT THEO SÂN
        // =====================================================
        private DataTable LayPhanBoSanDat()
        {
            string sql = @"
                SELECT
                    MaSan,
                    COUNT(*) AS SoPhieu
                FROM dbo.PhieuDatSan
            " + DieuKienNgay() + @"
                GROUP BY MaSan
                ORDER BY COUNT(*) DESC;";

            return LayDuLieu(sql);
        }

        // =====================================================
        // 8. CẤU HÌNH LẠI BIỂU ĐỒ
        // =====================================================
        private void CaiDatBieuDo(string tieuDe)
        {
            chartDoanhThu.Series.Clear();
            chartDoanhThu.ChartAreas.Clear();
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Legends.Clear();

            ChartArea khuVuc = new ChartArea("KhuVuc");

            khuVuc.BackColor = Color.White;
            khuVuc.AxisX.MajorGrid.LineColor = Color.LightGray;
            khuVuc.AxisY.MajorGrid.LineColor = Color.LightGray;

            chartDoanhThu.ChartAreas.Add(khuVuc);

            Title title = new Title(tieuDe);
            title.Font = new Font(
                "Segoe UI", 12, FontStyle.Regular);

            chartDoanhThu.Titles.Add(title);
        }

        // =====================================================
        // 9. BIỂU ĐỒ 1: DOANH THU THEO SÂN - CỘT NGANG
        // =====================================================
        private void ThongKeDoanhThuTheoSan()
        {
            try
            {
                DataTable bangDuLieu = LayDoanhThuTheoSan();

                CaiDatBieuDo("Doanh Thu Theo Sân (VNĐ)");

                ChartArea khuVuc = chartDoanhThu.ChartAreas[0];

                // Biểu đồ cột ngang:
                // Trục X là doanh thu, trục Y là mã sân.
                khuVuc.AxisX.Title = "Doanh thu (VNĐ)";
                khuVuc.AxisY.Title = "Mã sân";

                khuVuc.AxisX.Minimum = 0;
                khuVuc.AxisX.LabelStyle.Format = "#,##0";
                khuVuc.AxisX.MajorGrid.Enabled = true;

                khuVuc.AxisY.Interval = 1;
                khuVuc.AxisY.MajorGrid.Enabled = false;

                Series duLieu = new Series("Doanh Thu");
                duLieu.ChartType = SeriesChartType.Bar;
                duLieu.Color = Color.FromArgb(76, 175, 80);
                duLieu.IsValueShownAsLabel = true;
                duLieu.LabelFormat = "#,##0";
                duLieu["PointWidth"] = "0.6";
                duLieu.IsXValueIndexed = true;

                foreach (DataRow dong in bangDuLieu.Rows)
                {
                    string maSan = Convert.ToString(dong["MaSan"])
                        ?? "";

                    decimal doanhThu =
                        Convert.ToDecimal(dong["DoanhThu"]);

                    int diem = duLieu.Points.AddXY(
                        maSan, doanhThu);

                    duLieu.Points[diem].AxisLabel = maSan;
                    duLieu.Points[diem].Label =
                        doanhThu.ToString("#,##0");

                    duLieu.Points[diem].ToolTip =
                        maSan + ": " +
                        doanhThu.ToString("#,##0") + " VNĐ";
                }

                chartDoanhThu.Series.Add(duLieu);

                if (bangDuLieu.Rows.Count == 0)
                {
                    chartDoanhThu.Titles[0].Text =
                        "Không có doanh thu đã thanh toán trong khoảng ngày đã chọn";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thống kê doanh thu theo sân:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // 10. BIỂU ĐỒ 2: DOANH THU THEO THỜI GIAN - ĐƯỜNG
        // =====================================================
        private void ThongKeDoanhThuTheoThoiGian()
        {
            try
            {
                DataTable bangDuLieu =
                    LayDoanhThuTheoThoiGian();

                CaiDatBieuDo("Doanh Thu Theo Ngày (VNĐ)");

                ChartArea khuVuc = chartDoanhThu.ChartAreas[0];

                khuVuc.AxisX.Title = "Ngày đặt";
                khuVuc.AxisY.Title = "Doanh thu (VNĐ)";
                khuVuc.AxisY.LabelStyle.Format = "#,##0";
                khuVuc.AxisY.Minimum = 0;

                khuVuc.AxisX.LabelStyle.Format = "dd/MM/yyyy";
                khuVuc.AxisX.IntervalAutoMode =
                    IntervalAutoMode.VariableCount;

                khuVuc.AxisX.LabelStyle.Angle = -45;

                Series duLieu = new Series("Doanh Thu");
                duLieu.ChartType = SeriesChartType.Line;
                duLieu.Color = Color.SkyBlue;
                duLieu.BorderWidth = 3;
                duLieu.MarkerStyle = MarkerStyle.Circle;
                duLieu.MarkerSize = 8;
                duLieu.IsValueShownAsLabel = true;
                duLieu.LabelFormat = "#,##0";
                duLieu.XValueType = ChartValueType.DateTime;

                foreach (DataRow dong in bangDuLieu.Rows)
                {
                    DateTime ngay =
                        Convert.ToDateTime(dong["NgayDat"]);

                    decimal doanhThu =
                        Convert.ToDecimal(dong["DoanhThu"]);

                    int diem = duLieu.Points.AddXY(
                        ngay.ToOADate(), doanhThu);

                    duLieu.Points[diem].ToolTip =
                        ngay.ToString("dd/MM/yyyy") + ": " +
                        doanhThu.ToString("#,##0") + " VNĐ";
                }

                chartDoanhThu.Series.Add(duLieu);

                if (bangDuLieu.Rows.Count == 0)
                {
                    chartDoanhThu.Titles[0].Text =
                        "Không có doanh thu trong khoảng ngày đã chọn";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thống kê doanh thu theo thời gian:\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // 11. BIỂU ĐỒ 3: PHÂN BỐ SÂN ĐẶT - HÌNH TRÒN
        // =====================================================
        private void ThongKePhanBoSanDat()
        {
            try
            {
                DataTable bangDuLieu = LayPhanBoSanDat();

                CaiDatBieuDo("Phân Bố Sân Đặt");

                ChartArea khuVuc = chartDoanhThu.ChartAreas[0];

                // Biểu đồ tròn không cần các trục tọa độ.
                khuVuc.AxisX.Enabled = AxisEnabled.False;
                khuVuc.AxisY.Enabled = AxisEnabled.False;

                Series duLieu = new Series("Phân Bố Sân");
                duLieu.ChartType = SeriesChartType.Pie;
                duLieu.IsValueShownAsLabel = true;
                duLieu.Label = "#VALY (#PERCENT{P1})";
                duLieu.LegendText = "#VALX";
                duLieu.ToolTip =
                    "#VALX: #VALY phiếu (#PERCENT{P1})";

                foreach (DataRow dong in bangDuLieu.Rows)
                {
                    string maSan = Convert.ToString(dong["MaSan"])
                        ?? "";

                    int soPhieu =
                        Convert.ToInt32(dong["SoPhieu"]);

                    int diem = duLieu.Points.AddXY(
                        maSan, soPhieu);

                    duLieu.Points[diem].LegendText = maSan;
                }

                chartDoanhThu.Series.Add(duLieu);

                Legend chuGiai = new Legend("ChuGiai");
                chuGiai.Docking = Docking.Right;
                chuGiai.Alignment = StringAlignment.Center;

                chartDoanhThu.Legends.Add(chuGiai);

                if (bangDuLieu.Rows.Count == 0)
                {
                    chartDoanhThu.Titles[0].Text =
                        "Không có phiếu đặt sân đã thanh toán";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thống kê phân bố sân đặt:\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // 12. SỰ KIỆN NÚT XEM
        // =====================================================
        private void btnXem_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show(
                    "Ngày bắt đầu không được lớn hơn ngày kết thúc!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            switch (cboLoaiThongKe.SelectedIndex)
            {
                case 1:
                    ThongKeDoanhThuTheoSan();
                    break;

                case 2:
                    ThongKeDoanhThuTheoThoiGian();
                    break;

                case 3:
                    ThongKePhanBoSanDat();
                    break;

                default:
                    MessageBox.Show(
                        "Vui lòng chọn loại thống kê!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}