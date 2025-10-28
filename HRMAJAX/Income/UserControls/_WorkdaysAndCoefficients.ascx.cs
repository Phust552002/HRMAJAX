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

public partial class Income_UserControls_WorkdaysAndCoefficients : System.Web.UI.UserControl
{

    public event EventHandler ControlOnLoad;
    private int _Month;
    private int _Year;
    private int _UserId;

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

    void OnWorkdaysAndCoefficientsLoad(EventArgs e)
    {
        if (ControlOnLoad != null)
        {
            ControlOnLoad(this, e);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        OnWorkdaysAndCoefficientsLoad(e);
    }

    public void GridDataBinding()
    {
        grdTimeKeeping.DataBind();
        grdWorkdays.DataBind();
        grdCoefficients.DataBind();
    }

    protected void odsWorkdays_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["userId"] = UserId;
        e.InputParameters["month"] = Month;
        e.InputParameters["year"] = Year;
        e.InputParameters["type"] = 0;
    }
    protected void odsTimeKeepings_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["userId"] = UserId;
        e.InputParameters["month"] = Month;
        e.InputParameters["year"] = Year;
        e.InputParameters["type"] = 1;
    }
    protected void odsCoefficients_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["userId"] = UserId;
        e.InputParameters["month"] = Month;
        e.InputParameters["year"] = Year;
    }

    protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["userId"] = UserId;
        e.InputParameters["month"] = Month;
        e.InputParameters["year"] = Year;
        e.InputParameters["type"] = 2;
    }
}
