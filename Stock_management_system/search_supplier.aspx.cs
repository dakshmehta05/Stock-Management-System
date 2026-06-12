using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_management_system
{
    public partial class search_supplier : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=stock_management_system;Integrated Security=True;");
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string s = "SELECT * from supplier where sid= " + TextBox1.Text + "";
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count == 0)
            {
                Label8.Text = "Invalid ID";
                TextBox1.Focus();
            }
            else
            {
                Label1.Text = ds.Tables[0].Rows[0][0].ToString();
                Label2.Text = ds.Tables[0].Rows[0][1].ToString();
                Label3.Text = ds.Tables[0].Rows[0][2].ToString();
                Label4.Text = ds.Tables[0].Rows[0][3].ToString();
                Label5.Text = ds.Tables[0].Rows[0][4].ToString();
                Label6.Text = ds.Tables[0].Rows[0][5].ToString();
                Label7.Text = ds.Tables[0].Rows[0][6].ToString();
            }
        }
    }
}