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

using HRMBLL.H;

public partial class Income_UserControls_Incomes : System.Web.UI.UserControl
{

    private int _Month;
    private int _Year;
    private int _UserId;

    private double _Total = 0;
    private double _DongGop = 0;

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
   
    private void SetTotal()
    {
        //EmployeeIncomeBLL objBLL = EmployeeIncomeBLL.GetByUserId_Monthly(UserId, Month, Year);

        ////HRMBLL.H.IncomesMonthBLL.GetByUserId_Monthly(UserId, Month, Year, false);
        //if (objBLL != null)
        //{
        //    //SetVisible(true);
        //    pnIncome.Visible = true;
        //    lbTotalIncome.Text = (objBLL.Total_Inc + (decimal)_DongGop).ToString("#,###0.00");
        //    //lbTotalContribution.Text = objBLL.Total_Cntr.ToString("#,###0.00");
        //    decimal realIncome = objBLL.Total_Real;//objBLL.Total_Inc - objBLL.Total_Cntr;
        //    lbRealIncome.Text = realIncome.ToString("#,###0.00") + " VND ";
        //}
        //else
        //{
        //    //SetVisible(false);
        //    pnIncome.Visible = false;
        ////}
        Label lbSumTotal = (Label)this.FindControl("lbTotalIncome");
        Label lbSumTotalII = (Label)this.FindControl("lbTotalII");
        DataTable dtIncome = IncomesMonthBLL.GetAllByUserId_Monthly_By_All(UserId, Month, Year);
        DataTable dtPaid = IncomesMonthBLL.GetAllByUserId_Paid_Monthly_By_All(UserId, Month, Year);
        if (dtIncome.Rows.Count > 0 && dtPaid.Rows.Count > 0)
        {
            pnIncome.Visible = true;
            lbSumTotal.Text = HRMUtil.StringFormat.SetFormatMoney(decimal.Parse(dtIncome.Rows[0]["TotalIncome"].ToString()));

            decimal _TotalPaid = 0;
            foreach (DataRow row in dtPaid.Rows)
            {
                _TotalPaid += decimal.Parse(row["Value"].ToString());
            }
            lbSumTotalII.Text = HRMUtil.StringFormat.SetFormatMoney(_TotalPaid);

            lbRealIncome.Text = HRMUtil.StringFormat.SetFormatMoney(decimal.Parse(dtIncome.Rows[0]["ThucLinh"].ToString())) + " VND";
        }
        else
        {
            pnIncome.Visible = false;
        }
    }

    //private void SetVisible(bool visible)
    //{

    //    lbNotes.Visible = visible;
    //    lbTextTotalContribution.Visible = visible;
    //    lbTextTotalIncome.Visible = visible;
    //    lbTitleTextTotalContribution.Visible = visible;
    //    lbTotalIncome.Visible = visible;
    //    lbTotalContribution.Visible = visible;
    //    lbRealIncome.Visible = visible;
    //}

    protected void Page_Load(object sender, EventArgs e)
    {
        OnIncomesLoad(e);
        if (!IsPostBack)
        {
            SetTotal();
        }
    }

    public void GridDataBinding()
    {
        grdInocomesMonth.DataBind();
        grdContributions.DataBind();
        SetTotal();
    }
    protected void odsIncomesMonth_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["userId"] = UserId;
        e.InputParameters["month"] = Month;
        e.InputParameters["year"] = Year;
    }
    protected void odsContributions_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["userId"] = UserId;
        e.InputParameters["month"] = Month;
        e.InputParameters["year"] = Year;
    }

   
    protected void grdContributions_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //GridViewRow row = e.Row;
        //if (row.RowType == DataControlRowType.DataRow)
        //{
        //    IncomesMonthBLL obj = (IncomesMonthBLL)e.Row.DataItem;
        //    _Total = _Total + obj.Value;

        //}
        //if (row.RowType == DataControlRowType.Footer)
        //{
        //    Label lbSumTotal = (Label)e.Row.FindControl("lbSumTotal");
        //    lbSumTotal.Text = HRMUtil.StringFormat.SetFormatMoney(decimal.Parse(IncomesMonthBLL.GetAllByUserId_Paid_Monthly_By_All(UserId, Month, Year).Rows[6]["TOTAL"].ToString()));
        //}
    }
    protected void grdInocomesMonth_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //GridViewRow row = e.Row;
        //if (row.RowType == DataControlRowType.DataRow)
        //{
        //    IncomesMonthBLL obj = (IncomesMonthBLL)e.Row.DataItem;
        //    if (obj.IncomeTypeId == 19)
        //    {
        //        _DongGop = obj.Value;
        //    }
        //}
    }
}
