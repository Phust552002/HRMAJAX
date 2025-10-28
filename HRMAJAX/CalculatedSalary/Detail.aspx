<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Detail.aspx.cs" Inherits="CalculatedSalary_Detail" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="UserControls/LogCalculateSalary.ascx" TagName="LogCalculateSalary" TagPrefix="uc6" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc5" %>

<%@ Register Src="UserControls/Incomes.ascx" TagName="Incomes" TagPrefix="uc2" %>
<%@ Register Src="UserControls/CoefficientsAndWorkdays.ascx" TagName="CoefficientsAndWorkdays" TagPrefix="uc3" %>
<%@ Register Src="~/UserControls/HeaderContent.ascx" TagName="HeaderContent" TagPrefix="uc1" %>
<%@ Register Src="../UserControls/Tabs.ascx" TagName="ucTabs" TagPrefix="uc4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" class="bgEachPage">   
    <tr>
        <td align="center" valign="top">
            <table width="100%">
                <tr>
                    <td>
                        <uc5:ucTitle ID="UcTitle1" runat="server" /></td>
                </tr>
                <tr>
                    <td align="left">
                        
                        <table style="width: 100%">                            
                            <tr>
                                <td>
                                    <table style="width: 100%" class="tableBorder">
                                        <tr>
                                            <td class="tdLabel" style="width: 7%">
                                                <asp:Label ID="Label1" runat="server" Text="Họ và tên" CssClass="label"></asp:Label></td>
                                            <td colspan="3" class="tdValue">
                                                <asp:Label ID="lbFullName" runat="server" CssClass="value"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label3" runat="server" Text="Chức danh" CssClass="label"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:Label ID="lbPosition" runat="server" CssClass="value"></asp:Label></td>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label4" runat="server" Text="Phòng ban" CssClass="label"></asp:Label></td>
                                            <td class="tdValue"> 
                                                <asp:Label ID="lbDepartment" runat="server" CssClass="value"></asp:Label></td>
                                        </tr>
                                    </table> 
                                </td>
                            </tr>
                        </table>
                        
                    </td>
                </tr>
                <tr>
                    <td align="left">
                    <table width="100%" cellpadding="0" cellspacing="0">
                        <tr>
                            <td>
                                <uc4:ucTabs ID="TabItems" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table width="100%" class="borderMultiView"  cellspacing="0">
                                    <tr>
                                        <td>                                        
                                            <table width="100%" style="background-color:White">
                                                    <tr>
                                                        <td>
                                                            <asp:MultiView ID="MultiTabs" runat="server">
                                                                <asp:View ID="Tab0" runat="server">
                                                                    <table style="width: 100%">
                                                                        <tr>
                                                                            <td>
                                                                                <uc2:Incomes ID="Incomes" runat="server" />
                                                                                
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </asp:View>
                                                                <asp:View ID="Tab1" runat="server">
                                                                    <table style="width: 100%">
                                                                        <tr>
                                                                            <td>
                                                                                <uc3:CoefficientsAndWorkdays ID="CoefficientsAndWorkdays" runat="server" />
                                                                                
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </asp:View>                                                
                                                                <asp:View ID="Tab2" runat="server">
                                                                    <table style="width: 100%">
                                                                        <tr>
                                                                            <td>
                                                                                <uc6:LogCalculateSalary ID="LogCalculateSalary1" runat="server" />
                                                                                
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </asp:View>
                                                                <asp:View ID="Tab3" runat="server">
                                                                    <table style="width: 100%">
                                                                        <tr>
                                                                            <td>
                                                                                <uc6:LogCalculateSalary ID="LogCalculateSalary2" runat="server" />
                                                                                
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </asp:View>   
                                                                <asp:View ID="Tab4" runat="server">
                                                                    <table style="width: 100%">
                                                                        <tr>
                                                                            <td>
                                                                                <uc6:LogCalculateSalary ID="LogCalculateSalary3" runat="server" />                                                                                
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </asp:View>   
                                                                <asp:View ID="Tab5" runat="server">
                                                                    <table style="width: 100%">
                                                                        <tr>
                                                                            <td>
                                                                                <uc6:LogCalculateSalary ID="LogCalculateSalary4" runat="server" />                                                                                
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
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>        
</asp:Content>

