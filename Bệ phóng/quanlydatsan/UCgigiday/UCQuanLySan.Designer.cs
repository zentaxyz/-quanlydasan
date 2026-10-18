namespace quanlydatsan
{
    partial class UCQuanLySan
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
            label1 = new Label();
            dgvSan = new DataGridView();
            TxtMaSan = new TextBox();
            TxtTenSan = new TextBox();
            cboLoaiSan = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnTao = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(145, 31);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Sân";
            // 
            // dgvSan
            // 
            dgvSan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSan.Location = new Point(13, 260);
            dgvSan.Name = "dgvSan";
            dgvSan.RowHeadersWidth = 51;
            dgvSan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSan.Size = new Size(1354, 477);
            dgvSan.TabIndex = 1;
            dgvSan.CellClick += dgvSan_CellClick;
            // 
            // TxtMaSan
            // 
            TxtMaSan.Location = new Point(142, 78);
            TxtMaSan.Name = "TxtMaSan";
            TxtMaSan.ReadOnly = true;
            TxtMaSan.Size = new Size(312, 27);
            TxtMaSan.TabIndex = 2;
            // 
            // TxtTenSan
            // 
            TxtTenSan.Location = new Point(744, 78);
            TxtTenSan.Name = "TxtTenSan";
            TxtTenSan.Size = new Size(348, 27);
            TxtTenSan.TabIndex = 3;
            // 
            // cboLoaiSan
            // 
            cboLoaiSan.FormattingEnabled = true;
            cboLoaiSan.Location = new Point(142, 162);
            cboLoaiSan.Name = "cboLoaiSan";
            cboLoaiSan.Size = new Size(312, 28);
            cboLoaiSan.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 81);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã Sân:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 165);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 6;
            label3.Text = "Loại sân:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(662, 81);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 7;
            label4.Text = "Tên Sân:";
            // 
            // btnTao
            // 
            btnTao.Location = new Point(662, 168);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(146, 35);
            btnTao.TabIndex = 8;
            btnTao.Text = "Tạo";
            btnTao.UseVisualStyleBackColor = true;
            btnTao.Click += btnTao_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(831, 167);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(146, 36);
            btnSua.TabIndex = 9;
            btnSua.Text = "Lưu";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1002, 167);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(146, 35);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // UCQuanLySan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnTao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboLoaiSan);
            Controls.Add(TxtTenSan);
            Controls.Add(TxtMaSan);
            Controls.Add(dgvSan);
            Controls.Add(label1);
            Name = "UCQuanLySan";
            Size = new Size(1374, 745);
            ((System.ComponentModel.ISupportInitialize)dgvSan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvSan;
        private TextBox TxtMaSan;
        private TextBox TxtTenSan;
        private ComboBox cboLoaiSan;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnTao;
        private Button btnSua;
        private Button btnXoa;
    }
}
