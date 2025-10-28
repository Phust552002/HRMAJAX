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

public partial class Income_ListMonthlyStaffIncomes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            AddDataToCboYear();

        }
    }
    protected void odsEmployeeIncomes_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["departmentId"] = int.Parse(cboDepartment.SelectedValue);
        e.InputParameters["date"] = new DateTime(int.Parse(cboYears.SelectedValue), int.Parse(cboMonths.SelectedValue), 1);
        e.InputParameters["fullName"] = txtFullName.Text.Trim(); ;

    }

    private void AddDataToCboYear()
    {
        for (int i = 2000; i <= DateTime.Now.Year; i++)
        {
            ListItem item = new ListItem(i.ToString(), i.ToString());
            cboYears.Items.Add(item);
        }
        if (DateTime.Now.Month == 1)
        {
            cboMonths.SelectedValue = Convert.ToString(12);
            cboYears.SelectedValue = Convert.ToString(DateTime.Now.Year - 1);
        }
        else
        {
            cboMonths.SelectedValue = Convert.ToString(DateTime.Now.Month - 1);
            cboYears.SelectedValue = DateTime.Now.Year.ToString();
        }
    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        grdListMonthlyStaffIncomes.DataBind();
    }
}
