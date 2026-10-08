using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlydatsan
{
    public partial class frmTrans : Form
    {
        Database dt = new Database();
        String query;
        public frmTrans()
        {
            InitializeComponent();
            label6.Visible = false;
            label5.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "SELECT t.Tendangnhap, u.Sodienthoai, u.Email, t.Matkhau " +
              "FROM Taikhoan t " +
              "LEFT JOIN Thongtinnguoidung u ON t.Mataikhoan = u.Mataikhoan " +
              "WHERE (t.Tendangnhap = '" + txtLogin.Text.Trim() + "' " +
              "   OR u.Email = '" + txtLogin.Text.Trim() + "' " +
              "   OR u.Sodienthoai = '" + txtLogin.Text.Trim() + "') ";
            DataSet ds = dt.GetData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                label6.Visible = false;

                if(txtNPass.Text == txtNPassN.Text && txtNPass.Text != "")
                {   
                    label5.Visible=false;
                    query = "UPDATE Taikhoan SET Matkhau = '" + txtNPass.Text.Trim() + "' WHERE Tendangnhap = '" + txtLogin.Text.Trim() + "'";
                    dt.setData(query, "Đổi mật khẩu thành công!");
                }
                else
                {
                    label5.Visible=true;
                }
            }
            else
            {
                label6.Visible = true;
            }
        }
    }

}
