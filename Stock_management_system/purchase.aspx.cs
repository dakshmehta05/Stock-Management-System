using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_management_system
{
    public partial class purchase : System.Web.UI.Page
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
            string t = "SELECT * from supplier WHERE sid= " + TextBox1.Text + "";
            da = new SqlDataAdapter(t, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                Label2.Text = "Invalid Supplier ID";
            }
            else
            {
                string s = "INSERT into purchase values (" + TextBox1.Text + ",'" + TextBox2.Text + "'," + TextBox3.Text + "," + TextBox4.Text + "," + Label1.Text + ")";
                cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();

                DataSet ds1 = new DataSet();
                string f="SELECT * from stock WHERE iname='" + TextBox2.Text + "'";
                da1=new SqlDataAdapter(f, con);
                da1.Fill(ds1);

                if (ds1.Tables[0].Rows.Count == 0)
                {
                    string n;
                    n = "INSERT into stock values ('" + TextBox2.Text + "', " + TextBox4.Text + ")";
                    cmd = new SqlCommand(n, con);
                    cmd.ExecuteNonQuery();
                }
                else 
                {
                    string n;
                    n = "UPDATE stock SET iqty = iqty + "+TextBox4.Text+ "WHERE iname = "+TextBox2.Text+"";
                    cmd=new SqlCommand(n, con);
                    cmd.ExecuteNonQuery();
                }


                Response.Write("<script> alert('Item Purchased')  </script> ");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
            
            }

            
        }
        
    }
}