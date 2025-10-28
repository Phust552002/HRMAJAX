<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="Timer.aspx.cs" Inherits="Timer" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
        <asp:Timer runat="server" id="UpdateTimer" interval="1000" ontick="UpdateTimer_Tick" />
        <asp:UpdatePanel runat="server" id="TimedPanel" updatemode="Conditional">
            <ContentTemplate>
<asp:Label id="DateStampLabel" runat="server" __designer:wfdid="w1"></asp:Label> 
</ContentTemplate>
            <Triggers>
<asp:AsyncPostBackTrigger ControlID="UpdateTimer" EventName="Tick"></asp:AsyncPostBackTrigger>
</Triggers>
        </asp:UpdatePanel>
        
        <asp:Timer runat="server" id="UpdateTimerGrid" interval="10000" OnTick="UpdateTimerGrid_Tick"  />
        <asp:UpdatePanel runat="server" id="GridRefesh" updatemode="Conditional">
            <ContentTemplate>
                 <asp:GridView ID="grdEmployeesList" runat="server" AllowPaging="True" AllowSorting="True"
                    AutoGenerateColumns="False" CssClass="grid-Border" DataKeyNames="UserId" DataSourceID="odsEmployees"
                    OnRowDataBound="grdEmployeesList_RowDataBound" PageSize="20" Width="100%">
                    <PagerSettings PageButtonCount="30" />
                    <Columns>
                        <asp:BoundField DataField="UserId" DataFormatString="{0:000#}" HeaderText="M&#227; NV"
                            HtmlEncode="False" SortExpression="UserId">
                            <ItemStyle HorizontalAlign="Left" />
                            <HeaderStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="EmployeeCode" HeaderText="M&#227; SAC" SortExpression="EmployeeCode">
                            <ItemStyle HorizontalAlign="Left" />
                            <HeaderStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Họ v&#224; t&#234;n" SortExpression="FullName">
                            <ItemStyle HorizontalAlign="Left" />
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemTemplate>
                                <asp:HyperLink ID="lnkFullName" runat="server" CssClass="hyperlink-Grid">[lnkFullName]</asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="PositionName" HeaderText="Chức danh" SortExpression="PositionName">
                            <ItemStyle HorizontalAlign="Left" />
                            <HeaderStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DepartmentFullName" HeaderText="Ph&#242;ng" SortExpression="RootId" />
                        <asp:TemplateField HeaderText="Ng&#224;y v&#224;o ng&#224;nh HK" SortExpression="JoinDate">
                            <ItemStyle HorizontalAlign="Center" />
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemTemplate>
                                <asp:Label ID="lbJoinDate" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ng&#224;y v&#224;o Cty" SortExpression="JoinCompanyDate">
                            <ItemTemplate>
                                <asp:Label ID="lbJoinCompanyDate" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <RowStyle CssClass="grid-item" />
                    <PagerStyle CssClass="grid-paper" />
                    <HeaderStyle CssClass="grid-header" />
                    <AlternatingRowStyle CssClass="grid-atlternating-item" />
                </asp:GridView>
                <asp:ObjectDataSource ID="odsEmployees" runat="server"
                    OnSelecting="odsEmployees_Selecting" SelectMethod="GetByDeptIds"
                    SortParameterName="sortParameter" TypeName="HRMBLL.H0.EmployeesBLL" 
                     OldValuesParameterFormatString="original_{0}">
                    <SelectParameters>
                        <asp:Parameter Name="deptIds" Type="String" />
                        <asp:Parameter Name="rootId" Type="Int32" />
                        <asp:Parameter Name="fullName" Type="String" />
                        <asp:Parameter Name="sortParameter" Type="String" />
                        <asp:Parameter Name="AirlinesWorking" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger controlid="UpdateTimerGrid" eventname="Tick" />
            </Triggers>
        </asp:UpdatePanel>
        
   


</asp:Content>

