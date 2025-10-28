using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Recruitment_Location : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            UcTitle1.Text = "CHỌN ĐỊA ĐIỂM LÀM VIỆC";
        }

    }
    protected void btnSelectLocation_Click(object sender, EventArgs e)
    {
        if (checkValidate())
        {
            if (chkDAD.Checked)
            {
                Response.Redirect("~/Recruitment/Registration.aspx");

            }
            else if (chkSGN.Checked)
            {
                Response.Redirect("~/Recruitment/Registration.aspx");
            }
        }

    }

    private bool checkValidate()
    {
        if (chkDAD.Checked == false && chkSGN.Checked == false)
        {
            lbResult.Text = "VUI LÒNG CHỌN ĐỊA ĐIỂM LÀM VIỆC";
            return false;
        }
        else if (chkDAD.Checked == true && chkSGN.Checked == true)
        {
            lbResult.Text = "VUI LÒNG CHỈ CHỌN MỘT(01) ĐỊA ĐIỂM LÀM VIỆC";
            return false;
        }
        else 
        {
            return true;
        }


    }
}