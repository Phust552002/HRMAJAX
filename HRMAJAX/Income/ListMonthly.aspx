<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ListMonthly.aspx.cs" Inherits="Income_ListMonthlyStaffIncomes" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>

<%@ Register Src="~/UserControls/DateDepartmentFilter.ascx" TagName="DateDepartmentFilter" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" class="bgEachPage">
<tr>
    <td valign="top">
        <table width="100%" border="0">
            <tr>
                <td>
                    <uc2:ucTitle ID="UcTitle1" runat="server" />
                </td>
            </tr>
            <tr>
                <td align="right">
                    <uc1:DateDepartmentFilter ID="DateDepartmentFilter1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                 <table class="tableBorder" width="100%">
                    <tr>
                        <td> 
                            <asp:GridView ID="grdListMonthlyStaffIncomes" runat="server" AutoGenerateColumns="False"
                                DataSourceID="odsEmployeeIncomes" Width="100%" 
                                OnRowDataBound="grdListMonthlyStaffIncomes_RowDataBound" PageSize="50" 
                                CssClass="grid-Border" AllowPaging="True" ShowFooter="True" 
                                DataKeyNames="UserId"> 
                                <Columns>
                                    <asp:BoundField DataField="UserId" DataFormatString="{0:000#}" HeaderText="M&#227; Nh&#226;n Vi&#234;n"
                                        SortExpression="UserId">
                                        </asp:BoundField>
                                    <asp:TemplateField HeaderText="T&#234;n Nh&#226;n Vi&#234;n" SortExpression="FullName">
                                        <ItemTemplate>
                                            <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid">[lnkFullName]</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Tổng C&#225;c Khoản Thu Nhập" SortExpression="Total_Inc">
                                        <ItemStyle HorizontalAlign="Right" />
                                        <ItemTemplate>
                                            <asp:Label ID="lbTotalIncome" runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:Label ID="lbSumTotal_Inc" runat="server"></asp:Label>
                                        </FooterTemplate>
                                        <FooterStyle HorizontalAlign="Right" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Tổng C&#225;c Khoản Phải Nộp" SortExpression="Total_Cntr">
                                        <ItemStyle HorizontalAlign="Right" />
                                        <ItemTemplate>
                                            <asp:Label ID="lbTotalPaid" runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:Label ID="lbSumTotal_Cntr" runat="server"></asp:Label>
                                        </FooterTemplate>
                                        <FooterStyle HorizontalAlign="Right" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Tổng Thu Nhập Thực Lĩnh" SortExpression="RealIncome">
                                        <ItemStyle HorizontalAlign="Right" />
                                        <ItemTemplate>
                                            <asp:Label ID="lbThucLinh" runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:Label ID="lbSumTotal_RealIncome" runat="server"></asp:Label>
                                        </FooterTemplate>
                                        <FooterStyle HorizontalAlign="Right" />
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="DataDate" HeaderText="Th&#225;ng" 
                                        SortExpression="Date" HtmlEncode="False" DataFormatString="{0:MM/yyyy}">
                                        <ItemStyle HorizontalAlign="Center" />
                                        </asp:BoundField>
                                </Columns>
                               
                                <EmptyDataTemplate>
                                    <asp:Label ID="Label1" runat="server" CssClass="value" Text="Thông tin lương tháng này chưa có"></asp:Label>
                                </EmptyDataTemplate>
                                <HeaderStyle CssClass="grid-header" /> 
                                <FooterStyle CssClass="grid-footer" />
                                <RowStyle CssClass ="grid-item" />
                                <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                <PagerStyle CssClass="grid-paper" />
                                <PagerSettings PageButtonCount="30" />
                            </asp:GridView>
                            <asp:ObjectDataSource ID="odsEmployeeIncomes" runat="server" OldValuesParameterFormatString="original_{0}"
                                SelectMethod="GetDTByFilter" TypeName="HRMBLL.H.EmployeeIncomeBLL" OnSelecting="odsEmployeeIncomes_Selecting" OnSelected="odsEmployeeIncomes_Selected">
                                <SelectParameters>
                                    <asp:Parameter Name="fullName" Type="String" />
                                    <asp:Parameter Name="DepartmentIds" Type="String" />
                                    <asp:Parameter Name="RootId" Type="Int32" />
                                    <asp:Parameter Name="month" Type="Int32" />
                                    <asp:Parameter Name="year" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                         </td>
                        </tr>
                    </table>
                    <uc3:ucPermission ID="UcPermission1" runat="server" />
                </td>
            </tr>
        </table>
    </td>
</tr>
</table>

</asp:Content>

