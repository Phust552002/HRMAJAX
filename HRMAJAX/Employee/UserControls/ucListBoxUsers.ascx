<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ucListBoxUsers.ascx.cs" Inherits="Admin_UserControls_ucListBoxUsers" %>
<%@ Register Src="../../UserControls/ucDepartmentFilter.ascx" TagName="ucDepartmentFilter"
    TagPrefix="uc1" %>
<table>
    <tr>
        <td colspan="3">            
            <uc1:ucDepartmentFilter ID="UcDepartmentFilter1" runat="server" />
        </td>
    </tr>
	<tr>
		<td align="left">
            <asp:Label ID="Label1" runat="server" CssClass="value" Text="Nhân viên"></asp:Label></td>
		<td>&nbsp;</td>
		<td align="left">
            <asp:Label ID="Label2" runat="server" CssClass="value" Text="Nhân viên đã chọn"></asp:Label></td>
	</tr>
	<tr>
		<td>
			<asp:ListBox id="lstEmployees" Runat="Server" Width="150" SelectionMode="Multiple" CssClass="textBox" Rows="8" Height="200px" />
		</td>
		<td>
			<asp:Button Text="->" style="FONT:9pt Courier" Runat="server" id="btnSelect" CssClass="small color green button" OnClick="btnSelect_Click" />
			<br>
			<asp:Button Text="<-" style="FONT:9pt Courier" Runat="server" id="btnRemove" CssClass="small color green button" OnClick="btnRemove_Click" />
		</td>
		<td>
			<asp:ListBox id="lstSelectedEmployees" Runat="Server" Width="150" SelectionMode="Multiple" CssClass="textBox" Rows="8" Height="200px" />
		</td>
	</tr>
</table>