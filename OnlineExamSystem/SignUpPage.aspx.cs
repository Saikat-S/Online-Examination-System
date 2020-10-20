using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using System.Drawing;
using System.Drawing.Imaging;

namespace OnlineExamSystem
{
    public partial class SignUpPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginB_Click(object sender, EventArgs e)
        {
            Server.Transfer("LoginPage.aspx", true);
        }

        protected void signUpB_Click(object sender, EventArgs e)
        {
            //Response.Write("hello");
            string pass1 = passTxBox.Text;
            string pass2 = cPassTxBox.Text;

            //FileUpload1.SaveAs(Server.MapPath("C:/Users/Saikat/Documents/Visual Studio 2015/Projects/OnlineExamSystem/OnlineExamSystem/Images") + Path.GetFileName(FileUpload1.FileName));
            FileUpload1.SaveAs(Server.MapPath("~/Images/") + Path.GetFileName(FileUpload1.FileName));
            string link = "Images/" + Path.GetFileName(FileUpload1.FileName);
            int nEx = 0;
            double tM = 0;
            if (pass1 == pass2)
            {
                try
                {
                    string CS = "your-database-connection-string";
                           
                    SqlConnection con = new SqlConnection(CS);
                    con.Open();
                    string newcon = "insert into userInfo (id,name,department,email,semester,gender,password,fatherName,hall,image,no_of_exam,total_mark) VALUES('" + idTxBox.Text + "', '" + nameTxBox.Text + "', '" + deptDropDownList.Text + "', '" + emailTxBox.Text + "', '" + semesterDropDownList.Text + "', '" + genderDropDownList.Text + "', '" + passTxBox.Text + "', '" + fatherNameTB.Text + "', '" + hallTB.Text + "', '" + link + "', '" + nEx + "', '" + tM + "')";

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
