<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="CntLst.aspx.cs" Inherits="Contracts_CntLst" Title="Untitled Page" %>

<%@ Register Src="../UserControls/LeftMenu.ascx" TagName="LeftMenu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td style="width:25%" align="left">
                <uc1:LeftMenu ID="LeftMenu1" runat="server" />
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>

