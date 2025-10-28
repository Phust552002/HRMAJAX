using HRMBLL.H0;
using HRMUtil;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TimeWorks_TimeBillHistory : System.Web.UI.Page
{
    public int UserId
    {
        set
        {
            ViewState["UserId"] = value;
        }
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
    }
    public DateTime ViewDate
    {
        set
        {
            ViewState["ViewDate"] = value;
        }
        get
        {
            if (ViewState["ViewDate"] != null)
            {
                return DateTime.Parse(ViewState["ViewDate"].ToString());
            }
            else
            {
                return DateTime.Now;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                UcTitle1.Text = "THÔNG TIN CHI TIẾT GHI NHẬN THỜI GIAN ĐIỂM DANH VÂN TAY";
                if (Request.QueryString["uid"] != null)
                {
                    UserId = int.Parse(Request.QueryString["uid"].ToString());
                }
                else
                {
                    Response.Redirect("~/TimeWorks/StatisticTimeWork.aspx");
                }
                try
                {
                    ViewDate = new DateTime(int.Parse(Request.QueryString["y"].ToString()), int.Parse(Request.QueryString["m"].ToString()), int.Parse(Request.QueryString["d"].ToString()));
                }
                catch
                {
                    ViewDate = DateTime.Now;
                }
                CalendarPicker1.SelectedDate = ViewDate;
                ShowInfor();
            }
            catch
            {
                Response.Redirect("~/TimeWorks/StatisticTimeWork.aspx");
            }
        }
    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        ShowInfor();
    }

    private void ShowInfor()
    {
        try
        {   
            EmployeesBLL obj = EmployeesBLL.GetEmployeeById(UserId);
            lbFullName.Text = obj.FullName;
            lbUserId.Text = obj.UserId.ToString();


            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = clsEncDec.Decrypt("Q5xiU7Y7ybblB5jA17N4JHhDTONdT+zd41/OHMFiz+dpwgue3uo4zfmwVc7kEhd+zMzEcV9MwJQOs4b8A1sFgDyfEnJ1v2rptmDhwepmZ1rQ3lDF17CYlO2jfBF0dXZV");
            //conn.Open();

            //SqlCommand cmd = new SqlCommand()
            //{
            //    CommandType = CommandType.StoredProcedure,
            //    CommandText = "[dbo].[Sel_DataHikCentral_By_DataDate_And_UserId]",
            //    Connection = conn
            //};

            //cmd.Parameters.Add(new SqlParameter("@UserId", UserId));
            //cmd.Parameters.Add(new SqlParameter("@DataDate", CalendarPicker1.SelectedDate));

            //SqlDataReader reader = cmd.ExecuteReader();

            DataTable dtLog = EmployeeTimeBillBLL.GetLogByUserIdAndDate(UserId, CalendarPicker1.SelectedDate);
            grdHistory.DataSource = dtLog;
            grdHistory.DataBind();
        }
        catch
        { }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/TimeWorks/PersonalTW.aspx?uid=" + UserId + "&m=" + ViewDate.Month + "&y=" + ViewDate.Year);
    }
}