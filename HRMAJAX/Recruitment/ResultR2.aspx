<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ResultR2.aspx.cs" Inherits="Recruitment_ResultR2" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

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
                            <td align="right" style="width: 80%">                                                                
                                <asp:Label ID="Label1" CssClass="label" runat="server" Text="Họ và tên"></asp:Label>
                                <asp:TextBox ID="txtFirstName" runat="server" CssClass="textBox"></asp:TextBox>
                                &nbsp;&nbsp;
                                &nbsp;
                                <asp:Label ID="Label3" CssClass="label" runat="server" Text="Đợt "></asp:Label>
                                <asp:DropDownList ID="ddlSessions" runat="server" DataSourceID="odsSession" DataTextField="Name" DataValueField="Id" CssClass="dropDownList">
                                </asp:DropDownList>
                                &nbsp;
                                <asp:Label ID="Label4" CssClass="label" runat="server" Text="Kết quả"></asp:Label>
                                <asp:DropDownList ID="ddlResultType" runat="server" CssClass="dropDownList">
                                    <asp:ListItem Value="-1">Tất cả</asp:ListItem>
                                    <asp:ListItem Value="1">Ko đạt</asp:ListItem>
                                    <asp:ListItem Value="2">Đạt</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;
                                <asp:Button ID="btnView" runat="server" Text="Xem" OnClick="btnView_Click" CssClass="small color green button" />&nbsp;
                                <asp:ObjectDataSource ID="odsSession" runat="server" SelectMethod="GetAll"
                                    TypeName="HRMBLL.H2.SessionsBLL" OldValuesParameterFormatString="original_{0}"></asp:ObjectDataSource>
                                &nbsp;
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
                                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="odsCandidateList" Width="100%" CellPadding="0" OnRowDataBound="GridView2_RowDataBound" PageSize="20">
                                    <Columns>
                                        <asp:TemplateField>
                                            <HeaderTemplate>
                                                <table style="width:100%" cellpadding="0" cellspacing="1">
                                                    <tr class="grid-header" >
                                                        <td rowspan="2" style="width:120px" align="center">
                                                            HỌ</td>
                                                        <td rowspan="2" align="center">
                                                            TÊN</td>                                                                
                                                        <td rowspan="2" align="center">
                                                            GIỚI TÍNH</td>   
                                                        <td rowspan="2" align="center">
                                                            DỊCH ANH - VIỆT</td>                                                                                                              
                                                        <td colspan="4" align="center">
                                                            NGOẠI NGỮ</td>
                                                        <td colspan="4" align="center">
                                                            NGOẠI HÌNH</td>
                                                        <td colspan="4" align="center">
                                                            PHONG CÁCH</td>
                                                        <td colspan="4" align="center">
                                                            KINH NGHIỆM</td>
                                                        <td colspan="4" align="center">
                                                            ĐH NGHỀ NGHIỆP</td>
                                                        <td rowspan="2" align="center">
                                                            VI TÍNH (%)</td> 
                                                        <td rowspan="2" align="center">
                                                            GHI CHÚ</td>                                                        
                                                        <td rowspan="2" align="center">
                                                            KẾT QUẢ</td>    
                                                    </tr>
                                                    <tr class="grid-header">
                                                        <td style="width:30px" align="center">
                                                            GK1</td>
                                                        <td style="width:30px" align="center">
                                                            GK2</td>
                                                        <td style="width:30px" align="center">
                                                            GK3</td>
                                                        <td style="width:30px" align="center">
                                                            TB</td>
                                                        <td style="width:30px" align="center">
                                                            GK1</td>
                                                        <td style="width:30px" align="center">
                                                            GK2</td>
                                                        <td style="width:30px" align="center">
                                                            GK3</td>
                                                        <td style="width:30px" align="center">
                                                            TB</td>
                                                        <td style="width:30px" align="center">
                                                            GK1</td>
                                                        <td style="width:30px" align="center">
                                                            GK2</td>
                                                        <td style="width:30px" align="center">
                                                            GK3</td>
                                                        <td style="width:30px" align="center">
                                                            TB</td>
                                                        <td style="width:30px" align="center">
                                                            GK1</td>
                                                        <td style="width:30px" align="center">
                                                            GK2</td>
                                                        <td style="width:30px" align="center">
                                                            GK3</td>
                                                        <td style="width:30px" align="center">
                                                            TB</td>
                                                        <td style="width:30px" align="center">
                                                            GK1</td>
                                                        <td style="width:30px" align="center">
                                                            GK2</td>
                                                        <td style="width:30px" align="center">
                                                            GK3</td>
                                                        <td style="width:30px" align="center">
                                                            TB</td>                                                                                                                                                                          
                                                    </tr>                                        
                                            </HeaderTemplate>
                                             <ItemTemplate>
                                                <tr class="grid-item">
                                                    <td align="left">
                                                        <asp:Label ID="lbLastName" CssClass="value" runat="server"></asp:Label></td>    
                                                    <td align="left">
                                                        <asp:Label ID="lbFirstName" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbSex" CssClass="value" runat="server"></asp:Label></td>                                                   
                                                    <td align="center">
                                                        <asp:Label ID="lbDHTB" CssClass="value" runat="server"></asp:Label></td>    
                                                    <td align="center">
                                                        <asp:Label ID="lbNNGK1" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNNGK2" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNNGK3" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNNTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNHGK1" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNHGK2" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNHGK3" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNHTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbPCGK1" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbPCGK2" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbPCGK3" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbPCTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbKNGK1" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbKNGK2" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbKNGK3" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbKNTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbDHNNGK1" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbDHNNGK2" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbDHNNGK3" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbDHNNTB" CssClass="value-bold" runat="server"></asp:Label></td>                                                    
                                                    <td align="center">
                                                        <asp:Label ID="lbVT" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="left">
                                                        <asp:Label ID="lbRemark2" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbResult" CssClass="value" runat="server"></asp:Label></td>
                                                </tr>
                                            </ItemTemplate>
                                            <AlternatingItemTemplate>
                                                <tr class="grid-atlternating-item">                                                    
                                                    <td align="left">
                                                        <asp:Label ID="lbLastName" CssClass="value" runat="server"></asp:Label></td>    
                                                    <td align="left">
                                                        <asp:Label ID="lbFirstName" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbSex" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbDHTB" CssClass="value" runat="server"></asp:Label></td>    
                                                    <td align="center">
                                                        <asp:Label ID="lbNNGK1" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNNGK2" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNNGK3" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNNTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNHGK1" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNHGK2" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNHGK3" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNHTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbPCGK1" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbPCGK2" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbPCGK3" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbPCTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbKNGK1" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbKNGK2" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbKNGK3" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbKNTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbDHNNGK1" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbDHNNGK2" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbDHNNGK3" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbDHNNTB" CssClass="value-bold" runat="server"></asp:Label></td>                                                    
                                                    <td align="center">
                                                        <asp:Label ID="lbVT" CssClass="value" runat="server"></asp:Label></td>                                                                                                                                                                     
                                                    <td align="left">
                                                        <asp:Label ID="lbRemark2" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbResult" CssClass="value" runat="server" ></asp:Label></td>
                                                </tr>
                                            </AlternatingItemTemplate>   
                                            <FooterTemplate>
                                                </table>
                                            </FooterTemplate>                                            
                                        </asp:TemplateField>
                                    </Columns>
                                    <PagerSettings PageButtonCount="2" />
                                    <PagerStyle CssClass="grid-paper"></PagerStyle>
                                </asp:GridView>
                                
                                                                
                                <asp:ObjectDataSource ID="odsCandidateList" runat="server" OnSelecting="ObjectDataSource1_Selecting"
                                    SelectMethod="GetByFilter" TypeName="HRMBLL.H2.CandidatesBLL" OldValuesParameterFormatString="original_{0}" OnSelected="odsCandidateList_Selected">
                                    <SelectParameters>
                                        <asp:Parameter Name="firstName" Type="String" />
                                        <asp:Parameter Name="positionId" Type="Int32" />
                                        <asp:Parameter Name="result" Type="Int32" />
                                        <asp:Parameter Name="sessionId" Type="Int32" />
                                        <asp:Parameter Name="type" Type="Int32" />
                                        <asp:Parameter Name="sessionType" Type="Int32" />
                                        <asp:Parameter Name="TypeSort" Type="Int32" />
                                        <asp:Parameter DefaultValue="0" Name="isBlack" Type="Int32" />
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

</asp:Content>


