<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Incomes.ascx.cs" Inherits="Income_UserControls_Incomes" %>
<asp:Panel ID="pnIncome" runat="server" Width="100%">
<table style="width: 100%">
    <tr>
        <td valign="top" align="left" style="width:50%">
            <table style="width: 100%" >
                <tr>
                    <td colspan="2">
                     <table class="tableBorder" width="100%">
                            <tr>
                                <td>   
                                    <asp:GridView ID="grdInocomesMonth" runat="server" AutoGenerateColumns="False" DataSourceID="odsIncomesMonth"
                                        Width="100%" CssClass="grid-Border" 
                                        onrowdatabound="grdInocomesMonth_RowDataBound">
                                        <Columns>
                                            <asp:BoundField DataField="Description" HeaderText="C&#225;c Khoản Thu Nhập" SortExpression="Description">
                                                <ItemStyle Width="60%" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="Value" HeaderText="Số Tiền (VND)" SortExpression="FileCode" DataFormatString="{0:#,###0.00}" HtmlEncode="False">
                                                <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                        </Columns>                                                                              
                                        <HeaderStyle CssClass="grid-header" /> 
                                        <RowStyle CssClass ="grid-item" />
                                        <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                        <PagerStyle CssClass="grid-paper" />                                                
                                    </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr class="grid-footer">
                    <td style="width:60%">
                        <asp:Label ID="lbTextTotalIncome" runat="server" Font-Bold="True" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                            Font-Size="10px" Text="Tổng Cộng ( I )"></asp:Label></td>
                    <td align="right">
                        <asp:Label ID="lbTotalIncome" runat="server" Font-Bold="False" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                            Font-Size="10px"></asp:Label>&nbsp;</td>
                </tr>
            </table>
        </td>
        <td align="left" style="width: 4px">
        </td>
        <td valign="top" align="left">
            <table style="width: 100%" >
                <tr>
                    <td colspan="2">
                    <table class="tableBorder" width="100%">
                        <tr>
                            <td>   
                                <asp:GridView ID="grdContributions" runat="server" AutoGenerateColumns="False" DataSourceID="odsContributions" Width="100%" CssClass="grid-Border" OnRowDataBound="grdContributions_RowDataBound" ShowFooter="True">
                                    <Columns>
                                        <asp:TemplateField HeaderText="C&#225;c Khoản Phải Nộp" SortExpression="Description">
                                           
                                            <ItemTemplate>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                                            </ItemTemplate>
                                             <FooterTemplate>
                                                <asp:Label ID="lbTitelTotal" runat="server" Text="Tổng Cộng ( II )"></asp:Label>
                                            </FooterTemplate>
                                            <ItemStyle Width="60%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Số Tiền (VND)" SortExpression="Value">
                                            
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Value", "{0:#,###0.00}") %>'></asp:Label>
                                            </ItemTemplate>
                                             <FooterTemplate>
                                                <asp:Label ID="lbSumTotal" runat="server"></asp:Label>
                                            </FooterTemplate>
                                            <ItemStyle HorizontalAlign="Right" Width="40%" />
                                            <FooterStyle HorizontalAlign="Right" />
                                        </asp:TemplateField>
                                    </Columns>                                                              
                                    <HeaderStyle CssClass="grid-header" /> 
                                    <RowStyle CssClass ="grid-item" />
                                    <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                    <PagerStyle CssClass="grid-paper" />  
                                    <FooterStyle CssClass="grid-footer" />
                                </asp:GridView>
                                <asp:ObjectDataSource ID="odsContributions" runat="server" OnSelecting="odsContributions_Selecting"
                                    SelectMethod="GetByUserId_Monthly" TypeName="HRMBLL.H.IncomesMonthBLL">
                                    <SelectParameters>
                                        <asp:Parameter Name="userId" Type="Int32" />
                                        <asp:Parameter Name="month" Type="Int32" />
                                        <asp:Parameter Name="year" Type="Int32" />
                                        <asp:Parameter Name="type" Type="Boolean" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </td>
                          </tr>
                      </table>
                    </td>
                </tr>
                <%--<tr class="grid-footer">
                    <td style="width:60%">
                        <asp:Label ID="lbTextTotalContribution" runat="server" Font-Bold="True" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                            Font-Size="11px" Text="Tổng Cộng ( II )"></asp:Label></td>
                    <td style="width:40%" align="right">
                        <asp:Label ID="lbTotalContribution" runat="server" Font-Bold="False" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                            Font-Size="10px"></asp:Label>&nbsp;</td>
                </tr>--%>
            </table>
            <table style="width: 100%; height:70px; background-color:#90bae0;">
                <tr>
                    <td align="center">
                        <asp:Label ID="lbTitleTextTotalContribution" runat="server" Font-Bold="True" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                            Font-Size="11px" Text="Thu Nhập Thực Lĩnh ( I - II )"></asp:Label></td>
                    
                </tr>
                <tr>
                    <td align="center">
                        <asp:Label ID="lbRealIncome" runat="server" Font-Bold="True" Font-Names="Verdana,Arial,Helvetica,sans-serif" Font-Size="15pt"></asp:Label></td>
                    
                </tr>
            </table>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lbNotes" runat="server" CssClass="label" Text="(*) : Đã được tính trong khoản Lương"></asp:Label>
                        <br />
                        
                        </td>
                        
                </tr>
            </table>
        </td>
    </tr>
</table>
</asp:Panel>