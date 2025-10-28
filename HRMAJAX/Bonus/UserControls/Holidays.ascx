<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Holidays.ascx.cs" Inherits="Bonus_UserControls_Holidays" %>
<table style="width: 100%">
    <tr>
        <td>
        <table class="tableBorder" width="100%">
            <tr>
                <td>  
                    <asp:GridView ID="grdHolidays" runat="server" AutoGenerateColumns="False" DataSourceID="odsHolidays"
                        Width="100%" CssClass="grid-Border" OnRowDataBound="grdHolidays_RowDataBound">
                        <Columns>
                            <asp:TemplateField HeaderText="Thưởng lễ " SortExpression="Description">
                                <ItemTemplate>
                                    <asp:Label ID="lbName" runat="server"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Số tiền ( VND )" SortExpression="BonusValue">
                                <ItemStyle HorizontalAlign="Right" />
                                <ItemTemplate>
                                    <asp:Label ID="lbBonusValue" runat="server"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EmptyDataTemplate>
                            <asp:Label ID="Label1" runat="server" CssClass="value" Text="Chưa có thông tin về tiền thưởng"></asp:Label>
                        </EmptyDataTemplate> 
                         <HeaderStyle CssClass="grid-header" /> 
                        <RowStyle CssClass ="grid-item" />
                        <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                        <PagerStyle CssClass="grid-paper" />                
                    </asp:GridView>
                    <asp:ObjectDataSource ID="odsHolidays" runat="server" OnSelecting="odsHolidays_Selecting"
                        SelectMethod="GetAll" TypeName="HRMBLL.H.BonusValuesBLL">
                        <SelectParameters>
                            <asp:Parameter Name="userId" Type="Int32" />
                            <asp:Parameter Name="year" Type="Int32" />
                            <asp:Parameter Name="type" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    </td>
            </tr>
        </table>
        </td>
    </tr>
</table>
