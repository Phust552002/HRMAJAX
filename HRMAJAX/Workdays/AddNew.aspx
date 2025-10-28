<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="AddNew.aspx.cs" Inherits="Workdays_AddNew" Title="Untitled Page" %>
<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc2" %>

<%@ Register Src="~/Leave/UserControls/ListLeaves.ascx" TagName="ListLeaves" TagPrefix="uc5" %>
<%@ Register Src="~/Leave/UserControls/AddLeaves.ascx" TagName="AddLeaves" TagPrefix="uc6" %>
<%@ Register Src="~/UserControls/TabSub.ascx" TagName="TabSub" TagPrefix="uc4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table style="width: 100%">
    <tr>
        <td valign="top" >
            <table style="width: 100%">
                <tr>
                    <td valign="top">
                        <asp:UpdatePanel ID="UpdatePanel3" runat="server" >
                             <ContentTemplate>
                                <uc1:ucTitle ID="UcTitle1" runat="server" />                      
                             </ContentTemplate>
                             <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="imgSearch" EventName="Click" />                                
                             </Triggers>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td valign="top">                         
                        <table style="width: 100%" class="tableBorder"> 
                            <tr>
                                <td style="width: 80%" valign="top">
                                <TABLE cellSpacing=0 cellPadding=0 width="100%"><TBODY><TR><TD style="WIDTH: 10%" align=left><TABLE width="100%"><TBODY><TR><TD style="WIDTH: 25%" align=right><asp:ImageButton id="btnSend" onclick="btnSend_Click" runat="server" ImageUrl="~/Images/Icon_Send.gif" Visible="False"></asp:ImageButton></TD><TD style="WIDTH: 25%" align=left><asp:LinkButton id="lnkSend" onclick="btnSend_Click" runat="server" CssClass="hyperlink-Button" Visible="False">Gửi</asp:LinkButton></TD><TD style="WIDTH: 25%; font-size: 12pt; font-family: Times New Roman;" align=left><asp:ImageButton id="imgDelete" onclick="imgDelete_Click" runat="server" ImageUrl="~/Images/icon-delete.gif" Visible="False" OnClientClick="return confirm('Bạn có chắc muốn xóa bảng chấm công này ?');"></asp:ImageButton></TD><TD style="WIDTH: 25%; font-size: 12pt; font-family: Times New Roman;" align=left><asp:LinkButton id="lnkDelete" onclick="lnkDelete_Click" runat="server" CssClass="hyperlink-Button" Visible="False" OnClientClick="return confirm('Bạn có chắc muốn xóa bảng chấm công này ?');">Xóa</asp:LinkButton></TD><TD style="WIDTH: 15%; font-size: 12pt; font-family: Times New Roman;" align=left><asp:DropDownList id="ddlViewType" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlViewType_SelectedIndexChanged"><asp:ListItem Value="1">Xem mặc định</asp:ListItem>
<asp:ListItem Value="2">Xem Chi tiết</asp:ListItem>
</asp:DropDownList></TD></TR></TBODY></TABLE></TD><TD style="WIDTH: 80%" align=right><asp:Label id="Label3" runat="server" CssClass="label" Text="Họ tên"></asp:Label> <asp:TextBox id="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>&nbsp; &nbsp;
    <asp:Label ID="Label2" runat="server" CssClass="label" Text="Phòng Ban "></asp:Label>&nbsp;<asp:DropDownList
        ID="ddlDepartment" runat="server" AutoPostBack="True" CssClass="dropDownList"
        OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged">
    </asp:DropDownList>
    &nbsp;
    <asp:Label id="Label11" runat="server" CssClass="label" Text="Tháng"></asp:Label> <asp:DropDownList id="ddlMonths" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlMonths_SelectedIndexChanged"><asp:ListItem>1</asp:ListItem>
