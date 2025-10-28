<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="LeaveSchedule.aspx.cs" Inherits="Leave_LeaveSchedule" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
<%@ Register Src="~/UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc5" %>
<%@ Register Src="~/UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>
<%@ Register Src="~/Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc5" %>
<%@ Register Src="~/UserControls/CalendarPicker.ascx" TagName="CalendarPicker"TagPrefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> 
                    <table style="width: 100%">
                        <tr>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
                                    <ContentTemplate>  
                                        <uc5:ucTitle ID="UcTitle1" runat="server" /> 
                                    </ContentTemplate>
                                </asp:UpdatePanel>                      
                            </td>
                        </tr>
                        <tr>
                            <td valign="top" align="left">
                            <asp:CheckBox ID="chkHideAddSession" runat="server" AutoPostBack="True" CssClass="value" OnCheckedChanged="chkHideAddSession_CheckedChanged" Text="Thêm mới" />
                            <asp:Panel ID="pnlAddSession" runat="server" Width="100%" Visible="False">
                                <fieldset>
                                <legend class="legend">Thêm mới ngày kế hoạch nghỉ phép</legend>                              
                                 <table style="width: 100%;"class="tableBorder">
                                        <%--<tr>
                                            <td class="tdLabel" style="width: 190px">
                                                <asp:Label ID="Label6" runat="server" CssClass="label" Text="Năm "></asp:Label>
                                            </td>
                                            <td class="tdValue">
                                                <asp:DropDownList ID="ddlYears" runat="server" CssClass="dropDownList">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>--%>
                                        <tr>
                                            <td class="tdLabel" style="width: 190px">
                                                <asp:Label ID="Label9" runat="server" CssClass="label" Text="Họ và tên "></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:DropDownList ID="ddlFullName" runat="server" Width="200px" 
                                                    CssClass="dropDownList" AutoPostBack="true" Font-Bold="False"></asp:DropDownList>

                                                <asp:Label ID="Label10" runat="server" CssClass="label" Text="Tổng số ngày phép được nghỉ: "></asp:Label>
                                                <asp:Label ID="lblTotalLeave" runat="server" CssClass="label" Text="..." 
                                                    Font-Bold="True" ForeColor=Blue></asp:Label>

                                            </td>
                                        </tr>
                                    <%--<tr>
                                        <td class="tdLabel" align="right">
                                            <asp:Label ID="Label13" runat="server" CssClass="label" Text="Lần nghỉ"></asp:Label>
                                        </td>
                                        <td align="left" class="tdValue">
                                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="label" 
                                                Height="21px" Width="36px" RepeatColumns="3" RepeatDirection="Vertical" 
                                                Font-Bold="False">
                                                <asp:ListItem>1</asp:ListItem>
                                                <asp:ListItem>2</asp:ListItem>
                                                <asp:ListItem>3</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>--%>
                                     <tr>
                                         <td class="tdLabel" style="width: 190px">
                                             <asp:Label ID="Label2" runat="server" CssClass="label" Text="Từ ngày"></asp:Label></td>
                                         <td class="tdValue">
                                             <uc3:CalendarPicker ID="cpFromDate" runat="server" />
                                         </td>
                                     </tr>
                                     <tr>
                                         <td class="tdLabel" style="width: 190px">
                                             <asp:Label ID="Label3" runat="server" CssClass="label" Text="Đến ngày"></asp:Label></td>
                                         <td class="tdValue">
                                             <uc3:CalendarPicker ID="cpToDateDate" runat="server" />
                                         </td>
                                     </tr>
                                        <tr>
                                            <td colspan="2" class="tdButton" align="center">                                                 
                                                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Lưu" CssClass="small color green button" Width="100px" />                                                                                                             
                                            </td>
                                            
                                        </tr>
                                    </table>                                       
                            </fieldset>
                            </asp:Panel>
                         </td>
                        </tr>
                        <tr>
                        <td><asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
                        <table  style="width: 100%;"class="tableBorder">
                            <tr>
                                <td>                                
                                <asp:GridView ID="GridView1" runat="server" 
                                    AllowSorting="True" CssClass="grid-Border" PageSize="20" 
                                    Width="100%" onrowdatabound="GridView1_RowDataBound" 
                                    AutoGenerateColumns="False" 
                                    DataKeyNames="EmployeeLeaveScheduleId"
                                        DataSourceID="ObjectDataSource1" 
                                        onrowcancelingedit="GridView1_RowCancelingEdit" 
                                        onrowediting="GridView1_RowEditing" onrowdeleted="GridView1_RowDeleted" 
                                        onrowcommand="GridView1_RowCommand">
                                <RowStyle CssClass="grid-item"></RowStyle>

                                <PagerStyle CssClass="grid-paper"></PagerStyle>

                                    <Columns>
                                        <asp:BoundField DataField="UserId" DataFormatString="{0:000#}" 
                                            HeaderText="Mã nhân viên" SortExpression="UserId" ReadOnly="true">
                                        <ItemStyle Width="5%" HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="FullName" HeaderText="Họ và tên" 
                                            SortExpression="UserId" ReadOnly="true">
                                            <ItemStyle Width="25%"/>
                                            </asp:BoundField>
                                        <asp:BoundField DataField="Seniority" HeaderText="Số ngày thâm niên" 
                                            SortExpression="Seniority" ItemStyle-Width="5%" ItemStyle-Wrap="true" ReadOnly="true" >
                                        <ItemStyle HorizontalAlign="Right" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="MaxF" HeaderText="Số ngày phép" 
                                            SortExpression="MaxF" ItemStyle-Width="5%" ItemStyle-Wrap="true" ReadOnly="true" >
                                        <ItemStyle HorizontalAlign="Right" />
                                        </asp:BoundField>
                                        <asp:TemplateField HeaderText="Tổng ngày phép" ItemStyle-Width="5%" ItemStyle-Wrap="true" >
                                            <ItemTemplate>
                                                <asp:Label ID="lblTotal" runat="server" ItemStyle-Font-Bold="true"></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle Font-Bold="True" HorizontalAlign="Right" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Ngày đi phép" SortExpression="FromDate" ItemStyle-Width="5%" ItemStyle-Wrap="true" >
                                            <EditItemTemplate>
                                                <uc5:CalendarPicker ID="CalendarPicker1" runat="server" SelectedDate='<%# Bind("FromDate")%>'/>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label1" runat="server" 
                                                    Text='<%# Bind("FromDate", "{0:dd/MM/yyyy}") %>'></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Ngày vào phép" SortExpression="ToDate" ItemStyle-Width="5%" ItemStyle-Wrap="true" >
                                            <EditItemTemplate>
                                                <uc5:CalendarPicker ID="CalendarPicker2" runat="server" SelectedDate='<%# Bind("ToDate")%>'/>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" 
                                                    Text='<%# Bind("ToDate", "{0:dd/MM/yyyy}") %>'></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Số ngày nghỉ" ItemStyle-Width="5%" ItemStyle-Wrap="true" >
                                            <ItemTemplate>
                                                <asp:Label ID="lblDays" runat="server"></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Right" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Còn lại" ItemStyle-Width="5%" ItemStyle-Wrap="true" >
                                            <ItemTemplate>
                                                <asp:Label ID="lblDaysLeft" runat="server" ItemStyle-Font-Bold="true"></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle Font-Bold="True" HorizontalAlign="Right" />
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="Time" HeaderText="Lần" SortExpression="Time" 
                                            ItemStyle-Width="5%" ItemStyle-Wrap="true" ReadOnly="true" Visible="False" >
                                        <ItemStyle HorizontalAlign="Right" />
                                        </asp:BoundField>
                                        <asp:TemplateField HeaderText="Thao tác" ShowHeader="False">
                                            <EditItemTemplate>
                                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="True" CommandName="Update" ImageUrl="~/Images/icon-save.gif"/>
                                                <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Cancel" ImageUrl="~/Images/icon-cancel.gif"/>
                                                <asp:LinkButton ID="lnkSend" runat="server" CausesValidation="false" CommandName="SendCmd" Text="Gửi" Font-Bold="true"></asp:LinkButton>
                                            </EditItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" Width="5%" />
                                            <ItemTemplate>
                                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Edit" ImageUrl="~/Images/icon-edit.gif"/>
                                                <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/Images/icon-delete.gif" OnClientClick="return confirm('Bạn có muốn xóa thông tin này không?');"/>
                                                <asp:LinkButton ID="lnkSend" runat="server" CausesValidation="false" CommandName="SendCmd" Text="Gửi" Font-Bold="true"></asp:LinkButton>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Nội dung phê duyệt">
                                            <ItemTemplate>
                                                <asp:Label ID="Label3" runat="server"></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle Width="20%" />
                                        </asp:TemplateField>
                                    </Columns>

                                <HeaderStyle CssClass="grid-header"></HeaderStyle>

                                <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                                </asp:GridView>
                            </td>
                            </tr>
                        </table>
                            <uc1:ucPermission ID="UcPermission1" runat="server" />
                            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                                SelectMethod="GetByFilter" TypeName="HRMBLL.H0.EmployeeLeaveScheduleBLL" 
                                DeleteMethod="Delete" 
                                UpdateMethod="Update"
                                onselecting="ObjectDataSource1_Selecting">
                                <DeleteParameters>
                                    <asp:Parameter Name="EmployeeLeaveScheduleId" Type="Int32" />
                                </DeleteParameters>
                                <SelectParameters>
                                    <asp:Parameter Name="fullName" Type="String" DefaultValue="" />
                                    <asp:Parameter Name="departmentIds" Type="String" DefaultValue="" />
                                    <asp:Parameter Name="UserId" Type="Int32" />
                                    <asp:Parameter Name="Time" Type="Int32" />
                                    <asp:Parameter Name="Status" Type="String" />
                                    <asp:Parameter Name="RootId" Type="Int32" />
                                    <asp:Parameter Name="LevelPosition" Type="Int32" />
                                    <asp:Parameter Name="RangeFrom" Type="DateTime" />
                                    <asp:Parameter Name="RangeTo" Type="DateTime" />
                                </SelectParameters>
                                <UpdateParameters>
                                    <asp:Parameter Name="EmployeeLeaveScheduleId" Type="Int32" />
                                    <asp:Parameter Name="FromDate" Type="DateTime" />
                                    <asp:Parameter Name="ToDate" Type="DateTime" />
                                </UpdateParameters>
                            </asp:ObjectDataSource>
                        </ContentTemplate>
                    </asp:UpdatePanel></td>
                        </tr>
                        </table>
                                       
                    
                </asp:Content>