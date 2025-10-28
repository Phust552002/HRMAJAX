<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="WorkdayRole.aspx.cs" Inherits="Workdays_WorkdayRole" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>

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
                                <td valign="top" class="tdTreeView" align="left">
                                    <asp:TreeView  
                                        ID="TreeView1"
                                        ExpandDepth="1" 
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
                                        <legend class="legend">
                                            <asp:Label ID="lbTitleList" runat="server" Text="Các Nhân Viên Được Phân Quyền Trên Menu Chấm Công - SAGS"></asp:Label></legend>
                                            
                                        <table style="width: 100%">
                                            <tr>
                                                <td style="width:80%" align="right"><asp:Label id="Label3" runat="server" CssClass="label" Text="Họ tên"></asp:Label> <asp:TextBox id="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                                    &nbsp;
                                                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Vai trò"></asp:Label>&nbsp;<asp:DropDownList
                                                        ID="ddlRoles" runat="server" CssClass="dropDownList">
                                                    </asp:DropDownList></td>
                                                <td style="width:10%"><asp:ImageButton id="imgSearch" onclick="imgSearch_Click" runat="server" ImageUrl="~/Images/Icon-Search.gif"></asp:ImageButton></td>
                                            </tr>
                                        </table>
                                        <table style="width: 100%" class="tableBorder">
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="100%" CssClass="grid-Border" AllowPaging="True" PageSize="20" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="Họ t&#234;n" SortExpression="FullName">
                                                                <ItemTemplate>
                                                                    <asp:LinkButton ID="lbtnFullName" runat="server" Text='<%# Bind("FullName") %>' ToolTip='<%# Bind("UserId") %>' CssClass="hyperlink-Grid" CommandName="Select"></asp:LinkButton>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="M&#244; tả" SortExpression="Description">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbDescription" runat="server" Text='<%# Bind("Description") %>' ToolTip='<%# Bind("RoleId") %>' ></asp:Label>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                        </Columns>
                                                        <HeaderStyle CssClass="grid-header" /> 
                                                        <RowStyle CssClass ="grid-item" />
                                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                                        <PagerStyle CssClass="grid-paper" />  
                                                        <PagerSettings PageButtonCount="30" />
                                                        <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                                    </asp:GridView>
                                                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting"
                                                        SelectMethod="GetByFilter" TypeName="HRMBLL.H0.UserRolesBLL" OldValuesParameterFormatString="original_{0}" OnSelected="ObjectDataSource1_Selected">
                                                        <SelectParameters>
                                                            <asp:Parameter Name="fullName" Type="String" />
                                                            <asp:Parameter Name="roleIds" Type="String" />
                                                            <asp:Parameter Name="departmentIds" Type="String" />
                                                        </SelectParameters>
                                                    </asp:ObjectDataSource>
                                                </td>                                                
                                            </tr>
                                            
                                        </table>
                                    </fieldset>
                                    <fieldset class="fieldset">
                                        <legend class="legend">
                                            <asp:Label ID="Label6" runat="server" Text="Danh mục các trang theo quyền"></asp:Label></legend>
                                        <table style="width: 100%">
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" Width="100%" CssClass="grid-Border" AllowPaging="True" PageSize="20" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="Trang" SortExpression="Title">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbTitle" runat="server" Text='<%# Bind("Title") %>'></asp:Label>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Địa chỉ truy cập" SortExpression="Url">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbUrl" runat="server" Text='<%# Bind("Url") %>'></asp:Label>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                        </Columns>
                                                        <HeaderStyle CssClass="grid-header" /> 
                                                        <RowStyle CssClass ="grid-item" />
                                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                                        <PagerStyle CssClass="grid-paper" />  
                                                        <PagerSettings PageButtonCount="30" />
                                                        <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                                    </asp:GridView>
                                                     <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OnSelecting="ObjectDataSource2_Selecting"
                                                        SelectMethod="GetByRoles" TypeName="HRMBLL.H0.SiteMapBLL" OldValuesParameterFormatString="original_{0}" >
                                                        <SelectParameters>
                                                            <asp:Parameter Name="roleIds" Type="String" />
                                                        </SelectParameters>
                                                    </asp:ObjectDataSource>
                                                </td>
                                            </tr>
                                        </table>
                                    </fieldset>
                                    <fieldset>
                                        <legend class="legend"><asp:Label ID="lbTitleAddRole" runat="server" Text="Phân Quyền Trên Menu Chấm Công - SAGS"></asp:Label></legend>
                                        <table width="100%" class="tableBorder">
                                            <tr>
                                                <td class="tdLabel">
                                                    <asp:Label ID="Label5" runat="server" CssClass="label" Text="Tìm Họ và tên"></asp:Label></td>
                                                <td class="tdValue">
                                                    <table cellpadding="0" cellspacing="0">
                                                        <tr>
                                                            <td>
                                                                <asp:TextBox ID="txtFilterFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                                            </td>
                                                            <td>
                                                                 <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Icon-Search.gif"
                                                                 OnClick="ImageButton1_Click" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="tdLabel">
                                                    <asp:Label ID="Label2" runat="server" CssClass="label" Text="Họ và tên"></asp:Label></td>
                                                <td class="tdValue"><asp:DropDownList
                                                        ID="ddlEmployeeAdd" runat="server" CssClass="dropDownList">
                                                </asp:DropDownList></td>
                                            </tr>
                                            <tr>
                                                <td class="tdLabel">
                                                    <asp:Label ID="Label4" runat="server" CssClass="label" Text="Vai trò"></asp:Label></td>
                                                <td class="tdValue">
                                                    <asp:DropDownList
                                                        ID="ddlRoleAdd" runat="server" CssClass="dropDownList">
                                                    </asp:DropDownList></td>
                                            </tr>
                                            <tr>
                                                <td class="tdButton" colspan="2" align="center">
                                                    <asp:Button ID="btnClear" runat="server" CssClass="small color green button" OnClick="btnClear_Click"
                                                        Text="Clear" Visible="False" Width="100px" />
                                                    &nbsp;
                                                    <asp:Button ID="btnDelete" runat="server" CssClass="small color green button" OnClick="btnDelete_Click"
                                                        OnClientClick="return confirm('Bạn có muốn xóa mục thông tin này ?');" Text="Xóa"
                                                        Visible="False" Width="100px" />
                                                    &nbsp;
                                                    <asp:Button ID="btnSave" runat="server" CssClass="small color green button" OnClick="btnSave_Click"
                                                        Text="Thêm" Width="100px" /></td>
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

