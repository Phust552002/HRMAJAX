<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DatePicker.ascx.cs" Inherits="UserControls_DatePicker" %>

<table cellpadding="0" cellspacing="0">
    <tr>
        <td>
            <asp:TextBox Runat="server" ID="txtText" CssClass="textBox" Width="100px"></asp:TextBox></td>
        <td>
            <asp:ImageButton ID="imgCalendar" runat="server" ImageUrl="~/Images/icon-calendar.gif" OnClick="imgCalendar_Click" /></td>
    </tr>   
    <tr>
        <td colspan="2">
            <asp:Panel Runat="server" ID="Panel1" CssClass="calendarHide" Width="200px">
                <asp:Calendar id="Calendar1" runat="server" OnSelectionChanged="PickDate" FirstDayOfWeek="Monday" BorderStyle="Solid" BorderColor="#999999" CellPadding="2" CellSpacing="0">
                    <TodayDayStyle CssClass="calendar-today" />
                    <TitleStyle CssClass="calendar-title" />
                    <WeekendDayStyle CssClass="calendar-weekend" />
                    <DayStyle CssClass="calendar" />
                    <DayHeaderStyle CssClass="calendar-header" />
                    <SelectedDayStyle CssClass="calendar-selectedDay" />
                    <OtherMonthDayStyle CssClass="calendar-OtherDay" />
                </asp:Calendar>
                <table cellpadding="0" cellspacing="0" style="width: 100%">
                    <tr>
                        <td>
                            <asp:DropDownList ID="ddlMonth" runat="server" AutoPostBack="True" CssClass="dropDownList" OnSelectedIndexChanged="ddlMonth_SelectedIndexChanged">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                                <asp:ListItem>7</asp:ListItem>
                                <asp:ListItem>8</asp:ListItem>
                                <asp:ListItem>9</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>11</asp:ListItem>
                                <asp:ListItem>12</asp:ListItem>
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                            </td>
                        <td>
                            <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" CssClass="dropDownList" DataSourceID="ObjectDataSource1" DataTextField="UnitName" DataValueField="UnitId" OnSelectedIndexChanged="ddlYear_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"
                    SelectMethod="GetYears" TypeName="HRMUtil.FormatDate"></asp:ObjectDataSource>
            </asp:Panel>	
        </td>
    </tr>
</table>
