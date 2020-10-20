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
    public partial class SetExam1 : System.Web.UI.Page
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
        protected void theoryB_Click(object sender, EventArgs e)
        {
            //Session["_qsN"] = 1;
            Server.Transfer("TheorySet.aspx", true);
        }

        protected void mcqB_Click(object sender, EventArgs e)
        {
            //Session["_qsN"] = 1;
            Server.Transfer("MCQSet.aspx", true);
        }

        protected void logoutB_Click(object sender, EventArgs e)
        {
            Server.Transfer("LoginPage.aspx", true);
        }
    }
}