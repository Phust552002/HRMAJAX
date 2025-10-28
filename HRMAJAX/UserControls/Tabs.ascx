<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Tabs.ascx.cs" Inherits="UserControls_Tabs" %>
<table cellpadding="0" cellspacing="0" style="width: 100%" >
    <tr>
        <td align="left">
            <asp:Menu
                ID="MenuTabs"
                runat="server"
                Orientation="Horizontal"
                StaticEnableDefaultPopOutImage="False"
                OnMenuItemClick="MenuTabs_MenuItemClick" BorderWidth="0px" > 
                <StaticMenuStyle CssClass="tab" />
                <StaticSelectedStyle CssClass="tabSelectedItem" />
                <StaticMenuItemStyle CssClass="tabItem" />
                <StaticHoverStyle CssClass="tabItemHover" />
            </asp:Menu>
        </td>
        <td align="right">
            <asp:ImageButton ID="imgBack" runat="server" ImageUrl="~/images/Icon-Back.gif" OnClick="imgBack_Click" />&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
</table>
