<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="WorkdayPrivilegeList.aspx.cs" Inherits="Workdays_WorkdayPrivilegeList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
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
                                            <asp:Label ID="lbTitleList" runat="server" Text="Label"></asp:Label></legend>
                                            
                                        <table style="width: 100%">
                                            <tr>
                                                <td style="width:10%" align="left"><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/HRM-Icon-AddEmployee.gif" OnClick="ImageButton1_Click" ValidationGroup="Thêm mới nhân viên" /></td>
                                                <td style="width:80%" align="right"><asp:Label id="Label3" runat="server" CssClass="label" Text="Họ tên"></asp:Label> <asp:TextBox id="txtFullName" runat="server" CssClass="textBox"></asp:TextBox></td>
                                                <td style="width:10%"><asp:ImageButton id="imgSearch" onclick="imgSearch_Click" runat="server" ImageUrl="~/Images/Icon-Search.gif"></asp:ImageButton></td>
                                            </tr>
                                        </table>
                                        <table style="width: 100%" class="tableBorder">
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="100%" CssClass="grid-Border" AllowPaging="True" PageSize="20">
                                                        <Columns>
                                                            <asp:BoundField DataField="UserId" HeaderText="M&#227; nh&#226;n vi&#234;n" SortExpression="UserId" DataFormatString="{0:000#}" HtmlEncode="False" >
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="EmployeeCode" HeaderText="M&#227; SAC" SortExpression="EmployeeCode" >
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="FullName" HeaderText="Họ t&#234;n" SortExpression="FullName" />
                                                            <asp:BoundField DataField="DepartmentFullName" HeaderText="Ph&#242;ng" SortExpression="DepartmentFullName" />
                                                            <asp:CheckBoxField DataField="IsInit" HeaderText="Tạo BCC" SortExpression="IsInit" >
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:CheckBoxField>
                                                        </Columns>
                                                        <HeaderStyle CssClass="grid-header" /> 
                                                        <RowStyle CssClass ="grid-item" />
                                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                                        <PagerStyle CssClass="grid-paper" />  
                                                        <PagerSettings PageButtonCount="30" />
                                                    </asp:GridView>
                                                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting"
                                                        SelectMethod="GetByDeptIds" TypeName="HRMBLL.H1.WorkDayPrivilegeBLL" OldValuesParameterFormatString="original_{0}" OnSelected="ObjectDataSource1_Selected">
                                                        <SelectParameters>
                                                            <asp:Parameter Name="deptIds" Type="String" />
                                                            <asp:Parameter Name="privilegeType" Type="Int32" />
                                                            <asp:Parameter Name="fullName" Type="String" />
                                                        </SelectParameters>
                                                    </asp:ObjectDataSource>
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

