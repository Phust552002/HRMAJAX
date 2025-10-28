<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="RelationTypeList.aspx.cs" Inherits="Catalogue_RelationTypeList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc3" %>

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
                        <td valign="top" align="right">
                            <asp:CheckBox ID="chkHide" runat="server" Text="Thêm mới" CssClass="value" OnCheckedChanged="chkHide_CheckedChanged" AutoPostBack="True"/><br/>
                            <asp:Panel ID="pnAdd" runat="server" Width="100%" Visible="false">                            
                                <fieldset>
                                    <legend class="legend">Thêm mới mối quan hệ trong gia đình</legend>                               
                                    <table style="width: 100%" class="tableBorder">
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tên mối quan hệ"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:TextBox ID="txtRelationTypeName" runat="server" Width="200px" CssClass="textBox"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label4" runat="server" CssClass="label" Text="Mô tả"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Width="300px" CssClass="textBox"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Thuộc bên"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:DropDownList ID="ddlType" runat="server" CssClass="dropDownList" DataSourceID="ObjectDataSource1" DataTextField="RTypeName" DataValueField="RTypeId">
                                                </asp:DropDownList>
                                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllRType"
                                                    TypeName="HRMUtil.Constants"></asp:ObjectDataSource>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" class="tdButton">
                                                <asp:Button ID="btnAdd" runat="server" Text="Thêm Mới" CssClass="small color green button" Width="100px" OnClick="btnAdd_Click" />                                                 
                                            </td>
                                            
                                        </tr>
                                    </table>                                       
                                </fieldset>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <fieldset>
                                <legend class="legend">Danh sách các mối quan hệ trong gia đình</legend>
                                <table style="width: 100%" >
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="Label2" runat="server" CssClass="label" Text="Tên mối quan hệ"></asp:Label>
                                            <asp:TextBox ID="txtRelationTypeNameFilter" runat="server" CssClass="textBox"></asp:TextBox>&nbsp;
                                            &nbsp;<asp:Label ID="Label5" runat="server" CssClass="label" Text="Thuộc bên"></asp:Label>
                                            <asp:DropDownList ID="ddlTypeFilter" runat="server" DataSourceID="ObjectDataSource2" DataTextField="RTypeName" DataValueField="RTypeId" CssClass="dropDownList">
                                            </asp:DropDownList>
                                            &nbsp;
                                            <asp:Button ID="btnSearch" runat="server" Text="Tìm" OnClick="btnSearch_Click" CssClass="small color green button"/>
                                            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllRTypeN"
                                                TypeName="HRMUtil.Constants"></asp:ObjectDataSource>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table style="width: 100%" class="tableBorder">
                                                <tr>
                                                    <td>
                                                        <asp:GridView ID="grdRelationTypes" runat="server" DataSourceID="odsRelationType" DataKeyNames="RelationTypeId" AutoGenerateColumns="False" Width="100%" CssClass="grid-Border">
                                                            <Columns>
                                                                <asp:TemplateField HeaderText="T&#234;n mối quan hệ" SortExpression="RelationTypeName">
                                                                    <EditItemTemplate>
                                                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("RelationTypeName") %>'
                                                                            Width="98%" CssClass="textBox"></asp:TextBox>
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("RelationTypeName") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                    <ItemStyle Width="25%" />
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Thuộc b&#234;n" SortExpression="TypeName">
                                                                    <EditItemTemplate>
                                                                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource3"
                                                                            DataTextField="RTypeName" DataValueField="RTypeId" SelectedValue='<%# Bind("Type")%>' CssClass="dropDownList">
                                                                        </asp:DropDownList>
                                                                        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetAllRType"
                                                                            TypeName="HRMUtil.Constants"></asp:ObjectDataSource>
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("TypeName") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                    <ItemStyle Width="25%" />
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="M&#244; tả" SortExpression="Description">
                                                                    <EditItemTemplate>
                                                                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Description") %>'
                                                                            Width="100%" CssClass="textBox"></asp:TextBox>
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                    <ItemStyle Width="40%" />
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
                                                        <asp:ObjectDataSource ID="odsRelationType" runat="server" SelectMethod="GetByFilter" TypeName="HRMBLL.H0.RelationTypesBLL" OnSelecting="odsRelationType_Selecting" DeleteMethod="Delete" UpdateMethod="Update">
                                                            <SelectParameters>
                                                                <asp:Parameter Name="relationTypeName" Type="String" />
                                                                <asp:Parameter Name="type" Type="Int32" />
                                                            </SelectParameters>
                                                            <DeleteParameters>
                                                                <asp:Parameter Name="relationTypeId" Type="Int32" />
                                                            </DeleteParameters>
                                                            <UpdateParameters>
                                                                <asp:Parameter Name="relationTypeName" Type="String" />
                                                                <asp:Parameter Name="description" Type="String" />
                                                                <asp:Parameter Name="type" Type="Int32" />
                                                                <asp:Parameter Name="relationTypeId" Type="Int32" />
                                                            </UpdateParameters>
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
                    
                </table>
            </td>
        </tr>
</table>
</asp:Content>

