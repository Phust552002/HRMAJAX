<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Personal.ascx.cs" Inherits="Employee_UserControls_Personal" %>
<%@ Register Src="Personal/DetailInfor.ascx" TagName="DetailInfor" TagPrefix="uc3" %>
<%@ Register Src="Personal/GeneralInfo.ascx" TagName="GeneralInfo" TagPrefix="uc2" %>
<%@ Register Src="../../UserControls/TabSub.ascx" TagName="TabSub" TagPrefix="uc1" %>
<table width="100%">   
    <tr>
        <td align="center" valign="top">
            <table width="100%" >
                <tr>
                    <td valign="top" align="left" >
                       <fieldset class="fieldset" style="padding:2px 2px 2px 2px">
                                <legend class="legend"> Thông Tin Cá Nhân</legend>
                                    <table style="width: 100%">                                        
                                        <tr>
                                            <td align="center">
                                                <table style="width: 99%" class="tableBorder">
                                                    <tr>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label1" runat="server" Text="Họ và tên" CssClass="label"></asp:Label></td>
                                                        <td class="tdValue" >
                                                            <asp:Label ID="lbFullName" runat="server" CssClass="value"></asp:Label></td>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label4" runat="server" Text="Phòng ban" CssClass="label"></asp:Label></td>
                                                        <td class="tdValue"> &nbsp;<asp:Label ID="lbDepartment" runat="server" CssClass="value"></asp:Label></td>
                                                        <%--<td class="tdLabel">
                                                            <asp:Label ID="Label5" runat="server" Text="Phép năm(F) tối đa<br/>được nghỉ/ đã nghỉ" CssClass="label"></asp:Label></td>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="lbMaxF" runat="server" CssClass="label"></asp:Label></td>--%>
                                                    </tr>
                                                    <tr>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label3" runat="server" Text="Tên truy cập" CssClass="label"></asp:Label></td>
                                                        <td class="tdValue">
                                                            <asp:Label ID="lbUserName" runat="server" CssClass="value"></asp:Label></td>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label2" runat="server" Text="Chức danh" CssClass="label"></asp:Label></td>
                                                        <td class="tdValue"> 
                                                            <asp:Label ID="lbPosition" runat="server" CssClass="value"></asp:Label></td>
                                                        <%--<td class="tdLabel">
                                                            <asp:Label ID="Label6" runat="server" Text="Phép Ốm(Om) tối đa<br/>được nghỉ/ đã nghỉ" CssClass="label"></asp:Label></td>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="lbMaxOm" runat="server" CssClass="label"></asp:Label></td>--%>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>                                        
                                    </table>
                            </fieldset>                      
                    </td>
                </tr>         
                <tr>
                    <td align="center" valign="top">
                      <table width="100%" cellpadding="0" cellspacing="0"> 
                        <tr>
                            <td align="right">
                                <uc1:TabSub ID="TabSub1" runat="server" />
                            </td>
                        </tr>                       
                        <tr>
                            <td>
                                <table width="100%" class="borderMultiViewSub" cellpadding="0" cellspacing="1">
                                    <tr>
                                        <td>                                        
                                            <table width="100%" bgcolor="#ffffff">
                                                <tr>
                                                    <td>
                                                        <asp:MultiView ID="MultiTabs" runat="server">
                                                            <asp:View ID="Tab0" runat="server">
                                                                <table style="width: 100%">
                                                                    <tr>
                                                                        <td>                                                                        
                                                                            <uc2:GeneralInfo ID="GeneralInfo1" runat="server" />
                                                                            
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:View>
                                                            <asp:View ID="Tab1" runat="server">
                                                                <table style="width: 100%">
                                                                    <tr>
                                                                        <td>
                                                                            <uc3:DetailInfor ID="DetailInfor1" runat="server" />
                                                                            
                                                                        
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:View>                                                            
                                                            
                                                        </asp:MultiView>
                                                     </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    
                                </table> 
                            </td>
                        </tr>
                        
                      </table>   
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table> 