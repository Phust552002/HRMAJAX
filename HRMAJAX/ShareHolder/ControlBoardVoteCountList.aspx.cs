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

public partial class ShareHolder_ControlBoardVoteCountList : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "BẦU BAN KIỂM SOÁT";
            MenuItemCollection items = new MenuItemCollection();
            items.Add(new MenuItem("Kiểm phiếu", "1"));
            ActionMenu1.BindMenu(items);
            //if (Request.QueryString["s"] != null)
            //{
            //    ddlSessions.SelectedValue = Request.QueryString["s"].ToString();
            //}
        }
        ActionMenu1.MenuItemClick += new EventHandler(ActionMenu1_MenuItemClick);
        lnkReport.NavigateUrl = "javascript:OpenPopupVoteReport('ControlBoardVoteCountReport.aspx','" + 339 + "')";
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
            Response.Redirect("~/ShareHolder/ControlBoardVoteCountAdd.aspx");
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

            double _total = 0; double _BKS_A = 0; double _BKS_B = 0; double _BKS_C = 0; 
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

            try{ lbStock.Text = Convert.ToInt32(rv["Stock"]).ToString("#,###0"); }
            catch { }            

            try { lbStockRatio.Text = Convert.ToDouble(rv["StockRatio"]).ToString(StringFormat.FormatRepresentative);}
            catch { }
            
            
            try { lbBKS_Vote.Text = Convert.ToDouble(rv["BKS_Vote"]).ToString("#,###0");}
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
            Label lbBKS_A = (Label)row.FindControl("lbBKS_A");
            _BKS_A = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_BKS_A] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_BKS_A].ToString());
            lbBKS_A.Text = _BKS_A <= 0 ? "" : _BKS_A.ToString("#,###0");

            Label lbBKS_B = (Label)row.FindControl("lbBKS_B");
            _BKS_B = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_BKS_B] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_BKS_B].ToString());
            lbBKS_B.Text = _BKS_B <= 0 ? "" : _BKS_B.ToString("#,###0");

            Label lbBKS_C = (Label)row.FindControl("lbBKS_C");
            _BKS_C = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_BKS_C] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_BKS_C].ToString());
            lbBKS_C.Text = _BKS_C <= 0 ? "" : _BKS_C.ToString("#,###0");



            _total = _BKS_A + _BKS_B + _BKS_C;
            lbTotal.Text = _total <= 0 ? "" : _total.ToString("#,###0");

            int _BKS_IsValid = rv[RepresentativeKeys.Field_Representative_BKS_IsValid] == DBNull.Value ? 0 : Convert.ToInt32(rv[RepresentativeKeys.Field_Representative_BKS_IsValid]);
            Label lbBKS_IsValid = (Label)row.FindControl("lbBKS_IsValid");
            if (_BKS_IsValid == 1)
            {
                lbBKS_IsValid.Text = "Hợp lệ";
            }
            else if (_BKS_IsValid == -1)
            {
                lbBKS_IsValid.Text = "Ko hợp lệ";
                lbBKS_IsValid.Font.Bold = true;
                lbBKS_IsValid.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                lbBKS_IsValid.Text = "";
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
        e.InputParameters["KTTCDB"] = 1;
    }
    protected void imgSearch_Click(object sender, EventArgs e)
    {
        GridView2.DataBind();        
    }

    

}