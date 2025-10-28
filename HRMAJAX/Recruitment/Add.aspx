<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Recruitment_Add" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"
    TagPrefix="uc1" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
        <tr>
            <td valign="top" >
                <table style="width: 100%">
                    <tr>
                        <td valign="top" >
                            <uc2:ucTitle ID="UcTitle1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" >
                            <fieldset>
                                <legend class="legend">Nhập Thông Tin Ứng Viên</legend>                               
                                    <table style="width: 99%;margin-top:2px; margin-left:2px; margin-right:2px;" class="tableBorder">
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label3" runat="server" CssClass="label" Text="Họ và tên lót"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:TextBox ID="txtLastName" runat="server" Width="200px" CssClass="textBox"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label11" runat="server" CssClass="label" Text="Tên"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:TextBox ID="txtFirstName" runat="server" CssClass="textBox" Width="100px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label4" runat="server" CssClass="label" Text="Ngày tháng năm sinh(dd/mm/yyyy)"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:TextBox ID="txtDay" runat="server" CssClass="textBox" Width="30px"></asp:TextBox>
                                                <asp:TextBox ID="txtMonth" runat="server" CssClass="textBox" Width="30px"></asp:TextBox>
                                                <asp:TextBox ID="txtYear" runat="server" CssClass="textBox" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Giới tính"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:RadioButton ID="rdoMale" runat="server" CssClass="value" GroupName="groupSex"
                                                    Text="Nam" /><asp:RadioButton ID="rdoFemale" runat="server" CssClass="value" GroupName="groupSex"
                                                        Text="Nữ" /></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label2" runat="server" CssClass="label" Text="Chức danh tuyển dụng"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:DropDownList ID="ddlPosition" runat="server" CssClass="dropDownList">
                                                </asp:DropDownList>&nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label5" runat="server" CssClass="label" Text="Kinh nghiệm"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:TextBox ID="txtExperience" runat="server" CssClass="textBox" TextMode="MultiLine"
                                                    Width="300px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel" style="height: 20px">
                                                <asp:Label ID="Label7" runat="server" CssClass="label" Text="Chiều cao"></asp:Label></td>
                                            <td class="tdValue" style="height: 20px">
                                                <asp:TextBox ID="txtHeight" runat="server" CssClass="textBox" Width="200px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel" style="height: 20px">
                                                <asp:Label ID="Label13" runat="server" CssClass="label" Text="Thông tin chung về sức khỏe"></asp:Label></td>
                                            <td class="tdValue" style="height: 20px">
                                                <asp:TextBox ID="txtHealth" runat="server" CssClass="textBox" Rows="3" TextMode="MultiLine"
                                                    Width="300px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label8" runat="server" CssClass="label" Text="Điện thoại nhà"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:TextBox ID="txtHomePhone" runat="server" CssClass="textBox" Width="200px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label12" runat="server" CssClass="label" Text="Điện thoại di động"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:TextBox ID="txtHandPhone" runat="server" CssClass="textBox" Width="200px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label14" runat="server" CssClass="label" Text="Email"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:TextBox ID="txtEmail" runat="server" CssClass="textBox" Width="200px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label6" runat="server" CssClass="label" Text="Tiêu chuẩn ứng tuyển"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:DropDownList ID="ddlStandards" runat="server" DataSourceID="odsStandards" DataTextField="RTypeName"
                                                    DataValueField="RTypeId" OnSelectedIndexChanged="ddlStandards_SelectedIndexChanged" AutoPostBack="True" CssClass="dropDownList">
                                                </asp:DropDownList>
                                                <asp:ObjectDataSource ID="odsStandards" runat="server" SelectMethod="GetAllCandidateType"
                                                    TypeName="HRMUtil.Constants"></asp:ObjectDataSource>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel" style="height: 21px">
                                                <asp:Label ID="Label9" runat="server" CssClass="label" Text="Lý do"></asp:Label></td>
                                            <td class="tdValue" style="height: 21px">
                                                <asp:TextBox ID="txtReson" runat="server" TextMode="MultiLine" Width="300px" CssClass="textBox"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label10" runat="server" CssClass="label" Text="Ghi chú"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:TextBox ID="txtRemark" runat="server" TextMode="MultiLine" Width="300px" CssClass="textBox"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel" colspan="2">
                                                <fieldset>
                                                    <legend class="label"> Trình độ văn hóa</legend>
                                                    <table style="width: 100%" class="tableBorder" cellpadding="0" cellspacing="0">
                                                        <tr>
                                                            <td>
                                                                <asp:DataList ID="dlEducation" runat="server" Width="100%" OnItemDataBound="dlDataListInsert_ItemDataBound">
                                                                    <HeaderTemplate>
                                                                        <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                            <tr class="dataList-header">
                                                                                <td style="width:20%" align="left">Trình độ</td>                                                                        
                                                                                <td style="width:20%" align="left">Giá trị</td>
                                                                                <td style="width:40%" align="left">Ghi chú</td>                                                                                                                        
                                                                                <td style="width:10%" align="center">Xóa</td>
                                                                                <td style="width:10%" align="center">Thêm</td>
                                                                            </tr>
                                                                        </table>
                                                                    </HeaderTemplate>
                                                                    <ItemTemplate>
                                                                        <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                            <tr>
                                                                                <td style="width:20%;" align="left" valign="top">
                                                                                    <asp:TextBox Visible="false" ID="txtTraining_Job" runat="server" CssClass="textBox" Width="1"></asp:TextBox>
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
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" class="tdButton">
                                                 <table style="width: 100%" >
                                                    <tr>                                                        
                                                        <td align="center">
                                                         <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Lưu" CssClass="small color green button" Width="100px" />
                                                            &nbsp;&nbsp;
                                                            <asp:Button ID="btnDelete" runat="server" Text="Xóa" CssClass="small color green button" Width="100px" OnClientClick="return confirm('Bạn có chắc xóa ứng cử viên này ?')" OnClick="btnDelete_Click" />
                                                            &nbsp;&nbsp;
                                                            <asp:Button ID="btnApproval" runat="server" Text="Duyệt Hồ Sơ" CssClass="small color green button" Width="100px" OnClientClick="return confirm('Bạn có chắc duyệt hồ sơ này không ?')" OnClick="btnApproval_Click" />
                                                            &nbsp; &nbsp;<asp:Button ID="btnCancel" runat="server" Text="Thoát" CssClass="small color green button" Width="100px" OnClick="btnCancel_Click" />
                                                         </td>
                                                     </tr>
                                                </table>
                                                <uc1:ucPermission ID="UcPermission1" runat="server" />
                                            </td>
                                            
                                        </tr>
                                    </table>
                                       
                            </fieldset>
                        </td>
                    </tr>
                                  
                </table>
            </td>
        </tr>
</table> 
</asp:Content>

