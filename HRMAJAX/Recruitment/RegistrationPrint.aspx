<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistrationPrint.aspx.cs" Inherits="Recruitment_RegistrationPrint" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>SAGS :: SAGS.VN</title>
    <link href="../Stylesheets/CandidateRegistration.css" rel="stylesheet" type="text/css" />    
    <link rel="shortcut icon" href="../Images/sags.ico"/> 
     
     <style type="text/css">
         .style1
         {
             font-family: "Times New Roman", Times, serif;
             font-size: 10pt;
         }
         .style2
         {
             width: 28%;
         }
         .style3
         {
             width: 14%;
         }
         .style4
         {
             width: 65px;
         }
         </style>
     
</head>
<body>
    <form id="form1" runat="server">
    <table style="width: 100%" bgcolor="#FFFFFF" align="center">            
            <tr>
                <td>
                    <table style="width: 100%; height: 20px" class="tableBorderPrint">
                        <tr>
                            <td style="width: 10%" valign="top" class="tableBorderPrint" align="center">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/SAGS_Logo.png" Height="82px" /></td>
                            <td valign="middle" align="center">
                                 <asp:Label ID="lbCompanyName" runat="server" Text="CÔNG TY CỔ PHẦN PHỤC VỤ MẶT ĐẤT SÀI GÒN" CssClass="labelPrintTitleCenter"></asp:Label> </td>                              
                        </tr> 
                    </table>                    
                </td>
            </tr>   
            <tr>
                <td align="center">                    
                    <asp:Label ID="Label2" runat="server" Text="ĐƠN XIN DỰ TUYỂN ĐÀO TẠO" CssClass="labelPrintTitleCenter"></asp:Label>
                </td>
            </tr>       
            <tr>
                <td>                    
                    <table width="100%">
                        <tr>
                            <td style="width:20%"  align="left">
                                <asp:Label ID="Label1" runat="server" Text="Vị trí dự tuyển" CssClass="labelPrint"></asp:Label>
                            </td>
                            <td align="left">
                                <table class="tableBorderPrint" width="100%" cellpadding="4">
                                <tr>
                                    <td>
                                        <asp:Label ID="lbPositionName" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                    </td>
                                </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    
                </td>
            </tr>
            <tr>
                <td>
                    <table width="100%">
                        <tr>
                            <td style="width:20%" align="left">
                                <asp:Label ID="Label5" runat="server" Text="Ngày nộp đơn" CssClass="labelPrint"></asp:Label>
                            </td>
                            <td align="left">
                                <table class="tableBorderPrint" width="50%" cellpadding="4">
                                <tr>
                                    <td align="left" style="height:15px">
                                        <asp:Label ID="lbCV_ReceivedDate" runat="server" Text=""  CssClass="labelPrint"></asp:Label>
                                    </td>
                                </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="height:15px"></td>
            </tr>
            <tr>
                <td align="left"><asp:Label ID="Label4" runat="server" Text="A -  THÔNG TIN CÁ NHÂN" CssClass="labelPrintTitleLeft"></asp:Label></td>
            </tr>
            <tr>
                <td>                    
                    <table width="100%">
                        <tr>
                            <td style="width:20%"  align="left">
                                 <asp:Label ID="Label6" runat="server" Text="Tên ứng viên" CssClass="labelPrint"></asp:Label>
                            </td>
                            <td  align="left">
                                <table class="tableBorderPrint" width="100%" cellpadding="4">
                                <tr>
                                    <td align="left" rowspan="2" valign="middle"  class="tableBorderPrint" style="width:60%">
                                        <asp:Label ID="lbFullName" runat="server" Text=""  CssClass="labelPrint" Font-Bold="true"></asp:Label>
                                    </td>
                                    <td align="center"  class="tableBorderPrint"  style="width:20%">
                                        <asp:Label ID="Label7" runat="server" Text="[Chiều cao]" CssClass="labelPrint"></asp:Label></td>
                                    <td align="center"  class="tableBorderPrint" style="width:20%">
                                       <asp:Label ID="Label8" runat="server" Text="[Cân nặng]" CssClass="labelPrint"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td align="right" class="tableBorderPrint">
                                        <asp:Label ID="lbHeight" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                    </td>
                                    <td align="right"  class="tableBorderPrint">
                                        <asp:Label ID="lbWeight" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                    </td>
                                </tr>
                                
                                </table>
                            </td>
                        </tr>
                    </table>
                    
                </td>
            </tr>

            <tr>
                <td>
                    <table width="100%" cellpadding ="4" cellspacing="0">
                           <tr>
                                <td style="width:20%" align="left">
                                    <asp:Label ID="Label68" runat="server" Text="Ngày sinh" CssClass="labelPrint"></asp:Label>
                                </td>

                                <td align="left">
                                    <table  width="100%">
                                        <tr>
                                            <td>
                                                <table class="tableBorderPrint" width="100%" cellpadding="4">
                                                    <tr>
                                                        <td class="tableBorderPrint">
                                                            <asp:Label ID="lbBirthday" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>    
                                            <td align="left" class="style4">
                                                <asp:Label ID="Label20" runat="server" Text="Giới tính" CssClass="labelPrint"></asp:Label>
                                            </td>
                                            <td>
                                                    <table class="tableBorderPrint" width="100%" cellpadding="4">
                                                    <tr>
                                                        <td class="tableBorderPrint">
                                                            <asp:Label ID="lbSex" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                                <tr>
                                <td style="width:20%" align="left">
                                    <asp:Label ID="Label21" runat="server" Text="Tình trạng hôn nhân" CssClass="labelPrint"></asp:Label>

                                </td>
                                <td align="right">
                                    <table class="tableBorderPrint" width="100%" cellpadding="4">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lbMarriage" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                        </td>
                                    </tr>
                                    </table>
                                </td>
                            </tr>
                    </table>
                </td>
            </tr>

            <tr>
                <td>                    
                    <table width="100%" cellpadding="4" cellspacing="0">
                        <tr>
                            <td align="left">
                               <asp:Label ID="Label9" runat="server" Text="Địa chỉ liên hệ" CssClass="labelPrint"></asp:Label>
                            </td>
                            <td align="left">
                                <asp:Label ID="Label10" runat="server" Text="Địa chỉ thường trú" CssClass="labelPrint"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="left"  class="tableBorderPrint" style="height:15px">
                                <asp:Label ID="lbLive" runat="server" Text=""  CssClass="labelPrint"></asp:Label>
                            </td>
                            <td align="left"  class="tableBorderPrint" style="height:15px">
                                <asp:Label ID="lbResident" runat="server" Text=""  CssClass="labelPrint"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>                    
                    <table width="100%">
                        <tr>
                            <td style="width:70%"  align="left">                                
                                <table width="100%" cellpadding="4">
                                    <tr>
                                        <td  align="left" class="style2"><asp:Label ID="Label11" runat="server" Text="CMND" CssClass="labelPrint"></asp:Label></td>
                                        <td align="right">
                                            <table class="tableBorderPrint" width="100%" cellpadding="4">
                                                <tr>
                                                    <td  align="left"><asp:Label ID="Label12" runat="server" Text="[Số]" CssClass="labelPrint"></asp:Label></td>
                                                    <td>
                                                        <asp:Label ID="lbIdCard" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td  align="left"<asp:Label ID="Label13" runat="server" Text="[Ngày cấp]" CssClass="labelPrint"></asp:Label></td>
                                                    <td>
                                                        <asp:Label ID="lbIdDateOfIssue" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td  align="left"><asp:Label ID="Label14" runat="server" Text="[Nơi cấp]" CssClass="labelPrint"></asp:Label> </td>
                                                    <td>
                                                        <asp:Label ID="lbIdPlaceOfIssue" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td  align="left" class="style2"><asp:Label ID="Label15" runat="server" Text="Quê quán" CssClass="labelPrint"></asp:Label></td>
                                        <td align="right">
                                            <table class="tableBorderPrint" width="100%" cellpadding="4">
                                            <tr>
                                                <td style="height:15px">
                                                    <asp:Label ID="lbHomeTownAddress" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                                </td>
                                            </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td  align="left" class="style2"><asp:Label ID="Label16" runat="server" Text="Điện thoại nhà / di động" CssClass="labelPrint"></asp:Label></td>
                                        <td align="right">
                                            <table class="tableBorderPrint" width="100%" cellpadding="4">
                                            <tr>
                                                <td style="height:15px">
                                                    <asp:Label ID="lbHandPhone" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                                </td>
                                            </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td  align="left" class="style2"><asp:Label ID="Label18" runat="server" Text="Email" CssClass="labelPrint"></asp:Label></td>
                                        <td align="right">
                                            <table class="tableBorderPrint" width="100%" cellpadding="4">
                                            <tr>
                                                <td style="height:15px">
                                                    <asp:Label ID="lbEmail" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                                </td>
                                            </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td  align="left" class="style2"><asp:Label ID="Label17" runat="server" Text="Điện thoại cơ quan" CssClass="labelPrint" Visible="false"></asp:Label></td>
                                        <td align="right">
                                            <table width="100%" cellpadding="4">
                                            <tr>
                                                <td style="height:15px">
                                                    <asp:Label ID="lbWorkingPhone" runat="server" Text="a" CssClass="labelPrint" Visible="false"></asp:Label>
                                                </td>
                                            </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    
                                </table>
                            </td>
                            <td align="center" valign="middle">  
                                <table class="tableBorderPrint" cellpadding="4" style="width:100px; height:150px">
                                    <tr>
                                        <td align="center" valign="middle">
                                            <asp:Label ID="Label22" runat="server" Text="Dán ảnh" CssClass="labelPrint"></asp:Label>
                                        </td>
                                    </tr>
                                </table>                              
                            </td>
                        </tr>
                    </table>                   
                </td>
            </tr>
            <tr>
                <td style="height:15px"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label23" runat="server" Text="B - TRÌNH ĐỘ HỌC VẤN, CÁC LỚP ĐÀO TẠO (CAO CẤP NHẤT)" CssClass="labelPrintTitleLeft"></asp:Label></td>
            </tr>
            <tr>
                <td style="height:5px"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label24" runat="server" Text="1-HỌC VẤN" CssClass="labelPrintTitleLeftSub"></asp:Label></td>
            </tr>
            <tr>
                <td>
                   <asp:GridView ID="grdEducation" runat="server" Width="100%" AutoGenerateColumns="False"  OnRowDataBound="grdEducation_RowDataBound" CssClass="tableBorderPrint">
                        <Columns>
                            <asp:TemplateField HeaderText="Trình độ học vấn">
                                <ItemTemplate>
                                    <asp:Label ID="lbTraining_Job" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" Height="15px"/>
                                <HeaderStyle Width="20%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Năm" >                                    
                                <ItemTemplate>
                                    <asp:Label ID="lbYear" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center"  Height="15px"/>
                                <HeaderStyle Width="12%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Tên trường">
                                <ItemTemplate>
                                    <asp:Label ID="lbSchool_Position" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left"  Height="15px"/>
                                <HeaderStyle Width="28%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Chuyên ngành" >                                    
                                <ItemTemplate>
                                    <asp:Label ID="lbMajor_Salary" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left"  Height="15px"/>
                                <HeaderStyle Width="28%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Năm tốt nghiệp" >
                                <ItemTemplate>
                                    <asp:Label ID="lbGraduateYear_LeaveReason" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center"  Height="15px"/>
                                <HeaderStyle Width="12%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                                                                 
                        </Columns>
                        <RowStyle CssClass="labelPrint" />
                        <AlternatingRowStyle CssClass="labelPrint" />                       
                        <HeaderStyle CssClass="labelPrintBold"/>
                    </asp:GridView>
                    
                </td>
            </tr>
            <tr>
                <td style="height:5px"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label25" runat="server" Text="2-ĐÀO TẠO (ĐÃ HOÀN TẤT)" CssClass="labelPrintTitleLeftSub"></asp:Label></td>
            </tr>
            <tr>
                <td>
                   <asp:GridView ID="grdTraining" runat="server" Width="100%" AutoGenerateColumns="False"  OnRowDataBound="grdTraining_RowDataBound" CssClass="tableBorderPrint">
                        <Columns>
                            <asp:TemplateField HeaderText="Môn học">
                                <ItemTemplate>
                                    <asp:Label ID="lbTraining_Job" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left"  Height="15px"/>
                                <HeaderStyle Width="25%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Năm" >                                    
                                <ItemTemplate>
                                    <asp:Label ID="lbYear" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center"  Height="15px"/>
                                <HeaderStyle Width="15%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Tên trường">
                                <ItemTemplate>
                                    <asp:Label ID="lbSchool_Position" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" />
                                <HeaderStyle Width="30%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Kết quả đạt được" >                                    
                                <ItemTemplate>
                                    <asp:Label ID="lbMajor_Salary" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" />
                                <HeaderStyle Width="30%" HorizontalAlign="Center" />
                            </asp:TemplateField>                           
                                                                 
                        </Columns>
                        <RowStyle CssClass="labelPrint" />
                        <AlternatingRowStyle CssClass="labelPrint" />                       
                        <HeaderStyle CssClass="labelPrintBold"/>
                    </asp:GridView>
                    
                </td>
            </tr>
            <tr>
                <td style="height:5px"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label26" runat="server" Text="3-ĐÀO TẠO (CHƯA HOÀN TẤT)" CssClass="labelPrintTitleLeftSub"></asp:Label></td>
            </tr>
            <tr>
                <td>
                   <asp:GridView ID="grdTrainingIncomplete" runat="server" Width="100%" AutoGenerateColumns="False"  OnRowDataBound="grdTrainingIncomplete_RowDataBound" CssClass="tableBorderPrint">
                        <Columns>
                            <asp:TemplateField HeaderText="Môn học">
                                <ItemTemplate>
                                    <asp:Label ID="lbTraining_Job" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left"  Height="15px"/>
                                <HeaderStyle Width="25%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Năm" >                                    
                                <ItemTemplate>
                                    <asp:Label ID="lbYear" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                                <HeaderStyle Width="15%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Tên trường">
                                <ItemTemplate>
                                    <asp:Label ID="lbSchool_Position" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" />
                                <HeaderStyle Width="30%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Kết quả đạt được" >                                    
                                <ItemTemplate>
                                    <asp:Label ID="lbMajor_Salary" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" />
                                <HeaderStyle Width="30%" HorizontalAlign="Center" />
                            </asp:TemplateField>                           
                                                                 
                        </Columns>
                        <RowStyle CssClass="labelPrint" />
                        <AlternatingRowStyle CssClass="labelPrint" />                       
                        <HeaderStyle CssClass="labelPrintBold"/>
                    </asp:GridView>
                    
                </td>
            </tr>
            <tr>
                <td style="height:5px"></td>
            </tr>
             <tr>
                <td><asp:Label ID="Label27" runat="server" Text="4-NGOẠI NGỮ / VI TÍNH" CssClass="labelPrintTitleLeftSub"></asp:Label></td>
            </tr>
            <tr>
                <td>
                   <asp:GridView ID="grdEnglishComputer" runat="server" Width="100%" 
                        AutoGenerateColumns="False"  OnRowDataBound="grdEnglishComputer_RowDataBound" 
                        CssClass="tableBorderPrint" ShowHeader="False">
                        <Columns>
                            <asp:TemplateField HeaderText="Môn học">
                                <ItemTemplate>
                                    <asp:Label ID="lbTraining_Job" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" Width="25%"  Height="15px"/>
                                <HeaderStyle Width="25%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Kết quả đạt được" >                                    
                                <ItemTemplate>
                                    <asp:Label ID="lbMajor_Salary" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" Width="75%" />
                                <HeaderStyle Width="75%" HorizontalAlign="Center" />
                            </asp:TemplateField>                                                                                            
                        </Columns>
                        <RowStyle CssClass="labelPrint" />
                        <AlternatingRowStyle CssClass="labelPrint" />                       
                        <HeaderStyle CssClass="labelPrintBold"/>
                    </asp:GridView>
                    
                </td>
            </tr>
             <tr>
                <td style="height:15px"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label28" runat="server" Text="C - QUÁ TRÌNH LÀM VIỆC (BẮT ĐẦU VỚI CÔNG VIỆC GẦN NHẤT)" CssClass="labelPrintTitleLeft"></asp:Label></td>
            </tr>
             <tr>
                <td style="height:5px"></td>
            </tr>
            <tr>
                <td>
                   <asp:GridView ID="grdJob" runat="server" Width="100%" AutoGenerateColumns="False"  OnRowDataBound="grdJob_RowDataBound" CssClass="tableBorderPrint">
                        <Columns>
                            <asp:TemplateField HeaderText="Tên công ty/cơ quan">
                                <ItemTemplate>
                                    <asp:Label ID="lbTraining_Job" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left"  Height="15px"/>
                                <HeaderStyle Width="28%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Vị trí">
                                <ItemTemplate>
                                    <asp:Label ID="lbSchool_Position" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" />
                                <HeaderStyle Width="20%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Năm (từ-đến)" >                                    
                                <ItemTemplate>
                                    <asp:Label ID="lbYear" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                                <HeaderStyle Width="12%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Tiền lương" >                                    
                                <ItemTemplate>
                                    <asp:Label ID="lbMajor_Salary" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" />
                                <HeaderStyle Width="12%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Lý do thôi việc" >
                                <ItemTemplate>
                                    <asp:Label ID="lbGraduateYear_LeaveReason" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                                <HeaderStyle Width="28%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                                                                 
                        </Columns>
                        <RowStyle CssClass="labelPrint" />
                        <AlternatingRowStyle CssClass="labelPrint" />                       
                        <HeaderStyle CssClass="labelPrintBold"/>
                    </asp:GridView>
                    
                </td>
            </tr>
            <tr>
                <td style="height:15px"></td>
            </tr>
             <tr>
                <td><asp:Label ID="Label29" runat="server" Text="D - KINH NGHIỆM LÀM VIỆC (BẮT ĐẦU VỚI CÔNG VIỆC GẦN NHẤT)" CssClass="labelPrintTitleLeft"></asp:Label></td>
            </tr>
             <tr>
                <td style="height:5px"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label30" runat="server" Text="Mô tả chi tiết kinh nghiệm làm việc (mỗi ô tương ứng với thứ tự các ô được liệt kê trong phần C)" CssClass="labelPrint"></asp:Label></td>
            </tr>
            <tr>
                <td>
                   <asp:GridView ID="grdExperience" runat="server" Width="100%" AutoGenerateColumns="False"  OnRowDataBound="grdExperience_RowDataBound" CssClass="tableBorderPrint" ShowHeader="false">
                        <Columns>
                            <asp:TemplateField HeaderText="Tên công ty/cơ quan">
                                <ItemTemplate>
                                    <asp:Label ID="lbExperience" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left"  Height="15px"/>
                                <HeaderStyle Width="28%" HorizontalAlign="Center" />
                            </asp:TemplateField>                                             
                        </Columns>
                        <RowStyle CssClass="labelPrint" />
                        <AlternatingRowStyle CssClass="labelPrint" />                       
                        <HeaderStyle CssClass="labelPrintBold"/>
                    </asp:GridView>                    
                </td>
            </tr>           
             <tr>
                <td style="height:5px"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label32" runat="server" Text="Những kỹ năng hoặc kinh nghiệm khác có liên quan trực tiếp đến vị trí dự tuyển" CssClass="labelPrint"></asp:Label></td>
            </tr>
            <tr>
                <td>
                   <asp:GridView ID="grdExperienceOther" runat="server" Width="100%" AutoGenerateColumns="False"  OnRowDataBound="grdExperienceOther_RowDataBound" CssClass="tableBorderPrint" ShowHeader="false">
                        <Columns>
                            <asp:TemplateField HeaderText="Tên công ty/cơ quan">
                                <ItemTemplate>
                                    <asp:Label ID="lbExperience" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left"  Height="15px"/>
                                <HeaderStyle Width="28%" HorizontalAlign="Center" />
                            </asp:TemplateField>                                             
                        </Columns>
                        <RowStyle CssClass="labelPrint" />
                        <AlternatingRowStyle CssClass="labelPrint" />                       
                        <HeaderStyle CssClass="labelPrintBold"/>
                    </asp:GridView>                    
                </td>
            </tr>
            <tr>
                <td style="height:15px"></td>
            </tr>
             <tr>
                <td><asp:Label ID="Label31" runat="server" Text="E - TIỀN LƯƠNG" CssClass="labelPrintTitleLeft"></asp:Label></td>
            </tr>
             <tr>
                <td style="height:5px"></td>
            </tr>
            <tr>
                <td align="left">
                    <table cellpadding="0" cellspacing="0" border="0">
                        <tr>
                            <td rowspan="2" valign="middle"><asp:Label ID="Label35" runat="server" 
                                    Text="Tiền lương hiện nay / mỗi tháng" CssClass="labelPrint"></asp:Label>&nbsp;&nbsp;</td>
                            <td align="center"><asp:Label ID="Label33" runat="server" Text="VND" CssClass="labelPrint"></asp:Label></td>
                            <td rowspan="2" valign="middle" style="width:50px"></td>
                            <td rowspan="2" valign="middle"><asp:Label ID="Label36" runat="server" 
                                    Text="Tiền lương đề nghị / mỗi tháng" CssClass="labelPrint"></asp:Label>&nbsp;&nbsp;</td>
                            <td align="center"><asp:Label ID="Label34" runat="server" Text="VND" CssClass="labelPrint"></asp:Label></td>
                        </tr>
                        <tr>
                            <td align="center">
                                <table class="tableBorderPrint" cellpadding="4">
                                    <tr>
                                        <td align="center" valign="middle" style="height:15px; width:100px;">
                                            <asp:Label ID="lbSalary_Present" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                        </td>
                                    </tr>
                                </table>   
                            </td>
                            <td align="center">
                                <table class="tableBorderPrint" cellpadding="4">
                                    <tr>
                                        <td align="center" valign="middle" style="height:15px; width:100px;">
                                            <asp:Label ID="lbSalary_Offer" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                        </td>
                                    </tr>
                                </table>  
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="height:15px"></td>
            </tr>
             <tr>
                <td><asp:Label ID="Label37" runat="server" Text="F - HỢP ĐỒNG LAO ĐỘNG HIỆN TẠI" CssClass="labelPrintTitleLeft"></asp:Label></td>
            </tr>
             <tr>
                <td style="height:5px"></td>
            </tr>
            <tr>
                <td align="left">
                    <table>
                        <tr>
                            <td  align="left">
                                <asp:Label ID="Label38" runat="server" Text="Bạn có ký HĐLĐ với công ty/cơ quan hiện đang làm việc không?" CssClass="labelPrint"></asp:Label>&nbsp;&nbsp;
                            </td>
                            <td align="left">
                                <table class="tableBorderPrint" width="100px" cellpadding="4">
                                <tr>
                                    <td align="center" style="height:15px; width:100px;">
                                        <asp:Label ID="lbContract_YesNo" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                    </td>
                                </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="left"><asp:Label ID="Label41" runat="server" Text="Nếu Có thì trả lời các câu hỏi sau:" CssClass="labelPrint"></asp:Label></td>
            </tr>
            <tr>
                <td align="left">
                    <table>
                        <tr>
                            <td align="left">
                                <asp:Label ID="Label39" runat="server" Text="- HĐLĐ có hiệu lực đến ngày?" CssClass="labelPrint"></asp:Label>&nbsp;&nbsp;
                            </td>
                            <td align="left">
                                <table class="tableBorderPrint" width="100px" cellpadding="4">
                                <tr>
                                    <td align="center" style="height:15px; width:100px;">
                                        <asp:Label ID="lbContract_Present_Date" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                    </td>
                                </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:Label ID="Label40" runat="server" Text="- Bạn có thể kết thúc HĐLĐ không?" CssClass="labelPrint"></asp:Label>&nbsp;&nbsp;
                            </td>
                            <td align="left">
                                <table class="tableBorderPrint" width="100px" cellpadding="4">
                                <tr>
                                    <td align="center" style="height:15px; width:100px;">
                                        <asp:Label ID="lbContract_Present_End" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                    </td>
                                </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:Label ID="Label42" runat="server" Text="- Khi nào bạn có thể bắt đầu tham gia đào tạo nếu được tuyển dụng?" CssClass="labelPrint"></asp:Label>&nbsp;&nbsp;
                            </td>
                            <td align="left">
                                <table class="tableBorderPrint" width="100px" cellpadding="4">
                                <tr>
                                    <td align="center" style="height:15px; width:100px;">
                                        <asp:Label ID="lbContract_New_StartDate" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                    </td>
                                </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>         
            <tr>
                <td style="height:15px"></td>
            </tr>
             <tr>
                <td><asp:Label ID="Label43" runat="server" Text="G - SỨC KHỎE" CssClass="labelPrintTitleLeft"></asp:Label></td>
            </tr>
             <tr>
                <td style="height:5px"></td>
            </tr>
            <tr>
                <td align="left">
                    <table>
                        <tr>
                            <td  align="left">
                                <asp:Label ID="Label44" runat="server" Text="- Tình trạng sức khỏe hiện nay? Tốt/Bình thường/Khác (nêu rõ)" CssClass="labelPrint"></asp:Label>&nbsp;&nbsp;
                            </td>
                            <td align="left">
                                <table class="tableBorderPrint" width="100%" cellpadding="4">
                                <tr>
                                    <td align="center" style="height:15px; width:100px;">
                                        <asp:Label ID="lbHealth_Present" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                    </td>
                                </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td  align="left">
                                <asp:Label ID="Label45" runat="server" Text="- Bạn có khuyết tật về hình thể không? Nếu có xin cho biết chi tiết:" CssClass="labelPrint"></asp:Label>&nbsp;&nbsp;
                            </td>
                            <td align="left">
                                <table class="tableBorderPrint" width="100%" cellpadding="4">
                                <tr>
                                    <td align="center" style="height:15px; width:100px;">
                                        <asp:Label ID="lbHealth_Body" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                    </td>
                                </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="height:15px"></td>
            </tr>
             <tr>
                <td><asp:Label ID="Label46" runat="server" Text="H - LÝ LỊCH GIA ĐÌNH" CssClass="labelPrintTitleLeft"></asp:Label></td>
            </tr>
             <tr>
                <td style="height:5px"></td>
            </tr>
            <tr>
                <td>
                   <asp:GridView ID="grdFatherMother" runat="server" Width="100%" AutoGenerateColumns="False"  OnRowDataBound="grdFatherMother_RowDataBound" CssClass="tableBorderPrint">
                        <Columns>
                            <asp:TemplateField HeaderText="Bố mẹ, Vợ/Chồng, Con, Anh chị em ruột">
                                <ItemTemplate>
                                    <asp:Label ID="lbTraining_Job" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left"  Height="15px"/>
                                <HeaderStyle Width="15%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Họ tên">
                                <ItemTemplate>
                                    <asp:Label ID="lbSchool_Position" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" />
                                <HeaderStyle Width="25%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Ngày sinh" >                                    
                                <ItemTemplate>
                                    <asp:Label ID="lbYear" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                                <HeaderStyle Width="15%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Nghề nghiệp" >                                    
                                <ItemTemplate>
                                    <asp:Label ID="lbMajor_Salary" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" />
                                <HeaderStyle Width="45%" HorizontalAlign="Center" />
                            </asp:TemplateField>                           
                                                                 
                        </Columns>
                        <RowStyle CssClass="labelPrint" />
                        <AlternatingRowStyle CssClass="labelPrint" />                       
                        <HeaderStyle CssClass="labelPrintBold"/>
                    </asp:GridView>
                    
                </td>
            </tr>
            <tr>
                <td align="left">
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <td  align="left">
                                <asp:Label ID="Label47" runat="server" Text="Bạn có người thân nào đang làm việc cho Công ty cổ phần PVMĐ Sài Gòn không?" CssClass="labelPrint"></asp:Label>&nbsp;&nbsp;
                            </td>
                            <td align="left">
                                <table class="tableBorderPrint" width="100px" cellpadding="4">
                                <tr>
                                    <td align="center">
                                        <asp:Label ID="lbSAGS_Family" runat="server" Text="" CssClass="labelPrint"></asp:Label>
                                    </td>
                                </tr>
                                </table>
                            </td>
                        </tr>                        
                    </table>
                </td>
            </tr>
            
            <tr>
                <td align="left"><asp:Label ID="Label48" runat="server" Text="Nếu Có, điền các thông tin dưới đây:" CssClass="labelPrint"></asp:Label></td>            
            </tr>
            <tr>
                <td>
                   <asp:GridView ID="grdSAGSFamily" runat="server" Width="100%" AutoGenerateColumns="False"  OnRowDataBound="grdSAGSFamily_RowDataBound" CssClass="tableBorderPrint">
                        <Columns>
                            <asp:TemplateField HeaderText="Tên người thân">
                                <ItemTemplate>
                                    <asp:Label ID="lbTraining_Job" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left"   Height="15px"/>
                                <HeaderStyle Width="35%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Bộ phận làm việc">
                                <ItemTemplate>
                                    <asp:Label ID="lbSchool_Position" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" />
                                <HeaderStyle Width="35%" HorizontalAlign="Center" />
                            </asp:TemplateField>                                                       
                            <asp:TemplateField HeaderText="Mối quan hệ" >                                    
                                <ItemTemplate>
                                    <asp:Label ID="lbMajor_Salary" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" />
                                <HeaderStyle Width="30%" HorizontalAlign="Center" />
                            </asp:TemplateField>                           
                                                                 
                        </Columns>
                        <RowStyle CssClass="labelPrint" />
                        <AlternatingRowStyle CssClass="labelPrint" />                       
                        <HeaderStyle CssClass="labelPrintBold"/>
                    </asp:GridView>
                    
                </td>
            </tr>
             <tr>
                <td style="height:15px"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label49" runat="server" Text="I - NGUỒN XÁC MINH THÔNG TIN" CssClass="labelPrintTitleLeft"></asp:Label></td>
            </tr>
             <tr>
                <td style="height:5px"></td>
            </tr>
            <tr>
                <td align="left"><asp:Label ID="Label50" runat="server" Text="Vui lòng điền hai thông tin xác minh:" CssClass="labelPrint"></asp:Label></td>            
            </tr>
             <tr>
                <td>
                   <asp:GridView ID="grdInforConfirm" runat="server" Width="100%" AutoGenerateColumns="False"  OnRowDataBound="grdInforConfirm_RowDataBound" CssClass="tableBorderPrint">
                        <Columns>
                            <asp:TemplateField HeaderText="Họ tên">
                                <ItemTemplate>
                                    <asp:Label ID="lbTraining_Job" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left"   Height="15px"/>
                                <HeaderStyle Width="15%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Công ty/Cơ quan">
                                <ItemTemplate>
                                    <asp:Label ID="lbSchool_Position" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" />
                                <HeaderStyle Width="25%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Mối quan hệ" >                                    
                                <ItemTemplate>
                                    <asp:Label ID="lbMajor_Salary" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" />
                                <HeaderStyle Width="45%" HorizontalAlign="Center" />
                            </asp:TemplateField>     
                            <asp:TemplateField HeaderText="Số điện thoại" >                                    
                                <ItemTemplate>
                                    <asp:Label ID="lbYear" runat="server"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                                <HeaderStyle Width="15%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                        </Columns>
                        <RowStyle CssClass="labelPrint" />
                        <AlternatingRowStyle CssClass="labelPrint" />                       
                        <HeaderStyle CssClass="labelPrintBold"/>
                    </asp:GridView>
                    
                </td>
            </tr>
            <tr>
                <td style="height:15px"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label51" runat="server" Text="CAM KẾT" CssClass="labelPrintTitleLeft"></asp:Label></td>
            </tr>
            <tr>
                <td style="height:5px"></td>
            </tr>
            <tr>
                <td align="left">
                    <asp:Label ID="Label52" runat="server" CssClass="labelPrint" Text="- Tôi cam kết mọi thông tin do tôi cung cấp trong đơn dự tuyển là hoàn toàn chính xác."></asp:Label>
                </td>                                                                                                                               
            </tr>                                                          
                <tr>
                <td align="left">
                    <asp:Label ID="Label53" runat="server" CssClass="labelPrint" Text=" - Nêu SAGS phát hiện có bất kỳ thông tin sai lệch nào, SAGS có quyền chấm dứt khóa đào tạo hoặc chấm dứt Hợp đồng lao động đối với tôi."></asp:Label>
                </td>                                                                                                                             
            </tr>
            <tr>
                <td align="left">
                    <asp:Label ID="Label54" runat="server" CssClass="labelPrint" Text=" - Tôi cam kết tuân thủ các quy định về tuyển dụng của SAGS."></asp:Label>
                </td>                                                                                                                             
            </tr>
            <tr>
                <td style="height:5px"></td>
            </tr>
            <tr>
                <td align="left">
                    <table width="100%" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                            <td style="width:40%">
                                <asp:Label ID="Label55" runat="server" CssClass="labelPrint" Text="Ngày/Chữ ký/Họ và tên" Font-Bold="true" Font-Underline="true"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label56" runat="server" CssClass="labelPrint" Text="Hồ sơ đính kèm" Font-Bold="true" Font-Underline="true"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:5px"></td>
                            </tr>
                         <tr>
                            <td colspan="2">
                                <table class="tableBorderPrint" cellpadding="4" width="100%">
                                    <tr>
                                        <td class="tableBorderPrint"  style="width:40%" align="left">
                                            <asp:Label ID="Label57" runat="server" CssClass="labelPrint" Text="Ngày/tháng/năm"></asp:Label><br />
                                            <asp:Label ID="Label58" runat="server" CssClass="labelPrint" Text="Chữ ký"></asp:Label><br /><br /><br /><br /><br /><br /><br />
                                            <asp:Label ID="Label59" runat="server" CssClass="labelPrint" Text="Họ tên"></asp:Label>
                                        </td>
                                        <td class="tableBorderPrint" align="left" valign="top">
                                            
                                        <span class="style1"><asp:Literal ID="lbCV_Content" runat="server" Text=""></asp:Literal></span></td>
                                    </tr>                                    
                                </table>
                            </td>                           
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="height:15px"></td>
            </tr>
            <tr>
                <td align="center"><asp:Label ID="Label60" runat="server" Text="PHẦN DÀNH RIÊNG CHO NỘI BỘ" CssClass="labelPrintTitleLeft"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <table class="tableBorderPrint" cellpadding="4" width="100%">
                        <tr>
                            <td class="tableBorderPrint">
                                <asp:Label ID="Label61" runat="server" CssClass="labelPrint" Text="Tên người đánh giá:"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="tableBorderPrint">
                                <%--<table>
                                    <tr>
                                        <asp:Label ID="Label3" runat="server" CssClass="labelPrint" Text="Nhận xét:"></asp:Label>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label71" runat="server" CssClass="labelPrint" Text="Hồ sơ dự tuyển đầy đủ theo yêu cầu"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox2" runat="server" BorderStyle="Solid" Width="30px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label19" runat="server" CssClass="labelPrint" Text="Hồ sơ dự tuyển chưa đạt cần bổ sung"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox3" runat="server" BorderStyle="Solid" Width="30px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label72" runat="server" CssClass="labelPrint" Text="________________________________________________________________________________________________"></asp:Label>
                                        </td>
                                        
                                    </tr>
                                </table>--%>
                                <asp:Label ID="Label62" runat="server" CssClass="labelPrint" Text="Nhận xét:"></asp:Label><br />
                                <asp:Label ID="Label69" runat="server" CssClass="labelPrint" Text="▢ Hồ sơ dự tuyển đầy đủ theo yêu cầu"></asp:Label><br />
                                <asp:Label ID="Label70" runat="server" CssClass="labelPrint" Text="▢ Hồ sơ dự tuyển chưa đạt cần bổ sung"></asp:Label><br />
                                <asp:Label ID="Label63" runat="server" CssClass="labelPrint" Text="________________________________________________________________________________________________"></asp:Label><br />
                                <asp:Label ID="Label64" runat="server" CssClass="labelPrint" Text="________________________________________________________________________________________________"></asp:Label><br />
                                <asp:Label ID="Label65" runat="server" CssClass="labelPrint" Text="________________________________________________________________________________________________"></asp:Label><br />
                                <asp:Label ID="Label66" runat="server" CssClass="labelPrint" Text="________________________________________________________________________________________________"></asp:Label><br />
                                <asp:Label ID="Label67" runat="server" CssClass="labelPrint" Text="________________________________________________________________________________________________"></asp:Label><br />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>  
    </form>
</body>
</html>
