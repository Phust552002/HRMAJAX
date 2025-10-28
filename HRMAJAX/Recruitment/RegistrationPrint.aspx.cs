using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using HRMBLL.H2;
using HRMBLL.H0;
using HRMUtil;
using HRMUtil.KeyNames.H2;
using HRMUtil.KeyNames.H0;
using System.Web.Configuration;

public partial class Recruitment_RegistrationPrint : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        switch (WebConfigurationManager.AppSettings["BaseStation"])
        {
            case "DAD":
                lbCompanyName.Text = "CÔNG TY CỔ PHẦN PHỤC VỤ MẶT ĐẤT SÀI GÒN - ĐÀ NẴNG";
                break;
            case "CXR":
                lbCompanyName.Text = "CÔNG TY CỔ PHẦN PHỤC VỤ MẶT ĐẤT SÀI GÒN - CAM RANH";
                break;
            default:
                lbCompanyName.Text = "CÔNG TY CỔ PHẦN PHỤC VỤ MẶT ĐẤT SÀI GÒN";
                break;
        }
        if (!IsPostBack)
        {
            if (Session[Constants.KEY_CANDIDATE_CURRENT] != null)
            {
                CandidateId = Convert.ToInt32(Session[Constants.KEY_CANDIDATE_CURRENT]);
            }
            else if (Request.QueryString["Id"] != null)
            {
                CandidateId = int.Parse(Request.QueryString["Id"].ToString());

            }
            else
            {
                BackList();
            }

            if (CandidateId > 0)
            {
                ShowInfor();
                BindEducation();
                BindTraining();
                BindTrainingIncomplete();
                BindEnglishComputer();
                BindJob();
                BindExperience();
                BindExperienceOther();
                BindFatherMother();
                BindSAGSFamily();
                BindInforConfirm();
            }
        }
    }
    private void BackList()
    {
        Response.Redirect("~/Recruitment/SignIn.aspx");
    }

    private void ShowInfor()
    {
        if (CandidateId > 0)
        {
            DataRow dr = CandidatesBLL.GetByIdForDataRow(CandidateId);

            //int candidateStatus = int.Parse(dr["CandidateStatus"].ToString());
            //if (candidateStatus <= 0)
            //{
            //    btnSave.Visible = true;
            //    btnPrint.Visible = true;
            //}
            //else
            //{
            //    btnSave.Visible = false;
            //    btnPrint.Visible = false;
            //}

            lbPositionName.Text = dr[PositionKeys.FIELD_POSITION_NAME] == DBNull.Value ? string.Empty : dr[PositionKeys.FIELD_POSITION_NAME].ToString();
            lbCV_ReceivedDate.Text = dr["CV_ReceivedDate"] == DBNull.Value ? "" : FormatDate.FormatVNDate(Convert.ToDateTime(dr["CV_ReceivedDate"]));

            string LastName = dr[CandidatesKeys.FIELD_CANDIDATE_LASTNAME] == DBNull.Value ? string.Empty : dr[CandidatesKeys.FIELD_CANDIDATE_LASTNAME].ToString();
            string FirstName = dr[CandidatesKeys.FIELD_CANDIDATE_FIRSTNAME] == DBNull.Value ? string.Empty : dr[CandidatesKeys.FIELD_CANDIDATE_FIRSTNAME].ToString();
            lbFullName.Text = LastName.TrimStart().TrimEnd() + " " + FirstName.TrimStart().TrimEnd();

            lbHeight.Text = dr["Height"] == DBNull.Value ? string.Empty : dr["Height"].ToString() + " cm";
            lbWeight.Text = dr["Weight"] == DBNull.Value ? string.Empty : dr["Weight"].ToString() + " kg";
            lbLive.Text = dr["Live"] == DBNull.Value ? string.Empty : dr["Live"].ToString();
            lbResident.Text = dr["Resident"] == DBNull.Value ? string.Empty : dr["Resident"].ToString();
            lbIdCard.Text = dr["IdCard"] == DBNull.Value ? string.Empty : dr["IdCard"].ToString();
            lbIdDateOfIssue.Text = dr["IdDateOfIssue"] == DBNull.Value ? "" : FormatDate.FormatVNDate(Convert.ToDateTime(dr["IdDateOfIssue"].ToString()));
            lbIdPlaceOfIssue.Text = dr["IdPlaceOfIssue"] == DBNull.Value ? string.Empty : dr["IdPlaceOfIssue"].ToString();
            lbHomeTownAddress.Text = dr["HomeTownAddress"] == DBNull.Value ? string.Empty : dr["HomeTownAddress"].ToString();
            lbHandPhone.Text = dr["HandPhone"] == DBNull.Value ? string.Empty : dr["HandPhone"].ToString();
            lbWorkingPhone.Text = dr["WorkingPhone"] == DBNull.Value ? string.Empty : dr["WorkingPhone"].ToString();
            lbEmail.Text = dr["Email"] == DBNull.Value ? string.Empty : dr["Email"].ToString();


            int dayOfBirth = dr[CandidatesKeys.FIELD_CANDIDATE_DATE_OF_BIRTH] == DBNull.Value ? 0 : int.Parse(dr[CandidatesKeys.FIELD_CANDIDATE_DATE_OF_BIRTH].ToString());
            int monthOfBirth = dr[CandidatesKeys.FIELD_CANDIDATE_MONTH_OF_BIRTH] == DBNull.Value ? 0 : int.Parse(dr[CandidatesKeys.FIELD_CANDIDATE_MONTH_OF_BIRTH].ToString());
            int yearOfBirth = dr[CandidatesKeys.FIELD_CANDIDATE_YEAR_OF_BIRTH] == DBNull.Value ? 0 : int.Parse(dr[CandidatesKeys.FIELD_CANDIDATE_YEAR_OF_BIRTH].ToString());

            DateTime dtBirthday = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
            lbBirthday.Text = FormatDate.FormatVNDate(dtBirthday.Date);


            bool sex = dr["Sex"] == DBNull.Value ? false : Convert.ToBoolean(dr["Sex"].ToString());
            if (sex)
            {
                lbSex.Text = "Nam";
            }
            else
            {
                lbSex.Text = "Nữ";
            }

            int Marriage = dr["Marriage"] == DBNull.Value ? 0 : int.Parse(dr["Marriage"].ToString());
            if (Marriage == 0)
            {
                lbMarriage.Text = "Độc thân";
            }
            else if (Marriage == 1)
            {
                lbMarriage.Text = "Đã thành hôn";
            }
            else
            {
                lbMarriage.Text = "Đã ly dị";
            }
            


            try{lbSalary_Present.Text = dr["Salary_Present"] == DBNull.Value ? "" : double.Parse(dr["Salary_Present"].ToString()).ToString(StringFormat.FormatCurrencyFinal);}
            catch{lbSalary_Present.Text ="";}

            try{lbSalary_Offer.Text = dr["Salary_Offer"] == DBNull.Value ? "" : double.Parse(dr["Salary_Offer"].ToString()).ToString(StringFormat.FormatCurrencyFinal);}
            catch{lbSalary_Offer.Text ="";}

            int Contract_YesNo = int.Parse(dr["Contract_YesNo"] == DBNull.Value ? "0" : dr["Contract_YesNo"].ToString());

            if (Contract_YesNo == 1)
            {
                lbContract_YesNo.Text = "Có";
            }
            else
            {
                lbContract_YesNo.Text = "Không";
            }

            lbContract_Present_Date.Text = dr["Contract_Present_Date"] == DBNull.Value ? "" : FormatDate.FormatVNDate(Convert.ToDateTime(dr["Contract_Present_Date"]));
            int Contract_Present_End = int.Parse(dr["Contract_Present_End"] == DBNull.Value ? "0" : dr["Contract_Present_End"].ToString());

            if (Contract_Present_End == 1)
            {
                lbContract_Present_End.Text = "Có";
            }
            else if (Contract_Present_End == 0)
            {
                lbContract_Present_End.Text = "Không";
            }
            else
            {
                lbContract_Present_End.Text = "";
            }

            lbContract_New_StartDate.Text = dr["Contract_New_StartDate"] == DBNull.Value ? "" : FormatDate.FormatVNDate(Convert.ToDateTime(dr["Contract_New_StartDate"]));


            lbHealth_Present.Text = dr["Health_Present"] == DBNull.Value ? "" : dr["Health_Present"].ToString();
            
            lbHealth_Body.Text = dr["Health_Body"] == DBNull.Value ? "" : dr["Health_Body"].ToString();



            int SAGS_Family = dr["SAGS_Family"] == DBNull.Value ? 0 : int.Parse(dr["SAGS_Family"].ToString());
            if (SAGS_Family == 1)
            {
                lbSAGS_Family.Text = "Có";
            }
            else
            {
                lbSAGS_Family.Text = "Không";
            }
            string CV_Content = dr["CV_Content"] == DBNull.Value ? "" : dr["CV_Content"].ToString();
            //lbCV_Content.Text = "<span class=\"style1\">" + CV_Content.Replace("\n", "<br/>")+"";
            lbCV_Content.Text = CV_Content.Replace("\n", "<br/>") ;
        }

    }

    public int CandidateId
    {
        get
        {
            if (ViewState["CandidateId"] != null)
            {
                return int.Parse(ViewState["CandidateId"].ToString());
            }
            else
            {
                return 0;
            }
        }
        set
        {
            ViewState["CandidateId"] = value;
        }
    }

    public void BindEducation()
    {

        List<CandidateTrainingJobHistoryBLL> list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "EDU");
        if (list.Count == 0)
        {
            CandidateTrainingJobHistoryBLL obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }
       
        grdEducation.DataSource = list;
        grdEducation.DataBind();
    }
    public void BindTraining()
    {

        List<CandidateTrainingJobHistoryBLL> list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "TRN");
        if (list.Count == 0)
        {
            CandidateTrainingJobHistoryBLL obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        grdTraining.DataSource = list;
        grdTraining.DataBind();
    }
    public void BindTrainingIncomplete()
    {

        List<CandidateTrainingJobHistoryBLL> list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "TIC");
        if (list.Count == 0)
        {
            CandidateTrainingJobHistoryBLL obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        grdTrainingIncomplete.DataSource = list;
        grdTrainingIncomplete.DataBind();
    }
    public void BindEnglishComputer()
    {

        List<CandidateTrainingJobHistoryBLL> list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "ENC");
        if (list.Count == 0)
        {
            CandidateTrainingJobHistoryBLL obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        grdEnglishComputer.DataSource = list;
        grdEnglishComputer.DataBind();
    }
    public void BindJob()
    {

        List<CandidateTrainingJobHistoryBLL> list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "JOB");
        if (list.Count == 0)
        {
            CandidateTrainingJobHistoryBLL obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        grdJob.DataSource = list;
        grdJob.DataBind();
    }
    public void BindExperience()
    {

        List<CandidateTrainingJobHistoryBLL> list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "EXP");
        if (list.Count == 0)
        {
            CandidateTrainingJobHistoryBLL obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        grdExperience.DataSource = list;
        grdExperience.DataBind();
    }
    public void BindExperienceOther()
    {

        List<CandidateTrainingJobHistoryBLL> list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "EXO");
        if (list.Count == 0)
        {
            CandidateTrainingJobHistoryBLL obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        grdExperienceOther.DataSource = list;
        grdExperienceOther.DataBind();
    }
    public void BindFatherMother()
    {

        List<CandidateTrainingJobHistoryBLL> list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "FMT");
        if (list.Count == 0)
        {
            CandidateTrainingJobHistoryBLL obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        grdFatherMother.DataSource = list;
        grdFatherMother.DataBind();
    }
    public void BindSAGSFamily()
    {

        List<CandidateTrainingJobHistoryBLL> list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "SAG");
        if (list.Count == 0)
        {
            CandidateTrainingJobHistoryBLL obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        grdSAGSFamily.DataSource = list;
        grdSAGSFamily.DataBind();
    }
    public void BindInforConfirm()
    {

        List<CandidateTrainingJobHistoryBLL> list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "ICF");
        if (list.Count == 0)
        {
            CandidateTrainingJobHistoryBLL obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        grdInforConfirm.DataSource = list;
        grdInforConfirm.DataBind();
    }

    protected void grdEducation_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow item = e.Row;
        if (item.RowType == DataControlRowType.DataRow)
        {
            CandidateTrainingJobHistoryBLL obj = (CandidateTrainingJobHistoryBLL)item.DataItem;

            Label lbTraining_Job = (Label)item.FindControl("lbTraining_Job");
            lbTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            lbTraining_Job.Text = obj.Training_Job;

            Label lbYear = (Label)item.FindControl("lbYear");
            lbYear.Text = obj.Year.ToString();

            Label lbSchool_Position = (Label)item.FindControl("lbSchool_Position");
            lbSchool_Position.Text = obj.School_Position;

            Label lbMajor_Salary = (Label)item.FindControl("lbMajor_Salary");
            lbMajor_Salary.Text = obj.Major_Salary;

            Label lbGraduateYear_LeaveReason = (Label)item.FindControl("lbGraduateYear_LeaveReason");
            lbGraduateYear_LeaveReason.Text = obj.GraduateYear_LeaveReason;
        }
    }
    protected void grdTraining_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow item = e.Row;
        if (item.RowType == DataControlRowType.DataRow)
        {
            CandidateTrainingJobHistoryBLL obj = (CandidateTrainingJobHistoryBLL)item.DataItem;

            Label lbTraining_Job = (Label)item.FindControl("lbTraining_Job");
            lbTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            lbTraining_Job.Text = obj.Training_Job;

            Label lbYear = (Label)item.FindControl("lbYear");
            lbYear.Text = obj.Year.ToString();

            Label lbSchool_Position = (Label)item.FindControl("lbSchool_Position");
            lbSchool_Position.Text = obj.School_Position;

            Label lbMajor_Salary = (Label)item.FindControl("lbMajor_Salary");
            lbMajor_Salary.Text = obj.Major_Salary;

        }
    }
    protected void grdTrainingIncomplete_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow item = e.Row;
        if (item.RowType == DataControlRowType.DataRow)
        {
            CandidateTrainingJobHistoryBLL obj = (CandidateTrainingJobHistoryBLL)item.DataItem;

            Label lbTraining_Job = (Label)item.FindControl("lbTraining_Job");
            lbTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            lbTraining_Job.Text = obj.Training_Job;

            Label lbYear = (Label)item.FindControl("lbYear");
            lbYear.Text = obj.Year.ToString();

            Label lbSchool_Position = (Label)item.FindControl("lbSchool_Position");
            lbSchool_Position.Text = obj.School_Position;

            Label lbMajor_Salary = (Label)item.FindControl("lbMajor_Salary");
            lbMajor_Salary.Text = obj.Major_Salary;

        }
    }
    protected void grdEnglishComputer_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow item = e.Row;
        if (item.RowType == DataControlRowType.DataRow)
        {
            CandidateTrainingJobHistoryBLL obj = (CandidateTrainingJobHistoryBLL)item.DataItem;

            Label lbTraining_Job = (Label)item.FindControl("lbTraining_Job");
            lbTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            lbTraining_Job.Text = obj.Training_Job;

            Label lbMajor_Salary = (Label)item.FindControl("lbMajor_Salary");
            lbMajor_Salary.Text = obj.Major_Salary;

        }
    }
    protected void grdJob_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow item = e.Row;
        if (item.RowType == DataControlRowType.DataRow)
        {
            CandidateTrainingJobHistoryBLL obj = (CandidateTrainingJobHistoryBLL)item.DataItem;

            Label lbTraining_Job = (Label)item.FindControl("lbTraining_Job");
            lbTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            lbTraining_Job.Text = obj.Training_Job;

            Label lbYear = (Label)item.FindControl("lbYear");
            lbYear.Text = obj.Year.ToString();

            Label lbSchool_Position = (Label)item.FindControl("lbSchool_Position");
            lbSchool_Position.Text = obj.School_Position;

            Label lbMajor_Salary = (Label)item.FindControl("lbMajor_Salary");
            try
            {
                lbMajor_Salary.Text = double.Parse(obj.Major_Salary.ToString()).ToString(StringFormat.FormatCurrencyFinal);
            }
            catch { lbMajor_Salary.Text = ""; }

            Label lbGraduateYear_LeaveReason = (Label)item.FindControl("lbGraduateYear_LeaveReason");
            lbGraduateYear_LeaveReason.Text = obj.GraduateYear_LeaveReason;
        }
    }
    protected void grdExperience_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow item = e.Row;
        if (item.RowType == DataControlRowType.DataRow)
        {
            CandidateTrainingJobHistoryBLL obj = (CandidateTrainingJobHistoryBLL)item.DataItem;

            Label lbExperience = (Label)item.FindControl("lbExperience");
            lbExperience.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            lbExperience.Text = obj.Experience;
        }
    }
    protected void grdExperienceOther_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow item = e.Row;
        if (item.RowType == DataControlRowType.DataRow)
        {
            CandidateTrainingJobHistoryBLL obj = (CandidateTrainingJobHistoryBLL)item.DataItem;

            Label lbExperience = (Label)item.FindControl("lbExperience");
            lbExperience.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            lbExperience.Text = obj.Experience;
        }
    }
    protected void grdFatherMother_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow item = e.Row;
        if (item.RowType == DataControlRowType.DataRow)
        {
            CandidateTrainingJobHistoryBLL obj = (CandidateTrainingJobHistoryBLL)item.DataItem;

            Label lbTraining_Job = (Label)item.FindControl("lbTraining_Job");
            lbTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            lbTraining_Job.Text = obj.Training_Job;

            Label lbYear = (Label)item.FindControl("lbYear");
            try { lbYear.Text = Convert.ToDateTime(obj.Year).ToString("dd/MM/yyyy"); }
            catch { lbYear.Text = ""; }

            Label lbSchool_Position = (Label)item.FindControl("lbSchool_Position");
            lbSchool_Position.Text = obj.School_Position;

            Label lbMajor_Salary = (Label)item.FindControl("lbMajor_Salary");
            lbMajor_Salary.Text = obj.Major_Salary;

        }
    }
    protected void grdSAGSFamily_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow item = e.Row;
        if (item.RowType == DataControlRowType.DataRow)
        {
            CandidateTrainingJobHistoryBLL obj = (CandidateTrainingJobHistoryBLL)item.DataItem;

            Label lbTraining_Job = (Label)item.FindControl("lbTraining_Job");
            lbTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            lbTraining_Job.Text = obj.Training_Job;

            Label lbSchool_Position = (Label)item.FindControl("lbSchool_Position");
            lbSchool_Position.Text = obj.School_Position;

            Label lbMajor_Salary = (Label)item.FindControl("lbMajor_Salary");
            lbMajor_Salary.Text = obj.Major_Salary;

        }
    }
    protected void grdInforConfirm_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow item = e.Row;
        if (item.RowType == DataControlRowType.DataRow)
        {
            CandidateTrainingJobHistoryBLL obj = (CandidateTrainingJobHistoryBLL)item.DataItem;

            Label lbTraining_Job = (Label)item.FindControl("lbTraining_Job");
            lbTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            lbTraining_Job.Text = obj.Training_Job;

            Label lbYear = (Label)item.FindControl("lbYear");
            lbYear.Text = obj.Year.ToString();

            Label lbSchool_Position = (Label)item.FindControl("lbSchool_Position");
            lbSchool_Position.Text = obj.School_Position;

            Label lbMajor_Salary = (Label)item.FindControl("lbMajor_Salary");
            lbMajor_Salary.Text = obj.Major_Salary;

        }
    }
}