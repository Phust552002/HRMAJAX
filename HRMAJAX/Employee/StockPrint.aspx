<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockPrint.aspx.cs" Inherits="Employee_StockPrint" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

 p.MsoNormal
	{margin-bottom:.0001pt;
	font-size:12.0pt;
	font-family:"Times New Roman","serif";
	        margin-left: 0in;
            margin-right: 0in;
            margin-top: 0in;
        }
        .style2
        {
            font-weight: bold;
            font-size: 10.0pt;
        }
        .style3
        {
            text-align: center;
        }
        .style5
        {
            font-family: "Times New Roman", serif;
            font-size: 11pt;
        }
        .style6
        {
            color: black;
        }
        .style7
        {
            font-size: 9pt;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1" style="width:100%;border-collapse:collapse;">
        <tr>
            <td>
            
        <table width="100%" border="0">
            <tr>
                <td>
                    <b
style='mso-bidi-font-weight:normal'>
                    <span style='mso-fareast-font-family:"Arial Unicode MS";
' class="style6">Mã s&#7889; nhà &#273;&#7847;u t&#432;: 
                    </span><span style='mso-fareast-font-family:"Arial Unicode MS";
color:teal'> <asp:Label ID="lbInvestorNo" runat="server" 
                        Text="Label" CssClass="style6"></asp:Label>
                    <br />
                    <br />
                    </span></b></td>
            </tr>
            <tr>
                <td align="center">
                    <b
style='mso-bidi-font-weight:normal'><span style='font-size:16.0pt;mso-fareast-font-family:
"Arial Unicode MS";color:maroon'>PHI&#7870;U MUA C&#7892; PH&#7846;N</span></b></td>
            </tr>
            <tr>
                <td align="center" class="style5">
                    <strong>THEO
CHÍNH SÁCH &#431;U &#272;ÃI CHO NG&#431;&#7900;I LAO &#272;&#7896;NG TRONG
DOANH NGHI&#7878;P C&#7892; PH&#7846;N HÓA</strong><o:p></o:p></td>
            </tr>
            <tr>
                <td  align="right">
                                <span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><asp:Label ID="lbDate" runat="server" 
                                    Font-Names="Times New Roman" Font-Size="9pt" 
                        Font-Italic="True">TP.HCM, Ngày.... Tháng .... Năm</asp:Label>
                    </span></td>
            </tr>
            <tr>
                <td  align="center">
                    <span
style='font-size:11.0pt;mso-fareast-font-family:"Arial Unicode MS";font-style:
normal;mso-bidi-font-style:italic'><strong><em>Kính g&#7917;i</em></strong></span><span style='font-size:
11.0pt;mso-fareast-font-family:"Arial Unicode MS";font-weight:normal;
mso-bidi-font-weight:bold;font-style:normal;mso-bidi-font-style:italic'><strong><em>:</em></strong></span><span
style='font-size:11.0pt;mso-fareast-font-family:"Arial Unicode MS";font-weight:
normal;mso-bidi-font-weight:bold'><strong><em> </em> </strong> </span><span style='font-size:11.0pt;
mso-fareast-font-family:"Arial Unicode MS"'><strong><em>Ban Ch&#7881; &#272;&#7841;o C&#7893;
ph&#7847;n hóa Công ty TNHH MTV Ph&#7909;c V&#7909; M&#7863;t &#272;&#7845;t
Sài Gòn (SAGS)</em></strong></span><span style='font-size:11.0pt'><o:p></o:p></span></td>
            </tr>
            <tr>
                <td  align="center">
                    <b style='mso-bidi-font-weight:normal'><i
style='mso-bidi-font-style:normal'><span style='font-size:11.0pt;mso-fareast-font-family:
"Arial Unicode MS"'><span
style='mso-spacerun:yes'>&nbsp;</span>Ch&#7911;
t&#7883;ch - Giám &#273;&#7889;c </span></i></b><b style='mso-bidi-font-weight:
normal'><span style='font-size:11.0pt;mso-fareast-font-family:"Arial Unicode MS"'><i>Công
ty TNHH MTV Ph&#7909;c V&#7909; M&#7863;t &#272;&#7845;t Sài Gòn (SAGS)</i><i
style='mso-bidi-font-style:normal'><o:p></o:p></i></span></b></td>
            </tr>
            <tr>
                <td  align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <p class="MsoNormal">
                        <![if !supportLists]><span style="font-size:10.0pt">
                        <span style="mso-list:Ignore">-<span 
                            style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </span></span></span><![endif]>
                        <span style="font-size:10.0pt;mso-fareast-font-family:
&quot;Arial Unicode MS&quot;">Căn cứ Thông báo số 64/TB-TCHC ngày 26/11/2014 v.v nộp tiền mua cổ phần ưu 
                        đãi cho CB-CNV<o:p></o:p></span></p>
                    <p class="MsoNormal">
                        <![if !supportLists]><span style="font-size:10.0pt">
                        <span style="mso-list:Ignore">-<span 
                            style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </span></span></span><![endif]>
                        <span style="font-size:10.0pt;mso-fareast-font-family:
&quot;Arial Unicode MS&quot;">Căn cứ Phiếu cam kết mua cổ phần (đối với người lao động thuộc đối tượng 
                        SAGS cần sử dụng và có cam kết làm việc lâu dài cho SAGS).<o:p></o:p></span></p>
                </td>
            </tr>
            <tr>
                <td  align="left">
                    <span style="font-size:10.0pt;font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;
