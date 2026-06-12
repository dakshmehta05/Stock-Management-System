using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_management_system
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con= new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=stock_management_system;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter da,da1,da2;
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds= new DataSet();
            string s = "SELECT * from alogin where id="+TextBox1.Text+"";
            da=new SqlDataAdapter(s,con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count==0)
            {
                DataSet ds1= new DataSet(); 
                string c="SELECT * from clogin where id="+TextBox1.Text+"";
                da1=new SqlDataAdapter(c,con);
                da1.Fill(ds1);
                if (ds1.Tables[0].Rows.Count==0)
                {
                    DataSet ds2=new DataSet();
                    string t = "SELECT * from slogin where id=" + TextBox1.Text + "";
                    da2=new SqlDataAdapter(t,con);
                    da2.Fill(ds2);
                    if (ds2.Tables[0].Rows.Count==0)
                    {
                        Response.Write("Invalid ID or Password");
                    }
                    else if (ds2.Tables[0].Rows[0][1].ToString() == TextBox2.Text)
                    {
                        Session["id"] = TextBox1.Text;
                        Response.Redirect("home_supplier.aspx");
                        
                    }
                    else
                    {
                        Response.Write("<script>  alert('Invalid ID or Password')  </script>");
                    }
                }
                else if (ds1.Tables[0].Rows[0][1].ToString() == TextBox2.Text)
                {
                    Session["id"] = TextBox1.Text;
                    Response.Redirect("home_customer.aspx");
                    
                }
                else
                {
                    Response.Write("<script> alert('Invalid ID or Password') </script>");
                }
            }
            else if (ds.Tables[0].Rows[0][1].ToString() == TextBox2.Text)
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                Response.Write("<script> alert('Invalid ID or Password') </script>");
            }
        }
    }
}