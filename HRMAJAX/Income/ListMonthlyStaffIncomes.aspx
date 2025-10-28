<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ListMonthlyStaffIncomes.aspx.cs" Inherits="Income_ListMonthlyStaffIncomes" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%">
    <tr><td align="center">
    <table width="900px" border="0">
        <tr>
            <td style="width: 90%; height: 70px;" valign="bottom">
                
                <table width="95%">
                    <tr>
                        <td >
                        Tên nhân viên 
                        </td>
                        <td >
                            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox></td>
                        <td >
                            Phòng Ban
                        </td>
                        <td >
                <asp:DropDownList ID="cboDepartment" runat="server" DataSourceID="odsDepartment"
                    DataTextField="DepartmentName" DataValueField="DepartmentId" CssClass="combobox">
                </asp:DropDownList></td>
                        <td >
                            Tháng</td>
                        <td >
                            <asp:DropDownList ID="cboMonths" runat="server" CssClass="combobox">
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
                            </asp:DropDownList></td>
                        <td >
                            Năm</td>
                        <td >
                            <asp:DropDownList ID="cboYears" runat="server" CssClass="combobox">
                            </asp:DropDownList></td>
                        <td align="right">
                            <asp:Button ID="btnView" runat="server" Text="Xem" OnClick="btnView_Click" /></td>    
                    </tr>
                </table>
                
                <asp:ObjectDataSource ID="odsDepartment" runat="server" InsertMethod="AddNewDepartment"
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllDepartments"
                    TypeName="HRMBLL.DepartmentsBLL">
                    <InsertParameters>
                        <asp:Parameter Name="departmentName" Type="String" />
                        <asp:Parameter Name="description" Type="String" />
                    </InsertParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        
        <tr>
            <td style="width: 100px; height: 25px;">
            </td>
        </tr>
        <tr>
            <td colspan="1">
                <asp:GridView ID="grdListMonthlyStaffIncomes" runat="server" AutoGenerateColumns="False" DataKeyNames="UserId"
                    DataSourceID="odsEmployeeIncomes">
                    <Columns>
                        <asp:BoundField DataField="EmployeeCode" HeaderText="M&#227; nh&#226;n vi&#234;n"
                            SortExpression="EmployeeCode">
                            <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:HyperLinkField DataNavigateUrlFields="UserId" DataNavigateUrlFormatString="~/Income/StaffIncomeMonthly.aspx?UserId={0}"
                            DataTextField="FullName" HeaderText="Họ v&#224; t&#234;n">
                            <ItemStyle HorizontalAlign="Left" />
                        </asp:HyperLinkField>
                        <asp:BoundField DataField="PositionName" HeaderText="Chức danh" SortExpression="PositionName">
                            <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="AccountNo" HeaderText="Số t&#224;i khoản" SortExpression="AccountNo">
                            <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Total_Inc" HeaderText="C&#225;c khoản thu" SortExpression="Total_Inc" DataFormatString="{0:#,###0.00}" HtmlEncode="False">
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Total_Cntr" HeaderText="C&#225;c khoản chi" SortExpression="Total_Cntr" DataFormatString="{0:#,###0.00}" HtmlEncode="False">
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Total_Inc_LK" HeaderText="Total_Inc_LK" SortExpression="Total_Inc_LK"
                            Visible="False" />
                        <asp:BoundField DataField="Total_Cntr_LK" HeaderText="Total_Cntr_LK" SortExpression="Total_Cntr_LK"
                            Visible="False" />
                        <asp:BoundField DataField="RealIncome" HeaderText="Thực lĩnh" SortExpression="RealIncome" DataFormatString="{0:#,###0.00}" HtmlEncode="False"/>
                        <asp:BoundField DataField="Date" HeaderText="Của th&#225;ng" SortExpression="Date" HtmlEncode="False" DataFormatString="{0:MM/yyyy}"/>
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="odsEmployeeIncomes" runat="server" OldValuesParameterFormatString="original_{0}"
                    SelectMethod="GetEmployeeAllIncomes" TypeName="HRMBLL.EmployeeIncomeBLL" OnSelecting="odsEmployeeIncomes_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="DepartmentId" Type="Int32" />
                        <asp:Parameter Name="date" Type="DateTime" />
                        <asp:Parameter Name="fullName" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
    </td>
        </tr>
    </table>

</asp:Content>

