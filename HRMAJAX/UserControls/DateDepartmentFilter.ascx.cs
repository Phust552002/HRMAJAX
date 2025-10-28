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

public partial class UserControls_DateDepartmentFilter : System.Web.UI.UserControl
{
    public event EventHandler ViewButtonClick;
    public event EventHandler Control_Load;

    void OnViewButtonClick(EventArgs e)
    {
        if (ViewButtonClick != null)
        {
            ViewButtonClick(this, e);

        }
    }
    void OnControl_Load(EventArgs e)
    {
        if (Control_Load != null)
        {
            Control_Load(this, e);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            AddDataToCboYear();
        }
    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        OnViewButtonClick(e);
    }
    private void AddDataToCboYear()
    {

        for (int i = 2005; i <= DateTime.Now.Year; i++)
        {
            ListItem item = new ListItem(i.ToString(), i.ToString());
            ddlYears.Items.Add(item);
        }
        DateTime date = DateTime.Now.AddMonths(-2);
        ddlYears.SelectedValue = date.Year.ToString();
        ddlMonths.SelectedValue = date.Month.ToString();
    }
    public int DepartmentId
    {
        get
        {
            return Convert.ToInt32(DropDownList1.SelectedValue);
        }
        set
        {
            DropDownList1.SelectedValue = value.ToString();
        }
    }

    public string FullName
    {
        get
        {
            return txtFullName.Text;
        }
    }
    public int Month
    {
        get 
        {
            if (ddlMonths.SelectedValue.Trim().Length > 0)
            {
                return int.Parse(ddlMonths.SelectedValue.Trim());
            }
            else
            {
                return 0;
            }
        }
    }

    public int Year
    {
        get { return int.Parse(ddlYears.SelectedValue.Trim()); }
    }
}
