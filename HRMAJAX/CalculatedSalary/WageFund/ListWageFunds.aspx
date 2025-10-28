<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="ListWageFunds.aspx.cs" Inherits="CalculatedSalary_ListWageFunds" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../../UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc1" %>

<%@ Register Src="~/UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc3" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
    <tr>
        <td>
            <uc2:ucTitle ID="UcTitle1" runat="server" />
        </td>
    </tr>       
    <tr>
        <td align="center" colspan="2">
             <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                    <ProgressTemplate>
                        <asp:Image ID="Image2" runat="server" ImageUrl="~/images/run.gif" />
                        <asp:Label ID="Label4" runat="server" CssClass="value" Text="Đang Xử Lý..."></asp:Label>
                    </ProgressTemplate>
                </asp:UpdateProgress>
        </td>
    </tr>
    <tr>
        <td align="center">
            <asp:UpdatePanel id="UpdatePanel1" runat="server">
              <ContentTemplate>
<TABLE style="WIDTH: 100%"><TBODY><TR><TD vAlign=top><TABLE style="WIDTH: 100%"><TBODY><TR><TD align=center><asp:Label id="Label3" runat="server" CssClass="label" Text="Tháng năm"></asp:Label> <asp:DropDownList id="ddlMonths" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlMonths_SelectedIndexChanged">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList><asp:DropDownList id="ddlYears" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlYears_SelectedIndexChanged">
            </asp:DropDownList></TD></TR><TR><TD><TABLE style="WIDTH: 100%" class="tableBorder"><TBODY><TR><TD><asp:GridView id="grdWagwFunds" runat="server" Width="100%" CssClass="grid-Border" DataKeyNames="WageFundId" DataSourceID="ObjectDataSource1" OnRowDataBound="grdWagwFunds_RowDataBound" AutoGenerateColumns="False"><Columns>
<asp:TemplateField SortExpression="RootName" HeaderText="Ph&#242;ng"><EditItemTemplate>
                                                                                        <asp:Label ID="lbRootName" runat="server" Text='<%# Bind("RootName") %>'></asp:Label>
                                                                                    
                    
</EditItemTemplate>

<ItemStyle Width="20%" HorizontalAlign="Left"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
<ItemTemplate>
                                                                                        <asp:Label ID="lbRootName" runat="server" Text='<%# Bind("RootName") %>'></asp:Label>
                                                                                    
                    
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="FinalLNSCoefficientNoKTotal" HeaderText="Tổng Hệ Số LNS"><EditItemTemplate>
                                                                                        <asp:Label ID="lbFinalLNSCoefficientNoKTotal" runat="server"></asp:Label>
                                                                                    
                    
</EditItemTemplate>

<ItemStyle Width="5%" HorizontalAlign="Right"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
                                                                                        <asp:Label ID="lbFinalLNSCoefficientNoKTotal" runat="server"></asp:Label>
                                                                                    
                    
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="LNSOriginalWageFund" HeaderText="Quỹ Ban Đầu"><EditItemTemplate>
<asp:TextBox id="txtLNSOriginalWageFund" runat="server" CssClass="textBox" Text='<%# Bind("LNSOriginalWageFund") %>' __designer:wfdid="w2"> </asp:TextBox> 
</EditItemTemplate>

<ItemStyle Width="8%" HorizontalAlign="Right"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:Label id="lbLNSOriginalWageFund" runat="server" __designer:wfdid="w1"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="LNSShortTermWageFund" HeaderText="Quỹ Ngắn Hạn"><EditItemTemplate>
                                                                                        <asp:Label ID="lbLNSShortTermWageFund" runat="server" ></asp:Label>
                                                                                    
                    
</EditItemTemplate>

<ItemStyle Width="8%" HorizontalAlign="Right"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
                                                                                        <asp:Label ID="lbLNSShortTermWageFund" runat="server" ></asp:Label>
                                                                                    
                    
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="LNSNoKWageFund" HeaderText="Quỹ lương ĐV"><EditItemTemplate>
                                                                                        <asp:Label ID="lbLNSNoKWageFund" runat="server"></asp:Label>
                                                                                    
                    
</EditItemTemplate>

<ItemStyle Width="8%" HorizontalAlign="Right"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
                                                                                        <asp:Label ID="lbLNSNoKWageFund" runat="server"></asp:Label>
                                                                                    
                    
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="BonusShortTermWageFund" HeaderText="LNS"><EditItemTemplate>
<asp:Label id="lbLNSKWageFund" runat="server" __designer:wfdid="w10"></asp:Label> 
</EditItemTemplate>

<ItemStyle Width="8%" HorizontalAlign="Right"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:Label id="lbLNSKWageFund" runat="server" __designer:wfdid="w9"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="LNSBalanceWageFund" HeaderText="LNS C&#242;n Lại"><EditItemTemplate>
&nbsp;<asp:Label id="lbLNSBalanceWageFund" runat="server" __designer:wfdid="w8"></asp:Label> 
</EditItemTemplate>

<ItemStyle HorizontalAlign="Right"></ItemStyle>
<ItemTemplate>
<asp:Label id="lbLNSBalanceWageFund" runat="server" __designer:wfdid="w7"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="BonusOriginalWageFund" HeaderText="Quỹ Thưởng Ban Đầu"><EditItemTemplate>
<asp:TextBox id="txtBonusOriginalWageFund" runat="server" CssClass="textBox" Text='<%# Bind("BonusOriginalWageFund") %>' __designer:wfdid="w16"></asp:TextBox> 
</EditItemTemplate>

