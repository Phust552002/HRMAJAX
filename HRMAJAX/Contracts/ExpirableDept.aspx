<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ExpirableDept.aspx.cs" Inherits="Contracts_ExpirableDept" %>
<%@ Register Src="UserControls/ContractFilter.ascx" TagName="ContractFilter" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/Title.ascx" TagName="Title" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/LeftMenu.ascx" TagName="LeftMenu" TagPrefix="uc1" %>
<%@ Register src="../Administrator/UserControls/ucPermission.ascx" tagname="ucPermission" tagprefix="uc4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td style="width:20%; height:500px" align="left" valign="top" class="LeftMenu" >                
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
                            <asp:Label ID="lbTitleRemindExpiredContracts" runat="server" CssClass="label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>
                             <table style="width: 100%" class="tableBorder">
                                <tr>
                                    <td>
                                        <asp:GridView ID="grdRemindExpiredContracts" runat="server" AllowSorting="True"
                                            AutoGenerateColumns="False" CssClass="grid-Border" DataSourceID="odsRemindExpiredContracts"
                                            OnRowDataBound="grdRemindExpiredContracts_RowDataBound"
                                            PageSize="20" Width="100%">
                                            <Columns>
                                                 <asp:BoundField DataField="OrderNumber" HeaderText="STT" SortExpression="OrderNumber">
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                                <asp:TemplateField HeaderText="Họ v&#224; t&#234;n" SortExpression="FullName">
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="ContractTypeCode" HeaderText="Hợp đồng" SortExpression="ContractTypeCode">
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
                                                <asp:TemplateField HeaderText="In mẫu nhận xét">
                                                    <ItemTemplate>
                                                        <asp:ImageButton ID="imgCalendar" runat="server" ImageUrl="~/Images/print.gif"/>
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
                                    </td>
                                </tr>
                            </table>
                            <asp:ObjectDataSource ID="odsRemindExpiredContracts" runat="server" OnSelecting="odsRemindExpiredContracts_Selecting" SelectMethod="RemindExpiredConstracts" TypeName="HRMBLL.H0.EmployeeContractBLL" OldValuesParameterFormatString="original_{0}">
                                <SelectParameters>
                                    <asp:Parameter Name="fullName" Type="String" />
                                    <asp:Parameter Name="deptId" Type="Int32" />
                                    <asp:Parameter Name="expireDate" Type="DateTime" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td class="tdButton">
                            <asp:Button ID="btnExcelExport" runat="server" CssClass="small color green button" OnClick="btnExcelExport_Click"
                                Text="Xuất Excel" /></td>
                    </tr>
                    <asp:Panel ID="pnContractChanged" runat="server">
                    <tr>
                        <td><br />
                            <asp:Label ID="lbTitleChangedContracts" runat="server" CssClass="label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>
                            <table style="width: 100%" class="tableBorder">
                                <tr>
                                    <td valign="top">
                                        <asp:GridView ID="grdChangedContracts" runat="server" AllowSorting="True"
                                            AutoGenerateColumns="False" CssClass="grid-Border" DataSourceID="odsChangedContracts"
                                            OnRowDataBound="grdChangedContracts_RowDataBound"
                                            PageSize="20" Width="100%">
                                            <Columns>
                                                <asp:TemplateField HeaderText="Họ v&#224; t&#234;n" SortExpression="FullName">
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="ContractTypeCode" HeaderText="Hợp đồng" SortExpression="ContractTypeCode">
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
                                    </td>
                                </tr>
                            </table>
                              <asp:ObjectDataSource ID="odsChangedContracts" runat="server" OnSelecting="odsChangedContracts_Selecting" OnSelected="odsChangedContract_Selected" SelectMethod="ChangedConstracts" TypeName="HRMBLL.H0.EmployeeContractBLL" OldValuesParameterFormatString="original_{0}">
                                 <SelectParameters>
                                    <asp:Parameter Name="fullName" Type="String" />
                                    <asp:Parameter Name="deptId" Type="Int32" />
                                    <asp:Parameter Name="month" Type="Int32" />
                                    <asp:Parameter Name="year" Type="Int32" />
                                    <asp:Parameter Name="typeSort" Type="Int32" />
                                 </SelectParameters>
                              </asp:ObjectDataSource>
                        </td>
                    </tr>
                    </asp:Panel>
                    <uc4:ucPermission ID="ucPermission1" runat="server" />
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