mso-fareast-font-family:&quot;Arial Unicode MS&quot;;mso-ansi-language:EN-US;mso-fareast-language:
EN-US;mso-bidi-language:AR-SA">Sau khi nghiên cứu và xem xét kỹ các quy định liên quan đến các chính 
                    sách ưu đãi cho người lao động trong doanh nghiệp cổ phần hóa, tôi mua cổ phần 
                    theo chính sách ưu đãi dành cho người lao động tại SAGS sau khi chuyển thành 
                    công ty cổ phần, cụ thể như sau:</span></td>
            </tr>
            <tr>
                <td>
                    <table width="100%" border="0">
                        <tr> 
                            <td><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'>Tên cá nhân:<asp:Label ID="lbFullName" runat="server" 
                                    style="font-weight: 700" Font-Names="Times New Roman" Font-Size="9pt"></asp:Label>
                                </span></td>   
                            <td><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'>&#272;i&#7879;n tho&#7841;i:<span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><asp:Label ID="lbHandPhone" runat="server" 
                                    Font-Names="Times New Roman"></asp:Label>
                                </span> </span></td>   
                            <td><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'>Email:……………………………<o:p></o:p></span></td>   
                        </tr>
                        <tr> 
                            <td><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'>S&#7889; CMND:<span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><asp:Label ID="lbIdCard" runat="server" 
                                    Font-Names="Times New Roman"></asp:Label>
                                </span> </span></td>   
                            <td><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'>C&#7845;p ngày:<span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><asp:Label ID="lbDateOfIssue" runat="server" 
                                    Font-Names="Times New Roman"></asp:Label>
                                </span> </span></td>   
                            <td><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'>C&#7845;p t&#7841;i:<span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><asp:Label ID="lbPlaceOfIssue" runat="server" 
                                    Font-Names="Times New Roman"></asp:Label>
                                </span> </span></td>   
                        </tr>
                        <tr> 
                            <td colspan="3"><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'>&#272;&#7883;a ch&#7881; liên l&#7841;c:<span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><asp:Label ID="lbLive" runat="server" 
                                    Font-Names="Times New Roman"></asp:Label>
                                </span>
  </span></td>   
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table width="100%"  border="1" style="border-collapse:collapse;">
                        <tr>
                            <td rowspan="2" align="center"   
                                font-size: 10pt; width:30%">
                                <strong>STT</strong><o:p></o:p></td>
                            <td rowspan="2" align="center" class="style2" style="width:10%">
                                Kh&#7889;i
  l&#432;&#7907;ng mua<o:p></o:p></td>
                            <td rowspan="2" align="center" class="style2" style="width:10%">
                                Giá mua<o:p></o:p></td>
                            <td colspan="2" align="center" class="style2">
                                Thành ti&#7873;n<o:p></o:p></td>
                        </tr>
                        <tr>
                            <td align="center" class="style2" style="width:20%">
                                B&#7857;ng s&#7889;<o:p></o:p></td>
                            <td align="center" class="style2" style="width:30%">
                                B&#7857;ng ch&#7919;<o:p></o:p></td>
                        </tr>
                        <tr>
                            <td>
                                <span
  style='font-size:10.0pt'>1. Mua c&#7893; ph&#7847;n theo m&#7913;c t&#7889;i
  &#273;a 100 c&#7893; ph&#7847;n cho m&#7895;i n&#259;m th&#7921;c t&#7871;
  làm vi&#7879;c t&#7841;i khu v&#7921;c nhà n&#432;&#7899;c<o:p></o:p></span></td>
                            <td align="center">
                                <span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><asp:Label ID="lbSeniorStockBought" runat="server"></asp:Label>
                                </span> </span></td>
                            <td align="center">
                                <span style='font-size:10.0pt'>8.400<o:p></o:p></span></td>
                            <td align="center">
                                <span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><asp:Label ID="lbSeniorStockBoughtMoney" runat="server"></asp:Label>
                                </span> </span></td>
                            <td align="left">
                                <span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><asp:Label ID="lbSeniorStockBoughtMoneyChar" runat="server" 
                                    Font-Names="Times New Roman" Font-Size="9pt"></asp:Label>
                                </span> </span></td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;<span
  style='font-size:10.0pt'>2. Mua c&#7893; ph&#7847;n theo s&#7889; n&#259;m làm
  cam k&#7871;t làm vi&#7879;c lâu dài cho SAGS<o:p></o:p></span></td>
                            <td align="center">
                                <span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><asp:Label ID="lbUnderTakingStockBought" runat="server"></asp:Label>
                                </span> </span></td>
                            <td align="center">
                                <span style='font-size:10.0pt'>14.000<o:p></o:p></span></td>
                            <td align="center">
                                <span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><asp:Label ID="lbUnderTakingStockBoughtMoney" runat="server"></asp:Label>
                                </span> </span></td>
                            <td align="left">
                                <span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><asp:Label ID="lbUnderTakingStockBoughtMoneyChar" runat="server" 
                                    Font-Names="Times New Roman" Font-Size="9pt"></asp:Label>
                                </span> </span></td>
                        </tr>
                        <tr>
                            <td>
                                <b style='mso-bidi-font-weight:normal'><span style='font-size:10.0pt'>T&#7893;ng
  c&#7897;ng<o:p></o:p></span></b></td>
                            <td align="center">
                                <span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><asp:Label ID="lbTotalStock" runat="server" Font-Bold="True"></asp:Label>
                                </span> </span></td>
                            <td align="center">
                                &nbsp;</td>
                            <td align="center">
                                <span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><asp:Label ID="lbTotalMoneyBought" runat="server" 
                                    Font-Bold="True"></asp:Label>
                                </span> </span></td>
                            <td align="left">
                                <span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'><asp:Label ID="lbTotalMoneyBoughtChar" runat="server" 
                                    Font-Bold="True" Font-Names="Times New Roman" Font-Size="9pt" 
                                    style="font-size: 9pt"></asp:Label>
                                </span> </span></td>
                        </tr>
                    </table>
                    </td>
            </tr>
            <tr>
                <td>
                    <p class="MsoNormal" style="text-align:justify">
                        <span style="font-size:10.0pt;
