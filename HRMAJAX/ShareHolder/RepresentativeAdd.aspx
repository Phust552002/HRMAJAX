<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="RepresentativeAdd.aspx.cs" Inherits="ShareHolder_RepresentativeAdd" %>
<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>
<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc5" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%">   
    <tr>
        <td align="center" valign="top">
            <table width="100%">
                <tr>
                    <td>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
                            <ContentTemplate>  
                                <uc5:ucTitle ID="UcTitle1" runat="server" /> 
                            </ContentTemplate>
                             <%--<Triggers>
                                <asp:AsyncPostBackTrigger ControlID="imgSearch" EventName="Click" />
                             </Triggers>--%>
                        </asp:UpdatePanel>                      
                    </td>
                </tr>
          
                <tr>
                    <td align="left">
                        <table class="tableBorder" width="100%">
                         <tr>
                            <td>  
                                 <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                                 <ContentTemplate>
                                 <table class="tableBorder" width="100%">
                                    <tr>
                                        <td>
                                            <asp:GridView id="grdShareHolder" runat="server" Width="100%" 
                                                CssClass="grid-Border" AllowSorting="True" 
                                         AllowPaging="True" PageSize="20" OnRowDataBound="grdEmployeesList_RowDataBound" 
                                         AutoGenerateColumns="False" DataKeyNames="UserId" 
                                         OnSorting="grdEmployeesList_Sorting" DataSourceID="ObjectDataSource1" 
                                         ShowFooter="True">
<PagerSettings PageButtonCount="30"></PagerSettings>
<Columns>
<asp:BoundField DataField="InvestorNo" DataFormatString="SAG{0:000000000#}" SortExpression="InvestorNo" 
        HeaderText="Mã Cổ Đông">
<ItemStyle HorizontalAlign="Left" Width="8%"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
<asp:TemplateField SortExpression="FullName" HeaderText="Họ v&#224; t&#234;n">
<ItemStyle HorizontalAlign="Left"  Width="25%"></ItemStyle>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
<ItemTemplate>
  <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid">[lnkFullName]</asp:HyperLink>
                                               
</ItemTemplate>
<FooterTemplate>
   <asp:Label ID="lbTotal" runat="server"></asp:Label>
</FooterTemplate>
<FooterStyle HorizontalAlign="Left" />
<ItemStyle Width="150px" HorizontalAlign="Left"/>
</asp:TemplateField>

</Columns>

<RowStyle CssClass="grid-item"></RowStyle>
<FooterStyle CssClass="grid-footer" />
<PagerStyle CssClass="grid-paper"></PagerStyle>

<HeaderStyle CssClass="grid-header1"></HeaderStyle>

<AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
</asp:GridView>
                                        </td>
                                        <td>
                                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                                                AllowSorting="True" AutoGenerateColumns="False" CssClass="grid-Border" 
                                                DataKeyNames="UserId" DataSourceID="ObjectDataSource1" 
                                                OnRowDataBound="grdEmployeesList_RowDataBound" 
                                                OnSorting="grdEmployeesList_Sorting" PageSize="20" ShowFooter="True" 
                                                Width="100%">
                                                <PagerSettings PageButtonCount="30" />
                                                <Columns>
                                                    <asp:BoundField DataField="InvestorNo" DataFormatString="SAG{0:000000000#}" 
                                                        HeaderText="Mã Cổ Đông" SortExpression="InvestorNo">
                                                    <ItemStyle HorizontalAlign="Left" Width="8%" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                    </asp:BoundField>
                                                    <asp:TemplateField HeaderText="Họ và tên" SortExpression="FullName">
                                                        <ItemStyle HorizontalAlign="Left" Width="25%" />
                                                        <HeaderStyle HorizontalAlign="Left" />
                                                        <ItemTemplate>
                                                            <asp:HyperLink ID="lnkFullName0" runat="server" CssClass="hyperlink-Grid">[lnkFullName]</asp:HyperLink>
                                                        </ItemTemplate>
                                                        <FooterTemplate>
                                                            <asp:Label ID="lbTotal0" runat="server"></asp:Label>
                                                        </FooterTemplate>
                                                        <FooterStyle HorizontalAlign="Left" />
                                                        <ItemStyle HorizontalAlign="Left" Width="150px" />
                                                    </asp:TemplateField>
                                                </Columns>
                                                <RowStyle CssClass="grid-item" />
                                                <FooterStyle CssClass="grid-footer" />
                                                <PagerStyle CssClass="grid-paper" />
                                                <HeaderStyle CssClass="grid-header1" />
                                                <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                 </table>

 


</ContentTemplate>
                                     <%--<Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="imgSearch" EventName="Click" />
                                     </Triggers>--%>
                                </asp:UpdatePanel>
                            </td>
                       </tr>
                    </table>
                        <uc1:ucPermission ID="UcPermission1" runat="server" />
                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                            onselecting="ObjectDataSource1_Selecting" SelectMethod="GetByStocks" 
                            TypeName="HRMBLL.H0.EmployeesBLL" 
                            OldValuesParameterFormatString="original_{0}">
                            <SelectParameters>
                                <asp:Parameter Name="deptIds" Type="String" />
                                <asp:Parameter Name="rootId" Type="Int32" />
                                <asp:Parameter Name="fullname" Type="String" />
                                <asp:Parameter Name="typeSort" Type="Int32" />
                                <asp:Parameter Name="StockDayOfPayment" Type="Int32" />
                                <asp:Parameter Name="StockMonthOfPayment" Type="Int32" />
                                <asp:Parameter Name="StockYearOfPayment" Type="Int32" />
                                <asp:Parameter Name="ConfirmStocks" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </td>
                </tr>
                
            </table>
        </td>
    </tr>
    </table>
 <script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>
<script type="text/javascript" src="../JScripts/script.js"></script>
</asp:Content>


