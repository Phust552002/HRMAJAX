<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="WorkdayOverTimeList.aspx.cs" Inherits="Workdays_WorkdayOverTimeList" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
        <tr>
            <td valign="top">
                <table style="width: 100%">
                    <tr>
                        <td>
                            <uc1:ucTitle ID="UcTitle1" runat="server" />                                                        
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <table style="width:100%">
                                <tr>
                                     <td style="width:10%" align="left">
                                     <uc3:ActionMenu ID="ActionMenu1" runat="server" />
                                     </td>
                                    <td align="right">
                                         <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
                                        <asp:TextBox ID="txtFullName" runat="server" Width="100px" CssClass="textBox"></asp:TextBox>
                                        &nbsp;<asp:Label ID="Label2" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>&nbsp;<asp:DropDownList ID="ddlDepartments" runat="server" CssClass="dropDownList" Width="200px">
                                            </asp:DropDownList>
                                        &nbsp;<asp:Label ID="Label3" runat="server" CssClass="label" Text="Tháng/năm"></asp:Label>&nbsp;<asp:DropDownList ID="ddlMonths" runat="server" CssClass="dropDownList">
                                               <asp:ListItem Value="0" Text=""></asp:ListItem>
                                                <asp:ListItem Value="1" Text="1"></asp:ListItem>
                                                <asp:ListItem Value="2" Text="2"></asp:ListItem>
                                                <asp:ListItem Value="3" Text="3"></asp:ListItem>
                                                <asp:ListItem Value="4" Text="4"></asp:ListItem>
                                                <asp:ListItem Value="5" Text="5"></asp:ListItem>
                                                <asp:ListItem Value="6" Text="6"></asp:ListItem>
                                                <asp:ListItem Value="7" Text="7"></asp:ListItem>
                                                <asp:ListItem Value="8" Text="8"></asp:ListItem>
                                                <asp:ListItem Value="9" Text="9"></asp:ListItem>
                                                <asp:ListItem Value="10" Text="10"></asp:ListItem>
                                                <asp:ListItem Value="11" Text="11"></asp:ListItem>
                                                <asp:ListItem Value="12" Text="12"></asp:ListItem>
                                                
                                            </asp:DropDownList><asp:DropDownList ID="ddlYears" runat="server" CssClass="dropDownList" AppendDataBoundItems="true" >
                                           <asp:ListItem Value="0" Text=""></asp:ListItem>
                                            </asp:DropDownList>&nbsp;&nbsp; &nbsp;&nbsp;
                                    </td>
                                    <td >
                                        &nbsp;&nbsp;&nbsp;<asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif"
                                            OnClick="imgSearch_Click" />
                                    </td>
                                </tr>
                            </table>                                                            
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <table width="100%" class="tableBorder">
                                <tr>
                                    <td>
                                        <asp:GridView ID="grdWorkdayOverTimeList" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                            CssClass="grid-Border" DataSourceID="ObjectDataSource1" PageSize="20" 
                                            Width="100%" OnRowDataBound="grdWorkdayOverTimeList_RowDataBound">
                                            <PagerSettings PageButtonCount="30" />
                                            <Columns>
                                                <asp:TemplateField HeaderText="Họ t&#234;n" SortExpression="FullName">
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" Width="20%"/>
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="PositionName" HeaderText="Chức danh" SortExpression="PositionName">
                                                    <ItemStyle HorizontalAlign="Left"  Width="10%"/>
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                </asp:BoundField>
                                                <asp:TemplateField HeaderText="Làm thêm ngày thường ban ngày" 
                                                    SortExpression="Mark">
                                                    <ItemStyle HorizontalAlign="Center" Width="5%"/>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbLamthemNTbngay" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Làm thêm ngày thường ban đêm">
                                                     <ItemTemplate>
                                                        <asp:Label ID="lbLamthemCNbdem" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center"  Width="5%"/>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Làm thêm nghỉ tuần ban ngày" 
                                                    SortExpression="HTCV">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbLamthemNTbdem" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center"  Width="5%"/>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Làm thêm nghỉ tuần ban đêm">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbLamthemLTbngay" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center"  Width="5%"/>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Làm thêm lễ tết ban ngày">
                                                     <ItemTemplate>
                                                        <asp:Label ID="lbLamthemCNbngay" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center"  Width="5%"/>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Làm thêm lễ tết ban đêm">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbLamthemLTbdem" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center"  Width="5%"/>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Giải trình" SortExpression="Remark">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbRemark" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Th&#225;ng/Năm" SortExpression="WorkdayDate">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbWorkdayDate" runat="server" ></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" Width="100px"/>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                            </Columns>
                                            <RowStyle CssClass="grid-item" />
                                            <PagerStyle CssClass="grid-paper" />
                                            <HeaderStyle CssClass="grid-header" />
                                            <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting"
                                SelectMethod="GetAllByFilterHTCV" TypeName="HRMBLL.H1.WorkdayEmployeesBLL" OldValuesParameterFormatString="original_{0}" OnSelected="ObjectDataSource1_Selected">
                                <SelectParameters>
                                    <asp:Parameter Name="fullName" Type="String" />
                                    <asp:Parameter Name="deptIds" Type="String" />
                                    <asp:Parameter Name="minMark" Type="Int32" />
                                    <asp:Parameter Name="maxMark" Type="Int32" />
                                    <asp:Parameter Name="month" Type="Int32" />
                                    <asp:Parameter Name="year" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            
                        </td>
                    </tr>                    
                </table>
                
            </td>
        </tr>
    </table>
<uc2:ucPermission ID="UcPermission1" runat="server" />
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>
</asp:Content>

