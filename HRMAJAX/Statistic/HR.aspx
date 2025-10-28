<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="HR.aspx.cs" Inherits="Statistic_HR" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc1" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table style="width: 100%">
    <tr>
        <td>
            <uc3:ucTitle ID="UcTitle1" runat="server" />            
        </td>
    </tr>                    
    <tr>
        <td>
            <table style="width: 100%">
                <tr>
                    <td style="width:10%" align="left">                                                                       
                        <uc2:ActionMenu ID="ActionMenu1" runat="server" />
                    </td>
                    <td style="width:80%" align="right">
                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Từ ngày"></asp:Label>&nbsp;<uc1:CalendarPicker ID="cpFromDateA" runat="server" />
                        &nbsp;
                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Đến ngày"></asp:Label>&nbsp;<uc1:CalendarPicker ID="cpToDateA" runat="server" />
                        <asp:Label ID="Label6" runat="server" CssClass="label" Text="(A)"></asp:Label>
                        &nbsp;
                        &nbsp; &nbsp;
                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="So Sánh Với"></asp:Label>
                        &nbsp;
                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Từ ngày"></asp:Label>&nbsp;<uc1:CalendarPicker ID="cpFromDateB" runat="server" />
                        &nbsp;&nbsp;
                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Đến ngày"></asp:Label>&nbsp;<uc1:CalendarPicker ID="cpToDateB" runat="server" />
                        <asp:Label ID="Label7" runat="server" CssClass="label" Text="(B)"></asp:Label>
                    </td>
                    <td align="left">
                        &nbsp;&nbsp;
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Icon-Search.gif" /></td>
                </tr>
            </table>
            
        </td>
    </tr>
    <tr>
        <td>
             <table style="WIDTH: 100%" class="tableBorder">
                        <tr>
                            <td>
                              <asp:GridView ID="GridView1" runat="server" Width="100%" CssClass="grid-Border" OnRowDataBound="GridView1_RowDataBound" ShowFooter="True" AutoGenerateColumns="False">
                                <RowStyle CssClass="grid-item"></RowStyle>
                                <PagerStyle CssClass="grid-paper"></PagerStyle>
                                <HeaderStyle CssClass="grid-header"></HeaderStyle>
                                <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                                <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                <FooterStyle CssClass="grid-footer"></FooterStyle>
                                  <Columns>
                                      <asp:TemplateField HeaderText="STT">
                                          <ItemTemplate>
                                              <asp:Label ID="lbSTT" runat="server" Text=""></asp:Label>
                                          </ItemTemplate>
                                      </asp:TemplateField>
                                      <asp:TemplateField HeaderText="CHỨC DANH">
                                         <ItemTemplate>
                                              <asp:Label ID="lbPosition" runat="server" Text=""></asp:Label>
                                          </ItemTemplate>
                                          <FooterTemplate>
                                              SAGS
                                          </FooterTemplate>
                                          <ItemStyle HorizontalAlign="Left" />
                                      </asp:TemplateField>
                                      <asp:TemplateField HeaderText="Tổng A">
                                         <ItemTemplate>
                                              <asp:Label ID="lbTotalA" runat="server" Text=""></asp:Label>
                                          </ItemTemplate>
                                          <ItemStyle HorizontalAlign="Right" />
                                          <FooterTemplate>
                                              <asp:Label ID="lbSAGSTotalA" runat="server"></asp:Label>
                                          </FooterTemplate>
                                      </asp:TemplateField>
                                       <asp:TemplateField HeaderText="Tổng B">
                                         <ItemTemplate>
                                              <asp:Label ID="lbTotalB" runat="server" Text=""></asp:Label>
                                          </ItemTemplate>
                                           <ItemStyle HorizontalAlign="Right" />
                                           <FooterTemplate>
                                               <asp:Label ID="lbSAGSTotalB" runat="server"></asp:Label>
                                           </FooterTemplate>
                                      </asp:TemplateField>
                                      <asp:TemplateField HeaderText="SO VỚI C&#217;NG KỲ TH&#193;MG TRƯỚC">
                                         <ItemTemplate>
                                              <asp:Label ID="lbResult" runat="server" Text=""></asp:Label>
                                          </ItemTemplate>
                                          <FooterTemplate>
                                              <asp:Label ID="lbSAGSResult" runat="server"></asp:Label>
                                          </FooterTemplate>
                                      </asp:TemplateField>
                                  </Columns>
                              </asp:GridView>
                            </td>
                        </tr>
               </table>
         </td>
    </tr>               
 </table>    
</asp:Content>

