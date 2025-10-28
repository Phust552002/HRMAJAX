<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Traing.aspx.cs" Inherits="Recruitment_Traing" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/ListTotalCounts.ascx" TagName="ListTotalCounts" TagPrefix="uc3" %>
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
                           
                            <td align="right">                                
                                <asp:Label ID="Label1" CssClass="label" runat="server" Text="Họ và Tên"></asp:Label>
                                <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                &nbsp;&nbsp;
                                <asp:Label ID="Label3" CssClass="label" runat="server" Text="Đợt "></asp:Label>&nbsp;<asp:DropDownList
                                    ID="ddlSessions" runat="server" CssClass="dropDownList" AppendDataBoundItems="true">
                                    <asp:ListItem Text="" Value="0"></asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;
                                <asp:Button ID="btnView" runat="server" Text="Xem" OnClick="btnView_Click" CssClass="small color green button" />&nbsp;&nbsp;
                            </td>
                        </tr>
                    </table>     
                </td>
            </tr>
            <tr>
                <td>
                     <table class="tableBorder" width="100%">
                         <tr>
                            <td>  
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                    DataSourceID="odsCandidateForTraining" AllowPaging="True" PageSize="20" 
                                    CssClass="grid-Border" Width="100%" 
                                    OnRowDataBound="GridView1_RowDataBound">
                                    <Columns>                                        
                                        <asp:TemplateField HeaderText="Họ v&#224; t&#234;n" SortExpression="FirstName">
                                            <ItemTemplate>
                                                <asp:Label ID="lbFullName" runat="server"></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Giới T&#237;nh" SortExpression="Sex">
                                            <ItemTemplate>
                                                <asp:Label ID="lbSex" runat="server"></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Ng&#224;y sinh" SortExpression="YearOfBirth">                                           
                                            <ItemTemplate>
                                                <asp:Label ID="lbBirthday" runat="server"></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="PositionName" HeaderText="Chức danh tuyển dụng" SortExpression="PositionName" />
                                        <asp:BoundField DataField="SessionName" HeaderText="Đợt tuyển dụng" SortExpression="SessionName" />
                                        <asp:TemplateField HeaderText="Trình độ cao nhất">
                                            <ItemTemplate>
                                                <asp:DropDownList ID="ddlEducationLevel" runat="server" CssClass="dropDownList" 
                                                    DataSourceID="ObjectDataSource2" DataTextField="Training_Job1" 
                                                    DataValueField="CandidateTrainingJobHistoryId"  AppendDataBoundItems="True" 
                                                    ToolTip='<%# Eval("CandidateId") %>'>
                                                    <asp:ListItem Text="" Value="0"></asp:ListItem>
                                                 </asp:DropDownList>
                                                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                                                    OldValuesParameterFormatString="original_{0}" 
                                                    SelectMethod="GetByCandidateId_Type" 
                                                    TypeName="HRMBLL.H2.CandidateTrainingJobHistoryBLL">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="ddlEducationLevel" Name="CandidateId" 
                                                            PropertyName="ToolTip" Type="Int32" />
                                                        <asp:Parameter DefaultValue="EDU" Name="Type" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                            </ItemTemplate>
                                            <ControlStyle Width="100%" />
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Giá trị" Visible="False">
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtEduValue" runat="server" CssClass="textBox" Width="300px"></asp:TextBox>
                                            </ItemTemplate>
                                            <ControlStyle Width="100%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Chọn">
                                            <ItemStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkSelected" runat="server" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="CandidateId" Visible="False" />
                                    </Columns>
                                     <HeaderStyle CssClass="grid-header" /> 
                                    <RowStyle CssClass ="grid-item" />
                                    <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                    <PagerStyle CssClass="grid-paper" /> 
                                </asp:GridView>
                                <asp:ObjectDataSource ID="odsCandidateForTraining" runat="server"
                                    SelectMethod="GetForTrainingByFilter" TypeName="HRMBLL.H2.CandidatesBLL" OldValuesParameterFormatString="original_{0}" OnSelecting="odsCandidateForTraining_Selecting" OnSelected="odsCandidateForTraining_Selected">
                                    <SelectParameters>
                                        <asp:Parameter Name="fullName" Type="String" />
                                        <asp:Parameter Name="sessionId" Type="Int32" />
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
   <tr>
        <td align="center">
            <asp:Button ID="Button1" runat="server" CssClass="small color green button" OnClick="Button1_Click"
                Text="Chuyển thành nhân viên chính thức" /></td>
    </tr>
</table>    
</asp:Content>

