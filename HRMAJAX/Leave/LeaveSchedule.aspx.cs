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


public partial class Leave_LeaveSchedule : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Check đăng nhập
            EmployeesBLL objUser = UcPermission1.UserCurrent;
            if (objUser == null)
            {
                Response.Redirect("~/Login.aspx");

            }
            else
            {
                UcTitle1.Text = "ĐĂNG KÝ NGHỈ PHÉP THEO KẾ HOẠCH NĂM " + DateTime.Now.Year;
                AddDataToCboYear();
                InitData();
                chkHideAddSession.Checked = true;
                pnlAddSession.Visible = true;
                #region Thống kê
                DataRow dt = EmployeeLeaveBLL.GetRealLeaveByUserId(UcPermission1.UserCurrent.UserId, 0, DateTime.Now.Year);
                if (dt != null)
                {
                    lblTotalLeave.Text = dt["MaxFCurrent"].ToString();
                }
                #endregion
            }
        }
    }

    private void AddDataToCboYear()
    {
        //for (int i = DateTime.Now.Year - 1; i <= DateTime.Now.Year; i++)
        //{
        //    ListItem item = new ListItem(i.ToString(), i.ToString());
        //    ddlYears.Items.Add(item);
        //}
        ////DateTime date = DateTime.Now.AddMonths(-1);
        //DateTime date = DateTime.Now;
        //ddlYears.SelectedValue = date.Year.ToString();
    }

    private void BindDataToDDLEmployee()
    {
        List<EmployeesBLL> list = EmployeesBLL.GetByIds(UcPermission1.UserCurrent.UserId.ToString());
        ddlFullName.DataSource = list;
        ddlFullName.DataTextField = "FullName";
        ddlFullName.DataValueField = "UserId";
        ddlFullName.DataBind();
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            int Max = 0;
            EmployeeLeaveScheduleBLL obj = (EmployeeLeaveScheduleBLL)e.Row.DataItem;
            Label lblTotal = (Label)e.Row.FindControl("lblTotal");
            if (lblTotal != null)
            {
                Max = (Convert.ToInt32(obj.Seniority) + Convert.ToInt32(obj.MaxF));
                lblTotal.Text = Max.ToString();
            }
            int Days;
            Label lblDays = (Label)e.Row.FindControl("lblDays");
            if (lblDays != null)
            {
                Days = Convert.ToInt32(GetLeaveDaysV1(obj.FromDate, obj.ToDate));
                lblDays.Text = GetLeaveDaysV1(obj.FromDate, obj.ToDate).ToString();
            }
            int DayLeft = 0;
            List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByFilter("", "", Convert.ToInt32(obj.UserId), 0, "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
            if (lst != null)
            {
                foreach (var item in lst)
                {
                    if (item != null)
                    {
                        DayLeft += item.Days;
                    }
                }
            }
            Label lblDaysLeft = (Label)e.Row.FindControl("lblDaysLeft");
            if (lblDaysLeft != null)
            {
                int Left = (Max - DayLeft);
                if (Left < 0)
                {
                    lblDaysLeft.Text = Left.ToString();
                    lblDaysLeft.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblDaysLeft.Text = Left.ToString();
                    lblDaysLeft.ForeColor = System.Drawing.Color.Blue;
                }
            }
            ImageButton imButton1 = (ImageButton)e.Row.FindControl("ImageButton1");
            ImageButton imButton2 = (ImageButton)e.Row.FindControl("ImageButton2");
            LinkButton lnkSend = (LinkButton)e.Row.FindControl("lnkSend");
            Label DenyReason = (Label)e.Row.FindControl("Label3");
            object objTemp = GridView1.DataKeys[e.Row.RowIndex].Value as object;
            if (objTemp != null)
            {
                List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst1 = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByEmployeeLeaveScheduleId(Convert.ToInt32(objTemp));
                if (lst1[0].Status == 0)
                {
                    DenyReason.Visible = false;

                    imButton1.Visible = true;
                    imButton2.Visible = true;

                    lnkSend.Visible = true;
                    lnkSend.Enabled = true;
                    lnkSend.Text = "Gửi";
                }
                else if (lst1[0].Status == 1)
                {
                    DenyReason.Visible = false;

                    imButton1.Visible = false;
                    imButton2.Visible = false;

                    lnkSend.Visible = true;
                    lnkSend.Enabled = false;
                    lnkSend.Text = "Đã gửi";
                }
                else if (lst1[0].Status == 2)
                {
                    DenyReason.Visible = false;

                    imButton1.Visible = false;
                    imButton2.Visible = false;

                    lnkSend.Visible = true;
                    lnkSend.Enabled = false;
                    //lnkSend.Text = "Chờ duyệt";
                    lnkSend.Text = "Đã gửi";
                }
                else if (lst1[0].Status == 3)
                {
                    DenyReason.Visible = false;

                    imButton1.Visible = false;
                    imButton2.Visible = false;

                    lnkSend.Visible = true;
                    lnkSend.Enabled = false;
                    //lnkSend.Text = "Chờ duyệt";
                    lnkSend.Text = "Đã gửi";
                }
                else if (lst1[0].Status == 4)
                {
                    row.BackColor = System.Drawing.Color.FromArgb(0x96, 0xD2, 0xA4);
                    row.Font.Bold = true;

                    DenyReason.Visible = false;

                    imButton1.Visible = false;
                    imButton2.Visible = false;

                    lnkSend.Visible = true;
                    lnkSend.Enabled = false;
                    //lnkSend.Text = "Đã Duyệt";
                    lnkSend.Text = "Đã gửi";
                }
                else
                {
                    row.BackColor = System.Drawing.Color.FromArgb(0xD4, 0x94, 0x94);
                    row.Font.Bold = true;

                    DenyReason.Visible = true;
                    DenyReason.Text = lst1[0].DenyReason;

                    imButton1.Visible = true;
                    imButton2.Visible = true;

                    lnkSend.Visible = true;
                    lnkSend.Enabled = true;
                    lnkSend.Text = "Gửi";
                    //lnkSend.Text = "Từ chối (Gửi lại)";
                }
            }
        }
    }

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

    protected void imgSearch_Click(object sender, EventArgs e)
    {
        GridView1.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (ValidateDataInput())
        {
            int count = 0;
            List<EmployeeLeaveScheduleBLL> lst = EmployeeLeaveScheduleBLL.GetByFilter("", "", Convert.ToInt32(ddlFullName.SelectedValue), 0, "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
            List<DateTime> InputLeave = GetDateRange(cpFromDate.SelectedDate, cpToDateDate.SelectedDate);
            if (lst.Count > 0)
            {
                foreach (var itemlst in lst)
                {
                    DateRange1 range = new DateRange1(itemlst.FromDate, itemlst.ToDate);
                    foreach (var itemInputLeave in InputLeave)
                    {
                        if (range.Includes(new DateRange1(cpFromDate.SelectedDate, cpToDateDate.SelectedDate)) || range.Includes(itemInputLeave))
                        {
                            count++;
                        }
                    }
                }
                if (count == 0)
                {
                    //if (lst.Count <= 3)
                    //{
                    //    HRMBLL.H0.EmployeeLeaveScheduleBLL.Insert(Convert.ToInt32(ddlFullName.SelectedValue), cpFromDate.SelectedDate, cpToDateDate.SelectedDate, Convert.ToInt32(GetLeaveDaysV1(cpFromDate.SelectedDate, cpToDateDate.SelectedDate)), RadioButtonList1.SelectedIndex + 1);
                    //}
                    //else
                    //{
                    //    UcTitle1.ErrorText = "Đã dùng hết số lần nghỉ!";
                    //}
                    HRMBLL.H0.EmployeeLeaveScheduleBLL.Insert(Convert.ToInt32(ddlFullName.SelectedValue), cpFromDate.SelectedDate, cpToDateDate.SelectedDate, Convert.ToInt32(GetLeaveDaysV1(cpFromDate.SelectedDate, cpToDateDate.SelectedDate)), 0);
                    UcTitle1.ErrorText = "";
                    GridView1.DataBind();

                    RefreshAll();
                }
                else
                {
                    UcTitle1.ErrorText = "Trùng lần nghỉ/ ngày nghỉ";
                }
            }
            else
            {
                //if (lst.Count <= 3)
                //{
                //    HRMBLL.H0.EmployeeLeaveScheduleBLL.Insert(Convert.ToInt32(ddlFullName.SelectedValue), cpFromDate.SelectedDate, cpToDateDate.SelectedDate, Convert.ToInt32(GetLeaveDaysV1(cpFromDate.SelectedDate, cpToDateDate.SelectedDate)), RadioButtonList1.SelectedIndex + 1);
                //}
                //else
                //{
                //    UcTitle1.ErrorText = "Đã dùng hết số lần nghỉ!";
                //}
                HRMBLL.H0.EmployeeLeaveScheduleBLL.Insert(Convert.ToInt32(ddlFullName.SelectedValue), cpFromDate.SelectedDate, cpToDateDate.SelectedDate, Convert.ToInt32(GetLeaveDaysV1(cpFromDate.SelectedDate, cpToDateDate.SelectedDate)), 0);
                UcTitle1.ErrorText = "";
                GridView1.DataBind();

                RefreshAll();
            }
        }
    }

    private bool ValidateDataInput()
    {

        if (cpToDateDate.SelectedDate < cpFromDate.SelectedDate)
        {
            UcTitle1.ErrorText = "Nhập sai ngày phép!";
            return false;
        }
        if (cpFromDate.SelectedDate == HRMUtil.FormatDate.GetSQLDateMinValue || cpToDateDate.SelectedDate == HRMUtil.FormatDate.GetSQLDateMinValue)
        {
            UcTitle1.ErrorText = "Chưa chọn ngày nghỉ!";
            return false;
        }
        else
        {
            DataRow dr = EmployeeLeaveBLL.GetRealLeaveByUserId(UcPermission1.UserCurrent.UserId, 0, DateTime.Now.Year);
            if (dr != null)
            {
                if (Convert.ToDouble(dr["FRemain"]) - GetLeaveDaysV1(cpFromDate.SelectedDate, cpToDateDate.SelectedDate) <
                    0 || GetLeaveDaysV1(cpFromDate.SelectedDate, cpToDateDate.SelectedDate) > 6)
                {
                    UcTitle1.ErrorText = "Vượt quá số ngày phép quy định!";
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
    }

    protected void chkHideAddSession_CheckedChanged(object sender, EventArgs e)
    {
        pnlAddSession.Visible = chkHideAddSession.Checked;
    }

    protected void InitData()
    {
        BindDataToDDLEmployee();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        RefreshAll();
    }

    private void RefreshAll()
    {
        List<EmployeesBLL> lst = EmployeesBLL.GetByIds(UcPermission1.UserCurrent.UserId.ToString());
        ddlFullName.DataSource = lst;
        ddlFullName.DataTextField = "FullName";
        ddlFullName.DataValueField = "UserId";
        ddlFullName.DataBind();
        ddlFullName.SelectedValue = lst[0].UserId.ToString();

        cpFromDate.SelectedDate = DateTime.Now;
        cpToDateDate.SelectedDate = DateTime.Now;
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        GridView1.DataBind();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        GridView1.DataBind();
    }

    protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        List<EmployeesBLL> list = EmployeesBLL.GetByIds(UcPermission1.UserCurrent.UserId.ToString());

        e.InputParameters["fullName"] = "";
        e.InputParameters["departmentIds"] = "";
        e.InputParameters["UserId"] = UcPermission1.UserCurrent.UserId;
        e.InputParameters["Time"] = 0;
        e.InputParameters["Status"] = "";
        e.InputParameters["RootId"] = list[0].RootId;
        e.InputParameters["LevelPosition"] = -1;
        e.InputParameters["RangeFrom"] = HRMUtil.FormatDate.GetSQLDateMinValue;
        e.InputParameters["RangeTo"] = HRMUtil.FormatDate.GetSQLDateMinValue;
    }

    protected void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridView1.DataBind();
    }

    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        GridView1.DataBind();
        RefreshAll();
    }
    //protected void btnSend_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        if (ddlFullName.SelectedValue != null)
    //        {
    //            int UserId = Convert.ToInt32(ddlFullName.SelectedValue);
    //            int Time = Convert.ToInt32(RadioButtonList1.SelectedIndex) + 1;
    //            List<EmployeeLeaveScheduleBLL> lst = EmployeeLeaveScheduleBLL.GetByFilter("", "", UserId, Time, "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
    //            if (lst.Count > 0)
    //            {
    //                string Ids = ",";
    //                List<DepartmentEmployeeBLL> lst1 = DepartmentEmployeeBLL.GetByUserId(UcPermission1.UserCurrent.UserId);
    //                DataTable lstUserRoles = HRMBLL.UserRolesBLL.GetByFilter(15, lst1[0].RootId);
    //                for (int i = 0; i < lstUserRoles.Rows.Count; i++)
    //                {
    //                    DataRow item = lstUserRoles.Rows[i];
    //                    Ids += item["UserId"] + ",";
    //                }

    //                EmployeeLeaveScheduleBLL.UpdateReadIds(lst[0].EmployeeLeaveScheduleId, Ids);
    //                EmployeeLeaveScheduleBLL.Update_Status(lst[0].EmployeeLeaveScheduleId, 1);

    //                UcTitle1.ErrorText = "Gửi thành công đến các cán bộ phòng đã được phân quyền phê duyệt nghỉ phép!";
    //            }
    //            else
    //            {
    //                UcTitle1.ErrorText = "Ngày phép đã gửi!";
    //            }
    //        }
    //        else
    //        {
    //            UcTitle1.ErrorText = "Chưa chọn nhân viên!";
    //        }
    //    }
    //    catch
    //    {
    //        UcTitle1.ErrorText = "Không có dữ liệu! Lưu trước khi gửi!";
    //    }
    //}
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "SendCmd")
        {
            try
            {
                GridViewRow myRow = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;
                object objTemp = GridView1.DataKeys[myRow.RowIndex].Value as object;
                int UserId = Convert.ToInt32(myRow.Cells[0].Text);
                int Time = 0;// Convert.ToInt32(myRow.Cells[9].Text);
                List<HRMBLL.H0.EmployeeLeaveScheduleBLL> lst = HRMBLL.H0.EmployeeLeaveScheduleBLL.GetByEmployeeLeaveScheduleId(Convert.ToInt32(objTemp));
                //List<EmployeeLeaveScheduleBLL> lst = EmployeeLeaveScheduleBLL.GetByFilter("", "", UserId, Time, "", -1, -1, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
                if (lst.Count > 0)
                {
                    //Gửi lên cán bộ
                    //string Ids = ",";
                    //List<DepartmentEmployeeBLL> lst1 = DepartmentEmployeeBLL.GetByUserId(UcPermission1.UserCurrent.UserId);
                    //DataTable lstUserRoles = HRMBLL.UserRolesBLL.GetByFilter(15, lst1[0].RootId);
                    //for (int i = 0; i < lstUserRoles.Rows.Count; i++)
                    //{
                    //    DataRow item = lstUserRoles.Rows[i];
                    //    Ids += item["UserId"] + ",";
                    //}

                    //EmployeeLeaveScheduleBLL.UpdateReadIds(lst[0].EmployeeLeaveScheduleId, Ids);
                    EmployeeLeaveScheduleBLL.Update_Status(lst[0].EmployeeLeaveScheduleId, 1);
                    UcTitle1.ErrorText = "Gửi thành công đến các cán bộ phòng đã được phân quyền phê duyệt nghỉ phép!";
                }
                else
                {
                    UcTitle1.ErrorText = "Ngày phép đã gửi!";
                }
                GridView1.DataBind();
            }
            catch { }
        }
    }
}

public interface IRange<T>
{
    T Start { get; }
    T End { get; }
    bool Includes(T value);
    bool Includes(IRange<T> range);
}
public class DateRange1 : IRange<DateTime>
{
    public DateRange1(DateTime start, DateTime end)
    {
        Start = start;
        End = end;
    }

    public DateTime Start { get; private set; }
    public DateTime End { get; private set; }

    public bool Includes(DateTime value)
    {
        return (Start <= value) && (value <= End);
    }

    public bool Includes(IRange<DateTime> range)
    {
        return (Start <= range.Start) && (range.End <= End);
    }
}