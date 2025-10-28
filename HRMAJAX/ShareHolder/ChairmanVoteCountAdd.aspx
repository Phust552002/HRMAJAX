<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ChairmanVoteCountAdd.aspx.cs" Inherits="ShareHolder_ChairmanVoteCountAdd" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

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
                            <td align="center" style="width: 80%">                                                                
                               <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên"></asp:Label>

                                        <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox" Width="200px"></asp:TextBox>
                                    &nbsp;
                                        &nbsp;&nbsp;
                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Mã cổ đông"></asp:Label>
                                        <asp:TextBox ID="txtInvestor" runat="server" CssClass="textBox" Width="200px"></asp:TextBox>
                                        &nbsp;
                                        &nbsp;&nbsp;
                                
                                <asp:Button ID="btnView" runat="server" Text="Xem" OnClick="btnView_Click" 
                                    CssClass="small color green button" Width="100px" TabIndex="100" />
                                &nbsp;
                                <asp:Button ID="btnCancel" runat="server" CssClass="small color green button" OnClick="btnCancel_Click"
                                    Text="Thoát" Width="100px" TabIndex="100" />
                                &nbsp; &nbsp;&nbsp;
                            </td>
                        </tr>
                    </table>    
                </td>
            </tr>           
            <tr>
                <td style="BACKGROUND-COLOR: #cccc99" valign="top" align="center"> 
                    <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" CssClass="small color red button" Text="Lưu" 
                        Width="150px" />
                </td>
            </tr>
            <tr>
                <td align="left">
                    <table class="tableBorder" width="100%" style="background-color:#d5d5d5" cellpadding="0" cellspacing="0">
                         <tr>
                            <td>
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                    DataSourceID="odsRepresentative" Width="100%" CellPadding="0" 
                                    OnRowDataBound="GridView1_RowDataBound" PageSize="20" AllowPaging="True" 
                                    OnPageIndexChanged="GridView1_PageIndexChanged">
                                    <Columns>
                                        <asp:TemplateField>
                                            <HeaderTemplate>
                                                <table style="width:100%" cellpadding="0" cellspacing="1">
                                                    <tr class="grid-header1" >
                                                        <td rowspan="2" style="width:100px" align="center">
                                                            MÃ CĐ</td>
                                                        <td rowspan="2" align="center">
                                                            HỌ VÀ TÊN</td>                                                                
                                                        <td rowspan="2" align="center">
                                                            SỐ CỔ PHẦN</td>   
                                                        <td rowspan="2" align="center">
                                                            TỈ LỆ (%)</td>                                                                                                              
                                                        <td colspan="8" align="center">
                                                            BẦU HỘI ĐỒNG QUẢN TRỊ</td>
                                                        <%--<td colspan="4" align="center">
                                                            BẦU BAN KIỂM SOÁT</td>--%>
                                                        
                                                    </tr>
                                                    <tr class="grid-header1">
                                                        <td style="width:70px" align="center">
                                                            SL phiếu bầu</td>
                                                       <td style="width:70px" align="center">
                                                            SL đã bầu</td>
                                                          <td style="width:70px" align="center">
                                                            1.MR.HÙNG</td>
                                                        <td style="width:70px" align="center">
                                                            2.MR.LÂM</td>
                                                        <td style="width:70px" align="center">
                                                            3.MS.QUYÊN</td>
                                                        <td style="width:70px" align="center">
                                                            4.MS.THÚY</td>
                                                        <td style="width:70px" align="center">
                                                            5.MR.TÙNG</td>
                                                            <asp:Panel ID="pn2TVCuoi" runat="server" Visible="false">
                                                        <td style="width:70px" align="center">
                                                            UV6</td>
                                                        <td style="width:70px" align="center">
                                                            UV7</td>
                                                            </asp:Panel>
                                                        <td style="width:70px" align="center">
                                                            Phiếu bầu</td>
                                                        <%--<td style="width:100px" align="center">
                                                            SL phiếu bầu</td>
                                                        <td style="width:100px" align="center">
                                                            UV1</td>
                                                        <td style="width:100px" align="center">
                                                            UV2</td>
                                                        <td style="width:100px" align="center">
                                                            UV3</td>    --%>                                                                                                                                                                                                                            
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
                                                    <td align="right">
                                                        <asp:Label ID="lbHDQT_Vote" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbTotal" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtHDQT_A" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtHDQT_B" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtHDQT_C" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtHDQT_D" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtHDQT_E" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>

                                                        <asp:Panel ID="pn2TVCuoi2" runat="server" Visible="false">
                                                    <td align="center">
                                                        <asp:TextBox ID="txtHDQT_F" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtHDQT_G" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                        </asp:Panel>


                                                    <td align="center">
                                                        <asp:DropDownList ID="ddlHDQT_IsValid" runat="server" CssClass="dropDownList">                                                                                                                
                                                        <asp:ListItem Value="0" Text="--"></asp:ListItem>
                                                        <asp:ListItem Value="-1" Text="Ko Hợp lệ"></asp:ListItem>
                                                        <asp:ListItem Value="1" Text="Hợp lệ"></asp:ListItem>                                                         
                                                    </asp:DropDownList></td>
                                              <%--      <td align="right">
                                                        <asp:Label ID="lbBKS_Vote" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtBKS_A" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtBKS_B" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtBKS_C" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>--%>
                                
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
                                                   <td align="right">
                                                        <asp:Label ID="lbHDQT_Vote" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="right">
                                                        <asp:Label ID="lbTotal" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtHDQT_A" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtHDQT_B" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtHDQT_C" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtHDQT_D" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtHDQT_E" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>

                                                        <asp:Panel ID="pn2TVCuoi2" runat="server" Visible="false">
                                                    <td align="center">
                                                        <asp:TextBox ID="txtHDQT_F" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtHDQT_G" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                        </asp:Panel>


                                                    <td align="center">
                                                        <asp:DropDownList ID="ddlHDQT_IsValid" runat="server" CssClass="dropDownList">                                                                                                                
                                                        <asp:ListItem Value="0" Text="--"></asp:ListItem>
                                                        <asp:ListItem Value="-1" Text="Ko Hợp lệ"></asp:ListItem>
                                                        <asp:ListItem Value="1" Text="Hợp lệ"></asp:ListItem>                                                        
                                                    </asp:DropDownList></td>
                                                  <%--  <td align="right">
                                                        <asp:Label ID="lbBKS_Vote" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtBKS_A" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtBKS_B" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtBKS_C" Width="100px" CssClass="textBoxNumber" runat="server"></asp:TextBox></td>--%>
                                                        
                                                </tr>
                                            </AlternatingItemTemplate>   
                                            <FooterTemplate>
                                                </table>
                                            </FooterTemplate>                                            
                                        </asp:TemplateField>
                                    </Columns>
                                    <PagerSettings PageButtonCount="3" />
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
            <tr>
                <td style="BACKGROUND-COLOR: #cccc99" valign="top" align="center">                    
                    <asp:Button ID="Button2" runat="server" Text="Lưu" onclick="btnSave_Click" CssClass="small color red button" Width="150px" />
                </td>
            </tr>
        </table>
      </td>
   </tr>
</table>
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>    
</asp:Content>


