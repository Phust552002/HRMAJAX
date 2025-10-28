<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="UnofficialEmployeesList.aspx.cs" Inherits="Employee_UnofficialEmployeesList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> 
    <table width="100%">   
    <tr>
        <td align="center" valign="top">
            <table width="100%">
                <tr>
                    <td colspan="2">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
                            <ContentTemplate>  
                                <uc5:ucTitle ID="UcTitle1" runat="server" /> 
                            </ContentTemplate>
                             <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="imgSearch" EventName="Click" />
                             </Triggers>
                        </asp:UpdatePanel>                      
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <table width="100%">
                            <tr>
                                <td style="width:20%" align="left">                                                                       
                                    <uc2:ActionMenu ID="ActionMenu1" runat="server" />
                                </td>
                                <td style="width:80%" align="right">
                                    <table>
                                        <tr>                
                                            <td align="right">
                                                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
                                                    <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                                &nbsp;
                                                    &nbsp; &nbsp;&nbsp;<asp:Button ID="imgSearch" runat="server"
                                                        Text="Xem" CssClass="small color green button" OnClick="imgSearch_Click" />
                                                &nbsp;
                                            </td>
                                        </tr>
                                        
                                    </table>
                                </td>
                            </tr>
                        </table>                             
                    </td>
                </tr>
                <tr>
                    <td style="width:30%" valign="top" class="tdTreeView" align="left">
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
                    <td align="right">
                        <table class="tableBorder" width="100%">
                         <tr>
                            <td>  
                                 <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                                 <ContentTemplate>

<asp:GridView id="grdEmployeesList" runat="server" Width="100%" CssClass="grid-Border" AllowSorting="True" AllowPaging="True" PageSize="20" OnRowDataBound="grdEmployeesList_RowDataBound" AutoGenerateColumns="False" DataSourceID="odsEmployees" DataKeyNames="UserId" OnSorting="grdEmployeesList_Sorting">
<PagerSettings PageButtonCount="30"></PagerSettings>
<Columns>
<asp:BoundField HtmlEncode="False" DataFormatString="{0:000#}" DataField="UserId" SortExpression="UserId" HeaderText="M&#227; NV">
<ItemStyle HorizontalAlign="Left"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
<asp:TemplateField SortExpression="FullName" HeaderText="Họ v&#224; t&#234;n">
<ItemStyle HorizontalAlign="Left"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
<ItemTemplate>
<asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid">[lnkFullName]</asp:HyperLink>
                                               
</ItemTemplate>
</asp:TemplateField>

<asp:BoundField DataField="DepartmentFullName" SortExpression="RootId" HeaderText="Ph&#242;ng"></asp:BoundField>
<asp:TemplateField SortExpression="JoinDate" HeaderText="Ng&#224;y v&#224;o">
<ItemStyle HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:Label runat="server" id="lbJoinDate"></asp:Label>
</ItemTemplate>
</asp:TemplateField>

<asp:TemplateField SortExpression="LeaveDate" HeaderText="Ng&#224;y nghỉ"><ItemTemplate>
<asp:Label id="lbLeaveDate" runat="server" ></asp:Label>
</ItemTemplate>
</asp:TemplateField>
</Columns>

<RowStyle CssClass="grid-item"></RowStyle>

<PagerStyle CssClass="grid-paper"></PagerStyle>

<HeaderStyle CssClass="grid-header"></HeaderStyle>

<AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
</asp:GridView> 
<asp:ObjectDataSource id="odsEmployees" runat="server" SortParameterName="sortParameter" OnSelecting="odsEmployees_Selecting" TypeName="HRMBLL.H0.UnofficialEmployeesBLL" SelectMethod="GetByDeptIds" OldValuesParameterFormatString="original_{0}" OnSelected="odsEmployees_Selected"><SelectParameters>
<asp:Parameter Type="String" Name="deptIds"></asp:Parameter>
<asp:Parameter Type="Int32" Name="rootId"></asp:Parameter>
<asp:Parameter Type="String" Name="fullName"></asp:Parameter>
<asp:Parameter Type="String" Name="sortParameter"></asp:Parameter>
</SelectParameters>
</asp:ObjectDataSource> 

</ContentTemplate>
                                     <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="imgSearch" EventName="Click" />
                                     </Triggers>
                                </asp:UpdatePanel>
                            </td>
                       </tr>
                    </table>
                        <uc1:ucPermission ID="UcPermission1" runat="server" />
                    </td>
                </tr>
                
            </table>
        </td>
    </tr>
    </table>
</asp:Content>

