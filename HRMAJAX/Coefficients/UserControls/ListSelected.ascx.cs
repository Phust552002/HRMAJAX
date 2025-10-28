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
using HRMBLL.H1;

public partial class UserControls_ListSelected : System.Web.UI.UserControl
{

    private int _CoefficientNameId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindControl();
            setDefaultValues();
        }
    }

    public string SelectedItems
    {
        get
        {
            string ids = string.Empty;
            for(int i = 0; i < lstSelectedPositions.Items.Count; i++)
            {
                ListItem item = lstSelectedPositions.Items[i];
                if (i == lstSelectedPositions.Items.Count - 1)
                {
                    ids += item.Value ;
                }
                else
                {
                    ids += item.Value + ",";
                }
            }

            return ids;
        }
    }

    public int CoefficientNameId
    {
        get { return _CoefficientNameId; }
        set { _CoefficientNameId = value; }
    }

    public void setDefaultValues()
    {
        List<CoefficientNamePositionsBLL> list = CoefficientNamePositionsBLL.GetByNameId(CoefficientNameId);
        lstSelectedPositions.DataSource = list;
        lstSelectedPositions.DataTextField = "PositionName";
        lstSelectedPositions.DataValueField = "PositionId";
        lstSelectedPositions.DataBind();

        foreach (ListItem item in lstSelectedPositions.Items)
        {
            lstAllPositions.Items.Remove(item);
        }
    }

    private void BindControl()
    {
        lstAllPositions.DataSource = PositionsBLL.GetAll();
        lstAllPositions.DataTextField = "PositionName";
        lstAllPositions.DataValueField = "PositionId";
        lstAllPositions.DataBind();        
    }


    protected void AddUser(object sender, EventArgs e)
    {

        MoveItem(lstAllPositions, lstSelectedPositions);

    }
    protected void RemoveUser(object sender, EventArgs e)
    {
        MoveItem(lstSelectedPositions, lstAllPositions);
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
