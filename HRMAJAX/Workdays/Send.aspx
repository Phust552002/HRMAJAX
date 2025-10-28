<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Send.aspx.cs" Inherits="Workdays_Send" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="UserControls/SendTimeKeeping.ascx" TagName="SendTimeKeeping" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc4" %>
<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%">
    <tr>
        <td valign="top">
            <uc1:ucTitle ID="UcTitle1" runat="server" />
        </td>
    </tr>    
    <tr>
        <td align="right">
            <table width="100%" cellpadding="0" cellspacing="0">
                <tr>
                    <td align="left">
                        <uc4:ActionMenu ID="ActionMenu1" runat="server" />                                                
                    </td>
                    <td>
                        <asp:CheckBox ID="chkSend" runat="server" Text="Người nhận" CssClass="value" AutoPostBack="True" OnCheckedChanged="chkSend_CheckedChanged"/>
                    </td>
                    <td align="right">
                        <table cellpadding="0" cellspacing="0">
                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" CssClass="label" Text="Họ tên"></asp:Label>
                                    <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                    &nbsp;&nbsp;<asp:Label ID="Label1" runat="server" CssClass="label" Text="Phòng"></asp:Label>&nbsp;<asp:DropDownList
                                        ID="ddlDepartment" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged" Width="250px"></asp:DropDownList>&nbsp;
                                    <asp:Label ID="Label11" runat="server" CssClass="label" Text="Tháng"></asp:Label>&nbsp;<asp:DropDownList
                                        ID="ddlMonths" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlMonths_SelectedIndexChanged">
                                        <asp:ListItem>1</asp:ListItem>
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
                                    &nbsp;&nbsp;<asp:Label ID="Label12" runat="server" CssClass="label" Text="Năm"></asp:Label>&nbsp;<asp:DropDownList
                                        ID="ddlYears" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlYears_SelectedIndexChanged">
                                    </asp:DropDownList></td>
                                <td>
                                    &nbsp;<asp:Button ID="imgSearch" runat="server" Text="Xem" CssClass="small color green button"
                                        OnClick="imgSearch_Click" /></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            
        </td>
    </tr>
    <tr>
        <td align="left">
            <uc3:SendTimeKeeping ID="SendTimeKeeping1" runat="server" Visible="false" />
        </td>
    </tr>
    <tr>
        <td align="center" valign="top">
                <table width="100%" class="tableBorder">
                    <tr>
                        <td>                    
                        <asp:GridView ID="grdWorkdayEmployees" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                            CssClass="grid-Border" DataKeyNames="UserId" DataSourceID="ObjectDataSource1" OnRowDataBound="grdWorkdayEmployees_RowDataBound" PageSize="20"
                            Width="100%" OnPageIndexChanging="grdWorkdayEmployees_PageIndexChanging">
                            <PagerSettings PageButtonCount="30" />
                            <Columns>
                                <asp:TemplateField SortExpression="FullName" HeaderText="Họ t&#234;n">
                                    <ItemStyle Width="20%" HorizontalAlign="Left"></ItemStyle>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemTemplate>
                                        <asp:HyperLink id="lnkFullName" runat="server" CssClass="hyperlink-Grid" ></asp:HyperLink> 
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField SortExpression="XQD" HeaderText="Xqđ">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <ItemTemplate>
                                        <asp:Label id="lbXQD" runat="server"></asp:Label> 
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField SortExpression="NC_LamViec" HeaderText="X">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemTemplate>
                                        <asp:Label id="lbNC_LamViec" runat="server"></asp:Label> 
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ố, Co, NC, KHH, TNLD">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemTemplate>
                                         <asp:HyperLink ID="lnkF_O_Co_KHH_TNLD" runat="server"></asp:HyperLink>                                                                                                                
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="F, FC, Fdb, DD">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemTemplate>
                                        <asp:HyperLink id="lnkF_Nam_Fdb_DD" runat="server"></asp:HyperLink> 
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="TS">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemTemplate>
                                         <asp:HyperLink ID="lnkF_ThaiSan" runat="server"></asp:HyperLink>                                                                                                                
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField SortExpression="F_CongTac" HeaderText="CT">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <ItemTemplate>
                                        <asp:HyperLink id="lnkF_CongTac" runat="server" ></asp:HyperLink> 
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ho">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemTemplate>
                                          <asp:HyperLink ID="lnkF_Hoc" runat="server"></asp:HyperLink>                                                                                                                
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Kh&#225;c">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemTemplate>
                                          <asp:HyperLink ID="lnkF_Khac" runat="server"></asp:HyperLink>                                                                                                                
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField SortExpression="NghiTuan" HeaderText="NT, NB">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemTemplate>
                                         <asp:HyperLink ID="lnkNghiTuan_NghiBu" runat="server"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField SortExpression="CongDu" HeaderText="X dư qu&#225; khứ" Visible="False">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <ItemTemplate>
                                    <asp:Label runat="server" id="lbOldCongDu"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField SortExpression="CongDu" HeaderText="X dư trong th&#225;ng" Visible="False">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <ItemTemplate>
                                    <asp:Label runat="server" id="lbCongDu"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField SortExpression="CongDu" HeaderText="X dư" Visible="False">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <ItemTemplate>
                                    <asp:Label runat="server" id="lbFinalCongDu"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>                               
                                <asp:TemplateField SortExpression="GC_LamDem" HeaderText="Số giờ LĐ">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemTemplate>
                                         <asp:Label ID="lbGC_LamDem" runat="server"></asp:Label>                                                                                                                
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField SortExpression="Count1_2X" HeaderText="Số 1/2X">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <ItemTemplate>
                                        <asp:Label runat="server" id="lbCount1_2X"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField SortExpression="CountX" HeaderText="Số X">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <ItemTemplate>
                                        <asp:Label runat="server" id="lbCountX"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField SortExpression="Mark" HeaderText="Điểm HTCV">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemTemplate>
                                       <asp:Label ID="lbMark" runat="server" ></asp:Label>                                                                            
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField SortExpression="HTCV" HeaderText="HTCV">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemTemplate>
                                       <asp:Label ID="Label15" runat="server" Text='<%# Bind("HTCV") %>'></asp:Label>                                                                            
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField SortExpression="Remark" HeaderText="Ghi Ch&#250;">
                                    <ItemTemplate>
                                    <asp:Label runat="server" id="lbRemark"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="User tạo" SortExpression="CreateUserName">
                                    <ItemTemplate>
                                        <asp:Label ID="lbCreateUserName" runat="server"></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="50px" HorizontalAlign="Center" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="User cập nhật" SortExpression="UpdateUserName">
                                    <ItemTemplate>
                                        <asp:Label ID="lbUpdateUserName" runat="server"></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="50px" HorizontalAlign="Center" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="Quyền Chấm C&#244;ng" SortExpression="WriteUserIds">
                                    <ItemTemplate>
                                        <asp:Label ID="lbWriteUserIds" runat="server"></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="80px" HorizontalAlign="Left" />
                                </asp:TemplateField>
                            </Columns>
                            <RowStyle CssClass="grid-item" />
                            <PagerStyle CssClass="grid-paper" />
                            <HeaderStyle CssClass="grid-header1" />
                            <AlternatingRowStyle CssClass="grid-atlternating-item" />
                            <SelectedRowStyle CssClass="grid-SelectedRowStyle" />
                        </asp:GridView>
                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" OnSelecting="ObjectDataSource1_Selecting"
                            SelectMethod="GetByFilter" TypeName="HRMBLL.H1.WorkdayEmployeesBLL" OnSelected="ObjectDataSource1_Selected">
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
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CssClass="grid-Border" Width="100%" OnRowDataBound="GridView1_RowDataBound" AllowPaging="True" PageSize="20" OnPageIndexChanging="GridView1_PageIndexChanging">
                                <Columns>
                                    <asp:TemplateField SortExpression="FullName" HeaderText="Họ t&#234;n">
                                        <ItemStyle HorizontalAlign="Left" Width="20%"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:HyperLink id="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day1" SortExpression="Day1">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay1" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight1" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table>                                                                                        
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day2" SortExpression="Day2">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay2" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight2" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table>   
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day3" SortExpression="Day3">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay3" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight3" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table>   
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day4" SortExpression="Day4">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                             <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay4" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight4" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table>   
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day5" SortExpression="Day5">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay5" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight5" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day6" SortExpression="Day6">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay6" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight6" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day7" SortExpression="Day7">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay7" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight7" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day8" SortExpression="Day8">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay8" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight8" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day9" SortExpression="Day9">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay9" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight9" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day10" SortExpression="Day10">
                                       <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay10" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight10" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day11" SortExpression="Day11">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay11" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight11" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day12" SortExpression="Day12">
                                       <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay12" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight12" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day13" SortExpression="Day13">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay13" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight13" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day14" SortExpression="Day14">
                                       <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay14" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight14" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day15" SortExpression="Day15">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay15" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight15" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day16" SortExpression="Day16">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay16" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight16" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day17" SortExpression="Day17">
                                       <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay17" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight17" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day18" SortExpression="Day18">
                                       <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay18" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight18" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day19" SortExpression="Day19">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                             <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay19" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight19" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day20" SortExpression="Day20">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay20" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight20" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day21" SortExpression="Day21">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay21" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight21" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day22" SortExpression="Day22">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                           <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay22" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight22" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day23" SortExpression="Day23">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay23" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight23" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day24" SortExpression="Day24">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay24" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight24" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day25" SortExpression="Day25">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay25" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight25" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day26" SortExpression="Day26">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay26" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight26" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day27" SortExpression="Day27">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay27" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight27" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day28" SortExpression="Day28">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay28" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight28" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day29" SortExpression="Day29">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay29" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight29" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day30" SortExpression="Day30">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay30" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight30" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day31" SortExpression="Day31">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbDay31" runat="server" CssClass="label-Timekeeping-Day"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbNight31" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="X">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="center"><asp:Label ID="lbX" runat="server" CssClass="label-Timekeeping-Final"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td align="right"><asp:Label ID="lbXNight" runat="server" CssClass="label-Timekeeping-Night"></asp:Label></td>
                                                </tr>
                                            </table> 
                                            
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Ph&#233;p">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                         <ItemTemplate>
                                            <asp:Label ID="lbPhep" runat="server" CssClass="label-Timekeeping-Final"></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="X dư">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                         <ItemTemplate>
                                            <asp:Label ID="lbXDu" runat="server" CssClass="label-Timekeeping-Final"></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField SortExpression="Mark" HeaderText="Điểm HTCV">
                                        <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                           <asp:Label ID="lbMark" runat="server" ></asp:Label>                                                                            
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="HTCV">
                                        <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lbHTCV" runat="server" CssClass="label-Timekeeping-Final"></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <RowStyle CssClass="grid-item" />
                                <PagerStyle CssClass="grid-paper" />
                                <HeaderStyle CssClass="grid-header1" />
                                <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                <PagerSettings PageButtonCount="30" />
                            </asp:GridView>                                                        
                        </td>
                    </tr>                
                </table>               
                <uc2:ucPermission ID="UcPermission1" runat="server" />
            </td>
    </tr>
</table>
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>        
</asp:Content>

