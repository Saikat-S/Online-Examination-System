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
    public partial class StartExam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["_ID"] != null)
            {
                if (!IsPostBack)
                {
                    string year = "";
                    string ID = Session["_ID"].ToString();
                    string CS = "your-database-connection-string";
                    SqlConnection con = new SqlConnection(CS);
                    con.Open();

                    string newcon = "select  * from userInfo where id='" + ID + "'";

                    SqlCommand cmd = new SqlCommand(newcon, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        year = (dr["semester"].ToString());
                    }
                    con.Close();


                    SelectCourseDropDownList.Items.Clear();
                    if (year == "1st Year 1st Semseter")
                    {
                        //Response.Write("hello");
                        List<ListItem> items = new List<ListItem>();
                        items.Add(new ListItem("CSE-1101", "CSE-1101"));
                        items.Add(new ListItem("CSE-1102", "CSE-1102"));
                        items.Add(new ListItem("CSE-1103", "CSE-1103"));
                        items.Add(new ListItem("CSE-1104", "CSE-1104"));
                        items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                        SelectCourseDropDownList.Items.AddRange(items.ToArray());
                    }
                    else if (year == "1st Year 2nd Semseter")
                    {
                        List<ListItem> items = new List<ListItem>();
                        items.Add(new ListItem("CSE-1201", "CSE-1201"));
                        items.Add(new ListItem("CSE-1202", "CSE-1202"));
                        items.Add(new ListItem("CSE-1203", "CSE-1203"));
                        items.Add(new ListItem("CSE-1204", "CSE-1204"));
                        items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                        SelectCourseDropDownList.Items.AddRange(items.ToArray());
                    }
                    else if (year == "2nd Year 1st Semseter")
                    {
                        List<ListItem> items = new List<ListItem>();
                        items.Add(new ListItem("CSE-2101", "CSE-2101"));
                        items.Add(new ListItem("CSE-2102", "CSE-2102"));
                        items.Add(new ListItem("CSE-2103", "CSE-2103"));
                        items.Add(new ListItem("CSE-2104", "CSE-2104"));
                        items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                        SelectCourseDropDownList.Items.AddRange(items.ToArray());
                    }
                    else if (year == "2nd Year 2nd Semseter")
                    {
                        List<ListItem> items = new List<ListItem>();
                        items.Add(new ListItem("CSE-2201", "CSE-2201"));
                        items.Add(new ListItem("CSE-2202", "CSE-2202"));
                        items.Add(new ListItem("CSE-2203", "CSE-2203"));
                        items.Add(new ListItem("CSE-2204", "CSE-2204"));
                        items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                        SelectCourseDropDownList.Items.AddRange(items.ToArray());
                    }
                    else if (year == "3rd Year 1st Semseter")
                    {
                        List<ListItem> items = new List<ListItem>();
                        items.Add(new ListItem("CSE-3101", "CSE-3101"));
                        items.Add(new ListItem("CSE-3102", "CSE-3102"));
                        items.Add(new ListItem("CSE-3103", "CSE-3103"));
                        items.Add(new ListItem("CSE-3104", "CSE-3104"));
                        items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                        SelectCourseDropDownList.Items.AddRange(items.ToArray());
                    }
                    else if (year == "3rd Year 2nd Semseter")
                    {
                        List<ListItem> items = new List<ListItem>();
                        items.Add(new ListItem("CSE-3201", "CSE-3201"));
                        items.Add(new ListItem("CSE-3202", "CSE-3202"));
                        items.Add(new ListItem("CSE-3203", "CSE-3203"));
                        items.Add(new ListItem("CSE-3204", "CSE-3204"));
                        items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                        SelectCourseDropDownList.Items.AddRange(items.ToArray());
                    }
                    else if (year == "4th Year 1st Semseter")
                    {
                        List<ListItem> items = new List<ListItem>();
                        items.Add(new ListItem("CSE-4101", "CSE-4101"));
                        items.Add(new ListItem("CSE-4102", "CSE-4102"));
                        items.Add(new ListItem("CSE-4103", "CSE-4103"));
                        items.Add(new ListItem("CSE-4104", "CSE-4104"));
                        items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                        SelectCourseDropDownList.Items.AddRange(items.ToArray());
                    }
                    else if (year == "4th Year 2nd Semseter")
                    {
                        List<ListItem> items = new List<ListItem>();
                        items.Add(new ListItem("CSE-4201", "CSE-4201"));
                        items.Add(new ListItem("CSE-4202", "CSE-4202"));
                        items.Add(new ListItem("CSE-4203", "CSE-4203"));
                        items.Add(new ListItem("CSE-4204", "CSE-4204"));
                        items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                        SelectCourseDropDownList.Items.AddRange(items.ToArray());
                    }
                    else
                    {
                        List<ListItem> items = new List<ListItem>();
                        items.Add(new ListItem("Select Your Course", "Select Your Course"));
                        items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                        SelectCourseDropDownList.Items.AddRange(items.ToArray());
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('You are not login!');</script>");
                Server.Transfer("LoginPage.aspx", true);
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

        protected void selectB_Click(object sender, EventArgs e)
        {
            
        }

        protected void startB_Click(object sender, EventArgs e)
        {
            string ExamType = selectExamType.SelectedItem.Text;
            Session["_Course"] = SelectCourseDropDownList.Text;
            Session["_qsN"] = 1;
            if (ExamType == "Theory")
            {

                string CS = "your-database-connection-string";
                SqlConnection con = new SqlConnection(CS);
                con.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from theoryQS where course ='" + SelectCourseDropDownList.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();

                string str = dt.Rows[0][0].ToString();
                int num;
                int.TryParse(str, out num);
                if (num >= 1)
                {
                    Session["_sMCRS"] = "";
                    Session["_sTCRS"] = SelectCourseDropDownList.Text;
                    //Server.Transfer("TheoryExam.aspx", true);
                }
                else
                {
                    Session["_sTCRS"] = "";
                    Session["_sMCRS"] = "";
                    Response.Write("<script>alert('No Theory Course Found!');</script>");
                }
            }
            else if (ExamType == "MCQ")
            {
                string CS = "your-database-connection-string";
                SqlConnection con = new SqlConnection(CS);
                con.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from mcqQS where course ='" + SelectCourseDropDownList.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();

                string str = dt.Rows[0][0].ToString();

                int num;
                int.TryParse(str, out num);


                if (num>=1)
                {
                    Session["_sTCRS"] = "";
                    Session["_sMCRS"] = SelectCourseDropDownList.Text;
                    //Server.Transfer("MCQExam.aspx", true);
                }
                else
                {
                    Session["_sTCRS"] = "";
                    Session["_sMCRS"] = "";
                    Response.Write("<script>alert('No MCQ Course Found!');</script>");
                }
            }
            else
            {
                Session["_sTCRS"] = "";
                Session["_sMCRS"] = "";
                Response.Write("<script>alert('You do not select any exam type!');</script>");
            }
        }

        protected void selectSemesterDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SelectCourseDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void logoutB_Click(object sender, EventArgs e)
        {
            Server.Transfer("LoginPage.aspx", true);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            string exNo = row.Cells[1].Text;
            string crsNo = row.Cells[2].Text;
            string stNo = Session["_ID"].ToString();

            // search this exam taken or not
            string CS = "your-database-connection-string";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from theoryTaken where studentID='" + stNo + "' and courseID='" + crsNo + "' and examNo='" + exNo + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            string str = dt.Rows[0][0].ToString();
            con.Close();
            int num;
            int.TryParse(str, out num);
            if (num >= 1)
            {
                Response.Write("<script>alert('You already take this exam!');</script>");
            }
            else
            {
                //set start question number
                int N;
                int.TryParse(exNo, out N);
                int xx = (N - 1) * 2;
                xx = xx + 1;
                Session["_qNO"] = xx;
                Server.Transfer("TheoryExam.aspx", true);
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView2.SelectedRow;
            string exNo = row.Cells[1].Text;
            string crsNo = row.Cells[2].Text;
            string stNo = Session["_ID"].ToString();

            // search this exam taken or not
            string CS = "your-database-connection-string";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from mcqTaken where studentID='" + stNo + "' and courseID='" + crsNo + "' and examNo='" + exNo + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            string str = dt.Rows[0][0].ToString();
            con.Close();
            int num;
            int.TryParse(str, out num);
            if (num >= 1)
            {
                Response.Write("<script>alert('You already take this exam!');</script>");
            }
            else
            {
                //set start question number
                int N;
                int.TryParse(exNo, out N);
                int xx = (N - 1) * 2;
                xx = xx + 1;
                Session["_qNO"] = xx;
                Server.Transfer("MCQExam.aspx", true);
            }
            
        }
    }
}
