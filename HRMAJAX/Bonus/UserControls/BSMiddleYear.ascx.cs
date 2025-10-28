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

using HRMBLL.H0;
using HRMBLL.H;


public partial class Bonus_UserControls_BSMiddleYear : System.Web.UI.UserControl
{
    private int _Year;
    private int _UserId;
    public event EventHandler BSMiddleYearLoad;

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


    void OnBSMiddleYearLoadLoad(EventArgs e)
    {
        if (BSMiddleYearLoad != null)
        {
            BSMiddleYearLoad(this, e);
        }
    }
    public void GridDataBinding()
    {
        grdBSDT.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        OnBSMiddleYearLoadLoad(e);
    }
    protected void odsBSDT_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["userId"] = UserId;
        e.InputParameters["year"] = Year;
        e.InputParameters["type"] = 4;

    }
    protected void grdBSDT_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            BonusValuesBLL objBLL = (BonusValuesBLL)row.DataItem;
            if (objBLL.BonusNameId == 34 || objBLL.BonusNameId == 35 || objBLL.BonusNameId == 36)
            {
                row.CssClass = "grid-item";
            }
            if (objBLL.BonusNameId == 37 || objBLL.BonusNameId == 38 || objBLL.BonusNameId == 39)
            {
                row.CssClass = "grid-atlternating-item";
            }
            if (objBLL.BonusNameId == 40)
            {
                row.CssClass = "grid-item";
            }

            Label lbName = (Label)row.FindControl("lbName");
            Label lbMoney = (Label)row.FindControl("lbMoney");
            if (objBLL.BonusNameId == 52)
            {
                row.CssClass = "grid-footer";
            }
        }
    }
}
