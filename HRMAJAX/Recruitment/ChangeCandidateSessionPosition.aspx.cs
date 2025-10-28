using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRMBLL.H2;
using HRMBLL.H2.Helper;
using HRMUtil;
using HRMUtil.KeyNames.H2;
using StringFormat = HRMUtil.StringFormat;

public partial class Recruitment_ChangeCandidateSessionPosition : System.Web.UI.Page
{
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = Constants.TITLE_RECRUITMENT_LIST;

            BindDataToDDLSession();
            BindDataToDDLSessionNew();
            BindDataToDDLPosition();
            if (Request.QueryString["SID"] != null)
                ddlSessions.SelectedValue = Request.QueryString["SID"];
            ClientScript.RegisterForEventValidation("GridView1");
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        var row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            var rv = (DataRowView)e.Row.DataItem;
            var lbLastName = (Label)e.Row.FindControl("lbLastName");
            var lbFirstName = (Label)e.Row.FindControl("lbFirstName");
            var lbSex = (Label)e.Row.FindControl("lbSex");
            var lbBirthday = (Label)e.Row.FindControl("lbBirthday");

            var candidateId = rv[CandidatesKeys.FIELD_CANDIDATE_ID] == DBNull.Value
                ? 0
                : int.Parse(rv[CandidatesKeys.FIELD_CANDIDATE_ID].ToString());
            lbLastName.Text = rv["LastName"].ToString();
            
            lbFirstName.Text = rv["FirstName"].ToString();

            var Sex = rv[CandidatesKeys.FIELD_CANDIDATE_SEX] == DBNull.Value
                ? false
                : bool.Parse(rv[CandidatesKeys.FIELD_CANDIDATE_SEX].ToString());
            if (Sex)
                lbSex.Text = "Nam";
            else
                lbSex.Text = "Nữ";
            var dayOfBirth = rv[CandidatesKeys.FIELD_CANDIDATE_DATE_OF_BIRTH] == DBNull.Value
                ? 0
                : int.Parse(rv[CandidatesKeys.FIELD_CANDIDATE_DATE_OF_BIRTH].ToString());
            var monthOfBirth = rv[CandidatesKeys.FIELD_CANDIDATE_MONTH_OF_BIRTH] == DBNull.Value
                ? 0
                : int.Parse(rv[CandidatesKeys.FIELD_CANDIDATE_MONTH_OF_BIRTH].ToString());
            var yearOfBirth = rv[CandidatesKeys.FIELD_CANDIDATE_YEAR_OF_BIRTH] == DBNull.Value
                ? 0
                : int.Parse(rv[CandidatesKeys.FIELD_CANDIDATE_YEAR_OF_BIRTH].ToString());

            var day = dayOfBirth.ToString();
            if (day.Length == 1)
                day = "0" + day;
            var month = monthOfBirth.ToString();
            if (month.Length == 1)
                month = "0" + month;

            if ((dayOfBirth > 0) && (monthOfBirth > 0) && (yearOfBirth > 0))
                lbBirthday.Text = day + "/" + month + "/" + yearOfBirth;
            else if ((monthOfBirth > 0) && (yearOfBirth > 0))
                lbBirthday.Text = month + "/" + yearOfBirth;
            else if (yearOfBirth > 0)
                lbBirthday.Text = yearOfBirth.ToString();
            else
                lbBirthday.Text = string.Empty;

            var lbPositionName = (Label)e.Row.FindControl("lbPositionName");
            lbPositionName.Text = rv["PositionName"].ToString();

            //var ltEducationLevel = (Literal)e.Row.FindControl("ltEducationLevel");


            //ltEducationLevel.Text = getEducationLevel(candidateId);

            //var ltExperience = (Literal)e.Row.FindControl("ltExperience");

            //ltExperience.Text = getExperience(candidateId);


            var lbCandidateNumber = (Label)row.FindControl("lbCandidateNumber");
            var candidateNumber = rv["CandidateNumber"] == DBNull.Value
                ? 0
                : int.Parse(rv["CandidateNumber"].ToString());
            if ((candidateNumber > 0) && (candidateNumber < 50000))
                lbCandidateNumber.Text = candidateNumber.ToString();
            

