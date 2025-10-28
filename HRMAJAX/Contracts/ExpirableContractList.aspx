<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ExpirableContractList.aspx.cs" Inherits="Contracts_ExpirableContractList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
    <tr>
        <td valign="top">
            <uc3:ucTitle ID="UcTitle1" runat="server" />
        </td>
    </tr>
    <tr>
        <td align="right">
             <table width="100%">
                <tr>
                    <td style="width:10%" align="left">                                                                       
                        <uc2:ActionMenu ID="ActionMenu1" runat="server" />
                    </td>
                    <td>
             <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
        &nbsp;
            <asp:Label ID="lbDepartment" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
            <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList" DataSourceID="odsDepartments" DataTextField="DepartmentName" DataValueField="DepartmentId">
            </asp:DropDownList>&nbsp; &nbsp;
            <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tháng"></asp:Label>&nbsp;<asp:DropDownList
                ID="ddlMonths" runat="server" CssClass="dropDownList">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>&nbsp;
            <asp:Label ID="Label4" runat="server" CssClass="label" Text="Năm"></asp:Label>&nbsp;<asp:DropDownList
                ID="ddlYears" runat="server" CssClass="dropDownList">
            </asp:DropDownList>&nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Icon-Search.gif" OnClick="ImageButton1_Click" />
            <asp:ObjectDataSource ID="odsDepartments" runat="server" OldValuesParameterFormatString="original_{0}"
                SelectMethod="GetAllRoots" TypeName="HRMBLL.H0.DepartmentsBLL"></asp:ObjectDataSource>
                </td>    
            </tr>
          </table>      
        </td>
            
    </tr>
    <tr>
        <td valign="top">
            <table style="width: 100%" class="tableBorder">                
                <tr>
                    <td valign="top" style="width:50%">
                        <fieldset>
                            <legend class="legend"><asp:Label ID="lbTitleRemindExpiredContracts" runat="server"></asp:Label></legend>
                            <table style="width: 100%">
                                <tr>
                                    <td>
                                        <table style="width: 100%" class="tableBorder">
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="grdRemindExpiredContracts" runat="server" AllowSorting="True"
                                                        AutoGenerateColumns="False" CssClass="grid-Border" DataSourceID="odsRemindExpiredContracts"
                                                        OnRowDataBound="grdRemindExpiredContracts_RowDataBound"
                                                        PageSize="20" Width="100%">
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="Họ v&#224; t&#234;n" SortExpression="FullName">
                                                                <ItemTemplate>
                                                                    <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Left" />
                                                                <HeaderStyle HorizontalAlign="Left" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="ContractTypeCode" HeaderText="Hợp đồng" SortExpression="ContractTypeCode">
                                                                <ItemStyle HorizontalAlign="Left" />
                                                                <HeaderStyle HorizontalAlign="Left" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="PositionName" HeaderText="Chức danh" SortExpression="PositionName">
                                                                <ItemStyle HorizontalAlign="Left" />
                                                                <HeaderStyle HorizontalAlign="Left" />
                                                            </asp:BoundField>
                                                            <asp:TemplateField HeaderText="Từ ng&#224;y " SortExpression="FromDate">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbFromDate" runat="server"></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Đến ng&#224;y" SortExpression="ToDate">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbToDate" runat="server"></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:TemplateField>
                                                        </Columns>
                                                        <HeaderStyle CssClass="grid-header" />
                                                        <RowStyle CssClass="grid-item" />
                                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                                        <PagerStyle CssClass="grid-paper" />
                                                        <EmptyDataTemplate>
                                                            <asp:Label ID="Label1" runat="server" CssClass="value" Text="Không có dữ liệu"></asp:Label>
                                                        </EmptyDataTemplate>
                                                        <PagerSettings PageButtonCount="30" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                        </table>
                                        <asp:ObjectDataSource ID="odsRemindExpiredContracts" runat="server" OnSelecting="odsRemindExpiredContracts_Selecting" SelectMethod="RemindExpiredConstracts" TypeName="HRMBLL.H0.EmployeeContractBLL" OldValuesParameterFormatString="original_{0}">
                                            <SelectParameters>
                                                <asp:Parameter Name="fullName" Type="String" />
                                                <asp:Parameter Name="deptId" Type="Int32" />
                                                <asp:Parameter Name="expireDate" Type="DateTime" />
                                            </SelectParameters>
                                        </asp:ObjectDataSource>
                                    </td>
                                </tr>
                            </table>
                        </fieldset>                        
                    </td>
                    <td valign="top" style="width:50%">
                        <fieldset>
                            <legend class="legend"><asp:Label ID="lbTitleChangedContracts" runat="server"></asp:Label></legend>
                            <table style="width: 100%" class="tableBorder">
                                <tr>
                                    <td valign="top">
                                        <asp:GridView ID="grdChangedContracts" runat="server" AllowSorting="True"
                                            AutoGenerateColumns="False" CssClass="grid-Border" DataSourceID="odsChangedContracts"
                                            OnRowDataBound="grdChangedContracts_RowDataBound"
                                            PageSize="20" Width="100%">
                                            <Columns>
                                                <asp:TemplateField HeaderText="Họ v&#224; t&#234;n" SortExpression="FullName">
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="ContractTypeCode" HeaderText="Hợp đồng" SortExpression="ContractTypeCode">
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="PositionName" HeaderText="Chức danh" SortExpression="PositionName">
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:BoundField>
                                                <asp:TemplateField HeaderText="Từ ng&#224;y " SortExpression="FromDate">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbFromDate" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Đến ng&#224;y" SortExpression="ToDate">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbToDate" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                            </Columns>
                                            <HeaderStyle CssClass="grid-header" />
                                            <RowStyle CssClass="grid-item" />
                                            <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                            <PagerStyle CssClass="grid-paper" />
                                            <EmptyDataTemplate>
                                                <asp:Label ID="Label1" runat="server" CssClass="value" Text="Không có dữ liệu"></asp:Label>
                                            </EmptyDataTemplate>
                                            <PagerSettings PageButtonCount="30" />
                                        </asp:GridView>
                                        <asp:ObjectDataSource ID="odsChangedContracts" runat="server" OnSelecting="odsChangedContracts_Selecting" SelectMethod="ChangedConstracts" TypeName="HRMBLL.H0.EmployeeContractBLL" OldValuesParameterFormatString="original_{0}">
                                            <SelectParameters>
                                                <asp:Parameter Name="fullName" Type="String" />
                                                <asp:Parameter Name="deptId" Type="Int32" />
                                                <asp:Parameter Name="month" Type="Int32" />
                                                <asp:Parameter Name="year" Type="Int32" />
                                                <asp:Parameter Name="typeSort" Type="Int32" />
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
</asp:Content>

