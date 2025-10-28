<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ControlBoardVoteCountList.aspx.cs" Inherits="ShareHolder_ControlBoardVoteCountList" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="../UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table style="width: 100%">
   <tr>
       <td valign="top" >
        <table style="width: 100%" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <uc1:ucTitle ID="UcTitle1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                      <table width="100%">
                            <tr>          
                             <td style="width:20%" align="left">                                                                       
                                    <uc2:ActionMenu ID="ActionMenu1" runat="server" />
                                </td>      
                                <td align="right">
                                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên"></asp:Label>

                                        <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox" Width="200px"></asp:TextBox>
                                    &nbsp;
                                        &nbsp;&nbsp;
                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Mã cổ đông"></asp:Label>
                                        <asp:TextBox ID="txtInvestor" runat="server" CssClass="textBox" Width="100px"></asp:TextBox>
                                       <%-- &nbsp;
                                        &nbsp;&nbsp;
                                        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Xác nhận"></asp:Label>
                                        <asp:DropDownList ID="ddlConfirmStocks" runat="server" CssClass="dropDownList">
                                        <asp:ListItem Text="" Value="-1"></asp:ListItem>
                                        <asp:ListItem Text="Tham dự" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Ủy quyền" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="Ko tham dự" Value="0"></asp:ListItem>                                        
                                        </asp:DropDownList>--%>
                                        &nbsp; &nbsp;<asp:Button ID="imgSearch" runat="server"
                                            OnClick="imgSearch_Click" Text="Xem" Width="100px" CssClass="small color green button"/>
                                        &nbsp; 
                                        <asp:HyperLink ID="lnkReport" runat="server" CssClass="hyperlink-Grid">Xem Kết Quả</asp:HyperLink>
                                        &nbsp;&nbsp;&nbsp;
                                </td>
                            </tr>
                                        
                        </table>      
                </td>
            </tr>           
            <tr>
                <td align="left">
                    <table class="tableBorder" width="100%" style="background-color:#d5d5d5" cellpadding="0" cellspacing="0">
                         <tr>
                            <td>
                                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                    DataSourceID="odsRepresentative" Width="100%" CellPadding="0" 
                                    OnRowDataBound="GridView2_RowDataBound" PageSize="20" AllowPaging="True" 
                                    ShowFooter="True">
                                    <Columns>
                                        <asp:TemplateField>
                                            <HeaderTemplate>
                                                <table style="width:100%" cellpadding="0" cellspacing="1">
                                                    <tr class="grid-header1" >
                                                        <td rowspan="2" style="width:110px" align="center">
                                                            MÃ CĐ</td>
                                                        <td rowspan="2" align="center" style="width:150px">
                                                            HỌ VÀ TÊN</td>                                                                
                                                        <td rowspan="2" align="center" style="width:70px">
                                                            SỐ CỔ PHẦN</td>   
                                                        <td rowspan="2" align="center" style="width:70px">
                                                            TỈ LỆ (%)</td>  
                                                        <td rowspan="2" align="center" style="width:70px">
                                                            XÁC NHẬN</td>                                                                                                             
                                                      <%--  <td colspan="8" align="center">
                                                            BẦU HỘI ĐỒNG QUẢN TRỊ</td>--%>
                                                        <td colspan="6" align="center">
                                                            BẦU BAN KIỂM SOÁT</td>
                                                        
                                                    </tr>
                                                    <tr class="grid-header1">
                                                       <%-- <td style="width:100px" align="center">
                                                            SL phiếu bầu</td>
                                                        <td style="width:100px" align="center">
                                                            UV1</td>
                                                        <td style="width:100px" align="center">
                                                            UV2</td>
                                                        <td style="width:100px" align="center">
                                                            UV3</td>
                                                        <td style="width:100px" align="center">
                                                            UV4</td>
                                                        <td style="width:100px" align="center">
                                                            UV5</td>
                                                        <td style="width:100px" align="center">
                                                            UV6</td>
                                                        <td style="width:100px" align="center">
                                                            UV7</td>--%>
                                                        <td style="width:100px" align="center">
                                                            Số cổ phần có quyền bầu cử (Đã quy đổi)</td>
                                                        <td style="width:100px" align="center">
                                                            SL đã bầu</td>
                                                        <td style="width:100px" align="center">
                                                            1.MS.LINH</td>
                                                        <td style="width:100px" align="center">
                                                            2.MS.THẢO</td>
                                                        <td style="width:100px" align="center">
                                                            3.MS.TRANG</td>  
                                                       <td style="width:100px" align="center">
                                                            Phiếu bầu</td>                                                                                                                                                                                                                              
                                                    </tr>                                        
                                            </HeaderTemplate>
                                             <ItemTemplate>
                                                <tr class="grid-item">
                                                    <td align="center">
                                                        <asp:Label ID="lbInvestorNo" CssClass="value" runat="server"></asp:Label></td>    
                                                    <td align="left">
                                                        <asp:Label ID="lbFullName" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbStock" CssClass="value" runat="server"></asp:Label></td>                                                   
                                                    <td align="right">
                                                        <asp:Label ID="lbStockRatio" CssClass="value" runat="server"></asp:Label></td>  
                                                    <td align="center">
                                                        <asp:Label ID="lbIsOk" CssClass="value" runat="server"></asp:Label></td>    
                                                    <%--<td align="right">
                                                        <asp:Label ID="lbHDQT_Vote" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbHDQT_A" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbHDQT_B" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbHDQT_C" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbHDQT_D" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbHDQT_E" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbHDQT_F" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbHDQT_G" CssClass="value-bold" runat="server"></asp:Label></td>--%>
                                                    <td align="right">
                                                        <asp:Label ID="lbBKS_Vote" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbTotal" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbBKS_A" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbBKS_B" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbBKS_C" CssClass="value-bold" runat="server"></asp:Label></td>
                                                   <td align="center">
                                                        <asp:Label ID="lbBKS_IsValid" CssClass="value" runat="server"></asp:Label></td>
                                                </tr>
                                            </ItemTemplate>
                                            <AlternatingItemTemplate>
                                                <tr class="grid-atlternating-item">
                                                    <td align="center">
                                                        <asp:Label ID="lbInvestorNo" CssClass="value" runat="server"></asp:Label></td>    
                                                    <td align="left">
                                                        <asp:Label ID="lbFullName" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbStock" CssClass="value" runat="server"></asp:Label></td>                                                   
                                                    <td align="right">
                                                        <asp:Label ID="lbStockRatio" CssClass="value" runat="server"></asp:Label></td>   
                                                    <td align="center">
                                                        <asp:Label ID="lbIsOk" CssClass="value" runat="server"></asp:Label></td>   
                                                  <%--  <td align="right">
                                                        <asp:Label ID="lbHDQT_Vote" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbHDQT_A" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbHDQT_B" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbHDQT_C" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbHDQT_D" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbHDQT_E" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbHDQT_F" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbHDQT_G" CssClass="value-bold" runat="server"></asp:Label></td>--%>
                                                    <td align="right">
                                                        <asp:Label ID="lbBKS_Vote" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbTotal" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbBKS_A" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbBKS_B" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbBKS_C" CssClass="value-bold" runat="server"></asp:Label></td> 
                                                    <td align="center">
                                                        <asp:Label ID="lbBKS_IsValid" CssClass="value" runat="server"></asp:Label></td>
                                                </tr>
                                            </AlternatingItemTemplate>   
                                            <FooterTemplate>
                                                </table>
                                            </FooterTemplate>                                            
                                        </asp:TemplateField>
                                    </Columns>
                                    <PagerSettings PageButtonCount="2" Mode="NextPreviousFirstLast" />                                    
                                    <PagerStyle CssClass="grid-paper"></PagerStyle>
                                </asp:GridView>
                                
                                                                
                                <asp:ObjectDataSource ID="odsRepresentative" runat="server" OnSelecting="odsRepresentative_Selecting"
                                    SelectMethod="GetByFilter" TypeName="HRMBLL.H4.RepresentativeBLL" 
                                    OldValuesParameterFormatString="original_{0}">
                                    <SelectParameters>
                                        <asp:Parameter Name="InvestorNo" Type="Int32" />
                                        <asp:Parameter Name="FullName" Type="String" />
                                        <asp:Parameter Name="IsOk" Type="Int32" />
                                        <asp:Parameter Name="KTTCDB" Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                                
                            </td>
                        </tr>
                    </table>  
                </td>
            </tr>
             
        </table>
      </td>
   </tr>
</table>
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>
<script type="text/javascript" src="../JScripts/script.js"></script>
</asp:Content>


