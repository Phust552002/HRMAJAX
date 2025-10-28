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

public partial class UserControls_ActionMenu : System.Web.UI.UserControl
{

    public event EventHandler MenuItemClick;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void OnMenuItemClick(EventArgs e)
    {
        if (MenuItemClick != null)
        {
            MenuItemClick(this, e);
        }
    }

    public void BindMenu(MenuItemCollection items)
    {
        MenuItem parent = Menu1.Items[0];
        foreach(MenuItem item in items)
        {
            parent.ChildItems.Add(item);
        }
        Menu1.DataBind();
    }
    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        OnMenuItemClick(e);        
    }
}
