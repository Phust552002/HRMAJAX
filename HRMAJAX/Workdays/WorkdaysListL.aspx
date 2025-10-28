<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="WorkdaysListL.aspx.cs" Inherits="Workdays_WorkdaysListL" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>
<%@ Register Src="~/Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc3" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%">
    <tr>
        <td><uc1:ucTitle id="UcTitle1" runat="server"></uc1:ucTitle></td>
    </tr>   
    <tr>
        <td valign="top" align="right">   
        <table width="100%">
            <tr>
                <td style="width:10%" align="left">                    
                    <uc2:ActionMenu ID="ActionMenu1" runat="server" />
                </td>
                <td align="right">
                    <asp:Label id="Label1" runat="server" CssClass="label" Text="Tên nhân viên"></asp:Label> <asp:TextBox id="txtFullName" runat="server" CssClass="textBox"></asp:TextBox> &nbsp; &nbsp;<asp:Label id="Label2" runat="server" CssClass="label" Text="Phòng Ban "></asp:Label> 
                    <asp:DropDownList id="ddlDepartment" runat="server" CssClass="dropDownList" DataSourceID="odsDepartments" DataTextField="DepartmentName" DataValueField="DepartmentId" AutoPostBack="True" OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged"> </asp:DropDownList> 
                    <asp:ObjectDataSource id="odsDepartments" runat="server" SelectMethod="GetAllRoots" TypeName="HRMBLL.H0.DepartmentsBLL" OldValuesParameterFormatString="original_{0}"></asp:ObjectDataSource> 
                    <asp:Label id="Label3" runat="server" CssClass="label" Text="Tháng"></asp:Label> 
                    <asp:DropDownList id="ddlMonths" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlMonths_SelectedIndexChanged">
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
                    <asp:Label id="Label4" runat="server" CssClass="label" Text="Năm"></asp:Label> <asp:DropDownList id="ddlYears" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlYears_SelectedIndexChanged"></asp:DropDownList> 
                </td>
                <td>
                    &nbsp;<asp:Button ID="imgSearch" runat="server" Text="Xem" CssClass="small color green button" OnClick="imgSearch_Click" /></td>
            </tr>
        </table>                            
        </td>
    </tr>
    <tr> 
        <td>
            <table width="100%" class="tableBorder">
                <tr>
                    <td>                                                   
                    <asp:GridView id="grdWorkdayEmployees" runat="server" Width="100%" CssClass="grid-Border" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="UserId" OnRowDataBound="grdWorkdayEmployees_RowDataBound" PageSize="20" DataSourceID="odsWorkdayEmployees">
                    <PagerSettings PageButtonCount="30"></PagerSettings>
                        <Columns>
                            <asp:TemplateField SortExpression="FullName" HeaderText="Họ t&#234;n">
                                <ItemStyle Width="25%" HorizontalAlign="Left"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:LinkButton id="lnkFullName" runat="server" CssClass="hyperlink-Grid" Text='<%# Bind("FullName") %>' CommandName="Select" ToolTip='<%# Bind("UserId") %>'></asp:LinkButton> 
                                </ItemTemplate>
                            </asp:TemplateField>
                        <asp:TemplateField SortExpression="XQDL" HeaderText="XQĐL">
                            <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                            <ItemTemplate>
                            <asp:Label id="lbXQDL" runat="server"></asp:Label> 
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField SortExpression="XL" HeaderText="XL">
                            <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                            <ItemTemplate>
                            <asp:Label id="lbXL" runat="server"></asp:Label> 
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ố, Co, KHH, TNLD">
                            <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                            <ItemTemplate>
                                 <asp:HyperLink ID="lnkF_O_Co_KHH_TNLD" runat="server"></asp:HyperLink>                                                                                                
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="F, Fdb, DD">
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
                        <asp:TemplateField SortExpression="GC_LamDem" HeaderText="LĐ (giờ)">
                        <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                            <ItemTemplate>
                                 <asp:Label ID="lbGC_LamDem" runat="server"></asp:Label>                                                                                                
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField SortExpression="MarkL" HeaderText="Điểm HTCV">
                            <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                            <ItemTemplate>
                            <asp:Label runat="server" id="lbMarkL"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField SortExpression="RankL" HeaderText="Xếp Loại">
                            <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                            <ItemTemplate>
                               <asp:Label ID="lbRank" runat="server"></asp:Label>                                                                            
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField SortExpression="RemarkL" HeaderText="Ghi Ch&#250;">
                            <ItemTemplate>
                            <asp:Label runat="server" id="lbRemarkL"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        </Columns>
                        <RowStyle CssClass="grid-item"></RowStyle>
                        <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                        <PagerStyle CssClass="grid-paper"></PagerStyle>
                        <HeaderStyle CssClass="grid-header2"></HeaderStyle>
                        <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                    </asp:GridView>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsWorkdayEmployees" CssClass="grid-Border" Width="100%" OnRowDataBound="GridView1_RowDataBound" AllowPaging="True" PageSize="20" OnPageIndexChanging="GridView1_PageIndexChanging">
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
                                    <asp:Label ID="lbDay1" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>                                    
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day2" SortExpression="Day2">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay2" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>                                    
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day3" SortExpression="Day3">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay3" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day4" SortExpression="Day4">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay4" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day5" SortExpression="Day5">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay5" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day6" SortExpression="Day6">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay6" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day7" SortExpression="Day7">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay7" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day8" SortExpression="Day8">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay8" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day9" SortExpression="Day9">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay9" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day10" SortExpression="Day10">
                               <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay10" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day11" SortExpression="Day11">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay11" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day12" SortExpression="Day12">
                               <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay12" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day13" SortExpression="Day13">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay13" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day14" SortExpression="Day14">
                               <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay14" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day15" SortExpression="Day15">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay15" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day16" SortExpression="Day16">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay16" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>                                
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day17" SortExpression="Day17">
                               <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay17" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day18" SortExpression="Day18">
                               <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay18" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day19" SortExpression="Day19">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay19" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day20" SortExpression="Day20">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay20" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day21" SortExpression="Day21">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay21" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day22" SortExpression="Day22">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay22" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day23" SortExpression="Day23">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay23" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day24" SortExpression="Day24">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay24" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day25" SortExpression="Day25">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay25" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day26" SortExpression="Day26">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay26" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day27" SortExpression="Day27">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay27" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day28" SortExpression="Day28">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay28" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day29" SortExpression="Day29">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay29" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day30" SortExpression="Day30">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay30" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Day31" SortExpression="Day31">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbDay31" runat="server" CssClass="label-Timekeeping-Day"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="X">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbX" runat="server" CssClass="label-Timekeeping-Final"></asp:Label>                                    
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Ph&#233;p">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                 <ItemTemplate>
                                    <asp:Label ID="lbPhep" runat="server" CssClass="label-Timekeeping-Final"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Giờ Đ&#234;m">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                 <ItemTemplate>
                                    <asp:Label ID="lbNightTime" runat="server" CssClass="label-Timekeeping-Night"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField SortExpression="Mark" HeaderText="Điểm HTCV">
                                <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                   <asp:Label ID="lbMarkL" runat="server" ></asp:Label>                                                                            
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Xếp loại">
                                <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:Label ID="lbRankL" runat="server" CssClass="label-Timekeeping-Final"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <RowStyle CssClass="grid-item" />
                        <PagerStyle CssClass="grid-paper" />
                        <HeaderStyle CssClass="grid-header2" />
                        <AlternatingRowStyle CssClass="grid-atlternating-item" />
                        <PagerSettings PageButtonCount="30" />
                    </asp:GridView> 
                    <asp:Panel id="pnNoData" runat="server" Width="100%" Visible="false">
                         <table style="width: 100%">
                            <tr>
                                <td align="center">
                                     <table>
                                        <tr>
                                            <td>
                                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/IconWarning.jpg" /></td>
                                            <td>
                                                <asp:Label ID="Label5" runat="server" CssClass="value" Text="Bảng nhập ngày công tháng này chưa có"></asp:Label></td>
                                        </tr>                                        
                                    </table>
                                </td>                                
                            </tr>                                                              
                        </table>
                    </asp:Panel> 
                    <asp:ObjectDataSource id="odsWorkdayEmployees" runat="server" SelectMethod="GetByFilter" TypeName="HRMBLL.H1.WorkdayEmployeesBLLL" OldValuesParameterFormatString="original_{0}" OnSelecting="odsWorkdayEmployees_Selecting" OnSelected="odsWorkdayEmployees_Selected"><SelectParameters>
                    <asp:Parameter Type="String" Name="fullName"></asp:Parameter>
                    <asp:Parameter Type="String" Name="departmentIds"></asp:Parameter>
                    <asp:Parameter Type="Int32" Name="month"></asp:Parameter>
                    <asp:Parameter Type="Int32" Name="year"></asp:Parameter>
                        <asp:Parameter Name="typeSort" Type="Int32" />
                    </SelectParameters>
                    </asp:ObjectDataSource>
                    <uc3:ucPermission ID="UcPermission1" runat="server" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>        
</asp:Content>

