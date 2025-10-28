<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="GroupSectionEmployeesDetail.aspx.cs" Inherits="Department_GroupSectionEmployeesDetail" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"
    TagPrefix="uc1" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%">
     <tr>
        <td valign="top">
            <uc2:ucTitle ID="UcTitle1" runat="server" />
        </td>
    </tr>   
    <tr>
        <td align="center" valign="top">
            <table style="width: 100%">                                        
                <tr>
                    <td align="center">
                        <table style="width: 99%" class="tableBorder">                            
                            <tr>
                                <td class="tdLabel" style="width:40%">
                                    <asp:Label ID="Label3" runat="server" Text="Mã Nhân Viên" CssClass="label"></asp:Label></td>
                                <td class="tdValue" style="width:60%">
                                    <asp:Label ID="lbUserId" runat="server" CssClass="value"></asp:Label></td>
                            </tr>
                            <tr>
                                <td class="tdLabel">
                                    <asp:Label ID="Label2" runat="server" Text="Mã SAC" CssClass="label"></asp:Label></td>
                                <td class="tdValue">
                                    <asp:Label ID="lbEmployeeCode" runat="server" CssClass="value"></asp:Label></td>
                            </tr>
                            <tr>
                                <td class="tdLabel">
                                    <asp:Label ID="Label1" runat="server" Text="Họ và tên" CssClass="label"></asp:Label></td>
                                <td class="tdValue" >
                                    <asp:Label ID="lbFullName" runat="server" CssClass="value"></asp:Label></td>
                            </tr>
                            <tr>
                                <td class="tdLabel">
                                    <asp:Label ID="Label5" runat="server" Text="Phòng - Tổ -  Đội" CssClass="label"></asp:Label></td>
                                <td class="tdValue" >
                                     <asp:DropDownList ID="ddlDepartments" runat="server" CssClass="dropDownList">
                                        </asp:DropDownList>&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class="tdLabel">
                                    <asp:Label ID="Label7" runat="server" Text="Cập Nhật Bảng Chấm Công" CssClass="label"></asp:Label></td>
                                <td class="tdValue">
                                    <asp:Label ID="Label4" runat="server" CssClass="label" Text="Tháng"></asp:Label>
                                    <asp:DropDownList ID="ddlMonths" runat="server" CssClass="dropDownList">
                                    </asp:DropDownList>
                                    &nbsp;
                                    <asp:Label ID="Label6" runat="server" CssClass="label" Text="Năm"></asp:Label>
                                    <asp:DropDownList ID="ddlYears" runat="server" CssClass="dropDownList">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="tdButton" colspan="2" align="center">
                                    <asp:Button ID="btnUpdate" runat="server" CssClass="small color green button" Text="Cập nhật" OnClick="btnUpdate_Click" Width="100px" />
                                    &nbsp;
                                    <asp:Button ID="Button1" runat="server" CssClass="small color green button" Text="Thoát" OnClick="Button1_Click" Width="100px" /></td>
                            </tr>
                        </table>
                        <uc1:ucPermission ID="UcPermission1" runat="server" />
                    </td>
                </tr>                                        
            </table>
        </td>
    </tr>
</table>
</asp:Content>

