<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="DetailLCBCoefficient.aspx.cs" Inherits="Coefficients_LCBCoefficientDetail" Title="SAGS :: Quản Lý Nhân Sự - Tiền Lương" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="../UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" >
<tr>
    <td colspan="2">
        <uc1:ucTitle ID="UcTitle1" runat="server" />
    </td>
</tr>
<tr>
    <td valign="top">
     <table style="width: 100%" class="tableBorder">
        <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label28" runat="server" CssClass="label" Text="Theo bảng quy chế"></asp:Label></td>
                <td class="tdValue">
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropDownList" >
                    </asp:DropDownList></td>
            </tr>
        <tr>
            <td class="tdLabel">
                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Mã ngạch"></asp:Label></td>
            <td class="tdValue"> 
                <asp:TextBox ID="txtCoefficientName" runat="server" CssClass="textBox" Width="250px"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="tdLabel">
                <asp:Label ID="Label27" runat="server" CssClass="label" Text="Các bậc hệ số lương cơ bản"></asp:Label></td>
            <td class="tdValue">
                <table style="width: 80%" cellpadding="0" cellspacing="0">
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" CssClass="value" Text="Bậc 1"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtValueLevel_1" runat="server" Width="50px" CssClass="textBox"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label15" runat="server" CssClass="value" Text="Thời gian nâng bậc 1"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtConditions1" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label3" runat="server" CssClass="value" Text="Bậc 2"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtValueLevel_2" runat="server" Width="50px" CssClass="textBox"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label16" runat="server" CssClass="value" Text="Thời gian nâng bậc 2"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtConditions2" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" CssClass="value" Text="Bậc 3"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtValueLevel_3" runat="server" Width="50px" CssClass="textBox"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label17" runat="server" CssClass="value" Text="Thời gian nâng bậc 3"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtConditions3" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label5" runat="server" CssClass="value" Text="Bậc 4"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtValueLevel_4" runat="server" Width="50px" CssClass="textBox"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label18" runat="server" CssClass="value" Text="Thời gian nâng bậc 4"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtConditions4" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" CssClass="value" Text="Bậc 5"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtValueLevel_5" runat="server" Width="50px" CssClass="textBox"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label19" runat="server" CssClass="value" Text="Thời gian nâng bậc 5"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtConditions5" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label7" runat="server" CssClass="value" Text="Bậc 6"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtValueLevel_6" runat="server" Width="50px" CssClass="textBox"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label20" runat="server" CssClass="value" Text="Thời gian nâng bậc 6"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtConditions6" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" CssClass="value" Text="Bậc 7"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtValueLevel_7" runat="server" Width="50px" CssClass="textBox"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label21" runat="server" CssClass="value" Text="Thời gian nâng bậc 7"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtConditions7" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label9" runat="server" CssClass="value" Text="Bậc 8"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtValueLevel_8" runat="server" Width="50px" CssClass="textBox"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label22" runat="server" CssClass="value" Text="Thời gian nâng bậc 8"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtConditions8" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                       </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label10" runat="server" CssClass="value" Text="Bậc 9"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtValueLevel_9" runat="server" Width="50px" CssClass="textBox"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label23" runat="server" CssClass="value" Text="Thời gian nâng bậc 9"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtConditions9" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label11" runat="server" CssClass="value" Text="Bậc 10"></asp:Label>
                            <asp:TextBox ID="txtValueLevel_10" runat="server" Width="50px" CssClass="textBox"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label24" runat="server" CssClass="value" Text="Thời gian nâng bậc 10"></asp:Label>
                            <asp:TextBox ID="txtConditions10" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                         </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label12" runat="server" CssClass="value" Text="Bậc 11"></asp:Label>
                            <asp:TextBox ID="txtValueLevel_11" runat="server" Width="50px" CssClass="textBox"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label25" runat="server" CssClass="value" Text="Thời gian nâng bậc 11"></asp:Label>
                            <asp:TextBox ID="txtConditions11" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label13" runat="server" CssClass="value" Text="Bậc 12"></asp:Label>
                            <asp:TextBox ID="txtValueLevel_12" runat="server" Width="50px" CssClass="textBox"></asp:TextBox>
                            &nbsp;
                            <asp:Label ID="Label26" runat="server" CssClass="value" Text="Thời gian nâng bậc 12"></asp:Label>
                            <asp:TextBox ID="txtConditions12" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="tdLabel">
                <asp:Label ID="Label14" runat="server" CssClass="label" Text="Mô tả"></asp:Label></td>
            <td class="tdValue">
                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" CssClass="textBox" Rows="3" Width="300px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" class="tdButton" align="center">
                 <asp:Button ID="btnAdd" runat="server" Text="Lưu" OnClick="btnAdd_Click" CssClass="small color green button" Width="100px" />
                &nbsp;
                 <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="small color green button" Width="100px" />
                &nbsp;
                 <asp:Button ID="btnCancel" runat="server" Text="Thoát" CssClass="small color green button" OnClick="btnCancel_Click" Width="100px" />
            </td>
            
        </tr>
    </table>
</td>
</tr>
</table>
</asp:Content>

