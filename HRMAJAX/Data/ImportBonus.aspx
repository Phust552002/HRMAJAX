<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ImportBonus.aspx.cs" Inherits="Data_ImportBonus" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucMessageError.ascx" TagName="ucMessageError" TagPrefix="uc3" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/HeaderContent.ascx" TagName="HeaderContent" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" class="bgEachPage">    
    <tr>
        <td align="center" valign="top">
            <table width="100%" >
                <tr>
                    <td>
                        <uc2:ucTitle ID="UcTitle1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <uc3:ucMessageError ID="UcMessageError1" runat="server" />
                    </td>
                </tr>
               
                <tr>
                    <td align="center" valign="middle">
                        <table width="40%" class="tableBorder">
                            <tr>
                                <td align="left" class="tdLabel">
                                    <asp:Label ID="Label5" runat="server" Text="Loại dữ liệu" CssClass="label"></asp:Label></td>
                                <td align="left" class="tdValue">
                                    <asp:DropDownList ID="ddlDataType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDataType_SelectedIndexChanged" DataSourceID="ObjectDataSource1" DataTextField="BonusName" DataValueField="BonusNameId" AppendDataBoundItems="true" CssClass="dropDownList">
                                    <asp:ListItem Text="" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="Thưởng ATHK" Value="-7"></asp:ListItem>
                                    <asp:ListItem Text="Thuế TNCN Khấu Trừ Trả Lại" Value="-6"></asp:ListItem>
                                    <asp:ListItem Text="Bảng chênh lệch lương thưởng ATHK" Value="-5"></asp:ListItem>
                                    <asp:ListItem Text="Tiền Bổ Sung Lương Giữa Năm" Value="-4"></asp:ListItem>
                                    <asp:ListItem Text="Tiền Thưởng Cuối Năm Bổ Sung Điều Tiết" Value="-3"></asp:ListItem>
                                    <asp:ListItem Text="Tiền Thưởng Cuối Năm Tết &#194;m Lịch Thời Vụ" Value="-2"></asp:ListItem>
                                    <asp:ListItem Text="Tiền Thưởng Bổ Sung Lương & ATHK Cuối Năm" Value="-1"></asp:ListItem>                                    
                                    </asp:DropDownList>
                                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetByType"
                                        TypeName="HRMBLL.H.BonusNamesBLL">
                                        <SelectParameters>
                                            <asp:Parameter DefaultValue="1" Name="type" Type="Int32" />
                                        </SelectParameters>
                                    </asp:ObjectDataSource>
                                </td>
                            </tr>
                            <tr>
                                <td class="tdLabel" align="left">
                                    <asp:Label ID="Label3" runat="server" CssClass="label" Text="Năm"></asp:Label> 
                                </td>
                                <td class="tdValue" align="left">
                                    <asp:DropDownList ID="cboYears" runat="server" CssClass="dropDownList">
                                    </asp:DropDownList>                                   
                                </td>
                            </tr>
                            <tr>
                                <td class="tdLabel" align="left">
                                    <asp:Label ID="Label2" runat="server" Text="Vị trí file" CssClass="label"></asp:Label></td>
                                <td class="tdValue" align="left"><asp:FileUpload ID="fuExcelFile" runat="server" CssClass="textBox" Width="203px" /></td>
                            </tr>
                            <tr>
                                <td colspan="2" class="tdButton" align="center">                                   
                                    <asp:Button ID="btnImportSalary" runat="server" Text="Import" Width="100px" OnClick="btnImportSalary_Click" CssClass="small color green button" />                                           
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td >
                        <fieldset style="margin-bottom:5px; margin-top:5px; margin-left:5px; margin-right:5px">
                            <legend class="legend"> Chú ý file import phải đúng với format sau</legend>
                            <table width="100%">
                                <tr>
                                    <td align="left">
                                        <span style="font-size: 10pt; color: #ff0000">- Các cột <strong><span style="color: #0066cc">
                                            "Mã NV", "Họ và tên", "Thực lĩnh"</span></strong> phải có.<br />
                                        - Các cột còn lại có thể có hoặc không.<br />
                                            - Dòng cuối cùng ở cột <strong>"Mã nhân viên"</strong> phải là <span style="color: #0066cc">
                                                "<strong>Stop</strong>".<br />
                                                <span style="color: #ff0000">- Tên file phải la
                                                    <asp:Label ID="lbFileNameD" runat="server" Text="tienthuong_le_2_9" Font-Bold="True" ForeColor="#0066CC"></asp:Label><br />
                                                    - Tên Sheet phải là </span><strong><span style="color: #ff0000">
                                                    <asp:Label ID="lbSheetName" runat="server" ForeColor="#0066CC" Text="thuongcuoinam"></asp:Label></span></strong></span></span></td>
                                </tr>
                            </table>
                            
                        </fieldset>
                    </td>
                </tr>
            </table>    
        </td>
    </tr>
</table>
</asp:Content>

