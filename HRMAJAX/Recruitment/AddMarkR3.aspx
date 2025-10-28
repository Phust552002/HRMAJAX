<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="AddMarkR3.aspx.cs" Inherits="Recruitment_AddMarkR3" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
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
                                <asp:Label ID="Label1" CssClass="label" runat="server" Text="Họ và tên"></asp:Label>
                                <asp:TextBox ID="txtFirstName" runat="server" CssClass="textBox" Width="150px"></asp:TextBox>
                                
                                <asp:Button ID="btnView" runat="server" Text="Xem" OnClick="btnView_Click" CssClass="small color green button" Width="100px" />
                                &nbsp;
                                <asp:Button ID="btnCancel" runat="server" CssClass="small color green button" OnClick="btnCancel_Click"
                                    Text="Thoát" Width="100px" />
                                <asp:ObjectDataSource ID="odsPosition" runat="server" SelectMethod="GetPositionIsRecruitment_AllItem"
                                    TypeName="HRMBLL.H2.SessionsBLL"></asp:ObjectDataSource>
                                <asp:ObjectDataSource ID="odsSession" runat="server" SelectMethod="GetAll" TypeName="HRMBLL.H2.SessionsBLL" OldValuesParameterFormatString="original_{0}">
                                </asp:ObjectDataSource>
                                &nbsp; &nbsp;&nbsp;
                            </td>
                        </tr>
                    </table>    
                </td>
            </tr>           
            <tr>
                <td style="BACKGROUND-COLOR: #cccc99" valign="top" align="center"> 
                    <asp:ImageButton id="ímgSave" onclick="ímgSave_Click" runat="server" ImageUrl="~/Images/icon-save.gif"></asp:ImageButton><asp:Label id="lbSave" runat="server" CssClass="label" Text="Lưu"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="left">
                    <table class="tableBorder" width="100%" style="background-color:#d5d5d5" cellpadding="0" cellspacing="0">
                         <tr>
                            <td>
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsCandidateList" Width="100%" CellPadding="0" OnRowDataBound="GridView1_RowDataBound" PageSize="20" AllowPaging="True" OnPageIndexChanged="GridView1_PageIndexChanged">
                                    <Columns>
                                        <asp:TemplateField>
                                            <HeaderTemplate>
                                                <table style="width:100%" cellpadding="0" cellspacing="1">
                                                    <tr class="grid-header" >
                                                        <td rowspan="2" align="center">
                                                            HỌ</td>
                                                        <td rowspan="2" align="center">
                                                            TÊN</td> 
                                                                                                                                                                                                                               
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
                                                    <td>
                                                        <asp:Label ID="lbLastName" CssClass="value" runat="server"></asp:Label></td>    
                                                    <td>
                                                        <asp:Label ID="lbFirstName" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2NNGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2NNGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2NNGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbL2NNTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2NHGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2NHGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2NHGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbL2NHTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2PCGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2PCGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2PCGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbL2PCTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2KNGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2KNGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2KNGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbL2KNTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2DHNNGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2DHNNGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2DHNNGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbL2DHNNTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtRemark3" Width="98%" CssClass="value" runat="server" TextMode="MultiLine" Rows="2"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:DropDownList ID="ddlResultType" runat="server" CssClass="dropDownList">                                                        
                                                        <asp:ListItem Value="3">Đạt</asp:ListItem>
                                                        <asp:ListItem Value="2">Ko</asp:ListItem>
                                                    </asp:DropDownList></td>
                                                                                                            
                                                </tr>
                                            </ItemTemplate>
                                            <AlternatingItemTemplate>
                                                <tr class="grid-atlternating-item">
                                                    <td>
                                                        <asp:Label ID="lbLastName" CssClass="value" runat="server"></asp:Label></td>    
                                                    <td>
                                                        <asp:Label ID="lbFirstName" CssClass="value-bold" runat="server"></asp:Label></td>                                                                                                   
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2NNGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2NNGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2NNGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbL2NNTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2NHGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2NHGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2NHGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbL2NHTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2PCGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2PCGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2PCGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbL2PCTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2KNGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2KNGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2KNGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbL2KNTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2DHNNGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2DHNNGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtL2DHNNGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbL2DHNNTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtRemark3" Width="98%" CssClass="value" runat="server" TextMode="MultiLine" Rows="2"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:DropDownList ID="ddlResultType" runat="server" CssClass="dropDownList">                                                                                                                
                                                        <asp:ListItem Value="3">Đạt</asp:ListItem>
                                                        <asp:ListItem Value="2">Ko</asp:ListItem></asp:DropDownList></td>
                                                        
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
            <tr>
                <td style="BACKGROUND-COLOR: #cccc99" valign="top" align="center">
                    <asp:ImageButton id="ímgSave1" onclick="ímgSave_Click" runat="server" ImageUrl="~/Images/icon-save.gif"></asp:ImageButton><asp:Label id="lbSave1" runat="server" CssClass="label" Text="Lưu"></asp:Label>
                </td>
            </tr>
        </table>
      </td>
   </tr>
</table>
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>    

</asp:Content>

