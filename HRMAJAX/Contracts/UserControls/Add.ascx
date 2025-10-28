<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Add.ascx.cs" Inherits="Contracts_UserControls_Add" %>
<%@ Register Src="../../UserControls/CalendarPicker.ascx" TagName="CalendarPicker"
    TagPrefix="uc2" %>
<%@ Register Src="../../UserControls/DatePicker.ascx" TagName="DatePicker" TagPrefix="uc3" %>
<%@ Register Src="../../UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc1" %>
<table style="width: 100%">
    <tr>
    <td valign="Top">
        <uc1:MessageError ID="MessageError1" runat="server" />
        <table style="width: 100%" class="tableBorder">    
            <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Loại hợp đồng"></asp:Label></td>
                <td class="tdValue">
                    <asp:DropDownList ID="ddlContractType" runat="server" DataSourceID="odsContractTypes" DataTextField="ContractTypeName" DataValueField="ContractTypeId" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlContractType_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="odsContractTypes" runat="server" SelectMethod="GetAll_N"
                        TypeName="HRMBLL.H0.ContractTypesBLL" OldValuesParameterFormatString="original_{0}"></asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label2" runat="server" CssClass="label" Text="Chức danh công việc"></asp:Label></td>
                <td class="tdValue">
                    <asp:DropDownList ID="ddlPositions" runat="server" DataSourceID="odsPositions" DataTextField="PositionName"
                        DataValueField="PositionId" CssClass="dropDownList">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="odsPositions" runat="server" SelectMethod="GetAll_N" TypeName="HRMBLL.H0.PositionsBLL" OnSelected="odsPositions_Selected">
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label6" runat="server" Text="Đơn giá" CssClass="label"></asp:Label></td>
                <td class="tdValue">
                    <asp:TextBox ID="txtWages" runat="server" CssClass="textBox" Width="100px"></asp:TextBox>
                    <asp:DropDownList ID="ddlUnit" runat="server" CssClass="dropDownList">
                        <asp:ListItem Value="1">đ/ng&#224;y</asp:ListItem>
                        <asp:ListItem Value="2">%</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label3" runat="server" CssClass="label" Text="Từ ngày"></asp:Label></td>
                <td class="tdValue">
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <td>                                 
                                <uc2:CalendarPicker ID="dpFromDate" runat="server" />
                            </td>
                            <td>
                                <asp:ImageButton ID="imgCalculatedToDate" runat="server" ImageUrl="~/Images/icn_pen.gif" OnClick="imgCalculatedToDate_Click" /></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label4" runat="server" CssClass="label" Text="Đến ngày"></asp:Label></td>
                <td class="tdValue">                   
                    <asp:Label ID="lbToDate" runat="server" CssClass="value" Text="Không xác định"
                        Visible="False"></asp:Label>
                    <uc2:CalendarPicker ID="dpToDate" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="tdLabel">
                    <asp:Label ID="Label5" runat="server" CssClass="label" Text="Ghi chú"></asp:Label></td>
                <td class="tdValue">
                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" CssClass="textBox" Rows="3" Width="300px"></asp:TextBox>&nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center" class="tdButton">

                    <table style="width: 100%">
                        <tr>
                            <td align="center" colspan="3">
                                <asp:Button ID="btnAdd" runat="server" Text="Thêm mới " OnClick="btnAdd_Click" CssClass="small color green button" Width="100px"/></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </td>
    </tr>
</table>