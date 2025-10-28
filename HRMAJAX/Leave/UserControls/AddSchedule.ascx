<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddSchedule.ascx.cs" Inherits="Leave_UserControls_AddSchedule" %>
<%@ Register Src="../../UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc3" %>
<%@ Register Src="../../UserControls/CalendarPicker.ascx" TagName="CalendarPicker"
    TagPrefix="uc2" %>
<%@ Register Src="../../UserControls/DatePicker.ascx" TagName="DatePicker" TagPrefix="uc1" %>

<uc3:MessageError ID="MessageError1" runat="server" />
<p>
    <asp:Label ID="Label1" runat="server" Text="Họ và tên"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" Width="300px">
    </asp:DropDownList>
</p>
<p>
    <asp:Button ID="Button1" runat="server" Text="Button" />
    <asp:Button ID="Button2" runat="server" Text="Button" />
</p>
