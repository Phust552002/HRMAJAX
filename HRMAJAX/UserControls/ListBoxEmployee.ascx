<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListBoxEmployee.ascx.cs" Inherits="UserControls_ListBoxEmployee" %>
<table class="tableBorder" cellspacing="2" cellpadding="0" width="100%" >
    <tr class="tdLabel">
        <td align="center">
            <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tên"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" CssClass="textBox" Width="100px"></asp:TextBox>
            &nbsp;
            <asp:Label ID="Label4" runat="server" CssClass="label" Text="Phòng ban"></asp:Label>
            <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList">
            </asp:DropDownList>
            <asp:Button ID="btnFind" runat="server" CssClass="small color green button" Text="Tìm" OnClick="btnFind_Click" /></td>
    </tr>
    <tr class="tdValue">
        <td align="center">
            <br />
            <table id="TABLE1">
                <tr>
		            <td>
		                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Nhân viên"></asp:Label><br/>
			            <asp:ListBox id="lstEmployees" Runat="Server" SelectionMode="Multiple" CssClass="textBox" Rows="5" />
                        </td>
		            <td>
			            <asp:Button Text="->" style="FONT:9pt Courier" Runat="server" id="btnSelect" CssClass="small color green button" OnClick="btnSelect_Click" />
                        <br />
			            <asp:Button Text="<-" style="FONT:9pt Courier" Runat="server" id="btnRemove" CssClass="small color green button" OnClick="btnRemove_Click" />
		            </td>
		            <td>
		                <asp:Label ID="Label2" runat="server" CssClass="label" Text="Nhân viên đã chọn"></asp:Label><br/>
			            <asp:ListBox id="lstSelectedEmployees" Runat="Server" SelectionMode="Multiple" CssClass="textBox" Rows="5" />
                    </td>
	            </tr>
            </table>            
        </td>
    </tr>
	
</table>
