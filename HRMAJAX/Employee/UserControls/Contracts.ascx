<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Contracts.ascx.cs" Inherits="Employee_UserControls_Contracts" %>

<%@ Register Src="~/Contracts/UserControls/History.ascx" TagName="History" TagPrefix="uc5" %>
<%@ Register Src="~/Contracts/UserControls/Add.ascx" TagName="Add" TagPrefix="uc6" %>
<%@ Register Src="~/UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc1" %>
<%@ Register Src="../../UserControls/TabSub.ascx" TagName="TabSub" TagPrefix="uc1" %>

<table style="width: 100%">                      
    <tr>
        <td>
            <fieldset class="fieldset" style="padding:2px 2px 2px 2px">
                <legend class="legend"> Thông Tin Cá Nhân</legend>
                     <table style="width: 100%">                                        
                        <tr>
                            <td align="center">
                                <table style="width: 99%" class="tableBorder">
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label1" runat="server" CssClass="label" Text="Họ và tên"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbFullName" runat="server" CssClass="value"></asp:Label></td>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label3" runat="server" CssClass="label" Text="Ngày vào ngành hàng không"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbAviationJoinDate" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label2" runat="server" CssClass="label" Text="Phòng ban"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbDeparment" runat="server" CssClass="value"></asp:Label></td>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label4" runat="server" CssClass="label" Text="Chức danh"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbPosition" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>                                                  
                                </table>
                             </td>
                          </tr>      
                      </table>          
            </fieldset>
        </td>                
    </tr>
    <tr>
        <td>
             <table width="100%" cellpadding="0" cellspacing="0">
                <tr>
                    <td>
                        <uc1:TabSub ID="TabItems" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <table width="100%" class="borderMultiViewSub" cellpadding="0" cellspacing="1">
                            <tr>
                                <td>                                        
                                    <table width="100%" style="background-color:#ffffff">
                                        <tr>
                                            <td style="width: 100%">
                                                <asp:MultiView ID="MultiTabs" runat="server">
                                                    <asp:View ID="Tab0" runat="server">
                                                        <table style="width: 100%">
                                                            <tr>
                                                                <td>                                                                            
                                                                    <uc5:History ID="History1" runat="server" />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:View>
                                                    <asp:View ID="Tab1" runat="server">
                                                        <table style="width: 100%">
                                                            <tr>
                                                                <td>
                                                                    <uc6:Add ID="Add" runat="server" />
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