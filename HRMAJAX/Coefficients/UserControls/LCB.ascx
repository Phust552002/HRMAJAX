<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LCB.ascx.cs" Inherits="Coefficients_UserControls_LCB" %>
<%@ Register Src="../../UserControls/CalendarPicker.ascx" TagName="CalendarPicker"
    TagPrefix="uc3" %>
<%@ Register Src="../../UserControls/DatePicker.ascx" TagName="DatePicker" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc1" %>

<table style="width: 100%">
        <tr>
            <td>
                <uc1:MessageError ID="MessageError1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <fieldset>
                <legend class="legend"> Quá trình chuyển đổi hệ số</legend>
                    <table style="width: 99%" class="tableBorder">
                    <tr>
                        <td align="center">
                            <asp:GridView ID="grdLCB_CoefficientEmployees" runat="server" AutoGenerateColumns="False"
                            DataSourceID="odsLCBCoefficientEmployees" DataKeyNames="LCB_CoefficientEmployeeId" OnRowEditing="grdLCB_CoefficientEmployees_RowEditing" CssClass="grid-Border" Width="100%" OnRowDataBound="grdLCB_CoefficientEmployees_RowDataBound" OnRowDeleted="grdLCB_CoefficientEmployees_RowDeleted" OnRowUpdated="grdLCB_CoefficientEmployees_RowUpdated">
                            <Columns>
                                <asp:TemplateField HeaderText="Hợp đồng" SortExpression="ContractTypeName">
                                    <EditItemTemplate>
                                        <asp:Label ID="grd_lbEmployeeContractId" runat="server" Visible="False" Text='<%# Bind("EmployeeContractId") %>'></asp:Label>
                                        <asp:Label ID="grd_lbContractTypeName" runat="server" Text='<%# Bind("ContractTypeName") %>' ToolTip='<%# Bind("ContractTypeId") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbContractTypeName" runat="server" Text='<%# Bind("ContractTypeName") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" Width="12%"/>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Chức danh c&#244;ng việc" SortExpression="CoefficientName">
                                    <EditItemTemplate>
                                        <asp:Label ID="grd_lbPositionName" runat="server" Text='<%# Bind("PositionName") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("PositionName") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" Width="11%"/>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Chức danh hệ số" SortExpression="CoefficientName">
                                    <EditItemTemplate>
                                        <asp:DropDownList ID="grd_ddlCoefficientNames" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="grd_ddlCoefficientNames_SelectedIndexChanged" Width="98%">
                                        </asp:DropDownList>
                                        
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbCoefficientName" runat="server" Text='<%# Bind("CoefficientName") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" Width="20%"/>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Bậc" SortExpression="CoefficientLevelName">
                                    <EditItemTemplate>
                                        <asp:DropDownList ID="grd_ddlCoefficientLevels" runat="server" DataSourceID="grd_odsCoefficientLevels"
                                            DataTextField="CoefficientLevelName" DataValueField="CoefficientLevelId" SelectedValue = '<%# Bind("CoefficientLevelId") %>' AutoPostBack="True" OnSelectedIndexChanged="grd_ddlCoefficientLevels_SelectedIndexChanged" CssClass="dropDownList">
                                        </asp:DropDownList>
                                        <asp:ObjectDataSource ID="grd_odsCoefficientLevels" runat="server" SelectMethod="GetAll"
                                            TypeName="HRMBLL.H1.CoefficientLevelsBLL">
                                            <SelectParameters>
                                                <asp:Parameter DefaultValue="1" Name="type" Type="Int32" />
                                            </SelectParameters>
                                        </asp:ObjectDataSource>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("CoefficientLevelName") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="5%"/>
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Hệ số" SortExpression="CoefficientValue">
                                    <EditItemTemplate>
                                        <asp:Label ID="grd_lbValue" runat="server" Text='<%# Bind("CoefficientValue") %>'></asp:Label>
                                        <asp:Label ID="grd_lbConditions" runat="server" CssClass="value" Text='<%# Bind("Conditions") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("CoefficientValue") %>'></asp:Label>
                                        <asp:Label ID="grd_lbConditions" runat="server" CssClass="value" Text='<%# Bind("Conditions") %>'></asp:Label>
                                    </ItemTemplate>
                                     <ItemStyle HorizontalAlign="Center" Width="12%"/>
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="Hưởng" SortExpression="Wages">
                                    <EditItemTemplate>                                        
                                        <asp:TextBox ID="TextBox3" runat="server" CssClass="textBox"  Text='<%# Bind("LCBWages") %>' Width="40%"></asp:TextBox><asp:DropDownList ID="DropDownList2" runat="server" CssClass="dropDownList" SelectedValue='<%# Bind("LCBUnit") %>' DataSourceID="ObjectDataSource2" DataTextField="UnitName" DataValueField="UnitId" Width="49%">
                                        </asp:DropDownList>
                                        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllUnit" TypeName="HRMUtil.Constants"></asp:ObjectDataSource>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbLCBWages" runat="server" Text='<%# Bind("LCBWages") %>'></asp:Label><asp:Label ID="lbLCBUnitName" runat="server" Text='<%# Bind("LCBUnitName") %>'></asp:Label>
                                    </ItemTemplate>
                                     <ItemStyle HorizontalAlign="Center" Width="10%"/>
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                
                                <asp:TemplateField HeaderText="Từ ng&#224;y" SortExpression="FromDate">
                                    <EditItemTemplate>
                                        <table cellpadding="0" cellspacing="0">
                                            <tr>
                                                <td>
                                                    <uc3:CalendarPicker ID="grd_dpFromDate" runat="server"  SelectedDate='<%#Bind("FromDate")%>'/>
                                                </td>
                                                <td><asp:ImageButton ID="grd_ImgSetToDate" runat="server" ImageUrl="~/Images/icn_pen.gif" OnClick="grd_ImgSetToDate_Click" /></td>
                                            </tr>
                                        </table>                                                                                
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label4" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "FromDate", "{0:dd/MM/yyyy}")%>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="8%"/>
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                
                                <asp:TemplateField HeaderText="Đến ng&#224;y" SortExpression="ToDate">
                                    <EditItemTemplate>
                                        <uc3:CalendarPicker ID="grd_dpToDate" runat="server" SelectedDate='<%#Bind("ToDate")%>'/>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label5" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "ToDate", "{0:dd/MM/yyyy}")%>'></asp:Label>
                                    </ItemTemplate>
                                     <ItemStyle HorizontalAlign="Center" Width="8%"/>
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ghi ch&#250;" SortExpression="LCB_CoefficientEmployeeDescription">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("LCB_CoefficientEmployeeDescription") %>' CssClass="textBox"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbLCB_CoefficientEmployeeDescription" runat="server" Text='<%# Bind("LCB_CoefficientEmployeeDescription") %>'></asp:Label>
                                    </ItemTemplate>
                                     <ItemStyle HorizontalAlign="Left" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Thao t&#225;c" ShowHeader="False">
                                <EditItemTemplate>
                                    <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="True" CommandName="Update" ImageUrl="~/Images/icon-save.gif"/>
                                    <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Cancel" ImageUrl="~/Images/icon-cancel.gif"/>
                                </EditItemTemplate>
                                <ItemStyle HorizontalAlign="Center"/>
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Edit" ImageUrl="~/Images/icon-edit.gif"/>
                                    <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/Images/icon-delete.gif" OnClientClick="return confirm('Bạn có muốn xóa thông tin đã chọn ?');"/>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" Width="5%"/>
                                </asp:TemplateField>   
                            </Columns>
                            <HeaderStyle CssClass="grid-header" /> 
                            <RowStyle CssClass ="grid-item" />
                            <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                            <PagerStyle CssClass="grid-paper" /> 
                                <EmptyDataTemplate>
                                    <asp:Label ID="Label14" runat="server" CssClass="value" Text="Chưa có thông tin hệ số về nhân viên này."></asp:Label>
                                </EmptyDataTemplate>
                        </asp:GridView>
                            <asp:ObjectDataSource ID="odsLCBCoefficientEmployees" runat="server" OnSelecting="ods_LCB_CoefficientEmployees_Selecting"
                    SelectMethod="GetByUserId" TypeName="HRMBLL.H1.LCBCoefficientEmployeeBLL" DeleteMethod="Delete" UpdateMethod="Update" OnUpdating="odsLCBCoefficientEmployees_Updating">
                    <SelectParameters>
                        <asp:Parameter Name="userId" Type="Int32" />
                    </SelectParameters>
                        <DeleteParameters>
                            <asp:Parameter Name="lCB_CoefficientEmployeeId" Type="Int32" />
                        </DeleteParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="lCB_CoefficientEmployeeId" Type="Int32" />
                            <asp:Parameter Name="userId" Type="Int32" />
                            <asp:Parameter Name="employeeContractId" Type="Int32" />
                            <asp:Parameter Name="positionName" Type="String" />
                            <asp:Parameter Name="coefficientNameId" Type="Int32" />
                            <asp:Parameter Name="coefficientLevelId" Type="Int32" />
                            <asp:Parameter Name="coefficientValue" Type="String" />
                            <asp:Parameter Name="lCBWages" Type="Double" />
                            <asp:Parameter Name="lCBUnit" Type="Int32" />
                            <asp:Parameter Name="fromDate" Type="DateTime" />
                            <asp:Parameter Name="toDate" Type="DateTime" />
                            <asp:Parameter Name="LCB_CoefficientEmployeeDescription" Type="String" />
                            <asp:Parameter Name="active" Type="Boolean" />
                            <asp:Parameter Name="contractTypeName" Type="String" />
                            <asp:Parameter Name="conditions" Type="String" />
                            <asp:Parameter Name="contractTypeId" Type="Int32" />
                        </UpdateParameters>
                </asp:ObjectDataSource>
                        </td>
                    </tr>
                    
                </table>
                </fieldset>
            </td>
        </tr>
        <tr>
            <td>
                <fieldset>
                    <legend class="legend"> Lập hệ số mới</legend>
                     <table width = "100%" style="width: 99%;margin-top:2px; margin-left:2px; margin-right:2px; margin-bottom:2px;" class="tableBorder">
                         <tr>
                             <td class="tdLabel">
                                 <asp:Label ID="Label7" runat="server" CssClass="label" Text="Hợp đồng"></asp:Label></td>
                             <td class="tdValue">
                                 <asp:HyperLink ID="lnkEmployeeContract" runat="server" CssClass="hyperlink"></asp:HyperLink></td>
                         </tr>
                        <tr>
                            <td class="tdLabel">
                                <asp:Label ID="Label8" runat="server" CssClass="label" Text="Chức danh công vệc"></asp:Label></td>
                            <td class="tdValue">
                                <asp:Label ID="lbContractPosition" runat="server" CssClass="value"></asp:Label></td>
                        </tr>
                         <tr>
                             <td class="tdLabel">
                                 <asp:Label ID="Label15" runat="server" CssClass="label" Text="Chức danh hệ số"></asp:Label></td>
                             <td class="tdValue">
                                 <asp:DropDownList ID="ddlCoefficientNames" runat="server" CssClass="dropDownList">
                                 </asp:DropDownList></td>
                         </tr>
                        <tr>
                            <td class="tdLabel"><asp:Label ID="Label9" runat="server" CssClass="label" Text="Bậc"></asp:Label></td>
                            <td class="tdValue">
                                <asp:DropDownList ID="ddlLevels" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLevels_SelectedIndexChanged" CssClass="dropDownList">
                                </asp:DropDownList>
                                </td>
                        </tr>
                        <tr>
                            <td class="tdLabel">
                                <asp:Label ID="Label10" runat="server" CssClass="label" Text="Hệ số"></asp:Label></td>
                            <td class="tdValue">
                                <asp:Label ID="lbValue" runat="server" CssClass="value"></asp:Label>
                                <asp:Label ID="lbConditions" runat="server" CssClass="value"></asp:Label></td>
                        </tr>
                         <tr>
                             <td class="tdLabel">
                                 <asp:Label ID="Label16" runat="server" CssClass="label" Text="Hưởng"></asp:Label></td>
                             <td class="tdValue">
                                 <asp:TextBox ID="txtWage" runat="server" CssClass="textBox" Width="40px"></asp:TextBox><asp:DropDownList
                                     ID="ddlUnit" runat="server" CssClass="dropDownList">
                                     <asp:ListItem Value="1">đ/ng&#224;y</asp:ListItem>
                                     <asp:ListItem Selected="True" Value="2">%</asp:ListItem>
                                 </asp:DropDownList></td>
                         </tr>
                         <tr>
                             <td class="tdLabel">
                                 <asp:Label ID="Label11" runat="server" CssClass="label" Text="Từ ngày"></asp:Label></td>
                             <td class="tdValue">                                 
                                 <table cellpadding="0" cellspacing="0">
                                     <tr>
                                         <td>
                                            <uc3:CalendarPicker ID="dpFromDate" runat="server" />
                                         </td>
                                         <td>
                                             <asp:ImageButton ID="imgSetToDate" runat="server" ImageUrl="~/Images/icn_pen.gif"
                                                 OnClick="imgSetToDate_Click" /></td>
                                     </tr>
                                 </table>
                                 
                             </td>
                         </tr>
                         <tr>
                             <td class="tdLabel">
                                 <asp:Label ID="Label12" runat="server" CssClass="label" Text="Đến ngày"></asp:Label></td>
                             <td class="tdValue">
                                 <uc3:CalendarPicker ID="dpToDate" runat="server" />
                             </td>
                         </tr>
                        <tr>
                            <td class="tdLabel">
                                <asp:Label ID="Label13" runat="server" CssClass="label" Text="Mô tả"></asp:Label></td>
                            <td class="tdValue">
                                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" CssClass="textBox" Width="300px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td colspan ="2" align="center" class="tdButton">
                                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Thêm mới" CssClass="small color green button"/>
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
</table>