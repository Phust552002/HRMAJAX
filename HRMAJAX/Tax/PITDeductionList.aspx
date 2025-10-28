<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="PITDeductionList.aspx.cs" Inherits="Tax_PITDeductionList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

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
                                <td style="width:20%" align="left">                                                                       
                                    <uc2:ActionMenu ID="ActionMenu1" runat="server" />
                                </td>
                                <td style="width:80%" align="right">
                                    <table>
                                        <tr>                
                                            <td align="right">
                                                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
                                                    <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                                &nbsp;
                                                    <asp:Label ID="lbDepartment" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
                                                    <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList">
                                                    </asp:DropDownList>&nbsp; &nbsp;&nbsp;<asp:ImageButton ID="imgSearch" runat="server"
                                                        ImageUrl="~/Images/Icon-Search.gif" OnClick="imgSearch_Click" />
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
                                
<asp:GridView id="grdPITDeductionList" runat="server" Width="100%" CssClass="grid-Border" AllowSorting="True" AllowPaging="True" PageSize="20" OnRowDataBound="grdPITDeductionList_RowDataBound" AutoGenerateColumns="False" DataKeyNames="UserId" DataSourceID="odsIPTDeduction">
<PagerSettings PageButtonCount="30"></PagerSettings>
<Columns>
<asp:TemplateField SortExpression="FullName" HeaderText="C&#225; Nh&#226;n C&#243; Thu Nhập">
<ItemStyle HorizontalAlign="Left"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
<ItemTemplate>
                                                   <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid-Bold"></asp:HyperLink>
                                               
</ItemTemplate>
</asp:TemplateField>
    <asp:TemplateField HeaderText="Ph&#242;ng" SortExpression="DepartmentCode">
        <ItemTemplate>
            <asp:Label ID="lbDepartmentCode" runat="server"></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>
    <asp:BoundField DataField="RFullName" HeaderText="Họ v&#224; T&#234;n Người Th&#226;n"
        SortExpression="RFullName" />
    <asp:BoundField DataField="RelationTypeName" HeaderText="Quan Hệ" SortExpression="RelationTypeName" >
        <ItemStyle HorizontalAlign="Center" />
        <HeaderStyle HorizontalAlign="Center" />
    </asp:BoundField>
    <asp:TemplateField HeaderText="Từ Th&#225;ng/Năm">
        <ItemTemplate>
            <asp:Label ID="lbFromDate" runat="server"></asp:Label>
        </ItemTemplate>
        <ItemStyle HorizontalAlign="Center" />
        <HeaderStyle HorizontalAlign="Center" />
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Đến Th&#225;ng/Năm">
        <ItemTemplate>
            <asp:Label ID="lbToDate" runat="server"></asp:Label>
        </ItemTemplate>
        <ItemStyle HorizontalAlign="Center" />
        <HeaderStyle HorizontalAlign="Center" />
    </asp:TemplateField>
</Columns>

<RowStyle CssClass="grid-item"></RowStyle>

<PagerStyle CssClass="grid-paper"></PagerStyle>

<HeaderStyle CssClass="grid-header"></HeaderStyle>

<AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
</asp:GridView> 
<asp:ObjectDataSource id="odsIPTDeduction" runat="server" OnSelecting="odsIPTDeduction_Selecting" TypeName="HRMBLL.H1.PITDeductionBLL" SelectMethod="GetByFilter" OnSelected="odsIPTDeduction_Selected"><SelectParameters>
<asp:Parameter Type="String" Name="fullName"></asp:Parameter>
<asp:Parameter Type="Int32" Name="rootId"></asp:Parameter>
</SelectParameters>
</asp:ObjectDataSource> 

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

