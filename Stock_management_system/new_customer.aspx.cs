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
    public partial class new_customer : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=stock_management_system;Integrated Security=True;");
            con.Open();
            DataSet ds1 = new DataSet();
            string n;
            n = "SELECT * from customer ORDER by cid desc";
            da = new SqlDataAdapter(n, con);
            da.Fill(ds1);
            if (ds1.Tables[0].Rows.Count==0)
            {
                Label1.Text = "001";
            }
            else
            {
                Label1.Text= (Convert.ToInt32(ds1.Tables[0].Rows[0][0].ToString()) + 1).ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           string t="";
            if (RadioButton1.Checked)
            {
                t = RadioButton1.Text;
            }
            else if (RadioButton2.Checked)
            {
                t = RadioButton2.Text;
            }
            else if (RadioButton3.Checked)
            {
                t= RadioButton3.Text;
            }

            string f, p;
            f = FileUpload1.FileName;
            p = Server.MapPath("~/Images/" + f);
            FileUpload1.SaveAs(p);

            string s = "insert into customer values(" + Label1.Text + ",'" + TextBox2.Text + "','" + t + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "', '" + TextBox6.Text + "', '" + TextBox7.Text + "' , 'Images/"+f+"')";
            cmd=new SqlCommand(s, con);
            cmd.ExecuteNonQuery();

            string l = "INSERT INTO clogin values(" + Label1.Text + ", '" + TextBox8.Text + "')";
            cmd = new SqlCommand(l, con);
            cmd.ExecuteNonQuery();

            Response.Write("<script>  alert('Customer Added')   </script>");
            TextBox2.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;

           
        }
    }
}