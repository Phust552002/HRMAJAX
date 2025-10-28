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

public partial class Management_Leave_LeaveScheduleList : System.Web.UI.Page
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
                UcTitle1.Text = "DANH SÁCH ĐĂNG KÝ NGHỈ PHÉP THỰC TẾ";
            }
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            int Max = 0;
            EmployeeLeaveScheduleBLL obj = (EmployeeLeaveScheduleBLL)e.Row.DataItem;

            HyperLink lnk = (HyperLink)e.Row.FindControl("lnkFullName");
            lnk.Text = obj.FullName;
            //int Time = Convert.ToInt32(row.Cells[10].Text);
            lnk.NavigateUrl = "~/Leave/Management/LeaveScheduleDetail.aspx?Id=" + obj.UserId + "&p=" + 0 + "&sid=" + obj.EmployeeLeaveScheduleId;

            Label lblTotal = (Label)e.Row.FindControl("lblTotal");
            if (lblTotal != null)
            {
                Max = (Convert.ToInt32(obj.Seniority) + Convert.ToInt32(obj.MaxF));
                lblTotal.Text = Max.ToString();
            }
            int Days;
            Label lblDays = (Label)e.Row.FindControl("lblDays");
            if (lblDays != null)
            {
                Days = Convert.ToInt32(GetLeaveDaysV1(obj.FromDate, obj.ToDate));
                lblDays.Text = GetLeaveDaysV1(obj.FromDate, obj.ToDate).ToString();
                if (Days > 6)
                {
                    row.BackColor = System.Drawing.Color.FromArgb(0xFF, 0x8C, 0x8C);
                    row.ForeColor = System.Drawing.Color.White;
                }
            }
            int DayLeft = 0;
            List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByFilter("", "", Convert.ToInt32(obj.UserId), 0, "", 0, 0, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
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
                int Left = (Max - (DayLeft + Convert.ToInt32(GetLeaveDaysV1(obj.FromDate, obj.ToDate))));
                if (Left < 0)
                {
                    lblDaysLeft.Text = Left.ToString();
                    row.BackColor = System.Drawing.Color.FromArgb(0xFF, 0x8C, 0x8C);
                    row.ForeColor = System.Drawing.Color.White;
                }
                else
                {
                    lblDaysLeft.Text = Left.ToString();
                }
            }
            ImageButton imButton1 = (ImageButton)e.Row.FindControl("ImageButton1");
            ImageButton imButton2 = (ImageButton)e.Row.FindControl("ImageButton2");
            Label imStatus = (Label)e.Row.FindControl("Image1");
            Label DenyReason = (Label)e.Row.FindControl("Label3");
            object objTemp = GridView1.DataKeys[e.Row.RowIndex].Value as object;
            if (objTemp != null)
            {
                if (UcPermission1.IsHRAdmin || UcPermission1.IsAdmin)
                {
                    List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst1 = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByEmployeeLeaveScheduleId(Convert.ToInt32(objTemp));
                    if (lst1[0].Status == 0)
                    {
                        DenyReason.Visible = false;
                    }
                    else if (lst1[0].Status == 1)
                    {
                        DenyReason.Visible = false;
                    }
                    else if (lst1[0].Status == 2)
                    {
                        DenyReason.Visible = false;
                    }
                    else if (lst1[0].Status == 3)
                    {
                        DenyReason.Visible = false;
                    }
                    else if (lst1[0].Status == 4)
                    {
                        row.BackColor = System.Drawing.Color.FromArgb(0x96, 0xD2, 0xA4);
                        row.Font.Bold = true;
                        DenyReason.Text = "Đã duyệt";
                    }
                    else
                    {
                        row.BackColor = System.Drawing.Color.FromArgb(0xD4, 0x94, 0x94);
                        row.Font.Bold = true;
                        DenyReason.Visible = true;
                        DenyReason.Text = lst1[0].DenyReason;
                    }
                }
                else if (UcPermission1.IsLeaveManagerApproved)
                {
                    lnk.Enabled = true;
                    List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst1 = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByEmployeeLeaveScheduleId(Convert.ToInt32(objTemp));
                    if (lst1[0].Status == 0)
                    {
                        DenyReason.Visible = false;
                    }
                    else if (lst1[0].Status == 1)
                    {
                        DenyReason.Visible = false;
                    }
                    else if (lst1[0].Status == 2)
                    {
                        DenyReason.Visible = false;
                    }
                    else if (lst1[0].Status == 3)
                    {
                        DenyReason.Visible = false;
                    }
                    else if (lst1[0].Status == 4)
                    {
                        row.BackColor = System.Drawing.Color.FromArgb(0x96, 0xD2, 0xA4);
                        row.Font.Bold = true;
                        DenyReason.Text = "Đã duyệt";
                    }
                    else
                    {
                        row.BackColor = System.Drawing.Color.FromArgb(0xD4, 0x94, 0x94);
                        row.Font.Bold = true;
                        DenyReason.Visible = true;
                        DenyReason.Text = lst1[0].DenyReason;
                    }
                }
            }
            Label Label1 = (Label)e.Row.FindControl("Label1");
            Label Label2 = (Label)e.Row.FindControl("Label2");
            if (Label1.Text.Contains("1753") == true)
            {
                Label1.Text = "";
            }
            if (Label2.Text.Contains("1753") == true)
            {
                Label2.Text = "";
            }
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
        List<DepartmentsBLL> list = null;
        if (UcPermission1.IsAdmin || UcPermission1.IsHRAdmin)
        {
            list = DepartmentsBLL.GetAllRoots();
        }
        else
        {
            string deptIds = WorkDayPrivilegeBLL.GetDepartmentIDsByUserId(UcPermission1.UserId, Constants.WorkdayPrivilege_TimeKeeping);
            list = DepartmentsBLL.GetByIds(deptIds);
        }

        string departmentIds = string.Empty;
        int departmentId = list[0].RootId;

        DepartmentsBLL obj = new DepartmentsBLL();
        obj.ChildNodeIds = departmentId.ToString() + ",";
        obj.GetAllChildId(departmentId);
        departmentIds = obj.ChildNodeIds;

        e.InputParameters["fullName"] = txtFullName.Text;
        e.InputParameters["departmentIds"] = departmentIds;
        e.InputParameters["UserId"] = 0;
        e.InputParameters["Time"] = 0;
        if (UcPermission1.IsAdmin)
        {
            e.InputParameters["Status"] = "-1,3,4";
        }
        else if (UcPermission1.IsHRAdmin)
        {
            e.InputParameters["Status"] = "-1,3,4";
        }
        else if (UcPermission1.IsLeaveManagerApproved)
        {
            e.InputParameters["Status"] = "-1,1";
        }
        
        e.InputParameters["RootId"] = -1;
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