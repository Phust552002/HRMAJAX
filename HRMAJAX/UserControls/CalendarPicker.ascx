<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CalendarPicker.ascx.cs" Inherits="UserControls_CalendarPicker" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:TextBox ID="txtDate" runat="server" CssClass="textBox" Width="70px"></asp:TextBox>
<cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtDate"  Format="dd/MM/yyyy" >
</cc1:CalendarExtender> 
