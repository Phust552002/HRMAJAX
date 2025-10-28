<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="TotalEmployees.aspx.cs" Inherits="Statistic_TotalEmployees" Title="Untitled Page" %>

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
                <td align="center">
                    <table>
                        <tr>
                            <td>
                                <asp:DropDownList ID="ddlIsStatistic" runat="server" CssClass="dropDownList-bold" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                    
                                    <asp:ListItem Value="1">Thống k&#234; th&#225;ng</asp:ListItem>
                                    <asp:ListItem Value="2">Thống k&#234; năm</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;
                                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Từ tháng/năm"></asp:Label>&nbsp;<asp:DropDownList
                                    ID="ddlFromMonth" runat="server" CssClass="dropDownList">
                                </asp:DropDownList><asp:DropDownList ID="ddlFromYear" runat="server" CssClass="dropDownList">
                                </asp:DropDownList>
                                &nbsp;
                                <asp:Label ID="Label2" runat="server" CssClass="label" Text="Đến tháng/năm"></asp:Label>&nbsp;<asp:DropDownList
                                    ID="ddlToMonth" runat="server" CssClass="dropDownList">
                                </asp:DropDownList><asp:DropDownList ID="ddlToYear" runat="server" CssClass="dropDownList">
                                </asp:DropDownList></td>
                            <td>
                                <asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif"
                                    OnClick="imgSearch_Click" /></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table style="WIDTH: 100%" class="tableBorder">
                        <tr>
                            <td>
                              <asp:GridView ID="GridView1" runat="server" Width="100%" CssClass="grid-Border" OnRowDataBound="GridView1_RowDataBound" ShowFooter="True">
                                <RowStyle CssClass="grid-item"></RowStyle>
                                <PagerStyle CssClass="grid-paper"></PagerStyle>
                                <HeaderStyle CssClass="grid-header"></HeaderStyle>
                                <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                                <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                <FooterStyle CssClass="grid-footer"></FooterStyle>
                              </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Label ID="Label3" runat="server" CssClass="label" Text="Phòng"></asp:Label>
                    <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList" AppendDataBoundItems="true" AutoPostBack="True" OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged">
                    <asp:ListItem Text="SAGS" Value="8"></asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td>
                    <table width="100%">
                        <tr>
                            <td align="center">
                                 <Web:ChartControl ID="ChartControl1" runat="server" HasChartLegend="False" TopPadding="25" BorderWidth="1px" Height="300px" Width="500px" Padding="10" ChartPadding="20">
                                    <YAxisFont StringFormat="Far,Near,Character,LineLimit" />
                                    <XTitle StringFormat="Center,Near,Character,LineLimit" />
                                    <ChartTitle StringFormat="Center,Near,Character,LineLimit" Font="Tahoma, 8pt, style=Bold" Text="Thống K&#234; Nghỉ Việc C&#244;ng Ty" />
                                    <XAxisFont StringFormat="Center,Near,Character,LineLimit" />
                                    <Background Color="LavenderBlush"/>
                                    <YTitle StringFormat="Center,Near,Character,LineLimit" />
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

