<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HRM.master" CodeFile="ExportMonthlyIncome.aspx.cs" Inherits="Income_ExportMonthlyIncome" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width ="100%">
    <tr>
        <td valign="top">
            <table width ="100%">
                <tr>
                    <td>
                        <uc2:ucTitle ID="UcTitle1" runat="server" />
                        </td>
                </tr>                
                <tr>
                    <td align="right">
                    <asp:Label ID="Label2" runat="server" CssClass="label" Text="Tháng"></asp:Label>
                    <asp:DropDownList ID="cboMonths" runat="server" CssClass="dropDownList">
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
                     </asp:DropDownList>&nbsp; &nbsp;<asp:Label ID="Label3" runat="server" CssClass="label" Text="Năm"></asp:Label>
                     <asp:DropDownList ID="cboYears" runat="server" CssClass="dropDownList">
                    </asp:DropDownList>&nbsp; &nbsp;<asp:button id="btnViewData" runat="server" onclick="btnViewData_Click" text="Xem" CssClass="small color green button"/>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                    <table class="tableBorder" width="100%">
                        <tr>
                            <td>  
                                <asp:GridView ID="grdRealMonthlyIncome" runat="server" AutoGenerateColumns="False" DataSourceID="odsRealMonthlyIncome" PageSize="20" CssClass="grid-Border" Width="100%" AllowPaging="True" OnRowDataBound="grdRealMonthlyIncome_RowDataBound">
                                    <Columns>
                                        <asp:BoundField DataField="EmployeeCode" HeaderText="M&#227; SAA" SortExpression="EmployeeCode" />
                                        <asp:BoundField DataField="FullName" HeaderText="Họ t&#234;n" SortExpression="FullName" />
                                        <asp:BoundField DataField="DepartmentName" HeaderText="Ph&#242;ng" SortExpression="DepartmentName" />
                                        <asp:BoundField DataField="RealIncome" HeaderText="Thu nhập" SortExpression="RealIncome" DataFormatString="{0:#,###0.00}" HtmlEncode="False" />
                                        <asp:BoundField DataField="AccountNo" HeaderText="Số t&#224;i khoản" SortExpression="AccountNo" />
                                        <asp:BoundField DataField="CardNo" HeaderText="Số thẻ" SortExpression="CardNo" />
                                        <asp:BoundField DataField="Date" HeaderText="Lương th&#225;ng" SortExpression="Date" DataFormatString="{0:MM/yyyy}" HtmlEncode="False" />
                                    </Columns>
                                    <HeaderStyle CssClass="grid-header" /> 
                                    <RowStyle CssClass ="grid-item" />
                                    <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                    <PagerStyle CssClass="grid-paper" />  
                                    <EmptyDataTemplate>
                                        <asp:Label ID="Label4" runat="server" CssClass="value" Text="Thông tin tháng này chưa có"></asp:Label>
                                    </EmptyDataTemplate>
                                </asp:GridView>
                                
                                <asp:ObjectDataSource ID="odsRealMonthlyIncome" runat="server" OldValuesParameterFormatString="original_{0}"
                                    SelectMethod="GetByFilter" TypeName="HRMBLL.H.EmployeeIncomeBLL" OnSelecting="odsRealMonthlyIncome_Selecting" OnSelected="odsRealMonthlyIncome_Selected">
                                    <SelectParameters>
                                        <asp:Parameter Name="fullName" Type="String" />
                                        <asp:Parameter Name="departmentId" Type="Int32" />
                                        <asp:Parameter Name="month" Type="Int32" />
                                        <asp:Parameter Name="year" Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                             </td>
                         </tr>
                      </table>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:button id="btnExportData" runat="server" onclick="btnExportData_Click" text="Export Bảng Lương Ngân Hàng" CssClass="small color green button"/>
                        <asp:button id="btnExportSalary" runat="server"  text="Export Bảng Tổng Hợp Lương " CssClass="small color green button" OnClick="btnExportSalary_Click"/>
                        <asp:button id="btnExportCoefficient" runat="server"  text="Export Bảng Tổng Hợp Hệ Số Ngày Công" CssClass="small color green button" OnClick="btnExportCoefficient_Click"/>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
    
</asp:Content>
