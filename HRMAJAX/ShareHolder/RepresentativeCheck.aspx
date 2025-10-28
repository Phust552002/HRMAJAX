<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="RepresentativeCheck.aspx.cs" Inherits="ShareHolder_RepresentativeCheck" %>

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
                                <asp:AsyncPostBackTrigger ControlID="btnCheck" EventName="Click" />
                             </Triggers>
                        </asp:UpdatePanel>                      
                    </td>
                </tr>
                <tr>
                    <td align="center">
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server" >
                            <ContentTemplate> 
                         <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên"></asp:Label>
                         &nbsp;<asp:TextBox ID="txtFullName" runat="server" CssClass="textBox" 
                             Width="200px"></asp:TextBox>
                    &nbsp;&nbsp;
                         <asp:Button ID="btnView" runat="server" 
                             Text="Tìm" CssClass="small color green button" onclick="btnView_Click"  />
                             </ContentTemplate>
                             <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="btnCheck" EventName="Click" />
                             </Triggers>
                        </asp:UpdatePanel> 
                    </td>
                </tr>
                <tr>
                    <td align="left">
                       
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                            <ContentTemplate>
                            <table class="tableBorder" width="100%">
                            <tr>
                                <td style="width:45%" align="center" class="tdLabel1"><asp:Label ID="lbShareHolder" runat="server" CssClass="label" 
                                        Text="CÒN LẠI" Font-Bold="True" Font-Italic="False" 
                                        Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Red"></asp:Label></td>
                                <td align="center" class="tdLabel1" rowspan="2" style="width:10%">
                                    <asp:Button ID="btnCheck" runat="server" CssClass="small color red button" 
                                        onclick="btnCheck_Click" Text="Điểm Danh >>" />
                                </td>
                                <td style="width:45%" align="center"  class="tdLabel1"><asp:Label ID="lbOk" runat="server" CssClass="label" 
                                        Text="THAM DỰ" Font-Bold="True" Font-Names="Times New Roman" 
                                        Font-Size="X-Large" ForeColor="Green"></asp:Label></td>
                            </tr>
                            <tr>
                                <td  valign="top">
                                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                                        onselecting="ObjectDataSource1_Selecting" SelectMethod="GetByFilter" 
                                        TypeName="HRMBLL.H4.RepresentativeBLL" 
                                        onselected="ObjectDataSource1_Selected" 
                                        OldValuesParameterFormatString="original_{0}">
                                        <SelectParameters>
                                            <asp:Parameter Name="InvestorNo" Type="Int32" />
                                            <asp:Parameter Name="fullname" Type="String" />
                                            <asp:Parameter Name="IsOk" Type="Int32" />
                                            <asp:Parameter Name="KTTCDB" Type="Int32" />
                                        </SelectParameters>
                                    </asp:ObjectDataSource>
                                    <asp:GridView id="grdShareHolder" runat="server" Width="100%" 
                                        CssClass="grid-Border" AllowSorting="True" 
                                    AllowPaging="True" PageSize="15" OnRowDataBound="grdShareHolder_RowDataBound" 
                                    AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
<PagerSettings PageButtonCount="30"></PagerSettings>
<Columns>
<asp:BoundField DataField="InvestorNo" DataFormatString="{0:000#}" SortExpression="InvestorNo" 
HeaderText="Mã Cổ Đông">
<ItemStyle HorizontalAlign="Left" Width="10%"></ItemStyle>
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
</asp:BoundField>
<asp:TemplateField SortExpression="FullName" HeaderText="Họ v&#224; t&#234;n">
<ItemStyle HorizontalAlign="Left"  Width="50%"></ItemStyle>
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid">[lnkFullName]</asp:HyperLink>                                               
</ItemTemplate>
</asp:TemplateField>
<asp:BoundField DataField="AttorneyCode" DataFormatString="{0:000#}" SortExpression="AttorneyCode" HeaderText="Mã ủy quyền">
<ItemStyle HorizontalAlign="Left" Width="10%"></ItemStyle>
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
</asp:BoundField>
<asp:TemplateField HeaderText="Xác nhận">
        <ItemTemplate>
            <asp:Label ID="lbIsOk" runat="server"></asp:Label>
        </ItemTemplate>
        <ItemStyle Width="20%" HorizontalAlign="Center"/>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Chọn">
        <ItemTemplate>
            <asp:CheckBox ID="chkSelect" runat="server" />
        </ItemTemplate>
        <ItemStyle Width="10%" HorizontalAlign="Center"/>
    </asp:TemplateField>
