<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Type.aspx.cs" Inherits="Decisions_Type" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/Title.ascx" TagName="Title" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/LeftMenu.ascx" TagName="LeftMenu" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td style="width:20%; height:500px" align="left" valign="top" class="LeftMenu" >
                <uc1:LeftMenu ID="LeftMenu1" runat="server" />
                &nbsp;
            </td>
            <td valign="top">
                <table cellpadding="0" cellspacing="0" style="width: 100%">
                    <tr>
                        <td>
                            <uc3:Title ID="Title1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table class="tableBorder" width="100%">
                                <tr>
                                    <td>
                                         <asp:GridView ID="grdContracts" runat="server" AutoGenerateColumns="False" DataSourceID="odsContractTypes" AllowPaging="True" PageSize="20" DataKeyNames="ContractTypeId" Width="100%" OnRowCancelingEdit="grdContracts_RowCancelingEdit" OnRowUpdated="grdContracts_RowUpdated" OnRowDeleted="grdContracts_RowDeleted" CssClass="grid-Border">
                                            <Columns>
                                                <asp:TemplateField HeaderText="M&#227; loại quyết định" SortExpression="ContractTypeCode">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ContractTypeCode") %>' CssClass="textBox" Width="90%"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("ContractTypeCode") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="T&#234;n loại quyết định" SortExpression="ContractTypeName">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ContractTypeName") %>' CssClass="textBox" Width="90%"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("ContractTypeName") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Thời gian hiệu lực(số th&#225;ng)" SortExpression="ContractTypeValue">
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
                                                <asp:Label ID="Label3" runat="server" CssClass="value" Text="Không có dữ liệu"></asp:Label>
                                            </EmptyDataTemplate>
                                          </asp:GridView>
                                          <asp:ObjectDataSource ID="odsContractTypes" runat="server"
                                          SelectMethod="GetAll" TypeName="HRMBLL.H0.ContractTypesBLL" DeleteMethod="Delete" UpdateMethod="Update" OnSelecting="odsContractTypes_Selecting" OnUpdating="odsContractTypes_Updating">
                                              <DeleteParameters>
                                                  <asp:Parameter Name="contractTypeId" Type="Int32" />
                                              </DeleteParameters>
                                              <UpdateParameters>
                                                  <asp:Parameter Name="contractTypeCode" Type="String" />
                                                  <asp:Parameter Name="contractTypeName" Type="String" />
                                                  <asp:Parameter Name="contractTypeValue" Type="Double" />
                                                  <asp:Parameter Name="contractTypeDescription" Type="String" />
                                                  <asp:Parameter Name="contractTypeId" Type="Int32" />
                                                  <asp:Parameter Name="dataType" Type="Int32" />
                                              </UpdateParameters>
                                              <SelectParameters>
                                                  <asp:Parameter Name="dataType" Type="Int32" />
                                              </SelectParameters>
                                          </asp:ObjectDataSource>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table class="tableBorder" style="width: 100%;" >
                                <tr>
                                    <td class="tdLabel">
                                        <asp:Label ID="Label1" runat="server" Text="Mã loại quyết định" CssClass="label"></asp:Label></td>
                                    <td class="tdValue">
                                        <asp:TextBox ID="txtContractTypeCode" runat="server" CssClass="textBox" Width="200px"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td class="tdLabel">
                                        <asp:Label ID="Label2" runat="server" Text="Tên loại quyết định" CssClass="label"></asp:Label></td>
                                    <td class="tdValue">
                                        <asp:TextBox ID="txtContractTypeName" runat="server" CssClass="textBox" Width="200px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="tdLabel">
                                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Thời gian hiệu lực(số tháng)"></asp:Label></td>
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
                                    <td colspan="2" class="tdButton" align="center">
                                        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Thêm mới" CssClass="small color green button" Width="100px" />
                                        &nbsp;
                                        <asp:Button ID="btnCancel" runat="server" Text="Thoát" CssClass="small color green button" Width="100px" />                                    
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


