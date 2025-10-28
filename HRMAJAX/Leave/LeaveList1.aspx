<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="LeaveList1.aspx.cs" Inherits="Leave_LeaveList1" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc3" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
        <tr>
            <td valign="top">
                <table style="width: 100%">
                    <tr>
                        <td>
                            <uc1:ucTitle ID="UcTitle1" runat="server" />                                                        
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <table style="width:100%">
                                <tr>
                                    <td rowspan="2" valign="top" align="left">
                                        <uc3:ActionMenu ID="ActionMenu1" runat="server" />
                                    </td>
                                    <td align="right">
                                         <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
                                            <asp:TextBox ID="txtFullName" runat="server" Width="100px" CssClass="textBox"></asp:TextBox>
                                            &nbsp;
                                            <asp:Label ID="Label2" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
                                            <asp:DropDownList ID="ddlDepartments" runat="server" CssClass="dropDownList">
                                            </asp:DropDownList>
                                    </td>
                                    <td rowspan="2">
                                        &nbsp;&nbsp;&nbsp;<asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif"
                                            OnClick="imgSearch_Click" />
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
                            <table width="100%" class="tableBorder">
                                <tr>
                                    <td>
                                        <asp:GridView ID="grdWorkdayEmployeesStatictisLeave" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                            CssClass="grid-Border" DataSourceID="ObjectDataSource1" PageSize="20" Width="100%" OnRowDataBound="grdWorkdayEmployeesStatictisLeave_RowDataBound">
                                            <PagerSettings PageButtonCount="30" />
                                            <Columns>
                                                <asp:TemplateField HeaderText="Họ t&#234;n" SortExpression="FullName">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbFullName" runat="server" ></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="PositionName" HeaderText="Chức danh" SortExpression="PositionName">
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="DepartmentFullName" HeaderText="Ph&#242;ng" SortExpression="DepartmentFullName">
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:BoundField>
                                                <asp:TemplateField HeaderText="Th&#225;ng/Năm" SortExpression="WorkdayDate">
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkWorkdaydate" runat="server" CssClass="hyperlink-Grid">HyperLink</asp:HyperLink>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Tổng số ng&#224;y nghỉ" SortExpression="TotalLeaves">
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("TotalLeaves") %>' CssClass="value-bold"></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Chi tiết">
                                                    <ItemTemplate>
                                                        <asp:Literal ID="ltDetail" runat="server"></asp:Literal>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                            <RowStyle CssClass="grid-item" />
                                            <PagerStyle CssClass="grid-paper" />
                                            <HeaderStyle CssClass="grid-header" />
                                            <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting"
                                SelectMethod="GetByStatisticLeave" TypeName="HRMBLL.H1.WorkdayEmployeesBLL">
                                <SelectParameters>
                                    <asp:Parameter Name="fullName" Type="String" />
                                    <asp:Parameter Name="deptIds" Type="String" />
                                    <asp:Parameter Name="leaveCode" Type="String" />
                                    <asp:Parameter Name="month" Type="Int32" />
                                    <asp:Parameter Name="year" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            
                        </td>
                    </tr>                    
                </table>
                
            </td>
        </tr>
    </table>
    <uc2:ucPermission ID="UcPermission1" runat="server" />
</asp:Content>

