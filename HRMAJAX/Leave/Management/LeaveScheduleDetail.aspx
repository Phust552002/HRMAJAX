<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="LeaveScheduleDetail.aspx.cs" Inherits="Management_Leave_LeaveScheduleDetail" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
<%@ Register Src="~/UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc5" %>
<%@ Register Src="~/UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>
<%@ Register Src="~/Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc5" %>
<%@ Register Src="~/UserControls/CalendarPicker.ascx" TagName="CalendarPicker"TagPrefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> 
<uc1:ucPermission ID="UcPermission1" runat="server" />

    <table style="width: 100%">
        <tr>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
                    <ContentTemplate>  
                        <uc5:ucTitle ID="UcTitle1" runat="server" /> 
                    </ContentTemplate>
                </asp:UpdatePanel>                      
            </td>
        </tr>
        <tr>
            <%--<td>
            <asp:Panel ID="pnlAddSession" runat="server" Width="100%">
                    <table style="width: 100%;"class="tableBorder">
                        <tr>
                            <td align="left" style="width: 780px">
                                <asp:DropDownList ID="ddlFullName" runat="server" Width="200px" 
                                    CssClass="dropDownList" AutoPostBack="true" DataTextField="FullName" 
                                    DataValueField="UserId" ></asp:DropDownList>

                                <asp:Label ID="Label19" runat="server" CssClass="label" Text="Lần nghỉ "></asp:Label>
                                <asp:DropDownList ID="ddlTimes" runat="server" Width="200px" 
                                    CssClass="dropDownList" AutoPostBack="true" 
                                    onselectedindexchanged="ddlTimes_SelectedIndexChanged">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Button ID="imgSearch" runat="server" Text="Xem" CssClass="small color green button" onclick="imgSearch_Click"/>
                            </td>
                            <td align="right">
                                <asp:ImageButton id="ImageButton1" onclick="btnSend_Click" runat="server" ImageUrl="~/Images/Icon_Send.gif" Visible="true" Width="20px" ></asp:ImageButton>
                                <asp:LinkButton id="LinkButton1" onclick="btnSend_Click" runat="server" CssClass="hyperlink-Button" Visible="true">Gửi đến</asp:LinkButton>
                            </td>
                            <td align="right" style="width: 10%">
                                <asp:ListBox ID="ListBox1" runat="server" Width="100%" CssClass="value" SelectionMode="Multiple"></asp:ListBox>
                            </td>
                        </tr>
                    </table>
            </asp:Panel>
        </td>--%>
        </tr>
        <tr>
            <td>
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                    <fieldset>
                    <%--<legend class="legend">MẪU ĐĂNG KÝ NGHỈ PHÉP</legend>--%>
                    <table style="width: 100%;"class="tableBorder">
                        <tr>
                            <td class="tdLabel" style="width: 190px">
                                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Họ và tên: "></asp:Label>
                            </td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtFullName" runat="server" CssClass="value" Width="345px" 
                                    ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="tdLabel" style="width: 190px">
                                <asp:Label ID="Label2" runat="server" CssClass="label" Text="Bộ phận công tác: "></asp:Label>
                            </td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtDepartmentName" runat="server" CssClass="value" 
                                    Width="345px" ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="tdLabel" style="width: 190px">
                                <asp:Label ID="Label3" runat="server" CssClass="label" Text="Chức vụ/ công việc: "></asp:Label>
                            </td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtPositionName" runat="server" CssClass="value" Width="345px" 
                                    ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="tdLabel" style="width: 190px">
                                <asp:Label ID="Label4" runat="server" CssClass="label" Text="Ngày vào biên chế, công tác, ký HĐLĐ: "></asp:Label>
                            </td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtJoinDate" runat="server" CssClass="value" Width="345px" 
                                    ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="tdLabel" style="width: 190px">
                                <asp:Label ID="Label6" runat="server" CssClass="label" Text="Số ngày phép: "></asp:Label>
                            </td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtMaxF" runat="server" CssClass="value" Width="345px" 
                                    ReadOnly="True"></asp:TextBox>
                            </td>

                            <td class="tdLabel" style="width: 190px">
                                <asp:Label ID="Label7" runat="server" CssClass="label" Text="Số lần được nghỉ: "></asp:Label>
                            </td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtTimes" runat="server" CssClass="value" Width="345px" 
                                    ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="tdLabel" style="width: 190px">
                                <asp:Label ID="Label8" runat="server" CssClass="label" Text="Số ngày đã nghỉ: "></asp:Label>
                            </td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtLeft" runat="server" CssClass="value" Width="345px" 
                                    ReadOnly="True"></asp:TextBox>
                            </td>

                            <td class="tdLabel" style="width: 190px">
                                <asp:Label ID="Label10" runat="server" CssClass="label" Text="Số lần đã nghỉ: "></asp:Label>
                            </td>
                            <td class="tdValue">
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="value" Width="345px" 
                                    ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="tdLabel" style="width: 190px">
                            </td>
                            <td class="tdValue">
                            </td>

                            <td class="tdLabel" style="width: 190px">
                                <asp:Label ID="Label12" runat="server" CssClass="label" Text="Trong đó, số lần nghỉ ngoài kế hoạch: "></asp:Label>
                            </td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtNghiNgoaiKeHoach" runat="server" CssClass="value" 
                                    Width="345px" BorderColor="Red" ReadOnly="True">0</asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="tdLabel" style="width: 190px">
                                <asp:Label ID="Label11" runat="server" CssClass="label" Text="Số ngày chưa nghỉ: "></asp:Label>
                            </td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtLeaveRemain" runat="server" CssClass="value" Width="345px" 
                                    ReadOnly="True"></asp:TextBox>
                            </td>

                            <td class="tdLabel" style="width: 190px">
                                <asp:Label ID="Label13" runat="server" CssClass="label" Text="Số lần chưa nghỉ: "></asp:Label>
                            </td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtTimeRemain" runat="server" CssClass="value" Width="345px" 
                                    ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="tdLabel" style="width: 190px">
                                <asp:Label ID="Label14" runat="server" CssClass="label" Text="Thời gian/ Số ngày xin nghỉ: "></asp:Label>
                            </td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtDays" runat="server" CssClass="value" Width="345px" 
                                    ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="tdLabel" style="width: 190px">
                                <asp:Label ID="Label15" runat="server" CssClass="label" Text="Địa điểm dự kiến nghỉ phép: "></asp:Label>
                            </td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtPlace" runat="server" CssClass="value" Width="345px" 
                                    BorderColor="Red" ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    </fieldset>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td align="center">
                <%--<asp:LinkButton ID="lnkSave" runat="server" OnClick="btnSave_Click" CssClass="hyperlink-Button">Chấp nhận</asp:LinkButton>
                                   
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
                <asp:LinkButton id="LinkButton1" onclick="btnSend_Click" runat="server" CssClass="hyperlink-Button" Visible="true">Từ chối</asp:LinkButton>--%>
                
                <asp:Button ID="btnApprove" runat="server" OnClick="btnApprove_Click" 
                    Text="Chấp nhận" CssClass="small color green button" Width="100px" />
                                                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="LinkButton1" runat="server" Text="Từ chối" CssClass="small color green button" Width="100px" onclick="btnSend_Click" />           
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" CssClass="label" Text="Lý do: " 
                    Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="value" Width="279px" Visible="false"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="OK" 
                    CssClass="small color green button" Width="100px" Visible="false" 
                    onclick="Button1_Click"/>
                      
                <asp:Button ID="Button2" runat="server" Text="Quay lại" 
                    CssClass="small color green button" Width="100px" 
                    onclick="Button2_Click"/> 
                <%--<asp:ImageButton id="btnSend" onclick="btnSend_Click" runat="server" 
                    ImageUrl="~/Images/Icon_Send.gif" Visible="true" Width="20px" ></asp:ImageButton>
                <asp:LinkButton id="lnkSend" onclick="btnSend_Click" runat="server" CssClass="hyperlink-Button" Visible="true">Gửi</asp:LinkButton>--%>
            </td>
        </tr>
    </table>

</asp:Content>