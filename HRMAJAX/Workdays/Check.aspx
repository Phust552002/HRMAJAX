<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Check.aspx.cs" Inherits="Workdays_Check" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/DatePicker.ascx" TagName="DatePicker" TagPrefix="uc1" %>
<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>
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
                    <td valign="top">
                        <table style="width: 100%" class="tableBorder"> 
                            <tr>
                                <td valign="top" class="tdTreeView" align="left" style="width:35%">
                                    <asp:TreeView  
                                        ID="TreeView1"
                                        ExpandDepth="1" 
                                        PopulateNodesFromClient="true" 
                                        ShowLines="true" 
                                        ShowExpandCollapse="true" 
                                        runat="server"
                                        OnTreeNodePopulate="TreeView1_TreeNodePopulate" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
                                        <RootNodeStyle CssClass="tvNodeRoot" />
                                        <NodeStyle CssClass="tvNode" />
                                        <ParentNodeStyle CssClass="tvNodeParent" />
                                        <SelectedNodeStyle CssClass="tvNodeSelected" />
                                    </asp:TreeView>  
                                </td>
                                <td valign="top">
                                    <fieldset class="fieldset">
                                        <legend class="legend">
                                            <asp:Label ID="lbTitleList" runat="server" Text="Label"></asp:Label></legend>
                                       
                                        <table cellpadding="0" cellspacing="0" style="width: 100%">
                                            <tr>
                                                <td align="center">
                                                    <uc3:CalendarPicker ID="cpFromDate" runat="server" />
                                                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="-"></asp:Label>&nbsp;<uc3:CalendarPicker ID="cpToDate" runat="server" /><asp:Label id="lbTitleMonth" runat="server" CssClass="label" Text="Tháng"></asp:Label> 
                                        <asp:DropDownList id="ddlMonths" runat="server" CssClass="dropDownList">
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
                                        </asp:DropDownList> 
                    <asp:Label id="lbTitleYear" runat="server" CssClass="label" Text="Năm"></asp:Label> <asp:DropDownList id="ddlYears" runat="server" CssClass="dropDownList"></asp:DropDownList> 
                                                    <asp:Button ID="imgView" runat="server" Text="Xem" CssClass="small color green button" OnClick="imgView_Click"/></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <table style="width: 100%" class="tableBorder">
                                            <tr>
                                                <td>                                                    
                                                    <asp:GridView ID="grdCheck" runat="server" AutoGenerateColumns="False"
                                                        CssClass="grid-Border" PageSize="20" Width="100%" OnRowDataBound="grdCheck_RowDataBound">
                                                        <PagerSettings PageButtonCount="30" />
                                                        <RowStyle CssClass="grid-item" />
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="Ng&#224;y" SortExpression="Birthday">                                                                
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbDate" runat="server"></asp:Label>
                                                                </ItemTemplate>
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderTemplate>
                                                                    <asp:Label ID="lbHeaderDate" runat="server" Text="Label"></asp:Label>
                                                                </HeaderTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Chấm c&#244;ng" SortExpression="DepartmentFullName">                                                               
                                                                <ItemTemplate>
                                                                    <asp:Image ID="imgCheck" runat="server" ImageUrl="~/Images/check.png"></asp:Image>
                                                                </ItemTemplate>
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                                <ItemStyle HorizontalAlign="Center" />
                                                            </asp:TemplateField>
                                                        </Columns>
                                                        <PagerStyle CssClass="grid-paper" />
                                                        <HeaderStyle CssClass="grid-header" />
                                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                                    </asp:GridView>
                                                </td>                                                
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
            </table>
     </tr>
</table>
</asp:Content>

