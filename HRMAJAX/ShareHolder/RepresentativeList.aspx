<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="RepresentativeList.aspx.cs" Inherits="ShareHolder_RepresentativeList" %>
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
                                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên"></asp:Label>

                                        <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox" Width="200px"></asp:TextBox>
                                    &nbsp;
                                        &nbsp;&nbsp;
                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Mã cổ đông"></asp:Label>
                                        <asp:TextBox ID="txtInvestor" runat="server" CssClass="textBox" Width="200px"></asp:TextBox>
                                        &nbsp;
                                        &nbsp;&nbsp;
                                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Xác nhận"></asp:Label>
                                        <asp:DropDownList ID="ddlConfirmStocks" runat="server" CssClass="dropDownList">
                                        <asp:ListItem Text="" Value="-1"></asp:ListItem>
                                        <asp:ListItem Text="Tham dự + Ủy quyền" Value="10"></asp:ListItem>
                                        <asp:ListItem Text="Tham dự" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Ủy quyền" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="Ko tham dự" Value="0"></asp:ListItem>                                        
                                        </asp:DropDownList>
                                        &nbsp; &nbsp;&nbsp;<asp:Button ID="imgSearch" runat="server"
                                            OnClick="imgSearch_Click" Text="Xem" Width="100px" CssClass="small color green button"/>
                                        <%--&nbsp; 
                                        <asp:HyperLink ID="lnkReport" runat="server" CssClass="hyperlink-Grid">Xem Báo Cáo</asp:HyperLink>
                                        &nbsp;&nbsp;&nbsp;--%>
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
                                         AllowPaging="True" PageSize="25" OnRowDataBound="grdEmployeesList_RowDataBound" 
                                         AutoGenerateColumns="False" OnSorting="grdEmployeesList_Sorting" DataSourceID="ObjectDataSource1" 
                                         ShowFooter="True">
<PagerSettings PageButtonCount="30"></PagerSettings>
<Columns>
<asp:BoundField DataField="InvestorNo" DataFormatString="SAG{0:000000000#}" SortExpression="InvestorNo" HeaderText="Mã Cổ Đông">
<ItemStyle HorizontalAlign="Left" Width="10%"></ItemStyle>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>


<asp:TemplateField SortExpression="FullName" HeaderText="Họ v&#224; t&#234;n">
<ItemStyle HorizontalAlign="Left"  Width="20%"></ItemStyle>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
<ItemTemplate>
  <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink"></asp:HyperLink>                                               
</ItemTemplate>
<FooterTemplate>
   <asp:Label ID="lbTotal" runat="server"></asp:Label>
</FooterTemplate>
</asp:TemplateField>
<asp:BoundField DataField="AttorneyCode" DataFormatString="{0:000#}" SortExpression="AttorneyCode" HeaderText="Mã ủy quyền">
<ItemStyle HorizontalAlign="Left" Width="5%"></ItemStyle>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
<asp:TemplateField HeaderText="Xác nhận">
        <ItemTemplate>
            <asp:Label ID="lbIsOk" runat="server"></asp:Label>
        </ItemTemplate>
        <ItemStyle Width="10%" HorizontalAlign="Center"/>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Số CP Sở hữu">
    <ItemTemplate>
            <asp:Label ID="lbStock" runat="server"></asp:Label>
     </ItemTemplate>
    <FooterTemplate>
        <asp:Label ID="lbTotalStock" runat="server"></asp:Label>
    </FooterTemplate>
    <ItemStyle HorizontalAlign="Right" Width="10%" />
    <FooterStyle HorizontalAlign="Right" />
    </asp:TemplateField>

    <asp:TemplateField HeaderText="Tỉ lệ (%)">        
        <ItemTemplate>
            <asp:Label ID="lbStockRatio" runat="server"></asp:Label>
        </ItemTemplate>
        <FooterTemplate>
            <asp:Label ID="lbSum_StockRatio" runat="server"></asp:Label>
        </FooterTemplate>
        <FooterStyle HorizontalAlign="Right" />
        <ItemStyle HorizontalAlign="Right" Width="10%" />
    </asp:TemplateField>

    <asp:TemplateField HeaderText="Cổ phần quy đổi bầu HĐQT">
        <ItemTemplate>
            <asp:Label ID="lbHDQT_Vote" runat="server"></asp:Label>
     </ItemTemplate>
    <FooterTemplate>
        <asp:Label ID="lbSumHDQT_Vote" runat="server"></asp:Label>
    </FooterTemplate>
    <ItemStyle HorizontalAlign="Right" Width="10%" />
    <FooterStyle HorizontalAlign="Right" />
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Cổ phần quy đổi bầu BSK">
        <ItemTemplate>
            <asp:Label ID="lbBKS_Vote" runat="server"></asp:Label>
     </ItemTemplate>
    <FooterTemplate>
        <asp:Label ID="lbSumBKS_Vote" runat="server"></asp:Label>
    </FooterTemplate>
    <ItemStyle HorizontalAlign="Right" Width="10%" />
    <FooterStyle HorizontalAlign="Right" />
    </asp:TemplateField>

    

    <asp:TemplateField HeaderText="Ghi chú">
     <ItemTemplate>
            <asp:Label ID="lbRemark" runat="server"></asp:Label>
        </ItemTemplate>
        <ItemStyle Width="10%" HorizontalAlign="Left"/>
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
                            onselecting="ObjectDataSource1_Selecting" SelectMethod="GetByFilter" 
                            TypeName="HRMBLL.H4.RepresentativeBLL" 
                            OldValuesParameterFormatString="original_{0}">
                            <SelectParameters>
                                <asp:Parameter Name="InvestorNo" Type="Int32" />
                                <asp:Parameter Name="fullname" Type="String" />
                                <asp:Parameter Name="IsOk" Type="Int32" />
                                <asp:Parameter Name="KTTCDB" Type="Int32" />
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

