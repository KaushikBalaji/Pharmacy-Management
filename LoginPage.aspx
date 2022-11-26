<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="PharmacyProject.LoginPage" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    </asp:Content>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link rel="stylesheet" href="bootstrap/css1/bootstrap.min.css">
  <script src="bootstrap/css1/jquery.min.js"></script>
  <script src="bootstrap/css1/bootstrap.min.js"></script>
        <link rel="stylesheet" href="bootstrap/css/bootstrap-grid.min.css" />
    <link rel="stylesheet" href="bootstrap/css/bootstrap-grid.css" />
    <script src="bootstrap/js/bootstrap.min.js"></script>


    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
            margin-top: 9px;
            width: 1044px;
            height: 529px;
        }
        .auto-style2 {
            margin-left: 0px;
            width: 60%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            box-sizing: border-box;

        }
        .auto-style4 {
            margin-left: 253px;
            margin-top: 52px;
        }
        .auto-style5 {
            margin-left: 30px;
            margin-top: 44px;
        }
        .auto-style6 {
            margin-left: 309px;
            margin-top: 0px;
            align-content:center;
        }
        .auto-style7 {
            width: 97%;
            margin-left: auto;
            margin-right: auto;
            padding-left: 15px;
            padding-right: 15px;
        }
        body {font-family: Arial, Helvetica, sans-serif;}
        form {border: 3px solid #f1f1f1;}



        button {
          background-color: #04AA6D;
          color: white;
          padding: 14px 20px;
          margin: 8px 0;
          border: none;
          cursor: pointer;
          width: 100%;
        }

        button:hover {
          opacity: 0.8;
        }

        .cancelbtn {
          width: auto;
          padding: 10px 18px;
          background-color: #f44336;
        }

        .imgcontainer {
          text-align: center;
          margin: 24px 0 12px 0;
        }

        img.avatar {
          width: 40%;
          border-radius: 50%;
        }

        .container {
          padding: 16px;
        }

        span.psw {
          float: right;
          padding-top: 16px;
        }

        /* Change styles for span and cancel button on extra small screens */
        @media screen and (max-width: 300px) {
          span.psw {
             display: block;
             float: none;
          }
          .cancelbtn {
             width: 100%;
          }
        }

    #logo-container {
        display: flex;
        align-items: center;
        justify-content: center;
    }
    #logo-container>img {
        max-width: 50%;
    }
    </style>
</head>
<body>
    <div>
       <form id="form1" runat="server" draggable="auto">
                       <div>
                <nav class="navbar navbar-default">
                    <div class="auto-style7">
                        <div class="navbar-header">
                            <a class="navbar-brand" href="HomePage.aspx">Heal & Deal</a>
                        </div>
                    <ul class="nav navbar-nav">
                      <li class="active"><a href="HomePage.aspx">Home</a></li>
                    </ul>
                    <ul class="nav navbar-nav navbar-right">
                      <li><a href="RegisterUser.aspx">Register</a></li>
                      <li class="headlist"><a href="LoginPage.aspx">Login</a></li>
                    </ul>

                </div>
                </nav>
            </div>
           
           <asp:Label ID="Label1" runat="server" Text="Signin" Font-Size="20px"></asp:Label>
           <br /><br /><br />
           <div id="logo-container">
           <asp:Image ID="image1" runat="server" ImageUrl="generaluser.png" Width="100px" Height="100px" />
               </div>
        <br />
        <br />
        <p class="auto-style2">
        <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
            <br />
           <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <br/><br/><br/>
           <p class="auto-style2">
               <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label><br />
               <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2" TextMode="Password"></asp:TextBox>

        </p><br />
        <asp:Button ID="loginBtn" runat="server" CssClass="auto-style4" OnClick="LoginBtn_click" Text="Login" Width="140px" BackColor="#009933" ForeColor="Black" Height="35px" />
        <p><br />
        <asp:TextBox ID="TextBox3" runat="server" Height="124px" Width="495px" BorderStyle="None" CssClass="auto-style5"></asp:TextBox>
        </p><br />
    </form>
    </div>
</body>
</html>


