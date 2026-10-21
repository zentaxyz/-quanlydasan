namespace quanlydatsan.ADD_UC_ADMIN
{
    partial class UC_QLTK
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvKhachhang = new DataGridView();
            label10 = new Label();
            groupBox3 = new GroupBox();
            txtTimkiem = new TextBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            btnLammoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            cboGioitinh = new ComboBox();
            dtpNgaysinh = new DateTimePicker();
            txtDiachi = new TextBox();
            txtEmail = new TextBox();
            txtHoten = new TextBox();
            txtSDT = new TextBox();
            txtMand = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachhang).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(10, 7);
            label5.Name = "label5";
            label5.Size = new Size(422, 30);
            label5.TabIndex = 4;
            label5.Text = "QUẢN LÝ KHÁCH HÀNG VÀ TÀI KHOẢN";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(10, 45);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(815, 457);
            tabControl1.TabIndex = 5;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvKhachhang);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(807, 429);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thông tin khách hàng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvKhachhang
            // 
            dgvKhachhang.AllowUserToAddRows = false;
            dgvKhachhang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachhang.Location = new Point(5, 248);
            dgvKhachhang.Margin = new Padding(3, 2, 3, 2);
            dgvKhachhang.Name = "dgvKhachhang";
            dgvKhachhang.ReadOnly = true;
            dgvKhachhang.RowHeadersWidth = 51;
            dgvKhachhang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachhang.Size = new Size(795, 180);
            dgvKhachhang.TabIndex = 17;
            dgvKhachhang.CellClick += dgvKhachhang_CellClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(5, 222);
            label10.Name = "label10";
            label10.Size = new Size(214, 25);
            label10.TabIndex = 16;
            label10.Text = "Danh sách khách hàng:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(txtTimkiem);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(582, 4);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(219, 151);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(5, 48);
            txtTimkiem.Margin = new Padding(3, 2, 3, 2);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.PlaceholderText = "Tên hoặc SĐT...";
            txtTimkiem.Size = new Size(209, 23);
            txtTimkiem.TabIndex = 1;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(5, 17);
            label9.Name = "label9";
            label9.Size = new Size(77, 21);
            label9.TabIndex = 0;
            label9.Text = "Tìm kiếm:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLammoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cboGioitinh);
            groupBox1.Controls.Add(dtpNgaysinh);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtHoten);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtMand);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(5, 4);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(571, 215);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnLammoi
            // 
            btnLammoi.BackColor = Color.Cyan;
            btnLammoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLammoi.Location = new Point(451, 159);
            btnLammoi.Margin = new Padding(3, 2, 3, 2);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(82, 34);
            btnLammoi.TabIndex = 5;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = false;
            btnLammoi.MouseClick += btnLammoi_MouseClick;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(310, 159);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 34);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.MouseClick += btnXoa_MouseClick;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Yellow;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(178, 159);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 34);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.MouseClick += btnSua_MouseClick;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Lime;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(40, 159);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.MouseClick += btnThem_MouseClick;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(597, 35);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(219, 94);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // cboGioitinh
            // 
            cboGioitinh.FormattingEnabled = true;
            cboGioitinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioitinh.Location = new Point(388, 86);
            cboGioitinh.Margin = new Padding(3, 2, 3, 2);
            cboGioitinh.Name = "cboGioitinh";
            cboGioitinh.Size = new Size(179, 23);
            cboGioitinh.TabIndex = 13;
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaysinh.Format = DateTimePickerFormat.Custom;
            dtpNgaysinh.Location = new Point(388, 60);
            dtpNgaysinh.Margin = new Padding(3, 2, 3, 2);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(179, 23);
            dtpNgaysinh.TabIndex = 12;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(388, 35);
            txtDiachi.Margin = new Padding(3, 2, 3, 2);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(179, 23);
            txtDiachi.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(91, 116);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(91, 62);
            txtHoten.Margin = new Padding(3, 2, 3, 2);
            txtHoten.Name = "txtHoten";
            txtHoten.PlaceholderText = "Lê Hoàng Phúc";
            txtHoten.Size = new Size(200, 23);
            txtHoten.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(91, 86);
            txtSDT.Margin = new Padding(3, 2, 3, 2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(200, 23);
            txtSDT.TabIndex = 8;
            // 
            // txtMand
            // 
            txtMand.BackColor = Color.White;
            txtMand.Location = new Point(91, 35);
            txtMand.Margin = new Padding(3, 2, 3, 2);
            txtMand.Name = "txtMand";
            txtMand.ReadOnly = true;
            txtMand.Size = new Size(200, 23);
            txtMand.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(310, 92);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 6;
            label8.Text = "Giới Tính:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(310, 64);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 5;
            label7.Text = "Ngày Sinh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(310, 35);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 4;
            label6.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 121);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 92);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "SĐT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 64);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ và Tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã ND:";
            // 
            // UC_QLTK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(label5);
            ForeColor = Color.MidnightBlue;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_QLTK";
            Size = new Size(836, 504);
            Load += Khachhangvataikhoan_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachhang).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private TextBox txtHoten;
        private TextBox txtSDT;
        private TextBox txtMand;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpNgaysinh;
        private TextBox txtDiachi;
        private GroupBox groupBox3;
        private TextBox txtTimkiem;
        private Label label9;
        private GroupBox groupBox2;
        private ComboBox cboGioitinh;
        private Button btnLammoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvKhachhang;
        private Label label10;
    }
}