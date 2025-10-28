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

using HRMBLL.H4;
using HRMUtil.KeyNames.H4;
using HRMUtil;
using HRMBLL.H1;

public partial class ShareHolder_RepresentativeList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            UcTitle1.Text = "DANH SÁCH NHÂN VIÊN ĐĂNG KÝ MUA CỔ PHẦN";
            //BindDataToDDLDepartment();
            if (Request.QueryString["p"] != null)
            {
                int pageIndex = int.Parse(Request.QueryString["p"].ToString());
                grdEmployeesList.PageIndex = pageIndex;
            }
            //lnkReport.NavigateUrl = "javascript:OpenPopupStockReport('StockReport.aspx','" + 339 + "')";

            MenuItemCollection items = new MenuItemCollection();
            items.Add(new MenuItem("Nhập đại biểu tham dự", "1"));
            ActionMenu1.BindMenu(items);
            //BindGriData();
        }
        ActionMenu1.MenuItemClick += new EventHandler(ActionMenu1_MenuItemClick);
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


            Label lbStock = (Label)e.Row.FindControl("lbStock");
            Label lbStockRatio = (Label)e.Row.FindControl("lbStockRatio");

            Label lbHDQT_Vote = (Label)e.Row.FindControl("lbHDQT_Vote");
            Label lbBKS_Vote = (Label)e.Row.FindControl("lbBKS_Vote");

            Label lbIsOk = (Label)e.Row.FindControl("lbIsOk");

            lnk.Text = rv[RepresentativeKeys.Field_Representative_RepresentativeName].ToString();
            

            try { lbStock.Text = Convert.ToInt32(rv["Stock"]).ToString("#,###0");}
            catch { }

            try { lbStockRatio.Text = Convert.ToDouble(rv["StockRatio"]).ToString(StringFormat.FormatRepresentative); }
            catch { }

            try { lbHDQT_Vote.Text = Convert.ToDouble(rv["HDQT_Vote"]).ToString("#,###0"); }
            catch { }             
            
            try { lbBKS_Vote.Text = Convert.ToDouble(rv["BKS_Vote"]).ToString("#,###0"); }
            catch { }

            int IsOk = Convert.ToInt32(rv["IsOk"]);

            if (IsOk == 0)
            {
                lbIsOk.Text = "Không";
                lbIsOk.Font.Bold = true;
                lbIsOk.ForeColor = System.Drawing.Color.Red;
            }
            else if (IsOk == 1)
            {
                lbIsOk.Text = "Tham dự";
                lbIsOk.Font.Bold = true;
                lbIsOk.ForeColor = System.Drawing.Color.Green;
                lnk.Font.Bold = true;
                //lbConfirm.ForeColor = System.Drawing.Color.White;
                //row.BackColor = System.Drawing.Color.FromArgb(175, 232, 190);
            }
            else if (IsOk == 2)
            {
                lbIsOk.Text = "Ủy quyền";
                lbIsOk.Font.Bold = false;
                lnk.Font.Bold = false;
            }
            //else
            //{
            //    lbConfirm.Text = "Chưa Nộp";
            //    lbConfirm.Font.Bold = true;
            //    lbConfirm.ForeColor = System.Drawing.Color.White;
            //    row.Cells[13].BackColor = System.Drawing.Color.Red;
            //}

        }
        if (row.RowType == DataControlRowType.Footer)
        {

            Label lbTotal = (Label)e.Row.FindControl("lbTotal");
            Label lbTotalStock = (Label)e.Row.FindControl("lbTotalStock");

            Label lbSum_StockRatio = (Label)e.Row.FindControl("lbSum_StockRatio");
            Label lbSumHDQT_Vote = (Label)e.Row.FindControl("lbSumHDQT_Vote");
            Label lbSumBKS_Vote = (Label)e.Row.FindControl("lbSumBKS_Vote");

        //    Label lbSum_SeniorStockBought = (Label)e.Row.FindControl("lbSum_SeniorStockBought");
        //    Label lbSum_SeniorStockBoughtMoney = (Label)e.Row.FindControl("lbSum_SeniorStockBoughtMoney");

        //    Label lbSum_UnderTakingStockBought = (Label)e.Row.FindControl("lbSum_UnderTakingStockBought");
        //    Label lbSum_UnderTakingStockBoughtMoney = (Label)e.Row.FindControl("lbSum_UnderTakingStockBoughtMoney");

        //    Label lbSum_TotalStock = (Label)e.Row.FindControl("lbSum_TotalStock");
        //    Label lbSum_TotalStockMoney = (Label)e.Row.FindControl("lbSum_TotalStockMoney");

            DataRow rf = RepresentativeBLL.GetForTotal(int.Parse(txtInvestor.Text.TrimEnd().TrimStart().Trim().Length <= 0 ? "0" : txtInvestor.Text.TrimEnd().TrimStart().Trim()), StringFormat.TrimFullName(txtFullName.Text), int.Parse(ddlConfirmStocks.SelectedValue), -1);
            if (rf != null)
            {
                //lbTotal.Text = "Tổng cộng: " + Convert.ToInt32(rf["Total"]).ToString("#,###0");
                //lbTotalStock.Text = Convert.ToInt32(rf["SumStock"]).ToString("#,###0");
                //lbSum_StockRatio.Text = Convert.ToDouble(rf["SumStockRatio"]).ToString(StringFormat.FormatRepresentative);

                //lbSumHDQT_Vote.Text = Convert.ToInt32(rf["SumHDQT_Vote"]).ToString("#,###0");
                //lbSumBKS_Vote.Text = Convert.ToInt32(rf["SumBKS_Vote"]).ToString("#,###0");

        //        lbSum_SeniorStockBoughtMoney.Text = "";//0.ToString("#,###0");

        //        lbSum_UnderTakingStockBought.Text = Convert.ToInt32(rf["SumUnderTakingStockBought"]).ToString("#,###0");
        //        lbSum_UnderTakingStockBoughtMoney.Text = "";// 0.ToString("#,###0");
        //        lbSum_TotalStock.Text = "";//0.ToString("#,###0");
        //        lbSum_TotalStockMoney.Text = Convert.ToDecimal(rf["SumTotalMoneyBought"]).ToString("#,###0");
            }
        //    //if (dt.Rows.Count == 1)
        //    //{
        //    //    double Sum_BonusValue = double.Parse(dt.Rows[0]["Sum_BonusValue"].ToString());
        //    //    lbSum_BonusValue.Text = Sum_BonusValue.ToString(StringFormat.FormatCurrency);
        //    //}
        }
    }
    protected void grdEmployeesList_Sorting(object sender, GridViewSortEventArgs e)
    {
        CountClick = CountClick + 1;

        if (CountClick % 2 == 0)
            e.SortExpression = e.SortExpression + " DESC";
        else
            e.SortExpression = e.SortExpression + " ASC";
    }

   

    protected void imgSearch_Click(object sender, EventArgs e)
    {
        try
        {
            //BindGriData();
            grdEmployeesList.DataBind();
        }
        catch (Exception ex)
        {
            UcTitle1.ErrorText = ex.Message;
        }
    }



    protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
       

        e.InputParameters["InvestorNo"] = int.Parse(txtInvestor.Text.TrimEnd().TrimStart().Trim().Length <= 0 ? "0" : txtInvestor.Text.TrimEnd().TrimStart().Trim());
        e.InputParameters["FullName"] = StringFormat.TrimFullName(txtFullName.Text); 
        e.InputParameters["IsOk"] = int.Parse(ddlConfirmStocks.SelectedValue);
        e.InputParameters["KTTCDB"] = -1;
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