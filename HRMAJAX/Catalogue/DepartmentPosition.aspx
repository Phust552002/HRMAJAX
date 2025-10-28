<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="DepartmentPosition.aspx.cs" Inherits="Catalogue_DepartmentPosition" Title="Untitled Page" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc1" %>


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
                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Phòng"></asp:Label>&nbsp;
                        <asp:DropDownList ID="ddlDepartmentFilter" runat="server" CssClass="dropDownList" DataSourceID="ObjectDataSource2"
                            DataTextField="DepartmentName" DataValueField="DepartmentId">
                        </asp:DropDownList>
                        <asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif"
                            OnClick="imgSearch_Click" />
                        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllRoots"
                            TypeName="HRMBLL.H0.DepartmentsBLL"></asp:ObjectDataSource>
                    </td>
                </tr>
                
                <tr>
                    <td valign="top">
                       <table style="width: 100%" class="tableBorder">                        
                                <tr>
                                    <td>
                                        <asp:GridView ID="grdPositions" runat="server" AutoGenerateColumns="False" DataSourceID="odsDepartmentPosition" OnRowUpdated="grdPositions_RowUpdated" AllowPaging="True" PageSize="20" CssClass="grid-Border" Width="100%" OnRowCancelingEdit="grdPositions_RowCancelingEdit" DataKeyNames="DeptPositionId">
                                            <Columns>
                                                <asp:TemplateField HeaderText="Chức danh c&#244;ng việc" SortExpression="PositionName">
                                                    <EditItemTemplate>
                                                        &nbsp;<asp:DropDownList ID="DropDownList2" runat="server" CssClass="dropDownList"
                                                            DataSourceID="ObjectDataSource3" DataTextField="PositionName" DataValueField="PositionId"
                                                            Enabled="False" SelectedValue='<%# Bind("PositionId") %>'>
                                                        </asp:DropDownList>
                                                        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" OldValuesParameterFormatString="original_{0}"
                                                            SelectMethod="GetALlPositions" TypeName="HRMBLL.PositionsBLL"></asp:ObjectDataSource>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("PositionName") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Thuộc ph&#242;ng" SortExpression="DepartmentName">
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropDownList" DataSourceID="ObjectDataSource1"
                                                            DataTextField="DepartmentName" DataValueField="DepartmentId" SelectedValue='<%# Bind("DepartmentId") %>' AppendDataBoundItems="true">
                                                            <asp:ListItem Value="0" Text=""></asp:ListItem>
                                                        </asp:DropDownList>
                                                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllRootsNoSAGS"
                                                            TypeName="HRMBLL.H0.DepartmentsBLL"></asp:ObjectDataSource>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("DepartmentName") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                 <asp:TemplateField HeaderText="Thao t&#225;c" ShowHeader="False">
                                                    <EditItemTemplate>
                                                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="True" CommandName="Update" ImageUrl="~/Images/icon-save.gif"/>
                                                        <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Cancel" ImageUrl="~/Images/icon-cancel.gif"/>
                                                    </EditItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" Width="15%" />
                                                    <ItemTemplate>
                                                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Edit" ImageUrl="~/Images/icon-edit.gif"/>
                                                        <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/Images/icon-delete.gif" OnClientClick="return confirm('Bạn có muốn xóa thông tin này không?');"/>
                                                    </ItemTemplate>
                                                </asp:TemplateField> 
                                            </Columns>
                                            <HeaderStyle CssClass="grid-header" /> 
                                            <RowStyle CssClass ="grid-item" />
                                            <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                            <PagerStyle CssClass="grid-paper" /> 
                                        </asp:GridView>
                                        <asp:ObjectDataSource ID="odsDepartmentPosition" runat="server" SelectMethod="GetByFilter" TypeName="HRMBLL.H0.DepartmentPositionBLL" OnSelecting="odsDepartmentPosition_Selecting" UpdateMethod="Update" DeleteMethod="Delete">
                                            <SelectParameters>
                                                <asp:Parameter Name="departmentId" Type="Int32" />
                                                <asp:Parameter Name="positionId" Type="Int32" />
                                            </SelectParameters>
                                            <UpdateParameters>
                                                <asp:Parameter Name="departmentId" Type="Int32" />
                                                <asp:Parameter Name="positionId" Type="Int32" />
                                                <asp:Parameter Name="deptPositionId" Type="Int32" />
                                                <asp:Parameter Name="PositionName" Type="String" />
                                            </UpdateParameters>
                                            <DeleteParameters>
                                                <asp:Parameter Name="deptPositionId" Type="Int32" />
                                            </DeleteParameters>
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
</asp:Content>

