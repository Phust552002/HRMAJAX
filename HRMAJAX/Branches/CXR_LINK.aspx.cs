using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Sockets;

public partial class Branches_CXR_LINK : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {


            string Str = "";
            string IPAddress = string.Empty;
            Str = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(Str);
            IPAddress[] addr = ipEntry.AddressList;
            IPAddress = addr[addr.Length - 1].ToString();

            Label1.Text = IPAddress;
            string base64_UserName = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ucPermission1.UserCurrent.UserName));
            string base64_Password = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ucPermission1.UserCurrent.Password));

            Response.Redirect("http://172.16.112.8/hrm/Login.aspx?n=" + base64_UserName + "&m=" + base64_Password);

            //if (ucPermission1.UserId == 339 || ucPermission1.UserId == 1)
            //{
            //    Response.Redirect("http://172.16.63.222/hrm/Login.aspx?n=" + ucPermission1.UserCurrent.UserName + "&m=" + ucPermission1.UserCurrent.Password);
            //}
            //else
            //{
            //    Response.Redirect("http://172.16.234.5/hrm/Login.aspx?n=" + ucPermission1.UserCurrent.UserName + "&m=" + ucPermission1.UserCurrent.Password);
            //}            
        }
    }
}