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

public partial class UserControls_ucDateFilter : System.Web.UI.UserControl
{

    public event EventHandler ViewButtonClick;
    public event EventHandler PrintClick;
    public event EventHandler Control_Load;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            AddDataToCboYear();
        }

        OnControl_Load(e);
    }

    private void AddDataToCboYear()
    {
        
        for (int i = 2005; i <= DateTime.Now.Year; i++)
        {
            ListItem item = new ListItem(i.ToString(), i.ToString());
            ddlYears.Items.Add(item);
        }
        //DateTime date = DateTime.Now.AddMonths(-1);
        DateTime date = DateTime.Now;
        ddlYears.SelectedValue = date.Year.ToString();
        ddlMonths.SelectedValue = date.Month.ToString();
    }

    void OnViewButtonClick(EventArgs e)
    {
        if (ViewButtonClick != null)
        {
            ViewButtonClick(this, e);

        }
    }

    void OnPrintButtonClick(EventArgs e)
    {
        //if (PrintClick != null)
        //{
        //    PrintClick(this, e);
        //}
    }

    void OnControl_Load(EventArgs e)
    {
        if (Control_Load != null)
        {
            Control_Load(this, e);        
        }
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        OnViewButtonClick(e);
    }
    protected void btnPrint_Click(object sender, EventArgs e)
    {
        OnPrintButtonClick(e);
    }


    public int Month
    {
        get { return int.Parse(ddlMonths.SelectedValue.Trim()); }
        set { ddlMonths.SelectedValue = value.ToString(); }
    }

    public int Year
    {
        get { return int.Parse(ddlYears.SelectedValue.Trim()); }
        set { ddlYears.SelectedValue = value.ToString(); }
    }
}
