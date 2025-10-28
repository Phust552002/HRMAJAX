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

public partial class ShareHolder_ChairmanVoteCountList : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "BẦU THÀNH VIÊN HỘI ĐỒNG QUẢN TRỊ";
            MenuItemCollection items = new MenuItemCollection();
            items.Add(new MenuItem("Kiểm phiếu", "1"));
            ActionMenu1.BindMenu(items);
            //if (Request.QueryString["s"] != null)
            //{
            //    ddlSessions.SelectedValue = Request.QueryString["s"].ToString();
            //}          
        }
        ActionMenu1.MenuItemClick += new EventHandler(ActionMenu1_MenuItemClick);
        lnkReport.NavigateUrl = "javascript:OpenPopupVoteReport('ChairmanVoteCountReport.aspx','" + 339 + "')";
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
            Response.Redirect("~/ShareHolder/ChairmanVoteCountAdd.aspx");
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


    //protected void odsCandidateList_Selected(object sender, ObjectDataSourceStatusEventArgs e)
    //{
    //    List<CandidatesBLL> list = (List<CandidatesBLL>)e.ReturnValue;
    //    if (list != null)
    //    {
    //        UcTitle1.CountRecord = "Tổng số ứng viên : " + list.Count;
    //    }
    //}

    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {

            double _total = 0; double _HDQT_A = 0; double _HDQT_B = 0; double _HDQT_C = 0; double _HDQT_D = 0; double _HDQT_E = 0; double _HDQT_F = 0; double _HDQT_G = 0;
            DataRowView rv = (DataRowView)e.Row.DataItem;


            Label lbInvestorNo = (Label)e.Row.FindControl("lbInvestorNo");
            Label lbFullName = (Label)e.Row.FindControl("lbFullName");

            Label lbStock = (Label)e.Row.FindControl("lbStock");
            Label lbStockRatio = (Label)e.Row.FindControl("lbStockRatio");

            Label lbHDQT_Vote = (Label)e.Row.FindControl("lbHDQT_Vote");
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

            try { lbHDQT_Vote.Text = Convert.ToDouble(rv["HDQT_Vote"]).ToString("#,###0"); }
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
            Label lbHDQT_A = (Label)row.FindControl("lbHDQT_A");
            _HDQT_A = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_HDQT_A] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_HDQT_A].ToString());
            lbHDQT_A.Text = _HDQT_A <= 0 ? "" : _HDQT_A.ToString("#,###0");

            Label lbHDQT_B = (Label)row.FindControl("lbHDQT_B");
            _HDQT_B = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_HDQT_B] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_HDQT_B].ToString());
            lbHDQT_B.Text = _HDQT_B <= 0 ? "" : _HDQT_B.ToString("#,###0");

            Label lbHDQT_C = (Label)row.FindControl("lbHDQT_C");
            _HDQT_C = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_HDQT_C] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_HDQT_C].ToString());
            lbHDQT_C.Text = _HDQT_C <= 0 ? "" : _HDQT_C.ToString("#,###0");


            Label lbHDQT_D = (Label)row.FindControl("lbHDQT_D");
            _HDQT_D = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_HDQT_D] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_HDQT_D].ToString());
            lbHDQT_D.Text = _HDQT_D <= 0 ? "" : _HDQT_D.ToString("#,###0");

            Label lbHDQT_E = (Label)row.FindControl("lbHDQT_E");
            _HDQT_E = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_HDQT_E] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_HDQT_E].ToString());
            lbHDQT_E.Text = _HDQT_E <= 0 ? "" : _HDQT_E.ToString("#,###0");

            Label lbHDQT_F = (Label)row.FindControl("lbHDQT_F");
            _HDQT_F = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_HDQT_F] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_HDQT_F].ToString());
            lbHDQT_F.Text = _HDQT_F <= 0 ? "" : _HDQT_F.ToString("#,###0");


            Label lbHDQT_G = (Label)row.FindControl("lbHDQT_G");
            _HDQT_G = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_HDQT_G] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_HDQT_G].ToString());
            lbHDQT_G.Text = _HDQT_G <= 0 ? "" : _HDQT_G.ToString("#,###0");

            _total = _HDQT_A + _HDQT_B + _HDQT_C + _HDQT_D + _HDQT_E + _HDQT_F + _HDQT_G;
            lbTotal.Text = _total <= 0 ? "" : _total.ToString("#,###0");

            int _hdqt_IsValid = rv[RepresentativeKeys.Field_Representative_HDQT_IsValid] == DBNull.Value ? 0 : Convert.ToInt32(rv[RepresentativeKeys.Field_Representative_HDQT_IsValid]);
            Label lbHDQT_IsValid = (Label)row.FindControl("lbHDQT_IsValid");
            if (_hdqt_IsValid == 1)
            {
                lbHDQT_IsValid.Text = "Hợp lệ";
            }
            else if (_hdqt_IsValid == -1)
            {
                lbHDQT_IsValid.Text = "Ko hợp lệ";
                lbHDQT_IsValid.Font.Bold = true;
                lbHDQT_IsValid.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                lbHDQT_IsValid.Text = "";
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

    protected void odsRepresentative_Selected(object sender, ObjectDataSourceStatusEventArgs e)
    {
        DataTable dt = (DataTable)e.ReturnValue;
        if (dt != null)
        {            
            UcTitle1.CountRecord = "Tổng số cổ đông tham dự : " + dt.Rows.Count;
        }
    }
   
}