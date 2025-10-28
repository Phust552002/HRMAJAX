<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DetailInfor.ascx.cs" Inherits="PMember_UserControls_Personal_DetailInfor"  %>
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
                    <asp:Label ID="Label24" runat="server" CssClass="label" Text="Giới tính"></asp:Label></td>                
                <td class="tdValue">
                    <asp:RadioButton ID="rdoMale" runat="server" CssClass="value" GroupName="groupSex"
                        Text="Nam" /><asp:RadioButton ID="rdoFemale" runat="server" CssClass="value" GroupName="groupSex"
                            Text="Nữ" /></td>
              </tr>
              <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Họ và tên khai sinh"></asp:Label></td>
                <td class="tdValue" >
                    <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox" Width="100%" ></asp:TextBox></td>
              </tr>
              <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label2" runat="server" CssClass="label" Text="Các bí danh"></asp:Label></td>
                <td class="tdValue">
                    <asp:TextBox ID="txtOtherNames" runat="server" CssClass="textBox" Width="100%" ></asp:TextBox></td>
                
              </tr>       
              <tr>
                
                <td class="tdLabel">
                    <asp:Label ID="Label3" runat="server" CssClass="label" Text="Sinh ngày"></asp:Label></td>
                <td class="tdValue">
                    <uc2:CalendarPicker ID="cpBirthDay" runat="server" />
                </td>
              </tr>       
             <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label5" runat="server" CssClass="label" Text="Nơi sinh"></asp:Label></td>
                 <td class="tdValue" colspan="1">
                     <asp:TextBox ID="txtBirthPlace" runat="server" CssClass="textBox"  Width="100%"></asp:TextBox></td>
             </tr>
             <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label6" runat="server" CssClass="label" Text="Quê quán"></asp:Label></td>
                 <td class="tdValue" colspan="1">
                     <asp:TextBox ID="txtNativePlace" runat="server" CssClass="textBox"  Width="100%"></asp:TextBox></td>
             </tr>
             <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label7" runat="server" CssClass="label" Visible="false" Text="Hộ khẩu thường trú"></asp:Label></td>
                 <td class="tdValue" colspan="1">
                     <asp:TextBox ID="txtResident" runat="server" CssClass="textBox" Visible="false" Width="100%"></asp:TextBox></td>
             </tr>
             <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label9" runat="server" CssClass="label" Text="Nơi ở hiện nay"></asp:Label></td>
                 <td class="tdValue" colspan="1">
                     <asp:TextBox ID="txtLive" runat="server" CssClass="textBox"  Width="100%"></asp:TextBox></td>
             </tr>

             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label15" runat="server" CssClass="label" Text="Dân tộc"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtNation" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>    
                 <td class="tdLabel">
                    <asp:Label ID="Label14" runat="server" CssClass="label" Text="Tôn giáo"></asp:Label></td>
                <td class="tdValue">
                    <asp:TextBox ID="txtReligion" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Nghề nghiệp bản thân hiện nay"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtNgheNghiepHienNay" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                     
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label28" runat="server" CssClass="label" Text="Giáo dục phổ thông"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtTrinhDoTHPT" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                     
             </tr>
              <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label30" runat="server" CssClass="label" Text="Chuyên môn, nghiệp vụ"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtChuyenMonNV" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>                     
             </tr>
             <tr>
                 <td class="tdLabel">
                        <asp:Label ID="Label31" runat="server" CssClass="label" Text="Học vị"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtHocVi" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td> 
                 <td class="tdLabel">
                        <asp:Label ID="Label32" runat="server" CssClass="label" Text="Học hàm"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtHocHam" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td> 
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
                     <asp:Label ID="Label25" runat="server" CssClass="label" Text="Ngày vào Đoàn TNCSHCM"></asp:Label></td>
                 <td class="tdValue">
                     <uc2:CalendarPicker ID="cpDateJoinCYU" runat="server" />
                 </td>
                 <td class="tdLabel">
                     <asp:Label ID="Label26" runat="server" CssClass="label" Text="Nơi vào Đoàn TNCSHCM"></asp:Label></td>
                 <td class="tdValue">
                     <asp:TextBox ID="txtPlaceJoinCYU" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
             </tr>
             <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label17" runat="server" CssClass="label" Text="Ngày vào Đảng CSVN"></asp:Label></td>
                <td class="tdValue">
                    <uc2:CalendarPicker ID="cpDateJoinParty" runat="server" />
                </td>
                <td class="tdLabel">
                    <asp:Label ID="Label18" runat="server" CssClass="label" Text="Nơi vào Đảng CSVN"></asp:Label></td>
                <td class="tdValue">
                    <asp:TextBox ID="txtPlaceJoinParty" runat="server" CssClass="textBox"  Width="100%" ></asp:TextBox></td>
             </tr>
             <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label35" runat="server" CssClass="label" Text="Ngày công nhận chính thức"></asp:Label></td>
                <td class="tdValue">
                    <uc2:CalendarPicker ID="cpDateJoinPOfficial" runat="server" />
                </td>
                <td class="tdLabel">
                    <asp:Label ID="Label36" runat="server" CssClass="label" Text="Nơi công nhận chính thức"></asp:Label></td>
                <td class="tdValue">
                    <asp:TextBox ID="txtPlaceJoinPOfficial" runat="server" CssClass="textBox"  Width="100%" ></asp:TextBox></td>
             </tr>
             <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label37" runat="server" CssClass="label" Text="Số thẻ Đảng viên"></asp:Label></td>
                 <td class="tdValue">
                     <asp:TextBox ID="txtPCardNo" runat="server" CssClass="textBox"  Width="100%"></asp:TextBox></td>
                 <td class="tdLabel">
                     <asp:Label ID="Label38" runat="server" CssClass="label" Text="Nơi cấp thẻ"></asp:Label></td>
                 <td class="tdValue">
                     <asp:TextBox ID="txtNoiCapThe" runat="server" CssClass="textBox"  Width="100%"></asp:TextBox></td>
             </tr>

             <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label39" runat="server" CssClass="label" Text="Ngày cấp thẻ"></asp:Label></td>
                 <td class="tdValue">
                    <uc2:CalendarPicker ID="cpNgayCapThe" runat="server" />
                </td>
                 <td class="tdLabel">
                     <asp:Label ID="Label23" runat="server" CssClass="label" Text="Người giới thiệu vào Đảng"></asp:Label></td>
                 <td class="tdValue">
                     <asp:TextBox ID="txtReference" runat="server" CssClass="textBox"  Width="100%"></asp:TextBox></td>
             </tr>
             <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label27" runat="server" CssClass="label" Text="Điện thoại di động"></asp:Label></td>
                 <td class="tdValue">
                     <asp:TextBox ID="txtHandPhone" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
                 <td class="tdLabel">
                     <asp:Label ID="Label29" runat="server" CssClass="label" Text="Điện thoại nhà"></asp:Label></td>
                 <td class="tdValue">
                     <asp:TextBox ID="txtHomePhone" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
             </tr>
            
             <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label10" runat="server" CssClass="label" Text="Số CMND"></asp:Label></td>
                <td class="tdValue">
                    <asp:TextBox ID="txtIdCard" runat="server" CssClass="textBox" Width="100%" ></asp:TextBox></td>
                <td class="tdLabel">
                    <asp:Label ID="Label11" runat="server" CssClass="label" Text="Ngày cấp"></asp:Label></td>
                <td class="tdValue">
                    <uc2:CalendarPicker ID="cpDateOfIssue" runat="server" />
                </td>
              </tr>
              <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label12" runat="server" CssClass="label" Text="Nơi cấp"></asp:Label></td>
                 <td class="tdValue">
                     <asp:TextBox ID="txtPlaceOfIssue" runat="server" CssClass="textBox"  Width="100%"></asp:TextBox></td>
                 
             </tr>     
             <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label13" runat="server" CssClass="label" Text="Quốc tịch"></asp:Label></td>
                <td class="tdValue">
                    <asp:TextBox ID="txtNationality" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
                
              </tr>
              <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label16" runat="server" CssClass="label" Text="Thành phần gia đình xuất thân"></asp:Label></td>
                 <td class="tdValue" colspan="1">
                     <asp:TextBox ID="txtOrigin" runat="server" CssClass="textBox"  Width="100%"></asp:TextBox></td>
             </tr> 
             <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label19" runat="server" CssClass="label" Text="Ngày nhập ngũ"></asp:Label></td>
                <td class="tdValue">
                    <uc2:CalendarPicker ID="cpDateOfEnlisted" runat="server" />
                </td>
                <td class="tdLabel">
                    <asp:Label ID="Label20" runat="server" CssClass="label" Text="Ngày xuất ngũ"></asp:Label></td>
                <td class="tdValue">
                    <uc2:CalendarPicker ID="cpDateOfDemobilized" runat="server" /></td>
             </tr>
             <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label21" runat="server" CssClass="label" Text="Quân hàm"></asp:Label></td>
                 <td class="tdValue" colspan="1">
                     <asp:TextBox ID="txtArmyRank" runat="server" CssClass="textBox"  Width="100%"></asp:TextBox></td>
             </tr>
             <%--<tr class="tdValue">
                 <td colspan="4">
                    <fieldset Visible="false">
                        <legend class="label"></legend>
                        
                         <table class="tableBorder" Visible="false" width="100%">
                             <tr>
                                <td> 
                                    <asp:UpdatePanel ID="UpdatePanel1" Visible="false" runat="server">
                                        <ContentTemplate>                                                                                                               
                                         <asp:DataList ID="dlEducation" runat="server" Width="100%" OnItemDataBound="dlDataListInsert_ItemDataBound">
                                            <HeaderTemplate>
                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                    <tr class="dataList-header">
                                                        <td style="width:20%" align="left">Trình độ</td>                                                                        
                                                        <td style="width:20%" align="left">Giá trị</td>
                                                        <td style="width:40%" align="left">Ghi chú</td>                                                                                                                        
                                                        <td style="width:10%" align="center">Xóa dòng</td>
                                                        <td style="width:10%" align="center">Thêm dòng mới</td>
                                                    </tr>
                                                </table>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                    <tr>
                                                        <td style="width:20%;" align="left" valign="top">
                                                            <asp:DropDownList ID="ddlEducationLevel" runat="server" CssClass="dropDownList" DataSourceID="ObjectDataSource2"
                                                                DataTextField="Name" DataValueField="Id"  AppendDataBoundItems="true">
                                                                <asp:ListItem Text="" Value="0"></asp:ListItem>
                                                            </asp:DropDownList>
                                                            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}"
                                                                SelectMethod="GetAll" TypeName="HRMBLL.H2.EducationLevelsBLL"></asp:ObjectDataSource></td>                                                                        
                                                        <td style="width:20%;" align="left" valign="top">
                                                            <asp:TextBox ID="txtEducationLevelValue" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>
                                                        <td style="width:40%;" align="left" valign="top">
                                                             <asp:TextBox ID="txtRemark" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>                                                                                                                                                                                    
                                                        <td style="width:10%;" align="center" valign="middle">
                                                            <asp:ImageButton ID="imgDeleteRow" runat="server"  ImageUrl="~/Images/icon-delete.gif" OnClick="imgDeleteRow_Click" /></td>
                                                        <td style="width:10%;" align="center" valign="middle">
                                                            <asp:ImageButton ID="imgAddNewRow" runat="server"  ImageUrl="~/Images/Add.gif" OnClick="imgAddNewRow_Click" Visible="false"/></td>  
                                                    </tr>
                                                   
                                                </table>
                                            </ItemTemplate>
                                            <ItemStyle CssClass="dataList-item" />
                                            <AlternatingItemStyle CssClass="dataList-atlternating-item" />
                                        </asp:DataList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    
                                </td>
                               </tr>
                            </table>
                        
                    </fieldset>
                 </td>
             </tr>--%>
             <tr class="tdValue">
                 <td colspan="4">
                     <asp:Label ID="Label22" runat="server" CssClass="label" Visible ="false" Text="Trước khi xin vào làm việc tại Công ty đã học, làm việc ở cơ quan nào, địa chỉ"></asp:Label>
                     <br/><asp:TextBox ID="txtWorkedCompany" runat="server" Visible ="false" TextMode="MultiLine" Rows="6" Width="100%" CssClass="textBox"></asp:TextBox></td>
             </tr>
             <tr>
                <td colspan="4" class="tdButton">
                   <table style="width: 100%" >
                        <tr>
                            <td align="center">
                                 <asp:Button ID="btnUpdate" Visible="true" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click" CssClass="small color green button" Width="100px" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>   
         </table>
    </td>
 </tr> 
</table>