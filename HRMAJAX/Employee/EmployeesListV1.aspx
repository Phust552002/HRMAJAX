<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="EmployeesListV1.aspx.cs" Inherits="Employee_EmployeesListV1" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc5" %>

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
                                <asp:AsyncPostBackTrigger ControlID="imgSearch" EventName="Click" />
                             </Triggers>
                        </asp:UpdatePanel>                      
                    </td>
                </tr>
                <tr>
                    <td>
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
                                                    <asp:Label ID="lbDepartment" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
                                                    <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList">
                                                    </asp:DropDownList>&nbsp; &nbsp;&nbsp;<asp:Button ID="imgSearch" runat="server"
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
                    <td align="left">
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
<asp:BoundField DataField="UserName" SortExpression="UserName" 
        HeaderText="Tên đăng nhập">
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
    <asp:BoundField DataField="Birthday" DataFormatString="{0:dd/MM/yyyy}" 
        HeaderText="Ngày sinh" SortExpression="Birthday" />
<asp:BoundField DataField="PositionName" SortExpression="PositionName" HeaderText="Chức danh">
<ItemStyle HorizontalAlign="Left"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="DepartmentFullName" SortExpression="RootId" HeaderText="Ph&#242;ng"></asp:BoundField>
<asp:TemplateField SortExpression="JoinDate" HeaderText="Ng&#224;y v&#224;o ng&#224;nh HK">
<ItemStyle HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:Label runat="server" id="lbJoinDate"></asp:Label>
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="JoinCompanyDate" HeaderText="Ng&#224;y v&#224;o Cty"><ItemTemplate>
<asp:Label id="lbJoinCompanyDate" runat="server"  __designer:wfdid="w14"></asp:Label>
</ItemTemplate>
</asp:TemplateField>
    <asp:BoundField DataField="IdCard" HeaderText="CMND" SortExpression="IdCard" />
    <asp:BoundField DataField="DateOfIssue" DataFormatString="{0:dd/MM/yyyy}" 
        HeaderText="Ngày cấp" SortExpression="DateOfIssue" />
    <asp:BoundField DataField="PlaceOfIssue" HeaderText="Nơi cấp" 
        SortExpression="PlaceOfIssue" />
</Columns>

<RowStyle CssClass="grid-item"></RowStyle>

<PagerStyle CssClass="grid-paper"></PagerStyle>

<HeaderStyle CssClass="grid-header"></HeaderStyle>

<AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
</asp:GridView> 
<asp:ObjectDataSource id="odsEmployees" runat="server" SortParameterName="sortParameter" OnSelecting="odsEmployees_Selecting" TypeName="HRMBLL.H0.EmployeesBLL" SelectMethod="GetByDeptIds" OldValuesParameterFormatString="original_{0}" OnSelected="odsEmployees_Selected"><SelectParameters>
<asp:Parameter Type="String" Name="deptIds"></asp:Parameter>
<asp:Parameter Type="Int32" Name="rootId"></asp:Parameter>
<asp:Parameter Type="String" Name="fullName"></asp:Parameter>
<asp:Parameter Type="String" Name="sortParameter"></asp:Parameter>
    <asp:Parameter Name="AirlinesWorking" Type="String" />
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

