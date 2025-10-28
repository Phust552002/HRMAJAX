<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Seniority.aspx.cs" Inherits="Statistic_Seniority" Title="Untitled Page" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
    <tr>
        <td>
            <uc1:ucTitle ID="UcTitle1" runat="server" />                    
        </td>
    </tr>                    
    <tr>
        <td align="center"> 
            <table>
                <tr>
                    <td align="center">                        
                        <asp:Label ID="Label3" runat="server" Text="Thâm niên theo" CssClass="label"></asp:Label>&nbsp;<asp:DropDownList ID="ddlTypeCompare" runat="server" CssClass="dropDownList">
                            <asp:ListItem Text="Ng&#224;y v&#224;o ng&#224;y h&#224;ng kh&#244;ng" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Ng&#224;y v&#224;o c&#244;ng ty" Value="2"></asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;
                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Số năm thâm niên"></asp:Label>
                        <asp:DropDownList ID="ddlOperator" runat="server" CssClass="dropDownList">
                            <asp:ListItem Value="0" Text=""></asp:ListItem>
                            <asp:ListItem Value="&gt;=" Text="&gt;="></asp:ListItem>
                            <asp:ListItem Value="&lt;=" Text="&lt;="></asp:ListItem>
                            <asp:ListItem Value="&gt;" Text="&gt;"></asp:ListItem>
                            <asp:ListItem Value="&lt;" Text="&lt;"></asp:ListItem>
                            <asp:ListItem Value="=" Text="="></asp:ListItem>
                        </asp:DropDownList><asp:TextBox ID="txtCountYear" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                    </td>                   
                </tr>
                <tr>
                    <td align="center">
                        <asp:Label ID="Label2" runat="server" Text="Phòng" CssClass="label"></asp:Label>
                        <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="center"><asp:Button ID="Button1" runat="server" CssClass="small color green button" Text="Thống kê" OnClick="Button1_Click" /></td>
                </tr>
            </table>                   
         </td>
    </tr>
    <tr>
        <td>    
            <table width="100%" class="tableBorder">
                <tr>
                    <td>                        
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CssClass="grid-Border" Width="100%" OnRowDataBound="GridView1_RowDataBound">
                            <Columns>
                                <asp:TemplateField HeaderText="M&#227; nh&#226;n vi&#234;n" SortExpression="UserId">                                    
                                    <ItemTemplate>
                                        <asp:Label ID="lbUserId" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="FullName" HeaderText="Họ v&#224; t&#234;n" SortExpression="FullName" />
                                <asp:BoundField DataField="RootName" HeaderText="Ph&#242;ng" SortExpression="RootName" />
                                <asp:TemplateField HeaderText="Ng&#224;y v&#224;o ng&#224;nh HK" SortExpression="JoinDate">
                                    <ItemTemplate>
                                        <asp:Label ID="lbJoinDate" runat="server" ></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ng&#224;y v&#224;o c&#244;ng ty" SortExpression="JoinCompanyDate">
                                    <ItemTemplate>
                                        <asp:Label ID="lbJoinCompanyDate" runat="server" ></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                            </Columns>
                             <HeaderStyle CssClass="grid-header" /> 
                            <RowStyle CssClass ="grid-item" />
                            <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                            <PagerStyle CssClass="grid-paper" />  
                            <PagerSettings PageButtonCount="30" />
                        </asp:GridView>
                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="StatisticSeniority"
                            TypeName="HRMBLL.H0.Statistic.STAEmployeeBLL" OldValuesParameterFormatString="original_{0}" OnSelecting="ObjectDataSource1_Selecting" OnSelected="ObjectDataSource1_Selected">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="rootId" QueryStringField="RId" Type="Int32" />
                                <asp:Parameter Name="Operator" Type="String" />
                                <asp:Parameter Name="countYear" Type="Int32" />
                                <asp:Parameter Name="typeCompare" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </td>
                </tr>
            </table>                
         </td>
    </tr>               
 </table>    
</asp:Content>

