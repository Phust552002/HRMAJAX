<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ImportSalary.aspx.cs" Inherits="Data_ImportSalary" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc3" %>

<%@ Register Src="../UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc2" %>

<%@ Register Src="../UserControls/HeaderContent.ascx" TagName="HeaderContent" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table width="100%" class="bgEachPage">    
        <tr>
            <td align="center" valign="top">
                <table width="100%" >
                    <tr>
                        <td align="left" >
                            <uc3:ucTitle ID="UcTitle1" runat="server" />
                            </td>
                    </tr>
                    <tr>
                        <td align="center" valign="middle">
                            </td>
                    </tr>
                    <tr>
                        <td align="center">
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                        </td>
                    </tr>
                    <tr>
                        <td align="center" valign="middle">
                            <table width="40%" class="tableBorder">
                                <tr>
                                    <td align="left" class="tdLabel">
                                        &nbsp;<asp:Label ID="Label1" runat="server" CssClass="label" Text="Loại thông tin import"></asp:Label></td>
                                    <td align="left" class="tdValue">
                                        <asp:DropDownList ID="ddlDataType" runat="server" CssClass="dropDownList">
                                            <asp:ListItem Value="1">Bảng lương</asp:ListItem>
                                            <asp:ListItem Value="2">Bảng hệ số</asp:ListItem>
                                            <asp:ListItem Value="3">Cập nhập bảng lương thay đổi</asp:ListItem>
                                            <asp:ListItem Value="4">Bảng lương khoán</asp:ListItem>
                                        </asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td class="tdLabel" align="left">
                                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Bảng lương"></asp:Label></td>
                                    <td class="tdValue" align="left">
                                        
                                                    <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tháng"></asp:Label>
                                                    <asp:DropDownList ID="cboMonths" runat="server" CssClass="dropDownList">
                                                        <asp:ListItem>1</asp:ListItem>
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
                                                        
                                                    </asp:DropDownList>
                                                    <asp:Label ID="Label4" runat="server" Text="Năm" CssClass="label"></asp:Label>
                                                    <asp:DropDownList ID="cboYears" runat="server" CssClass="dropDownList">
                                                    </asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td class="tdLabel" align="left">
                                        <asp:Label ID="Label2" runat="server" Text="Vị trí file" CssClass="label"></asp:Label></td>
                                    <td class="tdValue" align="left"><asp:FileUpload ID="fuExcelFile" runat="server" CssClass="textBox" Width="203px" /></td>
                                </tr>
                                <tr>
                                    <td colspan="2" class="tdButton" align="center">
                                        
                                      <asp:Button ID="btnImportSalary" runat="server" Text="Import Lương" CssClass="small color green button" OnClick="btnImportSalary_Click" Width="150px" />&nbsp;
                                        &nbsp;<asp:Button ID="Button1" runat="server" Text="Thoát" CssClass="small color green button" Width="100px" /></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>    
            </td>
        </tr>
    </table>

</asp:Content>

