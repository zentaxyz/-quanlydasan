namespace QuanLyDatSan
{
    partial class UCDoanhThuTheoSan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            grpThongTin = new GroupBox();
            btnXem = new Button();
            cboLoaiThongKe = new ComboBox();
            dtpTuNgay = new DateTimePicker();
            lblLoaiThongKe = new Label();
            dtpDenNgay = new DateTimePicker();
            lblTuNgay = new Label();
            lblDenNgay = new Label();
            grpBieuDo = new GroupBox();
            chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            grpThongTin.SuspendLayout();
            grpBieuDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(btnXem);
            grpThongTin.Controls.Add(cboLoaiThongKe);
            grpThongTin.Controls.Add(dtpTuNgay);
            grpThongTin.Controls.Add(lblLoaiThongKe);
            grpThongTin.Controls.Add(dtpDenNgay);
            grpThongTin.Controls.Add(lblTuNgay);
            grpThongTin.Controls.Add(lblDenNgay);
            grpThongTin.Location = new Point(11, 23);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(962, 125);
            grpThongTin.TabIndex = 7;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin";
            // 
            // btnXem
            // 
            btnXem.BackColor = Color.FromArgb(128, 255, 128);
            btnXem.FlatStyle = FlatStyle.Flat;
            btnXem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXem.ForeColor = Color.White;
            btnXem.Location = new Point(796, 41);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(125, 32);
            btnXem.TabIndex = 12;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = false;
            // 
            // cboLoaiThongKe
            // 
            cboLoaiThongKe.FormattingEnabled = true;
            cboLoaiThongKe.Location = new Point(6, 38);
            cboLoaiThongKe.Name = "cboLoaiThongKe";
            cboLoaiThongKe.Size = new Size(270, 23);
            cboLoaiThongKe.TabIndex = 9;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(306, 38);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(195, 23);
            dtpTuNgay.TabIndex = 11;
            // 
            // lblLoaiThongKe
            // 
            lblLoaiThongKe.AutoSize = true;
            lblLoaiThongKe.Location = new Point(6, 18);
            lblLoaiThongKe.Name = "lblLoaiThongKe";
            lblLoaiThongKe.Size = new Size(79, 15);
            lblLoaiThongKe.TabIndex = 6;
            lblLoaiThongKe.Text = "Loại thống kê";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(546, 38);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(195, 23);
            dtpDenNgay.TabIndex = 10;
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Location = new Point(306, 18);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(50, 15);
            lblTuNgay.TabIndex = 7;
            lblTuNgay.Text = "Từ ngày";
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Location = new Point(546, 18);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(57, 15);
            lblDenNgay.TabIndex = 8;
            lblDenNgay.Text = "Đến ngày";
            // 
            // grpBieuDo
            // 
            grpBieuDo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBieuDo.Controls.Add(chartDoanhThu);
            grpBieuDo.Location = new Point(11, 158);
            grpBieuDo.Name = "grpBieuDo";
            grpBieuDo.Size = new Size(962, 430);
            grpBieuDo.TabIndex = 8;
            grpBieuDo.TabStop = false;
            grpBieuDo.Text = "Dữ liệu thống kê";
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDoanhThu.Legends.Add(legend1);
            chartDoanhThu.Location = new Point(6, 22);
            chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDoanhThu.Series.Add(series1);
            chartDoanhThu.Size = new Size(948, 402);
            chartDoanhThu.TabIndex = 0;
            chartDoanhThu.Text = "chart1";
            // 
            // UCDoanhThuTheoSan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpThongTin);
            Controls.Add(grpBieuDo);
            Name = "UCDoanhThuTheoSan";
            Size = new Size(984, 611);
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpBieuDo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTin;
        private Button btnXem;
        private ComboBox cboLoaiThongKe;
        private DateTimePicker dtpTuNgay;
        private Label lblLoaiThongKe;
        private DateTimePicker dtpDenNgay;
        private Label lblTuNgay;
        private Label lblDenNgay;
        private GroupBox grpBieuDo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
    }
}
