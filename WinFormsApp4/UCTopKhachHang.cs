
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyDatSan
{
    public partial class UCTopKhachHang : UserControl
    {
        private readonly string connectionString =
            @"Server=localhost\SQLEXPRESS;Database=database;Integrated Security=True;TrustServerCertificate=True;";

        public UCTopKhachHang()
        {
            InitializeComponent();

            this.Text = "Thống Kê Top Khách Hàng Thuê Nhiều";

            // Tránh đăng ký sự kiện Click nhiều lần
            btnXem.Click -= btnXem_Click;
            btnXem.Click += btnXem_Click;

            KhoiTaoBieuDo();
        }

        // Khởi tạo biểu đồ ban đầu
        private void KhoiTaoBieuDo()
        {
            // Biểu đồ thanh ngang
            chartThanh.Series.Clear();
            chartThanh.ChartAreas.Clear();
            chartThanh.Legends.Clear();
            chartThanh.Titles.Clear();

            ChartArea areaThanh = new ChartArea("AreaThanh");

            areaThanh.AxisX.Title = "Số lượt đặt sân";
            areaThanh.AxisX.Minimum = 0;
            areaThanh.AxisX.MajorGrid.LineColor = Color.LightGray;

            areaThanh.AxisY.MajorGrid.Enabled = false;
            areaThanh.AxisY.Interval = 1;

            chartThanh.ChartAreas.Add(areaThanh);

            Series seriesThanh = new Series("SoLuotDat");
            seriesThanh.ChartType = SeriesChartType.Bar;
            seriesThanh.IsValueShownAsLabel = true;
            seriesThanh.LabelFormat = "N0";
            seriesThanh.YValueType = ChartValueType.Int32;
            seriesThanh["PointWidth"] = "0.6";

            // Quan trọng: mỗi điểm dữ liệu dùng nhãn riêng trên trục Y
            seriesThanh.IsXValueIndexed = true;

            chartThanh.Series.Add(seriesThanh);
            chartThanh.Titles.Add("Số lượng đặt sân theo khách hàng");

            // Biểu đồ tròn
            chartTron.Series.Clear();
            chartTron.ChartAreas.Clear();
            chartTron.Legends.Clear();
            chartTron.Titles.Clear();

            ChartArea areaTron = new ChartArea("AreaTron");
            chartTron.ChartAreas.Add(areaTron);

            Legend legend = new Legend("ChuGiai");
            legend.Docking = Docking.Right;
            legend.Alignment = StringAlignment.Center;
            chartTron.Legends.Add(legend);

            Series seriesTron = new Series("TyLe");
            seriesTron.ChartType = SeriesChartType.Pie;
            seriesTron.IsValueShownAsLabel = true;
            seriesTron.Label = "#VALY (#PERCENT{P1})";
            seriesTron.Legend = "ChuGiai";
            seriesTron["PieLabelStyle"] = "Outside";
            seriesTron["PieLineColor"] = "Black";

            chartTron.Series.Add(seriesTron);

            chartTron.Titles.Add(
                "Tỷ lệ lượt đặt sân theo khách hàng");
        }

        // Nút Xem
        private void btnXem_Click(object sender, EventArgs e)
        {
            string sql = @"
                SELECT TOP 10
                    k.MaKhach,
                    k.TenKhach,
                    COUNT(p.MaPhieu) AS SoLuotDat
                FROM dbo.KhachHang k
                INNER JOIN dbo.PhieuDatSan p
                    ON k.MaKhach = p.MaKhach
                GROUP BY k.MaKhach, k.TenKhach
                ORDER BY COUNT(p.MaPhieu) DESC,
                         k.TenKhach ASC;";

            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }

                HienThiBieuDo(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải Top khách hàng:\n" + ex.Message,
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Hiển thị dữ liệu lên hai biểu đồ
        private void HienThiBieuDo(DataTable dt)
        {
            KhoiTaoBieuDo();

            if (dt.Rows.Count == 0)
            {
                chartThanh.Titles.Clear();
                chartTron.Titles.Clear();

                chartThanh.Titles.Add("Chưa có dữ liệu");
                chartTron.Titles.Add("Chưa có dữ liệu");

                MessageBox.Show("Chưa có dữ liệu đặt sân.");
                return;
            }

            int tongLuotDat = 0;

            foreach (DataRow row in dt.Rows)
            {
                string tenKhach =
                    Convert.ToString(row["TenKhach"]);

                int soLuot =
                    Convert.ToInt32(row["SoLuotDat"]);

                // Mỗi khách hàng là một thanh riêng
                Series thanh = chartThanh.Series["SoLuotDat"];

                int viTri = thanh.Points.Count;

                DataPoint diemThanh = new DataPoint();
                diemThanh.SetValueY(soLuot);
                diemThanh.AxisLabel = tenKhach;
                diemThanh.Label = soLuot.ToString("N0");
                diemThanh.ToolTip =
                    tenKhach + ": " + soLuot + " lượt đặt";

                thanh.Points.Add(diemThanh);
                // Mỗi khách hàng là một phần của biểu đồ tròn
                DataPoint diemTron = new DataPoint();
                diemTron.SetValueY(soLuot);
                diemTron.AxisLabel = tenKhach;
                diemTron.LegendText = tenKhach;
                diemTron.ToolTip =
                    tenKhach + ": " + soLuot + " lượt đặt";

                chartTron.Series["TyLe"]
                    .Points.Add(diemTron);

                tongLuotDat += soLuot;
            }

            // Tổng kết nếu đã tạo lblTongKet trong Designer
            Control[] ketQua = Controls.Find(
                "lblTongKet", true);

            if (ketQua.Length > 0 && ketQua[0] is Label lbl)
            {
                lbl.Text =
                    "Số khách hàng: " + dt.Rows.Count +
                    " | Tổng lượt đặt của Top 10: " +
                    tongLuotDat.ToString("N0");
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            // Không cần xử lý khi nhấn vào biểu đồ.
        }
    }
}
