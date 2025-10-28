<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListLeaves.ascx.cs" Inherits="Leave_UserControls_ListLeaves" %>
<%@ Register Src="../../UserControls/CalendarPicker.ascx" TagName="CalendarPicker"
    TagPrefix="uc3" %>
<%@ Register Src="../../UserControls/DatePicker.ascx" TagName="DatePicker" TagPrefix="uc2" %>

<%@ Register Src="../../UserControls/ucDateFilter.ascx" TagName="ucDateFilter" TagPrefix="uc1" %>
<table style="width: 100%">
    <tr>
        <td align="right">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Loại ngày nghỉ"></asp:Label>
                        <asp:DropDownList ID="ddlLeaveType" runat="server" CssClass="dropDownList" AppendDataBoundItems="True">
                        <asp:ListItem Text="" Value="0"></asp:ListItem>
                        </asp:DropDownList>&nbsp; &nbsp;&nbsp;                        
                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Năm"></asp:Label>
                        <asp:DropDownList ID="ddlYears" runat="server" CssClass="dropDownList">
                        </asp:DropDownList>
                            
                    </td>
                    <td>
                        <asp:Button ID="btnShow" runat="server" CssClass="small color green button" Text="Xem" OnClick="btnShow_Click" /></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <table class="tableBorder" width="100%">
               <tr>
                   <td>  
                      <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                         <ContentTemplate>
                        <asp:GridView ID="grdListLeaves" runat="server" AutoGenerateColumns="False" DataSourceID="odsListLeaves" DataKeyNames="EmployeeLeaveId" OnRowEditing="grdListLeaves_RowEditing" PageSize="20" CssClass="grid-Border" Width="100%" OnRowDeleted="grdListLeaves_RowDeleted" OnRowUpdated="grdListLeaves_RowUpdated">
                            <Columns>
                                <asp:TemplateField HeaderText="Loại ng&#224;y nghỉ" SortExpression="LeaveTypeName">
                                    <EditItemTemplate>
                                        <asp:DropDownList ID="grd_ddlLeaveType" runat="server" DataSourceID="ObjectDataSource2"
                                            DataTextField="LeaveTypeName" DataValueField="LeaveTypeId" CssClass="dropDownList" SelectedValue='<%# Bind("LeaveTypeId") %>' AutoPostBack="True" OnSelectedIndexChanged="grd_ddlLeaveType_SelectedIndexChanged">
                                        </asp:DropDownList>
                                        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetByFilter"
                                            TypeName="HRMBLL.H0.LeaveTypesBLL" OldValuesParameterFormatString="original_{0}" OnSelecting="ObjectDataSource2_Selecting">
                                            <SelectParameters>
                                                <asp:Parameter Name="leaveTypeCode" Type="String" />
                                                <asp:Parameter Name="leaveTypeName" Type="String" />
                                                <asp:Parameter Name="type" Type="Int32" />
                                            </SelectParameters>
                                        </asp:ObjectDataSource>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("LeaveTypeName") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Từ ng&#224;y" SortExpression="FromDate">
                                    <EditItemTemplate>
                                        <uc3:CalendarPicker ID="grd_cpFromDate" runat="server" SelectedDate='<%#Bind("FromDate")%>'/>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "FromDate", "{0:dd/MM/yyyy}")%>'></asp:Label>
                                    </ItemTemplate>
                                     <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Đến ng&#224;y" SortExpression="ToDate">
                                    <EditItemTemplate>                           
                                        <table cellpadding="0" cellspacing="0">
                                            <tr>
                                                <td>
                                                    <uc3:CalendarPicker ID="grd_cpToDate" runat="server" SelectedDate='<%#Bind("ToDate")%>'/>
                                                </td>
                                                <td>
                                                    <asp:ImageButton ID="imgCalculateToDate" runat="server" ImageUrl="~/Images/icn_pen.gif"
                                                        OnClick="imgCalculateToDate_Click" /></td>
                                            </tr>
                                        </table>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label3" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "ToDate", "{0:dd/MM/yyyy}")%>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Số ng&#224;y" SortExpression="Days">
                                    <EditItemTemplate>
                                        <asp:Label ID="grd_lbTotalDays" runat="server" Text='<%# Bind("Days") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Days") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ghi ch&#250;" SortExpression="Remark">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("Remark") %>' CssClass="textBox"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("Remark") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Thao t&#225;c" ShowHeader="False">
                                    <EditItemTemplate>
                                        <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="True" CommandName="Update"
                                            ImageUrl="~/Images/icon-save.gif" />&nbsp;<asp:ImageButton ID="ImageButton3"
                                                runat="server" CausesValidation="False" CommandName="Cancel" ImageUrl="~/Images/icon-cancel.gif"/>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Edit"
                                            ImageUrl="~/Images/icon-edit.gif" />&nbsp;<asp:ImageButton ID="ImageButton2"
                                                runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/Images/icon-delete.gif" OnClientClick="return confirm('Bạn có muốn xóa thông tin đã chọn ?');"/>
                                    </ItemTemplate>
                                     <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                 
                            </Columns>
                            <HeaderStyle CssClass="grid-header" /> 
                            <RowStyle CssClass ="grid-item" />
                            <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                            <PagerStyle CssClass="grid-paper" />  
                            <EmptyDataTemplate>
                                <asp:Label ID="Label7" runat="server" CssClass="value" Text="Không có dữ liệu về ngày nghỉ"></asp:Label>
                            </EmptyDataTemplate>
                        </asp:GridView>
                        <asp:ObjectDataSource ID="odsListLeaves" runat="server" OnSelecting="odsListLeaves_Selecting"
                            SelectMethod="GetByUserId_Year_LeaveTypeId" TypeName="HRMBLL.H0.EmployeeLeaveBLL" OnUpdating="odsListLeaves_Updating" UpdateMethod="Update" DeleteMethod="Delete">
                            <SelectParameters>
                                <asp:Parameter Name="userId" Type="Int32" />
                                <asp:Parameter Name="leaveTypeId" Type="Int32" />
                                <asp:Parameter Name="year" Type="Int32" />
                                <asp:Parameter Name="groupId" Type="Int64" />
                            </SelectParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="userId" Type="Int32" />
                                <asp:Parameter Name="leaveTypeId" Type="Int32" />
                                <asp:Parameter Name="fromDate" Type="DateTime" />
                                <asp:Parameter Name="toDate" Type="DateTime" />
                                <asp:Parameter Name="days" Type="Double" />
                                <asp:Parameter Name="groupId" Type="Int64" />
                                <asp:Parameter Name="remark" Type="String" />
                                <asp:Parameter Name="employeeLeaveId" Type="Int64" />
                            </UpdateParameters>
                            <DeleteParameters>
                                <asp:Parameter Name="employeeLeaveId" Type="Int64" />
                            </DeleteParameters>
                        </asp:ObjectDataSource>
                        </ContentTemplate>
                         <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="btnShow" EventName="Click" />
                         </Triggers>
                    </asp:UpdatePanel>  
                   </td>
               </tr>
           </table>
        </td>
    </tr>
</table>
