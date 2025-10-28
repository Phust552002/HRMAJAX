<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SaveDcs.ascx.cs" Inherits="Decisions_UserControls_SaveDcs" %>
<%@ Register Src="../../UserControls/DatePicker.ascx" TagName="DatePicker" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc5" %>
<table cellpadding="0" cellspacing="0" style="width: 100%">        
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
                           THÔNG TIN QUYẾT ĐỊNH</td>
                    </tr>
                    <tr>
                        <td class="tdLabel" style="width:20%">
                            <asp:Label ID="Label3" runat="server" CssClass="label" Text="Quyết định số"></asp:Label></td>
                        <td class="tdValue" style="width:30%">
                            <asp:TextBox ID="txtDecisionNo" runat="server" CssClass="textBox" Width="98%" ReadOnly="True"></asp:TextBox></td>
                        <td class="tdLabel" style="width:20%">
                            <asp:Label ID="Label5" runat="server" CssClass="label" Text="Loại quyết định"></asp:Label></td>
                        <td class="tdValue" style="width:35%">
                            <asp:DropDownList ID="ddlDecisionType" runat="server" CssClass="dropDownList">
                            </asp:DropDownList></td>
                    </tr>    
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label6" runat="server" CssClass="label" Text="Đơn vị ra quyết định"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtBringOutDept" runat="server" CssClass="textBox" Width="98%"></asp:TextBox></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label7" runat="server" CssClass="label" Text="Người ký quyết định"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtSignUser" runat="server" CssClass="textBox" Width="98%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label8" runat="server" CssClass="label" Text="Tên quyết định"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtDecisionName" runat="server" CssClass="textBox" Width="98%"></asp:TextBox></td>
                        <td class="tdLabel">
                            <asp:Label ID="Label13" runat="server" CssClass="label" Text="Ngày ra quyết định"></asp:Label></td>
                        <td class="tdValue">
                            <uc5:CalendarPicker ID="cpDecisionDate" runat="server" />
                        </td>
                    </tr>
                     <tr>
                        <td colspan="4" class="form-title" align="left">
                            DANH SÁCH CÁ NHÂN CHỊU TRÁCH NHIỆM THI HÀNH QUYẾT ĐỊNH</td>
                    </tr>
                    <tr>
                        <td align="left" colspan="4">                            
                            <asp:DataList ID="dlEmployeesSelectedList" runat="server" OnItemDataBound="dlEmployeesSelectedList_ItemDataBound" Width="100%" CellPadding="0" CellSpacing="0">
                                <ItemTemplate>
                                    <table cellpadding="0" cellspacing="0" style="width: 100%; background-color:White" border="0">
                                        <tr class="dataList-header-Item">
                                            <td style="width:10%" align="center">
                                                <asp:Label ID="lbUserId" runat="server"></asp:Label></td>
                                            <td style="width:20%">
                                                <asp:Label ID="lbFullName" runat="server"></asp:Label></td>
                                            
                                            <td style="width:15%">
                                                <asp:Label ID="lbOldPosition" runat="server" ></asp:Label></td>
                                            <td style="width:15%" align="center">
                                                <asp:Label ID="lbOldFromDate" runat="server"></asp:Label></td>
                                            <td style="width:15%" align="center">
                                                <asp:DropDownList ID="ddlNewPosition" runat="server" CssClass="dropDownList" Width="100px">
                                                </asp:DropDownList></td>
                                            <td style="width:15%" align="center">
                                                <uc5:CalendarPicker ID="cpNewFromDate" runat="server" /></td>    
                                            <td style="width:10%" align="center">
                                                <asp:ImageButton ID="imgDLEmployeeSelectedDelete" runat="server" ImageUrl="~/Images/icon-delete.gif" OnClick="imgDLEmployeeSelectedDelete_Click" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="7">
                                                <table cellpadding="0" cellspacing="0" width="100%" class="tableBorder">                                                    
                                                    <tr>
                                                        <td>
                                                            <table cellpadding="2" cellspacing="2" style="width: 100%" class="tableBorder">
                                                                <tr>
                                                                    <td class="tdLabel">
                                                                        <asp:Label ID="Label11" runat="server" Text="Hệ số đính kèm" CssClass="label"></asp:Label>
                                                                    </td>
                                                                    <td align="center" class="tdValue" colspan="5">
                                                                          <asp:RadioButton ID="rdoSalary1" runat="server" AutoPostBack="True" Checked="True"
                                                                CssClass="value" GroupName="SalaryType" OnCheckedChanged="rdoSalary1_CheckedChanged"
                                                                Text="Lương chức danh" /><asp:RadioButton ID="rdoSalary2" runat="server" AutoPostBack="True"
                                                                    CssClass="value" GroupName="SalaryType" OnCheckedChanged="rdoSalary2_CheckedChanged"
                                                                    Text="Lương khoán" />
                                                                    </td>
                                                                </tr>
                                                                <asp:Panel ID="pnSalary1" runat="server" Visible="true">
                                                                <tr>
                                                                    <td class="tdLabel">
                                                                        <asp:Label ID="Label20" runat="server" CssClass="label" Text="Chức danh HSLNS"></asp:Label></td>
                                                                    <td class="tdValue"><asp:DropDownList ID="ddlCoefficientNamesLNS" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlCoefficientNamesLNS_SelectedIndexChanged" Width="100px" AppendDataBoundItems="true">
                                                                    <asp:ListItem Value="0" Text=""></asp:ListItem>
                                                                    </asp:DropDownList></td>
                                                                    <td class="tdLabel">
                                                                        <asp:Label ID="Label21" runat="server" CssClass="label" Text="Mức"></asp:Label></td>
                                                                    <td class="tdValue">
                                                                        <asp:DropDownList ID="ddlLevelsLNS" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLevelsLNS_SelectedIndexChanged" CssClass="dropDownList" Width="60px"></asp:DropDownList>
                                                                        <asp:Label ID="lbValueLNS" runat="server" CssClass="value"></asp:Label>
                                                                        <asp:TextBox ID="txtWageLNS" runat="server" CssClass="textBox" Width="30px"></asp:TextBox><asp:DropDownList ID="ddlUnitLNS" runat="server" CssClass="dropDownList" Width="40px">
                                                                            <asp:ListItem Value="1">đ/ng&#224;y</asp:ListItem>
                                                                            <asp:ListItem Value="2" Selected="True">%</asp:ListItem>
                                                                        </asp:DropDownList></td>
                                                                    <td class="tdLabel">
                                                                    <asp:Label ID="Label9" runat="server" CssClass="label" Text="PCTN LNS"></asp:Label></td>
                                                                    <td class="tdValue">
                                                                        <asp:TextBox ID="txtPCTNLNS" runat="server" CssClass="textBox" Width="50px"></asp:TextBox></td>
                                                                 </tr>                                                                         
                                                                </asp:Panel>
                                                                <asp:Panel ID="pnSalary2" runat="server" Visible="false">
                                                                <tr>
                                                                    <td class="tdLabel">
                                                                        <asp:Label ID="Label10" runat="server" CssClass="label" Text="Lương khoán"></asp:Label></td>
                                                                    <td class="tdValue" colspan="3"><asp:DropDownList ID="ddlCoefficientNamesLNS2" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlCoefficientNamesLNS2_SelectedIndexChanged" Width="150px" AppendDataBoundItems="true">
                                                                    <asp:ListItem Value="0" Text=""></asp:ListItem>
                                                                    </asp:DropDownList></td>
                                                                    <td class="tdLabel">
                                                                        <asp:Label ID="Label12" runat="server" CssClass="label" Text="Mức"></asp:Label></td>
                                                                    <td class="tdValue">
                                                                        <asp:DropDownList ID="ddlLevelsLNS2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLevelsLNS2_SelectedIndexChanged" CssClass="dropDownList" Width="60px"></asp:DropDownList>
                                                                        <asp:Label ID="lbValueLNS2" runat="server" CssClass="value"></asp:Label>
                                                                        <asp:DropDownList ID="ddlUnitLNS2" runat="server" CssClass="dropDownList" Width="100px">
                                                                            <asp:ListItem Value="3" Selected="True">đ/tháng</asp:ListItem>
                                                                            <asp:ListItem Value="2">%</asp:ListItem>
                                                                        </asp:DropDownList></td>
                                                                        
                                                                 </tr>        
                                                                </asp:Panel>
                                                            </table>
                                                        </td>
                                                    </tr> 
                                                     <tr>
                                                        <td>
                                                            <table cellpadding="2" cellspacing="2" width="100%"  class="tableBorder">
                                                                <tr>
                                                                    <td class="tdLabel">
                                                                        <asp:Label ID="Label25" runat="server" CssClass="label" Text="Chức danh HSLCB"></asp:Label></td>
                                                                    <td class="tdValue"><asp:DropDownList ID="ddlCoefficientNamesLCB" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlCoefficientNamesLCB_SelectedIndexChanged"  AppendDataBoundItems="true" Width="100px">
                                                                    <asp:ListItem Value="0" Text=""></asp:ListItem>
                                                                    </asp:DropDownList></td>
                                                                    <td class="tdLabel">
                                                                        <asp:Label ID="Label26" runat="server" CssClass="label" Text="Hưởng"></asp:Label></td>
                                                                    <td class="tdValue"><asp:DropDownList ID="ddlLevelsLCB" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLevelsLCB_SelectedIndexChanged" CssClass="dropDownList" Width="60px">
                                                                    </asp:DropDownList>
                                                                        <asp:Label ID="lbValueLCB" runat="server" CssClass="value"></asp:Label><asp:Label ID="lbConditionsLCB" runat="server" CssClass="value"></asp:Label>
                                                                        <asp:TextBox
                                                                        ID="txtWageLCB" runat="server" CssClass="textBox" Width="30px"></asp:TextBox><asp:DropDownList ID="ddlUnitLCB" runat="server" CssClass="dropDownList" Width="40px">
                                                                            <asp:ListItem Value="1">đ/ng&#224;y</asp:ListItem>
                                                                            <asp:ListItem Selected="True" Value="2">%</asp:ListItem>
                                                                        </asp:DropDownList></td>
                                                                    <td class="tdLabel">
                                                                        <asp:Label ID="Label13" runat="server" CssClass="label" Text="Từ ngày"></asp:Label></td>
                                                                    <td class="tdValue">
                                                                        <uc5:CalendarPicker ID="cpFromDateLCB" runat="server" />
                                                                        <asp:ImageButton ID="imgGetToDateLCB" runat="server" ImageUrl="~/Images/Enter.gif" OnClick="imgGetToDateLCB_Click" /></td>
                                                                    <td class="tdLabel">
                                                                        <asp:Label ID="Label28" runat="server" CssClass="label" Text="Đến ngày"></asp:Label></td>
                                                                    <td class="tdValue">
                                                                        <uc5:CalendarPicker ID="cpToDateLCB" runat="server" />
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="tdLabel">
                                                                        <asp:Label ID="Label30" runat="server" CssClass="label" Text="PCDH"></asp:Label></td>
                                                                    <td class="tdValue">                                                                        
                                                                        <asp:TextBox ID="txtPCDH" runat="server" CssClass="textBox" Width="50px"></asp:TextBox></td>
                                                                    <td class="tdLabel">
                                                                        <asp:Label ID="Label31" runat="server" CssClass="label" Text="PCTN"></asp:Label></td>
                                                                    <td class="tdValue">
                                                                        <asp:TextBox ID="txtPCTN" runat="server" CssClass="textBox" Width="50px"></asp:TextBox></td>
                                                                    <td class="tdLabel">
                                                                        <asp:Label ID="Label32" runat="server" CssClass="label" Text="PCCV"></asp:Label></td>
                                                                    <td class="tdValue">
                                                                        <asp:TextBox ID="txtPCCV" runat="server" CssClass="textBox" Width="50px"></asp:TextBox></td>
                                                                    <td class="tdLabel">
                                                                        <asp:Label ID="Label33" runat="server" CssClass="label" Text="PCKV"></asp:Label></td>
                                                                    <td class="tdValue">
                                                                        <asp:TextBox ID="txtPCKV" runat="server" CssClass="textBox" Width="50px"></asp:TextBox></td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>    
                                                </table>
                                            </td>
                                        </tr>
                                                                                                                                                             
                                    </table>
                                </ItemTemplate>
                                <HeaderTemplate>
                                    <table cellpadding="2" cellspacing="2" style="width: 100%" border="0">                                        
                                        <tr>
                                            <td style="width:10%">
                                                Mã NV</td>
                                            <td style="width:20%">
                                                Họ Tên</td>
                                            <td style="width:15%">
                                                Vị trí công tác củ</td>
                                            <td style="width:15%">
                                                Ngày</td>
                                            <td style="width:15%">
                                                Vị trí công tác mới    
                                            </td>
                                            <td style="width:15%">
                                                Ngày                                                    
                                            </td>
                                            <td style="width:10%">
                                                Xóa
                                            </td>
                                        </tr>
                                    </table>
                                </HeaderTemplate>
                                <HeaderStyle CssClass="dataList-header" />
                                <ItemStyle CssClass="dataList-LastDetail-item" /> 
                                <AlternatingItemStyle CssClass="dataList-Detail-atlternating-item" /> 
                            </asp:DataList></td>
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