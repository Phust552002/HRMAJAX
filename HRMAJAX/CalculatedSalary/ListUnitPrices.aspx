<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ListUnitPrices.aspx.cs" Inherits="CalculatedSalary_ListUnitPrices" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc3" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>



<%@ Register Src="../UserControls/HeaderContent.ascx" TagName="HeaderContent" TagPrefix="uc1" %>
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
                        <td valign="top" style="height: 238px">
                            <table style="width: 100%" >
                                    <tr>
                                        <td align="center">
                                            <asp:Label ID="Label7" runat="server" CssClass="label" Text="Tháng năm"></asp:Label>&nbsp;<asp:DropDownList id="ddlMonths" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlMonths_SelectedIndexChanged">
                                                <asp:ListItem>1</asp:ListItem>
                                                <asp:ListItem>2</asp:ListItem>
                                                <asp:ListItem>3</asp:ListItem>
                                                <asp:ListItem>4</asp:ListItem>
                                                <asp:ListItem>5</asp:ListItem>
                                                <asp:ListItem>6</asp:ListItem>
                                                <asp:ListItem>7</asp:ListItem>
                                                <asp:ListItem>8</asp:ListItem>
                                                <asp:ListItem>9</asp:ListItem>
                                                <asp:ListItem>10</asp:ListItem>
                                                <asp:ListItem>11</asp:ListItem>
                                                <asp:ListItem>12</asp:ListItem>
                                                <asp:ListItem></asp:ListItem>
                                            </asp:DropDownList><asp:DropDownList id="ddlYears" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlYears_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            &nbsp;&nbsp; &nbsp;&nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center">
                                            <table style="width: 100%" class="tableBorder">
                                                <tr>
                                                    <td>
                                                       <asp:GridView ID="grdUnitPriceDetails" runat="server" AutoGenerateColumns="False"
                                                        DataSourceID="odsUnitPriceDetails" DataKeyNames="UnitPriceDetailId" PageSize="20" CssClass="grid-Border" Width="100%" OnRowDataBound="grdUnitPriceDetails_RowDataBound">
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="Ph&#242;ng" SortExpression="RootName">
                                                                <EditItemTemplate>
                                                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("RootName") %>'></asp:Label>
                                                                </EditItemTemplate>
                                                                <HeaderStyle HorizontalAlign="Left" />
                                                                <ItemTemplate>
                                                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("RootName") %>'></asp:Label>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Đơn gi&#225; LNS" SortExpression="UnitPriceLNS">
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtUnitPriceLNS" runat="server" Text='<%# Bind("UnitPriceLNS") %>' CssClass="textBox" Width="98%"></asp:TextBox>
                                                                </EditItemTemplate>
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbUnitPriceLNS" runat="server" Text='<%# Bind("UnitPriceLNS") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Đơn gi&#225; Thưởng" SortExpression="UnitPriceBonus">
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtUnitPriceBonus" runat="server" Text='<%# Bind("UnitPriceBonus") %>' CssClass="textBox" Width="98%"></asp:TextBox>
                                                                </EditItemTemplate>
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbUnitPriceBonus" runat="server" Text='<%# Bind("UnitPriceBonus") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Đơn gi&#225; LCB" SortExpression="UnitPriceLCB">
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtUnitPriceLCB" runat="server" Text='<%# Bind("UnitPriceLCB") %>' CssClass="textBox" Width="98%"></asp:TextBox>
                                                                </EditItemTemplate>
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbUnitPriceLCB" runat="server" Text='<%# Bind("UnitPriceLCB") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Đơn gi&#225; tiền ăn" SortExpression="UnitPriceLuch">
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="txtUnitPriceLuch" runat="server" Text='<%# Bind("UnitPriceLuch") %>' CssClass="textBox" Width="98%"></asp:TextBox>
                                                                </EditItemTemplate>
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbUnitPriceLuch" runat="server" Text='<%# Bind("UnitPriceLuch") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Đơn gi&#225; LNS dư" SortExpression="UnitPriceLNSBalance">
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("UnitPriceLNSBalance") %>' CssClass="textBox"></asp:TextBox>
                                                                </EditItemTemplate>
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbUnitPriceLNSBalance" runat="server" Text='<%# Bind("UnitPriceLNSBalance") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Đơn gi&#225; thưởng dư" SortExpression="UnitPriceBonusBalance">
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("UnitPriceBonusBalance") %>' CssClass="textBox"></asp:TextBox>
                                                                </EditItemTemplate>
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbUnitPriceBonusBalance" runat="server" Text='<%# Bind("UnitPriceBonusBalance") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Chỉ số ph&#226;n bổ" SortExpression="IndexBalance">
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("IndexBalance") %>' CssClass="textBox"></asp:TextBox>
                                                                </EditItemTemplate>
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbIndexBalance" runat="server" Text='<%# Bind("IndexBalance") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Th&#225;ng năm" SortExpression="CreateDate">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="Label2" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "CreateDate", "{0:MM/yyyy}")%>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <uc3:CalendarPicker ID="CalendarPicker1" runat="server" SelectedDate='<%# Bind("CreateDate") %>'/>                                                                    
                                                                </EditItemTemplate>
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />                                                                
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Ghi ch&#250;" SortExpression="Remark">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Remark") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Remark") %>' CssClass="textBox" Width="98%"></asp:TextBox>
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Loại" SortExpression="UnitPriceTypeName">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("UnitPriceTypeName") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("UnitPriceTypeName") %>'></asp:Label>
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Thao t&#225;c" ShowHeader="False">
                                                                <EditItemTemplate>
                                                                    <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="True" CommandName="Update" ImageUrl="~/Images/icon-save.gif"/>
                                                                    <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Cancel" ImageUrl="~/Images/icon-cancel.gif"/>
                                                                </EditItemTemplate>
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Edit" ImageUrl="~/Images/icon-edit.gif"/>
                                                                    <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/Images/icon-delete.gif" OnClientClick="return confirm('Bạn có muốn xóa thông tin này không?');"/>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Center" Width="5%" />
                                                            </asp:TemplateField> 
                                                        </Columns>
                                                        <HeaderStyle CssClass="grid-header" /> 
                                                        <RowStyle CssClass ="grid-item" />
                                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                                        <PagerStyle CssClass="grid-paper" />
                                                    </asp:GridView>
                                                    <asp:ObjectDataSource ID="odsUnitPriceDetails" runat="server" SelectMethod="GetByDate"
                                                        TypeName="HRMBLL.H1.UnitPriceDetailsBLL" DeleteMethod="Delete" OnSelecting="odsUnitPriceDetails_Selecting" OnSelected="odsUnitPriceDetails_Selected" UpdateMethod="Update" OnUpdating="odsUnitPriceDetails_Updating">
                                                        <DeleteParameters>
                                                            <asp:Parameter Name="unitPriceDetailId" Type="Int32" />
                                                        </DeleteParameters>
                                                        <SelectParameters>
                                                            <asp:Parameter Name="month" Type="Int32" />
                                                            <asp:Parameter Name="year" Type="Int32" />
                                                        </SelectParameters>
                                                        <UpdateParameters>
                                                            <asp:Parameter Name="unitPriceLNS" Type="Double" />
                                                            <asp:Parameter Name="unitPriceBonus" Type="Double" />
                                                            <asp:Parameter Name="unitPriceLCB" Type="Double" />
                                                            <asp:Parameter Name="unitPriceLuch" Type="Double" />
                                                            <asp:Parameter Name="unitPriceDeptId" Type="Int32" />
                                                            <asp:Parameter Name="createDate" Type="DateTime" />
                                                            <asp:Parameter Name="remark" Type="String" />
                                                            <asp:Parameter Name="unitPriceType" Type="Int32" />
                                                            <asp:Parameter Name="unitPriceDetailId" Type="Int32" />
                                                            <asp:Parameter Name="rootName" Type="String" />
                                                            <asp:Parameter Name="unitPriceTypeName" Type="String" />
                                                            <asp:Parameter Name="indexBalance" Type="Double" />
                                                            <asp:Parameter Name="unitPriceLNSBalance" Type="Double" />
                                                            <asp:Parameter Name="unitPriceBonusBalance" Type="Double" />
                                                        </UpdateParameters>
                                                    </asp:ObjectDataSource>                                                        
                                                    </td>
                                                </tr>
                                            </table>
                                            <asp:Button ID="btnAddNew" runat="server" CssClass="small color green button" OnClick="btnAddNew_Click" Text="Nhập Đơn Giá Cố Định" />            
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

