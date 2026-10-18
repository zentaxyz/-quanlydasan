namespace quanlydatsan
{
    partial class FrmLichSuThanhToan
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
            groupBox1 = new GroupBox();
            btnXoa = new Button();
            btnLuu = new Button();
            TxtSotien = new TextBox();
            dtpTGthanhtoan = new DateTimePicker();
            cboPTThanhtoan = new ComboBox();
            TxtPhieuDatSan = new TextBox();
            TxtMatt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtTheoten = new TextBox();
            btnTheoTen = new Button();
            btnHientatca = new Button();
            dgvLSThanhtoan = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLSThanhtoan).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(TxtSotien);
            groupBox1.Controls.Add(dtpTGthanhtoan);
            groupBox1.Controls.Add(cboPTThanhtoan);
            groupBox1.Controls.Add(TxtPhieuDatSan);
            groupBox1.Controls.Add(TxtMatt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1047, 325);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thanh toán";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(815, 272);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(168, 36);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(618, 272);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(128, 38);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // TxtSotien
            // 
            TxtSotien.Location = new Point(24, 182);
            TxtSotien.Name = "TxtSotien";
            TxtSotien.ReadOnly = true;
            TxtSotien.Size = new Size(377, 27);
            TxtSotien.TabIndex = 9;
            // 
            // dtpTGthanhtoan
            // 
            dtpTGthanhtoan.Format = DateTimePickerFormat.Short;
            dtpTGthanhtoan.Location = new Point(501, 110);
            dtpTGthanhtoan.Name = "dtpTGthanhtoan";
            dtpTGthanhtoan.Size = new Size(379, 27);
            dtpTGthanhtoan.TabIndex = 8;
            // 
            // cboPTThanhtoan
            // 
            cboPTThanhtoan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPTThanhtoan.FormattingEnabled = true;
            cboPTThanhtoan.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "Thẻ ngân hàng" });
            cboPTThanhtoan.Location = new Point(24, 110);
            cboPTThanhtoan.Name = "cboPTThanhtoan";
            cboPTThanhtoan.Size = new Size(377, 28);
            cboPTThanhtoan.TabIndex = 7;
            // 
            // TxtPhieuDatSan
            // 
            TxtPhieuDatSan.Location = new Point(501, 56);
            TxtPhieuDatSan.Name = "TxtPhieuDatSan";
            TxtPhieuDatSan.ReadOnly = true;
            TxtPhieuDatSan.Size = new Size(379, 27);
            TxtPhieuDatSan.TabIndex = 6;
            // 
            // TxtMatt
            // 
            TxtMatt.Location = new Point(22, 52);
            TxtMatt.Name = "TxtMatt";
            TxtMatt.ReadOnly = true;
            TxtMatt.Size = new Size(379, 27);
            TxtMatt.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 156);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 4;
            label5.Text = "Số tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 86);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 3;
            label4.Text = "Thời gian thanh toán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(501, 33);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Phiếu đặt sân";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 82);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 1;
            label2.Text = "Phương thức thanh toán";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 29);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã ";
            // 
            // TxtTheoten
            // 
            TxtTheoten.Location = new Point(36, 352);
            TxtTheoten.Name = "TxtTheoten";
            TxtTheoten.Size = new Size(477, 27);
            TxtTheoten.TabIndex = 1;
            // 
            // btnTheoTen
            // 
            btnTheoTen.Location = new Point(609, 352);
            btnTheoTen.Name = "btnTheoTen";
            btnTheoTen.Size = new Size(173, 30);
            btnTheoTen.TabIndex = 2;
            btnTheoTen.Text = "Hiện theo tên";
            btnTheoTen.UseVisualStyleBackColor = true;
            btnTheoTen.Click += btnTheoTen_Click;
            // 
            // btnHientatca
            // 
            btnHientatca.Location = new Point(819, 352);
            btnHientatca.Name = "btnHientatca";
            btnHientatca.Size = new Size(187, 30);
            btnHientatca.TabIndex = 3;
            btnHientatca.Text = "Hiện tất cả";
            btnHientatca.UseVisualStyleBackColor = true;
            btnHientatca.Click += btnHientatca_Click;
            // 
            // dgvLSThanhtoan
            // 
            dgvLSThanhtoan.AllowUserToAddRows = false;
            dgvLSThanhtoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLSThanhtoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLSThanhtoan.Location = new Point(16, 384);
            dgvLSThanhtoan.MultiSelect = false;
            dgvLSThanhtoan.Name = "dgvLSThanhtoan";
            dgvLSThanhtoan.ReadOnly = true;
            dgvLSThanhtoan.RowHeadersWidth = 51;
            dgvLSThanhtoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLSThanhtoan.Size = new Size(1048, 286);
            dgvLSThanhtoan.TabIndex = 4;
            // 
            // FrmLichSuThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 670);
            Controls.Add(dgvLSThanhtoan);
            Controls.Add(btnHientatca);
            Controls.Add(btnTheoTen);
            Controls.Add(TxtTheoten);
            Controls.Add(groupBox1);
            Name = "FrmLichSuThanhToan";
            Text = "FrmLichSuThanhToan";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLSThanhtoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnXoa;
        private Button btnLuu;
        private TextBox TxtSotien;
        private DateTimePicker dtpTGthanhtoan;
        private ComboBox cboPTThanhtoan;
        private TextBox TxtPhieuDatSan;
        private TextBox TxtMatt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtTheoten;
        private Button btnTheoTen;
        private Button btnHientatca;
        private DataGridView dgvLSThanhtoan;
    }
}