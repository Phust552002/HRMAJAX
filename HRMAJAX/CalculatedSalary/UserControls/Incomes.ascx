<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Incomes.ascx.cs" Inherits="CalculatedSalary_UserControls_Incomes" %>

<table width="100%" class="tableBorder">
    <tr>
        <td>
            <asp:DataList ID="DataList1" runat="server" OnItemDataBound="DataList1_ItemDataBound" Width="100%" CellPadding="0" CellSpacing="0">                                           
            <ItemTemplate> 
                <table width="100%" cellpadding="0" cellspacing="0">
                    <tr class="grid-header">
                        <td style="width:50%" align="left">Các Khoản Thu Nhập</td>
                        <td style="width:50%" align="right">Số Tiền (VND)</td>
                    </tr>
                    <tr class="grid-item">
                        <td align="left">Lương</td><td align="right"><asp:Label ID="lbLNS" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="grid-atlternating-item">
                        <td align="left">Tiền lương cơ bản</td><td align="right"><asp:Label ID="lbLCBNN" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="grid-item">
                        <td  align="left">Phụ cấp chức vụ</td><td  align="right"><asp:Label ID="lbPCCV" runat="server"></asp:Label> </td>
                    </tr>
                    <tr class="grid-atlternating-item">
                        <td  align="left">Phụ cấp trách nhiệm</td><td  align="right"><asp:Label ID="lbPCTN" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="grid-item">
                        <td  align="left">Phụ cấp độc hại</td><td  align="right"><asp:Label ID="lbPCDH" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="grid-atlternating-item">
                        <td  align="left">Trợ cấp Bảo hiểm xã hội</td><td  align="right"><asp:Label ID="lbTCBHXH" runat="server"></asp:Label></td>
                    </tr>
                    
                    <tr class="grid-item">
                        <td  align="left">Tiền ăn</td><td  align="right"><asp:Label ID="lbTienAn" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="grid-atlternating-item">
                        <td  align="left">Bổ sung lương</td><td  align="right"><asp:Label ID="lbBoSungLuong" runat="server"></asp:Label> </td>
                    </tr>
                     <tr class="grid-item">
                        <td  align="left">Tiền thêm giờ</td><td  align="right"><asp:Label ID="lbTienThemGio" runat="server"></asp:Label></td>
                    </tr>                                                    
                    <tr class="grid-atlternating-item">
                        <td  align="left">Tiền làm đêm</td><td  align="right"><asp:Label ID="lbTienLamDem" runat="server"></asp:Label></td>
                    </tr>
                </table>                                                
            </ItemTemplate>
            <ItemStyle HorizontalAlign="Right" />
                
        </asp:DataList>
        </td>
    </tr>
</table>
<table width="100%" class="tableBorder">
    <tr>
        <td>
            <asp:DataList ID="DataList2" runat="server" OnItemDataBound="DataList2_ItemDataBound" Width="100%" CellPadding="0" CellSpacing="0">
                <ItemTemplate>
                <table width="100%" cellpadding="0" cellspacing="0">
                        <tr class="grid-header">
                            <td style="width:50%"  align="left">Các Khoản Phải Nộp</td>
                            <td style="width:50%"  align="right">Số Tiền (VND)</td>
                        </tr>
                        <tr class="grid-item">
                            <td  style="width:50%" align="left">Trích Bảo hiểm xã hội</td><td   style="width:50%" align="right"><asp:Label ID="lbTrBHXH" runat="server"></asp:Label></td>
                        </tr>
                        <tr class="grid-atlternating-item">
                            <td  style="width:50%" align="left">Trích Bảo hiểm y tế</td><td   style="width:50%" align="right"><asp:Label ID="lbTrBHYT" runat="server"> </asp:Label></td>
                        </tr>
                        <tr class="grid-item">
                            <td  style="width:50%" align="left">Trích phí công đoàn</td><td   style="width:50%" align="right"><asp:Label ID="lbTrDoanPhi" runat="server"></asp:Label></td>
                        </tr>
                        <tr class="grid-atlternating-item">
                            <td  style="width:50%" align="left">Thuế thu nhập</td><td   style="width:50%" align="right"><asp:Label ID="lbThueThuNhap" runat="server"></asp:Label></td>
                        </tr>
                    <tr class="grid-atlternating-item">
                        <td align="left" style="width: 50%">
                            Trích Bảo hiểm thất nghiệp</td>
                        <td align="right" style="width: 50%">
                            <asp:Label ID="lbTrBHTN" runat="server"></asp:Label></td>
                    </tr>
                  </table>                                                                                                                                                                                 
                 </ItemTemplate>
            </asp:DataList>
        </td>
    </tr>
</table>

