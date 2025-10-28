<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="AppointmentAdd.aspx.cs" Inherits="Decisions_AppointmentAdd" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="UserControls/AppointmentAdd.ascx" TagName="AppointmentAdd" TagPrefix="uc4" %>


<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/Tabs.ascx" TagName="Tabs" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
    <tr>
        <td valign="top" >
            <uc1:ucTitle ID="UcTitle1" runat="server" />
            
        </td>
    </tr>
    <tr>
        <td>
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
                                                                    <uc4:AppointmentAdd ID="AppointmentAdd1" runat="server" />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:View>
                                                    <asp:View ID="Tab1" runat="server">
                                                        <table style="width: 100%">
                                                            <tr>
                                                                <td>                                                                    
                                                                
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
</asp:Content>

