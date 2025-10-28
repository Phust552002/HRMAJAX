<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="AddMarkLR.aspx.cs" Inherits="Recruitment_AddMarkLR" Title="Untitled Page" %>

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
                            <td align="right" style="width: 80%">                                                                
                                <asp:Label ID="Label1" CssClass="label" runat="server" Text="Tên"></asp:Label>
                                <asp:TextBox ID="txtFirstName" runat="server" CssClass="textBox"></asp:TextBox>
                                &nbsp;&nbsp;
                                &nbsp;
                                <asp:Label ID="Label3" CssClass="label" runat="server" Text="Đợt "></asp:Label>
                                <asp:DropDownList ID="ddlSessions" runat="server" DataSourceID="odsSession" DataTextField="Name" DataValueField="Id" CssClass="dropDownList">
                                </asp:DropDownList>
                                &nbsp;
                                <asp:Label ID="Label4" CssClass="label" runat="server" Text="Kết quả"></asp:Label>
                                <asp:DropDownList ID="ddlResultType" runat="server" CssClass="dropDownList">
                                    <asp:ListItem Value="-2">Tất cả</asp:ListItem>
                                    <asp:ListItem Value="3">Đạt</asp:ListItem>
                                    <asp:ListItem Value="1">Ko đạt</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;
                                <asp:Button ID="btnView" runat="server" Text="Xem" OnClick="btnView_Click" CssClass="small color green button" />
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
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsCandidateList" Width="100%" CellPadding="0" OnRowDataBound="GridView1_RowDataBound" PageSize="20" AllowPaging="True">
                                    <Columns>
                                        <asp:TemplateField>
                                            <HeaderTemplate>
                                                <table style="width:100%" cellpadding="0" cellspacing="1">
                                                    <tr class="grid-header" >
                                                        <td rowspan="2" align="center">
                                                            HỌ</td>
                                                        <td rowspan="2" align="center">
                                                            TÊN</td>                                                          
                                                        <td rowspan="2" align="center">
                                                            GIỚI TÍNH</td>
                                                        <td rowspan="2" align="center">
                                                            TRÌNH ĐỘ NGOẠI NGỮ</td>                                                          
                                                        <td colspan="4" align="center">
                                                            NGOẠI NGỮ</td>
                                                        <td colspan="4" align="center">
                                                            NGOẠI HÌNH</td>                                                        
                                                        <td rowspan="2" align="center">
                                                            VI TÍNH (%)</td>
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
                                                    </tr>                                        
                                            </HeaderTemplate>
                                             <ItemTemplate>
                                                <tr class="grid-item">
                                                    <td>
                                                        <asp:Label ID="lbLastName" CssClass="value" runat="server"></asp:Label></td>    
                                                    <td>
                                                        <asp:Label ID="lbFirstName" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbSex" CssClass="value" runat="server"></asp:Label></td>  
                                                    <td align="Left" class="value">
                                                        <asp:Literal ID="ltEnglishFluency" runat="server"></asp:Literal></td>                                                  
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNNLRGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNNLRGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNNLRGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNNLRTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNHLRGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNHLRGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNHLRGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNHLRTB" CssClass="value-bold" runat="server"></asp:Label></td>                                                    
                                                    <td align="center">
                                                        <asp:Label ID="lbVT" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:DropDownList ID="ddlResultType" runat="server" CssClass="dropDownList">                                                        
                                                        <asp:ListItem Value="2">Đạt</asp:ListItem>
                                                        <asp:ListItem Value="1">Ko</asp:ListItem>
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
                                                        <asp:Label ID="lbSex" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="Left" class="value">
                                                        <asp:Literal ID="ltEnglishFluency" runat="server"></asp:Literal></td>                                                    
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNNLRGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNNLRGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNNLRGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNNLRTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNHLRGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNHLRGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNHLRGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNHLRTB" CssClass="value-bold" runat="server"></asp:Label></td>                                                  
                                                    <td align="center">
                                                        <asp:Label ID="lbVT" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:DropDownList ID="ddlResultType" runat="server" CssClass="dropDownList">                                                        
                                                        <asp:ListItem Value="2">Đạt</asp:ListItem>
                                                        <asp:ListItem Value="1">Ko</asp:ListItem></asp:DropDownList></td>
                                                        
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

