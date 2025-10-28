using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using HRMBLL.H0;
using HRMBLL.H1;
using HRMBLL.BLLHelper;
using HRMUtil;

public partial class Employee_EmployeeLeavesJobAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "THÊM MỚI NHÂN VIÊN NGHỈ VIỆC";
            BindDataToDDLStatus();

            if (Request.QueryString["Id"] != null)
            {
                UserId = int.Parse(Request.QueryString["Id"]);
                BindDataToDDLEmployeeLeaveJob();
                SetEmployeeInfor();
            }
            else
            {
                BindDataToDDLEmployee();
            }
            
        }
    }

    private int UserId
    {
        get
        {
            if (ViewState["UserId"] == null)
                return 0;
            else
                return int.Parse(ViewState["UserId"].ToString());
        }
        set
        {
            if (ViewState["UserId"] == null)
                ViewState["UserId"] = value;
        }
    }
    private int TypePage
    {
        get
        {
            if (ViewState["TypePage"] == null)
                return 0;
            else
                return int.Parse(ViewState["TypePage"].ToString());
        }
        set
        {
            ViewState["TypePage"] = value;
        }
    }

    private int PageIndex
    {
        get
        {
            if (ViewState["PageIndex"] == null)
                return 0;
            else
                return int.Parse(ViewState["PageIndex"].ToString());
        }
        set
        {
            if (ViewState["PageIndex"] == null)
                ViewState["PageIndex"] = value;
        }
    }

    private int DepartmentId
    {
        get
        {
            if (ViewState["DepartmentId"] == null)
                return 0;
            else
                return int.Parse(ViewState["DepartmentId"].ToString());
        }
        set
        {
            if (ViewState["DepartmentId"] == null)
                ViewState["DepartmentId"] = value;
        }
    }

    private void BindDataToDDLStatus()
    {

        ddlStatus.DataSource = Constants.GetAllEmployeeStatusForLeaveJob();
        ddlStatus.DataTextField = "RTypeName";
        ddlStatus.DataValueField = "RTypeId";
        ddlStatus.DataBind();
    }

    private void BindDataToDDLEmployee()
    {

        ddlEmployees.DataSource = EmployeesBLL.GetByDeptIdsForDataTable("", 0, txtFullName.Text, string.Empty);
        ddlEmployees.DataTextField = "FullName";
        ddlEmployees.DataValueField = "UserId";
        ddlEmployees.DataBind();
    }

    private void BindDataToDDLEmployeeLeaveJob()
    {

        ddlEmployees.DataSource = EmployeesBLL.GetEmployeeLeaveJobByFilterForDataTable(0,"", -1);
        ddlEmployees.DataTextField = "FullName";
        ddlEmployees.DataValueField = "UserId";
        ddlEmployees.DataBind();
    }

    private void SetEmployeeInfor()
    {
        if (Request.QueryString["d"] != null)
        {
            DepartmentId = int.Parse(Request.QueryString["d"].ToString());
        }
        if (Request.QueryString["i"] != null)
        {
            PageIndex = int.Parse(Request.QueryString["i"].ToString());
        }
        if (Request.QueryString["tp"] != null)
        {
            TypePage = int.Parse(Request.QueryString["tp"].ToString());
        }
        DataRow rv = EmployeesBLL.GetEmployeeByIdForDataRow(UserId);
        if (rv != null)
        {
            txtFullName.Enabled = false;
            ddlEmployees.Enabled = false;
            ddlEmployees.SelectedValue = UserId.ToString();
            cpLeaveDate.SelectedDate = (DateTime)rv["LeaveDate"];
            ddlStatus.SelectedValue = rv["Status"].ToString();
            txtLeaveRemark.Text = rv["LeaveRemark"].ToString();
        }
    }

   

    

    protected void odsEmployees_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        //DepartmentsBLL obj = new DepartmentsBLL();
        //obj.ChildNodeIds = DepartmentId.ToString() + ",";
        //obj.GetAllChildId(DepartmentId);
        //DepartmentIds = obj.ChildNodeIds;

        e.InputParameters["deptIds"] = "";
        e.InputParameters["rootId"] = 0;
        e.InputParameters["fullName"] = txtFullName.Text;
        e.InputParameters["sortParameter"] = string.Empty;
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            int status = int.Parse(ddlStatus.SelectedValue);
            UserId = int.Parse(ddlEmployees.SelectedValue);
            EmployeesBLL.UpdateStatus(status, cpLeaveDate.SelectedDate, txtLeaveRemark.Text, UserId);
            Response.Redirect("~/Employee/EmployeeLeavesJob.aspx?d=" + DepartmentId + "&p=" + PageIndex);
        }
        catch (HRMException he)
        {
            UcTitle1.ErrorText = he.Message;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Employee/EmployeeLeavesJob.aspx?d=" + DepartmentId + "&p=" + PageIndex);
    }
    protected void imgSearchFullName_Click(object sender, ImageClickEventArgs e)
    {
        ddlEmployees.Items.Clear();
        BindDataToDDLEmployee();
        try
        {
            if (ddlEmployees.Items.Count > 0)
            {
                ddlEmployees.SelectedIndex = 0;
                lbEmployeeCode.Text = "Mã NV: " + ddlEmployees.SelectedValue;
            }
        }
        catch { }
    }

    protected void ddlEmployees_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            lbEmployeeCode.Text = "Mã NV: " + ddlEmployees.SelectedValue;
        }
        catch
        { }
    }
}