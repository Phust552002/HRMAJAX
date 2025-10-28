<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Present.aspx.cs" Inherits="TimeWorks_Present" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

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
                                            <asp:Label id="Label1" runat="server" CssClass="label" Text="Tên nhân viên"></asp:Label> <asp:TextBox id="txtFullName" runat="server" CssClass="textBox"></asp:TextBox> &nbsp; &nbsp;<asp:Label id="Label2" runat="server" CssClass="label" Text="Phòng Ban "></asp:Label> 
                                            <asp:DropDownList id="ddlDepartment" runat="server" CssClass="dropDownList"> </asp:DropDownList> 
                                            <asp:Label ID="Label4" runat="server" CssClass="label" Text="Ngày"></asp:Label>
                                            &nbsp;&nbsp;<uc5:CalendarPicker ID="CalendarPicker1" runat="server" />
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
                                <asp:GridView ID="grdPresent" runat="server" AutoGenerateColumns="False"
                                    Width="100%" CssClass="grid-Border" OnRowDataBound="grdPresent_RowDataBound">
                                    <FooterStyle CssClass="grid-footer" />
                                    <Columns>
                                        <asp:TemplateField SortExpression="FileCode">
                                            
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                    <tr>
                                                        <td align="left">
                                                            <asp:Label ID="lbDepartment" runat="server" CssClass="value-bold"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right">
                                                        
                                                <asp:GridView ID="grdEmployeeTimeBillDetailToday" Width="100%" CssClass="grid-Border" runat="server" AutoGenerateColumns="False" OnRowDataBound="grdEmployeeTimeBillDetailToday_RowDataBound">
                                                    <Columns>
                                                        <asp:TemplateField HeaderText="Mã NV">
                                                        <ItemStyle HorizontalAlign="Center" Width="5%" />
                                                            <HeaderStyle HorizontalAlign="Center" Height="25px"/>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbUserId" runat="server"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Họ t&#234;n">
                                                        <ItemStyle HorizontalAlign="Left" Width="10%" />
                                                            <HeaderStyle HorizontalAlign="Center" Height="25px"/>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbFullName" runat="server"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Giờ v&#224;o">
                                                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                                                            <HeaderStyle HorizontalAlign="Center" Height="25px"/>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbTimeIn" runat="server"></asp:Label>
                                                            </ItemTemplate>
                                                            <HeaderTemplate>
                                                                <table cellpadding="0" cellspacing="0">
                                                                    <tr>
                                                                        <td>
                                                                            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/arrowin.gif" />
                                                                        </td>
                                                                        <td>
                                                                            Giờ vào
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </HeaderTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Giờ ra">
                                                            <HeaderTemplate>
                                                                <table cellpadding="0" cellspacing="0">
                                                                    <tr>
                                                                        <td>
                                                                            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/arrowout.gif" />
                                                                        </td>
                                                                        <td>
                                                                            Giờ ra
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </HeaderTemplate>
                                                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbTimeOut" runat="server"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Tổng thời gian (giờ)">
                                                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbTotalTime" runat="server"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Tổng thời gian thực tế (giờ)">
                                                             <ItemStyle HorizontalAlign="Center" Width="10%" />
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbTotalRealTime" runat="server"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                    </Columns>
                                                    <HeaderStyle CssClass="grid-detail-header" />
                                                    <RowStyle CssClass="grid-detail-item" />
                                                    <AlternatingRowStyle CssClass="grid-detail-atlternating-item" />
                                                </asp:GridView>
                                                              
                                                        </td>
                                                    </tr>
                                                </table>
                                              
                                            </ItemTemplate>
                                            <FooterStyle HorizontalAlign="Right" />
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
           </table>
        </td>
    </tr>
    <tr>
        <td valign="top" style="height:350px">                            
        </td>
    </tr>
</table>
</asp:Content>

