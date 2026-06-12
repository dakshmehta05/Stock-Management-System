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
    public partial class my_purchases : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataAdapter da;
        protected void Pagae_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=stock_management_system;Integrated Security=True;");
            con.Open();
            DataSet ds = new DataSet();
            Label1.Text= Session["id"].ToString();
            string s = "SELECT * from sell WHERE cid=" + Label1.Text + "";
            da=new SqlDataAdapter(s,con);
            da.Fill(ds);
            GridView1.DataSource=ds;
            GridView1.DataBind();

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}