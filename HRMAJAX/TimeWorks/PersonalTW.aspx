<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="PersonalTW.aspx.cs" Inherits="TimeWorks_PersonalTW" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucDateFilter.ascx" TagName="ucDateFilter" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/Title.ascx" TagName="Title" TagPrefix="uc1" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table style="width: 100%; height:500px" cellpadding="5" cellspacing="0" class="tableBackground">
    <tr>
        <td valign="top" style="height:45px">
             <table width="100%" class="tableBgBoxShare">
                <tr>
                    <td align="left">
                        <uc2:ucTitle ID="UcTitle1" runat="server" />
                    </td>
                </tr>
             </table>           
        </td>
    </tr>
    <tr>
        <td valign="top" style="height:95px">
           <table width="100%" class="tableBgBoxShare">
            <tr>                       
                <td valign="top" align="center">
                    <table style="width: 100%" cellpadding="0" cellspacing="0">                                
                        <tr>
                            <td align="center" colspan="4" style="height: 5px">
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="4">
                                <table cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td valign="middle">
                                            <asp:Label ID="Label4" runat="server" CssClass="label" Text="Tháng"></asp:Label>
                                            <asp:DropDownList ID="ddlMonths" runat="server" CssClass="dropDownList">
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
                                            &nbsp; &nbsp;<asp:Label ID="Label6" runat="server" CssClass="label" Text="Năm"></asp:Label>
                                            <asp:DropDownList ID="ddlYears" runat="server" CssClass="dropDownList">
                                            </asp:DropDownList>
                                        </td>
                                        <td valign="top">
                                            <table>
                                                <tr>
                                                    <td>
                                                        &nbsp;&nbsp;
                                                        <asp:Button ID="imgSearch" runat="server" Text="Xem" CssClass="small color green button"
                                                            OnClick="btnView_Click" />
                                                        &nbsp; &nbsp;</td>
                                                    <td>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                                </td>
                        </tr>
                        <tr>
                            <td align="right" style="height:5px">
                            </td>
                            <td align="left">
                            </td>
                            <td align="right">
                            </td>
                            <td align="left">
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="4">
                                <table width="99%" class="tableBorder" style="background-color:White">
                                    <tr>
                                        <td align="right" class="tdLabel" style="width:20%">
                                            <asp:Label ID="Label3" runat="server" CssClass="label" Text="Họ và tên"></asp:Label></td>
                                        <td align="left" class="tdValue">
                                        <asp:Label ID="lbFullname" runat="server" CssClass="value"></asp:Label>
                                            </td>
                                        <td align="right" class="tdLabel" style="width:20%">
                                            &nbsp;<asp:Label ID="Label2" runat="server" CssClass="label" Text="Chức danh công việc"></asp:Label>
                                        </td>
                                        <td align="left" class="tdValue">
                                            &nbsp;<asp:Label ID="lbPosition" runat="server" CssClass="value"></asp:Label></td>
                                    </tr>
                                     <tr>
                                        <td align="right" class="tdLabel">
                                            <asp:Label ID="Label7" runat="server" CssClass="label" Text="Phòng"></asp:Label></td>
                                        <td align="left" colspan="3" class="tdValue">
                                        <asp:Label ID="lbDepartment" runat="server" CssClass="value"></asp:Label>
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        
                        <tr>
                            <td align="right" style="height:5px">
                            </td>
                            <td align="left">
                            </td>
                            <td align="right">
                            </td>
                            <td align="left">
                            </td>
                        </tr>                                                                                
                        <%--<tr>
                            <td align="center" colspan="4" style="height: 5px">
                                 <table width="99%" class="tableBorder" style="background-color:White">
                                    <tr>
                                        <td>
                                <asp:GridView ID="grdEmployeeTimeBill2Days" runat="server" AutoGenerateColumns="False"
                                    Width="100%" CssClass="grid-Border" OnRowDataBound="grdEmployeeTimeBill2Days_RowDataBound" Visible="False">
                                    <FooterStyle CssClass="grid-footer" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="Ng&#224;y l&#224;m việc" SortExpression="Description">
                                            <ItemStyle HorizontalAlign="Center" Width="20%" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbWorkdate" runat="server" CssClass="labelNormHTCV"></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Chi tiết thời gian ra v&#224;o" SortExpression="FileCode">
                                            <FooterTemplate>
                                                TỔNG CỘNG
                                            </FooterTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:GridView ID="grdEmployeeTimeBillDetail2days" Width="100%" CssClass="grid-Border" runat="server" AutoGenerateColumns="False" OnRowDataBound="grdEmployeeTimeBillDetail2days_RowDataBound">
                                                    <Columns>
                                                        <asp:TemplateField HeaderText="Giờ v&#224;o">
                                                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                                                            <HeaderStyle HorizontalAlign="Center" Height="25px"/>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbTimeIn" runat="server"></asp:Label>
                                                            </ItemTemplate>
                                                            <HeaderTemplate>
                                                                <table cellpadding="0" cellspacing="0">
                                                                    <tr>
                                                                        <td>
                                                                            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/arrowin.gif" />
                                                                        </td>
                                                                        <td>
                                                                            Giờ vào
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </HeaderTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Giờ ra">
                                                            <HeaderTemplate>
                                                                <table cellpadding="0" cellspacing="0">
                                                                    <tr>
                                                                        <td>
                                                                            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/arrowout.gif" />
                                                                        </td>
                                                                        <td>
                                                                            Giờ ra
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </HeaderTemplate>
                                                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbTimeOut" runat="server"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Tổng thời gian (giờ)">
                                                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbTotalTime" runat="server"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                    </Columns>
                                                    <HeaderStyle CssClass="grid-detail-header" />
                                                    <RowStyle CssClass="grid-detail-item" />
                                                    <AlternatingRowStyle CssClass="grid-detail-atlternating-item" />
                                                </asp:GridView>
                                            </ItemTemplate>
                                            <FooterStyle HorizontalAlign="Right" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Tổng cộng(giờ)">
                                            <FooterTemplate>
                                                <asp:Label ID="lbTotalByMonth" runat="server"></asp:Label>
                                            </FooterTemplate>
                                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbTotalByDate" runat="server"></asp:Label>
                                            </ItemTemplate>
                                            <FooterStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                         <asp:TemplateField HeaderText="Tổng thời gian thực tế (giờ)">
                                             <ItemStyle HorizontalAlign="Center" Width="10%" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbTotalRealTime" runat="server"></asp:Label>
                                            </ItemTemplate>
                                             <FooterStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                    </Columns>
                                    <RowStyle CssClass ="grid-item" />
                                    <PagerStyle CssClass="grid-paper" />
                                    <HeaderStyle CssClass="grid-header" />
                                    <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                </asp:GridView>
                                        </td>
                                    </tr>
                                 </table>   
                            </td>
                        </tr>--%>
                        <tr>
                            <td align="right" style="height: 5px">
                            </td>
                            <td align="left">
                            </td>
                            <td align="right">
                            </td>
                            <td align="left">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
           </table>
        </td>
    </tr>
    <tr>
        <td valign="top" style="height:350px">                            
             <table width="100%" class="tableBgBoxShare" style="height:345px">
                <tr>
                   <td align="right" style="height:5px">
                   </td>
                </tr>
                <tr>
                    <td align="center" valign="top">
                      <table class="tableBorder" width="99%">
                        <tr>
                            <td>   
                                <asp:GridView ID="grdEmployeeTimeBill" runat="server" AutoGenerateColumns="False"
                                    Width="100%" CssClass="grid-Border" OnRowDataBound="grdEmployeeTimeBill_RowDataBound" ShowFooter="True">
                                    <Columns>
                                        <asp:TemplateField HeaderText="STT" >
                                            <ItemStyle HorizontalAlign="Center" Width="2%" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbSTT" runat="server" CssClass="labelNormHTCV"></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Ng&#224;y l&#224;m việc" SortExpression="Description">
                                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <%--<asp:Label ID="lbWorkdate" runat="server" CssClass="labelNormHTCV"></asp:Label>--%>
                                                <asp:HyperLink ID="lnkWorkDate" runat="server" CssClass="labelNormHTCV"></asp:HyperLink>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Chi tiết thời gian ra v&#224;o" SortExpression="FileCode">
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:GridView ID="grdEmployeeTimeBillDetail" Width="100%" CssClass="grid-Border" runat="server" AutoGenerateColumns="False" OnRowDataBound="grdEmployeeTimeBillDetail_RowDataBound">
                                                    <Columns>
                                                        <asp:TemplateField HeaderText="Giờ v&#224;o">
                                                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                                                            <HeaderStyle HorizontalAlign="Center" Height="25px"/>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbTimeIn" runat="server"></asp:Label>
                                                            </ItemTemplate>                                                            
                                                            <HeaderTemplate>                                                                
                                                                <table cellpadding="0" cellspacing="0">
                                                                    <tr>
                                                                        <td>
                                                                            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/arrowin.gif" />
                                                                        </td>
                                                                        <td>
                                                                            Giờ vào
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </HeaderTemplate>
                                                        </asp:TemplateField>
                                                         <asp:TemplateField HeaderText="Giờ ra">
                                                          <HeaderTemplate>                                                                
                                                                <table cellpadding="0" cellspacing="0">
                                                                    <tr>
                                                                        <td>
                                                                            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/arrowout.gif" />
                                                                        </td>
                                                                        <td>
                                                                            Giờ ra
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </HeaderTemplate>
                                                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbTimeOut" runat="server"></asp:Label>
                                                            </ItemTemplate>                                                            
                                                        </asp:TemplateField>
                                                         <asp:TemplateField HeaderText="Tổng thời gian (giờ)">
                                                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbTotalTime" runat="server"></asp:Label>
                                                            </ItemTemplate>                                                            
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Làm đêm (giờ)">
                                                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbNightTime" runat="server"></asp:Label>
                                                            </ItemTemplate>                                                            
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Công">
                                                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <ItemTemplate>
                                                                <asp:Label ID="lbOverTime" runat="server"></asp:Label>
                                                            </ItemTemplate>                                                            
                                                        </asp:TemplateField>
                                                        
                                                    </Columns>
                                                    <HeaderStyle CssClass="grid-detail-header" Height="25px"/>
                                                    <RowStyle CssClass="grid-detail-item" />
                                                    <AlternatingRowStyle CssClass="grid-detail-atlternating-item" />                                                    
                                                </asp:GridView>
                                            </ItemTemplate>
                                            <FooterTemplate>
                                                TỔNG CỘNG
                                            </FooterTemplate>
                                             <FooterStyle HorizontalAlign="Right" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Tổng cộng(giờ)">
                                            <ItemStyle HorizontalAlign="Center" Width="8%" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbTotalByDate" runat="server"></asp:Label>
                                            </ItemTemplate>
                                            <FooterTemplate>
                                                <asp:Label ID="lbTotalByMonth" runat="server" ></asp:Label>
                                            </FooterTemplate>
                                            <FooterStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Làm đêm(giờ)">
                                            <ItemStyle HorizontalAlign="Center" Width="8%" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbTotalNightTimeByDate" runat="server"></asp:Label>
                                            </ItemTemplate>
                                            <FooterTemplate>
                                                <asp:Label ID="lbTotalNightTimeByMonth" runat="server" ></asp:Label>
                                            </FooterTemplate>
                                            <FooterStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Làm ngày(giờ)">
                                            <ItemStyle HorizontalAlign="Center" Width="8%" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbTotalDayTimeByDate" runat="server"></asp:Label>
                                            </ItemTemplate>
                                            <FooterTemplate>
                                                <asp:Label ID="lbTotalDayTimeByMonth" runat="server" ></asp:Label>
                                            </FooterTemplate>
                                            <FooterStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                         <asp:TemplateField HeaderText="Tổng thời gian thực tế (giờ)">
                                             <ItemStyle HorizontalAlign="Center" Width="8%" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbTotalRealTime" runat="server"></asp:Label>
                                            </ItemTemplate>
                                             <FooterStyle HorizontalAlign="Center" />
                                             <FooterTemplate>
                                                 <asp:Label ID="lbTotalRealByMonth" runat="server"></asp:Label>
                                             </FooterTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Quy ra c&#244;ng">
                                            <ItemStyle HorizontalAlign="Center" Width="8%" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbX" runat="server"></asp:Label>
                                            </ItemTemplate>
                                             <FooterStyle HorizontalAlign="Center" />
                                             <FooterTemplate>
                                                 <asp:Label ID="lbTotalX" runat="server"></asp:Label>
                                             </FooterTemplate>
                                        </asp:TemplateField>
                                    </Columns>                                                                                                                  
                                    <FooterStyle CssClass="grid-footer" /> 
                                    <HeaderStyle CssClass="grid-header" Height="25px"/>
                                    <RowStyle CssClass="grid-item" />
                                    <AlternatingRowStyle CssClass="grid-atlternating-item" />     
                                    <PagerStyle CssClass="grid-paper" />                                                
                                </asp:GridView>                                
                            </td>
                        </tr>
                      </table>                        
                    </td>
                </tr>
                <tr>
                   <td align="center"><asp:Button ID="btnCancel" runat="server" CssClass="small color green button" OnClick="btnCancel_Click"
                                                Text="Thoát" Width="100px" /></td>
                </tr>
             </table> 
        </td>
    </tr>
</table>
</asp:Content>

