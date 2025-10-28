<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ManagerList.aspx.cs" Inherits="Holiday_ManagerList" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register src="../Administrator/UserControls/ucPermission.ascx" tagname="ucPermission" tagprefix="uc2" %>
<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%" class="bgEachPage">
    <tr>
        <td>
            <uc1:ucTitle ID="UcTitle1" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            <table width="100%">
                <tr>
                    <td style="width:20%" align="left">                                                                       
                        <uc4:ActionMenu ID="ActionMenu1" runat="server" />
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
                                        </asp:DropDownList>&nbsp;
                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Đợt"></asp:Label>
                                        <asp:DropDownList ID="ddlTourStage" runat="server" CssClass="dropDownList" Width="200px" AppendDataBoundItems="true">
                                        <asp:ListItem Text="" Value="0"></asp:ListItem>
                                        </asp:DropDownList>
                                        &nbsp; &nbsp;&nbsp;<asp:Button ID="imgSearch" runat="server"
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
        <td>
            <asp:Panel ID="pnlManagerApproved" runat="server" Visible="false">            
            <table class="tableBorder" style="width: 100%; margin-top:2px; margin-left:2px; margin-bottom:2px; margin-right:2px;" >
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label5" runat="server" Text="Tên CBNV" CssClass="label"></asp:Label></td>
                    <td class="tdValue"><asp:Label ID="lbFullNameSelected" runat="server" CssClass="value"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label4" runat="server" Text="Phê duyệt" CssClass="label"></asp:Label></td>
                    <td class="tdValue">
                         <asp:RadioButton ID="rdoAgree" runat="server" CssClass="value" 
                             GroupName="ManagerApproved" Text="Đồng ý" />
&nbsp;
                         <asp:RadioButton ID="rdoNotAgree" runat="server" CssClass="value" GroupName="ManagerApproved" Text="Không đồng ý" />
                         &nbsp;<asp:RadioButton ID="rdoRequire" runat="server" CssClass="value" 
                             GroupName="ManagerApproved" Text="Thông tin đăng ký sai cần điều chỉnh lại." />
                    </td>
                </tr>                
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label12" runat="server" Text="Ghi chú" CssClass="label"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtRemark" runat="server" TextMode="MultiLine" 
                            CssClass="textBox" Width="300px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" class="tdButton" align="center">
                        <asp:Button ID="btnApproved" runat="server" OnClick="btnApproved_Click" 
                            Text="Duyệt" CssClass="small color green button" Width="100px" />
                        &nbsp;
                        <asp:Button ID="btnCancel" runat="server" Text="Thoát" CssClass="small color green button" Width="100px" onclick="btnCancel_Click" />                                    
                    </td>
                </tr>
            </table>
            </asp:Panel>
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
                            <td>
                                <asp:Label ID="lbCount" runat="server" CssClass="dataList-header-label" Text=""></asp:Label>
                            </td>                                                                      
                        </tr>
                        <tr>
                            <td align="right" colspan="2">
                                <asp:GridView ID="grdHolidays" runat="server" AutoGenerateColumns="False" Width="100%" CssClass="grid-Border" onrowdatabound="grdHolidays_RowDataBound">
                                            <Columns>
                                                <asp:TemplateField HeaderText="Tên CBNV" SortExpression="FullName">                                                  
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbFullName" runat="server" Text='<%# Bind("FullName") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" Width="15%"  />
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
                                                    <ItemStyle HorizontalAlign="Left"  Width="15%" />
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
                                                    <ItemStyle HorizontalAlign="Left"  Width="10%" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Phòng" SortExpression="DepartmentFullName">                                                  
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbDepartmentFullName" runat="server" Text='<%# Bind("DepartmentFullName") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left"  Width="10%" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Trạng thái">
                                                     <ItemTemplate>
                                                        <asp:LinkButton ID="btnGridViewSelect" runat="server" Text="" CssClass="hyperlinkbutton"
                                                             onclick="btnGridViewSelect_Click"></asp:LinkButton>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" Width="6%" />
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
</table>
</asp:Content>

