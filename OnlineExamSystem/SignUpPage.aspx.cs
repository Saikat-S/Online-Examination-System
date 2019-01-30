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
    public partial class SignUpPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginB_Click(object sender, EventArgs e)
        {

        }

        protected void signUpB_Click(object sender, EventArgs e)
        {
            //Response.Write("hello");
            string pass1 = passTxBox.Text;
            string pass2 = cPassTxBox.Text;
            if (pass1 == pass2)
            {
                try
                {
                    string CS ="Data Source=DESKTOP-JT5TE1G\\SQLEXPRESS;Initial Catalog=OnlineExam;Persist Security Info=True;User ID=sa;Password=369@saikat";
                           
                    SqlConnection con = new SqlConnection(CS);
                    con.Open();
                    string newcon = "insert into userInfo (id,name,department,email,semester,gender,password,fatherName,hall) VALUES('" + idTxBox.Text + "', '" + nameTxBox.Text + "', '" + deptDropDownList.Text + "', '" + emailTxBox.Text + "', '" + semesterDropDownList.Text + "', '" + genderDropDownList.Text + "', '" + passTxBox.Text + "', '" + fatherNameTB.Text + "', '" + hallTB.Text + "')";

                    SqlCommand cmd = new SqlCommand(newcon, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script>alert('Registration Successful!');</script>");

                   Server.Transfer("LoginPage.aspx", true);
                 }
                 catch (Exception ex)
                {
                    //Response.Write(ex);
                    //Response.Write("<script>alert('Database Eror!');</script>");
                   }
            }
            else
            {
              Response.Write("<script>alert('Password Do not match!');</script>");
            }
        }
    }
}