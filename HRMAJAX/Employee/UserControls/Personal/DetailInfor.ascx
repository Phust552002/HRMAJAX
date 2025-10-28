<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DetailInfor.ascx.cs" Inherits="Employee_UserControls_Personal_DetailInfor"  %>
<%@ Register Src="../../../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc2" %>
<%@ Register Src="../../../UserControls/ucMessageError.ascx" TagName="ucMessageError" TagPrefix="uc1" %>
<%@ Register Src="~/Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"
    TagPrefix="uc3" %>

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
                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Họ và tên khai sinh"></asp:Label></td>
                <td class="tdValue" colspan="3">
                    <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox" Width="250px" ></asp:TextBox></td>
              </tr>
              <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label2" runat="server" CssClass="label" Text="Các tên gọi khác"></asp:Label></td>
                <td class="tdValue">
                    <asp:TextBox ID="txtOtherNames" runat="server" CssClass="textBox" Width="100%" ></asp:TextBox></td>
                <td class="tdLabel">
                    <asp:Label ID="Label8" runat="server" CssClass="label" Text="Tên thường dùng"></asp:Label></td>
                <td class="tdValue">
                    <asp:TextBox ID="txtNormalNames" runat="server" CssClass="textBox" Width="100%" ></asp:TextBox></td>
              </tr>       
              <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label4" runat="server" CssClass="label" Text="Giới tính"></asp:Label></td>
                <td class="tdValue">
                    <asp:RadioButton ID="rdoMale" runat="server" CssClass="value" GroupName="groupSex"
                        Text="Nam" /><asp:RadioButton ID="rdoFemale" runat="server" CssClass="value" GroupName="groupSex"
                            Text="Nữ" /></td>
                <td class="tdLabel">
                    <asp:Label ID="Label3" runat="server" CssClass="label" Text="Sinh ngày"></asp:Label></td>
                <td class="tdValue">
                    <uc2:CalendarPicker ID="cpBirthDay" runat="server" />
                </td>
              </tr>       
             <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label5" runat="server" CssClass="label" Text="Nơi sinh"></asp:Label></td>
                 <td class="tdValue" colspan="3">
                     <asp:TextBox ID="txtBirthPlace" runat="server" CssClass="textBox"  Width="100%"></asp:TextBox></td>
             </tr>
             <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label6" runat="server" CssClass="label" Text="Quê quán"></asp:Label></td>
                 <td class="tdValue" colspan="3">
                     <asp:TextBox ID="txtNativePlaceVneid" runat="server" CssClass="textBox"  Width="100%"></asp:TextBox></td>
             </tr>
             <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label7" runat="server" CssClass="label" Text="Hộ khẩu thường trú"></asp:Label>
                </td>
                <td class="tdValue"  colspan="3"  style="position: relative;">
                     <table style="width:100%; border-spacing:0;">
                        <tr class="resident-row">
                            <td style="width:34%; padding-right:5px;">
                                <asp:TextBox ID="txtResidentStreet" runat="server" CssClass="textBox" Width="100%" placeholder="Nhập địa chỉ..." />
                            </td>
                            <td class="tdLabel">
                                <asp:Label ID="Label23" runat="server" CssClass="label" Text="Tỉnh/ Thành phố"></asp:Label></td>
                            <td style="width:auto; padding-right:5px;">
                                <telerik:RadComboBox ID="ddlResidentCity" runat="server" Width="100%"  Height="100%"
                                    AutoPostBack="true" OnSelectedIndexChanged="ddlResidentCity_SelectedIndexChanged"
                                    EmptyMessage="Nhập để tìm..."
                                    Filter="Contains"
                                    MarkFirstMatch="true" style="font-size: 13px; color: #333; box-sizing: border-box;">
                                </telerik:RadComboBox>
                            </td>
                            <td class="tdLabel">
                                <asp:Label ID="Label24" runat="server" CssClass="label" Text="Phường/ Xã"></asp:Label></td>
                            <td style="width:auto;">
                                <telerik:RadComboBox ID="ddlResidentWard" runat="server" Width="100%" EmptyMessage="Chọn Phường/Xã" Filter="Contains" MarkFirstMatch="true">
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                    </table>
                </td>
             </tr>
            <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label9" runat="server" CssClass="label" Text="Nơi ở hiện nay"></asp:Label></td>
                 <td class="tdValue" colspan="3"  style="position: relative;">
                    <table style="width:100%; border-spacing:0;">
                         <tr class="resident-row">
                            <td style="width:34%; padding-right:5px;">
                                <asp:TextBox ID="txtLiveStreet" runat="server" CssClass="textBox" Width="100%" placeholder="Nhập địa chỉ..." />
                            </td>
                            <td class="tdLabel">
                                <asp:Label ID="Label30" runat="server" CssClass="label" Text="Tỉnh/ Thành phố"></asp:Label></td>
                            <td style="width:auto; padding-right:5px;">
                                <telerik:RadComboBox ID="ddlLiveCity" runat="server" Width="100%"  MaxHeight="200px"
                                  AutoPostBack="true" OnSelectedIndexChanged="ddlLiveCity_SelectedIndexChanged"
                                  EmptyMessage="Nhập để tìm..."
                                  Filter="Contains"
                                  MarkFirstMatch="true" style="font-size: 13px; color: #333; box-sizing: border-box;">
                                </telerik:RadComboBox>
                            </td>
                            <td class="tdLabel">
                                <asp:Label ID="Label28" runat="server" CssClass="label" Text="Phường/ Xã"></asp:Label></td>
                            <td style="width:auto;">
                                <telerik:RadComboBox ID="ddlLiveWard" runat="server" Width="100%" EmptyMessage="Chọn Phường/Xã" Filter="Contains" MarkFirstMatch="true"></telerik:RadComboBox>
                            </td>
                        </tr>
                    </table>
                 </td>
