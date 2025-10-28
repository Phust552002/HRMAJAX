<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UnofficialGeneralInfo.ascx.cs" Inherits="Unofficial_Employee_UserControls_Personal_GeneralInfo" %>
<%@ Register Src="../../../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"
    TagPrefix="uc4" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../../../UserControls/CalendarPicker.ascx" TagName="CalendarPicker"
    TagPrefix="uc3" %>
<%@ Register Src="../../../UserControls/DatePicker.ascx" TagName="DatePicker" TagPrefix="uc2" %>
<%@ Register Src="../../../UserControls/ucMessageError.ascx" TagName="ucMessageError" TagPrefix="uc1" %>
<style type="text/css">
    .auto-style1 {
        height: 23px;
    }
</style>
<table style="width: 100%" class="tableBorder" cellpadding="2" cellspacing="0">
    
    <tr>
        <td valign="top" style="width:200px">
            <asp:Image ID="ImgUser" runat="server" />
        </td>
        <td valign="top">
            <table style="width: 100%" class="tableBorder">
                <tr>
                    <td class="tdLabel" colspan="2">
                        <uc1:ucMessageError ID="UcMessageError1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Mã nhân viên"></asp:Label></td>
                    <td class="auto-style1">
                        <asp:Label ID="lbUserCode" runat="server" CssClass="value"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label6" runat="server" CssClass="label" Text="Giới tính"></asp:Label></td>
                    <td class="tdValue">
                        <asp:RadioButton ID="rdoMale" runat="server" CssClass="value" GroupName="groupSex"
                            Text="Nam" /><asp:RadioButton ID="rdoFemale" runat="server" CssClass="value" GroupName="groupSex"
                                Text="Nữ" /></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label8" runat="server" CssClass="label" Text="CCCD/CMND"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtIdCard" runat="server" CssClass="textBox" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Địa chỉ thường trú"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtResident" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Địa chỉ tạm trú"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtLive" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Ngày vào công ty"></asp:Label></td>
                    <td class="tdValue">
                        <uc3:CalendarPicker ID="cpJoinDate" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label11" runat="server" CssClass="label" Text="Mã số thuế cá nhân"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtTaxCode" runat="server" CssClass="textBox" Width="250px"></asp:TextBox></td>
                </tr>

                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label18" runat="server" CssClass="label" Text="Nghỉ việc"></asp:Label></td>
                    <td class="tdValue">
                        <asp:CheckBox ID="chkLeave" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Ngày nghỉ việc"></asp:Label></td>
                    <td class="tdValue">
                        <uc3:CalendarPicker ID="cpLeaveDate" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label7" runat="server" CssClass="label" Text="Đường dẫn ảnh"></asp:Label></td>
                    <td class="tdValue">
                        <asp:FileUpload ID="fuImageFile" runat="server" CssClass="textBox"/></td>
                </tr>
                
            </table>
        </td>
    </tr>
    
    <tr>
        <td colspan="2" class="tdButton">
            <table style="width: 100%" >
                <tr>
                    <td align="center">
                         <asp:Button ID="btnAdd" runat="server" Text="Cập nhật" OnClick="btnAdd_Click" CssClass="small color green button" Width="100px" /></td>
                </tr>
            </table>
            <uc4:ucPermission ID="UcPermission1" runat="server" />
        </td>
    </tr>
</table>
