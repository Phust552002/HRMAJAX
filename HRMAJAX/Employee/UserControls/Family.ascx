<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Family.ascx.cs" Inherits="Employee_UserControls_Family" %>

<%@ Register Src="Family/Others.ascx" TagName="Others" TagPrefix="uc6" %>
<%@ Register Src="Family/Maternal.ascx" TagName="Maternal" TagPrefix="uc4" %>
<%@ Register Src="Family/UBFByMarriage.ascx" TagName="UBFByMarriage" TagPrefix="uc5" %>
<%@ Register Src="Family/Perternal.ascx" TagName="Perternal" TagPrefix="uc3" %>
<%@ Register Src="Family/MyFamily.ascx" TagName="MyFamily" TagPrefix="uc2" %>
<%@ Register Src="../../UserControls/TabSub.ascx" TagName="TabSub" TagPrefix="uc1" %>

<table width="100%">   
    <tr>
        <td align="center" valign="top">
            <table width="100%" >
                <tr>
                    <td valign="top" align="left" >
                       <fieldset class="fieldset" style="padding:2px 2px 2px 2px">
                                <legend class="legend"> Thông Tin Cá Nhân</legend>
                                    <table style="width: 100%">                                        
                                        <tr>
                                            <td align="center">
                                                <table style="width: 99%" class="tableBorder">
                                                    <tr>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label1" runat="server" Text="Họ và tên" CssClass="label"></asp:Label></td>
                                                        <td class="tdValue" >
                                                            <asp:Label ID="lbFullName" runat="server" CssClass="value"></asp:Label></td>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label4" runat="server" Text="Phòng ban" CssClass="label"></asp:Label></td>
                                                        <td class="tdValue"> &nbsp;<asp:Label ID="lbDepartment" runat="server" CssClass="value"></asp:Label></td>
                                                    </tr>
                                                    <tr>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label3" runat="server" Text="Tên truy cập" CssClass="label"></asp:Label></td>
                                                        <td class="tdValue">
                                                            <asp:Label ID="lbUserName" runat="server" CssClass="value"></asp:Label></td>
                                                        <td class="tdLabel">
                                                            <asp:Label ID="Label2" runat="server" Text="Chức danh" CssClass="label"></asp:Label></td>
                                                        <td class="tdValue"> 
                                                            <asp:Label ID="lbPosition" runat="server" CssClass="value"></asp:Label></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>                                        
                                    </table>
                            </fieldset>                      
                    </td>
                </tr>         
                <tr>
                    <td align="center" valign="top">
                      <table width="100%" cellpadding="0" cellspacing="0"> 
                        <tr>
                            <td align="right">
                                <uc1:TabSub ID="TabSub1" runat="server" />
                            </td>
                        </tr>                       
                        <tr>
                            <td>
                                <table width="100%" class="borderMultiViewSub" cellpadding="0" cellspacing="1">
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
                                                                            <uc2:MyFamily ID="MyFamily1" runat="server" />                                                                            
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:View>
                                                            <asp:View ID="Tab1" runat="server">
                                                                <table style="width: 100%">
                                                                    <tr>
                                                                        <td>
                                                                            <uc3:Perternal ID="Perternal1" runat="server" />
                                                                                                                                                    
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:View>
                                                            <asp:View ID="Tab2" runat="server">
                                                                <table style="width: 100%">
                                                                    <tr>
                                                                        <td>                                                                                                                                                    
                                                                            <uc4:Maternal ID="Maternal1" runat="server" />
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:View>
                                                            <asp:View ID="Tab3" runat="server">
                                                                <table style="width: 100%">
                                                                    <tr>
                                                                        <td>                                                                                                                                                    
                                                                            <uc5:UBFByMarriage ID="UBFByMarriage1" runat="server" />
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:View>
                                                             <asp:View ID="Tab4" runat="server">
                                                                <table style="width: 100%">
                                                                    <tr>
                                                                        <td>                                                                                                                                                    
                                                                            <uc6:Others ID="Others1" runat="server" />
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
        </td>
    </tr>
</table>