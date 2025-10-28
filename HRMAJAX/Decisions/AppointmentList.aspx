<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="AppointmentList.aspx.cs" Inherits="Decisions_AppointmentList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
    <tr>
        <td>
            <uc1:ucTitle ID="UcTitle1" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            <table style="width:100%">
                <tr>
                    <td align="left">
                        <uc2:ActionMenu ID="ActionMenu1" runat="server" />
                    </td>
                    <td align="right">
                        <table>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" CssClass="label" Text="Số quyết định"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtDecisionNo" runat="server" CssClass="textBox"></asp:TextBox></td>
                                <td>
                                    <asp:Label ID="Label6" runat="server" CssClass="label" Text="Tên quyết định"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtDecisionName" runat="server" CssClass="textBox"></asp:TextBox></td>
                                <td>
                                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Icon-Search.gif" OnClick="ImageButton1_Click" /></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            
        </td>
    </tr>
    <tr>
        <td valign="top">
            <table style="width: 100%" class="tableBorder">                        
                    <tr>
                        <td>
                            <asp:GridView ID="grdAppointmentList" runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="20" Width="100%" CssClass="grid-Border" DataSourceID="ObjectDataSource1" OnRowDataBound="grdAppointmentList_RowDataBound">
                                <Columns>
                                    <asp:TemplateField HeaderText="Quyết định số" SortExpression="DecisionNo">
                                        <ItemTemplate>
                                            <asp:HyperLink ID="lnkDecisionNo" runat="server" CssClass="hyperlink-Grid">HyperLink</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="DecisionName" HeaderText="T&#234;n quyết định" SortExpression="DecisionName" />
                                    <asp:BoundField DataField="BringOutDept" HeaderText="Đơn vị đưa ra quyết định" SortExpression="BringOutDept" />
                                    <asp:BoundField DataField="SignUser" HeaderText="Người k&#253; quyết định" SortExpression="SignUser" />
                                    <asp:BoundField DataField="DecisionDate" HeaderText="Ng&#224;y ra quyết định" SortExpression="DecisionDate" />
                                 </Columns>
                                    <HeaderStyle CssClass="grid-header" /> 
                                    <RowStyle CssClass ="grid-item" />
                                    <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                    <PagerStyle CssClass="grid-paper" /> 
                                <EmptyDataTemplate>
                                    <asp:Label ID="Label3" runat="server" CssClass="value" Text="Chưa có dữ liệu"></asp:Label>
                                </EmptyDataTemplate>
                              </asp:GridView>                           
                            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting"
                                SelectMethod="GetByFilter" TypeName="HRMBLL.H3.DecisionsBLL">
                                <SelectParameters>
                                    <asp:Parameter Name="decisionTypeId" Type="Int32" />
                                    <asp:Parameter Name="decisionNo" Type="String" />
                                    <asp:Parameter Name="decisionName" Type="String" />
                                    <asp:Parameter Name="decisionDate" Type="DateTime" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </td>
                    </tr>
                </table>
        </td>
    </tr>        
</table>
</asp:Content>

