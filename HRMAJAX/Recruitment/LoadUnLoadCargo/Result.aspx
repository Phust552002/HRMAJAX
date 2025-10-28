<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Result.aspx.cs" Inherits="Recruitment_Driving_Result" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
<%@ Register Src="../../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc3" %>
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
                             <td style="width:20%" align="left">                                                                       
                                    <uc3:ActionMenu ID="ActionMenu1" runat="server" />
                             </td>
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
                                    <asp:ListItem Value="-1">Tất cả</asp:ListItem>
                                    <asp:ListItem Value="1">Đạt</asp:ListItem>
                                    <asp:ListItem Value="0">Ko đạt</asp:ListItem>
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
                <td align="left">
                    <table class="tableBorder" width="100%" style="background-color:#d5d5d5" cellpadding="0" cellspacing="0">
                         <tr>
                            <td>
                                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                    CssClass="grid-Border" DataSourceID="odsCandidateList" OnRowDataBound="GridView1_RowDataBound"
                                    PageSize="20" Width="100%" CellPadding="0">
                                    <%--<Columns>
                                        <asp:TemplateField HeaderText="SBD">
                                            <ItemTemplate>
                                                <asp:Label ID="lbCandidateNumber" runat="server" Text=""></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center"/>
                                        </asp:TemplateField>
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
                                         <asp:TemplateField HeaderText="Tr&#236;nh độ">
                                            <ItemTemplate>
                                                <asp:Literal ID="ltEducationLevel" runat="server"></asp:Literal>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Left" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Kinh nghiệm" SortExpression="Experience">
                                            <ItemTemplate>
                                                <asp:Literal ID="ltExperience" runat="server"></asp:Literal>
                                            </ItemTemplate>
                                             <ItemStyle HorizontalAlign="left" Width="100px"/>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="PositionName" HeaderText="Chức danh" SortExpression="PositionName" />
                                        <asp:TemplateField HeaderText="Sức khỏe">
                                            <ItemTemplate>
                                                <asp:Label ID="lbNNGK1" runat="server"></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Nhận x&#233;t Kinh nghiệm">
                                            <ItemTemplate>
                                                <asp:Label ID="lbRemark1" runat="server"></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="left" Width="100px"/>
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                          <asp:TemplateField HeaderText="ĐH nghề nghiệp">
                                            <ItemTemplate>
                                                <asp:Label ID="lbRemark2" runat="server"></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Left"  Width="100px"/>
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Kết quả">
                                            <ItemTemplate>
                                                <asp:Label ID="lbResult" runat="server" Text="Label"></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                         <asp:TemplateField HeaderText="Ghi ch&#250;">
                                            <ItemTemplate>
                                                <asp:Label ID="lbRemark3" runat="server"></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Left"  Width="100px"/>
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                    </Columns>--%>
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
                                                    <td align="center">
                                                        <asp:Label ID="lbSex" CssClass="value" runat="server"></asp:Label></td>         
                                                    <td align="center">
                                                        <asp:Label ID="lbGTGK1" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbGTGK2" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbGTGK3" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbGTTB" CssClass="value-bold" runat="server"></asp:Label></td>
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
                                                    <td align="left">
                                                        <asp:Label ID="lbRemark1" CssClass="value" runat="server"></asp:Label></td>
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
                                                        <asp:Label ID="lbGTGK1" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbGTGK2" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbGTGK3" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbGTTB" CssClass="value-bold" runat="server"></asp:Label></td>
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
                                                    <td align="left">
                                                        <asp:Label ID="lbRemark1" CssClass="value" runat="server"></asp:Label></td>
                                                    <td align="center">
                                                        <asp:Label ID="lbResult" CssClass="value" runat="server" ></asp:Label></td>
                                                </tr>
                                            </AlternatingItemTemplate>   
                                            <FooterTemplate>
                                                </table>
                                            </FooterTemplate>                                            
                                        </asp:TemplateField>
                                    </Columns>
                                   <%-- <RowStyle CssClass="grid-item" />
                                    <PagerStyle CssClass="grid-paper" />
                                    <HeaderStyle CssClass="grid-header" />
                                    <AlternatingRowStyle CssClass="grid-atlternating-item" />--%>
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
        </table>
      </td>
   </tr>
</table>
<script type="text/javascript" src="../../JScripts/wz_tooltip.js"></script>    
</asp:Content>

