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

public partial class UserControls_CalendarPicker : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public bool Enabled
    {
        set
        {
            txtDate.Enabled = value;
            //Image1.Visible = value;
        }
    }

    public string SelectedVNDate
    {
        get { return txtDate.Text; }
        set { txtDate.Text = value; }
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
            string[] arr = txtDate.Text.Split('/');

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
                return HRMUtil.FormatDate.GetSQLDateMinValue;
            }
        }
        set
        {
            if (value.Equals(HRMUtil.FormatDate.GetSQLDateMinValue))
            {
                txtDate.Text = string.Empty;
            }
            else
            {
                txtDate.Text = value.ToString("dd/MM/yyyy");
            }
        }
    }

    
}
