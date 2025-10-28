<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="AddBoard.aspx.cs" Inherits="Recruitment_Driving_AddBoard" Title="Untitled Page" %>

<%@ Register Src="../../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>


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
                                <asp:Label ID="Label1" CssClass="label" runat="server" Text="Tên"></asp:Label>
                                <asp:TextBox ID="txtFirstName" runat="server" CssClass="textBox"></asp:TextBox>
                                &nbsp;&nbsp;
                                <asp:Button ID="btnView" runat="server" Text="Xem" OnClick="btnView_Click" CssClass="small color green button" Width="100px" />&nbsp;
                                <asp:Button ID="btnCancel" runat="server" CssClass="small color green button" OnClick="btnCancel_Click"
                                    Text="Thoát" Width="100px" />                                
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
                               <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="odsCandidateList" Width="100%" CellPadding="0" OnRowDataBound="GridView2_RowDataBound" AllowPaging="True" PageSize="20">
                                    <Columns>
                                        <asp:TemplateField>
                                            <HeaderTemplate>
                                                <table style="width:100%" cellpadding="0" cellspacing="1">
                                                    <tr class="grid-header" >
                                                        <td rowspan="2" style="width:100px" align="center">
                                                            HỌ</td>
                                                        <td rowspan="2" align="center">
                                                            TÊN</td>    
                                                        <td rowspan="2" align="center">
                                                            NĂM SINH</td>                                                       
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
                                                    </tr>                                        
                                            </HeaderTemplate>
                                             <ItemTemplate>
                                                <tr class="grid-item">
                                                    <td>
                                                        <asp:Label ID="lbLastName" CssClass="value" runat="server"></asp:Label></td>    
                                                    <td>
                                                        <asp:Label ID="lbFirstName" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbBirthday" CssClass="value" runat="server"></asp:Label></td>                                                                                                 
                                                    <td align="center">
                                                        <asp:TextBox ID="txtPCGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtPCGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtPCGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbPCTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtKNGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtKNGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtKNGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbKNTB" CssClass="value-bold" runat="server"></asp:Label></td>                                                      
                                                    <td align="center">
                                                        <asp:TextBox ID="txtDHNNGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtDHNNGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtDHNNGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbDHNNTB" CssClass="value-bold" runat="server"></asp:Label></td>                                                                   
                                                    <td align="center">
                                                        <asp:TextBox ID="txtRemark3" Width="98%" CssClass="value" runat="server" Rows="1"></asp:TextBox></td>
                                                    <td align="center">
                                                         <asp:DropDownList ID="ddlResult" runat="server" CssClass="dropDownList">                                                        
                                                        <asp:ListItem Value="3">Đạt</asp:ListItem>
                                                        <asp:ListItem Value="2">Ko</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                            <AlternatingItemTemplate>
                                                <tr class="grid-atlternating-item">
                                                    <td>
                                                        <asp:Label ID="lbLastName" CssClass="value" runat="server"></asp:Label></td>    
                                                    <td>
                                                        <asp:Label ID="lbFirstName" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbBirthday" CssClass="value" runat="server"></asp:Label></td>                                                                                                      
                                                    <td align="center">
                                                        <asp:TextBox ID="txtPCGK1" Width="30px" CssClass="value"  runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtPCGK2" Width="30px" CssClass="value"  runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtPCGK3" Width="30px" CssClass="value"  runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbPCTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtKNGK1" Width="30px" CssClass="value"  runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtKNGK2" Width="30px" CssClass="value"  runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtKNGK3" Width="30px" CssClass="value"  runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbKNTB" CssClass="value-bold" runat="server"></asp:Label></td>                                                      
                                                    <td align="center">
                                                        <asp:TextBox ID="txtDHNNGK1" Width="30px" CssClass="value"  runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtDHNNGK2" Width="30px" CssClass="value"  runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtDHNNGK3" Width="30px" CssClass="value"  runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbDHNNTB" CssClass="value-bold" runat="server"></asp:Label></td> 
                                                    <td align="center">
                                                        <asp:TextBox ID="txtRemark3" Width="98%" CssClass="value" runat="server" Rows="1"></asp:TextBox></td>                                                                                                                                                                    
                                                    <td align="center">
                                                         <asp:DropDownList ID="ddlResult" runat="server" CssClass="dropDownList">                                                        
                                                        <asp:ListItem Value="3">Đạt</asp:ListItem>
                                                        <asp:ListItem Value="2">Ko</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
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
                    <uc2:ucPermission ID="UcPermission1" runat="server" />
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
<script type="text/javascript" src="../../JScripts/wz_tooltip.js"></script>    

</asp:Content>

