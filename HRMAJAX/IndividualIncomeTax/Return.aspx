<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Return.aspx.cs" Inherits="IndividualIncomeTax_Return" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%">
    <tr>
        <td>
            <uc1:ucTitle ID="UcTitle1" runat="server" />                        
        </td>
    </tr>
    <tr>
        <td>                        
            <table style="width: 100%">
                <tr>
                    <td align="center">
                        <span style="font-size: 14pt; color: #006600"><strong>THUẾ THU NHẬP CÁ NHÂN ĐÃ KHẤU
                            TRỪ TRẢ LẠI<br />
                        </strong><span style="font-size: 12pt; color: black">(Theo CV số 1823/BTC-TCT ngày 18/02/2009
                            v/v triển khai thực hiện giãn nộp thuế thu nhập cá nhân)</span></span></td>
                </tr>
                <tr>
                    <td>                                    
                        <fieldset class="fieldset">
                            <legend class="legend"> Thông Tin Cá Nhân</legend>
                                <table style="width: 100%">                                                
                                    <tr>
                                        <td align="center">
                                            <table style="width: 100%" class="tableBorder">
                                                <tr>
                                                    <td class="tdLabel">
                                                        <asp:Label ID="Label1" runat="server" Text="Họ và tên" CssClass="label"></asp:Label></td>
                                                    <td class="tdValue" >
                                                        <asp:Label ID="lbFullName" runat="server" CssClass="value"></asp:Label></td>
                                                    <td class="tdLabel">
                                                        <asp:Label ID="Label2" runat="server" Text="Tài khoản" CssClass="label"></asp:Label></td>
                                                    <td class="tdValue"> 
                                                        <asp:Label ID="lbAccountNo" runat="server" CssClass="value"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td class="tdLabel">
                                                        <asp:Label ID="Label3" runat="server" Text="Chức danh" CssClass="label"></asp:Label></td>
                                                    <td class="tdValue">
                                                        <asp:Label ID="lbPosition" runat="server" CssClass="value"></asp:Label></td>
                                                    <td class="tdLabel">
                                                        <asp:Label ID="Label4" runat="server" Text="Phòng ban" CssClass="label"></asp:Label></td>
                                                    <td class="tdValue"> 
                                                        <asp:Label ID="lbDepartment" runat="server" CssClass="value"></asp:Label></td>
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
    <tr>
        <td align="left">
            <table width="100%" class="tableBorder">
                <tr>
                    <td>
                    
            <asp:GridView ID="grdIndividualIncomeTax" runat="server" AutoGenerateColumns="False" DataSourceID="odsIndividualIncomeTax" CssClass="grid-Border" Width="100%" OnRowDataBound="grdIndividualIncomeTax_RowDataBound" >
                <Columns>
                    <asp:TemplateField HeaderText="M&#244; tả" SortExpression="Description">
                        <ItemTemplate>
                            <asp:Label ID="lbName" runat="server"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            Tổng Cộng
                        </FooterTemplate>
                        <ItemStyle HorizontalAlign="left" />
                        <FooterStyle HorizontalAlign="left" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Số tiền ( VND )" SortExpression="BonusValue">
                        <ItemStyle HorizontalAlign="Right" />
                        <FooterStyle HorizontalAlign="Right" />
                        <HeaderStyle HorizontalAlign="Right" />
                        <ItemTemplate>
                            <asp:Label ID="lbMoney" runat="server"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:Label ID="lbTotalMoney" runat="server"></asp:Label>
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    <asp:Label ID="Label1" runat="server" CssClass="value" Text="Chưa có thông tin"></asp:Label>
                </EmptyDataTemplate>
                <HeaderStyle CssClass="grid-header" />
                <RowStyle CssClass ="grid-item" />
                <AlternatingRowStyle CssClass="grid-atlternating-item" />
                <PagerStyle CssClass="grid-paper" />
                <FooterStyle CssClass="grid-footer" />
            </asp:GridView>
                <asp:ObjectDataSource ID="odsIndividualIncomeTax" runat="server" OnSelecting="odsIndividualIncomeTax_Selecting" SelectMethod="GetAll" TypeName="HRMBLL.H.BonusValuesBLL">
                    <SelectParameters>
                        <asp:Parameter Name="userId" Type="Int32" />
                        <asp:Parameter Name="year" Type="Int32" />
                        <asp:Parameter Name="type" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                    </td>
                </tr>
            </table>
        </td>
    </tr>           
</table>
</asp:Content>