<%--                <td class="tdLabel">
                     <asp:Label ID="Label9" runat="server" CssClass="label" Text="Nơi ở hiện nay"></asp:Label></td>
                    <td class="tdValue" colspan="3"  style="position: relative;">
                     <asp:TextBox ID="txtLive" runat="server" CssClass="textBox" Enabled="false"  Width="95%"></asp:TextBox>
                    </td>--%>
             </tr>
             <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label27" runat="server" CssClass="label" Text="Điện thoại di động"></asp:Label></td>
                 <td class="tdValue">
                     <asp:TextBox ID="txtHandPhone" runat="server" CssClass="textBox" Width="150px"></asp:TextBox></td>
                 <td class="tdLabel">
                     <asp:Label ID="Label29" runat="server" CssClass="label" Text="Điện thoại nhà"></asp:Label></td>
                 <td class="tdValue">
                     <asp:TextBox ID="txtHomePhone" runat="server" CssClass="textBox" Width="150px"></asp:TextBox></td>
             </tr>
            
             <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label10" runat="server" CssClass="label" Text="Số CMND"></asp:Label></td>
                <td class="tdValue">
                    <asp:TextBox ID="txtIdCard" runat="server" CssClass="textBox" ></asp:TextBox></td>
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
                 <td class="tdLabel">
                        <asp:Label ID="Label15" runat="server" CssClass="label" Text="Dân tộc"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtNation" runat="server" CssClass="textBox" ></asp:TextBox></td>    
             </tr>     
             <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label13" runat="server" CssClass="label" Text="Quốc tịch"></asp:Label></td>
                <td class="tdValue">
                    <asp:TextBox ID="txtNationality" runat="server" CssClass="textBox" ></asp:TextBox></td>
                <td class="tdLabel">
                    <asp:Label ID="Label14" runat="server" CssClass="label" Text="Tôn giáo"></asp:Label></td>
                <td class="tdValue">
                    <asp:TextBox ID="txtReligion" runat="server" CssClass="textBox" ></asp:TextBox></td>
              </tr>
              <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label16" runat="server" CssClass="label" Text="Thành phần gia đình xuất thân"></asp:Label></td>
                 <td class="tdValue" colspan="3">
                     <asp:TextBox ID="txtOrigin" runat="server" CssClass="textBox"  Width="100%"></asp:TextBox></td>
             </tr> 
             <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label17" runat="server" CssClass="label" Text="Ngày vào Đảng"></asp:Label></td>
                <td class="tdValue">
                    <uc2:CalendarPicker ID="cpDateJoinParty" runat="server" />
                </td>
                <td class="tdLabel">
                    <asp:Label ID="Label18" runat="server" CssClass="label" Text="Nơi vào Đảng"></asp:Label></td>
                <td class="tdValue">
                    <asp:TextBox ID="txtPlaceJoinParty" runat="server" CssClass="textBox"  Width="100%" ></asp:TextBox></td>
             </tr>
             <tr>
                 <td class="tdLabel">
                     <asp:Label ID="Label25" runat="server" CssClass="label" Text="Ngày vào Đoàn"></asp:Label></td>
                 <td class="tdValue">
                     <uc2:CalendarPicker ID="cpDateJoinCYU" runat="server" />
                 </td>
                 <td class="tdLabel">
                     <asp:Label ID="Label26" runat="server" CssClass="label" Text="Nơi vào Đoàn"></asp:Label></td>
                 <td class="tdValue">
                     <asp:TextBox ID="txtPlaceJoinCYU" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
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
                 <td class="tdValue" colspan="3">
                     <asp:TextBox ID="txtArmyRank" runat="server" CssClass="textBox"  Width="100%"></asp:TextBox></td>
             </tr>
             <tr class="tdValue">
                 <td colspan="4">
                    <fieldset>
                        <legend class="label"> Trình độ văn hóa</legend>
                        
                         <table class="tableBorder" width="100%">
                             <tr>
                                <td> 
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
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
             </tr>
             <tr class="tdValue">
                 <td colspan="4">
                     <asp:Label ID="Label22" runat="server" CssClass="label" Text="Trước khi xin vào làm việc tại Công ty đã học, làm việc ở cơ quan nào, địa chỉ"></asp:Label>
                     <br/><asp:TextBox ID="txtWorkedCompany" runat="server" TextMode="MultiLine" Rows="6" Width="100%" CssClass="textBox"></asp:TextBox></td>
             </tr>
             <tr>
                <td colspan="4" class="tdButton">
                   <table style="width: 100%" >
                        <tr>
                            <td align="center">
                                 <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click" CssClass="small color green button" Width="100px" />
                            </td>
                        </tr>
                    </table>
                     <uc3:ucPermission ID="UcPermission1" runat="server" />
                </td>
            </tr>   
         </table>
    </td>
 </tr> 
