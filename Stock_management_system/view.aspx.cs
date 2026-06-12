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
    public partial class view : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da1,da2;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=stock_management_system;Integrated Security=True;");
            con.Open();
        }
        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            string s = "SELECT * from purchase";
            da1 = new SqlDataAdapter(s, con);
            da1.Fill(ds1);
            GridView1.DataSource = ds1;
            GridView1.DataBind();

            s = "Select sum(iamt) from purchase";
            DataSet ds2 = new DataSet();
            da2= new SqlDataAdapter(s, con);    
            da2.Fill(ds2);
            int sum = Convert.ToInt32(ds2.Tables[0].Rows[0][0].ToString());
            Label1.Text=sum.ToString();
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            string t = "SELECT * from sell";
            da1 = new SqlDataAdapter(t, con);
            da1.Fill(ds1);  
            GridView1.DataSource = ds1;
            GridView1.DataBind();

            t = "Select sum(iamt) from sell";
            DataSet ds2=new DataSet();
            da2=new SqlDataAdapter(t, con);
            da2.Fill(ds2);
            int sum = Convert.ToInt32(ds2.Tables[0].Rows[0][0].ToString());
            Label1.Text = sum.ToString();
        }
    }
}