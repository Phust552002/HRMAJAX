<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword"%>
<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc3" %>
<%@ Register Src="~/Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"TagPrefix="uc2" %>
<%@ Register Src="~/Recruitment/UserControl/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>SAGS ::  WEB.SAG.VN</title>
    <link href="../Stylesheets/CandidateRegistration.css" rel="stylesheet" type="text/css" />
    <link href="../Stylesheets/buttonstyle.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" href="../Images/sags.ico"/> 
</head>

<body style="margin:0px">
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%" cellpadding="0" cellspacing="0" border="0">
            <tr>
                <td class="banner-CandidateBG" >
                     <table style="width: 100%" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                            <td align="left" style="width:420px">
                                <a href="http://Localhost/Home.aspx"><asp:Image ID="Image1" runat="server" ImageUrl="~/Images/SAGS_Logo.png" /></a></td>
                            <td align="center">
                                <asp:Label ID="Label53" runat="server" Text="HỒ SƠ ĐĂNG KÝ DỰ TUYỂN" Font-Bold="True" Font-Size="35pt"></asp:Label>
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
                    <table style="width: 100%"  cellpadding="20" cellspacing="0" class="tableBackground" border="0">                                                
                        <tr>
                            <td style="height:400px; vertical-align:top">
                             <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>  
                             <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                               <ContentTemplate>                                                               
                                    <table width="100%" >   
                                            <tr>
                                                <td align="center" valign="top">
                                                    <table width="100%" >
                                                        <tr>
                                                            <td valign="top">
                                                                <uc1:ucTitle ID="UcTitle1" runat="server" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center" valign="top">
                                                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtNewPassword"
                                                                    ControlToValidate="txtConfirmPassword" CssClass="errorMessage" ErrorMessage="Mật khẩu mới và xác nhận lại mật khẩu phải giống nhau"></asp:CompareValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center" valign="top">
                                                                <table style="width: 40%" class="tableBorder">
                                                                    <tr>
                                                                        <td class="tdLabel">
                                                                            <asp:Label ID="Label2" runat="server" Text="Mật khẩu cũ" CssClass="label"></asp:Label></td>
                                                                        <td class="tdValue">
                                                                            <asp:TextBox ID="txtOldPassword" runat="server" Width="200px" TextMode="Password" CssClass ="textBox"></asp:TextBox>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtOldPassword"
                                                                                CssClass="errorMessage" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="tdLabel">
                                                                            <asp:Label ID="Label3" runat="server" Text="Mật khẩu mới" CssClass="label"></asp:Label></td>
                                                                        <td class="tdValue">
                                                                            <asp:TextBox ID="txtNewPassword" runat="server" Width="200px" TextMode="Password" CssClass ="textBox"></asp:TextBox>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNewPassword"
                                                                                CssClass="errorMessage" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="tdLabel">
                                                                            <asp:Label ID="Label4" runat="server" Text="Xác nhận lại mật khẩu" CssClass="label"></asp:Label></td>
                                                                        <td class="tdValue">
                                                                            <asp:TextBox ID="txtConfirmPassword" runat="server" Width="200px" TextMode="Password" CssClass ="textBox"></asp:TextBox>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtConfirmPassword"
                                                                                CssClass="errorMessage" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                                                                    </tr>
                            
                                                                    <tr>
                                                                        <td colspan="2" class="tdButton" align="center">
                                                                            <asp:Button ID="btnChange" runat="server" Text="Thay Đổi" OnClick="btnChange_Click" Width="100px" CssClass="small color green button" />
                                                                            &nbsp;
                                                                            <asp:Button ID="btnCancel" runat="server" Text="Thoát" OnClick="btnCancel_Click" ValidationGroup="RequiredFieldValidator1" Width="100px" CssClass="small color green button" />
                                                                        </td>
                                                                    </tr>
                                                                </table>
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
                     © Copyright 2015 ® CÔNG TY CỔ PHẦN PHỤC VỤ MẶT ĐẤT SÀI GÒN giữ bản quyền nội dung trên website này.
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>

