using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using HRMBLL.H0;


public partial class Admin_UserControls_ucListBoxUsers : System.Web.UI.UserControl
{


    public event EventHandler ControlLoad;
    public event EventHandler ButtonAddClick;
    public event EventHandler ButtonRemoveClick;

    void OnButtonAddClick(EventArgs e)
    {
        if (ButtonAddClick != null)
        {
            ButtonAddClick(this, e);

        }
    }

    void OnButtonRemoveClick(EventArgs e)
    {
        if (ButtonRemoveClick != null)
        {
            ButtonRemoveClick(this, e);

        }
    }


    public int DepartmentId
    {
        get
        {
            if (ViewState["DepartmentId"] != null)
            {
                return int.Parse(ViewState["DepartmentId"].ToString());
            }
            else
            {
                return 0;
            }
        }
        set { ViewState["DepartmentId"] = value; }
    }

    public string DepartmentIds
    {
        get 
        {
            if (ViewState["DepartmentIds"] != null)
            {
                return ViewState["DepartmentIds"].ToString();
            }
            else
            {
                return string.Empty;
            }
        }
        set { ViewState["DepartmentIds"] = value; }
    }


    protected void Page_Load(object sender, EventArgs e)
    {       
        OnControlLoad(e);
        UcDepartmentFilter1.ViewButtonClick += new EventHandler(UcDepartmentFilter1_ViewButtonClick);
    }

    void UcDepartmentFilter1_ViewButtonClick(object sender, EventArgs e)
    {
        lstEmployees.DataSource = EmployeesBLL.GetByStatus(UcDepartmentFilter1.FullName, 2);//EmployeesBLL.GetEmployeeDeptPositionByFilter(UcDepartmentFilter1.DepartmentId, UcDepartmentFilter1.FullName);
        lstEmployees.DataTextField = "FullName";
        lstEmployees.DataValueField = "UserId";
        lstEmployees.DataBind();
        BindDataToSelectedListBox();
    }

    void OnControlLoad(EventArgs e)
    {
        if (ControlLoad != null)
        {
            ControlLoad(this, e);
        }
    }

    public DropDownList DDLDepartment
    {
        get { return UcDepartmentFilter1.DDLDepartment; }
    }
    public Label LBDepartment
    {
        get { return UcDepartmentFilter1.LBDepartment; }
    }
    
    public string SelectedItems
    {
        get
        {
            string ids = string.Empty;
            for (int i = 0; i < lstSelectedEmployees.Items.Count; i++)
            {
                ListItem item = lstSelectedEmployees.Items[i];
                if (i == lstSelectedEmployees.Items.Count - 1)
                {
                    ids += item.Value;
                }
                else
                {
                    ids += item.Value + ",";
                }
            }

            return ids;
        }
    }

    public string UnSelectedItems
    {
        get
        {
            string ids = string.Empty;
            for (int i = 0; i < lstEmployees.Items.Count; i++)
            {
                ListItem item = lstEmployees.Items[i];
                if (i == lstEmployees.Items.Count - 1)
                {
                    ids += item.Value;
                }
                else
                {
                    ids += item.Value + ",";
                }
            }

            return ids;
        }
    }

    public void ClearSelectedListBox()
    {
        lstSelectedEmployees.Items.Clear();
    }

    protected void btnSelect_Click(object sender, EventArgs e)
    {
        MoveItem(lstEmployees, lstSelectedEmployees);
        OnButtonAddClick(e);
    }
    protected void btnRemove_Click(object sender, EventArgs e)
    {
        MoveItem(lstSelectedEmployees, lstEmployees);
        OnButtonRemoveClick(e);
    }

    public void setDefaultValues()
    {
        //List<GroupUserBLL> list = GroupUserBLL.GetGroupUserByGroupId(GroupId);
        //lstSelectedEmployees.DataSource = list;
        //lstSelectedEmployees.DataTextField = "FullName";
        //lstSelectedEmployees.DataValueField = "UserId";
        //lstSelectedEmployees.DataBind();

        //foreach (ListItem item in lstSelectedEmployees.Items)
        //{
        //    lstEmployees.Items.Remove(item);
        //}
    }

    public void BindData()
    {
        UcDepartmentFilter1.BindDataToDDLDepartment();        
    }

    public void BindDataToListBox()
    {

        lstEmployees.DataSource = EmployeesBLL.GetByStatus(UcDepartmentFilter1.FullName, 2);//GetEmployeeDeptPositionByFilter(UcDepartmentFilter1.DepartmentId, UcDepartmentFilter1.FullName);
        lstEmployees.DataTextField = "FullName";
        lstEmployees.DataValueField = "UserId";
        lstEmployees.DataBind();    
    }

    public void BindDataToSelectedListBox()
    {

        lstSelectedEmployees.DataSource = EmployeesBLL.GetByDeptIds(DepartmentIds, 0, string.Empty, string.Empty, "");
        lstSelectedEmployees.DataTextField = "FullName";
        lstSelectedEmployees.DataValueField = "UserId";
        lstSelectedEmployees.DataBind();

        ListItemCollection lstItem = lstSelectedEmployees.Items;
        foreach (ListItem item in lstItem)
        {
            lstEmployees.Items.Remove(item);
        }
        lstSelectedEmployees.Items.Clear();
        lstSelectedEmployees.DataSource = EmployeesBLL.GetByDeptId(DepartmentId);
        lstSelectedEmployees.DataTextField = "FullName";
        lstSelectedEmployees.DataValueField = "UserId";
        lstSelectedEmployees.DataBind();
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
    
}
