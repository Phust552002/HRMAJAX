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
using System.Text;

using HRMBLL.H0;
using HRMUtil.KeyNames.H0;
using HRMUtil;
using HRMBLL.H1;

public partial class ShareHolder_RepresentativeAdd : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{

        //    UcTitle1.Text = "DANH SÁCH NHÂN VIÊN ĐĂNG KÝ MUA CỔ PHẦN";
        //    //BindDataToDDLDepartment();
        //    if (Request.QueryString["p"] != null)
        //    {
        //        int pageIndex = int.Parse(Request.QueryString["p"].ToString());
        //        grdEmployeesList.PageIndex = pageIndex;
        //    }
        //    lnkReport.NavigateUrl = "javascript:OpenPopupStockReport('StockReport.aspx','" + 339 + "')";

        //    MenuItemCollection items = new MenuItemCollection();
        //    items.Add(new MenuItem("Nhập đại biểu tham dự", "1"));
        //    ActionMenu1.BindMenu(items);
        //    //BindGriData();
        //}
        //ActionMenu1.MenuItemClick += new EventHandler(ActionMenu1_MenuItemClick);
    }

    void ActionMenu1_MenuItemClick(object sender, EventArgs e)
    {
        MenuItem item = ((MenuEventArgs)e).Item;
        if (item.Value == "1")
        {
            //ExportExcel();
        }
        else
        {

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
    private int StockDayOfPayment
    {
        get
        {
            if (ViewState["StockDayOfPayment"] != null)
                return int.Parse(ViewState["StockDayOfPayment"].ToString());
            else
                return 0;
        }
        set
        {
            ViewState["StockDayOfPayment"] = value;
        }
    }
    private int StockMonthOfPayment
    {
        get
        {
            if (ViewState["StockMonthOfPayment"] != null)
                return int.Parse(ViewState["StockMonthOfPayment"].ToString());
            else
                return 0;
        }
        set
        {
            ViewState["StockMonthOfPayment"] = value;
        }
    }
    private int StockYearOfPayment
    {
        get
        {
            if (ViewState["StockYearOfPayment"] != null)
                return int.Parse(ViewState["StockYearOfPayment"].ToString());
            else
                return 0;
        }
        set
        {
            ViewState["StockYearOfPayment"] = value;
        }
    }
    private int ConfirmStocks
    {
        get
        {
            if (ViewState["ConfirmStocks"] != null)
                return int.Parse(ViewState["ConfirmStocks"].ToString());
            else
                return 0;
        }
        set
        {
            ViewState["ConfirmStocks"] = value;
        }
    }
    private int RootId
    {
        get
        {
            if (ViewState["RootId"] != null)
                return int.Parse(ViewState["RootId"].ToString());
            else
                return 0;
        }
        set
        {
            ViewState["RootId"] = value;
        }
    }

    private string DepartmentIds
    {
        get
        {
            if (ViewState["DepartmentIds"] != null)
                return ViewState["DepartmentIds"].ToString();
            else
                return "";
        }
        set
        {
            ViewState["DepartmentIds"] = value;
        }
    }

    private string ExcelPath
    {
        get
        {
            return Server.MapPath(Constants.DATA_EXPORTED_PATH);
        }
    }



    protected void grdEmployeesList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {

            DataRowView rv = (DataRowView)e.Row.DataItem;
            HyperLink lnk = (HyperLink)e.Row.FindControl("lnkFullName");


            //Label lbSeniorStockRegistered = (Label)e.Row.FindControl("lbSeniorStockRegistered");
            //Label lbUnderTakingStockRegistered = (Label)e.Row.FindControl("lbUnderTakingStockRegistered");

            //Label lbUndertakingYear = (Label)e.Row.FindControl("lbUndertakingYear");

            //Label lbSeniorStockBought = (Label)e.Row.FindControl("lbSeniorStockBought");
            //Label lbSeniorStockBoughtMoney = (Label)e.Row.FindControl("lbSeniorStockBoughtMoney");

            //Label lbUnderTakingStockBought = (Label)e.Row.FindControl("lbUnderTakingStockBought");
            //Label lbUnderTakingStockBoughtMoney = (Label)e.Row.FindControl("lbUnderTakingStockBoughtMoney");

            //Label lbTotalStock = (Label)e.Row.FindControl("lbTotalStock");
            //Label lbTotalStockMoney = (Label)e.Row.FindControl("lbTotalStockMoney");

            //int UserId = Convert.ToInt32(rv["UserId"]);

            //lnk.Text = rv[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME].ToString();
            //if (UcPermission1.IsAdmin || UcPermission1.IsHRAdmin || UcPermission1.IsHRManager || UcPermission1.IsHRMember)
            //{
            //    lnk.NavigateUrl = "~/Employee/StockDetail.aspx?Id=" + UserId + "&d=" + ddlDepartment.SelectedValue + "&i=" + grdEmployeesList.PageIndex;
            //}

            //int SeniorStockRegistered = Convert.ToInt32(rv["SeniorStockRegistered"]);
            //lbSeniorStockRegistered.Text = SeniorStockRegistered.ToString("#,###0");
            //int UnderTakingStockRegistered = Convert.ToInt32(rv["UnderTakingStockRegistered"]);
            //lbUnderTakingStockRegistered.Text = UnderTakingStockRegistered.ToString("#,###0");

            //int UndertakingYear = Convert.ToInt32(rv["UndertakingYear"]);
            //lbUndertakingYear.Text = UndertakingYear.ToString("#,###0");

            //int SeniorStockBought = Convert.ToInt32(rv["SeniorStockBought"]);
            //lbSeniorStockBought.Text = SeniorStockBought.ToString("#,###0");
            //double SeniorStockBoughtMoney = SeniorStockBought * 8400;
            //lbSeniorStockBoughtMoney.Text = SeniorStockBoughtMoney.ToString("#,###0");

            //int UnderTakingStockBought = Convert.ToInt32(rv["UnderTakingStockBought"]);
            //lbUnderTakingStockBought.Text = UnderTakingStockBought.ToString("#,###0");
            //double UnderTakingStockBoughtMoney = UnderTakingStockBought * 14000;
            //lbUnderTakingStockBoughtMoney.Text = UnderTakingStockBoughtMoney.ToString("#,###0");

            //int TotalStock = SeniorStockBought + UnderTakingStockBought;
            //lbTotalStock.Text = TotalStock.ToString("#,###0");
            //decimal TotalStockMoney = 0;//;SeniorStockBoughtMoney + UnderTakingStockBoughtMoney;
            //try
            //{
            //    TotalStockMoney = Convert.ToDecimal(rv["TotalMoneyBought"]);
            //}
            //catch { TotalStockMoney = 0; }
            //lbTotalStockMoney.Text = TotalStockMoney.ToString("#,###0");

            //Label lbConfirm = (Label)e.Row.FindControl("lbConfirm");
            //Label lbStockDateOfPayment = (Label)e.Row.FindControl("lbStockDateOfPayment");
            //int confirm = 0;
            //try
            //{
            //    confirm = Convert.ToInt32(rv["ConfirmStocks"]);
            //}
            //catch { TotalStockMoney = 0; }
            //if (confirm == 1)
            //{
            //    lbConfirm.Text = "Nộp TM";
            //    lbStockDateOfPayment.Text = FormatDate.FormatVNDate(Convert.ToDateTime(rv["StockDateOfPayment"]));
            //}
            //else if (confirm == 2)
            //{
            //    lbConfirm.Text = "Nộp CK";
            //    lbStockDateOfPayment.Text = FormatDate.FormatVNDate(Convert.ToDateTime(rv["StockDateOfPayment"]));
            //}
            //else
            //{
            //    lbConfirm.Text = "Chưa Nộp";
            //    lbConfirm.Font.Bold = true;
            //    lbConfirm.ForeColor = System.Drawing.Color.White;
            //    row.Cells[13].BackColor = System.Drawing.Color.Red;
            //}

        }
        //if (row.RowType == DataControlRowType.Footer)
        //{

        //    Label lbTotal = (Label)e.Row.FindControl("lbTotal");

        //    Label lbSum_SeniorStockRegistered = (Label)e.Row.FindControl("lbSum_SeniorStockRegistered");
        //    Label lbSum_UnderTakingStockRegistered = (Label)e.Row.FindControl("lbSum_UnderTakingStockRegistered");

        //    Label lbSum_UndertakingYear = (Label)e.Row.FindControl("lbSum_UndertakingYear");

        //    Label lbSum_SeniorStockBought = (Label)e.Row.FindControl("lbSum_SeniorStockBought");
        //    Label lbSum_SeniorStockBoughtMoney = (Label)e.Row.FindControl("lbSum_SeniorStockBoughtMoney");

        //    Label lbSum_UnderTakingStockBought = (Label)e.Row.FindControl("lbSum_UnderTakingStockBought");
        //    Label lbSum_UnderTakingStockBoughtMoney = (Label)e.Row.FindControl("lbSum_UnderTakingStockBoughtMoney");

        //    Label lbSum_TotalStock = (Label)e.Row.FindControl("lbSum_TotalStock");
        //    Label lbSum_TotalStockMoney = (Label)e.Row.FindControl("lbSum_TotalStockMoney");

        //    DataRow rf = EmployeesBLL.GetByStocksForTotal(DepartmentIds, RootId, StringFormat.TrimFullName(txtFullName.Text), 1, StockDayOfPayment, StockMonthOfPayment, StockYearOfPayment, ConfirmStocks);
        //    if (rf != null)
        //    {
        //        lbTotal.Text = "Tổng cộng:" + Convert.ToInt32(rf["Total"]).ToString("#,###0");
        //        lbSum_SeniorStockRegistered.Text = Convert.ToInt32(rf["SumSeniorStockRegistered"]).ToString("#,###0");
        //        lbSum_UndertakingYear.Text = Convert.ToInt32(rf["SumUndertakingYear"]).ToString("#,###0");
        //        lbSum_UnderTakingStockRegistered.Text = Convert.ToInt32(rf["SumUnderTakingStockRegistered"]).ToString("#,###0");

        //        lbSum_SeniorStockBought.Text = Convert.ToInt32(rf["SumSeniorStockBought"]).ToString("#,###0");
        //        lbSum_SeniorStockBoughtMoney.Text = "";//0.ToString("#,###0");

        //        lbSum_UnderTakingStockBought.Text = Convert.ToInt32(rf["SumUnderTakingStockBought"]).ToString("#,###0");
        //        lbSum_UnderTakingStockBoughtMoney.Text = "";// 0.ToString("#,###0");
        //        lbSum_TotalStock.Text = "";//0.ToString("#,###0");
        //        lbSum_TotalStockMoney.Text = Convert.ToDecimal(rf["SumTotalMoneyBought"]).ToString("#,###0");
        //    }
        //    //if (dt.Rows.Count == 1)
        //    //{
        //    //    double Sum_BonusValue = double.Parse(dt.Rows[0]["Sum_BonusValue"].ToString());
        //    //    lbSum_BonusValue.Text = Sum_BonusValue.ToString(StringFormat.FormatCurrency);
        //    //}
        //}
    }
    protected void grdEmployeesList_Sorting(object sender, GridViewSortEventArgs e)
    {
        CountClick = CountClick + 1;

        if (CountClick % 2 == 0)
            e.SortExpression = e.SortExpression + " DESC";
        else
            e.SortExpression = e.SortExpression + " ASC";
    }

    //private void BindDataToDDLDepartment()
    //{

    //    string deptIds = WorkDayPrivilegeBLL.GetDepartmentIDsByUserId(UcPermission1.UserId, Constants.WorkdayPrivilege_CV);

    //    List<DepartmentsBLL> list = DepartmentsBLL.GetByIds(deptIds);
    //    if (UcPermission1.IsAdmin || UcPermission1.IsHRAdmin || UcPermission1.IsHRMember || UcPermission1.IsTrainingManager || UcPermission1.UserId == 341)
    //    {
    //        list = DepartmentsBLL.GetAllRoots();
    //    }
    //    ddlDepartment.DataSource = list;
    //    ddlDepartment.DataTextField = "DepartmentName";
    //    ddlDepartment.DataValueField = DepartmentKeys.FIELD_DEPARTMENT_ID;
    //    ddlDepartment.DataBind();

    //}

    //private void BindGriData()
    //{
    //    string departmentIds = string.Empty;
    //    int departmentId = 0;
    //    if (ddlDepartment.SelectedValue != "")
    //    {
    //        departmentId = int.Parse(ddlDepartment.SelectedValue);
    //        if (UcPermission1.IsAdmin || UcPermission1.IsHRAdmin || UcPermission1.IsHRManager || UcPermission1.IsHRMember || UcPermission1.IsTrainingManager)
    //        {
    //            departmentIds = string.Empty;
    //        }
    //        else
    //        {
    //            DepartmentsBLL obj = new DepartmentsBLL();
    //            obj.ChildNodeIds = departmentId.ToString() + ",";
    //            obj.GetAllChildId(departmentId);
    //            departmentIds = obj.ChildNodeIds;
    //            departmentId = 0;
    //        }
    //    }
    //    else
    //    {
    //        departmentIds = "-1";
    //    }

    //    DataTable dt = EmployeesBLL.GetByStocks(departmentIds, departmentId, StringFormat.TrimFullName(txtFullName.Text), 1);
    //    grdEmployeesList.DataSource = dt;
    //    grdEmployeesList.DataBind();
    //}

    //protected void imgSearch_Click(object sender, ImageClickEventArgs e)
    //{
    //    try
    //    {
    //        //BindGriData();
    //        grdEmployeesList.DataBind();
    //    }
    //    catch (Exception ex)
    //    {
    //        UcTitle1.ErrorText = ex.Message;
    //    }
    //}



    protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {

        //if (ddlDepartment.SelectedValue != "")
        //{
        //    RootId = int.Parse(ddlDepartment.SelectedValue);
        //    if (UcPermission1.IsAdmin || UcPermission1.IsHRAdmin || UcPermission1.IsHRManager || UcPermission1.IsHRMember || UcPermission1.IsTrainingManager)
        //    {
        //        DepartmentIds = string.Empty;
        //    }
        //    else
        //    {
        //        DepartmentsBLL obj = new DepartmentsBLL();
        //        obj.ChildNodeIds = RootId.ToString() + ",";
        //        obj.GetAllChildId(RootId);
        //        DepartmentIds = obj.ChildNodeIds;
        //        RootId = 0;
        //    }
        //}
        //else
        //{
        //    DepartmentIds = "-1";
        //}

        //StockDayOfPayment = int.Parse(txtDay.Text.Trim().Length <= 0 ? "0" : txtDay.Text.Trim());
        //StockMonthOfPayment = int.Parse(txtMonth.Text.Trim().Length <= 0 ? "0" : txtMonth.Text.Trim());
        //StockYearOfPayment = int.Parse(txtYear.Text.Trim().Length <= 0 ? "0" : txtYear.Text.Trim());
        //ConfirmStocks = int.Parse(ddlConfirmStocks.SelectedValue);

        //e.InputParameters["deptIds"] = DepartmentIds;
        //e.InputParameters["rootId"] = RootId;
        //e.InputParameters["fullName"] = StringFormat.TrimFullName(txtFullName.Text);

        //e.InputParameters["StockDayOfPayment"] = StockDayOfPayment;
        //e.InputParameters["StockMonthOfPayment"] = StockMonthOfPayment;
        //e.InputParameters["StockYearOfPayment"] = StockYearOfPayment;
        //e.InputParameters["ConfirmStocks"] = ConfirmStocks;
    }

    //private void ExportExcel()
    //{
    //    try
    //    {
    //        string strMachineName = Request.ServerVariables["SERVER_NAME"];
    //        string fileName = "DSNhanVien";

    //        string strDownload = HRMBLL.H0.Helper.EmployeesBLLExportData.ExcelByFilter("", int.Parse(ddlDepartment.SelectedValue), string.Empty, this.ExcelPath, 2);
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
}