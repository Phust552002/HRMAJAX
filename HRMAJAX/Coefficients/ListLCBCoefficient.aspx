<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ListLCBCoefficient.aspx.cs" Inherits="Coefficients_LCBCoeficientList" Title="SAGS :: Quản Lý Nhân Sự - Tiền Lương" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%">
<tr>
    <td valign="top">
        <table width="100%">
        <tr>
            <td colspan="2" valign="top">
                <uc1:ucTitle ID="UcTitle1" runat="server" />
            </td>
        </tr>
        <tr>
            <td valign="top">
            <table style="width: 100%">
                <tr>
                    <td>
                        <table style="width: 100%">
                            <tr>
                                <td align="left">
                                    <asp:ImageButton ID="imgAdd" runat="server" ImageUrl="~/Images/HRM-Icon-AddCoefficient.gif" OnClick="imgAdd_Click" /></td>
                                <td align="RIGHT">
                                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Chức danh hệ số"></asp:Label>
                                    <asp:TextBox ID="txtCoefficientName" runat="server" CssClass="textBox" Width="200px"></asp:TextBox>
                                    <asp:Label ID="Label3" runat="server" CssClass="label" Text="Theo bảng quy chế"></asp:Label>&nbsp;<asp:DropDownList
                                    ID="DropDownList1" runat="server" CssClass="dropDownList" DataSourceID="ObjectDataSource1"
                                    DataTextField="SalaryRegulationName" DataValueField="SalaryRegulationId">
                                </asp:DropDownList>&nbsp;<asp:ObjectDataSource ID="ObjectDataSource1" runat="server"
                                    SelectMethod="GetByFilter" TypeName="HRMBLL.H1.SalaryRegulationBLL" OldValuesParameterFormatString="original_{0}" OnSelecting="ObjectDataSource1_Selecting">
                                    <SelectParameters>
                                        <asp:Parameter Name="typeId" Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                                &nbsp;
                                    <asp:Button ID="btnFilter" runat="server" Text="Tìm" CssClass="small color green button" OnClick="btnFilter_Click" />
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
                        <asp:GridView ID="grdLCBCoefficients" runat="server" AutoGenerateColumns="False"
                            DataSourceID="odsLCB_Coefficients"  Width="100%" AllowPaging="True" PageSize="20" OnRowDataBound="grdLCBCoefficients_RowDataBound" CssClass="grid-Border">
                            <Columns>
                                <asp:TemplateField HeaderText="Chức danh hệ số">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="hyperlink-Grid" NavigateUrl='<%# Eval("CoefficientNameId", "~/Coefficients/DetailLCBCoefficient.aspx?Id={0}") %>'
                                            Text='<%# Eval("CoefficientName") %>'></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="CoefficientNameDescription" HeaderText="M&#244; tả" SortExpression="CoefficientNameDescription">
                                </asp:BoundField>
                                <asp:TemplateField HeaderText="Bậc 1" SortExpression="ValueLevel1">
                                    <ItemTemplate>
                                        <table cellpadding="0" cellspacing="0" style="width: 100%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbValue1" runat="server" ></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbCondition1" runat="server" ></asp:Label></td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Bậc 2" SortExpression="ValueLevel2">
                                    <ItemTemplate>
                                       <table cellpadding="0" cellspacing="0" style="width: 100%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbValue2" runat="server" ></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbCondition2" runat="server" ></asp:Label></td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Bậc 3" SortExpression="ValueLevel3">
                                    <ItemTemplate>
                                         <table cellpadding="0" cellspacing="0" style="width: 100%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbValue3" runat="server" ></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbCondition3" runat="server" ></asp:Label></td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Bậc 4" SortExpression="ValueLevel4">
                                    <ItemTemplate>
                                         <table cellpadding="0" cellspacing="0" style="width: 100%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbValue4" runat="server" ></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbCondition4" runat="server" ></asp:Label></td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Bậc 5" SortExpression="ValueLevel5">
                                    <ItemTemplate>
                                         <table cellpadding="0" cellspacing="0" style="width: 100%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbValue5" runat="server" ></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbCondition5" runat="server" ></asp:Label></td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Bậc 6" SortExpression="ValueLevel6">
                                    <ItemTemplate>
                                         <table cellpadding="0" cellspacing="0" style="width: 100%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbValue6" runat="server" ></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbCondition6" runat="server" ></asp:Label></td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Bậc 7" SortExpression="ValueLevel7">
                                    <ItemTemplate>
                                         <table cellpadding="0" cellspacing="0" style="width: 100%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbValue7" runat="server" ></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbCondition7" runat="server" ></asp:Label></td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Bậc 8" SortExpression="ValueLevel8">
                                    <ItemTemplate>
                                         <table cellpadding="0" cellspacing="0" style="width: 100%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbValue8" runat="server" ></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbCondition8" runat="server" ></asp:Label></td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Bậc 9" SortExpression="ValueLevel9">
                                    <ItemTemplate>
                                         <table cellpadding="0" cellspacing="0" style="width: 100%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbValue9" runat="server" ></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbCondition9" runat="server" ></asp:Label></td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Bậc 10" SortExpression="ValueLevel10">
                                    <ItemTemplate>
                                         <table cellpadding="0" cellspacing="0" style="width: 100%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbValue10" runat="server" ></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbCondition10" runat="server" ></asp:Label></td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Bậc 11" SortExpression="ValueLevel11">
                                    <ItemTemplate>
                                         <table cellpadding="0" cellspacing="0" style="width: 100%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbValue11" runat="server" ></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbCondition11" runat="server" ></asp:Label></td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Bậc 12" SortExpression="ValueLevel12">
                                    <ItemTemplate>
                                         <table cellpadding="0" cellspacing="0" style="width: 100%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbValue12" runat="server" ></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbCondition12" runat="server" ></asp:Label></td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <HeaderStyle CssClass="grid-header" /> 
                            <RowStyle CssClass ="grid-item" />
                            <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                            <PagerStyle CssClass="grid-paper" />  
                            <EmptyDataTemplate>
                                <asp:Label ID="Label2" runat="server" CssClass="value" Text="Chưa có thông tin về danh mục hẹ số lương cơ bản"></asp:Label>
                            </EmptyDataTemplate>
                        </asp:GridView>
                        <asp:ObjectDataSource ID="odsLCB_Coefficients" runat="server" SelectMethod="GetByFilte"
                            TypeName="HRMBLL.H1.CoefficientNamesBLL" OldValuesParameterFormatString="original_{0}" OnSelecting="odsLCB_Coefficients_Selecting">
                            <SelectParameters>
                                <asp:Parameter DefaultValue="1" Name="type" Type="Int32" />
                                <asp:Parameter Name="coefficientName" Type="String" />
                                <asp:Parameter Name="SalaryRegulationId" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                            </td>
                        </tr>
                    </table>
                    </td>
                </tr>
                <tr>
                    <td>
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


