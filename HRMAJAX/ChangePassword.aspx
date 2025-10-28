<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" >   
    <tr>
        <td align="center" valign="top">
            <table width="100%" >
                <tr>
                    <td valign="top">
                        <uc1:ucTitle ID="UcTitle1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td align="center" valign="top">
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtNewPassword"
                            ControlToValidate="txtConfirmPassword" CssClass="errorMessage" ErrorMessage="Mật khẩu mới và xác nhận lại mật khẩu phải giống nhau"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td align="center" valign="top">
                        <table style="width: 40%" class="tableBorder">
                            <tr>
                                <td class="tdLabel">
                                    <asp:Label ID="Label2" runat="server" Text="Mật khẩu cũ" CssClass="label"></asp:Label></td>
                                <td class="tdValue">
                                    <asp:TextBox ID="txtOldPassword" runat="server" Width="200px" TextMode="Password" CssClass ="textBox"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtOldPassword"
                                        CssClass="errorMessage" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                            </tr>
                            <tr>
                                <td class="tdLabel">
                                    <asp:Label ID="Label3" runat="server" Text="Mật khẩu mới" CssClass="label"></asp:Label></td>
                                <td class="tdValue">
                                    <asp:TextBox ID="txtNewPassword" runat="server" Width="200px" TextMode="Password" CssClass ="textBox"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNewPassword"
                                        CssClass="errorMessage" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                            </tr>
                            <tr>
                                <td class="tdLabel">
                                    <asp:Label ID="Label4" runat="server" Text="Xác nhận lại mật khẩu" CssClass="label"></asp:Label></td>
                                <td class="tdValue">
                                    <asp:TextBox ID="txtConfirmPassword" runat="server" Width="200px" TextMode="Password" CssClass ="textBox"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtConfirmPassword"
                                        CssClass="errorMessage" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                            </tr>
                            
                            <tr>
                                <td colspan="2" class="tdButton" align="center">
                                    <asp:Button ID="btnChange" runat="server" Text="Thay Đổi" OnClick="btnChange_Click" Width="100px" CssClass="small color green button" />
                                    &nbsp;
                                    <asp:Button ID="btnCancel" runat="server" Text="Thoát" OnClick="btnCancel_Click" ValidationGroup="RequiredFieldValidator1" Width="100px" CssClass="small color green button" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>  
</asp:Content>
