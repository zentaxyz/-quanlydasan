using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlydatsan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_content.Controls.Clear();
            UCQuanLyLichDat uc = new UCQuanLyLichDat();
            uc.Dock = DockStyle.Fill;
            pnl_content.Controls.Add(uc);
        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            pnl_content.Controls.Clear();
            UCPhieuDatSan uc = new UCPhieuDatSan();
            uc.Dock = DockStyle.Fill;
            pnl_content.Controls.Add(uc);
        }

        private void btnSan_Click(object sender, EventArgs e)
        {
            pnl_content.Controls.Clear();
            UCQuanLySan uc = new UCQuanLySan();
            uc.Dock = DockStyle.Fill;
            pnl_content.Controls.Add(uc);
        }

        private void btnNgayLe_Click(object sender, EventArgs e)
        {
            pnl_content.Controls.Clear();
            UCNgayLe uc = new UCNgayLe();
            uc.Dock = DockStyle.Fill;
            pnl_content.Controls.Add(uc);
        }
    }
}
