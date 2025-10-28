<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="WorkdayPrivilegeDetail.aspx.cs" Inherits="Workdays_WorkdayPrivilegeDetail" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
        <tr>
            <td valign="top" >
                <table style="width: 100%">
                    <tr>
                        <td valign="top">
                            <uc2:ucTitle ID="UcTitle1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" align="right">
                           <fieldset>
                                            <legend class="legend">
                                                <asp:Label ID="lbTitleAdd" runat="server" Text="Label"></asp:Label>
                                            </legend>                               
                                            <table class="tableBorder" style="width: 100%">
                                                <tr>
                                                    <td align="left" class="tdLabel" style="width:30%">
                                                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tìm nhân viên"></asp:Label></td>
                                                    <td align="left" class="tdValue">
                                                        <table cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td>
                                                                    <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                                                </td>
                                                                <td>
                                                                    &nbsp;<asp:ImageButton ID="imgSearchFullName" runat="server" ImageUrl="~/Images/Icon-Search.gif" OnClick="imgSearchFullName_Click" />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" class="tdLabel">
                                                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Nhân viên"></asp:Label></td>
                                                    <td align="left" class="tdValue">
                                                        <asp:DropDownList ID="ddlEmployees" runat="server" CssClass="dropDownList" DataSourceID="odsEmployees"
                                                            DataTextField="FullName" DataValueField="UserId" AppendDataBoundItems="true">
                                                            <asp:ListItem Value="0" Text="" ></asp:ListItem>
                                                        </asp:DropDownList>
                                                        <asp:ObjectDataSource ID="odsEmployees" runat="server" OldValuesParameterFormatString="original_{0}"
                                                            OnSelecting="odsEmployees_Selecting" SelectMethod="GetByDeptIds" TypeName="HRMBLL.H0.EmployeesBLL">
                                                            <SelectParameters>
                                                                <asp:Parameter Name="deptIds" Type="String" />
                                                                <asp:Parameter Name="rootId" Type="Int32" />
                                                                <asp:Parameter Name="fullName" Type="String" />
                                                                <asp:Parameter Name="sortParameter" Type="String" />
                                                                <asp:Parameter Name="AirlinesWorking" Type="String" />
                                                            </SelectParameters>
                                                        </asp:ObjectDataSource>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" class="tdLabel">
                                                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Có quyền chấm công"></asp:Label></td>
                                                    <td align="left" class="tdValue">
                                                        <asp:CheckBox ID="chkInit" runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td align="center" class="tdButton" colspan="2">
                                                        <asp:Button ID="btnClear" runat="server" CssClass="small color green button" Text="Clear" Visible="False"
                                                            Width="100px" OnClick="btnClear_Click" />
                                                        &nbsp;
                                                        <asp:Button CssClass="small color green button" ID="btnDelete" OnClick="btnDelete_Click" OnClientClick="return confirm('Bạn có muốn xóa mục thông tin này ?');" runat="server" Text="Xóa" Visible="False" Width="100px" />
                                                        &nbsp;
                                                        <asp:Button ID="btnSave" runat="server" CssClass="small color green button" OnClick="btnSave_Click"
                                                            Text="Thêm mới" Width="100px" />
                                                        &nbsp;
                                                        <asp:Button ID="btnCancel" runat="server" CssClass="small color green button" OnClick="btnCancel_Click"
                                                            Text="Thoát" Width="100px" /></td>
                                                </tr>
                                            </table>
                                        </fieldset>                       
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <fieldset>
                                <legend class="legend">
                                    <asp:Label ID="lbTitleList" runat="server" Text="Label"></asp:Label></legend>
                                <table style="width: 100%" >
                                    <tr>
                                        <td align="right">
                                             <table style="width: 100%">
                                            <tr>                                                
                                                <td style="width:95%" align="right"><asp:Label id="Label2" runat="server" CssClass="label" Text="Họ tên"></asp:Label> <asp:TextBox id="txtFullNameFilter" runat="server" CssClass="textBox"></asp:TextBox></td>
                                                <td style="width:5%"><asp:ImageButton id="ImageButton2" onclick="imgSearch_Click" runat="server" ImageUrl="~/Images/Icon-Search.gif"></asp:ImageButton></td>
                                            </tr>
                                        </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table style="width: 100%" class="tableBorder">
                                                <tr>
                                                    <td>
                                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="100%" CssClass="grid-Border" PageSize="20" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                                                        <Columns>
                                                            <asp:BoundField DataField="UserId" HeaderText="M&#227; nh&#226;n vi&#234;n" SortExpression="UserId" DataFormatString="{0:000#}" HtmlEncode="False" >
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="EmployeeCode" HeaderText="M&#227; SAC" SortExpression="EmployeeCode" >
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:BoundField>
                                                            <asp:TemplateField HeaderText="Họ t&#234;n" SortExpression="FullName">
                                                                <ItemTemplate>
                                                                    <asp:LinkButton ID="lbtnFullName" runat="server" CssClass="hyperlink-Grid" Text='<%# Bind("FullName") %>' CommandName="Select" ToolTip='<%# Bind("UserId") %>'></asp:LinkButton>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="DepartmentFullName" HeaderText="Ph&#242;ng" SortExpression="DepartmentFullName" />
                                                            <asp:TemplateField HeaderText="Tạo BCC" SortExpression="IsInit">
                                                                <ItemStyle HorizontalAlign="Center" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                                <ItemTemplate>
                                                                    <asp:CheckBox ID="chkIsInit" runat="server" Checked='<%# Bind("IsInit") %>' Enabled="false" />
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                        </Columns>
                                                        <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                                        <HeaderStyle CssClass="grid-header" /> 
                                                        <RowStyle CssClass ="grid-item" />
                                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                                        <PagerStyle CssClass="grid-paper" />  
                                                        <PagerSettings PageButtonCount="30" />
                                                    </asp:GridView>
                                                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting"
                                                        SelectMethod="GetByDeptIds" TypeName="HRMBLL.H1.WorkDayPrivilegeBLL" OldValuesParameterFormatString="original_{0}">
                                                        <SelectParameters>
                                                            <asp:Parameter Name="deptIds" Type="String" />
                                                            <asp:Parameter Name="privilegeType" Type="Int32" />
                                                            <asp:Parameter Name="fullName" Type="String" />
                                                        </SelectParameters>
                                                    </asp:ObjectDataSource>
                                                    </td>
                                                </tr>
                                            </table>            
                                        </td>
                                    </tr>
                                </table>        
                            </fieldset>
                        </td>
                    </tr>
                    
                </table>
            </td>
        </tr>
</table>
</asp:Content>
