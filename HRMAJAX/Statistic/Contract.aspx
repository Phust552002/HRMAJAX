<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Contract.aspx.cs" Inherits="Statistic_Contract" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

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
                     <asp:GridView id="GridView2" runat="server" Width="100%" CssClass="grid-Border" ShowFooter="True" AllowPaging="True" PageSize="20" AllowSorting="True" OnRowDataBound="GridView2_RowDataBound" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
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
                             <asp:BoundField DataField="KoXDTH" HeaderText="Kh&#244;ng XĐTH" SortExpression="KoXDTH" />
                             <asp:BoundField DataField="XDTH36T" HeaderText="XĐTH 36T" SortExpression="XDTH36T" />
                             <asp:BoundField DataField="XDTH24T" HeaderText="XĐTH 24T" SortExpression="XDTH24T" />
                             <asp:BoundField DataField="XDTH12T" HeaderText="XĐTH 12T" SortExpression="XDTH12T" />
                             <asp:BoundField DataField="TViecDH" HeaderText="TViệc ĐH" SortExpression="TViecDH" />
                             <asp:BoundField DataField="TViecKhac" HeaderText="TViệc Kh&#225;c" SortExpression="TViecKhac" />
                             <asp:BoundField DataField="TNgheDH" HeaderText="TNghề ĐH" SortExpression="TNgheDH" />
                             <asp:BoundField DataField="TNgheTCap" HeaderText="TNghề TCấp" SortExpression="TNgheTCap" />
                             <asp:BoundField DataField="TNgheSC" HeaderText="TNghề SCấp" SortExpression="TNgheSC" />
                             <asp:BoundField DataField="TNgheKhac" HeaderText="TNghề Kh&#225;c" SortExpression="TNgheKhac" />
                             <asp:BoundField DataField="HNghe" HeaderText="H Nghề" SortExpression="HNghe" />
                             <asp:BoundField DataField="TVuL1" HeaderText="TVụ 3T" SortExpression="TVuL1" />
                             <asp:BoundField DataField="TVuL2" HeaderText="TVụ 6T" SortExpression="TVuL2" />
                         </Columns>
                    </asp:GridView>
                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="StatisticSexContractType" TypeName="HRMBLL.H0.Statistic.STAEmployeeBLL" OnSelected="ObjectDataSource1_Selected"></asp:ObjectDataSource>
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
                                <Web:ChartControl ID="ChartControl1" runat="server" BorderWidth="1px" ShowXValues="False" ShowYValues="False" ChartPadding="10" GridLines="None" Height="320px" BorderStyle="Solid" ChartFormat="Jpg">
                                    <YAxisFont StringFormat="Far,Near,Character,LineLimit" />
                                    <XTitle StringFormat="Center,Near,Character,LineLimit" />
                                    <ChartTitle StringFormat="Center,Near,Character,LineLimit" Font="Tahoma, 8pt, style=Bold" Text="Thống K&#234; Giới T&#237;nh C&#244;ng Ty" />
                                    <XAxisFont StringFormat="Center,Near,Character,LineLimit" />
                                    <Background Color="LavenderBlush"/>
                                    <YTitle StringFormat="Center,Near,Character,LineLimit" />
                                    <Legend Width="150"></Legend>
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

