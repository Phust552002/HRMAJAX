<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="Employee_StockList" %>
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
                             <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="imgSearch" EventName="Click" />
                             </Triggers>
                        </asp:UpdatePanel>                      
                    </td>
                </tr>
                <tr>
                    <td>
                       <table width="100%">
                            <tr>          
                             <td style="width:20%" align="left">                                                                       
                                    <uc2:ActionMenu ID="ActionMenu1" runat="server" />
                                </td>      
                                <td align="right">
                                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
                                        <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox" Width="200px"></asp:TextBox>
                                    &nbsp;
                                        <asp:Label ID="lbDepartment" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
                                        <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList">
                                        </asp:DropDownList> &nbsp;<asp:Label ID="Label2" runat="server" CssClass="label" Text="Ngày nộp (dd/mm/yyyy)"></asp:Label>
                                        <asp:TextBox ID="txtDay" runat="server" CssClass="textBox" Width="30px"></asp:TextBox>
                                        <asp:TextBox ID="txtMonth" runat="server" CssClass="textBox" Width="30px"></asp:TextBox>
                                        <asp:TextBox ID="txtYear" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                                        &nbsp;
                                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Xác nhận"></asp:Label>
                                        <asp:DropDownList ID="ddlConfirmStocks" runat="server" CssClass="dropDownList">
                                        <asp:ListItem Text="" Value="0"></asp:ListItem>
                                        <asp:ListItem Text="Tiền mặt" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Chuyển khoản" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="Đã nộp" Value="3"></asp:ListItem>
                                        <asp:ListItem Text="Chưa nộp" Value="4"></asp:ListItem>
                                        </asp:DropDownList>
                                        &nbsp; &nbsp;&nbsp;<asp:Button ID="imgSearch" runat="server"
                                             OnClick="imgSearch_Click" Text="Xem" CssClass="small color green button"/>
                                        &nbsp; 
                                        <asp:HyperLink ID="lnkReport" runat="server" CssClass="hyperlink-Grid">Xem Báo Cáo</asp:HyperLink>
                                        &nbsp;&nbsp;&nbsp;
                                </td>
                            </tr>
                                        
                        </table>                       
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <table class="tableBorder" width="100%">
                         <tr>
                            <td>  
                                 <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                                 <ContentTemplate>

<asp:GridView id="grdEmployeesList" runat="server" Width="100%" CssClass="grid-Border" AllowSorting="True" 
                                         AllowPaging="True" PageSize="20" OnRowDataBound="grdEmployeesList_RowDataBound" 
                                         AutoGenerateColumns="False" DataKeyNames="UserId" 
                                         OnSorting="grdEmployeesList_Sorting" DataSourceID="ObjectDataSource1" 
                                         ShowFooter="True">
