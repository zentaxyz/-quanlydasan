namespace quanlydatsan.All_User_control
{
    partial class UC_LichSuDatSan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlTop = new Panel();
            lblSubTitle = new Label();
            lblTitle = new Label();
            pnlFilter = new Panel();
            btnLamMoi = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            cboLocTrangThai = new ComboBox();
            lblLocTrangThai = new Label();
            pnlBottom = new Panel();
            btnHuyPhieu = new Button();
            lblTongChiTieu = new Label();
            lblTongDon = new Label();
            dgvLichSu = new DataGridView();
            pnlTop.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(lblSubTitle);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(890, 65);
            pnlTop.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubTitle.Location = new Point(22, 38);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(319, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Theo dõi chi tiết các phiếu đặt sân và tình trạng thanh toán";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(20, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(173, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LỊCH SỬ ĐẶT SÂN";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.White;
            pnlFilter.Controls.Add(btnLamMoi);
            pnlFilter.Controls.Add(txtTimKiem);
            pnlFilter.Controls.Add(lblTimKiem);
            pnlFilter.Controls.Add(cboLocTrangThai);
            pnlFilter.Controls.Add(lblLocTrangThai);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 65);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(20, 10, 20, 10);
            pnlFilter.Size = new Size(890, 65);
            pnlFilter.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(241, 245, 249);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.FromArgb(71, 85, 105);
            btnLamMoi.Location = new Point(525, 25);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(95, 28);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "↺ Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.5F);
            txtTimKiem.Location = new Point(235, 27);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(270, 24);
            txtTimKiem.TabIndex = 3;
            txtTimKiem.TextChanged += Filter_Changed;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTimKiem.ForeColor = Color.FromArgb(71, 85, 105);
            lblTimKiem.Location = new Point(232, 9);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(134, 15);
            lblTimKiem.TabIndex = 2;
            lblTimKiem.Text = "Tìm theo Mã / Tên Sân:";
            // 
            // cboLocTrangThai
            // 
            cboLocTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocTrangThai.Font = new Font("Segoe UI", 9.5F);
            cboLocTrangThai.FormattingEnabled = true;
            cboLocTrangThai.Items.AddRange(new object[] { "Tất cả trạng thái", "Chờ duyệt", "Đã đặt", "Hủy" });
            cboLocTrangThai.Location = new Point(25, 27);
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(185, 25);
            cboLocTrangThai.TabIndex = 1;
            cboLocTrangThai.SelectedIndexChanged += Filter_Changed;
            // 
            // lblLocTrangThai
            // 
            lblLocTrangThai.AutoSize = true;
            lblLocTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLocTrangThai.ForeColor = Color.FromArgb(71, 85, 105);
            lblLocTrangThai.Location = new Point(22, 9);
            lblLocTrangThai.Name = "lblLocTrangThai";
            lblLocTrangThai.Size = new Size(89, 15);
            lblLocTrangThai.TabIndex = 0;
            lblLocTrangThai.Text = "Lọc Trạng Thái:";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(btnHuyPhieu);
            pnlBottom.Controls.Add(lblTongChiTieu);
            pnlBottom.Controls.Add(lblTongDon);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 560);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(20);
            pnlBottom.Size = new Size(890, 60);
            pnlBottom.TabIndex = 2;
            // 
            // btnHuyPhieu
            // 
            btnHuyPhieu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHuyPhieu.BackColor = Color.FromArgb(239, 68, 68);
            btnHuyPhieu.Cursor = Cursors.Hand;
            btnHuyPhieu.FlatAppearance.BorderSize = 0;
            btnHuyPhieu.FlatStyle = FlatStyle.Flat;
            btnHuyPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuyPhieu.ForeColor = Color.White;
            btnHuyPhieu.Location = new Point(742, 13);
            btnHuyPhieu.Name = "btnHuyPhieu";
            btnHuyPhieu.Size = new Size(125, 34);
            btnHuyPhieu.TabIndex = 3;
            btnHuyPhieu.Text = "❌ Hủy Đặt Sân";
            btnHuyPhieu.UseVisualStyleBackColor = false;
            btnHuyPhieu.Click += btnHuyPhieu_Click;
            // 
            // lblTongChiTieu
            // 
            lblTongChiTieu.AutoSize = true;
            lblTongChiTieu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTongChiTieu.ForeColor = Color.FromArgb(220, 38, 38);
            lblTongChiTieu.Location = new Point(220, 21);
            lblTongChiTieu.Name = "lblTongChiTieu";
            lblTongChiTieu.Size = new Size(138, 17);
            lblTongChiTieu.TabIndex = 1;
            lblTongChiTieu.Text = "Tổng chi tiêu: 0 VNĐ";
            // 
            // lblTongDon
            // 
            lblTongDon.AutoSize = true;
            lblTongDon.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTongDon.ForeColor = Color.FromArgb(30, 41, 59);
            lblTongDon.Location = new Point(22, 21);
            lblTongDon.Name = "lblTongDon";
            lblTongDon.Size = new Size(140, 17);
            lblTongDon.TabIndex = 0;
            lblTongDon.Text = "Tổng số phiếu: 0 đơn";
            // 
            // dgvLichSu
            // 
            dgvLichSu.AllowUserToAddRows = false;
            dgvLichSu.AllowUserToDeleteRows = false;
            dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSu.BackgroundColor = Color.FromArgb(241, 245, 249);
            dgvLichSu.BorderStyle = BorderStyle.None;
            dgvLichSu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLichSu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(21, 43, 29);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(21, 43, 29);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLichSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLichSu.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 252, 231);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(21, 43, 29);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLichSu.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLichSu.Dock = DockStyle.Fill;
            dgvLichSu.EnableHeadersVisualStyles = false;
            dgvLichSu.GridColor = Color.FromArgb(226, 232, 240);
            dgvLichSu.Location = new Point(0, 130);
            dgvLichSu.MultiSelect = false;
            dgvLichSu.Name = "dgvLichSu";
            dgvLichSu.ReadOnly = true;
            dgvLichSu.RowHeadersVisible = false;
            dgvLichSu.RowTemplate.Height = 35;
            dgvLichSu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichSu.Size = new Size(890, 430);
            dgvLichSu.TabIndex = 3;
            dgvLichSu.CellDoubleClick += dgvLichSu_CellDoubleClick;
            dgvLichSu.CellFormatting += dgvLichSu_CellFormatting;
            // 
            // UC_LichSuDatSan
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            Controls.Add(dgvLichSu);
            Controls.Add(pnlBottom);
            Controls.Add(pnlFilter);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 9.5F);
            Name = "UC_LichSuDatSan";
            Size = new Size(890, 620);
            Load += UC_LichSuDatSan_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTongDon;
        private System.Windows.Forms.Label lblTongChiTieu;
        private System.Windows.Forms.Button btnHuyPhieu;
        private System.Windows.Forms.DataGridView dgvLichSu;
    }
}