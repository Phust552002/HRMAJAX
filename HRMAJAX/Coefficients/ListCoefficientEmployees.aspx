<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ListCoefficientEmployees.aspx.cs" Inherits="Coefficients_CoefficientEmployeesList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc3" %>

<%@ Register Src="../UserControls/HeaderContent.ascx" TagName="HeaderContent" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/ucDepartmentFilter.ascx" TagName="ucDepartmentFilter" TagPrefix="uc1" %>

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
                        <td align="right">
                                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
                                <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                            &nbsp;
                                <asp:Label ID="lbDepartment" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
                                <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList">
                                </asp:DropDownList>&nbsp; &nbsp;<asp:Label ID="Label9" runat="server" CssClass="label"
                                    Text="Mức hưởng LNS"></asp:Label>&nbsp;<asp:DropDownList ID="ddlOperatorLNS" runat="server" CssClass="dropDownList">
                                        <asp:ListItem></asp:ListItem>
                                        <asp:ListItem>=</asp:ListItem>
                                        <asp:ListItem>&gt;</asp:ListItem>
                                        <asp:ListItem>&lt;</asp:ListItem>
                                        <asp:ListItem>&gt;=</asp:ListItem>
                                        <asp:ListItem>&lt;=</asp:ListItem>
                                    </asp:DropDownList><asp:TextBox ID="txtWagesLNS" runat="server" Width="40px" CssClass="textBox"></asp:TextBox>&nbsp;
                                    <asp:Label ID="Label14" runat="server" CssClass="label"
                                    Text="Mức hưởng LCB"></asp:Label>&nbsp;<asp:DropDownList ID="ddlOperatorLCB" runat="server" CssClass="dropDownList">
                                        <asp:ListItem></asp:ListItem>
                                        <asp:ListItem>=</asp:ListItem>
                                        <asp:ListItem>&gt;</asp:ListItem>
                                        <asp:ListItem>&lt;</asp:ListItem>
                                        <asp:ListItem>&gt;=</asp:ListItem>
                                        <asp:ListItem>&lt;=</asp:ListItem>
                                    </asp:DropDownList><asp:TextBox ID="txtWagesLCB" runat="server" Width="40px" CssClass="textBox"></asp:TextBox>&nbsp;
                                    <asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif" OnClick="btnView_Click" />
                        </td>
                    </tr>
                    
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table class="tableBorder" width="100%">
                    <tr>
                        <td>                            
                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1"
                                Width="100%" OnRowDataBound="GridView2_RowDataBound" CssClass="grid-Border" AllowSorting="True" PageSize="20" OnSorting="GridView2_Sorting" AllowPaging="True" ShowFooter="True">
                                <Columns>
                                    <asp:TemplateField HeaderText="M&#227; NV" SortExpression="UserId">
                                        <ItemTemplate>
                                            <asp:Label ID="lbUserId" runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Left" Width="5%"/>
                                        <HeaderStyle HorizontalAlign="Left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Họ t&#234;n" SortExpression="FullName">
                                        <ItemTemplate>
                                            <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Left"/>
                                        <HeaderStyle HorizontalAlign="Left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Chức danh" SortExpression="PositionName">
                                        <ItemTemplate>
                                            <asp:Label ID="lbPositionName" runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Left" Width="20%"/>
                                        <HeaderStyle HorizontalAlign="Left" />
                                        <FooterTemplate>
                                            Tổng Cộng (tổng cộng%) :
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Hợp đồng" SortExpression="ContractTypeCode">
                                        <ItemTemplate>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("ContractTypeCode") %>'></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Left" Width="10%"/>
                                        <HeaderStyle HorizontalAlign="Left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="LNS" SortExpression="LNS">
                                        <ItemTemplate>
                                            <asp:Label ID="lbLNS" runat="server" CssClass="value-bold"></asp:Label><asp:Label ID="lbLNSWage" runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="10%"/>
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <FooterTemplate>
                                            <asp:Label ID="lbTotalLNS" runat="server"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="LCB" SortExpression="LCB">
                                        <ItemTemplate>
                                            <asp:Label ID="lbLCB" runat="server" CssClass="value-bold"></asp:Label><asp:Label ID="lbLCBWage" runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="10%"/>
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <FooterTemplate>
                                            <asp:Label ID="lbTotalLCB" runat="server"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="PCDH" SortExpression="PCDH">
                                        <ItemTemplate>
                                            <asp:Label ID="lbPCDH" runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="5%"/>
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <FooterStyle HorizontalAlign="Center" />
                                        <FooterTemplate>
                                            <asp:Label ID="lbTotalPCDH" runat="server"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="PCTN" SortExpression="PCTN">
                                        <ItemTemplate>
                                            <asp:Label ID="lbPCTN" runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="5%"/>
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <FooterStyle HorizontalAlign="Center" />
                                        <FooterTemplate>
                                            <asp:Label ID="lbTotalPCTN" runat="server"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="PCKV" SortExpression="PCKV">
                                        <ItemTemplate>
                                            <asp:Label ID="lbPCKV" runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="5%"/>
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <FooterStyle HorizontalAlign="Center" />
                                        <FooterTemplate>
                                            <asp:Label ID="lbTotalPCKV" runat="server"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="PCCV" SortExpression="PCCV">
                                        <ItemTemplate>
                                            <asp:Label ID="lbPCCV" runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="5%"/>
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <FooterStyle HorizontalAlign="Center" />
                                        <FooterTemplate>
                                            <asp:Label ID="lbTotalPCCV" runat="server"></asp:Label>                                            
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <HeaderStyle CssClass="grid-header" /> 
                                <RowStyle CssClass ="grid-item" />
                                <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                <PagerStyle CssClass="grid-paper" /> 
                                <FooterStyle CssClass="grid-footer" />                                  
                                <PagerSettings PageButtonCount="30" />
                            </asp:GridView>                                                        
                            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting"
                                SelectMethod="AllCoefficientEmployeeGetByFilter" TypeName="HRMBLL.H1.CoefficientEmployeesBLL" OnSelected="ObjectDataSource1_Selected" OldValuesParameterFormatString="original_{0}">
                                <SelectParameters>
                                    <asp:Parameter Name="fullName" Type="String" />
                                    <asp:Parameter Name="departmentId" Type="Int32" />
                                    <asp:Parameter Name="LNSwages" Type="Int32" />
                                    <asp:Parameter Name="LNSstrOperator" Type="String" />
                                    <asp:Parameter Name="LCBwages" Type="Int32" />
                                    <asp:Parameter Name="LCBstrOperator" Type="String" />
                                    <asp:Parameter Name="sortParameter" Type="String" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
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

