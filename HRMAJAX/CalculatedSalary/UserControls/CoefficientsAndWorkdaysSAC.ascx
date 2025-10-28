<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CoefficientsAndWorkdaysSAC.ascx.cs" Inherits="CalculatedSalary_UserControls_CoefficientsAndWorkdaysSAC" %>

<table class="tableBorder" width="100%">
<tr>
    <td>  
        <asp:GridView ID="grdWorkdays" runat="server" AutoGenerateColumns="False" DataSourceID="odsWorkdays" Width="100%" CssClass="grid-Border" OnRowDataBound="grdWorkdays_RowDataBound">
            <Columns>
                <asp:TemplateField HeaderText="Số Ng&#224;y" SortExpression="Value">
                    <ItemTemplate>
                        <asp:Label ID="lbValue" runat="server"></asp:Label>
                    </ItemTemplate>
                    <ItemStyle Width="10%" HorizontalAlign="Right" />
                </asp:TemplateField>
                <asp:BoundField DataField="Description" HeaderText="Ng&#224;y c&#244;ng" SortExpression="Description">
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
            </Columns>            
            <EmptyDataTemplate>
                <asp:Label ID="Label4" runat="server" CssClass="value" Text="Thông tin tháng này chưa có"></asp:Label>
            </EmptyDataTemplate>
            <HeaderStyle CssClass="grid-header" /> 
            <RowStyle CssClass ="grid-item" />
            <AlternatingRowStyle CssClass="grid-atlternating-item" />    
            <PagerStyle CssClass="grid-paper" />    
        </asp:GridView>
        <asp:ObjectDataSource ID="odsWorkdays" runat="server" OnSelecting="odsWorkdays_Selecting"
            SelectMethod="GetByUserId_Monthly" TypeName="HRMBLL.H.TimeKeepingBLL" OldValuesParameterFormatString="original_{0}">
            <SelectParameters>
                <asp:Parameter Name="userId" Type="Int32" />
                <asp:Parameter Name="month" Type="Int32" />
                <asp:Parameter Name="year" Type="Int32" />
                <asp:Parameter Name="type" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
     </td>
    </tr>
</table>
 <table class="tableBorder" width="100%">
    <tr>
        <td>  
         <asp:GridView ID="grdCoefficients" runat="server" AutoGenerateColumns="False" DataSourceID="odsCoefficients" CssClass="grid-Border" Width="100%" OnRowDataBound="grdCoefficients_RowDataBound">
            <Columns>
                <asp:TemplateField HeaderText="Gi&#225; Trị" SortExpression="Value">                   
                    <ItemTemplate>
                        <asp:Label ID="lbValue" runat="server" ></asp:Label>
                    </ItemTemplate>
                    <ItemStyle Width="10%" HorizontalAlign="Right" />
                </asp:TemplateField>
                <asp:BoundField DataField="Description" HeaderText="Hệ số" SortExpression="Description">
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
            </Columns>
             <EmptyDataTemplate>
                 <asp:Label ID="Label4" runat="server" CssClass="value"></asp:Label>
             </EmptyDataTemplate>
             <HeaderStyle CssClass="grid-header" /> 
            <RowStyle CssClass ="grid-item" />
            <AlternatingRowStyle CssClass="grid-atlternating-item" />    
            <PagerStyle CssClass="grid-paper" />  
        </asp:GridView>
        <asp:ObjectDataSource ID="odsCoefficients" runat="server" OnSelecting="odsCoefficients_Selecting"
            SelectMethod="GetByUserId_Monthly" TypeName="HRMBLL.H.CoefficientsBLL" OldValuesParameterFormatString="original_{0}">
            <SelectParameters>
                <asp:Parameter Name="userId" Type="Int32" />
                <asp:Parameter Name="month" Type="Int32" />
                <asp:Parameter Name="year" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        </td>
    </tr>
</table>
 <table class="tableBorder" width="100%">
    <tr>
        <td>  
        <asp:GridView ID="grdTimeKeeping" runat="server" AutoGenerateColumns="False" DataSourceID="odsTimeKeepings" Width="100%" CssClass="grid-Border" OnRowDataBound="grdTimeKeeping_RowDataBound">
            <Columns>
                <asp:TemplateField HeaderText="Số Giờ" SortExpression="Value">
                    <ItemTemplate>
                        <asp:Label ID="lbValue" runat="server"></asp:Label>
                    </ItemTemplate>
                    <ItemStyle Width="10%" HorizontalAlign="Right" />
                </asp:TemplateField>
                <asp:BoundField DataField="Description" HeaderText="Giờ C&#244;ng" SortExpression="Description">
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
            </Columns>
            <EmptyDataTemplate>
                <asp:Label ID="Label4" runat="server" CssClass="value"></asp:Label>
            </EmptyDataTemplate>
            <HeaderStyle CssClass="grid-header" /> 
            <RowStyle CssClass ="grid-item" />
            <AlternatingRowStyle CssClass="grid-atlternating-item" />    
            <PagerStyle CssClass="grid-paper" />  
        </asp:GridView>
        <asp:ObjectDataSource ID="odsTimeKeepings" runat="server" OnSelecting="odsTimeKeepings_Selecting"
            SelectMethod="GetByUserId_Monthly" TypeName="HRMBLL.H.TimeKeepingBLL" OldValuesParameterFormatString="original_{0}">
            <SelectParameters>
                <asp:Parameter Name="userId" Type="Int32" />
                <asp:Parameter Name="month" Type="Int32" />
                <asp:Parameter Name="year" Type="Int32" />
                <asp:Parameter Name="type" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
     </td>
   </tr>
</table>
        