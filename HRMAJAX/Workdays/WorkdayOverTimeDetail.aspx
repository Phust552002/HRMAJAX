<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="WorkdayOverTimeDetail.aspx.cs" Inherits="Workdays_WorkdayOverTimeDetail" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table style="width: 100%">
    <tr>
        <td>
                <uc1:ucTitle ID="UcTitle1" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            <table style="width: 100%" class="tableBorder">
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label1" runat="server" Text="Họ và tên" CssClass="label"></asp:Label></td>
                    <td class="tdValue" >
                        <asp:Label ID="lbFullName" runat="server" CssClass="value"></asp:Label></td>
                    <td class="tdLabel">
                        <asp:Label ID="Label4" runat="server" Text="Phòng ban" CssClass="label"></asp:Label></td>
                    <td class="tdValue"> 
                        <asp:Label ID="lbDepartment" runat="server" CssClass="value"></asp:Label></td>
                </tr>                                                 
            </table>
        </td>
    </tr>                               
    <tr>
        <td>
            <table style="width: 100%" class="tableBorder" cellpadding="0" cellspacing="0">
                <tr>
                    <td>
                        <asp:DataList ID="dlWorkdayOverTime" runat="server" Width="100%" OnItemDataBound="dlWorkdayOverTime_ItemDataBound">
                            <HeaderTemplate>
                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                    <tr class="dataList-atlternating-item">
                                        <td style="width:20%" align="left">Loại giờ công làm thêm</td>
                                        <td style="width:10%" align="left">Ngày</td>
                                        <td style="width:10%" align="left">Số giờ làm thêm</td>
                                        <td style="width:50%" align="left">Giải trình</td>
                                        <td style="width:5%" align="center">Xóa</td>
                                        <td style="width:5%" align="center">Thêm</td>
                                    </tr>                                                                                   
                                </table>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td style="width:20%;" align="left" valign="top">                                            
                                            <asp:DropDownList ID="ddlOverTimeType" runat="server" CssClass="dropDownList" DataSourceID="ObjectDataSource2"
                                                DataTextField="OverTimeTypeName" DataValueField="OverTimeType"  AppendDataBoundItems="true">
                                                <asp:ListItem Text="" Value="0"></asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}"
                                                SelectMethod="GetAll" TypeName="HRMBLL.H1.OverTimeTypeBLL"></asp:ObjectDataSource>
                                        </td>                                                                                                                                                                                       
                                        <td style="width:10%;" align="left" valign="top">
                                            <uc2:CalendarPicker ID="cpOverTimeDate" runat="server" /></td>
                                        <td style="width:10%;" align="left" valign="top">
                                            <asp:TextBox ID="txtOverTimeHours" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>
                                        <td style="width:50%;" align="left" valign="top">
                                            <asp:TextBox ID="txtOverTimeRemark" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>

                                        <td style="width:5%;" align="center" valign="middle">
                                            <asp:ImageButton ID="imgDeleteRow" runat="server"  ImageUrl="~/Images/icon-delete.gif" OnClick="imgDeleteRowdlWorkdayOverTime_Click" /></td>
                                        <td style="width:5%;" align="center" valign="middle">
                                            <asp:ImageButton ID="imgAddNewRow" runat="server"  ImageUrl="~/Images/Add.gif" OnClick="imgAddNewRowdlWorkdayOverTime_Click" Visible="false"/></td>  
                                    </tr>
                                                                                       
                                </table>
                            </ItemTemplate>
                            <ItemStyle CssClass="dataList-item" />
                            <AlternatingItemStyle CssClass="dataList-atlternating-item" />
                        </asp:DataList>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="center" class="tdButton">
            &nbsp;<asp:Button ID="btnOk" runat="server" Text="Lưu" CssClass="small color green button" Width="100px" OnClick="btnOk_Click" />&nbsp;
                  <asp:Button ID="btnCancel" runat="server" CssClass="small color green button" Text="Thoát" Width="100px" OnClick="btnCancel_Click" />
            <uc3:ucPermission ID="UcPermission1" runat="server" />
        </td>
    </tr>
</table>
</asp:Content>

