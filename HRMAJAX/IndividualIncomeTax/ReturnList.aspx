<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ReturnList.aspx.cs" Inherits="IndividualIncomeTax_ReturnList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<table width="100%"  class="bgEachPage">
    <tr>
        <td valign="top">
            <table width="100%" border="0">
                <tr>
                    <td colspan="2">
                        <uc1:ucTitle ID="UcTitle1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên nhân viên"></asp:Label>
                        <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox" ></asp:TextBox>
                        &nbsp;&nbsp;
                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
                        <asp:DropDownList ID="ddlDepartment" runat="server" DataSourceID="odsDepartment"
                            DataTextField="DepartmentName" DataValueField="DepartmentId" CssClass="dropDownList" >
                        </asp:DropDownList>
                        &nbsp;&nbsp;
                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Năm"></asp:Label>
                        <asp:DropDownList ID="ddlYears" runat="server" CssClass="dropDownList">
                        </asp:DropDownList>
                        <asp:ObjectDataSource ID="odsBonuName" runat="server" SelectMethod="GetByIds" TypeName="HRMBLL.H.BonusNamesBLL" OldValuesParameterFormatString="original_{0}" OnSelecting="odsBonuName_Selecting">
                            <SelectParameters>
                                <asp:Parameter Name="bonusNameIds" Type="String" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                        
                        <asp:ObjectDataSource ID="odsDepartment" runat="server"
                            OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllRoots"
                            TypeName="HRMBLL.H0.DepartmentsBLL">
                        </asp:ObjectDataSource>
                    </td>
                    <td align="right" rowspan="2">
                        <asp:Button ID="btnView" runat="server" Text="Xem" OnClick="btnView_Click" CssClass="small color green button" /></td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Loại tiền thuế"></asp:Label>&nbsp;<asp:DropDownList ID="ddlBonusName" runat="server" CssClass="dropDownList" DataSourceID="odsBonuName" DataTextField="BonusName" DataValueField="BonusNameId">
                        </asp:DropDownList></td>
                </tr>
               
                <tr>
                    <td colspan="2">
                     <table class="tableBorder" width="100%">
                        <tr>
                            <td> 
                                <asp:GridView ID="grdBonusList" runat="server" AutoGenerateColumns="False" DataSourceID="odsBonusList"
                                    Width="100%" AllowPaging="True" PageSize="20" OnRowDataBound="grdBonusList_RowDataBound" CssClass="grid-Border" >
                                    <Columns>
                                        <asp:TemplateField HeaderText="Họ v&#224; t&#234;n " SortExpression="FullName">
                                            <ItemTemplate>                                            
                                                <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="PositionName" HeaderText="Chứ danh" SortExpression="PositionName" />
                                        <asp:BoundField DataField="DepartmentName" HeaderText="Ph&#242;ng ban" SortExpression="DepartmentName" />
                                        <asp:BoundField DataField="BonusValue" HeaderText="Số tiền (VND)" SortExpression="BonusValue" DataFormatString="{0:#,###0.00}" HtmlEncode="False">
                                            <ItemStyle HorizontalAlign="Right" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="BonusYear" HeaderText="Năm" SortExpression="BonusYear">
                                            <ItemStyle HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="BonusName" HeaderText="Loại tiền thưởng" SortExpression="BonusName" />
                                    </Columns>
                                     <HeaderStyle CssClass="grid-header" /> 
                                    <RowStyle CssClass ="grid-item" />
                                    <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                    <PagerStyle CssClass="grid-paper" /> 
                                    <PagerSettings PageButtonCount="30" />
                                </asp:GridView>
                                <asp:ObjectDataSource ID="odsBonusList" runat="server" OnSelecting="odsBonusList_Selecting"
                                    SelectMethod="GetByFilter" TypeName="HRMBLL.H.BonusValuesBLL" OnSelected="odsBonusList_Selected">
                                    <SelectParameters>
                                        <asp:Parameter Name="fullName" Type="String" />
                                        <asp:Parameter Name="departmentId" Type="Int32" />
                                        <asp:Parameter Name="year" Type="Int32" />
                                        <asp:Parameter Name="bonusNameId" Type="Int32" />
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


