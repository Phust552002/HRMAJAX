<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ComparerDetail.aspx.cs" Inherits="CalculatedSalary_ComparerDetail" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="UserControls/CoefficientsAndWorkdays.ascx" TagName="CoefficientsAndWorkdays"
    TagPrefix="uc7" %>
<%@ Register Src="UserControls/CoefficientsAndWorkdaysSAC.ascx" TagName="CoefficientsAndWorkdaysSAC"
    TagPrefix="uc8" %>

<%@ Register Src="UserControls/IncomesSAC.ascx" TagName="IncomesSAC" TagPrefix="uc5" %>

<%@ Register Src="UserControls/Incomes.ascx" TagName="Incomes" TagPrefix="uc1" %>


<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/Tabs.ascx" TagName="ucTabs" TagPrefix="uc4" %>
<%@ Register Src="UserControls/LogCalculateSalary.ascx" TagName="LogCalculateSalary" TagPrefix="uc6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%">
        <tr>
            <td valign="top">
                <table style="width: 100%">
                    <tr>
                        <td colspan="2" valign="top">
                            <uc3:ucTitle ID="UcTitle1" runat="server" />
                        </td>
                    </tr>
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
                    <tr>
                        <td>
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
                                                                    <table style="width:100%; background-color:#faf0e6" class="tableBorder">
                                                                        <tr>
                                                                            <td align="center" style="width:50%" valign="top">
                                                                                <strong>Công Ty SAGS</strong>                                                                                
                                                                                </td>
                                                                            <td align="center" style="width:50%" valign="top">
                                                                                <strong>Tổng Công Ty</strong>
                                                                                </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="center" style="width:50%" valign="top">                                                                                
                                                                                <uc1:Incomes ID="Incomes1" runat="server" Visible="true" />
                                                                                </td>
                                                                            <td align="center" style="width:50%" valign="top">                                                                                
                                                                                <uc5:IncomesSAC ID="IncomesSAC1" runat="server" />
                                                                                </td>
                                                                        </tr>
                                                                    </table>                                                                                                                                                            
                                                                </asp:View>
                                                                <asp:View ID="Tab1" runat="server">
                                                                    <table style="width:100%; background-color:#faf0e6" class="tableBorder">
                                                                        <tr>
                                                                            <td align="center" style="width:50%" valign="top">
                                                                                <strong>Công Ty SAGS</strong>                                                                                
                                                                                </td>
                                                                            <td align="center" style="width:50%" valign="top">
                                                                                <strong>Tổng Công Ty</strong>
                                                                                </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="center" style="width:50%" valign="top">                                                                                
                                                                                <uc7:CoefficientsAndWorkdays ID="CoefficientsAndWorkdays1" runat="server" />
                                                                               
                                                                                </td>
                                                                            <td align="center" style="width:50%" valign="top">                                                                                
                                                                                <uc8:CoefficientsAndWorkdaysSAC ID="CoefficientsAndWorkdaysSAC1" runat="server" />
                                                                               
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
<script type="text/javascript" src="../JScripts/script.js"></script>
</asp:Content>

