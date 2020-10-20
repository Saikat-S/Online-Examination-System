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
    public partial class MCQExam : System.Web.UI.Page
    {
        static int count = 20;
        protected void Page_Load(object sender, EventArgs e)
        {
            ///Session["Timer"] = DateTime.Now;
            string ET = "";
            if (Session["_Course"] != null)
            {
                string crs = Session["_Course"].ToString();

                string CS = "your-database-connection-string";
                SqlConnection con = new SqlConnection(CS);
                con.Open();


                string newcon = "select  * from mcqQS where course='" + crs + "' and qsNo ='" + "1" + "'";

                SqlCommand cmd = new SqlCommand(newcon, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    qs1.Text = (dr["qs"].ToString());
                    RadioButtonList1.Items[0].Text = (dr["op1"].ToString());
                    RadioButtonList1.Items[1].Text = (dr["op2"].ToString());
                    RadioButtonList1.Items[2].Text = (dr["op3"].ToString());
                    RadioButtonList1.Items[3].Text = (dr["op4"].ToString());
                    Session["_qs1"] = (dr["qs"].ToString());
                    Session["_ans1"] = (dr["ans"].ToString());
                    Session["_tag1"] = (dr["tag"].ToString());
                }
                con.Close();

                con.Open();

                newcon = "select  * from mcqQS where course='" + crs + "' and qsNo ='" + "2" + "'";
                cmd = new SqlCommand(newcon, con);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    qs2.Text = (dr["qs"].ToString());
                    RadioButtonList2.Items[0].Text = (dr["op1"].ToString());
                    RadioButtonList2.Items[1].Text = (dr["op2"].ToString());
                    RadioButtonList2.Items[2].Text = (dr["op3"].ToString());
                    RadioButtonList2.Items[3].Text = (dr["op4"].ToString());
                    Session["_qs2"] = (dr["qs"].ToString());
                    Session["_ans2"] = (dr["ans"].ToString());
                    Session["_tag2"] = (dr["tag"].ToString());
                }

                con.Close();

                con.Open();

                newcon = "select  * from mcqQS where course='" + crs + "' and qsNo ='" + "3" + "'";
                cmd = new SqlCommand(newcon, con);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    qs3.Text = (dr["qs"].ToString());
                    RadioButtonList3.Items[0].Text = (dr["op1"].ToString());
                    RadioButtonList3.Items[1].Text = (dr["op2"].ToString());
                    RadioButtonList3.Items[2].Text = (dr["op3"].ToString());
                    RadioButtonList3.Items[3].Text = (dr["op4"].ToString());
                    Session["_qs3"] = (dr["qs"].ToString());
                    Session["_ans3"] = (dr["ans"].ToString());
                    Session["_tag3"] = (dr["tag"].ToString());
                }

                con.Close();


                con.Open();

                newcon = "select  * from mcqQS where course='" + crs + "' and qsNo ='" + "4" + "'";
                cmd = new SqlCommand(newcon, con);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    qs4.Text = (dr["qs"].ToString());
                    RadioButtonList4.Items[0].Text = (dr["op1"].ToString());
                    RadioButtonList4.Items[1].Text = (dr["op2"].ToString());
                    RadioButtonList4.Items[2].Text = (dr["op3"].ToString());
                    RadioButtonList4.Items[3].Text = (dr["op4"].ToString());
                    Session["_qs4"] = (dr["qs"].ToString());
                    Session["_ans4"] = (dr["ans"].ToString());
                    Session["_tag4"] = (dr["tag"].ToString());
                }

                con.Close();

                con.Open();

                newcon = "select  * from mcqQS where course='" + crs + "' and qsNo ='" + "5" + "'";
                cmd = new SqlCommand(newcon, con);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    qs5.Text = (dr["qs"].ToString());
                    RadioButtonList5.Items[0].Text = (dr["op1"].ToString());
                    RadioButtonList5.Items[1].Text = (dr["op2"].ToString());
                    RadioButtonList5.Items[2].Text = (dr["op3"].ToString());
                    RadioButtonList5.Items[3].Text = (dr["op4"].ToString());
                    Session["_ans5"] = (dr["ans"].ToString());
                    Session["_qs5"] = (dr["qs"].ToString());
                    Session["_tag5"] = (dr["tag"].ToString());
                    ET = (dr["eTime"].ToString());
                }

                con.Close();
            }
            else
            {
                Response.Write("<script>alert('You not select Exam!');</script>");
            }
            if (!IsPostBack)
            {
                int examTime = 1;

                int.TryParse(ET, out examTime);

                Session["Timer"] = DateTime.Now.AddMinutes(examTime).ToString();
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

        protected void submitB_Click(object sender, EventArgs e)
        {
            //int a = (int)Session["_qsN"];
            //Response.Write(a);
            //Session["_qsN"] = ((int)Session["_qsN"]) + 1;

            string a1 = Session["_ans1"].ToString();
            string a2 = Session["_ans2"].ToString();
            string a3 = Session["_ans3"].ToString();
            string a4 = Session["_ans4"].ToString();
            string a5 = Session["_ans5"].ToString();
            int mark = 0;

            if (RadioButtonList1.SelectedIndex > -1)
            {
                if (RadioButtonList1.SelectedItem.Text == a1)
                {
                    mark++;
                }
            }
            if (RadioButtonList2.SelectedIndex > -1)
            {
                if (RadioButtonList2.SelectedItem.Text == a2)
                {
                    mark++;
                }
            }
            if (RadioButtonList3.SelectedIndex > -1)
            {
                if (RadioButtonList3.SelectedItem.Text == a3)
                {
                    mark++;
                }
            }
            if (RadioButtonList4.SelectedIndex > -1)
            {
                if (RadioButtonList4.SelectedItem.Text == a4)
                {
                    mark++;
                }
            }
            if (RadioButtonList5.SelectedIndex > -1)
            {
                if (RadioButtonList5.SelectedItem.Text == a5)
                {
                    mark++;
                }
            }

            Session["_tMark"] = mark;

            string sNo = Session["_ID"].ToString();
            string crsNo = Session["_Course"].ToString();
            double M = mark;
            //string M = mark.ToString();

            string CS = "your-database-connection-string";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            string newcon = "insert into mcqTaken (studentID,courseID,examNo,mark) VALUES('" + sNo + "','" + crsNo + "', '" + "1" + "', '" + M + "')";

            SqlCommand cmd = new SqlCommand(newcon, con);
            cmd.ExecuteNonQuery();
            con.Close();

            Server.Transfer("ExamResult.aspx", true);

        }
        protected void logoutB_Click(object sender, EventArgs e)
        {
            Server.Transfer("LoginPage.aspx", true);
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            //Label3.Text = DateTime.Now.ToString("hh:mm:ss");

            if(DateTime.Compare(DateTime.Now, DateTime.Parse(Session["Timer"].ToString())) < 0)
            {
                Label3.Text = "Time Left : " + ((Int32)DateTime.Parse(Session["Timer"].ToString()).Subtract(DateTime.Now).TotalMinutes).ToString() + " Minute " + (((Int32)DateTime.Parse(Session["Timer"].ToString()).Subtract(DateTime.Now).TotalSeconds) % 60).ToString() + " Seconds";
            }
            else
            {
                //Server.Transfer("LoginPage.aspx", true);
                //Fun();
                Label3.Text = "Time Out!";
                //submit1B_Click(submit1B, null);
                //Response.Write("<script>alert('Time Finish!');</script>");
            }

               
            /*if (count > 0)
            {
                count = count - 1;
                Label3.Text = count.ToString();

            }
            else
            {
                Label3.Text = "Time's up!";
                //Timer1.Enabled = false;
                Response.Write("<script>alert('Time Finish!');</script>");
                Server.Transfer("Dashboard.aspx", true);
            }*/


            /*TimeSpan time1 = new TimeSpan();
            time1 = (DateTime)Session["time"] - DateTime.Now;
            if (time1.Seconds <= 0)
            {
                Label3.Text = "TimeOut!";
            }
            else
            {
                Label3.Text = time1.Seconds.ToString();
            }*/


        }

        //protected void Timer2_Tick(object sender, EventArgs e)
        //{
        //timerL.Text = System.DateTime.Now.ToString("hh:mm:ss");
        //}
    }
}
