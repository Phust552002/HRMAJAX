<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="EmployeeBankAccountList.aspx.cs" Inherits="Employee_EmployeeBankAccountList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc5" %>
<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table width="100%">   
    <tr>
        <td align="center" valign="top">
            <table width="100%">
                <tr>
                    <td>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
                            <ContentTemplate>  
                                <uc5:ucTitle ID="UcTitle1" runat="server" /> 
                            </ContentTemplate>
                             <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="imgSearch" EventName="Click" />
                             </Triggers>
                        </asp:UpdatePanel>                      
                    </td>
                </tr>
                <tr>
                    <td>
                        <table width="100%">
                            <tr>
                                <td style="width:90%" align="right">
                                    <table width="100%">
                                        <tr>                
                                            <td align="left" rowspan="2">
                                                <uc2:ActionMenu ID="ActionMenu1" runat="server" />
                                                </td>
                                            <td align="right">
                                                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
                                                    <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox></td>
                                            <td align="right">
                                                
                                                    <asp:Label ID="lbDepartment" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
                                                    <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList">
                                                    </asp:DropDownList>
                                            </td>
                                            <td align="right" rowspan="2">
                                                &nbsp;<asp:Button ID="imgSearch" runat="server"
                                                        Text="Xem" CssClass="small color green button" OnClick="imgSearch_Click" /></td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                                <asp:Label ID="Label4" runat="server" CssClass="label" Text="Số tài khoản"></asp:Label>
                                                <asp:TextBox
                                                    ID="txtAccountNo" runat="server" CssClass="textBox"></asp:TextBox></td>
                                            <td align="right">
                                                <asp:Label ID="Label5" runat="server" CssClass="label" Text="Số thẻ ATM"></asp:Label>
                                                <asp:TextBox
                                                    ID="txtCardNo" runat="server" CssClass="textBox"></asp:TextBox>
                                                <asp:DropDownList ID="ddlIsExists" runat="server" CssClass="dropDownList">
                                                    <asp:ListItem Value="0" Text=""></asp:ListItem>
                                                    <asp:ListItem Value="1" Text="C&#243; t&#224;i khoản"></asp:ListItem>
                                                    <asp:ListItem Value="2" Text="Chưa c&#243; t&#224;i khoản"></asp:ListItem>
                                                </asp:DropDownList></td>
                                        </tr>
                                        
                                    </table>
                                </td>
                            </tr>
                        </table>                             
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <table class="tableBorder" width="100%">
                         <tr>
                            <td>  
                                 <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                                 <ContentTemplate>
<asp:GridView id="grdEmployeesList" runat="server" Width="100%" CssClass="grid-Border" AllowSorting="True" AllowPaging="True" PageSize="20" OnRowDataBound="grdEmployeesList_RowDataBound" AutoGenerateColumns="False" DataSourceID="odsEmployees" DataKeyNames="UserId" OnSorting="grdEmployeesList_Sorting">
<PagerSettings PageButtonCount="30"></PagerSettings>

<RowStyle CssClass="grid-item"></RowStyle>
<Columns>
<asp:TemplateField HeaderText="Họ v&#224; t&#234;n" SortExpression="FullName"><ItemTemplate>
<asp:HyperLink id="lnkFullName" runat="server" CssClass="hyperlink-Grid" __designer:wfdid="w15">[lnkFullName]</asp:HyperLink> 
   <%-- <asp:Label id="Label4" runat="server" Text='<%# Bind("FullName") %>' __designer:wfdid="w31"></asp:Label> --%>
</ItemTemplate>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>

<ItemStyle HorizontalAlign="Left"></ItemStyle>
</asp:TemplateField>
<asp:TemplateField HeaderText="Chức danh" SortExpression="PositionName"><ItemTemplate>
<asp:Label id="Label0" runat="server" Text='<%# Bind("PositionName") %>' __designer:wfdid="w32"></asp:Label> 
</ItemTemplate>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>

