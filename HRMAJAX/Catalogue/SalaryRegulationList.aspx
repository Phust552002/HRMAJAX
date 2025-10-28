<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="SalaryRegulationList.aspx.cs" Inherits="Catalogue_SalaryRegulationList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
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
                                    <legend class="legend">Thêm Mới Bảng Quy Chế Lương</legend>                               
                                    <table style="width: 100%" class="tableBorder">
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tên bảng quy chế"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:TextBox ID="txtSalaryRegulation" runat="server" Width="400px" CssClass="textBox"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label6" runat="server" CssClass="label" Text="Ngày bắt đầu áp dụng"></asp:Label></td>
                                            <td class="tdValue">
                                                <uc3:CalendarPicker ID="cpBeginingDate" runat="server" />
                                                </td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label4" runat="server" CssClass="label" Text="Mô tả"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Width="400px" CssClass="textBox" Rows="4"></asp:TextBox></td>
                                        </tr>
                                         <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label5" runat="server" CssClass="label" Text="Loại"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:DropDownList ID="ddlType" runat="server" CssClass="dropDownList">
                                                </asp:DropDownList></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Đang sử dụng"></asp:Label>
                                            </td>
                                            <td class="tdValue">
                                                <asp:CheckBox ID="chkInUse" runat="server" /></td>
                                        </tr>
                                       
                                        <tr>
                                            <td colspan="2" class="tdButton" align="center" style="height: 23px">
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
                                <legend class="legend">Danh Sách Quản Lý Bảng Quy Chế Lương</legend>
                                <table style="width: 100%" >
                                    <tr>
                                        <td>
                                            <table style="width: 100%" class="tableBorder">
                                                <tr>
                                                    <td>
                                                        <asp:GridView ID="grdSalaryRegulation" runat="server" DataSourceID="odsSalaryRegulation" AutoGenerateColumns="False" Width="100%" CssClass="grid-Border" DataKeyNames="SalaryRegulationId">
                                                            <Columns>
                                                                <asp:TemplateField HeaderText="T&#234;n bảng quy chế" SortExpression="SalaryRegulationName">
                                                                    <EditItemTemplate>
                                                                        <asp:TextBox ID="SalaryRegulationName" runat="server" Text='<%# Bind("SalaryRegulationName") %>' CssClass="textBox" Width="99%"></asp:TextBox>
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("SalaryRegulationName") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Ng&#224;y &#225;p dụng" SortExpression="BeginingDate">
                                                                    <EditItemTemplate>
                                                                        <uc3:CalendarPicker ID="CalendarPicker1" runat="server" SelectedDate='<%# Bind("BeginingDate") %>'/>                                                                        
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("BeginingDate", "{0:dd/MM/yyyy}") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="M&#244; tả" SortExpression="Description">
                                                                    <EditItemTemplate>
                                                                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Description") %>' CssClass="textBox" Width="99%"></asp:TextBox>
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Loại" SortExpression="TypeName">
                                                                    <EditItemTemplate>
                                                                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropDownList" DataSourceID="ObjectDataSource1"
                                                                            DataTextField="RTypeName" DataValueField="RTypeId" SelectedValue='<%# Bind("TypeId") %>'>
                                                                        </asp:DropDownList>
                                                                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllSalaryRegulationType"
                                                                            TypeName="HRMUtil.Constants"></asp:ObjectDataSource>
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("TypeName") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Đang sử dụng" SortExpression="InUse">
                                                                    <EditItemTemplate>
                                                                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("InUse") %>' />
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("InUse") %>' Enabled="false" />
                                                                    </ItemTemplate>
                                                                    <ItemStyle HorizontalAlign="Center" />
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
                                                        <asp:ObjectDataSource ID="odsSalaryRegulation" runat="server" SelectMethod="GetByFilter" TypeName="HRMBLL.H1.SalaryRegulationBLL" DeleteMethod="Delete" UpdateMethod="Update" OldValuesParameterFormatString="original_{0}" OnSelecting="odsSalaryRegulation_Selecting">
                                                            <DeleteParameters>
                                                                <asp:Parameter Name="salaryRegulationId" Type="Int32" />
                                                            </DeleteParameters>
                                                            <UpdateParameters>
                                                                <asp:Parameter Name="salaryRegulationName" Type="String" />
                                                                <asp:Parameter Name="beginingDate" Type="DateTime" />
                                                                <asp:Parameter Name="description" Type="String" />
                                                                <asp:Parameter Name="inUse" Type="Boolean" />
                                                                <asp:Parameter Name="typeId" Type="Int32" />
                                                                <asp:Parameter Name="salaryRegulationId" Type="Int32" />
                                                            </UpdateParameters>
                                                            <SelectParameters>
                                                                <asp:Parameter Name="typeId" Type="Int32" />
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
                    
                </table>
            </td>
        </tr>
</table>
</asp:Content>

