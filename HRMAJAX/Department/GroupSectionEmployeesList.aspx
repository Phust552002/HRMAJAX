<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="GroupSectionEmployeesList.aspx.cs" Inherits="Department_GroupSectionEmployeesList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"
    TagPrefix="uc1" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
    <tr>
        <td valign="top" >
            <table style="width: 100%">
                <tr>
                    <td valign="top">
                        <uc2:ucTitle ID="UcTitle1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td valign="top">
                        <table style="width: 100%"> 
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
                                                    </asp:DropDownList>&nbsp; &nbsp;&nbsp;<asp:Button ID="imgSearch" runat="server"
                                                        Text="Xem" CssClass="small color green button" OnClick="imgSearch_Click" />
                                                &nbsp;
                                            </td>
                                        </tr>
                                        
                                    </table>
                                       <table style="width: 100%" class="tableBorder">
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" CssClass="grid-Border" AllowPaging="True" PageSize="20" OnRowDataBound="GridView1_RowDataBound" DataSourceID="ObjectDataSource1">
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="M&#227; Nh&#226;n Vi&#234;n" SortExpression="UserId">                                                               
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbUserId" runat="server"></asp:Label>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="EmployeeCode" HeaderText="M&#227; SAC" SortExpression="EmployeeCode">
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:BoundField>
                                                            <asp:TemplateField HeaderText="Họ T&#234;n" SortExpression="FullName">
                                                                <ItemStyle HorizontalAlign="Left" />
                                                                <HeaderStyle HorizontalAlign="Left" />
                                                                <ItemTemplate>
                                                                    <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="DepartmentFullName" HeaderText="Ph&#242;ng" SortExpression="DepartmentFullName">
                                                                <ItemStyle HorizontalAlign="Left" />
                                                                <HeaderStyle HorizontalAlign="Left" />
                                                            </asp:BoundField>
                                                            <asp:TemplateField HeaderText="Ng&#224;y Sinh" SortExpression="Birthday">                                                             
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbBirthday" runat="server"></asp:Label>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                           
                                                        </Columns>
                                                        <HeaderStyle CssClass="grid-header" /> 
                                                        <RowStyle CssClass ="grid-item" />
                                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                                        <PagerStyle CssClass="grid-paper" />  
                                                        <PagerSettings PageButtonCount="30" />
                                                    </asp:GridView>                                                    
                                                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting"
                                                        SelectMethod="GetByDeptIds" TypeName="HRMBLL.H0.EmployeesBLL" OnSelected="ObjectDataSource1_Selected" SortParameterName="sortParameter" OldValuesParameterFormatString="original_{0}">
                                                        <SelectParameters>
                                                            <asp:Parameter Name="deptIds" Type="String" />
                                                            <asp:Parameter Name="rootId" Type="Int32" />
                                                            <asp:Parameter Name="fullname" Type="String" />
                                                            <asp:Parameter Name="sortParameter" Type="String" />
                                                            <asp:Parameter Name="AirlinesWorking" Type="String" />
                                                        </SelectParameters>
                                                    </asp:ObjectDataSource>
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
        </td>    
     </tr>
</table>
</asp:Content>



