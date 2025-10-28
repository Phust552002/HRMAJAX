<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="MoreSearch.aspx.cs" Inherits="Employee_MoreSearch" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
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
                        <uc5:ucTitle ID="UcTitle1" runat="server" /> 
                    </td>
                </tr>
                <tr>
                    <td>
                        <table width="100%">
                            <tr>
                                <td style="width:80%" align="center">
                                    <table>
                                        <tr>                
                                            <td align="center">
                                                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Họ và tên"></asp:Label>
                                                    <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                                &nbsp;
                                                    <asp:Label ID="lbDepartment" runat="server" CssClass="label" Text="Phòng"></asp:Label>
                                                    <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList">
                                                    </asp:DropDownList></td>
                                        </tr>
                                        <tr>
                                            <td align="center">
                                                <asp:Label ID="Label2" runat="server" CssClass="label" Text="Tên đăng nhập"></asp:Label>
                                                <asp:TextBox
                                                    ID="txtUserName" runat="server" CssClass="textBox"></asp:TextBox>&nbsp;
                                                <asp:Label ID="Label3"
                                                        runat="server" CssClass="label" Text="Mã nhân viên"></asp:Label>
                                                <asp:TextBox ID="txtUserId" runat="server" CssClass="textBox" Width="100px"></asp:TextBox>&nbsp;
                                                <asp:Label ID="Label4" runat="server"
                                                                CssClass="label" Text="Mã nhân viên SAC"></asp:Label>
                                                <asp:TextBox ID="txtEmployeeCode" runat="server"
                                                                    CssClass="textBox" Width="100px"></asp:TextBox>&nbsp;
                                                <asp:Label ID="Label5" runat="server" CssClass="label" Text="Trạng thái"></asp:Label>&nbsp;<asp:DropDownList ID="ddlStatus" runat="server" CssClass="dropDownList">
                                                </asp:DropDownList></td>
                                        </tr>
                                        <tr>
                                            <td align="center">
                                                &nbsp;<asp:Label ID="Label6" runat="server" CssClass="label" Text="Tháng năm nghỉ việc"></asp:Label>&nbsp;<asp:DropDownList ID="ddlMonthOfLeave" runat="server" CssClass="dropDownList">
                                                </asp:DropDownList><asp:TextBox ID="txtYearOfLeave" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                                                <asp:Label ID="Label7" runat="server" CssClass="label" Text="Tháng năm sinh nhật"></asp:Label>&nbsp;<asp:DropDownList ID="ddlMonthOfBirth" runat="server" CssClass="dropDownList">
                                                </asp:DropDownList><asp:TextBox ID="txtYearOfBirth" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>&nbsp;
                                                <asp:Label ID="Label8" runat="server" CssClass="label" Text="Tháng năm vào ngày hàng không"></asp:Label>&nbsp;<asp:DropDownList ID="ddlMonthOfJoinDate" runat="server" CssClass="dropDownList">
                                                </asp:DropDownList><asp:TextBox ID="txtYearOfJoinDate" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                                                <asp:Label ID="Label9" runat="server" CssClass="label" Text="Tháng năm vào công ty"></asp:Label>&nbsp;<asp:DropDownList ID="ddlMonthOfJoinCompanyDate" runat="server" CssClass="dropDownList">
                                                </asp:DropDownList><asp:TextBox ID="txtYearOfJoinCompanyDate" runat="server" CssClass="textBox" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td align="center">
                                                <asp:Label ID="lbResult" runat="server" CssClass="labelCountRecord"></asp:Label></td>
                                        </tr>
                                        
                                    </table>
                                </td>
                            </tr>
                        </table>                             
                    </td>
                </tr>
                <tr>
                    <td class="tdButton" align="center">
                        <asp:Button ID="btnSearch" runat="server" Text="Tìm Kiếm" CssClass="small color green button" Width="100px" OnClick="btnSearch_Click"/></td>
                </tr>
                <tr>
                    <td align="left">
                        <table class="tableBorder" width="100%">
                         <tr>
                            <td>  
                                <asp:GridView id="grdEmployeesList" runat="server" Width="100%" CssClass="grid-Border" AllowSorting="True" AllowPaging="True" PageSize="20" OnRowDataBound="grdEmployeesList_RowDataBound" AutoGenerateColumns="False" DataKeyNames="UserId" OnPageIndexChanging="grdEmployeesList_PageIndexChanging">
                                    <PagerSettings PageButtonCount="30"></PagerSettings>
                                    <Columns>
                                    <asp:BoundField HtmlEncode="False" DataFormatString="{0:000#}" DataField="UserId" SortExpression="UserId" HeaderText="M&#227; NV">
                                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="EmployeeCode" SortExpression="EmployeeCode" HeaderText="M&#227; SAC">
                                    <ItemStyle HorizontalAlign="Left"></ItemStyle>

                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                    </asp:BoundField>
                                    <asp:TemplateField SortExpression="FullName" HeaderText="Họ v&#224; t&#234;n">
                                    <ItemStyle HorizontalAlign="Left"></ItemStyle>

                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                    <ItemTemplate>
                                                                                       <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid">[lnkFullName]</asp:HyperLink>
                                                                                   
                                    </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="DepartmentName" SortExpression="RootId" HeaderText="Ph&#242;ng"></asp:BoundField>
                                    <asp:TemplateField SortExpression="JoinDate" HeaderText="Ng&#224;y v&#224;o ng&#224;nh HK">
                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>

                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemTemplate>
                                    <asp:Label runat="server" id="lbJoinDate"></asp:Label>
                                    </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField SortExpression="JoinCompanyDate" HeaderText="Ng&#224;y v&#224;o Cty"><ItemTemplate>
                                    <asp:Label id="lbJoinCompanyDate" runat="server"></asp:Label>
                                    </ItemTemplate>
                                    </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Ng&#224;y nghỉ việc" SortExpression="LeaveDate">
                                           
                                            <ItemTemplate>
                                                <asp:Label ID="lbLeaveDate" runat="server"></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Ng&#224;y sinh">
                                             <ItemTemplate>
                                                <asp:Label ID="lbBirthDay" runat="server"></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Trạng th&#225;i" SortExpression="Status">
                                            
                                            <ItemTemplate>
                                                <asp:Label ID="lbStatus" runat="server"></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>

                                    <RowStyle CssClass="grid-item"></RowStyle>
                                    <PagerStyle CssClass="grid-paper"></PagerStyle>
                                    <HeaderStyle CssClass="grid-header"></HeaderStyle>
                                    <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                                </asp:GridView> 
                            </td>
                       </tr>
                    </table>
                        <uc1:ucPermission ID="UcPermission1" runat="server" />
                    </td>
                </tr>
                
            </table>
        </td>
    </tr>
    </table>
</asp:Content>

