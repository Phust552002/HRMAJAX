<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="StatisticTimeWork.aspx.cs" Inherits="TimeWorks_StatisticTimeWork" Title="Untitled Page" %>

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
                    <asp:DropDownList id="ddlDepartment" runat="server" CssClass="dropDownList"> </asp:DropDownList> 
                    
                    <asp:Label id="Label3" runat="server" CssClass="label" Text="Tháng"></asp:Label> 
                    <asp:DropDownList id="ddlMonths" runat="server" CssClass="dropDownList">
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
                    <asp:Label id="Label4" runat="server" CssClass="label" Text="Năm"></asp:Label> <asp:DropDownList id="ddlYears" runat="server" CssClass="dropDownList"></asp:DropDownList> 
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
                        <asp:GridView ID="grdEmployeesList" runat="server" AllowPaging="True" AllowSorting="True"
                            AutoGenerateColumns="False" CssClass="grid-Border" DataKeyNames="UserId" DataSourceID="odsEmployees"
                            OnRowDataBound="grdEmployeesList_RowDataBound" PageSize="20" Width="100%">
                            <PagerSettings PageButtonCount="30" />
                            <Columns>
                                <asp:BoundField DataField="UserId" DataFormatString="{0:000#}" HeaderText="M&#227; NV"
                                    HtmlEncode="False" SortExpression="UserId">
                                    <ItemStyle HorizontalAlign="Left" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:BoundField>
                                <asp:TemplateField HeaderText="Họ v&#224; t&#234;n" SortExpression="FullName">
                                    <ItemStyle HorizontalAlign="Left" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                    <ItemTemplate>
                                        <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid">[lnkFullName]</asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="DepartmentFullName" HeaderText="Ph&#242;ng" SortExpression="RootId" />
                                <asp:TemplateField HeaderText="Xqđ">
                               <ItemStyle Width="30px" HorizontalAlign="Center"/>
                                    <ItemTemplate>
                                        <asp:Label ID="lbXQD" runat="server" Text=""></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Giờ C&#244;ng  qđ">
                                <ItemTemplate>
                                        <asp:Label ID="lbHourXQD" runat="server" Text="Label"></asp:Label>
                                    </ItemTemplate>
                                 <ItemStyle Width="30px" HorizontalAlign="Center"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="X điểm danh">
                                    <ItemStyle Width="30px" HorizontalAlign="Center"/>
                                    <ItemTemplate>
                                        <asp:Label ID="lbXQDReal" runat="server" Text=""></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Giờ C&#244;ng Thực Tế">
                              <ItemStyle Width="30px" HorizontalAlign="Center"/>
                                <ItemTemplate>
                                        <asp:Label ID="lbHourXQDReal" runat="server" Text=""></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ghi ch&#250;">
                                <ItemStyle Width="5%"/>
                                </asp:TemplateField>
                            </Columns>
                            <RowStyle CssClass="grid-item" />
                            <PagerStyle CssClass="grid-paper" />
                            <HeaderStyle CssClass="grid-header1" />
                            <AlternatingRowStyle CssClass="grid-atlternating-item" />
                        </asp:GridView>
                        <asp:ObjectDataSource ID="odsEmployees" runat="server" OldValuesParameterFormatString="original_{0}"
                            OnSelected="odsEmployees_Selected" OnSelecting="odsEmployees_Selecting" SelectMethod="GetByDeptIds"
                            SortParameterName="sortParameter" TypeName="HRMBLL.H0.EmployeesBLL">
                            <SelectParameters>
                                <asp:Parameter Name="deptIds" Type="String" />
                                <asp:Parameter Name="rootId" Type="Int32" />
                                <asp:Parameter Name="fullName" Type="String" />
                                <asp:Parameter Name="sortParameter" Type="String" />
                                <asp:Parameter Name="AirlinesWorking" Type="String" />
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

