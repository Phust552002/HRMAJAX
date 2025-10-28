<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Options.aspx.cs" Inherits="CalculatedSalary_Options" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" class="bgEachPage">        
        <tr>
            <td valign="top">
                <table style="width: 100%">                    
                     <tr>
                        <td align="left">
                            <uc2:ucTitle ID="UcTitle1" runat="server" />
                        </td>
                    </tr>                    
                    <tr>
                        <td align="center" >
                            <table class="tableBorder">                               
                                <tr>
                                    <td align="left" class="tdLabel">
                                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Tính lương"></asp:Label></td>
                                    <td align="left" class="tdValue">
                                        <asp:DropDownList ID="ddlUnitPriceType" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlUnitPriceType_SelectedIndexChanged">
                                            <asp:ListItem Value="1">Kỳ I - Lương ngắn hạn</asp:ListItem>
                                            <asp:ListItem Value="2">Kỳ II - Lương năng suất</asp:ListItem>
                                            <asp:ListItem Value="3">Kỳ III - Lương từ quỹ dư</asp:ListItem>
                                        </asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td class="tdLabel" align="left">
                                        <asp:Label ID="Label1" runat="server" Text="Phòng ban" CssClass="label"></asp:Label></td>
                                    <td class="tdValue" align="left">
                                        <asp:DropDownList ID="ddlDepartments" runat="server" CssClass="dropDownList" DataSourceID="odsDepartments" DataTextField="DepartmentName" DataValueField="DepartmentId">
                                        </asp:DropDownList>
                                        <asp:ObjectDataSource ID="odsDepartments" runat="server" SelectMethod="GetAllRoots"
                                            TypeName="HRMBLL.H0.DepartmentsBLL" OldValuesParameterFormatString="original_{0}"></asp:ObjectDataSource>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="tdLabel" align="left">
                                        <asp:Label ID="Label2" runat="server" Text="Tháng năm" CssClass="label"></asp:Label></td>
                                    <td class="tdValue" align="left">
                                        <asp:Label ID="lbDate" runat="server" CssClass="value"></asp:Label></td>
                                </tr>
                                <asp:Panel ID="pnApportionment" runat="server" Visible ="false">                            
                                <tr>
                                    <td class="tdLabel" align="left">
                                        <asp:Label ID="Label3" runat="server" Text="Phân bổ quỹ dư theo" CssClass="label"></asp:Label></td>
                                    <td class="tdValue" align="left">
                                        <asp:RadioButton ID="rdoSags" runat="server" CssClass="value" GroupName="Apportionment"
                                            Text="Công ty" AutoPostBack="True" OnCheckedChanged="rdoSags_CheckedChanged" Checked="true"/>&nbsp;
                                        <asp:RadioButton ID="rdoDepartment" runat="server" CssClass="value" GroupName="Apportionment"
                                            Text="Phòng" AutoPostBack="True" OnCheckedChanged="rdoDepartment_CheckedChanged" /></td>
                                </tr>
                                </asp:Panel>
                                <tr>
                                    <td colspan="2" class="tdButton" align="center">
                                        <asp:Button ID="btnCalculate" runat="server" Text="Tiếp tục" CssClass="small color green button" OnClick="btnCalculate_Click" Width="100px" /></td>
                                </tr>
                            </table>                                                       
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

