using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExamSystem
{
    public partial class MCQExam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void homeB_Click(object sender, EventArgs e)
        {
            Server.Transfer("Dashboard.aspx", true);
        }

        protected void profileB_Click(object sender, EventArgs e)
        {
            Server.Transfer("UserProfile.aspx", true);
        }

        protected void editProfileB_Click(object sender, EventArgs e)
        {

        }

        protected void submitB_Click(object sender, EventArgs e)
        {

        }

        protected void logoutB_Click(object sender, EventArgs e)
        {
            Server.Transfer("LoginPage.aspx", true);
        }
    }
}