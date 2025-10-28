<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddLeaves.ascx.cs" Inherits="Leave_UserControls_AddLeaves" %>
<%@ Register Src="../../UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc3" %>
<%@ Register Src="../../UserControls/CalendarPicker.ascx" TagName="CalendarPicker"
    TagPrefix="uc2" %>
<%@ Register Src="../../UserControls/DatePicker.ascx" TagName="DatePicker" TagPrefix="uc1" %>

<uc3:MessageError ID="MessageError1" runat="server" />
<table style="width: 100%">
    <tr>
        <td>
             <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                <ContentTemplate>
            <table style="width: 100%" class="tableBorder">
                <tr>
                    <td class="tdLabel" align="left">
                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Loại ngày nghỉ"></asp:Label></td>
                    <td class="tdValue" align="left">
                        <asp:DropDownList ID="ddlLeaveTypes" runat="server" CssClass="dropDownList" DataSourceID="odsLeaveType" DataTextField="LeaveTypeName" DataValueField="LeaveTypeId">
                        </asp:DropDownList>
                        <asp:ObjectDataSource ID="odsLeaveType" runat="server" SelectMethod="GetByFilter"
                            TypeName="HRMBLL.H0.LeaveTypesBLL" OldValuesParameterFormatString="original_{0}" OnSelecting="odsLeaveType_Selecting">
                            <SelectParameters>
                                <asp:Parameter Name="leaveTypeCode" Type="String" />
                                <asp:Parameter Name="leaveTypeName" Type="String" />
                                <asp:Parameter Name="type" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel" align="left">
                        <asp:Label ID="Label6" runat="server" CssClass="label" Text="Từ ngày"></asp:Label></td>
                    <td class="tdValue" align="left">
                        <uc2:CalendarPicker ID="cpFromDate" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel" align="left">
                        <asp:Label ID="Label7" runat="server" CssClass="label" Text="Đến ngày"></asp:Label></td>
                    <td class="tdValue" align="left">
                        <table cellpadding="0" cellspacing="0">
                            <tr>
                                <td> 
                                    <uc2:CalendarPicker ID="cpToDate" runat="server" />
                                    </td>
                                <td> <asp:ImageButton ID="imgGetTotalDays" runat="server" ImageUrl="~/Images/icn_pen.gif" OnClick="imgGetTotalDays_Click" /> </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="left" class="tdLabel">
                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Số ngày nghỉ"></asp:Label></td>
                    <td align="left" class="tdValue">
                        <asp:Label ID="lbTotalLeaveDays" runat="server" CssClass="label"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tdLabel" align="left">
                        <asp:Label ID="Label9" runat="server" CssClass="label" Text="Ghi chú"></asp:Label></td>
                    <td class="tdValue" align="left">
                        <asp:TextBox ID="txtRemark" runat="server" CssClass="textBox" TextMode="MultiLine" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" class="tdButton" align="center">
                        <asp:Button ID="btnSave" runat="server" CssClass="small color green button" Text="Thêm" OnClick="btnSave_Click" Width="100px" />                        
                    </td>
                </tr>
            </table>
                </ContentTemplate>               
            </asp:UpdatePanel>  
        </td>
    </tr>
</table>

