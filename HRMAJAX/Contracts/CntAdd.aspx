<%@ Page Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="CntAdd.aspx.cs" Inherits="Contracts_CntAdd" Title="SAGS :: HUMAN RESOURCES MANAGEMENT" %>

<%@ Register Src="UserControls/SaveCnt.ascx" TagName="SaveCnt" TagPrefix="uc6" %>
<%@ Register Src="../UserControls/CalendarPicker.ascx" TagName="CalendarPicker" TagPrefix="uc5" %>
<%@ Register Src="../Employee/UserControls/Ele.ascx" TagName="Ele" TagPrefix="uc4" %>
<%@ Register Src="UserControls/ContractFilter.ascx" TagName="ContractFilter" TagPrefix="uc2" %>
<%@ Register Src="../UserControls/Title.ascx" TagName="Title" TagPrefix="uc3" %>
<%@ Register Src="../UserControls/LeftMenu.ascx" TagName="LeftMenu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td style="width:20%; height:500px" align="left" valign="top" class="LeftMenu" >
                <uc1:LeftMenu ID="LeftMenu1" runat="server" />
                <uc4:Ele ID="Ele1" runat="server" />                
            </td>
            <td valign="top">
                 <table cellpadding="0" cellspacing="0" style="width: 100%">
                    <tr>
                        <td>
                            <uc3:Title ID="Title1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <uc6:SaveCnt ID="SaveCnt1" runat="server" />
                        </td>
                    </tr>
                  </table>  
            </td>
        </tr>
    </table>
</asp:Content>

