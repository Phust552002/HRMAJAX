<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Others.ascx.cs" Inherits="Coefficients_UserControls_Others" %>
<%@ Register Src="../../UserControls/CalendarPicker.ascx" TagName="CalendarPicker"
    TagPrefix="uc3" %>
<%@ Register Src="../../UserControls/DatePicker.ascx" TagName="DatePicker" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc1" %>

<table style="width: 100%">
        <tr>
            <td>
                <uc1:MessageError ID="MessageError1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <fieldset>
                <legend class="legend"> Quá trình chuyển đổi hệ số</legend>
                    <table style="width: 99%" class="tableBorder">
                    <tr>
                        <td align="center">   
                    <asp:GridView ID="grdCoefficientEmployees" runat="server" AutoGenerateColumns="False" DataKeyNames="CoefficientEmployeeId" DataSourceID="ObjectDataSource1" HorizontalAlign="Left" CssClass="grid-Border" Width="100%" OnRowDeleted="grdCoefficientEmployees_RowDeleted" OnRowUpdated="grdCoefficientEmployees_RowUpdated" OnRowDataBound="grdCoefficientEmployees_RowDataBound">
                        <Columns>
                            <asp:TemplateField HeaderText="PCDH" SortExpression="PCDH">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("PCDH") %>' CssClass="textBox" Width="95%"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lbPCDH" runat="server" ></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Right" />
                                <HeaderStyle HorizontalAlign="Right" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="PCTN" SortExpression="PCTN">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("PCTN") %>' CssClass="textBox" Width="95%"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lbPCTN" runat="server" ></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Right" />
                                <HeaderStyle HorizontalAlign="Right" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="PCKV" SortExpression="PCKV">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("PCKV") %>' CssClass="textBox" Width="95%"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lbPCKV" runat="server" ></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Right" />
                                <HeaderStyle HorizontalAlign="Right" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="PCCV" SortExpression="PCCV">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("PCCV") %>' CssClass="textBox" Width="95%"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lbPCCV" runat="server" ></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Right" />
                                <HeaderStyle HorizontalAlign="Right" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Ng&#224;y &#193;p Dụng" SortExpression="CREATEDATE">
                                <EditItemTemplate>                                  
                                    <uc3:CalendarPicker ID="dpCreateDate" runat="server" SelectedDate='<%#Bind("CREATEDATE") %>'/>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server"  Text='<%#DataBinder.Eval(Container.DataItem, "CREATEDATE", "{0:dd/MM/yyyy}")%>'></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                                <HeaderStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Ghi Ch&#250;" SortExpression="Description">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("Description") %>' CssClass="textBox" Width="95%"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" />
                                <HeaderStyle HorizontalAlign="Left" />
                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Thao t&#225;c" ShowHeader="False">
                                <EditItemTemplate>
                                    <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="True" CommandName="Update" ImageUrl="~/Images/icon-save.gif"/>
                                    <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Cancel" ImageUrl="~/Images/icon-cancel.gif"/>
                                </EditItemTemplate>
                                <ItemStyle HorizontalAlign="Center" Width="15%" />
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Edit" ImageUrl="~/Images/icon-edit.gif"/>
                                    <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/Images/icon-delete.gif" OnClientClick="return confirm('Bạn có muốn xóa thông tin đã chọn ?');"/>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" />
                            </asp:TemplateField> 
                        </Columns>
                         <HeaderStyle CssClass="grid-header" /> 
                    <RowStyle CssClass ="grid-item" />
                    <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                    <PagerStyle CssClass="grid-paper" /> 
                        <EmptyDataTemplate>
                            <asp:Label ID="Label14" runat="server" CssClass="value" Text="Chưa có thông tin hệ số về nhân viên này."></asp:Label>
                        </EmptyDataTemplate>
                </asp:GridView>                                        
                    </td>
                    </tr>
                    
                </table>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete"
                        OnSelecting="ObjectDataSource1_Selecting" OnUpdating="ObjectDataSource1_Updating"
                        SelectMethod="GetByUserId" TypeName="HRMBLL.H1.CoefficientEmployeesBLL" UpdateMethod="Update">
                        <DeleteParameters>
                            <asp:Parameter Name="coefficientEmployeeId" Type="Int32" />
                        </DeleteParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="coefficientEmployeeId" Type="Int32" />
                            <asp:Parameter Name="userId" Type="Int32" />
                            <asp:Parameter Name="lCB" Type="Double" />
                            <asp:Parameter Name="lNS" Type="Double" />
                            <asp:Parameter Name="pCDH" Type="Double" />
                            <asp:Parameter Name="pCTN" Type="Double" />
                            <asp:Parameter Name="pCCV" Type="Double" />
                            <asp:Parameter Name="pCKV" Type="Double" />
                            <asp:Parameter Name="description" Type="String" />
                            <asp:Parameter Name="active" Type="Boolean" />
                            <asp:Parameter Name="createDate" Type="DateTime" />
                        </UpdateParameters>
                        <SelectParameters>
                            <asp:Parameter Name="userId" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </fieldset>
            </td>
        </tr>
        <tr>
            <td>
                <fieldset>
                    <legend class="legend"> Lập hệ số mới</legend>
                     <table style="width: 99%;margin-top:2px; margin-left:2px; margin-right:2px; margin-bottom:2px;" class="tableBorder">
                        <tr>
                            <td class="tdLabel">
                                <asp:Label ID="Label2" runat="server" CssClass="label" Text="PCDH ( Phụ cấp độc hại )"></asp:Label></td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtPCDH" runat="server" CssClass="textBox" Width="150px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td class="tdLabel">
                                <asp:Label ID="Label3" runat="server" CssClass="label" Text="PCTN ( Phụ cấp trách nhiệm )"></asp:Label></td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtPCTN" runat="server" CssClass="textBox" Width="150px"></asp:TextBox></td>
                        </tr>
                         <tr>
                             <td class="tdLabel">
                                 <asp:Label ID="Label4" runat="server" CssClass="label" Text="PCCV ( Phụ cấp chức vụ )"></asp:Label></td>
                             <td class="tdValue">
                                 <asp:TextBox ID="txtPCCV" runat="server" CssClass="textBox" Width="150px"></asp:TextBox></td>
                         </tr>
                         <tr>
                             <td class="tdLabel">
                                 <asp:Label ID="Label5" runat="server" CssClass="label" Text="PCKV ( Phụ cấp khu vực )"></asp:Label></td>
                             <td class="tdValue">
                                 <asp:TextBox ID="txtPCKV" runat="server" CssClass="textBox" Width="150px"></asp:TextBox></td>
                         </tr>
                        <tr>
                            <td class="tdLabel">
                                <asp:Label ID="Label8" runat="server" CssClass="label" Text="Ngày áp dụng"></asp:Label></td>
                            <td class="tdValue">                                
                                <uc3:CalendarPicker ID="dpCreateDate" runat="server" />
                            </td>
                        </tr>
                         <tr>
                             <td class="tdLabel">
                                <asp:Label ID="Label7" runat="server" CssClass="label" Text="Ghi chú"></asp:Label></td>
                             <td class="tdValue">
                                 <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" CssClass="textBox" Width="250px"></asp:TextBox></td>
                         </tr>
                        <tr>
                            <td colspan="2" class="tdButton">
                             <table style="width: 100%" >
                                 <tr>
                                     <td align="center">
                                         <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Thêm mới" CssClass="small color green button"/></td>
                                 </tr>
                             </table>
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
    </table>