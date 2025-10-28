<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ComparerList.aspx.cs" Inherits="CalculatedSalary_ComparerList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc3" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%">
        <tr>
            <td valign="top">
                <table style="width: 100%">
                    <tr>
                        <td colspan="2" valign="top">
                            <uc3:ucTitle ID="UcTitle1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right"> 
                            <table width="100%">
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên nhân viên"></asp:Label>
                                        <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>&nbsp;
                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Phòng Ban "></asp:Label>
                                        <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList">
                                        </asp:DropDownList>&nbsp; &nbsp;&nbsp;
                                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tháng"></asp:Label>
                                        <asp:DropDownList ID="ddlMonths" runat="server" CssClass="dropDownList">
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
                                        </asp:DropDownList>
                                        &nbsp;
                                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Năm"></asp:Label>&nbsp;<asp:DropDownList ID="ddlYears" runat="server" CssClass="dropDownList">
                                        </asp:DropDownList>
                                        &nbsp;&nbsp;&nbsp;<asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif"
                                            OnClick="imgSearch_Click" />&nbsp;&nbsp;
                                    </td>
                                    <td></td>
                                </tr>
                            </table>                                                                                                              
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table style="width:100%; background-color:#faf0e6" class="tableBorder">
                                <tr>
                                    <td align="center">
                                        <strong>Bảng Lương Công Ty SAGS</strong></td>
                                    <td align="center">
                                        <strong>Bảng Lương Tổng Công Ty</strong></td>
                                </tr>
                                <tr>
                                    <td>
                                        <table class="tableBorder">
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="odsEmployeeIncomes"
                                                        Width="100%" OnRowDataBound="GridView2_RowDataBound" CssClass="grid-Border" AllowSorting="True" PageSize="20" OnSorting="GridView2_Sorting" AllowPaging="True">
                                                        <HeaderStyle CssClass="grid-header1" /> 
                                                        <RowStyle CssClass ="grid-item" />
                                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                                        <PagerStyle CssClass="grid-paper" /> 
                                                        <FooterStyle CssClass="grid-footer" />                                  
                                                        <PagerSettings PageButtonCount="30" />
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="Họ T&#234;n" SortExpression="FullName">
                                                                <ItemTemplate>
                                                                    <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Left" Width="200px"/>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Lương năng suất" SortExpression="LNS">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbLNS" runat="server" ></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Bổ sung lương" SortExpression="BoSungLuong">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbBoSungLuong" runat="server"></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Thuế TN" SortExpression="TienThuong">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbTienThuong" runat="server"></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Th&#224;nh tiền" SortExpression="RealIncome">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbRealIncome" runat="server" CssClass="value-bold"></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                        </Columns>
                                                    </asp:GridView>
                                                    <asp:ObjectDataSource ID="odsEmployeeIncomes" runat="server" OnSelecting="odsEmployeeIncomes_Selecting"
                                                        SelectMethod="GetAllByFilter" TypeName="HRMBLL.H1.IncomesBLL" OldValuesParameterFormatString="original_{0}">
                                                        <SelectParameters>
                                                            <asp:Parameter Name="fullName" Type="String" />
                                                            <asp:Parameter Name="departmentId" Type="Int32" />
                                                            <asp:Parameter Name="month" Type="Int32" />
                                                            <asp:Parameter Name="year" Type="Int32" />
                                                            <asp:Parameter Name="sortParameter" Type="String" />
                                                        </SelectParameters>
                                                    </asp:ObjectDataSource>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                    </td> 
                                    <td>
                                        <table class="tableBorder">
                                            <tr>
                                                <td>
                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1"
                                            Width="100%" CssClass="grid-Border" AllowSorting="True" PageSize="20" AllowPaging="True" OnRowDataBound="GridView1_RowDataBound">
                                            <HeaderStyle CssClass="grid-header1" /> 
                                            <RowStyle CssClass ="grid-item" />
                                            <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                            <PagerStyle CssClass="grid-paper" /> 
                                            <FooterStyle CssClass="grid-footer" />                                  
                                            <PagerSettings PageButtonCount="30" />
                                            <Columns>
                                                <asp:TemplateField HeaderText="Th&#224;nh tiền" SortExpression="RealIncome">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbRealIncome" runat="server" CssClass="value-bold"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Thuế TN" SortExpression="TienThuong">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTienThuong" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Bổ sung lương" SortExpression="BoSungLuong">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbBoSungLuong" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Lương năng suất" SortExpression="LNS">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbLNS" runat="server" ></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Họ T&#234;n" SortExpression="FullName">
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" Width="200px"/>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="odsEmployeeIncomes_Selecting"
                                            SelectMethod="GetAllByFilter" TypeName="HRMBLL.H.EmployeeIncomeBLL" OldValuesParameterFormatString="original_{0}">
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
                            </table>
                        </td>
                    </tr>
                </table>    
            </td>
        </tr>
    </table>
</asp:Content>