</Columns>

<RowStyle CssClass="grid-item"></RowStyle>
<FooterStyle CssClass="grid-footer" />
<PagerStyle CssClass="grid-paper"></PagerStyle>
<HeaderStyle CssClass="grid-header1"></HeaderStyle>
<AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
</asp:GridView>
                                </td>
                                <td valign="top">
                                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                                        OldValuesParameterFormatString="original_{0}" 
                                        onselecting="ObjectDataSource2_Selecting" SelectMethod="GetByFilter" 
                                        TypeName="HRMBLL.H4.RepresentativeBLL" 
                                        onselected="ObjectDataSource2_Selected">
                                        <SelectParameters>
                                            <asp:Parameter Name="InvestorNo" Type="Int32" />
                                            <asp:Parameter Name="fullname" Type="String" />
                                            <asp:Parameter Name="IsOk" Type="Int32" />
                                            <asp:Parameter Name="KTTCDB" Type="Int32" />
                                        </SelectParameters>
                                    </asp:ObjectDataSource>
                                    <asp:GridView ID="grdShareHolder_Ok" runat="server" AllowPaging="True" 
                                        AllowSorting="True" AutoGenerateColumns="False" CssClass="grid-Border" 
                                        DataSourceID="ObjectDataSource2" 
                                        OnRowDataBound="grdShareHolder_Ok_RowDataBound" PageSize="25" 
                                        Width="100%">
                                        <PagerSettings PageButtonCount="30" />
                                        <Columns>
                                            <asp:BoundField DataField="InvestorNo" DataFormatString="{0:000#}" 
                                                HeaderText="Mã Cổ Đông" SortExpression="InvestorNo">
                                            <ItemStyle HorizontalAlign="Left" Width="20%" />
                                            <HeaderStyle HorizontalAlign="Left" />
                                            </asp:BoundField>
                                            <asp:TemplateField HeaderText="Họ và tên" SortExpression="FullName">
                                                <ItemStyle HorizontalAlign="Left" Width="80%" />
                                                <HeaderStyle HorizontalAlign="Left" />
                                                <ItemTemplate>
                                                    <asp:HyperLink ID="lnkFullNameOk" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                                                </ItemTemplate>
                                                
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="AttorneyCode" DataFormatString="{0:000#}" SortExpression="AttorneyCode" HeaderText="Mã ủy quyền">
<ItemStyle HorizontalAlign="Left" Width="5%"></ItemStyle>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
<asp:TemplateField HeaderText="Xác nhận">
        <ItemTemplate>
            <asp:Label ID="lbIsOk" runat="server"></asp:Label>
        </ItemTemplate>
        <ItemStyle Width="20%" HorizontalAlign="Center"/>
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
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="btnCheck" EventName="Click" />
                            </Triggers>
                        </asp:UpdatePanel>
                            
                        <uc1:ucPermission ID="UcPermission1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td align="center">
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server" >
                            <ContentTemplate> 
                     <table class="tableBorder">
                        <tr>
                            <td class="tdLabel">
                                <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource3" 
                                    onrowdatabound="GridView1_RowDataBound">
                                 <RowStyle CssClass="grid-item"></RowStyle>
                                <PagerStyle CssClass="grid-paper"></PagerStyle>
                                <HeaderStyle CssClass="grid-header" HorizontalAlign="Center"></HeaderStyle>
                                <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                                <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                <FooterStyle CssClass="grid-footer"></FooterStyle>

                                </asp:GridView>
                                <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" 
                                    SelectMethod="GetForStatisticByKTTCDB" 
                                    TypeName="HRMBLL.H4.RepresentativeBLL" 
                                    OldValuesParameterFormatString="original_{0}">
                                </asp:ObjectDataSource>
                                </td>                            
                        </tr>                      
                      
                    </table>
                     </ContentTemplate>
                             <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="btnCheck" EventName="Click" />
                             </Triggers>
                        </asp:UpdatePanel> 
                </td>
                </tr>
            </table>
        </td>
    </tr>
    </table>
 <script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>
<script type="text/javascript" src="../JScripts/script.js"></script>
</asp:Content>