<asp:ListItem>2</asp:ListItem>
<asp:ListItem>3</asp:ListItem>
<asp:ListItem>4</asp:ListItem>
<asp:ListItem>5</asp:ListItem>
<asp:ListItem>6</asp:ListItem>
<asp:ListItem>7</asp:ListItem>
<asp:ListItem>8</asp:ListItem>
<asp:ListItem>9</asp:ListItem>
<asp:ListItem>10</asp:ListItem>
<asp:ListItem>11</asp:ListItem>
<asp:ListItem>12</asp:ListItem>
<asp:ListItem></asp:ListItem>
</asp:DropDownList> &nbsp;&nbsp;<asp:Label id="Label12" runat="server" CssClass="label" Text="Năm"></asp:Label> <asp:DropDownList id="ddlYears" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlYears_SelectedIndexChanged"></asp:DropDownList> </TD><TD style="WIDTH: 10%" align=right><asp:ImageButton id="imgSearch" onclick="imgSearch_Click" runat="server" ImageUrl="~/Images/Icon-Search.gif"></asp:ImageButton> </TD></TR></TBODY></TABLE>
                                </td>
                            </tr>
                            <tr>
                                <td style="width:80%" valign="top">
                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                                    <ContentTemplate>
                                    
<FIELDSET class="fieldset"><LEGEND class="legend"><asp:Label id="lbTitlefirst" runat="server" Text=""></asp:Label>&nbsp;<asp:Label id="lbTitleList" runat="server" Text="Chưa chọn phòng"></asp:Label></LEGEND><TABLE style="WIDTH: 100%" class="tableBorder"><TBODY><TR class="tdLabel">
    <td align="right" colspan="3">
    </td>
</TR><TR class="tdLabel">
    <td align="center" colspan="3">
        <asp:GridView id="grdWorkdayEmployees" runat="server" Width="100%" CssClass="grid-Border" OnSelectedIndexChanged="grdWorkdayEmployees_SelectedIndexChanged" DataSourceID="ObjectDataSource1" PageSize="5" OnRowDataBound="grdWorkdayEmployees_RowDataBound" DataKeyNames="UserId" AutoGenerateColumns="False" AllowPaging="True">
<PagerSettings PageButtonCount="30"></PagerSettings>
<Columns>
<asp:TemplateField SortExpression="FullName" HeaderText="Họ t&#234;n">
<ItemStyle Width="25%" HorizontalAlign="Left"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:LinkButton id="lnkFullName" runat="server" CssClass="hyperlink-Grid" Text='<%# Bind("FullName") %>' CommandName="Select" ToolTip='<%# Bind("UserId") %>'></asp:LinkButton> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="XQD" HeaderText="Xqđ">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
<ItemTemplate>
<asp:Label id="lbXQD" runat="server"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="NC_LamViec" HeaderText="X">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:Label id="lbNC_LamViec" runat="server"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Ố, Co, KHH, TNLD">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
                                                                                <asp:HyperLink ID="lnkF_O_Co_KHH_TNLD" runat="server"></asp:HyperLink>
                                                                            
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="F, Fdb, DD">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:HyperLink id="lnkF_Nam_Fdb_DD" runat="server"></asp:HyperLink> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="TS">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
                                                                                <asp:HyperLink ID="lnkF_ThaiSan" runat="server"></asp:HyperLink>
                                                                            
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="F_CongTac" HeaderText="CT">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
<ItemTemplate>
<asp:HyperLink id="lnkF_CongTac" runat="server" ></asp:HyperLink> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Ho">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
                                                                                <asp:HyperLink ID="lnkF_Hoc" runat="server"></asp:HyperLink>
                                                                            
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Kh&#225;c">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
                                                                                <asp:HyperLink ID="lnkF_Khac" runat="server"></asp:HyperLink>
                                                                            
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="NghiTuan" HeaderText="NT, NB">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
                                                                                <asp:HyperLink ID="lnkNghiTuan_NghiBu" runat="server"></asp:HyperLink>                                                                        
                                                                            
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="CongDu" HeaderText="X dư qu&#225; khứ">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
<ItemTemplate>
<asp:Label runat="server" id="lbOldCongDu"></asp:Label>
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="CongDu" HeaderText="X dư trong th&#225;ng">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
<ItemTemplate>
<asp:Label runat="server" id="lbCongDu"></asp:Label>
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="CongDu" HeaderText="X dư">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
<ItemTemplate>
<asp:Label runat="server" id="lbFinalCongDu"></asp:Label>
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="GC_LamDem" HeaderText="LĐ (giờ)">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
                                                                                <asp:Label ID="lbGC_LamDem" runat="server"></asp:Label>
                                                                            
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="Count1_2X" HeaderText="Số 1/2X">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
<ItemTemplate>
<asp:Label runat="server" id="lbCount1_2X"></asp:Label>
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="CountX" HeaderText="Số X">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
<ItemTemplate>
<asp:Label runat="server" id="lbCountX"></asp:Label>
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="Mark" HeaderText="Điểm HTCV">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
   <asp:Label ID="lbMark" runat="server" ></asp:Label>                                                                            
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="HTCV" HeaderText="Xếp Loại">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
   <asp:Label ID="Label15" runat="server" Text='<%# Bind("HTCV") %>'></asp:Label>                                                                            
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="Remark" HeaderText="Ghi Ch&#250;"><ItemTemplate>
<asp:Label runat="server" id="lbRemark"></asp:Label>
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Copy">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
   <asp:HyperLink ID="lnkCopy" runat="server" ImageUrl="~/Images/copy.gif"></asp:HyperLink>                                                                            