            var lbCandidateStatus = (Label)row.FindControl("lbCandidateStatus");
            try
            {
                var CandidateStatus = int.Parse(rv["CandidateStatus"].ToString());
                lbCandidateStatus.Text = Constants.GetCandidateStatusNameById(CandidateStatus);
                if (CandidateStatus == Constants.Candidate_Status_Unapproved_Id)
                {
                    lbCandidateStatus.Font.Bold = true;
                    lbCandidateStatus.ForeColor = Color.White;
                    row.Cells[13].BackColor = Color.Red;
                    //row.CssClass = "grid-item-Warning"; 
                }
            }
            catch
            {
                lbCandidateStatus.Text = "";
            }

            e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
            e.Row.ToolTip = "Click để chọn";
        }
    }
    protected void ddlSessions_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDataToDDLPosition();
        GridView1.DataBind();
    }
    private void BindDataToDDLSession()
    {
        ddlSessions.DataSource = SessionsBLL.GetAll();
        ddlSessions.DataTextField = "Name";
        ddlSessions.DataValueField = "Id";
        ddlSessions.DataBind();
    }
    private void BindDataToDDLSessionNew()
    {
        ddlSessionsNew.DataSource = SessionsBLL.GetAll();
        ddlSessionsNew.DataTextField = "Name";
        ddlSessionsNew.DataValueField = "Id";
        ddlSessionsNew.DataBind();
    }

    private void BindDataToDDLPosition()
    {
        ddlPositions.Items.Clear();
        ddlPositions.Items.Add(new ListItem("", "0"));
        ddlPositions.DataSource = SessionsBLL.GetPositionBySessionId(int.Parse(ddlSessions.SelectedValue));
        ddlPositions.DataTextField = "PositionName";
        ddlPositions.DataValueField = "PositionId";
        ddlPositions.DataBind();
    }
    protected void odsCandidateList_Selected(object sender, ObjectDataSourceStatusEventArgs e)
    {
        var list = (DataTable)e.ReturnValue;
        if (list != null)
        {
            int countMen = 0, countWomen = 0, countApproved = 0;
            var Sex = false;
            var candidateStatus = 0;
            foreach (DataRow rv in list.Rows)
            {
                Sex = rv[CandidatesKeys.FIELD_CANDIDATE_SEX] == DBNull.Value
                    ? false
                    : bool.Parse(rv[CandidatesKeys.FIELD_CANDIDATE_SEX].ToString());
                candidateStatus = rv["CandidateStatus"] == DBNull.Value
                    ? 0
                    : int.Parse(rv["CandidateStatus"].ToString());
                if (Sex)
                    countMen++;
                else
                    countWomen++;
                if (candidateStatus == Constants.Candidate_Status_Approved_Ok_Id)
                    countApproved++;
            }

            UcTitle1.CountRecord = "Tổng số " + countMen + " nam và " + countWomen + " nữ : " + list.Rows.Count +
                                   " (HS đạt:" + countApproved + ")";
        }
    }
    protected void odsCandidateList_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        var positionId = int.Parse(ddlPositions.SelectedValue);
        var sesionId = int.Parse(ddlSessions.SelectedValue);
        e.InputParameters["firstName"] = StringFormat.TrimFullName(txtFirstName.Text);
        e.InputParameters["positionId"] = positionId;
        e.InputParameters["result"] = -10;
        e.InputParameters["sessionId"] = sesionId;
        e.InputParameters["type"] = -1;
        e.InputParameters["sessionType"] = -1;
        e.InputParameters["TypeSort"] = 0;
        e.InputParameters["isBlack"] = 0;
    }
    private string getExperience(int candidateId)
    {
        var Experience = string.Empty;
        var lstJOB = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(candidateId, "JOB");
        for (var i = 0; i < lstJOB.Count; i++)
        {
            var objJOB = lstJOB[i];
            if (objJOB.Training_Job.Trim().Length > 0)
            {
                if (objJOB.School_Position.Trim().Length > 0)
                    Experience += "- " + objJOB.Training_Job + ": " + objJOB.School_Position;
                else
                    Experience += "- " + objJOB.Training_Job;
                Experience += "<br>";
            }
        }
        return Experience;
    }

    private string getEducationLevelName(int Id)
    {
        return HRMBLL.H2.EducationLevelsBLL.GetById(Id) != null
            ? HRMBLL.H2.EducationLevelsBLL.GetById(Id)["Name"].ToString()
            : "";
    }

    private string getEducationLevel(int candidateId)
    {
        var educationLevel = string.Empty;
        //List<CandidateEducationLevelsBLL> listCEL = CandidateEducationLevelsBLL.GetById(obj.Id);
        var lstEDU = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(candidateId, "EDU");
        for (var i = 0; i < lstEDU.Count; i++)
        {
            var objEDU = lstEDU[i];
            if (objEDU.Training_Job.Trim().Length > 0)
            {
                if (objEDU.Major_Salary.Trim().Length > 0)
                {
                    try
                    {
                        educationLevel += "- " + getEducationLevelName(Convert.ToInt32(objEDU.Training_Job)) + ": " +
                                          objEDU.Major_Salary;
                    }
                    catch
                    {
                        educationLevel += "- " + objEDU.Training_Job + ": " +
                                          objEDU.Major_Salary;
                    }
                }
                else
                {
                    try
                    {
                        educationLevel += "- " + getEducationLevelName(Convert.ToInt32(objEDU.Training_Job));
                    }
                    catch
                    {
                        educationLevel += "- " + (objEDU.Training_Job);
                    }
                }
                //if (objCEL.Remark.Trim().Length > 0)
                //{
                //    educationLevel += " (" + objCEL.Remark + ")";
                //}
                educationLevel += "<br>";
            }
        }
        var lstTRN = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(candidateId, "TRN");
        for (var i = 0; i < lstTRN.Count; i++)
        {
            var objTRN = lstTRN[i];
            if (objTRN.Training_Job.Trim().Length > 0)
            {
                if (objTRN.Major_Salary.Trim().Length > 0)
                    educationLevel += "- " + objTRN.Training_Job + ": " + objTRN.Major_Salary;
                else
                    educationLevel += "- " + objTRN.Training_Job;

                educationLevel += "<br>";
            }
        }
        var lstTIC = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(candidateId, "TIC");
        for (var i = 0; i < lstTIC.Count; i++)
        {
            var objTIC = lstTIC[i];
            if (objTIC.Training_Job.Trim().Length > 0)
            {
                if (objTIC.Major_Salary.Trim().Length > 0)
                    educationLevel += "- " + objTIC.Training_Job + ": " + objTIC.Major_Salary + "(chưa hoàn tất)";
                else
                    educationLevel += "- " + objTIC.Training_Job;
                educationLevel += "<br>";
            }
        }
        var lstENC = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(candidateId, "ENC");
        for (var i = 0; i < lstENC.Count; i++)
        {
            var objTENC = lstENC[i];
            if (objTENC.Training_Job.Trim().Length > 0)
            {
                if (objTENC.Major_Salary.Trim().Length > 0)
                    educationLevel += "- " + objTENC.Training_Job + ": " + objTENC.Major_Salary;
                else
                    educationLevel += "- " + objTENC.Training_Job;
                educationLevel += "<br>";
            }
        }

        return educationLevel;
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            CandidateId = Convert.ToInt32(GridView1.Rows[GridView1.SelectedIndex].Cells[0].Text);
            CandidatesBLL candidate = CandidatesBLL.GetById(CandidateId);
            selectedCandidate.Text = candidate.LastName + " " + candidate.FirstName;
            ddlSessionsNew.SelectedValue = candidate.SessionId.ToString();


            ddlPositionsNew.Items.Clear();
            ddlPositionsNew.Items.Add(new ListItem("", "0"));
            ddlPositionsNew.DataSource = SessionsBLL.GetPositionBySessionId(int.Parse(ddlSessionsNew.SelectedValue));
            ddlPositionsNew.DataTextField = "PositionName";
            ddlPositionsNew.DataValueField = "PositionId";
            ddlPositionsNew.DataBind();

            ddlPositionsNew.SelectedValue = candidate.PositionId.ToString();
        }
        catch
        {

        }
    }

    protected void ddlSessionsNew_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlPositionsNew.Items.Clear();
        ddlPositionsNew.Items.Add(new ListItem("", "0"));
        ddlPositionsNew.DataSource = SessionsBLL.GetPositionBySessionId(int.Parse(ddlSessionsNew.SelectedValue));
        ddlPositionsNew.DataTextField = "PositionName";
        ddlPositionsNew.DataValueField = "PositionId";
        ddlPositionsNew.DataBind();
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            CandidatesBLL.UpdateCandidateSessionPosition(CandidateId, int.Parse(ddlSessionsNew.SelectedValue), int.Parse(ddlPositionsNew.SelectedValue));
            UcTitle1.ErrorText = "Cập nhật thành công!";
            GridView1.DataBind();
            GridView1.SelectedIndex = 0;
            GridView1_SelectedIndexChanged(this, null);
        }
        catch (Exception ex)
        {
            UcTitle1.ErrorText = "Cập nhật không thành công!" + ex.Message;
        }
    }
}