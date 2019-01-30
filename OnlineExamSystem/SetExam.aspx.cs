using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

        }
        protected void theoryB_Click(object sender, EventArgs e)
        {
            Server.Transfer("TheorySet.aspx", true);
        }

        protected void mcqB_Click(object sender, EventArgs e)
        {
            Server.Transfer("MCQSet.aspx", true);
        }

        protected void logoutB_Click(object sender, EventArgs e)
        {

        }
    }
}