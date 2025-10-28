<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="CheckSend.aspx.cs" Inherits="Workdays_CheckSend" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>
<%@ Register Src="~/Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc3" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%">
    <tr>
        <td><uc1:ucTitle id="UcTitle1" runat="server"></uc1:ucTitle></td>
    </tr>   
    <tr>
        <td valign="top" align="right">   
        <table>
            <tr>               
                <td align="right">
                    <asp:Label id="Label3" runat="server" CssClass="label" Text="Tháng"></asp:Label> 
                    <asp:DropDownList id="ddlMonths" runat="server" CssClass="dropDownList">
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
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList> 
                    <asp:Label id="Label4" runat="server" CssClass="label" Text="Năm"></asp:Label> <asp:DropDownList id="ddlYears" runat="server" CssClass="dropDownList"></asp:DropDownList> 
                </td>
                <td>
                    &nbsp;&nbsp;
                    <asp:Button ID="imgSearch" runat="server" Text="Xem" CssClass="small color green button" OnClick="imgSearch_Click" />&nbsp; &nbsp;</td>
            </tr>
        </table>                            
        </td>
    </tr>
    <tr> 
        <td>
             <table style="WIDTH: 100%" class="tableBorder">
                        <tr>
                            <td>
                              <asp:GridView ID="GridView1" runat="server" Width="100%" CssClass="grid-Border" ShowFooter="True">
                                <RowStyle CssClass="grid-item"></RowStyle>
                                <PagerStyle CssClass="grid-paper"></PagerStyle>
                                <HeaderStyle CssClass="grid-header"></HeaderStyle>
                                <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                                <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                <FooterStyle CssClass="grid-footer"></FooterStyle>
                              </asp:GridView>
                            </td>
                        </tr>
                    </table>
        </td>
    </tr>
</table>
<uc3:ucPermission ID="UcPermission1" runat="server" />
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>
</asp:Content>