</table>

<%--<telerik:RadWindowManager ID="RadWindowManager" runat="server"></telerik:RadWindowManager>
<telerik:RadWindow ID="rwEditLive" runat="server" Title="Chỉnh sửa nơi ở hiện tại"
                   VisibleOnPageLoad="false" Width="500px" Height="200px"
                   Modal="true" Behaviors="None" KeepInScreenBounds="true">
    <ContentTemplate>
     <div style="display:flex; flex-direction:column; justify-content:center; height:100%;">
        <table style="margin:0 auto;">
            <tr>
                <td>Địa chỉ:</td>
                <td><asp:TextBox ID="txtLiveStreet" runat="server" Width="300px" style="font-size: 13px; color: #333; box-sizing: border-box;"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Tỉnh/TP:</td>
                <td>
                    <telerik:RadComboBox ID="ddlLiveCity" runat="server" Width="300px"  MaxHeight="200px"
                        AutoPostBack="true" OnSelectedIndexChanged="ddlLiveCity_SelectedIndexChanged"
                        EmptyMessage="Nhập để tìm..."
                        Filter="Contains"
                        MarkFirstMatch="true" style="font-size: 13px; color: #333; box-sizing: border-box;">
                    </telerik:RadComboBox>
                </td>
            </tr>
            <tr>
                <td>Phường/Xã:</td>
                <td>
                    <telerik:RadComboBox ID="ddlLiveWard" runat="server" Width="300px"  MaxHeight="200px"
                        EmptyMessage="Nhập để tìm..."
                        Filter="Contains"
                        MarkFirstMatch="true" style="font-size: 13px; color: #333; box-sizing: border-box;">
                    </telerik:RadComboBox>
                </td>

            </tr>
            <tr>
                <td colspan="2" style="text-align:right; padding-top:10px;">
                    <asp:Button ID="btnSaveLive" runat="server" Text="Lưu" CssClass="btn"  OnClick="btnSaveLive_Click"/>
                    <asp:Button ID="btnCancelLive" runat="server" Text="Hủy" CssClass="btn" OnClick="btnCancelLive_Click" />
                </td>
            </tr>
        </table>
    </div>
