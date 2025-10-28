<%@ Page Language="C#" AutoEventWireup="true" CodeFile="_Login.aspx.cs" Inherits="_Default" %>
<%@ Register Src="Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"TagPrefix="uc2" %>
<%@ Register Src="UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>SAGS :: HUMAN RESOURCES MANAGEMENT</title>
    <link href="Stylesheets/Styles.css" rel="stylesheet" type="text/css"/>
    <link type="text/css" rel="stylesheet" href="Stylesheets/buttonstyle.css" media="screen"/>
    <link rel="shortcut icon" href="Images/sags.ico"/>
</head>

<body style="margin: 0px">
<form id="form1" runat="server">
    <div>
        <table style="width: 100%" cellpadding="0" cellspacing="0">
            <tr>
                <td class="banner-BG">
                    <table style="width: 100%" cellpadding="0" cellspacing="0">
                        <tr>
                            <td align="left"><a href="http://Localhost/Home.aspx"><asp:Image ID="Image1" runat="server" ImageUrl="~/Images/hrm_left_2017.jpg"/></a></td>
                            <td align="center">
                                <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/hrm-banner-center.jpg"/>
                            </td>
                            <%--<td align="center">
                                <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/hrm-banner-right.jpg"/>
                            </td>--%>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="background-image: url(images/HRM-Menu-BG.gif); height: 22px"></td>
            </tr>
            <tr>
                <td>
                    <table style="width: 100%" cellpadding="20" cellspacing="0" class="tableBackground">

                        <tr>
                            <td style="height: 400px; vertical-align: top">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <table style="height: 500px; width: 100%;" class="tableBgBoxShare">
                                            <tr>
                                                <td valign="top">
                                                    <table style="width: 100%;">
                                                        <tr>
                                                            <td style="height: 80px" colspan="3">

                                                                <div align="center">
                                                                    <MARQUEE bgcolor="#9cc9de" SCROLLDELAY="100"
                                                                             direction="left" loop="20" width="80%">
                                                                        <asp:Literal id="ltBulletin" runat="server"></asp:Literal>
                                                                    </MARQUEE>
                                                                </DIV>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 20%" rowspan="2"></td>
                                                            <td style="height: 50px; width: 60%;" valign="top">
                                                                <uc1:ucTitle ID="UcTitle1" runat="server"/>

                                                            </td>
                                                            <td style="width: 20%" rowspan="2"></td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 60%" align="center" valign="top">

                                                                <table style="width: 60%" class="tableBorder">
                                                                    <tr>
                                                                        <td class="tdLabel">
                                                                            <asp:Label ID="Label1" runat="server" Text="Tên đăng nhập" CssClass="label"></asp:Label>
                                                                        </td>
                                                                        <td class="tdValue">
                                                                            <asp:TextBox ID="txtUserName" runat="server" CssClass="login_textbox_username" Width="150px"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="tdLabel">
                                                                            <asp:Label ID="Label2" runat="server" Text="Mật khẩu" CssClass="label"></asp:Label>
                                                                        </td>
                                                                        <td class="tdValue">
                                                                            <asp:TextBox ID="txtPassword" runat="server" CssClass="login_textbox_password" Width="150px" TextMode="Password"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="2" class="tdButton" align="center">
                                                                            <asp:Button ID="btnLogin" runat="server" Text="Đăng nhập" CssClass="small color green button" OnClick="btnLogin_Click"/>
                                                                        </td>
                                                                    </tr>
                                                                </table>

                                                                <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                                                                    <ProgressTemplate>
                                                                        <asp:Image ID="Image2" runat="server" ImageUrl="~/images/run.gif"/>
                                                                        <asp:Label ID="Label4" runat="server" CssClass="value" Text="Đang Đăng Nhập ..."></asp:Label>
                                                                    </ProgressTemplate>
                                                                </asp:UpdateProgress>
                                                                <uc2:ucPermission ID="UcPermission1" runat="server"/>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>

                                    </ContentTemplate>

                                </asp:UpdatePanel>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="footer">
                    © 2007 Bản Quyền Thuộc Về SAGS.<br/>
                    Tổ Nhân Sự - Phòng Tổ Chức Hành Chính. Điện thoại : 3349.
                </td>
            </tr>
        </table>
    </div>
</form>
</body>
</html>