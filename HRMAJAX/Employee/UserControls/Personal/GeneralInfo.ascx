<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GeneralInfo.ascx.cs" Inherits="Employee_UserControls_Personal_GeneralInfo" %>
<%@ Register Src="../../../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"
    TagPrefix="uc4" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../../../UserControls/CalendarPicker.ascx" TagName="CalendarPicker"
    TagPrefix="uc3" %>
<%@ Register Src="../../../UserControls/DatePicker.ascx" TagName="DatePicker" TagPrefix="uc2" %>
<%@ Register Src="../../../UserControls/ucMessageError.ascx" TagName="ucMessageError" TagPrefix="uc1" %>
<table style="width: 100%" class="tableBorder" cellpadding="2" cellspacing="0">
    
    <tr>
        <td valign="top" style="width:200px">
            <asp:Image ID="ImgUser" runat="server" />
        </td>
        <td valign="top">
            <table style="width: 100%" class="tableBorder">
                <tr>
                    <td class="tdLabel" colspan="2">
                        <uc1:ucMessageError ID="UcMessageError1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Mã nhân viên"></asp:Label></td>
                    <td class="tdValue">
                        <asp:Label ID="lbUserCode" runat="server" CssClass="value"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label2" runat="server" Text="Mã nhân viên SAA" CssClass="label"></asp:Label></td>
                    <td class="tdValue">
                        <asp:Label ID="lbUserCodeSAA" runat="server" CssClass="value"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label12" runat="server" Text="Mã thẻ KSAN" CssClass="label"></asp:Label></td>
                    <td class="tdValue">
                        <asp:Label ID="lbUserSecurityControl" runat="server" CssClass="value"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label6" runat="server" CssClass="label" Text="Giới tính"></asp:Label></td>
                    <td class="tdValue">
                        <asp:RadioButton ID="rdoMale" runat="server" CssClass="value" GroupName="groupSex"
                            Text="Nam" /><asp:RadioButton ID="rdoFemale" runat="server" CssClass="value" GroupName="groupSex"
                                Text="Nữ" /></td>
                </tr>
                
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label10" runat="server" CssClass="label" Text="Trình trạng hôn nhân"></asp:Label></td>
                    <td class="tdValue">
                        <asp:CheckBox ID="chkMarriageStatus" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label9" runat="server" CssClass="label" Text="Ngày vào ngành hàng không"></asp:Label></td>
                    <td class="tdValue">
                        <uc3:CalendarPicker id="cpJoinAviationDate" runat="server">
                        </uc3:CalendarPicker>
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Ngày vào công ty"></asp:Label></td>
                    <td class="tdValue">
                        <uc3:CalendarPicker ID="cpJoinCompanyDate" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Điện thoại làm việc"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtWorkingPhone" runat="server" CssClass="textBox" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label15" runat="server" CssClass="label" Text="Email làm việc"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtBusinessEmail" runat="server" CssClass="textBox" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label11" runat="server" CssClass="label" Text="Mã số thuế cá nhân"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtTaxCode" runat="server" CssClass="textBox" Width="250px"></asp:TextBox>
                        <asp:HyperLink Text="Tra cứu thông tin" NavigateUrl="http://tracuunnt.gdt.gov.vn/tcnnt/mstcn.jsp" runat="server" CssClass="hyperlink-Grid"></asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label14" runat="server" CssClass="label" Text="Số bảo hiểm xã hội"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtSocialInsuranceNo" runat="server" CssClass="textBox" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label13" runat="server" CssClass="label" Text="Số bảo hiểm y tế"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtHealthInsuranceCardNo" runat="server" CssClass="textBox" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label18" runat="server" CssClass="label" Text="Nghỉ việc"></asp:Label></td>
                    <td class="tdValue">
                        <asp:CheckBox ID="chkLeave" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Ngày nghỉ việc"></asp:Label></td>
                    <td class="tdValue">
                        <uc3:CalendarPicker ID="cpLeaveDate" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label7" runat="server" CssClass="label" Text="Đường dẫn ảnh"></asp:Label></td>
                    <td class="tdValue">
                        <asp:FileUpload ID="fuImageFile" runat="server" CssClass="textBox"/></td>
                </tr>
                
            </table>
        </td>
    </tr>
    <tr>
        <td colspan="2">
        <table style="width: 100%" >
                <tr>
                    <td align="center">
                         <asp:Button ID="btnDeactive" runat="server" Text="Vô hiệu hóa tài khoản" OnClick="btnDeactive_Click" OnClientClick="return confirm('Bạn có chắc muốn vô hiệu hóa tài khoản này không?');"/></td>
                </tr>
            </table>
            <uc4:ucPermission ID="UcPermission2" runat="server" />
            </td>
    </tr>
    <tr>
        <td valign="top" colspan="2">
             <fieldset>
                        <legend class="label"> Trình độ văn hóa</legend>
                        
                         <table class="tableBorder" width="100%">
                             <tr>
                                <td> 
                                    <asp:GridView ID="grdEducation" runat="server" AutoGenerateColumns="False" CssClass="grid-Border" Width="100%" OnRowDataBound="grdEducation_RowDataBound">
                            <Columns>
                                <asp:TemplateField HeaderText="Tr&#236;nh độ" SortExpression="PositionName">
                                    <ItemTemplate>
                                        <asp:Label ID="lbEducationLevel" runat="server" ></asp:Label>  
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" Width="40%"/>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Gi&#225; trị" SortExpression="ContractTypeName">
                                    <ItemTemplate>
                                        <asp:Label ID="lbEducationLevelValue" runat="server" ></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" Width="30%"/>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ghi ch&#250;" SortExpression="Wages">
                                    <ItemTemplate>
                                        <asp:Label ID="lbRemark" runat="server"></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" Width="30%"/>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                            </Columns>
                                 <HeaderStyle CssClass="grid-header" /> 
                                <RowStyle CssClass ="grid-item" />
                                <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                <PagerStyle CssClass="grid-paper" />  
                            <EmptyDataTemplate>
                                <asp:Label ID="Label8" runat="server" CssClass="value" Text="Chưa có thông tin hợp đồng về nhân viên này."></asp:Label>
                            </EmptyDataTemplate>
                        </asp:GridView>
                                </td>
                               </tr>
                            </table>
                        
                    </fieldset>
        </td>
    </tr>
     <tr class="tdValue">
         <td colspan="2">
             <asp:Label ID="Label22" runat="server" CssClass="label" Text="Trước khi xin vào làm việc tại Công ty đã học, làm việc ở cơ quan nào, địa chỉ"></asp:Label>
             <br/><asp:TextBox ID="txtWorkedCompany" runat="server" TextMode="MultiLine" Rows="6" Width="100%" CssClass="textBox" Enabled="false"></asp:TextBox></td>
     </tr>
    <tr>
        <td colspan="2" class="tdButton">
            <table style="width: 100%" >
                <tr>
                    <td align="center">
                         <asp:Button ID="btnAdd" runat="server" Text="Cập nhật" OnClick="btnAdd_Click" CssClass="small color green button" Width="100px" /></td>
                </tr>
            </table>
            <uc4:ucPermission ID="UcPermission1" runat="server" />
        </td>
    </tr>
</table>
