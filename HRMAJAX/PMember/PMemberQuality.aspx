<%@ Page Title="" Language="C#" MasterPageFile="~/HRM-PM.master" AutoEventWireup="true" CodeFile="PMemberQuality.aspx.cs" Inherits="PMember_PMemberQuality" %>
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
                  <td align="left" class="tdLabel">&nbsp;<asp:Label ID="Label5" runat="server" CssClass="label" Text="Tìm theo năm"></asp:Label></td>
                  <td align="left" class="tdValue">
                      <asp:DropDownList ID="ddlYear" runat="server" CssClass="dropDownList" AppendDataBoundItems="true" AutoPostBack="true">
                      </asp:DropDownList></td>
              </tr>
                                         
              <tr>
                  <td class="tdButton" colspan="2" align="center">
                      <asp:Button ID="btnSearch" runat="server" CssClass="small color green button" Text="Tìm" Width="100px" OnClick="btnSearch_Click" />
                      &nbsp;&nbsp;
                        <asp:Button ID="btnExport" runat="server" CssClass="small color green button" Text="Xuất File" Width="100px" OnClick="btnExport_Click" /> 
                      &nbsp;&nbsp;
                        <asp:Button ID="btnCancel" runat="server" CssClass="small color green button" Text="Thoát" Width="100px" OnClick="btnCancel_Click" />                    
                  </td>
              </tr>

              <tr>
                  <asp:GridView  ID="grdEmployeesList" runat="server" AllowPaging="True" AllowSorting="True" 
                                 CssClass="grid-Border" PageSize="50" Width="100%">

                  </asp:GridView>
              </tr>
          </table>
        </td>
    </tr>                                         
</table>

</asp:Content>

