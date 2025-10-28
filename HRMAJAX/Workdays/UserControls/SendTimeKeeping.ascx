<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SendTimeKeeping.ascx.cs" Inherits="Workdays_UserControls_SendTimeKeeping" %>
<%@ Register Src="../../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"
    TagPrefix="uc1" %>
<table class="tableBorder" cellpadding="0" cellspacing="0">
    <tr class="tdLabel">
        <td>
            <table>                
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Gửi bảng chấm công của "></asp:Label> <asp:Label ID="lbDepartment" runat="server" Font-Bold="True" Font-Size="14px"></asp:Label>
                    </td>
                    <td align="left" valign="top">
	                    <asp:Label ID="lbUsersWrite" runat="server" CssClass="label" Text="Người"></asp:Label><br />
		                <asp:ListBox id="lstUserWrite" Runat="Server" SelectionMode="Multiple" CssClass="textBox" Rows="3" Width="150px"/>
	                </td>
	                <td valign="middle" align="center">
	                    
                        <asp:ImageButton ID="btnSelectWrite" runat="server" ImageUrl="~/images/ArrowAdd.gif" OnClick="btnSelectWrite_Click"/><br /><asp:ImageButton ID="btnRemoveWrite" runat="server" ImageUrl="~/images/ArrowRemove.gif" OnClick="btnRemoveWrite_Click"/>
	                </td>                   
                    <td align="right" valign="top">
                        <asp:Label ID="lbSelectedUsersWrite" runat="server" Text="Người nhận" CssClass="label"></asp:Label><br />
                        <asp:ListBox ID="lstReceivedUserWrite" runat="server" CssClass="textBox" Rows="3" SelectionMode="Multiple" Width="150px"></asp:ListBox>
                    </td>
                </tr>
            </table>
        </td>
        <td>
            <table>
                <tr>                    
                    <td align="left" valign="top">
	                    <asp:Label ID="lbUsersRead" runat="server" CssClass="label" Text="Người" Visible="False"></asp:Label><br />
		                <asp:ListBox id="lstUserRead" Runat="Server" SelectionMode="Multiple" CssClass="textBox" Rows="3" Width="150px" Visible="False"/>
	                </td>
	                <td valign="middle" align="center" style="width:20px;">
                        <asp:ImageButton ID="btnSelectRead" runat="server" ImageUrl="~/images/ArrowAdd.gif" OnClick="btnSelectRead_Click" Visible="False"/><br /><asp:ImageButton ID="btnRemoveRead" runat="server" ImageUrl="~/images/ArrowRemove.gif" OnClick="btnRemoveRead_Click" Visible="False"/>
	                </td>                   
                    <td align="left" valign="top">
                        <asp:Label ID="lbSelectedUsersRead" runat="server" Text="Người nhận" CssClass="label" Visible="False"></asp:Label><br />
                        <asp:ListBox ID="lstReceivedUserRead" runat="server" CssClass="textBox" Rows="3" SelectionMode="Multiple" Width="150px" Visible="False"></asp:ListBox>
                    </td>
                </tr>
            </table>
        </td>        
        <td valign="top">
            <table>
                <tr>
                    <td><asp:ImageButton id="imgSend" onclick="imgSend_Click" runat="server" ImageUrl="~/Images/Icon_Send.gif" OnClientClick="return confirm('Bạn có chắc muốn gửi bảng chấm công này ?');"></asp:ImageButton></td>
                    <td><asp:LinkButton id="lnkSend" runat="server" CssClass="hyperlink-Button" Text="Gửi" OnClick="lnkSend_Click" OnClientClick="return confirm('Bạn có chắc muốn gửi bảng chấm công này ?');"></asp:LinkButton></td>
                </tr>
            </table>
        </td>
    </tr>
</table>
<uc1:ucPermission ID="UcPermission1" runat="server" />
