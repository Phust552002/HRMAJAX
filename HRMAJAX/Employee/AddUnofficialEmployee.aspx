<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="AddUnofficialEmployee.aspx.cs" Inherits="Employee_AddUnofficialEmployee" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>
<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table style="width: 100%">
    <tr>
        <td>                   
           <uc1:ucTitle ID="UcTitle1" runat="server" />                        
        </td>
    </tr>
    <tr>
        <td>
           <table style="width: 100%" class="tableBorder">
                <tr>
                 <td style="width:30%" valign="top" class="tdTreeView" align="left">
                        <asp:TreeView  
                            ID="TreeView1"
                            ExpandDepth="1" 
                            PopulateNodesFromClient="true" 
                            ShowLines="true" 
                            ShowExpandCollapse="true" 
                            runat="server"
                            OnTreeNodePopulate="TreeView1_TreeNodePopulate" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
                            <RootNodeStyle CssClass="tvNodeRoot" />
                            <NodeStyle CssClass="tvNode" />
                            <ParentNodeStyle CssClass="tvNodeParent" />
                            <SelectedNodeStyle CssClass="tvNodeSelected" />
                        </asp:TreeView>  
                    </td>
                    <td valign="top" >
                    <fieldset>
                        <legend class="legend"><asp:Label ID="lbTitleList" runat="server" Text="Sags"></asp:Label></legend>
                        <table style="width: 100%" class="tableBorder">                                    
                            <tr>
                                <td align="left" class="tdLabel"><asp:Label ID="Label2" runat="server" CssClass="label" Text="Họ và tên"></asp:Label></td>
                                <td align="left" class="tdValue">
                                    <asp:TextBox ID="txtFullname" runat="server" CssClass="textBox" Width="200px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="left" class="tdLabel">
                                    &nbsp;<asp:Label ID="Label1" runat="server" CssClass="label" Text="Ngày sinh"></asp:Label></td>
                                <td align="left" class="tdValue">
                                    <uc2:CalendarPicker ID="cpBirthday" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td align="left" class="tdLabel"><asp:Label ID="Label3" runat="server" CssClass="label" Text="Giới tính"></asp:Label></td>
                                <td align="left" class="tdValue">
                                    <asp:RadioButton ID="rdoMale" runat="server" GroupName="Sex" Text="Nam" CssClass="value"/>
                                    <asp:RadioButton ID="rdoFamale" runat="server" GroupName="Sex" Text="Nữ" CssClass="value"/></td>
                            </tr>
                            <tr>
                                <td align="left" class="tdLabel">
                                    &nbsp;<asp:Label ID="Label5" runat="server" CssClass="label" Text="Điện thoại di động"></asp:Label></td>
                                <td align="left" class="tdValue">
                                    <asp:TextBox ID="txtHandPhone" runat="server" CssClass="textBox" Width="100px"></asp:TextBox></td>
                            </tr>
                          
                            <tr>
                               <td class="tdButton" colspan="2" align="center">                                
                                   <asp:Button ID="btnSave" runat="server" CssClass="small color green button" Text="Lưu" Width="100px" OnClick="btnSave_Click"/>
                                   &nbsp;&nbsp;
                                   <asp:Button ID="btnCancel" runat="server" CssClass="small color green button" Text="Thoát" Width="100px" OnClick="btnCancel_Click"/>
                               </td>
                           </tr>                           
                         </table>
                    </fieldset>
                            
                    </td>                          
                </tr>                      
              <uc3:ucPermission ID="UcPermission1" runat="server" />
            </table>
        </td>
    </tr>                                         
</table>
</asp:Content>

