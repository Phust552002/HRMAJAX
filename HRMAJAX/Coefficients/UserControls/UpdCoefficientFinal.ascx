<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UpdCoefficientFinal.ascx.cs" Inherits="Coefficients_UserControls_UpdCoefficientFinal" %>

<%@ Register Src="~/UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc1" %>
<table style="width: 99%;margin-top:2px; margin-left:2px; margin-right:2px; margin-bottom:2px;" class="tableBorder">
    <tr>
            <td>
                <uc1:MessageError ID="MessageError1" runat="server" />
            </td>
        </tr>
    <tr>
        <td class="tdLabel">
            <asp:Label ID="Label1" runat="server" CssClass="label" Text="LCB"></asp:Label></td>
        <td class="tdValue">
            <asp:TextBox ID="txtLCB" runat="server" CssClass="textBox" Width="150px"></asp:TextBox></td>
    </tr>
        <tr>
        <td class="tdLabel" style="width:30%">
            <asp:Label ID="Label6" runat="server" CssClass="label" Text="LNS"></asp:Label></td>
        <td class="tdValue" style="width:70%">
            <asp:TextBox ID="txtLNS" runat="server" CssClass="textBox" Width="150px" ReadOnly="True"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="tdLabel" style="width: 30%">
            <asp:Label ID="Label7" runat="server" CssClass="label" Text="LNSPCTN"></asp:Label></td>
        <td class="tdValue" style="width: 70%">
            <asp:TextBox ID="txtLNSPCTN" runat="server" CssClass="textBox" Width="150px" ReadOnly="True"></asp:TextBox></td>
    </tr>

    <tr>
        <td class="tdLabel">
            <asp:Label ID="Label2" runat="server" CssClass="label" Text="PCDH ( Phụ cấp độc hại )"></asp:Label></td>
        <td class="tdValue">
            <asp:TextBox ID="txtPCDH" runat="server" CssClass="textBox" Width="150px" ReadOnly="True"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="tdLabel">
            <asp:Label ID="Label3" runat="server" CssClass="label" Text="PCTN ( Phụ cấp trách nhiệm )"></asp:Label></td>
        <td class="tdValue">
            <asp:TextBox ID="txtPCTN" runat="server" CssClass="textBox" Width="150px" ReadOnly="True"></asp:TextBox></td>
    </tr>
     <tr>
         <td class="tdLabel">
             <asp:Label ID="Label4" runat="server" CssClass="label" Text="PCCV ( Phụ cấp chức vụ )"></asp:Label></td>
         <td class="tdValue">
             <asp:TextBox ID="txtPCCV" runat="server" CssClass="textBox" Width="150px" ReadOnly="True"></asp:TextBox></td>
     </tr>
     <tr>
         <td class="tdLabel">
             <asp:Label ID="Label5" runat="server" CssClass="label" Text="PCKV ( Phụ cấp khu vực )"></asp:Label></td>
         <td class="tdValue">
             <asp:TextBox ID="txtPCKV" runat="server" CssClass="textBox" Width="150px" ReadOnly="True"></asp:TextBox></td>
     </tr>
    <tr>
        <td colspan="2" class="tdButton">
         <table style="width: 100%" >
             <tr>
                 <td align="center">
                     <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" CssClass="small color green button" OnClick="btnUpdate_Click"/></td>
             </tr>
         </table>
        </td>
    </tr>
</table>