</ContentTemplate>
</telerik:RadWindow>--%>
<%--<telerik:RadWindow ID="rwEditResident" runat="server" Title="Chỉnh sửa nơi cư trú"
                   VisibleOnPageLoad="false" Width="500px" Height="200px"
                   Modal="true" Behaviors="None" KeepInScreenBounds="true">
    <ContentTemplate>
     <div style="display:flex; flex-direction:column; justify-content:center; height:100%;">
        <table style="margin:0 auto;">
            <tr>
                <td>Địa chỉ:</td>
                <td><asp:TextBox ID="txtResidentStreet" runat="server" Width="300px" style="font-size: 13px; color: #333; box-sizing: border-box;"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Tỉnh/TP:</td>
                <td>
                    <telerik:RadComboBox ID="ddlResidentCity" runat="server" Width="300px"  MaxHeight="200px"
                        AutoPostBack="true" OnSelectedIndexChanged="ddlResidentCity_SelectedIndexChanged"
                        EmptyMessage="Nhập để tìm..."
                        Filter="Contains"
                        MarkFirstMatch="true" style="font-size: 13px; color: #333; box-sizing: border-box;">
                    </telerik:RadComboBox>
                </td>
            </tr>
            <tr>
                <td>Phường/Xã:</td>
                <td>
                    <telerik:RadComboBox ID="ddlResidentWard" runat="server" Width="300px"  MaxHeight="200px"
                        EmptyMessage="Nhập để tìm..."
                        Filter="Contains"
                        MarkFirstMatch="true" style="font-size: 13px; color: #333; box-sizing: border-box;">
                    </telerik:RadComboBox>
                </td>

            </tr>
            <tr>
                <td colspan="2" style="text-align:right; padding-top:10px;">
                    <asp:Button ID="btnSaveResident" runat="server" Text="Lưu" CssClass="btn"  OnClick="btnSaveResident_Click"/>
                    <asp:Button ID="btnCancelResident" runat="server" Text="Hủy" CssClass="btn" OnClick="btnCancelResident_Click"/>
                </td>
            </tr>
        </table>
    </div>
</ContentTemplate>
</telerik:RadWindow>--%>

<style>
    .resident-row .RadComboBox .rcbInputCell input {
        font-size: 10px !important;
        font-weight: 500; 
        padding: 0 0px !important;
    }

    .resident-row .RadComboBox .rcbArrowCell {
        width: 14px !important;
    }

    .resident-row .RadComboBox .rcbInner,
    .resident-row .RadComboBox .rcbInputCell {
        margin: 0 !important;
        padding: 0 !important;
        border: none !important;
    }

</style>
