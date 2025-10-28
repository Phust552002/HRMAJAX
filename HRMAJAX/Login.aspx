<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>
<%@ Register Src="Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"TagPrefix="uc2" %>
<%@ Register Src="UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta charset="UTF-8">
    <title>SAGS :: HUMAN RESOURCES MANAGEMENT</title>
    <link href="Stylesheets/Styles.css" rel="stylesheet" type="text/css"/>
    <link type="text/css" rel="stylesheet" href="Stylesheets/buttonstyle.css" media="screen"/>
    <link rel="shortcut icon" href="Images/sags.ico"/>
    <style>
      /* NOTE: The styles were added inline because Prefixfree needs access to your styles and they must be inlined if they are on local disk! */
        @import url(http://fonts.googleapis.com/css?family=Exo:100,200,400);

        @import url(http://fonts.googleapis.com/css?family=Source+Sans+Pro:700,400,300);

        body {
            background: #fff;
            color: #fff;
            font-family: Arial;

            font-size: 12px;
            margin: 0;
            padding: 0;
        }

        .body {
            -webkit-filter: blur(0px);
            background-image: url(images/Login_BG.PNG);
            background-size: cover;
            bottom: -40px;
            height: auto;
            left: -20px;
            position: absolute;
            right: -40px;
            top: -20px;
            width: auto;
            z-index: 0;
        }

        .grad {
            background: -webkit-gradient(linear, left top, left bottom, color-stop(0%, rgba(0, 0, 0, 0)), color-stop(100%, rgba(0, 0, 0, 0.65))); /* Chrome,Safari4+ */
            bottom: -40px;
            height: auto;
            left: -20px;
            opacity: 1.5;
            position: absolute;
            right: -40px;
            top: -20px;
            width: auto;
            z-index: 1;
        }

        .header {
            left: calc(60% - 255px);
            position: absolute;
            top: calc(65% - 35px);
            z-index: 2;
        }

        .header div {
            color: #fff;
            float: left;
            font-family: 'Exo', sans-serif;
            font-size: 20px;
            font-weight: bold;
        }

        .header div span { color: #ea7125 !important; }

        .login {
            height: 150px;
            left: calc(50% - 50px);
            padding: 10px;
            position: absolute;
            top: calc(50% - 200px);
            width: 350px;
            z-index: 2;
        }

        .login input[type=text] {
            background: #fff;
            border: 1px solid rgb(0, 0, 0);
            border-radius: 2px;
            color: #000;
            font-family: 'Exo', sans-serif;
            font-size: 16px;
            font-weight: 400;
            height: 30px;
            opacity: 0.6;
            padding: 4px;
            width: 250px;
        }

        .login input[type=password] {
            background: #fff;
            border: 1px solid rgb(0, 0, 0);
            border-radius: 2px;
            color: #000;
            font-family: 'Exo', sans-serif;
            font-size: 16px;
            font-weight: 400;
            height: 30px;
            margin-top: 10px;
            opacity: 0.6;
            padding: 4px;
            width: 250px;
        }

        .login input[type=button] {
            background: #fff;
            border: 1px solid #fff;
            border-radius: 2px;
            color: #00ff21;
            cursor: pointer;
            font-family: 'Exo', sans-serif;
            font-size: 16px;
            font-weight: 400;
            height: 35px;
            margin-top: 10px;
            padding: 6px;
            width: 260px;
        }

        .login input[type=button]:hover { opacity: 0.8; }

        .login input[type=button]:active { opacity: 0.6; }

        .login input[type=text]:focus {
            border: 1px solid rgba(255, 255, 255, 0.9);
            outline: none;
        }

        .login input[type=password]:focus {
            border: 1px solid rgba(255, 255, 255, 0.9);
            outline: none;
        }

        .login input[type=button]:focus { outline: none; }

        ::-webkit-input-placeholder { color: #a18d6c; }

        ::-moz-input-placeholder { color: #a18d6c; }

        .quoc {
            background: #03663b;
            border: 1px solid #fff;
            border-radius: 2px;
            color: #fff;
            cursor: pointer;
            font-family: 'Exo', sans-serif;
            font-size: 16px;
            font-weight: 400;
            height: 35px;
            margin-top: 10px;
            padding: 6px;
            width: 260px;
        }

        .quoc:hover { opacity: 0.8; }

        .quoc:active { opacity: 0.6; }

        .hrmlogo {
            height: 150px;
            left: calc(10% - 135px);
            padding: 10px;
            position: absolute;
            top: calc(10% - 75px);
            width: 350px;
            z-index: 2;
        }

        .hrmbanner {
            height: 150px;
            left: calc(40% - 50px);
            padding: 10px;
            position: absolute;
            top: calc(10% - 75px);
            width: 350px;
            z-index: 2;
        }
    </style>
</head>

<body style="margin: 0px">
<form id="form1" runat="server">
    <div align="center">
        <MARQUEE bgcolor="#9cc9de" SCROLLDELAY="100"
                 direction="left" loop="20" width="80%">
            <asp:Literal id="ltBulletin" runat="server"></asp:Literal></MARQUEE>
    </div>
    <div class="body"></div>
    <div class="grad">        
    </div>
    <div class="hrmlogo">
        <asp:Image ID="Image2" runat="server"  ImageUrl="~/images/SAGS_Logo.png"/>
    </div>
    <%--<div class="hrmbanner">
        <%--<asp:Image ID="Image4" runat="server"  ImageUrl="~/images/hrm_title_2017.png"/>
    </div>--%>
    <div class="header">
        <div><span><asp:Label ID="lbError" runat="server" Text=""></asp:Label></span></div>
            
    </div>
    <div class="login">
        <asp:TextBox ID="txtUserName" runat="server" placeholder="Tên đăng nhập"></asp:TextBox><br>
        <asp:TextBox ID="txtPassword" runat="server"  placeholder="Mật khẩu" TextMode="Password"></asp:TextBox><br>
				
        <asp:Button ID="ImageButton1" runat="server" Text="Đăng Nhập" CssClass="quoc" OnClick="ImageButton1_Click"/>
    </div>
    <uc2:ucPermission ID="UcPermission1" runat="server"/>
</form>
</body>
</html>