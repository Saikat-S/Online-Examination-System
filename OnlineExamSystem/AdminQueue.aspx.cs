using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExamSystem
{
    public partial class AdminCourseQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void homeB_Click(object sender, EventArgs e)
        {
            Server.Transfer("AdminPanel.aspx", true);
        }

        protected void profileB_Click(object sender, EventArgs e)
        {

        }

        protected void LeaderboardB_Click(object sender, EventArgs e)
        {
            Server.Transfer("AdminLeaderboard.aspx", true);
        }

        protected void logoutB_Click(object sender, EventArgs e)
        {
            Server.Transfer("LoginPage.aspx", true);
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView2.SelectedRow;
            Session["_crsID1"] = row.Cells[1].Text;

            Server.Transfer("AdminCourseQueue.aspx", true);
        }
    }
}