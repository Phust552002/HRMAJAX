<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockReport.aspx.cs" Inherits="Employee_StockReport" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="../UserControls/ucTitle.ascx" TagName="ucTitle" TagPrefix="uc1" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>SAGS :: HUMAN RESOURCES MANAGEMENT</title>
    <link href="../Stylesheets/Styles.css" rel="stylesheet" type="text/css" />  
</head>
<body>
    <form id="form1" runat="server">
    <div>
     
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
                            <td class="tdLabel">
                                <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" 
                                    onrowdatabound="GridView1_RowDataBound" Width="100%">
                                 <RowStyle CssClass="grid-item"></RowStyle>
                                <PagerStyle CssClass="grid-paper"></PagerStyle>
                                <HeaderStyle CssClass="grid-header"></HeaderStyle>
                                <AlternatingRowStyle CssClass="grid-atlternating-item"></AlternatingRowStyle>
                                <SelectedRowStyle CssClass="grid-SelectedRowStyle"></SelectedRowStyle>
                                <FooterStyle CssClass="grid-footer"></FooterStyle>

                                </asp:GridView>
                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                                    SelectMethod="GetStockForReport" TypeName="HRMBLL.H0.EmployeesBLL">
                                </asp:ObjectDataSource>
                                </td>                            
                        </tr>                      
                       <tr>
                           <td class="tdButton" align="center">                                
                               <asp:Button ID="btnCancel" runat="server" CssClass="small color green button" Text="Thoát" Width="100px" OnClientClick="javascript:self.close();"/>                                
                           </td>
                       </tr>
                    </table>
                </td>
            </tr>                                         
        </table>
       
    </div>
    </form>
</body>
</html>

