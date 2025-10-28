<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ContractFilter.ascx.cs" Inherits="Contracts_UserControls_ContractFilter" %>
<table cellpadding="0" cellspacing="0" style="width: 100%;" class="LeftMenu">    
    <tr>
        <td class="LeftMenu" valign="top">
            <table cellpadding="0" cellspacing="0" style="width: 100%;">    
                <tr>
                    <td align="center" style="height:25px">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/leftmenuline.jpg"></asp:Image></td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Label ID="lbTitleFilter" runat="server" CssClass="LeftMenuTitle"></asp:Label></td>
                </tr>
                <tr>
                    <td align="center" style="height:25px">
                        <asp:Image ID="imgLeftMenuLine" runat="server" ImageUrl="~/Images/leftmenuline.jpg"></asp:Image></td>
                </tr>
                <tr>
                    <td align="center">
                        <table cellpadding="0" cellspacing="0" >
                             <tr>
                                <td>                       
                                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Tên Nhân Viên"></asp:Label><br />
                                    <asp:TextBox ID="txtFullName" runat="server" CssClass="textBox" Width="150px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lbDepartment" runat="server" CssClass="label" Text="Phòng Ban"></asp:Label><br />
                                    <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList" Width="150px"></asp:DropDownList>
                                </td>
                            </tr>
                            <asp:Panel ID="pnContractType" runat="server">
                            <tr>
                                <td>
                                    <asp:Label ID="lbContractType" runat="server" Text="Loại HĐ" CssClass="label"></asp:Label><br />
                                    <asp:DropDownList ID="ddlContractType" runat="server" CssClass="dropDownList" Width="150px"></asp:DropDownList>
                                </td>
                            </tr>
                            </asp:Panel>
                            <asp:Panel ID="pnDateFilter" runat="server">
                            <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server" CssClass="label" Text="Từ "></asp:Label>&nbsp;<asp:DropDownList
                                        ID="ddlMonths" runat="server" CssClass="dropDownList">
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
                                    </asp:DropDownList><asp:DropDownList ID="ddlYears" runat="server" CssClass="dropDownList"></asp:DropDownList>
                                    </br><asp:Label ID="lbToDate" runat="server" CssClass="label" Text=""></asp:Label>
                                </td>
                            </tr>
                            </asp:Panel>
                            <tr>
                                <td>
                                    <asp:Label ID="lbViewAll" runat="server" Text="Xem tất cả" CssClass="label"></asp:Label>
                                    <asp:CheckBox ID="chkViewAll" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td align="center"><br />
                                    <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="Xem"  CssClass="small color green button" Width="100px" />
                                </td>
                            </tr>
                            <tr>
                                <td align="center"><br />
                                    <asp:Label ID="lbCountRecord" runat="server" CssClass="labelCountRecord"></asp:Label>                                    
                                </td>
                            </tr>
                        </table>
                        
                    </td>    
                </tr>
               
            </table>
        </td>
    </tr>
</table>        