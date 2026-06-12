using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_management_system
{
    public partial class sell : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da,da1;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=stock_management_system;Integrated Security=True;");
            con.Open();
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            int a, b, amt;
            a = Convert.ToInt32(TextBox3.Text.ToString());
            b = Convert.ToInt32(TextBox4.Text.ToString());
            amt = a * b;
            Label1.Text = amt.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string t="SELECT * from customer WHERE cid= "+TextBox1.Text+"";
            da = new SqlDataAdapter(t, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                Label2.Text = "Invalid Customer ID";
            }
            else
            { 
                DataSet ds1 = new DataSet();
                string n = "SELECT iqty FROM stock WHERE iname='" + TextBox2.Text + "'";
                da1=new SqlDataAdapter(n, con);
                da1.Fill(ds1);

                int a;
                a = Convert.ToInt32(ds1.Tables[0].Rows[0][0].ToString());

                if (a >= Convert.ToInt32(TextBox4.Text))
                {
                    string f = "UPDATE stock SET iqty = iqty - " + TextBox4.Text + " WHERE iname = '" + TextBox2.Text + "'";
                    cmd= new SqlCommand(f, con);
                    cmd.ExecuteNonQuery();

                    string s = "INSERT into sell values (" + TextBox1.Text + ",'" + TextBox2.Text + "'," + TextBox3.Text + "," + TextBox4.Text + ", " + Label1.Text + ")";
                    cmd = new SqlCommand(s, con);
                    cmd.ExecuteNonQuery();
                }

                Response.Write("<script> alert('Item Sold')  </script> ");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
            }
        }
        
    }
}