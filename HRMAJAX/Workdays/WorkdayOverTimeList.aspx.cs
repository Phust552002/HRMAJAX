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
using HRMBLL.H1;
using HRMBLL.H1.Helper;
using HRMUtil.KeyNames.H0;
using HRMUtil;

public partial class Workdays_WorkdayOverTimeList : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "THEO DÕI CHẤM CÔNG LÀM THÊM GIỜ";
            AddDataToCboYear();
            AddDataToDDLDepartment();
            if (Request.QueryString["d"] != null)
            {
                string departmentId = Request.QueryString["d"].ToString();
                ddlDepartments.SelectedValue = departmentId;
            }
            if (Request.QueryString["p"] != null)
            {
                int pageIndex = int.Parse(Request.QueryString["p"].ToString());
                grdWorkdayOverTimeList.PageIndex = pageIndex;
            }
            MenuItemCollection items = new MenuItemCollection();
            items.Add(new MenuItem("Export excel", "1"));
            ActionMenu1.BindMenu(items);

        }
        ActionMenu1.MenuItemClick += new EventHandler(ActionMenu1_MenuItemClick);
    }

    void ActionMenu1_MenuItemClick(object sender, EventArgs e)
    {
        MenuItem item = ((MenuEventArgs)e).Item;
        int valueItem = int.Parse(item.Value);
        if (valueItem == 1)
        {
            ExportExcel();
        }
    }

    public string ExcelPath
    {
        get
        {
            return Server.MapPath(Constants.DATA_EXPORTED_PATH);
        }
    }

    private void AddDataToCboYear()
    {

        for (int i = 2000; i <= DateTime.Now.Year; i++)
        {
            ListItem item = new ListItem(i.ToString(), i.ToString());
            ddlYears.Items.Add(item);
        }

        if (DateTime.Now.Day >= 20)
        {
            ddlMonths.SelectedValue = DateTime.Now.Month.ToString();
            ddlYears.SelectedValue = DateTime.Now.Year.ToString();
        }
        else
        {
            ddlMonths.SelectedValue = DateTime.Now.AddMonths(-1).Month.ToString();
            ddlYears.SelectedValue = DateTime.Now.AddMonths(-1).Year.ToString();
        }
    }

    private void AddDataToDDLDepartment()
    {
        string deptIds = WorkDayPrivilegeBLL.GetDepartmentIDsByUserId(UcPermission1.UserId, Constants.WorkdayPrivilege_TimeKeeping);

        List<DepartmentsBLL> list = DepartmentsBLL.GetByIds(deptIds);
        if (UcPermission1.IsAdmin || UcPermission1.IsHRAdmin)
        {
            list = DepartmentsBLL.GetAllDepartments();
        }
        ddlDepartments.DataSource = list;
        ddlDepartments.DataTextField = "DepartmentNameLevel";
        ddlDepartments.DataValueField = DepartmentKeys.FIELD_DEPARTMENT_ID;
        ddlDepartments.DataBind();
    }

    protected void imgSearch_Click(object sender, ImageClickEventArgs e)
    {
        grdWorkdayOverTimeList.DataBind();
    }

    protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        string departmentIds = string.Empty;
        int deptId = ddlDepartments.SelectedValue == "" ? 0 : int.Parse(ddlDepartments.SelectedValue);
        DepartmentsBLL obj = new DepartmentsBLL();
        obj.ChildNodeIds = deptId.ToString() + ",";
        obj.GetAllChildId(deptId);
        departmentIds = obj.ChildNodeIds;
        int minMark = 0, maxMark = 0;

        e.InputParameters["fullName"] = StringFormat.TrimFullName(txtFullName.Text);
        e.InputParameters["deptIds"] = departmentIds;
        e.InputParameters["minMark"] = minMark;
        e.InputParameters["maxMark"] = maxMark;
        e.InputParameters["month"] = ddlMonths.SelectedValue;
        e.InputParameters["year"] = ddlYears.SelectedValue;
    }

    protected void grdWorkdayOverTimeList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            WorkdayEmployeesBLL obj = (WorkdayEmployeesBLL)row.DataItem;

            HyperLink lnkFullName = (HyperLink)row.FindControl("lnkFullName");
            lnkFullName.Text = obj.FullName;
            lnkFullName.NavigateUrl = "~/Workdays/WorkdayOverTimeDetail.aspx?uId=" + obj.UserId + "&m=" + obj.WorkdayDate.Month + "&y=" + obj.WorkdayDate.Year + "&d=" + int.Parse(ddlDepartments.SelectedValue) + "&p=" + grdWorkdayOverTimeList.PageIndex;

            Label lbWorkdayDate = (Label)row.FindControl("lbWorkdayDate");
            lbWorkdayDate.Text = StringFormat.FormatMonthYearVN(obj.WorkdayDate);

            //Label lbMark = (Label)row.FindControl("lbMark");
            //lbMark.Text = obj.Mark <= 0 ? string.Empty : obj.Mark.ToString();

            //Label lbHTCV = (Label)row.FindControl("lbHTCV");
            //lbHTCV.Text = obj.HTCV;

            //Label lbRemark = (Label)row.FindControl("lbRemark");
            //string allRemark = HTCVEmployeeBLL.GetForAllRemarkByUserIdDate(obj.UserId, obj.WorkdayDate.Month, obj.WorkdayDate.Year);

            //allRemark = obj.Remark + ";" + allRemark;
            //if (allRemark.Trim().Length > 0)
            //{
            //    // string[] sTemp = allRemark.Split(';');
            //    allRemark = StringFormat.ReplaceWordWrap(allRemark);
            //    lbRemark.Text = allRemark;
            //    //if (sTemp.Length == 2)
            //    //{
            //    //    lbRemark.Text = sTemp[0];
            //    //}
            //    //else
            //    //{
            //    //    lbRemark.Text = sTemp[0]+ " ...";

            //    //}

            //    lbRemark.Attributes.Add("onmouseover", "Tip('" + StringFormat.ReplaceWordWrap(allRemark) + "');");
            //}

            //Label lbWriteUserIds = (Label)row.FindControl("lbWriteUserIds");
            //lbWriteUserIds.Text = EmployeesBLL.GetDisplayIds(obj.WriteUserIds);
            //lbWriteUserIds.Attributes.Add("onmouseover", "Tip('" + "Quyền Chấm Công:<br/><br/>" + EmployeesBLL.GetDisplayFullNames(obj.WriteUserIds) + "');");

        }
    }

    protected void ObjectDataSource1_Selected(object sender, ObjectDataSourceStatusEventArgs e)
    {
        List<WorkdayEmployeesBLL> list = (List<WorkdayEmployeesBLL>)e.ReturnValue;
        if (list.Count == 0 && txtFullName.Text.Length == 0)
        {
            UcTitle1.ErrorText = "Bảng chấm công phải được tạo trước khi chấm điểm HTCV";
        }
        else
        {
            UcTitle1.ErrorText = "";
            UcTitle1.CountRecord = "Số nhân viên được chấm công: " + list.Count;
        }


    }

    private void ExportExcel()
    {
        try
        {
            string strMachineName = Request.ServerVariables["SERVER_NAME"];
            int month = int.Parse(ddlMonths.SelectedValue);
            int year = int.Parse(ddlYears.SelectedValue);
            string fileName = "BangDiemHTCV_" + month + "_" + year;
            string departmentIds = string.Empty;
            int deptId = ddlDepartments.SelectedValue == "" ? 0 : int.Parse(ddlDepartments.SelectedValue);
            DepartmentsBLL obj = new DepartmentsBLL();
            obj.ChildNodeIds = deptId.ToString() + ",";
            obj.GetAllChildId(deptId);
            departmentIds = obj.ChildNodeIds;
            int minMark = 0, maxMark = 0;

            //if (!ddlRankHTCV.SelectedValue.Equals("0"))
            //    DefaultValues.MarkHTCV(ddlRankHTCV.SelectedValue, ref minMark, ref maxMark);

            string strDownload = HRMBLL.H1.Helper.WorkdayEmployeesBLLExportData.ExcelByFilterForHTCV(txtFullName.Text, departmentIds, minMark, maxMark, month, year, int.Parse(ddlDepartments.SelectedValue), ExcelPath);

            if (strDownload != null)
            {
                Response.Clear();
                Response.ContentType = "application/x-download";
                Response.AddHeader("Content-Disposition", "filename=" + fileName + ".xls");
                Response.WriteFile(strDownload);
            }
            else
            {
                UcTitle1.ErrorText = "No data !...";
            }
        }
        catch (Exception ex)
        {
            UcTitle1.ErrorText = ex.Message;
        }
    }

   
}