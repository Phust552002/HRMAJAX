<%@ Control Language="C#" AutoEventWireup="true" CodeFile="List.ascx.cs" Inherits="Coefficients_UserControls_List" %>
<table style="width: 99%" class="tableBorder">
    <tr>
        <td>
            <asp:GridView ID="grdCoefficients" runat="server" AutoGenerateColumns="False" DataSourceID="odsCoefficients" OnRowDataBound="grdCoefficients_RowDataBound" CssClass="grid-Border" Width="100%">
                <Columns>
                    <asp:TemplateField HeaderText="LNS" SortExpression="LNS">
                        <ItemStyle HorizontalAlign="Center" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemTemplate>
                            <asp:Label ID="lbLNS" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="LCB" SortExpression="LCB">
                        <ItemStyle HorizontalAlign="Center" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemTemplate>
                            <asp:Label ID="lbLCB" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="PCDH" SortExpression="PCDH">
                        <ItemStyle HorizontalAlign="Center" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemTemplate>
                            <asp:Label ID="lbPCDH" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="PCTN" SortExpression="PCTN">
                        <ItemStyle HorizontalAlign="Right" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemTemplate>
                            <asp:Label ID="lbPCTN" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="PCKV" SortExpression="PCKV">
                        <ItemStyle HorizontalAlign="Right" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemTemplate>
                            <asp:Label ID="lbPCKV" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="PCCV" SortExpression="PCCV">
                        <ItemStyle HorizontalAlign="Right" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemTemplate>
                            <asp:Label ID="lbPCCV" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <HeaderStyle CssClass="grid-header" /> 
                <RowStyle CssClass ="grid-item" />
                <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                <PagerStyle CssClass="grid-paper" /> 
                <EmptyDataTemplate>
                    <asp:Label ID="Label1" runat="server" CssClass="value" Text="Chưa có thông tin hệ số về nhân viên."></asp:Label>
                </EmptyDataTemplate>
            </asp:GridView>
            <asp:ObjectDataSource ID="odsCoefficients" runat="server" OnSelecting="odsCoefficients_Selecting"
                SelectMethod="AllCoefficientEmployeeGetByUserId" TypeName="HRMBLL.H1.CoefficientEmployeesBLL" OldValuesParameterFormatString="original_{0}">
                <SelectParameters>
                    <asp:Parameter Name="userId" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </td>
    </tr> 
</table>
