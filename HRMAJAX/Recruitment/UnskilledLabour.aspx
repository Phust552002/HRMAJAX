<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="UnskilledLabour.aspx.cs" Inherits="Recruitment_UnskilledLabour" Title="Untitled Page" %>

<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
   <tr>
       <td valign="top" >
        <table style="width: 100%" cellpadding="0" cellspacing="0">
            <tr>
                <td style="width: 846px">
                    <uc1:ucTitle ID="UcTitle1" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width: 846px">
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
                                    <asp:ListItem Value="-1">Tất cả</asp:ListItem>
                                    <asp:ListItem Value="2">Đạt</asp:ListItem>
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
                <td align="left" style="width: 846px">
                    <table class="tableBorder" width="100%" style="background-color:#d5d5d5" cellpadding="0" cellspacing="0">
                         <tr>
                            <td>
                                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                    CssClass="grid-Border" DataSourceID="odsCandidateList" OnRowDataBound="GridView1_RowDataBound"
                                    PageSize="20" Width="100%" DataKeyNames="Id">
                                    <Columns>
                                        <asp:TemplateField HeaderText="Họ v&#224; t&#234;n l&#243;t">
                                            <ItemStyle HorizontalAlign="Left" Width="20%"/>
                                            <HeaderStyle HorizontalAlign="Left" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbLastName" runat="server" CssClass="hyperlink-Grid" Text='<%# Eval("LastName") %>' ></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="T&#234;n">
                                            <ItemStyle HorizontalAlign="Left" Width="10%"/>
                                            <HeaderStyle HorizontalAlign="Left" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbFirstName" runat="server" CssClass="hyperlink-Grid" Text='<%# Eval("FirstName") %>' ToolTip='<%# Eval("Id") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Giới T&#237;nh" SortExpression="Sex">
                                            <ItemStyle HorizontalAlign="Center" Width="5%"/>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbSex" runat="server"></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Năm Sinh" SortExpression="DayOfBirth">
                                            <ItemStyle HorizontalAlign="Center" Width="5%"/>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:Label ID="lbBirthday" runat="server"></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Cao" SortExpression="Height">
                                          
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Height") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Sức khỏe" SortExpression="Health">
                                          
                                            <ItemTemplate>
                                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Health") %>'></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Left" Width="15%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Tr&#236;nh độ">
                                            <ItemTemplate>
                                                <asp:Literal ID="ltEducationLevel" runat="server"></asp:Literal>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Left"/>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Ghi ch&#250;" SortExpression="Remark">                                           
                                            <ItemStyle HorizontalAlign="Left" />
                                            <HeaderStyle HorizontalAlign="Left" />
                                            <ItemTemplate>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Remark") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Kết quả">
                                            <ItemTemplate>
                                                <asp:Label ID="lbResult" runat="server" Text="Label"></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <EditItemTemplate>
                                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropDownList" SelectedValue='<%#Bind ("Result")%>'>
                                                    <asp:ListItem Value="2">Đạt</asp:ListItem>
                                                    <asp:ListItem Value="0">Ko Đạt</asp:ListItem>
                                                </asp:DropDownList>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                         <asp:TemplateField HeaderText="Thao t&#225;c" ShowHeader="False">
                                            <EditItemTemplate>
                                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="True" CommandName="Update" ImageUrl="~/Images/icon-save.gif"/>
                                                <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Cancel" ImageUrl="~/Images/icon-cancel.gif"/>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Edit" ImageUrl="~/Images/icon-edit.gif"/>                                                
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" Width="5%" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:TemplateField> 
                                    </Columns>
                                    <RowStyle CssClass="grid-item" />
                                    <PagerStyle CssClass="grid-paper" />
                                    <HeaderStyle CssClass="grid-header" />
                                    <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                </asp:GridView>
                                                                
                                <asp:ObjectDataSource ID="odsCandidateList" runat="server" OnSelecting="ObjectDataSource1_Selecting"
                                    SelectMethod="GetByFilter" TypeName="HRMBLL.H2.CandidatesBLL" 
                                    OnSelected="odsCandidateList_Selected" UpdateMethod="UpdateUnSkilledLabour" 
                                    OldValuesParameterFormatString="original_{0}">
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
                                    <UpdateParameters>
                                        <asp:Parameter Name="Id" Type="Int32" />
                                        <asp:Parameter Name="lastName" Type="String" />
                                        <asp:Parameter Name="firstname" Type="String" />
                                        <asp:Parameter Name="sex" Type="Boolean" />
                                        <asp:Parameter Name="birthday" Type="String" />
                                        <asp:Parameter Name="height" Type="String" />
                                        <asp:Parameter Name="health" Type="String" />
                                        <asp:Parameter Name="educationLevel" Type="String" />
                                        <asp:Parameter Name="Remark" Type="String" />
                                        <asp:Parameter Name="Result" Type="Int32" />
                                    </UpdateParameters>
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
<script type="text/javascript" src="../../JScripts/wz_tooltip.js"></script>    
</asp:Content>


