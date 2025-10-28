<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="PregnantAllownceList.aspx.cs" Inherits="CalculatedSalary_PregnantAllownceList" Title="Untitled Page" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
    <tr>
        <td valign="top">
            <table style="width: 100%">
                <tr>
                    <td>
                        <uc1:ucTitle ID="UcTitle1" runat="server" />                                                        
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <table style="width:100%">
                            <tr>
                                 <td style="width:10%" align="left">                                                                       
                                    <uc2:ActionMenu ID="ActionMenu1" runat="server" />
                                </td>
                                <td align="right">
                                     <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
                                        <asp:TextBox ID="txtFullName" runat="server" Width="100px" CssClass="textBox"></asp:TextBox>
                                        &nbsp;
                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
                                        <asp:DropDownList ID="ddlDepartments" runat="server" CssClass="dropDownList">
                                        </asp:DropDownList>
                                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tháng"></asp:Label>
                                       <asp:DropDownList ID="ddlMonths" runat="server" CssClass="dropDownList">
                                           <asp:ListItem Value="0" Text=""></asp:ListItem>
                                            <asp:ListItem Value="1" Text="1"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="2"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="3"></asp:ListItem>
                                            <asp:ListItem Value="4" Text="4"></asp:ListItem>
                                            <asp:ListItem Value="5" Text="5"></asp:ListItem>
                                            <asp:ListItem Value="6" Text="6"></asp:ListItem>
                                            <asp:ListItem Value="7" Text="7"></asp:ListItem>
                                            <asp:ListItem Value="8" Text="8"></asp:ListItem>
                                            <asp:ListItem Value="9" Text="9"></asp:ListItem>
                                            <asp:ListItem Value="10" Text="10"></asp:ListItem>
                                            <asp:ListItem Value="11" Text="11"></asp:ListItem>
                                            <asp:ListItem Value="12" Text="12"></asp:ListItem>
                                            
                                        </asp:DropDownList><asp:DropDownList ID="ddlYears" runat="server" CssClass="dropDownList" AppendDataBoundItems="true" >
                                       <asp:ListItem Value="0" Text=""></asp:ListItem>
                                        </asp:DropDownList>
                                </td>
                                <td>
                                    &nbsp;&nbsp;&nbsp;<asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif"
                                        OnClick="imgSearch_Click" />
                                </td>
                            </tr>                      
                        </table>                                                            
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <table width="100%" class="tableBorder">
                            <tr>
                                <td>
                                    <asp:GridView ID="grdPregnantAllownce" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                        CssClass="grid-Border" DataSourceID="ObjectDataSource1" PageSize="20" Width="100%" OnRowDataBound="grdPregnantAllownce_RowDataBound">
                                        <PagerSettings PageButtonCount="30" />
                                        <Columns>
                                            <asp:TemplateField HeaderText="Họ t&#234;n" SortExpression="FullName">
                                                <ItemTemplate>
                                                    <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Th&#225;ng năm &#225;p dụng" SortExpression="AllownceDate">
                                                <ItemTemplate>
                                                    <asp:Label ID="lbAllownceDate" runat="server"></asp:Label>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Gi&#225; trị" SortExpression="AllownceValue">
                                                <ItemTemplate>
                                                    <asp:Label ID="lbAllownceValue" runat="server"></asp:Label>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Right" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Lần thứ" SortExpression="IsCount">
                                                <ItemTemplate>
                                                    <asp:Label ID="lbIsCount" runat="server"></asp:Label>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="center" />
                                            </asp:TemplateField>
                                        </Columns>
                                        <RowStyle CssClass="grid-item" />
                                        <PagerStyle CssClass="grid-paper" />
                                        <HeaderStyle CssClass="grid-header" />
                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                    </asp:GridView>
                                </td>
                            </tr>
                        </table>
                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting"
                            SelectMethod="GetByFilter" TypeName="HRMBLL.H1.PregnantAllownceBLL" OldValuesParameterFormatString="original_{0}" OnSelected="ObjectDataSource1_Selected">
                            <SelectParameters>
                                <asp:Parameter Name="fullName" Type="String" />
                                <asp:Parameter Name="rootId" Type="Int32" />
                                <asp:Parameter Name="allownceDate" Type="DateTime" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                        
                    </td>
                </tr>                    
            </table>
            
        </td>
    </tr>
</table>
</asp:Content>

