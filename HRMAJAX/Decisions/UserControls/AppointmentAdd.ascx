<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AppointmentAdd.ascx.cs" Inherits="Decisions_UserControls_AppointmentAdd" %>

<%@ Register Src="~/UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc2" %>

 <table style="width: 100%">   
    <tr>
        <td valign="top" align="right">                                                      
            <fieldset>
                <legend class="legend">Thông Tin Quyết Định</legend>                               
                <table style="width: 100%" class="tableBorder">
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label3" runat="server" CssClass="label" Text="Quyết định số"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtDecisionNo" runat="server" CssClass="textBox" Width="100px"></asp:TextBox></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label2" runat="server" CssClass="label" Text="Ngày quyết định"></asp:Label></td>
                        <td class="tdValue">
                            <uc2:CalendarPicker ID="cpDecisionDate" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="L0abel6" runat="server" CssClass="label" Text="Tên quyết định"></asp:Label></td>
                        <td class="tdValue" colspan="3">
                            <asp:TextBox ID="txtDecisionName" runat="server" CssClass="textBox" Width="98%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label4" runat="server" CssClass="label" Text="Đơn vị ra quyết định"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtBringOutDept" runat="server" CssClass="textBox" Width="200px"></asp:TextBox></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label1" runat="server" CssClass="label" Text="Người ký quyết định"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtSignUser" runat="server" CssClass="textBox" Width="200px"></asp:TextBox></td>
                    </tr>
                </table>                                       
            </fieldset>                            
        </td>
    </tr>
    <tr>
        <td valign="top">
            <fieldset>
                <legend class="legend">Cá Nhân Chịu Trách Nhiệm Thi Hành Quyết Định</legend>
                <table style="width: 100%"  class="tableBorder">
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label8" runat="server" CssClass="label" Text="Họ và tên"></asp:Label>
                        </td>
                        <td class="tdValue">                                                                                
                            <table cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif" OnClick="imgSearch_Click" />
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlEmployees" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlEmployees_SelectedIndexChanged"></asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label11" runat="server" CssClass="label" Text="Chức danh hiện hành"></asp:Label></td>
                        <td class="tdValue">
                            <asp:Label ID="lbPositionNameP" runat="server" CssClass="value"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label12" runat="server" CssClass="label" Text="Vị trí làm việc hiện hành"></asp:Label></td>
                        <td class="tdValue">
                            <asp:Label ID="lbDepartmentNameP" runat="server" CssClass="value"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="tdLabel"><asp:Label ID="Label9" runat="server" CssClass="label" Text="Chức danh bổ nhiệm mới"></asp:Label></td>
                        <td class="tdValue"><asp:DropDownList ID="ddlPositions" runat="server" CssClass="dropDownList" AppendDataBoundItems="true">
                            <asp:ListItem Text="" Value="0"></asp:ListItem>
                        </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label10" runat="server" CssClass="label" Text="Vị trí làm việc mới"></asp:Label></td>
                        <td class="tdValue">
                            <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList">
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label15" runat="server" CssClass="label" Text="Ngày bắt đầu"></asp:Label></td>
                        <td class="tdValue">
                            <uc2:CalendarPicker ID="cpFromDate" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label16" runat="server" CssClass="label" Text="Ngày kết thúc"></asp:Label></td>
                        <td class="tdValue">
                            <uc2:CalendarPicker ID="cpToDate" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label17" runat="server" CssClass="label" Text="Vị trí chính"></asp:Label></td>
                        <td class="tdValue">
                            <asp:CheckBox ID="chkKeyPosition" runat="server" /></td>
                    </tr>
                </table>                            
            </fieldset>
        </td>
    </tr>
    <tr>
        <td colspan="2" class="tdButton" align="center">
            <asp:Button ID="btnSave" runat="server" Text="Lưu" Width="100px" CssClass="small color green button" OnClick="btnSave_Click" />
            &nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Xóa"  Width="100px" CssClass="small color green button" OnClick="btnDelete_Click" OnClientClick="return confirm('Bạn có muốn xóa tất cả các thông tin ?');" />
            &nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Thoát" Width="100px" CssClass="small color green button" OnClick="btnCancel_Click" /></td>
    </tr>
</table>