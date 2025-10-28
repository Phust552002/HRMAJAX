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

public partial class UserControls_TabSub : System.Web.UI.UserControl
{
    public event EventHandler TabSubItemClick;
    public event EventHandler TabSubLoad;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            OnTabSubLoad(e);
            //MenuTabs.Items[0].Selected = true;
        }
    }
    public Menu SourceTabSub
    {
        get { return MenuTabs; }
    }


    void OnTabSubItemClick(EventArgs e)
    {
        if (TabSubItemClick != null)
        {
            TabSubItemClick(this, e);

        }
    }
    void OnTabSubLoad(EventArgs e)
    {
        if (TabSubLoad != null)
        {
            TabSubLoad(this, e);
        }
    }

    protected void MenuTabSub_MenuItemClick(object sender, MenuEventArgs e)
    {
        OnTabSubItemClick(e);
    }
}
