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
    public partial class changepass_supplier : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=stock_management_system;Integrated Security=True;");
            con.Open();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            DataSet ds= new DataSet();
            string s = "SELECT * FROM slogin WHERE sid=" + Session["id"].ToString() + "";
            da=new SqlDataAdapter(s,con);
            da.Fill(ds);
            if (ds.Tables[0].Rows[0][1].ToString() == TextBox1.Text)
            {
                Label1.Text = "Correct Password";
            }
            else
            {
                Label1.Text = "Incorrect Password";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string s = "SELECT * FROM login WHERE sid=" + Session["id"].ToString() + "";
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);
            if(TextBox2.Text == TextBox3.Text)
            {
                string t = "UPDATE slogin SET pass = " + TextBox3.Text + " WHERE id= " + Session["id"].ToString() + "";
                cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery ();
                Response.Write("<script> alert('Password Changed') </script>");
            }
            else
            {
                Label2.Text = "Passwords didn't matched";
            }
        }
    }
}