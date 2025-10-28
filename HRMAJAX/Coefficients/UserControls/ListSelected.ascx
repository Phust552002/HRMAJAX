<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListSelected.ascx.cs" Inherits="UserControls_ListSelected" %>
<table>
	<tr>
		<td>
            <asp:Label ID="Label1" runat="server" CssClass="label" Text="Chức danh"></asp:Label></td>
		<td>&nbsp;</td>
		<td>
            <asp:Label ID="Label2" runat="server" CssClass="label" Text="Chức danh đã chọn"></asp:Label></td>
	</tr>
	<tr>
		<td>
			<asp:ListBox id="lstAllPositions" Runat="Server" Width="150" SelectionMode="Multiple" CssClass="textBox" Rows="8" />
		</td>
		<td>
			<asp:Button Text="->" style="FONT:9pt Courier" Runat="server" id="btnSelect" onclick="AddUser" CssClass="small color green button" />
			<br>
			<asp:Button Text="<-" style="FONT:9pt Courier" Runat="server" id="btnRemove" onclick="RemoveUser" CssClass="small color green button" />
		</td>
		<td>
			<asp:ListBox id="lstSelectedPositions" Runat="Server" Width="150" SelectionMode="Multiple" CssClass="textBox" Rows="8" />
		</td>
	</tr>
</table>
<script language="javascript" type="text/javascript">



</script>