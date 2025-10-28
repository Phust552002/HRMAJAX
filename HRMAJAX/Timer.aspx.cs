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
using HRMUtil.KeyNames.H0;
using HRMUtil;
using HRMBLL.H1;

public partial class Timer : System.Web.UI.Page
{
    private int tt = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void UpdateTimer_Tick(object sender, EventArgs e)
    {
        DateStampLabel.Text = DateTime.Now.ToString();
    }
    protected void odsEmployees_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
       

        e.InputParameters["deptIds"] = "";
        e.InputParameters["rootId"] = 0;
        e.InputParameters["fullName"] = "";

    }
    protected void grdEmployeesList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {

            EmployeesBLL obj = (EmployeesBLL)e.Row.DataItem;
            HyperLink lnk = (HyperLink)e.Row.FindControl("lnkFullName");
            lnk.Text = obj.FullName;
            lnk.NavigateUrl = "~/Employee/EmployeesDetail.aspx?";

            Label lbJoinDate = (Label)row.FindControl("lbJoinDate");
            if (!obj.JoinDate.Equals(FormatDate.GetSQLDateMinValue))
            {
                lbJoinDate.Text = FormatDate.FormatVNDate(obj.JoinDate);
            }
            Label lbJoinCompanyDate = (Label)row.FindControl("lbJoinCompanyDate");
            if (!obj.JoinCompanyDate.Equals(FormatDate.GetSQLDateMinValue))
            {
                lbJoinCompanyDate.Text = FormatDate.FormatVNDate(obj.JoinCompanyDate);
            }
            if (row.RowIndex == 5)
            {
                if (countclick % 2 == 0)
                {
                    row.Cells[4].CssClass = "celltest";
                }
                else
                {
                    row.Cells[4].CssClass = "celltest2";
                }
            }
        }
    }
    private int countclick
    {
        get 
        {
            if (ViewState["countclick"] != null)
            {
                return int.Parse(ViewState["countclick"].ToString());
            }
            else
            {
                return 0;
            }
        }
        set
        {
            ViewState["countclick"] = value;
        }
    }

    protected void UpdateTimerGrid_Tick(object sender, EventArgs e)
    {
        countclick = countclick + 1;
        grdEmployeesList.DataBind();
    }
}
