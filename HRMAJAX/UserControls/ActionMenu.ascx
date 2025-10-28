<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ActionMenu.ascx.cs" Inherits="UserControls_ActionMenu" %>
<asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" MaximumDynamicDisplayLevels="2"
    DynamicEnableDefaultPopOutImage="False" StaticEnableDefaultPopOutImage="False" OnMenuItemClick="Menu1_MenuItemClick">
         <Items>
        <asp:MenuItem ImageUrl="~/Images/Icon_SubMenu.gif">
        </asp:MenuItem>
    </Items>
    <DynamicMenuStyle CssClass="menuPopupSub" />
     <DynamicMenuItemStyle CssClass="menuPopupItemSub" Font-Strikeout="False" />
     <DynamicHoverStyle CssClass="menuPopupItemHoverSub" />
</asp:Menu>