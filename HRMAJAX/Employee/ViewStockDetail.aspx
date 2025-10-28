<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ViewStockDetail.aspx.cs" Inherits="Employee_ViewStockDetail" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"TagPrefix="uc1" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>
<%@ Register src="../UserControls/CalendarPicker.ascx" tagname="CalendarPicker" tagprefix="uc3" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
    <tr>
        <td valign="top" >
            <table style="width: 100%">
                <tr>
                    <td valign="top" >
                        <uc2:ucTitle ID="UcTitle1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td valign="top" >
                        <table style="width: 99%;margin-top:2px; margin-left:2px; margin-right:2px;" class="tableBorder">
                                    <tr>
                                        <td class="tdLabel" style="width:30%">
                                            <asp:Label ID="Label3" runat="server" CssClass="label" Text="Mã số nhà đầu tư"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbInvestorNo" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label11" runat="server" CssClass="label" Text="Tên cá nhân"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:Label ID="lbFullName" runat="server" CssClass="value"></asp:Label></td>        
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label4" runat="server" CssClass="label" Text="Điện thoại"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:TextBox ID="txtHandPhone" runat="server" CssClass="textBox" Width="150px" 
                                                ReadOnly="True"></asp:TextBox>
                                        </td>
                                    </tr>
                                    
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label1" runat="server" CssClass="label" Text="Số CMND"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:TextBox ID="txtIDCard" runat="server" CssClass="textBox" Width="150px" 
                                                ReadOnly="True"></asp:TextBox>
                                         </td>
                                    </tr>
                                    <tr>
                                         <td class="tdLabel">
                                            <asp:Label ID="Label2" runat="server" CssClass="label" Text="Cấp ngày"></asp:Label></td>
                                        <td class="tdValue">                                            
                                            <uc3:CalendarPicker ID="cpDateOfIssue" runat="server" Enabled="False" />                                            
                                        </td>                                        
                                    </tr>
                                    <tr>
                                         <td class="tdLabel">
                                            <asp:Label ID="Label5" runat="server" CssClass="label" Text="Cấp tại"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:TextBox ID="txtPlaceOfIssue" runat="server" CssClass="textBox"
                                                Width="98%" ReadOnly="True"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                         <td class="tdLabel">
                                            <asp:Label ID="Label18" runat="server" CssClass="label" Text="Địa chỉ liên lạc"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:TextBox ID="txtLive" runat="server" CssClass="textBox"
                                                Width="98%" ReadOnly="True"></asp:TextBox></td>
                                    </tr>
                                   
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label7" runat="server" CssClass="label" Text="Khối lượng cổ phần đăng ký mua theo thăm niên"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:TextBox ID="txtSeniorStockBought" runat="server" CssClass="textBoxNumber" 
                                                Width="50px" ReadOnly="True"></asp:TextBox><asp:Label ID="Label6" runat="server" CssClass="label" Text=" x "></asp:Label><asp:TextBox ID="TextBox3" runat="server" CssClass="textBoxNumber" Width="50px"  ReadOnly="true" Text="8,400"></asp:TextBox><asp:Label ID="Label14" runat="server" CssClass="label" Text=" = "></asp:Label><asp:TextBox ID="txtSeniorStockBoughtMoney" runat="server" CssClass="textBoxNumber" Width="100px"  ReadOnly="true"></asp:TextBox></td>
                                     
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label13" runat="server" CssClass="label" Text="Khối lượng cổ phần đăng ký mua theo cam kết"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:TextBox ID="txtUnderTakingStockBought" runat="server" 
                                                CssClass="textBoxNumber" Rows="3" Width="50px" ReadOnly="True"></asp:TextBox><asp:Label ID="Label8" runat="server" CssClass="label" Text=" x "></asp:Label><asp:TextBox ID="TextBox4" runat="server" CssClass="textBoxNumber" Width="50px"  ReadOnly="true" Text="14,000"></asp:TextBox><asp:Label ID="Label15" runat="server" CssClass="label" Text=" = "></asp:Label><asp:TextBox ID="txtUnderTakingStockBoughtMoney" runat="server" CssClass="textBoxNumber" Width="100px"  ReadOnly="true"></asp:TextBox></td>
                                               
                                    </tr>                                   
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label9" runat="server" CssClass="label" Text="Tổng Cộng"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:TextBox ID="txtTotalStock" runat="server" CssClass="textBoxNumber" Rows="3" Width="50px" ReadOnly="true"></asp:TextBox><asp:Label ID="Label12" runat="server" CssClass="label" Text=" --------------- "></asp:Label><asp:TextBox ID="txtTotalStockMoney" runat="server" CssClass="textBoxNumber" Width="100px"  ReadOnly="true"></asp:TextBox></td>
                                               
                                    </tr>     
                                     <tr>
                                         <td class="tdLabel">
                                            <asp:Label ID="Label16" runat="server" CssClass="label" Text="Ngày nộp các chứng từ thanh toán ngân hàng"></asp:Label></td>
                                        <td class="tdValue">                                            
                                            <uc3:CalendarPicker ID="cpStockDateOfPayment" runat="server" Enabled="False" />                                            
                                        </td>                                        
                                    </tr>
                                   
                                    <tr>
                                        <td class="tdLabel">
                                            <asp:Label ID="Label10" runat="server" CssClass="label" Text="Ghi chú"></asp:Label></td>
                                        <td class="tdValue">
                                            <asp:TextBox ID="txtStockRemark" runat="server" Width="98%" CssClass="textBox" 
                                                TextMode="MultiLine" Rows="3" ReadOnly="True"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                         <td class="tdLabel">
                                            <asp:Label ID="Label17" runat="server" CssClass="label" Text="Xác nhận đã nộp giấy tờ đầy đủ"></asp:Label></td>
                                        <td class="tdValue">                                            
                                            <asp:CheckBox ID="chkCash" runat="server" CssClass="value" 
                                                Text="Nộp tiền mặt" TextAlign="Left" Enabled="False" />
                                        &nbsp;&nbsp;                                            
                                            <asp:CheckBox ID="chkBanking" runat="server" CssClass="value" 
                                                Text="Chứng từ thanh toán ngân hàng" TextAlign="Left" Enabled="False" />
                                        </td>                                        
                                    </tr>
                                </table>                                                                   
                    </td>
                </tr>
                                  
                <uc1:ucPermission ID="ucPermission1" runat="server" />
                                  
            </table>
        </td>
    </tr>
</table>
</asp:Content>

