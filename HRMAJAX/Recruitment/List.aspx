<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="Recruitment_List" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td valign="top">
                <table style="width: 100%" cellpadding="0" cellspacing="0">
                    <tr>
                        <td>
                            <uc1:ucTitle ID="UcTitle1" runat="server"/>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table width="100%">
                                <tr>
                                    <td style="width: 6%" align="left">
                                        <uc2:ActionMenu ID="ActionMenu1" runat="server"/>
                                    </td>

                                    <td align="right" style="width: 90%">
                                        <asp:Label ID="Label3" CssClass="label" runat="server" Text="Đợt "></asp:Label>&nbsp;<asp:DropDownList
                                                                                                                                 ID="ddlSessions" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlSessions_SelectedIndexChanged" Width="200px">
                                        </asp:DropDownList>

                                        &nbsp;
                                        <asp:Label ID="Label2" CssClass="label" runat="server" Text="Chức danh"></asp:Label>
                                        <asp:DropDownList ID="ddlPositions" runat="server" CssClass="dropDownList" AppendDataBoundItems="True" Width="100px">
                                            <asp:ListItem Value="0" Text=""></asp:ListItem>
                                        </asp:DropDownList>&nbsp; &nbsp;
                                        <asp:Label ID="Label1" CssClass="label" runat="server" Text="Họ và tên"></asp:Label>
                                        <asp:TextBox ID="txtFirstName" runat="server" CssClass="textBox"></asp:TextBox>
                                        &nbsp;&nbsp;
                                        <asp:Label ID="Label6" runat="server" CssClass="label" Text="Hồ sơ"></asp:Label>
                                        <asp:DropDownList ID="ddlStandards" runat="server" CssClass="dropDownList" DataSourceID="odsStandards"
                                                          DataTextField="UnitName" DataValueField="UnitId" AppendDataBoundItems="true">
                                            <asp:ListItem Text=" " Value="-1"></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:ObjectDataSource ID="odsStandards" runat="server" SelectMethod="GetAllCandidateStatus"
                                                              TypeName="HRMUtil.Constants" OldValuesParameterFormatString="original_{0}">
                                        </asp:ObjectDataSource>
                                        &nbsp;
                                        <asp:Button ID="btnView" runat="server" Text="Xem" OnClick="btnView_Click" CssClass="small color green button"/>&nbsp;&nbsp;
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
                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsCandidateList"
                                                      OnRowDataBound="GridView1_RowDataBound" PageSize="20"
                                                      CssClass="grid-Border" Width="100%" AllowPaging="True">
                                            <Columns>
                                                <asp:TemplateField HeaderText="SBD">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbCandidateNumber" runat="server" Text=""></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center"/>
                                                </asp:TemplateField>
                                                <%--<asp:TemplateField HeaderText="STT ĐK">
                                            <ItemTemplate>
                                                <asp:Label ID="lbOrdernumber" runat="server" Text=""></asp:Label>
                                            </ItemTemplate>
                                             <ItemStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>--%>
                                                <asp:TemplateField HeaderText="Họ v&#224; t&#234;n l&#243;t">
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkLastName" runat="server" Text='<%# Eval("LastName") %>' CssClass="hyperlink-Grid"></asp:HyperLink>
                                                    </ItemTemplate>
                                                    <ItemStyle Width="10%" HorizontalAlign="Left"/>
                                                    <HeaderStyle HorizontalAlign="Left"/>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="T&#234;n">
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkFirstName" runat="server" Text='<%# Eval("FirstName") %>' CssClass="hyperlink-Grid"></asp:HyperLink>
                                                    </ItemTemplate>
                                                    <ItemStyle Width="4%" HorizontalAlign="Left"/>
                                                    <HeaderStyle HorizontalAlign="Left"/>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Giới T&#237;nh" SortExpression="Sex">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbSex" runat="server" Text="Label"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" Width="4%"/>
                                                    <HeaderStyle HorizontalAlign="Center"/>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Năm Sinh" SortExpression="DayOfBirth">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbBirthday" runat="server" Text=""></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" Width="6%"/>
                                                    <HeaderStyle HorizontalAlign="Center"/>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Chức danh" SortExpression="DayOfBirth">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbPositionName" runat="server" Text=""></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" Width="6%"/>
                                                    <HeaderStyle HorizontalAlign="Center"/>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Tr&#236;nh độ">
                                                    <ItemTemplate>
                                                        <asp:Literal ID="ltEducationLevel" runat="server"></asp:Literal>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"/>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Kinh nghiệm" SortExpression="Experience">
                                                    <ItemTemplate>
                                                        <asp:Literal ID="ltExperience" runat="server"></asp:Literal>
                                                    </ItemTemplate>
                                                    <ItemStyle Width="12%" VerticalAlign="Top"/>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="TypeName" HeaderText="TC ứng tuyển" SortExpression="TypeName" Visible="False">
                                                    <ItemStyle HorizontalAlign="Center"/>
                                                    <HeaderStyle HorizontalAlign="Center"/>
                                                </asp:BoundField>
                                                <asp:BoundField DataField="Height" HeaderText="Chiều cao" HtmlEncode="False" SortExpression="Height">
                                                    <ItemStyle HorizontalAlign="Center"/>
                                                    <HeaderStyle HorizontalAlign="Center"/>
                                                </asp:BoundField>
                                                <asp:BoundField DataField="Remark" HeaderText="Ghi ch&#250;" SortExpression="Remark">
                                                    <ItemStyle HorizontalAlign="Left"/>
                                                    <HeaderStyle HorizontalAlign="Left"/>
                                                </asp:BoundField>
                                                <asp:BoundField DataField="RemarkR3" HeaderText="Ghi chú vòng hội đồng" />
                                                <asp:BoundField DataField="HandPhone" HeaderText="ĐT Di động" SortExpression="HandPhone">
                                                    <ItemStyle Width="8%" HorizontalAlign="Center"/>
                                                    <HeaderStyle HorizontalAlign="Center"/>
                                                </asp:BoundField>
                                                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email"/>
                                                <asp:TemplateField HeaderText="Hồ sơ">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbCandidateStatus" runat="server" Text="Label"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center"/>
                                                </asp:TemplateField>
                                            </Columns>
                                            <HeaderStyle CssClass="grid-header"/>
                                            <RowStyle CssClass="grid-item"/>
                                            <AlternatingRowStyle CssClass="grid-atlternating-item"/>
                                            <PagerStyle CssClass="grid-paper"/>
                                        </asp:GridView>
                                        <asp:ObjectDataSource ID="odsCandidateList" runat="server" OnSelecting="odsCandidateList_Selecting"
                                                              SelectMethod="GetByFilterForTable" TypeName="HRMBLL.H2.CandidatesBLL" OldValuesParameterFormatString="original_{0}" OnSelected="odsCandidateList_Selected">
                                            <SelectParameters>
                                                <asp:Parameter Name="firstName" Type="String"/>
                                                <asp:Parameter Name="positionId" Type="Int32"/>
                                                <asp:Parameter Name="result" Type="Int32"/>
                                                <asp:Parameter Name="sessionId" Type="Int32"/>
                                                <asp:Parameter Name="type" Type="Int32"/>
                                                <asp:Parameter Name="sessionType" Type="Int32"/>
                                                <asp:Parameter Name="TypeSort" Type="Int32"/>
                                                <asp:Parameter Name="isBlack" Type="Int32" />
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