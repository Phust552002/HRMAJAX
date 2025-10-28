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

public partial class PMember_PMemberQuality : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "Chất lượng Đảng viên";
            BindDataToDDLYear();
           

        }
    }

    private int UserId
    {
        get
        {
            if (ViewState["UserId"] == null)
                return 0;
            else
                return int.Parse(ViewState["UserId"].ToString());
        }
        set
        {
            if (ViewState["UserId"] == null)
                ViewState["UserId"] = value;
        }
    }
    private int TypePage
    {
        get
        {
            if (ViewState["TypePage"] == null)
                return 0;
            else
                return int.Parse(ViewState["TypePage"].ToString());
        }
        set
        {
            ViewState["TypePage"] = value;
        }
    }

    private int PageIndex
    {
        get
        {
            if (ViewState["PageIndex"] == null)
                return 0;
            else
                return int.Parse(ViewState["PageIndex"].ToString());
        }
        set
        {
            if (ViewState["PageIndex"] == null)
                ViewState["PageIndex"] = value;
        }
    }

    private int DepartmentId
    {
        get
        {
            if (ViewState["DepartmentId"] == null)
                return 0;
            else
                return int.Parse(ViewState["DepartmentId"].ToString());
        }
        set
        {
            if (ViewState["DepartmentId"] == null)
                ViewState["DepartmentId"] = value;
        }
    }


    private void BindDataToDDLYear()
    {

        ddlYear.DataSource = PMembersBLL.GetYearQuality();
        ddlYear.DataTextField = "Year";
        ddlYear.DataValueField = "Year";
        ddlYear.DataBind();
    }

    
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
        //    int status = int.Parse(ddlStatus.SelectedValue);
        //    UserId = int.Parse(ddlEmployees.SelectedValue);
        //    PMembersBLL.Add(UserId, cpDateJoinP.SelectedDate, cpDateJoinPOfficial.SelectedDate, txtPlaceJoinP.Text, txtPCardNo.Text, status);
        }
        catch (HRMException he)
        {
            UcTitle1.ErrorText = he.Message;
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        int year = int.Parse(ddlYear.SelectedValue.ToString());
        DataTable dtPMembersQuality = PMembersBLL.GetPMembersQualityByYear(year);
        grdEmployeesList.DataSource = dtPMembersQuality;
        grdEmployeesList.DataBind();
    }

    protected void btnExport_Click(object sender, EventArgs e)
    {
        int year = int.Parse(ddlYear.SelectedValue.ToString());
        DataTable dtPMembersQuality = PMembersBLL.GetPMembersQualityByYear(year);
        ExportQualityPMembers(dtPMembersQuality);
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/PMember/PMemberList.aspx");
    }
   
    private void ExportQualityPMembers(DataTable dt)
    {

        Response.Clear();
        Response.AddHeader("content-disposition", "attachment;filename=ChatLuongDangVien.xls");
        Response.ContentType = "application/ms-excel";
        Response.ContentEncoding = System.Text.Encoding.Unicode;
        Response.BinaryWrite(System.Text.Encoding.Unicode.GetPreamble());
        string tab = "";
        foreach (DataColumn dc in dt.Columns)
        {
            Response.Write(tab + dc.ColumnName);
            tab = "\t";
        }
        Response.Write("\n");
        int i;
        foreach (DataRow dr in dt.Rows)
        {
            tab = "";
            for (i = 0; i < dt.Columns.Count; i++)
            {
                Response.Write(tab + dr[i].ToString());
                tab = "\t";
            }
            Response.Write("\n");
        }
        Response.End();
    }
}