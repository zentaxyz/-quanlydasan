namespace quanlydatsan
{
    partial class Khachhangvataikhoan
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
            tabPage2 = new TabPage();
            dgvTaikhoan = new DataGridView();
            label18 = new Label();
            groupBox6 = new GroupBox();
            txtTimkiemTK = new TextBox();
            label14 = new Label();
            groupBox4 = new GroupBox();
            cboMand = new ComboBox();
            cboTrangthai = new ComboBox();
            btnLammoiTK = new Button();
            btnXoaTK = new Button();
            btnXuaTK = new Button();
            btnThemTK = new Button();
            groupBox5 = new GroupBox();
            cboLoaitk = new ComboBox();
            txtTendangnhap = new TextBox();
            txtMatkhau = new TextBox();
            txtMatk = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachhang).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaikhoan).BeginInit();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(541, 38);
            label5.TabIndex = 4;
            label5.Text = "QUẢN LÝ KHÁCH HÀNG VÀ TÀI KHOẢN";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 60);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(931, 609);
            tabControl1.TabIndex = 5;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvKhachhang);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(923, 576);
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
            dgvKhachhang.Location = new Point(6, 330);
            dgvKhachhang.Name = "dgvKhachhang";
            dgvKhachhang.ReadOnly = true;
            dgvKhachhang.RowHeadersWidth = 51;
            dgvKhachhang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachhang.Size = new Size(909, 240);
            dgvKhachhang.TabIndex = 17;
            dgvKhachhang.CellClick += dgvKhachhang_CellClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 296);
            label10.Name = "label10";
            label10.Size = new Size(260, 31);
            label10.TabIndex = 16;
            label10.Text = "Danh sách khách hàng:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(txtTimkiem);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(665, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 201);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(6, 64);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.PlaceholderText = "Tên hoặc SĐT...";
            txtTimkiem.Size = new Size(238, 27);
            txtTimkiem.TabIndex = 1;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 23);
            label9.Name = "label9";
            label9.Size = new Size(95, 28);
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
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnLammoi
            // 
            btnLammoi.BackColor = Color.Cyan;
            btnLammoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLammoi.Location = new Point(515, 212);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(94, 46);
            btnLammoi.TabIndex = 5;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = false;
            btnLammoi.MouseClick += btnLammoi_MouseClick;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(354, 212);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 46);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.MouseClick += btnXoa_MouseClick;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Yellow;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(203, 212);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 46);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.MouseClick += btnSua_MouseClick;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Lime;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(46, 212);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 46);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.MouseClick += btnThem_MouseClick;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(682, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // cboGioitinh
            // 
            cboGioitinh.FormattingEnabled = true;
            cboGioitinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioitinh.Location = new Point(444, 114);
            cboGioitinh.Name = "cboGioitinh";
            cboGioitinh.Size = new Size(204, 28);
            cboGioitinh.TabIndex = 13;
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaysinh.Format = DateTimePickerFormat.Custom;
            dtpNgaysinh.Location = new Point(444, 80);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(204, 27);
            dtpNgaysinh.TabIndex = 12;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(444, 47);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(204, 27);
            txtDiachi.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(104, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(104, 82);
            txtHoten.Name = "txtHoten";
            txtHoten.PlaceholderText = "Lê Hoàng Phúc";
            txtHoten.Size = new Size(228, 27);
            txtHoten.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(104, 115);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(228, 27);
            txtSDT.TabIndex = 8;
            // 
            // txtMand
            // 
            txtMand.BackColor = Color.LightGray;
            txtMand.Location = new Point(104, 47);
            txtMand.Name = "txtMand";
            txtMand.ReadOnly = true;
            txtMand.Size = new Size(228, 27);
            txtMand.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(354, 122);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 6;
            label8.Text = "Giới Tính:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(354, 85);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 5;
            label7.Text = "Ngày Sinh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 47);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 4;
            label6.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 161);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 122);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "SĐT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 85);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ và Tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 47);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã ND:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvTaikhoan);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(groupBox6);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(923, 576);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tài khoản thành viên";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTaikhoan
            // 
            dgvTaikhoan.AllowUserToAddRows = false;
            dgvTaikhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTaikhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaikhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaikhoan.Location = new Point(12, 288);
            dgvTaikhoan.Name = "dgvTaikhoan";
            dgvTaikhoan.ReadOnly = true;
            dgvTaikhoan.RowHeadersWidth = 51;
            dgvTaikhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaikhoan.Size = new Size(899, 275);
            dgvTaikhoan.TabIndex = 18;
            dgvTaikhoan.CellClick += dgvTaikhoan_CellClick;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(6, 254);
            label18.Name = "label18";
            label18.Size = new Size(357, 31);
            label18.TabIndex = 17;
            label18.Text = "Danh sách tài khoản thành viên:";
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox6.Controls.Add(txtTimkiemTK);
            groupBox6.Controls.Add(label14);
            groupBox6.Location = new Point(682, 6);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(235, 245);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tìm kiếm";
            // 
            // txtTimkiemTK
            // 
            txtTimkiemTK.Location = new Point(12, 78);
            txtTimkiemTK.Name = "txtTimkiemTK";
            txtTimkiemTK.PlaceholderText = "Tên đăng nhập...";
            txtTimkiemTK.Size = new Size(217, 27);
            txtTimkiemTK.TabIndex = 1;
            txtTimkiemTK.TextChanged += txtTimkiemTK_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(12, 36);
            label14.Name = "label14";
            label14.Size = new Size(112, 31);
            label14.TabIndex = 0;
            label14.Text = "Tìm kiếm:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cboMand);
            groupBox4.Controls.Add(cboTrangthai);
            groupBox4.Controls.Add(btnLammoiTK);
            groupBox4.Controls.Add(btnXoaTK);
            groupBox4.Controls.Add(btnXuaTK);
            groupBox4.Controls.Add(btnThemTK);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(cboLoaitk);
            groupBox4.Controls.Add(txtTendangnhap);
            groupBox4.Controls.Add(txtMatkhau);
            groupBox4.Controls.Add(txtMatk);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label17);
            groupBox4.Location = new Point(6, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(671, 245);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin khách hàng";
            // 
            // cboMand
            // 
            cboMand.FormattingEnabled = true;
            cboMand.Location = new Point(464, 119);
            cboMand.Name = "cboMand";
            cboMand.Size = new Size(191, 28);
            cboMand.TabIndex = 16;
            // 
            // cboTrangthai
            // 
            cboTrangthai.FormattingEnabled = true;
            cboTrangthai.Items.AddRange(new object[] { "Hoạt động", "Bị khóa" });
            cboTrangthai.Location = new Point(465, 82);
            cboTrangthai.Name = "cboTrangthai";
            cboTrangthai.Size = new Size(190, 28);
            cboTrangthai.TabIndex = 15;
            // 
            // btnLammoiTK
            // 
            btnLammoiTK.BackColor = Color.Cyan;
            btnLammoiTK.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLammoiTK.Location = new Point(512, 176);
            btnLammoiTK.Name = "btnLammoiTK";
            btnLammoiTK.Size = new Size(94, 46);
            btnLammoiTK.TabIndex = 5;
            btnLammoiTK.Text = "Làm mới";
            btnLammoiTK.UseVisualStyleBackColor = false;
            btnLammoiTK.MouseClick += btnLammoiTK_MouseClick;
            // 
            // btnXoaTK
            // 
            btnXoaTK.BackColor = Color.Red;
            btnXoaTK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaTK.Location = new Point(363, 176);
            btnXoaTK.Name = "btnXoaTK";
            btnXoaTK.Size = new Size(86, 46);
            btnXoaTK.TabIndex = 4;
            btnXoaTK.Text = "Xóa";
            btnXoaTK.UseVisualStyleBackColor = false;
            btnXoaTK.MouseClick += btnXoaTK_MouseClick;
            // 
            // btnXuaTK
            // 
            btnXuaTK.BackColor = Color.Yellow;
            btnXuaTK.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuaTK.Location = new Point(209, 175);
            btnXuaTK.Name = "btnXuaTK";
            btnXuaTK.Size = new Size(86, 46);
            btnXuaTK.TabIndex = 3;
            btnXuaTK.Text = "Sửa";
            btnXuaTK.UseVisualStyleBackColor = false;
            btnXuaTK.MouseClick += btnXuaTK_MouseClick;
            // 
            // btnThemTK
            // 
            btnThemTK.BackColor = Color.Lime;
            btnThemTK.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemTK.Location = new Point(58, 175);
            btnThemTK.Name = "btnThemTK";
            btnThemTK.Size = new Size(86, 46);
            btnThemTK.TabIndex = 2;
            btnThemTK.Text = "Thêm";
            btnThemTK.UseVisualStyleBackColor = false;
            btnThemTK.MouseClick += btnThemTK_MouseClick;
            // 
            // groupBox5
            // 
            groupBox5.Location = new Point(682, 47);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(250, 125);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox5";
            // 
            // cboLoaitk
            // 
            cboLoaitk.FormattingEnabled = true;
            cboLoaitk.Items.AddRange(new object[] { "Admin", "Khách hàng" });
            cboLoaitk.Location = new Point(465, 42);
            cboLoaitk.Name = "cboLoaitk";
            cboLoaitk.Size = new Size(190, 28);
            cboLoaitk.TabIndex = 13;
            // 
            // txtTendangnhap
            // 
            txtTendangnhap.Location = new Point(120, 78);
            txtTendangnhap.Name = "txtTendangnhap";
            txtTendangnhap.PlaceholderText = "Lê Hoàng Phúc";
            txtTendangnhap.Size = new Size(203, 27);
            txtTendangnhap.TabIndex = 9;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(120, 115);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(203, 27);
            txtMatkhau.TabIndex = 8;
            txtMatkhau.UseSystemPasswordChar = true;
            // 
            // txtMatk
            // 
            txtMatk.BackColor = Color.LightGray;
            txtMatk.Location = new Point(120, 43);
            txtMatk.Name = "txtMatk";
            txtMatk.ReadOnly = true;
            txtMatk.Size = new Size(203, 27);
            txtMatk.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(344, 122);
            label11.Name = "label11";
            label11.Size = new Size(114, 20);
            label11.TabIndex = 6;
            label11.Text = "Mã người dùng:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(344, 85);
            label12.Name = "label12";
            label12.Size = new Size(78, 20);
            label12.TabIndex = 5;
            label12.Text = "Trạng thái:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(344, 50);
            label13.Name = "label13";
            label13.Size = new Size(105, 20);
            label13.TabIndex = 4;
            label13.Text = "Loại tài khoản:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 122);
            label15.Name = "label15";
            label15.Size = new Size(73, 20);
            label15.TabIndex = 2;
            label15.Text = "Mật khẩu:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 85);
            label16.Name = "label16";
            label16.Size = new Size(110, 20);
            label16.TabIndex = 1;
            label16.Text = "Tên đăng nhập:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 50);
            label17.Name = "label17";
            label17.Size = new Size(54, 20);
            label17.TabIndex = 0;
            label17.Text = "Mã TK:";
            // 
            // Khachhangvataikhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 672);
            Controls.Add(tabControl1);
            Controls.Add(label5);
            ForeColor = Color.MidnightBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Khachhangvataikhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khachhangvataikhoan";
            WindowState = FormWindowState.Maximized;
            Load += Khachhangvataikhoan_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachhang).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaikhoan).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
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
        private TabPage tabPage2;
        private GroupBox groupBox4;
        private Button btnLammoiTK;
        private Button btnXoaTK;
        private Button btnXuaTK;
        private Button btnThemTK;
        private GroupBox groupBox5;
        private ComboBox cboLoaitk;
        private TextBox txtTendangnhap;
        private TextBox txtMatkhau;
        private TextBox txtMatk;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label16;
        private Label label17;
        private ComboBox cboMand;
        private ComboBox cboTrangthai;
        private GroupBox groupBox6;
        private TextBox txtTimkiemTK;
        private Label label14;
        private DataGridView dgvTaikhoan;
        private Label label18;
    }
}