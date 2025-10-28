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

public partial class UserControls_ListBoxEmployee : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindingDataToDepartment();
            BindingData();
        }
    }

    private void BindingDataToDepartment()
    {

        ddlDepartment.DataSource = DepartmentsBLL.GetAllRoots();
        ddlDepartment.DataTextField = "DepartmentName";
        ddlDepartment.DataValueField = "DepartmentId";
        ddlDepartment.DataBind();
    }

    public string SelectedItems
    {
        get
        {
            string ids = ",";
            for (int i = 0; i < lstSelectedEmployees.Items.Count; i++)
            {
                ListItem item = lstSelectedEmployees.Items[i];
                ids += item.Value + ",";

            }

            return ids;
        }
    }

    public void BindingData()
    {
        lstEmployees.DataSource = EmployeesBLL.GetByDeptIds("", int.Parse(ddlDepartment.SelectedValue), txtName.Text,"", "");
        lstEmployees.DataTextField = "FullName";
        lstEmployees.DataValueField = "UserId";
        lstEmployees.DataBind();
    }

    public ListBox ListSelectedEmployees
    {
        get
        {
            return lstSelectedEmployees;
        }
    }
    public ListBox ListEmployees
    {
        get
        {
            return lstEmployees;
        }
    }

    private void MoveItem(ListBox listFrom, ListBox listTo)
    {
        ListItemCollection lstItemFrom = listFrom.Items;
        foreach (ListItem item in lstItemFrom)
        {
            if (item.Selected)
            {
                listTo.Items.Add(item);
            }
        }

        ListItemCollection lstItemTo = listTo.Items;
        foreach (ListItem item in lstItemTo)
        {
            listFrom.Items.Remove(item);
        }
    }

    protected void btnSelect_Click(object sender, EventArgs e)
    {
        MoveItem(lstEmployees, lstSelectedEmployees);
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        MoveItem(lstSelectedEmployees, lstEmployees);
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        BindingData();
        MoveItem(lstEmployees, lstSelectedEmployees);
    }
}
