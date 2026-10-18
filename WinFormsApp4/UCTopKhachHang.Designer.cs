namespace QuanLyDatSan
{
    partial class UCTopKhachHang
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            grpThongTin = new GroupBox();
            btnXem = new Button();
            grpDanhSach = new GroupBox();
            chartTron = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartThanh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            grpThongTin.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTron).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartThanh).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTin.Controls.Add(btnXem);
            grpThongTin.Location = new Point(10, 10);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(960, 85);
            grpThongTin.TabIndex = 5;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "groupBox1";
            // 
            // btnXem
            // 
            btnXem.Location = new Point(15, 25);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(120, 30);
            btnXem.TabIndex = 0;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSach.Controls.Add(chartTron);
            grpDanhSach.Controls.Add(chartThanh);
            grpDanhSach.Location = new Point(10, 105);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(960, 550);
            grpDanhSach.TabIndex = 6;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách";
            // 
            // chartTron
            // 
            chartTron.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartTron.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartTron.Legends.Add(legend1);
            chartTron.Location = new Point(10, 285);
            chartTron.Name = "chartTron";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartTron.Series.Add(series1);
            chartTron.Size = new Size(925, 235);
            chartTron.TabIndex = 1;
            chartTron.Text = "chart2";
            // 
            // chartThanh
            // 
            chartThanh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            chartThanh.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartThanh.Legends.Add(legend2);
            chartThanh.Location = new Point(10, 25);
            chartThanh.Name = "chartThanh";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartThanh.Series.Add(series2);
            chartThanh.Size = new Size(925, 260);
            chartThanh.TabIndex = 0;
            chartThanh.Text = "chart1";
            // 
            // UCTopKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpThongTin);
            Controls.Add(grpDanhSach);
            Name = "UCTopKhachHang";
            Size = new Size(984, 661);
            grpThongTin.ResumeLayout(false);
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartTron).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartThanh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTin;
        private Button btnXem;
        private GroupBox grpDanhSach;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTron;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThanh;
    }
}
