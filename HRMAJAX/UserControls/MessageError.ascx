<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MessageError.ascx.cs" Inherits="UserControls_MessageError" %>
<table style="width: 100%">
    <tr>
        <td align="center">
            <asp:Label ID="lbError" runat="server" ForeColor="Red" CssClass="value"></asp:Label></td>
    </tr>
    <tr>
        <td align="center">
            <asp:HyperLink ID="lnkSuccessful" runat="server" Visible="False">HyperLink</asp:HyperLink></td>
    </tr>
</table>
