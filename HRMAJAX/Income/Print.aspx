<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Print.aspx.cs" Inherits="Income_Print" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title visible="false" >SAGS :: HUMAN RESOURCES MANAGEMENT</title>
    <link href="../Stylesheets/Styles.css" rel="stylesheet" type="text/css" />  
   
</head>
<body style="margin-left:0; margin-top:0">
    <form id="form1" runat="server">
               <br />
            <br />
        <br />
            <br />


        <table style="width: 100%; background-color: #FFFFFF">
            
            <tr>
                <td colspan="2">
                    <table width="100%">
                        <tr>
                            <td rowspan="2" style="width: 81px">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/SAGS_Logo.png" Height="62px" Width="81px" /></td>
                            <td align="center">
                                <strong><span style="font-size: 16pt">CÔNG TY CỔ PHẦN PHỤC VỤ MẶT ĐẤT SÀI GÒN</span></strong></td>
                        </tr>
                        <tr>
                            <td align="center" style="height: 48px">
                                <table>
                                    <tr>
                                        <td style="height: 21px">
                                            <strong>
                                            THU NHẬP THÁNG</strong></td>
                                        <td style="height: 21px">
                                            <asp:Label ID="labelMonth" runat="server" Font-Bold="True" Font-Size="12pt"></asp:Label></td>
                                        <td style="height: 21px">
                                            <strong>
                                            NĂM</strong></td>
                                        <td style="height: 21px">
                                            <asp:Label ID="labelYear" runat="server" Font-Bold="True" Font-Size="12pt"></asp:Label></td>
                                    </tr>
                                </table>
                                <hr />
                            </td>
                        </tr>
                    </table>                    
                </td>
            </tr>
            <tr>
                <td colspan="2">
                </td>
                
            </tr>
            <tr>
                <td colspan="2">
                    <fieldset>
                        <legend class="legend">Thông tin cá nhân</legend>
                             <table style="width: 100%" >
                                <tr>
                                        <td>
                                            <asp:Label ID="Label1" runat="server" Text="Họ và tên" CssClass="label"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbFullName" runat="server" CssClass="value"></asp:Label></td>
                                </tr>
                                <tr>
                                        <td>
                                            <asp:Label ID="Label10" runat="server" Text="Chức danh" CssClass="label"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="lbPosition" runat="server" CssClass="value"></asp:Label></td>
                                </tr>
                                <tr>
                                        <td>
                                            <asp:Label ID="Label4" runat="server" Text="Phòng ban" CssClass="label"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="lbDepartment" runat="server" CssClass="value"></asp:Label></td>
                                </tr>
                                <tr>

                                        <td style="width: 10%">
                                            <asp:Label ID="Label3" runat="server" Text="Số tài khoản" CssClass="label"></asp:Label></td>
                                        <td style="width: 20%">
                                            <asp:Label ID="lbAccountNo" runat="server" CssClass="value"></asp:Label></td>
                                 </tr>
                                 <tr>
                                        <td style="width: 7%">
                                            <asp:Label ID="Label11" runat="server" CssClass="label" Text="Ngân hàng"></asp:Label></td>
                                        <td colspan="63%" > 
                                            <asp:Label ID="lbBankName" runat="server" CssClass="value"></asp:Label></td>
                                 </tr>
                            </table>
                    </fieldset> 
                </td>
            </tr>
            <%--<tr>
                <td align="left" class="legend">Hệ Số</td>
                <td class="legend">Giảm trừ cá nhân</td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="grdCoefficients" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="odsCoefficients" Width="99%" 
                        OnRowDataBound="grdCoefficients_RowDataBound" CssClass="grid-Border">
                        <Columns>
                            <%--<asp:BoundField DataField="CoefficientName" HeaderText="Hệ Số" SortExpression="CoefficientName">
                            </asp:BoundField>
                            <asp:BoundField DataField="Description" HeaderText="M&#244; Tả" SortExpression="Description">
                            </asp:BoundField>
                            <asp:BoundField DataField="Value" HeaderText="Gi&#225; Trị" SortExpression="Value" >
                            </asp:BoundField>
                        </Columns>
                        <HeaderStyle CssClass="grid-header" />
                    </asp:GridView>
                    <asp:ObjectDataSource ID="odsCoefficients" runat="server" SelectMethod="GetCoefficient"
                        TypeName="HRMBLL.H1.WorkdayCoefficientEmployeesFinalBLL" 
                        OnSelecting="odsCoefficients_Selecting">
                        <SelectParameters>
                            <asp:Parameter Name="userId" Type="Int32" />
                            <asp:Parameter Name="month" Type="Int32" />
                            <asp:Parameter Name="year" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
                <td valign="top">    
                     <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Right" 
                         AutoGenerateColumns="False" DataSourceID="odsTimeKeeping" Width="99%" 
                         OnRowDataBound="grdTimeKeeping_RowDataBound"  CssClass="grid-Border">
                        <Columns>
                            <asp:BoundField DataField="Description" HeaderText="Loại" SortExpression="Description">
                            </asp:BoundField>
                            <asp:BoundField DataField="Value" HeaderText="Số Giờ" SortExpression="Value">
                            </asp:BoundField>
                        </Columns>
                        <HeaderStyle CssClass="grid-header" />
                    </asp:GridView>
                    &nbsp;
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                         SelectMethod="GetPIT" TypeName="HRMBLL.H1.WorkdayCoefficientEmployeesFinalBLL" 
                         OnSelecting="ObjectDataSource1_Selecting" 
                         OldValuesParameterFormatString="original_{0}">
                        <SelectParameters>
                            <asp:Parameter Name="userId" Type="Int32" />
                            <asp:Parameter Name="month" Type="Int32" />
                            <asp:Parameter Name="year" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
            </tr>--%>
            <%--<tr>
                <td colspan="2">
                    <table style="width: 100%">
                        <tr>
                            <td align="left" class="legend" style="height: 14px">
                                Ngày Công</td>
                            <td align="left" class="legend" style="height: 14px">
                                Giờ Công</td>
                        </tr>    
                        <tr>
                            <td align="left">
                                <asp:GridView ID="grdWorkday" runat="server" AutoGenerateColumns="False" DataSourceID="odsWorkday" Width="99%" OnRowDataBound="grdWorkday_RowDataBound" CssClass="grid-Border">
                                    <Columns>
                                        <%--<asp:BoundField DataField="TimeKeepingCode" HeaderText="Loại" SortExpression="TimeKeepingCode">
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Description" HeaderText="M&#244; Tả" SortExpression="Description">
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Value" HeaderText="Số Ng&#224;y" SortExpression="Value">
                                        </asp:BoundField>
                                    </Columns>
                                    <HeaderStyle CssClass="grid-header" />
                                </asp:GridView>
                                <asp:ObjectDataSource ID="odsWorkday" runat="server" SelectMethod="GetWorkday" 
                                    TypeName="HRMBLL.H1.WorkdayCoefficientEmployeesFinalBLL" 
                                    OnSelecting="odsWorkday_Selecting" 
                                    OldValuesParameterFormatString="original_{0}">
                                    <SelectParameters>
                                        <asp:Parameter Name="userId" Type="Int32" />
                                        <asp:Parameter Name="month" Type="Int32" />
                                        <asp:Parameter Name="year" Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </td>
                            <td valign="top">
                                <asp:GridView ID="grdTimeKeeping" runat="server" HorizontalAlign="Right" AutoGenerateColumns="False" DataSourceID="odsTimeKeeping" Width="99%" OnRowDataBound="grdTimeKeeping_RowDataBound"  CssClass="grid-Border">
                                    <Columns>
                                        <asp:BoundField DataField="Description" HeaderText="Loại" SortExpression="Description">
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Value" HeaderText="Số Giờ" SortExpression="Value">
                                        </asp:BoundField>
                                    </Columns>
                                    <HeaderStyle CssClass="grid-header" />
                                </asp:GridView>
                                &nbsp;
                                <asp:ObjectDataSource ID="odsTimeKeeping" runat="server" 
                                    SelectMethod="GetWorktime" 
                                    TypeName="HRMBLL.H1.WorkdayCoefficientEmployeesFinalBLL" 
                                    OnSelecting="odsTimeKeeping_Selecting" 
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
            </tr>--%>

            <tr>
                <td colspan="2">
                    <table style="width: 100%">
                        <tr>
                            <td align="left" class="legend">
                                Các Khoản Thu Nhập</td>
                            <td align="left" class="legend">
                                Các Khoản Phải Nộp</td>
                        </tr>
                        <tr>
                            <td valign="top">
                                 <table width="100%">
                                    <tr>
                                        <td colspan="2">
                                            <asp:GridView ID="grdIncomes" runat="server" AutoGenerateColumns="False" 
                                                DataSourceID="odsIncomes" Width="99%" OnRowDataBound="grdIncomes_RowDataBound" 
                                                CssClass="grid-Border">
                                                <Columns>
                                                    <asp:BoundField DataField="Description" HeaderText="C&#225;c Khoản Thu" SortExpression="Description" >
                                                        <ItemStyle CssClass="grid-item-print" HorizontalAlign="Left" />
                                                        <HeaderStyle CssClass="grid-header-print" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="Value" HeaderText="Số Tiền ( VNĐ )" SortExpression="Value" DataFormatString="{0:#,###0.00}" HtmlEncode="False">
                                                        <ItemStyle CssClass="grid-item-print" HorizontalAlign="Right" />
                                                        <HeaderStyle CssClass="grid-header-print" />
                                                    </asp:BoundField>
                                                </Columns>
                                                 <HeaderStyle CssClass="grid-header" />
                                            </asp:GridView>
                                            <asp:ObjectDataSource ID="odsIncomes" runat="server" OnSelecting="odsIncomes_Selecting"
                                                SelectMethod="GetAllByUserId_Monthly_By_All" 
                                                TypeName="HRMBLL.H.IncomesMonthBLL" 
                                                OldValuesParameterFormatString="original_{0}">
                                                <SelectParameters>
                                                    <asp:Parameter Name="userId" Type="Int32" />
                                                    <asp:Parameter Name="month" Type="Int32" />
                                                    <asp:Parameter Name="year" Type="Int32" />
                                                </SelectParameters>
                                            </asp:ObjectDataSource>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                                                Font-Size="10px" Text="Tổng Cộng ( I )"></asp:Label></td>
                                        <td align="right">
                                            <asp:Label ID="lbTotalIncome" runat="server" Font-Bold="False" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                                                Font-Size="10px"></asp:Label>&nbsp;&nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                            <td valign="top">
                                <table width="100%">
                                    <tr>
                                        <td colspan="2">
                                            <asp:GridView ID="grdContributions" runat="server" AutoGenerateColumns="False" 
                                                DataSourceID="odsContribution" HorizontalAlign="Right" Width="100%" 
                                                OnRowDataBound="grdContributions_RowDataBound" CssClass="grid-Border">
                                                <Columns>
                                                    <asp:BoundField DataField="Description" HeaderText="C&#225;c Khoản Nộp" SortExpression="Description">
                                                    <ItemStyle CssClass="grid-item-print" HorizontalAlign="Left" />
                                                        <HeaderStyle CssClass="grid-header-print" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="Value" HeaderText="Số Tiền ( VNĐ )" SortExpression="Value" DataFormatString="{0:#,###0.00}" HtmlEncode="False">
                                                    <ItemStyle CssClass="grid-item-print" HorizontalAlign="Right" />
                                                        <HeaderStyle CssClass="grid-header-print" />
                                                    </asp:BoundField>
                                                </Columns>
                                                 <HeaderStyle CssClass="grid-header" />
                                            </asp:GridView>
                                            <asp:ObjectDataSource ID="odsContribution" runat="server" OnSelecting="odsContribution_Selecting"
                                                SelectMethod="GetAllByUserId_Paid_Monthly_By_All" 
                                                TypeName="HRMBLL.H.IncomesMonthBLL" 
                                                OldValuesParameterFormatString="original_{0}">
                                                <SelectParameters>
                                                    <asp:Parameter Name="userId" Type="Int32" />
                                                    <asp:Parameter Name="month" Type="Int32" />
                                                    <asp:Parameter Name="year" Type="Int32" />
                                                </SelectParameters>
                                            </asp:ObjectDataSource>
                                         </td>
                                      </tr>
                                      <tr>
                                            <td style="height: 21px">
                                                <asp:Label ID="label7" runat="server" Font-Bold="True" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                                                    Font-Size="11px" Text="Tổng Cộng ( II )"></asp:Label></td>
                                            <td style="height: 21px" align="right">
                                                <asp:Label ID="lbTotalContribution" runat="server" Font-Bold="False" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                                                    Font-Size="10px"></asp:Label>&nbsp;</td>
                                      </tr>
                                      <tr>
                                           <td colspan="2">
                                                <fieldset class="fieldset">
                                                    <legend class="legend">Thu Nhập Thực Lĩnh ( I - II )</legend>
                                                        <table style="width: 100%; height:50px; background-color:#b2c891;">                                                    
                                                            <tr>
                                                                <td align="center">
                                                                    <asp:Label ID="lbRealIncome" runat="server" Font-Bold="True" Font-Names="Verdana,Arial,Helvetica,sans-serif" Font-Size="15pt"></asp:Label></td>
                                                                
                                                            </tr>
                                                        </table>
                                                         <asp:Label ID="Label5" runat="server" CssClass="label" Text="( * ) : Đã được tính trong khoản Lương"></asp:Label>
                                                </fieldset>
                                               <table style="width: 100%">
                                                   <tr>
                                                       <td style="text-align: center">
                                                           <asp:Label ID="lbPositionSelectUser" runat="server" Font-Bold="True" 
                                                               Text="TL. Tổng Giám đốc &lt;br&gt; Phó Giám Đốc"></asp:Label>
                                                           </td>
                                                   </tr>
                                                   <tr>
                                                       <td style="height: 80px">
                                                           &nbsp;</td>
                                                   </tr>
                                                   <tr>
                                                       <td style="height: 21px; text-align: center">
                                                           <asp:Label ID="lbFullNameSelectUser" runat="server" Text="Nguyễn Thị Đỗ Quyên" Font-Bold="True"></asp:Label></td>
                                                   </tr>
                                               </table>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
           
        </table>
    
    
    </form>
</body>
</html>
