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

public partial class Bonus_UserControls_Holidays : System.Web.UI.UserControl
{

    private int _Year;
    private int _UserId;
    public event EventHandler HolidaysLoad;

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

    void OnHolidaysLoad(EventArgs e)
    {
        if (HolidaysLoad != null)
        {
            HolidaysLoad(this, e);
        }
    }

    public void GridDataBinding()
    {
        grdHolidays.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        OnHolidaysLoad(e);
    }

    protected void odsHolidays_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["userId"] = UserId;
        e.InputParameters["year"] = Year;
        e.InputParameters["type"] = 1;
    }

    protected void grdHolidays_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            HRMBLL.H.BonusValuesBLL obj = (HRMBLL.H.BonusValuesBLL)row.DataItem;

            Label lbName = (Label)row.FindControl("lbName");
            lbName.Text = obj.Description;
            Label lbBonusValue = (Label)row.FindControl("lbBonusValue");
            lbBonusValue.Text = obj.BonusValue == 0 ? "" : obj.BonusValue.ToString(HRMUtil.StringFormat.FormatCurrencyFinal);

            //if ((obj.BonusNameId == 5 || obj.BonusNameId == 51 || obj.BonusNameId == 52) && obj.BonusYear > 2008)
            //{
            //    row.CssClass = "grid-item";
            //}
            if (obj.BonusNameId == 2 || obj.BonusNameId == 5 || obj.BonusNameId == 6 || obj.BonusNameId == 7)
            {

                row.CssClass = "grid-footer";
            }
        }
    }
}
