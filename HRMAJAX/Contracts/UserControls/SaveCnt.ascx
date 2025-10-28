<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SaveCnt.ascx.cs" Inherits="Contracts_UserControls_SaveCnt" %>

<%@ Register Src="~/UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc5" %>
<table cellpadding="0" cellspacing="0" style="width: 100%">        
        <tr>
            <td align="center">
                <asp:RadioButton ID="rdoSalary1" runat="server" CssClass="value" Text="Lương chức danh" GroupName="SalaryType" AutoPostBack="True" Checked="True" OnCheckedChanged="rdoSalary1_CheckedChanged"/>
                <asp:RadioButton ID="rdoSalary2" runat="server" CssClass="value" Text="Lương khoán" GroupName="SalaryType" OnCheckedChanged="rdoSalary2_CheckedChanged" AutoPostBack="True"/></td>
        </tr>
         <asp:Panel ID="pnEmployeeInfor" runat="server" Visible="false">
        <tr>
            <td valign="top">
               <table style="width: 100%" class="tableBorder">
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label1" runat="server" Text="Họ và tên" CssClass="label"></asp:Label></td>
                        <td class="tdValue" >
                            <asp:Label ID="lbFullName" runat="server" CssClass="value"></asp:Label></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label4" runat="server" Text="Mã NV" CssClass="label"></asp:Label></td>
                        <td class="tdValue"><asp:Label ID="lbEmployeeCode" runat="server" CssClass="value"></asp:Label></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label2" runat="server" Text="Ngày sinh" CssClass="label"></asp:Label></td>
                        <td class="tdValue"><asp:Label ID="lbBirthday" runat="server" CssClass="value"></asp:Label></td>
                    </tr>
                </table>
            </td>
        </tr>
        </asp:Panel>
        <tr>
            <td>
                <table style="width: 100%" class="tableBorder">
                    <tr>
                        <td colspan="4" class="form-title" align="left">
                            THÔNG TIN BÊN SỬ DỤNG LAO ĐỘNG</td>
                    </tr>
                    <tr>
                        <td class="tdLabel" style="width:20%">
                            <asp:Label ID="Label3" runat="server" CssClass="label" Text="Số hợp đồng"></asp:Label></td>
                        <td class="tdValue" style="width:30%">
                            <asp:TextBox ID="txtContractNo" runat="server" CssClass="textBox" Width="98%" ReadOnly="True"></asp:TextBox></td>
                        <td class="tdLabel" style="width:15%">
                            <asp:Label ID="Label5" runat="server" CssClass="label" Text="Loại hợp đồng"></asp:Label></td>
                        <td class="tdValue" style="width:35%">
                            <asp:DropDownList ID="ddlContractType" runat="server" CssClass="dropDownList">
                            </asp:DropDownList></td>
                    </tr>    
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label6" runat="server" CssClass="label" Text="Đơn vị sử dụng LĐ"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtCompanyName" runat="server" CssClass="textBox" Width="98%"></asp:TextBox></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label7" runat="server" CssClass="label" Text="Người Đại Diện"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtRepresentativeOfCompany" runat="server" CssClass="textBox" Width="98%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label8" runat="server" CssClass="label" Text="Tên hợp đồng"></asp:Label></td>
                        <td class="tdValue" colspan="3">
                            <asp:TextBox ID="txtContractName" runat="server" CssClass="textBox" Width="98%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label29" runat="server" CssClass="label" Text="Ghi chú"></asp:Label></td>
                        <td class="tdValue" colspan="3">
                            <asp:TextBox ID="txtDescription" runat="server" CssClass="textBox" Width="98%"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td colspan="4" class="form-title" align="left">
                            THÔNG TIN BÊN NGƯỜI LAO ĐỘNG</td>
                    </tr>
                     <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label11" runat="server" CssClass="label" Text="Người lao động"></asp:Label></td>
                        <td class="tdValue">
                            <asp:Label ID="lbEmployeeFullName" runat="server" CssClass="value"></asp:Label></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label12" runat="server" CssClass="label" Text="Tập tin lưu trữ"></asp:Label></td>
                        <td class="tdValue">
                            <asp:FileUpload ID="fuAttachFileName" runat="server" CssClass="textBox"/></td>
                    </tr>    
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label34" runat="server" CssClass="label" Text="Ngày bắt đầu"></asp:Label></td>
                        <td class="tdValue">
                            <uc5:CalendarPicker ID="cpFromDate" runat="server" />
                            <asp:ImageButton ID="imgGetToDateContract" runat="server" ImageUrl="~/Images/Enter.gif" OnClick="imgGetToDateContract_Click" />
                        </td>
                        <td class="tdLabel">
                            <asp:Label ID="Label14" runat="server" CssClass="label" Text="Ngày kết thúc"></asp:Label></td>
                        <td class="tdValue">
                            <uc5:CalendarPicker ID="cpToDate" runat="server" />
                            <asp:Label ID="lbToDate" runat="server" CssClass="value" Text="Không xác định" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label24" runat="server" CssClass="label" Text="Đơn giá"></asp:Label></td>
                        <td class="tdValue" colspan="3">
                            <asp:TextBox ID="txtContractWages" runat="server" CssClass="textBox" Width="100px"></asp:TextBox><asp:DropDownList
                                ID="ddlContractUnit" runat="server" CssClass="dropDownList">
                                <asp:ListItem Value="0" Text=""></asp:ListItem>
                                <asp:ListItem Value="1">đ/ng&#224;y</asp:ListItem>
                                <asp:ListItem Value="2">%</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label27" runat="server" CssClass="error-Text" Text="* (Nhập đơn giá khi không có hệ số đính kèm)"></asp:Label></td>
                    </tr>
                     <tr>
                        <td colspan="4" class="form-title" align="left">
                           ĐIỀU KHOẢN HỢP ĐỒNG</td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label16" runat="server" CssClass="label" Text="Vị trí làm việc"></asp:Label></td>
                        <td class="tdValue"><asp:DropDownList ID="ddlPositions" runat="server" CssClass="dropDownList">
                        </asp:DropDownList></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label17" runat="server" CssClass="label" Text="Công việc phải làm"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtWorkingName" runat="server" CssClass="textBox" Width="98%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label35" runat="server" CssClass="label" Text="Giờ làm chính thức"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtWorkingHour" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                            <asp:Label ID="Label18" runat="server" CssClass="label" Text="giờ/tuần"></asp:Label></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label36" runat="server" CssClass="label" Text="Giờ làm thêm"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtOvertime" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                            <asp:Label ID="Label37" runat="server" CssClass="label" Text="giờ/ngày"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="4" class="form-title" align="left">
                            HỆ SỐ LNS ĐÍNH KÈM</td>
                    </tr>
                    <asp:Panel ID="pnSalary1" runat="server" Visible="false">
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label20" runat="server" CssClass="label" Text="Chức danh hệ số"></asp:Label></td>
                        <td class="tdValue"><asp:DropDownList ID="ddlCoefficientNamesLNS" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlCoefficientNamesLNS_SelectedIndexChanged" Width="95%" AppendDataBoundItems="true">
                        <asp:ListItem Value="0" Text=""></asp:ListItem>
                        </asp:DropDownList></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label21" runat="server" CssClass="label" Text="Mức/hưởng"></asp:Label></td>
                        <td class="tdValue">
                            <asp:DropDownList ID="ddlLevelsLNS" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLevelsLNS_SelectedIndexChanged" CssClass="dropDownList" Width="60px"></asp:DropDownList>
                            <asp:Label ID="lbValueLNS" runat="server" CssClass="value"></asp:Label>
                            <asp:TextBox ID="txtWageLNS" runat="server" CssClass="textBox" Width="30px"></asp:TextBox><asp:DropDownList ID="ddlUnitLNS" runat="server" CssClass="dropDownList" Width="40px">
                                <asp:ListItem Value="1">đ/ng&#224;y</asp:ListItem>
                                <asp:ListItem Value="2" Selected="True">%</asp:ListItem>
                                <asp:ListItem Value="3">đ/tháng</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label22" runat="server" CssClass="label" Text="PCTN LNS"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtPCTNLNS" runat="server" CssClass="textBox" Width="98%"></asp:TextBox></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label23" runat="server" CssClass="label" Text="Ngày áp dụng"></asp:Label></td>
                        <td class="tdValue">
                            <uc5:CalendarPicker ID="cpCreateDateLNS" runat="server" />
                        </td>
                    </tr>
                    </asp:Panel>
                    <asp:Panel ID="pnSalary2" runat="server" Visible="false">
                   <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label10" runat="server" CssClass="label" Text="Lương khoán"></asp:Label></td>
                        <td class="tdValue" ><asp:DropDownList ID="ddlCoefficientNamesLNS2" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlCoefficientNamesLNS2_SelectedIndexChanged" Width="150px" AppendDataBoundItems="true">
                        <asp:ListItem Value="0" Text=""></asp:ListItem>
                        </asp:DropDownList></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label9" runat="server" CssClass="label" Text="Mức"></asp:Label></td>
                        <td class="tdValue">
                            <asp:DropDownList ID="ddlLevelsLNS2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLevelsLNS2_SelectedIndexChanged" CssClass="dropDownList" Width="60px"></asp:DropDownList>
                            <asp:Label ID="lbValueLNS2" runat="server" CssClass="value"></asp:Label>
                            <asp:TextBox ID="txtWageLNS2" runat="server" CssClass="textBox" Width="30px"></asp:TextBox><asp:DropDownList ID="ddlUnitLNS2" runat="server" CssClass="dropDownList" Width="40px">
                                <asp:ListItem Value="1">đ/ng&#224;y</asp:ListItem>                                
                                <asp:ListItem Value="2" Selected="True">%</asp:ListItem>
                                <asp:ListItem Value="3">đ/tháng</asp:ListItem>
                            </asp:DropDownList></td>
                            
                     </tr>
                      <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label15" runat="server" CssClass="label" Text="PCTN Khoán"></asp:Label></td>
                        <td class="tdValue" colspan="3">
                            <asp:TextBox ID="txtPCTNKhoan" runat="server" CssClass="textBox" Width="50%"></asp:TextBox> &nbsp;<asp:Label ID="Label19" runat="server" CssClass="label" Text="(đồng/tháng)"></asp:Label></td>
                    </tr>       
                    </asp:Panel>
                    
                    <tr>
                        <td colspan="4" class="form-title" align="left">HỆ SỐ LCB ĐÍNH KÈM</td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label25" runat="server" CssClass="label" Text="Chức danh hệ số"></asp:Label></td>
                        <td class="tdValue"><asp:DropDownList ID="ddlCoefficientNamesLCB" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlCoefficientNamesLCB_SelectedIndexChanged" Width="95%" AppendDataBoundItems="true">
                        <asp:ListItem Value="0" Text=""></asp:ListItem>
                        </asp:DropDownList></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label26" runat="server" CssClass="label" Text="Mức/hưởng"></asp:Label></td>
                        <td class="tdValue"><asp:DropDownList ID="ddlLevelsLCB" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLevelsLCB_SelectedIndexChanged" CssClass="dropDownList" Width="60px">
                        </asp:DropDownList>
                            <asp:Label ID="lbValueLCB" runat="server" CssClass="value"></asp:Label><asp:Label ID="lbConditionsLCB" runat="server" CssClass="value"></asp:Label>
                            <asp:TextBox
                            ID="txtWageLCB" runat="server" CssClass="textBox" Width="30px"></asp:TextBox><asp:DropDownList ID="ddlUnitLCB" runat="server" CssClass="dropDownList" Width="40px">
                                <asp:ListItem Value="1">đ/ng&#224;y</asp:ListItem>
                                <asp:ListItem Selected="True" Value="2">%</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label13" runat="server" CssClass="label" Text="Ngày bắt đầu"></asp:Label></td>
                        <td class="tdValue">
                            <uc5:CalendarPicker ID="cpFromDateLCB" runat="server" />
                            <asp:ImageButton ID="imgGetToDateLCB" runat="server" ImageUrl="~/Images/Enter.gif" OnClick="imgGetToDateLCB_Click" />
                        </td>
                        <td class="tdLabel">
                            <asp:Label ID="Label28" runat="server" CssClass="label" Text="Ngày kết thúc"></asp:Label></td>
                        <td class="tdValue">
                            <uc5:CalendarPicker ID="cpToDateLCB" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label30" runat="server" CssClass="label" Text="PCDH"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtPCDH" runat="server" CssClass="textBox" Width="98%"></asp:TextBox></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label31" runat="server" CssClass="label" Text="PCTN"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtPCTN" runat="server" CssClass="textBox" Width="98%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label32" runat="server" CssClass="label" Text="PCCV"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtPCCV" runat="server" CssClass="textBox" Width="98%"></asp:TextBox></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label33" runat="server" CssClass="label" Text="PCKV"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtPCKV" runat="server" CssClass="textBox" Width="98%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdButton" colspan="4" align="center">
                            <asp:Button ID="btnSave" runat="server" CssClass="small color green button" Text="Lưu" Width="100px" OnClick="btnSave_Click" />
                            &nbsp;&nbsp;
                            <asp:Button ID="btnDelete" runat="server" CssClass="small color green button" Text="Xóa" Width="100px" OnClientClick="return confirm('Bạn có muốn xóa hợp đồng này không?')" OnClick="btnDelete_Click" />
                            &nbsp;
                            <asp:Button ID="btnPrint" runat="server" CssClass="small color green button" Text="In" Width="100px" OnClick="btnPrint_Click" /></td>
                    </tr>
                </table>    
            </td>
        </tr>
    </table>