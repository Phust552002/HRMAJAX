<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="VaccinationList.aspx.cs" Inherits="Covid19_VaccinationList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> 
    <%--<table style="width: 100%">
    <tr>
        <td style="text-align:left">                   
            <asp:RadioButtonList ID="rblView" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rblView_SelectedIndexChanged" RepeatDirection="Horizontal" CssClass="tdLabel" RepeatLayout="Flow" Font-Bold="True">
                <asp:ListItem Selected="True" Value="0">Danh sách</asp:ListItem>
                <asp:ListItem Value="1">Power BI</asp:ListItem>
            </asp:RadioButtonList>     
        </td>
    </tr>
    </table>
    <table style="width: 100%" id="tbPowerBi" runat="server" visible="false">
    <tr>
        <td>                   
           <iframe width="100%" height="768" src="https://app.powerbi.com/view?r=eyJrIjoiNTVhYjU1YjMtMTM1NC00MGZlLTk0MTYtMjFkNDg1MWZkYWZhIiwidCI6ImY3OTY3M2Q3LThlOTUtNGM3My04YWJiLTU0OGUzMWFhM2M1YSIsImMiOjEwfQ%3D%3D&pageName=ReportSection" frameborder="0" allowFullScreen="true"></iframe>                    
        </td>
    </tr>
    </table>--%>
    <table width="100%" id="tbGridView" runat="server" visible="true">   
    <tr>
        <td align="center" valign="top">
            <table width="100%">
                <tr>
                    <td>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
                            <ContentTemplate>  
                                <uc5:ucTitle ID="UcTitle1" runat="server" /> 
                            </ContentTemplate>
                             <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="imgSearch" EventName="Click" />
                             </Triggers>
                        </asp:UpdatePanel>                      
                    </td>
                </tr>
                <tr>
                    <td>
                        <table width="100%">
                            <tr>
                                <%--<td style="width:20%" align="left">                                                                       
                                    <uc2:ActionMenu ID="ActionMenu1" runat="server" />
                                </td>--%>
                                <td style="width:80%" align="right">
                                    <table>
                                        <tr>                
                                            <td align="right">
                                                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
                                                    <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                                &nbsp;
                                                    <asp:Label ID="lbDepartment" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
                                                    <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList">
                                                    </asp:DropDownList>
                                                 &nbsp;    
                                                    <asp:Label ID="lbType" runat="server" CssClass="label" Text="Phân loại"></asp:Label>
                                                    <asp:DropDownList ID="ddlType" runat="server" CssClass="dropDownList" AppendDataBoundItems="true">
                                                        <asp:ListItem Text="Tất cả" Value="-1" Selected="True"></asp:ListItem>
                                                        <asp:ListItem Text="Chưa tiêm" Value="0"></asp:ListItem>
                                                        <asp:ListItem Text="Tiêm 1 mũi" Value="1"></asp:ListItem>
                                                        <asp:ListItem Value="2">Tiêm 2 mũi</asp:ListItem>
                                                    </asp:DropDownList>
                                                &nbsp;&nbsp;&nbsp<asp:Button ID="imgSearch" runat="server"
                                                        Text="Xem" CssClass="small color green button" OnClick="imgSearch_Click" />
                                                &nbsp;
                                            </td>
                                        </tr>
                                        
                                    </table>
                                </td>
                            </tr>
                        </table>                             
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <table class="tableBorder" width="100%">
                         <tr>
                            <td>  
                                 <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                                 <ContentTemplate>

<asp:GridView id="grdEmployeesList" runat="server" Width="100%" CssClass="grid-Border" AllowSorting="True" AllowPaging="True" PageSize="20" OnRowDataBound="grdEmployeesList_RowDataBound" AutoGenerateColumns="False" DataSourceID="odsEmployees" DataKeyNames="UserId" OnSorting="grdEmployeesList_Sorting">
<PagerSettings PageButtonCount="30"></PagerSettings>
<Columns>
<asp:BoundField HtmlEncode="False" DataFormatString="{0:000#}" DataField="UserId" SortExpression="UserId" HeaderText="M&#227; NV">
<ItemStyle HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
</asp:BoundField>

<%--<asp:TemplateField SortExpression="FullName" HeaderText="Họ v&#224; t&#234;n">
<ItemStyle HorizontalAlign="Left"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
<ItemTemplate>
    <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid">[lnkFullName]</asp:HyperLink>
                                               
</ItemTemplate>
</asp:TemplateField>--%>
    <asp:BoundField DataField="FullName" SortExpression="FullName" HeaderText="Họ và tên">
    <ItemStyle HorizontalAlign="Left"></ItemStyle>

    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
    </asp:BoundField>
<asp:BoundField DataField="PositionName" SortExpression="PositionName" HeaderText="Chức danh">
<ItemStyle HorizontalAlign="Left"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>

<asp:BoundField DataField="DepartmentFullName" SortExpression="RootId" HeaderText="Ph&#242;ng"></asp:BoundField>

<asp:TemplateField HeaderText="Số mũi tiêm">
<ItemStyle HorizontalAlign="Center" Width="70px"></ItemStyle>
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:Label runat="server" id="lbNumberOfDose"></asp:Label>
</ItemTemplate>
</asp:TemplateField>

<asp:TemplateField SortExpression="FirstDose" HeaderText="Ngày tiêm mũi 1">
<ItemStyle HorizontalAlign="Center" Width="100px"></ItemStyle>
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:Label runat="server" id="lbFirstDose"></asp:Label>
</ItemTemplate>
</asp:TemplateField>

<asp:TemplateField SortExpression="SecondDose" HeaderText="Ngày tiêm mũi 2">
<ItemStyle HorizontalAlign="Center" Width="100px"></ItemStyle>
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:Label runat="server" id="lbSecondDose"></asp:Label>
</ItemTemplate>
</asp:TemplateField>

<asp:BoundField DataField="Remarks" SortExpression="Remarks" HeaderText="Ghi chú">
<ItemStyle HorizontalAlign="Left" Width="500px"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
</Columns>

<RowStyle CssClass="grid-item"></RowStyle>

<PagerStyle CssClass="grid-paper"></PagerStyle>

<HeaderStyle CssClass="grid-header"></HeaderStyle>

<AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
</asp:GridView> 
<asp:ObjectDataSource id="odsEmployees" runat="server" OnSelecting="odsEmployees_Selecting" TypeName="HRMBLL.H8.Covid19BLL" SelectMethod="GetVaccinationInfoByDeptIds" OldValuesParameterFormatString="original_{0}" OnSelected="odsEmployees_Selected"><SelectParameters>
<asp:Parameter Type="String" Name="deptIds"></asp:Parameter>
<asp:Parameter Type="Int32" Name="rootId"></asp:Parameter>
<asp:Parameter Type="String" Name="fullName"></asp:Parameter>
<asp:Parameter Type="Int32" Name="type"></asp:Parameter>
</SelectParameters>
</asp:ObjectDataSource> 

</ContentTemplate>
                                     <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="imgSearch" EventName="Click" />
                                     </Triggers>
                                </asp:UpdatePanel>
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

