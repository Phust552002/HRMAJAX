<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LNS.ascx.cs" Inherits="Coefficients_UserControls_LNS" %>
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
            <legend class="legend"> Quá trình chuyển đổi hệ số theo
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="1">Quy chế mới</asp:ListItem>
                    <asp:ListItem Value="-1">Tất cả</asp:ListItem>                    
                </asp:DropDownList>&nbsp;</legend>    
                <table style="width: 99%" class="tableBorder">
                    <tr>
                        <td align="center">
                            <asp:GridView ID="grdLNS_CoefficientEmployees" runat="server" AutoGenerateColumns="False"
                            DataSourceID="ods_LNS_CoefficientEmployees" DataKeyNames="LNS_CoefficientEmployeeId" OnRowEditing="grdLNS_CoefficientEmployees_RowEditing" CssClass="grid-Border" Width="100%" OnRowDeleted="grdLNS_CoefficientEmployees_RowDeleted" OnRowUpdated="grdLNS_CoefficientEmployees_RowUpdated" OnRowDataBound="grdLNS_CoefficientEmployees_RowDataBound">
                            <Columns>
                                <asp:TemplateField HeaderText="Hợp đồng" SortExpression="ContractTypeName">
                                    <EditItemTemplate>
                                        <asp:Label ID="grd_lbContractTypeName" runat="server" Text='<%# Bind("ContractTypeName") %>'></asp:Label>
                                        <asp:Label ID="grd_lbEmployeeContractId" runat="server" Visible ="false" Text='<%# Bind("EmployeeContractId") %>'></asp:Label>                            
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("ContractTypeName") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" Width="12%"/>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Chức danh c&#244;ng việc" SortExpression="PositionName">
                                    <EditItemTemplate>
                                        <asp:Label ID="grd_lbPosition" runat="server" Text='<%# Bind("PositionName") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("PositionName") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" Width="13%"/>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Chức danh hệ số" SortExpression="CoefficientName">
                                    <EditItemTemplate>
                                        <asp:DropDownList ID="grd_ddlCoefficientName" runat="server" CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="grd_ddlCoefficientName_SelectedIndexChanged" Width="90%">
                                        </asp:DropDownList>
                                        
                                        
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label9" runat="server" Text='<%# Bind("CoefficientName") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" Width="25%"/>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Mức" SortExpression="CoefficientLevelName">
                                    <EditItemTemplate>
                                        <asp:DropDownList ID="grd_ddl_CoefficientLevels" runat="server" DataSourceID="grd_odsCoefficientLevelName"
                                            DataTextField="CoefficientLevelName" DataValueField="CoefficientLevelId" SelectedValue = '<%# Bind("CoefficientLevelId") %>' AutoPostBack="True" OnSelectedIndexChanged="grd_ddl_CoefficientLevels_SelectedIndexChanged" CssClass="dropDownList">
                                        </asp:DropDownList>
                                        <asp:ObjectDataSource ID="grd_odsCoefficientLevelName" runat="server" SelectMethod="GetAll"
                                            TypeName="HRMBLL.H1.CoefficientLevelsBLL">
                                            <SelectParameters>
                                                <asp:Parameter DefaultValue="0" Name="type" Type="Int32" />
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
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("CoefficientValue") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="5%"/>
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Hưởng" SortExpression="Wages">
                                    <EditItemTemplate>                                        
                                        <asp:TextBox ID="TextBox3" runat="server" CssClass="textBox"  Text='<%# Bind("LNSWages") %>' Width="40%"></asp:TextBox><asp:DropDownList ID="DropDownList2" runat="server" CssClass="dropDownList" SelectedValue='<%# Bind("LNSUnit") %>' DataSourceID="ObjectDataSource2" DataTextField="UnitName" DataValueField="UnitId" Width="49%">
                                        </asp:DropDownList>
                                        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllUnit" TypeName="HRMUtil.Constants"></asp:ObjectDataSource>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("LNSWages") %>'></asp:Label><asp:Label ID="Label8" runat="server" Text='<%# Bind("LNSUnitName") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="10%"/>
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>                               
                                <asp:TemplateField HeaderText="PCTN" SortExpression="PCTN">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox2" runat="server" CssClass="textBox" Text='<%# Bind("PCTN") %>' Width="99%"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label10" runat="server" Text='<%# Bind("PCTN") %>'></asp:Label>
                                    </ItemTemplate>
                                     <ItemStyle HorizontalAlign="Center" Width="5%"/>
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ng&#224;y &#225;p dụng" SortExpression="CreateDate">
                                    <EditItemTemplate>
                                        <uc3:CalendarPicker ID="dpCreateDate" runat="server" SelectedDate='<%#Bind("CreateDate") %>'/>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbCreateDate" runat="server" ></asp:Label>
                                    </ItemTemplate>
                                     <ItemStyle HorizontalAlign="Center" Width="10%"/>
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ghi ch&#250;" SortExpression="LNS_CoefficientEmployeeDescription">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("LNS_CoefficientEmployeeDescription") %>' CssClass="textBox"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("LNS_CoefficientEmployeeDescription") %>'></asp:Label>
                                    </ItemTemplate>
                                     <ItemStyle HorizontalAlign="Center" Width="10%"/>
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                 
                                <asp:TemplateField HeaderText="Thao t&#225;c" ShowHeader="False">
                                <EditItemTemplate>
                                    <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="True" CommandName="Update" ImageUrl="~/Images/icon-save.gif"/>
                                    <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Cancel" ImageUrl="~/Images/icon-cancel.gif"/>
                                </EditItemTemplate>
                                <ItemStyle HorizontalAlign="Center" Width="5%"/>
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Edit" ImageUrl="~/Images/icon-edit.gif"/>
                                    <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/Images/icon-delete.gif" OnClientClick="return confirm('Bạn có muốn xóa thông tin đã chọn ?');"/>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" />
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
                            <asp:ObjectDataSource ID="ods_LNS_CoefficientEmployees" runat="server" OnSelecting="ods_LNS_CoefficientEmployees_Selecting"
                                SelectMethod="GetByUserId" TypeName="HRMBLL.H1.LNSCoefficientEmployeeBLL" OnUpdating="ods_LNS_CoefficientEmployees_Updating" DeleteMethod="Delete" UpdateMethod="Update">
                                <SelectParameters>
                                    <asp:Parameter Name="userId" Type="Int32" />
                                    <asp:Parameter Name="InUse" Type="Int32" />
                                </SelectParameters>
                                <DeleteParameters>
                                    <asp:Parameter Name="lNS_CoefficientEmployeeId" Type="Int32" />
                                </DeleteParameters>
                                <UpdateParameters>
                                    <asp:Parameter Name="lNS_CoefficientEmployeeId" Type="Int32" />
                                    <asp:Parameter Name="userId" Type="Int32" />
                                    <asp:Parameter Name="employeeContractId" Type="Int32" />
                                    <asp:Parameter Name="contractTypeName" Type="String" />
                                    <asp:Parameter Name="positionName" Type="String" />
                                    <asp:Parameter Name="CoefficientNameId" Type="Int32" />
                                    <asp:Parameter Name="coefficientLevelId" Type="Int32" />
                                    <asp:Parameter Name="coefficientValue" Type="String" />
                                    <asp:Parameter Name="lNSWages" Type="Double" />
                                    <asp:Parameter Name="lNSUnit" Type="Int32" />
                                    <asp:Parameter Name="createDate" Type="DateTime" />
                                    <asp:Parameter Name="lNS_CoefficientEmployeeDescription" Type="String" />
                                    <asp:Parameter Name="active" Type="Boolean" />
                                    <asp:Parameter Name="pCTN" Type="Double" />
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
                 <table style="width: 98%;margin-top:2px; margin-left:2px; margin-right:2px; margin-bottom:2px;" class="tableBorder">
                     <tr>
                         <td class="tdLabel">
                             <asp:Label ID="Label6" runat="server" CssClass="label" Text="Hợp đồng"></asp:Label></td>
                         <td class="tdValue">
                             <asp:HyperLink ID="lnkEmployeeContract" runat="server" CssClass="hyperlink">None</asp:HyperLink></td>
                     </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label7" runat="server" CssClass="label" Text="Chức danh công việc"></asp:Label></td>
                        <td class="tdValue">
                            <asp:Label ID="lbPositionContract" runat="server" CssClass="value"></asp:Label></td>
                    </tr>
                     <tr>
                         <td class="tdLabel">
                             <asp:Label ID="Label15" runat="server" CssClass="label" Text="Chức danh hệ số"></asp:Label></td>
                         <td class="tdValue">
                         <asp:DropDownList ID="ddlCoefficientNames" runat="server" CssClass="dropDownList" OnSelectedIndexChanged="ddlCoefficientNames_SelectedIndexChanged"></asp:DropDownList>&nbsp;
                         </td>
                     </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label9" runat="server" CssClass="label" Text="Mức"></asp:Label></td>
                        <td class="tdValue">
                            <asp:DropDownList ID="ddlLevels" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLevels_SelectedIndexChanged" CssClass="dropDownList">
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label10" runat="server" CssClass="label" Text="Hệ số"></asp:Label></td>
                        <td class="tdValue">                           
                            <asp:Label ID="lbValue" runat="server" CssClass="value"></asp:Label></td>
                    </tr>                    
                     <tr>
                         <td class="tdLabel">
                             <asp:Label ID="lbNgay" runat="server" CssClass="label" Text="Đơn giá"></asp:Label>
                             <asp:Label ID="lbPercent" runat="server" Text="Mức hưởng" Visible="False" CssClass="label"></asp:Label></td>
                         <td class="tdValue">
                             <asp:TextBox ID="txtWage" runat="server" CssClass="textBox" Width="40px"></asp:TextBox>
                              <asp:DropDownList ID="ddlUnit" runat="server" CssClass="dropDownList">
                                <asp:ListItem Value="1">đ/ng&#224;y</asp:ListItem>
                                <asp:ListItem Value="2" Selected="True">%</asp:ListItem>
                            </asp:DropDownList></td>
                     </tr>
                      <tr>
                         <td class="tdLabel">
                            <asp:Label ID="Label16" runat="server" CssClass="label" Text="PCTN LNS"></asp:Label></td>
                         <td class="tdValue">
                            <asp:TextBox ID="txtPCTN_LNS" runat="server" CssClass="textBox"></asp:TextBox></td>
                     </tr>
                     <tr>
                         <td class="tdLabel">
                                <asp:Label ID="Label8" runat="server" CssClass="label" Text="Ngày áp dụng hệ số mới (dd/mm/yyyy)"></asp:Label></td>
                         <td class="tdValue">
                             <uc3:CalendarPicker ID="dpCreateDate" runat="server" />
                         </td>
                     </tr>
                    <tr>
                        <td class="tdLabel">
                            <asp:Label ID="Label11" runat="server" CssClass="label" Text="Mô tả"></asp:Label></td>
                        <td class="tdValue">
                            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" CssClass="textBox" Width="250px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2" class="tdButton">
                             <table style="width: 100%" >
                                 <tr>                                    
                                     <td align="center">
                                         <asp:Button ID="btnAdd" runat="server" CssClass="small color green button" OnClick="btnAdd_Click" Text="Thêm mới" Width="100px" /></td>
                                 </tr>
                             </table>
                      </td>
                      </tr>  
                </table>                
            </fieldset>
        </td>
    </tr>
</table>