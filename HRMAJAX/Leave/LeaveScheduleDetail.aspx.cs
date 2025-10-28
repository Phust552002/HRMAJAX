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

using HRMBLL.H0;
using HRMUtil.KeyNames.H0;
using HRMUtil;
using HRMBLL.H1;

public partial class Leave_LeaveScheduleDetail : System.Web.UI.Page
{
    int flag = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                UserId = int.Parse(Request.QueryString["Id"]);
                Sid = int.Parse(Request.QueryString["sid"]);
                Page = int.Parse(Request.QueryString["p"]);
                flag = 1;
            }
            catch
            {
                flag = 0;
                Response.Redirect("~/Login.aspx");
            }
            if (flag == 1)
            {
                EmployeesBLL objUser = EmployeesBLL.GetEmployeeById(UserId);

                UcTitle1.Text = "ĐƠN ĐĂNG KÝ NGHỈ PHÉP THỰC TẾ CỦA " + objUser.FullName.ToUpper() + " (Mã nhân viên: " + UserId + ")";
                ChangeDetail();
                Open();
            }
        }
    }

    #region Funcs
    public double GetLeaveDaysV1(DateTime fromDate, DateTime toDate)
    {

        int days = 0;
        DateTime tempFromDate = fromDate;

        while (tempFromDate.CompareTo(toDate) <= 0)
        {
            days++;

            tempFromDate = tempFromDate.AddDays(1);
        }

        List<DateTime> DateRange = GetDateRange(fromDate, toDate);

        int SubDays = (DateRange.Count / 7);

        return (days - SubDays);
    }
    public List<DateTime> GetDateRange(DateTime StartingDate, DateTime EndingDate)
    {
        if (StartingDate > EndingDate)
        {
            return null;
        }
        List<DateTime> rv = new List<DateTime>();
        DateTime tmpDate = StartingDate;
        do
        {
            rv.Add(tmpDate);
            tmpDate = tmpDate.AddDays(1);
        } while (tmpDate <= EndingDate);
        return rv;
    }
    private void ChangeDetail()
    {
        if (UserId != null)
        {
            int TotalLeave = 0;
            int TotalTime = 0;
            int totalLeaveLeft = 0;
            int DayLeft = 0;
            DataRow dr = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetById("", "", Convert.ToInt32(UserId));
            if (dr != null)
            {
                int MaxF = dr == null ? 0 : Convert.ToInt32(dr["MaxF"]);
                int Seniority = dr == null ? 0 : Convert.ToInt32(dr["Seniority"]);

                List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst0 = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByScheduleId(Sid);// HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByFilter("", "", Convert.ToInt32(UserId), 0, "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
                if (lst0 != null)
                {
                    foreach (var item in lst0)
                    {
                        if (item != null)
                        {
                            DayLeft += item.Days;
                        }
                    }

                    txtFullName.Text = lst0[0].FullName;
                    txtDepartmentName.Text = lst0[0].DepartmentName;
                    txtPositionName.Text = lst0[0].PositionName;
                    txtJoinDate.Text = lst0[0].JoinDate.ToString("dd/MM/yyyy");
                    txtMaxF.Text = lst0[0].MaxF.ToString();
                    txtTimes.Text = "3";
                    txtLeft.Text = DayLeft.ToString();
                    TextBox2.Text = TotalTime.ToString();
                    txtLeaveRemain.Text = totalLeaveLeft.ToString();
                    txtTimeRemain.Text = (3 - TotalTime).ToString();
                    txtDays.Text = string.Format("Nghỉ từ ngày {0} đến ngày {1} ({2} ngày)", lst0[0].FromDate.ToString("dd/MM/yyyy"), lst0[0].ToDate.ToString("dd/MM/yyyy"), lst0[0].Days.ToString());

                    txtNghiNgoaiKeHoach.Text = lst0[0].NotInSchedule.ToString();
                    txtPlace.Text = lst0[0].Place;
                }
                else
                {
                    CleanDetail();
                    txtNghiNgoaiKeHoach.Text = "0";
                    txtPlace.Text = "";
                }
                TotalTime += lst0.Count;
                TotalLeave = MaxF + Seniority;
                totalLeaveLeft = MaxF + Seniority - DayLeft;

            }
        }
    }
    private void Open()
    {
        try
        {
            List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst0 = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByScheduleId(Sid);// HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByFilter("", "", Convert.ToInt32(UserId), 0, "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
            if (lst0.Count > 0)
            {
                if (lst0[0].Status > 2 || lst0[0].Status == -1)
                {
                    UpdatePanel3.Visible = true;
                    LinkButton1.Visible = false;
                    lnkSave.Visible = false;
                    //UcTitle1.ErrorText = "Ngày phép đã gửi!";
                }
                else
                {
                    UpdatePanel3.Visible = true;
                    LinkButton1.Visible = true;
                    lnkSave.Visible = true;
                }
            }
        }
        catch
        {
            UcTitle1.ErrorText = "Lỗi trong quá trình lấy dữ liệu";
        }
    }
    private void Close()
    {
        UpdatePanel3.Visible = false;
        LinkButton1.Visible = false;
        lnkSave.Visible = false;
    }
    private void CleanDetail()
    {
        txtFullName.Text = "";
        txtDepartmentName.Text = "";
        txtPositionName.Text = "";
        txtJoinDate.Text = "";
        txtMaxF.Text = "";
        txtTimes.Text = "";
        txtLeft.Text = "";
        TextBox2.Text = "";
        txtLeaveRemain.Text = "";
        txtTimeRemain.Text = "";
        txtDays.Text = "";
        txtNghiNgoaiKeHoach.Text = "";
        txtPlace.Text = "";
    }
    #endregion

    #region Events
    //protected void imgSearch_Click(object sender, EventArgs e)
    //{
    //    UcTitle1.ErrorText = "";
    //    List<EmployeeLeaveScheduleBLL> lst = EmployeeLeaveScheduleBLL.GetByFilter("", "", Convert.ToInt32(ddlFullName.SelectedValue), Convert.ToInt32(ddlTimes.SelectedValue), "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
    //    if (lst.Count > 0)
    //    {
    //        Open();
    //        ChangeDetail();

    //        try
    //        {
    //            List<EmployeeLeaveBLL> lst0 = EmployeeLeaveBLL.GetByScheduleId(lst[0].EmployeeLeaveScheduleId);
    //            if (lst0.Count > 0)
    //            {
    //                btnSave.Visible = true;
    //                lnkSave.Visible = true;
    //                if (lst[0].Status <= 0)
    //                {
    //                    ImageButton1.Visible = true;
    //                    LinkButton1.Visible = true;
    //                    ListBox1.Visible = true;
    //                    ListBox1.Enabled = true;
    //                    List<DepartmentEmployeeBLL> lst1 = DepartmentEmployeeBLL.GetByUserId(UcPermission1.UserCurrent.UserId);
    //                    ListBox1.DataSource = HRMBLL.UserRolesBLL.GetByFilter(15, lst1[0].RootId);
    //                    ListBox1.DataTextField = "FullName";
    //                    ListBox1.DataValueField = "UserId";
    //                    ListBox1.DataBind();
    //                }
    //                else
    //                {
    //                    btnSave.Visible = false;
    //                    lnkSave.Visible = false;

    //                    ImageButton1.Visible = false;
    //                    LinkButton1.Visible = false;
    //                    ListBox1.Visible = false;
    //                    ListBox1.SelectedValue = null;
    //                    ListBox1.Enabled = false;
    //                }
    //            }
    //            else
    //            {
    //                btnSave.Visible = true;
    //                lnkSave.Visible = true;

    //                ImageButton1.Visible = false;
    //                LinkButton1.Visible = false;
    //                ListBox1.Visible = false;
    //                ListBox1.SelectedValue = null;
    //                ListBox1.Enabled = false;
    //            }
    //        }
    //        catch { }
    //    }
    //    else
    //    {
    //        Close();
    //    }
    //}
    //protected void ddlTimes_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    List<EmployeeLeaveScheduleBLL> lst = EmployeeLeaveScheduleBLL.GetByFilter("", "", Convert.ToInt32(ddlFullName.SelectedValue), Convert.ToInt32(ddlTimes.SelectedValue), "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
    //    if (lst.Count > 0)
    //    {
    //        Open();
    //        ChangeDetail();
    //        List<EmployeeLeaveBLL> lst0 = EmployeeLeaveBLL.GetByScheduleId(lst[0].EmployeeLeaveScheduleId);
    //        if (lst0.Count > 0)
    //        {
    //            btnSave.Visible = false;
    //            lnkSave.Visible = false;
    //            if (lst[0].Status == 1)
    //            {
    //                ImageButton1.Visible = true;
    //                LinkButton1.Visible = true;
    //                ListBox1.Visible = true;
    //                ListBox1.Enabled = true;
    //                List<DepartmentEmployeeBLL> lst1 = DepartmentEmployeeBLL.GetByUserId(UcPermission1.UserCurrent.UserId);
    //                ListBox1.DataSource = HRMBLL.UserRolesBLL.GetByFilter(15, lst1[0].RootId);
    //                ListBox1.DataTextField = "FullName";
    //                ListBox1.DataValueField = "UserId";
    //                ListBox1.DataBind();
    //            }
    //        }
    //        else
    //        {
    //            btnSave.Visible = true;
    //            lnkSave.Visible = true;

    //            ImageButton1.Visible = false;
    //            LinkButton1.Visible = false;
    //            ListBox1.Visible = false;
    //            ListBox1.SelectedValue = null;
    //            ListBox1.Enabled = false;
    //        }
    //    }
    //    else
    //    {
    //        Close();
    //    }
    //}
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            UcTitle1.ErrorText = "";
            List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByScheduleId(Sid);
            //List<EmployeeLeaveScheduleBLL> lst = EmployeeLeaveScheduleBLL.GetByFilter("", "", UserId, 0, "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
            if (lst.Count > 0)
            {
                EmployeeLeaveScheduleBLL.UpdateRemark1(lst[0].EmployeeLeaveScheduleId, txtPlace.Text.Trim(), Convert.ToInt32(txtNghiNgoaiKeHoach.Text));
                long Id = EmployeeLeaveBLL.InsertInWeb(UserId, 5, lst[0].FromDate, lst[0].ToDate, lst[0].Days, 0, "Leave Registration", 0, lst[0].EmployeeLeaveScheduleId);
                if (Id != -1)
                {
                    UcTitle1.ErrorText = "Lưu thành công!";

                    LinkButton1.Visible = true;
                    lnkSave.Visible = false;

                    EmployeeLeaveScheduleBLL.UpdateRemark1(lst[0].EmployeeLeaveScheduleId, txtPlace.Text.Trim(), Convert.ToInt32(txtNghiNgoaiKeHoach.Text));
                    EmployeeLeaveBLL.UpdateInWeb(UserId, lst[0].FromDate, lst[0].ToDate, lst[0].Days, "Upd_Leave Registration", lst[0].EmployeeLeaveScheduleId, Convert.ToInt32(Id));
                }
                else
                {
                    
                }
            }
            else
            {
                UcTitle1.ErrorText = "Không có dữ liệu (chưa đăng ký kế hoạch nghỉ phép)!";
            }
            Open();
        }
        catch (HRMException he)
        {
            UcTitle1.ErrorText = he.Message;
        }
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        try
        {
            List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByScheduleId(Sid);
            //List<EmployeeLeaveScheduleBLL> lst = EmployeeLeaveScheduleBLL.GetByFilter("", "", UserId, 0, "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
            if (lst.Count > 0)
            {
                List<EmployeeLeaveBLL> lst0 = EmployeeLeaveBLL.GetByFilterV2(UserId, lst[0].EmployeeLeaveScheduleId, "0,-1");
                EmployeeLeaveBLL.UpdateStatus(lst0[0].EmployeeLeaveId, 3);

                EmployeeLeaveScheduleBLL.Update_Status(lst[0].EmployeeLeaveScheduleId, 3);
                UcTitle1.ErrorText = "Gửi thành công đến các cán bộ phòng đã được phân quyền phê duyệt nghỉ phép!";
                List<EmployeeLeaveScheduleBLL> lstR = EmployeeLeaveScheduleBLL.GetByFilter("", "", UserId, 0, "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
                if (lstR.Count > 0)
                {
                    ChangeDetail();
                }
            }
            else
            {
                UcTitle1.ErrorText = "Ngày phép đã gửi!";
            }
            Open();
        }
        catch 
        {
            UcTitle1.ErrorText = "Không có dữ liệu! Lưu trước khi gửi!";
            CleanDetail();
            ChangeDetail();
        }
    }
    #endregion

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
    private int Sid
    {
        get
        {
            if (ViewState["sid"] == null)
                return 0;
            else
                return int.Parse(ViewState["sid"].ToString());
        }
        set
        {
            if (ViewState["sid"] == null)
                ViewState["sid"] = value;
        }
    }
    private int Page
    {
        get
        {
            if (ViewState["p"] == null)
                return 0;
            else
                return int.Parse(ViewState["p"].ToString());
        }
        set
        {
            if (ViewState["p"] == null)
                ViewState["p"] = value;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page == 2)
        {
            Response.Redirect("~/Leave/LeaveScheduleList.aspx");
        }
    }
}