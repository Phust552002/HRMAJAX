<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Reward.ascx.cs" Inherits="Employee_UserControls_Working_Reward" %>
<%@ Register Src="../../../UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc1" %>
<uc1:MessageError ID="MessageError1" runat="server" />
<table style="width: 100%" class="tableBorder">
 <tr>
    <td>
        <asp:DataList ID="dlReward" runat="server" Width="100%" OnItemDataBound="dlDataListInsert_ItemDataBound">
            <HeaderTemplate>
                <table style="width: 100%" cellpadding="0" cellspacing="0">
                    <tr class="dataList-header">
                        <td style="width:8%" align="left">Từ năm</td>                                                                        
                        <td style="width:8%" align="left">Đến năm</td>
                        <td style="width:64%" align="left">Khen thưởng</td>                                                                                                                        
                        <td style="width:10%" align="center">Xóa dòng</td>
                        <td style="width:10%" align="center">Thêm dòng mới</td>
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemTemplate>
                <table style="width: 100%" cellpadding="0" cellspacing="0">
                    <tr>
                        <td style="width:8%;" align="left" valign="top">
                            <asp:TextBox ID="txtFromYear" runat="server" CssClass="textBox" Width="90%" MaxLength="4"></asp:TextBox></td>                                                                        
                        <td style="width:8%;" align="left" valign="top">
                            <asp:TextBox ID="txtToYear" runat="server" CssClass="textBox" Width="90%" MaxLength="4"></asp:TextBox></td>
                        <td style="width:64%;" align="left" valign="top">
                             <asp:TextBox ID="txtInfor" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                                                                                                                                                                                    
                        <td style="width:10%;" align="center" valign="middle">
                            <asp:ImageButton ID="imgDeleteRow" runat="server"  ImageUrl="~/Images/icon-delete.gif" OnClick="imgDeleteRow_Click" /></td>
                        <td style="width:10%;" align="center" valign="middle">
                            <asp:ImageButton ID="imgAddNewRow" runat="server"  ImageUrl="~/Images/Add.gif" OnClick="imgAddNewRow_Click" Visible="false"/></td>  
                    </tr>
                   
                </table>
            </ItemTemplate>
            <ItemStyle CssClass="dataList-item" />
            <AlternatingItemStyle CssClass="dataList-atlternating-item" />
        </asp:DataList>
    </td>
 </tr>
<tr>
    <td class="tdButton" align="center">
        <asp:Button ID="btnSave" runat="server" Text="Lưu" CssClass="small color green button" Width="100px" OnClick="btnSave_Click" />
    </td>
</tr>   
</table>