<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Copy.aspx.cs" Inherits="Workdays_Copy" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%">
    <tr>
        <td valign="top">
            <uc1:ucTitle ID="UcTitle1" runat="server" />
        </td>
    </tr>
    <tr>
        <td valign="top" align="center">
            <table width="100%" cellpadding="0" cellspacing="0">
                <tr>
                    <td align="right" style="width:65%">
                        <asp:Label ID="lbTitle" runat="server" Text="Label" CssClass="value-bold"></asp:Label></td>
                    <td align="right" style="width:35%">
                        <asp:DropDownList ID="ddlViewType" runat="server" AutoPostBack="True" CssClass="dropDownList"
                            OnSelectedIndexChanged="ddlViewType_SelectedIndexChanged">
                            <asp:ListItem Value="1">Xem mặc định</asp:ListItem>
                            <asp:ListItem Value="2">Xem Chi tiết</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
            </table>
            
        </td>
    </tr>
    <tr>
        <td>
            <fieldset>
                <legend class="legend">
                    <asp:Label ID="lbTitleUserSelected" runat="server" Text="Label"></asp:Label></legend>
                    <table width="100%" class="tableBorder">
                        <tr>
                            <td>
                                <asp:GridView id="grdWorkdayEmployees" runat="server" Width="100%" CssClass="grid-Border" PageSize="5" OnRowDataBound="grdWorkdayEmployees_RowDataBound" DataKeyNames="UserId" AutoGenerateColumns="False" AllowPaging="True">
                                <PagerSettings PageButtonCount="30"></PagerSettings>
                                    <Columns>
                                    <asp:TemplateField SortExpression="FullName" HeaderText="Họ t&#234;n">
                                        <ItemStyle Width="25%" HorizontalAlign="Left"></ItemStyle>
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
                                    <asp:TemplateField SortExpression="CongDu" HeaderText="X dư qu&#225; khứ">
                                        <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                        <ItemTemplate>
                                        <asp:Label runat="server" id="lbOldCongDu"></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField SortExpression="CongDu" HeaderText="X dư trong th&#225;ng">
                                        <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                        <ItemTemplate>
                                        <asp:Label runat="server" id="lbCongDu"></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField SortExpression="CongDu" HeaderText="X dư">
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
                                    </Columns>

                                <RowStyle CssClass="grid-item"></RowStyle>
                                <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                <PagerStyle CssClass="grid-paper"></PagerStyle>
                                <HeaderStyle CssClass="grid-header1"></HeaderStyle>
                                <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                                </asp:GridView> 
                            </td>
                        </tr>
                    </table>
                <uc3:ucPermission ID="UcPermission1" runat="server" />
            </fieldset>
            <fieldset>
                <legend class="legend">
                    <asp:Label ID="lbTitleUserCopy" runat="server" Text="Label"></asp:Label></legend>
                    <table width="100%" cellpadding="0" cellspacing="0">
                        <tr>
                            <td align="right">
                                <table>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label3" runat="server" CssClass="label" Text="Họ tên"></asp:Label>
                                            <asp:TextBox
                                                ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                            &nbsp;&nbsp;
                                        </td>
                                        <td style="width: 10px">
                                            <asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif"
                                                OnClick="imgSearch_Click" /></td>
                                    </tr>
                                </table>  
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table width="100%" class="tableBorder">
                                    <tr>
                                        <td>
                                            <asp:GridView id="grdCopy" runat="server" Width="100%" CssClass="grid-Border" PageSize="5" OnRowDataBound="grdCopy_RowDataBound" DataKeyNames="UserId" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                                            <PagerSettings PageButtonCount="30"></PagerSettings>
                                                <Columns>
                                                <asp:TemplateField SortExpression="FullName" HeaderText="Họ t&#234;n">
                                                    <ItemStyle Width="25%" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink> 
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
                                                <asp:TemplateField SortExpression="CongDu" HeaderText="X dư qu&#225; khứ">
                                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                    <asp:Label runat="server" id="lbOldCongDu"></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField SortExpression="CongDu" HeaderText="X dư trong th&#225;ng">
                                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                    <asp:Label runat="server" id="lbCongDu"></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField SortExpression="CongDu" HeaderText="X dư">
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
                                                <asp:TemplateField HeaderText="Copy">
                                                    <ItemStyle Width="30px" HorizontalAlign="Center"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                    <ItemTemplate>
                                                       <asp:CheckBox ID="chkChoose" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                </Columns>

                                            <RowStyle CssClass="grid-item"></RowStyle>
                                            <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                            <PagerStyle CssClass="grid-paper"></PagerStyle>
                                            <HeaderStyle CssClass="grid-header1"></HeaderStyle>
                                            <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                                            </asp:GridView> 
                                            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting"
                                                SelectMethod="GetByFilterByNotUser" TypeName="HRMBLL.H1.WorkdayEmployeesBLL" OldValuesParameterFormatString="original_{0}">
                                                <SelectParameters>
                                                    <asp:Parameter Name="fullName" Type="String" />
                                                    <asp:Parameter Name="departmentIds" Type="String" />
                                                    <asp:Parameter Name="month" Type="Int32" />
                                                    <asp:Parameter Name="year" Type="Int32" />
                                                    <asp:Parameter Name="status" Type="Int32" />
                                                    <asp:Parameter Name="receivedUserId" Type="Int32" />
                                                    <asp:Parameter Name="typeSort" Type="Int32" />
                                                    <asp:Parameter Name="notUserId" Type="Int32" />
                                                </SelectParameters>
                                            </asp:ObjectDataSource>                                            
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td class="tdButton" align="center">
                                <table>
                                    <tr>
                                        <td><asp:ImageButton ID="btnSave" runat="server" OnClick="btnSave_Click" ImageUrl="~/Images/save.gif"/></td>
                                        <td><asp:LinkButton ID="lnkSave" runat="server" OnClick="btnSave_Click" CssClass="hyperlink-Button">Lưu</asp:LinkButton></td>
                                        <td>
                                            &nbsp; &nbsp;
                                            <asp:ImageButton ID="btnCancel" runat="server" OnClick="btnCancel_Click" ImageUrl="~/Images/back.gif"/></td>
                                        <td><asp:LinkButton ID="lnkCancel" runat="server" OnClick="btnCancel_Click" CssClass="hyperlink-Button">Thoát</asp:LinkButton></td>
                                    </tr>
                                </table>     
                            </td>
                        </tr>
                    </table>
                      
                    
            </fieldset>
        </td>
    </tr>
</table>
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>
</asp:Content>

