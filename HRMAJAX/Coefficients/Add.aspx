<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Coefficients_Add" Title="Untitled Page" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table style="width: 100%">
    <tr>
        <td>
            <uc3:ucTitle ID="UcTitle1" runat="server" />                    
        </td>
    </tr>
    <tr>
        <td>
            <table width="100%">
                <tr>
                    
                    <td align="center">
                        <table>
                            <tr>                
                                <td align="right">                                                                  
                                    <asp:Label ID="Label11" runat="server" CssClass="label" Text="Tháng năm"></asp:Label>
                                    <asp:DropDownList ID="ddlMonth" runat="server" CssClass="dropDownList" Enabled="false">                                        
                                        <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                        <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                        <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                        <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                        <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                        <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                        <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                        <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                        <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                        <asp:ListItem Text="12" Value="12"></asp:ListItem>
                                    </asp:DropDownList><asp:DropDownList ID="ddlYear" runat="server" CssClass="dropDownList"  Enabled="false">                                        
                                    </asp:DropDownList>
                                    &nbsp;
                                    <asp:Button ID="btnView" runat="server" CssClass="small color green button" OnClick="btnView_Click"
                                        Text="Xem" Width="100px" Visible="false"/>&nbsp;<asp:Button ID="btnCancel" runat="server" CssClass="small color green button"
                                            OnClick="btnCancel_Click" Text="Thoát" Width="100px" />
                                </td>                                
                            </tr>                            
                        </table>
                        
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
        <td>
            <table class="tableBorder" width="100%">
                <tr>
                    <td>
                                                                                           
                        <asp:GridView ID="grdEquipmentDetail" runat="server" AutoGenerateColumns="False"
                            CssClass="grid-Border" PageSize="20" Width="100%" DataSourceID="odsEmployees" AllowPaging="True" OnRowDataBound="grdEquipmentDetail_RowDataBound">
                            <PagerSettings Mode="NumericFirstLast" PageButtonCount="30" />
                            <Columns>
                                <asp:TemplateField HeaderText="STT" SortExpression="OrderNumber">
                                    <ItemTemplate>
                                        <asp:Label ID="lbOrderNumber" runat="server" ></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="M&#227; SAC" SortExpression="OrderNumber">
                                    <ItemTemplate>
                                        <asp:Label ID="lbEmployeeCode" runat="server" ></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="M&#227; NV" SortExpression="OrderNumber">
                                    <ItemTemplate>
                                        <asp:Label ID="lbUserId" runat="server" ></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Họ v&#224; T&#234;n" SortExpression="EquipmentName">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="lnkFullname" runat="server" CssClass="hyperlink-Grid" ></asp:HyperLink>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>                                
                                <asp:TemplateField HeaderText="LNS" SortExpression="OperativePeriodEnd">
                                    <ItemTemplate>
                                        <asp:Label ID="lbOperativePeriodEnd" runat="server"></asp:Label>
                                        <asp:TextBox ID="txtOperativePeriodEnd" runat="server" CssClass="textBox" Width="60px"></asp:TextBox>
                                    </ItemTemplate>
                                     <ItemStyle Width="5%" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="LCB" SortExpression="Production">
                                    <ItemTemplate>
                                        <asp:Label ID="lbProduction" runat="server"></asp:Label>
                                        <asp:TextBox ID="txtProduction" runat="server" CssClass="textBox" Width="60px"></asp:TextBox>                                        
                                    </ItemTemplate>
                                     <ItemStyle Width="5%" />
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="PCDH" SortExpression="RemanentFuelPeriodEnd">
                                    <ItemTemplate>
                                        <asp:Label ID="lbRemanentFuelPeriodEnd" runat="server"></asp:Label>
                                        <asp:TextBox ID="txtRemanentFuelPeriodEnd" runat="server" CssClass="textBox" Width="60px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ItemStyle Width="5%" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="PCTN" SortExpression="RemanentFuelPeriodEnd">
                                    <ItemTemplate>
                                        <asp:Label ID="lbRemanentFuelPeriodEnd" runat="server"></asp:Label>
                                        <asp:TextBox ID="txtRemanentFuelPeriodEnd" runat="server" CssClass="textBox" Width="60px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ItemStyle Width="5%" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="PCKV" SortExpression="RemanentFuelPeriodEnd">
                                    <ItemTemplate>
                                        <asp:Label ID="lbRemanentFuelPeriodEnd" runat="server"></asp:Label>
                                        <asp:TextBox ID="txtRemanentFuelPeriodEnd" runat="server" CssClass="textBox" Width="60px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ItemStyle Width="5%" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="PCCV" SortExpression="RemanentFuelPeriodEnd">
                                    <ItemTemplate>
                                        <asp:Label ID="lbRemanentFuelPeriodEnd" runat="server"></asp:Label>
                                        <asp:TextBox ID="txtRemanentFuelPeriodEnd" runat="server" CssClass="textBox" Width="60px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ItemStyle Width="5%" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ghi ch&#250;" SortExpression="EDRemark">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txtEDRemark" runat="server" CssClass="textBox" Width="99%"></asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <RowStyle CssClass="grid-item" />
                            <PagerStyle CssClass="grid-paper" />
                            <HeaderStyle CssClass="grid-header1" />
                            <AlternatingRowStyle CssClass="grid-atlternating-item" />
                        </asp:GridView> 
                        <asp:ObjectDataSource id="odsEmployees" runat="server" SortParameterName="sortParameter" OnSelecting="odsEmployees_Selecting" TypeName="HRMBLL.H0.EmployeesBLL" SelectMethod="GetByDeptIds" OldValuesParameterFormatString="original_{0}" OnSelected="odsEmployees_Selected">
                            <SelectParameters>
                                <asp:Parameter Type="String" Name="deptIds"></asp:Parameter>
                                <asp:Parameter Type="Int32" Name="rootId"></asp:Parameter>
                                <asp:Parameter Type="String" Name="fullName"></asp:Parameter>
                                <asp:Parameter Type="String" Name="sortParameter"></asp:Parameter>
                                <asp:Parameter Name="AirlinesWorking" Type="String" />
                            </SelectParameters>
                        </asp:ObjectDataSource>                                                                       
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td style="BACKGROUND-COLOR: #cccc99" valign="top" align="center"> 
            <asp:ImageButton id="ImageButton1" onclick="ímgSave_Click" runat="server" ImageUrl="~/Images/icon-save.gif"></asp:ImageButton><asp:Label id="Label1" runat="server" CssClass="label" Text="Lưu"></asp:Label>
        </td>
    </tr>
</table>    

</asp:Content>

