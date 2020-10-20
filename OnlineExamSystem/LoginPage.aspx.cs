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
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signupB(object sender, EventArgs e)
        {
            Server.Transfer("SignUpPage.aspx", true);
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            //Server.Transfer("Dashboard.aspx", true);
            if (AccountTypeDB.SelectedItem.Text == "Student")
            {
                string CS = "your-database-connection-string";
                SqlConnection con = new SqlConnection(CS);
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select count(*) from userInfo where id ='" + userTextBox.Text + "' and password='" + passTextBox.Text + "' ", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cmd.ExecuteNonQuery();
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Session["_ID"] = userTextBox.Text;

                        Server.Transfer("Dashboard.aspx", true);
                    }
                    else
                    {
                        Response.Write("<script>alert('User ID or Password do not match!');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert(ex.Message);</script>");
                }
            }
            else if (AccountTypeDB.SelectedItem.Text == "Teacher")
            {
                if (userTextBox.Text == "Admin" && passTextBox.Text == "Admin")
                {
                    Server.Transfer("AdminPanel.aspx", true);
                }
                else
                {
                    Response.Write("<script>alert('User ID or Password do not match!');</script>");
                }

            }
        }
    }
}
