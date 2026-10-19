using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Linq;



namespace quanlydatsan
{
    public partial class UCQuanLyLichDat : UserControl
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=quanlydatsan;Integrated Security=True;Trust Server Certificate=True";

        int maLichDangChon = -1;
        public UCQuanLyLichDat()
        {
            InitializeComponent();
            LoadDanhSachLichDat();
            LoadComboBox();
        }
        private void LoadDanhSachLichDat()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                SELECT
                    p.MaPhieu AS [Số phiếu],
                    p.MaKhach,
                    k.TenKhach AS [Tên Khách],
                    p.MaSan,
                    s.TenSan AS [Tên Sân],
                    l.TenLoaiSan as [Loại Sân],
                    t.TenTrangThai,
                    p.XacNhanThanhToan,
                    p.NgayDat AS [Ngày Đặt],
                    p.NgaySuDung AS [Ngày Dùng],
                    p.ThoiGianBatDau AS [Giờ bắt đầu],
                    p.ThoiGianKetThuc AS [Giờ kết thúc]
                FROM PhieuDatSan p
                INNER JOIN KhachHang k
                    ON p.MaKhach = k.MaKhach
                INNER JOIN San s
                    ON p.MaSan = s.MaSan
                INNER JOIN LoaiSan l
                    ON s.MaLoaiSan = l.MaLoaiSan
                INNER JOIN TrangThai t 
                    ON p.MaTrangThai = t.MaTrangThai
                ORDER BY p.MaPhieu ASC;";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvLichDat.DataSource = dt;
                            dgvLichDat.Columns["Giờ bắt đầu"].DefaultCellStyle.Format = @"hh\:mm";
                            dgvLichDat.Columns["Giờ kết thúc"].DefaultCellStyle.Format = @"hh\:mm";
                            dgvLichDat.Columns["Ngày Đặt"].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dgvLichDat.Columns["Ngày Dùng"].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dgvLichDat.Columns["MaKhach"].Visible = false;
                            dgvLichDat.Columns["MaSan"].Visible = false;
                            dgvLichDat.Columns["TenTrangThai"].Visible = false;
                            dgvLichDat.Columns["XacNhanThanhToan"].Visible = false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi tải danh sách lịch đặt: " + ex.Message,"Lỗi SQL",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void LoadComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                
                    SqlDataAdapter daloaisan = new SqlDataAdapter("SELECT MaLoaiSan, TenLoaiSan FROM LoaiSan", conn);
                    DataTable dtloaisan = new DataTable();
                    daloaisan.Fill(dtloaisan);
                    DataRow row1 = dtloaisan.NewRow();
                    row1["MaLoaiSan"] = DBNull.Value;
                    row1["TenLoaiSan"] = "Tất cả";
                    dtloaisan.Rows.InsertAt(row1, 0);
                    cboLocLoaiSan.DataSource = dtloaisan;
                    cboLocLoaiSan.DisplayMember = "TenLoaiSan";
                    cboLocLoaiSan.ValueMember = "MaLoaiSan";
                    cboLocLoaiSan.SelectedIndex = 0;

