<%@ Control Language="C#" AutoEventWireup="true" CodeFile="YearEnd.ascx.cs" Inherits="Bonus_Year_End" %>
<table style="width: 100%">
    <tr>
        <td>
            <asp:Panel ID="pnTet2006" runat="server" >            
            <table style="width: 100%">
                <tr>
                    <td>
                    <table class="tableBorder" width="100%">
                        <tr>
                            <td>  
                                <asp:GridView ID="grdYearEnd" runat="server" AutoGenerateColumns="False" DataSourceID="odsYearEnd" Width="100%" CssClass="grid-Border" OnRowDataBound="grdYearEnd_RowDataBound">
                                    <Columns>
                                <asp:TemplateField HeaderText="M&#244; tả" SortExpression="Description">                                                    
                                    <ItemTemplate>
                                        <asp:Label ID="lbName" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Số tiền ( VND )" SortExpression="BonusValue">                                                   
                                    <ItemStyle HorizontalAlign="Right" />
                                    <HeaderStyle HorizontalAlign="Right" />
                                    <ItemTemplate>
                                        <asp:Label ID="lbMoney" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <EmptyDataTemplate>
                                <asp:Label ID="Label1" runat="server" CssClass="value" Text="Chưa có thông tin về tiền thưởng"></asp:Label>
                            </EmptyDataTemplate>
                             <HeaderStyle CssClass="grid-header" /> 
                            <RowStyle CssClass ="grid-item" />
                            <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                            <PagerStyle CssClass="grid-paper" />                           
                                </asp:GridView>
                                <asp:ObjectDataSource ID="odsYearEnd" runat="server" OnSelecting="odsYearEnd_Selecting"
                                    SelectMethod="GetAll" TypeName="HRMBLL.H.BonusValuesBLL" OldValuesParameterFormatString="original_{0}">
                                    <SelectParameters>
                                        <asp:Parameter Name="userId" Type="Int32" />
                                        <asp:Parameter Name="year" Type="Int32" />
                                        <asp:Parameter Name="type" Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                              </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <%--<tr>
                    <td style="height: 20px">
                    </td>
                </tr>
                <tr>
                    <td align="center">
                    
                        <asp:Panel ID="Panel1" runat="server">
                         <table style="width: 100%; background-color: #66cdaa" >
                            <tr>
                                <td align="center">
                                    <span style="font-size: 10pt; color: #000000"><strong>Số tiền thực lĩnh (I+II) - (III
                                        + IV) : </strong></span>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:Label ID="lbRealBonus" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="Black"></asp:Label></td>
                            </tr>
                        </table>
                        </asp:Panel>
                       
                    </td>
                </tr>--%>
            </table>
            </asp:Panel>
            
            <%--
                <table style="width: 100%">
                <asp:Panel ID="pnTet2007" runat="server" Visible="true">
                    <tr>
                        <td style="text-align: center">
                            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="Green"
                                Text="Tiền Bổ Sung Lương, An Toàn Hàng Không (tháng 7 đến tháng 12 năm 2010), Tết Âm Lịch 2011"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>
                            <table class="tableBorder" width="100%">
                            <tr>
                                <td>  
                                    <asp:GridView ID="grdViewLastYearBonus2007" runat="server" AutoGenerateColumns="False" DataSourceID="odsLastYearBonus2007" CssClass="grid-Border" Width="100%" OnRowDataBound="grdViewLastYearBonus2007_RowDataBound">
                                            <Columns>
                                                <asp:TemplateField HeaderText="M&#244; tả" SortExpression="Description">                                                    
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbName" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        Tổng Cộng
                                                    </FooterTemplate>
                                                    <ItemStyle HorizontalAlign="Left" Width="70%"/>
                                                    <FooterStyle HorizontalAlign="Left" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Số tiền ( VND )" SortExpression="BonusValue">                                                   
                                                    <ItemStyle HorizontalAlign="Right" Width="30%"/>
                                                    <FooterStyle HorizontalAlign="Right" />
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbMoney" runat="server"></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:Label ID="lbTotalMoney" runat="server"></asp:Label>
                                                        
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                
                                            </Columns>
                                            <EmptyDataTemplate>
                                                <asp:Label ID="Label1" runat="server" CssClass="value" Text="Chưa có thông tin về tiền thưởng"></asp:Label>
                                            </EmptyDataTemplate>
                                             <HeaderStyle CssClass="grid-header" /> 
                                            <RowStyle CssClass ="grid-item" />
                                            <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                            <PagerStyle CssClass="grid-paper" />   
                                            <FooterStyle CssClass="grid-footer"></FooterStyle>
                                        </asp:GridView>
                                        <asp:ObjectDataSource ID="odsLastYearBonus2007" runat="server" OnSelecting="odsLastYearBonus2007_Selecting"
                                            SelectMethod="GetByYearBonusNameIdsUserId" TypeName="HRMBLL.H.BonusValuesBLL" OldValuesParameterFormatString="original_{0}" OnSelected="odsLastYearBonus2007_Selected">
                                            <SelectParameters>
                                                <asp:Parameter Name="year" Type="Int32" />
                                                <asp:Parameter Name="bonusNameIds" Type="String" />
                                                <asp:Parameter Name="userId" Type="Int32" />
                                            </SelectParameters>
                                        </asp:ObjectDataSource>
                                </td>
                            </tr>
                      
                        </table>
                        </td>
                    </tr>
                    </asp:Panel>
                <asp:Panel ID="Panel2" runat="server" Visible="false">
                    <tr>
                        <td align="center">
                            <asp:Label ID="lbChenhLech" runat="server" Font-Size="Larger" ForeColor="Green" Text="Tiền Thưởng Tết Âm Lịch - Bổ Sung Lương - An Toàn Hàng Không Đợt II, Tiền Thưởng Năm 2009" Font-Bold="True" Visible="False"></asp:Label></td>
                    </tr>
                    
                    <tr>
                        <td>
                            
                            <table class="tableBorder" width="100%">
                                <tr>
                                    <td>  
                        <asp:GridView ID="grdChenhLech" runat="server" AutoGenerateColumns="False" DataSourceID="odsChenhLech" CssClass="grid-Border" Width="100%" OnRowDataBound="grdChenhLech_RowDataBound" Visible="False">
                            <Columns>
                                <asp:TemplateField HeaderText="M&#244; tả" SortExpression="Description">
                                    <ItemTemplate>
                                        <asp:Label ID="lbName" runat="server"></asp:Label>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        Tổng Cộng
                                    </FooterTemplate>
                                    <ItemStyle HorizontalAlign="Left" Width="70%"/>
                                    <FooterStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Số tiền ( VND )" SortExpression="BonusValue">
                                    <ItemStyle HorizontalAlign="Right" Width="30%"/>
                                    <FooterStyle HorizontalAlign="Right" />
                                    <ItemTemplate>
                                        <asp:Label ID="lbMoney" runat="server"></asp:Label>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        <asp:Label ID="lbTotalMoney" runat="server"></asp:Label>
                                    </FooterTemplate>
                                </asp:TemplateField>
                            </Columns>
                            
                            <HeaderStyle CssClass="grid-header" />
                            <RowStyle CssClass ="grid-item" />
                            <AlternatingRowStyle CssClass="grid-atlternating-item" />
                            <PagerStyle CssClass="grid-paper" />
                            <FooterStyle CssClass="grid-footer" />
                        </asp:GridView>
                            <asp:ObjectDataSource ID="odsChenhLech" runat="server" OnSelecting="odsChenhLech_Selecting" SelectMethod="GetByYearBonusNameIdsUserId" TypeName="HRMBLL.H.BonusValuesBLL" OnSelected="odsChenhLech_Selected" OldValuesParameterFormatString="original_{0}">
                                <SelectParameters>
                                    <asp:Parameter Name="year" Type="Int32" />
                                    <asp:Parameter Name="bonusNameIds" Type="String" />
                                    <asp:Parameter Name="userId" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                                    </td>
                                </tr>                          
                            </table>
                            
                        </td>
                    </tr>
                    </asp:Panel>
                <asp:Panel ID="Panel3" runat="server" Visible="false">
                     <tr>
                        <td align="center">
                            <asp:Label ID="Label3" runat="server" Font-Size="Larger" ForeColor="Green" Text="Tiền Bổ Sung Điều Tiết Lương Đợt III Năm 2009" Font-Bold="True" Visible="False"></asp:Label></td>
                    </tr>
                    
                    <tr>
                        <td>
                            
                            <table class="tableBorder" width="100%">
                                <tr>
                                    <td>  
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CssClass="grid-Border" Width="100%" OnRowDataBound="GridView1_RowDataBound" Visible="False">
                            <Columns>
                                <asp:TemplateField HeaderText="M&#244; tả" SortExpression="Description">
                                    <ItemTemplate>
                                        <asp:Label ID="lbName" runat="server"></asp:Label>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        Tổng Cộng
                                    </FooterTemplate>
                                    <ItemStyle HorizontalAlign="Left" Width="70%"/>
                                    <FooterStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Số tiền ( VND )" SortExpression="BonusValue">
                                    <ItemStyle HorizontalAlign="Right" Width="30%"/>
                                    <FooterStyle HorizontalAlign="Right" />
                                    <ItemTemplate>
                                        <asp:Label ID="lbMoney" runat="server"></asp:Label>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        <asp:Label ID="lbTotalMoney" runat="server"></asp:Label>
                                    </FooterTemplate>
                                </asp:TemplateField>
                            </Columns>
                            
                            <HeaderStyle CssClass="grid-header" />
                            <RowStyle CssClass ="grid-item" />
                            <AlternatingRowStyle CssClass="grid-atlternating-item" />
                            <PagerStyle CssClass="grid-paper" />
                            <FooterStyle CssClass="grid-footer" />
                        </asp:GridView>
                            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting" SelectMethod="GetByYearBonusNameIdsUserId" TypeName="HRMBLL.H.BonusValuesBLL" OnSelected="ObjectDataSource1_Selected" OldValuesParameterFormatString="original_{0}">
                                <SelectParameters>
                                    <asp:Parameter Name="year" Type="Int32" />
                                    <asp:Parameter Name="bonusNameIds" Type="String" />
                                    <asp:Parameter Name="userId" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                                    </td>
                                </tr>                          
                            </table>
                            
                        </td>
                    </tr>
                     </asp:Panel>
                </table>
                --%>
            
        </td>
    </tr>
</table>
