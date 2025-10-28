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

using HRMUtil;

public partial class UserControls_MessageError : System.Web.UI.UserControl
{
    private HRMException _HRMException;
    private string _FormatString;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    public HyperLink SuccessfulLink
    {
        get { return lnkSuccessful; }
    }

    private XMLFile XML
    {
        get
        {
            XMLFile xml = new XMLFile(Server.MapPath(@"~\App_Data\XML\MessageErrors.xml"));
            return xml;
        }
    }

    public HRMException HRMExceptions
    {
        get { return _HRMException; }
        set { _HRMException = value; }
    }

    public string FormatString
    {
        get { return _FormatString; }
        set { _FormatString = value; }
    }

    public string ErrorText
    {
        get { return lbError.Text; }
        set { lbError.Text = value; }
    }

    public void DisplayInsertingMessageError()
    {

        lbError.Text = XML.GetInsertingFormatMessageError(HRMExceptions.ErrorCode.ToString(), FormatString);
    }
    public void DisplayUpdatingMessageError()
    {

        lbError.Text = XML.GetUpdatingFormatMessageError(HRMExceptions.ErrorCode.ToString(), FormatString);
    }
    public void DisplayDeletingMessageError()
    {

        lbError.Text = XML.GetDeletingFormatMessageError(HRMExceptions.ErrorCode.ToString(), FormatString);
    }
}
