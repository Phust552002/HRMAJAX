<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="HTCVList.aspx.cs" Inherits="Catalogue_HTCVList" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/MessageError.ascx" TagName="MessageError" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
        <tr>
            <td valign="top" >
                <table style="width: 100%">
                    <tr>
                        <td valign="top">
                            <uc2:ucTitle ID="UcTitle1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" align="right">
                            <asp:CheckBox ID="chkHide" runat="server" Text="Thêm mới" CssClass="value" OnCheckedChanged="chkHide_CheckedChanged" AutoPostBack="True"/><br/>
                            <asp:Panel ID="pnAdd" runat="server" Width="100%" Visible="false">                            
                                <fieldset>
                                    <legend class="legend">Thêm mới mối quan hệ trong gia đình</legend>                               
                                    <table style="width: 100%" class="tableBorder">
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label3" runat="server" CssClass="label" Text="Tiêu chí đánh giá"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:TextBox ID="txtHTCVCatalogueName" runat="server" TextMode="MultiLine" Width="90%" CssClass="textBox"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label6" runat="server" CssClass="label" Text="Điểm mỗi lần vi phạm"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:TextBox ID="txtMarkDiplay" runat="server" CssClass="textBox" Width="100px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label4" runat="server" CssClass="label" Text="Điểm mặc định"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:TextBox ID="txtMarkDefault" runat="server" CssClass="textBox" Width="100px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="tdLabel">
                                                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Thuộc nhóm"></asp:Label></td>
                                            <td class="tdValue">
                                                <asp:DropDownList ID="ddlHTCVCatalogueType" runat="server" CssClass="dropDownList" DataSourceID="ObjectDataSource1" DataTextField="RTypeName" DataValueField="RTypeId">
                                                </asp:DropDownList>
                                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllHTCVCatalogueType"
                                                    TypeName="HRMUtil.Constants" OldValuesParameterFormatString="original_{0}"></asp:ObjectDataSource>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" class="tdButton" align="center">
                                                <asp:Button ID="btnAdd" runat="server" Text="Thêm Mới" CssClass="small color green button" Width="100px" OnClick="btnAdd_Click" />                                                 
                                            </td>
                                            
                                        </tr>
                                    </table>                                       
                                </fieldset>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <fieldset>
                                <legend class="legend">Bảng Tiêu Chí Đánh Giá Mức Độ Hoàn Thành Công Việc</legend>
                                <table style="width: 100%" >
                                    <tr>
                                        <td align="right">
                                            &nbsp;<asp:Label ID="Label7" runat="server" CssClass="label" Text="Tiêu chí đánh giá"></asp:Label>
                                            <asp:TextBox ID="txtHTCVCatalogueNameFilter" runat="server" CssClass="textBox" Width="200px"></asp:TextBox>&nbsp;
                                            &nbsp;<asp:Label ID="Label5" runat="server" CssClass="label" Text="Thuộc nhóm" ></asp:Label>
                                            <asp:DropDownList ID="ddlHTCVCatalogueTypeFilter" runat="server" DataSourceID="ObjectDataSource2" DataTextField="RTypeName" DataValueField="RTypeId" CssClass="dropDownList" AppendDataBoundItems="true">
                                            <asp:ListItem Text="" Value="0"></asp:ListItem>
                                            </asp:DropDownList>
                                            &nbsp;&nbsp;
                                            <asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif"
                                                OnClick="imgSearch_Click" />
                                            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllHTCVCatalogueType"
                                                TypeName="HRMUtil.Constants" OldValuesParameterFormatString="original_{0}"></asp:ObjectDataSource>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table style="width: 100%" class="tableBorder">
                                                <tr>
                                                    <td>
                                                        <asp:GridView ID="grdHTCVCatalogue" runat="server" DataSourceID="odsHTCVCatalogue" AutoGenerateColumns="False" Width="100%" CssClass="grid-Border" OnRowDataBound="grdHTCVCatalogue_RowDataBound" DataKeyNames="HTCVCatalogueId">
                                                            <Columns>
                                                                <asp:TemplateField HeaderText="Ti&#234;u ch&#237; đ&#225;nh gi&#225;" SortExpression="HTCVCatalogueName">
                                                                    <EditItemTemplate>
                                                                        <asp:TextBox ID="TextBox1" runat="server" CssClass="textBox" Text='<%# Bind("HTCVCatalogueName") %>' Rows="3" TextMode="MultiLine" Width="99%" ></asp:TextBox>
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="lbHTCVCatalogueName" runat="server" Text='<%# Bind("HTCVCatalogueName") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Mức điểm" SortExpression="MarkDisplay">
                                                                    <EditItemTemplate>
                                                                        <asp:TextBox ID="txtMarkDisplay" runat="server" Text='<%# Bind("MarkDisplay") %>' CssClass="textBox" Width="100px"></asp:TextBox>
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("MarkDisplay") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                    <HeaderStyle HorizontalAlign="Center" />
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Điểm mặc định" SortExpression="MarkDefault">
                                                                    <EditItemTemplate>
                                                                        <asp:TextBox ID="txtMarkDefault" runat="server" Text='<%# Bind("MarkDefault") %>' CssClass="textBox" Width="100px"></asp:TextBox>
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="lbMarkDefault" runat="server" Text='<%# Bind("MarkDefault") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                    <HeaderStyle HorizontalAlign="Center" />
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Thuộc Nh&#243;m" SortExpression="TypeDisplayName">
                                                                    <EditItemTemplate>
                                                                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropDownList" DataSourceID="ObjectDataSource3" DataTextField="RTypeName" DataValueField="RTypeId" SelectedValue='<%# Bind("TypeDisplay")%>'>
                                                                        </asp:DropDownList>
                                                                        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetAllHTCVCatalogueType"
                                                                            TypeName="HRMUtil.Constants" OldValuesParameterFormatString="original_{0}"></asp:ObjectDataSource>
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("TypeDisplayName") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                                 <asp:TemplateField HeaderText="Thao t&#225;c" ShowHeader="False">
                                                                    <EditItemTemplate>
                                                                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="True" CommandName="Update" ImageUrl="~/Images/icon-save.gif"/>
                                                                        <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Cancel" ImageUrl="~/Images/icon-cancel.gif"/>
                                                                    </EditItemTemplate>
                                                                    <ItemStyle HorizontalAlign="Center" Width="15%" />
                                                                    <ItemTemplate>
                                                                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Edit" ImageUrl="~/Images/icon-edit.gif"/>
                                                                        <asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Delete" ImageUrl="~/Images/icon-delete.gif" OnClientClick="return confirm('Bạn có muốn xóa thông tin này không?');"/>
                                                                    </ItemTemplate>
                                                                </asp:TemplateField> 
                                                            </Columns>
                                                            <HeaderStyle CssClass="grid-header" /> 
                                                            <RowStyle CssClass ="grid-item" />
                                                            <AlternatingRowStyle CssClass="grid-atlternating-item" />    
                                                            <PagerStyle CssClass="grid-paper" />                                                        
                                                        </asp:GridView>
                                                        <asp:ObjectDataSource ID="odsHTCVCatalogue" runat="server" SelectMethod="GetByFilter" TypeName="HRMBLL.H1.HTCVCatalogueBLL" OnSelecting="odsRelationType_Selecting" DeleteMethod="Delete" UpdateMethod="Update">
                                                            <SelectParameters>
                                                                <asp:Parameter Name="hTCVCatalogueName" Type="String" />
                                                                <asp:Parameter Name="markDisplay" Type="String" />
                                                                <asp:Parameter Name="markDefault" Type="Double" />
                                                                <asp:Parameter Name="typeDisplay" Type="Int32" />
                                                            </SelectParameters>
                                                            <DeleteParameters>
                                                                <asp:Parameter Name="hTCVCatalogueId" Type="Int32" />
                                                            </DeleteParameters>
                                                            <UpdateParameters>
                                                                <asp:Parameter Name="hTCVCatalogueName" Type="String" />
                                                                <asp:Parameter Name="markDisplay" Type="String" />
                                                                <asp:Parameter Name="markDefault" Type="Double" />
                                                                <asp:Parameter Name="typeDisplay" Type="Int32" />
                                                                <asp:Parameter Name="hTCVCatalogueId" Type="Int32" />
                                                            </UpdateParameters>
                                                        </asp:ObjectDataSource>
                                                    </td>
                                                </tr>
                                            </table>            
                                        </td>
                                    </tr>
                                </table>        
                            </fieldset>
                        </td>
                    </tr>
                    
                </table>
            </td>
        </tr>
</table>
</asp:Content>

