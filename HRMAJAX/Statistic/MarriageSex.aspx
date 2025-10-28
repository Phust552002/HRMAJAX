<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="MarriageSex.aspx.cs" Inherits="Statistic_MarriageSex" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

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
                     <asp:GridView id="GridView2" runat="server" Width="100%" CssClass="grid-Border" DataSourceID="ObjectDataSource1" ShowFooter="True" AllowPaging="True" PageSize="20" AllowSorting="True" OnRowDataBound="GridView2_RowDataBound" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                            <PagerSettings PageButtonCount="30"></PagerSettings>
                            <FooterStyle CssClass="grid-footer"></FooterStyle>
                            <Columns>
                                <asp:TemplateField HeaderText="Ph&#242;ng" SortExpression="RootName">
                                    <FooterTemplate>
                                        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="hyperlink-Grid" OnClick="LinkButton1_Click"
                                            Text="SAGS"></asp:LinkButton>
                                    </FooterTemplate>
                                    <ItemTemplate>                                        
                                        <asp:LinkButton ID="LinkButton1" CssClass="hyperlink-Grid" runat="server" CommandName="Select" Text='<%# Bind("RootName") %>'></asp:LinkButton>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                    <FooterStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Tổng" SortExpression="Total">
                                    <FooterTemplate>
                                        <asp:Label ID="lbTotalAll" runat="server" CssClass="value-bold"></asp:Label>
                                    </FooterTemplate>
                                    <FooterStyle HorizontalAlign="Center" Width="10%" />
                                    <ItemStyle HorizontalAlign="Center" Width="10%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lbTotal" runat="server" Text='<%# Bind("Total") %>' CssClass="value-bold"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nam" SortExpression="Male">
                                    <FooterTemplate>
                                        <asp:Label ID="lbTotalMale" runat="server"></asp:Label>
                                    </FooterTemplate>
                                    <FooterStyle HorizontalAlign="Center" Width="10%" />
                                    <ItemStyle HorizontalAlign="Center" Width="10%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lbMale" runat="server" Text='<%# Bind("Male") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nữ" SortExpression="Female">
                                    <FooterTemplate>
                                        <asp:Label ID="lbTotalFemale" runat="server"></asp:Label>
                                    </FooterTemplate>
                                    <FooterStyle HorizontalAlign="Center" Width="10%" />
                                    <ItemStyle HorizontalAlign="Center" Width="10%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lbFemale" runat="server" Text='<%# Bind("Female") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Lập gia đ&#236;nh" SortExpression="Marriage">
                                    <FooterTemplate>
                                        <asp:Label ID="lbTotalMarriage" runat="server"></asp:Label>
                                    </FooterTemplate>
                                    <FooterStyle HorizontalAlign="Center" Width="10%" />
                                    <ItemStyle HorizontalAlign="Center" Width="10%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lbMarriage" runat="server" Text='<%# Bind("Marriage") %>' CssClass="value-italic"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Độc th&#226;n" SortExpression="Unmarried">
                                    <FooterTemplate>
                                        <asp:Label ID="lbTotalUnmarried" runat="server"></asp:Label>
                                    </FooterTemplate>
                                    <FooterStyle HorizontalAlign="Center" Width="10%" />
                                    <ItemStyle HorizontalAlign="Center" Width="10%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lbUnmarried" runat="server" Text='<%# Bind("Unmarried") %>' CssClass="value-italic"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <RowStyle CssClass="grid-item"></RowStyle>
                            <PagerStyle CssClass="grid-paper"></PagerStyle>
                            <HeaderStyle CssClass="grid-header"></HeaderStyle>
                            <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                            <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                    </asp:GridView> 
                    <asp:ObjectDataSource id="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" TypeName="HRMBLL.H0.Statistic.STAEmployeeBLL" SelectMethod="StatisticSexMarriage">
                    </asp:ObjectDataSource> 
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table width="100%">
                        <tr>
                            <td align="center">
                                <Web:ChartControl ID="ChartControl1" runat="server" BorderWidth="1px" ShowXValues="False" ShowYValues="False" ChartPadding="10" GridLines="None" Height="200px" Width="300px" BorderStyle="Solid" ChartFormat="Jpg">
                                    <YAxisFont StringFormat="Far,Near,Character,LineLimit" />
                                    <XTitle StringFormat="Center,Near,Character,LineLimit" />
                                    <ChartTitle StringFormat="Center,Near,Character,LineLimit" Font="Tahoma, 8pt, style=Bold" Text="Thống K&#234; Giới T&#237;nh C&#244;ng Ty" />
                                    <XAxisFont StringFormat="Center,Near,Character,LineLimit" />
                                    <Background Color="LavenderBlush"/>
                                    <YTitle StringFormat="Center,Near,Character,LineLimit" />
                                </Web:ChartControl>
                            </td>
                            <td align="center">
                                <Web:ChartControl ID="ChartControl2" runat="server" BorderWidth="1px" ShowXValues="False" ShowYValues="False" ChartPadding="10" GridLines="None" Height="200px" Width="300px" BorderStyle="Solid">
                                    <YAxisFont StringFormat="Far,Near,Character,LineLimit" />
                                    <XTitle StringFormat="Center,Near,Character,LineLimit" />
                                    <XAxisFont StringFormat="Center,Near,Character,LineLimit" />
                                    <Background Color="LavenderBlush"/>
                                    <YTitle StringFormat="Center,Near,Character,LineLimit" />
                                    <ChartTitle StringFormat="Center,Near,Character,LineLimit" Font="Tahoma, 8pt, style=Bold" Text="Thống K&#234; Tr&#236;nh Trạng Gia Đ&#236;nh C&#244;ng Ty" />
                                </Web:ChartControl>
                            </td>
                        </tr>
                    </table>
                 </td>
            </tr>               
         </table>    
    </td>
</tr>
</table>
</asp:Content>

