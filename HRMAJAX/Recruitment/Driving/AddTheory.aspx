<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="AddTheory.aspx.cs" Inherits="Recruitment_Driving_AddTheory" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

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
                                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                    CssClass="grid-Border" DataSourceID="odsCandidateList" OnRowDataBound="GridView1_RowDataBound"
                                    PageSize="20" Width="100%">
                                    <Columns>
                                    <asp:TemplateField>
                                        <HeaderTemplate>
                                            <table style="width:100%" cellpadding="0" cellspacing="1">
                                                <tr class="grid-header" >
                                                    <td rowspan="2" style="width:10%" align="center">HỌ</td>
                                                    <td rowspan="2" style="width:5%" align="center">TÊN</td> 
                                                    <td rowspan="2" style="width:5%" align="center">GIỚI TÍNH</td>                                                                                                                                                           
                                                    <td rowspan="2" style="width:5%" align="center">NĂM SINH</td>
                                                    <td rowspan="2" style="width:5%" align="center">LUẬT GTĐB</td>
                                                    <td colspan="4" style="width:20%" align="center">THỰC HÀNH</td>
                                                    <td rowspan="2" style="width:30%" align="center">GHI CHÚ</td> 
                                                    <td rowspan="2" style="width:5%" align="center">KẾT QUẢ</td>
                                                </tr>
                                                <tr class="grid-header">
                                                    <td style="width:5%" align="center">GK1</td>
                                                    <td style="width:5%" align="center">GK2</td>
                                                    <td style="width:5%" align="center">GK3</td>
                                                    <td style="width:5%" align="center">TB</td>                                                                                                       
                                                </tr>  
                                                                        
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <tr class="grid-item">
                                                <td align="left"><asp:Label ID="lbLastName" runat="server" Width="95%" CssClass="hyperlink-Grid" Text='<%# Eval("LastName") %>' ></asp:Label></td>
                                                <td align="left"><asp:Label ID="lbFirstName" runat="server" Width="95%" CssClass="hyperlink-Grid" Text='<%# Eval("FirstName") %>' ToolTip='<%# Eval("Id") %>'></asp:Label></td>
                                                <td align="center"><asp:Label ID="lbSex" runat="server" Width="95%"></asp:Label></td>
                                                <td align="center"><asp:Label ID="lbBirthday" runat="server" Width="95%"></asp:Label></td>
                                                <td align="center"><asp:TextBox ID="txtVT" CssClass="textBox" runat="server" Width="95%"></asp:TextBox></td>
                                                <td align="center"><asp:TextBox ID="txtNNGK1" CssClass="textBox" runat="server" Width="95%"></asp:TextBox></td>
                                                <td align="center"><asp:TextBox ID="txtNNGK2" CssClass="textBox" runat="server" Width="95%"></asp:TextBox></td>
                                                <td align="center"><asp:TextBox ID="txtNNGK3" CssClass="textBox" runat="server" Width="95%"></asp:TextBox></td>
                                                <td align="center"><asp:Label ID="lblNNTB" runat="server" Width="95%"></asp:Label></td>
                                                <td align="center"><asp:TextBox ID="txtRemarkR1" CssClass="textBox" runat="server" Width="95%"></asp:TextBox></td>
                                                <td align="center"><asp:DropDownList ID="ddlResult" runat="server" CssClass="dropDownList" Width="95%">                                                        
                                                        <asp:ListItem Value="2">Đạt</asp:ListItem>
                                                        <asp:ListItem Value="1">Ko</asp:ListItem>
                                                    </asp:DropDownList></td>
                                            </tr>
                                        </ItemTemplate>
                                        <%--<AlternatingItemTemplate>
                                            <tr class="grid-atlternating-item">
                                                <td align="left"><asp:Label ID="lbLastName" runat="server" CssClass="hyperlink-Grid" Text='<%# Eval("LastName") %>' ></asp:Label></td>
                                                <td align="left"><asp:Label ID="lbFirstName" runat="server" CssClass="hyperlink-Grid" Text='<%# Eval("FirstName") %>' ToolTip='<%# Eval("Id") %>'></asp:Label></td>
                                                <td align="left"><asp:Label ID="lbSex" runat="server"></asp:Label></td>
                                                <td align="left"><asp:Label ID="lbBirthday" runat="server"></asp:Label></td>
                                                <td align="left"><asp:Literal ID="ltEducationLevel" runat="server"></asp:Literal></td>
                                                <td align="left"><asp:Literal ID="ltExperience" runat="server"></asp:Literal></td>
                                                <td align="left"><asp:Label ID="lblVT" runat="server"></asp:Label></td>
                                                <td align="left"><asp:Label ID="lblNNGK1" runat="server" Width="40px"></asp:Label></td>
                                                <td align="left"><asp:Label ID="lblNNGK2" runat="server" Width="40px"></asp:Label></td>
                                                <td align="left"><asp:Label ID="lblNNGK3" runat="server" Width="40px"></asp:Label></td>
                                                <td align="left"><asp:Label ID="lblNNTB" runat="server" Width="40px"></asp:Label></td>
                                                <td align="left"><asp:Label ID="lblRemarkR1" runat="server" Width="300"></asp:Label></td>
                                                <td align="left"><asp:Label ID="lbResult" runat="server" Text="Label"></asp:Label></td>
                                            </tr>
                                        </AlternatingItemTemplate>--%>
                                        <FooterTemplate>
                                                </table>
                                            </FooterTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <PagerStyle CssClass="grid-paper" />
                                    <%--<RowStyle CssClass="grid-item" />
                                    
                                    <HeaderStyle CssClass="grid-header" />
                                    <AlternatingRowStyle CssClass="grid-atlternating-item" />--%>
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


