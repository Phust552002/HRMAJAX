<%@ Page EnableEventValidation="false" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="UnofficialEmployeesDetail.aspx.cs" Inherits="Employee_UnofficialEmployeesDetail" Title="SAGS :: HUMAN RESOURCES MANAGEMENT"  %>

<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission"
    TagPrefix="uc6" %>

<%@ Register Src="UserControls/UnofficialPersonal.ascx" TagName="Personal" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/Tabs.ascx" TagName="Tabs" TagPrefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
<table width="100%">   
    <tr>
        <td align="center" valign="top">
            <table width="100%" >
                <tr>
                    <td valign="top" align="left" >
                        <uc1:ucTitle ID="UcTitle1" runat="server" />
                      
                    </td>
                </tr>         
                <tr>
                    <td align="center" valign="top">
                      <table width="100%" cellpadding="0" cellspacing="0" > 
                         <tr>
                            <td valign="top">
                                <uc3:Tabs ID="Tabs1" runat="server" />
                            </td>
                        </tr>                      
                        <tr>
                            <td>
                                <table width="100%" class="borderMultiView" cellpadding="0" cellspacing="1">
                                    <tr>
                                        <td>                                        
                                            <table width="100%" style="background-color:#ffffff">
                                                <tr>
                                                    <td>
                                                        <asp:MultiView ID="MultiTabs" runat="server">
                                                            <asp:View ID="Tab0" runat="server">
                                                                <table style="width: 100%">
                                                                    <tr>
                                                                        <td>                                                                        
                                                                            <uc2:Personal ID="Personal1" runat="server" />
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:View>
                                                        </asp:MultiView>
                                                     </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    
                                </table> 
                            </td>
                        </tr>
                        
                      </table>   
                        <uc6:ucPermission ID="UcPermission1" runat="server" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table> 
</asp:Content>

