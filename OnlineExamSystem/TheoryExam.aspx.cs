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
    public partial class TheoryExam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ET ="";
            if (Session["_ID"].ToString() == null)
            {
                Response.Write("<script>alert('You are not Login Please Login First!');</script>");
                Server.Transfer("LoginPage.aspx", true);
            }
            else
            {
                //RadioButtonList1.Items[0].Text = "Hello Radio Buttoin";
                string crs = Session["_Course"].ToString();
                int qN = (int)Session["_qNo"];
                int qsNumber = qN;
                string QN = qsNumber.ToString();

                //Response.Write(QN);

                string CS = "your-database-connection-string";
                SqlConnection con = new SqlConnection(CS);
                con.Open();
                string newcon = "select  * from theoryQS where course='" + crs + "' and qsNo ='" + QN + "'";

                SqlCommand cmd = new SqlCommand(newcon, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    qs1A.Text = (dr["qsA"].ToString());
                    qs1B.Text = (dr["qsB"].ToString());
                    m1A.Text = (dr["markA"].ToString());
                    m1B.Text = (dr["markB"].ToString());
                    ET = (dr["eTime"].ToString());
                }
                con.Close();

                qN = qN + 1;
                qsNumber = qN;
                QN = qsNumber.ToString();

                con.Open();
                newcon = "select  * from theoryQS where course='" + crs + "' and qsNo ='" + QN + "'";
                cmd = new SqlCommand(newcon, con);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    qs2A.Text = (dr["qsA"].ToString());
                    qs2B.Text = (dr["qsB"].ToString());
                    m2A.Text = (dr["markA"].ToString());
                    m2B.Text = (dr["markB"].ToString());        
                }
                con.Close();

                qN = qN + 1;
                qsNumber = qN;
                QN = qsNumber.ToString();

                con.Open();
                newcon = "select  * from theoryQS where course='" + crs + "' and qsNo ='" + QN + "'";
                cmd = new SqlCommand(newcon, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    qs3A.Text = (dr["qsA"].ToString());
                    qs3B.Text = (dr["qsB"].ToString());
                    m3A.Text = (dr["markA"].ToString());
                    m3B.Text = (dr["markB"].ToString());                    
                }
                con.Close();

                qN = qN + 1;
                qsNumber = qN;
                QN = qsNumber.ToString();

                con.Open();
                newcon = "select  * from theoryQS where course='" + crs + "' and qsNo ='" + QN + "'";
                cmd = new SqlCommand(newcon, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    qs4A.Text = (dr["qsA"].ToString());
                    qs4B.Text = (dr["qsB"].ToString());
                    m4A.Text = (dr["markA"].ToString());
                    m4B.Text = (dr["markB"].ToString());
                }
                con.Close();

                qN = qN + 1;
                qsNumber = qN;
                QN = qsNumber.ToString();

                con.Open();
                newcon = "select  * from theoryQS where course='" + crs + "' and qsNo ='" + QN + "'";
                cmd = new SqlCommand(newcon, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    qs5A.Text = (dr["qsA"].ToString());
                    qs5B.Text = (dr["qsB"].ToString());
                    m5A.Text = (dr["markA"].ToString());
                    m5B.Text = (dr["markB"].ToString());
                }
                con.Close();

                if (!IsPostBack)
                {
                    //Response.Write(ET);
                    int examTime;
                    int.TryParse(ET, out examTime);

                    Session["Timer"] = DateTime.Now.AddMinutes(examTime).ToString();
                }

            }
        }

        protected string getCourseName(string courseID)
        {
            string cName = "Course Name";

            if(courseID == "CSE-1101")
            {
                cName = "Computer Basics & Programming Fundamentals";
            }
            else if(courseID == "CSE-1201")
            {
                cName = "Electronic Devices and Circuits";
            }
            else if (courseID == "CSE-2101")
            {
                cName = "Object Oriented Programming";
            }
            else if (courseID == "CSE-2201")
            {
                cName = "Algorithm Design & Analysis";
            }
            else if (courseID == "CSE-3101")
            {
                cName = "Operating System";
            }
            else if (courseID == "CSE-3201")
            {
                cName = "Compiler Design";
            }
            else if (courseID == "CSE-4101")
            {
                cName = "Artificial Intelligence & ExpertSystem";
            }
            else if (courseID == "CSE-4201")
            {
                cName = "Computer Graphics & Animation";
            }

            return cName;
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

            // store the answersheet in database store

            string stID = Session["_ID"].ToString();
            string crsID = Session["_Course"].ToString();

                string CS = "your-database-connection-string";

                SqlConnection con = new SqlConnection(CS);
                con.Open();
                string newcon = "insert into theoryAns (studentID,courseID,qsNo,qsA,ansA,markA,isAprove,qsB,markB,ansB) VALUES('" + stID + "', '" + crsID + "', '" + "1" + "', '" + qs1A.Text + "', '" + ans1ATB.Text + "', '" + m1A.Text + "','" + "No" + "', '" + qs1B.Text + "', '" + m1B.Text + "' ,'" + ans1BTB.Text + "')";

                SqlCommand cmd = new SqlCommand(newcon, con);
                cmd.ExecuteNonQuery();
                con.Close();


                con.Open();
                newcon = "insert into theoryAns (studentID,courseID,qsNo,qsA,ansA,markA,isAprove,qsB,markB,ansB) VALUES('" + stID + "', '" + crsID + "', '" + "2" + "', '" + qs2A.Text + "', '" + ans2ATB.Text + "', '" + m2A.Text + "','" + "No" + "', '" + qs2B.Text + "', '" + m2B.Text + "' ,'" + ans2BTB.Text + "')";

                cmd = new SqlCommand(newcon, con);
                cmd.ExecuteNonQuery();
                con.Close();


                con.Open();
                newcon = "insert into theoryAns (studentID,courseID,qsNo,qsA,ansA,markA,isAprove,qsB,markB,ansB) VALUES('" + stID + "', '" + crsID + "', '" + "3" + "', '" + qs3A.Text + "', '" + ans3ATB.Text + "', '" + m3A.Text + "','" + "No" + "', '" + qs3B.Text + "', '" + m3B.Text + "' ,'" + ans3BTB.Text + "')";

                cmd = new SqlCommand(newcon, con);
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                newcon = "insert into theoryAns (studentID,courseID,qsNo,qsA,ansA,markA,isAprove,qsB,markB,ansB) VALUES('" + stID + "', '" + crsID + "', '" + "4" + "', '" + qs4A.Text + "', '" + ans4ATB.Text + "', '" + m4A.Text + "','" + "No" + "', '" + qs4B.Text + "', '" + m4B.Text + "' ,'" + ans4BTB.Text + "')";

                cmd = new SqlCommand(newcon, con);
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                newcon = "insert into theoryAns (studentID,courseID,qsNo,qsA,ansA,markA,isAprove,qsB,markB,ansB) VALUES('" + stID + "', '" + crsID + "', '" + "5" + "', '" + qs5A.Text + "', '" + ans5ATB.Text + "', '" + m5A.Text + "','" + "No" + "', '" + qs5B.Text + "', '" + m5B.Text + "' ,'" + ans5BTB.Text + "')";

                cmd = new SqlCommand(newcon, con);
                cmd.ExecuteNonQuery();
                con.Close();

                // insert data in theory course queue database
                con.Open();
                newcon = "insert into theoryCourseQueue (student_ID,courseID) VALUES('" + stID + "', '" + crsID + "')";

                cmd = new SqlCommand(newcon, con);
                cmd.ExecuteNonQuery();
                con.Close();


                // insert the data in admin queue database 
                string courseNAME = getCourseName(crsID);
                con.Open();
                newcon = "insert into theoryQueue (courseID, courseName) VALUES('" + crsID + "', '" + courseNAME + "')";
                cmd = new SqlCommand(newcon, con);
                cmd.ExecuteNonQuery();
                con.Close();


            // increase the count value in admin queue

            /*
            // check for admin queue is empty or not
            con = new SqlConnection(CS);
            con.Open();
            cmd = new SqlCommand("select count(*) from theoryQueue where courseID ='" + crsID + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();

            string str = dt.Rows[0][0].ToString();

            int cnt;
            int.TryParse(str, out cnt);

            cnt = cnt + 1;

            // insert the data in admin queue database 
            con.Open();
            newcon = "insert into theoryQueue (courseID, courseName,count) VALUES('" + crsID + "', '"+ courseNAME + "', '" + cnt.ToString() + "')";
            cmd = new SqlCommand(newcon, con);
            cmd.ExecuteNonQuery();
            con.Close();
            */
            
            // insert taken course database
            string sNo = Session["_ID"].ToString();
            string crsNo = Session["_Course"].ToString();
            string eN = "1";  // it need update

            CS = "your-database-connection-string";
            con = new SqlConnection(CS);
            con.Open();
            newcon = "insert into theoryTaken (studentID,courseID,examNo) VALUES('" + sNo + "','" + crsNo + "', '" + eN + "')";
            cmd = new SqlCommand(newcon, con);
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Write("<script>alert('Your Answer Sheet Submited!');</script>");
            Server.Transfer("Dashboard.aspx", true);

        }

        protected void logoutB_Click(object sender, EventArgs e)
        {
            Server.Transfer("LoginPage.aspx", true);
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Compare(DateTime.Now, DateTime.Parse(Session["Timer"].ToString())) < 0)
            {
                Label3.Text = "Time Left : " + ((Int32)DateTime.Parse(Session["Timer"].ToString()).Subtract(DateTime.Now).TotalMinutes).ToString() + " Minute " + (((Int32)DateTime.Parse(Session["Timer"].ToString()).Subtract(DateTime.Now).TotalSeconds) % 60).ToString() + " Seconds";
            }
            else
            {
                Label3.Text = "Time Out!";
                //UpdatePanel1.Enabled = false;
                //Response.Write("<script>alert('Time Finish!');</script>");
            }
        }
    }
}
