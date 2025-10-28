<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="Contracts_List" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%" class="bgEachPage">
        <tr>
            <td>
                <uc1:ucTitle ID="UcTitle1" runat="server" />
            </td>
        </tr>
        
        <tr>
            <td valign="top">
                <fieldset>
                    <legend class="legend">Danh sách các loại hợp đồng</legend>
                    <table style="width: 100%" class="tableBorder">                        
                        <tr>
                            <td>
                                <asp:GridView ID="grdContracts" runat="server" AutoGenerateColumns="False" DataSourceID="odsContractTypes" AllowPaging="True" PageSize="20" DataKeyNames="ContractTypeId" Width="100%" OnRowCancelingEdit="grdContracts_RowCancelingEdit" OnRowUpdated="grdContracts_RowUpdated" OnRowDeleted="grdContracts_RowDeleted" OnRowDataBound="grdContracts_RowDataBound" CssClass="grid-Border">
                                    <Columns>
                                        <asp:TemplateField HeaderText="M&#227; hợp đồng" SortExpression="ContractTypeCode">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ContractTypeCode") %>' CssClass="textBox" Width="90%"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("ContractTypeCode") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="T&#234;n hợp đồng" SortExpression="ContractTypeName">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ContractTypeName") %>' CssClass="textBox" Width="90%"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("ContractTypeName") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Số th&#225;ng" SortExpression="ContractTypeValue">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox3" runat="server" CssClass="textBox" Text='<%# Bind("ContractTypeValue") %>' Width="90%"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("ContractTypeValue") %>'></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Right" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="M&#244; tả" SortExpression="ContractTypeDescription">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("ContractTypeDescription") %>' CssClass="textBox" Width="90%"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("ContractTypeDescription") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:CommandField ShowEditButton="True"  HeaderText="Thao t&#225;c" ButtonType="Image" EditImageUrl="~/Images/icon-edit.gif"
                                            UpdateImageUrl="~/Images/icon-save.gif" CancelImageUrl="~/Images/icon-cancel.gif" ShowDeleteButton="True" DeleteImageUrl="~/Images/icon-delete.gif">
                                        <ItemStyle HorizontalAlign="Center" />
                                        </asp:CommandField>                                         
                                     </Columns>
                                        <HeaderStyle CssClass="grid-header" /> 
                                        <RowStyle CssClass ="grid-item" />
                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                        <PagerStyle CssClass="grid-paper" /> 
                                    <EmptyDataTemplate>
                                        <asp:Label ID="Label3" runat="server" CssClass="value" Text="Chưa có dữ liệu cho các loại hợp đồng"></asp:Label>
                                    </EmptyDataTemplate>
                                  </asp:GridView>
                                  <asp:ObjectDataSource ID="odsContractTypes" runat="server"
                                  SelectMethod="GetAll" TypeName="HRMBLL.H0.ContractTypesBLL" 
                                    DeleteMethod="Delete" UpdateMethod="Update" 
                                    onselecting="odsContractTypes_Selecting">
                                      <DeleteParameters>
                                          <asp:Parameter Name="contractTypeId" Type="Int32" />
                                      </DeleteParameters>
                                      <SelectParameters>
                                          <asp:Parameter Name="dataType" Type="Int32" />
                                      </SelectParameters>
                                      <UpdateParameters>
                                          <asp:Parameter Name="contractTypeCode" Type="String" />
                                          <asp:Parameter Name="contractTypeName" Type="String" />
                                          <asp:Parameter Name="contractTypeValue" Type="Double" />
                                          <asp:Parameter Name="ContractTypeDescription" Type="String" />
                                          <asp:Parameter Name="ContractTypeId" Type="Int32" />
                                          <asp:Parameter Name="dataType" Type="Int32" />
                                      </UpdateParameters>
                                  </asp:ObjectDataSource>
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
        <tr>
            <td>
                <fieldset>
                    <legend class="legend">Định nghĩa loại hợp đồng</legend>
                        <table class="tableBorder" style="width: 100%; margin-top:2px; margin-left:2px; margin-bottom:2px; margin-right:2px;" >
                            <tr>
                                <td class="tdLabel">
                                    <asp:Label ID="Label1" runat="server" Text="Mã loại hợp đồng" CssClass="label"></asp:Label></td>
                                <td class="tdValue">
                                    <asp:TextBox ID="txtContractTypeCode" runat="server" CssClass="textBox" Width="200px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td class="tdLabel">
                                    <asp:Label ID="Label2" runat="server" Text="Tên loại hợp đồng" CssClass="label"></asp:Label></td>
                                <td class="tdValue">
                                    <asp:TextBox ID="txtContractTypeName" runat="server" CssClass="textBox" Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="tdLabel">
                                    <asp:Label ID="Label5" runat="server" CssClass="label" Text="Số tháng của loại hợp đồng"></asp:Label></td>
                                <td class="tdValue">
                                    <asp:TextBox ID="txtContractTypeValue" runat="server" CssClass="textBox" Width="50px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td class="tdLabel">
                                    <asp:Label ID="Label4" runat="server" Text="Mô tả" CssClass="label"></asp:Label></td>
                                <td class="tdValue">
                                    <asp:TextBox ID="txtDescriptions" runat="server" TextMode="MultiLine" CssClass="textBox" Width="300px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td colspan="2" class="tdButton">
                                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Thêm mới" CssClass="small color green button" Width="100px" />
                                    &nbsp;
                                    <asp:Button ID="btnCancel" runat="server" Text="Thoát" CssClass="small color green button" Width="100px" />                                    
                                </td>
                            </tr>
                        </table>
                    </fieldset>
            </td>
        </tr>
    </table>
</asp:Content>