                    SqlDataAdapter daloctrangthai = new SqlDataAdapter("SELECT * FROM TrangThai", conn);
                    DataTable dtloctrangthai = new DataTable();
                    daloctrangthai.Fill(dtloctrangthai);
                    DataRow row2 = dtloctrangthai.NewRow();
                    row2["MaTrangThai"] = DBNull.Value;
                    row2["TenTrangThai"] = "Tất cả";
                    dtloctrangthai.Rows.InsertAt(row2, 0);
                    cboLocTrangThai.DataSource = dtloctrangthai;
                    cboLocTrangThai.DisplayMember = "TenTrangThai";
                    cboLocTrangThai.ValueMember = "MaTrangThai";
                    cboLocTrangThai.SelectedIndex = 0;

            }
        }
        private void dgvLichDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dgvLichDat.Rows[e.RowIndex];
            TxtMaPhieu.Text = row.Cells["Số phiếu"].Value?.ToString();
            TxtTenKhach.Text = row.Cells["Tên Khách"].Value?.ToString();
            TxtSan.Text = row.Cells["Tên Sân"].Value?.ToString();
            TxtLoaiSan.Text = row.Cells["Loại Sân"].Value?.ToString();
            TxtTrangThai.Text = row.Cells["TenTrangThai"].Value?.ToString();
            object thanhToan = row.Cells["XacNhanThanhToan"].Value;
                bool daThanhToan = Convert.ToBoolean(thanhToan);
                TxtThanhToan.Text = daThanhToan? "Đã thanh toán" : "Chưa thanh toán";
            dtpNgayDat.Value = Convert.ToDateTime(row.Cells["Ngày Đặt"].Value);
            dtpNgaySuDung.Value = Convert.ToDateTime(row.Cells["Ngày Dùng"].Value);
            TimeSpan gioBatDau = (TimeSpan)row.Cells["Giờ bắt đầu"].Value;
            dtpThoiGianBatDau.Value = DateTime.Today.Add(gioBatDau);        
            TimeSpan gioKetThuc = (TimeSpan)row.Cells["Giờ kết thúc"].Value;
            dtpThoiGianDen.Value = DateTime.Today.Add(gioKetThuc);            
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (dtpLocTuNgay.Value.Date > dtpLocDenNgay.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không lớn hơn ngày đến!");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                SELECT
                    p.MaPhieu AS [Số phiếu],
                    p.MaKhach AS [Mã Khách],
                    k.TenKhach AS [Tên Khách],
                    p.MaSan AS [Mã sân],
                    s.TenSan AS [Tên Sân],
                    p.NgayDat AS [Ngày Đặt],
                    p.NgaySuDung AS [Ngày Sử Dụng]
                    FROM PhieuDatSan p
                    INNER JOIN KhachHang k
                    ON p.MaKhach = k.MaKhach
                    INNER JOIN San s
                    ON p.MaSan = s.MaSan
                    INNER JOIN LoaiSan ls
                    ON s.MaLoaiSan = ls.MaLoaiSan
                    INNER JOIN TrangThai tt
                    ON p.MaTrangThai = tt.MaTrangThai
                    WHERE
                    p.NgaySuDung >= @TuNgay
                    AND p.NgaySuDung <= @DenNgay
                    AND (@MaLoaiSan IS NULL
                         OR ls.MaLoaiSan = @MaLoaiSan)
                    AND (@MaTrangThai IS NULL
                         OR p.MaTrangThai = @MaTrangThai)
                    AND (
                        @TuKhoa = N''
                        OR p.MaPhieu LIKE N'%' + @TuKhoa + N'%'
                        OR p.MaKhach LIKE N'%' + @TuKhoa + N'%'
                        OR k.TenKhach LIKE N'%' + @TuKhoa + N'%'
                        OR p.MaSan LIKE N'%' + @TuKhoa + N'%'
                        OR s.TenSan LIKE N'%' + @TuKhoa + N'%'
                    )
                    ORDER BY p.MaPhieu ASC;";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@TuNgay", SqlDbType.Date).Value = dtpLocTuNgay.Value.Date;
                        cmd.Parameters.Add("@DenNgay", SqlDbType.Date).Value = dtpLocDenNgay.Value.Date;
                        object maLoaiSan =cboLocLoaiSan.SelectedIndex > 0 ? cboLocLoaiSan.SelectedValue:DBNull.Value;
                        cmd.Parameters.Add("@MaLoaiSan", SqlDbType.VarChar, 10).Value = maLoaiSan;
                        object maTrangThai =cboLocTrangThai.SelectedIndex > 0 ? cboLocTrangThai.SelectedValue:DBNull.Value;
                        cmd.Parameters.Add("@MaTrangThai", SqlDbType.VarChar, 10).Value = maTrangThai;
                        cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar, 200).Value = txtTimKiem.Text.Trim();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvLichDat.DataSource = dt;
                        }
                    }
                }
                dgvLichDat.Columns["Ngày Đặt"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvLichDat.Columns["Ngày Sử Dụng"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu: " + ex.Message,"Lỗi SQL",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void mcLichDat_DateSelected(object sender, DateRangeEventArgs e)
        {
            dtpLocTuNgay.Value = e.Start.Date;
            dtpLocDenNgay.Value = e.End.Date;
            btnTimKiem_Click(sender, EventArgs.Empty);
        }
    }
}