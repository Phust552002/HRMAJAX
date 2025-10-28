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

public partial class Management_Leave_LeaveScheduleDetail : System.Web.UI.Page
{
    private int Boss = 0;
    int flag = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                UserId = int.Parse(Request.QueryString["Id"]);
                Page = int.Parse(Request.QueryString["p"]);
                SId = int.Parse(Request.QueryString["sid"]);
                flag = 1;
            }
            catch
            {
                flag = 0;
                Response.Redirect("~/Login.aspx");
            }
            if (flag == 1)
            {
                UcTitle1.ErrorText = "";
                EmployeesBLL objUser = EmployeesBLL.GetEmployeeById(UserId);
                if (Page == 1)
                {
                    UcTitle1.Text = "ĐƠN ĐĂNG KÝ NGHỈ PHÉP THEO KẾ HOẠCH CỦA " + objUser.FullName.ToUpper() + " (Mã nhân viên: " + UserId + ")";
                }
                else
                {
                    UcTitle1.Text = "ĐƠN ĐĂNG KÝ NGHỈ PHÉP THỰC TẾ CỦA " + objUser.FullName.ToUpper() + " (Mã nhân viên: " + UserId + ")";
                }
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

                List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst0 = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByScheduleId(SId);// HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByFilter("", "", Convert.ToInt32(UserId), 0, "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
                if (lst0 != null)
                {
                    List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByFilter("", "", UserId, 0, "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
                    foreach (var item in lst)
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

                    TextBox2.Text = lst.Count.ToString();
                    txtLeaveRemain.Text = (lst0[0].MaxF - DayLeft).ToString();
                    txtTimeRemain.Text = (3 - lst.Count).ToString();

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
            }
        }
    }
    private void Open()
    {
        List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByScheduleId(SId);
        //List<EmployeeLeaveScheduleBLL> lst = EmployeeLeaveScheduleBLL.GetByFilter("", "", UserId, Time, "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
        if (lst.Count > 0)
        {
            //Đã được TCHC approve
            if (lst[0].Status == 4)
            {
                UpdatePanel3.Visible = true;
                LinkButton1.Visible = false;
                btnApprove.Visible = false;
            }
            //Đang chờ TCHC approved
            else if (lst[0].Status == 3)
            {
                UpdatePanel3.Visible = true;
                LinkButton1.Visible = true;
                btnApprove.Visible = true;
            }
            //Đang chờ cán bộ approved
            else if (lst[0].Status == 1)
            {
                UpdatePanel3.Visible = true;
                LinkButton1.Visible = true;
                btnApprove.Visible = true;
            }
            else
            {
                UpdatePanel3.Visible = true;
                LinkButton1.Visible = false;
                btnApprove.Visible = false;
            }
        }
        else
        {
            UpdatePanel3.Visible = false;
            LinkButton1.Visible = false;
            btnApprove.Visible = false;
        }
    }
    private void Close()
    {
        UpdatePanel3.Visible = false;
        LinkButton1.Visible = false;
        btnApprove.Visible = false;
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
    protected void btnApprove_Click(object sender, EventArgs e)
    {
        try
        {
            UcTitle1.ErrorText = "";
            #region Admin/HRAdmin
            if (UcPermission1.IsAdmin || UcPermission1.IsHRAdmin)
            {
                //if (UcPermission1.IsHRAdmin)
                {
                    //Lấy status = 3
                    List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByScheduleId(SId);
                    //List<EmployeeLeaveScheduleBLL> lst = EmployeeLeaveScheduleBLL.GetByFilter("", "", UserId, Time, "3", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
                    if (lst.Count > 0)
                    {
                        if (lst[0].Status == 3)
                        {
                            EmployeeLeaveScheduleBLL.Update_Status(lst[0].EmployeeLeaveScheduleId, 4);
                            string Ids = HRMUtil.Util.RejectFirstLastComma(lst[0].WriteIds);
                            if (Ids.Length > 0)
                            {
                                Ids += "," + UcPermission1.UserCurrent.UserId;
                            }
                            else
                            {
                                Ids = UcPermission1.UserCurrent.UserId.ToString();
                            }
                            Ids = string.Format(",{0},", Ids);

                            EmployeeLeaveScheduleBLL.Update_ApprovedDenied(lst[0].EmployeeLeaveScheduleId, Ids, 1);
                            EmployeeLeaveBLL.UpdateStatus(Convert.ToInt32(EmployeeLeaveBLL.GetByScheduleId(lst[0].EmployeeLeaveScheduleId)["EmployeeLeaveId"]), 4);
                        }
                        else
                        {
                            if (UcPermission1.IsLeaveManagerApproved)
                            {
                                //Lấy  status = 1, -1 gửi về lại cho nhân viên chỉnh sửa rồi resend.
                                //List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByScheduleId(SId);
                                //List<EmployeeLeaveScheduleBLL> lst = EmployeeLeaveScheduleBLL.GetByFilter("", "", UserId, Time, "1", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
                                if (lst.Count > 0)
                                {
                                    EmployeeLeaveScheduleBLL.Update_Status(lst[0].EmployeeLeaveScheduleId, 2);
                                    string Ids = HRMUtil.Util.RejectFirstLastComma(lst[0].WriteIds);
                                    if (Ids.Length > 0)
                                    {
                                        Ids += "," + UcPermission1.UserCurrent.UserId;
                                    }
                                    else
                                    {
                                        Ids = UcPermission1.UserCurrent.UserId.ToString();
                                    }
                                    Ids = string.Format(",{0},", Ids);
                                    EmployeeLeaveScheduleBLL.Update_ApprovedDenied(lst[0].EmployeeLeaveScheduleId, Ids, 1);
                                }
                                else
                                {
                                    UcTitle1.ErrorText = "Không có dữ liệu (chưa đăng ký kế hoạch nghỉ phép)!";
                                }
                            }
                        }
                    }
                    else
                    {
                        UcTitle1.ErrorText = "Không có dữ liệu (chưa đăng ký kế hoạch nghỉ phép)!";
                    }
                }
            }
            #endregion

            #region Cán bộ thường
            else if (UcPermission1.IsLeaveManagerApproved)
            {
                //Lấy  status = 1, -1 gửi về lại cho nhân viên chỉnh sửa rồi resend.
                List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByScheduleId(SId);
                //List<EmployeeLeaveScheduleBLL> lst = EmployeeLeaveScheduleBLL.GetByFilter("", "", UserId, Time, "1", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
                if (lst.Count > 0)
                {
                    EmployeeLeaveScheduleBLL.Update_Status(lst[0].EmployeeLeaveScheduleId, 2);
                    string Ids = HRMUtil.Util.RejectFirstLastComma(lst[0].WriteIds);
                    if (Ids.Length > 0)
                    {
                        Ids += "," + UcPermission1.UserCurrent.UserId;
                    }
                    else
                    {
                        Ids = UcPermission1.UserCurrent.UserId.ToString();
                    }
                    Ids = string.Format(",{0},", Ids);
                    EmployeeLeaveScheduleBLL.Update_ApprovedDenied(lst[0].EmployeeLeaveScheduleId, Ids, 1);
                }
                else
                {
                    UcTitle1.ErrorText = "Không có dữ liệu (chưa đăng ký kế hoạch nghỉ phép)!";
                }
            }
            #endregion
            
            Open();
            UcTitle1.ErrorText = "Cập nhật thành công!";
        }
        catch (HRMException he)
        {
            UcTitle1.ErrorText = he.Message;
        }
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        Label5.Visible = true;
        TextBox1.Visible = true;
        Button1.Visible = true;
    }
    private void CloseReason()
    {
        Label5.Visible = false;
        TextBox1.Visible = false;
        Button1.Visible = false;
    }
    #endregion
    private int SId
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
    private int Time
    {
        get
        {
            if (ViewState["Time"] == null)
                return 0;
            else
                return int.Parse(ViewState["Time"].ToString());
        }
        set
        {
            if (ViewState["Time"] == null)
                ViewState["Time"] = value;
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
        try
        {
            if (UcPermission1.IsLeaveManagerApproved)
            {
                if (TextBox1.Text == "" || TextBox1.Text.Length <= 0)
                {
                    UcTitle1.ErrorText = "Chưa nhập lý do!";
                }
                else
                {
                    UcTitle1.ErrorText = "";
                    List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByScheduleId(SId);
                    //List<EmployeeLeaveScheduleBLL> lst = EmployeeLeaveScheduleBLL.GetByFilter("", "", UserId, Time, "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
                    if (lst.Count > 0)
                    {
                        EmployeeLeaveScheduleBLL.Update_Status(lst[0].EmployeeLeaveScheduleId, -1);
                        string Ids = HRMUtil.Util.RejectFirstLastComma(lst[0].WriteIds);
                        if (Ids.Length > 0)
                        {
                            Ids += ",-" + UcPermission1.UserCurrent.UserId;
                        }
                        else
                        {
                            Ids = "-" + UcPermission1.UserCurrent.UserId.ToString();
                        }
                        Ids = "," + Ids + ",";
                        EmployeeLeaveScheduleBLL.Update_ApprovedDenied(lst[0].EmployeeLeaveScheduleId, Ids, 0);
                        EmployeeLeaveScheduleBLL.UpdateDenyReason(lst[0].EmployeeLeaveScheduleId, TextBox1.Text.Trim());
                        DataRow lst1 = EmployeeLeaveBLL.GetByScheduleId(lst[0].EmployeeLeaveScheduleId);
                        if (lst1 != null)
                        {
                            EmployeeLeaveBLL.UpdateStatus(Convert.ToInt32(lst1["EmployeeLeaveId"]), -1);
                        }
                    }
                    else
                    {
                        UcTitle1.ErrorText = "Không có dữ liệu (chưa đăng ký kế hoạch nghỉ phép)!";
                    }
                    Open();
                    UcTitle1.ErrorText = "Cập nhật thành công!";
                    CloseReason();
                }
            }
        }
        catch
        {
            UcTitle1.ErrorText = "Không có dữ liệu! Lưu trước khi gửi!";
            CleanDetail();
            ChangeDetail();
            CloseReason();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Page == 0)
        {
            Response.Redirect("~/Leave/Management/LeaveScheduleList.aspx");
        }
        else
        {
            Response.Redirect("~/Leave/Management/LeaveSchedule.aspx");
        }
    }
}