</ItemTemplate>
</asp:TemplateField>
</Columns>

<RowStyle CssClass="grid-item"></RowStyle>

<SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>

<PagerStyle CssClass="grid-paper"></PagerStyle>

<HeaderStyle CssClass="grid-header1"></HeaderStyle>

<AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
</asp:GridView> <asp:LinkButton id="lnkInit" onclick="lnkInit_Click" runat="server" CssClass="hyperlink" Visible="False" OnClientClick="return confirm('Bạn có muốn tạo bảng chấm công ?')">Click vào đây để tạo bảng chấm công</asp:LinkButton><asp:ObjectDataSource id="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" TypeName="HRMBLL.H1.WorkdayEmployeesBLL" SelectMethod="GetByFilter" OnSelecting="ObjectDataSource1_Selecting" OnSelected="ObjectDataSource1_Selected"><SelectParameters>
<asp:Parameter Type="String" Name="fullName"></asp:Parameter>
<asp:Parameter Type="String" Name="departmentIds"></asp:Parameter>
<asp:Parameter Type="Int32" Name="month"></asp:Parameter>
<asp:Parameter Type="Int32" Name="year"></asp:Parameter>
<asp:Parameter Type="Int32" Name="status"></asp:Parameter>
<asp:Parameter Type="Int32" Name="receivedUserId"></asp:Parameter>
<asp:Parameter Type="Int32" Name="typeSort"></asp:Parameter>
</SelectParameters>
</asp:ObjectDataSource> 
    </td>
