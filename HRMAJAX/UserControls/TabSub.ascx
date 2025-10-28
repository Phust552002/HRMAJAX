<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TabSub.ascx.cs" Inherits="UserControls_TabSub" %>
<table cellpadding="0" cellspacing="0" style="width: 100%" >
    <tr>
        <td align="left">
            <asp:Menu
                ID="MenuTabs"
                runat="server"
                Orientation="Horizontal"
                StaticEnableDefaultPopOutImage="False"
                OnMenuItemClick="MenuTabSub_MenuItemClick" BorderWidth="0px" > 
                <StaticMenuStyle CssClass="tabSub" />
                <StaticSelectedStyle CssClass="tabSelectedItemSub" />
                <StaticMenuItemStyle CssClass="tabItemSub" />
                <StaticHoverStyle CssClass="tabItemHoverSub" />
            </asp:Menu>
        </td>
    </tr>
</table>