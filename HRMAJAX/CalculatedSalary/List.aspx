<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="CalculatedSalary_List" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc4" %>
<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%">
        <tr>
            <td valign="top">
                <table style="width: 100%">
                    <tr>
                        <td colspan="2" valign="top">
                            <uc3:ucTitle ID="UcTitle1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right"> 
                            <table width="100%">
                                <tr>
                                    <td style="width:10%" align="left">                                                                       
                                        <uc4:ActionMenu ID="ActionMenu1" runat="server" />
                                    </td>
                                    <td align="right">
                                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên nhân viên"></asp:Label>
                                        <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>&nbsp;
                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Phòng Ban "></asp:Label>
                                        <asp:DropDownList ID="ddlDepartment" runat="server" DataSourceID="odsDepartments"
                                            DataTextField="DepartmentName" DataValueField="DepartmentId" CssClass="dropDownList">
                                        </asp:DropDownList>&nbsp; &nbsp;<asp:ObjectDataSource ID="odsDepartments" runat="server" SelectMethod="GetAllRoots" TypeName="HRMBLL.H0.DepartmentsBLL" OldValuesParameterFormatString="original_{0}">
                                        </asp:ObjectDataSource>
                                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tháng"></asp:Label>
                                        <asp:DropDownList ID="ddlMonths" runat="server" CssClass="dropDownList"></asp:DropDownList>
                                        &nbsp;
                                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Năm"></asp:Label>&nbsp;<asp:DropDownList ID="ddlYears" runat="server" CssClass="dropDownList">
                                        </asp:DropDownList>
                                        &nbsp;&nbsp;&nbsp;<asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif"
                                            OnClick="imgSearch_Click" />&nbsp;&nbsp;
                                    </td>
                                    <td></td>
                                </tr>
                            </table>                                                                                                              
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table class="tableBorder">
                                <tr>
                                    <td>
                                     <div class="scrollcontent400">
                                     <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="odsEmployeeIncomes"
                                            OnRowDataBound="GridView2_RowDataBound" CssClass="grid-Border" AllowSorting="True" PageSize="20" OnSorting="GridView2_Sorting" AllowPaging="True" ShowFooter="True" Width="2000px">
                                            <HeaderStyle CssClass="grid-header" /> 
                                            <RowStyle CssClass ="grid-item" />
                                            <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                            <PagerStyle CssClass="grid-paper" /> 
                                            <FooterStyle CssClass="grid-footer" />                                  
                                            <PagerSettings PageButtonCount="30" />
                                            <Columns>
                                                <asp:TemplateField HeaderText="Họ T&#234;n" SortExpression="FullName">
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" Width="200px"/>
                                                    <HeaderStyle HorizontalAlign="Left" Width="200px"/>
                                                    <FooterStyle HorizontalAlign="Left" />
                                                    <FooterTemplate>
                                                        Tổng Cộng
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Lương năng suất" SortExpression="LNS">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbLNS" runat="server" ></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbLNSTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Lương năng suất dư" SortExpression="LNSBalance">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbLNSBalance" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbLNSBalanceTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Lương cơ bản" SortExpression="LCBNN">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbLCBNN" runat="server" ></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbLCBNNTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="PCCV" SortExpression="PCCV">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbPCCV" runat="server" ></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbPCCVTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="PCTN" SortExpression="PCTN">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbPCTN" runat="server" ></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbPCTNTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="PCDH" SortExpression="PCDH">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbPCDH" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbPCDHTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Trợ Cấp BHXH" SortExpression="TCBHXH">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTCBHXH" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbTCBHXHTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Trợ Cấp Ốm" SortExpression="TCom">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTCom" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbTCOmTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                 <asp:TemplateField HeaderText="Trợ Cấp Thai Sản 1 lần" SortExpression="TCTS1Lan">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTCTS1Lan" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbTCTS1LanTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Ăn giữa ca" SortExpression="TienAn">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTienAn" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbTienAnTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Bổ sung lương" SortExpression="BoSungLuong">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbBoSungLuong" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbBoSungLuongTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Tiền th&#234;m giờ" SortExpression="TienThemGio">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTienThemGio" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbTienThemGioTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Tiền L&#224;m Đ&#234;m" SortExpression="TienLamDem">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTienLamDem" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbTienLamDemTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Tổng lương ngắn hạn" SortExpression="TotalShortTerm">                                                   
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTotalShortTerm" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                     <ItemStyle HorizontalAlign="Right" />
                                                     <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbTotalShortTermTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Tiền Thưởng" SortExpression="TienThuong">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTienThuong" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbTienThuongTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Tiền Thưởng dư" SortExpression="BonusBalance">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbBonusBalance" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbBonusBalanceTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Tổng" SortExpression="TotalIncome">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTotalIncome" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbTotalIncomeTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Tr&#237;ch BHXH" SortExpression="TrBHXH">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTrBHXH" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbTrBHXHTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Tr&#237;ch BHYT" SortExpression="TrBHYT">                                                    
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTrBHYT" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                     <FooterTemplate>
                                                        <asp:Label ID="lbTrBHYTTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Tr&#237;ch ĐPCĐ" SortExpression="TrDoanPhi">                                                    
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTrDoanPhi" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbTrDoanPhiTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Tr&#237;ch TTN" SortExpression="ThueThuNhap">                                                    
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbThueThuNhap" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbThueThuNhapTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Tr&#237;ch BHTN" SortExpression="TrBHTN">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTrBHTN" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbTrBHTNTotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Lương Kỳ I" SortExpression="TotalPeriod_I">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTotalPeriod_I" runat="server" CssClass="value-bold"></asp:Label>
                                                    </ItemTemplate>
                                                     <FooterTemplate>
                                                        <asp:Label ID="lbTotalPeriod_ITotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Th&#224;nh Tiền" SortExpression="TotalPeriod_II">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbTotalPeriod_II" runat="server" CssClass="value-bold"></asp:Label>                                                        
                                                    </ItemTemplate>
                                                     <FooterTemplate>
                                                        <asp:Label ID="lbTotalPeriod_IITotal" runat="server"></asp:Label>
                                                    </FooterTemplate>
                                                    <ItemStyle HorizontalAlign="Right" />
                                                    <FooterStyle HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                     </div>   
                                        <asp:ObjectDataSource ID="odsEmployeeIncomes" runat="server" OnSelecting="odsEmployeeIncomes_Selecting"
                                            SelectMethod="GetAllByFilter" TypeName="HRMBLL.H1.IncomesBLL" OldValuesParameterFormatString="original_{0}" OnSelected="odsEmployeeIncomes_Selected">
                                            <SelectParameters>
                                                <asp:Parameter Name="fullName" Type="String" />
                                                <asp:Parameter Name="departmentId" Type="Int32" />
                                                <asp:Parameter Name="month" Type="Int32" />
                                                <asp:Parameter Name="year" Type="Int32" />
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
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>
<script type="text/javascript" src="../JScripts/script.js"></script>
</asp:Content>

