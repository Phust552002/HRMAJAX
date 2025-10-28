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

public partial class ShareHolder_BQSLHDQTAdd : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "KIỂM PHIẾU BIỂU QUYẾT THÔNG QUA SỐ LƯỢNG HỘI ĐỒNG QUẢN TRỊ";

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


            int _BQ_SLHDQT = rv["BQ_SLHDQT"] == DBNull.Value ? 0 : Convert.ToInt32(rv["BQ_SLHDQT"]);
            DropDownList ddlBQ_SLHDQT = (DropDownList)row.FindControl("ddlBQ_SLHDQT");
            ddlBQ_SLHDQT.SelectedValue = _BQ_SLHDQT.ToString();

        }
    }



    private void Save()
    {
        int _RepresentativeId = 0; int _BQ_SLHDQT = 0;

        try
        {
            foreach (GridViewRow row in GridView1.Rows)
            {


                Label lbFullName = (Label)row.FindControl("lbFullName");
                _RepresentativeId = int.Parse(lbFullName.ToolTip.Trim().Length <= 0 ? "0" : lbFullName.ToolTip.Trim());

                DropDownList ddlBQ_SLHDQT = (DropDownList)row.FindControl("ddlBQ_SLHDQT");
                _BQ_SLHDQT = int.Parse(ddlBQ_SLHDQT.SelectedValue.ToString().Trim());

                if (_BQ_SLHDQT == -1)
                {
                    RepresentativeBLL.UpdateForBQ_SLHDQT(_RepresentativeId, _BQ_SLHDQT, -1);
                    UcTitle1.ErrorText = "PHIẾU KHÔNG HỢP LỆ !!!!!!!!!!!!!!............";
                }
                else
                {
                    RepresentativeBLL.UpdateForBQ_SLHDQT(_RepresentativeId, _BQ_SLHDQT, 1);
                    UcTitle1.ErrorText = "LƯU THÀNH CÔNG.";
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
        Response.Redirect("~/ShareHolder/BQSLHDQTList.aspx");
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