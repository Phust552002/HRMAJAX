<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="SendDetail.aspx.cs" Inherits="Workdays_SendDetail" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc2" %>

<%@ Register Src="~/Leave/UserControls/ListLeaves.ascx" TagName="ListLeaves" TagPrefix="uc5" %>
<%@ Register Src="~/Leave/UserControls/AddLeaves.ascx" TagName="AddLeaves" TagPrefix="uc6" %>
<%@ Register Src="~/UserControls/TabSub.ascx" TagName="TabSub" TagPrefix="uc4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table width="100%">
    <tr>
        <td valign="top">
            <uc1:ucTitle ID="UcTitle1" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
             <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
              <ContentTemplate>
            <fieldset>
                <legend class="legend">
                    <asp:Label ID="lbTitleWorkingEmployee" runat="server" Text="Label"></asp:Label></legend>
                    <table style="width: 100%">
                        <tr>
                            <td style="width:20%" valign="top">
                                <table style="width: 100%" class="tableBorder">
                                    <tr>
                                        <td class="tdLabel" style="width:50%">
                                            <asp:Label ID="Label1" runat="server" CssClass="label" Text="X"></asp:Label></td>
                                        <td class="tdValue" style="width:50%">
                                            <asp:Label ID="lbX" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label2" runat="server" CssClass="label" Text="Ố,Co,NC,KHHDS"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbOCoKHHDS" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label3" runat="server" CssClass="label" Text="TS"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbTS" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label4" runat="server" CssClass="label" Text="TNLD"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbTNLD" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label5" runat="server" CssClass="label" Text="DD"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbDD" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label6" runat="server" CssClass="label" Text="Fdb"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbFdb" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label17" runat="server" CssClass="label" Text="FC"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbFC" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label7" runat="server" CssClass="label" Text="Ho"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbHo" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label8" runat="server" CssClass="label" Text="F"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbF" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label9" runat="server" CssClass="label" Text="Khác"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbKhac" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label10" runat="server" CssClass="label" Text="NT"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbNT" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label11" runat="server" CssClass="label" Text="NB"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbNB" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label12" runat="server" CssClass="label" Text="Đêm"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbCountNights" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label14" runat="server" CssClass="label" Text="Tổng số giờ đêm"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbGcLamDem" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                </table>
                            </td>
                            <td style="width:80%" valign="top">
                                <table style="width: 100%" class="tableBorder">                                   
                                        <tr>
                                            <td>
                                                 <table width="100%" class="tableBorder">
                                                     <tr>
                                                        <td align="left" class="tdLabel"><asp:Label ID="Label13" runat="server" CssClass="label" Text="Nhân viên"></asp:Label></td>
                                                        <td class="tdValue"><asp:Label ID="lbEmployeeSelected" runat="server" CssClass="value"></asp:Label></td>                                                                                                                                                
                                                        <td align="left" class="tdLabel"><asp:Label ID="lbMarkHTCV" runat="server" CssClass="label" Text="Điểm HTCV"></asp:Label></td>
                                                        <%--<td align="left" class="tdValue"><asp:TextBox ID="txtMark" runat="server" CssClass="textBox-Disable" Width="50px" ></asp:TextBox>--%>
                                                         <td align="left" class="tdValue"><asp:Label ID="txtMark" runat="server" CssClass="label"></asp:Label>
                                                            
                                                        <a href="javascript:OpenPopupHTCVPage('MarkHTCV.aspx','<%= txtMark.ClientID %>','<%= Page.IsPostBack %>', '<%= UserId%>','<%= Month%>','<%= Year%>');">
                                                         <img src="../Images/icn_pen.gif" border="0" align="absBottom" width="24" height="16"></a> 
                                                        </td>
                                                        <td align="left" class="tdLabel"><asp:Label ID="lbTitleRemark" runat="server" CssClass="label" Text="Ghi chú"></asp:Label></td>
                                                        <td align="left" class="tdValue"><asp:TextBox ID="txtRemark" runat="server" CssClass="textBox" Width="200px" ></asp:TextBox></td>
                                                        <td align="left" class="tdLabel"><asp:Label ID="lbRank" runat="server" CssClass="label" Text="Xếp loại"></asp:Label> </td>
                                                        <td align="left" class="tdValue"><asp:Label ID="lnkRank" runat="server" CssClass="labelHTCV" ></asp:Label></td>
                                                    </tr>                                               
                                                    <tr>
                                                        <td class="tdLabel"><asp:Label ID="Label15" runat="server" CssClass="label" Text="Theo"></asp:Label></td>
                                                        <td class="tdValue"><asp:DropDownList ID="ddlType" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlType_SelectedIndexChanged"></asp:DropDownList></td>
                                                        <td class="tdLabel" align="left">
                                                            <asp:Label ID="lbLeaveType" runat="server" CssClass="label" Text="Loại"></asp:Label></td>
                                                        <td class="tdValue" align="left" colspan="3">
                                                            <asp:DropDownList ID="ddlLeaveTypes" runat="server" CssClass="dropDownList"></asp:DropDownList>
                                                            <asp:DropDownList ID="ddl4gio" runat="server" CssClass="dropDownList">
                                                            </asp:DropDownList>
                                                            </td>
                                                        <td align="left" class="tdLabel"><asp:Label ID="Label16" runat="server" CssClass="label" Text="Giờ đêm" Visible="true"></asp:Label><asp:Label ID="lbFromDate" runat="server" CssClass="label" Text="Từ ngày" Visible="false"></asp:Label><br/><asp:Label ID="lbToDate" runat="server" CssClass="label" Text="Đến ngày" Visible="false"></asp:Label></td>
                                                        <td align="left" class="tdValue"><uc2:CalendarPicker id="cpFromDate" runat="server"></uc2:CalendarPicker><uc2:CalendarPicker id="cpToDate" runat="server"></uc2:CalendarPicker><asp:CheckBox ID="chkGioDem" runat="server" AutoPostBack="True" OnCheckedChanged="chkGioDem_CheckedChanged" /><asp:ImageButton id="imgApplyTimeKeeping" onclick="imgApplyTimeKeeping_Click" runat="server" ImageUrl="~/Images/icn_pen.gif"></asp:ImageButton></td>
                                                        
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>                                                                                                                               
                                         <tr class="tdLabel">
                                            <td>                                                                                                                                                             
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
                                                                <tr><td align="right"><asp:TextBox ID="txtNight12" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight12" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb13" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk13" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight13" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight13" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb14" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk14" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight14" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight14" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>   
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb15" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk15" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight15" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight15" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>                  
                                                         </td>
                                                        <td align="center" class="tdLabel">
                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb16" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk16" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight16" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight16" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>                        
                                                         </td>
                                                        <td align="center" class="tdValue">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb17" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk17" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight17" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight17" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>                   
                                                         </td>
                                                        <td align="center" class="tdValue">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left" valign="top"><asp:Label ID="lb18" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk18" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight18" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight18" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb22" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk22" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight22" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight22" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb23" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk23" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight23" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight23" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb24" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk24" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight24" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight24" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb25" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk25" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight25" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight25" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb26" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk26" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight26" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight26" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdValue">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb27" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk27" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight27" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight27" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdValue">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb28" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk28" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight28" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight28" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                       </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb32" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk32" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight32" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight32" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb33" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk33" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight33" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight33" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                       </td>
                                                        <td align="center" class="tdLabel">
                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb34" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk34" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight34" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight34" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb35" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk35" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight35" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight35" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb36" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk36" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight36" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight36" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdValue">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb37" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk37" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight37" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight37" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                       </td>
                                                        <td align="center" class="tdValue">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb38" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk38" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight38" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight38" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="center" class="tdLabel">
                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb42" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk42" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight42" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight42" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb43" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk43" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight43" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight43" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb44" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk44" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight44" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight44" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb45" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk45" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight45" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight45" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb46" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk46" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight46" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight46" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdValue">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb47" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk47" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight47" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight47" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>                                                                                
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdValue">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb48" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk48" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight48" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight48" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="center" class="tdLabel">
                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb52" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk52" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight52" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight52" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                       </td>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb53" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk53" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight53" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight53" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb54" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk54" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight54" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight54" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb55" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk55" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight55" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight55" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb56" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk56" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight56" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight56" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdValue">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb57" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk57" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight57" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight57" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdValue">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb58" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk58" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight58" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight58" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="center" class="tdLabel">
                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb62" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk62" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight62" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight62" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                       </td>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb63" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk63" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight63" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight63" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb64" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk64" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight64" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight64" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb65" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"> <asp:LinkButton ID="lnk65" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight65" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight65" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdLabel">
                                                             <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb66" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk66" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight66" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight66" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                        </td>
                                                        <td align="center" class="tdValue">
                                                            <table cellpadding="0" cellspacing="0" style="width:100%"> 
                                                                <tr><td align="left"><asp:Label ID="lb67" runat="server" CssClass="label-Day"></asp:Label></td></tr>
                                                                <tr><td align="center"><asp:LinkButton ID="lnk67" runat="server"  CssClass="hyperlink-TimeKeeping" OnClick="lnkTimeKeeping_Click"></asp:LinkButton></td></tr>
                                                                <tr><td align="right"><asp:TextBox ID="txtNight67" runat="server" CssClass="textBox-Calendar" Width="25px"></asp:TextBox><asp:Label ID="lbNight67" runat="server" CssClass="value-Calendar"></asp:Label></td></tr>
                                                            </table>
                                                         </td>
                                                        <td align="center" class="tdValue">
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
                                            <td align="center" class="tdButton">
                                                <table>
                                                    <tr>
                                                        <td><asp:ImageButton ID="btnSave" runat="server" OnClick="btnSave_Click" ImageUrl="~/Images/save.gif"/></td>
                                                        <td><asp:LinkButton ID="lnkSave" runat="server" OnClick="btnSave_Click" CssClass="hyperlink-Button">Lưu</asp:LinkButton></td>
                                                        <td>
                                                            &nbsp; &nbsp;
                                                            <asp:ImageButton ID="btnCancel" runat="server" OnClick="btnCancel_Click" ImageUrl="~/Images/back.gif"/></td>
                                                        <td><asp:LinkButton ID="lnkCancel" runat="server" OnClick="btnCancel_Click" CssClass="hyperlink-Button">Thoát</asp:LinkButton></td>
                                                    </tr>
                                                </table>                                                                                                                                                                  
                                            </td>
                                        </tr>                                                                             
                                </table>
                            </td>
                        </tr>
                    </table>
                <uc3:ucPermission ID="UcPermission1" runat="server" />
            </fieldset>
              </ContentTemplate>
           </asp:UpdatePanel>   
        </td>
    </tr>
</table>
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>
<script type="text/javascript" src="../JScripts/script.js"></script>
</asp:Content>

