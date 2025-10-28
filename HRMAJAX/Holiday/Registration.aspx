<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Holiday_Registration" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register src="../Administrator/UserControls/ucPermission.ascx" tagname="ucPermission" tagprefix="uc2" %>
<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc3" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%" class="bgEachPage">
    <tr>
        <td>
            <uc1:ucTitle ID="UcTitle1" runat="server" />
        </td>
    </tr>
        
    <tr>
        <td valign="top"><uc2:ucPermission ID="ucPermission1" runat="server" />              
            <asp:DataList ID="dlTourStage" runat="server" CellPadding="0" 
                        OnItemDataBound="dlTourStage_ItemDataBound" Width="100%">
                <ItemTemplate>
                    <table cellpadding="0" cellspacing="0" style="width: 100%">
                        <tr class="dataList-header">
                            <td align="left">
                                <asp:Label ID="lbTourStageName" runat="server" CssClass="dataList-header-label" Text=""></asp:Label>                                            
                            </td>                                                                      
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:GridView ID="grdHolidays" runat="server" AutoGenerateColumns="False" 
                                            AllowPaging="True" PageSize="20" Width="100%" CssClass="grid-Border" 
                                            onrowdatabound="grdHolidays_RowDataBound">
                                            <Columns>
                                                <asp:TemplateField HeaderText="Tên CBNV" SortExpression="FullName">                                                  
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbFullName" runat="server" Text='<%# Bind("FullName") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" Width="20%"  />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Thân nhân đi kèm" 
                                                    SortExpression="KinType">                                                    
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbKinType" runat="server" Text='<%# Bind("KinType") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" Width="6%" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Họ tên" SortExpression="KinName">                                                   
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbKinName" runat="server" Text='<%# Bind("KinName") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left"  Width="20%" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Năm sinh">
                                                     <ItemTemplate>
                                                        <asp:Label ID="lbKinBirthday" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left"  Width="5%" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Số điện thoại CBNV">
                                                     <ItemTemplate>
                                                        <asp:Label ID="lbKinPhoneNumber" runat="server" Text='<%# Bind("KinPhoneNumber") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left"  Width="6%" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="M&#244; tả" SortExpression="Remark">                                                  
                                                    <ItemTemplate>
                                                        <asp:Literal ID="ltRemark" runat="server" Text='<%# Bind("Remark") %>'></asp:Literal>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Trạng thái">
                                                     <ItemTemplate>
                                                        <asp:LinkButton ID="btnGridViewSelect" runat="server" Text="" CssClass="hyperlinkbutton"
                                                             onclick="btnGridViewSelect_Click"></asp:LinkButton>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center"  Width="6%" />
                                                </asp:TemplateField>                                    
                                                </Columns>
                                                <HeaderStyle CssClass="grid-detail-header" /> 
                                                <RowStyle CssClass ="grid-item" />
                                                <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                                <PagerStyle CssClass="grid-paper" /> 
                                            <EmptyDataTemplate>
                                                <asp:Label ID="Label3" runat="server" CssClass="value" Text="..."></asp:Label>
                                            </EmptyDataTemplate>
                                            </asp:GridView>
                                                                                    
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <AlternatingItemStyle CssClass="dataList-atlternating-item" />
                <ItemStyle CssClass="dataList-item" />
            </asp:DataList>                                 
        </td>
    </tr>
    <tr>
        <td>                
            <table class="tableBorder" style="width: 100%; margin-top:2px; margin-left:2px; margin-bottom:2px; margin-right:2px;" >
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label1" runat="server" Text="Họ tên" CssClass="label"></asp:Label></td>
                    <td class="tdValue">
                                                                        <asp:Label ID="lbFullName" 
                            runat="server" CssClass="value"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label2" runat="server" Text="Phòng" CssClass="label"></asp:Label></td>
                    <td class="tdValue">
                                                                        <asp:Label ID="lbDepartment" 
                            runat="server" CssClass="value"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Đợt"></asp:Label></td>
                    <td class="tdValue">
                        <asp:DropDownList ID="ddlTourStage" runat="server" CssClass="dropDownList" AppendDataBoundItems="true" >
                        <asp:ListItem Text="" Value="0"></asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label6" runat="server" CssClass="label" 
                            Text="Thân nhân đi kèm (Cha, mẹ, vợ, con...)"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtKinType" runat="server" CssClass="textBox" Width="50px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label7" runat="server" CssClass="label" 
                            Text="Họ tên thân nhân đi kèm"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtKinName" runat="server" CssClass="textBox" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label8" runat="server" CssClass="label" 
                            Text="Năm sinh thân nhân đi kèm"></asp:Label></td>
                    <td class="tdValue">
                        <uc3:CalendarPicker ID="cpKinBirthday" runat="server" /></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label9" runat="server" CssClass="label" Text="Điện thoại CBNV"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtKinPhoneNumber" runat="server" CssClass="textBox" 
                            Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label4" runat="server" Text="Ghi chú" CssClass="label"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtRemark" runat="server" TextMode="MultiLine" 
                            CssClass="textBox" Width="300px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" class="tdButton" align="center">
                        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Thêm mới" 
                            CssClass="small color green button" Width="100px" />
                        &nbsp;
                        <asp:Button ID="btnSend" runat="server" Text="Gửi" 
                            CssClass="small color green button" Width="100px" onclick="btnSend_Click" 
                            Visible="False" />                                    
                    &nbsp;
                        <asp:Button ID="btnDelete" runat="server" Text="Xóa" 
                            CssClass="small color green button" Width="100px" 
                            onclick="btnDelete_Click" Visible="False" OnClientClick="return confirm('Bạn có muốn xóa thông tin này không?');"/>                                    
                    &nbsp;
                        <asp:Button ID="btnClean" runat="server" Text="Làm sạch để thêm mới" 
                            CssClass="small color green button" Width="150px" onclick="btnClean_Click" 
                            Visible="False" />                                    
                    </td>
                </tr>
            </table>                    
        </td>
    </tr>
</table>
</asp:Content>

