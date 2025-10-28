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

public partial class ShareHolder_ChairmanVoteCountAdd : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "KIỂM PHIẾU BẦU THÀNH VIÊN HỘI ĐỒNG QUẢN TRỊ";

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

    //protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    //{
    //    //int positionId = int.Parse(ddlPositions.SelectedValue);
    //    int result = -1;
    //    e.InputParameters["firstName"] = txtFirstName.Text;
    //    e.InputParameters["positionId"] = -1;
    //    e.InputParameters["result"] = result;
    //    e.InputParameters["sessionId"] = SessionId;
    //    e.InputParameters["type"] = -1;
    //    e.InputParameters["sessionType"] = Constants.SESSION_TYPE_CS;
    //    e.InputParameters["TypeSort"] = 2;
    //}

    protected void btnView_Click(object sender, EventArgs e)
    {
        GridView1.DataBind();
    }

    //protected void odsCandidateList_Selected(object sender, ObjectDataSourceStatusEventArgs e)
    //{
    //    List<CandidatesBLL> list = (List<CandidatesBLL>)e.ReturnValue;
    //    if (list != null)
    //    {
    //        UcTitle1.CountRecord = "Tổng số ứng viên : " + list.Count;
    //    }
    //}

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
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

            try { lbHDQT_Vote.Text = Convert.ToDouble(rv["HDQT_Vote"]).ToString("#,###0"); }
            catch { }




            ///////////////////////////////////////////////////////////////////////////////
            TextBox txtHDQT_A = (TextBox)row.FindControl("txtHDQT_A");
            _HDQT_A = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_HDQT_A] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_HDQT_A].ToString());
            txtHDQT_A.Text = _HDQT_A <= 0 ? "" : _HDQT_A.ToString("#,###0");

            TextBox txtHDQT_B = (TextBox)row.FindControl("txtHDQT_B");
            _HDQT_B = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_HDQT_B] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_HDQT_B].ToString());
            txtHDQT_B.Text = _HDQT_B <= 0 ? "" : _HDQT_B.ToString("#,###0");

            TextBox txtHDQT_C = (TextBox)row.FindControl("txtHDQT_C");
            _HDQT_C = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_HDQT_C] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_HDQT_C].ToString());
            txtHDQT_C.Text = _HDQT_C <= 0 ? "" : _HDQT_C.ToString("#,###0");


            TextBox txtHDQT_D = (TextBox)row.FindControl("txtHDQT_D");
            _HDQT_D = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_HDQT_D] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_HDQT_D].ToString());
            txtHDQT_D.Text = _HDQT_D <= 0 ? "" : _HDQT_D.ToString("#,###0");

            TextBox txtHDQT_E = (TextBox)row.FindControl("txtHDQT_E");
            _HDQT_E = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_HDQT_E] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_HDQT_E].ToString());
            txtHDQT_E.Text = _HDQT_E <= 0 ? "" : _HDQT_E.ToString("#,###0");

            TextBox txtHDQT_F = (TextBox)row.FindControl("txtHDQT_F");
            _HDQT_F = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_HDQT_F] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_HDQT_F].ToString());
            txtHDQT_F.Text = _HDQT_F <= 0 ? "" : _HDQT_F.ToString("#,###0");


            TextBox txtHDQT_G = (TextBox)row.FindControl("txtHDQT_G");
            _HDQT_G = Convert.ToDouble(rv[RepresentativeKeys.Field_Representative_HDQT_G] == DBNull.Value ? "0" : rv[RepresentativeKeys.Field_Representative_HDQT_G].ToString());
            txtHDQT_G.Text = _HDQT_G <= 0 ? "" : _HDQT_G.ToString("#,###0");

            _total = _HDQT_A + _HDQT_B + _HDQT_C + _HDQT_D + _HDQT_E + _HDQT_F + _HDQT_G;
            lbTotal.Text = _total <= 0 ? "" : _total.ToString("#,###0");

            int _hdqt_IsValid = rv[RepresentativeKeys.Field_Representative_HDQT_IsValid] == DBNull.Value ? 0 : Convert.ToInt32(rv[RepresentativeKeys.Field_Representative_HDQT_IsValid]);
            DropDownList ddlHDQT_IsValid = (DropDownList)row.FindControl("ddlHDQT_IsValid");
            ddlHDQT_IsValid.SelectedValue = _hdqt_IsValid.ToString();
        }

    }



    private void Save()
    {
        int _RepresentativeId = 0; double _HDQT_A = 0; double _HDQT_B = 0; double _HDQT_C = 0; double _HDQT_D = 0; double _HDQT_E = 0; double _HDQT_F = 0; double _HDQT_G = 0; int _HDQT_IsValid = 0;
        double _HDQT_Vote = 0;
        double _total = 0;
        try
        {
            foreach (GridViewRow row in GridView1.Rows)
            {



                Label lbFullName = (Label)row.FindControl("lbFullName");
                _RepresentativeId = int.Parse(lbFullName.ToolTip.Trim().Length <= 0 ? "0" : lbFullName.ToolTip.Trim());
                Label lbHDQT_Vote = (Label)row.FindControl("lbHDQT_Vote");
                _HDQT_Vote = lbHDQT_Vote.Text == "" ? 0 : double.Parse(lbHDQT_Vote.Text);

                TextBox txtHDQT_A = (TextBox)row.FindControl("txtHDQT_A");
                _HDQT_A = txtHDQT_A.Text == "" ? 0 : double.Parse(txtHDQT_A.Text);
                TextBox txtHDQT_B = (TextBox)row.FindControl("txtHDQT_B");
                _HDQT_B = txtHDQT_B.Text == "" ? 0 : double.Parse(txtHDQT_B.Text);
                TextBox txtHDQT_C = (TextBox)row.FindControl("txtHDQT_C");
                _HDQT_C = txtHDQT_C.Text == "" ? 0 : double.Parse(txtHDQT_C.Text);


                TextBox txtHDQT_D = (TextBox)row.FindControl("txtHDQT_D");
                _HDQT_D = txtHDQT_D.Text == "" ? 0 : double.Parse(txtHDQT_D.Text);
                TextBox txtHDQT_E = (TextBox)row.FindControl("txtHDQT_E");
                _HDQT_E = txtHDQT_E.Text == "" ? 0 : double.Parse(txtHDQT_E.Text);
                TextBox txtHDQT_F = (TextBox)row.FindControl("txtHDQT_F");
                _HDQT_F = txtHDQT_F.Text == "" ? 0 : double.Parse(txtHDQT_F.Text);


                TextBox txtHDQT_G = (TextBox)row.FindControl("txtHDQT_G");
                _HDQT_G = txtHDQT_G.Text == "" ? 0 : double.Parse(txtHDQT_G.Text);

                DropDownList ddlHDQT_IsValid = (DropDownList)row.FindControl("ddlHDQT_IsValid");
                _HDQT_IsValid = int.Parse(ddlHDQT_IsValid.SelectedValue.ToString().Trim());


                _total = _HDQT_A + _HDQT_B + _HDQT_C + _HDQT_D + _HDQT_E + _HDQT_F + _HDQT_G;

                if (_total > _HDQT_Vote)
                {                 
                    RepresentativeBLL.UpdateForHDQT(_RepresentativeId, _HDQT_A, _HDQT_B, _HDQT_C, _HDQT_D, _HDQT_E, _HDQT_F, _HDQT_G, -1);
                    UcTitle1.ErrorText = "SỐ PHIẾU ĐÃ BẦU VƯỢT QUÁ SỐ LƯỢNG PHIẾU BẦU THEO QUY ĐỊNH...... !!. PHIẾU KHÔNG HỢP LỆ ";
                }
                else if (_total <=0)
                {                    
                    RepresentativeBLL.UpdateForHDQT(_RepresentativeId, _HDQT_A, _HDQT_B, _HDQT_C, _HDQT_D, _HDQT_E, _HDQT_F, _HDQT_G, -1);
                    UcTitle1.ErrorText = "PHIẾU ĐÃ BỎ TRỐNG...... !!. PHIẾU KHÔNG HỢP LỆ ";
                }
                else
                {
                    RepresentativeBLL.UpdateForHDQT(_RepresentativeId, _HDQT_A, _HDQT_B, _HDQT_C, _HDQT_D, _HDQT_E, _HDQT_F, _HDQT_G, 1);
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
        Response.Redirect("~/ShareHolder/ChairmanVoteCountList.aspx");
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