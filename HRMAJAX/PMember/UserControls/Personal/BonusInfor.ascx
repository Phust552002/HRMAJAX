<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BonusInfor.ascx.cs" Inherits="PMember_UserControls_Personal_BonusInfor"  %>
<%@ Register Src="../../../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc2" %>
<%@ Register Src="../../../UserControls/ucMessageError.ascx" TagName="ucMessageError" TagPrefix="uc1" %>
 
 <table style="width: 100%">
 <tr>
    <td>
         <table width="100%" class="tableBorder">
             <tr>
                 <td class="tdLabel" colspan="4">
                     <uc1:ucMessageError ID="UcMessageError1" runat="server" />
                 </td>
             </tr>
             <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label8" runat="server" CssClass="label" Text="Họ và tên đang dùng"></asp:Label></td>
                <td class="tdValue">
                    <asp:TextBox ID="txtNormalNames" runat="server" CssClass="textBox" Width="100%" ></asp:TextBox></td>
                  <td class="tdLabel">
                    <asp:Label ID="Label3" runat="server" CssClass="label" Text="Sinh ngày"></asp:Label></td>
                <td class="tdValue">
                    <uc2:CalendarPicker ID="cpBirthDay" runat="server" />
                </td>
              </tr>
              <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label9" runat="server" CssClass="label" Text="Mới thay đổi nơi ở"></asp:Label></td>
                 <td class="tdValue" colspan="1">
                     <asp:TextBox ID="txtLive" runat="server" CssClass="textBox"  Width="100%"></asp:TextBox></td>
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Mới thay đổi nghề nghiệp, đơn vị công tác"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtNgheNghiepHienNay" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                     
             </tr>
              
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Chức vụ mới được giao"></asp:Label></td>                                         
             </tr>

               <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Chức vụ Đảng"></asp:Label></td>  
                   <td class="tdValue">
                        <asp:TextBox ID="txtChucVuDang" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td> 
                   <td class="tdLabel">
                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Chức vụ Chính quyền"></asp:Label></td>  
                   <td class="tdValue">
                        <asp:TextBox ID="txtChucVuCQ" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td> 
             </tr>
      
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label6" runat="server" CssClass="label" Text="Chức vụ Đoàn thể"></asp:Label></td>  
                   <td class="tdValue">
                        <asp:TextBox ID="txtChucVuDT" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td> 
                 <td class="tdLabel">
                        <asp:Label ID="Label7" runat="server" CssClass="label" Text="Chức vụ Doanh nghiệp, đơn vị công tác"></asp:Label></td>  
                   <td class="tdValue">
                        <asp:TextBox ID="txtChucVuDN" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td> 
             </tr>
            
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label10" runat="server" CssClass="label" Text="Mới thay đổi về trình độ, chuyên môn, nghiệp vụ"></asp:Label></td>                                         
             </tr>

             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label28" runat="server" CssClass="label" Text="Giáo dục phổ thông"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtTrinhDoTHPT" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>     
                  <td class="tdLabel">
                        <asp:Label ID="Label30" runat="server" CssClass="label" Text="Chuyên môn, nghiệp vụ"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtChuyenMonNV" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
             </tr>
             
             <tr>                 
                 <td class="tdLabel">
                        <asp:Label ID="Label32" runat="server" CssClass="label" Text="Học hàm"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtHocHam" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td> 
                 <td class="tdLabel">
                        <asp:Label ID="Label31" runat="server" CssClass="label" Text="Học vị"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtHocVi" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td> 
             </tr>
              <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label33" runat="server" CssClass="label" Text="Lý luận chính trị"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtLyLuanChinhTri" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                 
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label34" runat="server" CssClass="label" Text="Ngoại ngữ"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtNgoaiNgu" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                 
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label11" runat="server" CssClass="label" Text="Hình thức khen thưởng mới trong năm"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtKhenThuong" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                 
             </tr>
            <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label12" runat="server" CssClass="label" Text="Bị xử lý hình thức kỷ luật trong năm"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtKyLuat" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                 
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label13" runat="server" CssClass="label" Text="Gia đình có gì thay đổi trong năm"></asp:Label></td>                                         
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label14" runat="server" CssClass="label" Text="Cha đẻ"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtChaDe" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td> 
                 <td class="tdLabel">
                        <asp:Label ID="Label15" runat="server" CssClass="label" Text="Mẹ đẻ"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtMeDe" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label16" runat="server" CssClass="label" Text="Cha (vợ hoặc chồng)"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtChaVc" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td> 
                 <td class="tdLabel">
                        <asp:Label ID="Label17" runat="server" CssClass="label" Text="Mẹ (vợ hoặc chồng)"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtMeVc" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label18" runat="server" CssClass="label" Text="Vợ hoặc chồng"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtVoChong" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                 
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label19" runat="server" CssClass="label" Text="Con"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtCon" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                 
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label20" runat="server" CssClass="label" Text="Có con lấy vợ (chồng) là người nước ngoài"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtVoChongNuocNgoaiCuaCon" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                 
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label21" runat="server" CssClass="label" Text="Có vợ (chồng) hoặc con đi học ở nước ngoài"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtVCConDiNuocNgoai" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                 
             </tr>

             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label22" runat="server" CssClass="label" Text="Có thay đổi về kinh tế bản thân và gia đình trong năm"></asp:Label></td>                                         
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label23" runat="server" CssClass="label" Text="Tổng mức thu nhâp của hộ gia đình (đồng)"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtTongThuNhapHGD" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
                 
                 <td class="tdLabel">
                        <asp:Label ID="Label24" runat="server" CssClass="label" Text="Bình quân người/hộ (đồng)"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtBinhQuanNguoi" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
             </tr>
              <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label25" runat="server" CssClass="label" Text="Nhà ở"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtNhaO" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                 
             </tr>
              <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label26" runat="server" CssClass="label" Text="Đất ở"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtDatO" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                 
             </tr>
              <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label27" runat="server" CssClass="label" Text="Hoạt động kinh tế"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtHoatDongKinhTe" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                 
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label29" runat="server" CssClass="label" Text="Tài sản mới (50 triệu đồng trở lên)"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtTaiSanMoi" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                 
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label35" runat="server" CssClass="label" Text="Giá trị (đồng)"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtGiaTri" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                 
             </tr>
             <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label36" runat="server" CssClass="label" Text="Được miễn công tác và sinh hoạt Đảng ngày"></asp:Label></td>
                 <td class="tdValue">
                     <asp:TextBox ID="txtMienCongTacSHD" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
             </tr>
             <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label37" runat="server" CssClass="label" Text="Kết quả đánh giá chất lượng đảng viên trong năm"></asp:Label></td>
                 <td class="tdValue">
                     <%--<asp:TextBox ID="txtCLDangVien" runat="server" CssClass="textBox" Width="100%"></asp:TextBox>--%>
                     <asp:DropDownList ID="txtCLDangVien" runat="server">
                        <asp:ListItem Enabled="true" Text="Vui lòng chọn" Value="-1"></asp:ListItem>
                        <asp:ListItem Text="Hoàn thành xuất sắc nhiệm vụ" Value="Hoàn thành xuất sắc nhiệm vụ"></asp:ListItem>
                        <asp:ListItem Text="Hoàn thành tốt nhiệm vụ" Value="Hoàn thành tốt nhiệm vụ"></asp:ListItem>
                        <asp:ListItem Text="Hoàn thành nhiệm vụ" Value="Hoàn thành nhiệm vụ"></asp:ListItem>
                        <asp:ListItem Text="Không hoàn thành nhiệm vụ" Value="Không hoàn thành nhiệm vụ "></asp:ListItem>
                    </asp:DropDownList>

                 </td>
             </tr>

             <tr>
                <td colspan="4" class="tdButton">
                   <table style="width: 100%" >
                        <tr>
                            <td align="center">
                                 <asp:Button ID="btnUpdateBonusInfor" Visible="true" runat="server" Text="Cập nhật" OnClick="btnUpdateBonusInfor_Click" CssClass="small color green button" Width="100px" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>   
         </table>
    </td>
 </tr> 
</table>