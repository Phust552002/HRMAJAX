<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="CheckNewEmployee.aspx.cs" Inherits="Administrator_CheckNewEmployee" Title="Untitled Page" %>
<%@ Register Src="../UserControls/ucMessageError.ascx" TagName="ucMessageError" TagPrefix="uc3" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="tableBorder" width="100%">
        <tr>
            <td colspan="2" style="height: 62px">
                <uc2:ucTitle ID="UcTitle1" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <uc3:ucMessageError ID="UcMessageError1" runat="server" />
            </td>
        </tr>
        <tr>
            <td align="left" class="tdLabel">
                <asp:Label ID="Label2" runat="server" CssClass="label" Text="Vị trí file"></asp:Label></td>
            <td align="left" class="tdValue">
                <asp:FileUpload ID="fuExcelFile" runat="server" CssClass="textBox" Width="203px" /></td>
        </tr>
        <tr>
            <td align="left" class="tdLabel">
                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Sheet Name"></asp:Label></td>
            <td align="left" class="tdValue">
                <asp:TextBox ID="txtSheetnName" runat="server">Sheet 1</asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" class="tdButton" colspan="2">
                <asp:Button ID="btnImportSalary" runat="server" OnClick="btnImportSalary_Click" Text="Check"
                    Width="100px" />
            </td>
        </tr>
        <tr>
            <td align="center" valign="top">
                <asp:DataList ID="DataList1" runat="server" Width="100%" OnItemDataBound="DataList1_ItemDataBound">
                    <HeaderTemplate>
                        <table style="width:100%">
                            <tr class="dataList-header">
                                <td style="width:20%" align="left"> STT</td>
                                <td style="width:30%" align="left">Mã Nhân Viên</td>
                                <td style="width:50%" align="left">Họ và tên</td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemTemplate>
                       <table style="width:100%">
                            <tr>
                                <td style="width:20%" align="left"><asp:TextBox ID="txtOrderNumber" runat="server" ReadOnly="true" Width="30px"></asp:TextBox></td>
                                <td style="width:30%" align="left"><asp:Label ID="lbEmployeeCode" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"EmployeeCode") %>'></asp:Label></td>
                                <td style="width:50%" align="left"><asp:Label ID="lbFullName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"FullName") %>'></asp:Label></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <AlternatingItemStyle CssClass="dataList-atlternating-item" />
                    <ItemStyle CssClass="dataList-item" />
                    <HeaderStyle CssClass="dataList-header" />
                </asp:DataList>
             </td>
             <td valign="top">
                 <asp:DataList ID="dlEmployeeWithoutEmployeeCode" runat="server" Width="100%" OnItemDataBound="DataList2_ItemDataBound" DataKeyField="UserId">
                     <HeaderTemplate>
                        <table style="width:100%">
                            <tr class="dataList-header">
                                <td style="width:20%" align="left"> STT</td>
                                <td style="width:30%" align="left">Mã Nhân Viên</td>
                                <td style="width:50%" align="left">Họ và tên</td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemTemplate>
                      <table style="width:100%">
                            <tr>
                                <td style="width:20%" align="left"><asp:TextBox ID="txtOrderNumber" runat="server" Width="30px"></asp:TextBox></td>
                                <td style="width:30%" align="left"><asp:TextBox ID="txtUserCode" runat="server"></asp:TextBox></td>
                                <td style="width:50%" align="left"><asp:Label ID="lbFullName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"FullName") %>'></asp:Label></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <AlternatingItemStyle CssClass="dataList-atlternating-item" />
                    <ItemStyle CssClass="dataList-item" />
                    <HeaderStyle CssClass="dataList-header" />
                 </asp:DataList>
                 <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" /></td>
        </tr>
    </table>
</asp:Content>

