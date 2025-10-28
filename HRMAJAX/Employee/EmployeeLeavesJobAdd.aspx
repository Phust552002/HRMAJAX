<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="EmployeeLeavesJobAdd.aspx.cs" Inherits="Employee_EmployeeLeavesJobAdd" %>
<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table style="width: 100%">
    <tr>
        <td>                   
           <uc1:ucTitle ID="UcTitle1" runat="server" />                        
        </td>
    </tr>
    <tr>
        <td>
          <table style="width: 100%" class="tableBorder">                                    
                 <tr>
                    <td align="left" class="tdLabel" style="width:30%">
                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tìm nhân viên"></asp:Label></td>
                    <td align="left" class="tdValue">
                        <table cellpadding="0" cellspacing="0">
                            <tr>
                                <td align="left" >
                                    <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                </td>
                                <td align="left" >
                                    &nbsp;<asp:ImageButton ID="imgSearchFullName" runat="server" ImageUrl="~/Images/Icon-Search.gif" OnClick="imgSearchFullName_Click" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="left" class="tdLabel">
                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Nhân viên"></asp:Label></td>
                    <td align="left" class="tdValue">
                        <asp:DropDownList ID="ddlEmployees" runat="server" CssClass="dropDownList" AppendDataBoundItems="True" OnSelectedIndexChanged="ddlEmployees_SelectedIndexChanged"  AutoPostBack="true">
                            <asp:ListItem Value="0" Text=""></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="lbEmployeeCode" runat="server" CssClass="label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left" class="tdLabel">
                        &nbsp;<asp:Label ID="Label5" runat="server" CssClass="label" Text="Quyết định"></asp:Label></td>
                    <td align="left" class="tdValue">
                                                    <asp:DropDownList ID="ddlStatus" runat="server" CssClass="dropDownList" AppendDataBoundItems="true">
                                                    <asp:ListItem Text="" Value="-1"></asp:ListItem>
                                                    </asp:DropDownList></td>
                </tr>
                <tr>
                    <td align="left" class="tdLabel">
                        <asp:Label ID="Label6" runat="server" CssClass="label" Text="Ngày"></asp:Label></td>
                    <td align="left" class="tdValue">
                                    <uc2:CalendarPicker ID="cpLeaveDate" runat="server" />
                                </td>
                </tr>
                <tr>
                    <td align="left" class="tdLabel"><asp:Label ID="Label4" runat="server" 
                            CssClass="label" Text="Ghi chú"></asp:Label></td>
                    <td align="left" class="tdValue">
                        <asp:TextBox ID="txtLeaveRemark" runat="server" CssClass="textBox" Width="99%" 
                            TextMode="MultiLine"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="tdButton" colspan="2" align="center">                                
                        <asp:Button ID="btnSave" runat="server" CssClass="small color green button" Text="Lưu" Width="100px" OnClick="btnSave_Click"/>
                        &nbsp;&nbsp;
                        <asp:Button ID="btnCancel" runat="server" CssClass="small color green button" Text="Thoát" Width="100px" OnClick="btnCancel_Click"/>
                    </td>
                </tr>                           
                </table>
        </td>
    </tr>                                         
</table>

</asp:Content>

