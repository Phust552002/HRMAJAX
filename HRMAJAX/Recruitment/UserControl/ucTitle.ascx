<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ucTitle.ascx.cs" Inherits="UserControls_ucTitle" %>
<table style="width: 100%" border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td style="width:10px;">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/images/CandidateRegistrationTitle.gif" /></td>
        <td align="left">
            <asp:Label ID="lbTitle" runat="server" CssClass="titleContent"></asp:Label>
            &nbsp; &nbsp;&nbsp;
        <asp:Label ID="lbError" runat="server" ForeColor="Red" CssClass="value"></asp:Label></td>
        <td align="right">
            <asp:Label ID="lbCountRecord" runat="server" CssClass="labelCountRecord"></asp:Label></td>    
    </tr>
    <tr>
        <td class="titleLine" colspan="3"></td>
    </tr>
    <tr>
        <td style="height:5px" colspan="3">
        </td>
    </tr>
</table>