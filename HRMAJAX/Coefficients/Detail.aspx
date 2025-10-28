<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Detail.aspx.cs" Inherits="Coefficients_Detail" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="UserControls/UpdCoefficientFinal.ascx" TagName="UpdCoefficientFinal"
    TagPrefix="uc7" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="UserControls/LCB.ascx" TagName="LCB" TagPrefix="uc5" %>
<%@ Register Src="UserControls/Others.ascx" TagName="Others" TagPrefix="uc6" %>
<%@ Register Src="UserControls/List.ascx" TagName="List" TagPrefix="uc2" %>
<%@ Register Src="UserControls/LNS.ascx" TagName="LNS" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/Tabs.ascx" TagName="Tabs" TagPrefix="uc4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table style="width: 100%">
    <tr>
        <td valign="top">
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
                                    <table width="100%" class="borderMultiView" cellpadding="0" cellspacing="1">
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
                                                                <asp:View ID="Tab4" runat="server">
                                                                    <table style="width: 100%">
                                                                        <tr>
                                                                            <td>
                                                                                <uc7:UpdCoefficientFinal ID="UpdCoefficientFinal1" runat="server" />
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
</asp:Content>

