<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeInforDetail.aspx.cs" Inherits="Employee_EmployeeInforDetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>SAGS :: HUMAN RESOURCES MANAGEMENT</title>
    <link href="../Stylesheets/Styles.css" rel="stylesheet" type="text/css" />  
</head>
<body>
    <form id="form1" runat="server">
    <div>
     
        <table style="width: 100%">
            <tr>
                <td>                   
                   <uc1:ucTitle ID="UcTitle1" runat="server" />                        
                </td>
            </tr>
            <tr>
                <td>
                   <table style="width: 100%" class="tableBorder">
                        <tr>
                            <td class="tdLabel" style="width:200px;">
                                <asp:Image ID="ImgUser" runat="server" /></td>
                            <td>
                                 <table style="width: 100%" class="tableBorder">                                    
                                    <tr class="tdLabel">
                                        <td align="left"><asp:Label ID="Label2" runat="server" CssClass="label" Text="Họ và tên :"></asp:Label></td>
                                    </tr>
                                    <tr class="tdValue">
                                        <td align="left">
                                            &nbsp;<asp:Label ID="lbFullName" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr class="tdLabel">
                                        <td align="left"><asp:Label ID="Label3" runat="server" CssClass="label" Text="Chức danh :"></asp:Label></td>
                                    </tr>
                                    <tr class="tdValue">
                                        <td align="left">
                                            &nbsp;<asp:Label ID="lbPosition" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr class="tdLabel">
                                        <td align="left"><asp:Label ID="Label4" runat="server" CssClass="label" Text="Phòng :"></asp:Label></td>
                                    </tr>
                                    <tr class="tdValue">
                                        <td align="left">
                                            &nbsp;<asp:Label ID="lbDepartment" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr class="tdLabel">
                                        <td align="left"><asp:Label ID="Label5" runat="server" CssClass="label" Text="Giới tính :"></asp:Label></td>
                                    </tr>
                                    <tr class="tdValue">
                                        <td align="left">
                                            &nbsp;<asp:Label ID="lbSex" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr class="tdLabel">
                                        <td align="left"><asp:Label ID="Label6" runat="server" CssClass="label" Text="Sinh ngày :"></asp:Label></td>
                                    </tr>
                                    <tr class="tdValue">
                                        <td align="left">
                                            &nbsp;<asp:Label ID="lbBirthday" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr class="tdLabel">
                                        <td align="left"><asp:Label ID="Label7" runat="server" CssClass="label" Text="Trình trạng hôn nhân :"></asp:Label></td>
                                    </tr>
                                    <tr class="tdValue">
                                        <td align="left">
                                            &nbsp;<asp:Label ID="lbMarriage" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr class="tdLabel">
                                        <td align="left"><asp:Label ID="Label8" runat="server" CssClass="label" Text="Điện thoại làm việc :"></asp:Label></td>
                                    </tr>
                                    <tr class="tdValue">
                                        <td align="left">
                                            &nbsp;<asp:Label ID="lbWorkingPhone" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr class="tdLabel">
                                        <td align="left"><asp:Label ID="Label9" runat="server" CssClass="label" Text="Di động :"></asp:Label></td>
                                    </tr>
                                    <tr class="tdValue">
                                        <td align="left">
                                            &nbsp;<asp:Label ID="lbHandPhone" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                 </table>   
                            </td>                          
                        </tr>                      
                       <tr>
                           <td class="tdButton" colspan="2" align="center">                                
                               <asp:Button ID="btnCancel" runat="server" CssClass="small color green button" Text="Thoát" Width="100px" OnClientClick="javascript:self.close();"/>                                
                           </td>
                       </tr>
                    </table>
                </td>
            </tr>                                         
        </table>
       
    </div>
    </form>
</body>
</html>
