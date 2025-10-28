<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Holidays.aspx.cs" Inherits="Administrator_Holidays" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc5" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc4" %>

<%@ Register Src="../UserControls/DatePicker.ascx" TagName="DatePicker" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/HeaderContent.ascx" TagName="HeaderContent" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table style="width: 100%">
        <tr>
            <td valign="top" >
                <table style="width: 100%">
                    <tr>
                        <td valign="top">
                            <uc4:ucTitle ID="UcTitle1" runat="server" />
                        </td>
                    </tr>
                    
                    <tr>
                        <td valign="top">
                            <asp:CheckBox ID="chkHide" runat="server" Text="Thêm mới" CssClass="value" OnCheckedChanged="chkHide_CheckedChanged" AutoPostBack="True"/><br/>
                            <asp:Panel ID="pnAdd" runat="server" Width="100%" Visible="false">   
                                <fieldset>
                                    <legend class="legend">Định Nghĩa Ngày Nghỉ Lễ</legend>
                                    <table>
                                        <tr>
                                            <td>
                                                <table style="width: 100%" class="tableBorder">
                                                    <tr>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tên ngày nghỉ lễ"></asp:Label></td>
                                                        <td class="tdValue">
                                                            <asp:TextBox ID="txtHolidayName" runat="server" Width="200px" CssClass="textBox"></asp:TextBox></td>
                                                    </tr>
                                                    <tr>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label4" runat="server" CssClass="label" Text="Ngày dương lịch"></asp:Label></td>
                                                        <td class="tdValue">
                                                            <uc5:CalendarPicker ID="cpDateHolidays" runat="server" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                             <table style="width: 100%" class="tdButton">
                                                                <tr>
                                                                    <td align="right" style="width: 45%; text-align: center;">
                                                                        <asp:Button ID="btnAdd" runat="server" Text="Thêm Mới" CssClass="small color green button" Width="100px" OnClick="btnAdd_Click" /></td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        
                                                    </tr>
                                                </table>
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
                                <legend class="legend">Danh Sách Các Ngày Nghỉ Lễ Trong Năm</legend>
                                <table style="width: 100%" >
                                    <tr>
                                        <td align="right">
                                        <asp:Label ID="Label5" runat="server" Text="Tháng" CssClass="label"></asp:Label>
                                            <asp:DropDownList ID="ddlMonth" runat="server" CssClass="dropDownList">
                                                <asp:ListItem Value="0" Text=""></asp:ListItem>
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
                                            </asp:DropDownList>
                                            &nbsp;
                                            
                                            <asp:Label ID="Label6" runat="server" Text="Năm" CssClass="label"></asp:Label>
                                            <asp:DropDownList ID="ddlYear" runat="server" CssClass="dropDownList">
                                            </asp:DropDownList>
                                            &nbsp;
                                            <asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif" OnClick="imgSearch_Click" /></td>
                                    </tr>
                                </table>
                                <table style="width: 100%" class="tableBorder">                        
                                    <tr>
                                        <td>                                            
                                            <asp:GridView ID="grdHolidays" runat="server" AutoGenerateColumns="False" DataSourceID="odsHolidays" CellPadding="0" AllowPaging="True" DataKeyNames="HolidayId" PageSize="20" Width="100%" CssClass="grid-Border">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="T&#234;n ng&#224;y nghỉ lễ" SortExpression="HolidayName">
                                                        <EditItemTemplate>
                                                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("HolidayName") %>' CssClass="textBox" Width="95%"></asp:TextBox>
                                                        </EditItemTemplate>
                                                        <ItemTemplate>
                                                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("HolidayName") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Ng&#224;y dương lịch" SortExpression="HolidayDate">
                                                        <EditItemTemplate>
                                                            <uc5:CalendarPicker ID="CalendarPicker1" runat="server" SelectedDate='<%# Bind("HolidayDate")%>'/>
                                                        </EditItemTemplate>
                                                        <ItemTemplate>
                                                            <asp:Label ID="Label1" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "HolidayDate", "{0:dd/MM/yyyy}")%>'></asp:Label>
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
                                            <asp:ObjectDataSource ID="odsHolidays" runat="server" SelectMethod="GetByDate" TypeName="HRMBLL.H0.HolidaysBLL" DeleteMethod="Delete" UpdateMethod="Update" OnSelecting="odsHolidays_Selecting">
                                                <DeleteParameters>
                                                    <asp:Parameter Name="holidayId" Type="Int32" />
                                                </DeleteParameters>
                                                <UpdateParameters>
                                                    <asp:Parameter Name="holidayId" Type="Int32" />
                                                    <asp:Parameter Name="holidayName" Type="String" />
                                                    <asp:Parameter Name="holidayDate" Type="DateTime" />
                                                </UpdateParameters>
                                                <SelectParameters>
                                                    <asp:Parameter Name="month" Type="Int32" />
                                                    <asp:Parameter Name="year" Type="Int32" />
                                                </SelectParameters>
                                            </asp:ObjectDataSource>
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

