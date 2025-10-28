<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Ele.ascx.cs" Inherits="Employee_UserControls_Ele" %>
<table cellpadding="0" cellspacing="0" style="width: 100%;" class="LeftMenu">    
    <tr>
        <td class="LeftMenu" valign="top">
            <table cellpadding="0" cellspacing="0" style="width: 100%;">    
                <tr>
                    <td align="center" style="height:25px">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/leftmenuline.jpg"></asp:Image></td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Label ID="lbTitleFilter" runat="server" CssClass="LeftMenuTitle"></asp:Label></td>
                </tr>
                <tr>
                    <td align="center" style="height:25px">
                        <asp:Image ID="imgLeftMenuLine" runat="server" ImageUrl="~/Images/leftmenuline.jpg"></asp:Image></td>
                </tr>
                <tr>
                    <td align="center">
                        <table cellpadding="0" cellspacing="0" >
                             <tr>
                                <td>                       
                                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label><br />
                                    <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox" Width="100px"></asp:TextBox>
                                    <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="Xem"  CssClass="small color green button" /></td>
                            </tr>                           
                            <tr>
                                <td align="center">
                                    <div class="scrollcontent250">
                                    <asp:GridView ID="grdEmployeesList" runat="server" AllowSorting="True"
                                        AutoGenerateColumns="False" CssClass="grid-Border" OnRowDataBound="grdEmployeesList_RowDataBound" OnSorting="grdEmployeesList_Sorting" PageSize="1" Width="100%" OnSelectedIndexChanged="grdEmployeesList_SelectedIndexChanged">
                                        <PagerSettings PageButtonCount="30" />
                                        <RowStyle CssClass="grid-item" />
                                        <Columns>
                                            <asp:TemplateField HeaderText="M&#227; NV" SortExpression="UserId">
                                                <ItemTemplate>
                                                    <asp:Label ID="lbUserId" runat="server"></asp:Label>
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left" />
                                                <ItemStyle HorizontalAlign="Left" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Họ v&#224; t&#234;n" SortExpression="FullName">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lnkFullName" runat="server" CssClass="hyperlink-Grid" CommandName="Select" >[lnkFullName]</asp:LinkButton>
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left" />
                                                <ItemStyle HorizontalAlign="Left" />
                                            </asp:TemplateField>
                                        </Columns>
                                        <PagerStyle CssClass="grid-paper" />
                                        <HeaderStyle CssClass="grid-header" />
                                        <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                    </asp:GridView>
                                    </div>                                    
                                </td>
                            </tr>
                        </table>
                        
                    </td>    
                </tr>
               
            </table>
        </td>
    </tr>
</table>