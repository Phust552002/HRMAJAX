<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ConvertFullNameCadidate.aspx.cs" Inherits="Administrator_ConvertFullNameCadidate" Title="Untitled Page" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/ListTotalCounts.ascx" TagName="ListTotalCounts" TagPrefix="uc3" %>
<%@ Register Src="~/UserControls/ActionMenu.ascx" TagName="ActionMenu" TagPrefix="uc2" %>

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
                           
                            <td align="right" style="width: 90%">
                                
                                <table cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label3" CssClass="label" runat="server" Text="Đợt "></asp:Label>&nbsp;<asp:DropDownList
                                                ID="ddlSessions" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlSessions_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            
                                            &nbsp;
                                            <asp:Label ID="Label2" CssClass="label" runat="server" Text="Chức danh"></asp:Label>
                                            <asp:DropDownList ID="ddlPositions" runat="server" CssClass="dropDownList" AppendDataBoundItems="True">
                                            <asp:ListItem Value="0" Text=""></asp:ListItem>
                                            </asp:DropDownList>&nbsp; &nbsp;
                                            <asp:Label ID="Label1" CssClass="label" runat="server" Text="Tên"></asp:Label>
                                            <asp:TextBox ID="txtFirstName" runat="server" CssClass="textBox"></asp:TextBox>
                                            &nbsp;&nbsp;
                                            <asp:Label ID="Label6" runat="server" CssClass="label" Text="TC ứng tuyển" Visible="False"></asp:Label>
                                            <asp:DropDownList ID="ddlStandards" runat="server" CssClass="dropDownList" DataSourceID="odsStandards"
                                                DataTextField="RTypeName" DataValueField="RTypeId" Visible="False">
                                            </asp:DropDownList><asp:ObjectDataSource ID="odsStandards" runat="server" SelectMethod="GetAllCandidateType"
                                                TypeName="HRMUtil.Constants" OldValuesParameterFormatString="original_{0}"></asp:ObjectDataSource>
                                        </td>
                                        <td>
                                            &nbsp;
                                             <asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif"
                                             OnClick="imgSearch_Click" />
                                        </td>
                                    </tr>
                                </table>                               
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
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsCandidateList" PageSize="20" CssClass="grid-Border" Width="100%">
                                    <Columns>           
                                        <asp:TemplateField HeaderText="M&#227; ứng vi&#234;n">
                                            <ItemTemplate>
                                                <asp:Label ID="lbId" runat="server" Text='<%# Eval("Id") %>' ></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle Width="15%" HorizontalAlign="Left" />
                                            <HeaderStyle HorizontalAlign="Left" />
                                        </asp:TemplateField>                             
                                        <asp:TemplateField HeaderText="Họ v&#224; t&#234;n l&#243;t">
                                            <ItemTemplate>
                                                <asp:Label ID="lbLastName" runat="server" Text='<%# Eval("LastName") %>' ></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle Width="15%" HorizontalAlign="Left" />
                                            <HeaderStyle HorizontalAlign="Left" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="T&#234;n">
                                            <ItemTemplate>
                                                <asp:Label ID="lbFirstName" runat="server" Text='<%# Eval("FirstName") %>' ></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle Width="5%" HorizontalAlign="Left"/>
                                            <HeaderStyle HorizontalAlign="Left" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Họ v&#224; t&#234;n l&#243;t kh&#244;ng dấu" SortExpression="LastName1">
                                            <ItemTemplate>
                                                <asp:Label ID="lbLastName1" runat="server" Text='<%# Bind("LastName1") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="T&#234;n kh&#244;ng dấu" SortExpression="FirstName1">
                                            <ItemTemplate>
                                                <asp:Label ID="lbFirstName1" runat="server" Text='<%# Bind("FirstName1") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                     <HeaderStyle CssClass="grid-header" /> 
                                    <RowStyle CssClass ="grid-item" />
                                    <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                    <PagerStyle CssClass="grid-paper" /> 
                                </asp:GridView>
                                <asp:ObjectDataSource ID="odsCandidateList" runat="server" OnSelecting="odsCandidateList_Selecting"
                                    SelectMethod="GetByFilter" TypeName="HRMBLL.H2.CandidatesBLL" OldValuesParameterFormatString="original_{0}" OnSelected="odsCandidateList_Selected">
                                    <SelectParameters>
                                        <asp:Parameter Name="firstName" Type="String" />
                                        <asp:Parameter Name="positionId" Type="Int32" />
                                        <asp:Parameter Name="result" Type="Int32" />
                                        <asp:Parameter Name="sessionId" Type="Int32" />
                                        <asp:Parameter Name="type" Type="Int32" />
                                        <asp:Parameter Name="sessionType" Type="Int32" />
                                        <asp:Parameter Name="TypeSort" Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
             <tr>
                <td class="tdButton" align="center">
                    <asp:Button ID="btnConvert" runat="server" CssClass="small color green button" Text="Chuyển FullName thành không dấu" OnClick="btnConvert_Click" /></td>
            </tr>
        </table>
      </td>
   </tr>
</table>    
</asp:Content>


