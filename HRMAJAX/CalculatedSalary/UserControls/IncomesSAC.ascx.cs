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

using HRMUtil;

public partial class CalculatedSalary_UserControls_IncomesSAC : System.Web.UI.UserControl
{
    private int _Month;
    private int _Year;
    private int _UserId;

    public event EventHandler IncomesLoad;
    void OnIncomesLoad(EventArgs e)
    {
        if (IncomesLoad != null)
        {
            IncomesLoad(this, e);
        }
    }

    public int Month
    {
        get { return _Month; }
        set { _Month = value; }
    }

    public int Year
    {
        get { return _Year; }
        set { _Year = value; }
    }

    public int UserId
    {
        get { return _UserId; }
        set { _UserId = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        OnIncomesLoad(e);
        //if (!IsPostBack)
        //{
        //    SetTotal();
        //}
    }

    public void GridDataBinding()
    {
        grdInocomesMonth.DataBind();
        grdContributions.DataBind();
        //SetTotal();
    }
    protected void odsIncomesMonth_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["userId"] = UserId;
        e.InputParameters["month"] = Month;
        e.InputParameters["year"] = Year;
        e.InputParameters["type"] = false;
    }
    protected void odsContributions_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["userId"] = UserId;
        e.InputParameters["month"] = Month;
        e.InputParameters["year"] = Year;
        e.InputParameters["type"] = true;
    }
    protected void grdInocomesMonth_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            HRMBLL.H.IncomesMonthBLL obj = (HRMBLL.H.IncomesMonthBLL)row.DataItem;
            Label lbValue = (Label)row.FindControl("lbValue");
            lbValue.Text = obj.Value <= 0 ? "" : obj.Value.ToString(StringFormat.FormatCurrency);
        }
    }
    protected void grdContributions_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            HRMBLL.H.IncomesMonthBLL obj = (HRMBLL.H.IncomesMonthBLL)row.DataItem;
            Label lbValue = (Label)row.FindControl("lbValue");
            lbValue.Text = obj.Value <= 0 ? "" : obj.Value.ToString(StringFormat.FormatCurrency);
        }
    }
}