<PagerSettings PageButtonCount="30"></PagerSettings>
<Columns>
<asp:BoundField HtmlEncode="False" DataFormatString="{0:000#}" DataField="UserId" SortExpression="UserId" HeaderText="M&#227; NV">
<ItemStyle HorizontalAlign="Left" Width="3%"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
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
<asp:BoundField DataField="PositionName" SortExpression="PositionName" HeaderText="Chức danh">
<ItemStyle HorizontalAlign="Left" Width="14%"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
    <asp:TemplateField HeaderText="CP Thăm Niên ĐK" SortExpression="SeniorStock">
        <ItemTemplate>
            <asp:Label ID="lbSeniorStockRegistered" runat="server"></asp:Label>
        </ItemTemplate>
        <FooterTemplate>
            <asp:Label ID="lbSum_SeniorStockRegistered" runat="server"></asp:Label>
        </FooterTemplate>
        <FooterStyle HorizontalAlign="Right" />
        <ItemStyle Width="5%" HorizontalAlign="Right"/>
    </asp:TemplateField>

    <asp:TemplateField HeaderText="CP Cam Kết ĐK" SortExpression="UnderTakingStock">
        <ItemTemplate>
            <asp:Label ID="lbUnderTakingStockRegistered" runat="server"></asp:Label>
        </ItemTemplate>
        <FooterTemplate>
            <asp:Label ID="lbSum_UnderTakingStockRegistered" runat="server"></asp:Label>
        </FooterTemplate>
        <FooterStyle HorizontalAlign="Right" />
        <ItemStyle Width="5%" HorizontalAlign="Right"/>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Năm Cam Kết" SortExpression="UndertakingYear">
        <ItemTemplate>
            <asp:Label ID="lbUndertakingYear" runat="server"></asp:Label>
        </ItemTemplate>
        <FooterTemplate>
            <asp:Label ID="lbSum_UndertakingYear" runat="server"></asp:Label>
        </FooterTemplate>
        <FooterStyle HorizontalAlign="Right" />
        <ItemStyle Width="5%" HorizontalAlign="Right"/>
    </asp:TemplateField>

    <asp:TemplateField HeaderText="CP Thâm Niên Mua (Giá 8,400)" 
        SortExpression="SeniorStockBought">
        <ItemTemplate>
            <asp:Label ID="lbSeniorStockBought" runat="server"></asp:Label>
        </ItemTemplate>
        <FooterTemplate>
            <asp:Label ID="lbSum_SeniorStockBought" runat="server"></asp:Label>
        </FooterTemplate>
        <FooterStyle HorizontalAlign="Right" />
        <ItemStyle Width="5%" HorizontalAlign="Right"/>
    </asp:TemplateField>    
    <asp:TemplateField HeaderText="CP Cam Kết Mua(Giá 14,000)" 
        SortExpression="UnderTakingStockBought">
        <ItemTemplate>
            <asp:Label ID="lbUnderTakingStockBought" runat="server"></asp:Label>
        </ItemTemplate>
        <FooterTemplate>
            <asp:Label ID="lbSum_UnderTakingStockBought" runat="server"></asp:Label>
        </FooterTemplate>
        <FooterStyle HorizontalAlign="Right" />
        <ItemStyle Width="5%" HorizontalAlign="Right"/>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Tổng Cộng CP Mua">
        <ItemTemplate>
            <asp:Label ID="lbTotalStock" runat="server"></asp:Label>
        </ItemTemplate>
        <FooterTemplate>
            <asp:Label ID="lbSum_TotalStock" runat="server"></asp:Label>
        </FooterTemplate>
        <FooterStyle HorizontalAlign="Right" />
        <ItemStyle Width="5%" HorizontalAlign="Right"/>
    </asp:TemplateField>

    <asp:TemplateField HeaderText="CP Thâm Niên Mua (Thành Tiền)" >
        <ItemTemplate>
            <asp:Label ID="lbSeniorStockBoughtMoney" runat="server"></asp:Label>
        </ItemTemplate>
        <FooterTemplate>
            <asp:Label ID="lbSum_SeniorStockBoughtMoney" runat="server"></asp:Label>
        </FooterTemplate>
        <FooterStyle HorizontalAlign="Right" />
        <ItemStyle Width="5%" HorizontalAlign="Right"/>
    </asp:TemplateField>    
    <asp:TemplateField HeaderText="CP Cam Kết Mua(Thành Tiền)" >
        <ItemTemplate>
            <asp:Label ID="lbUnderTakingStockBoughtMoney" runat="server"></asp:Label>
        </ItemTemplate>
        <FooterTemplate>
            <asp:Label ID="lbSum_UnderTakingStockBoughtMoney" runat="server"></asp:Label>
        </FooterTemplate>
        <FooterStyle HorizontalAlign="Right" />
        <ItemStyle Width="5%" HorizontalAlign="Right"/>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Tổng Cộng Thành Tiền">
        <ItemTemplate>
            <asp:Label ID="lbTotalStockMoney" runat="server"></asp:Label>
        </ItemTemplate>
        <FooterTemplate>
            <asp:Label ID="lbSum_TotalStockMoney" runat="server"></asp:Label>
        </FooterTemplate>
        <FooterStyle HorizontalAlign="Right" />
        <ItemStyle Width="5%" HorizontalAlign="Right"/>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Xác Nhận Nộp Tiền">
        <ItemTemplate>
            <asp:Label ID="lbConfirm" runat="server"></asp:Label>
        </ItemTemplate>
        <ItemStyle Width="5%" HorizontalAlign="Left"/>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Ngày Nộp Tiền">
        <ItemTemplate>
            <asp:Label ID="lbStockDateOfPayment" runat="server"></asp:Label>
        </ItemTemplate>
        <ItemStyle Width="5%" HorizontalAlign="Left"/>
    </asp:TemplateField>

</Columns>

<RowStyle CssClass="grid-item"></RowStyle>
<FooterStyle CssClass="grid-footer" />
<PagerStyle CssClass="grid-paper"></PagerStyle>

<HeaderStyle CssClass="grid-header1"></HeaderStyle>

<AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
</asp:GridView> 


</ContentTemplate>
                                     <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="imgSearch" EventName="Click" />
                                     </Triggers>
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

