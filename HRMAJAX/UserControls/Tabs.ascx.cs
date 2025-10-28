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

public partial class UserControls_Tabs : System.Web.UI.UserControl
{

    public event EventHandler TabItemClick;
    public event EventHandler TabLoad;
    public event EventHandler BackClick;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            OnTabLoad(e);
            //MenuTabs.Items[0].Selected = true;
        }
    }
    public Menu SourceTab
    {
        get { return MenuTabs; }
    }

    public bool ImageVisible
    {
        set { imgBack.Visible = value; }
    }

    void OnTabItemClick(EventArgs e)
    {
        if (TabItemClick != null)
        {
            TabItemClick(this, e);

        }
    }
    void OnTabLoad(EventArgs e)
    {
        if (TabLoad != null)
        {
            TabLoad(this, e);
        }
    }
    void OnBackClick(EventArgs e)
    {
        if (BackClick != null)
        {
            BackClick(this, e);
        }
    }
    protected void MenuTabs_MenuItemClick(object sender, MenuEventArgs e)
    {
        OnTabItemClick(e);
    }
    protected void imgBack_Click(object sender, ImageClickEventArgs e)
    {
        if (BackClick != null)
        {
            OnBackClick(e);
        }
    }
}
