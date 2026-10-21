namespace quanlydatsan
{
    partial class UCNgayLe
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
            dgvNgayLe = new DataGridView();
            btnTao = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            lable2 = new Label();
            label4 = new Label();
            dtpNgayLe = new DateTimePicker();
            TxtNgayLe = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvNgayLe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(23, 17);
            label1.Name = "label1";
            label1.Size = new Size(100, 31);
            label1.TabIndex = 0;
            label1.Text = "Ngày Lễ";
            // 
            // dgvNgayLe
            // 
            dgvNgayLe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNgayLe.Location = new Point(15, 222);
            dgvNgayLe.Name = "dgvNgayLe";
            dgvNgayLe.RowHeadersWidth = 51;
            dgvNgayLe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNgayLe.Size = new Size(1372, 507);
            dgvNgayLe.TabIndex = 1;
            dgvNgayLe.CellClick += dgvNgayLe_CellClick;
            // 
            // btnTao
            // 
            btnTao.Location = new Point(1000, 176);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(94, 29);
            btnTao.TabIndex = 2;
            btnTao.Text = "Thêm";
            btnTao.UseVisualStyleBackColor = true;
            btnTao.Click += btnTao_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(1115, 176);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Lưu";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1230, 176);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Location = new Point(595, 62);
            lable2.Name = "lable2";
            lable2.Size = new Size(47, 20);
            lable2.TabIndex = 6;
            lable2.Text = "Ngày:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 68);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 7;
            label4.Text = "Tên ngày lễ:";
            // 
            // dtpNgayLe
            // 
            dtpNgayLe.CustomFormat = "dd/MM/yyyy";
            dtpNgayLe.Format = DateTimePickerFormat.Custom;
            dtpNgayLe.Location = new Point(657, 58);
            dtpNgayLe.Name = "dtpNgayLe";
            dtpNgayLe.Size = new Size(187, 27);
            dtpNgayLe.TabIndex = 9;
            // 
            // TxtNgayLe
            // 
            TxtNgayLe.Location = new Point(244, 65);
            TxtNgayLe.Name = "TxtNgayLe";
            TxtNgayLe.Size = new Size(307, 27);
            TxtNgayLe.TabIndex = 10;
            // 
            // UCNgayLe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TxtNgayLe);
            Controls.Add(dtpNgayLe);
            Controls.Add(label4);
            Controls.Add(lable2);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnTao);
            Controls.Add(dgvNgayLe);
            Controls.Add(label1);
            Name = "UCNgayLe";
            Size = new Size(1395, 744);
            ((System.ComponentModel.ISupportInitialize)dgvNgayLe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvNgayLe;
        private Button btnTao;
        private Button btnSua;
        private Button btnXoa;
        private Label lable2;
        private Label label4;
        private DateTimePicker dtpNgayLe;
        private TextBox TxtNgayLe;
    }
}
