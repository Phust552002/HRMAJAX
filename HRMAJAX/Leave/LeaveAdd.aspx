<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="LeaveAdd.aspx.cs" Inherits="Leave_LeaveAdd" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
<table style="width: 100%">
    <tr>
        <td valign="top" >
            <table style="width: 100%">
                <tr>
                    <td valign="top">
                        <uc1:ucTitle ID="UcTitle1" runat="server" />                      
                    </td>018
                </tr>
                <tr>
                    <td valign="top">
                         
                        <table style="width: 100%" class="tableBorder"> 
                            <tr>
                                <td style="width:30%" valign="top" class="tdTreeView" align="left">
                                    <asp:TreeView  
                                        ID="TreeView1"
                                        ExpandDepth="1" 
                                        PopulateNodesFromClient="true" 
                                        ShowLines="true" 
                                        ShowExpandCollapse="true" 
                                        runat="server"
                                        OnTreeNodePopulate="TreeView1_TreeNodePopulate" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
                                        <RootNodeStyle CssClass="tvNodeRoot" />
                                        <NodeStyle CssClass="tvNode" />
                                        <ParentNodeStyle CssClass="tvNodeParent" />
                                        <SelectedNodeStyle CssClass="tvNodeSelected" />
                                    </asp:TreeView>  
                                </td>
                                <td style="width:70%" valign="top">
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                                    <ContentTemplate>
<asp:Panel id="pnLeaveDate" runat="server" Width="100%"><FIELDSET class="fieldset"><LEGEND class="legend"><asp:Label id="lbTitleList" runat="server" Text="Chưa chọn phòng"></asp:Label></LEGEND><TABLE style="WIDTH: 100%" class="tableBorder"><TBODY><TR><TD class="tdLabel" align=left><asp:Label id="Label3" runat="server" CssClass="label" Text="Tìm nhân viên"></asp:Label></TD><TD class="tdValue" align=left><TABLE cellSpacing=0 cellPadding=0><TBODY><TR><TD><asp:TextBox id="txtFullName" runat="server" CssClass="textBox"></asp:TextBox> </TD><TD>&nbsp;<asp:ImageButton id="imgSearch" onclick="imgSearch_Click" runat="server" ImageUrl="~/Images/Icon-Search.gif"></asp:ImageButton> </TD></TR></TBODY></TABLE></TD></TR><TR><TD class="tdLabel" align=left><asp:Label id="Label1" runat="server" CssClass="label" Text="Nhân viên"></asp:Label></TD><TD class="tdValue" align=left><asp:DropDownList id="ddlEmployees" runat="server" CssClass="dropDownList" DataValueField="UserId" DataTextField="FullName" DataSourceID="odsEmployees">
                                                        </asp:DropDownList> <asp:ObjectDataSource id="odsEmployees" runat="server" TypeName="HRMBLL.H0.EmployeesBLL" SelectMethod="GetByDeptIds" OnSelecting="odsEmployees_Selecting" OldValuesParameterFormatString="original_{0}"><SelectParameters>
<asp:Parameter Type="String" Name="deptIds"></asp:Parameter>
<asp:Parameter Type="Int32" Name="rootId"></asp:Parameter>
<asp:Parameter Type="String" Name="fullName"></asp:Parameter>
<asp:Parameter Type="String" Name="sortParameter"></asp:Parameter>
        <asp:Parameter Name="AirlinesWorking" Type="String" />
</SelectParameters>
</asp:ObjectDataSource> </TD></TR><TR><TD class="tdLabel" align=left><asp:Label id="Label5" runat="server" CssClass="label" Text="Loại ngày nghỉ"></asp:Label></TD><TD class="tdValue" align=left><asp:DropDownList id="ddlLeaveTypes" runat="server" CssClass="dropDownList" DataValueField="LeaveTypeId" DataTextField="LeaveTypeName" DataSourceID="odsLeaveType">
                                                        </asp:DropDownList> <asp:ObjectDataSource id="odsLeaveType" runat="server" TypeName="HRMBLL.H0.LeaveTypesBLL" SelectMethod="GetByFilter" OnSelecting="odsLeaveType_Selecting" OldValuesParameterFormatString="original_{0}"><SelectParameters>
<asp:Parameter Type="String" Name="leaveTypeCode"></asp:Parameter>
<asp:Parameter Type="String" Name="leaveTypeName"></asp:Parameter>
<asp:Parameter Type="Int32" Name="type"></asp:Parameter>
</SelectParameters>
</asp:ObjectDataSource> </TD></TR><TR><TD class="tdLabel" align=left><asp:Label id="Label6" runat="server" CssClass="label" Text="Từ ngày"></asp:Label></TD><TD class="tdValue" align=left><uc2:CalendarPicker id="cpFromDate" runat="server"></uc2:CalendarPicker> </TD></TR><TR><TD class="tdLabel" align=left><asp:Label id="Label7" runat="server" CssClass="label" Text="Đến ngày"></asp:Label></TD><TD class="tdValue" align=left><TABLE cellSpacing=0 cellPadding=0><TBODY><TR><TD><uc2:CalendarPicker id="cpToDate" runat="server"></uc2:CalendarPicker> </TD><TD><asp:ImageButton id="imgGetTotalDays" onclick="imgGetTotalDays_Click" runat="server" ImageUrl="~/Images/icn_pen.gif"></asp:ImageButton> </TD></TR></TBODY></TABLE></TD></TR><TR><TD class="tdLabel" align=left><asp:Label id="Label2" runat="server" CssClass="label" Text="Số ngày nghỉ"></asp:Label></TD><TD class="tdValue" align=left><asp:Label id="lbTotalLeaveDays" runat="server" CssClass="label"></asp:Label></TD></TR><TR><TD class="tdLabel" align=left><asp:Label id="Label9" runat="server" CssClass="label" Text="Ghi chú"></asp:Label></TD><TD class="tdValue" align=left><asp:TextBox id="txtRemark" runat="server" Width="250px" CssClass="textBox" TextMode="MultiLine"></asp:TextBox></TD></TR><TR><TD class="tdButton" align=center colSpan=2><asp:Button id="btnSave" onclick="btnSave_Click" runat="server" Width="100px" CssClass="small color green button" Text="Thêm"></asp:Button> &nbsp; <asp:Button id="btnCancel" onclick="btnCancel_Click" runat="server" Width="100px" CssClass="small color green button" Text="Thoát"></asp:Button></TD></TR></TBODY></TABLE><uc3:ucPermission id="UcPermission1" runat="server"></uc3:ucPermission> </FIELDSET> </asp:Panel> <asp:Label id="lbError" runat="server" CssClass="error-Text" Text="Bạn không có quyền !."></asp:Label> 
</ContentTemplate>
                                     <Triggers>
                                            <asp:AsyncPostBackTrigger ControlID="TreeView1" EventName="SelectedNodeChanged" />
                                         </Triggers>               
                                 </asp:UpdatePanel> 
                                    
                                </td>
                            </tr>
                            
                        </table>
                                              
                    </td>
                </tr>
            </table>
         </td>   
     </tr>
</table>
</asp:Content>

