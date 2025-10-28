<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="EmployeeInforList.aspx.cs" Inherits="Employee_EmployeeInforList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc4" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"
    TagPrefix="uc1" %>
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
                                <asp:AsyncPostBackTrigger ControlID="imgSearch" EventName="Click" />
                             </Triggers>
                        </asp:UpdatePanel>                      
                    </td>
                </tr>
                <tr>
                    <td>
                        <table width="100%">
                            <tr>
                                <td style="width:15%" align="left">                                    
                                    <uc4:ActionMenu ID="ActionMenu1" runat="server" />
                                </td>
                                <td style="width:90%" align="right">
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
<ItemStyle HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
</asp:BoundField>
<asp:TemplateField SortExpression="FullName" HeaderText="Họ v&#224; t&#234;n (click v&#224;o t&#234;n để xem chi tiết)">
<ItemStyle HorizontalAlign="Left"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
<ItemTemplate>
<asp:HyperLink id="lnkFullName" runat="server" CssClass="hyperlink-Grid" __designer:wfdid="w5">[lnkFullName]</asp:HyperLink> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="H&#236;nh">
<ItemStyle HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:Image id="Image1" runat="server" Height="80px" __designer:wfdid="w2" ToolTip="40"></asp:Image> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="Sex" HeaderText="Giới t&#237;nh">
<ItemStyle HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:Label id="lbSex" runat="server" __designer:wfdid="w6"></asp:Label>
</ItemTemplate>
</asp:TemplateField>
<asp:BoundField DataField="PositionName" SortExpression="PositionName" HeaderText="Chức danh">
<ItemStyle HorizontalAlign="Left"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="DepartmentFullName" SortExpression="RootId" HeaderText="Ph&#242;ng"></asp:BoundField>
<asp:BoundField DataField="WorkingPhone" SortExpression="WorkingPhone" HeaderText="Điện thoại l&#224;m việc">
<ItemStyle HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="JoinDate" SortExpression="JoinDate" HeaderText="Ngày vào ngành HK" DataFormatString = "{0:dd/MM/yyyy}">
<ItemStyle HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="JoinCompanyDate" SortExpression="JoinCompanyDate" HeaderText="Ngày vào công ty" DataFormatString = "{0:dd/MM/yyyy}">
<ItemStyle HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
</asp:BoundField>
</Columns>

<RowStyle CssClass="grid-item"></RowStyle>

<PagerStyle CssClass="grid-paper"></PagerStyle>

<HeaderStyle CssClass="grid-header"></HeaderStyle>

<AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
</asp:GridView> <asp:ObjectDataSource id="odsEmployees" runat="server" SortParameterName="sortParameter" OnSelecting="odsEmployees_Selecting" TypeName="HRMBLL.H0.EmployeesBLL" SelectMethod="GetByDeptIds" OldValuesParameterFormatString="original_{0}" OnSelected="odsEmployees_Selected"><SelectParameters>
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
    <script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>
<script type="text/javascript" src="../JScripts/script.js"></script>
</asp:Content>

