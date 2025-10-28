<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Location.aspx.cs" Inherits="Recruitment_Location" %>
<%@ Register TagPrefix="cc1" Namespace="WebControlCaptcha" Assembly="WebControlCaptcha" %>
<%@ Register Src="~/Recruitment/UserControl/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc3" %>
<%@ Register Src="~/Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SAGS :: WEB.SAG.VN</title>
    <link href="../Stylesheets/CandidateRegistration.css" rel="stylesheet" type="text/css" />
    <link href="../Stylesheets/buttonstyle.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" href="../Images/sags.ico"/> 
</head>
<body>
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
                                <asp:Label ID="Label5" runat="server" Text="ĐĂNG KÝ HỒ SƠ DỰ TUYỂN" Font-Bold="True" Font-Size="35pt"></asp:Label>
                            </td>
                            <td style="width:420px"></td>
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
                                    <table style="width: 100%">
                                        <tr>
                                            <td valign="top" >
                                                <uc1:ucTitle ID="UcTitle1" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td valign="top" align="center" style="height:50px">
                                                
                                            </td>
                                        </tr>                                                          
                                        <tr>
                                            <td align="center" valign="top">
                                                <table border="0">
                                                    <tr>
                                                        <td align="center">
                                                            <asp:Label ID="lbSession" runat="server"  Font-Bold="true" ForeColor="Black"  Text="NỘP ĐƠN DỰ TUYỂN LÀM VIỆC TẠI : "></asp:Label>
                                                        </td>                                                       
                                                    </tr>
                                                     <tr>
                                                        <td valign="top" align="center" style="height:30px">
                                                
                                                        </td>
                                                    </tr>   
                                                    <tr>
                                                        <td>                                                            
                                                            <asp:CheckBox ID="chkSGN" runat="server"  
                                                                Text="Cảng hàng không quốc tế Tân Sơn Nhất, TP. Hồ Chí Minh, Việt Nam" 
                                                                Checked="True" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:CheckBox ID="chkDAD" runat="server"  
                                                                Text="Cảng hàng không quốc tế Đà Nẵng, TP. Đà Nẵng, Việt Nam" Visible="True" />                                                            
                                                        </td>
                                                    </tr>
                                                     <tr>
                                                        <td align="center">
                                                            <asp:Label ID="lbResult" runat="server" Font-Bold="true" ForeColor="Red" Text=""></asp:Label>
                                                        </td>                                                                                                                             
                                                    </tr>
                                                    <tr>
                                                        <td valign="top" align="center" style="height:30px">
                                                
                                                        </td>
                                                    </tr>   
                                                    <tr>
                                                        <td align="center" valign="top"  class="tdButton">
                                                            <asp:Button ID="btnSelectLocation" runat="server" OnClick="btnSelectLocation_Click" Text="Tiếp tục" CssClass="small color red button" Width="100px"/>
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
