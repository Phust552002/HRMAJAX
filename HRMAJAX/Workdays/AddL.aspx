<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="AddL.aspx.cs" Inherits="Workdays_AddL" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

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
                                <td style="width:20%" valign="top" class="tdTreeView" align="left">
                                    <asp:TreeView  
                                        ID="TreeView1"
                                        ExpandDepth="2" 
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
                                <td style="width:80%" valign="top">
                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                                    <ContentTemplate>
<FIELDSET class="fieldset"><LEGEND class="legend"><asp:Label id="lbTitleList" runat="server" Text="Chưa chọn phòng"></asp:Label></LEGEND><TABLE style="WIDTH: 100%" class="tableBorder"><TBODY><TR class="tdLabel"><TD align=right colSpan=2><TABLE cellSpacing=0 cellPadding=0 width="100%"><TBODY><TR><TD style="WIDTH: 10%" align=left><TABLE width="100%"><TBODY><TR><TD style="WIDTH: 25%" align=left><asp:DropDownList id="ddlViewType" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlViewType_SelectedIndexChanged"><asp:ListItem Value="1">Xem mặc định</asp:ListItem>
<asp:ListItem Value="2">Xem Chi tiết</asp:ListItem>
</asp:DropDownList></TD></TR></TBODY></TABLE></TD><TD style="WIDTH: 80%" align=right><asp:Label id="Label3" runat="server" CssClass="label" Text="Họ tên"></asp:Label> <asp:TextBox id="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>&nbsp; <asp:Label id="Label11" runat="server" CssClass="label" Text="Tháng"></asp:Label> <asp:DropDownList id="ddlMonths" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlMonths_SelectedIndexChanged"><asp:ListItem>1</asp:ListItem>
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
</asp:DropDownList> &nbsp;&nbsp;<asp:Label id="Label12" runat="server" CssClass="label" Text="Năm"></asp:Label> <asp:DropDownList id="ddlYears" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlYears_SelectedIndexChanged"></asp:DropDownList> </TD><TD style="WIDTH: 10%" align=right><asp:ImageButton id="imgSearch" onclick="imgSearch_Click" runat="server" ImageUrl="~/Images/Icon-Search.gif"></asp:ImageButton> </TD></TR></TBODY></TABLE></TD></TR><TR class="tdLabel"><TD align=center colSpan=2><asp:GridView id="grdWorkdayEmployees" runat="server" Width="100%" CssClass="grid-Border" OnSelectedIndexChanged="grdWorkdayEmployees_SelectedIndexChanged" DataSourceID="ObjectDataSource1" PageSize="5" OnRowDataBound="grdWorkdayEmployees_RowDataBound" DataKeyNames="UserId" AutoGenerateColumns="False" AllowPaging="True">
<PagerSettings PageButtonCount="30"></PagerSettings>
<Columns>
<asp:TemplateField SortExpression="FullName" HeaderText="Họ t&#234;n">
<ItemStyle Width="25%" HorizontalAlign="Left"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:LinkButton id="lnkFullName" runat="server" CssClass="hyperlink-Grid" Text='<%# Bind("FullName") %>' CommandName="Select" ToolTip='<%# Bind("UserId") %>'></asp:LinkButton> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="XQDL" HeaderText="XQĐL">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
<ItemTemplate>
<asp:Label id="lbXQDL" runat="server"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="XL" HeaderText="XL">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:Label id="lbXL" runat="server"></asp:Label> 
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
<asp:TemplateField SortExpression="GC_LamDem" HeaderText="LĐ (giờ)">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
                                                                                <asp:Label ID="lbGC_LamDem" runat="server"></asp:Label>
                                                                            
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="MarkL" HeaderText="Điểm HTCV">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
<ItemTemplate>
<asp:Label runat="server" id="lbMarkL"></asp:Label>
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="RankL" HeaderText="Xếp Loại">
<ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
   <asp:Label ID="Label15" runat="server" Text='<%# Bind("RankL") %>'></asp:Label>                                                                            
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="RemarkL" HeaderText="Ghi Ch&#250;"><ItemTemplate>
<asp:Label runat="server" id="lbRemarkL"></asp:Label>
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

<HeaderStyle CssClass="grid-header2"></HeaderStyle>

<AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
</asp:GridView> <asp:LinkButton id="lnkInit" onclick="lnkInit_Click" runat="server" CssClass="hyperlink" OnClientClick="return confirm('Bạn có muốn tạo bảng chấm công ?')" Visible="False">Click vào đây để tạo bảng chấm công</asp:LinkButton><asp:ObjectDataSource id="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" TypeName="HRMBLL.H1.WorkdayEmployeesBLLL" SelectMethod="GetByFilter" OnSelecting="ObjectDataSource1_Selecting" OnSelected="ObjectDataSource1_Selected"><SelectParameters>
<asp:Parameter Type="String" Name="fullName"></asp:Parameter>
<asp:Parameter Type="String" Name="departmentIds"></asp:Parameter>
<asp:Parameter Type="Int32" Name="month"></asp:Parameter>
<asp:Parameter Type="Int32" Name="year"></asp:Parameter>
<asp:Parameter Type="Int32" Name="typeSort"></asp:Parameter>
</SelectParameters>
</asp:ObjectDataSource> </TD></TR><asp:Panel id="pnTimeKeeping" runat="server" Width="100%" Visible="false">
                                                        <tr>
                                                            <td colspan="2">
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
                                                                        <td align="left" class="tdValue"><uc2:CalendarPicker id="cpFromDate" runat="server"></uc2:CalendarPicker><uc2:CalendarPicker id="cpToDate" runat="server"></uc2:CalendarPicker><asp:TextBox ID="txtNightTime" runat="server" CssClass="textBox" Width="30px"></asp:TextBox><asp:ImageButton id="imgApplyTimeKeeping" onclick="imgApplyTimeKeeping_Click" runat="server" ImageUrl="~/Images/icn_pen.gif"></asp:ImageButton></td>
                                                                        
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>                                                                                                      
                                                        
                                                         <tr class="tdLabel">
                                                            <td align="left" colspan="2">                                                                                                                                                                             
                                                               <table style="width: 100%; background-color:White" class="tableBorder" >
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
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb12" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk12" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb13" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk13" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>                                                                                
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb14" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk14" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>   
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb15" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk15" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>                  
                                                                         </td>
                                                                        <td align="center" class="tdLabel">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb16" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk16" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>                        
                                                                         </td>
                                                                        <td align="center" class="tdValue">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb17" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk17" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>                   
                                                                         </td>
                                                                        <td align="center" class="tdValue">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left" valign="top"><asp:Label ID="lb18" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk18" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb22" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk22" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb23" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk23" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb24" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk24" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb25" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk25" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb26" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk26" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb27" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk27" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb28" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk28" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                       </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb32" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk32" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb33" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk33" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                       </td>
                                                                        <td align="center" class="tdLabel">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb34" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk34" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb35" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk35" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb36" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk36" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb37" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk37" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                       </td>
                                                                        <td align="center" class="tdValue">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb38" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk38" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="center" class="tdLabel">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb42" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk42" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb43" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk43" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb44" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk44" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb45" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk45" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb46" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk46" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb47" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk47" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb48" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk48" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="center" class="tdLabel">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb52" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk52" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                       </td>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb53" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk53" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb54" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk54" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb55" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk55" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb56" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk56" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb57" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk57" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb58" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk58" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="center" class="tdLabel">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb62" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk62" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                       </td>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb63" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk63" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb64" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk64" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb65" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"> <asp:LinkButton ID="lnk65" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdLabel">
                                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb66" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk66" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" class="tdValue">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb67" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk67" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                         </td>
                                                                        <td align="center" class="tdValue">
                                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                                <tr><td align="left"><asp:Label ID="lb68" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                                <tr><td align="center"><asp:LinkButton ID="lnk68" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>                                                        
                                                            </td>
                                                        </tr>                                                
                                                        <tr>
                                                            <td colspan="2" class="tdButton" align="center"> 
                                                                <table width="100%">
                                                                    <tr>
                                                                        <td style="width:50%" align="right"><asp:ImageButton ID="btnSave" runat="server" OnClick="btnSave_Click" ImageUrl="~/Images/icon-save.gif"/></td>
                                                                        <td style="width:50%" align="left"><asp:LinkButton ID="lnkSave" runat="server" OnClick="btnSave_Click" CssClass="hyperlink-Button">Lưu</asp:LinkButton></td>
                                                                    </tr>
                                                                </table>                                                                                                                                                                  
                                                            </td>
                                                        </tr>
                                                        
                                                        </asp:Panel></TBODY></TABLE><uc3:ucPermission id="UcPermission1" runat="server"></uc3:ucPermission> </FIELDSET> 
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