mso-fareast-font-family:&quot;Arial Unicode MS&quot;">Ghi chú:<o:p></o:p></span></p>
                    <p class="MsoNormal" style="margin-left:.25in;text-align:justify;text-indent:
-.25in;mso-list:l0 level1 lfo2">
                        <![if !supportLists]><span style="font-size:
10.0pt"><span style="mso-list:Ignore">1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </span></span></span><![endif]>
                        <span style="font-size:10.0pt;mso-fareast-font-family:
&quot;Arial Unicode MS&quot;">Người lao động mua </span><span style="font-size:10.0pt">cổ phần theo mức 
                        tối đa 100 cổ phần cho mỗi năm thực tế làm việc tại khu vực nhà nước: </span>
                        <span style="font-size:10.0pt;mso-fareast-font-family:&quot;Arial Unicode MS&quot;">
                        mức giá mua bằng 60% giá bán thành công thấp nhất cho các nhà đầu tư chiến lược.<o:p></o:p></span></p>
                    <p class="MsoNormal" style="margin-left:.25in;text-align:justify;text-indent:
-.25in;mso-list:l0 level1 lfo2">
                        <![if !supportLists]><span style="font-size:
10.0pt"><span style="mso-list:Ignore">2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </span></span></span><![endif]>
                        <span style="font-size:10.0pt;mso-fareast-font-family:
