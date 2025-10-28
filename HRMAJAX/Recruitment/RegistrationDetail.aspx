<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistrationDetail.aspx.cs" Inherits="Recruitment_RegistrationDetail" %>

<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc3" %>
<%@ Register Src="~/Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"TagPrefix="uc2" %>
<%@ Register Src="~/Recruitment/UserControl/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>SAGS ::  WEB.SAG.VN</title>
    <link href="../Stylesheets/CandidateRegistration.css" rel="stylesheet" type="text/css" />
    <link href="../Stylesheets/buttonstyle.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" href="../Images/sags.ico"/> 
</head>
<body style="margin:0px">
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%" cellpadding="0" cellspacing="0" border="0">
            <tr>
                <td class="banner-CandidateBG" >
                     <table style="width: 100%" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                            <td align="left" style="width:420px">
                                <a href="http://Localhost/Home.aspx"><asp:Image ID="Image1" runat="server" ImageUrl="~/Images/SAGS_Logo.png" /></a></td>
                            <td align="center">
                                <asp:Label ID="Label53" runat="server" Text="ĐĂNG KÝ HỒ SƠ DỰ TUYỂN" Font-Bold="True" Font-Size="35pt"></asp:Label>
                            </td>
                            <td style="width: 420px"></td>
                        </tr>
                    </table>
                </td>
            </tr>           
             <tr>
                <td class="user-infor" align="right">                    
                </td>
            </tr>
            <tr>
                <td>
                    <table style="width: 100%"  cellpadding="20" cellspacing="0" class="tableBackground" border="0">                                                
                        <tr>
                            <td style="height:400px; vertical-align:top">
                             <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>  
                             <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                               <ContentTemplate>                                                               
                                    <table style="width: 100%">
                                        <tr>
                                            <td valign="top" >
                                                <uc1:ucTitle ID="UcTitle1" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td valign="top">
                                                <table style="width: 99%;margin-top:2px; margin-left:2px; margin-right:2px;" class="tableBorder">
                                                <tr>
                                                    <td class="tdTitleCenter" align="center">
                                                        <asp:Label ID="Label48" runat="server" CssClass="labelTitleCenter" Text="NHẬP SAU ĐÓ IN MẪU ĐƠN, KÝ TÊN VÀ NỘP TẠI PHÒNG TCHC"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" class="tdTable">
                                                        <table cellpadding="0" cellspacing="0" border="0">
                                                            <tr>
                                                                <td align="left">
                                                                    
                                                                    <asp:Label ID="Label6" runat="server" CssClass="label" Text="Vị trí dự tuyển"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtPositionName" runat="server" CssClass="textBox" 
                                                                        Width="300px" ReadOnly="True"></asp:TextBox>                                                       
                                                                </td>
                                                                <td style="width:10px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label15" runat="server" CssClass="label" Text="Ngày nộp đơn"></asp:Label>
                                                                    <br />
                                                                    <uc3:CalendarPicker ID="cpDateCV" runat="server" />                                                                    
                                                                </td>
                                                            </tr>
                                                        </table>                                                                                                               
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="tdTitle">
                                                        <asp:Label ID="Label9" runat="server" CssClass="labelTitle" Text="A- THÔNG TIN CÁ NHÂN"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" class="tdTable">
                                                        <table cellpadding="0" cellspacing="0" border="0">
                                                            <tr>
                                                                <td align="left">
                                                                    <asp:Label ID="Label3" runat="server" CssClass="label" Text="Họ tên lót"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtLastName" runat="server" Width="200px" CssClass="textBox"></asp:TextBox><asp:Label ID="lbLastNameError" runat="server" ForeColor="Red" Text=""></asp:Label>
                                                                </td>
                                                                <td style="width:10px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label11" runat="server" CssClass="label" Text="Tên"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtFirstName" runat="server" CssClass="textBox" Width="100px"></asp:TextBox><asp:Label ID="lbFirstNameError" runat="server" ForeColor="Red" Text=""></asp:Label>                                                                 
                                                                </td>
                                                                <td style="width:10px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label16" runat="server" CssClass="label" Text="Chiều cao"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtHeight" runat="server" Width="100px" CssClass="textBox"></asp:TextBox><asp:Label ID="Label18" runat="server" CssClass="label" Text="cm"></asp:Label><asp:Label ID="lbHeightError" runat="server" ForeColor="Red" Text=""></asp:Label>
                                                                </td>
                                                                <td style="width:10px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label17" runat="server" CssClass="label" Text="Cân nặng"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtWeight" runat="server" CssClass="textBox" Width="100px"></asp:TextBox><asp:Label ID="Label19" runat="server" CssClass="label" Text="kg"></asp:Label><asp:Label ID="lbWeightError" runat="server" ForeColor="Red" Text=""></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>                                                                                                                      
                                                    </td>
                                                </tr>        
                                                <tr>
                                                    <td align="left" class="tdTable">
                                                        <table cellpadding="0" cellspacing="0" border="0">
                                                            <tr>
                                                                <td align="left">
                                                                    <asp:Label ID="Label30" runat="server" CssClass="label" Text="Ngày sinh"></asp:Label>
                                                                    <br />
                                                                    <uc3:CalendarPicker ID="cpBirthday" runat="server" /> <asp:Label ID="lbBirthdayError" runat="server" ForeColor="Red" Text=""></asp:Label>                                                                 
                                                                </td>
                                                                <td style="width:10px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label50" runat="server" CssClass="label" Text="Nơi Sinh"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtBirthPlace" runat="server" Width="200px" CssClass="textBox"></asp:TextBox>
                                                                </td>
                                                                <td style="width:10px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label51" runat="server" CssClass="label" Text="Quốc tịch"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtNationality" runat="server" Width="100px" CssClass="textBox"></asp:TextBox>
                                                                </td>
                                                                <td style="width:10px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label52" runat="server" CssClass="label" Text="Dân tộc"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtNation" runat="server" Width="100px" CssClass="textBox"></asp:TextBox>
                                                                </td>
                                                                <td style="width:10px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label31" runat="server" CssClass="label" Text="Giới tính"></asp:Label>
                                                                    <br />
                                                                    <asp:DropDownList ID="ddlSex" runat="server" Width="100px" CssClass="dropDownList" AppendDataBoundItems="true">
                                                                    <asp:ListItem Text="Nam" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Nữ" Value="0"></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="width:10px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label33" runat="server" CssClass="label" Text="Tình trạng hôn nhân"></asp:Label>
                                                                    <br />
                                                                    <asp:DropDownList ID="ddlMarriage" runat="server" Width="100px" CssClass="dropDownList" AppendDataBoundItems="true">
                                                                    <asp:ListItem Text="Độc thân" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="Đã thành hôn" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Đã ly dị" Value="2"></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                            </tr>
                                                        </table>                                                                                                                      
                                                    </td>
                                                </tr>   
                                                <tr>
                                                    <td align="left" class="tdTable">
                                                        <table cellpadding="0" cellspacing="0" border="0">
                                                            <tr>
                                                                <td align="left">
                                                                    <asp:Label ID="Label23" runat="server" CssClass="label" Text="Địa chỉ liên hệ"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtLive" runat="server" Width="350px" CssClass="textBox"></asp:TextBox>
                                                                </td>
                                                                <td style="width:10px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label24" runat="server" CssClass="label" Text="Địa chỉ thường trú"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtResident" runat="server" CssClass="textBox" Width="350px"></asp:TextBox>                                                                   
                                                                </td>
                                                                
                                                            </tr>
                                                        </table>                                                                                                                      
                                                    </td>
                                                </tr>                                                  
                                                <tr>
                                                    <td align="left" class="tdTable">
                                                        <table cellpadding="0" cellspacing="0" border="0">
                                                            <tr>
                                                                <td align="left">
                                                                    <asp:Label ID="Label20" runat="server" CssClass="label" Text="CMND-Số"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtIdCard" runat="server" Width="200px" CssClass="textBox"></asp:TextBox>
                                                                </td>
                                                                <td style="width:10px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label21" runat="server" CssClass="label" Text="CMND-Ngày cấp"></asp:Label>
                                                                    <br />
                                                                    <uc3:CalendarPicker ID="cpIdDateOfIssue" runat="server" />                                                                   
                                                                </td>
                                                                <td style="width:10px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label22" runat="server" CssClass="label" Text="CMND-Nơi cấp"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtIdPlaceOfIssue" runat="server" Width="200px" CssClass="textBox"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                        </table>                                                                                                                      
                                                    </td>
                                                </tr>  
                                                <tr>
                                                    <td align="left" class="tdTable">
                                                        <table cellpadding="0" cellspacing="0" border="0">
                                                            <tr>
                                                                <td align="left">
                                                                    <asp:Label ID="Label25" runat="server" CssClass="label" Text="Quê quán"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtHomeTownAddress" runat="server" Width="300px" CssClass="textBox"></asp:TextBox>
                                                                </td>
                                                                <td style="width:10px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label26" runat="server" CssClass="label" Text="Điện thoại nhà / di động"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtHandPhone" runat="server" CssClass="textBox" Width="150px"></asp:TextBox>                                                                   
                                                                </td>
                                                                <td style="width:10px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label29" runat="server" CssClass="label" Text="Email"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtEmail" runat="server" Width="200px" CssClass="textBox"></asp:TextBox>
                                                                </td>
                                                                <td style="width:10px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label27" runat="server" CssClass="label" Text="Điện thoại cơ quan" Visible="false"></asp:Label>
                                                                    <br />
                                                                    <asp:TextBox ID="txtWorkingPhone" runat="server" Width="150px" CssClass="textBox" Visible="false"></asp:TextBox>
                                                                </td>
                                                                
                                                            </tr>
                                                        </table>                                                                                                                      
                                                    </td>
                                                </tr>                  
                                                       
                                              <tr>
                                                    <td class="tdTitle">
                                                        <asp:Label ID="Label1" runat="server" CssClass="labelTitle" Text="B - TRÌNH ĐỘ HỌC VẤN, CÁC LỚP ĐÀO TẠO (CAO CẤP NHẤT)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" class="tdTable">
                                                            <asp:Label ID="Label2" runat="server" CssClass="labelTitle" Text="1. HỌC VẤN"></asp:Label>
                                                            <table style="width: 100%" class="tableBorder" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td>
                                                                        <asp:DataList ID="dlEducation" runat="server" Width="100%"
                                  OnItemDataBound="dlEducation_ItemDataBound"
                                  DataKeyField="CandidateTrainingJobHistoryId">
                        <HeaderTemplate>
                            <table style="width: 100%" cellpadding="0" cellspacing="0">
                                <tr class="dataList-header">
                                    <td style="width: 15%" align="left">Trình độ học vấn</td>
                                    <td style="width: 10%" align="left">Năm</td>
                                    <td style="width: 30%" align="left">Tên trường</td>
                                    <td style="width: 25%" align="left">Chuyên ngành</td>
                                    <td style="width: 10%" align="left">Năm tốt nghiệp</td>

                                    <td style="width: 5%" align="center">Xóa</td>
                                    <td style="width: 5%" align="center">Thêm</td>
                                </tr>
                                <tr class="dataList-atlternating-item">
                                    <td style="width: 15%" align="left">Ví dụ: Đại học</td>
                                    <td style="width: 10%" align="left">1990-1994</td>
                                    <td style="width: 30%" align="left">Đại học kinh tế TP-HCM</td>
                                    <td style="width: 25%" align="left">Quản trị kinh doanh</td>
                                    <td style="width: 10%" align="left">20/06/1994</td>

                                    <td style="width: 5%" align="center"></td>
                                    <td style="width: 5%" align="center"></td>
                                </tr>
                            </table>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table style="width: 100%" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td style="width: 15%;" align="left" valign="top">
                                        <asp:TextBox Visible="false" ID="txtTraining_Job" runat="server" CssClass="textBox" Width="1"></asp:TextBox>
                                        <asp:TextBox Visible="false" ID="txtSelectedEdu" runat="server" CssClass="textBox" Width="1"></asp:TextBox>
                                        <asp:DropDownList ID="ddlEducationLevel" runat="server" CssClass="dropDownList"
                                                          DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="EducationLevelId"
                                                          AppendDataBoundItems="True" Width="90%">
                                            <asp:ListItem Text="" Value="0"></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"
                                                              SelectMethod="GetDT_All"
                                                              TypeName="HRMBLL.H2.EducationLevelsBLL">
                                        </asp:ObjectDataSource>
                                    </td>

                                    <td style="width: 10%;" align="left" valign="top">
                                        <asp:TextBox ID="txtYear" runat="server" CssClass="textBox" Width="90%"></asp:TextBox>
                                    </td>

                                    <td style="width: 30%;" align="left" valign="top">
                                        <asp:TextBox ID="txtSchool_Position" runat="server" CssClass="textBox" Width="90%"></asp:TextBox>
                                    </td>

                                    <td style="width: 25%;" align="left" valign="top">
                                        <asp:TextBox ID="txtMajor_Salary" runat="server" CssClass="textBox" Width="90%"></asp:TextBox>
                                    </td>

                                    <td style="width: 10%;" align="left" valign="top">
                                        <asp:TextBox ID="txtGraduateYear_LeaveReason" runat="server" CssClass="textBox" Width="90%"></asp:TextBox>
                                    </td>

                                    <td style="width: 5%;" align="center" valign="middle">
                                        <asp:ImageButton ID="imgDeleteRow" runat="server" ImageUrl="~/Images/icon-delete.gif" OnClick="imgDeleteRowdlEducation_Click"/>
                                    </td>
                                    <td style="width: 5%;" align="center" valign="middle">
                                        <asp:ImageButton ID="imgAddNewRow" runat="server" ImageUrl="~/Images/Add.gif" OnClick="imgAddNewRowdlEducation_Click" Visible="false"/>
                                    </td>
                                </tr>

                            </table>
                        </ItemTemplate>
                        <ItemStyle CssClass="dataList-item"/>
                        <AlternatingItemStyle CssClass="dataList-atlternating-item"/>
                    </asp:DataList>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" class="tdTable">
                                                            <asp:Label ID="Label4" runat="server" CssClass="labelTitle" Text="2. ĐÀO TẠO (ĐÃ HOÀN TẤT)"></asp:Label>
                                                            <table style="width: 100%" class="tableBorder" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td>
                                                                        <asp:DataList ID="dlTraining" runat="server" Width="100%" OnItemDataBound="dlTraining_ItemDataBound">
                                                                            <HeaderTemplate>
                                                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                                    <tr class="dataList-header">
                                                                                        <td style="width:15%" align="left">Môn học</td>
                                                                                        <td style="width:10%" align="left">Năm</td>
                                                                                        <td style="width:35%" align="left">Tên trường</td>                                                                                                                        
                                                                                        <td style="width:30%" align="left">Kết quả đạt được</td>
                                                                                        
                                                                                        <td style="width:5%" align="center">Xóa</td>
                                                                                        <td style="width:5%" align="center">Thêm</td>
                                                                                    </tr>
                                                                                    <tr class="dataList-atlternating-item">
                                                                                        <td style="width:15%" align="left">Ví dụ: Tài chính kế toán</td>
                                                                                        <td style="width:10%" align="left">1995-1996</td>
                                                                                        <td style="width:35%" align="left">Trung tâm ABC</td>                                                                                                                        
                                                                                        <td style="width:30%" align="left">Chứng chỉ kế toán doanh nghiệp</td>
                                                                                        
                                                                                        <td style="width:5%" align="center"></td>
                                                                                        <td style="width:5%" align="center"></td>
                                                                                    </tr>
                                                                                </table>
                                                                            </HeaderTemplate>
                                                                            <ItemTemplate>
                                                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                                    <tr>
                                                                                        <td style="width:15%;" align="left" valign="top">
                                                                                           <asp:TextBox ID="txtTraining_Job" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>                                                                        
                                                                                       
                                                                                        <td style="width:10%;" align="left" valign="top">
                                                                                            <asp:TextBox ID="txtYear" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>
                                                                                       
                                                                                        <td style="width:35%;" align="left" valign="top">
                                                                                                <asp:TextBox ID="txtSchool_Position" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>
                                                                                                
                                                                                        <td style="width:30%;" align="left" valign="top">
                                                                                            <asp:TextBox ID="txtMajor_Salary" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>
                                                                                       
                                                                                        
                                                                                        <td style="width:5%;" align="center" valign="middle">
                                                                                            <asp:ImageButton ID="imgDeleteRow" runat="server"  ImageUrl="~/Images/icon-delete.gif" OnClick="imgDeleteRowdlTraining_Click" /></td>
                                                                                        <td style="width:5%;" align="center" valign="middle">
                                                                                            <asp:ImageButton ID="imgAddNewRow" runat="server"  ImageUrl="~/Images/Add.gif" OnClick="imgAddNewRowdlTraining_Click" Visible="false"/></td>  
                                                                                    </tr>
                                                                                       
                                                                                </table>
                                                                            </ItemTemplate>
                                                                            <ItemStyle CssClass="dataList-item" />
                                                                            <AlternatingItemStyle CssClass="dataList-atlternating-item" />
                                                                        </asp:DataList>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" class="tdTable">
                                                            <asp:Label ID="Label5" runat="server" CssClass="labelTitle" Text="3. ĐÀO TẠO (CHƯA HOÀN TẤT)"></asp:Label>
                                                            <table style="width: 100%" class="tableBorder" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td>
                                                                        <asp:DataList ID="dlTrainingIncomplete" runat="server" Width="100%" OnItemDataBound="dlTrainingIncomplete_ItemDataBound">
                                                                            <HeaderTemplate>
                                                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                                    <tr class="dataList-header">
                                                                                        <td style="width:15%" align="left">Môn học</td>
                                                                                        <td style="width:10%" align="left">Năm</td>
                                                                                        <td style="width:35%" align="left">Tên trường</td>                                                                                                                        
                                                                                        <td style="width:30%" align="left">Kết quả đạt được</td>
                                                                                        
                                                                                        <td style="width:5%" align="center">Xóa</td>
                                                                                        <td style="width:5%" align="center">Thêm</td>
                                                                                    </tr>                                                                                   
                                                                                </table>
                                                                            </HeaderTemplate>
                                                                            <ItemTemplate>
                                                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                                    <tr>
                                                                                        <td style="width:15%;" align="left" valign="top">
                                                                                           <asp:TextBox ID="txtTraining_Job" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>                                                                        
                                                                                       
                                                                                        <td style="width:10%;" align="left" valign="top">
                                                                                            <asp:TextBox ID="txtYear" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>
                                                                                       
                                                                                        <td style="width:35%;" align="left" valign="top">
                                                                                                <asp:TextBox ID="txtSchool_Position" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>
                                                                                                
                                                                                        <td style="width:30%;" align="left" valign="top">
                                                                                            <asp:TextBox ID="txtMajor_Salary" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>
                                                                                       
                                                                                        
                                                                                        <td style="width:5%;" align="center" valign="middle">
                                                                                            <asp:ImageButton ID="imgDeleteRow" runat="server"  ImageUrl="~/Images/icon-delete.gif" OnClick="imgDeleteRowdlTrainingIncomplete_Click" /></td>
                                                                                        <td style="width:5%;" align="center" valign="middle">
                                                                                            <asp:ImageButton ID="imgAddNewRow" runat="server"  ImageUrl="~/Images/Add.gif" OnClick="imgAddNewRowdlTrainingIncomplete_Click" Visible="false"/></td>  
                                                                                    </tr>
                                                                                       
                                                                                </table>
                                                                            </ItemTemplate>
                                                                            <ItemStyle CssClass="dataList-item" />
                                                                            <AlternatingItemStyle CssClass="dataList-atlternating-item" />
                                                                        </asp:DataList>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" class="tdTable">
                                                            <asp:Label ID="Label7" runat="server" CssClass="labelTitle" Text="4. NGOẠI NGỮ / VI TÍNH / BẰNG LÁI XE"></asp:Label>
                                                            <table style="width: 100%" class="tableBorder" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td>
                                                                        <asp:DataList ID="dlEnglishComputer" runat="server" Width="100%" OnItemDataBound="dlEnglishComputer_ItemDataBound">
                        <HeaderTemplate>
                            <table style="width: 100%" cellpadding="0" cellspacing="0">
                                <tr class="dataList-atlternating-item">
                                    <td style="width: 15%" align="left">Ví dụ: TOEIC <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Chứng chỉ tin học</td>
                                    <td style="width: 75%" align="left">600 <br/> Chứng chỉ A</td>

                                    <td style="width: 5%" align="center">Xóa</td>
                                    <td style="width: 5%" align="center">Thêm</td>
                                </tr>
                            </table>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table style="width: 100%" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td style="width: 15%;" align="left" valign="top">
                                        <%--<asp:TextBox ID="txtTraining_Job" runat="server" CssClass="textBox" Width="90%"></asp:TextBox>--%>
                                        <asp:DropDownList ID="ddlEducationLevel" runat="server" CssClass="dropDownList" DataSourceID="ObjectDataSource2"
                                                          DataTextField="Name" DataValueField="EducationLevelId"
                                                          AppendDataBoundItems="true" Width="90%">
                                            <asp:ListItem Text="" Value="0"></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}"
                                                              SelectMethod="GetForForeignLanguageComputerDrivingLicense" TypeName="HRMBLL.H2.EducationLevelsBLL">
                                        </asp:ObjectDataSource>
                                    </td>


                                    <td style="width: 75%;" align="left" valign="top">
                                        <asp:TextBox ID="txtMajor_Salary" runat="server" CssClass="textBox" Width="90%"></asp:TextBox>
                                    </td>


                                    <td style="width: 5%;" align="center" valign="middle">
                                        <asp:ImageButton ID="imgDeleteRow" runat="server" ImageUrl="~/Images/icon-delete.gif" OnClick="imgDeleteRowdlEnglishComputer_Click"/>
                                    </td>
                                    <td style="width: 5%;" align="center" valign="middle">
                                        <asp:ImageButton ID="imgAddNewRow" runat="server" ImageUrl="~/Images/Add.gif" OnClick="imgAddNewRowdlEnglishComputer_Click" Visible="false"/>
                                    </td>
                                </tr>

                            </table>
                        </ItemTemplate>
                        <ItemStyle CssClass="dataList-item"/>
                        <AlternatingItemStyle CssClass="dataList-atlternating-item"/>
                    </asp:DataList>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="tdTitle">
                                                        <asp:Label ID="Label8" runat="server" CssClass="labelTitle" Text="C - QUÁ TRÌNH LÀM VIỆC (BẮT ĐẦU VỚI CÔNG VIỆC GẦN NHẤT)"></asp:Label>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td align="left" class="tdTable">                                                            
                                                            <table style="width: 100%" class="tableBorder" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td>
                                                                        <asp:DataList ID="dlJob" runat="server" Width="100%" OnItemDataBound="dlJob_ItemDataBound">
                                                                            <HeaderTemplate>
                                                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                                    <tr class="dataList-header">
                                                                                        <td style="width:15%" align="left">Tên Công ty / Cơ quan</td>                                                                                        
                                                                                        <td style="width:30%" align="left">Vị trí</td>                                                                                                                        
                                                                                        <td style="width:10%" align="left">Năm (từ-đến)</td>
                                                                                        <td style="width:25%" align="left">Tiền lương</td>
                                                                                        <td style="width:10%" align="left">Lý do thôi việc</td>

                                                                                        <td style="width:5%" align="center">Xóa</td>
                                                                                        <td style="width:5%" align="center">Thêm</td>
                                                                                    </tr>
                                                                                   
                                                                                </table>
                                                                            </HeaderTemplate>
                                                                            <ItemTemplate>
                                                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                                    <tr>
                                                                                        <td style="width:15%;" align="left" valign="top">
                                                                                           <asp:TextBox ID="txtTraining_Job" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>                                                                        
                                                                                       
                                                                                       <td style="width:30%;" align="left" valign="top">
                                                                                                <asp:TextBox ID="txtSchool_Position" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>

                                                                                        <td style="width:10%;" align="left" valign="top">
                                                                                            <asp:TextBox ID="txtYear" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>                                                                                                                                                                              
                                                                                                
                                                                                        <td style="width:25%;" align="left" valign="top">
                                                                                            <asp:TextBox ID="txtMajor_Salary" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>
                                                                                       
                                                                                        <td style="width:10%;" align="left" valign="top">
                                                                                                <asp:TextBox ID="txtGraduateYear_LeaveReason" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>
                                                                                        
                                                                                        <td style="width:5%;" align="center" valign="middle">
                                                                                            <asp:ImageButton ID="imgDeleteRow" runat="server"  ImageUrl="~/Images/icon-delete.gif" OnClick="imgDeleteRowdlJob_Click" /></td>
                                                                                        <td style="width:5%;" align="center" valign="middle">
                                                                                            <asp:ImageButton ID="imgAddNewRow" runat="server"  ImageUrl="~/Images/Add.gif" OnClick="imgAddNewRowdlJob_Click" Visible="false"/></td>  
                                                                                    </tr>
                                                                                       
                                                                                </table>
                                                                            </ItemTemplate>
                                                                            <ItemStyle CssClass="dataList-item" />
                                                                            <AlternatingItemStyle CssClass="dataList-atlternating-item" />
                                                                        </asp:DataList>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="tdTitle">
                                                        <asp:Label ID="Label10" runat="server" CssClass="labelTitle" Text="D - KINH NGHIỆM LÀM VIỆC(BẮT ĐẦU VỚI CÔNG VIỆC GẦN NHẤT)"></asp:Label>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td align="left" class="tdTable">                                                            
                                                            <table style="width: 100%" class="tableBorder" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td>
                                                                        <asp:DataList ID="dlExperience" runat="server" Width="100%" OnItemDataBound="dlExperience_ItemDataBound">
                                                                            <HeaderTemplate>
                                                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                                    <tr class="dataList-atlternating-item">
                                                                                        <td style="width:90%" align="left">Mô tả chi tiết kinh nghiệm làm việc (mỗi ô tương ứng với thứ tự các ô được liệt kê trong phần C)</td>
                                                                                        <td style="width:5%" align="center">Xóa</td>
                                                                                        <td style="width:5%" align="center">Thêm</td>
                                                                                    </tr>                                                                                   
                                                                                </table>
                                                                            </HeaderTemplate>
                                                                            <ItemTemplate>
                                                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                                    <tr>
                                                                                        <td style="width:90%;" align="left" valign="top">
                                                                                           <asp:TextBox ID="txtExperience" runat="server" CssClass="textBox" Width="95%"></asp:TextBox></td>

                                                                                        <td style="width:5%;" align="center" valign="middle">
                                                                                            <asp:ImageButton ID="imgDeleteRow" runat="server"  ImageUrl="~/Images/icon-delete.gif" OnClick="imgDeleteRowdlExperience_Click" /></td>
                                                                                        <td style="width:5%;" align="center" valign="middle">
                                                                                            <asp:ImageButton ID="imgAddNewRow" runat="server"  ImageUrl="~/Images/Add.gif" OnClick="imgAddNewRowdlExperience_Click" Visible="false"/></td>  
                                                                                    </tr>
                                                                                </table>
                                                                            </ItemTemplate>
                                                                            <ItemStyle CssClass="dataList-item" />
                                                                            <AlternatingItemStyle CssClass="dataList-atlternating-item" />
                                                                        </asp:DataList>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td align="left" class="tdTable">                                                            
                                                            <table style="width: 100%" class="tableBorder" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td>
                                                                        <asp:DataList ID="dlExperienceOther" runat="server" Width="100%" OnItemDataBound="dlExperienceOther_ItemDataBound">
                                                                            <HeaderTemplate>
                                                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                                    <tr class="dataList-atlternating-item">
                                                                                        <td style="width:90%" align="left">Những kỹ năng hoặc kinh nghiệm khác có liên quan trực tiếp đến vị trí dự tuyển</td>
                                                                                        <td style="width:5%" align="center">Xóa</td>
                                                                                        <td style="width:5%" align="center">Thêm</td>
                                                                                    </tr>                                                                                   
                                                                                </table>
                                                                            </HeaderTemplate>
                                                                            <ItemTemplate>
                                                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                                    <tr>
                                                                                        <td style="width:90%;" align="left" valign="top">
                                                                                           <asp:TextBox ID="txtExperience" runat="server" CssClass="textBox" Width="95%"></asp:TextBox></td>

                                                                                        <td style="width:5%;" align="center" valign="middle">
                                                                                            <asp:ImageButton ID="imgDeleteRow" runat="server"  ImageUrl="~/Images/icon-delete.gif" OnClick="imgDeleteRowdlExperienceOther_Click" /></td>
                                                                                        <td style="width:5%;" align="center" valign="middle">
                                                                                            <asp:ImageButton ID="imgAddNewRow" runat="server"  ImageUrl="~/Images/Add.gif" OnClick="imgAddNewRowdlExperienceOther_Click" Visible="false"/></td>  
                                                                                    </tr>
                                                                                </table>
                                                                            </ItemTemplate>
                                                                            <ItemStyle CssClass="dataList-item" />
                                                                            <AlternatingItemStyle CssClass="dataList-atlternating-item" />
                                                                        </asp:DataList>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="tdTitle">
                                                        <asp:Label ID="Label12" runat="server" CssClass="labelTitle" Text="E - TIỀN LƯƠNG"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" class="tdTable">
                                                        <table cellpadding="0" cellspacing="0" border="0">
                                                            <tr>
                                                                <td align="left">
                                                                    <asp:Label ID="Label13" runat="server" CssClass="label" Text="Tiền lương hiện nay / mỗi tháng (VND) "></asp:Label>
                                                                </td>
                                                                <td style="width:5px"></td>
                                                                <td align="left">
                                                                    <asp:TextBox ID="txtSalary_Present" runat="server" CssClass="textBox" Width="150px"></asp:TextBox><asp:Label ID="lbSalary_PresentError" runat="server" ForeColor="Red" Text=""></asp:Label>                                                                   
                                                                </td>
                                                                <td style="width:20px"></td>
                                                                <td align="left">
                                                                    <asp:Label ID="Label28" runat="server" CssClass="label" Text="Tiền lương đề nghị / mỗi tháng (VND) "></asp:Label>
                                                                </td>
                                                                <td style="width:5px"></td>
                                                                <td align="left">
                                                                    <asp:TextBox ID="txtSalary_Offer" runat="server" CssClass="textBox" Width="150px"></asp:TextBox><asp:Label ID="lbSalary_OfferError" runat="server" ForeColor="Red" Text=""></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>                                                                                                                      
                                                    </td>
                                                </tr> 
                                                <tr>
                                                    <td class="tdTitle">
                                                        <asp:Label ID="Label14" runat="server" CssClass="labelTitle" Text="F - HỢP ĐỒNG LAO ĐỘNG HIỆN TẠI"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" class="tdTable">
                                                        <table cellpadding="0" cellspacing="0" border="0">
                                                            <tr>
                                                                <td align="left">
                                                                    <asp:Label ID="Label32" runat="server" CssClass="label" Text="Bạn có ký HĐLĐ với công ty/cơ quan hiện đang làm việc không?  Có/Không"></asp:Label>
                                                                </td>
                                                                <td style="width:5px"></td>
                                                                <td align="left">
                                                                     <asp:DropDownList ID="ddlContract_YesNo" runat="server" Width="100px" 
                                                                         CssClass="dropDownList" AppendDataBoundItems="true">
                                                                    <asp:ListItem Text="Có" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Không" Value="0"></asp:ListItem>
                                                                    </asp:DropDownList>                                                                  
                                                                </td>                                                                
                                                            </tr>
                                                            <tr>
                                                                <td align="left">
                                                                    <asp:Label ID="Label34" runat="server" CssClass="label" Text=" - HĐLĐ có hiệu lực đến ngày? Ngày/tháng/năm"></asp:Label>
                                                                </td>
                                                                <td style="width:5px"></td>
                                                                <td align="left">
                                                                    <uc3:CalendarPicker ID="cpContract_Present_Date" runat="server" />                                                                 
                                                                </td>                                                                
                                                            </tr>
                                                             <tr>
                                                                <td align="left">
                                                                    <asp:Label ID="Label35" runat="server" CssClass="label" Text=" - Bạn có thể kết thúc HĐLĐ không?"></asp:Label>
                                                                </td>
                                                                <td style="width:5px"></td>
                                                                <td align="left">
                                                                     <asp:DropDownList ID="ddlContract_Present_End" runat="server" Width="100px" CssClass="dropDownList" AppendDataBoundItems="true">
                                                                    <asp:ListItem Text="" Value="-1"></asp:ListItem>
                                                                    <asp:ListItem Text="Được" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Không" Value="0"></asp:ListItem>
                                                                    
                                                                    </asp:DropDownList>
                                                                </td>                                                                
                                                            </tr>
                                                             <tr>
                                                                <td align="left">
                                                                    <asp:Label ID="Label36" runat="server" CssClass="label" Text=" - Khi nào bạn có thể bắt đầu làm việc nếu được tuyển dụng?"></asp:Label>
                                                                </td>
                                                                <td style="width:5px"></td>
                                                                <td align="left">
                                                                    <uc3:CalendarPicker ID="cpContract_New_StartDate" runat="server" />                                                                 
                                                                </td>                                                                
                                                            </tr>
                                                        </table>                                                                                                                      
                                                    </td>
                                                </tr> 
                                                <tr>
                                                    <td class="tdTitle">
                                                        <asp:Label ID="Label37" runat="server" CssClass="labelTitle" Text="G - SỨC KHỎE"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" class="tdTable">
                                                        <table cellpadding="0" cellspacing="0" border="0">
                                                            <tr>
                                                                <td align="left" s>
                                                                    <asp:Label ID="Label38" runat="server" CssClass="label" Text="- Tình trạng sức khỏe hiện nay? Tốt/Bình thường/Khác (nêu rõ)"></asp:Label>
                                                                </td>
                                                                <td style="width:5px"></td>
                                                                <td align="left">
                                                                    <asp:TextBox ID="txtHealth_Present" runat="server" CssClass="textBox" Width="400px"></asp:TextBox>                                                                  
                                                                </td>                                                                
                                                            </tr>                                                          
                                                             <tr>
                                                                <td align="left">
                                                                    <asp:Label ID="Label41" runat="server" CssClass="label" Text=" - Bạn có khuyết tật về hình thể không? Nếu có xin cho biết chi tiết"></asp:Label>
                                                                </td>
                                                                <td style="width:5px"></td>
                                                                <td align="left">
                                                                    <asp:TextBox ID="txtHealth_Body" runat="server" CssClass="textBox" Width="400px"></asp:TextBox>   
                                                                </td>                                                                
                                                            </tr>
                                                        </table>                                                                                                                      
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="tdTitle">
                                                        <asp:Label ID="Label39" runat="server" CssClass="labelTitle" Text="H - LÝ LỊCH GIA ĐÌNH"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" class="tdTable">                                                            
                                                            <table style="width: 100%" class="tableBorder" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td>
                                                                        <asp:DataList ID="dlFatherMother" runat="server" Width="100%" OnItemDataBound="dlFatherMother_ItemDataBound">
                        <HeaderTemplate>
                            <table style="width: 100%" cellpadding="0" cellspacing="0">
                                <tr class="dataList-header">
                                    <td style="width: 15%" align="left">Bố mẹ,Vợ/Chồng, Con, Anh chị em ruột</td>
                                    <td style="width: 35%" align="left">Họ tên</td>
                                    <td style="width: 10%" align="left">Ngày sinh <br />(ngày/ tháng/ năm)</td>
                                    <td style="width: 30%" align="left">Nghề nghiệp</td>

                                    <td style="width: 5%" align="center">Xóa</td>
                                    <td style="width: 5%" align="center">Thêm</td>
                                </tr>
                            </table>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table style="width: 100%" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td style="width: 15%;" align="left" valign="top">
                                        <asp:TextBox Visible="false" ID="txtTraining_Job" runat="server" CssClass="textBox" Width="1"></asp:TextBox>
                                        <asp:TextBox Visible="false" ID="txtSelectedFamily" runat="server" CssClass="textBox" Width="1"></asp:TextBox>
                                        <asp:DropDownList ID="ddlFamily" runat="server" CssClass="dropDownList"
                                                          DataSourceID="ObjectDataSource3"

                                                          DataTextField="RelationTypeName"
                                                          DataValueField="RelationTypeId"

                                                          AppendDataBoundItems="True" Width="90%">
                                            <asp:ListItem Text="" Value="0"></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server"
                                                              SelectMethod="GetByFilter" 
                                            TypeName="HRMBLL.H0.RelationTypesBLL" 
                                            OldValuesParameterFormatString="original_{0}">
                                            <SelectParameters>
                                                <asp:Parameter DefaultValue="" Name="relationTypeName" Type="String"/>
                                                <asp:Parameter DefaultValue="-1" Name="type" Type="Int32"/>
                                            </SelectParameters>
                                        </asp:ObjectDataSource>
                                    </td>

                                    <td style="width: 35%;" align="left" valign="top">
                                        <asp:TextBox ID="txtSchool_Position" runat="server" CssClass="textBox" Width="90%"></asp:TextBox>
                                    </td>

                                    <td style="width: 10%;" align="left" valign="top">
                                        <uc3:CalendarPicker ID="cpFamilyBirthday" runat="server" Width="90%"/>
                                        <%--<asp:TextBox ID="txtYear" runat="server" CssClass="textBox" Width="90%"></asp:TextBox>--%>
                                    </td>


                                    <td style="width: 30%;" align="left" valign="top">
                                        <asp:TextBox ID="txtMajor_Salary" runat="server" CssClass="textBox" Width="90%"></asp:TextBox>
                                    </td>


                                    <td style="width: 5%;" align="center" valign="middle">
                                        <asp:ImageButton ID="imgDeleteRow" runat="server" ImageUrl="~/Images/icon-delete.gif" OnClick="imgDeleteRowdlFatherMother_Click"/>
                                    </td>
                                    <td style="width: 5%;" align="center" valign="middle">
                                        <asp:ImageButton ID="imgAddNewRow" runat="server" ImageUrl="~/Images/Add.gif" 
                                            OnClick="imgAddNewRowdlFatherMother_Click" Visible="false" style="width: 15px"/>
                                    </td>
                                </tr>

                            </table>
                        </ItemTemplate>
                        <ItemStyle CssClass="dataList-item"/>
                        <AlternatingItemStyle CssClass="dataList-atlternating-item"/>
                    </asp:DataList>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td align="left" class="tdTable">
                                                        <table cellpadding="0" cellspacing="0" border="0">
                                                            <tr>
                                                                <td align="left" s>
                                                                    <asp:Label ID="Label40" runat="server" CssClass="label" Text="Bạn có người thân nào đang làm việc cho Công ty cổ phần PVMĐ Sài Gòn không?"></asp:Label>
                                                                </td>
                                                                <td style="width:5px"></td>
                                                                <td align="left">
                                                                     <asp:DropDownList ID="ddlSAGS_Family" runat="server" Width="100px" 
                                                                         CssClass="dropDownList" AppendDataBoundItems="true">
                                                                    <asp:ListItem Text="Có" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Không" Value="0"></asp:ListItem>
                                                                    </asp:DropDownList>     
                                                                </td>                                                                
                                                            </tr>                                                                                                                     
                                                        </table>                                                                                                                      
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" class="tdTable">                                                            
                                                            <table style="width: 100%" class="tableBorder" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td>
                                                                        <asp:DataList ID="dlSAGSFamily" runat="server" Width="100%" OnItemDataBound="dlSAGSFamily_ItemDataBound">
                                                                            <HeaderTemplate>
                                                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                                    <tr class="dataList-header">
                                                                                        <td style="width:25%" align="left">Tên người thân</td>
                                                                                        <td style="width:35%" align="left">Bộ phận làm việc</td>                                                                                                                                                                                                              
                                                                                        <td style="width:30%" align="left">Mới quan hệ</td>
                                                                                        
                                                                                        <td style="width:5%" align="center">Xóa</td>
                                                                                        <td style="width:5%" align="center">Thêm</td>
                                                                                    </tr>                                                                                   
                                                                                </table>
                                                                            </HeaderTemplate>
                                                                            <ItemTemplate>
                                                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                                    <tr>
                                                                                        <td style="width:25%;" align="left" valign="top">
                                                                                           <asp:TextBox ID="txtTraining_Job" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>                                                                        
                                                                                       
                                                                                        <td style="width:35%;" align="left" valign="top">
                                                                                                <asp:TextBox ID="txtSchool_Position" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>

                                                                                               
                                                                                        <td style="width:30%;" align="left" valign="top">
                                                                                            <asp:TextBox ID="txtMajor_Salary" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>
                                                                                       
                                                                                        
                                                                                        <td style="width:5%;" align="center" valign="middle">
                                                                                            <asp:ImageButton ID="imgDeleteRow" runat="server"  ImageUrl="~/Images/icon-delete.gif" OnClick="imgDeleteRowdlSAGSFamily_Click" /></td>
                                                                                        <td style="width:5%;" align="center" valign="middle">
                                                                                            <asp:ImageButton ID="imgAddNewRow" runat="server"  ImageUrl="~/Images/Add.gif" OnClick="imgAddNewRowdlSAGSFamily_Click" Visible="false"/></td>  
                                                                                    </tr>
                                                                                       
                                                                                </table>
                                                                            </ItemTemplate>
                                                                            <ItemStyle CssClass="dataList-item" />
                                                                            <AlternatingItemStyle CssClass="dataList-atlternating-item" />
                                                                        </asp:DataList>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="tdTitle">
                                                        <asp:Label ID="Label42" runat="server" CssClass="labelTitle" Text="H - NGUỒN XÁC MINH THÔNG TIN"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" class="tdTable"> 
                                                            <asp:Label ID="Label43" runat="server" CssClass="label" Text=" Vui lòng điền hai thông tin xác minh"></asp:Label>                                                           
                                                            <table style="width: 100%" class="tableBorder" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td>
                                                                        <asp:DataList ID="dlInforConfirm" runat="server" Width="100%" OnItemDataBound="dlInforConfirm_ItemDataBound">
                                                                            <HeaderTemplate>
                                                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                                    <tr class="dataList-header">
                                                                                        <td style="width:20%" align="left">Họ tên</td>
                                                                                        <td style="width:30%" align="left">Công ty/Cơ quan</td>
                                                                                        <td style="width:30%" align="left">Mối quan hệ</td>                                                                                                                        
                                                                                        <td style="width:10%" align="left">Số điện thoại</td>
                                                                                        
                                                                                        <td style="width:5%" align="center">Xóa</td>
                                                                                        <td style="width:5%" align="center">Thêm</td>
                                                                                    </tr>                                                                                   
                                                                                </table>
                                                                            </HeaderTemplate>
                                                                            <ItemTemplate>
                                                                                <table style="width: 100%" cellpadding="0" cellspacing="0">
                                                                                    <tr>
                                                                                        <td style="width:20%;" align="left" valign="top">
                                                                                           <asp:TextBox ID="txtTraining_Job" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>                                                                        
                                                                                       
                                                                                        <td style="width:30%;" align="left" valign="top">
                                                                                                <asp:TextBox ID="txtSchool_Position" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>                                                                                        
                                                                                                
                                                                                        <td style="width:30%;" align="left" valign="top">
                                                                                            <asp:TextBox ID="txtMajor_Salary" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>
                                                                                       
                                                                                       <td style="width:10%;" align="left" valign="top">
                                                                                            <asp:TextBox ID="txtYear" runat="server" CssClass="textBox" Width="90%"></asp:TextBox></td>
                                                                                       
                                                                                                                                                                                
                                                                                        <td style="width:5%;" align="center" valign="middle">
                                                                                            <asp:ImageButton ID="imgDeleteRow" runat="server"  ImageUrl="~/Images/icon-delete.gif" OnClick="imgDeleteRowdlInforConfirm_Click" /></td>
                                                                                        <td style="width:5%;" align="center" valign="middle">
                                                                                            <asp:ImageButton ID="imgAddNewRow" runat="server"  ImageUrl="~/Images/Add.gif" OnClick="imgAddNewRowdlInforConfirm_Click" Visible="false"/></td>  
                                                                                    </tr>
                                                                                       
                                                                                </table>
                                                                            </ItemTemplate>
                                                                            <ItemStyle CssClass="dataList-item" />
                                                                            <AlternatingItemStyle CssClass="dataList-atlternating-item" />
                                                                        </asp:DataList>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="tdTitle">
                                                        <asp:Label ID="Label44" runat="server" CssClass="labelTitle" Text="CAM KẾT"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" class="tdTable">
                                                        <table cellpadding="0" cellspacing="0" border="0">
                                                            <tr>
                                                                <td align="left">
                                                                    <asp:Label ID="Label45" runat="server" CssClass="label" Text="- Tôi cam kết mọi thông tin do tôi cung cấp trong đơn dự tuyển là hoàn toàn chính xác."></asp:Label>
                                                                </td>                                                                                                                               
                                                            </tr>                                                          
                                                             <tr>
                                                                <td align="left">
                                                                    <asp:Label ID="Label46" runat="server" CssClass="label" Text=" - Nêu SAGS phát hiện có bất kỳ thông tin sai lệch nào, SAGS có quyền chấm dứt khóa đào tạo hoặc chấm dứt Hợp đồng lao động đối với tôi."></asp:Label>
                                                                </td>                                                                                                                             
                                                            </tr>
                                                            <tr>
                                                                <td align="left">
                                                                    <asp:Label ID="Label47" runat="server" CssClass="label" Text=" - Tôi cam kết tuân thủ các quy định về tuyển dụng của SAGS."></asp:Label>
                                                                </td>                                                                                                                             
                                                            </tr>
                                                           
                                                        </table>                                                                                                                      
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td align="left" class="tdTable">
                                                         <asp:Label ID="Label49" runat="server" CssClass="label" Text="Các hồ sơ đính kèm gồm có (tối thiểu 50 ký tự)" Font-Bold="true"></asp:Label>
                                                                    <br />
                                                          <asp:TextBox ID="txtCVContent" runat="server" Width="350px" CssClass="textBox" 
                                                             TextMode="MultiLine" Rows="4"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td align="center">
                                                        <asp:Label ID="lbResult" runat="server" Font-Bold="true" ForeColor="Red" Text=""></asp:Label>
                                                         <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                                                            <ProgressTemplate>
                                                                <asp:Image ID="Image2" runat="server" ImageUrl="~/images/run.gif" />
                                                                <asp:Label ID="lbSaveWaitting" runat="server" CssClass="value" Text="Đang Lưu Dữ Liệu ..."></asp:Label>
                                                            </ProgressTemplate>
                                                        </asp:UpdateProgress>
                                                    </td>                                                                                                                             
                                                </tr>
                                                <tr>
                                                    <td class="tdButton">
                                                            <table style="width: 100%" >
                                                            <tr>                                                        
                                                                <td align="center">
                                                                    <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Lưu" CssClass="small color red button" Width="100px" />
                                                                    &nbsp;&nbsp;
                                                                    <asp:Button ID="btnPrint" runat="server" Text="In Đơn Dự Tuyển" CssClass="small color red button" Width="150px" OnClick="btnPrint_Click" />
                                                                    &nbsp;
                                                                    <asp:Button ID="btnChangePassword" runat="server" Text="Đổi mật khẩu" CssClass="small color red button" Width="150px" OnClick="btnChangePassword_Click" />
                                                                    &nbsp;
                                                                    <asp:Button ID="btnCancel" runat="server" Text="Thoát" CssClass="small color red button" Width="100px" OnClick="btnCancel_Click" />
                                                                    </td>
                                                                </tr>
                                                        </table>
                                                        <uc2:ucPermission ID="UcPermission1" runat="server" />
                                                    </td>
                                                        
                                                </tr>
                                            </table>
                                            </td>
                                        </tr>                                                          
                                    </table>                                
                               </ContentTemplate> 
                               </asp:UpdatePanel>                                                           
                            </td>                            
                        </tr>                        
                    </table>
                </td>
            </tr>
            <tr>
                <td class="footer">
                     © Copyright 2015 ® CÔNG TY CỔ PHẦN PHỤC VỤ MẶT ĐẤT SÀI GÒN giữ bản quyền nội dung trên website này.
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
