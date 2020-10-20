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
    public partial class ExamResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            markLabel.Text = Session["_tMark"].ToString();


            int num = (int)(Session["_tMark"]);

            int noOfExam, a=0;
            double totalMark, b=0.0;

            if (Session["_ID"] != null)
            {
                string ID = Session["_ID"].ToString();



                //try
                // {
                string CS = "your-database-connection-string";
                SqlConnection con = new SqlConnection(CS);
                con.Open();

                string newcon = "select * from userInfo where id='" + ID + "'";

                SqlCommand cmd = new SqlCommand(newcon, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    a = (int)(dr["no_of_exam"]);
                    b = (double)(dr["total_mark"]);
                    //Response.Write(a);
                    //Response.Write(b);

                    //noOfExam = ;

                }
                con.Close();
                //}
                // catch (Exception ex)
                // {
                //MessageBox.Show(ex.Message);
                //  }

                //Response.Write(a);
                //Response.Write(b);

                totalMark = b + (double)num;

                noOfExam = a + 1;

                //Response.Write(noOfExam);
                //Response.Write(totalMark);


                double Avg = totalMark / (double)noOfExam;

                string av = Avg.ToString();

                //try
                //{
                //CS = "your-database-connection-string";
                SqlConnection con1 = new SqlConnection(CS);
                con1.Open();

                string newcon1 = "update userInfo set no_of_exam='" + noOfExam + "', total_mark='" + totalMark + "', abc='" + av + "' where id='" + ID + "';";

                SqlCommand cmd1 = new SqlCommand(newcon1, con1);

                SqlDataReader dr1 = cmd1.ExecuteReader();

                con1.Close();
                // }
                //catch (Exception ex)
                // {
                //MessageBox.Show(ex.Message);
                //  }





                qs1.Text = Session["_qs1"].ToString();
                qs2.Text = Session["_qs2"].ToString();
                qs3.Text = Session["_qs3"].ToString();
                qs4.Text = Session["_qs4"].ToString();
                qs5.Text = Session["_qs5"].ToString();

                tag1.Text = "(" + Session["_tag1"].ToString() + ")";
                tag2.Text = "(" + Session["_tag2"].ToString() + ")";
                tag3.Text = "(" + Session["_tag3"].ToString() + ")";
                tag4.Text = "(" + Session["_tag4"].ToString() + ")";
                tag5.Text = "(" + Session["_tag5"].ToString() + ")";


                ans1.Text = Session["_ans1"].ToString();
                ans2.Text = Session["_ans2"].ToString();
                ans3.Text = Session["_ans3"].ToString();
                ans4.Text = Session["_ans4"].ToString();
                ans5.Text = Session["_ans5"].ToString();
            }
            else
            {
                Response.Write("<script>alert('You are not login!');</script>");
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
            Server.Transfer("Leaderboard.aspx", true);
        }

        protected void logoutB_Click(object sender, EventArgs e)
        {
            Server.Transfer("LoginPage.aspx", true);
        }
    }
}
