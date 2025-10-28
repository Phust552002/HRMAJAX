<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Covid19_Details" %>
<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table style="width: 100%">
    <tr>
        <td>                   
           <uc1:ucTitle ID="UcTitle1" runat="server" />                        
        </td>
    </tr>
    <tr>
        <td>
          <table style="width: 100%" class="tableBorder">                                    
                 <tr>
                    <td align="left" class="tdLabel" style="width:30%">
                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tìm nhân viên"></asp:Label></td>
                    <td align="left" class="tdValue">
                        <table cellpadding="0" cellspacing="0">
                            <tr>
                                <td align="left" >
                                    <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                </td>
                                <td align="left" >
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
                        <asp:DropDownList ID="ddlEmployees" runat="server" CssClass="dropDownList" AppendDataBoundItems="True" OnSelectedIndexChanged="ddlEmployees_SelectedIndexChanged"  AutoPostBack="true">
                            <asp:ListItem Value="0" Text=""></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="lbEmployeeCode" runat="server" CssClass="label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left" class="tdLabel">
                        &nbsp;<asp:Label ID="Label5" runat="server" CssClass="label" Text="Loại"></asp:Label></td>
                    <td align="left" class="tdValue">
                                                    <asp:DropDownList ID="ddlType" runat="server" CssClass="dropDownList" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="ddlType_SelectedIndexChanged">
                                                    <asp:ListItem Text="F0" Value="F0"></asp:ListItem><asp:ListItem Text="F1" Value="F1"></asp:ListItem>
                                                    </asp:DropDownList></td>
                </tr>
                <tr id="trF0" runat="server" visible="false">
                    <td align="left" class="tdLabel">
                        <asp:Label ID="Label10" runat="server" CssClass="label" Text="F0 liên quan"></asp:Label></td>
                    <td align="left" class="tdValue">
                        <asp:DropDownList ID="ddlF0" runat="server" CssClass="dropDownList" AppendDataBoundItems="True" >
                            <asp:ListItem Value="0" Text=""></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="Label11" runat="server" CssClass="label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left" class="tdLabel">
                        &nbsp;<asp:Label ID="Label9" runat="server" CssClass="label" Text="Nơi phát hiện/tiếp xúc"></asp:Label></td>
                    <td align="left" class="tdValue">
                                                    <asp:DropDownList ID="ddlPlace" runat="server" CssClass="dropDownList" AppendDataBoundItems="true">
                                                    <asp:ListItem Text="Chưa xác định" Value="0"></asp:ListItem>
                                                    <asp:ListItem Text="Địa phương" Value="1"></asp:ListItem>
                                                    <asp:ListItem Text="Nơi làm việc" Value="2"></asp:ListItem>
                                                    </asp:DropDownList></td>
                </tr>
                <tr>
                    <td align="left" class="tdLabel">
                        <asp:Label ID="Label6" runat="server" CssClass="label" Text="Ngày phát hiện/tiếp xúc"></asp:Label></td>
                    <td align="left" class="tdValue">
                                    <uc2:CalendarPicker ID="cpTestContactDate" runat="server" />
                                </td>
                </tr>
                <tr>
                    <td align="left" class="tdLabel">
                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Ngày bắt đầu cách ly"></asp:Label></td>
                    <td align="left" class="tdValue">
                                    <uc2:CalendarPicker ID="cpQuarantineBeginDate" runat="server" />
                                </td>
                </tr>
                 <tr>
                    <td align="left" class="tdLabel">
                        <asp:Label ID="Label7" runat="server" CssClass="label" Text="Ngày kết thúc cách ly"></asp:Label></td>
                    <td align="left" class="tdValue">
                                    <uc2:CalendarPicker ID="cpQuarantineEndDate" runat="server" />
                                </td>
                </tr>
                <tr>
                    <td align="left" class="tdLabel"><asp:Label ID="Label4" runat="server" 
                            CssClass="label" Text="Ghi chú"></asp:Label></td>
                    <td align="left" class="tdValue">
                        <asp:TextBox ID="txtRemarks" runat="server" CssClass="textBox" Width="99%" 
                            TextMode="MultiLine"></asp:TextBox></td>
                </tr>
                <tr>
                        <td class="tdLabel">
                        <asp:Label ID="Label8" runat="server" CssClass="label" Text="Tập tin đính kèm"></asp:Label></td>
                    <td class="tdValue" colspan="3">
                        <div>
                            <telerik:RadAsyncUpload ID="rauCorrectiveActionAttachments" runat="server" MultipleFileSelection="Automatic" HideFileInput="true" Width="100%" PostbackTriggers="btnSave"></telerik:RadAsyncUpload>
                        </div>
                        <div>
                            <asp:GridView ID="gvCorrectiveActionAttachments" runat="server" AutoGenerateColumns="False" Width="100%" GridLines="None" ShowHeader="False" OnRowDataBound="gvCorrectiveActionFileList_RowDataBound">
                                <Columns>
                                    <%--<asp:BoundField DataField="Text" HeaderText="File Name" />--%>
                                    <asp:TemplateField HeaderText="Tên file">
                                        <ItemStyle HorizontalAlign="Left"></ItemStyle>

                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:HyperLink ID="lnkFile" runat="server" CssClass="hyperlink-Grid">[lnkFullName]</asp:HyperLink>
                                               
                                        </ItemTemplate>
                                        </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ImageUrl="~/images/icon-save.gif" ID="lnkDownload" Text = "Download" CommandArgument = '<%# Eval("Value") %>' runat="server" OnClick = "DownloadFile" Width="16px"></asp:ImageButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ImageUrl="~/images/icon-delete.gif" ID = "lnkDelete" Text = "Delete" CommandArgument = '<%# Eval("Value") %>' runat = "server" OnClick = "DeleteFile"  Width="16px" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>

                            </asp:GridView>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td class="tdButton" colspan="2" align="center">                                
                        <asp:Button ID="btnSave" runat="server" CssClass="small color green button" Text="Lưu" Width="100px" OnClick="btnSave_Click" OnClientClick="return confirm('Bạn có chắc chắn muốn lưu người này?')"/>
                        &nbsp;&nbsp;
                        <asp:Button ID="btnCancel" runat="server" CssClass="small color blue button" Text="Thoát" Width="100px" OnClick="btnCancel_Click"/>
                        &nbsp;&nbsp;
                        <asp:Button ID="btnDelete" runat="server" CssClass="small color red button" Text="Xóa" Width="100px" OnClick="btnDelete_Click" OnClientClick="return confirm('Bạn có chắc chắn muốn xóa người này?')" Visible="False"/>
                    </td>
                </tr>                           
                </table>
        </td>
    </tr>                                         
