<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ucDateFilter.ascx.cs" Inherits="UserControls_ucDateFilter" %>
<table cellpadding="0" cellspacing="0">
    <tr>
        <td valign="middle">
            <asp:Label ID="Label2" runat="server" CssClass="label" Text="Tháng"></asp:Label>
            <asp:DropDownList ID="ddlMonths" runat="server" CssClass="dropDownList">
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
            &nbsp; &nbsp;<asp:Label ID="Label1" runat="server" CssClass="label" Text="Năm"></asp:Label>
            <asp:DropDownList ID="ddlYears" runat="server" CssClass="dropDownList">
            </asp:DropDownList>
        </td>
        <td valign="top">
            <table>
                <tr>
                    <td>
                        &nbsp;&nbsp;
                        <asp:Button ID="imgSearch" runat="server" Text="Xem" CssClass="small color green button" OnClick="btnView_Click" />
                        &nbsp; &nbsp;</td>
                    <td>
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/print.gif" OnClick="btnPrint_Click" /></td>
                </tr>
            </table>
        </td>
    </tr>
</table>