<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="History.aspx.cs" Inherits="Contracts_History" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="UserControls/SaveCnt.ascx" TagName="SaveCnt" TagPrefix="uc5" %>

<%@ Register Src="../Employee/UserControls/Ele.ascx" TagName="Ele" TagPrefix="uc4" %>
<%@ Register Src="UserControls/ContractFilter.ascx" TagName="ContractFilter" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/Title.ascx" TagName="Title" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/LeftMenu.ascx" TagName="LeftMenu" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td style="width:20%; height:500px" align="left" valign="top" class="LeftMenu" >
                <uc1:LeftMenu ID="LeftMenu1" runat="server" />
                <uc4:Ele ID="Ele1" runat="server" />                
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
                             <table style="width: 100%" class="tableBorder">
                                <tr>
                                    <td class="tdLabel">
                                        <asp:Label ID="Label1" runat="server" Text="Họ và tên" CssClass="label"></asp:Label></td>
                                    <td class="tdValue" >
                                        <asp:Label ID="lbFullName" runat="server" CssClass="value"></asp:Label></td>
                                    <td class="tdLabel">
                                        <asp:Label ID="Label4" runat="server" Text="Mã NV" CssClass="label"></asp:Label></td>
                                    <td class="tdValue"><asp:Label ID="lbEmployeeCode" runat="server" CssClass="value"></asp:Label></td>
                                    <td class="tdLabel">
                                        <asp:Label ID="Label2" runat="server" Text="Ngày sinh" CssClass="label"></asp:Label></td>
                                    <td class="tdValue"><asp:Label ID="lbBirthday" runat="server" CssClass="value"></asp:Label></td>
                                </tr>
                            </table>
                        </td>
                    </tr>                      
                    <tr>
                        <td>
                            <table class="tableBorder" width="100%">
                                <tr>
                                    <td>
                                        <asp:GridView ID="grdHistoryContracts" runat="server" AutoGenerateColumns="False" CssClass="grid-Border" Width="100%" OnRowDataBound="grdHistoryContracts_RowDataBound" OnSelectedIndexChanged="grdHistoryContracts_SelectedIndexChanged">
                                            <Columns>
                                                <asp:TemplateField HeaderText="Chức danh c&#244;ng việc" SortExpression="PositionName">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="lnkPositionName" runat="server" Text='<%# Bind("PositionName") %>' CssClass="hyperlink-Grid" CommandName="Select" ToolTip='<%# Bind("EmployeeContractId")%>'></asp:LinkButton>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Lọai hợp đồng" SortExpression="ContractTypeName">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("ContractTypeName") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:TemplateField>                                              
                                                <asp:TemplateField HeaderText="Từ ng&#224;y" SortExpression="FromDate">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label3" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "FromDate", "{0:dd/MM/yyyy}")%>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Đến ng&#224;y" SortExpression="ToDate">
                                                    <ItemTemplate>
                                                        <asp:Label ID="grd_lbToDate" runat="server" ></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Ghi ch&#250;" SortExpression="Description">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:TemplateField>
                                            </Columns>
                                                 <HeaderStyle CssClass="grid-header" /> 
                                                <RowStyle CssClass ="grid-item" />
                                                <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                                <PagerStyle CssClass="grid-paper" />  
                                            <EmptyDataTemplate>
                                                <asp:Label ID="Label8" runat="server" CssClass="value" Text="Chưa có thông tin hợp đồng về nhân viên được chọn."></asp:Label>
                                            </EmptyDataTemplate>
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <asp:Panel ID="pnDetailContract" runat="server" Visible="false">
                    <tr>
                        <td class="grid-header" >
                            <asp:Label ID="Label6" runat="server" Text="Chi tiết về hợp đồng"></asp:Label></td>
                    </tr>
                    </asp:Panel>
                    <tr>
                        <td>
                            <uc5:SaveCnt ID="SaveCnt1" runat="server" Visible="false" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>



