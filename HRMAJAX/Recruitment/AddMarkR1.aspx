<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="AddMarkR1.aspx.cs" Inherits="Recruitment_AddMarkR1" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc2" %>
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
                                <asp:TextBox ID="txtFirstName" runat="server" CssClass="textBox" Width="150px"></asp:TextBox>&nbsp;
                                <asp:Button ID="btnView" runat="server" Text="Xem" OnClick="btnView_Click" CssClass="small color green button" Width="100px" />
                                &nbsp; &nbsp;
                                <asp:Button ID="btnCancel" runat="server" Text="Thoát" CssClass="small color green button" Width="100px" OnClick="btnCancel_Click" /></td>
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
                                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="odsCandidateList" Width="100%" CellPadding="0" OnRowDataBound="GridView2_RowDataBound1" PageSize="20" AllowPaging="True">
                                    <Columns>
                                        <asp:TemplateField>
                                            <HeaderTemplate>
                                                <table style="width:100%" cellpadding="0" cellspacing="1" class="grid-header1">
                                                    <tr>
                                                        <td align="center" >
                                                            SỐ BD</td>
                                                        <td align="center" >
                                                            HỌ</td>
                                                        <td align="center" >
                                                            TÊN</td>                                                          
                                                        <td align="center">
                                                            GIỚI TÍNH</td>
                                                        <td align="center">
                                                            NĂM SINH</td>                                                      
                                                        <td align="center" >
                                                            DỊCH ANH - VIỆT</td>                                                                                                           
                                                       
                                                        <td align="center">
                                                            KẾT QUẢ</td>                                                            
                                                        <td align="center">
                                                            GHI CHÚ</td>                                                            
                                                        
                                                    </tr>
                                                   
                                                                                     
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <tr class="grid-item">
                                                    <td align="center">
                                                        <asp:Label ID="lbOrderNumber" CssClass="value" runat="server"></asp:Label></td> 
                                                    <td>
                                                        <asp:Label ID="lbLastName" CssClass="value" runat="server"></asp:Label></td>    
                                                    <td>
                                                        <asp:Label ID="lbFirstName" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbSex" CssClass="value" runat="server"></asp:Label></td>  
                                                    <td align="center">
                                                        <asp:Label ID="lbBirthday" CssClass="value" runat="server"></asp:Label></td>  
                                                    <td align="center">
                                                        <%--<asp:DropDownList ID="ddlDHTB" runat="server" CssClass="dropDownList">                                                        
                                                        <asp:ListItem Value="1">Đạt</asp:ListItem>
                                                        <asp:ListItem Value="0">Ko</asp:ListItem>
                                                    </asp:DropDownList>--%>
                                                    <asp:TextBox ID="txtDHTB" CssClass="value" runat="server"  Width="200px"></asp:TextBox>
                                                    </td>
                                                                                                                                                                                                            
                                                    <td align="center">
                                                        <asp:DropDownList ID="ddlResult" runat="server" CssClass="dropDownList">                                                        
                                                            <asp:ListItem Value="1">Đạt</asp:ListItem>
                                                            <asp:ListItem Value="0">Ko</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtRemark1" CssClass="value" runat="server" Width="200px"></asp:TextBox></td>                                                          
                                                </tr>
                                            </ItemTemplate>
                                            <AlternatingItemTemplate>
                                                <tr class="grid-atlternating-item">
                                                    <td align="center">
                                                        <asp:Label ID="lbOrderNumber" CssClass="value" runat="server"></asp:Label></td> 
                                                    <td>
                                                        <asp:Label ID="lbLastName" CssClass="value" runat="server"></asp:Label></td>    
                                                    <td>
                                                        <asp:Label ID="lbFirstName" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbSex" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbBirthday" CssClass="value" runat="server"></asp:Label></td>  
                                                    <td align="center">
                                                        <%--<asp:DropDownList ID="ddlDHTB" runat="server" CssClass="dropDownList">                                                        
                                                        <asp:ListItem Value="1">Đạt</asp:ListItem>
                                                        <asp:ListItem Value="0">Ko</asp:ListItem>
                                                    </asp:DropDownList>--%>
                                                    <asp:TextBox ID="txtDHTB" CssClass="value" runat="server"  Width="200px"></asp:TextBox>
                                                    </td>
                                                     
                                                    <td align="center">
                                                        <asp:DropDownList ID="ddlResult" runat="server" CssClass="dropDownList">                                                        
                                                        <asp:ListItem Value="1">Đạt</asp:ListItem>
                                                        <asp:ListItem Value="0">Ko</asp:ListItem></asp:DropDownList></td>
                                                     <td align="center">
                                                        <asp:TextBox ID="txtRemark1" CssClass="value" runat="server"  Width="200px"></asp:TextBox></td>   
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
           <uc2:ucpermission ID="UcPermission1" runat="server" />
      </td>
   </tr>
</table>
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>    
</asp:Content>

