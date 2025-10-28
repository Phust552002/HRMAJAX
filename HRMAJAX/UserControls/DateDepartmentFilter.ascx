<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DateDepartmentFilter.ascx.cs" Inherits="UserControls_DateDepartmentFilter" %>
<table style="width: 100%">
    <tr>
        <td align="right">
            <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server" Width="100px" CssClass="textBox"></asp:TextBox>
            &nbsp;
            <asp:Label ID="Label2" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="odsDepartment"
                DataTextField="DepartmentName" DataValueField="DepartmentId" CssClass="dropDownList">
            </asp:DropDownList>&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tháng"></asp:Label>
           <asp:DropDownList ID="ddlMonths" runat="server" CssClass="dropDownList">
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
            </asp:DropDownList>
            &nbsp;
            <asp:Label ID="Label4" runat="server" CssClass="label" Text="Năm"></asp:Label>
           <asp:DropDownList ID="ddlYears" runat="server" CssClass="dropDownList">
            </asp:DropDownList>
            &nbsp;
            <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="Xem" CssClass="small color green button"/>
            <asp:ObjectDataSource ID="odsDepartment" runat="server"
                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllRoots"
                TypeName="HRMBLL.H0.DepartmentsBLL">
            </asp:ObjectDataSource>
        </td>
    </tr>
   
</table>