</TR>
<asp:Panel id="pnTimeKeeping" runat="server" Width="100%" Visible="true">
                                                        <tr>
                                                            <td colspan="3">
                                                                <table width="100%" class="tableBorder">
                                                                     <tr>
                                                                        <td align="left" class="tdLabel"><asp:Label ID="Label5" runat="server" CssClass="label" Text="Nhân viên"></asp:Label></td>
                                                                        <td class="tdValue"><asp:Label ID="lbEmployeeSelected" runat="server" CssClass="value"></asp:Label></td>                                                                                                                                                
                                                                        <td align="left" class="tdLabel"><asp:Label ID="lbMarkHTCV" runat="server" CssClass="label" Text="Điểm HTCV"></asp:Label></td>
                                                                        <td align="left" class="tdValue"><asp:TextBox ID="txtMark" runat="server" CssClass="textBox-Disable" Width="50px" Enabled="false"></asp:TextBox>                                                                        
                                                                        <a href="javascript:OpenPopupHTCVPage('MarkHTCV.aspx','<%= txtMark.ClientID %>','<%= Page.IsPostBack %>', '<%= UserSelected%>','<%= Month%>','<%= Year%>');">
                                                                         <img src="../Images/icn_pen.gif" border="0" align="absBottom" width="24" height="16"></a> 
                                                                        </td>
                                                                        <td align="left" class="tdLabel"><asp:Label ID="lbTitleRemark" runat="server" CssClass="label" Text="Ghi chú"></asp:Label></td>
                                                                        <td align="left" class="tdValue"><asp:TextBox ID="txtRemark" runat="server" CssClass="textBox" Width="200px" ></asp:TextBox></td>
                                                                        <td align="left" class="tdLabel"><asp:Label ID="lbRank" runat="server" CssClass="label" Text="Xếp loại"></asp:Label> </td>
                                                                        <td align="left" class="tdValue"><asp:Label ID="lnkRank" runat="server" CssClass="labelHTCV" ></asp:Label></td>
                                                                    </tr>                                               
                                                                    <tr>
                                                                        <td class="tdLabel"><asp:Label ID="Label4" runat="server" CssClass="label" Text="Theo"></asp:Label></td>
                                                                        <td class="tdValue"><asp:DropDownList ID="ddlType" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlType_SelectedIndexChanged"></asp:DropDownList></td>
                                                                        <td class="tdLabel" align="left">
                                                                            <asp:Label ID="lbLeaveType" runat="server" CssClass="label" Text="Loại"></asp:Label></td>
                                                                        <td class="tdValue" align="left" colspan="3">
                                                                            <asp:DropDownList ID="ddlLeaveTypes" runat="server" CssClass="dropDownList"></asp:DropDownList>
                                                                            <asp:DropDownList ID="ddl4gio" runat="server" CssClass="dropDownList">
                                                                            </asp:DropDownList>
                                                                            </td>
                                                                        <td align="left" class="tdLabel"><asp:Label ID="lbgcLamDem" runat="server" CssClass="label" Text="Giờ đêm" Visible="true"></asp:Label><asp:Label ID="lbFromDate" runat="server" CssClass="label" Text="Từ ngày" Visible="false"></asp:Label><br/><asp:Label ID="lbToDate" runat="server" CssClass="label" Text="Đến ngày" Visible="false"></asp:Label></td>
                                                                        <td align="left" class="tdValue"><uc2:CalendarPicker id="cpFromDate" runat="server"></uc2:CalendarPicker><uc2:CalendarPicker id="cpToDate" runat="server"></uc2:CalendarPicker><asp:CheckBox ID="chkGioDem" runat="server" AutoPostBack="True" OnCheckedChanged="chkGioDem_CheckedChanged" /><asp:ImageButton id="imgApplyTimeKeeping" onclick="imgApplyTimeKeeping_Click" runat="server" ImageUrl="~/Images/icn_pen.gif"></asp:ImageButton></td>
                                                                        
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>                                                                                                      
                                                       
                                                         <tr class="tdLabel">
                                                             <td align="left" colspan="1" valign="top" width="50%">
                                                                 <table style="width: 100%; background-color:White" class="tableBorder" >
                                                                    <tr class="grid-header">
                                                                        <td colspan="7" align="center">CHẤM CÔNG DẤU VÂN TAY</td>
                                                                    </tr>
                                                                     <tr class="grid-header1">
                                                                         <td align="center" style="width:14%">
                                                                             Thứ Hai</td>
                                                                         <td align="center" style="width:14%">
                                                                             Thứ Ba</td>
                                                                         <td align="center" style="width:14%">
                                                                             Thứ Tư</td>
                                                                         <td align="center" style="width:14%">
                                                                             Thứ Năm</td>
                                                                         <td align="center" style="width:14%">
                                                                             Thứ Sáu</td>
                                                                         <td align="center" style="width:15%">
                                                                             Thứ Bảy</td>
                                                                         <td align="center" style="width:15%">
                                                                             Chủ Nhật</td>
                                                                     </tr>
                                                                     <tr>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF12" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF12" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime12" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight12" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF13" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF13" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>                                                                                     
                                                                                     <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime13" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight13" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF14" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF14" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>                                                                                     
                                                                                     <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime14" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight14" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF15" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF15" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>                                                                                     
                                                                                     <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime15" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight15" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF16" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF16" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>                                                                                     
                                                                                     <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime16" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight16" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdValue" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF17" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF17" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>                                                                                     
                                                                                     <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime17" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight17" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdValue" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF18" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF18" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>                                                                                     
                                                                                     <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime18" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight18" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                     </tr>
                                                                     <tr>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF22" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF22" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime22" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight22" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF23" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF23" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime23" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight23" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF24" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF24" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime24" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight24" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF25" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF25" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime25" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight25" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF26" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF26" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                 <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime26" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight26" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdValue" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF27" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF27" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                 <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime27" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight27" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdValue" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF28" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF28" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime28" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight28" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                     </tr>
                                                                     <tr>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF32" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF32" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime32" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight32" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF33" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF33" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime33" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight33" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF34" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF34" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime34" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight34" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF35" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF35" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime35" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight35" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF36" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF36" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime36" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight36" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdValue" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF37" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF37" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime37" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight37" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdValue" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF38" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF38" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime38" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight38" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                     </tr>
                                                                     <tr>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF42" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF42" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime42" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight42" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF43" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF43" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime43" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight43" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF44" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF44" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime44" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight44" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF45" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF45" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime45" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight45" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF46" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF46" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime46" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight46" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdValue" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF47" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF47" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime47" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight47" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdValue" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF48" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF48" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime48" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight48" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                     </tr>
                                                                     <tr>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF52" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF52" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime52" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight52" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF53" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF53" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime53" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight53" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF54" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF54" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime54" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight54" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF55" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF55" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime55" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight55" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF56" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF56" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime56" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight56" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdValue" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF57" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF57" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime57" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight57" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdValue" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF58" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF58" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime58" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>   
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight58" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                     </tr>
                                                                     <tr>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF62" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF62" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime62" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight62" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF63" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF63" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>                                                                                 
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime63" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight63" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF64" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF64" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime64" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight64" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF65" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF65" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime65" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight65" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF66" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF66" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime66" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight66" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdValue" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF67" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF67" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime67" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight67" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                         <td align="center" class="tdValue" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%">
                                                                                 <tr>
                                                                                     <td align="left" colspan="2">
                                                                                         <asp:Label ID="lbF68" runat="server" CssClass="label-Day"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td align="center" colspan="2">
                                                                                         <asp:Label ID="lnkF68" runat="server" CssClass="FDayTime-TimeKeeping"></asp:Label></td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                    <td align="left">
                                                                                         <asp:Label
                                                                                             ID="lbFDayTime68" runat="server" CssClass="FHourDayTime-TimeKeeping"></asp:Label></td>
                                                                                     <td align="right">
                                                                                         <asp:Label
                                                                                             ID="lbFNight68" runat="server" CssClass="value-Calendar"></asp:Label></td>
                                                                                 </tr>
                                                                             </table>
                                                                         </td>
                                                                     </tr>
                                                                 </table>
                                                             </td>
                                                            <td align="left" colspan="2" valign="top" width="50%">                                                                                                                                                                             
                                                               <table style="width: 100%; background-color:White" class="tableBorder" >
                                                                     <tr class="grid-header">
                                                                        <td colspan="7" align="center">CHẤM CÔNG DẤU MANUAL</td>
                                                                    </tr>
                                                                    <tr class="grid-header1">
                                                                        <td align="center" style="width:14%">
                                                                            Thứ Hai</td>
                                                                        <td align="center" style="width:14%">
                                                                            Thứ Ba</td>
                                                                        <td align="center" style="width:14%">
                                                                            Thứ Tư</td>
                                                                        <td align="center" style="width:14%">
                                                                            Thứ Năm</td>
                                                                        <td align="center" style="width:14%">
                                                                            Thứ Sáu</td>
                                                                        <td align="center" style="width:15%">
                                                                            Thứ Bảy</td>
                                                                        <td align="center" style="width:15%">
                                                                            Chủ Nhật</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb12" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk12" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight12" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight12" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb13" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk13" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight13" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight13" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb14" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk14" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight14" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight14" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>   
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb15" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk15" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight15" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight15" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>                  
                                                                         </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb16" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk16" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight16" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight16" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>                        
                                                                         </td>
                                                                        <td align="center" class="tdValue" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb17" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk17" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight17" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight17" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>                   
                                                                         </td>
                                                                        <td align="center" class="tdValue" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left" valign="top"><asp:Label ID="lb18" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk18" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight18" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight18" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb22" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk22" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight22" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight22" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb23" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk23" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight23" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight23" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb24" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk24" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight24" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight24" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb25" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk25" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight25" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight25" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb26" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk26" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight26" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight26" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb27" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk27" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight27" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight27" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb28" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk28" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight28" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight28" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                       </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb32" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk32" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight32" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight32" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb33" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk33" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight33" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight33" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                       </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb34" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk34" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight34" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight34" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb35" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk35" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight35" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight35" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb36" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk36" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight36" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight36" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb37" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk37" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight37" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight37" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                       </td>
                                                                        <td align="center" class="tdValue" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb38" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk38" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight38" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight38" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb42" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk42" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight42" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight42" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb43" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk43" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight43" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight43" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb44" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk44" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight44" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight44" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb45" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk45" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight45" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight45" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb46" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk46" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight46" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight46" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb47" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk47" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight47" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight47" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>                                                                                
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb48" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk48" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight48" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight48" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb52" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk52" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight52" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight52" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                       </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb53" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk53" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight53" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight53" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb54" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk54" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight54" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight54" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb55" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk55" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight55" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight55" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb56" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk56" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight56" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight56" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb57" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk57" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight57" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight57" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb58" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk58" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight58" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight58" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb62" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk62" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight62" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight62" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                       </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb63" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk63" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight63" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight63" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb64" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk64" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight64" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight64" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb65" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"> <asp:LinkButton ID="lnk65" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight65" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight65" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel" valign="top">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb66" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk66" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight66" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight66" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb67" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk67" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight67" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight67" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                         </td>
                                                                        <td align="center" class="tdValue" valign="top">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb68" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk68" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                                <tr><td align="right"><asp:TextBox ID="txtNight68" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight68" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>                                                        
                                                            </td>
                                                        </tr>                                                
                                                        <tr>
                                                            <td align="center" class="tdButton" colspan="1">
                                                            </td>
                                                            <td colspan="2" class="tdButton" align="center"> 
                                                                <table width="100%">
                                                                    <tr>
                                                                        <td style="width:50%" align="right"><asp:ImageButton ID="btnSave" runat="server" OnClick="btnSave_Click" ImageUrl="~/Images/icon-save.gif"/></td>
                                                                        <td style="width:50%" align="left"><asp:LinkButton ID="lnkSave" runat="server" OnClick="btnSave_Click" CssClass="hyperlink-Button">Lưu</asp:LinkButton></td>
                                                                    </tr>
                                                                </table>                                                                                                                                                                  
                                                            </td>
                                                        </tr>
                                                        
                                                        </asp:Panel>
                                                        </TBODY></TABLE><uc3:ucPermission id="UcPermission1" runat="server"></uc3:ucPermission> </FIELDSET> 
  
                                    </ContentTemplate>
                                   
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
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>
<script type="text/javascript" src="../JScripts/script.js"></script>
</asp:Content>

