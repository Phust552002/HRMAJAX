using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


using HRMBLL.H1;
using HRMBLL.H1.Helper;
using HRMBLL.H0;
using HRMUtil;
using HRMUtil.KeyNames.H1;

public partial class Workdays_WorkdayOverTimeDetail : System.Web.UI.Page
{


    private double _LamthemNTbngay = 0;
    private double _LamthemCNbngay = 0;
    private double _LamthemLTbngay = 0;
    private double _LamthemNTbdem = 0;
    private double _LamthemCNbdem = 0;
    private double _LamthemLTbdem = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            UcTitle1.Text = "CHẤM ĐIỂM MỨC ĐỘ HOÀN THÀNH CÔNG VIỆC";

            UserId = int.Parse(Request.QueryString["uId"]);
            Month = int.Parse(Request.QueryString["m"]);
            Year = int.Parse(Request.QueryString["y"]);
            DepartmentId = int.Parse(Request.QueryString["d"]);
            PageIndex = int.Parse(Request.QueryString["p"]);

            DisplayPersonalInformation();
            BindWorkdayOverTime();
        }
    }

    #region private properties

    private int UserId
    {
        get
        {
            if (ViewState["UserId"] != null)
            {
                return int.Parse(ViewState["UserId"].ToString());
            }
            else
            {
                return 0;
            }
        }
        set
        {
            ViewState["UserId"] = value;
        }
    }
    private int Month
    {
        get
        {
            if (ViewState["Month"] != null)
            {
                return int.Parse(ViewState["Month"].ToString());
            }
            else
            {
                return 0;
            }
        }
        set
        {
            ViewState["Month"] = value;
        }
    }
    private int Year
    {
        get
        {
            if (ViewState["Year"] != null)
            {
                return int.Parse(ViewState["Year"].ToString());
            }
            else
            {
                return 0;
            }
        }
        set
        {
            ViewState["Year"] = value;
        }
    }

    private string OverTimeIds
    {
        get
        {
            if (ViewState["OverTimeIds"] != null)
            {
                return ViewState["OverTimeIds"].ToString();
            }
            else
            {
                return string.Empty;
            }
        }
        set
        {
            ViewState["OverTimeIds"] = value;
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
        set
        {
            ViewState["DepartmentId"] = value;
        }
    }
    private int PageIndex
    {
        get
        {
            if (ViewState["PageIndex"] != null)
            {
                return int.Parse(ViewState["PageIndex"].ToString());
            }
            else
            {
                return 0;
            }
        }
        set
        {
            ViewState["PageIndex"] = value;
        }
    }

    #endregion

    private void DisplayPersonalInformation()
    {
        EmployeesBLL objUser = EmployeesBLL.GetEmployeeById(UserId);

        lbFullName.Text = objUser.FullName;
        lbDepartment.Text = objUser.DepartmentFullName;
    }

    #region insert dlWorkdayOverTime

    public void BindWorkdayOverTime()
    {

        List<WorkdayOverTimeBLL> list = WorkdayOverTimeBLL.GetByFilter(UserId, "", new DateTime(Year, Month, 1));
        if (list.Count == 0)
        {
            WorkdayOverTimeBLL obj1 = new WorkdayOverTimeBLL();
            obj1.OverTimeId = 0;
            obj1.OverTimeDate = new DateTime(Year, Month, 1);
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        dlWorkdayOverTime.DataSource = list;
        dlWorkdayOverTime.DataBind();
    }

    protected void dlWorkdayOverTime_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        DataListItem item = e.Item;
        if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
        {

            WorkdayOverTimeBLL obj = (WorkdayOverTimeBLL)e.Item.DataItem;

            DropDownList ddlOverTimeType = (DropDownList)item.FindControl("ddlOverTimeType");
            ddlOverTimeType.ToolTip = obj.OverTimeId.ToString();
            ddlOverTimeType.SelectedValue = obj.OverTimeType;

            UserControls_CalendarPicker cpOverTimeDate = (UserControls_CalendarPicker)item.FindControl("cpOverTimeDate");
            cpOverTimeDate.SelectedDate = obj.OverTimeDate;

            TextBox txtOverTimeHours = (TextBox)item.FindControl("txtOverTimeHours");
            txtOverTimeHours.Text = obj.OverTimeHours.ToString();

            TextBox txtOverTimeRemark = (TextBox)item.FindControl("txtOverTimeRemark");
            txtOverTimeRemark.Text = obj.OverTimeRemark;


            ImageButton imgAddNewRow = (ImageButton)item.FindControl("imgAddNewRow");
            ImageButton imgDeleteRow = (ImageButton)item.FindControl("imgDeleteRow");
            if (item.ItemIndex == obj.LastItem - 1)
            {
                imgAddNewRow.Visible = true;
            }
            else
            {
                imgAddNewRow.Visible = false;
            }


            imgDeleteRow.OnClientClick = "return confirm('Bạn có muốn xóa thông tin dòng này ?');";
            if (obj.LastItem <= 1)
            {
                imgDeleteRow.Visible = false;
            }
            else
            {
                imgDeleteRow.Visible = true;
            }
        }
    }

    protected void imgDeleteRowdlWorkdayOverTime_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton imgDeleteRow = (ImageButton)sender;
        DataListItem itemSelected = (DataListItem)imgDeleteRow.Parent;
        DropDownList ddlOverTimeType_JobSelected = (DropDownList)itemSelected.FindControl("ddlOverTimeType");

        ////////////////////////////////////////////////////////////////////////////////////////////
        int Id = ddlOverTimeType_JobSelected.ToolTip.Length == 0 ? 0 : int.Parse(ddlOverTimeType_JobSelected.ToolTip);
        if (Id > 0)
        {
            if (OverTimeIds.Length <= 0)
            {
                OverTimeIds = Id.ToString();
            }
            else
            {
                OverTimeIds = OverTimeIds + "," + Id.ToString();
            }
        }

        List<WorkdayOverTimeBLL> list = new List<WorkdayOverTimeBLL>();
        foreach (DataListItem item in dlWorkdayOverTime.Items)
        {

            DropDownList ddlOverTimeType = (DropDownList)item.FindControl("ddlOverTimeType");

            if (!ddlOverTimeType.ClientID.Equals(ddlOverTimeType_JobSelected.ClientID))
            {
                WorkdayOverTimeBLL obj = new WorkdayOverTimeBLL();

                obj.OverTimeId = int.Parse(ddlOverTimeType.ToolTip);
                obj.OverTimeType = ddlOverTimeType.SelectedValue;

                UserControls_CalendarPicker cpOverTimeDate = (UserControls_CalendarPicker)item.FindControl("cpOverTimeDate");
                obj.OverTimeDate = cpOverTimeDate.SelectedDate;

                TextBox txtOverTimeHours = (TextBox)item.FindControl("txtOverTimeHours");
                obj.OverTimeHours = txtOverTimeHours.Text.Trim().Length <= 0 ? 0 : double.Parse(txtOverTimeHours.Text.Trim());

                TextBox txtOverTimeRemark = (TextBox)item.FindControl("txtOverTimeRemark");
                obj.OverTimeRemark = txtOverTimeRemark.Text;


                obj.LastItem = dlWorkdayOverTime.Items.Count - 1;

                list.Add(obj);
            }
        }
        dlWorkdayOverTime.DataSource = list;
        dlWorkdayOverTime.DataBind();
    }

    protected void imgAddNewRowdlWorkdayOverTime_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton imgAddNewRowRouting = (ImageButton)sender;
        DataListItem itemBaggageRouting = (DataListItem)imgAddNewRowRouting.Parent;

        List<WorkdayOverTimeBLL> list = new List<WorkdayOverTimeBLL>();
        foreach (DataListItem item in dlWorkdayOverTime.Items)
        {
            WorkdayOverTimeBLL obj = new WorkdayOverTimeBLL();

            DropDownList ddlOverTimeType = (DropDownList)item.FindControl("ddlOverTimeType");

            obj.OverTimeId = int.Parse(ddlOverTimeType.ToolTip);
            obj.OverTimeType = ddlOverTimeType.SelectedValue;

            UserControls_CalendarPicker cpOverTimeDate = (UserControls_CalendarPicker)item.FindControl("cpOverTimeDate");
            obj.OverTimeDate = cpOverTimeDate.SelectedDate;

            TextBox txtOverTimeHours = (TextBox)item.FindControl("txtOverTimeHours");
            obj.OverTimeHours = txtOverTimeHours.Text.Trim().Length <= 0 ? 0 : double.Parse(txtOverTimeHours.Text.Trim());

            TextBox txtOverTimeRemark = (TextBox)item.FindControl("txtOverTimeRemark");
            obj.OverTimeRemark = txtOverTimeRemark.Text;


            obj.LastItem = dlWorkdayOverTime.Items.Count + 1;
            list.Add(obj);
        }
        WorkdayOverTimeBLL obj1 = new WorkdayOverTimeBLL();
        obj1.OverTimeId = 0;
        obj1.OverTimeDate = new DateTime(Year, Month, 1);
        obj1.LastItem = list.Count + 1;
        list.Add(obj1);
        dlWorkdayOverTime.DataSource = list;
        dlWorkdayOverTime.DataBind();

    }

    private void SaveOverTime()
    {
        if (OverTimeIds.Length > 0)
        {
            WorkdayOverTimeBLL.Delete(OverTimeIds);
            OverTimeIds = string.Empty;
        }

        _LamthemNTbngay = 0;
        _LamthemCNbngay = 0;
        _LamthemLTbngay = 0;
        _LamthemNTbdem = 0;
        _LamthemCNbdem = 0;
        _LamthemLTbdem = 0;

        foreach (DataListItem item in dlWorkdayOverTime.Items)
        {

            DropDownList ddlOverTimeType = (DropDownList)item.FindControl("ddlOverTimeType");

            int OverTimeId = int.Parse(ddlOverTimeType.ToolTip);
            string OverTimeType = ddlOverTimeType.SelectedValue;

            UserControls_CalendarPicker cpOverTimeDate = (UserControls_CalendarPicker)item.FindControl("cpOverTimeDate");
            DateTime OverTimeDate = cpOverTimeDate.SelectedDate;

            TextBox txtOverTimeHours = (TextBox)item.FindControl("txtOverTimeHours");
            double OverTimeHours = txtOverTimeHours.Text.Trim().Length <= 0 ? 0 : double.Parse(txtOverTimeHours.Text.Trim());

            TextBox txtOverTimeRemark = (TextBox)item.FindControl("txtOverTimeRemark");
            string OverTimeRemark = txtOverTimeRemark.Text;



            if (OverTimeId == 0)
            {
                WorkdayOverTimeBLL.Insert(UserId, OverTimeType, OverTimeHours, OverTimeDate, OverTimeRemark, UcPermission1.UserId, DateTime.Now);
            }
            else
            {
                WorkdayOverTimeBLL.Update(UserId, OverTimeType, OverTimeHours, OverTimeDate, OverTimeRemark, UcPermission1.UserId, DateTime.Now, OverTimeId);
            }

            if (OverTimeType == "LTNTBN")
            {
                _LamthemNTbngay = _LamthemNTbngay + OverTimeHours;
            }
            else if (OverTimeType == "LTNTBD")
            {
                _LamthemNTbdem = _LamthemNTbdem + OverTimeHours;
            }
            else if (OverTimeType == "LTCNBN")
            {
                _LamthemCNbngay = _LamthemCNbngay + OverTimeHours;
            }
            else if (OverTimeType == "LTCNBD")
            {
                _LamthemCNbdem = _LamthemCNbdem + OverTimeHours;
            }
            else if (OverTimeType == "LTLTBN")
            {
                _LamthemLTbngay = _LamthemLTbngay + OverTimeHours;
            }
            else if (OverTimeType == "LTLTBD")
            {
                _LamthemLTbdem = _LamthemLTbdem + OverTimeHours;
            }

            WorkdayCoefficientEmployeesFinalBLL.UpdateForOverTime(UserId, Month, Year, _LamthemNTbngay, _LamthemCNbngay, _LamthemLTbngay, _LamthemNTbdem, _LamthemCNbdem, _LamthemLTbdem);
            WorkdayEmployeesBLL.UpdateForOverTime(UserId, Month, Year, _LamthemNTbngay, _LamthemCNbngay, _LamthemLTbngay, _LamthemNTbdem, _LamthemCNbdem, _LamthemLTbdem);
        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        try 
        {
            SaveOverTime();
            BackRedirect();
        }
        catch (HRMException he) { UcTitle1.ErrorText = he.Message; }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        BackRedirect();
    }

    private void BackRedirect()
    {

        Response.Redirect("~/Workdays/WorkdayOverTimeList.aspx?m=" + Month + "&y=" + Year + "&d=" + DepartmentId + "&p=" + PageIndex);


    }

    #endregion
}