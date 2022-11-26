using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PharmacyProject
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection scn = new SqlConnection
            {
                ConnectionString = "Data Source = kaushik\\sqlexpress;Initial Catalog=pharmacy;Integrated Security = True"
            };
            scn.Open();
            string qry = "select * from CurrUser";
            SqlCommand cmd = new SqlCommand(qry, scn);
            SqlDataReader sdr1 = cmd.ExecuteReader();
            sdr1.Read();
            string name = (string)sdr1.GetValue(1);
            sdr1.Close();
            TextBox1.Text = name;
            scn.Close();
        }

        protected void LogoutClick(object sender, EventArgs e)
        {
            SqlConnection scn = new SqlConnection("Data Source = kaushik\\sqlexpress; Initial Catalog = pharmacy; Integrated Security = True");
            String qry = "delete from CurrUser;";
            scn.Open();
            SqlCommand cmd = new SqlCommand(qry, scn);
            cmd.ExecuteNonQuery();
            scn.Close();
            Response.Redirect("LoginPage.aspx");
        }


        protected void InsertMed(object sender, EventArgs e)
        {
            SqlConnection scon = new SqlConnection
            {
                ConnectionString = "Data Source = kaushik\\sqlexpress; Initial Catalog = pharmacy; Integrated Security = True"
            };
            scon.Open();
            string qry = "select * from CurrUser";
            SqlCommand cmd = new SqlCommand(qry, scon);
            SqlDataReader sdr1 = cmd.ExecuteReader();
            sdr1.Read();
            string name = (string)sdr1.GetValue(1);
            sdr1.Close();
            /*  
            
            //Code to dalete the details in the cache table

            qry = "delete from CurrUser where uname = @name";
            cmd = new SqlCommand(qry, scon);
            cmd.Parameters.AddWithValue("name", name.Trim());
            sdr1 = cmd.ExecuteReader();
            sdr1.Close();
            */
            Response.Redirect("InsertPage.aspx");
        }
    }
}