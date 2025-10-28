<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BSDT.ascx.cs" Inherits="Bonus_UserControls_BSDT" %>

                                
<table style="width: 100%">
    
    <tr>
        <td>
            <table class="tableBorder" width="100%">
            <tr>
                <td>  
                    <asp:GridView ID="grdBSDT" runat="server" AutoGenerateColumns="False" DataSourceID="odsBSDT" CssClass="grid-Border" Width="100%" OnRowDataBound="grdBSDT_RowDataBound">
                            <Columns>
                                <asp:TemplateField HeaderText="M&#244; tả" SortExpression="Description">                                                    
                                    <ItemTemplate>
                                        <asp:Label ID="lbName" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Số tiền ( VND )" SortExpression="BonusValue">                                                   
                                    <ItemStyle HorizontalAlign="Right" />
                                    <HeaderStyle HorizontalAlign="Right" />
                                    <ItemTemplate>
                                        <asp:Label ID="lbMoney" runat="server"></asp:Label>
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
                    <asp:ObjectDataSource ID="odsBSDT" runat="server" OnSelecting="odsBSDT_Selecting"
                            SelectMethod="GetAll" TypeName="HRMBLL.H.BonusValuesBLL" OldValuesParameterFormatString="original_{0}">
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
                            
  