<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="SelectUser.aspx.cs" Inherits="Income_SelectUser" Title="Untitled Page" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%">
    <tr>
        <td>
            <uc1:ucTitle ID="UcTitle1" runat="server" />
        </td>
    </tr>
    <tr>
        <td style="text-align: center">
            <asp:Label ID="Label1" runat="server" CssClass="label" Text="Người ký xác nhận bảng lương"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropDownList">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td style="text-align: center">
            <asp:Button ID="Button1" runat="server" CssClass="small color green button" OnClick="Button1_Click"
                Text="Xem Trước Khi In" /></td>
    </tr>
</table>
</asp:Content>

