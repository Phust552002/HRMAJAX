<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="WorkdaySharingList.aspx.cs" Inherits="Workdays_WorkdaySharingList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ListBoxEmployee.ascx" TagName="ListBoxEmployee"
    TagPrefix="uc1" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>

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
                    <td valign="top">
                        <table style="width: 100%" class="tableBorder"> 
                            <tr>
                                <td valign="top" class="tdTreeView" align="left">
                                    <asp:TreeView  
                                        ID="TreeView1"
                                        ExpandDepth="1" 
                                        PopulateNodesFromClient="true" 
                                        ShowLines="true" 
                                        ShowExpandCollapse="true" 
                                        runat="server"
                                        OnTreeNodePopulate="TreeView1_TreeNodePopulate" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
                                        <RootNodeStyle CssClass="tvNodeRoot" />
                                        <NodeStyle CssClass="tvNode" />
                                        <ParentNodeStyle CssClass="tvNodeParent" />
                                        <SelectedNodeStyle CssClass="tvNodeSelected" />
                                    </asp:TreeView>  
                                </td>
                                <td valign="top">
                                    <table width="100%" cellpadding="0" cellspacing="0">
                                        <tr>
                                            <td>
                                                <fieldset class="fieldset">
                                                    <legend class="legend"><asp:LinkButton ID="lbtnTitleList" runat="server" OnClick="lbtnTitleList_Click">SAGS</asp:LinkButton></legend>                                                        
                                                    <table style="width: 100%">
                                                        <tr>
                                                            <td style="width:80%" align="right">
                                                                <asp:Label ID="Label11" runat="server" CssClass="label" Text="Tháng"></asp:Label>&nbsp;<asp:DropDownList
                                                                    ID="ddlMonths" runat="server" CssClass="dropDownList">
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
                                                                &nbsp;
                                                                <asp:Label ID="Label12" runat="server" CssClass="label" Text="Năm"></asp:Label>&nbsp;<asp:DropDownList
                                                                    ID="ddlYears" runat="server" CssClass="dropDownList">
                                                                </asp:DropDownList></td>
                                                            <td style="width:10%; text-align: left;">
                                                                &nbsp;&nbsp;
                                                                <asp:Button id="imgSearch" onclick="imgSearch_Click" runat="server" Text="Xem" CssClass="small color green button"></asp:Button></td>
                                                        </tr>
                                                    </table>
                                                    <table style="width: 100%" class="tableBorder">
                                                        <tr>
                                                            <td>
                                                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="100%" CssClass="grid-Border" AllowPaging="True" PageSize="20" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound">
                                                                    <Columns>
                                                                        <asp:TemplateField HeaderText="M&#227; NV" SortExpression="UserId">
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="lbUserId" runat="server"></asp:Label>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Họ t&#234;n" SortExpression="FullName">
                                                                            <ItemTemplate>
                                                                                <asp:LinkButton ID="lbtnFullName" CssClass="hyperlink-Grid"  runat="server" Text='<%# Bind("FullName") %>' ToolTip='<%# Bind("UserId") %>' CommandName="Select"></asp:LinkButton>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Quyền Xem" SortExpression="ReadUserIds">
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="lbReadUserIds" runat="server"></asp:Label>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Quyền Chấm C&#244;ng" SortExpression="WriteUserIds">
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="lbWriteUserIds" runat="server"></asp:Label>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="UpdateUserName" HeaderText="Người Cập nhật" SortExpression="UpdateUserName" />
                                                                        <asp:TemplateField HeaderText="Ng&#224;y Cập Nhật" SortExpression="LastUpdate">
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="lbLastUpdate" runat="server"></asp:Label>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                    </Columns>
                                                                    <HeaderStyle CssClass="grid-header" /> 
                                                                    <RowStyle CssClass ="grid-item" />
                                                                    <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                                                    <PagerStyle CssClass="grid-paper" />  
                                                                    <PagerSettings PageButtonCount="30" />
                                                                    <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                                                </asp:GridView>
                                                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting"
                                                                    SelectMethod="GetByFilter" TypeName="HRMBLL.H1.WorkdayEmployeesBLL" OldValuesParameterFormatString="original_{0}" OnSelected="ObjectDataSource1_Selected">
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
                                                            </td>                                                
                                                        </tr>
                                                        
                                                    </table>
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr>                                            
                                            <td>
                                                <fieldset>
                                                    <legend class="legend"><asp:Label ID="lbTitleAdd" runat="server" Text="Chia sẻ và gửi BCC"></asp:Label></legend>
                                                    <table width="100%" class="tableBorder">
                                                        <tr>
                                                            <td class="tdLabel">
                                                                <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tháng năm"></asp:Label></td>
                                                            <td class="tdValue">
                                                                &nbsp;<asp:DropDownList
                                                                    ID="ddlMonthDept" runat="server" CssClass="dropDownList">
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
                                                                </asp:DropDownList><asp:DropDownList
                                                                    ID="ddlYearDept" runat="server" CssClass="dropDownList">
                                                                </asp:DropDownList></td>
                                                        </tr>
                                                        <tr>
                                                            <td class="tdLabel">
                                                                <asp:Label ID="Label5" runat="server" CssClass="label" Text="Quyền"></asp:Label></td>
                                                            <td class="tdValue">
                                                                <asp:CheckBox ID="chkRead" runat="server" CssClass="value" Text="xem" />
                                                                <asp:CheckBox ID="chkWrite" runat="server" CssClass="value" Text="chấm công" /></td>
                                                        </tr>
                                                        <tr>
                                                            <td class="tdValue" colspan="2">
                                                                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Người nhận"></asp:Label>
                                                                <uc1:ListBoxEmployee ID="ListBoxEmployee1" runat="server" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="tdButton" colspan="2" align="center">
                                                                <asp:Button ID="btnSharing" runat="server" CssClass="small color green button" Text="Chia sẻ" Width="100px" OnClientClick="return confirm('Bạn có chắc muốn chia sẻ bảng chấm công này ?');" OnClick="btnSharing_Click"/>
                                                                &nbsp;
                                                                <asp:Button ID="btnSend" runat="server" CssClass="small color green button" Text="Gửi" Width="100px" OnClick="btnSend_Click" OnClientClick="return confirm('Bạn có chắc muốn gửi bảng chấm công này ?');"/></td>
                                                        </tr>
                                                    </table>
                                                </fieldset>
                                            </td>
                                        </tr>
                                    </table>                                                                        
                                </td>
                            </tr>
                            
                        </table>
                                           
                    </td>
                </tr>
            </table>
     </tr>
</table>
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>   
</asp:Content>

