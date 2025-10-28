<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="Recruitment_SignIn" %>
<%@ Register Src="~/Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>SAGS :: WEB.SAG.VN</title>
    <link href="../Stylesheets/CandidateRegistration.css" rel="stylesheet" type="text/css" />
    <link href="../Stylesheets/buttonstyle.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" href="../Images/sags.ico"/> 
</head>
<body style="margin:0px">
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%" cellpadding="0" cellspacing="0" >
            <tr>
                <td class="banner-CandidateBG" >
                     <table style="width: 100%" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                            <td align="left" style="width:420px">
                                <a href="http://Localhost/Home.aspx"><asp:Image ID="Image1" runat="server" ImageUrl="~/Images/SAGS_Logo.png" /></a></td>
                            <td align="center">
                                <asp:Label ID="Label5" runat="server" Text="ĐĂNG KÝ HỒ SƠ DỰ TUYỂN" Font-Bold="True" Font-Size="35pt"></asp:Label>
                            </td>
                            <td style="width:420px"></td>
                        </tr>
                    </table>
                </td>
            </tr>                     
            <tr>
                <td>
                    <table style="width: 100%;"  cellpadding="20" cellspacing="0" class="tableBackground"  border="0" >                                                
                        <tr>
                            <td style="height:400px; vertical-align:top" align="center">
                             <asp:ScriptManager ID="ScriptManager1" runat="server">
                                        </asp:ScriptManager>  
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                               <ContentTemplate>

                                <table style="width: 50%; margin-top:2px; margin-left:2px; margin-right:2px;" border="0">
                                    <tr>
                                        <td valign="top" align="center">
                                            <table style="width: 100%;"  border="0">                                                                                         
                                                <tr>                                                    
                                                    <td valign="top">
                                                        <uc1:ucTitle ID="UcTitle1" runat="server" />                                                    
                                                    </td>                                                    
                                                </tr>
                                                <tr>                                        
                                                    <td align="center" valign="top">
                                                    
                                                            <table style="width: 100%" border="0">
                                                                <tr>
                                                                    <td align="center" colspan="2">
                                                                        <asp:Label ID="lbSession" runat="server" CssClass="labelTitle" Text="ĐĂNG NHẬP ĐỂ KIỂM TRA ĐƠN DỰ TUYỂN ĐÀO TẠO"></asp:Label>
                                                                    </td>                                                       
                                                                </tr>
                                                                 <tr>
                                                                    <td colspan="2" style="height:15px"></td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right">
                                                                        <asp:Label ID="Label1" runat="server" Text="Người dùng (UserName)" CssClass="label"></asp:Label></td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtUserName" runat="server" CssClass="login_textbox_username" Width="150px"></asp:TextBox></td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right">
                                                                        <asp:Label ID="Label2" runat="server" Text="Mật khẩu" CssClass="label"></asp:Label></td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtPassword" runat="server" CssClass="login_textbox_password" Width="150px" TextMode="Password"></asp:TextBox></td>
                                                                </tr>
                                                                <tr>
                                                                    <td colspan="2" style="height:15px"></td>
                                                                </tr>
                                                                <tr>
                                                                    <td colspan="2" class="tdButton" align="center">
                                                                        <asp:Button ID="btnLogin" runat="server" Text="Đăng nhập" CssClass="small color red button" OnClick="btnLogin_Click" Width="100px"/>
                                                                        </td>
                                                                </tr>
                                                                <tr>
                                                                    <td colspan="2" style="height:15px"></td>
                                                                </tr>
                                                                 <tr>
                                                                    <td colspan="2"><asp:Label ID="Label3" runat="server" Text="Bạn chưa có thông tin, Vui lòng đăng ký ở tại đây" CssClass="label"></asp:Label>
                                                                        <asp:LinkButton ID="lnkRegistration" runat="server" 
                                                                            onclick="lnkRegistration_Click" CssClass="labelTitle" Text="ĐĂNG KÝ"></asp:LinkButton>
                                                                     </td>
                                                                </tr>
                                                            </table>
                                                   
                                                         <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                                                            <ProgressTemplate>
                                                                <asp:Image ID="Image2" runat="server" ImageUrl="~/images/run.gif" />
                                                                <asp:Label ID="Label4" runat="server" CssClass="value" Text="Đang Đăng Nhập ..."></asp:Label>
                                                            </ProgressTemplate>
                                                        </asp:UpdateProgress>
                                                        <uc2:ucPermission ID="UcPermission1" runat="server" />
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
