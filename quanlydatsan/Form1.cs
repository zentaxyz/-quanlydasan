using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlydatsan
{
    public partial class frmLogin : Form
    {
        
        Database dt = new Database();
        String query;
        public frmLogin()
        {
            InitializeComponent();
            label7.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            frmRes Res = new frmRes();
            Res.Show();
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            frmTrans Trans = new frmTrans();
            Trans.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "SELECT t.Tendangnhap, u.Sodienthoai, u.Email, t.Matkhau " +
        "FROM Taikhoan t " +
        "LEFT JOIN Thongtinnguoidung u ON t.Mataikhoan = u.Mataikhoan " +
        "WHERE (t.Tendangnhap = '" + txtLogin.Text.Trim() + "' " +
        "   OR u.Email = '" + txtLogin.Text.Trim() + "' " +
        "   OR u.Sodienthoai = '" + txtLogin.Text.Trim() + "') " +
        "  AND t.Matkhau = '" + txtPass.Text.Trim() + "'";
            DataSet ds = dt.GetData(query);

            if (ds.Tables[0].Rows.Count !=0)
            {
                DashbroadLogin dash = new DashbroadLogin();
                this.Hide();
                dash.Show();
            }
            else
            {
                label7.Visible = true;
                txtPass.Clear();
            }
        }
    }
}
