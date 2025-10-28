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
using HRMBLL.H8;
using System.IO;
using Telerik.Web.UI;

public partial class Covid19_Details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "CẬP NHẬT F0, F1";

            if (Request.QueryString["Id"] != null)
            {
                CovidVictimId = int.Parse(Request.QueryString["Id"]);
                BindDataToDDLEmployee();
                BindDataToDDLF0();
                SetEmployeeInfor();
                btnDelete.Visible = true;
            }
            else
            {
                BindDataToDDLF0();
                BindDataToDDLEmployee();
                btnDelete.Visible = false;
            }
            try
            {
                if (Directory.Exists(Server.MapPath("~/Documents/Covid19/" + "/" + CovidVictimId + "/")))
                {
                    string[] fileCAPaths = Directory.GetFiles(Server.MapPath("~/Documents/Covid19/" + CovidVictimId + "/"));
                    List<ListItem> filesCA = new List<ListItem>();
                    foreach (string fileCAPath in fileCAPaths)
                    {
                        filesCA.Add(new ListItem(System.IO.Path.GetFileName(fileCAPath), fileCAPath));
                    }
                    gvCorrectiveActionAttachments.DataSource = filesCA;
                    gvCorrectiveActionAttachments.DataBind();
                }
            }
            catch
            { }
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
    private int CovidVictimId
    {
        get
        {
            if (ViewState["CovidVictimId"] == null)
                return 0;
            else
                return int.Parse(ViewState["CovidVictimId"].ToString());
        }
        set
        {
            if (ViewState["CovidVictimId"] == null)
                ViewState["CovidVictimId"] = value;
        }
    }

    private void BindDataToDDLEmployee()
    {
        string deptIds = WorkDayPrivilegeBLL.GetDepartmentIDsByUserId(UcPermission1.UserId, Constants.WorkdayPrivilege_CV);
        if (UcPermission1.IsAdmin || UcPermission1.IsHRAdmin || UcPermission1.IsHRMember)
        {
            deptIds = "";
        }
        ddlEmployees.DataSource = EmployeesBLL.GetByDeptIdsForDataTable(deptIds, 0, txtFullName.Text, string.Empty);
        ddlEmployees.DataTextField = "FullName";
        ddlEmployees.DataValueField = "UserId";
        ddlEmployees.DataBind();
    }
    private void BindDataToDDLF0()
    {
        ddlF0.DataSource = Covid19BLL.GetByDeptIds("", 0, "", "F0");
        ddlF0.DataTextField = "Info";
        ddlF0.DataValueField = "CovidVictimId";
        ddlF0.DataBind();
    }


    private void SetEmployeeInfor()
    {

        DataRow rv = Covid19BLL.GetCovid19VictimByIdForDataRow(CovidVictimId);
        if (rv != null)
        {
            txtFullName.Enabled = false;
            imgSearchFullName.Enabled = false;
            ddlEmployees.Enabled = false;
            ddlEmployees.SelectedValue = rv["UserId"].ToString();
            ddlType.SelectedValue = rv["Type"].ToString();
            ddlType_SelectedIndexChanged(null, null);
            ddlPlace.SelectedValue = rv["Place"].ToString();
            cpTestContactDate.SelectedDate = (DateTime)rv["Test/ApproachDate"];
            try
            {
                cpQuarantineBeginDate.SelectedDate = (DateTime)rv["QuarantineBeginDate"];
            }
            catch
            { }
            try
            {
                cpQuarantineEndDate.SelectedDate = (DateTime)rv["QuarantineEndDate"];
            }
            catch
            { }
            txtRemarks.Text = rv["Remarks"].ToString();
            try
            {
                DataRow dr = Covid19BLL.GetF0ByCovidVictimId(CovidVictimId);
                if (dr != null)
                {
                    ddlF0.SelectedValue = dr["CovidVictimId"].ToString();
                }
            }
            catch
            { }
        }
    }





    protected void odsEmployees_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        //DepartmentsBLL obj = new DepartmentsBLL();
        //obj.ChildNodeIds = DepartmentId.ToString() + ",";
        //obj.GetAllChildId(DepartmentId);
        //DepartmentIds = obj.ChildNodeIds;

        e.InputParameters["deptIds"] = "";
        e.InputParameters["rootId"] = 0;
        e.InputParameters["fullName"] = txtFullName.Text;
        e.InputParameters["sortParameter"] = string.Empty;
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            UserId = int.Parse(ddlEmployees.SelectedValue);
            int result = Covid19BLL.Save(CovidVictimId, UserId, ddlType.SelectedValue, cpTestContactDate.SelectedDate, cpQuarantineBeginDate.SelectedDate, cpQuarantineEndDate.SelectedDate, txtRemarks.Text, Convert.ToInt32(ddlPlace.SelectedValue));
            if (result > 0)
            {
                CovidVictimId = result;
                if (!Directory.Exists(Server.MapPath("~/Documents/Covid19/" + CovidVictimId + "/")))
                    Directory.CreateDirectory(Server.MapPath("~/Documents/Covid19/" + CovidVictimId + "/"));
                foreach (UploadedFile f in rauCorrectiveActionAttachments.UploadedFiles)
                {
                    f.SaveAs(Server.MapPath("~/Documents/Covid19/" + CovidVictimId + "/") + CovidVictimId + "_" + f.GetName(), true);
                }
                try
                {
                    Covid19BLL.SaveApproach(UserId, Convert.ToInt32(ddlF0.SelectedValue), txtRemarks.Text, cpTestContactDate.SelectedDate, CovidVictimId);
                }
                catch
                { }
            }
            Response.Redirect("~/Covid19/VictimList.aspx");
        }
        catch (HRMException he)
        {
            UcTitle1.ErrorText = he.Message;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Covid19/VictimList.aspx");
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Covid19BLL.Delete(CovidVictimId);
        try
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Server.MapPath("~/Documents/Covid19/" + CovidVictimId + "/"));

            if (dir.Exists)
            {
                setAttributesNormal(dir);
                dir.Delete(true);
            }
        }
        catch
        { }
        Response.Redirect("~/Covid19/VictimList.aspx");
    }

    private void setAttributesNormal(DirectoryInfo dir)
    {
        foreach (var subDir in dir.GetDirectories())
            setAttributesNormal(subDir);
        foreach (var file in dir.GetFiles())
        {
            file.Attributes = FileAttributes.Normal;
        }
    }

    protected void imgSearchFullName_Click(object sender, ImageClickEventArgs e)
    {
        ddlEmployees.Items.Clear();
        BindDataToDDLEmployee();
        try
        {
            if (ddlEmployees.Items.Count > 0)
            {
                ddlEmployees.SelectedIndex = 0;
                try
                {
                    EmployeesBLL employee = EmployeesBLL.GetEmployeeById(Convert.ToInt32(ddlEmployees.SelectedValue));

                    lbEmployeeCode.Text = "Mã NV: " + ddlEmployees.SelectedValue + " - " + employee.PositionName + " - " + employee.DepartmentFullName;
                    grdHistory.DataBind();
                }
                catch
                {
                    lbEmployeeCode.Text = "Mã NV: " + ddlEmployees.SelectedValue;
                }
            }
        }
        catch { }
    }

    protected void ddlEmployees_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            EmployeesBLL employee = EmployeesBLL.GetEmployeeById(Convert.ToInt32(ddlEmployees.SelectedValue));
            
            lbEmployeeCode.Text = "Mã NV: " + ddlEmployees.SelectedValue + " - " + employee.PositionName + " - " + employee.DepartmentFullName;
            grdHistory.DataBind();
        }
        catch
        {
            lbEmployeeCode.Text = "Mã NV: " + ddlEmployees.SelectedValue;
        }
    }

    protected void gvCorrectiveActionFileList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            ListItem item = (ListItem)e.Row.DataItem;
            ImageButton btnDel = (ImageButton)e.Row.FindControl("lnkDelete");
            HyperLink lnkFile = (HyperLink)e.Row.FindControl("lnkFile");
            lnkFile.Text = item.Text;
            lnkFile.NavigateUrl = "~/Documents/Covid19/" + CovidVictimId + "/" + item.Text;
            //if (objReport != null)
            //{
            //    if (Convert.ToInt32(Session[Constants.USER_ID_CURRENT].ToString()) != objReport.ResponsiblePersonId)
            //    {
            //        btnDel.Enabled = false;
            //    }
            //}

        }
    }
    protected void DownloadFile(object sender, EventArgs e)
    {
        string filePath = (sender as ImageButton).CommandArgument;
        Response.ContentType = ContentType;
        Response.AppendHeader("Content-Disposition", "attachment; filename=" + System.IO.Path.GetFileName(filePath));
        Response.WriteFile(filePath);
        Response.End();
    }

    protected void DeleteFile(object sender, EventArgs e)
    {
        string filePath = (sender as ImageButton).CommandArgument;
        File.Delete(filePath);
        Response.Redirect(Request.Url.AbsoluteUri);
    }



    protected void grdHistory_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {

            DataRowView dataRow = (DataRowView)e.Row.DataItem;
            //HyperLink lnk = (HyperLink)e.Row.FindControl("lnkFullName");
            //lnk.Text = dataRow["FullName"].ToString();
            //lnk.NavigateUrl = "~/Covid19/Details.aspx?Id=" + dataRow["CovidVictimId"].ToString();

            Label lbTestApproachDate = (Label)row.FindControl("lbTestApproachDate");
            Label lbNew = (Label)row.FindControl("lbNew");
            try
            {
                lbTestApproachDate.Text = FormatDate.FormatVNDate(Convert.ToDateTime(dataRow["Test/ApproachDate"].ToString()));
                if (Convert.ToDateTime(dataRow["Test/ApproachDate"].ToString()) >= DateTime.Now.Date.AddDays(-7))
                {
                    lbNew.Visible = true;
                }
                else
                {
                    lbNew.Visible = false;
                }
            }
            catch
            {

            }
            Label lbPlace = (Label)row.FindControl("lbPlace");
            try
            {

                switch (dataRow["Place"].ToString())
                {
                    case "0":
                        lbPlace.Text = "Chưa xác định";
                        break;
                    case "1":
                        lbPlace.Text = "Địa phương";
                        break;
                    case "2":
                        lbPlace.Text = "Nơi làm việc";
                        break;
                    default:
                        lbPlace.Text = "Chưa xác định";
                        break;
                }
            }
            catch
            {

            }
            Label lbQuarantineBeginDate = (Label)row.FindControl("lbQuarantineBeginDate");
            try
            {
                lbQuarantineBeginDate.Text = FormatDate.FormatVNDate(Convert.ToDateTime(dataRow["QuarantineBeginDate"].ToString()));
            }
            catch
            {

            }
            Label lbEstimatedQuarantineEndDate = (Label)row.FindControl("lbEstimatedQuarantineEndDate");
            try
            {
                if (lbQuarantineBeginDate.Text != "" && dataRow["Type"].ToString() == "F1")
                    lbEstimatedQuarantineEndDate.Text = FormatDate.FormatVNDate(Convert.ToDateTime(dataRow["QuarantineBeginDate"].ToString()).AddDays(14));
            }
            catch
            {

            }
            Label lbQuarantineEndDate = (Label)row.FindControl("lbQuarantineEndDate");
            try
            {
                lbQuarantineEndDate.Text = FormatDate.FormatVNDate(Convert.ToDateTime(dataRow["QuarantineEndDate"].ToString()));
            }
            catch
            {

            }
            if (lbQuarantineEndDate.Text != "")
                row.BackColor = System.Drawing.Color.LightGreen;

        }
    }

    protected void odsHistory_Selected(object sender, ObjectDataSourceStatusEventArgs e)
    {

    }

    protected void odsHistory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        
        e.InputParameters["userId"] = int.Parse(ddlEmployees.SelectedValue);
    }

    protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlType.SelectedValue == "F1")
            trF0.Visible = true;
        else
            trF0.Visible = false;
    }
}