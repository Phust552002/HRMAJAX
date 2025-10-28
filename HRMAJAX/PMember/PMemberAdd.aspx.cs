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
using HRMBLL.H6;

public partial class PMember_PMemberAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "THÊM MỚI ĐẢNG VIÊN";
            BindDataToDDLStatus();
            BindDataToDDLEmployee();

            cpDateJoinP.Enabled = false;
            cpDateJoinPOfficial.Enabled = false;
            txtPlaceJoinP.Enabled = false;
            txtPCardNo.Enabled = false;
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

        ddlStatus.DataSource = Constants.GetAllPMemberStatus();
        ddlStatus.DataTextField = "RTypeName";
        ddlStatus.DataValueField = "RTypeId";
        ddlStatus.DataBind();
    }
    private void BindDataToDDLEmployee()
    {

        ddlEmployees.DataSource = PMembersBLL.GetEmployeesForImport(txtFullName.Text);
        ddlEmployees.DataTextField = "FullName";
        ddlEmployees.DataValueField = "UserId";
        ddlEmployees.DataBind();
    }
    
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            int status = int.Parse(ddlStatus.SelectedValue);
            UserId = int.Parse(ddlEmployees.SelectedValue);
            string fullName = ddlEmployees.SelectedItem.Text;
            EmployeesBLL employee = EmployeesBLL.GetEmployeeById(UserId);
            if (employee != null)
            {
                PMembersBLL.Add(UserId, cpDateJoinP.SelectedDate, cpDateJoinPOfficial.SelectedDate,
                               txtPlaceJoinP.Text, txtPCardNo.Text, status, fullName, employee.Sex);
            }
           
        }
        catch (HRMException he)
        {
            UcTitle1.ErrorText = he.Message;
        }
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/PMember/PMemberAdd.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/PMember/PMemberList.aspx");
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

    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            
            switch (ddlStatus.SelectedIndex)
            {
                case 1:
                    cpDateJoinP.Enabled = true;
                    cpDateJoinPOfficial.Enabled = false;
                    txtPlaceJoinP.Enabled = true;
                    txtPCardNo.Enabled = true;
                    break;
                case 2:
                    cpDateJoinP.Enabled = true;
                    cpDateJoinPOfficial.Enabled = true;
                    txtPlaceJoinP.Enabled = true;
                    txtPCardNo.Enabled = true;
                    break;
                default:
                    cpDateJoinP.Enabled = false;
                    cpDateJoinPOfficial.Enabled = false;
                    txtPlaceJoinP.Enabled = false;
                    txtPCardNo.Enabled = false;
                    break;
            }
        }
        catch
        { }
    }
}