<%@ Control Language="C#" AutoEventWireup="true" CodeFile="IncomesSAC.ascx.cs" Inherits="CalculatedSalary_UserControls_IncomesSAC" %>
<table width="100%" class="tableBorder">
    <tr>
        <td>
<asp:GridView ID="grdInocomesMonth" runat="server" AutoGenerateColumns="False" CssClass="grid-Border"
    DataSourceID="odsIncomesMonth" Width="100%" OnRowDataBound="grdInocomesMonth_RowDataBound">
    <Columns>
        <asp:TemplateField HeaderText="Số Tiền (VND)" SortExpression="FileCode">
            <ItemStyle HorizontalAlign="Right" Width="20%"/>
            <ItemTemplate>
                <asp:Label ID="lbValue" runat="server"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="Description" HeaderText="C&#225;c Khoản Thu Nhập" SortExpression="Description">
            <ItemStyle HorizontalAlign="Right" />
        </asp:BoundField>
    </Columns>
    <EmptyDataTemplate>
        <asp:Label ID="Label4" runat="server" CssClass="value" Text="Thông tin tháng này chưa có"></asp:Label>
    </EmptyDataTemplate>
    <HeaderStyle CssClass="grid-header" />
    <RowStyle CssClass="grid-item" />
    <AlternatingRowStyle CssClass="grid-atlternating-item" />
    <PagerStyle CssClass="grid-paper" />
</asp:GridView>
<asp:ObjectDataSource ID="odsIncomesMonth" runat="server" OnSelecting="odsIncomesMonth_Selecting"
    SelectMethod="GetByUserId_Monthly" TypeName="HRMBLL.H.IncomesMonthBLL">
    <SelectParameters>
        <asp:Parameter Name="userId" Type="Int32" />
        <asp:Parameter Name="month" Type="Int32" />
        <asp:Parameter Name="year" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>
        </td>
    </tr>
</table>

<table width="100%" class="tableBorder">
    <tr>
        <td>        
<asp:GridView ID="grdContributions" runat="server" AutoGenerateColumns="False" CssClass="grid-Border"
    DataSourceID="odsContributions" Width="100%" OnRowDataBound="grdContributions_RowDataBound">
    <Columns>
        <asp:TemplateField HeaderText="Số Tiền (VND)" SortExpression="Value">
            <ItemTemplate>
                <asp:Label ID="lbValue" runat="server" ></asp:Label>
            </ItemTemplate>
            <ItemStyle HorizontalAlign="Right" Width="20%"/>
        </asp:TemplateField>
        <asp:BoundField DataField="Description" HeaderText="C&#225;c Khoản Phải Nộp" SortExpression="Description">
            <ItemStyle HorizontalAlign="Right" />
        </asp:BoundField>
    </Columns>
    <EmptyDataTemplate>
        <asp:Label ID="Label4" runat="server" CssClass="value"></asp:Label>
    </EmptyDataTemplate>
    <HeaderStyle CssClass="grid-header" />
    <RowStyle CssClass="grid-item" />
    <AlternatingRowStyle CssClass="grid-atlternating-item" />
    <PagerStyle CssClass="grid-paper" />
</asp:GridView>
<asp:ObjectDataSource ID="odsContributions" runat="server" OnSelecting="odsContributions_Selecting"
    SelectMethod="GetByUserId_Monthly" TypeName="HRMBLL.H.IncomesMonthBLL">
    <SelectParameters>
        <asp:Parameter Name="userId" Type="Int32" />
        <asp:Parameter Name="month" Type="Int32" />
        <asp:Parameter Name="year" Type="Int32" />
        <asp:Parameter Name="type" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
        </td>
   </tr>
</table>   
        