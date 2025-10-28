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
using HRMBLL.BLLHelper;
using HRMUtil;
using HRMBLL.H6;
using System.IO;

public partial class PMember_PMemberLeaveList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "Đảng viên chuyển sinh hoạt";
                     
        }
    }

    private string ImagePath
    {
        get
        {
            return Server.MapPath(@"~\Employee\Images\");
        }
    }

    private int CountClick
    {
        get
        {
            if (ViewState["CountClick"] != null)
                return int.Parse(ViewState["CountClick"].ToString());
            else
                return 0;
        }
        set
        {
            ViewState["CountClick"] = value;
        }
    }


    private int DepartmentId
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

    private string DepartmentIds
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

    private string DepartmentNameSelected
    {
        get
        {
            if (ViewState["DepartmentNameSelected"] != null)
            {
                return ViewState["DepartmentNameSelected"].ToString();
            }
            else
            {
                return string.Empty;
            }
        }
        set { ViewState["DepartmentNameSelected"] = value; }
    }

    

 

    protected void imgSearch_Click(object sender, ImageClickEventArgs e)
    {
        grdEmployeesList.DataBind();
    }


    protected void odsEmployees_Selected(object sender, ObjectDataSourceStatusEventArgs e)
    {
        List<PMembersBLL> list = (List<PMembersBLL>)e.ReturnValue;
        if (list != null)
        {
            UcTitle1.CountRecord = DepartmentNameSelected + " : " + list.Count.ToString();
        }
    }
    protected void odsEmployees_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {


        string departmentIds = DepartmentIds;
        int departmentId = 0;
        string fullname = "";
        fullname = StringFormat.TrimFullName(txtFullName.Text);

        e.InputParameters["deptIds"] = departmentIds;
        e.InputParameters["rootId"] = departmentId;

        e.InputParameters["sortParameter"] = "LevelPosition ASC";

        e.InputParameters["fullName"] = fullname;

    }
    protected void grdEmployeesList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {

            PMembersBLL obj = (PMembersBLL)e.Row.DataItem;
            HyperLink lnk = (HyperLink)e.Row.FindControl("lnkFullName");
            lnk.Text = obj.FullName;

            lnk.NavigateUrl = "~/PMember/PMemberDetail.aspx?Id=" + obj.UserId;

            Image Image1 = (Image)row.FindControl("Image1");

            string userImageURL = ImagePath + StringFormat.GetUserCode(obj.UserId) + ".jpg";

            if (File.Exists(userImageURL))
            {
                Image1.ImageUrl = @"~/Employee/Images/" + StringFormat.GetUserCode(obj.UserId) + ".jpg";
            }
            else
            {
                Image1.ImageUrl = "~/Employee/Images/no_image.gif";
            }
            Label lbSex = (Label)row.FindControl("lbSex");
            if (obj.Sex == 1)
            {
                lbSex.Text = "Nam";
            }
            else
            {
                lbSex.Text = "Nữ";
            }
            Label lbDateJoinP = (Label)row.FindControl("lbDateJoinP");
            if (!obj.DateJoinP.Equals(FormatDate.GetSQLDateMinValue))
            {
                lbDateJoinP.Text = FormatDate.FormatVNDate(obj.DateJoinP);
            }
            Label lbDateJoinPOfficial = (Label)row.FindControl("lbDateJoinPOfficial");
            if (!obj.DateJoinPOfficial.Equals(FormatDate.GetSQLDateMinValue))
            {
                lbDateJoinPOfficial.Text = FormatDate.FormatVNDate(obj.DateJoinPOfficial);
            }
        }
    }
    protected void grdEmployeesList_Sorting(object sender, GridViewSortEventArgs e)
    {
        CountClick = CountClick + 1;

        if (CountClick % 2 == 0)
            e.SortExpression = e.SortExpression + " DESC";
        else
            e.SortExpression = e.SortExpression + " ASC";
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        grdEmployeesList.DataBind();
    }
}