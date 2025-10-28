<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ControlBoardVoteCountReport.aspx.cs" Inherits="ShareHolder_ControlBoardVoteCountReport" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>ĐẠI HỘI ĐÔNG CỔ ĐÔNG THÀNH LẬP CÔNG TY CỔ PHẦN PVMĐ SÀI GÒN</title>
    <link href="../Stylesheets/Styles.css" rel="stylesheet" type="text/css" />  
</head>
<body>
    <form id="form1" runat="server">
    <div>
     
        <table style="width: 100%">
            <tr>
                <td>                   
                   <uc1:ucTitle ID="UcTitle1" runat="server" />                        
                </td>
            </tr>
            <tr>
                <td>
                   <table class="tableBorder" cellpadding="0" cellspacing="0" width="100%">
                        <tr>
                            <td class="tdLabel">
                                <asp:GridView ID="GridView3" runat="server" DataSourceID="ObjectDataSource2" 
                                    onrowdatabound="GridView3_RowDataBound" Width="100%" 
                                    AutoGenerateColumns="False">
                                 <RowStyle CssClass="grid-item"></RowStyle>
                                <PagerStyle CssClass="grid-paper"></PagerStyle>
                                <HeaderStyle CssClass="grid-header" HorizontalAlign="Center"></HeaderStyle>
                                <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                                <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                    <Columns>
                                        <asp:BoundField DataField="Col1" HeaderText="STT">
                                        <ItemStyle HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Col2" HeaderText="Nội dung">
                                        <ItemStyle HorizontalAlign="Left" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Col3" HeaderText="KQ"></asp:BoundField>
                                        <asp:BoundField DataField="Col4" HeaderText="--">
                                        <ItemStyle HorizontalAlign="Center" />
                                        </asp:BoundField>
                                    </Columns>
                                <FooterStyle CssClass="grid-footer"></FooterStyle>

                                </asp:GridView>
                                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                                    SelectMethod="GetForStatisticByBKS2" 
                                    TypeName="HRMBLL.H4.RepresentativeBLL" 
                                         OldValuesParameterFormatString="original_{0}">
                                </asp:ObjectDataSource>
                                </td>       
                        </tr>
                        <tr>
                            <td style="height:30px"></td>
                        </tr>
                        <tr>
                            <td class="tdLabel" style="width:40%">
                                <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" 
                                    onrowdatabound="GridView1_RowDataBound" Width="100%" 
                                    AutoGenerateColumns="False">
                                 <RowStyle CssClass="grid-item"></RowStyle>
                                <PagerStyle CssClass="grid-paper"></PagerStyle>
                                <HeaderStyle CssClass="grid-header" HorizontalAlign="Center"></HeaderStyle>
                                <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                                <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                    <Columns>
                                        <asp:BoundField DataField="Col1" HeaderText="STT">
                                        <ItemStyle Width="10%" HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Col2" HeaderText="Họ và tên">
                                        <ItemStyle Width="50%" HorizontalAlign="Left" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Col3" 
                                            HeaderText="Số lượng cổ phần bỏ phiếu hợp lệ (đã quy đổi)">
                                        <ItemStyle Width="20%" HorizontalAlign="Right" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Col4" 
                                            HeaderText="Tỷ lệ CP bỏ phiếu hợp lệ (đã quy đổi)/Tổng số CP tham gia bầu cử">
                                        <ItemStyle Width="20%" HorizontalAlign="Right" />
                                        </asp:BoundField>
                                    </Columns>
                                <FooterStyle CssClass="grid-footer"></FooterStyle>

                                </asp:GridView>
                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                                    SelectMethod="GetForStatisticByBKS" 
                                    TypeName="HRMBLL.H4.RepresentativeBLL" 
                                    OldValuesParameterFormatString="original_{0}">
                                </asp:ObjectDataSource>
                                </td>                                                       
                        </tr>                      
                        
                    </table>
                </td>
            </tr>                                         
        </table>
       
    </div>
    </form>
</body>
</html>

