<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="CongDu.aspx.cs" Inherits="Administrator_CongDu" Title="Untitled Page" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%">
        <tr>
            <td colspan="2">
                <uc1:ucTitle ID="UcTitle1" runat="server" />
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label id="Label3" runat="server" CssClass="label" Text="Họ tên"></asp:Label>
                <asp:TextBox id="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                &nbsp;
                <asp:Label ID="lbDepartment" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>&nbsp;<asp:DropDownList
                    ID="ddlDepartment" runat="server" CssClass="dropDownList">
                </asp:DropDownList>
                &nbsp;
                <asp:Label id="Label11" runat="server" CssClass="label" Text="Tháng"></asp:Label>&nbsp;<asp:DropDownList id="ddlMonths" runat="server" CssClass="dropDownList"><asp:ListItem>1</asp:ListItem>
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
                <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                &nbsp;
                <asp:Label id="Label12" runat="server" CssClass="label" Text="Năm"></asp:Label>&nbsp;<asp:DropDownList id="ddlYears" runat="server" CssClass="dropDownList"></asp:DropDownList>
            </td>
            <td>
                &nbsp;<asp:ImageButton id="imgSearch" onclick="imgSearch_Click" runat="server" ImageUrl="~/Images/Icon-Search.gif"></asp:ImageButton>&nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <table class="tableBorder" width="100%">
                    <tr>
                        <td>
                             <asp:GridView ID="grdWorkdayEmployees" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    CssClass="grid-Border" DataKeyNames="UserId" DataSourceID="ObjectDataSource1"
                    OnRowDataBound="grdWorkdayEmployees_RowDataBound" PageSize="20" Width="100%">
                    <PagerSettings PageButtonCount="30" />
                    <Columns>
                        <asp:TemplateField HeaderText="Họ t&#234;n" SortExpression="FullName">
                            <ItemStyle HorizontalAlign="Left" Width="25%" />
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkFullName" runat="server" CommandName="Select" CssClass="hyperlink-Grid"
                                    Text='<%# Bind("FullName") %>' ToolTip='<%# Bind("UserId") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Xqđ" SortExpression="XQD">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <ItemTemplate>
                                <asp:Label ID="lbXQD" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="X" SortExpression="NC_LamViec">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemTemplate>
                                <asp:Label ID="lbNC_LamViec" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ố, Co, KHH, TNLD">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemTemplate>
                                <asp:HyperLink ID="lnkF_O_Co_KHH_TNLD" runat="server"></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="F, Fdb, DD">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemTemplate>
                                <asp:HyperLink ID="lnkF_Nam_Fdb_DD" runat="server"></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TS">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemTemplate>
                                <asp:HyperLink ID="lnkF_ThaiSan" runat="server"></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="CT" SortExpression="F_CongTac">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <ItemTemplate>
                                <asp:HyperLink ID="lnkF_CongTac" runat="server"></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ho">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemTemplate>
                                <asp:HyperLink ID="lnkF_Hoc" runat="server"></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Kh&#225;c">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemTemplate>
                                <asp:HyperLink ID="lnkF_Khac" runat="server"></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NT, NB" SortExpression="NghiTuan">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemTemplate>
                                <asp:HyperLink ID="lnkNghiTuan_NghiBu" runat="server"></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="X dư qu&#225; khứ" SortExpression="CongDu">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <ItemTemplate>
                                <asp:Label ID="lbOldCongDu" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="X dư trong th&#225;ng" SortExpression="CongDu">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <ItemTemplate>
                                <asp:Label ID="lbCongDu" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="X dư" SortExpression="CongDu">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <ItemTemplate>
                                <asp:Label ID="lbFinalCongDu" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="LĐ (giờ)" SortExpression="GC_LamDem">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemTemplate>
                                <asp:Label ID="lbGC_LamDem" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Số 1/2X" SortExpression="Count1_2X">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <ItemTemplate>
                                <asp:Label ID="lbCount1_2X" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Số X" SortExpression="CountX">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <ItemTemplate>
                                <asp:Label ID="lbCountX" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Điểm HTCV" SortExpression="Mark">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemTemplate>
                                <asp:Label ID="lbMark" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Xếp Loại" SortExpression="HTCV">
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemTemplate>
                                <asp:Label ID="Label15" runat="server" Text='<%# Bind("HTCV") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ghi Ch&#250;" SortExpression="Remark">
                            <ItemTemplate>
                                <asp:Label ID="lbRemark" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <RowStyle CssClass="grid-item" />
                    <SelectedRowStyle CssClass="grid-SelectedRowStyle" />
                    <PagerStyle CssClass="grid-paper" />
                    <HeaderStyle CssClass="grid-header1" />
                    <AlternatingRowStyle CssClass="grid-atlternating-item" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}"
                    OnSelected="ObjectDataSource1_Selected" OnSelecting="ObjectDataSource1_Selecting"
                    SelectMethod="GetByFilter" TypeName="HRMBLL.H1.WorkdayEmployeesBLL">
                    <SelectParameters>
                        <asp:Parameter Name="fullName" Type="String" />
                        <asp:Parameter Name="departmentIds" Type="String" />
                        <asp:Parameter Name="month" Type="Int32" />
                        <asp:Parameter Name="year" Type="Int32" />
                        <asp:Parameter Name="status" Type="Int32" />
                        <asp:Parameter Name="receivedUserId" Type="Int32" />
                        <asp:Parameter Name="typeSort" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <uc2:ucPermission ID="UcPermission1" runat="server" />
                        </td>
                    </tr>
                </table>               
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="Button1" runat="server" CssClass="small color green button" OnClick="Button1_Click"
                    Text="Tính Công Dư" /></td>
        </tr>
    </table>
    <script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>
<script type="text/javascript" src="../JScripts/script.js"></script>
</asp:Content>

