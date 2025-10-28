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

public partial class ShareHolder_ControlBoardVoteCountAdd : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "KIỂM PHIẾU BẦU BAN KIỂM SOÁT";

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


            double _total = 0; double _BKS_A = 0; double _BKS_B = 0; double _BKS_C = 0;

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
            TextBox txtBKS_A = (TextBox)row.FindControl("txtBKS_A");
            _BKS_A = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_BKS_A] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_BKS_A].ToString());
            txtBKS_A.Text = _BKS_A <= 0 ? "" : _BKS_A.ToString("#,###0");

            TextBox txtBKS_B = (TextBox)row.FindControl("txtBKS_B");
            _BKS_B = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_BKS_B] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_BKS_B].ToString());
            txtBKS_B.Text = _BKS_B <= 0 ? "" : _BKS_B.ToString("#,###0");

            TextBox txtBKS_C = (TextBox)row.FindControl("txtBKS_C");
            _BKS_C = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_BKS_C] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_BKS_C].ToString());
            txtBKS_C.Text = _BKS_C <= 0 ? "" : _BKS_C.ToString("#,###0");



            _total = _BKS_A + _BKS_B + _BKS_C;
            lbTotal.Text = _total <= 0 ? "" : _total.ToString("#,###0");

            int _BKS_IsValid = rv[RepresentativeKeys.Field_Representative_BKS_IsValid] == DBNull.Value ? 0 : Convert.ToInt32(rv[RepresentativeKeys.Field_Representative_BKS_IsValid]);
            DropDownList ddlBKS_IsValid = (DropDownList)row.FindControl("ddlBKS_IsValid");
            ddlBKS_IsValid.SelectedValue = _BKS_IsValid.ToString();

        }
    }



    private void Save()
    {
        int _RepresentativeId = 0; double _BKS_A = 0; double _BKS_B = 0; double _BKS_C = 0; int _BKS_IsValid = 0;
        double _BKS_Vote = 0;
        double _total = 0;
        try
        {
            foreach (GridViewRow row in GridView1.Rows)
            {



                Label lbFullName = (Label)row.FindControl("lbFullName");
                _RepresentativeId = int.Parse(lbFullName.ToolTip.Trim().Length <= 0 ? "0" : lbFullName.ToolTip.Trim());
                Label lbBKS_Vote = (Label)row.FindControl("lbBKS_Vote");
                _BKS_Vote = lbBKS_Vote.Text == "" ? 0 : double.Parse(lbBKS_Vote.Text);

                TextBox txtBKS_A = (TextBox)row.FindControl("txtBKS_A");
                _BKS_A = txtBKS_A.Text == "" ? 0 : double.Parse(txtBKS_A.Text);
                TextBox txtBKS_B = (TextBox)row.FindControl("txtBKS_B");
                _BKS_B = txtBKS_B.Text == "" ? 0 : double.Parse(txtBKS_B.Text);
                TextBox txtBKS_C = (TextBox)row.FindControl("txtBKS_C");
                _BKS_C = txtBKS_C.Text == "" ? 0 : double.Parse(txtBKS_C.Text);



                DropDownList ddlBKS_IsValid = (DropDownList)row.FindControl("ddlBKS_IsValid");
                _BKS_IsValid = int.Parse(ddlBKS_IsValid.SelectedValue.ToString().Trim());


                _total = _BKS_A + _BKS_B + _BKS_C;

                if (_total > _BKS_Vote)
                {
                    RepresentativeBLL.UpdateForBKS(_RepresentativeId, _BKS_A, _BKS_B, _BKS_C, -1);
                    UcTitle1.ErrorText = "SỐ PHIẾU ĐÃ BẦU VƯỢT QUÁ SỐ LƯỢNG PHIẾU BẦU THEO QUY ĐỊNH...... !!. KHÔNG THỂ ";
                }
                else if (_total <= 0)
                {
                    RepresentativeBLL.UpdateForBKS(_RepresentativeId, _BKS_A, _BKS_B, _BKS_C, -1);
                    UcTitle1.ErrorText = "PHIẾU ĐÃ BỎ TRỐNG...... !!. PHIẾU KHÔNG HỢP LỆ ";
                }
                else
                {
                    RepresentativeBLL.UpdateForBKS(_RepresentativeId, _BKS_A, _BKS_B, _BKS_C, 1);
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
        Response.Redirect("~/ShareHolder/ControlBoardVoteCountList.aspx");
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