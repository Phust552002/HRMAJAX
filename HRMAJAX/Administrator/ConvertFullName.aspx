<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ConvertFullName.aspx.cs" Inherits="Administrator_ConvertFullName" Title="Untitled Page" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
    <tr>
        <td valign="top">
            <uc4:ucTitle ID="UcTitle1" runat="server" />
        </td>
    </tr>
    <tr>
        <td valign="top" align="right">
            <table>
                <tr>                
                    <td align="right">
                            <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
                            <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                        &nbsp;
                            <asp:Label ID="lbDepartment" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
                            <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList">
                            </asp:DropDownList>&nbsp; &nbsp;&nbsp;<asp:ImageButton ID="imgSearch" runat="server"
                                ImageUrl="~/Images/Icon-Search.gif" OnClick="imgSearch_Click" />
                        &nbsp;
                    </td>
                </tr>
                
            </table>
        </td>
    </tr>
    <tr>
        <td>
             <table class="tableBorder" width="100%">
                         <tr>
                            <td>  
            <asp:GridView ID="grdEmployeesList" runat="server" AllowPaging="True" AllowSorting="True"
                AutoGenerateColumns="False" CssClass="grid-Border" DataKeyNames="UserId" DataSourceID="ObjectDataSource1"
                OnRowDataBound="grdEmployeesList_RowDataBound" OnSorting="grdEmployeesList_Sorting"
                PageSize="20" Width="100%">
                <PagerSettings PageButtonCount="30" />
                <Columns>
                    <asp:TemplateField HeaderText="M&#227; NV" SortExpression="UserId">
                        <ItemStyle HorizontalAlign="Left" />
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemTemplate>
                            <asp:Label ID="lbUserId" runat="server" Text='<%# Bind("UserId", "{0:000#}") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="EmployeeCode" HeaderText="M&#227; SAC" SortExpression="EmployeeCode">
                        <ItemStyle HorizontalAlign="Left" />
                        <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="Họ v&#224; t&#234;n" SortExpression="FullName">
                        <ItemStyle HorizontalAlign="Left" />
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemTemplate>
                            <asp:Label ID="lbFullName" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Họ t&#234;n ko dấu" SortExpression="FullName2">                        
                        <ItemTemplate>
                            <asp:Label ID="lbFullName2" runat="server" ></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="DepartmentFullName" HeaderText="Ph&#242;ng" SortExpression="RootId" />
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
                SelectMethod="GetByDeptIds" TypeName="HRMBLL.H0.EmployeesBLL" 
                 OldValuesParameterFormatString="original_{0}">
                <SelectParameters>
                    <asp:Parameter Name="deptIds" Type="String" />
                    <asp:Parameter Name="rootId" Type="Int32" />
                    <asp:Parameter Name="fullname" Type="String" />
                    <asp:Parameter Name="sortParameter" Type="String" />
                    <asp:Parameter Name="AirlinesWorking" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OnSelecting="ObjectDataSource2_Selecting"
                SelectMethod="GetEmployeeLeaveJobByFilter" TypeName="HRMBLL.H0.EmployeesBLL">
                <SelectParameters>
                    <asp:Parameter Name="deptId" Type="Int32" />
                    <asp:Parameter Name="fullName" Type="String" />
                    <asp:Parameter Name="sortParameter" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </td>
    </tr>
    <tr>
        <td class="tdButton" align="center">
            <asp:Button ID="btnConvert" runat="server" CssClass="small color green button" Text="Chuyển FullName thành không dấu" OnClick="btnConvert_Click" /></td>
    </tr>
</table>
</asp:Content>

