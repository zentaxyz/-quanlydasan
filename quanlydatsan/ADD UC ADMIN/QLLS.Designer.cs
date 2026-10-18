namespace quanlydatsan.ADD_UC_ADMIN
{
    partial class QLLS
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
            label5 = new Label();
            groupBox1 = new GroupBox();
            txtGiaTheoGio = new TextBox();
            txtTenLoaiSan = new TextBox();
            txtMaLoaiSan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            txtTimKiem = new TextBox();
            label9 = new Label();
            label10 = new Label();
            dgvLoaiSan = new DataGridView();

            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSan).BeginInit();
            SuspendLayout();

            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(276, 38);
            label5.TabIndex = 0;
            label5.Text = "QUẢN LÝ LOẠI SÂN";

            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGiaTheoGio);
            groupBox1.Controls.Add(txtTenLoaiSan);
            groupBox1.Controls.Add(txtMaLoaiSan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(12, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 220);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại sân";

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 35);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã loại sân:";

            // 
            // txtMaLoaiSan
            // 
            txtMaLoaiSan.Location = new Point(130, 32);
            txtMaLoaiSan.Name = "txtMaLoaiSan";
            txtMaLoaiSan.Size = new Size(480, 27);
            txtMaLoaiSan.TabIndex = 1;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên loại sân:";

            // 
            // txtTenLoaiSan
            // 
            txtTenLoaiSan.Location = new Point(130, 72);
            txtTenLoaiSan.Name = "txtTenLoaiSan";
            txtTenLoaiSan.PlaceholderText = "Sân 5 người, Sân 7 người...";
            txtTenLoaiSan.Size = new Size(480, 27);
            txtTenLoaiSan.TabIndex = 3;

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 115);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 4;
            label3.Text = "Giá theo giờ:";

            // 
            // txtGiaTheoGio
            // 
            txtGiaTheoGio.Location = new Point(130, 112);
            txtGiaTheoGio.Name = "txtGiaTheoGio";
            txtGiaTheoGio.PlaceholderText = "150000";
            txtGiaTheoGio.Size = new Size(480, 27);
            txtGiaTheoGio.TabIndex = 5;

            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Lime;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(130, 155);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 45);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;

            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Yellow;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(255, 155);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 45);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;

            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(380, 155);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 45);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;

            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Cyan;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(505, 155);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(105, 45);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;

            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(665, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 220);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";

            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 35);
            label9.Name = "label9";
            label9.Size = new Size(95, 28);
            label9.TabIndex = 0;
            label9.Text = "Tìm kiếm:";

            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(10, 75);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tên loại sân...";
            txtTimKiem.Size = new Size(230, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;

            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 290);
            label10.Name = "label10";
            label10.Size = new Size(223, 31);
            label10.TabIndex = 3;
            label10.Text = "Danh sách loại sân:";

            // 
            // dgvLoaiSan
            // 
            dgvLoaiSan.AllowUserToAddRows = false;
            dgvLoaiSan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLoaiSan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiSan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiSan.Location = new Point(12, 330);
            dgvLoaiSan.Name = "dgvLoaiSan";
            dgvLoaiSan.ReadOnly = true;
            dgvLoaiSan.RowHeadersWidth = 51;
            dgvLoaiSan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiSan.Size = new Size(903, 270);
            dgvLoaiSan.TabIndex = 4;
            dgvLoaiSan.CellClick += dgvLoaiSan_CellClick;

            // 
            // QLLS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvLoaiSan);
            Controls.Add(label10);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            ForeColor = Color.MidnightBlue;
            Name = "QLLS";
            Size = new Size(930, 610);
            Load += QLLS_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtMaLoaiSan;
        private Label label2;
        private TextBox txtTenLoaiSan;
        private Label label3;
        private TextBox txtGiaTheoGio;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private GroupBox groupBox2;
        private Label label9;
        private TextBox txtTimKiem;
        private Label label10;
        private DataGridView dgvLoaiSan;
    }
}