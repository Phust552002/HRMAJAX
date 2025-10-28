<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Positions.aspx.cs" Inherits="Employee_Positions" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

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
                            <fieldset>
                                <legend class="legend">Danh sách chức danh</legend>
                                 <table width="100%">
                                        <tr>
                                            <td>
                                             <asp:Label ID="Label7" runat="server" CssClass="label" Text="Tên chức danh"></asp:Label>
                                                <asp:TextBox ID="txtPositionNameFilter" runat="server" CssClass="textBox" Width="100px"></asp:TextBox>
                                                &nbsp;
                                                <asp:Label ID="Label8" runat="server" CssClass="label" Text="Phòng"></asp:Label>
                                                <asp:DropDownList ID="ddlDepartmentFilter" runat="server" CssClass="dropDownList" Width="200px">
                                                </asp:DropDownList>
                                                &nbsp;&nbsp;
                                                <asp:Label ID="Label9" runat="server" CssClass="label" Text="Cấp chức danh"></asp:Label>
                                                <asp:DropDownList ID="ddlLevelPositionFilter" runat="server" CssClass="dropDownList" Width="100px" AppendDataBoundItems="true">
                                                <asp:ListItem Value="0" Text=""></asp:ListItem>
                                                </asp:DropDownList>
                                                &nbsp;
                                                <asp:ImageButton ID="imgBtnSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif" OnClick="imgBtnSearch_Click" /></td>
                                        </tr>
                                        <tr>
                                            <td>  
                                <table style="width: 100%" class="tableBorder">                        
                                    <tr>
                                        <td>
                                            <asp:GridView ID="grdPositions" runat="server" AutoGenerateColumns="False" DataSourceID="odsPosition" DataKeyNames="PositionId" OnRowUpdated="grdPositions_RowUpdated" AllowPaging="True" PageSize="20" CssClass="grid-Border" Width="100%" OnRowCancelingEdit="grdPositions_RowCancelingEdit" OnRowDataBound="grdPositions_RowDataBound">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="Chức danh" SortExpression="PositionName">
                                                        <EditItemTemplate>
                                                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("PositionName") %>' CssClass ="textBox" Width="90%"></asp:TextBox>
                                                        </EditItemTemplate>
                                                        <ItemTemplate>
                                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("PositionName") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Cấp chức danh" SortExpression="LevelPosition">
                                                        <EditItemTemplate>
                                                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropDownList" DataSourceID="ObjectDataSource1"
                                                                DataTextField="UnitName" DataValueField="UnitId" SelectedValue='<%# Bind("LevelPosition") %>'>
                                                            </asp:DropDownList>&nbsp;<asp:ObjectDataSource ID="ObjectDataSource1" runat="server"
                                                                SelectMethod="GetAllLevelPosition" TypeName="HRMUtil.Constants"></asp:ObjectDataSource>
                                                        </EditItemTemplate>
                                                        <ItemTemplate>
                                                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("LevelPositionName") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Ph&#242;ng" SortExpression="DepartmentName">
                                                        <EditItemTemplate>
                                                            &nbsp;<asp:DropDownList ID="DropDownList2" runat="server" CssClass="dropDownList"
                                                                DataSourceID="ObjectDataSource2" DataTextField="DepartmentName" DataValueField="DepartmentId"
                                                                SelectedValue='<%# Bind("DepartmentId") %>'>
                                                            </asp:DropDownList>
                                                            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllRoots"
                                                                TypeName="HRMBLL.H0.DepartmentsBLL"></asp:ObjectDataSource>
                                                        </EditItemTemplate>
                                                        <ItemTemplate>
                                                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("DepartmentName") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="M&#244; tả" SortExpression="Description">
                                                        <EditItemTemplate>
                                                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Description") %>' CssClass ="textBox" Width="90%"></asp:TextBox>&nbsp;
                                                        </EditItemTemplate>
                                                        <ItemTemplate>
                                                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
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
                                            <asp:ObjectDataSource ID="odsPosition" runat="server" SelectMethod="GetByFilter" TypeName="HRMBLL.H0.PositionsBLL" UpdateMethod="Update" DeleteMethod="Delete" OnSelecting="odsPosition_Selecting">
                                                <UpdateParameters>
                                                    <asp:Parameter Name="positionId" Type="Int32" />
                                                    <asp:Parameter Name="positionName" Type="String" />
                                                    <asp:Parameter Name="description" Type="String" />
                                                    <asp:Parameter Name="levelPosition" Type="Int32" />
                                                    <asp:Parameter Name="departmentId" Type="Int32" />
                                                </UpdateParameters>
                                                <DeleteParameters>
                                                    <asp:Parameter Name="positionId" Type="Int32" />
                                                </DeleteParameters>
                                                <SelectParameters>
                                                    <asp:Parameter Name="positionName" Type="String" />
                                                    <asp:Parameter Name="levelPosition" Type="Int32" />
                                                    <asp:Parameter Name="departmentId" Type="Int32" />
                                                </SelectParameters>
                                            </asp:ObjectDataSource>
                                        </td>
                                    </tr>
                                </table>     
                                            </td>
                                        </tr>
                                  </table>      
                            </fieldset>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <fieldset>
                                <legend class="legend">Định Nghĩa Chức Danh</legend>
                                                                                 
                                            <table style="width: 100%;" class="tableBorder">
                                                <tr>
                                                    <td class="tdLabel">
                                                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Chức danh"></asp:Label></td>
                                                    <td class="tdValue">
                                                        <asp:TextBox ID="txtPositionName" runat="server" Width="200px" CssClass="textBox"></asp:TextBox></td>
                                                </tr>
                                                <tr>
                                                    <td class="tdLabel">
                                                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Phòng"></asp:Label></td>
                                                    <td class="tdValue">
                                                        <asp:DropDownList ID="ddlDepartments" runat="server" CssClass="dropDownList">
                                                        </asp:DropDownList></td>
                                                </tr>
                                                <tr>
                                                    <td class="tdLabel">
                                                        <asp:Label ID="Label6" runat="server" CssClass="label" Text="Cấp chức danh"></asp:Label></td>
                                                    <td class="tdValue">
                                                        <asp:DropDownList ID="ddlLevelPosition" runat="server" CssClass="dropDownList">
                                                        </asp:DropDownList></td>
                                                </tr>
                                                <tr>
                                                    <td class="tdLabel">
                                                        <asp:Label ID="Label10" runat="server" CssClass="label" Text="Loại"></asp:Label></td>
                                                    <td class="tdValue">
                                                        <asp:DropDownList ID="ddlPositionType" runat="server" CssClass="dropDownList">
                                                        </asp:DropDownList></td>
                                                </tr>
                                                <tr>
                                                    <td class="tdLabel">
                                                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Mô tả"></asp:Label></td>
                                                    <td class="tdValue">
                                                        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Width="300px" CssClass="textBox"></asp:TextBox></td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2" class="tdButton" align="center">
                                                         <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Thêm Mới" CssClass="small color green button" Width="100px" />
                                                        &nbsp;
                                                                    <asp:Button ID="btnCancel" runat="server" Text="Thoát" CssClass="small color green button" Width="100px" />
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

