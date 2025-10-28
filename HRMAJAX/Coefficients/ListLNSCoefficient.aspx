<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ListLNSCoefficient.aspx.cs" Inherits="Coefficients_LNSCoefficientList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

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
                <td align="center" valign="top">
                    <table style="width: 100%" >
                        
                        <tr>
                            <td align="left">
                                <asp:ImageButton ID="imgAddCoefficients" runat="server" ImageUrl="~/Images/HRM-Icon-AddCoefficient.gif" OnClick="imgAddCoefficients_Click" ToolTip="Định nghĩa hệ số lương năng suất" />
                            </td>
                            <td align="right">
                                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Chức danh hệ số"></asp:Label>
                                <asp:TextBox ID="txtCoefficientName" runat="server" CssClass="textBox" Width="200px"></asp:TextBox>&nbsp;&nbsp;
                                <asp:Label ID="Label3" runat="server" CssClass="label" Text="Theo bảng quy chế"></asp:Label>&nbsp;<asp:DropDownList
                                    ID="DropDownList1" runat="server" CssClass="dropDownList" DataSourceID="ObjectDataSource1"
                                    DataTextField="SalaryRegulationName" DataValueField="SalaryRegulationId">
                                </asp:DropDownList>&nbsp;<asp:ObjectDataSource ID="ObjectDataSource1" runat="server"
                                    SelectMethod="GetByFilter" TypeName="HRMBLL.H1.SalaryRegulationBLL" OldValuesParameterFormatString="original_{0}" OnSelecting="ObjectDataSource1_Selecting">
                                    <SelectParameters>
                                        <asp:Parameter Name="typeId" Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                                
                                <asp:RadioButton ID="rdoSalary1" runat="server" CssClass="label" Text="Chức danh" TextAlign="Left" GroupName="rdoLNS" Checked="true"/>
                                <asp:RadioButton ID="rdoSalary2" runat="server" CssClass="label" Text="Khoán" TextAlign="Left" GroupName="rdoLNS"/>
                                &nbsp;
                                <asp:Button ID="btnFilter" runat="server" Text="Xem" CssClass="small color green button" OnClick="btnFilter_Click" />
                            </td>
                        </tr>
                   
                        <tr>
                            <td colspan="2" valign="top">
                                <table class="tableBorder" width="100%">
                                    <tr>
                                        <td> 
                                <asp:GridView ID="grdLNSCoefficients" runat="server" AutoGenerateColumns="False" DataSourceID="odsLNS_Coefficients" DataKeyNames="CoefficientNameId" Width="100%"  AllowPaging="True" PageSize="20" OnRowDataBound="grdLNSCoefficients_RowDataBound" CssClass="grid-Border">
                                    <Columns>
                                        <asp:TemplateField HeaderText="Chức danh hệ số">
                                            <ItemStyle CssClass="hyperlink-Grid" HorizontalAlign="Left" />
                                            <ItemTemplate>
                                                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="hyperlink-Grid" NavigateUrl='<%# Eval("CoefficientNameId", "~/Coefficients/DetailLNSCoefficient.aspx?Id={0}") %>'
                                                    Text='<%# Eval("CoefficientName") %>'></asp:HyperLink>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="CoefficientNameDescription" HeaderText="M&#244; tả"
                                            SortExpression="CoefficientNameDescription">
                                       </asp:BoundField>    
                                        <asp:BoundField DataField="ValueLevel1" HeaderText="Mức 1" SortExpression="ValueLevel1" DataFormatString="{0:###0.00}" HtmlEncode="False">
                                       </asp:BoundField>   
                                        <asp:BoundField DataField="ValueLevel2" HeaderText="Mức 2" SortExpression="ValueLevel2" DataFormatString="{0:###0.00}" HtmlEncode="False">
                                       </asp:BoundField>   
                                        <asp:BoundField DataField="ValueLevel3" HeaderText="Mức 3" SortExpression="ValueLevel3" DataFormatString="{0:###0.00}" HtmlEncode="False">
                                       </asp:BoundField>   
                                        <asp:BoundField DataField="ValueLevel4" HeaderText="Mức 4" SortExpression="ValueLevel4" DataFormatString="{0:###0.00}" HtmlEncode="False">
                                       </asp:BoundField>   
                                        <asp:BoundField DataField="ValueLevel5" HeaderText="Mức 5" SortExpression="ValueLevel5" DataFormatString="{0:###0.00}" HtmlEncode="False">
                                       </asp:BoundField>
                                      
                                    </Columns>
                                        <HeaderStyle CssClass="grid-header" /> 
                                        <RowStyle CssClass ="grid-item" />
                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                        <PagerStyle CssClass="grid-paper" />  
                                    <EmptyDataTemplate>
                                        <asp:Label ID="Label2" runat="server" CssClass="value" Text="Chưa có thông tin về danh mục hệ số lương năng suất"></asp:Label>
                                    </EmptyDataTemplate>
                                    
                                </asp:GridView>
                                <asp:ObjectDataSource ID="odsLNS_Coefficients" runat="server" SelectMethod="GetByFilter"
                                    TypeName="HRMBLL.H1.CoefficientNamesBLL" OnSelecting="odsLNS_Coefficients_Selecting" OldValuesParameterFormatString="original_{0}">
                                    <SelectParameters>
                                        <asp:Parameter Name="type" Type="Int32" />
                                        <asp:Parameter Name="coefficientName" Type="String" />
                                        <asp:Parameter Name="SalaryRegulationId" Type="Int32" />
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
    </td>
 </tr>
</table>   
</asp:Content>

