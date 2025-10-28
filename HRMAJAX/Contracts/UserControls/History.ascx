<%@ Control Language="C#" AutoEventWireup="true" CodeFile="History.ascx.cs" Inherits="Contracts_UserControls_History" %>
<%@ Register Src="../../UserControls/CalendarPicker.ascx" TagName="CalendarPicker"
    TagPrefix="uc3" %>
<%@ Register Src="../../UserControls/DatePicker.ascx" TagName="DatePicker" TagPrefix="uc2" %>
<%@ Register Src="../../UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc1" %>
<table style="width: 100%">                        
    <tr>
        <td>
            <uc1:MessageError ID="MessageError1" runat="server" />
        </td>
    </tr>
    <tr>
        <td>  
            <table class="tableBorder" width="100%">
                <tr>
                    <td>            
                        <asp:GridView ID="grdHistoryContracts" runat="server" AutoGenerateColumns="False" DataSourceID="odsHistoryContracts" DataKeyNames="EmployeeContractId" OnRowUpdated="grdHistoryContracts_RowUpdated" OnRowDeleted="grdHistoryContracts_RowDeleted" CssClass="grid-Border" Width="100%"  OnRowEditing="grdHistoryContracts_RowEditing" OnRowDataBound="grdHistoryContracts_RowDataBound">
                            <Columns>
                                <asp:TemplateField HeaderText="Chức danh c&#244;ng việc" SortExpression="PositionName">
                                    <EditItemTemplate>
                                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1"
                                            DataTextField="PositionName" DataValueField="PositionId" SelectedValue='<%# Bind("PositionId") %>' CssClass="dropDownList">
                                        </asp:DropDownList>
                                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAll"
                                            TypeName="HRMBLL.H0.PositionsBLL"></asp:ObjectDataSource>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("PositionName") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Lọai hợp đồng" SortExpression="ContractTypeName">
                                    <EditItemTemplate>
                                        <asp:DropDownList ID="grd_ddlContractTypes" runat="server" DataSourceID="grd_odsContractTypes"
                                            DataTextField="ContractTypeName" DataValueField="ContractTypeId" SelectedValue='<%# Bind("ContractTypeId") %>' CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="grd_ddlContractTypes_SelectedIndexChanged">
                                        </asp:DropDownList>
                                        <asp:ObjectDataSource ID="grd_odsContractTypes" runat="server" SelectMethod="GetAll"
                                            TypeName="HRMBLL.H0.ContractTypesBLL"></asp:ObjectDataSource>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("ContractTypeName") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Gi&#225; trị" SortExpression="Wages">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Wages") %>' CssClass="textBox" Width="50px"></asp:TextBox> <asp:DropDownList ID="DropDownList2" runat="server" CssClass="dropDownList" SelectedValue='<%# Bind("Unit") %>' DataSourceID="ObjectDataSource2" DataTextField="UnitName" DataValueField="UnitId">
                                        </asp:DropDownList>
                                        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllUnit"
                                            TypeName="HRMUtil.Constants"></asp:ObjectDataSource>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("Wages") %>'></asp:Label><asp:Label ID="Label7" runat="server" Text='<%# Bind("UnitName") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                              
                                <asp:TemplateField HeaderText="Từ ng&#224;y" SortExpression="FromDate">
                                    <EditItemTemplate>                                        
                                        <table cellpadding="0" cellspacing="0">
                                            <tr>
                                                <td>
                                                    <uc3:CalendarPicker ID="grd_dpFromDate" runat="server" SelectedDate='<%#Bind("FromDate")%>'/>
                                                </td>
                                                <td valign="top">
                                                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/icn_pen.gif"
                                                        OnClick="ImageButton1_Click" /></td>
                                            </tr>
                                        </table>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label3" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "FromDate", "{0:dd/MM/yyyy}")%>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Đến ng&#224;y" SortExpression="ToDate">
                                    <EditItemTemplate>                                       
                                        <uc3:CalendarPicker ID="grd_dpToDate" runat="server" SelectedDate='<%#Bind("ToDate")%>'/>
                                        <asp:Label ID="grd_lbNoExpire" runat="server" CssClass="value" Text="Không xác định" Visible="False"></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="grd_lbToDate" runat="server" ></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ghi ch&#250;" SortExpression="Description">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Description") %>' CssClass="textBox" Width="90%"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:CheckBoxField DataField="Active" HeaderText="C&#243; hiệu lực" SortExpression="Active" >
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:CheckBoxField>   
                                <asp:TemplateField HeaderText="Thao t&#225;c" ShowHeader="False">
                                    <EditItemTemplate>
                                        <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="True" CommandName="Update"
                                            ImageUrl="~/Images/icon-save.gif" Text="Update" />&nbsp;<asp:ImageButton ID="ImageButton3"
                                                runat="server" CausesValidation="False" CommandName="Cancel" ImageUrl="~/Images/icon-cancel.gif"/>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Edit"
                                            ImageUrl="~/Images/icon-edit.gif" Text="Edit" />&nbsp;<asp:ImageButton ID="ImageButton2"
                                                runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/Images/icon-delete.gif" OnClientClick="return confirm('Bạn có muốn xóa thông tin đã chọn ?');"/>
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
                                <asp:Label ID="Label8" runat="server" CssClass="value" Text="Chưa có thông tin hợp đồng về nhân viên này."></asp:Label>
                            </EmptyDataTemplate>
                        </asp:GridView>
                        <asp:ObjectDataSource ID="odsHistoryContracts" runat="server" SelectMethod="GetByUserId" TypeName="HRMBLL.H0.EmployeeContractBLL" DeleteMethod="Delete" UpdateMethod="Update" OnSelecting="odsHistoryContracts_Selecting" OnUpdating="odsHistoryContracts_Updating">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="userId" QueryStringField="UserId" Type="Int32" />
                            </SelectParameters>
                            <DeleteParameters>
                                <asp:Parameter Name="employeeContractId" Type="Int32" />
                            </DeleteParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="employeeContractId" Type="Int32" />
                                <asp:Parameter Name="userId" Type="Int32" />
                                <asp:Parameter Name="contractTypeId" Type="Int32" />
                                <asp:Parameter Name="positionId" Type="Int32" />
                                <asp:Parameter Name="wages" Type="Double" />
                                <asp:Parameter Name="unit" Type="Int32" />
                                <asp:Parameter Name="fromDate" Type="DateTime" />
                                <asp:Parameter Name="toDate" Type="DateTime" />
                                <asp:Parameter Name="description" Type="String" />
                                <asp:Parameter Name="active" Type="Boolean" />
                            </UpdateParameters>
                        </asp:ObjectDataSource>
                    </td>
                </tr>
            </table>        
        </td>
    </tr>
</table>