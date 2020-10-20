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
    public partial class Leaderboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["_ID"] != null)
            {
                string ID = Session["_ID"].ToString();
                string CS = "your-database-connection-string";
                SqlConnection con = new SqlConnection(CS);
                con.Open();

                string newcon = "select  * from userInfo where id='" + ID + "'";

                SqlCommand cmd = new SqlCommand(newcon, con);
                SqlDataReader dr = cmd.ExecuteReader();

                string year = "";

                if (dr.Read())
                {
                    year = (dr["semester"].ToString());
                }
                con.Close();

                Session["_Year"] = year;

            }
            else
            {
                Response.Write("<script>alert('You are not login!');</script>");
                Server.Transfer("LoginPage.aspx", true);
            }
        }

        protected void homeB_Click(object sender, EventArgs e)
        {
            Server.Transfer("Dashboard.aspx", true);
        }

        protected void profileB_Click(object sender, EventArgs e)
        {
            Server.Transfer("UserProfile.aspx", true);
        }

        protected void LeaderboardB_Click(object sender, EventArgs e)
        {

        }

        protected void logoutB_Click(object sender, EventArgs e)
        {
            Session["_ID"] = "not";
            Server.Transfer("LoginPage.aspx", true);
        }
    }
}
