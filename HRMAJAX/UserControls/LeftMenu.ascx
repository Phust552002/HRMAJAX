<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LeftMenu.ascx.cs" Inherits="UserControls_LeftMenu" %>

<table cellpadding="0" cellspacing="0" style="width: 100%;" class="LeftMenu">    
    <tr>
        <td class="LeftMenu" valign="top">
            <table cellpadding="0" cellspacing="0" style="width: 100%;">    
                <tr>
                    <td align="center" style="height:25px">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/leftmenuline.jpg"></asp:Image></td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Label ID="lbTitleLeftMenu" runat="server" CssClass="LeftMenuTitle"></asp:Label></td>
                </tr>
                <tr>
                    <td align="center" style="height:25px">
                        <asp:Image ID="imgLeftMenuLine" runat="server" ImageUrl="~/Images/leftmenuline.jpg"></asp:Image></td>
                </tr>
                <tr>
                    <td >
                        <asp:DataList ID="dlLeftMenu" runat="server" OnItemDataBound="dlLeftMenu_ItemDataBound">
                            <ItemTemplate>
                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                    <tr>
                                        <td style="width:13px" align="right" valign="top">
                                            <asp:Image ID="imgLink" runat="server" ImageUrl="~/Images/ul_bullet.gif" /></td>
                                        <td align="left">
                                            <asp:HyperLink ID="lnkURL" runat="server" CssClass="LeftMenuItem"></asp:HyperLink></td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                            <SelectedItemStyle BackColor="white" />
                        </asp:DataList>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>        


