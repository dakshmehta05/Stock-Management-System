using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Stock_management_system
{
    public partial class my_sell : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=stock_management_system;Integrated Security=True;");
            con.Open();

            DataSet ds=new DataSet();
            Label1.Text = Session["id"].ToString();
            string s = "SELECT * FROM purchase WHERE sid=" + Label1.Text + "";
            da=new SqlDataAdapter(s,con);
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}