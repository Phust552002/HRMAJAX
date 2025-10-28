<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="OptionConfirm.aspx.cs" Inherits="CalculatedSalary_Fixed_UnitPrices_OptionConfirm" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="~/UserControls/ucMessageError.ascx" TagName="ucMessageError" TagPrefix="uc4" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
        <tr>
            <td valign="top">
                 
                <table style="width: 100%">
                    <tr>
                        <td>
                            <uc2:ucTitle ID="UcTitle1" runat="server" />                                                      
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="center">
                            <table>
                                <tr>
                                    <td align="right">
                                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/icn_right.gif" /></td>
                                    <td align="left">
                                        <asp:Label ID="lbDept" runat="server" CssClass="value" Text="Label"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/icn_right.gif" /></td>
                                    <td align="left">
                                        <asp:Label ID="lbDate" runat="server" CssClass="value" Text="Label"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/icn_right.gif" /></td>
                                    <td align="left">
                                        <asp:Label ID="lbUnitPriceType" runat="server" CssClass="value" Text="Tính theo đơn giá cố định"></asp:Label></td>
                                </tr>                              
                            </table>
                        </td>
                    </tr>                   
                    <tr>
                        <td align="center" colspan="2">
                             <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                                    <ProgressTemplate>
                                        <asp:Image ID="Image2" runat="server" ImageUrl="~/images/run.gif" />
                                        <asp:Label ID="Label4" runat="server" CssClass="value" Text="Đang Tính Lương ..."></asp:Label>
                                    </ProgressTemplate>
                                </asp:UpdateProgress>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                        <table width="100%">
                            <tr>
                                <td>
                                    <asp:Panel ID="pnUnitPrice" runat="server" Width="100%" Visible="false">
                                    <fieldset>
                                        <legend class="legend"><asp:Label ID="lbTitleUnitPrice" runat="server"></asp:Label></legend>
                                        <table width="100%" class="tableBorder">
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="grdUnitPriceDetails" runat="server" AutoGenerateColumns="False"
                                                        CssClass="grid-Border" DataKeyNames="UnitPriceDetailId" DataSourceID="odsUnitPriceDetails"
                                                        OnRowDataBound="grdUnitPriceDetails_RowDataBound" PageSize="20" Width="100%">
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="Ph&#242;ng" SortExpression="RootName">
                                                                <HeaderStyle HorizontalAlign="Left" />
                                                                <ItemStyle HorizontalAlign="Left" />
                                                                <ItemTemplate>
                                                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("RootName") %>'></asp:Label>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Đơn gi&#225; LNS" SortExpression="UnitPriceLNS">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbUnitPriceLNS" runat="server" ></asp:Label>
                                                                </ItemTemplate>
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Đơn gi&#225; Thưởng" SortExpression="UnitPriceBonus">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbUnitPriceBonus" runat="server"></asp:Label>
                                                                </ItemTemplate>
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Đơn gi&#225; LCB" SortExpression="UnitPriceLCB">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbUnitPriceLCB" runat="server"></asp:Label>
                                                                </ItemTemplate>
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Đơn gi&#225; tiền ăn" SortExpression="UnitPriceLuch">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbUnitPriceLuch" runat="server"></asp:Label>
                                                                </ItemTemplate>
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                                <ItemStyle HorizontalAlign="Right" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Th&#225;ng năm" SortExpression="CreateDate">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="Label2" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "CreateDate", "{0:MM/yyyy}")%>'></asp:Label>
                                                                </ItemTemplate>
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Ghi ch&#250;" SortExpression="Remark">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Remark") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <HeaderStyle HorizontalAlign="Left" />
                                                                <ItemStyle HorizontalAlign="Left" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Loại" SortExpression="UnitPriceTypeName">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("UnitPriceTypeName") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <HeaderStyle HorizontalAlign="Left" />
                                                                <ItemStyle HorizontalAlign="Left" />
                                                            </asp:TemplateField>
                                                        </Columns>
                                                        <HeaderStyle CssClass="grid-header" />
                                                        <RowStyle CssClass="grid-item" />
                                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                                        <PagerStyle CssClass="grid-paper" />
                                                    </asp:GridView>
                                                    <asp:ObjectDataSource ID="odsUnitPriceDetails" runat="server" SelectMethod="GetByDate"
                                                        TypeName="HRMBLL.H1.UnitPriceDetailsBLL" DeleteMethod="Delete" OnSelecting="odsUnitPriceDetails_Selecting" OldValuesParameterFormatString="original_{0}">
                                                        <DeleteParameters>
                                                            <asp:Parameter Name="unitPriceDetailId" Type="Int32" />
                                                        </DeleteParameters>
                                                        <SelectParameters>
                                                            <asp:Parameter Name="month" Type="Int32" />
                                                            <asp:Parameter Name="year" Type="Int32" />
                                                        </SelectParameters>
                                                    </asp:ObjectDataSource>                                  
                                                </td>
                                            </tr>                                            
                                        </table>
                                    </fieldset>
                                    </asp:Panel>
                                </td>
                            </tr>
                           
                                    <tr>
                                        <td align="center" class="tdButton"> 
                                         <asp:UpdatePanel id="UpdatePanel1" runat="server">
                                            <ContentTemplate>
<uc4:ucMessageError id="UcMessageError1" runat="server"></uc4:ucMessageError> <asp:Button id="btnContinue" onclick="btnContinue_Click" runat="server" Width="100px" CssClass="small color green button" Text="Chạy lương" OnClientClick="return confirm('Bạn có muốn tình lương theo các mục đã chọn ?')"></asp:Button> &nbsp;&nbsp; <asp:Button id="btnCancel" onclick="btnCancel_Click" runat="server" Width="100px" CssClass="small color green button" Text="Quay về"></asp:Button> <asp:Label id="lbFinish" runat="server" CssClass="value" Text="Tính lương thành công. Click vào nút Xem Lương để kiểm tra." Visible="False"></asp:Label><BR /><asp:Button id="btnViewSalary" onclick="btnViewSalary_Click" runat="server" CssClass="small color green button" Text="Xem Bảng Lương" Visible="False"></asp:Button> 
</ContentTemplate>
                                        </asp:UpdatePanel>
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

