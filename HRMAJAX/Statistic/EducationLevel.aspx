<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="EducationLevel.aspx.cs" Inherits="Statistic_EducationLevel" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Assembly="WebChart" Namespace="WebChart" TagPrefix="Web" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%">
<tr>
    <td valign="top">
        <table style="width: 100%">
            <tr>
                <td>
                    <uc3:ucTitle ID="UcTitle1" runat="server" />                    
                </td>
            </tr>                    
            <tr>
                <td>
                    <table style="WIDTH: 100%" class="tableBorder">
                        <tr>
                            <td>
                             <asp:GridView id="GridView2" runat="server" Width="100%" CssClass="grid-Border" ShowFooter="True" PageSize="20" AllowSorting="True" OnRowDataBound="GridView2_RowDataBound" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                                    <PagerSettings PageButtonCount="30"></PagerSettings>
                                    <FooterStyle CssClass="grid-footer"></FooterStyle>
                                    <RowStyle CssClass="grid-item"></RowStyle>
                                    <PagerStyle CssClass="grid-paper"></PagerStyle>
                                    <HeaderStyle CssClass="grid-header"></HeaderStyle>
                                    <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                                    <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                 <Columns>
                                     <asp:BoundField DataField="RootId" HeaderText="STT" SortExpression="RootId" Visible="False">
                                         <ItemStyle HorizontalAlign="Center" />
                                     </asp:BoundField>
                                     <asp:BoundField DataField="RootName" HeaderText="Ph&#242;ng" SortExpression="RootName" />
                                     <asp:TemplateField HeaderText="CH" SortExpression="CH">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtCH" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                         <FooterTemplate>
                                             <asp:LinkButton ID="lbtFCH" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>                                             
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="ĐH" SortExpression="DH">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtDH" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                         <FooterTemplate>
                                             <asp:LinkButton ID="lbtFDH" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="CĐ" SortExpression="CD">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtCD" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                         <FooterTemplate>
                                             <asp:LinkButton ID="lbtFCD" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="TC" SortExpression="TC">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtTC" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                         <FooterTemplate>
                                             <asp:LinkButton ID="lbtFTC" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="TOIEC" SortExpression="TOIEC">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtTOIEC" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                         <FooterTemplate>
                                             <asp:LinkButton ID="lbtFTOIEC" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="TOEFL" SortExpression="TOEFL">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtTOEFL" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                         <FooterTemplate>
                                             <asp:LinkButton ID="lbtFTOEFL" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="IELTS" SortExpression="IELTS">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtIELTS" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                         <FooterTemplate>
                                             <asp:LinkButton ID="lbtFIELTS" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="CCAAV" SortExpression="CCAAV">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtCCAAV" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                         <FooterTemplate>
                                             <asp:LinkButton ID="lbtFCCAAV" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="CCBAV" SortExpression="CCBAV">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtCCBAV" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                         <FooterTemplate>
                                             <asp:LinkButton ID="lbtFCCBAV" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="CCCAV" SortExpression="CCCAV">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtCCCAV" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                         <FooterTemplate>
                                             <asp:LinkButton ID="lbtFCCCAV" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="CNAV" SortExpression="CNAV">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtCNAV" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                         <FooterTemplate>
                                             <asp:LinkButton ID="lbtFCNAV" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="CCAVK" SortExpression="CCAVK">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtCCAVK" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                          <FooterTemplate>
                                             <asp:LinkButton ID="lbtFCCAVK" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="NNK" SortExpression="NNK">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtNNK" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                          <FooterTemplate>
                                             <asp:LinkButton ID="lbtFNNK" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="CCTH" SortExpression="CCTH">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtCCTH" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                          <FooterTemplate>
                                             <asp:LinkButton ID="lbtFCCTH" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="GPLX" SortExpression="GPLX">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtGPLX" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                          <FooterTemplate>
                                             <asp:LinkButton ID="lbtFGPLX" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="CCK" SortExpression="CCK">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtCCK" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                          <FooterTemplate>
                                             <asp:LinkButton ID="lbtFCCK" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="BK" SortExpression="BK">
                                         <ItemTemplate>
                                             <asp:LinkButton ID="lbtBK" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </ItemTemplate>
                                         <ItemStyle HorizontalAlign="Center" />
                                         <FooterStyle HorizontalAlign="Center" />
                                          <FooterTemplate>
                                             <asp:LinkButton ID="lbtFBK" runat="server" CssClass="hyperlink-Grid" OnClick="lbtCH_Click"></asp:LinkButton>
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                 </Columns>
                            </asp:GridView>
                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="StatisticEducationLevel" TypeName="HRMBLL.H0.Statistic.STAEmployeeBLL" OnSelected="ObjectDataSource1_Selected" OldValuesParameterFormatString="original_{0}"></asp:ObjectDataSource>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>             
            <tr>
                <td>
                    <table width="100%">                       
                        <tr>
                            <td align="center" style="width:50%" valign="top">
                                <fieldset>
                                    <legend class="legend"> Sơ Đồ Hiển Thị</legend>                                
                                 <asp:Label ID="Label3" runat="server" CssClass="label" Text="Phòng"></asp:Label>
                                <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList" AppendDataBoundItems="true" AutoPostBack="True" OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged">
                                <asp:ListItem Text="SAGS" Value="8"></asp:ListItem>
                                </asp:DropDownList>
                                <Web:ChartControl ID="ChartControl1" runat="server" BorderWidth="1px" ShowXValues="False" ShowYValues="False" ChartPadding="10" GridLines="None" Height="500px" BorderStyle="Solid" ChartFormat="Jpg" Width="500px">
                                    <YAxisFont StringFormat="Far,Near,Character,LineLimit" />
                                    <XTitle StringFormat="Center,Near,Character,LineLimit" />
                                    <ChartTitle StringFormat="Center,Near,Character,LineLimit" Font="Tahoma, 8pt, style=Bold" Text="Thống K&#234; Giới T&#237;nh C&#244;ng Ty" />
                                    <XAxisFont StringFormat="Center,Near,Character,LineLimit" />
                                    <Background Color="LavenderBlush"/>
                                    <YTitle StringFormat="Center,Near,Character,LineLimit" />
                                    <Legend Width="150"></Legend>
                                </Web:ChartControl>
                                </fieldset>
                            </td>
                            <td align="center" style="width:50%" valign="top">
                                <fieldset>
                                    <legend class="legend"> 
                                        <asp:Label ID="lbTitleEducationList" runat="server" Text="Label"></asp:Label></legend>
                                        <table width="100%" class="tableBorder">
                                            <tr>
                                                <td>                                                
                                                    <asp:GridView id="GridView1" runat="server" Width="100%" CssClass="grid-Border" PageSize="20" AllowSorting="True" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound">
                                                        <PagerSettings PageButtonCount="30"></PagerSettings>
                                                        <FooterStyle CssClass="grid-footer"></FooterStyle>
                                                        <RowStyle CssClass="grid-item"></RowStyle>
                                                        <PagerStyle CssClass="grid-paper"></PagerStyle>
                                                        <HeaderStyle CssClass="grid-header"></HeaderStyle>
                                                        <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                                                        <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                                         <Columns>
                                                             <asp:TemplateField HeaderText="Họ t&#234;n" SortExpression="FullName">
                                                                 <ItemTemplate>
                                                                     <asp:Label ID="lbFullName" runat="server" ></asp:Label>
                                                                 </ItemTemplate>
                                                             </asp:TemplateField>
                                                             <asp:BoundField DataField="EducationLevelName" HeaderText="Văn bằng" SortExpression="EducationLevelName"/>
                                                             <asp:BoundField DataField="EducationLevelValue" HeaderText="Ng&#224;nh/Điểm" SortExpression="EducationLevelValue" />
                                                         </Columns>
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                        </table>
                                </fieldset>    
                            </td>
                        </tr>
                    </table>
                 </td>
            </tr>               
         </table>    
    </td>
</tr>
</table>
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>    
</asp:Content>

