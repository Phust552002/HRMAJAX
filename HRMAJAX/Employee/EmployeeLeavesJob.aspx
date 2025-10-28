<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="EmployeeLeavesJob.aspx.cs" Inherits="Employee_EmployeeLeavesJob" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc1" %>
    <%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc4" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc5" %>
<%@ Register Src="~/UserControls/ListTotalCounts.ascx" TagName="ListTotalCounts" TagPrefix="uc3" %>
<%@ Register Src="~/UserControls/ucDepartmentFilter.ascx" TagName="ucDepartmentFilter" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table width="100%">   
    <tr>
        <td align="center" valign="top">
            <table width="100%">
                <tr>
                    <td>
                         <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
                            <ContentTemplate>  
                                <uc5:ucTitle ID="UcTitle1" runat="server" /> 
                            </ContentTemplate>
                             <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="btnView" EventName="Click" />
                             </Triggers>
                        </asp:UpdatePanel>     
                    </td>
                </tr>
                <tr>
                    <td>
                        <table width="100%"  border="0">
                            <tr> 
                                <td style="width:20%" align="left">                                                                       
                                    <uc4:ActionMenu ID="ActionMenu1" runat="server" />
                                </td>                               
                                <td  style="width:80%" align="right" >
                                 <table>
                                        <tr> 
                                                                                           
                                            <td align="right">
                                                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
                                                    <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                                &nbsp;
                                                    <asp:Label ID="lbDepartment" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
                                                    <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList">
                                                    </asp:DropDownList>&nbsp; &nbsp;
                                                    <asp:Label ID="Label2" runat="server" CssClass="label" Text="Quyết định"></asp:Label>
                                                    <asp:DropDownList ID="ddlStatus" runat="server" CssClass="dropDownList" AppendDataBoundItems="true">
                                                    <asp:ListItem Text="" Value="-1"></asp:ListItem>
                                                    </asp:DropDownList>&nbsp; &nbsp;
                                                    <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="Xem"  CssClass="small color green button" />&nbsp;
                                            </td>
                                        </tr>                                        
                                 </table>
                                 </td>
                            </tr>
                        </table>                             
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <table class="tableBorder" width="100%">
                         <tr>
                            <td>  
                             <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                                 <ContentTemplate>
<asp:GridView id="grdEmployeesList" runat="server" Width="100%" CssClass="grid-Border" DataKeyNames="UserId" 
                                         DataSourceID="ObjectDataSource1" OnRowDataBound="grdEmployeesList_RowDataBound" 
                                         AutoGenerateColumns="False" PageSize="20" 
                                         AllowSorting="True"><Columns>
    <asp:TemplateField HeaderText="Mã NV" SortExpression="UserId">
       
        <ItemTemplate>
            <asp:HyperLink ID="lnkUserId" runat="server" Text='<%# Bind("UserId", "{0:000#}") %>' CssClass="hyperlink-Grid"></asp:HyperLink>
        </ItemTemplate>
        <ItemStyle HorizontalAlign="Center" Width="5%" />
    </asp:TemplateField>
<asp:TemplateField SortExpression="FullName" HeaderText="Họ v&#224; t&#234;n"><ItemTemplate>
                                                   <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid">[lnkFullName]</asp:HyperLink>
                                               
</ItemTemplate>
    <ItemStyle Width="13%" />
</asp:TemplateField>
<asp:BoundField DataField="PositionName" SortExpression="RootId" HeaderText="Chức danh">
    <ItemStyle Width="8%" />
    </asp:BoundField>
<asp:BoundField DataField="DepartmentFullName" SortExpression="RootId" HeaderText="Ph&#242;ng">
    <ItemStyle Width="26%" />
    </asp:BoundField>
<asp:TemplateField SortExpression="JoinDate" HeaderText="Ng&#224;y v&#224;o ng&#224;nh HK">
<ItemStyle HorizontalAlign="Center" Width="7%"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
                                                   <asp:Label ID="lbJoinDate" runat="server" ></asp:Label>
                                               
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="JoinCompanyDate" HeaderText="Ng&#224;y v&#224;o Cty"><ItemTemplate>
<asp:Label id="lbJoinCompanyDate" runat="server"  __designer:wfdid="w40"></asp:Label>
</ItemTemplate>
    <ItemStyle Width="7%" HorizontalAlign="Center" />
</asp:TemplateField>
<asp:TemplateField SortExpression="LeaveDate" HeaderText="Ng&#224;y nghỉ">
<ItemStyle HorizontalAlign="Center" Width="8%"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
                                                   <asp:Label ID="lbLeaveDate" runat="server"></asp:Label>
                                               
</ItemTemplate>
</asp:TemplateField>
    <asp:TemplateField HeaderText="Quyết định">
        <ItemStyle HorizontalAlign="Center" Width="8%"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
                                                   <asp:Label ID="lbEmployeeStatus" runat="server"></asp:Label>
                                               
</ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Ghi chú"> 
        <ItemTemplate>
                                                   <asp:Label ID="lbLeaveRemark" runat="server"></asp:Label>
                                               
</ItemTemplate>       
        <ItemStyle Width="18%" />
    </asp:TemplateField>
</Columns>

<RowStyle CssClass="grid-item"></RowStyle>

<PagerStyle CssClass="grid-paper"></PagerStyle>

<HeaderStyle CssClass="grid-header"></HeaderStyle>

<AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
</asp:GridView>  
</ContentTemplate>
                                     <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="btnView" EventName="Click" />
                                     </Triggers>
                                </asp:UpdatePanel>
                            </td>
                       </tr>
                    </table>
                        <uc1:ucPermission ID="UcPermission1" runat="server" />
                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                            onselected="ObjectDataSource1_Selected" 
                            onselecting="ObjectDataSource1_Selecting" 
                            SelectMethod="GetEmployeeLeaveJobByFilterForDataTable" 
                            TypeName="HRMBLL.H0.EmployeesBLL">
                            <SelectParameters>
                                <asp:Parameter Name="deptId" Type="Int32" />
                                <asp:Parameter Name="fullName" Type="String" />
                                <asp:Parameter Name="status" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        &nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
    </table>
</asp:Content>

