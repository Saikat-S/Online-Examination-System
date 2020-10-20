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
    public partial class UserProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["_ID"] != null)
            {
                string ID = Session["_ID"].ToString();
                string CS = "Data Source=DESKTOP-JT5TE1G\\SQLEXPRESS;Initial Catalog=OnlineExam;Persist Security Info=True;User ID=sa;Password=369@saikat";
                SqlConnection con = new SqlConnection(CS);
                con.Open();

                string newcon = "select  * from userInfo where id='" + ID + "'";

                SqlCommand cmd = new SqlCommand(newcon, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    NameTB.Text = (dr["name"].ToString());
                    idTB.Text = (dr["id"].ToString());
                    deptTB.Text = (dr["department"].ToString());
                    semesterTB.Text = (dr["semester"].ToString());
                    genderTB.Text = (dr["gender"].ToString());
                    emailTB.Text = (dr["email"].ToString());
                    fatherNameTB.Text = (dr["fatherName"].ToString());
                    hallTB.Text = (dr["hall"].ToString());
                }
                con.Close();

            }
            else
            {
                Response.Write("<script>alert('You are not login!');</script>");
                Server.Transfer("LoginPage.aspx", true);
            }
            //NameTB.Enabled = false;
            //deptTB.Enabled = false;
            //semesterTB.Enabled = false;
            //genderTB.Enabled = false;
            //emailTB.Enabled = false;
        }

        protected void homeB_Click(object sender, EventArgs e)
        {
            Server.Transfer("Dashboard.aspx", true);
        }

        protected void profileB_Click(object sender, EventArgs e)
        {
           // Server.Transfer("UserProfile.aspx", true);
        }

        protected void LeaderboardB_Click(object sender, EventArgs e)
        {
            Server.Transfer("Leaderboard.aspx", true);
        }

        protected void NameTB_TextChanged(object sender, EventArgs e)
        {

        }

        protected void logoutB_Click(object sender, EventArgs e)
        {
            Server.Transfer("LoginPage.aspx", true);
        }

        protected void coursesB_Click(object sender, EventArgs e)
        {
            Server.Transfer("TakenCourses.aspx", true);
        }
    }
}