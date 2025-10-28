<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="BonusList.aspx.cs" Inherits="Bonus_BonusList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <telerik:RadWindowManager ID="RadWindowManager" runat="server"></telerik:RadWindowManager>

<telerik:RadWindow ID="rwEditLive" 
    runat="server" 
    Title="Xác nhận thao tác" 
    VisibleOnPageLoad="false" 
    Width="400px" 
    Height="200px"
    Modal="true" 
    Behaviors="None" 
    KeepInScreenBounds="true"
    CssClass="rwCustom">
    <ContentTemplate>
        <div style="display:flex; flex-direction:column; justify-content:center; align-items:center; height:100%; padding:0px;">

            <div style="text-align:center; margin-bottom:25px;">
                <span style="font-size:16px; color:#333; font-weight:500;">
                    Bạn có chắc muốn <b>HIỆN tất cả</b> các dòng trong bảng không?
                </span>
            </div>

            <div style="display:flex; justify-content:center; gap:12px;">
                <asp:Button ID="btnEditLive" 
                            runat="server" 
                            Text="✅ Chấp nhận" 
                            CssClass="rw-btn rw-btn-accept" 
                            OnClick="btnEditLive_Click" />

                <asp:Button ID="btnCancelLive" 
                            runat="server" 
                            Text="❌ Hủy" 
                            CssClass="rw-btn rw-btn-cancel" 
                            OnClick="btnCancelLive_Click" />
            </div>

        </div>
    </ContentTemplate>
</telerik:RadWindow>


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
        <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
        <asp:DropDownList ID="ddlDepartment" runat="server"
            DataSourceID="odsDepartment"
            DataTextField="DepartmentName"
            DataValueField="DepartmentId"
            CssClass="dropDownList">
        </asp:DropDownList>
        &nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Năm"></asp:Label>
        <asp:DropDownList ID="ddlYears" runat="server"
            CssClass="dropDownList"
            AutoPostBack="true"
            OnSelectedIndexChanged="ddlYears_SelectedIndexChanged">
        </asp:DropDownList>
        &nbsp;&nbsp;
        <asp:Label ID="lblMonth" runat="server" CssClass="label" Text="Tháng"></asp:Label>
        <asp:DropDownList ID="ddlMonths" runat="server" CssClass="dropDownList"
            AutoPostBack="true" OnSelectedIndexChanged="ddlMonths_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Loại tiền thưởng"></asp:Label>
        <asp:DropDownList ID="ddlBonusName" runat="server" CssClass="dropDownList">
        </asp:DropDownList>

        <asp:ObjectDataSource ID="odsDepartment" runat="server"
            OldValuesParameterFormatString="original_{0}"
            SelectMethod="GetAllRoots"
            TypeName="HRMBLL.H0.DepartmentsBLL">
        </asp:ObjectDataSource>
    </td>

    <td align="right" colspan="2" rowspan="2">
        <asp:Button ID="btnView" runat="server" Text="Xem"
            OnClick="btnView_Click"
            CssClass="small color green button" />
    </td>
</tr>
<tr>
    <td align="right">
        <asp:Label ID="lblMessage" Style="font-size:10px;color:red" runat="server" Visible="false" CssClass="messageLabel"></asp:Label>
        <asp:Button ID="btnViewOn" runat="server" Text="Hiện" OnClick="btnViewOn_Click" CssClass="small color blue button"/>
    </td>
</tr>
                   
                    <tr>
                        <td colspan="2">
                         <table class="tableBorder" width="100%">
                            <tr>
                                <td> 
                                    <asp:GridView ID="grdBonusList" runat="server" AutoGenerateColumns="False" DataSourceID="odsBonusList"
                                        Width="100%" AllowPaging="True" PageSize="50" OnRowDataBound="grdBonusList_RowDataBound" CssClass="grid-Border" ShowFooter="True" >
                                        <Columns>
                                            <asp:TemplateField HeaderText="Họ v&#224; t&#234;n " SortExpression="FullName">
                                                <ItemTemplate>                                            
                                                    <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="PositionName" HeaderText="Chức danh" SortExpression="PositionName" />
                                            <asp:BoundField DataField="DepartmentName" HeaderText="Ph&#242;ng ban" SortExpression="DepartmentName" />
                                            <asp:TemplateField HeaderText="Số tiền (VND)" SortExpression="BonusValue">
                                                <ItemStyle HorizontalAlign="Right" />
                                                <ItemTemplate>
                                                    <asp:Label ID="Label1" runat="server" Text='<%# String.Format("{0:N0}", Eval("ThucLinh")) %>'></asp:Label>
                                                </ItemTemplate>
                                                <FooterTemplate>
                                                    <asp:Label ID="lbSum_BonusValue" runat="server"></asp:Label>
                                                </FooterTemplate>
                                                <FooterStyle HorizontalAlign="Right" />
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Ngày chi" SortExpression="PayDate">
                                                <ItemStyle HorizontalAlign="Center" />
                                                <ItemTemplate>
                                                     <asp:Label ID="lbPayDate" runat="server" ></asp:Label>
                                                 </ItemTemplate>
                                               
                                            </asp:TemplateField>

                                            <asp:BoundField DataField="BonusYear" HeaderText="Năm" SortExpression="BonusYear">
                                                <ItemStyle HorizontalAlign="Center" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="BonusTitle" HeaderText="Loại tiền thưởng" SortExpression="BonusTitle" />
                                            <asp:BoundField HeaderText="Chi tiết thưởng" DataField="BonusTitleDetail" /> 
                                            <asp:BoundField HeaderText="Hide" DataField="Hide" /> 

                                        </Columns>
                                        <FooterStyle CssClass="grid-footer" />
                                        <HeaderStyle CssClass="grid-header" /> 
                                        <RowStyle CssClass ="grid-item" />
                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                        <PagerStyle CssClass="grid-paper" /> 
                                        <PagerSettings PageButtonCount="30" />
                                    </asp:GridView>
                                    <asp:ObjectDataSource ID="odsBonusList" runat="server" OnSelecting="odsBonusList_Selecting"
                                        SelectMethod="GetByFilter" TypeName="HRMBLL.H1.BonusEmployeeConditionBLL" OnSelected="odsBonusList_Selected">
                                        <SelectParameters>
                                            <asp:Parameter Name="fullName" Type="String" />
                                            <asp:Parameter Name="departmentId" Type="Int32" />
                                            <asp:Parameter Name="year" Type="Int32" />
                                            <asp:Parameter Name="bonusTitleId" Type="Int32" />
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


