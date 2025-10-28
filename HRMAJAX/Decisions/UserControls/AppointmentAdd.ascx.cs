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
using HRMBLL.H3;
using HRMUtil.KeyNames.H0;
using HRMUtil;

public partial class Decisions_UserControls_AppointmentAdd : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindDataToDropDownListDepartments();
            BindDataToDropDownListEmployees();
            BindDataToDropDownListPositions();
        }
    }

    private void BindDataToDropDownListDepartments()
    {
        ddlDepartment.DataSource = DepartmentsBLL.GetAllRoots();
        ddlDepartment.DataTextField = DepartmentKeys.FIELD_DEPARTMENT_NAME;
        ddlDepartment.DataValueField = DepartmentKeys.FIELD_DEPARTMENT_ID;
        ddlDepartment.DataBind();
    }

    private void BindDataToDropDownListEmployees()
    {
        ddlEmployees.DataSource = EmployeesBLL.GetByDeptIds("", 0, txtFullName.Text, "", "");
        ddlEmployees.DataTextField = EmployeeKeys.FIELD_EMPLOYEES_FULLNAME;
        ddlEmployees.DataValueField = EmployeeKeys.FIELD_EMPLOYEES_USERID;
        ddlEmployees.DataBind();
    }

    private void BindDataToDropDownListPositions()
    {
        ddlPositions.DataSource = PositionsBLL.GetAll();
        ddlPositions.DataTextField = PositionKeys.FIELD_POSITION_NAME;
        ddlPositions.DataValueField = PositionKeys.FIELD_POSITION_ID;
        ddlPositions.DataBind();
    }
    protected void imgSearch_Click(object sender, ImageClickEventArgs e)
    {
        BindDataToDropDownListEmployees();
    }
   
    protected void btnSave_Click(object sender, EventArgs e)
    {

    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
    protected void ddlEmployees_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
