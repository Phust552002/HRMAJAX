<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MarkHTCV.aspx.cs" Inherits="Workdays_MarkHTCV" %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"
    TagPrefix="uc3" %>

<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc2" %>

<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>SAGS :: HRM :: HTCV</title>
    <link href="../Stylesheets/Styles.css" rel="stylesheet" type="text/css" />       
</head>
<body style="margin:0px;">
    <form id="form1" runat="server">
    <asp:ScriptManager id="ScriptManager1" runat="server"> </asp:ScriptManager>
    <div>
     
        <table style="width: 100%">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                        <ContentTemplate>
                            <uc1:ucTitle ID="UcTitle1" runat="server" />
                        </ContentTemplate>
                        <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="grdHTCVCatalogue" EventName="SelectedIndexChanged" />                                
                        </Triggers>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td>
                   <table style="width: 100%" class="tableBorder">
                        <tr>
                            <td class="tdLabel">
                                <asp:Label ID="Label1" runat="server" Text="Họ và tên" CssClass="label"></asp:Label></td>
                            <td class="tdValue" >
                                <asp:Label ID="lbFullName" runat="server" CssClass="value"></asp:Label></td>
                           <td class="tdLabel">
                                <asp:Label ID="Label4" runat="server" Text="Phòng ban" CssClass="label"></asp:Label></td>
                            <td class="tdValue"> 
                                <asp:Label ID="lbDepartment" runat="server" CssClass="value"></asp:Label></td>
                        </tr>                      
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                   
                        <table style="width: 100%" class="tableBorder">
                            <tr>
                                <td style="background-color:#f3f4f9;" align="right">
                                    <table cellpadding="0" cellspacing="0" width="100%">
                                        <tr>
                                            <td align="left"><asp:Label ID="Label3" runat="server" CssClass="label" Text="Lưu ý: (A1: 101->115); (A: 91->100); (B: 76->90); (C: 66->75); (D: 0->66)"></asp:Label></td>
                                            <td align="right"><asp:CheckBox ID="chkHide" runat="server" Text="Nhập Điểm Đánh Giá HTCV" CssClass="value" OnCheckedChanged="chkHide_CheckedChanged" AutoPostBack="True"/></td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:Panel ID="pnAdd" runat="server" Width="100%" Visible="false">                                
                                                <fieldset>
                                                    <legend class="legend">Bảng Tiêu Chí Đánh Giá</legend> 
                                                         <table style="width: 100%">
                                                             <tr>
                                                                <td align="right">
                                                                    &nbsp;<asp:Label ID="Label7" runat="server" CssClass="label" Text="Tiêu chí đánh giá"></asp:Label>
                                                                    <asp:TextBox ID="txtHTCVCatalogueNameFilter" runat="server" CssClass="textBox" Width="150px"></asp:TextBox>&nbsp;
                                                                    &nbsp;<asp:Label ID="Label5" runat="server" CssClass="label" Text="Thuộc nhóm"></asp:Label>
                                                                    <asp:DropDownList ID="ddlHTCVCatalogueTypeFilter" runat="server"
                                                                        CssClass="dropDownList" AutoPostBack="True" OnSelectedIndexChanged="ddlHTCVCatalogueTypeFilter_SelectedIndexChanged">                                    
                                                                    </asp:DropDownList>
                                                                    &nbsp;&nbsp;
                                                                    <asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/Images/Icon-Search.gif"
                                                                        OnClick="imgSearch_Click" />&nbsp;
                                                                </td>
                                                            </tr>
                                                         </table>   
                                                         <table class="tableBorder" style="width: 100%">                                         
                                                            <tr>
                                                                <td>
                                                                <div class="scrollcontent150">                                           
                                                                <asp:GridView ID="grdHTCVCatalogue" runat="server" AutoGenerateColumns="False" CssClass="grid-Border"
                                                                    DataKeyNames="HTCVCatalogueId" DataSourceID="odsHTCVCatalogue" OnRowDataBound="grdHTCVCatalogue_RowDataBound"
                                                                    Width="100%" OnSelectedIndexChanged="grdHTCVCatalogue_SelectedIndexChanged">
                                                                    <Columns>
                                                                        <asp:TemplateField HeaderText="Ti&#234;u ch&#237; đ&#225;nh gi&#225;" SortExpression="HTCVCatalogueName">                                                      
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="lbHTCVCatalogueName" runat="server" Text='<%# Bind("HTCVCatalogueName") %>'></asp:Label>
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="Left" />
                                                                            <HeaderStyle HorizontalAlign="Left" />
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Mức điểm" SortExpression="MarkDisplay">
                                                                            
                                                                            <ItemStyle HorizontalAlign="Center" Width="100px" />
                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="lbMarkDisplay" runat="server" Text='<%# Bind("MarkDisplay") %>'></asp:Label>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Điểm" SortExpression="MarkDefault">                                                       
                                                                            <ItemTemplate>
                                                                                <asp:TextBox ID="txtMark" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                        </asp:TemplateField>                                                  
                                                                        <asp:TemplateField HeaderText="Ng&#224;y">
                                                                            <ItemTemplate>
                                                                                <uc2:CalendarPicker ID="CalendarPicker1" runat="server" />
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Ghi ch&#250;">
                                                                            <ItemTemplate>
                                                                                <asp:TextBox ID="txtRemark" runat="server" CssClass="textBox"></asp:TextBox>
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="Left" />
                                                                            <HeaderStyle HorizontalAlign="Left" />
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Th&#234;m" ShowHeader="False">                                                      
                                                                            <ItemStyle HorizontalAlign="Center" Width="50px" />
                                                                            <ItemTemplate>
                                                                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False"
                                                                                    ImageUrl="~/Images/Add.gif" CommandName="Select" />                                                           
                                                                            </ItemTemplate>
                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                        </asp:TemplateField>
                                                                    </Columns>
                                                                    <HeaderStyle CssClass="grid-header" />
                                                                    <RowStyle CssClass="grid-item" />
                                                                    <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                                                    <PagerStyle CssClass="grid-paper" />
                                                                </asp:GridView>
                                                                </div>
                                                                <asp:ObjectDataSource ID="odsHTCVCatalogue" runat="server"
                                                                    OnSelecting="odsRelationType_Selecting" SelectMethod="GetByFilter" TypeName="HRMBLL.H1.HTCVCatalogueBLL" OldValuesParameterFormatString="original_{0}">
                                                                    <SelectParameters>
                                                                        <asp:Parameter Name="hTCVCatalogueName" Type="String" />
                                                                        <asp:Parameter Name="markDisplay" Type="String" />
                                                                        <asp:Parameter Name="markDefault" Type="Double" />
                                                                        <asp:Parameter Name="typeDisplay" Type="Int32" />
                                                                    </SelectParameters>
                                                                </asp:ObjectDataSource>
                                                                
                                                                </td>
                                                            </tr>
                                                        </table>
                                                 </fieldset>
                                            </asp:Panel>
                                            </td>
                                        </tr>
                                    </table>                                     
                                           
                                </td>
                            </tr>
                        </table>
                    
                </td>
            </tr>
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
                        <ContentTemplate>
                        <table style="width: 100%" class="tableBorder">
                             <tr>
                                <td style="background-color:#f0f1f5;">
                                    <fieldset>
                                        <legend class="legend">Bảng Điểm Đã Nhập</legend>
                                            <table class="tableBorder" style="width: 100%">                                         
                                                <tr>
                                                    <td>
                                                        <div class="scrollcontent150">   
                                                        <asp:GridView ID="grdSave" runat="server" AutoGenerateColumns="False" CssClass="grid-Border"
                                                            DataKeyNames="HTCVCatalogueId" OnRowDataBound="grdSave_RowDataBound"
                                                            Width="100%" OnSelectedIndexChanged="grdSave_SelectedIndexChanged">
                                                            <Columns>
                                                                <asp:TemplateField HeaderText="Ti&#234;u ch&#237; đ&#225;nh gi&#225;" SortExpression="HTCVCatalogueName">                                                      
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="lbHTCVCatalogueName" runat="server" Text='<%# Bind("HTCVCatalogueName") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                    <ItemStyle HorizontalAlign="Left" />
                                                                    <HeaderStyle HorizontalAlign="Left" />
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Mức điểm" SortExpression="MarkDisplay">
                                                                    <ItemStyle HorizontalAlign="Center" Width="100px" />
                                                                    <HeaderStyle HorizontalAlign="Center" />
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="lbMarkDisplay" runat="server" Text='<%# Bind("MarkDisplay") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Điểm" SortExpression="MarkDefault">                                                       
                                                                    <ItemTemplate>
                                                                        <asp:TextBox ID="txtMark" runat="server" CssClass="textBox" Width="50px"></asp:TextBox>
                                                                    </ItemTemplate>
                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                    <HeaderStyle HorizontalAlign="Center" />
                                                                </asp:TemplateField>
                                                                                                                  
                                                                <asp:TemplateField HeaderText="Ng&#224;y">
                                                                    <ItemTemplate>
                                                                        <uc2:CalendarPicker ID="CalendarPicker1" runat="server" />
                                                                    </ItemTemplate>
                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                    <HeaderStyle HorizontalAlign="Center" />
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Ghi ch&#250;">
                                                                    <ItemTemplate>
                                                                        <asp:TextBox ID="txtRemark" runat="server" CssClass="textBox"></asp:TextBox>
                                                                    </ItemTemplate>
                                                                    <ItemStyle HorizontalAlign="Left" />
                                                                    <HeaderStyle HorizontalAlign="Left" />
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Thao t&#225;c" ShowHeader="False">                                                      
                                                                    <ItemStyle HorizontalAlign="Center" Width="50px"/>
                                                                    <ItemTemplate>
                                                                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False"
                                                                            ImageUrl="~/Images/icon-delete.gif" CommandName="Select" />                                                           
                                                                    </ItemTemplate>
                                                                    <HeaderStyle HorizontalAlign="Center" />
                                                                </asp:TemplateField>
                                                            </Columns>
                                                            <HeaderStyle CssClass="grid-header" />
                                                            <RowStyle CssClass="grid-item" />
                                                            <AlternatingRowStyle CssClass="grid-atlternating-item" />
                                                            <PagerStyle CssClass="grid-paper" />
                                                        </asp:GridView>
                                                        </div>
                                                    </td>
                                                </tr>
                                            </table>
                                    </fieldset>
                                </td>
                            </tr>
                            <tr>
                                <td style="background-color:#f0f1f5;">
                                    <asp:Label ID="Label2" runat="server" CssClass="label" Text="Điểm cuối cùng : "></asp:Label>
                                    <asp:Label ID="lbMark" runat="server" CssClass="labelMarkHTCV" Text="0"></asp:Label>
                                    &nbsp; &nbsp; &nbsp;
                                    <asp:Label ID="lbTitleMarkBreach" runat="server" CssClass="label" Text="Điểm nhập : "></asp:Label>
                                    <asp:Label ID="lbMarkBreach" runat="server" CssClass="labelMarkHTCV" Text="0"></asp:Label>
                                    </td>
                            </tr>
                        </table>
                        </ContentTemplate>
                        <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="grdHTCVCatalogue" EventName="SelectedIndexChanged" />                                
                        </Triggers>
                    </asp:UpdatePanel>
                </td>
            </tr>                                
            <tr>
                <td>
                    <table style="width: 100%">                                                                                                             
                        <tr>
                            <td align="center" class="tdButton">
                                &nbsp;<asp:Button ID="btnOk" runat="server" Text="Lưu" CssClass="small color green button" Width="100px" OnClick="btnOk_Click" />&nbsp;
                                <asp:Button ID="btnCancel" runat="server" CssClass="small color green button" Text="Thoát" Width="100px" />
                            </td>
                        </tr>
                    </table>
                    <uc3:ucPermission ID="UcPermission1" runat="server" />
                </td>
            </tr>
        </table>
       
    </div>
    </form>
</body>
</html>
