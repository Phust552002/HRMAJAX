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

using HRMUtil;
using HRMUtil.KeyNames.H4;
using HRMBLL.H4;

public partial class ShareHolder_BQCTTGDList : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "BIỂU QUYẾT THÔNG QUA VIỆC CHỦ TỊCH KIÊM TỔNG GIÁM ĐỐC";
            MenuItemCollection items = new MenuItemCollection();
            items.Add(new MenuItem("Kiểm phiếu", "1"));
            ActionMenu1.BindMenu(items);
            //if (Request.QueryString["s"] != null)
            //{
            //    ddlSessions.SelectedValue = Request.QueryString["s"].ToString();
            //}
        }
        ActionMenu1.MenuItemClick += new EventHandler(ActionMenu1_MenuItemClick);
    }

    private string ExcelPath
    {
        get
        {
            return Server.MapPath(Constants.DATA_EXPORTED_PATH);
        }
    }

    void ActionMenu1_MenuItemClick(object sender, EventArgs e)
    {
        MenuItem item = ((MenuEventArgs)e).Item;
        if (item.Value == "1")
        {
            Response.Redirect("~/ShareHolder/BQCTTGDAdd.aspx");
        }

    }


    private int PageIndexSelected
    {
        set { ViewState["PageIndexSelected"] = value; }
        get
        {
            if (ViewState["PageIndexSelected"] != null)
            {
                return int.Parse(ViewState["PageIndexSelected"].ToString());
            }
            else
            {
                return 0;
            }
        }
    }




    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {

            DataRowView rv = (DataRowView)e.Row.DataItem;

            Label lbInvestorNo = (Label)e.Row.FindControl("lbInvestorNo");
            Label lbFullName = (Label)e.Row.FindControl("lbFullName");

            Label lbStock = (Label)e.Row.FindControl("lbStock");
            Label lbStockRatio = (Label)e.Row.FindControl("lbStockRatio");

            Label lbBKS_Vote = (Label)e.Row.FindControl("lbBKS_Vote");
            Label lbTotal = (Label)e.Row.FindControl("lbTotal");
            Label lbIsOk = (Label)e.Row.FindControl("lbIsOk");

            try { lbInvestorNo.Text = Convert.ToInt32(rv[RepresentativeKeys.Field_Representative_InvestorNo]).ToString("SAG000000000#"); }
            catch { }
            try { lbFullName.Text = rv[RepresentativeKeys.Field_Representative_RepresentativeName].ToString(); }
            catch { }

            try { lbStock.Text = Convert.ToInt32(rv["Stock"]).ToString("#,###0"); }
            catch { }

            try { lbStockRatio.Text = Convert.ToDouble(rv["StockRatio"]).ToString(StringFormat.FormatRepresentative); }
            catch { }


            try { lbBKS_Vote.Text = Convert.ToDouble(rv["BKS_Vote"]).ToString("#,###0"); }
            catch { }

            int IsOk = Convert.ToInt32(rv["IsOk"]);

            if (IsOk == 0)
            {
                lbIsOk.Text = "Không";
                lbIsOk.Font.Bold = true;
                lbIsOk.ForeColor = System.Drawing.Color.White;

            }
            else if (IsOk == 1)
            {
                lbIsOk.Text = "Tham dự";
                lbIsOk.Font.Bold = true;
                lbFullName.Font.Bold = true;
                //lbConfirm.ForeColor = System.Drawing.Color.White;
                //row.BackColor = System.Drawing.Color.FromArgb(175, 232, 190);
            }
            else if (IsOk == 2)
            {
                lbIsOk.Text = "Ủy quyền";
                lbIsOk.Font.Bold = false;
                lbFullName.Font.Bold = false;
            }

            ///////////////////////////////////////////////////////////////////////////////


            int _BQ_CTTGD = rv["BQ_CTTGD"] == DBNull.Value ? -10 : Convert.ToInt32(rv["BQ_CTTGD"]);
            Label lbBQ_CTTGD = (Label)row.FindControl("lbBQ_CTTGD");
            if (_BQ_CTTGD == 0)
            {
                lbBQ_CTTGD.Text = "Không đồng ý";
            }
            else if (_BQ_CTTGD == 1)
            {
                lbBQ_CTTGD.Text = "Đồng ý";
            }
            else if (_BQ_CTTGD == 2)
            {
                lbBQ_CTTGD.Text = "Không ý kiến";
                //lbBKS_IsValid.Font.Bold = true;
                //lbBKS_IsValid.ForeColor = System.Drawing.Color.Red;
            }
            else if (_BQ_CTTGD == -1)
            {
                lbBQ_CTTGD.Text = "Không hợp lệ";
            }
            else
            {
                lbBQ_CTTGD.Text = "";
            }
        }
    }

    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        PageIndexSelected = e.NewPageIndex;
    }


    //private void ExportExcel()
    //{
    //    try
    //    {
    //        string strMachineName = Request.ServerVariables["SERVER_NAME"];
    //        string fileName = "KetQuaVong2";

    //        int result = int.Parse(ddlResultType.SelectedValue);
    //        int sessionId = int.Parse(ddlSessions.SelectedValue);

    //        string strDownload = HRMBLL.H2.Helper.CandidateBLLExportExcel.ExportR2(txtFirstName.Text, -1, result, sessionId, -1, Constants.SESSION_TYPE_CS, 2, this.ExcelPath);
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

    //private void ExportExcelTemplateRFinal()
    //{
    //    try
    //    {
    //        string strMachineName = Request.ServerVariables["SERVER_NAME"];
    //        string fileName = "FormMauVongHD";

    //        int result = int.Parse(ddlResultType.SelectedValue);
    //        int sessionId = int.Parse(ddlSessions.SelectedValue);

    //        string strDownload = HRMBLL.H2.Helper.CandidateBLLExportExcel.ExportTemplateRoundBoard(txtFirstName.Text, -1, result, sessionId, -1, Constants.SESSION_TYPE_CS, 2, this.ExcelPath);
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
    protected void odsRepresentative_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {


        e.InputParameters["InvestorNo"] = int.Parse(txtInvestor.Text.TrimEnd().TrimStart().Trim().Length <= 0 ? "0" : txtInvestor.Text.TrimEnd().TrimStart().Trim());
        e.InputParameters["FullName"] = StringFormat.TrimFullName(txtFullName.Text);
        e.InputParameters["IsOk"] = 10;
        e.InputParameters["KTTCDB"] = -1;
    }
    protected void imgSearch_Click(object sender, EventArgs e)
    {
        GridView2.DataBind();
        GridView1.DataBind();
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            row.Cells[0].HorizontalAlign = HorizontalAlign.Center;
            row.Cells[1].HorizontalAlign = HorizontalAlign.Left;
            row.Cells[2].HorizontalAlign = HorizontalAlign.Right;

        }

    }
}