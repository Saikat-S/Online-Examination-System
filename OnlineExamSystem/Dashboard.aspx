<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="OnlineExamSystem.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/bootstrap.css" rel="stylesheet" />
    <title>Online Exam Management System</title>
    <style type="text/css">
        body {
            height: 100%;
            width: 100%;
            background-image: url("https://img.freepik.com/premium-vector/retro-science-wallpaper_23-2148557501.jpg?w=2000");
            background-size: cover;
            z-index: -2
        }

        #cover {
            height: 100%;
            width: 100%;
            background-color: rgb(243, 237, 247);
            opacity: 0.5;
            position: absolute;
            z-index: -1
        }

        #headerPanel1 {
            height: 200px;
            width: 100%;
            background-color: rgba(21, 252, 148, 0.7);
            display: flex;
            flex-direction: row;
            align-items: center;
            justify-content: center;
        }

        #labelHeading {
            height: auto;
            width: auto;
            font-size: 60px;
        }

            #labelHeading > p {
                color: rgb(89, 146, 236);
            }

        #Menu {
            height: 25px;
            width: 100%;
            background-color: rgba(21, 252, 148, 0.3);
        }

            #Menu > ul {
                display: flex;
                list-style: none;
                justify-content: flex-end;
            }

                #Menu > ul > li {
                    margin-right: 18px;
                    margin-left: 18px;
                }

                    #Menu > ul > li > a {
                        text-decoration: none;
                    }

                #Menu > ul :last-child {
                    padding-right: 5px;
                    padding-left: 10px;
                }

        #welcome_message {
            text-align: center;
            font-size: 50px;
            height: 70px;
            width: 100%;
        }

        #exam_btn{
            display:flex;
            justify-content:center;
            align-items:center;
            height:400px;
        }

        #sExamB{
            height: 100px;
            width: 200px;
            font-size: 25px;
        }


    </style>
</head>
<body>


    <form id="form2" runat="server">

        <div id="cover">
        </div>

        <%--<form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:panel id="headerpanel1" runat="server" backcolor="#00cc99" height="125px" style="margin-top: 0px">
                        <asp:label id="label1" runat="server" borderstyle="none" font-bold="true" font-size="xx-large" forecolor="#006666" height="39px" style="margin-left: 388px; margin-bottom: 0px; margin-top: 43px;" text="online examination system management" width="580px"></asp:label>
                    </asp:panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Panel ID="signUpPanel1" runat="server" BackColor="#99FFCC" Height="37px">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="homeB" runat="server" BackColor="#00CC99" CssClass="auto-style17" Font-Bold="True" Font-Size="Medium" Height="34px" OnClick="homeB_Click" Text="Home" Width="100px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="profileB" runat="server" BackColor="#00CC99" CssClass="auto-style18" Font-Bold="True" Font-Size="Medium" Height="34px" OnClick="profileB_Click" Text="Profile" Width="90px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="LeaderboardB" runat="server" BackColor="#00CC99" CssClass="auto-style18" Font-Bold="True" Font-Size="Medium" Height="34px" OnClick="LeaderboardB_Click" Text="Leaderboard" Width="120px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="logoutB" runat="server" CssClass="auto-style19" Font-Bold="True" Font-Size="Medium" Height="34px" OnClick="logoutB_Click" Text="Log Out" Width="140px" />
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style20"></td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" CssClass="auto-style13" Font-Bold="True" Font-Size="XX-Large" ForeColor="#CC6600" Height="43px" Text="Welcome To Dashboard" Width="347px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="sExamB" runat="server" BackColor="#99FFCC" Font-Bold="True" Font-Size="X-Large" Height="90px" OnClick="sExamB_Click" Text="Start Exam" Width="200px" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>--%>


        <div>
            <asp:Panel ID="headerPanel1" runat="server">
                <div id="labelHeading">
                    <p>
                        Online Examination Management System
                    </p>
                </div>
            </asp:Panel>
        </div>

        <div id="Menu">
            <ul>
                <li>
                    <asp:HyperLink ID="leaderboard_link" runat="server" href="Leaderboard.aspx">Leaderboard</asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="profile_link" runat="server" href="UserProfile.aspx">Profile</asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="home_link" runat="server" href="Dashboard.aspx">Home</asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="logout_link" runat="server" href="LoginPage.aspx">Logout</asp:HyperLink>
                </li>
            </ul>
        </div>

        <br />
        <br />
        <br />

        <div id="welcome_message">
            <asp:Label ID="Label2" runat="server" ForeColor="#CC6600" Text="Welcome To The Dashboard"></asp:Label>
        </div>

        <div id="exam_btn">
            <asp:Button ID="sExamB" runat="server" text="Start Exam" class="btn btn-primary" OnClick="sExamB_Click"/>
        </div>

    </form>


</body>
</html>
