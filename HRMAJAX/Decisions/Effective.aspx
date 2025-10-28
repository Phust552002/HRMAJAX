<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Effective.aspx.cs" Inherits="Decisions_Effective" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
<%@ Register Src="~/Contracts/UserControls/ContractFilter.ascx" TagName="ContractFilter" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/Title.ascx" TagName="Title" TagPrefix="uc3" %>

<%@ Register Src="../UserControls/LeftMenu.ascx" TagName="LeftMenu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td style="width:20%; height:500px" align="left" valign="top" class="LeftMenu" >
                <uc1:LeftMenu ID="LeftMenu1" runat="server" />
                <uc2:ContractFilter ID="ContractFilter1" runat="server" />
            </td>
            <td valign="top">
                <table cellpadding="0" cellspacing="0" style="width: 100%">
                    <tr>
                        <td>
                            <uc3:Title ID="Title1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table class="tableBorder" width="100%">
                                <tr>
                                    <td>
                                        <asp:GridView ID="grdContractEmployee" runat="server" AllowPaging="True" AllowSorting="True"
                                            AutoGenerateColumns="False" CssClass="grid-Border" DataSourceID="odsContractEmployees"
                                            OnRowDataBound="grdContractEmployee_RowDataBound" OnSorting="grdContractEmployee_Sorting"
                                            PageSize="25" Width="100%">
                                            <Columns>
                                                <asp:TemplateField HeaderText="Họ v&#224; t&#234;n" SortExpression="FullName">
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid" NavigateUrl='<%# Eval("UserId", "~/Contracts/DetailContractEmployee.aspx?UserId={0}") %>'
                                                            Text='<%# Eval("FullName") %>'></asp:HyperLink>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="ContractTypeName" HeaderText="Hợp đồng" SortExpression="ContractTypeName">
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="PositionName" HeaderText="Chức danh" SortExpression="PositionName">
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:BoundField>
                                                <asp:TemplateField HeaderText="Từ ng&#224;y " SortExpression="FromDate">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbFromDate" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Đến ng&#224;y" SortExpression="ToDate">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbToDate" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                            </Columns>
                                            <HeaderStyle CssClass="grid-header" />
                                            <RowStyle CssClass="grid-item" />
                                            <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                            <PagerStyle CssClass="grid-paper" />
                                            <EmptyDataTemplate>
                                                <asp:Label ID="Label1" runat="server" CssClass="value" Text="Không có dữ liệu"></asp:Label>
                                            </EmptyDataTemplate>
                                            <PagerSettings PageButtonCount="30" />
                                        </asp:GridView>
                                        <asp:ObjectDataSource ID="odsContractEmployees" runat="server" OldValuesParameterFormatString="original_{0}"
                                            OnSelected="odsContractEmployees_Selected" OnSelecting="odsContractEmployees_Selecting"
                                            SelectMethod="GetByFilter" SortParameterName="sortParameter" TypeName="HRMBLL.H0.EmployeeContractBLL">
                                            <SelectParameters>
                                                <asp:Parameter Name="fullName" Type="String" />
                                                <asp:Parameter Name="departmentId" Type="Int32" />
                                                <asp:Parameter Name="contractType" Type="Int32" />
                                                <asp:Parameter Name="sortParameter" Type="String" />
                                                <asp:Parameter Name="typeSort" Type="Int32" />
                                            </SelectParameters>
                                        </asp:ObjectDataSource>
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


