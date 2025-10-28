<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="BQCTTGDAdd.aspx.cs" Inherits="ShareHolder_BQCTTGDAdd" %>
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
                    <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" Text="Lưu" CssClass="small color red button" 
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
                                                        <td style="width:100px" align="center">
                                                            MÃ CĐ</td>
                                                        <td align="center">
                                                            HỌ VÀ TÊN</td>                                                                
                                                        <td align="center">
                                                            SỐ CỔ PHẦN</td>   
                                                        <td align="center">
                                                            TỈ LỆ (%)</td>                                                                                                              
                                                        <td align="center">
                                                            THÔNG QUA VIỆC CHỦ TỊCH KIÊM TỔNG GIÁM ĐỐC</td>
                                                        
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
                                                         <asp:DropDownList ID="ddlBQ_CTTGD" runat="server" CssClass="dropDownList">                                                                                                                
                                                        <asp:ListItem Value="1" Text="Đồng ý"></asp:ListItem>
                                                        <asp:ListItem Value="0" Text="Không đồng ý"></asp:ListItem>
                                                        <asp:ListItem Value="2" Text="Không có ý kiến"></asp:ListItem>
                                                        <asp:ListItem Value="-1" Text="--"></asp:ListItem>
                                                    </asp:DropDownList></td>
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
                                                         <asp:DropDownList ID="ddlBQ_CTTGD" runat="server" CssClass="dropDownList">                                                                                                                
                                                        <asp:ListItem Value="1" Text="Đồng ý"></asp:ListItem>
                                                        <asp:ListItem Value="0" Text="Không đồng ý"></asp:ListItem>
                                                        <asp:ListItem Value="2" Text="Không có ý kiến"></asp:ListItem>
                                                        <asp:ListItem Value="-1" Text="--"></asp:ListItem>
                                                    </asp:DropDownList></td>
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
                    <asp:Button ID="Button2" runat="server" Text="Lưu" onclick="btnSave_Click"  CssClass="small color red button"  Width="150px" />
                </td>
            </tr>
        </table>
      </td>
   </tr>
</table>
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>    
</asp:Content>

