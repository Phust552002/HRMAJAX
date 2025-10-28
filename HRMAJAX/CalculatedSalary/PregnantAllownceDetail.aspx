<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="PregnantAllownceDetail.aspx.cs" Inherits="CalculatedSalary_PregnantAllownceDetail" Title="Untitled Page" %>

<%@ Register Src="../UserControls/Tabs.ascx" TagName="Tabs" TagPrefix="uc3" %>
<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
    <tr>
        <td valign="top">
            <uc1:ucTitle ID="UcTitle1" runat="server" />                      
        </td>
    </tr>
    <tr>
        <td valign="top">
            <table style="width: 100%" class="tableBorder">
                <tr>
                    <td class="tdLabel" style="width:40%">
                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Phòng"></asp:Label></td>
                    <td class="tdValue"  style="width:60%"><asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged">
                    </asp:DropDownList></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Lọc họ và tên"></asp:Label></td>
                    <td class="tdValue">                                               
                        <table cellpadding="0" cellspacing="0">
                            <tr>
                                <td>
                                    <asp:TextBox ID="txtFilterFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                </td>
                                <td>
                                     <asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif"
                                     OnClick="imgSearch_Click" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Họ và tên cá nhân hưởng trợ cấp thai sản"></asp:Label></td>
                    <td class="tdValue">
                        <asp:DropDownList ID="ddlEmployees" runat="server" CssClass="dropDownList">
                        
                        </asp:DropDownList>
                    </td>
                </tr>               
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tháng năm"></asp:Label></td>
                    <td class="tdValue">
                       <asp:DropDownList ID="ddlMonths" runat="server" CssClass="dropDownList">
                               <asp:ListItem Value="0" Text=""></asp:ListItem>
                                <asp:ListItem Value="1" Text="1"></asp:ListItem>
                                <asp:ListItem Value="2" Text="2"></asp:ListItem>
                                <asp:ListItem Value="3" Text="3"></asp:ListItem>
                                <asp:ListItem Value="4" Text="4"></asp:ListItem>
                                <asp:ListItem Value="5" Text="5"></asp:ListItem>
                                <asp:ListItem Value="6" Text="6"></asp:ListItem>
                                <asp:ListItem Value="7" Text="7"></asp:ListItem>
                                <asp:ListItem Value="8" Text="8"></asp:ListItem>
                                <asp:ListItem Value="9" Text="9"></asp:ListItem>
                                <asp:ListItem Value="10" Text="10"></asp:ListItem>
                                <asp:ListItem Value="11" Text="11"></asp:ListItem>
                                <asp:ListItem Value="12" Text="12"></asp:ListItem>
                                
                            </asp:DropDownList>
                        <asp:DropDownList ID="ddlYears" runat="server" CssClass="dropDownList">
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label7" runat="server" CssClass="label" Text="Số tiền được hưởng"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtAllowanceValue" runat="server" CssClass="textBox"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Lần hưởng thứ"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtIsCount" runat="server" CssClass="textBox"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td colspan="2" class="tdButton" align="center">
                        <asp:Button ID="btnAdd" runat="server" Text="Lưu" CssClass="small color green button" Width="100px" OnClick="btnAdd_Click"/>
                        &nbsp;&nbsp;<asp:Button ID="btnAddAndCancel" runat="server" Text="Lưu Và Thoát" CssClass="small color green button" Width="100px" OnClick="btnAddAndCancel_Click"/>
                        &nbsp;<asp:Button ID="btnDelete" runat="server" Text="Xóa" CssClass="small color green button" Width="100px" OnClientClick="confirm('Bạn có muốn xóa hay không?')" OnClick="btnDelete_Click"/>&nbsp;
                        <asp:Button ID="btnCancel" runat="server" Text="Thoảt" CssClass="small color green button" Width="100px" OnClick="btnCancel_Click"/></td>
                    
                </tr>
            </table>                                                                       
            <uc2:ucPermission ID="UcPermission1" runat="server" />
        </td>
    </tr>       
                                    
    
</table>
</asp:Content>

