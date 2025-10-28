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
using HRMUtil;
using HRMUtil.KeyNames.H0;

public partial class Contracts_ExpirableDept : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Title1.Text = "THEO DÕI HỢP ĐỒNG ĐẾN HẠN";            
            ContractFilter1.BindContractFilter(1);
            lbTitleRemindExpiredContracts.Text = "Các Hợp Đồng Đến Hạn Trước 3 Tháng";
            lbTitleChangedContracts.Text = "Các Hợp Đồng Chuyển Đổi Trong Tháng " + ContractFilter1.Month + "/" + ContractFilter1.Year;
            if (ucPermission1.UserId == 152)
            {
                ContractFilter1.DDLDepartment.SelectedValue = "7";
            }
            else
            {
                ContractFilter1.DDLDepartment.SelectedValue = ucPermission1.RootId.ToString();
            }

            if (ucPermission1.IsAdmin || ucPermission1.IsHRAdmin || ucPermission1.IsHRManager)
            {
                ContractFilter1.DDLDepartment.Enabled = true;
                ContractFilter1.DDLMonth.Enabled = true;
                ContractFilter1.DDLYear.Enabled = true;
            }
            else
            {
                ContractFilter1.DDLDepartment.Enabled = false;
                ContractFilter1.DDLMonth.Enabled = false;
                ContractFilter1.DDLYear.Enabled = false;
            }
            ContractFilter1.LBContractType.Visible = false;
            ContractFilter1.DDLContractType.Visible = false;
            ContractFilter1.LBViewAll.Visible = false;
            ContractFilter1.CHKViewAll.Visible = false;

            
        }
        ContractFilter1.FilterClick += new EventHandler(ContractFilter1_FilterClick);
    }

    void ContractFilter1_FilterClick(object sender, EventArgs e)
    {
        lbTitleRemindExpiredContracts.Text = "Các Hợp Đồng Đến Hạn Trước 3 Tháng";
        lbTitleChangedContracts.Text = "Các Hợp Đồng Chuyển Đổi Trong Tháng " + ContractFilter1.Month + "/" + ContractFilter1.Year;
        grdChangedContracts.DataBind();
        grdRemindExpiredContracts.DataBind();
    }
    private string ExcelPath
    {
        get
        {
            return Server.MapPath(Constants.DATA_EXPORTED_PATH);
        }
    }

    private int CountClick
    {
        get
        {
            if (ViewState["CountClick"] != null)
                return int.Parse(ViewState["CountClick"].ToString());
            else
                return 0;
        }
        set
        {
            ViewState["CountClick"] = value;
        }
    }

    protected void odsRemindExpiredContracts_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["fullName"] = ContractFilter1.FullName;
        e.InputParameters["deptId"] = ContractFilter1.DepartmentId;
        DateTime expireDate = new DateTime(ContractFilter1.Year, ContractFilter1.Month, DateTime.DaysInMonth(ContractFilter1.Year, ContractFilter1.Month));

        e.InputParameters["expireDate"] = expireDate;
        e.InputParameters["typeSort"] = 1;

    }

    protected void grdRemindExpiredContracts_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            EmployeeContractBLL obj = (EmployeeContractBLL)e.Row.DataItem;
            HyperLink lnk = (HyperLink)e.Row.FindControl("lnkFullName");
            lnk.Text = obj.FullName;
            //lnk.NavigateUrl = "~/Contracts/DetailContractEmployee.aspx?Id=" + obj.UserId + "&d=" + ddlDepartment.SelectedValue + "&i=" + grdRemindExpiredContracts.PageIndex + "&t=1";

            Label lbFromDate = (Label)e.Row.FindControl("lbFromDate");
            if (obj.FromDate.Equals(DateTime.MinValue))
            {
                lbFromDate.Text = string.Empty;
            }
            else
            {
                lbFromDate.Text = FormatDate.FormatVNDate(obj.FromDate);
            }

            Label lbToDate = (Label)e.Row.FindControl("lbToDate");
            if (obj.ToDate.Equals(DateTime.MinValue))
            {
                lbToDate.Text = string.Empty;
            }
            else if (obj.ToDate.Equals(HRMBLL.BLLHelper.DefaultValues.GetSQLDateMinValue()))
            {
                lbToDate.Text = "Không xác định";
            }
            else
            {
                lbToDate.Text = FormatDate.FormatVNDate(obj.ToDate);
            }
            DateTime toMonth = new DateTime(obj.ToDate.Year, obj.ToDate.Month, 1);
            DateTime nowMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            if (toMonth.CompareTo(nowMonth) <=0)
            {
                lbToDate.Font.Bold = true;
                lbToDate.ForeColor = System.Drawing.Color.White;
                row.Cells[5].BackColor = System.Drawing.Color.Red;
            }
        }
    }

    protected void odsChangedContracts_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["fullName"] = ContractFilter1.FullName;
        e.InputParameters["deptId"] = ContractFilter1.DepartmentId;
        e.InputParameters["month"] = ContractFilter1.Month;
        e.InputParameters["year"] = ContractFilter1.Year;
        e.InputParameters["typeSort"] = 1;
    }

    protected void grdChangedContracts_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            EmployeeContractBLL obj = (EmployeeContractBLL)e.Row.DataItem;
            HyperLink lnk = (HyperLink)e.Row.FindControl("lnkFullName");
            lnk.Text = obj.FullName;
            // lnk.NavigateUrl = "~/Contracts/DetailContractEmployee.aspx?Id=" + obj.UserId + "&d=" + ddlDepartment.SelectedValue + "&i=" + grdChangedContracts.PageIndex + "&t=1";

            Label lbFromDate = (Label)e.Row.FindControl("lbFromDate");
            if (obj.FromDate.Equals(DateTime.MinValue))
            {
                lbFromDate.Text = string.Empty;
            }
            else
            {
                lbFromDate.Text = FormatDate.FormatVNDate(obj.FromDate);
            }

            Label lbToDate = (Label)e.Row.FindControl("lbToDate");
            if (obj.ToDate.Equals(DateTime.MinValue))
            {
                lbToDate.Text = string.Empty;
            }
            else if (obj.ToDate.Equals(HRMBLL.BLLHelper.DefaultValues.GetSQLDateMinValue()))
            {
                lbToDate.Text = "Không xác định";
            }
            else
            {
                lbToDate.Text = FormatDate.FormatVNDate(obj.ToDate);
            }
            
        }
    }

    protected void odsChangedContract_Selected(object sender, ObjectDataSourceStatusEventArgs e)
    {
        List<EmployeeContractBLL> list = (List<EmployeeContractBLL>)e.ReturnValue;
        if (list != null)
        {
            if (list.Count > 0)
                pnContractChanged.Visible = true;
            else
                pnContractChanged.Visible = false;
        }
        else
        {
            pnContractChanged.Visible = false;
        }
    }

    protected void btnExcelExport_Click(object sender, EventArgs e)
    {
        ExportExcelExpirableContract();
    }
    private void ExportExcelExpirableContract()
    {
        try
        {
            string strMachineName = Request.ServerVariables["SERVER_NAME"];
            string fileName = "DSHopDongNhanVienDenHan";
            int year = ContractFilter1.Year;
            int month = ContractFilter1.Month;
            DateTime expireDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));


            string strDownload = HRMBLL.H0.Helper.EmployeesContractBLLExportData.ExcelByFilterExpirbaleContract("", ContractFilter1.DepartmentId, expireDate, 2, this.ExcelPath);
            if (strDownload != null)
            {
                Response.Clear();
                Response.ContentType = "application/x-download";
                Response.AddHeader("Content-Disposition", "filename=" + fileName + ".xls");
                Response.WriteFile(strDownload);
            }
            else
            {
                Title1.ErrorText = "No data !...";
            }
        }
        catch (Exception ex)
        {
            Title1.ErrorText = ex.Message;
        }
    }

}