<%@ Page Title="SAGS :: HUMAN RESOURCES MANAGEMENT" Language="C#" MasterPageFile="~/HRM-PM.master" AutoEventWireup="true" CodeFile="PMemberDetail.aspx.cs" Inherits="PMember_PMemberDetail" %>

<%@ Register Src="~/UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<%@ Register Src="~/PMember/UserControls/Personal.ascx" TagName="Personal" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/Tabs.ascx" TagName="Tabs" TagPrefix="uc3" %>
<%@ Register Src="~/Employee/UserControls/Family.ascx" TagName="Family" TagPrefix="uc4" %>
<%@ Register Src="~/Employee/UserControls/Working.ascx" TagName="Working" TagPrefix="uc5" %>
<%@ Register Src="../Administrator/UserControls/ucPermission.ascx" TagName="ucPermission" TagPrefix="uc6" %>
<%@ Register Src="~/UserControls/TabSub.ascx" TagName="TabSub" TagPrefix="uc7" %>
<%@ Register Src="UserControls/PMemberInfo.ascx" TagName="PMemberInfo" TagPrefix="uc8" %>

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
                                                                        <td align="center" valign="top">
                                                                          <table width="100%" cellpadding="0" cellspacing="0" > 
                                                                             <tr>
                                                                                <td valign="top">
                                                                                    <uc7:TabSub ID="Tabs2" runat="server" />
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
                                                                                                            <asp:MultiView ID="MultiTabs2" runat="server">
                                                                                                                <asp:View ID="MultiTabs2_Tab0" runat="server">
                                                                                                                    <table style="width: 100%">
                                                                                                                        <tr>
                                                                                                                            <td>                                                                        
                                                                                                                                <uc2:Personal ID="Personal1" runat="server" />
                                                                                                                            </td>
                                                                                                                        </tr>
                                                                                                                    </table>
                                                                                                                </asp:View>
                                                                                                                <asp:View ID="MultiTabs2_Tab1" runat="server">
                                                                                                                    <table style="width: 100%">
                                                                                                                        <tr>
                                                                                                                            <td>
                                                                                                                                <uc4:Family ID="Family1" runat="server" />
                                                                        
                                                                                                                            </td>
                                                                                                                        </tr>
                                                                                                                    </table>
                                                                                                                </asp:View>
                                                                                                                <asp:View ID="MultiTabs2_Tab2" runat="server">
                                                                                                                    <table style="width: 100%">
                                                                                                                        <tr>
                                                                                                                            <td>                                                                        
                                                                                                                                <uc5:Working ID="Working1" runat="server" />
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
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:View>
                                                            <asp:View ID="Tab1" runat="server">
                                                                <table style="width: 100%">
                                                                    <tr>
                                                                        <td>                                                                        
                                                                            <uc8:PMemberInfo ID="PMemberInfo1" runat="server" />
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

