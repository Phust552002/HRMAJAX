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
                                        Width="100%" CssClass="grid-Border">
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
                                    <asp:ObjectDataSource ID="odsIncomesMonth" runat="server" 
                                        OnSelecting="odsIncomesMonth_Selecting" SelectMethod="GetAllByUserId_Monthly_By_All" 
                                        TypeName="HRMBLL.H.IncomesMonthBLL">
                                        <SelectParameters>
                                            <asp:Parameter Name="userId" Type="Int32" />
                                            <asp:Parameter Name="month" Type="Int32" />
                                            <asp:Parameter Name="year" Type="Int32" />
                                        </SelectParameters>
                                    </asp:ObjectDataSource>
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
                                <asp:GridView ID="grdContributions" runat="server" AutoGenerateColumns="False" DataSourceID="odsContributions" Width="100%" CssClass="grid-Border">
                                    <Columns>
                                            <asp:BoundField DataField="Description" HeaderText="Các Khoản Phải Nộp" SortExpression="Description">
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
                                    <FooterStyle CssClass="grid-footer" />
                                </asp:GridView>
                                <asp:ObjectDataSource ID="odsContributions" runat="server" OnSelecting="odsContributions_Selecting"
                                    SelectMethod="GetAllByUserId_Paid_Monthly_By_All" 
                                    TypeName="HRMBLL.H.IncomesMonthBLL">
                                    <SelectParameters>
                                        <asp:Parameter Name="userId" Type="Int32" />
                                        <asp:Parameter Name="month" Type="Int32" />
                                        <asp:Parameter Name="year" Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </td>
                          </tr>
                      </table>
                    </td>
                </tr>
                <tr class="grid-footer">
                    <td style="width:60%">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                            Font-Size="10px" Text="Tổng Cộng ( II )"></asp:Label></td>
                    <td align="right">
                        <asp:Label ID="lbTotalII" runat="server" Font-Bold="False" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                            Font-Size="10px"></asp:Label>&nbsp;</td>
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