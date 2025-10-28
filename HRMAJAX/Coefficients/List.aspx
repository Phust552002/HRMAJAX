<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="Coefficients_List" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc4" %>
<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table width="100%">
<tr>
    <td valign="top">
        <table style="width: 100%">
            <tr>
                <td>
                    <uc3:ucTitle ID="UcTitle1" runat="server" />
                    
                </td>
            </tr>
            <tr>
                <td>
                    <table style="width: 100%">
                        <tr>
                            <td align="left">
                                <uc4:ActionMenu ID="ActionMenu1" runat="server" />
                            </td>
                            <td align="right">
                                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên nhân viên"></asp:Label>
                                <asp:TextBox
                                    ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>&nbsp;
                                <asp:Label ID="Label2"
                                        runat="server" CssClass="label" Text="Phòng Ban "></asp:Label>&nbsp;<asp:DropDownList ID="ddlDepartment"
                                            runat="server" CssClass="dropDownList" DataSourceID="odsDepartments" DataTextField="DepartmentName"
                                            DataValueField="DepartmentId">
                                        </asp:DropDownList><asp:ObjectDataSource ID="odsDepartments" runat="server" OldValuesParameterFormatString="original_{0}"
                                            SelectMethod="GetAllRoots" TypeName="HRMBLL.H0.DepartmentsBLL"></asp:ObjectDataSource>
                                <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tháng"></asp:Label>&nbsp;<asp:DropDownList
                                    ID="ddlMonths" runat="server" CssClass="dropDownList">
                                </asp:DropDownList><asp:DropDownList
                                    ID="ddlYears" runat="server" CssClass="dropDownList">
                                </asp:DropDownList>&nbsp;
                                <asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif"
                                    OnClick="imgSearch_Click" /></td>
                        </tr>
                    </table>                    
                </td>
            </tr>                    
            <tr>
                <td>
                    <TABLE style="WIDTH: 100%" class="tableBorder">
                        <TR>
                            <TD>
                     <asp:GridView id="GridView2" runat="server" Width="100%" CssClass="grid-Border" DataSourceID="ObjectDataSource1" ShowFooter="True" AllowPaging="True" PageSize="20" AllowSorting="True" OnRowDataBound="GridView2_RowDataBound" AutoGenerateColumns="False">
                            <PagerSettings PageButtonCount="30"></PagerSettings>
                            <FooterStyle CssClass="grid-footer"></FooterStyle>
                            <Columns>
                            <asp:TemplateField SortExpression="UserId" HeaderText="M&#227; NV">
                            <ItemStyle Width="5%" HorizontalAlign="Left"></ItemStyle>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                            <ItemTemplate>
                               <asp:Label ID="lbUserId" runat="server"></asp:Label>                                                                    
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField SortExpression="FullName" HeaderText="Họ t&#234;n">
                            <ItemStyle HorizontalAlign="Left"></ItemStyle>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                            <ItemTemplate>
                              <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>                                                                    
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField SortExpression="PositionName" HeaderText="Chức danh">
                            <FooterTemplate>Tổng Cộng (tổng cộng%) :</FooterTemplate>
                            <ItemStyle Width="20%" HorizontalAlign="Left"></ItemStyle>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                            <ItemTemplate>
                               <asp:Label ID="lbPositionName" runat="server"></asp:Label>                                                                   
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField SortExpression="ContractTypeCode" HeaderText="Hợp đồng">
                            <ItemStyle Width="10%" HorizontalAlign="Left"></ItemStyle>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                            <ItemTemplate>
                              <asp:Label ID="Label1" runat="server" Text='<%# Bind("ContractTypeCode") %>'></asp:Label>                                                                    
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField SortExpression="LNS" HeaderText="LNS"><FooterTemplate>
                               <asp:Label ID="lbTotalLNS" runat="server"></asp:Label>                                                                    
                            </FooterTemplate>
                            <ItemStyle Width="10%" HorizontalAlign="Center"></ItemStyle>
                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                            <ItemTemplate>
                             <asp:Label ID="lbLNS" runat="server"></asp:Label>                                                                    
                            </ItemTemplate>
                            <FooterStyle HorizontalAlign="Center"></FooterStyle>
                            </asp:TemplateField>
                            <asp:TemplateField SortExpression="LCB" HeaderText="LCB"><FooterTemplate>
                              <asp:Label ID="lbTotalLCB" runat="server"></asp:Label>                                                                    
                            </FooterTemplate>
                            <ItemStyle Width="10%" HorizontalAlign="Center"></ItemStyle>
                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                            <ItemTemplate>
                               <asp:Label ID="lbLCB" runat="server"></asp:Label>                                                                    
                            </ItemTemplate>
                            <FooterStyle HorizontalAlign="Center"></FooterStyle>
                            </asp:TemplateField>
                            <asp:TemplateField SortExpression="PCDH" HeaderText="PCDH"><FooterTemplate>
                             <asp:Label ID="lbTotalPCDH" runat="server"></asp:Label>                                                                    
                            </FooterTemplate>
                            <ItemStyle Width="5%" HorizontalAlign="Center"></ItemStyle>
                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                            <ItemTemplate>
                             <asp:Label ID="lbPCDH" runat="server"></asp:Label>                                                                    
                            </ItemTemplate>
                            <FooterStyle HorizontalAlign="Center"></FooterStyle>
                            </asp:TemplateField>
                            <asp:TemplateField SortExpression="PCTN" HeaderText="PCTN"><FooterTemplate>
                             <asp:Label ID="lbTotalPCTN" runat="server"></asp:Label>                                                                    
                            </FooterTemplate>
                            <ItemStyle Width="5%" HorizontalAlign="Center"></ItemStyle>
                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                            <ItemTemplate>
                             <asp:Label ID="lbPCTN" runat="server"></asp:Label>                                                                    
                            </ItemTemplate>
                            <FooterStyle HorizontalAlign="Center"></FooterStyle>
                            </asp:TemplateField>
                            <asp:TemplateField SortExpression="PCKV" HeaderText="PCKV"><FooterTemplate>
                             <asp:Label ID="lbTotalPCKV" runat="server"></asp:Label>                                                                    
                            </FooterTemplate>
                            <ItemStyle Width="5%" HorizontalAlign="Center"></ItemStyle>
                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                            <ItemTemplate>
                             <asp:Label ID="lbPCKV" runat="server"></asp:Label>                                                                    
                            </ItemTemplate>
                            <FooterStyle HorizontalAlign="Center"></FooterStyle>
                            </asp:TemplateField>
                            <asp:TemplateField SortExpression="PCCV" HeaderText="PCCV"><FooterTemplate>
                             <asp:Label ID="lbTotalPCCV" runat="server"></asp:Label>                                                                                                                
                            </FooterTemplate>
                            <ItemStyle Width="5%" HorizontalAlign="Center"></ItemStyle>
                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                            <ItemTemplate>
                              <asp:Label ID="lbPCCV" runat="server"></asp:Label>                                                                    
                            </ItemTemplate>
                            <FooterStyle HorizontalAlign="Center"></FooterStyle>
                            </asp:TemplateField>
                            </Columns>
                            <RowStyle CssClass="grid-item"></RowStyle>
                            <PagerStyle CssClass="grid-paper"></PagerStyle>
                            <HeaderStyle CssClass="grid-header"></HeaderStyle>
                            <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                    </asp:GridView> 
                    <asp:ObjectDataSource id="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" TypeName="HRMBLL.H1.CoefficientEmployeeFinalBLL" SelectMethod="GetByFilter" OnSelected="ObjectDataSource1_Selected" OnSelecting="ObjectDataSource1_Selecting"><SelectParameters>
                    <asp:Parameter Type="String" Name="fullName"></asp:Parameter>
                    <asp:Parameter Type="Int32" Name="rootId"></asp:Parameter>
                    <asp:Parameter Type="Int32" Name="month"></asp:Parameter>
                    <asp:Parameter Type="Int32" Name="year"></asp:Parameter>
                    </SelectParameters>
                    </asp:ObjectDataSource> 
                            </TD>
                        </TR>
                    </TABLE>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                         <ProgressTemplate>
                             <asp:Image ID="Image2" runat="server" ImageUrl="~/images/run.gif" />
                             <asp:Label ID="Label4" runat="server" CssClass="value" Text="Đang Xử Lý..."></asp:Label>
                          </ProgressTemplate>
                    </asp:UpdateProgress>
                </td>
            </tr>
         </table>    
    </td>
</tr>
</table>
</asp:Content>