<ItemStyle HorizontalAlign="Left"></ItemStyle>
</asp:TemplateField>
<asp:TemplateField HeaderText="Số t&#224;i khoản" SortExpression="AccountNo"><EditItemTemplate>
<asp:TextBox id="TextBox1" runat="server" Width="98%" CssClass="textBox" Text='<%# Bind("AccountNo") %>' __designer:wfdid="w35"></asp:TextBox> 
</EditItemTemplate>
<ItemTemplate>
<asp:Label id="Label1" runat="server" Text='<%# Bind("AccountNo") %>' __designer:wfdid="w34"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Số thẻ ATM" SortExpression="ATMNo"><EditItemTemplate>
<asp:TextBox id="TextBox2" runat="server" Width="98%" CssClass="textBox" Text='<%# Bind("ATMNo") %>' __designer:wfdid="w37"></asp:TextBox> 
</EditItemTemplate>
<ItemTemplate>
<asp:Label id="Label2" runat="server" Text='<%# Bind("ATMNo") %>' __designer:wfdid="w36"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="T&#234;n ng&#226;n h&#224;ng" SortExpression="BankName"><EditItemTemplate>
<asp:TextBox id="TextBox3" runat="server" Width="98%" CssClass="textBox" Text='<%# Bind("BankName") %>' __designer:wfdid="w39"></asp:TextBox> 
</EditItemTemplate>
<ItemTemplate>
<asp:Label id="Label3" runat="server" Text='<%# Bind("BankName") %>' __designer:wfdid="w38"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Trạng Th&#225;i"><EditItemTemplate>
<asp:Label id="lbStatus" runat="server" __designer:wfdid="w2"></asp:Label>
</EditItemTemplate>
<ItemTemplate>
<asp:Label id="lbStatus" runat="server" __designer:wfdid="w1"></asp:Label>
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Thao t&#225;c" ShowHeader="False"><EditItemTemplate>
        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="True" CommandName="Update" ImageUrl="~/Images/icon-save.gif"/>
        <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Cancel" ImageUrl="~/Images/icon-cancel.gif"/>
    
</EditItemTemplate>
<ItemTemplate>
        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Edit" ImageUrl="~/Images/icon-edit.gif"/>        
    
</ItemTemplate>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
</asp:TemplateField>
</Columns>

<PagerStyle CssClass="grid-paper"></PagerStyle>

<HeaderStyle CssClass="grid-header"></HeaderStyle>

<AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
</asp:GridView> <asp:ObjectDataSource id="odsEmployees" runat="server" OnUpdating="odsEmployees_Updating" SortParameterName="sortParameter" OnSelecting="odsEmployees_Selecting" TypeName="HRMBLL.H0.EmployeesBLL" SelectMethod="GetByFilterAccountBank" OnSelected="odsEmployees_Selected" UpdateMethod="UpdateAccountBank"><UpdateParameters>
<asp:Parameter Type="String" Name="accountNo"></asp:Parameter>
<asp:Parameter Type="String" Name="ATMNo"></asp:Parameter>
<asp:Parameter Type="String" Name="bankName"></asp:Parameter>
<asp:Parameter Type="Int32" Name="userId"></asp:Parameter>
<asp:Parameter Type="String" Name="positionName"></asp:Parameter>
<asp:Parameter Type="Int32" Name="UpdatedUser"></asp:Parameter>
</UpdateParameters>
<SelectParameters>
<asp:Parameter Type="String" Name="fullName"></asp:Parameter>
<asp:Parameter Type="Int32" Name="rootId"></asp:Parameter>
<asp:Parameter Type="String" Name="accountNo"></asp:Parameter>
<asp:Parameter Type="String" Name="CardNo"></asp:Parameter>
<asp:Parameter Type="Int32" Name="IsExists"></asp:Parameter>
<asp:Parameter Type="String" Name="sortParameter"></asp:Parameter>
</SelectParameters>
</asp:ObjectDataSource> 
</ContentTemplate>
                                     <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="imgSearch" EventName="Click" />
                                     </Triggers>
                                </asp:UpdatePanel>
                            </td>
                       </tr>
                    </table>
                        <uc1:ucPermission ID="UcPermission1" runat="server" />
                    </td>
                </tr>
                
            </table>
        </td>
    </tr>
    </table>
</asp:Content>

