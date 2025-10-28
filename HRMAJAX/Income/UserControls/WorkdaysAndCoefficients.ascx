<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WorkdaysAndCoefficients.ascx.cs" Inherits="Income_UserControls_WorkdaysAndCoefficients" %>

<table style="width: 100%">    
    <tr>
        <td valign="top">
        <table class="tableBorder" width="90%">
            <tr>
                <td>  
                    <asp:GridView ID="grdWorkdays" runat="server" AutoGenerateColumns="False" DataSourceID="odsWorkdays" Width="100%" CssClass="grid-Border">
                        <Columns>
                            <asp:BoundField DataField="Description" HeaderText="Ng&#224;y c&#244;ng" SortExpression="Description">
                            </asp:BoundField>
                            <asp:BoundField DataField="Value" HeaderText="Số Ng&#224;y" SortExpression="Value">
                            </asp:BoundField>
                        </Columns>                                   
                        <HeaderStyle CssClass="grid-header" /> 
                        <RowStyle CssClass ="grid-item" />
                        <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                        <PagerStyle CssClass="grid-paper" />    
                    </asp:GridView>
                    <asp:ObjectDataSource ID="odsWorkdays" runat="server" OnSelecting="odsWorkdays_Selecting"
                        SelectMethod="GetWorkday" 
                        TypeName="HRMBLL.H1.WorkdayCoefficientEmployeesFinalBLL" 
                        OldValuesParameterFormatString="original_{0}">
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
        <td valign="top">
         <table class="tableBorder" width="90%">
            <tr>
                <td>  
                 <asp:GridView ID="grdCoefficients" runat="server" AutoGenerateColumns="False" DataSourceID="odsCoefficients" CssClass="grid-Border" Width="100%">
                    <Columns>
                        <asp:BoundField DataField="Description" HeaderText="Hệ số" SortExpression="Description" >
                        </asp:BoundField>
                        <asp:BoundField DataField="Value" HeaderText="Gi&#225; Trị" SortExpression="Value">
                        </asp:BoundField>
                    </Columns>                    
                     <HeaderStyle CssClass="grid-header" /> 
                    <RowStyle CssClass ="grid-item" />
                    <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                    <PagerStyle CssClass="grid-paper" />  
                </asp:GridView>
                <asp:ObjectDataSource ID="odsCoefficients" runat="server" OnSelecting="odsCoefficients_Selecting"
                    SelectMethod="GetCoefficient" 
                        TypeName="HRMBLL.H1.WorkdayCoefficientEmployeesFinalBLL" 
                        OldValuesParameterFormatString="original_{0}">
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
    <tr>
        <td valign="top">
         <table class="tableBorder" width="90%">
            <tr>
                <td>  
            <asp:GridView ID="grdTimeKeeping" runat="server" AutoGenerateColumns="False" DataSourceID="odsTimeKeepings" Width="100%" CssClass="grid-Border">
                <Columns>
                    <asp:BoundField DataField="Description" HeaderText="Giờ C&#244;ng" SortExpression="Description">
                    </asp:BoundField>
                    <asp:BoundField DataField="Value" HeaderText="Số Giờ" SortExpression="Value">
                    </asp:BoundField>
                </Columns>
                
                <HeaderStyle CssClass="grid-header" /> 
                <RowStyle CssClass ="grid-item" />
                <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                <PagerStyle CssClass="grid-paper" />  
            </asp:GridView>
            <asp:ObjectDataSource ID="odsTimeKeepings" runat="server" OnSelecting="odsTimeKeepings_Selecting"
                SelectMethod="GetWorktime" 
                        TypeName="HRMBLL.H1.WorkdayCoefficientEmployeesFinalBLL" 
                        OldValuesParameterFormatString="original_{0}">
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
        <td valign="top">
             <table class="tableBorder" width="90%">
                <tr>
                    <td> 
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="100%" CssClass="grid-Border">
            <Columns>
                <asp:BoundField DataField="Description" HeaderText="Giảm trừ c&#225; nh&#226;n" SortExpression="Description" />
                <asp:BoundField DataField="Value" HeaderText="Gi&#225; trị" SortExpression="Value" />
            </Columns>
            <RowStyle CssClass ="grid-item" />
            <PagerStyle CssClass="grid-paper" />
            <HeaderStyle CssClass="grid-header" />
            <AlternatingRowStyle CssClass="grid-atlternating-item" />
        </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting"
                SelectMethod="GetPIT" TypeName="HRMBLL.H1.WorkdayCoefficientEmployeesFinalBLL" 
                            OldValuesParameterFormatString="original_{0}">
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
    <tr>
        <td valign="top">
         <table class="tableBorder" width="90%">
             <tr class="grid-footer">
                 <td style="width:100%">
                     <table  width="100%">
                        <tr>
                            <td style="width:60%">
                                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                                    Font-Size="10px" Text="Lương theo HĐLĐ"></asp:Label></td>
                            <td align="right">
                                <asp:Label ID="lbLuongTheoHDLD" runat="server" Font-Bold="False" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                                    Font-Size="10px"></asp:Label>&nbsp;</td>
                            </tr>
                     </table>
                     </td>
                </tr>   
             </table>
            </td>
    </tr>
</table>
