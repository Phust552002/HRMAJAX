<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="EmployeesSecurityList.aspx.cs" Inherits="Employee_EmployeesSecurityList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%">
        <tr>
            <td align="center" valign="top">
                <table width="100%">
                    <tr>
                        <td>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <uc5:ucTitle ID="UcTitle1" runat="server"/>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="imgSearch" EventName="Click"/>
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table width="100%">
                                <tr>
                                    <td style="width: 20%" align="left">
                                        <uc2:ActionMenu ID="ActionMenu1" runat="server"/>
                                    </td>
                                    <td style="width: 80%" align="right">
                                        <table>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>&nbsp;
                                                    <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                                    &nbsp;
                                                    <asp:Label ID="lbDepartment" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>&nbsp;
                                                    <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList">
                                                    </asp:DropDownList>&nbsp;
                                                    <asp:Label ID="Label2" runat="server" CssClass="label" Text="Lọc"></asp:Label>&nbsp;
                                                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropDownList">
                                                        <asp:ListItem Selected="True" Value="0">&lt;All&gt;</asp:ListItem>
                                                        <asp:ListItem Value="1">Nghỉ việc/ chuyển công tác</asp:ListItem>
                                                        <asp:ListItem Value="2">Đến hạn (trước 3 tuần ở thời điểm hiện tại)</asp:ListItem>
                                                        <asp:ListItem Value="3">Mất thẻ</asp:ListItem>
                                                    </asp:DropDownList>&nbsp;
                                                    
                                                    &nbsp;&nbsp;&nbsp;<asp:Button ID="imgSearch" runat="server" Text="Xem" CssClass="small color green button" OnClick="imgSearch_Click"/>
                                                    &nbsp;
                                                </td>
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
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>

                                                <asp:GridView id="grdEmployeesList" runat="server" Width="100%" CssClass="grid-Border" AllowSorting="True" AllowPaging="True" PageSize="20" OnRowDataBound="grdEmployeesList_RowDataBound" AutoGenerateColumns="False" DataSourceID="odsEmployees" DataKeyNames="UserId" OnSorting="grdEmployeesList_Sorting">
                                                    <PagerSettings PageButtonCount="30"></PagerSettings>
                                                    <Columns>
                                                        <asp:BoundField HtmlEncode="False" DataFormatString="{0:000#}" DataField="UserId" SortExpression="UserId" HeaderText="M&#227; NV">
                                                            <ItemStyle HorizontalAlign="Center"></ItemStyle>

                                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="CurrentSCI" SortExpression="CurrentSCI"
                                                                        HeaderText="Mã thẻ KSAN">
                                                            <ItemStyle HorizontalAlign="Center"></ItemStyle>

                                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        </asp:BoundField>
                                                        <asp:TemplateField SortExpression="FullName" HeaderText="Họ v&#224; t&#234;n">
                                                            <ItemStyle HorizontalAlign="Left"></ItemStyle>

                                                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                            <ItemTemplate>
                                                                <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid">[lnkFullName]</asp:HyperLink>

                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:BoundField DataField="PositionName" SortExpression="PositionName" HeaderText="Chức danh">
                                                            <ItemStyle HorizontalAlign="Left"></ItemStyle>

                                                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="DepartmentFullName" SortExpression="RootId" HeaderText="Ph&#242;ng">
                                                            <HeaderStyle HorizontalAlign="Left"/>
                                                        </asp:BoundField>
                                                        <asp:TemplateField HeaderText="KV 1">
                                                            <HeaderStyle HorizontalAlign="Center"/>
                                                            <ItemStyle HorizontalAlign="Center"/>
                                                            <ItemTemplate>
                                                                <asp:Label runat="server" id="lbArea1"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="KV 2">
                                                            <HeaderStyle HorizontalAlign="Center"/>
                                                            <ItemStyle HorizontalAlign="Center"/>
                                                            <ItemTemplate>
                                                                <asp:Label runat="server" id="lbArea2"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="KV 3">
                                                            <HeaderStyle HorizontalAlign="Center"/>
                                                            <ItemStyle HorizontalAlign="Center"/>
                                                            <ItemTemplate>
                                                                <asp:Label runat="server" id="lbArea3"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="KV 4">
                                                            <HeaderStyle HorizontalAlign="Center"/>
                                                            <ItemStyle HorizontalAlign="Center"/>
                                                            <ItemTemplate>
                                                                <asp:Label runat="server" id="lbArea4"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="KV 5">
                                                            <HeaderStyle HorizontalAlign="Center"/>
                                                            <ItemStyle HorizontalAlign="Center"/>
                                                            <ItemTemplate>
                                                                <asp:Label runat="server" id="lbArea5"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="KV 6">
                                                            <HeaderStyle HorizontalAlign="Center"/>
                                                            <ItemStyle HorizontalAlign="Center"/>
                                                            <ItemTemplate>
                                                                <asp:Label runat="server" id="lbArea6"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField SortExpression="Expired" HeaderText="Ngày hết hạn">
                                                            <ItemStyle HorizontalAlign="Center"></ItemStyle>

                                                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                            <ItemTemplate>
                                                                <asp:Label runat="server" id="lbExpired"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Ghi chú mất thẻ" Visible="False">
                                                            <ItemTemplate>
                                                                <asp:Label runat="server" id="lbRemark1"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:BoundField DataField="SecurityControlId"
                                                                        SortExpression="SecurityControlId" Visible="False"/>
                                                    </Columns>

                                                    <RowStyle CssClass="grid-item"></RowStyle>

                                                    <PagerStyle CssClass="grid-paper"></PagerStyle>

                                                    <HeaderStyle CssClass="grid-header"></HeaderStyle>

                                                    <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                                                </asp:GridView>
                                                <asp:ObjectDataSource id="odsEmployees" runat="server"
                                                                      OnSelecting="odsEmployees_Selecting" TypeName="HRMBLL.H0.SecurityControlBLL"
                                                                      SelectMethod="GetAllByFilter" OldValuesParameterFormatString="original_{0}"
                                                                      OnSelected="odsEmployees_Selected">
                                                    <SelectParameters>
                                                        <asp:Parameter Name="fullName" Type="String" />
                                                        <asp:Parameter Name="departmentIds" Type="String" />
                                                        <asp:Parameter Name="status" Type="String" />
                                                        <asp:Parameter Name="almostExpired" Type="DateTime" />
                                                        <asp:Parameter Name="isLost" Type="Int32" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>

                                            </ContentTemplate>
                                            <Triggers>
                                                <asp:AsyncPostBackTrigger ControlID="imgSearch" EventName="Click"/>
                                            </Triggers>
                                        </asp:UpdatePanel>
                                    </td>
                                </tr>
                            </table>
                            <uc1:ucPermission ID="UcPermission1" runat="server"/>
                        </td>
                    </tr>

                </table>
            </td>
        </tr>
    </table>
</asp:Content>