<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ucDepartmentFilter.ascx.cs" Inherits="UserControls_Common_ucDepartmentFilter" %>
<table>
    <tr>                
        <td align="right">
                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
                <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
            &nbsp;
                <asp:Label ID="lbDepartment" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropDownList">
                </asp:DropDownList>&nbsp; &nbsp;
                <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="Xem"  CssClass="small color green button" />&nbsp;
        </td>
    </tr>
    
</table>
