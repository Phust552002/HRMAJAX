<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" EnableEventValidation="false" CodeFile="ChangeCandidateSessionPosition.aspx.cs" Inherits="Recruitment_ChangeCandidateSessionPosition" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td>
                <uc1:ucTitle ID="UcTitle1" runat="server"/>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="Label3" CssClass="label" runat="server" Text="Đợt "></asp:Label>&nbsp;
                <asp:DropDownList ID="ddlSessions" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlSessions_SelectedIndexChanged" Width="200px"></asp:DropDownList>&nbsp;
                <asp:Label ID="Label2" CssClass="label" runat="server" Text="Chức danh"></asp:Label>
                <asp:DropDownList ID="ddlPositions" runat="server" CssClass="dropDownList" AppendDataBoundItems="True" Width="100px">
                    <asp:ListItem Value="0" Text=""></asp:ListItem>
                </asp:DropDownList>&nbsp; &nbsp;
                <asp:Label ID="Label1" CssClass="label" runat="server" Text="Họ và tên"></asp:Label>
                <asp:TextBox ID="txtFirstName" runat="server" CssClass="textBox"></asp:TextBox>
                <asp:ObjectDataSource ID="odsStandards" runat="server" SelectMethod="GetAllCandidateStatus" TypeName="HRMUtil.Constants" OldValuesParameterFormatString="original_{0}"></asp:ObjectDataSource>
                &nbsp;
                <asp:Button ID="btnView" runat="server" Text="Xem" OnClick="btnView_Click" CssClass="small color green button"/>&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <table style="width:100%">
                    <tr>
                        <td style="width:70%">
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsCandidateList"
                                            OnRowDataBound="GridView1_RowDataBound" PageSize="20"
                                            CssClass="grid-Border" Width="100%" AllowPaging="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                                <Columns>
                                    <asp:BoundField DataField="CandidateId" HeaderText="Mã HV">
                                        <ItemStyle Width="5%" HorizontalAlign="Center"/>
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="SBD">
                                        <ItemTemplate>
                                            <asp:Label ID="lbCandidateNumber" runat="server" Text=""></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle Width="10%" HorizontalAlign="Center"/>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Họ v&#224; t&#234;n l&#243;t">
                                        <ItemTemplate>
                                            <asp:Label ID="lbLastName" runat="server" Text=""></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle Width="30%" HorizontalAlign="Left"/>
                                        <HeaderStyle HorizontalAlign="Left"/>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="T&#234;n">
                                        <ItemTemplate>
                                            <asp:Label ID="lbFirstName" runat="server" Text=""></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle Width="10%" HorizontalAlign="Left"/>
                                        <HeaderStyle HorizontalAlign="Left"/>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Giới T&#237;nh" SortExpression="Sex">
                                        <ItemTemplate>
                                            <asp:Label ID="lbSex" runat="server" Text="Label"></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="10%"/>
                                        <HeaderStyle HorizontalAlign="Center"/>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Năm Sinh" SortExpression="DayOfBirth">
                                        <ItemTemplate>
                                            <asp:Label ID="lbBirthday" runat="server" Text=""></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="10%"/>
                                        <HeaderStyle HorizontalAlign="Center"/>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Chức danh" SortExpression="DayOfBirth">
                                        <ItemTemplate>
                                            <asp:Label ID="lbPositionName" runat="server" Text=""></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="20%"/>
                                        <HeaderStyle HorizontalAlign="Center"/>
                                    </asp:TemplateField>
                                    <%--<asp:TemplateField HeaderText="Tr&#236;nh độ">
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
                                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email"/>--%>
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
                                <SelectedRowStyle BackColor="#99CCFF" BorderColor="#0066FF" BorderStyle="Dashed" />
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
                        <td style="width:30%" valign="top">
                            <table style="width:100%">
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label6" CssClass="label" runat="server" Text="Ứng viên "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:Label ID="selectedCandidate" CssClass="value" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label4" CssClass="label" runat="server" Text="Đợt "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:DropDownList ID="ddlSessionsNew" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlSessionsNew_SelectedIndexChanged" Width="200px"></asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label5" CssClass="label" runat="server" Text="Chức danh"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:DropDownList ID="ddlPositionsNew" runat="server" CssClass="dropDownList" AppendDataBoundItems="True" Width="100px">
                                            <asp:ListItem Value="0" Text=""></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>

                                    </td>
                                    <td align="left">
                                        <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click" CssClass="small color green button"/>
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

