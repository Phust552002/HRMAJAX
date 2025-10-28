using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using HRMBLL.H0;
using HRMBLL.BLLHelper;
using HRMUtil;

public partial class Leave_UserControls_AddSchedule : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.DataSource = EmployeesBLL.GetAll();
            DropDownList1.DataValueField = "UserId";
            DropDownList1.DataTextField = "FullName";
        }
    }
}