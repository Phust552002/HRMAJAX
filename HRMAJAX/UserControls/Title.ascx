<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Title.ascx.cs" Inherits="UserControls_Title" %>
<table style="width: 100%">
    <tr>
        <td align="center"><asp:Label ID="lbTitle" runat="server" CssClass="titleContent"></asp:Label></td>
    </tr>
    <tr>
        <td class="titleLine1" colspan="2" align="center">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/TitleLine.jpg" /></td>
    </tr>
    <tr>
        <td style="height:5px" colspan="2" align="center">
            <asp:Label ID="lbError" runat="server" ForeColor="Red" CssClass="value"></asp:Label>
        </td>
    </tr>
</table>