<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="OptionCalculation.aspx.cs" Inherits="CalculatedSalary_Fixed_UnitPrices_OptionCalculation" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>

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
                                    <td align="left" class="tdValue" colspan="2">
                                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Tính lương theo đơn giá cố định"></asp:Label></td>
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
                                <tr>
                                    <td colspan="2" class="tdButton" align="center">
                                        <asp:Button ID="btnCalculate" runat="server" Text="Tiếp tục" CssClass="small color green button" OnClick="btnCalculate_Click" Width="100px" />
                                        &nbsp;
                                        <asp:Button ID="btnCancel" runat="server" CssClass="small color green button" OnClick="btnCancel_Click"
                                            Text="Quay về" Width="100px" /></td>
                                </tr>
                            </table>                                                       
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

