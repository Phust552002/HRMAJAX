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

public partial class UserControls_Common_ucDepartmentFilter : System.Web.UI.UserControl
{
    public event EventHandler ViewButtonClick;
    public event EventHandler ControlLoad;

    protected void Page_Load(object sender, EventArgs e)
    {
        OnControlLoad(e);
    }
    public DropDownList DDLDepartment
    {
        get { return DropDownList1; }
    }

    public Label LBDepartment
    {
        get { return lbDepartment; }
    }

    //public bool VisibleImageAdd
    //{
    //    set { lnkAddUser.Visible = value; }
    //}

    void OnControlLoad(EventArgs e)
    {
        if (ControlLoad != null)
        {
            ControlLoad(this, e);

        }
    }

    void OnViewButtonClick(EventArgs e)
    {
        if (ViewButtonClick != null)
        {
            ViewButtonClick(this, e);
            
        }
    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        OnViewButtonClick(e);
    }

    public int DepartmentId
    {
        get 
        {
            if (DropDownList1.SelectedValue.Trim().Length > 0)
            {
                return Convert.ToInt32(DropDownList1.SelectedValue);
            }
            else
            {
                return 0;
            }
            
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
    public void BindDataToDDLDepartment()
    {

        DropDownList1.DataSource = DepartmentsBLL.GetAllRoots();
        DropDownList1.DataTextField = "DepartmentName";
        DropDownList1.DataValueField = "DepartmentId";
        DropDownList1.DataBind();
    }
}
