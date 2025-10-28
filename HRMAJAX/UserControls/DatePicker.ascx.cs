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

using HRMBLL.BLLHelper;

public partial class UserControls_DatePicker : System.Web.UI.UserControl
{
  
    public event EventHandler OnSelectedChange;

    void On_SelectedChange(EventArgs e)
    {
        if (OnSelectedChange != null)
        {
            OnSelectedChange(this, e);
        }
    }
    

    public string SelectedVNDate
    {
        get { return txtText.Text; }
        set { txtText.Text = value; }
    }

    public DateTime MinDate
    {
        get
        {            
            return (DefaultValues.GetSQLDateMinValue());
        }
    }

    public DateTime SelectedDate
    {
        get
        {
            string[] arr = txtText.Text.Split('/');

            if (arr.Length == 3)
            {
                int year = int.Parse(arr[2].Trim());
                int month = int.Parse(arr[1].Trim());
                int day = int.Parse(arr[0].Trim());

                DateTime date = new DateTime(year, month, day);

                return date;
            }
            else
            {
               return HRMBLL.BLLHelper.DefaultValues.GetSQLDateMinValue();                
            }
        }
        set
        {
            if (value.Equals(HRMBLL.BLLHelper.DefaultValues.GetSQLDateMinValue()))
            {
                txtText.Text = string.Empty;
            }
            else
            {
                txtText.Text = value.ToString("dd/MM/yyyy");
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        //BindDropDownList();
        //ddlMonth.SelectedValue = DateTime.Now.Month.ToString();
        //ddlYear.SelectedValue = DateTime.Now.Year.ToString();

    }

    private void BindDropDownList()
    {
        //for (int i = 2000; i <= DateTime.Now.Year + 5; i++)
        //{
        //    ddlYear.Items.Add(new ListItem(i.ToString(), i.ToString()));
        //}
        //for (int i = 1; i <= 12; i++)
        //{
        //    ddlMonth.Items.Add(new ListItem(i.ToString(), i.ToString()));
        //}
    }

    private void SetToDay()
    {
        Calendar1.TodaysDate = new DateTime(int.Parse(ddlYear.SelectedValue), int.Parse(ddlMonth.SelectedValue), 1);
    }

    protected void PickDate(object sender, EventArgs e)
    {
        txtText.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
        ToggleCalendar();
        On_SelectedChange(e);

    }
    private void ToggleCalendar()
    {
        Panel1.CssClass = ("calendarHide" == Panel1.CssClass) ? ("calendarShow") : ("calendarHide");
    }
    protected void imgCalendar_Click(object sender, ImageClickEventArgs e)
    {
        ToggleCalendar();
        if (txtText.Text.Trim().Length > 0)
        {
            Calendar1.TodaysDate = this.SelectedDate;
            ddlYear.SelectedValue = this.SelectedDate.Year.ToString();
            ddlMonth.SelectedValue = this.SelectedDate.Month.ToString();
        }
    }

    protected void ddlYear_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetToDay();
    }
    protected void ddlMonth_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetToDay();
    }
    
    //protected void ObjectDataSource1_Selected(object sender, ObjectDataSourceStatusEventArgs e)
    //{
    //    ddlYear.SelectedValue = Calendar1.TodaysDate.Year.ToString();
    //    ddlMonth.SelectedValue = Calendar1.TodaysDate.Month.ToString();
    //}
}
