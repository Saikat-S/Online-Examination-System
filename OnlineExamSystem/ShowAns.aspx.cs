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
    public partial class ShowAns : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["_stID"] != null && Session["_crsID"] != null)
            {
                string sID = Session["_stID"].ToString();
                string cID = Session["_crsID"].ToString();


                string CS = "your-database-connection-string";
                SqlConnection con = new SqlConnection(CS);
                con.Open();


                string newcon = "select  * from theoryAns where studentID='" + sID + "' and courseID ='" + cID + "' and qsNo='" + "1" + "'";

                SqlCommand cmd = new SqlCommand(newcon, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    qs1A.Text = (dr["qsA"].ToString());
                    m1A.Text = (dr["markA"].ToString());
                    ans1ATB.Text = (dr["ansA"].ToString());
                    qs1B.Text = (dr["qsB"].ToString());
                    m1B.Text = (dr["markB"].ToString());
                    ans1BTB.Text = (dr["ansB"].ToString());
                }
                con.Close();

                //x++;
                // xx = x;
                // CR = crs + xx.ToString();

                con.Open();

                newcon = "select  * from theoryAns where studentID='" + sID + "' and courseID ='" + cID + "' and qsNo='" + "2" + "'";
                cmd = new SqlCommand(newcon, con);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    qs2A.Text = (dr["qsA"].ToString());
                    m2A.Text = (dr["markA"].ToString());
                    ans2ATB.Text = (dr["ansA"].ToString());
                    qs2B.Text = (dr["qsB"].ToString());
                    m2B.Text = (dr["markB"].ToString());
                    ans2BTB.Text = (dr["ansB"].ToString());
                }

                con.Close();

                con.Open();

                newcon = "select  * from theoryAns where studentID='" + sID + "' and courseID ='" + cID + "' and qsNo='" + "3" + "'";
                cmd = new SqlCommand(newcon, con);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    qs3A.Text = (dr["qsA"].ToString());
                    m3A.Text = (dr["markA"].ToString());
                    ans3ATB.Text = (dr["ansA"].ToString());
                    qs3B.Text = (dr["qsB"].ToString());
                    m3B.Text = (dr["markB"].ToString());
                    ans3BTB.Text = (dr["ansB"].ToString());
                }

                con.Close();

                con.Open();

                newcon = "select  * from theoryAns where studentID='" + sID + "' and courseID ='" + cID + "' and qsNo='" + "4" + "'";
                cmd = new SqlCommand(newcon, con);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    qs4A.Text = (dr["qsA"].ToString());
                    m4A.Text = (dr["markA"].ToString());
                    ans4ATB.Text = (dr["ansA"].ToString());
                    qs4B.Text = (dr["qsB"].ToString());
                    m4B.Text = (dr["markB"].ToString());
                    ans4BTB.Text = (dr["ansB"].ToString());
                }

                con.Close();

                con.Open();

                newcon = "select  * from theoryAns where studentID='" + sID + "' and courseID ='" + cID + "' and qsNo='" + "5" + "'";
                cmd = new SqlCommand(newcon, con);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    qs5A.Text = (dr["qsA"].ToString());
                    m5A.Text = (dr["markA"].ToString());
                    ans5ATB.Text = (dr["ansA"].ToString());
                    qs5B.Text = (dr["qsB"].ToString());
                    m5B.Text = (dr["markB"].ToString());
                    ans5BTB.Text = (dr["ansB"].ToString());
                }

                con.Close();



                //Response.Write(a);
                //Response.Write("\n");
                //Response.Write(b);
            }
            else
            {
                Response.Write("<script>alert('Some problem to find your data');</script>");
                Server.Transfer("AdminPanel.aspx", true);
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

        protected void submitB_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0, d = 0, ee = 0;
            int a1 = 0, b1 = 0, c1 = 0, d1 = 0, ee1 = 0;
            int.TryParse(mark1A.Text, out a);
            int.TryParse(mark2A.Text, out b);
            int.TryParse(mark3A.Text, out c);
            int.TryParse(mark4A.Text, out d);
            int.TryParse(mark5A.Text, out ee);


            int.TryParse(mark1B.Text, out a1);
            int.TryParse(mark2B.Text, out b1);
            int.TryParse(mark3B.Text, out c1);
            int.TryParse(mark4B.Text, out d1);
            int.TryParse(mark5B.Text, out ee1);

            double total = a + b + c + d + ee;
            total = a1 + b1 + c1 + d1 + ee1;


           /* string CS = "Data Source=DESKTOP-JT5TE1G\\SQLEXPRESS;Initial Catalog=OnlineExam;Persist Security Info=True;User ID=sa;Password=369@saikat";
            SqlConnection con = new SqlConnection(CS);
            con.Open();

            string newcon = "select * from userInfo where id='" + ID + "'";

            SqlCommand cmd = new SqlCommand(newcon, con);
            SqlDataReader dr = cmd.ExecuteReader();
            int a = 0;
            if (dr.Read())
            {
                a = (int)(dr["no_of_exam"]);
                b = (double)(dr["total_mark"]);
                //Response.Write(a);
                //Response.Write(b);

                //noOfExam = ;

            }
            con.Close();
   

            totalMark = b + (double)num;

            noOfExam = a + 1;


            double Avg = totalMark / (double)noOfExam;

            string av = Avg.ToString();

            SqlConnection con1 = new SqlConnection(CS);
            con1.Open();

            string newcon1 = "update userInfo set no_of_exam='" + noOfExam + "', total_mark='" + totalMark + "', abc='" + av + "' where id='" + ID + "';";

            SqlCommand cmd1 = new SqlCommand(newcon1, con1);

            SqlDataReader dr1 = cmd1.ExecuteReader();

            con1.Close();
            */

            //Response.Write(total);

            string sID = Session["_stID"].ToString();
            string cID = Session["_crsID"].ToString();

            // update student theory course mark
            string CS = "your-database-connection-string";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            string newcon = "update theoryAns set mark='" + total + "', isAprove='" + "Yes" + "' where studentID='" + sID + "' and courseID='" + cID + "';";
            SqlCommand cmd = new SqlCommand(newcon, con);
            SqlDataReader dr = cmd.ExecuteReader();
            con.Close();

            // detele the student id from theoryCourseQueue
            SqlConnection con1 = new SqlConnection(CS);
            con1.Open();
            string newcon1 = "delete from theoryCourseQueue where student_ID='" + sID + "' and courseID='" + cID + "';";
            SqlCommand cmd1 = new SqlCommand(newcon1, con1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            con1.Close();

            /*
            // check for admin queue is empty or not
            con.Open();
            newcon = "select * from theoryQueue where courseID ='" + cID + "'";
            cmd = new SqlCommand(newcon, con);
            dr = cmd.ExecuteReader();
            string sCnt="0";
            if (dr.Read())
            {
                sCnt = (dr["count"].ToString());
            }
            con.Close();

            int cnt = 0;
            int.TryParse(sCnt, out cnt);

            cnt = cnt - 1;

            if(cnt <= 0)
            {
                // delete the cID row from admin queue
                con.Open();
                newcon = "delete from theoryQueue where courseID='" + cID + "';";
                cmd = new SqlCommand(newcon, con);
                dr = cmd1.ExecuteReader();
                con.Close();
            }
            else
            {
                // update admin queue count values
                newcon = "update theoryQueue set count='" + cnt + "' where courseID='" + cID + "';";
                cmd = new SqlCommand(newcon, con);
                dr = cmd.ExecuteReader();
                con.Close();
            }
            */
            Response.Write("<script>alert('Mark Submitted!');</script>");
            Session["_checkCID"] = cID;
            Server.Transfer("AdminCourseQueue.aspx", true);

        }

        protected void logoutB_Click(object sender, EventArgs e)
        {
            Server.Transfer("LoginPage.aspx", true);
        }
    }
}
