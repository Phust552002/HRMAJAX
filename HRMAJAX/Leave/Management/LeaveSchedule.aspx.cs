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

public partial class Leave_LeaveSchedule : System.Web.UI.Page
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
                UcTitle1.Text = "DANH SÁCH ĐĂNG KÝ NGHỈ PHÉP THEO KẾ HOẠCH";
                InitData();
                MenuItemCollection items = new MenuItemCollection();
                items.Add(new MenuItem("Xuất ra Excel", "2"));
                //ActionMenu1.BindMenu(items);
            }
        }
        //ActionMenu1.MenuItemClick += new EventHandler(ActionMenu1_MenuItemClick);
    }
    //void ActionMenu1_MenuItemClick(object sender, EventArgs e)
    //{
    //    MenuItem item = ((MenuEventArgs)e).Item;
    //    int index = int.Parse(item.Value);
    //    if (index == 2)
    //    {
    //        ExportExcel();
    //    }
    //}
    //private void ExportExcel()
    //{
    //    try
    //    {
    //        string strMachineName = Request.ServerVariables["SERVER_NAME"];
    //        string fileName = "BangTheoDoiPhep";

    //        string departmentIds = string.Empty;
    //        int departmentId = ddlDepartment1.SelectedValue == null ? 0 : Convert.ToInt32(ddlDepartment1.SelectedValue);

    //        DepartmentsBLL obj = new DepartmentsBLL();
    //        obj.ChildNodeIds = departmentId.ToString() + ",";
    //        obj.GetAllChildId(departmentId);
    //        departmentIds = obj.ChildNodeIds;

    //        string strDownload = HRMBLL.H0.Helper.EmployeeLeaveScheduleBLLExport.ExcelByFilter(departmentIds, 0, string.Empty, this.ExcelPath);
    //        if (strDownload != null)
    //        {
    //            Response.Clear();
    //            Response.ContentType = "application/x-download";
    //            Response.AddHeader("Content-Disposition", "filename=" + fileName + ".xls");
    //            Response.WriteFile(strDownload);
    //        }
    //        else
    //        {
    //            UcTitle1.ErrorText = "No data !...";
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        UcTitle1.ErrorText = ex.Message;
    //    }
    //}
    private void BindDataToDDLDepartment()
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

        ddlDepartment.DataSource = list;
        ddlDepartment.DataTextField = "DepartmentName";
        ddlDepartment.DataValueField = DepartmentKeys.FIELD_DEPARTMENT_ID;
        ddlDepartment.DataBind();

    }
    private string ExcelPath
    {
        get
        {
            return Server.MapPath(Constants.DATA_EXPORTED_PATH);
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            int Max = 0;
            int MaxFCurrent = 0;
            EmployeeLeaveScheduleBLL obj = (EmployeeLeaveScheduleBLL)row.DataItem;

            if (obj.Status == 1)
            {
                Label lblStatus = (Label) row.FindControl("lblStatus");
                lblStatus.Text = "Đã gửi";
                lblStatus.ForeColor = Color.Green;
                lblStatus.Font.Bold = true;

                HyperLink lnk = (HyperLink) row.FindControl("lnkFullName");
                lnk.Text = obj.FullName;
                lnk.NavigateUrl = "~/Leave/Management/LeaveScheduleDetail.aspx?Id=" + obj.UserId + "&p=" + 1 + "&sid=" +
                                  obj.EmployeeLeaveScheduleId;
                lnk.Font.Bold = true;
            }
            else if (obj.Status == 2)
            {
                Label lblStatus = (Label)row.FindControl("lblStatus");
                lblStatus.Text = "Đã duyệt";
                lblStatus.ForeColor = Color.Green;
                lblStatus.Font.Bold = true;

                HyperLink lnk = (HyperLink)row.FindControl("lnkFullName");
                lnk.Text = obj.FullName;
            }
            else
            {
                HyperLink lnk = (HyperLink)row.FindControl("lnkFullName");
                lnk.Text = obj.FullName;
            }

            #region 
            DataRow dt = EmployeeLeaveBLL.GetRealLeaveByUserId(UcPermission1.UserCurrent.UserId, 0, DateTime.Now.Year);
            if (dt != null)
            {
                MaxFCurrent = Convert.ToInt32(dt["MaxFCurrent"].ToString());
            }
            Label lblTotal = (Label)row.FindControl("lblTotal");
            if (lblTotal != null)
            {
                Max = (Convert.ToInt32(obj.Seniority) + MaxFCurrent);
                lblTotal.Text = Max.ToString();
            }
            int Days;
            Label lblDays = (Label)row.FindControl("lblDays");
            if (lblDays != null)
            {
                Days = Convert.ToInt32(GetLeaveDaysV1(obj.FromDate, obj.ToDate));
                lblDays.Text = Days.ToString();
            }
            #endregion
            
            Label DenyReason = (Label)row.FindControl("Label3");
            if (obj.Status == 0)
            {
                DenyReason.Visible = false;
            }
            else if (obj.Status == 1)
            {
                DenyReason.Visible = false;
            }
            else if (obj.Status == 2)
            {
                DenyReason.Visible = false;
            }
            else if (obj.Status == 3)
            {
                DenyReason.Visible = false;
            }
            else if (obj.Status == 4)
            {
                row.BackColor = System.Drawing.Color.FromArgb(0x96, 0xD2, 0xA4);
                row.ForeColor = System.Drawing.Color.White;
                row.Font.Bold = true;
                DenyReason.Text = "Đã duyệt";
            }
            else
            {
                row.BackColor = System.Drawing.Color.FromArgb(0xD4, 0x94, 0x94);
                row.ForeColor = System.Drawing.Color.White;
                row.Font.Bold = true;
                DenyReason.Visible = true;
                DenyReason.Text = obj.DenyReason;
            }
        }
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
    protected void imgSearch_Click(object sender, EventArgs e)
    {
        GridView1.DataBind();
    }
    protected void InitData()
    {
        BindDataToDDLDepartment();
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
        string departmentIds = string.Empty;
        int departmentId = ddlDepartment.SelectedValue == null || ddlDepartment.SelectedValue.ToString() == string.Empty ? 0 : Convert.ToInt32(ddlDepartment.SelectedValue);

        DepartmentsBLL obj = new DepartmentsBLL();
        obj.ChildNodeIds = departmentId.ToString() + ",";
        obj.GetAllChildId(departmentId);
        departmentIds = obj.ChildNodeIds;

        e.InputParameters["fullName"] = txtFullName.Text;
        e.InputParameters["departmentIds"] = "";
        e.InputParameters["UserId"] = 0;
        e.InputParameters["Time"] = 0;
        //e.InputParameters["Status"] = "";
        //e.InputParameters["RootId"] = -1;
        e.InputParameters["LevelPosition"] = -1;
        e.InputParameters["RangeFrom"] = HRMUtil.FormatDate.GetSQLDateMinValue;
        e.InputParameters["RangeTo"] = HRMUtil.FormatDate.GetSQLDateMinValue;

        if (UcPermission1.IsAdmin || UcPermission1.IsHRAdmin)
        {
            if (UcPermission1.IsAdmin)
            {
                //e.InputParameters["fullName"] = txtFullName.Text;
                //e.InputParameters["departmentIds"] = "";
                //e.InputParameters["UserId"] = 0;
                //e.InputParameters["Time"] = 0;
                e.InputParameters["Status"] = "";
                e.InputParameters["RootId"] = -1;
                //e.InputParameters["LevelPosition"] = -1;
                //e.InputParameters["RangeFrom"] = HRMUtil.FormatDate.GetSQLDateMinValue;
                //e.InputParameters["RangeTo"] = HRMUtil.FormatDate.GetSQLDateMinValue;
            }
            else
            {
                //e.InputParameters["fullName"] = txtFullName.Text;
                //e.InputParameters["departmentIds"] = "";
                //e.InputParameters["UserId"] = 0;
                //e.InputParameters["Time"] = 0;
                e.InputParameters["Status"] = "3";
                e.InputParameters["RootId"] = -1;
                //e.InputParameters["LevelPosition"] = -1;
                //e.InputParameters["RangeFrom"] = HRMUtil.FormatDate.GetSQLDateMinValue;
                //e.InputParameters["RangeTo"] = HRMUtil.FormatDate.GetSQLDateMinValue;
            }
            
        }
        else if (UcPermission1.IsLeaveManagerApproved)
        {
            List<EmployeesBLL> list = EmployeesBLL.GetByIds(UcPermission1.UserCurrent.UserId.ToString());

            //e.InputParameters["fullName"] = txtFullName.Text;
            //e.InputParameters["departmentIds"] = departmentIds;
            //e.InputParameters["UserId"] = 0;
            //e.InputParameters["Time"] = 0;
            e.InputParameters["Status"] = "1";
            e.InputParameters["RootId"] = list[0].RootId;
            //e.InputParameters["LevelPosition"] = -1;
            //e.InputParameters["RangeFrom"] = HRMUtil.FormatDate.GetSQLDateMinValue;
            //e.InputParameters["RangeTo"] = HRMUtil.FormatDate.GetSQLDateMinValue;
        }
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