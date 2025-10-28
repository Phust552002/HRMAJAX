<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Coefficients.ascx.cs" Inherits="Employee_UserControls_Coefficients" %>
<%@ Register Src="~/Coefficients/UserControls/LCB.ascx" TagName="LCB" TagPrefix="uc5" %>
<%@ Register Src="~/Coefficients/UserControls/Others.ascx" TagName="Others" TagPrefix="uc6" %>
<%@ Register Src="~/Coefficients/UserControls/List.ascx" TagName="List" TagPrefix="uc2" %>
<%@ Register Src="~/Coefficients/UserControls/LNS.ascx" TagName="LNS" TagPrefix="uc3" %>
<%@ Register Src="~/UserControls/TabSub.ascx" TagName="Tabs" TagPrefix="uc4" %>

<table style="width: 100%">                             
    <tr>
        <td>
             <table style="width: 100%" class="tableBorder">
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
    <tr>
        <td valign="top">
             <table width="100%" cellpadding="0" cellspacing="0">
                <tr>
                    <td>
                        <uc4:Tabs ID="TabItems" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <table width="100%" class="borderMultiViewSub" cellpadding="0" cellspacing="1">
                            <tr>
                                <td>                                        
                                    <table width="100%" style="background-color:#ffffff" cellpadding="0" cellspacing="1">
                                        <tr>
                                            <td>
                                                <asp:MultiView ID="MultiTabs" runat="server">                                                               
                                                    
                                                    <asp:View ID="Tab1" runat="server">
                                                        <table style="width: 100%">
                                                            <tr>
                                                                <td>
                                                                    <uc3:LNS ID="LNS" runat="server" />                                                                
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:View>
                                                    <asp:View ID="Tab2" runat="server">
                                                        <table style="width: 100%">
                                                            <tr>
                                                                <td>
                                                                    <uc5:LCB ID="LCB" runat="server" />
                                                                
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:View>
                                                    <asp:View ID="Tab3" runat="server">
                                                        <table style="width: 100%">
                                                            <tr>
                                                                <td>
                                                                    <uc6:Others ID="Others" runat="server" />
                                                                
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