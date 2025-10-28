<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ChangingLCBCoefficientList.aspx.cs" Inherits="Coefficients_ChangingLCBCoefficientList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc3" %>
<%@ Register Src="~/UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
    <tr>
        <td valign="top"  colspan="2">
            <uc3:ucTitle ID="UcTitle1" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
             <uc4:ActionMenu ID="ActionMenu1" runat="server" />
        </td>
        <td align="right">
             <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
        &nbsp;
            <asp:Label ID="lbDepartment" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
            <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList" DataSourceID="odsDepartments" DataTextField="DepartmentName" DataValueField="DepartmentId" Width="200px">
            </asp:DropDownList>&nbsp; 
            <asp:Label ID="Label2" runat="server" CssClass="label" Text="Ngày"></asp:Label>&nbsp;<asp:DropDownList
                ID="ddlDays" runat="server" CssClass="dropDownList" AppendDataBoundItems="True">                
                <asp:ListItem Value="0" Text=""></asp:ListItem>
            </asp:DropDownList><asp:DropDownList
                ID="ddlMonths" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlMonths_SelectedIndexChanged">
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
            </asp:DropDownList><asp:DropDownList
                ID="ddlYears" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlYears_SelectedIndexChanged">
            </asp:DropDownList>&nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Icon-Search.gif" OnClick="ImageButton1_Click" />
            <asp:ObjectDataSource ID="odsDepartments" runat="server" OldValuesParameterFormatString="original_{0}"
                SelectMethod="GetAllRoots" TypeName="HRMBLL.H0.DepartmentsBLL"></asp:ObjectDataSource>
        </td>            
    </tr>
    <tr>
        <td valign="top" colspan="2">
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
                                                    <asp:GridView ID="grdLCBRemind" runat="server" AutoGenerateColumns="False" DataSourceID="odsLCBRemind" CssClass="grid-Border" OnRowDataBound="grdLCBRemind_RowDataBound" Width="100%">
                                                       <Columns>
                                                           <asp:TemplateField HeaderText="Họ t&#234;n" SortExpression="FullName">
                                                               <ItemTemplate>
                                                                   <asp:HyperLink ID="lnkFullName" runat="server" Text='<%# Bind("FullName") %>' CssClass="hyperlink-Grid"></asp:HyperLink>
                                                               </ItemTemplate>
                                                           </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Chức danh hệ số" SortExpression="CoefficientName">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbCoefficientName" runat="server" Text='<%# Bind("CoefficientName") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Left" />
                                                                <HeaderStyle HorizontalAlign="Left" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Bậc" SortExpression="CoefficientLevelName">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("CoefficientLevelName") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Hệ số" SortExpression="CoefficientValue">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("CoefficientValue") %>'></asp:Label>
                                                                    <%--<asp:Label ID="grd_lbConditions" runat="server" CssClass="value" Text='<%# Bind("Conditions") %>'></asp:Label>--%>
                                                                </ItemTemplate>
                                                                 <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:TemplateField>
                                                             <asp:TemplateField HeaderText="Hưởng" SortExpression="Wages">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbLCBWages" runat="server" Text='<%# Bind("LCBWages") %>'></asp:Label><asp:Label ID="lbLCBUnitName" runat="server" Text='<%# Bind("LCBUnitName") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                 <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:TemplateField>
                                                            
                                                            <asp:TemplateField HeaderText="Từ ng&#224;y" SortExpression="FromDate">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="Label4" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "FromDate", "{0:dd/MM/yyyy}")%>'></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:TemplateField>                                                            
                                                            <asp:TemplateField HeaderText="Đến ng&#224;y" SortExpression="ToDate">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbToDate" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "ToDate", "{0:dd/MM/yyyy}")%>'></asp:Label>
                                                                </ItemTemplate>
                                                                 <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:TemplateField>
                                                        </Columns>
                                                         <HeaderStyle CssClass="grid-header" /> 
                                                         <RowStyle CssClass ="grid-item" />
                                                         <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                                         <PagerStyle CssClass="grid-paper" /> 
                                                         <EmptyDataTemplate>
                                                            <asp:Label ID="Label14" runat="server" CssClass="value" Text="Không có dữ liệu."></asp:Label>
                                                         </EmptyDataTemplate>    
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                        </table>
                                        <asp:ObjectDataSource ID="odsLCBRemind" runat="server" SelectMethod="RemindLCBCoefficient" TypeName="HRMBLL.H1.LCBCoefficientEmployeeBLL" OnSelecting="odsLCBRemind_Selecting">
                                            <SelectParameters>
                                                <asp:Parameter Name="fullName" Type="String" />
                                                <asp:Parameter Name="deptId" Type="Int32" />
                                                <asp:Parameter Name="day" Type="Int32" />
                                                <asp:Parameter Name="month" Type="Int32" />
                                                <asp:Parameter Name="year" Type="Int32" />
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
                                        <asp:GridView ID="grdChanging" runat="server" AutoGenerateColumns="False" DataSourceID="odsChanging" CssClass="grid-Border" OnRowDataBound="grdChanging_RowDataBound" Width="100%">
                                           <Columns>
                                               <asp:TemplateField HeaderText="Họ t&#234;n" SortExpression="FullName">
                                                   <ItemTemplate>
                                                       <asp:HyperLink ID="lnkFullName" runat="server" Text='<%# Bind("FullName") %>' CssClass="hyperlink-Grid"></asp:HyperLink>
                                                   </ItemTemplate>
                                               </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Chức danh hệ số" SortExpression="CoefficientName">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbCoefficientName" runat="server" Text='<%# Bind("CoefficientName") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Bậc" SortExpression="CoefficientLevelName">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("CoefficientLevelName") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Hệ số" SortExpression="CoefficientValue">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("CoefficientValue") %>'></asp:Label>
                                                        <asp:Label ID="grd_lbConditions" runat="server" CssClass="value" Text='<%# Bind("Conditions") %>'></asp:Label>
                                                    </ItemTemplate>
                                                     <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                 <asp:TemplateField HeaderText="Hưởng" SortExpression="Wages">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbLCBWages" runat="server" Text='<%# Bind("LCBWages") %>'></asp:Label><asp:Label ID="lbLCBUnitName" runat="server" Text='<%# Bind("LCBUnitName") %>'></asp:Label>
                                                    </ItemTemplate>
                                                     <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                
                                                <asp:TemplateField HeaderText="Từ ng&#224;y" SortExpression="FromDate">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label4" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "FromDate", "{0:dd/MM/yyyy}")%>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>                                                            
                                                <asp:TemplateField HeaderText="Đến ng&#224;y" SortExpression="ToDate">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label5" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "ToDate", "{0:dd/MM/yyyy}")%>'></asp:Label>
                                                    </ItemTemplate>
                                                     <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                            </Columns>
                                             <HeaderStyle CssClass="grid-header" /> 
                                             <RowStyle CssClass ="grid-item" />
                                             <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                             <PagerStyle CssClass="grid-paper" /> 
                                             <EmptyDataTemplate>
                                                <asp:Label ID="Label14" runat="server" CssClass="value" Text="Không có dữ liệu"></asp:Label>
                                             </EmptyDataTemplate>    
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                            <asp:ObjectDataSource ID="odsChanging" runat="server" OnSelecting="odsChanging_Selecting" SelectMethod="ChangedLCBCoefficient" TypeName="HRMBLL.H1.LCBCoefficientEmployeeBLL">
                                <SelectParameters>
                                    <asp:Parameter Name="fullName" Type="String" />
                                    <asp:Parameter Name="deptId" Type="Int32" />
                                    <asp:Parameter Name="day" Type="Int32" />
                                    <asp:Parameter Name="month" Type="Int32" />
                                    <asp:Parameter Name="year" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </fieldset>                        
                    </td>    
                </tr>
                
            </table>
        </td>
    </tr>
 </table>
</asp:Content>

