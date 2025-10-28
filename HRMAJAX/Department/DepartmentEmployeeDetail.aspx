<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="DepartmentEmployeeDetail.aspx.cs" Inherits="Department_DepartmentEmployeeDetail" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>

<%@ Register Src="../Employee/UserControls/ucListBoxUsers.ascx" TagName="ucListBoxUsers" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td colspan="2">
                <uc2:ucTitle ID="UcTitle1" runat="server" />
            </td>
        </tr>
        <tr>
            <td valign="top">
                <table class="tableBorder">
                <tr>
                    <td style="width: 348px">
                        <uc1:ucListBoxUsers id="UcListBoxUsers1" runat="server">
                        </uc1:ucListBoxUsers>
                    </td>
                </tr>
                <tr>
                    <td class="tdButton" align="center" style="width: 348px" >                         &nbsp;
                        &nbsp;&nbsp;
                        <asp:Button ID="btnCancel" runat="server" Text="Thoát" CssClass="small color green button" Width="100px" OnClick="btnCancel_Click" /></td>
                </tr>    
             </table>
            </td> 
            <td valign="top">
                <fieldset>
                <legend class="legend"><asp:Label ID="lbDepartmentName" runat="server" Text="Label"></asp:Label></legend>
                <table width="100%" class="tableBorder">
                    <tr>
                        <td>                        
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CssClass="grid-Border" Width="100%">
                                <Columns>
                                    <asp:BoundField DataField="UserName" HeaderText="T&#234;n truy cập" SortExpression="UserName" />
                                    <asp:BoundField DataField="DepartmentName" HeaderText="Ph&#242;ng ban" SortExpression="DepartmentName" />
                                    <asp:BoundField DataField="FullName" HeaderText="Họ v&#224; t&#234;n" SortExpression="FullName" />
                                </Columns>
                                 <HeaderStyle CssClass="grid-header" /> 
                                <RowStyle CssClass ="grid-item" />
                                <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                <PagerStyle CssClass="grid-paper" />  
                                <PagerSettings PageButtonCount="30" />
                            </asp:GridView>
                            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetByRootId"
                                TypeName="HRMBLL.H0.EmployeesBLL" OnSelected="ObjectDataSource1_Selected" OldValuesParameterFormatString="original_{0}">
                                <SelectParameters>
                                    <asp:QueryStringParameter Name="rootId" QueryStringField="RId" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </td>
                    </tr>
                </table>
                </fieldset>
            </td>            
        </tr>
    </table>
</asp:Content>