</table>

    <fieldset class="fieldset" style="padding:2px 2px 2px 2px">
                                <legend class="legend"> Lịch sử</legend>
                                    <table style="width: 100%">                                        
                                        <tr>
                                            <td align="center">
                                                <%--<asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                                                    <ContentTemplate>--%>
                                                <asp:GridView id="grdHistory" runat="server" Width="100%" CssClass="grid-Border" AllowSorting="True" AllowPaging="True" PageSize="20" OnRowDataBound="grdHistory_RowDataBound" AutoGenerateColumns="False" DataSourceID="odsHistory" DataKeyNames="UserId">
                                                <PagerSettings PageButtonCount="30"></PagerSettings>
                                                <Columns>
                                                <%--<asp:BoundField HtmlEncode="False" DataFormatString="{0:000#}" DataField="UserId" SortExpression="UserId" HeaderText="M&#227; NV">
                                                <ItemStyle HorizontalAlign="Left"></ItemStyle>

                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                </asp:BoundField>

                                                <asp:TemplateField SortExpression="FullName" HeaderText="Họ v&#224; t&#234;n">
                                                <ItemStyle HorizontalAlign="Left"></ItemStyle>

                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid">[lnkFullName]</asp:HyperLink>
                                               
                                                </ItemTemplate>
                                                </asp:TemplateField>--%>
                                                <%--<asp:BoundField DataField="PositionName" SortExpression="PositionName" HeaderText="Chức danh">
                                                <ItemStyle HorizontalAlign="Left"></ItemStyle>

                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                </asp:BoundField>--%>
                                                <asp:BoundField DataField="Type" SortExpression="Type" HeaderText="Loại">
                                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                </asp:BoundField>
                                                <asp:BoundField DataField="DepartmentFullName" SortExpression="RootId" HeaderText="Ph&#242;ng"></asp:BoundField>

                                                <asp:TemplateField SortExpression="Test/ApproachDate" HeaderText="Ngày phát hiện">
                                                <ItemStyle HorizontalAlign="Center" Width="100px"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                <ItemTemplate>
                                                <asp:Label runat="server" id="lbTestApproachDate"></asp:Label>
                                                    <asp:Label runat="server" id="lbNew" BackColor="Red" ForeColor="White" Text="New"></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField SortExpression="Place" HeaderText="Nơi phát hiện">
                                                <ItemStyle HorizontalAlign="Center" Width="100px"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                <ItemTemplate>
                                                <asp:Label runat="server" id="lbPlace"></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField SortExpression="QuarantineBeginDate" HeaderText="Bắt đầu cách ly">
                                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                <ItemTemplate>
                                                <asp:Label id="lbQuarantineBeginDate" runat="server"  __designer:wfdid="w14"></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField SortExpression="QuarantineEndDate" HeaderText="Kết thúc dự kiên">
                                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                <ItemTemplate>
                                                <asp:Label id="lbEstimatedQuarantineEndDate" runat="server"  __designer:wfdid="w14"></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField SortExpression="QuarantineEndDate" HeaderText="Kết thúc cách ly">
                                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                <ItemTemplate>
                                                <asp:Label id="lbQuarantineEndDate" runat="server"  __designer:wfdid="w14"></asp:Label>
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
                                                <asp:ObjectDataSource id="odsHistory" runat="server" OnSelecting="odsHistory_Selecting" TypeName="HRMBLL.H8.Covid19BLL" SelectMethod="GetHistory" OldValuesParameterFormatString="original_{0}" OnSelected="odsHistory_Selected"><SelectParameters>
                                                <asp:Parameter Type="Int32" Name="userId"></asp:Parameter>
                                                </SelectParameters>
                                                </asp:ObjectDataSource> 
                                                <%--</ContentTemplate>--%>
                                                <%--<Triggers>
                                                    <asp:AsyncPostBackTrigger ControlID="ddlEmployees" EventName="SelectedIndexChanged" />
                                                </Triggers>--%>
                                        <%--</asp:UpdatePanel>--%>
                                            </td>
                                        </tr>                                        
                                    </table>
                            </fieldset> 
        
<uc3:ucPermission ID="UcPermission1" runat="server" />
</asp:Content>

