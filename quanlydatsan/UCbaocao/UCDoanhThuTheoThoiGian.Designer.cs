namespace QuanLyDatSan
{
    partial class UCDoanhThuTheoThoiGian
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartTyLe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            grpBieuDo = new GroupBox();
            chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            grpThongTin = new GroupBox();
            btnXem = new Button();
            dtpNgay = new DateTimePicker();
            cboTuanQuy = new ComboBox();
            cboLoaiThongKe = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)chartTyLe).BeginInit();
            grpBieuDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).BeginInit();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // chartTyLe
            // 
            chartTyLe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea7.Name = "ChartArea1";
            chartTyLe.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            chartTyLe.Legends.Add(legend7);
            chartTyLe.Location = new Point(10, 214);
            chartTyLe.Name = "chartTyLe";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            chartTyLe.Series.Add(series7);
            chartTyLe.Size = new Size(925, 220);
            chartTyLe.TabIndex = 1;
            chartTyLe.Text = "chart1";
            // 
            // grpBieuDo
            // 
            grpBieuDo.Controls.Add(chartTyLe);
            grpBieuDo.Controls.Add(chartDoanhThu);
            grpBieuDo.Location = new Point(15, 155);
            grpBieuDo.Name = "grpBieuDo";
            grpBieuDo.Size = new Size(950, 440);
            grpBieuDo.TabIndex = 2;
            grpBieuDo.TabStop = false;
            grpBieuDo.Text = "Biểu đồ doanh thu";
            // 
            // chartDoanhThu
            // 
            chartDoanhThu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea8.Name = "ChartArea1";
            chartDoanhThu.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            chartDoanhThu.Legends.Add(legend8);
            chartDoanhThu.Location = new Point(10, 22);
            chartDoanhThu.Name = "chartDoanhThu";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            chartDoanhThu.Series.Add(series8);
            chartDoanhThu.Size = new Size(925, 183);
            chartDoanhThu.TabIndex = 0;
            chartDoanhThu.Text = "chart1";
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(btnXem);
            grpThongTin.Controls.Add(dtpNgay);
            grpThongTin.Controls.Add(cboTuanQuy);
            grpThongTin.Controls.Add(cboLoaiThongKe);
            grpThongTin.Location = new Point(15, 15);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(950, 130);
            grpThongTin.TabIndex = 3;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin";
            // 
            // btnXem
            // 
            btnXem.Location = new Point(650, 30);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(100, 35);
            btnXem.TabIndex = 3;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            // 
            // dtpNgay
            // 
            dtpNgay.Location = new Point(450, 30);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(150, 23);
            dtpNgay.TabIndex = 2;
            // 
            // cboTuanQuy
            // 
            cboTuanQuy.FormattingEnabled = true;
            cboTuanQuy.Location = new Point(130, 75);
            cboTuanQuy.Name = "cboTuanQuy";
            cboTuanQuy.Size = new Size(200, 23);
            cboTuanQuy.TabIndex = 1;
            // 
            // cboLoaiThongKe
            // 
            cboLoaiThongKe.FormattingEnabled = true;
            cboLoaiThongKe.Location = new Point(130, 30);
            cboLoaiThongKe.Name = "cboLoaiThongKe";
            cboLoaiThongKe.Size = new Size(200, 23);
            cboLoaiThongKe.TabIndex = 0;
            cboLoaiThongKe.SelectedIndexChanged += cboLoaiThongKe_SelectedIndexChanged;
            // 
            // UCDoanhThuTheoThoiGian
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpThongTin);
            Controls.Add(grpBieuDo);
            Name = "UCDoanhThuTheoThoiGian";
            Size = new Size(984, 611);
            ((System.ComponentModel.ISupportInitialize)chartTyLe).EndInit();
            grpBieuDo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).EndInit();
            grpThongTin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTyLe;
        private GroupBox grpBieuDo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private GroupBox grpThongTin;
        private Button btnXem;
        private DateTimePicker dtpNgay;
        private ComboBox cboTuanQuy;
        private ComboBox cboLoaiThongKe;
    }
}
