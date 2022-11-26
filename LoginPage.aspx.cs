using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication4
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection scn = new SqlConnection
            {
                ConnectionString = "Data Source = kaushik\\sqlexpress;Initial Catalog=pharmacy;Integrated Security = True"
            };
            scn.Open();
            string qry = "delete from CurrUser;";
            SqlCommand cmd = new SqlCommand(qry, scn);
            cmd.ExecuteNonQuery();
            qry = "delete from Bill;";
            SqlCommand cmd1 = new SqlCommand(qry, scn);
            cmd1.ExecuteNonQuery();
            scn.Close();
        }

        protected void LoginBtn_click(object sender, EventArgs e)
        {
            bool result;
            string name = "";
            string cid = "";
            SqlConnection scn = new SqlConnection
            {
                ConnectionString = "Data Source = kaushik\\sqlexpress;Initial Catalog=pharmacy;Integrated Security = True"
            };
            string uid = TextBox1.Text;
            string passwd = TextBox2.Text;
            scn.Open();
            string qury = "select * from Customer where cust_uname = @uname and cust_pass = @passwd";
            SqlCommand cmd = new SqlCommand(qury, scn);
            cmd.Parameters.AddWithValue("uname", uid.Trim());
            cmd.Parameters.AddWithValue("passwd", passwd.Trim());
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            if (result == true)
            {
                TextBox3.Text = "Success";
                sdr.Read();
                name = (string)sdr.GetValue(1);
                cid = sdr.GetValue(0).ToString();
                sdr.Close();
                TextBox3.Text = "Welcome, " + name;
                qury = "insert into CurrUser values(@id, @nm);";
                SqlCommand cmd1 = new SqlCommand(qury, scn);
                cmd1.Parameters.AddWithValue("id", cid.Trim());
                cmd1.Parameters.AddWithValue("nm", name.Trim());
                _ = cmd1.ExecuteReader();
                if (name == "Kaushik Balaji" || name == "Karthick Raja")
                {
                    Session["role"] = "admin";
                    Session["name"] = name;
                    Response.Redirect("AdminPage.aspx");
                }
                else
                {
                    Response.Redirect("SearchPage.aspx");
                }
            }
            else
            {
                TextBox3.Text = "Failed";
                scn.Close();
            }
            scn.Close();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}