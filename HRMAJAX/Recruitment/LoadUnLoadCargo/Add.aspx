<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Recruitment_Driving_Add" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
<%@ Register Src="../../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"
    TagPrefix="uc2" %>
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
                                <%--<asp:Label ID="Label1" CssClass="label" runat="server" Text="Tên"></asp:Label>
                                <asp:TextBox ID="txtFirstName" runat="server" CssClass="textBox"></asp:TextBox>
                                &nbsp;&nbsp;
                                <asp:Button ID="btnView" runat="server" Text="Xem" OnClick="btnView_Click" CssClass="small color green button" Width="100px" />&nbsp;
                                <asp:Button ID="btnCancel" runat="server" CssClass="small color green button" OnClick="btnCancel_Click"
                                    Text="Thoát" Width="100px" />  --%>        
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
                                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                    CssClass="grid-Border" DataSourceID="odsCandidateList" OnRowDataBound="GridView1_RowDataBound"
                                    PageSize="20" Width="100%" OnPageIndexChanged="GridView1_PageIndexChanged" CellPadding="0">
                                    <%--<Columns>
                                        <asp:TemplateField HeaderText="Họ v&#224; t&#234;n l&#243;t">
                                            <ItemStyle HorizontalAlign="Left"/>
                                            <HeaderStyle HorizontalAlign="Left" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbLastName" runat="server" CssClass="hyperlink-Grid" Text='<%# Eval("LastName") %>' ></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="T&#234;n">
                                            <ItemStyle HorizontalAlign="Left"/>
                                            <HeaderStyle HorizontalAlign="Left" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbFirstName" runat="server" CssClass="hyperlink-Grid" Text='<%# Eval("FirstName") %>' ToolTip='<%# Eval("Id") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Giới T&#237;nh" SortExpression="Sex">
                                            <ItemStyle HorizontalAlign="Center"/>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbSex" runat="server"></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Năm Sinh" SortExpression="DayOfBirth">
                                            <ItemStyle HorizontalAlign="Center"/>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbBirthday" runat="server"></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Sức khỏe">
                                            <ItemTemplate>
                                               <asp:DropDownList ID="ddlNNGK1" runat="server" CssClass="dropDownList">                                                        
                                                        <asp:ListItem Value="1">Đạt</asp:ListItem>
                                                        <asp:ListItem Value="0">Ko</asp:ListItem>
                                                    </asp:DropDownList>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Nhận x&#233;t kinh nghiệm">
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtRemark1" runat="server" CssClass="textBox" Width="100px"></asp:TextBox>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                          <asp:TemplateField HeaderText="ĐH nghề nghiệp">
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtRemark2" runat="server" CssClass="textBox" Width="100px"></asp:TextBox>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                         <asp:TemplateField HeaderText="Ghi ch&#250;">
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtRemark3" runat="server" CssClass="textBox" Width="200px"></asp:TextBox>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Kết quả">
                                            <ItemTemplate>
                                               <asp:DropDownList ID="ddlResult" runat="server" CssClass="dropDownList">                                                        
                                                        <asp:ListItem Value="1">Đạt</asp:ListItem>
                                                        <asp:ListItem Value="0">Ko</asp:ListItem>
                                                    </asp:DropDownList>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                    </Columns>--%>
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
                                                            GIAO TIẾP</td>
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
                                                    <td align="left">
                                                        <asp:Label ID="lbLastName" CssClass="value" runat="server"></asp:Label></td>    
                                                    <td align="left">
                                                        <asp:Label ID="lbFirstName" CssClass="value-bold" runat="server"></asp:Label></td>
                                                     <%--<asp:DropDownList ID="ddlDHTB" runat="server" CssClass="dropDownList">                                                        
                                                            <asp:ListItem Value="1">Đạt</asp:ListItem>
                                                            <asp:ListItem Value="0">Ko</asp:ListItem>
                                                        </asp:DropDownList>--%>
                                                    <%--<td align="center">
                                                       
                                                        <asp:Label ID="lbDHTB" CssClass="value" runat="server"></asp:Label>
                                                    </td>--%>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtGTGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtGTGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtGTGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbGTTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNHGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNHGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNHGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNHTB" CssClass="value-bold" runat="server"></asp:Label></td>
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
                                                        <asp:TextBox ID="txtRemark" Width="150px" CssClass="value" runat="server" TextMode="MultiLine" Rows="2"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:DropDownList ID="ddlResultType" runat="server" CssClass="dropDownList">                                                        
                                                        <asp:ListItem Value="1">Đạt</asp:ListItem>
                                                        <asp:ListItem Value="0">Ko</asp:ListItem>
                                                    </asp:DropDownList></td>
                                                                                                            
                                                </tr>
                                            </ItemTemplate>
                                            <AlternatingItemTemplate>
                                                <tr class="grid-atlternating-item">
                                                    <td align="left">
                                                        <asp:Label ID="lbLastName" CssClass="value" runat="server"></asp:Label></td>    
                                                    <td align="left">
                                                        <asp:Label ID="lbFirstName" CssClass="value-bold" runat="server"></asp:Label></td>   
                                                    <%--<asp:DropDownList ID="ddlDHTB" runat="server" CssClass="dropDownList">                                                        
                                                            <asp:ListItem Value="1">Đạt</asp:ListItem>
                                                            <asp:ListItem Value="0">Ko</asp:ListItem>
                                                        </asp:DropDownList>--%>
                                                    <%--<td align="center">
                                                        <asp:Label ID="lbDHTB" CssClass="value" runat="server"></asp:Label>
                                                        
                                                    </td>  --%>  
                                                    <td align="center">
                                                        <asp:TextBox ID="txtGTGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtGTGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtGTGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbGTTB" CssClass="value-bold" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNHGK1" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNHGK2" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:TextBox ID="txtNHGK3" Width="30px" CssClass="value" runat="server"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbNHTB" CssClass="value-bold" runat="server"></asp:Label></td>
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
                                                        <asp:TextBox ID="txtRemark" Width="150px" CssClass="value" runat="server" TextMode="MultiLine" Rows="2"></asp:TextBox></td>
                                                    <td align="center">
                                                        <asp:DropDownList ID="ddlResultType" runat="server" CssClass="dropDownList">                                                                                                                
                                                        <asp:ListItem Value="1">Đạt</asp:ListItem>
                                                        <asp:ListItem Value="0">Ko</asp:ListItem></asp:DropDownList></td>
                                                        
                                                </tr>
                                            </AlternatingItemTemplate>   
                                            <FooterTemplate>
                                                </table>
                                            </FooterTemplate>                                            
                                        </asp:TemplateField>
                                    </Columns>
                                    <%--<RowStyle CssClass="grid-item" />
                                    <PagerStyle CssClass="grid-paper" />
                                    <HeaderStyle CssClass="grid-header" />
                                    <AlternatingRowStyle CssClass="grid-atlternating-item" />--%>
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


