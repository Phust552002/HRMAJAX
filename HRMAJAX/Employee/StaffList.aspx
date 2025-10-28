<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="Employee_StaffList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"
    TagPrefix="uc1" %>
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
                        <table style="width: 100%" class="tableBorder" cellpadding="0" cellspacing="1"> 
                           
                            <tr>
                                <td valign="top" class="tdTreeView" align="left" style="width:25%">
                                    <table cellpadding="0" cellspacing="0" style="width: 100%">
                                       
                                        <tr>
                                            <td>
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
                                        </tr>
                                        <tr>
                                            <td><hr /></td>
                                        </tr>    
                                         <tr>
                                            <td>
                                    <asp:Label id="Label3" runat="server" CssClass="label" Text="Tìm kiếm tên"></asp:Label> <asp:TextBox id="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                                <asp:Button ID="btnSearch" runat="server" CssClass="small color green button" OnClick="btnSearch_Click"
                                                    Text="Tìm" /></td>
                                        </tr>
                                    </table>
                                </td>
                                  <td valign="top" style="width:75%">                                    
                                                                                 
                                        <table style="width: 100%" class="tableBorder">
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="grdEmployeesList" runat="server" AllowPaging="True" AllowSorting="True"
                                                        AutoGenerateColumns="False" CssClass="grid-Border" DataKeyNames="UserId" DataSourceID="odsEmployees"
                                                        OnRowDataBound="grdEmployeesList_RowDataBound" OnSorting="grdEmployeesList_Sorting"
                                                        PageSize="20" Width="100%">
                                                        <PagerSettings PageButtonCount="30" />
                                                        <Columns>
                                                            <asp:BoundField DataField="UserId" DataFormatString="{0:000#}" HeaderText="M&#227; NV"
                                                                HtmlEncode="False" SortExpression="UserId">
                                                                <ItemStyle HorizontalAlign="Center"/>
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:BoundField>
                                                            <asp:TemplateField HeaderText="H&#236;nh">
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                                <ItemTemplate>
                                                                    <asp:Image ID="Image1" runat="server" Height="60px" ToolTip="30" />
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Họ v&#224; t&#234;n"
                                                                SortExpression="FullName">
                                                                <ItemStyle HorizontalAlign="Left" Width="20%"/>
                                                                <HeaderStyle HorizontalAlign="Left" />
                                                                <ItemTemplate>
                                                                    <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid">[lnkFullName]</asp:HyperLink>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>                                                            
                                                            <asp:TemplateField HeaderText="Giới t&#237;nh" SortExpression="Sex">
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbSex" runat="server"></asp:Label>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="PositionName" HeaderText="Chức danh" SortExpression="LevelPosition">
                                                                <ItemStyle HorizontalAlign="Left" />
                                                                <HeaderStyle HorizontalAlign="Left" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="DepartmentName" HeaderText="Ph&#242;ng/Đội/Nh&#243;m/Ca" SortExpression="RootId">
                                                                <ItemStyle Width="20%" />
                                                            </asp:BoundField>
                                                            <asp:TemplateField SortExpression="JoinDate" HeaderText="Ng&#224;y v&#224;o ng&#224;nh HK">
                                                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                                <ItemTemplate>
                                                                <asp:Label runat="server" id="lbJoinDate"></asp:Label>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField SortExpression="JoinCompanyDate" HeaderText="Ng&#224;y v&#224;o Cty">
                                                                <ItemTemplate>
                                                                <asp:Label id="lbJoinCompanyDate" runat="server"></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                            </asp:TemplateField>
                                                        </Columns>
                                                        <RowStyle CssClass="grid-item" />
                                                        <PagerStyle CssClass="grid-paper" />
                                                        <HeaderStyle CssClass="grid-header" />
                                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                                    </asp:GridView>
                                                    <asp:ObjectDataSource ID="odsEmployees" runat="server" OldValuesParameterFormatString="original_{0}"
                                                        OnSelected="odsEmployees_Selected" OnSelecting="odsEmployees_Selecting" SelectMethod="GetByDeptIds"
                                                        SortParameterName="sortParameter" TypeName="HRMBLL.H0.EmployeesBLL">
                                                        <SelectParameters>
                                                            <asp:Parameter Name="deptIds" Type="String" />
                                                            <asp:Parameter Name="rootId" Type="Int32" />
                                                            <asp:Parameter Name="fullName" Type="String" />
                                                            <asp:Parameter Name="sortParameter" Type="String" />
                                                            <asp:Parameter Name="AirlinesWorking" Type="String" />
                                                        </SelectParameters>
                                                    </asp:ObjectDataSource>
                                                    <uc1:ucPermission ID="UcPermission1" runat="server" />
                                                                                                        
                                                </td>                                                
                                            </tr>
                                            
                                        </table>                                    
                                </td>
                            </tr>
                            
                        </table>
                                           
                    </td>
                </tr>
            </table>
     </tr>
</table>
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>
<script type="text/javascript" src="../JScripts/script.js"></script>
</asp:Content>

