using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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

public partial class Leave_LeaveScheduleList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Check đăng nhập
            EmployeesBLL objUser = UcPermission1.UserCurrent;
            if (objUser == null)
            {
                Response.Redirect("~/Login.aspx");

            }
            else
            {
                UcTitle1.Text = "";
                UcTitle1.Text = "ĐĂNG KÝ NGHỈ PHÉP THỰC TẾ";
            }
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            object objTemp = GridView1.DataKeys[e.Row.RowIndex].Value as object;
            int Max = 0;
            EmployeeLeaveScheduleBLL obj = (EmployeeLeaveScheduleBLL)e.Row.DataItem;

            HyperLink lnk = (HyperLink)row.FindControl("lnkFullName");
            if (obj.Status == 2)
            {
                Label lblStatus = (Label)row.FindControl("lblStatus");
                lblStatus.Text = "Đã duyệt";
                lblStatus.ForeColor = Color.Green;
                lblStatus.Font.Bold = true;

                lnk.Text = obj.FullName;
                lnk.NavigateUrl = "~/Leave/LeaveScheduleDetail.aspx?Id=" + obj.UserId + "&sid=" + Convert.ToInt32(objTemp) + "&p=" + 2;
                lnk.Font.Bold = true;
            }
            if (obj.Status == 3)
            {
                Label lblStatus = (Label)row.FindControl("lblStatus");
                lblStatus.Text = "Đã gửi";
                lblStatus.ForeColor = Color.Green;
                lblStatus.Font.Bold = true;

                lnk.Text = obj.FullName;
            }
            else
            {
                lnk.Text = obj.FullName;
            }

            #region Thống kê
            Label lblTotal = (Label)e.Row.FindControl("lblTotal");
            if (lblTotal != null)
            {
                DataRow dt = EmployeeLeaveBLL.GetRealLeaveByUserId(UcPermission1.UserCurrent.UserId, 0, DateTime.Now.Year);
                if (dt != null)
                {
                    Max = (Convert.ToInt32(obj.Seniority) + Convert.ToInt32(dt["MaxFCurrent"].ToString()));
                }
                lblTotal.Text = Max.ToString();
            }
            int Days;
            Label lblDays = (Label)e.Row.FindControl("lblDays");
            if (lblDays != null)
            {
                Days = Convert.ToInt32(GetLeaveDaysV1(obj.FromDate, obj.ToDate));
                lblDays.Text = GetLeaveDaysV1(obj.FromDate, obj.ToDate).ToString();
            }
            int DayLeft = 0;
            List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByFilter("", "", Convert.ToInt32(obj.UserId), 0, "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
            if (lst != null)
            {
                foreach (var item in lst)
                {
                    if (item != null)
                    {
                        DayLeft += item.Days;
                    }
                }
            }
            Label lblDaysLeft = (Label)e.Row.FindControl("lblDaysLeft");
            if (lblDaysLeft != null)
            {
                int Left = (Max - DayLeft);
                if (Left < 0)
                {
                    lblDaysLeft.Text = Left.ToString();
                    lblDaysLeft.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblDaysLeft.Text = Left.ToString();
                    lblDaysLeft.ForeColor = System.Drawing.Color.Blue;
                }
            }
            #endregion

            #region Ẩn/ hiện Deny
            Label DenyReason = (Label)e.Row.FindControl("Label3");
            
            if (objTemp != null)
            {
                List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst1 = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByEmployeeLeaveScheduleId(Convert.ToInt32(objTemp));
                if (lst1[0].Status == 0)
                {
                    DenyReason.Visible = false;
                    lnk.Enabled = false;
                }
                else if (lst1[0].Status == 1)
                {
                    DenyReason.Visible = false;
                    lnk.Enabled = false;
                }
                else if (lst1[0].Status == 2)
                {
                    DenyReason.Visible = false;
                    lnk.Enabled = true;
                }
                else if (lst1[0].Status == 3)
                {
                    DenyReason.Visible = false;
                    lnk.Enabled = false;
                }
                else if (lst1[0].Status == 4)
                {
                    row.BackColor = System.Drawing.Color.FromArgb(0x96, 0xD2, 0xA4);
                    row.Font.Bold = true;
                    DenyReason.Text = "Đã duyệt";
                    lnk.Enabled = false;
                }
                else
                {
                    row.BackColor = System.Drawing.Color.FromArgb(0xD4, 0x94, 0x94);
                    row.Font.Bold = true;
                    DenyReason.Visible = true;
                    DenyReason.Text = lst1[0].DenyReason;
                    lnk.Enabled = false;
                }
            }
            #endregion
        }
    }
    protected void imgSearch_Click(object sender, EventArgs e)
    {
        GridView1.DataBind();
    }
    public double GetLeaveDaysV1(DateTime fromDate, DateTime toDate)
    {

        int days = 0;
        DateTime tempFromDate = fromDate;

        while (tempFromDate.CompareTo(toDate) <= 0)
        {
            days++;

            tempFromDate = tempFromDate.AddDays(1);
        }

        List<DateTime> DateRange = GetDateRange(fromDate, toDate);

        int SubDays = (DateRange.Count / 7);

        return (days - SubDays);
    }
    public List<DateTime> GetDateRange(DateTime StartingDate, DateTime EndingDate)
    {
        if (StartingDate > EndingDate)
        {
            return null;
        }
        List<DateTime> rv = new List<DateTime>();
        DateTime tmpDate = StartingDate;
        do
        {
            rv.Add(tmpDate);
            tmpDate = tmpDate.AddDays(1);
        } while (tmpDate <= EndingDate);
        return rv;
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        
        GridView1.DataBind();
    }
    protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        List<EmployeesBLL> list = EmployeesBLL.GetByIds(UcPermission1.UserCurrent.UserId.ToString());

        string departmentIds = string.Empty;
        int departmentId = list[0].RootId;

        DepartmentsBLL obj = new DepartmentsBLL();
        obj.ChildNodeIds = departmentId.ToString() + ",";
        obj.GetAllChildId(departmentId);
        departmentIds = obj.ChildNodeIds;

        e.InputParameters["fullName"] = txtFullName.Text;
        e.InputParameters["departmentIds"] = "";
        e.InputParameters["UserId"] = UcPermission1.UserCurrent.UserId;
        e.InputParameters["Time"] = 0;
        e.InputParameters["Status"] = "";
        e.InputParameters["RootId"] = list[0].RootId;
        e.InputParameters["LevelPosition"] = -1;
        e.InputParameters["RangeFrom"] = filterFrom.SelectedDate == null || filterFrom.SelectedDate == HRMUtil.FormatDate.GetSQLDateMinValue ? HRMUtil.FormatDate.GetSQLDateMinValue : filterFrom.SelectedDate;
        e.InputParameters["RangeTo"] = filterFrom.SelectedDate == null || filterFrom.SelectedDate == HRMUtil.FormatDate.GetSQLDateMinValue ? HRMUtil.FormatDate.GetSQLDateMinValue : filterTo.SelectedDate;
    }
    protected void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridView1.DataBind();
    }
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        GridView1.DataBind();
    }
}