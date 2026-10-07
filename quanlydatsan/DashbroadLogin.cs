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
        public DashbroadLogin()
        {
            InitializeComponent();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Close();
            login.Show();
        }

        private void DashbroadLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
