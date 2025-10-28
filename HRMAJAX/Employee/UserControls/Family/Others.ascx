<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Others.ascx.cs" Inherits="Employee_UserControls_Family_Others" %>
<%@ Register Src="../../../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc2" %>
<%@ Register Src="../../../UserControls/ucMessageError.ascx" TagName="ucMessageError" TagPrefix="uc1" %>

 
 <table style="width: 100%">   
    <tr>
        <td valign="top" align="right">
            <asp:CheckBox ID="chkHide" runat="server" Text="Thêm mới" CssClass="value" OnCheckedChanged="chkHide_CheckedChanged" AutoPostBack="True"/><br/>
            <asp:Panel ID="pnAdd" runat="server" Width="100%" Visible="false">                            
                <fieldset>
                    <legend class="legend">Thêm mới</legend>                               
                     <table width="100%" class="tableBorder">
                         <tr>
                             <td class="tdLabel" colspan="4">
                                 <uc1:ucMessageError ID="UcMessageError1" runat="server" />
                             </td>
                         </tr>
                          <tr>
                            <td class="tdLabel">
                                <asp:DropDownList ID="ddlRelationType" runat="server" CssClass="dropDownList" DataSourceID="odsRType" DataTextField="RelationTypeName" DataValueField="RelationTypeId">
                                </asp:DropDownList>
                                <asp:Label ID="Label2" runat="server" CssClass="label" Text="tên"></asp:Label>
                                <asp:ObjectDataSource ID="odsRType" runat="server" SelectMethod="GetByFilter"
                                    TypeName="HRMBLL.H0.RelationTypesBLL" OldValuesParameterFormatString="original_{0}">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="" Name="relationTypeName" Type="String" />
                                        <asp:Parameter DefaultValue="4" Name="type" Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtRFullName" runat="server" CssClass="textBox" Width="200px" ></asp:TextBox></td>
                            <td class="tdLabel">
                                <asp:Label ID="Label3" runat="server" CssClass="label" Text="Sinh ngày"></asp:Label></td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtRDayOfBirth" runat="server" MaxLength="2" Width="20px" CssClass="textBox"></asp:TextBox><asp:TextBox ID="txtMonthOfBirth" runat="server" MaxLength="2" Width="20px" CssClass="textBox"></asp:TextBox><asp:TextBox ID="txtRYearOfBirth" runat="server" MaxLength="4" Width="50px" CssClass="textBox"></asp:TextBox></td>
                          </tr>       
                         <tr>
                             <td class="tdLabel">
                                 <asp:Label ID="Label5" runat="server" CssClass="label" Text="Nơi sinh"></asp:Label></td>
                             <td class="tdValue" colspan="3">
                                 <asp:TextBox ID="txtRNativePlace" runat="server" CssClass="textBox"  Width="70%"></asp:TextBox></td>
                         </tr>
                         <tr>
                             <td class="tdLabel">
                                 <asp:Label ID="Label6" runat="server" CssClass="label" Text="Quê quán"></asp:Label></td>
                             <td class="tdValue" colspan="3">
                                 <asp:TextBox ID="txtRResident" runat="server" CssClass="textBox"  Width="70%"></asp:TextBox></td>
                         </tr>
                         <tr>
                             <td class="tdLabel">
                                 <asp:Label ID="Label9" runat="server" CssClass="label" Text="Nơi ở hiện nay"></asp:Label></td>
                             <td class="tdValue" colspan="3">
                                 <asp:TextBox ID="txtRLive" runat="server" CssClass="textBox"  Width="70%"></asp:TextBox></td>
                         </tr>
                          <tr>
                             <td class="tdLabel">
                                 <asp:Label ID="Label16" runat="server" CssClass="label" Text="Trước 1975"></asp:Label></td>
                             <td class="tdValue" colspan="3">
                                 <asp:TextBox ID="txtBefore1975" runat="server" CssClass="textBox"  Width="100%" Rows="2" TextMode="MultiLine"></asp:TextBox></td>
                         </tr> 
                         <tr>
                             <td class="tdLabel">
                                 <asp:Label ID="Label21" runat="server" CssClass="label" Text="Sau 1975"></asp:Label></td>
                             <td class="tdValue" colspan="3">
                                 <asp:TextBox ID="txtAfter1975" runat="server" CssClass="textBox"  Width="100%" Rows="2" TextMode="MultiLine"></asp:TextBox></td>
                         </tr>
                        <tr>
                            <td class="tdLabel">
                                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Thành phần tham gia"></asp:Label></td>
                            <td class="tdValue" colspan="3">
                                <asp:TextBox ID="txtParticipate" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
                        </tr>
                        
                        <tr>
                            <td class="tdLabel">
                                <asp:Label ID="Label4" runat="server" CssClass="label" Text="Chết"></asp:Label></td>
                            <td class="tdValue">
                                <asp:CheckBox ID="chkDied" runat="server" /></td>
                            <td class="tdLabel">
                                <asp:Label ID="Label8" runat="server" CssClass="label" Text="Lý do chết"></asp:Label></td>
                            <td class="tdValue"><asp:TextBox ID="txtDiedCause" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
                        </tr>
                        
                        <tr>
                            <td class="tdLabel">
                                <asp:Label ID="Label7" runat="server" CssClass="label" Text="Khác"></asp:Label></td>
                            <td class="tdLabel" colspan="3">
                                <asp:TextBox ID="txtOthers" runat="server" CssClass="textBox" Rows="2" TextMode="MultiLine"
                                    Width="100%"></asp:TextBox></td>
                        </tr>
                         <tr>
                            <td colspan="4" class="tdButton">
                               <table style="width: 100%" >
                                    <tr>
                                        <td align="center">
                                             <asp:Button ID="btnUpdate" runat="server" Text="Lưu" OnClick="btnUpdate_Click" CssClass="small color green button" Width="100px" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>   
                     </table>                                      
                </fieldset>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td valign="top">
            <fieldset>
                <legend class="legend">Thông tin đã nhập</legend>
                <table style="width: 100%" cellpadding="0" cellspacing="0">
                    <tr>
                        <td align="center">
                            &nbsp;<asp:Label ID="Label14" runat="server" CssClass="label" Text="Thông tin của"></asp:Label>
                            <asp:DropDownList ID="ddlTypeFilter" runat="server" CssClass="dropDownList" AppendDataBoundItems="true" AutoPostBack="True" OnSelectedIndexChanged="ddlTypeFilter_SelectedIndexChanged">
                            <asp:ListItem Value="-1" Text=""></asp:ListItem>
                            </asp:DropDownList>&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table style="width: 100%" class="tableBorder">
                                <tr>
                                    <td>
                                        <asp:DataList ID="dlMyFamily" runat="server" Width="100%" OnItemDataBound="dlMyFamily_ItemDataBound" OnCancelCommand="dlMyFamily_CancelCommand" OnDeleteCommand="dlMyFamily_DeleteCommand" OnEditCommand="dlMyFamily_EditCommand" DataKeyField="UserRelationId" OnUpdateCommand="dlMyFamily_UpdateCommand">
                                            <ItemTemplate>
                                                <table width="100%" class="tableBorder">
                                                      <tr class="dataList-edit-header-item">
                                                        <td colspan="4">                                                           
                                                            <table width="100%" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td style="width:60%">
                                                                        <asp:Label ID="lbRelationType" runat="server" CssClass="dataList-edit-label"></asp:Label></td>
                                                                    <td style="width:40%" align="right">
                                                                        <asp:Label ID="lbEdit" runat="server" Text="Cập nhật" CssClass="dataList-edit-label"></asp:Label>
                                                                        <asp:ImageButton ID="imgEdit" runat="server" ImageUrl="~/Images/icon-edit.gif" CommandName="Edit"/>&nbsp;
                                                                        <asp:Label ID="lbDelete" runat="server" Text="Xóa" CssClass="dataList-edit-label"></asp:Label>
                                                                        <asp:ImageButton ID="imgDelete" runat="server" ImageUrl="~/Images/icon-delete.gif" CommandName="Delete" OnClientClick="return confirm('Bạn có muốn xóa thông tin này không?');"/>
                                                                    </td>
                                                                </tr>
                                                            </table>                                                            
                                                        </td>                                                        
                                                      </tr>                                                       
                                                      <tr>
                                                        <td class="tdLabel" style="width:30%">                                                           
                                                            <asp:Label ID="lbTen" runat="server" CssClass="label" Text="Tên"></asp:Label>
                                                        </td>
                                                        <td class="tdValue" style="width:70%" colspan="3">
                                                            <asp:Label ID="lbRFullName" runat="server" CssClass="value"></asp:Label></td>
                                                        
                                                      </tr>       
                                                     <tr>
                                                         <td class="tdLabel">
                                                             <asp:Label ID="Label5" runat="server" CssClass="label" Text="Nơi sinh"></asp:Label></td>
                                                         <td class="tdValue">
                                                            <asp:Label ID="lbRNativePlace" runat="server" CssClass="value"></asp:Label></td>
                                                         <td class="tdLabel">
                                                            <asp:Label ID="Label3" runat="server" CssClass="label" Text="Sinh ngày"></asp:Label></td>
                                                        <td class="tdValue">
                                                            <asp:Label ID="lbRBirthday" runat="server" CssClass="value"></asp:Label></td>
                                                     </tr>
                                                     <tr>
                                                         <td class="tdLabel">
                                                             <asp:Label ID="Label6" runat="server" CssClass="label" Text="Quê quán"></asp:Label></td>
                                                         <td class="tdValue" colspan="3">
                                                            <asp:Label ID="lbRResident" runat="server" CssClass="value"></asp:Label></td>
                                                     </tr>
                                                     <tr>
                                                         <td class="tdLabel">
                                                             <asp:Label ID="Label9" runat="server" CssClass="label" Text="Nơi ở hiện nay"></asp:Label></td>
                                                         <td class="tdValue" colspan="3">
                                                            <asp:Label ID="lbRLive" runat="server" CssClass="value"></asp:Label></td>                                                             
                                                     </tr>
                                                      <tr>
                                                         <td class="tdLabel">
                                                             <asp:Label ID="Label16" runat="server" CssClass="label" Text="Trước 1975"></asp:Label></td>
                                                         <td class="tdValue" colspan="3">
                                                            <asp:Label ID="lbBefore1975" runat="server" CssClass="value"></asp:Label></td>                                                             
                                                     </tr> 
                                                     <tr>
                                                         <td class="tdLabel">
                                                             <asp:Label ID="Label21" runat="server" CssClass="label" Text="Sau 1975"></asp:Label></td>
                                                         <td class="tdValue" colspan="3">
                                                             <asp:Label ID="lbAfter1975" runat="server" CssClass="value"></asp:Label></td>                                                               
                                                     </tr>
                                                    <tr>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label1" runat="server" CssClass="label" Text="Thành phần tham gia"></asp:Label></td>
                                                        <td class="tdValue" colspan="3">
                                                            <asp:Label ID="lbParticipate" runat="server" CssClass="value"></asp:Label></td>  
                                                            
                                                    </tr>
                                                    <asp:Panel ID="pnDied" runat="server" Width="100%" Visible="false">
                                                    <tr>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label4" runat="server" CssClass="label" Text="Chết"></asp:Label></td>
                                                        <td class="tdValue">
                                                            <asp:CheckBox ID="chkDied" runat="server" Enabled="false"/></td>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label8" runat="server" CssClass="label" Text="Lý do chết"></asp:Label></td>
                                                        <td class="tdValue">
                                                            <asp:Label ID="lbDiedCause" runat="server" CssClass="value"></asp:Label></td>                                                              
                                                    </tr>
                                                    </asp:Panel>
                                                    <tr>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label7" runat="server" CssClass="label" Text="Khác"></asp:Label></td>
                                                        <td class="tdValue" colspan="3">                                                            
                                                            <asp:Label ID="lbOthers" runat="server" CssClass="value"></asp:Label></td>  
                                                    </tr>
                                                    
                                                 </table>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <table width="100%" class="tableBorder"> 
                                                      <tr class="dataList-edit-header-item">
                                                        <td colspan="4">                                                           
                                                            <table width="100%" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td style="width:60%">
                                                                        <asp:Label ID="lbRelationType" runat="server" CssClass="dataList-edit-label"></asp:Label></td>
                                                                    <td style="width:40%" align="right">
                                                                        <asp:Label ID="Label10" runat="server" Text="Lưu" CssClass="dataList-edit-label"></asp:Label>
                                                                        <asp:ImageButton
                                                                            ID="ImageButton1" runat="server" ImageUrl="~/Images/icon-save.gif" CommandName="Update"/>&nbsp;&nbsp;
                                                                        <asp:Label ID="Label11" runat="server" Text="Thoát" CssClass="dataList-edit-label"></asp:Label>
                                                                        <asp:ImageButton
                                                                                ID="ImageButton2" runat="server" ImageUrl="~/Images/icon-cancel.gif" CommandName="Cancel"/>
                                                                    </td>
                                                                </tr>
                                                            </table>                                                            
                                                        </td>                                                        
                                                      </tr>                                                             
                                                      <tr>
                                                        <td class="tdLabel">
                                                            <asp:DropDownList ID="ddlRelationTypeEdit" runat="server" CssClass="dropDownList" DataSourceID="odsRType" DataTextField="RelationTypeName" DataValueField="RelationTypeId">
                                                            </asp:DropDownList>
                                                            <asp:Label ID="Label2" runat="server" CssClass="label" Text="tên"></asp:Label>
                                                            <asp:ObjectDataSource ID="odsRType" runat="server" SelectMethod="GetByFilter"
                                                                TypeName="HRMBLL.H0.RelationTypesBLL" OldValuesParameterFormatString="original_{0}">
                                                                <SelectParameters>
                                                                    <asp:Parameter DefaultValue="" Name="relationTypeName" Type="String" />
                                                                    <asp:Parameter DefaultValue="4" Name="type" Type="Int32" />
                                                                </SelectParameters>
                                                            </asp:ObjectDataSource>
                                                        </td>
                                                        <td class="tdValue">
                                                            <asp:TextBox ID="txtRFullNameEdit" runat="server" CssClass="textBox" Width="200px" ></asp:TextBox></td>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label3" runat="server" CssClass="label" Text="Sinh ngày"></asp:Label></td>
                                                        <td class="tdValue">
                                                            <asp:TextBox ID="txtRDayOfBirthEdit" runat="server" MaxLength="2" Width="20px" CssClass="textBox"></asp:TextBox><asp:TextBox ID="txtMonthOfBirthEdit" runat="server" MaxLength="2" Width="20px" CssClass="textBox"></asp:TextBox><asp:TextBox ID="txtRYearOfBirthEdit" runat="server" MaxLength="4" Width="50px" CssClass="textBox"></asp:TextBox></td>
                                                      </tr>       
                                                     <tr>
                                                         <td class="tdLabel">
                                                             <asp:Label ID="Label5" runat="server" CssClass="label" Text="Nơi sinh"></asp:Label></td>
                                                         <td class="tdValue" colspan="3">
                                                             <asp:TextBox ID="txtRNativePlaceEdit" runat="server" CssClass="textBox"  Width="70%"></asp:TextBox></td>
                                                     </tr>
                                                     <tr>
                                                         <td class="tdLabel">
                                                             <asp:Label ID="Label6" runat="server" CssClass="label" Text="Quê quán"></asp:Label></td>
                                                         <td class="tdValue" colspan="3">
                                                             <asp:TextBox ID="txtRResidentEdit" runat="server" CssClass="textBox"  Width="70%"></asp:TextBox></td>
                                                     </tr>
                                                     <tr>
                                                         <td class="tdLabel">
                                                             <asp:Label ID="Label9" runat="server" CssClass="label" Text="Nơi ở hiện nay"></asp:Label></td>
                                                         <td class="tdValue" colspan="3">
                                                             <asp:TextBox ID="txtRLiveEdit" runat="server" CssClass="textBox"  Width="70%"></asp:TextBox></td>
                                                     </tr>
                                                      <tr>
                                                         <td class="tdLabel">
                                                             <asp:Label ID="Label16" runat="server" CssClass="label" Text="Trước 1975"></asp:Label></td>
                                                         <td class="tdValue" colspan="3">
                                                             <asp:TextBox ID="txtBefore1975Edit" runat="server" CssClass="textBox"  Width="100%" Rows="2" TextMode="MultiLine"></asp:TextBox></td>
                                                     </tr> 
                                                     <tr>
                                                         <td class="tdLabel">
                                                             <asp:Label ID="Label21" runat="server" CssClass="label" Text="Sau 1975"></asp:Label></td>
                                                         <td class="tdValue" colspan="3">
                                                             <asp:TextBox ID="txtAfter1975Edit" runat="server" CssClass="textBox"  Width="100%" Rows="2" TextMode="MultiLine"></asp:TextBox></td>
                                                     </tr>
                                                    <tr>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label1" runat="server" CssClass="label" Text="Thành phần tham gia"></asp:Label></td>
                                                        <td class="tdValue" colspan="3">
                                                            <asp:TextBox ID="txtParticipateEdit" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
                                                    </tr>
                                                    <tr>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label4" runat="server" CssClass="label" Text="Chết"></asp:Label></td>
                                                        <td class="tdValue">
                                                            <asp:CheckBox ID="chkDiedEdit" runat="server" /></td>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label8" runat="server" CssClass="label" Text="Lý do chết"></asp:Label></td>
                                                        <td class="tdValue"><asp:TextBox ID="txtDiedCauseEdit" runat="server" CssClass="textBox" Width="100%"></asp:TextBox></td>
                                                    </tr>
                                                    <tr>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label7" runat="server" CssClass="label" Text="Khác"></asp:Label></td>
                                                        <td class="tdLabel" colspan="3">
                                                            <asp:TextBox ID="txtOthersEdit" runat="server" CssClass="textBox" Rows="2" TextMode="MultiLine"
                                                                Width="100%"></asp:TextBox></td>
                                                    </tr>                                                    
                                                 </table> 
                                            </EditItemTemplate>
                                        </asp:DataList></td>
                                </tr>
                            </table>            
                        </td>
                    </tr>
                </table>        
            </fieldset>
        </td>
    </tr>    
</table>