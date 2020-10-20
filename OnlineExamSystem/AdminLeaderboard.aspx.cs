using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace OnlineExamSystem
{
    public partial class AdminLeaderboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (!IsPostBack)
            {
                string CS = "your-database-connection-string";
                SqlConnection con = new SqlConnection(CS);
                con.Open();

                string newcon = "select  id, name, abc from userInfo";

                SqlCommand cmd = new SqlCommand(newcon, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                GridView2.DataSource = dt;
                GridView2.DataBind();
                dt.Dispose();
                con.Close();
            }
            */
        }

        protected void homeB_Click(object sender, EventArgs e)
        {
            Server.Transfer("AdminPanel.aspx", true);
        }

        protected void profileB_Click(object sender, EventArgs e)
        {
            Server.Transfer("AdminQueue.aspx", true);
        }

        protected void LeaderboardB_Click(object sender, EventArgs e)
        {

        }
        protected void searchB_Click(object sender, EventArgs e)
        {
            /*
            // search in database
            string CS = "your-database-connection-string";
            SqlConnection con = new SqlConnection(CS);
            con.Open();

            string newcon = "select  id, name, abc from userInfo where semester='" + semesterDropDownList.Text + "'";

            SqlCommand cmd = new SqlCommand(newcon, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            dt.Dispose();
            con.Close();
            */
            Session["_Year1"] = semesterDropDownList.Text;
        }

        protected void logoutB_Click(object sender, EventArgs e)
        {
            Server.Transfer("LoginPage.aspx", true);
        }
    }
}