<ItemStyle Width="8%" HorizontalAlign="Right"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:Label id="lbBonusOriginalWageFund" runat="server" __designer:wfdid="w15"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="BonusNoKWageFund" HeaderText="Thưởng kỳ"><EditItemTemplate>
<asp:Label id="lbBonusKWageFund" runat="server" __designer:wfdid="w14"></asp:Label> 
</EditItemTemplate>

<ItemStyle Width="8%" HorizontalAlign="Right"></ItemStyle>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<ItemTemplate>
<asp:Label id="lbBonusKWageFund" runat="server" __designer:wfdid="w13"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="BonusBalanceWageFund" HeaderText="Thưởng C&#242;n Lại"><EditItemTemplate>
<asp:Label id="lbBonusBalanceWageFund" runat="server" __designer:wfdid="w12"></asp:Label>&nbsp; 
</EditItemTemplate>

<ItemStyle HorizontalAlign="Right"></ItemStyle>
<ItemTemplate>
<asp:Label id="lbBonusBalanceWageFund" runat="server" __designer:wfdid="w11"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField SortExpression="Remark" HeaderText="Ghi ch&#250;"><EditItemTemplate>
                                                                                        <asp:TextBox ID="txtRemark" runat="server" Text='<%# Bind("Remark") %>' CssClass="textBox"></asp:TextBox>
                                                                                    
                    
</EditItemTemplate>

<ItemStyle HorizontalAlign="Left"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
<ItemTemplate>
                                                                                        <asp:Label ID="lbRemark" runat="server" Text='<%# Bind("Remark") %>'></asp:Label>
                                                                                    
                    
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Thao t&#225;c" ShowHeader="False"><EditItemTemplate>
                                                                                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="True" CommandName="Update" ImageUrl="~/Images/icon-save.gif"/>
                                                                                        <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Cancel" ImageUrl="~/Images/icon-cancel.gif"/>
                                                                                    
                    
</EditItemTemplate>

<ItemStyle Width="5%" HorizontalAlign="Center"></ItemStyle>
<ItemTemplate>
                                                                                        <asp:ImageButton ID="imgEdit" runat="server" CausesValidation="False" CommandName="Edit" ImageUrl="~/Images/icon-edit.gif"/>                                        
                                                                                    
                    
</ItemTemplate>
</asp:TemplateField>
</Columns>

<RowStyle CssClass="grid-item"></RowStyle>

<PagerStyle CssClass="grid-paper"></PagerStyle>

<HeaderStyle CssClass="grid-header1"></HeaderStyle>

<AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
</asp:GridView> <uc1:MessageError id="MessageError1" runat="server" __designer:wfdid="w2"></uc1:MessageError></TD></TR></TBODY></TABLE><asp:ObjectDataSource id="ObjectDataSource1" runat="server" UpdateMethod="UpdateByOriginalWageFund" OnUpdating="ObjectDataSource1_Updating" TypeName="HRMBLL.H1.WageFundsBLL" SelectMethod="GetByCreateDate" OnSelecting="ObjectDataSource1_Selecting" OnSelected="ObjectDataSource1_Selected"><UpdateParameters>
<asp:Parameter Type="Int32" Name="rootId"></asp:Parameter>
<asp:Parameter Type="Decimal" Name="lNSOriginalWageFund"></asp:Parameter>
<asp:Parameter Type="Decimal" Name="lNSShortTermWageFund"></asp:Parameter>
<asp:Parameter Type="Decimal" Name="lNSNoKWageFund"></asp:Parameter>
<asp:Parameter Type="Decimal" Name="bonusOriginalWageFund"></asp:Parameter>
<asp:Parameter Type="Decimal" Name="bonusShortTermWageFund"></asp:Parameter>
<asp:Parameter Type="Decimal" Name="bonusNoKWageFund"></asp:Parameter>
<asp:Parameter Type="Double" Name="finalLNSCoefficientNoKTotal"></asp:Parameter>
<asp:Parameter Type="Int32" Name="apportionmentType"></asp:Parameter>
<asp:Parameter Type="String" Name="remark"></asp:Parameter>
<asp:Parameter Type="DateTime" Name="createDate"></asp:Parameter>
<asp:Parameter Type="Int32" Name="wageFundId"></asp:Parameter>
<asp:Parameter Type="String" Name="rootName"></asp:Parameter>
</UpdateParameters>
<SelectParameters>
<asp:Parameter Type="Int32" Name="month"></asp:Parameter>
<asp:Parameter Type="Int32" Name="year"></asp:Parameter>
<asp:Parameter Type="Boolean" Name="apportionmentType"></asp:Parameter>
</SelectParameters>
</asp:ObjectDataSource> </TD></TR></TBODY></TABLE><asp:Label id="lbError" runat="server" CssClass="value" ForeColor="Red" __designer:wfdid="w5"></asp:Label></TD></TR><TR><TD class="tdButton" align=center><asp:Button id="btnGetLNSCoefficient" onclick="btnGetLNSCoefficient_Click" runat="server" CssClass="small color green button" __designer:dtid="281474976710685" Text="Lấy Hệ Số" __designer:wfdid="w1"></asp:Button><asp:Button id="btnCalculateSalary" onclick="btnCalculateSalary_Click" runat="server" CssClass="small color green button" Text="Tính Lương"></asp:Button> </TD></TR></TBODY></TABLE>
</ContentTemplate>
            </asp:UpdatePanel> 
        </td>
    </tr>
    
    
</table>
<script type="text/javascript" src="../JScripts/wz_tooltip.js"></script>        
</asp:Content>

