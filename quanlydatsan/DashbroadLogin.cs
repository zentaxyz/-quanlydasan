using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlydatsan
{
    public partial class DashbroadLogin : Form
    {
        private Form formCha;
        public DashbroadLogin(Form parent)
        {
            InitializeComponent();
            this.formCha = parent;
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            formCha.Show();
        }

        private void DashbroadLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
