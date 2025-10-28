<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true" CodeFile="LINK_SAGS.aspx.cs" Inherits="SAGS_LINK_SAGS" %>

<%@ Register src="../Administrator/UserControls/ucPermission.ascx" tagname="ucPermission" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    <uc1:ucPermission ID="ucPermission1" runat="server" />
</asp:Content>

