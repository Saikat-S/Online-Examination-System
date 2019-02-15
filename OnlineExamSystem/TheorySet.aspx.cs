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
    public partial class TheorySet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int a = (int)Session["_qsN"];
            //string qNO = a.ToString();
            //qsNoTB.Text = qNO;

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
        protected void selectB_Click(object sender, EventArgs e)
        {
            SelectCourseDropDownList.Items.Clear();
            if (selectSemesterDropDownList.SelectedItem.Text == "1st Year 1st Semseter")
            {
                //Response.Write("hello");
                List<ListItem> items = new List<ListItem>();
                items.Add(new ListItem("Select", "Select"));
                items.Add(new ListItem("CSE-1101", "CSE-1101"));
                items.Add(new ListItem("CSE-1102", "CSE-1102"));
                items.Add(new ListItem("CSE-1103", "CSE-1103"));
                items.Add(new ListItem("CSE-1104", "CSE-1104"));
                //items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                SelectCourseDropDownList.Items.AddRange(items.ToArray());
            }
            else if (selectSemesterDropDownList.SelectedItem.Text == "1st Year 2nd Semseter")
            {
                List<ListItem> items = new List<ListItem>();
                items.Add(new ListItem("Select", "Select"));
                items.Add(new ListItem("CSE-1201", "CSE-1201"));
                items.Add(new ListItem("CSE-1202", "CSE-1202"));
                items.Add(new ListItem("CSE-1203", "CSE-1203"));
                items.Add(new ListItem("CSE-1204", "CSE-1204"));
                //items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                SelectCourseDropDownList.Items.AddRange(items.ToArray());
            }
            else if (selectSemesterDropDownList.SelectedItem.Text == "2nd Year 1st Semseter")
            {
                List<ListItem> items = new List<ListItem>();
                items.Add(new ListItem("Select", "Select"));
                items.Add(new ListItem("CSE-2101", "CSE-2101"));
                items.Add(new ListItem("CSE-2102", "CSE-2102"));
                items.Add(new ListItem("CSE-2103", "CSE-2103"));
                items.Add(new ListItem("CSE-2104", "CSE-2104"));
                //items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                SelectCourseDropDownList.Items.AddRange(items.ToArray());
            }
            else if (selectSemesterDropDownList.SelectedItem.Text == "2nd Year 2nd Semseter")
            {
                List<ListItem> items = new List<ListItem>();
                items.Add(new ListItem("Select", "Select"));
                items.Add(new ListItem("CSE-2201", "CSE-2201"));
                items.Add(new ListItem("CSE-2202", "CSE-2202"));
                items.Add(new ListItem("CSE-2203", "CSE-2203"));
                items.Add(new ListItem("CSE-2204", "CSE-2204"));
                //items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                SelectCourseDropDownList.Items.AddRange(items.ToArray());
            }
            else if (selectSemesterDropDownList.SelectedItem.Text == "3rd Year 1st Semseter")
            {
                List<ListItem> items = new List<ListItem>();
                items.Add(new ListItem("Select", "Select"));
                items.Add(new ListItem("CSE-3101", "CSE-3101"));
                items.Add(new ListItem("CSE-3102", "CSE-3102"));
                items.Add(new ListItem("CSE-3103", "CSE-3103"));
                items.Add(new ListItem("CSE-3104", "CSE-3104"));
                //items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                SelectCourseDropDownList.Items.AddRange(items.ToArray());
            }
            else if (selectSemesterDropDownList.SelectedItem.Text == "3rd Year 2nd Semseter")
            {
                List<ListItem> items = new List<ListItem>();
                items.Add(new ListItem("Select", "Select"));
                items.Add(new ListItem("CSE-3201", "CSE-3201"));
                items.Add(new ListItem("CSE-3202", "CSE-3202"));
                items.Add(new ListItem("CSE-3203", "CSE-3203"));
                items.Add(new ListItem("CSE-3204", "CSE-3204"));
                //items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                SelectCourseDropDownList.Items.AddRange(items.ToArray());
            }
            else if (selectSemesterDropDownList.SelectedItem.Text == "4th Year 1st Semseter")
            {
                List<ListItem> items = new List<ListItem>();
                items.Add(new ListItem("Select", "Select"));
                items.Add(new ListItem("CSE-4101", "CSE-4101"));
                items.Add(new ListItem("CSE-4102", "CSE-4102"));
                items.Add(new ListItem("CSE-4103", "CSE-4103"));
                items.Add(new ListItem("CSE-4104", "CSE-4104"));
                //items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
                SelectCourseDropDownList.Items.AddRange(items.ToArray());
            }
            else if (selectSemesterDropDownList.SelectedItem.Text == "4th Year 2nd Semseter")
            {
                List<ListItem> items = new List<ListItem>();
                items.Add(new ListItem("Select", "Select"));
                items.Add(new ListItem("CSE-4201", "CSE-4201"));
                items.Add(new ListItem("CSE-4202", "CSE-4202"));
                items.Add(new ListItem("CSE-4203", "CSE-4203"));
                items.Add(new ListItem("CSE-4204", "CSE-4204"));
                //items.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
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
        protected void AddQB_Click(object sender, EventArgs e)
        {
                string CS = "Data Source=DESKTOP-JT5TE1G\\SQLEXPRESS;Initial Catalog=OnlineExam;Persist Security Info=True;User ID=sa;Password=369@saikat";

                SqlConnection con = new SqlConnection(CS);
                con.Open();
                string newcon = "insert into theoryQS (course,qsId,qsNo,qsA,markA,qsB,markB,eTime) VALUES('" + SelectCourseDropDownList.Text + "', '" + "null" + "', '" + qsNoTB.Text + "', '" + QATBox.Text + "', '" + markATB.Text + "', '" + QBTBox.Text + "', '" + markBTB.Text + "', '" + timeTB.Text + "')";

                SqlCommand cmd = new SqlCommand(newcon, con);
                cmd.ExecuteNonQuery();
                con.Close();

            //Session["_qsN"] = ((int)Session["_qsN"]) + 1;
            //int a = (int)Session["_qsN"];
            //string qNO = a.ToString();
            //qsNoTB.Text = qNO;

            // set question number
            CS = "Data Source=DESKTOP-JT5TE1G\\SQLEXPRESS;Initial Catalog=OnlineExam;Persist Security Info=True;User ID=sa;Password=369@saikat";
            con = new SqlConnection(CS);
            con.Open();
            cmd = new SqlCommand("select count(*) from theoryQS where course ='" + SelectCourseDropDownList.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();

            string str = dt.Rows[0][0].ToString();
            con.Close();

            int num = 0;
            int.TryParse(str, out num);

            num = num + 1;

            string qNO = num.ToString();
            qsNoTB.Text = qNO;

            Response.Write("<script>alert('Question Added!');</script>");

                //Server.Transfer("LoginPage.aspx", true);
        }

        protected void setB_Click(object sender, EventArgs e)
        {
            string CS = "Data Source=DESKTOP-JT5TE1G\\SQLEXPRESS;Initial Catalog=OnlineExam;Persist Security Info=True;User ID=sa;Password=369@saikat";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from theoryCourseDetail where courseID ='" + SelectCourseDropDownList.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();

            string str = dt.Rows[0][0].ToString();
            con.Close();

            int num = 0;
            int.TryParse(str, out num);

            num = num + 1;
            string examNO = num.ToString();

            con = new SqlConnection(CS);
            con.Open();
            string newcon = "insert into theoryCourseDetail (courseID,examNo) VALUES('" + SelectCourseDropDownList.Text + "','" + examNO + "')";

            cmd = new SqlCommand(newcon, con);
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Write("<script>alert('Exam Added!');</script>");
            Server.Transfer("AdminPanel.aspx", true);
        }

        protected void clearB_Click(object sender, EventArgs e)
        {
            QATBox.Text = "";
            markATB.Text = "";
            QBTBox.Text = "";
            markBTB.Text = "";
        }
        protected void logoutB_Click(object sender, EventArgs e)
        {
            Server.Transfer("LoginPage.aspx", true);
        }

        protected void selectSemesterDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SelectCourseDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

            string CS = "Data Source=DESKTOP-JT5TE1G\\SQLEXPRESS;Initial Catalog=OnlineExam;Persist Security Info=True;User ID=sa;Password=369@saikat";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from theoryQS where course ='" + SelectCourseDropDownList.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();

            string str = dt.Rows[0][0].ToString();
            int num=0;
            int.TryParse(str, out num);

            num = num + 1;

            string qNO = num.ToString();
            qsNoTB.Text = qNO;

            //Response.Write("Hello");
        }
    }
}