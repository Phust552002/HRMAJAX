<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PMemberInfo.ascx.cs" Inherits="PMember_UserControls_PMemberInfo" %>
<%@ Register Src="~/UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/ucMessageError.ascx" TagName="ucMessageError" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/TabSub.ascx" TagName="TabSub" TagPrefix="uc3" %>
<%@ Register Src="~/Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc4" %>
<%@ Register Src="ucDocumentList.ascx" TagName="ucDocumentList" TagPrefix="uc5" %>

<table style="width: 100%;" class="tableBorder" cellpadding="2" cellspacing="0">
    <tr>
        <td valign="top" style="width:150px">
            <asp:Image ID="ImgUser" runat="server" Width="150px" />
        </td>
        <td valign="top">
            <table style="width: 100%" class="tableBorder">
                <tr>
                    <td class="tdLabel" colspan="2">
                        <uc1:ucMessageError ID="UcMessageError1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label2" runat="server" Text="Họ và tên" CssClass="label"></asp:Label></td>
                    <td class="tdValue">
                        <asp:Label ID="lbFullName" runat="server" CssClass="value"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label3" runat="server" Text="Trạng thái" CssClass="label"></asp:Label></td>
                    <td class="tdValue">
                        <asp:DropDownList ID="ddlPMemberStatus" runat="server" CssClass="dropDownList">
                            <asp:ListItem Value="0">Xem xét</asp:ListItem>
                            <asp:ListItem Value="1">Dự bị</asp:ListItem>
                            <asp:ListItem Value="2">Chính thức</asp:ListItem>
                            <asp:ListItem Value="-1">Chuyển sinh hoạt</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Ngày vào Đảng"></asp:Label></td>
                    <td class="tdValue">
                        <uc2:calendarpicker id="cpDateJoinP" runat="server"></uc2:calendarpicker>
                    </td>
                </tr>
                
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label12" runat="server" Text="Ngày vào Đảng chính thức" CssClass="label"></asp:Label></td>
                    <td class="tdValue">
                        <uc2:calendarpicker id="cpDateJoinPOfficial" runat="server"></uc2:calendarpicker>
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label6" runat="server" CssClass="label" Text="Nơi vào Đảng"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtPlaceJoinP" runat="server" TextMode="MultiLine" Rows="2" Width="100%" CssClass="textBox"></asp:TextBox></td>
                </tr>
                
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label10" runat="server" CssClass="label" Text="Số thẻ Đảng viên"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtPCardNo" runat="server" CssClass="textBox" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Ghi chú"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtRemarks" runat="server" TextMode="MultiLine" Rows="2" Width="100%" CssClass="textBox"></asp:TextBox></td>
                </tr>
                <tr>
                <td colspan="2" class="tdButton">
                    <table style="width: 100%" >
                        <tr>
                            <td align="center">
                                 <asp:Button ID="btnAdd" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click" CssClass="small color green button" Width="100px" /></td>
                        </tr>
                    </table>
                    <uc4:ucPermission ID="UcPermission1" runat="server" />
                </td>
            </tr>
                
            </table>
        </td>
    </tr>
    <tr>
        <td valign="top" colspan="2">
            <uc3:TabSub ID="Tabs1" runat="server" />
        </td>
    </tr>  
    <tr>
        <td colspan="2">
            <table width="100%" class="borderMultiView" cellpadding="0" cellspacing="1">
                <tr>
                    <td>                                        
                        <table width="100%" style="background-color:#ffffff">
                            <tr>
                                <td>
                                    <asp:MultiView ID="MultiTabs" runat="server">
                                        <asp:View ID="Tab0" runat="server">
                                            <table style="width: 100%">
                                                <tr>
                                                    <td>                                                                        
                                                        <uc5:ucDocumentList ID="DocumentList0" runat="server" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:View>
                                        <asp:View ID="Tab1" runat="server">
                                            <table style="width: 100%">
                                                <tr>
                                                    <td>
                                                        <uc5:ucDocumentList ID="DocumentList1" runat="server" />
                                                                        
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:View>
                                        <asp:View ID="Tab2" runat="server">
                                            <table style="width: 100%">
                                                <tr>
                                                    <td>                                                                        
                                                        <uc5:ucDocumentList ID="DocumentList2" runat="server" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:View>
                                        <asp:View ID="Tab3" runat="server">
                                            <table style="width: 100%">
                                                <tr>
                                                    <td>                                                                        
                                                        <uc5:ucDocumentList ID="DocumentList3" runat="server" />                                                                      
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:View>
                                        
                                    </asp:MultiView>
                                    </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                                    
            </table> 
        </td>
    </tr>
</table>
