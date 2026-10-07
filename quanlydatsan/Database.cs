using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace quanlydatsan
{
    internal class Database
    {
        private string connection = @"Data Source=DESKTOP-71ROIT7\SQLEXPRESS;Initial Catalog=Quanlydatsanthethao;Integrated Security=True";

        public DataTable ReadData(string sql)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return dt;
        }

        public int WriteData(string sql) 
        {

            int rowEffect = -1;
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    rowEffect = cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            return rowEffect;
        }
    }
}
