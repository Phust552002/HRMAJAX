<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="Decisions_List" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="UserControls/SaveDcs.ascx" TagName="SaveDcs" TagPrefix="uc6" %>
<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc5" %>
<%@ Register Src="../Employee/UserControls/Ele.ascx" TagName="Ele" TagPrefix="uc4" %>
<%@ Register Src="UserControls/DecisionFilter.ascx" TagName="ContractFilter" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/Title.ascx" TagName="Title" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/LeftMenu.ascx" TagName="LeftMenu" TagPrefix="uc1" %>
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
                                    <td>    
                                        <asp:GridView ID="grdDecisions" runat="server" AllowPaging="True" AllowSorting="True"
                                            AutoGenerateColumns="False" CssClass="grid-Border"
                                            PageSize="20" Width="100%" OnRowDataBound="grdDecisions_RowDataBound">
                                            <Columns>
                                                <asp:TemplateField HeaderText="QĐ Số" SortExpression="DecisionNo">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbDecisionNo" runat="server" ></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="T&#234;n quyết định" SortExpression="DecisionName">
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkDecisionName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Ng&#224;y ra QĐ" SortExpression="DecisionDate">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbDecisionDate" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Loại QĐ">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbDecisionsType" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                            <HeaderStyle CssClass="grid-header" />
                                            <RowStyle CssClass="grid-item" />
                                            <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                            <PagerStyle CssClass="grid-paper" />
                                            <EmptyDataTemplate>
                                                <asp:Label ID="Label1" runat="server" CssClass="value" Text="Không có dữ liệu"></asp:Label>
                                            </EmptyDataTemplate>
                                            <PagerSettings PageButtonCount="30" />
                                        </asp:GridView>                                        
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

