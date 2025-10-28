<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="PITDeductionDetail.aspx.cs" Inherits="Tax_PITDeductionDetail" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/Tabs.ascx" TagName="Tabs" TagPrefix="uc3" %>
<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table style="width: 100%">
    <tr>
        <td valign="top">
            <uc1:ucTitle ID="UcTitle1" runat="server" />                      
        </td>
    </tr>
    <tr>
        <td valign="top">
            <table style="width: 100%" class="tableBorder">
                <tr>
                    <td class="tdLabel" style="width:40%">
                        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Phòng"></asp:Label></td>
                    <td class="tdValue"  style="width:60%"><asp:DropDownList ID="ddlDepartment" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlEmployees_SelectedIndexChanged">
                    </asp:DropDownList></td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Lọc họ và tên"></asp:Label></td>
                    <td class="tdValue">                                               
                        <table cellpadding="0" cellspacing="0">
                            <tr>
                                <td>
                                    <asp:TextBox ID="txtFilterFullName" runat="server" CssClass="textBox"></asp:TextBox>
                                </td>
                                <td>
                                     <asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif"
                                     OnClick="imgSearch_Click" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Họ và tên cá nhân có thu nhập"></asp:Label></td>
                    <td class="tdValue">
                        <asp:DropDownList ID="ddlEmployees" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlEmployees_SelectedIndexChanged">
                        
                        </asp:DropDownList>
                    </td>
                </tr>               
                <tr>
                    <td class="tdLabel">
                        <asp:Label ID="Label7" runat="server" CssClass="label" Text="Mã số thuế"></asp:Label></td>
                    <td class="tdValue">
                        <asp:TextBox ID="txtTaxCode" runat="server" CssClass="textBox"></asp:TextBox></td>
                </tr>
                
                <tr>
                    <td colspan="2" align="left">
                    <table style="width: 100%" class="tableBorder">
                    <tr>
                        <td>
                            <asp:GridView ID="grdEmployeeRelation" runat="server" DataSourceID="odsEmployeeRelation" AutoGenerateColumns="False" Width="100%" CssClass="grid-Border" OnRowDataBound="grdEmployeeRelation_RowDataBound">
                            <Columns>
                                <asp:TemplateField HeaderText="Họ t&#234;n" SortExpression="RFullName">
                                    <ItemTemplate>
                                        <asp:Label ID="lbRFullName" runat="server" ></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ng&#224;y sinh" SortExpression="RDayOfBirth">
                                    <ItemTemplate>
                                        <asp:Label ID="lbBirthDay" runat="server"></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="M&#227; số thuế">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txtTaxNumber" runat="server" CssClass="textBox" Width="98%"></asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Số CMND/Hộ chiếu">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txtId_Passport" runat="server" CssClass="textBox" Width="98%"></asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="RelationTypeName" HeaderText="Quan hệ với ĐTTN" SortExpression="RelationTypeName">
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:TemplateField HeaderText="Thời điểm t&#237;nh giảm trừ (th&#225;ng/năm)">
                                    <ItemTemplate>
                                        <table cellpadding="0" cellspacing="0">
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="txtFromMonth" runat="server" CssClass="textBox" Width="30px"/><asp:TextBox ID="txtFromYear" runat="server" CssClass="textBox" Width="50px" />
                                                </td>
                                                <td>
                                                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Icon-DownLoad.gif"
                                             OnClick="ImageButton1_Click" />
                                                </td>
                                            </tr>
                                        </table>                                                                              
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="15%"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Thời điểm kết th&#250;c giảm trừ (th&#225;ng/năm)">
                                     <ItemTemplate>                                         
                                        <asp:TextBox ID="txtToMonth" runat="server" CssClass="textBox" Width="30px"/><asp:TextBox ID="txtToYear" runat="server" CssClass="textBox" Width="50px" />                                    
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center"  Width="15%"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Chọn">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="chkSelected" runat="server" />
                                     </ItemTemplate>
                                     <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                            </Columns>
                            <HeaderStyle CssClass="grid-header" /> 
                            <RowStyle CssClass ="grid-item" />
                            <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                            <PagerStyle CssClass="grid-paper" />                                                        
                        </asp:GridView>
                        <asp:ObjectDataSource ID="odsEmployeeRelation" runat="server" SelectMethod="GetByFilter" TypeName="HRMBLL.H0.EmployeeRelationBLL" OnSelecting="odsEmployeeRelation_Selecting" OldValuesParameterFormatString="original_{0}">
                            <SelectParameters>
                                <asp:Parameter Name="relationTypeId" Type="Int32" />
                                <asp:Parameter Name="userId" Type="Int32" />
                                <asp:Parameter Name="type" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>   
                        </td>
                    </tr>               
                </table>                    
                        </td>
                </tr>
                <tr>
                    <td colspan="2" align="left" class="tdValue">
                        <table>
                            <tr>
                                <td>
                                    <asp:Image ID="imgAddNewEmployeeRelation" runat="server" ImageUrl="~/Images/Add.gif" /></td>
                                <td>
                                <asp:LinkButton ID="lbtnAddNewEmployeeRelation" runat="server" CssClass="hyperlink" OnClick="lbtnAddNewEmployeeRelation_Click" Visible="False" CausesValidation="False">Thêm Mới Người Thân</asp:LinkButton></td>
                            </tr>
                        </table>
                    </td>
                </tr>    
                 <tr>
                    <td colspan="2" class="tdButton" align="center">
                        <asp:Button ID="btnAdd" runat="server" Text="Lưu" CssClass="small color green button" Width="100px" OnClick="btnAdd_Click"/>
                        &nbsp;
                        <asp:Button ID="btnAddAndCancel" runat="server" Text="Lưu Và Thoát" CssClass="small color green button" Width="100px" OnClick="btnAddAndCancel_Click"/>
                        &nbsp;
                        <asp:Button ID="btnCancel" runat="server" Text="Thoảt" CssClass="small color green button" Width="100px" OnClick="btnCancel_Click"/></td>
                    
                </tr>
            </table>                                                                       
            <uc2:ucPermission ID="UcPermission1" runat="server" />
        </td>
    </tr>       
                                    
    
</table>
 
</asp:Content>