&quot;Arial Unicode MS&quot;">Người lao động mua </span><span style="font-size:10.0pt">cổ phần theo số 
                        năm làm cam kết làm việc lâu dài cho SAGS: </span>
                        <span style="font-size:10.0pt;mso-fareast-font-family:&quot;Arial Unicode MS&quot;">
                        mức giá mua bằng giá bán thành công thấp nhất cho các nhà đầu tư chiến lược. Tôi 
                        cam kết:<o:p></o:p></span></p>
                    <p class="MsoNormal" style="margin-left:27.0pt;text-align:justify;text-indent:
-9.0pt;mso-list:l1 level1 lfo1">
                        <![if !supportLists]><span style="font-size:
10.0pt"><span style="mso-list:Ignore">-<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;
                        </span></span></span><![endif]>
                        <span style="font-size:10.0pt;mso-fareast-font-family:
&quot;Arial Unicode MS&quot;">Nắm giữ số cổ phần mua thêm theo mục 2 này và sẽ được chuyển đổi thành cổ 
                        phần phổ thông sau khi kết thúc thời gian cam kết.<o:p></o:p></span></p>
                    <p class="MsoNormal" style="margin-left:27.0pt;text-align:justify;text-indent:
-9.0pt;mso-list:l1 level1 lfo1">
                        <![if !supportLists]><span style="font-size:
10.0pt;letter-spacing:-.3pt"><span style="mso-list:Ignore">-<span 
                            style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp; </span>
                        </span></span><![endif]>
                        <span style="font-size:10.0pt;mso-fareast-font-family:&quot;Arial Unicode MS&quot;;letter-spacing:
-.3pt">Trường hợp tôi chấm dứt hợp đồng lao động trước thời hạn đã cam kết thì tôi đồng ý bán lại cho 
                        Công ty toàn bộ số cổ phần đã được mua thêm với giá sát với giá giao dịch trên 
                        thị trường nhưng không vượt quá giá được mua này.<o:p></o:p></span></p>
                    <p class="MsoNormal" style="margin-left:27.0pt;text-align:justify;text-indent:
-9.0pt;mso-list:l1 level1 lfo1">
                        <![if !supportLists]><span style="font-size:
10.0pt"><span style="mso-list:Ignore">-<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;
                        </span></span></span><![endif]>
                        <span style="font-size:10.0pt;mso-fareast-font-family:
&quot;Arial Unicode MS&quot;">Trường hợp Công ty thực hiện tái cơ cấu dẫn tới tôi phải chấm dứt hợp đồng 
                        lao động, thôi việc, mất việc theo quy định của Bộ Luật Lao động trước thời hạn 
                        đã cam kết thì số cổ phần tôi đã được mua thêm sẽ được chuyển đổi thành cổ phần 
                        phổ thông. Trong trường hợp này, nếu tôi có nhu cầu bán lại cho Công ty số cổ 
                        phần này thì Công ty có trách nhiệm mua lại với giá sát với giá giao dịch trên 
                        thị trường.<o:p></o:p></span></p>
                    <p class="MsoNormal" style="margin-left:27.0pt;text-align:justify;text-indent:
-9.0pt;mso-list:l1 level1 lfo1">
                        <o:p></o:p>
                    </p>
                </td>
            </tr>
            <tr>
                <td>
                    <table width="100%" border="0">
                        <tr> 
                            <td style="width:50%">

                            </td>   
                            <td align="center">

                                <p class="MsoNormal">
                                    <b style="mso-bidi-font-weight:
normal"><span style="font-size:10.0pt;mso-bidi-font-size:12.0pt;mso-fareast-font-family:
&quot;Arial Unicode MS&quot;">Cá nhân mua cổ phần<o:p></o:p></span></b></p>
                                <p class="MsoNormal">
                                    <i style="mso-bidi-font-style:
