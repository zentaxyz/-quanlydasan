namespace quanlydatsan
{
    partial class Form2
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
            pnl_menu = new Panel();
            btnSan = new Button();
            btnDatSan = new Button();
            btnQuanLyLichDat = new Button();
            label1 = new Label();
            pnl_content = new Panel();
            btnNgayLe = new Button();
            pnl_menu.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_menu
            // 
            pnl_menu.BackColor = SystemColors.MenuHighlight;
            pnl_menu.Controls.Add(btnNgayLe);
            pnl_menu.Controls.Add(btnSan);
            pnl_menu.Controls.Add(btnDatSan);
            pnl_menu.Controls.Add(btnQuanLyLichDat);
            pnl_menu.Controls.Add(label1);
            pnl_menu.Dock = DockStyle.Left;
            pnl_menu.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            pnl_menu.Location = new Point(0, 0);
            pnl_menu.Name = "pnl_menu";
            pnl_menu.Size = new Size(199, 815);
            pnl_menu.TabIndex = 0;
            // 
            // btnSan
            // 
            btnSan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSan.Location = new Point(18, 265);
            btnSan.Name = "btnSan";
            btnSan.Size = new Size(153, 33);
            btnSan.TabIndex = 2;
            btnSan.Text = "Sân";
            btnSan.UseVisualStyleBackColor = true;
            btnSan.Click += btnSan_Click;
            // 
            // btnDatSan
            // 
            btnDatSan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatSan.Location = new Point(18, 211);
            btnDatSan.Name = "btnDatSan";
            btnDatSan.Size = new Size(153, 33);
            btnDatSan.TabIndex = 0;
            btnDatSan.Text = "Đặt sân";
            btnDatSan.UseVisualStyleBackColor = true;
            btnDatSan.Click += btnDatSan_Click;
            // 
            // btnQuanLyLichDat
            // 
            btnQuanLyLichDat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuanLyLichDat.Location = new Point(18, 148);
            btnQuanLyLichDat.Name = "btnQuanLyLichDat";
            btnQuanLyLichDat.Size = new Size(153, 39);
            btnQuanLyLichDat.TabIndex = 1;
            btnQuanLyLichDat.Text = "Quản Lý Lịch Đặt";
            btnQuanLyLichDat.UseVisualStyleBackColor = true;
            btnQuanLyLichDat.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(8, 18);
            label1.Name = "label1";
            label1.Size = new Size(173, 31);
            label1.TabIndex = 0;
            label1.Text = "ALOBOOKING";
            // 
            // pnl_content
            // 
            pnl_content.Dock = DockStyle.Fill;
            pnl_content.Location = new Point(199, 0);
            pnl_content.Name = "pnl_content";
            pnl_content.Size = new Size(1430, 815);
            pnl_content.TabIndex = 1;
            // 
            // btnNgayLe
            // 
            btnNgayLe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNgayLe.Location = new Point(18, 320);
            btnNgayLe.Name = "btnNgayLe";
            btnNgayLe.Size = new Size(153, 33);
            btnNgayLe.TabIndex = 3;
            btnNgayLe.Text = "Ngày lễ";
            btnNgayLe.UseVisualStyleBackColor = true;
            btnNgayLe.Click += btnNgayLe_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1629, 815);
            Controls.Add(pnl_content);
            Controls.Add(pnl_menu);
            Name = "Form2";
            Text = "Form2";
            pnl_menu.ResumeLayout(false);
            pnl_menu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_menu;
        private Label label1;
        private Button btnQuanLyLichDat;
        private Panel pnl_content;
        private Button btnDatSan;
        private Button btnSan;
        private Button btnNgayLe;
    }
}