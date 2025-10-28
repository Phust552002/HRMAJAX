<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Recruitment_Registration" %>
<%@ Register Src="~/Recruitment/UserControl/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SAGS :: WEB.SAG.VN</title>
    <link href="../Stylesheets/CandidateRegistration.css" rel="stylesheet" type="text/css"/>
    <link href="../Stylesheets/buttonstyle.css" rel="stylesheet" type="text/css"/>
    <link rel="shortcut icon" href="../Images/sags.ico"/>
</head>
<body>
<form id="form1" runat="server">
<div>
<table style="width: 100%" cellpadding="0" cellspacing="0" border="0">
    <tr>
        <td class="banner-CandidateBG">
            <table style="width: 100%" cellpadding="0" cellspacing="0" border="0">
                <tr>
                    <td align="left" style="width:420px">
                        <a href="http://Localhost/Home.aspx"><asp:Image ID="Image1" runat="server" ImageUrl="~/Images/SAGS_Logo.png" /></a></td>
                    <td align="center">
                        <asp:Label ID="Label16" runat="server" Text="ĐĂNG KÝ HỒ SƠ DỰ TUYỂN" Font-Bold="True" Font-Size="35pt"></asp:Label>
                    </td>
                    <td style="width: 420px"></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="user-infor" align="right">
        </td>
    </tr>
    <tr>
        <td>
            <table style="width: 100%" cellpadding="20" cellspacing="0" class="tableBackground" border="0">
                <tr>
                    <td style="height: 400px; vertical-align: top">
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <table style="width: 100%">
                                    <tr>
                                        <td valign="top">
                                            <uc1:ucTitle ID="UcTitle1" runat="server"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td valign="top" align="center">
                                            <asp:Panel ID="pnRegistration" runat="server">
                                                <table style="margin-left: 2px; margin-right: 2px; margin-top: 2px;">
                                                    <tr>
                                                        <td align="center" colspan="3">
                                                            <asp:Label ID="lbCompanyName" runat="server" Font-Bold="true" ForeColor="Black" Text="CÔNG TY CỔ PHẦN PHỤC VỤ MẶT ĐẤT SÀI GÒN"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="center" colspan="3">
                                                            <asp:Label ID="lbSession" runat="server" Font-Bold="true" ForeColor="Black" Text="TUYỂN DỤNG ĐÀO TẠO NGHIỆP VỤ PHỤC VỤ MẶT ĐẤT"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="3" style="height: 15px"></td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left">
                                                            <asp:Label ID="Label14" runat="server" CssClass="label" Text="Chức danh"></asp:Label>
                                                        </td>
                                                        <td style="width: 20px">&nbsp;</td>
                                                        <td align="left">
                                                            <asp:DropDownList ID="ddlPositions" runat="server" CssClass="dropDownList" AppendDataBoundItems="true">
                                                                <asp:ListItem Text="" Value="0"></asp:ListItem>
                                                            </asp:DropDownList><asp:Label ID="lbPositionsError" runat="server" ForeColor="Red" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left">
                                                            <asp:Label ID="Label2" runat="server" CssClass="label" Text="Họ tên lót"></asp:Label>
                                                        </td>
                                                        <td style="width: 20px"></td>
                                                        <td align="left">
                                                            <asp:TextBox ID="txtLastName" runat="server" CssClass="textBox" Width="300px"></asp:TextBox><asp:Label ID="lbLastNameError" runat="server" ForeColor="Red" Text=""></asp:Label>&nbsp;<asp:Label ID="Label8" runat="server" CssClass="label" Text="(Vd:Nguyễn Văn)"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left">
                                                            <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tên"></asp:Label>
                                                        </td>
                                                        <td style="width: 20px"></td>
                                                        <td align="left">
                                                            <asp:TextBox ID="txtFirstName" runat="server" CssClass="textBox" Width="150px"></asp:TextBox><asp:Label ID="lbFirstNameError" runat="server" ForeColor="Red" Text=""></asp:Label>&nbsp;<asp:Label ID="Label9" runat="server" CssClass="label" Text="(Vd:Ba)"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left">
                                                            <asp:Label ID="Label4" runat="server" CssClass="label" Text="Ngày sinh"></asp:Label>
                                                        </td>
                                                        <td style="width: 20px"></td>
                                                        <td align="left">
                                                            <table border="0" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label10" runat="server" CssClass="label" Text="Ngày"></asp:Label><br/>
                                                                        <asp:TextBox ID="txtDay" runat="server" CssClass="textBox" Width="35px"
                                                                                     MaxLength="2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                        </asp:TextBox>
                                                                    </td>
                                                                    <td style="width: 5px"></td>
                                                                    <td>
                                                                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Tháng"></asp:Label><br/>
                                                                        <asp:TextBox ID="txtMonth" runat="server" CssClass="textBox" Width="35px"
                                                                                     MaxLength="2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                        </asp:TextBox>
                                                                    </td>
                                                                    <td style="width: 5px"></td>
                                                                    <td>
                                                                        <asp:Label ID="Label11" runat="server" CssClass="label" Text="Năm"></asp:Label><br/>
                                                                        <asp:TextBox ID="txtYear" runat="server" CssClass="textBox" Width="80px"></asp:TextBox><asp:Label ID="lbBirthdayError" runat="server" ForeColor="Red" Text=""></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left">
                                                            <asp:Label ID="Label15" runat="server" CssClass="label" Text="E-mail"></asp:Label>
                                                        </td>
                                                        <td style="width: 20px"></td>
                                                        <td align="left">
                                                            <asp:TextBox ID="txtEmail" runat="server" CssClass="textBox" Width="150px"></asp:TextBox>&nbsp;<asp:Label ID="Label17" runat="server" CssClass="label" Text="(Sử dụng khi cần liên hệ hoặc khôi phục mật khẩu)"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left">
                                                            <asp:Label ID="Label6" runat="server" CssClass="label" Text="Người dùng (UserName)"></asp:Label>
                                                        </td>
                                                        <td style="width: 20px"></td>
                                                        <td align="left">
                                                            <asp:TextBox ID="txtUserName" runat="server" CssClass="textBox" Width="150px"></asp:TextBox><asp:Label ID="lbUserNameError" runat="server" ForeColor="Red" Text=""></asp:Label>
                                                            <asp:Label ID="Label7" runat="server" CssClass="label" Text="(Vd:banv) nếu báo trùng thì thêm ký tự số, vd:banv1"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left">
                                                            <asp:Label ID="Label1" runat="server" CssClass="label" Text="Mật khẩu (Password)"></asp:Label>
                                                        </td>
                                                        <td style="width: 20px"></td>
                                                        <td align="left">
                                                            <asp:TextBox ID="txtPassword" runat="server" CssClass="textBox" Width="150px"
                                                                         TextMode="Password">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                            </asp:TextBox><asp:Label ID="lbPasswordError" runat="server" ForeColor="Red" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left">
                                                            <asp:Label ID="Label13" runat="server" CssClass="label" Text="Xác nhận mật khẩu (Password)"></asp:Label>
                                                        </td>
                                                        <td style="width: 20px"></td>
                                                        <td align="left">
                                                            <asp:TextBox ID="txtPasswordConfirm" runat="server" CssClass="textBox" Width="150px"
                                                                         TextMode="Password">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                            </asp:TextBox>
                                                            <asp:CompareValidator ID="CompareValidator1" runat="server"
                                                                                  ControlToCompare="txtPassword" ControlToValidate="txtPasswordConfirm"
                                                                                  CssClass="errorMessage"
                                                                                  ErrorMessage="Mật khẩu và xác nhận lại mật khẩu phải giống nhau">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                            </asp:CompareValidator>
                                                        </td>
                                                    </tr>
                                                    <%-- <tr>
                                                        <td align="left">
                                                            <asp:Label ID="Label15" runat="server" CssClass="label" Text="Nhập mã bảo vệ"></asp:Label>
                                                        </td>
                                                        <td style="width:20px"></td>
                                                        <td align="left">
                                                            <cc1:captchacontrol id="CaptchaControl1" runat="server" ></cc1:captchacontrol>
                                                            &nbsp;
                                                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />                                                                                                                         
                                                        </td>
                                                    </tr>--%>
                                                    <tr>
                                                        <td colspan="3" style="height: 15px"></td>
                                                    </tr>
                                                    <tr>
                                                        <td align="center" colspan="3" class="tdButton">
                                                            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Đăng ký" CssClass="small color red button" Width="100px"/>
                                                            &nbsp;&nbsp;&nbsp;
                                                            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Quay lại" CssClass="small color red button" Width="100px"/>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left">
                                                            <asp:Label ID="lbRetypedEmail" runat="server" CssClass="label" Text="E-mail đã đăng ký"></asp:Label>
                                                        </td>
                                                        <td style="width: 20px"></td>
                                                        <td align="left">
                                                            <asp:TextBox ID="txtRetypedEmail" runat="server" CssClass="textBox" Width="150px"></asp:TextBox><asp:Label ID="lbRetypedEmailError" runat="server" ForeColor="Red" Text=""></asp:Label>&nbsp;<asp:Label ID="lbRetypedEmailSuggestion" runat="server" CssClass="label" Text="Vui lòng điền email đã dùng đăng ký"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="center" colspan="3">
                                                            <asp:Button ID="btnResetPassword" runat="server" OnClick="btnResetPassword_Click" Text="Gửi mật khẩu" CssClass="small color red button" Width="100px"/>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="height: 15px"></td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="3">
                                                            <asp:Label ID="Label12" runat="server" Text="Bạn đã có thông tin, Vui lòng kiểm tra đơn dự tuyển tại đây" CssClass="label"></asp:Label>
                                                            <asp:LinkButton ID="lnkRegistration" runat="server"
                                                                            onclick="lnkRegistration_Click" CssClass="labelTitle" Text=" KIỂM TRA">
                                                            </asp:LinkButton>
                                                        </td>
                                                    </tr>
                                                </table>

                                            </asp:Panel>
                                            <asp:Label ID="lbError" runat="server" ForeColor="Red" Text=""></asp:Label>
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
            © Copyright 2015 ® CÔNG TY CỔ PHẦN PHỤC VỤ MẶT ĐẤT SÀI GÒN giữ bản quyền nội dung trên website này.
        </td>
    </tr>
</table>
</div>
</form>
</body>
</html>