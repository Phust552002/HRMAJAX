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

using HRMBLL.H2;
using HRMUtil;

public partial class Recruitment_Category_EducationLevel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text =Constants.TITLE_EDUCATION_LEVEL_CATEGORY;
        }

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            EducationLevelsBLL el = new EducationLevelsBLL();

            el.Name = txtName.Text;
            el.Remark = txtDescription.Text;

            el.Save();
            grdEducationLevel.DataBind();
        }
        catch (HRMException ex)
        {
            UcTitle1.ErrorText = ex.Message;
        }
    }
    protected void chkHideAddEducationLevel_CheckedChanged(object sender, EventArgs e)
    {
        pnlAddEducationLevel.Visible = chkHideAddEducationLevel.Checked;
    }
}
