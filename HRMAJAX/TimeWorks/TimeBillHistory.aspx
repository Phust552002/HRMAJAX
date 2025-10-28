<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="TimeBillHistory.aspx.cs" Inherits="TimeWorks_TimeBillHistory" %>
<%@ Register Src="../UserControls/DatePicker.ascx" TagName="DatePicker" TagPrefix="uc4" %>
<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc5" %>
<%@ Register Src="../UserControls/ucDateFilter.ascx" TagName="ucDateFilter" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/Title.ascx" TagName="Title" TagPrefix="uc1" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>
<%@ Register Src="~/Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; height:500px" cellpadding="5" cellspacing="0" class="tableBackground">
    <tr>
        <td valign="top" style="height:45px">
             <table width="100%" class="tableBgBoxShare">
                <tr>
                    <td align="left">
                        <uc2:ucTitle ID="UcTitle1" runat="server" />
                    </td>
                </tr>
             </table>           
        </td>
    </tr>
    <tr>
        <td valign="top" style="height:95px">
           <table width="100%" class="tableBgBoxShare">
            <tr>                       
                <td valign="top" align="center">
                    <table style="width: 100%" cellpadding="0" cellspacing="0">                                
                        <tr>
                            <td align="center" colspan="4" style="height: 5px">
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="4">
                                <table cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td valign="middle">
                                            <asp:Label id="Label1" runat="server" CssClass="label" Text="Tên nhân viên: "></asp:Label> <asp:Label id="lbFullName" runat="server" CssClass="label" Font-Bold="true"></asp:Label> &nbsp; &nbsp;<asp:Label id="Label2" runat="server" CssClass="label" Text="Mã NV: "></asp:Label> 
                                            <asp:Label id="lbUserId" runat="server" CssClass="label" Font-Bold="true"></asp:Label> 
                                             &nbsp; &nbsp;
                                            <asp:Label ID="Label4" runat="server" CssClass="label" Text="Ngày: "></asp:Label> <uc5:CalendarPicker ID="CalendarPicker1" runat="server" />
                                            &nbsp; &nbsp;
                                        </td>
                                        <td valign="top">
                                            <table>
                                                <tr>
                                                    <td>
                                                        &nbsp;&nbsp;
                                                        <asp:Button ID="imgSearch" runat="server" Text="Xem" CssClass="small color green button"
                                                            OnClick="btnView_Click" />
                                                        &nbsp; &nbsp;</td>
                                                    <td>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                                </td>
                        </tr>
                        <tr>
                            <td align="right" style="height:5px">
                            </td>
                            <td align="left">
                            </td>
                            <td align="right">
                            </td>
                            <td align="left">
                            </td>
                        </tr>
                        
                        <tr>
                            <td align="right" style="height:5px">
                            </td>
                            <td align="left">
                            </td>
                            <td align="right">
                            </td>
                            <td align="left">
                            </td>
                        </tr>                                                                                
                        <tr>
                            <td align="center" colspan="4" style="height: 5px">
                                 <table width="99%" class="tableBorder" style="background-color:White">
                                    <tr>
                                        <td>
                                <asp:GridView ID="grdHistory" runat="server" AutoGenerateColumns="False"
                                    Width="100%" CssClass="grid-Border" >
                                    <FooterStyle CssClass="grid-footer" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="STT">
                                        <ItemStyle HorizontalAlign="Center" Width="10%" />
                                            <HeaderStyle HorizontalAlign="Center" Height="25px"/>
                                            <ItemTemplate>
                                                <asp:Label ID="lbSTT" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Ngày giờ">
                                        <ItemStyle HorizontalAlign="Left" Width="30%" />
                                            <HeaderStyle HorizontalAlign="Left" Height="25px"/>
                                            <ItemTemplate>
                                                <asp:Label ID="lbInputTime" runat="server" Text='<%# Convert.ToDateTime(Eval("InputTime")).ToString("dd/MM/yyyy HH:mm:ss") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Máy chấm công">
                                            <ItemStyle HorizontalAlign="Left" Width="30%" />
                                            <HeaderStyle HorizontalAlign="Left" Height="25px"/>
                                            <ItemTemplate>
                                                <asp:Label ID="lbMachineName" runat="server" Text='<%# Eval("MachineName") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Trạng thái">
                                            <ItemStyle HorizontalAlign="Left" Width="30%" />
                                            <HeaderStyle HorizontalAlign="Left" Height="25px"/>
                                            <ItemTemplate>
                                                <asp:Label ID="lbStatus" runat="server" Text='<%# Eval("AttendanceStatus") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <RowStyle CssClass ="grid-item" />
                                    <PagerStyle CssClass="grid-paper" />
                                    <HeaderStyle CssClass="grid-header" />
                                    <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                </asp:GridView>
                                            <uc6:ucPermission ID="UcPermission1" runat="server" />
                                        </td>
                                    </tr>
                                 </table>   
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="height: 5px">
                            </td>
                            <td align="left">
                            </td>
                            <td align="right">
                            </td>
                            <td align="left">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="center"><asp:Button ID="btnCancel" runat="server" CssClass="small color green button" OnClick="btnCancel_Click"
                                            Text="Thoát" Width="100px" /></td>
            </tr>
           </table>
        </td>
    </tr>
    <tr>
        <td valign="top" style="height:350px">                            
        </td>
    </tr>
</table>
</asp:Content>

