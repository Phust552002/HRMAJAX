<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="LeaveList.aspx.cs" Inherits="Leave_LeaveList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table style="width: 100%">
        <tr>
            <td valign="top">
                <table style="width: 100%">
                    <tr>
                        <td>
                           <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
                                <ContentTemplate>  
                                    <uc1:ucTitle ID="UcTitle1" runat="server" /> 
                                </ContentTemplate>
                                 <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnView" EventName="Click" />
                                 </Triggers>
                            </asp:UpdatePanel>   
                         
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <table style="width:100%">
                                <tr>
                                    <td rowspan="2" valign="top" align="left">
                                     <asp:HyperLink ID="lnkAddUser" runat="server" ImageUrl="~/Images/HRM-Icon-AddEmployee.gif" NavigateUrl="~/Leave/LeaveAdd.aspx"
                                     >HyperLink</asp:HyperLink> 
                                        <asp:Label ID="Label6" runat="server" CssClass="labelIcon" Text="Thêm Ngày Phép"></asp:Label></td>
                                    <td align="right">
                                         <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
                                            <asp:TextBox ID="txtFullName" runat="server" Width="100px" CssClass="textBox"></asp:TextBox>
                                            &nbsp;
                                            <asp:Label ID="Label2" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
                                            <asp:DropDownList ID="ddlDepartments" runat="server" CssClass="dropDownList">
                                            </asp:DropDownList>
                                    </td>
                                    <td rowspan="2">
                                        &nbsp;&nbsp;
                                        <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="Xem" CssClass="small color green button"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label5" runat="server" CssClass="label"
                                                Text="Loại ngày nghỉ"></asp:Label>
                                        <asp:DropDownList ID="ddlLeaveType" runat="server" CssClass="dropDownList" AppendDataBoundItems="true" DataSourceID="odsLeaveType" DataTextField="LeaveTypeName" DataValueField="LeaveTypeId">
                                         <asp:ListItem Value="0" Text=""></asp:ListItem>
                                        </asp:DropDownList>
                                        &nbsp;
                                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tháng"></asp:Label>
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
                                            &nbsp;
                                            <asp:Label ID="Label4" runat="server" CssClass="label" Text="Năm"></asp:Label>
                                           <asp:DropDownList ID="ddlYears" runat="server" CssClass="dropDownList" AppendDataBoundItems="true" >
                                           <asp:ListItem Value="0" Text=""></asp:ListItem>
                                            </asp:DropDownList> <asp:ObjectDataSource ID="odsLeaveType" runat="server" SelectMethod="GetByFilter"
                                        TypeName="HRMBLL.H0.LeaveTypesBLL" OldValuesParameterFormatString="original_{0}" OnSelecting="odsLeaveType_Selecting">
                                                <SelectParameters>
                                                    <asp:Parameter Name="leaveTypeCode" Type="String" />
                                                    <asp:Parameter Name="leaveTypeName" Type="String" />
                                                    <asp:Parameter Name="type" Type="Int32" />
                                                </SelectParameters>
                                            </asp:ObjectDataSource>                                                                                                                                  
                                    </td>
                                </tr>
                            </table>
                            
                                
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <table style="width: 100%" class="tableBorder">
                                <tr>
                                    <td>
                                     <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                                        <ContentTemplate>
<asp:GridView id="grdEmployeeLeave" runat="server" Width="100%" CssClass="grid-Border" DataSourceID="odsEmployeeLeave" AutoGenerateColumns="False" CellPadding="0" AllowPaging="True" PageSize="20" OnRowDataBound="grdEmployeeLeave_RowDataBound">
<PagerSettings PageButtonCount="30"></PagerSettings>
<Columns>
<asp:TemplateField HeaderText="Họ v&#224; t&#234;n">
<ItemStyle HorizontalAlign="Left"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
<ItemTemplate>
                                                            <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid" NavigateUrl='<%# Eval("UserId", "~/Leave/Detail.aspx?UserId={0}") %>'
                                                                Text='<%# Eval("FullName") %>'></asp:HyperLink>
                                                        
</ItemTemplate>
</asp:TemplateField>
<asp:BoundField DataField="DepartmentFullName" SortExpression="DepartmentFullName" HeaderText="Ph&#242;ng Ban">
<ItemStyle HorizontalAlign="Left"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="LeaveTypeName" SortExpression="LeaveTypeName" HeaderText="Loại ng&#224;y nghỉ">
<ItemStyle HorizontalAlign="Left"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
<asp:BoundField HtmlEncode="False" DataFormatString="{0:dd/MM/yyyy}" DataField="FromDate" SortExpression="FromDate" HeaderText="Từ ng&#224;y">
<ItemStyle HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
</asp:BoundField>
<asp:BoundField HtmlEncode="False" DataFormatString="{0:dd/MM/yyyy}" DataField="ToDate" SortExpression="ToDate" HeaderText="Đến ng&#224;y">
<ItemStyle HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="Days" SortExpression="Days" HeaderText="Số ng&#224;y nghỉ">
<ItemStyle HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
</asp:BoundField>
</Columns>

<RowStyle CssClass="grid-item"></RowStyle>

<PagerStyle CssClass="grid-paper"></PagerStyle>

<HeaderStyle CssClass="grid-header"></HeaderStyle>

<AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
</asp:GridView> <asp:ObjectDataSource id="odsEmployeeLeave" runat="server" OnSelecting="odsEmployeeLeave_Selecting" OldValuesParameterFormatString="original_{0}" TypeName="HRMBLL.H0.EmployeeLeaveBLL" SelectMethod="GetByFilter" OnSelected="odsEmployeeLeave_Selected"><SelectParameters>
<asp:Parameter Type="String" Name="fullName"></asp:Parameter>
<asp:Parameter Type="String" Name="departmentIds"></asp:Parameter>
<asp:Parameter Type="Int32" Name="leaveTypeId"></asp:Parameter>
<asp:Parameter Type="Int32" Name="month"></asp:Parameter>
<asp:Parameter Type="Int32" Name="year"></asp:Parameter>
</SelectParameters>
</asp:ObjectDataSource> 
</ContentTemplate>
                                         <Triggers>
                                            <asp:AsyncPostBackTrigger ControlID="btnView" EventName="Click" />
                                         </Triggers>
                                    </asp:UpdatePanel>   
                                        <uc2:ucPermission ID="UcPermission1" runat="server" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                    </tr>
                </table>
                
            </td>
        </tr>
    </table>
</asp:Content>

