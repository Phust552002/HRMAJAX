<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Departments.aspx.cs" Inherits="Department_Departments" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>
<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
    <tr>
        <td valign="top" >
            <table style="width: 100%">
                <tr>
                    <td valign="top">
                        <uc2:ucTitle ID="UcTitle1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td valign="top">
                        <table style="width: 100%" class="tableBorder"> 
                            <tr>
                                <td valign="top" rowspan="2" class="tdTreeView" align="left">
                                    <asp:TreeView  
                                        ID="TreeView1"
                                        ExpandDepth="0" 
                                        PopulateNodesFromClient="true" 
                                        ShowLines="true" 
                                        ShowExpandCollapse="true" 
                                        runat="server"
                                        OnTreeNodePopulate="TreeView1_TreeNodePopulate" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
                                        <RootNodeStyle CssClass="tvNodeRoot" />
                                        <NodeStyle CssClass="tvNode" />
                                        <ParentNodeStyle CssClass="tvNodeParent" />
                                        <SelectedNodeStyle CssClass="tvNodeSelected" />
                                    </asp:TreeView>  
                                </td>
                                <td valign="top">
                                    <fieldset class="fieldset">
                                        <legend class="legend"><asp:Label ID="lbTitleUpdate" runat="server"></asp:Label></legend>
                                        <table style="width: 99%;margin-top:2px; margin-left:2px; margin-right:2px;" class="tableBorder">
                                            <tr>
                                                <td class="tdLabel">
                                                    <asp:Label ID="Label7" runat="server" CssClass="label" Text="Mã phòng ban"></asp:Label></td>
                                                <td class="tdValue">
                                                    <asp:TextBox ID="txtDepartmentCodeUpdate" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
                                            </tr>
                                            <tr>
                                                <td class="tdLabel">
                                                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên phòng ban"></asp:Label></td>
                                                <td class="tdValue">
                                                    <asp:TextBox ID="txtDepartmentNameUpdate" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
                                            </tr>
                                            <tr>
                                                <td class="tdLabel">
                                                    <asp:Label ID="Label8" runat="server" CssClass="label" Text="Tên phòng ban tiếng anh"></asp:Label></td>
                                                <td class="tdValue">
                                                    <asp:TextBox ID="txtDepartmentNameEUpdate" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
                                            </tr>
                                            <tr>
                                                <td class="tdLabel">
                                                    <asp:Label ID="Label9" runat="server" CssClass="label" Text="Diễn giải"></asp:Label></td>
                                                <td class="tdValue">
                                                    <asp:TextBox ID="txtDescriptionEUpdate" runat="server" CssClass="textBox" TextMode="MultiLine"
                                                        Width="100%"></asp:TextBox></td>
                                            </tr>
                                            <tr>
                                                <td class="tdButton" colspan="2" align="center">
                                                    <asp:Button ID="btnUpdate" runat="server" Text="Thay đổi" CssClass="small color green button" Width="100px" OnClick="btnUpdate_Click" />
                                                    &nbsp;&nbsp;
                                                    <asp:Button ID="btnDelete" runat="server" Text="Xóa" CssClass="small color green button" Width="100px" OnClick="btnDelete_Click" /></td>
                                            </tr>
                                        </table>
                                        <uc3:ucPermission id="UcPermission1" runat="server"></uc3:ucPermission>
                                    </fieldset>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <fieldset class="fieldset">
                                        <legend class="legend">
                                            <asp:Label ID="lbTitleInsert" runat="server"></asp:Label></legend>
                                        <table style="width: 99%;margin-top:2px; margin-left:2px; margin-right:2px;" class="tableBorder">
                                            <tr>
                                                <td class="tdLabel">
                                                    <asp:Label ID="Label2" runat="server" CssClass="label" Text="Mã phòng ban"></asp:Label></td>
                                                <td class="tdValue">
                                                    <asp:TextBox ID="txtDepartmentCodeInsert" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
                                            </tr>
                                            <tr>
                                                <td class="tdLabel">
                                                    <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tên phòng ban"></asp:Label></td>
                                                <td class="tdValue">
                                                    <asp:TextBox ID="txtDepartmentNameInsert" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
                                            </tr>
                                            <tr>
                                                <td class="tdLabel">
                                                    <asp:Label ID="Label4" runat="server" CssClass="label" Text="Tên phòng ban tiếng anh"></asp:Label></td>
                                                <td class="tdValue">
                                                    <asp:TextBox ID="txtDepartmentNameEInsert" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
                                            </tr>
                                            <tr>
                                                <td class="tdLabel">
                                                    <asp:Label ID="Label5" runat="server" CssClass="label" Text="Diễn giải"></asp:Label></td>
                                                <td class="tdValue">
                                                    <asp:TextBox ID="txtDescriptionInsert" runat="server" CssClass="textBox" TextMode="MultiLine"
                                                        Width="100%"></asp:TextBox></td>
                                            </tr>
                                            <tr>
                                                <td class="tdButton" colspan="2" align="center">
                                                    <asp:Button ID="btnAdd" runat="server" Text="Thêm mới" CssClass="small color green button" Width="100px" OnClick="btnAdd_Click" />&nbsp;
                                                </td>
                                            </tr>
                                        </table>
                                    </fieldset>
                                </td>
                            </tr>
                        </table>
                                           
                    </td>
                </tr>
            </table>
     </tr>
</table>                    
</asp:Content>

