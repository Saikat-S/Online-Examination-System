using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExamSystem
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void homeB_Click(object sender, EventArgs e)
        {

        }

        protected void profileB_Click(object sender, EventArgs e)
        {
            Server.Transfer("UserProfile.aspx", true);
        }

        protected void LeaderboardB_Click(object sender, EventArgs e)
        {
            Server.Transfer("Leaderboard.aspx", true);
        }

        protected void sExamB_Click(object sender, EventArgs e)
        {
            Server.Transfer("StartExam.aspx", true);
        }

        protected void logoutB_Click(object sender, EventArgs e)
        {
            Server.Transfer("LoginPage.aspx", true);
        }
    }
}