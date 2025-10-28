<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Statistic1.aspx.cs" Inherits="Workdays_Statistic_Statistic1" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%">
    <tr>
        <td><uc1:ucTitle id="UcTitle1" runat="server"></uc1:ucTitle></td>
    </tr>   
    <tr>
        <td valign="top">   
            
                                    
        </td>
    </tr>
    <tr> 
        <td>
            <table style="width: 100%" class="tableBorder"> 
                            <tr>
                                <td valign="top" class="tdTreeView" align="left" style="width:20%">
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
                                <td valign="top" style="width:80%">
                                    <fieldset class="fieldset">
                                        <legend class="legend">
                                            <asp:Label ID="lbTitleList" runat="server" Text="Thống kê ngày công của SAGS"></asp:Label></legend>                                            
                                                <table style="width: 100%" class="tableBorder">
                                                    <tr class="tdValue">
                                                        <td align="center">
                                                            <table>
                                                                <tr>
                                                                    <td align="center">
                                                                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tháng"></asp:Label>&nbsp;<asp:DropDownList
                                                                            ID="ddlMonths" runat="server" CssClass="dropDownList">
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
                                                                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Năm"></asp:Label>&nbsp;<asp:DropDownList
                                                                            ID="ddlYears" runat="server" CssClass="dropDownList" AppendDataBoundItems="true">
                                                                            <asp:ListItem Value="0" Text=""></asp:ListItem>
                                                                        </asp:DropDownList></td>
                                                                    <td rowspan="2">
                                                                        &nbsp;&nbsp;
                                                                        <asp:Button ID="imgSearch" runat="server" Text="Xem" CssClass="small color green button"
                                                                            OnClick="imgSearch_Click" /></td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="center">
                                                                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Công"></asp:Label>
                                                                        <asp:DropDownList
                                                                            ID="ddlDebit" runat="server" CssClass="dropDownList">
                                                                            <asp:ListItem Value="0" Text=""></asp:ListItem>    
                                                                            <asp:ListItem Value="1">Dư</asp:ListItem>
                                                                            <asp:ListItem Value="2">Nợ</asp:ListItem>
                                                                            <asp:ListItem Value="3">Đủ</asp:ListItem>
                                                                        </asp:DropDownList>&nbsp;
                                                                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="HTCV"></asp:Label> <asp:DropDownList ID="ddlHTCV" runat="server" CssClass="dropDownList">
                                                                                                                                <asp:ListItem Value="" Text=""></asp:ListItem>
                                                                                                                                <asp:ListItem>A</asp:ListItem>
                                                                                                                                <asp:ListItem>A1</asp:ListItem>
                                                                                                                                <asp:ListItem>B</asp:ListItem>
                                                                                                                                <asp:ListItem>C</asp:ListItem>
                                                                                                                                <asp:ListItem>D</asp:ListItem>
                                                                                                                            </asp:DropDownList>
                                                                        &nbsp;
                                                                        <asp:Label ID="Label6" runat="server" CssClass="label" Text="Làm"></asp:Label>&nbsp;<asp:DropDownList
                                                                            ID="ddlWorkdayType" runat="server" CssClass="dropDownList">
                                                                            <asp:ListItem Value="0" Text=""></asp:ListItem>
                                                                            <asp:ListItem Value="1">1/2X</asp:ListItem>
                                                                            <asp:ListItem Value="2">Đ&#234;m</asp:ListItem>
                                                                        </asp:DropDownList></td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>        
                                                <table style="width: 100%" class="tableBorder">
                                                    <tr>
                                                        <td>
                                                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="100%" CssClass="grid-Border" AllowPaging="True" PageSize="20" OnRowDataBound="GridView1_RowDataBound">
                                                                <Columns>
                                                                    <asp:TemplateField SortExpression="FullName" HeaderText="Họ t&#234;n">
                                                                        <ItemStyle HorizontalAlign="Left" Width="20%"></ItemStyle>
                                                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                                        <ItemTemplate>
                                                                            <asp:HyperLink id="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink> 
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                     <asp:TemplateField HeaderText="X">
                                                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="lbX" runat="server" ></asp:Label>                                                                            
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                     <asp:TemplateField SortExpression="Count1_2X" HeaderText="Số 1/2X">
                                                                        <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                                                        <ItemTemplate>
                                                                            <asp:Label runat="server" id="lbCount1_2X"></asp:Label>
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField SortExpression="CountX" HeaderText="Số X">
                                                                        <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                                                        <ItemTemplate>
                                                                            <asp:Label runat="server" id="lbCountX"></asp:Label>
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField HeaderText="Ph&#233;p">
                                                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                                         <ItemTemplate>
                                                                            <asp:Label ID="lbPhep" runat="server"></asp:Label>
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField HeaderText="Số Đ&#234;m" SortExpression="CountNight">
                                                                        <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="lbCountNight" runat="server"></asp:Label>
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField SortExpression="GC_LamDem" HeaderText="LĐ (giờ)">
                                                                        <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                                        <ItemTemplate>
                                                                             <asp:Label ID="lbGC_LamDem" runat="server"></asp:Label>                                                                                                                
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>  
                                                                    
                                                                    <asp:TemplateField HeaderText="X dư">
                                                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                                         <ItemTemplate>
                                                                            <asp:Label ID="lbXDu" runat="server"></asp:Label>
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField HeaderText="HTCV">
                                                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="lbHTCV" runat="server"></asp:Label>
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                </Columns>
                                                                <HeaderStyle CssClass="grid-header" /> 
                                                                <RowStyle CssClass ="grid-item" />
                                                                <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                                                <PagerStyle CssClass="grid-paper" />  
                                                                <PagerSettings PageButtonCount="30" />
                                                            </asp:GridView>
                                                            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting"
                                                                SelectMethod="GetByStatistic1" TypeName="HRMBLL.H1.WorkdayEmployeesBLL" OldValuesParameterFormatString="original_{0}" OnSelected="ObjectDataSource1_Selected">
                                                                <SelectParameters>
                                                                    <asp:Parameter Name="deptIds" Type="String" />
                                                                    <asp:Parameter Name="month" Type="Int32" />
                                                                    <asp:Parameter Name="year" Type="Int32" />
                                                                    <asp:Parameter Name="debit" Type="Int32" />
                                                                    <asp:Parameter Name="hTCV" Type="String" />
                                                                    <asp:Parameter Name="workdayType" Type="Int32" />
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
<script type="text/javascript" src="../../JScripts/wz_tooltip.js"></script>        
</asp:Content>