normal"><span style="font-size:10.0pt;mso-bidi-font-size:12.0pt;mso-fareast-font-family:
&quot;Arial Unicode MS&quot;">Ký ghi rõ họ tên<o:p></o:p></span></i></p>

                            </td> 
                        </tr>
                    </table>
                    </td>
            </tr>
            <tr>
                <td>
                    <p class="MsoNormal">
                        &nbsp;</p>
                    <p class="MsoNormal">
                        &nbsp;</p>
                    <p class="MsoNormal">
                        &nbsp;</p>
                </td>
            </tr>
            <tr>
                <td>
                        <b style="mso-bidi-font-weight:normal">
                        <span style="mso-fareast-font-family:&quot;Arial Unicode MS&quot;;color:blue">
                        Xác nhận của Đơn vị nhận đăng ký mua cổ phần:</span></b></td>
            </tr>
            <tr>
                <td>
                        <span class="style7">1</span>.<span style="font-size:9.0pt;mso-bidi-font-size:12.0pt;
font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;mso-fareast-font-family:&quot;Arial Unicode MS&quot;;
mso-ansi-language:EN-US;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">Bản sao CMND: 
                        <asp:CheckBox ID="CheckBox1" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2.Nộp tiền mặt
                        <span style="font-size: 9.0pt; mso-bidi-font-size: 12.0pt; font-family: &quot;Times New Roman&quot;,&quot;serif&quot;; mso-fareast-font-family: &quot;Arial Unicode MS&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                        <asp:CheckBox ID="CheckBox2" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        3.Chứng từ thanh toán ngân hàng (CTNH):<asp:CheckBox ID="CheckBox3" 
                            runat="server" />
                        </span></span></td>
            </tr>
            <tr>
                <td>
                                <span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'>
                    <asp:Label ID="lbTotalMoneyBought0" runat="server" 
                                    Font-Bold="True"></asp:Label>
                    </span>
                    <span style="mso-bidi-font-size:12.0pt;mso-fareast-font-family:
  &quot;Arial Unicode MS&quot;" class="style7">&nbsp;&nbsp;</span><span style="font-size:10.0pt;mso-bidi-font-size:12.0pt;mso-fareast-font-family:
  &quot;Arial Unicode MS&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
                    <span style="mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:&quot;Arial Unicode MS&quot;">
                    <span style="mso-bidi-font-size:12.0pt;mso-fareast-font-family:
  &quot;Arial Unicode MS&quot;" class="style7">
                    <span style='font-size:10.0pt;mso-bidi-font-size:12.0pt;
  mso-fareast-font-family:"Arial Unicode MS"'>
                    <asp:Label ID="lbTotalMoneyBoughtChar0" runat="server" 
                                    Font-Bold="True" Font-Names="Times New Roman" Font-Size="9pt" 
                                    style="font-size: 9pt"></asp:Label>
                    </span></span></span></td>
            </tr>
            <tr>
                <td>
                <table border="0" width="100%">
                    <tr>
                        <td style="width:35%" class="style3">
                                    <b style="mso-bidi-font-weight:normal">
                                    <span style="font-size:10.0pt;mso-bidi-font-size:
  12.0pt;mso-fareast-font-family:&quot;Arial Unicode MS&quot;;color:blue">Người nộp tiền/CTNHH</span></b></td>
                        <td style="width:30%" class="style3">
                                    <b style="mso-bidi-font-weight:normal">
                                    <span style="font-size:10.0pt;mso-bidi-font-size:12.0pt;mso-fareast-font-family:
  &quot;Arial Unicode MS&quot;;color:blue">Người thu tiền/CTNH<o:p></o:p></span></b></td>
                        <td style="width:35%" class="style3">
                                    <b style="mso-bidi-font-weight:normal">
                                    <span style="font-size:10.0pt;mso-bidi-font-size:
  12.0pt;mso-fareast-font-family:&quot;Arial Unicode MS&quot;;color:blue">Nhân viên nhận phiếu<o:p></o:p></span></b></td>
                    </tr>
                </table>
                    </td>
            </tr>
               <tr>
                <td>
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
               </tr> 
        </table>    
            </td>
        </tr>
        </table>
    </div>
    </form>
</body>
</html>
