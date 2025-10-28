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

public partial class UserControls_ucMessageError : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public HyperLink SuccessfulLink
    {
        get { return lnkSuccessful; }
    }
    public string ErrorText
    {
        get { return lbError.Text; }
        set { lbError.Text = value; }
    }
}
