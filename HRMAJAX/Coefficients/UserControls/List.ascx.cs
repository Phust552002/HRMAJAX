using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using HRMBLL.H1;
using HRMUtil;

public partial class Coefficients_UserControls_List : System.Web.UI.UserControl
{
    private int _UserId;
    public event EventHandler OnLoadList;
    void OnListLoad(EventArgs e)
    {
        if (OnLoadList != null)
        {
            OnLoadList(this, e);
        }
    }
    public int UserId
    {
        get { return _UserId; }
        set { _UserId = value; }
    }
    public void GridDataBinding()
    {
        grdCoefficients.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        OnListLoad(e);
    }
    protected void odsCoefficients_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["userId"] = UserId;
    }
    protected void grdCoefficients_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            CoefficientEmployeesBLL obj = (CoefficientEmployeesBLL)row.DataItem;
            Label lbLNS = (Label)row.FindControl("lbLNS");
            lbLNS.Text = obj.LNS <= 0 ? string.Empty : StringFormat.SetFormatCoefficient(obj.LNS);   
            Label lbLCB = (Label)row.FindControl("lbLCB");
            lbLCB.Text = obj.LCB <= 0 ? string.Empty : StringFormat.SetFormatCoefficient(obj.LCB);   
            Label lbPCDH = (Label)row.FindControl("lbPCDH");
            lbPCDH.Text = obj.PCDH <= 0 ? string.Empty : StringFormat.SetFormatCoefficient(obj.PCDH);   
            Label lbPCTN = (Label)row.FindControl("lbPCTN");
            lbPCTN.Text = obj.PCTN <= 0 ? string.Empty : StringFormat.SetFormatCoefficient(obj.PCTN);   
            Label lbPCKV = (Label)row.FindControl("lbPCKV");
            lbPCKV.Text = obj.PCKV <= 0 ? string.Empty : StringFormat.SetFormatCoefficient(obj.PCKV);   
            Label lbPCCV = (Label)row.FindControl("lbPCCV");
            lbPCCV.Text = obj.PCCV <= 0 ? string.Empty : StringFormat.SetFormatCoefficient(obj.PCCV);   
        }
    }
}
