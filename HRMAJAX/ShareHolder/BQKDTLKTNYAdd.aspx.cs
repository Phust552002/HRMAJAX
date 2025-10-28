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

public partial class ShareHolder_BQKDTLKTNYAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "KIỂM PHIẾU BIỂU QUYẾT THÔNG QUA CT KIÊM TGĐ, KH SXKD NĂM 2015, THÙ LAO HĐQT & BKS, LỰA CHỌN ĐV KIỂM TOÁN, LƯU KÝ CK VÀ NIÊM YẾT CP ";

            //if (Request.QueryString["s"] != null)
            //{
            //    SessionId = int.Parse(Request.QueryString["s"].ToString());
            //}
        }
        txtInvestor.Focus();
    }

    //private int SessionId
    //{
    //    get
    //    {
    //        if (ViewState["SessionId"] != null)
    //        {
    //            return int.Parse(ViewState["SessionId"].ToString());
    //        }
    //        else
    //        {
    //            return 0;
    //        }
    //    }
    //    set { ViewState["SessionId"] = value; }
    //}



    protected void btnView_Click(object sender, EventArgs e)
    {
        GridView1.DataBind();
    }



    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
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


            try { lbInvestorNo.Text = Convert.ToInt32(rv[RepresentativeKeys.Field_Representative_InvestorNo]).ToString("SAG000000000#"); }
            catch { }
            try
            {
                lbFullName.Text = rv[RepresentativeKeys.Field_Representative_RepresentativeName].ToString();
                lbFullName.ToolTip = rv[RepresentativeKeys.Field_Representative_RepresentativeId].ToString();
            }
            catch { }

            try { lbStock.Text = Convert.ToInt32(rv["Stock"]).ToString("#,###0"); }
            catch { }

            try { lbStockRatio.Text = Convert.ToDouble(rv["StockRatio"]).ToString(StringFormat.FormatRepresentative); }
            catch { }

            try { lbBKS_Vote.Text = Convert.ToDouble(rv["BKS_Vote"]).ToString("#,###0"); }
            catch { }


            ///////////////////////////////////////////////////////////////////////////////


            int _BQ_KD = rv["BQ_KD"] == DBNull.Value ? 0 : Convert.ToInt32(rv["BQ_KD"]);
            DropDownList ddlBQ_KD = (DropDownList)row.FindControl("ddlBQ_KD");
            ddlBQ_KD.SelectedValue = _BQ_KD.ToString();

            int _BQ_TL = rv["BQ_TL"] == DBNull.Value ? 0 : Convert.ToInt32(rv["BQ_TL"]);
            DropDownList ddlBQ_TL = (DropDownList)row.FindControl("ddlBQ_TL");
            ddlBQ_TL.SelectedValue = _BQ_TL.ToString();

            int _BQ_KT = rv["BQ_KT"] == DBNull.Value ? 0 : Convert.ToInt32(rv["BQ_KT"]);
            DropDownList ddlBQ_KT = (DropDownList)row.FindControl("ddlBQ_KT");
            ddlBQ_KT.SelectedValue = _BQ_KT.ToString();

            int _BQ_NY = rv["BQ_NY"] == DBNull.Value ? 0 : Convert.ToInt32(rv["BQ_NY"]);
            DropDownList ddlBQ_NY = (DropDownList)row.FindControl("ddlBQ_NY");
            ddlBQ_NY.SelectedValue = _BQ_NY.ToString();

            int _BQ_CTTGD = rv["BQ_CTTGD"] == DBNull.Value ? 0 : Convert.ToInt32(rv["BQ_CTTGD"]);
            DropDownList ddlBQ_CTTGD = (DropDownList)row.FindControl("ddlBQ_CTTGD");
            ddlBQ_CTTGD.SelectedValue = _BQ_CTTGD.ToString();

            int _BQ_KDTLKTNY_IsValid = rv["BQ_KDTLKTNY_IsValid"] == DBNull.Value ? 0 : Convert.ToInt32(rv["BQ_KDTLKTNY_IsValid"]);
            DropDownList ddlBQ_KDTLKTNY_IsValid = (DropDownList)row.FindControl("ddlBQ_KDTLKTNY_IsValid");
            ddlBQ_KDTLKTNY_IsValid.SelectedValue = _BQ_KDTLKTNY_IsValid.ToString();

        }
    }



    private void Save()
    {
        int _RepresentativeId = 0; int _BQ_KD = 0; int _BQ_TL = 0; int _BQ_KT = 0; int _BQ_NY = 0; int _BQ_CTTGD = 0; int _BQ_KDTLKTNY_IsValid = 0;

        try
        {
            foreach (GridViewRow row in GridView1.Rows)
            {


                Label lbFullName = (Label)row.FindControl("lbFullName");
                _RepresentativeId = int.Parse(lbFullName.ToolTip.Trim().Length <= 0 ? "0" : lbFullName.ToolTip.Trim());

                DropDownList ddlBQ_KD = (DropDownList)row.FindControl("ddlBQ_KD");
                _BQ_KD = int.Parse(ddlBQ_KD.SelectedValue.ToString().Trim());

                DropDownList ddlBQ_TL = (DropDownList)row.FindControl("ddlBQ_TL");
                _BQ_TL = int.Parse(ddlBQ_TL.SelectedValue.ToString().Trim());

                DropDownList ddlBQ_KT = (DropDownList)row.FindControl("ddlBQ_KT");
                _BQ_KT = int.Parse(ddlBQ_KD.SelectedValue.ToString().Trim());

                DropDownList ddlBQ_NY = (DropDownList)row.FindControl("ddlBQ_NY");
                _BQ_NY = int.Parse(ddlBQ_NY.SelectedValue.ToString().Trim());

                DropDownList ddlBQ_CTTGD = (DropDownList)row.FindControl("ddlBQ_CTTGD");
                _BQ_CTTGD = int.Parse(ddlBQ_CTTGD.SelectedValue.ToString().Trim());

                DropDownList ddlBQ_KDTLKTNY_IsValid = (DropDownList)row.FindControl("ddlBQ_KDTLKTNY_IsValid");
                _BQ_KDTLKTNY_IsValid = int.Parse(ddlBQ_KDTLKTNY_IsValid.SelectedValue.ToString().Trim());

                if (_BQ_KD == -1 || _BQ_TL == -1 || _BQ_KT == -1 || _BQ_NY == -1 || _BQ_CTTGD ==-1)
                {
                    RepresentativeBLL.UpdateForBQ_KDTLKTNY(_RepresentativeId, _BQ_KD, _BQ_TL, _BQ_KT, _BQ_NY, _BQ_CTTGD, - 1);
                    UcTitle1.ErrorText = "PHIẾU ĐÃ BỎ TRỐNG...... !!. PHIẾU KHÔNG HỢP LỆ ";
                }
                else
                {
                    RepresentativeBLL.UpdateForBQ_KDTLKTNY(_RepresentativeId, _BQ_KD, _BQ_TL, _BQ_KT, _BQ_NY, _BQ_CTTGD, 1);
                    UcTitle1.ErrorText = "LƯU THÀNH CÔNG...";
                }

            }
            GridView1.DataBind();
            txtFullName.Text = "";
            txtInvestor.Text = "";
        }
        catch (HRMException he)
        {
            UcTitle1.ErrorText = he.Message;
        }

    }



    protected void GridView1_PageIndexChanged(object sender, EventArgs e)
    {
        UcTitle1.ErrorText = "";
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/ShareHolder/BQKDTLKTNYList.aspx");
    }

    protected void odsRepresentative_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {

        e.InputParameters["InvestorNo"] = int.Parse(txtInvestor.Text.TrimEnd().TrimStart().Trim().Length <= 0 ? "0" : txtInvestor.Text.TrimEnd().TrimStart().Trim());
        e.InputParameters["FullName"] = StringFormat.TrimFullName(txtFullName.Text);
        e.InputParameters["IsOk"] = 10;
        e.InputParameters["KTTCDB"] = 1;
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        Save();
    }

}