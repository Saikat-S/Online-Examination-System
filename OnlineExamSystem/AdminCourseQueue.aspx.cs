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
    public partial class AdminQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["_crsID1"] != null)
            {
                string crsID = Session["_crsID1"].ToString();

            }
            else
            {
                Response.Write("<script>alert('Some problem to find your data!');</script>");
            }

            if(Session["_checkCID"] != null)
            {
                string CID = Session["_checkCID"].ToString();

                // check admin queue course in empty or not
                string CS = "your-database-connection-string";
                SqlConnection con = new SqlConnection(CS);
                con.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from theoryCourseQueue where courseID ='" + CID + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();

                string str = dt.Rows[0][0].ToString();

                int num;
                int.TryParse(str, out num);
                if (num >= 1)
                {
                   // CID course is not empty in adminQueue database
                }
                else
                {
                    SqlConnection con1 = new SqlConnection(CS);
                    con1.Open();
                    string newcon1 = "delete from theoryQueue where courseID='" + CID + "';";
                    SqlCommand cmd1 = new SqlCommand(newcon1, con1);
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    con1.Close();
                }

            }

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
            Server.Transfer("AdminLeaderboard.aspx", true);
        }

        protected void logoutB_Click(object sender, EventArgs e)
        {
            Server.Transfer("LoginPage.aspx", true);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Get the currently selected row using the SelectedRow property.
            GridViewRow row = GridView1.SelectedRow;
            Session["_stID"] = row.Cells[1].Text;
            Session["_crsID"] = row.Cells[2].Text;

            Server.Transfer("ShowAns.aspx", true);
        }
    }
}
