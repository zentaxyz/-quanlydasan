
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyDatSan
{
    public partial class UCDoanhThuTheoThoiGian : UserControl
    {
        private readonly string connectionString =
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=quanlydatsan;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        private bool dangKhoiTao = true;

        public UCDoanhThuTheoThoiGian()
        {
            InitializeComponent();

            // Các loại thống kê
            cboLoaiThongKe.Items.Clear();
            cboLoaiThongKe.Items.Add("Theo ngày");
            cboLoaiThongKe.Items.Add("Theo tuần");
            cboLoaiThongKe.Items.Add("Theo tháng");
            cboLoaiThongKe.Items.Add("Theo quý");
            cboLoaiThongKe.SelectedIndex = 0;

            cboTuanQuy.Visible = false;

            dtpNgay.Format = DateTimePickerFormat.Custom;
            dtpNgay.CustomFormat = "dd/MM/yyyy";
            dtpNgay.Value = DateTime.Today;

            // Tránh đăng ký trùng sự kiện nếu Designer đã gắn sẵn.
            btnXem.Click -= btnXem_Click;
            btnXem.Click += btnXem_Click;

            cboLoaiThongKe.SelectedIndexChanged -=
                cboLoaiThongKe_SelectedIndexChanged;
            cboLoaiThongKe.SelectedIndexChanged +=
                cboLoaiThongKe_SelectedIndexChanged;

            dangKhoiTao = false;

            CapNhatLuaChonThoiGian();
            TaoBieuDoBanDau();
        }

        private void CapNhatLuaChonThoiGian()
        {
            if (cboLoaiThongKe.SelectedItem == null)
                return;

            string loai = cboLoaiThongKe.SelectedItem.ToString();

            cboTuanQuy.Items.Clear();
            cboTuanQuy.Visible = false;

            if (loai == "Theo ngày")
            {
                dtpNgay.CustomFormat = "dd/MM/yyyy";
            }
            else if (loai == "Theo tháng")
            {
                dtpNgay.CustomFormat = "MM/yyyy";
            }
            else if (loai == "Theo tuần")
            {
                dtpNgay.CustomFormat = "yyyy";

                cboTuanQuy.Visible = true;

                for (int i = 1; i <= 53; i++)
                {
                    cboTuanQuy.Items.Add("Tuần " + i);
                }

                int tuanHienTai = LaySoTuan(DateTime.Today);
                cboTuanQuy.SelectedIndex = tuanHienTai - 1;
            }
            else if (loai == "Theo quý")
            {
                dtpNgay.CustomFormat = "yyyy";

                cboTuanQuy.Visible = true;
                cboTuanQuy.Items.Add("Quý 1");
                cboTuanQuy.Items.Add("Quý 2");
                cboTuanQuy.Items.Add("Quý 3");
                cboTuanQuy.Items.Add("Quý 4");

                cboTuanQuy.SelectedIndex =
                    (DateTime.Today.Month - 1) / 3;
            }
        }

        private int LaySoTuan(DateTime ngay)
        {
            // Tuần bắt đầu từ thứ Hai.
            DateTime dauNam = new DateTime(ngay.Year, 1, 1);

            int soNgay = ((int)dauNam.DayOfWeek + 6) % 7;
            DateTime dauTuanDauTien = dauNam.AddDays(-soNgay);

            return (int)((ngay.Date - dauTuanDauTien.Date).TotalDays / 7) + 1;
        }

        private void cboLoaiThongKe_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (dangKhoiTao)
                return;

            CapNhatLuaChonThoiGian();
        }

        private void TaoBieuDoBanDau()
        {
            chartDoanhThu.Series.Clear();
            chartDoanhThu.ChartAreas.Clear();
            chartDoanhThu.Legends.Clear();
            chartDoanhThu.Titles.Clear();

            ChartArea khuVucCot = new ChartArea("KhuVucCot");
            khuVucCot.AxisX.Interval = 1;
            khuVucCot.AxisX.MajorGrid.Enabled = false;
            khuVucCot.AxisY.Title = "Doanh thu (VNĐ)";
            chartDoanhThu.ChartAreas.Add(khuVucCot);

            Series cot = new Series("Doanh thu");
            cot.ChartType = SeriesChartType.Column;
            cot.XValueType = ChartValueType.String;
            cot.YValueType = ChartValueType.Double;
            cot.IsValueShownAsLabel = true;
            cot.LabelFormat = "N0";
            chartDoanhThu.Series.Add(cot);

            chartTyLe.Series.Clear();
            chartTyLe.ChartAreas.Clear();
            chartTyLe.Legends.Clear();
            chartTyLe.Titles.Clear();

            chartTyLe.ChartAreas.Add(new ChartArea("KhuVucTron"));

            Legend chuGiai = new Legend("ChuGiai");
            chartTyLe.Legends.Add(chuGiai);

            Series tron = new Series("Tỷ lệ doanh thu");
            tron.ChartType = SeriesChartType.Pie;
            tron.IsValueShownAsLabel = true;
            tron.Label = "#VALX: #PERCENT{P1}";
            tron.Legend = "ChuGiai";
            chartTyLe.Series.Add(tron);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cboLoaiThongKe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại thống kê.");
                return;
            }

            string loai = cboLoaiThongKe.SelectedItem.ToString();
            DateTime tuNgay;
            DateTime denNgay;

            int nam = dtpNgay.Value.Year;

            if (loai == "Theo ngày")
            {
                tuNgay = dtpNgay.Value.Date;
                denNgay = tuNgay.AddDays(1);
            }
            else if (loai == "Theo tháng")
            {
                tuNgay = new DateTime(
                    nam, dtpNgay.Value.Month, 1);

                denNgay = tuNgay.AddMonths(1);
            }
            else if (loai == "Theo tuần")
            {
                if (cboTuanQuy.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn tuần.");
                    return;
                }

                int soTuan = cboTuanQuy.SelectedIndex + 1;

                DateTime dauNam = new DateTime(nam, 1, 1);
                int soNgayLech =
                    ((int)dauNam.DayOfWeek + 6) % 7;

                tuNgay = dauNam.AddDays(-soNgayLech)
                    .AddDays((soTuan - 1) * 7);

                denNgay = tuNgay.AddDays(7);

                // Không lấy dữ liệu ngoài năm được chọn.
                if (tuNgay.Year < nam)
                    tuNgay = dauNam;

                DateTime dauNamSau = new DateTime(nam + 1, 1, 1);

                if (denNgay > dauNamSau)
                    denNgay = dauNamSau;
            }
            else
            {
                if (cboTuanQuy.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn quý.");
                    return;
                }

                int quy = cboTuanQuy.SelectedIndex + 1;
                int thangBatDau = (quy - 1) * 3 + 1;

                tuNgay = new DateTime(nam, thangBatDau, 1);
                denNgay = tuNgay.AddMonths(3);
            }

            HienThiDoanhThu(loai, tuNgay, denNgay);
        }

        private void HienThiDoanhThu(
            string loai, DateTime tuNgay, DateTime denNgay)
        {
            string sql = @"
                SELECT
                    s.MaSan,
                    s.TenSan,
                    SUM(p.TongTien) AS DoanhThu
                FROM dbo.PhieuDatSan p
                INNER JOIN dbo.San s ON p.MaSan = s.MaSan
                WHERE p.XacNhanThanhToan = 1
                  AND p.NgaySuDung >= @TuNgay
                  AND p.NgaySuDung < @DenNgay
                GROUP BY s.MaSan, s.TenSan
                ORDER BY s.TenSan;";

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@TuNgay", SqlDbType.Date).Value =
                        tuNgay.Date;

                    cmd.Parameters.Add("@DenNgay", SqlDbType.Date).Value =
                        denNgay.Date;

                    DataTable bangDuLieu = new DataTable();

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(bangDuLieu);
                    }

                    TaoBieuDoBanDau();

                    decimal tongDoanhThu = 0;

                    foreach (DataRow row in bangDuLieu.Rows)
                    {
                        string tenSan = row["TenSan"].ToString();

                        decimal doanhThu =
                            Convert.ToDecimal(row["DoanhThu"]);

                        chartDoanhThu.Series["Doanh thu"]
                            .Points.AddXY(tenSan, doanhThu);

                        chartTyLe.Series["Tỷ lệ doanh thu"]
                            .Points.AddXY(tenSan, doanhThu);

                        tongDoanhThu += doanhThu;
                    }

                    string tieuDe =
                        $"Doanh thu theo sân ({loai})";

                    chartDoanhThu.Titles.Add(tieuDe);
                    chartDoanhThu.Titles.Add(
                        $"Tổng doanh thu: {tongDoanhThu:N0} VNĐ");

                    chartTyLe.Titles.Add(
                        "Tỷ lệ doanh thu theo sân");

                    if (bangDuLieu.Rows.Count == 0)
                    {
                        MessageBox.Show(
                            "Không có doanh thu trong khoảng thời gian đã chọn.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải doanh thu: " + ex.Message,
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void grpThongTin_Enter(object sender, EventArgs e)
        {
        }

        private void FormDoanhThuTheoThoiGian_Load(
            object sender, EventArgs e)
        {
        }
    }
}
