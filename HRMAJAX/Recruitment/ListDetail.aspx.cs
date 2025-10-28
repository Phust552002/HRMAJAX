using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRMBLL.H2;
using HRMUtil;
using HRMUtil.KeyNames.H0;
using HRMUtil.KeyNames.H2;

public partial class Recruitment_ListDetail : Page
{
    private readonly string[,] Mảng = new string[14, 18];
        //Tạo mảng có 14 hàng và 17 cột, mỗi hàng chứa các ký tự cùng nhóm

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "ĐƠN DỰ TUYỂN ĐÀO TẠO";
            cpDateCV.SelectedDate = DateTime.Now;
            BindCandidateStatus();
            //if (Session[Constants.KEY_CANDIDATE_CURRENT] != null)
            //{
            //    CandidateId = Convert.ToInt32(Session[Constants.KEY_CANDIDATE_CURRENT]);
            //}
            if (Request.QueryString["SID"] != null)
                SessionId = int.Parse(Request.QueryString["SID"]);
            if (Request.QueryString["Id"] != null)
                CandidateId = int.Parse(Request.QueryString["Id"]);
            else
                BackList();

            if (CandidateId > 0)
                ShowInfor();

            BindDataList();
        }
    }

    private void BindCandidateStatus()
    {
        var listLP = Constants.GetAllCandidateStatus();

        ddlCandidateStatus.DataSource = listLP;
        ddlCandidateStatus.DataTextField = "UnitName";
        ddlCandidateStatus.DataValueField = "UnitId";
        ddlCandidateStatus.DataBind();
    }

    private void BindDataList()
    {
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

    private void ShowInfor()
    {
        if (CandidateId > 0)
        {
            var dr = CandidatesBLL.GetByIdForDataRow(CandidateId);

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
            txtBirthPlace.Text = dr["BirthPlace"] == DBNull.Value ? string.Empty : dr["BirthPlace"].ToString();
            txtNation.Text = dr["Nation"] == DBNull.Value ? string.Empty : dr["Nation"].ToString();
            txtNationality.Text = dr["Nationality"] == DBNull.Value ? string.Empty : dr["Nationality"].ToString();

            txtPositionName.Text = dr[PositionKeys.FIELD_POSITION_NAME] == DBNull.Value
                ? string.Empty
                : dr[PositionKeys.FIELD_POSITION_NAME].ToString();

            txtLastName.Text = dr[CandidatesKeys.FIELD_CANDIDATE_LASTNAME] == DBNull.Value
                ? string.Empty
                : dr[CandidatesKeys.FIELD_CANDIDATE_LASTNAME].ToString();
            txtFirstName.Text = dr[CandidatesKeys.FIELD_CANDIDATE_FIRSTNAME] == DBNull.Value
                ? string.Empty
                : dr[CandidatesKeys.FIELD_CANDIDATE_FIRSTNAME].ToString();

            txtHeight.Text = dr["Height"] == DBNull.Value ? string.Empty : dr["Height"].ToString();
            txtWeight.Text = dr["Weight"] == DBNull.Value ? string.Empty : dr["Weight"].ToString();
            txtLive.Text = dr["Live"] == DBNull.Value ? string.Empty : dr["Live"].ToString();
            txtResident.Text = dr["Resident"] == DBNull.Value ? string.Empty : dr["Resident"].ToString();
            txtIdCard.Text = dr["IdCard"] == DBNull.Value ? string.Empty : dr["IdCard"].ToString();
            cpIdDateOfIssue.SelectedDate = dr["IdDateOfIssue"] == DBNull.Value
                ? FormatDate.GetSQLDateMinValue
                : Convert.ToDateTime(dr["IdDateOfIssue"].ToString());
            txtIdPlaceOfIssue.Text = dr["IdPlaceOfIssue"] == DBNull.Value
                ? string.Empty
                : dr["IdPlaceOfIssue"].ToString();
            txtHomeTownAddress.Text = dr["HomeTownAddress"] == DBNull.Value
                ? string.Empty
                : dr["HomeTownAddress"].ToString();
            txtHandPhone.Text = dr["HandPhone"] == DBNull.Value ? string.Empty : dr["HandPhone"].ToString();
            txtWorkingPhone.Text = dr["WorkingPhone"] == DBNull.Value ? string.Empty : dr["WorkingPhone"].ToString();
            txtEmail.Text = dr["Email"] == DBNull.Value ? string.Empty : dr["Email"].ToString();


            var dayOfBirth = dr[CandidatesKeys.FIELD_CANDIDATE_DATE_OF_BIRTH] == DBNull.Value
                ? 0
                : int.Parse(dr[CandidatesKeys.FIELD_CANDIDATE_DATE_OF_BIRTH].ToString());
            var monthOfBirth = dr[CandidatesKeys.FIELD_CANDIDATE_MONTH_OF_BIRTH] == DBNull.Value
                ? 0
                : int.Parse(dr[CandidatesKeys.FIELD_CANDIDATE_MONTH_OF_BIRTH].ToString());
            var yearOfBirth = dr[CandidatesKeys.FIELD_CANDIDATE_YEAR_OF_BIRTH] == DBNull.Value
                ? 0
                : int.Parse(dr[CandidatesKeys.FIELD_CANDIDATE_YEAR_OF_BIRTH].ToString());

            try
            {
                var dtBirthday = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
                cpBirthday.SelectedDate = dtBirthday.Date;
            }
            catch
            {
            }


            var sex = dr["Sex"] == DBNull.Value ? false : Convert.ToBoolean(dr["Sex"].ToString());
            if (sex)
                ddlSex.SelectedValue = "1";
            else
                ddlSex.SelectedValue = "0";

            var Marriage = dr["Marriage"] == DBNull.Value ? 0 : int.Parse(dr["Marriage"].ToString());
            ddlMarriage.SelectedValue = Marriage.ToString();


            txtSalary_Present.Text = dr["Salary_Present"] == DBNull.Value ? "" : dr["Salary_Present"].ToString();
            txtSalary_Offer.Text = dr["Salary_Offer"] == DBNull.Value ? "" : dr["Salary_Offer"].ToString();

            ddlContract_YesNo.SelectedValue = dr["Contract_YesNo"] == DBNull.Value
                ? "0"
                : dr["Contract_YesNo"].ToString();
            cpContract_Present_Date.SelectedDate = dr["Contract_Present_Date"] == DBNull.Value
                ? FormatDate.GetSQLDateMinValue
                : Convert.ToDateTime(dr["Contract_Present_Date"].ToString());

            ddlContract_Present_End.SelectedValue = dr["Contract_Present_End"] == DBNull.Value
                ? "0"
                : dr["Contract_Present_End"].ToString();
            cpContract_New_StartDate.SelectedDate = dr["Contract_New_StartDate"] == DBNull.Value
                ? FormatDate.GetSQLDateMinValue
                : Convert.ToDateTime(dr["Contract_New_StartDate"].ToString());

            txtHealth_Present.Text = dr["Health_Present"] == DBNull.Value ? "" : dr["Health_Present"].ToString();
            txtHealth_Body.Text = dr["Health_Body"] == DBNull.Value ? "" : dr["Health_Body"].ToString();


            cpDateCV.SelectedDate = dr["CV_ReceivedDate"] == DBNull.Value
                ? FormatDate.GetSQLDateMinValue
                : Convert.ToDateTime(dr["CV_ReceivedDate"].ToString());
            var SAGS_Family = dr["SAGS_Family"] == DBNull.Value ? 0 : int.Parse(dr["SAGS_Family"].ToString());
            ddlSAGS_Family.SelectedValue = SAGS_Family.ToString();

            txtCVContent.Text = dr["CV_Content"] == DBNull.Value ? "" : dr["CV_Content"].ToString();

            var CandidateNumber = dr[CandidatesKeys.Field_Cadidate_CandidateNumber] == DBNull.Value
                ? 0
                : int.Parse(dr[CandidatesKeys.Field_Cadidate_CandidateNumber].ToString());
            if ((CandidateNumber == 0) || (CandidateNumber == 50000))
                txtCandidateNumber.Text = "";
                    // dr[CandidatesKeys.Field_Cadidate_CandidateNumber] == DBNull.Value ? "" : dr[CandidatesKeys.Field_Cadidate_CandidateNumber].ToString();
            else
                txtCandidateNumber.Text = CandidateNumber.ToString();
            txtRemark.Text = dr["Remark"] == DBNull.Value ? string.Empty : dr["Remark"].ToString();
            ddlCandidateStatus.SelectedValue = dr["CandidateStatus"].ToString();
        }
    }

    protected void btnApproval_Click(object sender, EventArgs e)
    {
        try
        {
            var candidateNumber = int.Parse(txtCandidateNumber.Text.Trim().Length <= 0 ? "0" : txtCandidateNumber.Text);
            if (candidateNumber == 0)
                candidateNumber = 50000;
            var remark = txtRemark.Text;

            CandidatesBLL.UpdateByCandidateStatus(int.Parse(ddlCandidateStatus.SelectedValue), 0, remark,
                candidateNumber, CandidateId);
            BackList();
        }
        catch (HRMException he)
        {
            UcTitle1.ErrorText = he.Message;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            CandidatesBLL.Delete(CandidateId);
            BackList();
        }
        catch (HRMException he)
        {
            UcTitle1.ErrorText = he.Message;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        BackList();
    }

    protected void btnPrint_Click(object sender, EventArgs e)
    {
        if (Save())
            Response.Redirect("~/Recruitment/RegistrationPrint.aspx?Id=" + CandidateId);
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Save();
    }

    private bool Save()
    {
        var returnbool = false;
        if (CheckInvalid())
            try
            {
                SaveInfor();

                SaveEducation();
                SaveTraining();
                SaveTrainingIncomplete();
                SaveEnglishComputer();
                SaveJob();
                SaveExperience();
                SaveExperienceOther();
                SaveFatherMother();
                SaveSAGSFamily();
                SaveInforConfirm();

                //////////////////////////////////////////////////////////////
                BindDataList();
                //////////////////////////////////////////////////////////////

                lbResult.Text = "CẬP NHẬT THÔNG TIN THÀNH CÔNG";
                UcTitle1.ErrorText = "CẬP NHẬT THÔNG TIN THÀNH CÔNG";
                returnbool = true;
            }
            catch (HRMException he)
            {
                UcTitle1.ErrorText = he.Message;
                lbResult.Text = he.Message;
                returnbool = false;
            }
        else
            returnbool = false;
        return returnbool;
    }

    private void SaveInfor()
    {
        var LastName = txtLastName.Text;
        var FirstName = txtFirstName.Text;

        var Height = float.Parse(txtHeight.Text.Trim().Length <= 0 ? "0" : txtHeight.Text);
        var Weight = float.Parse(txtWeight.Text.Trim().Length <= 0 ? "0" : txtWeight.Text);
        var Live = txtLive.Text;
        var Resident = txtResident.Text;
        var IdCard = txtIdCard.Text;
        var IdDateOfIssue = cpIdDateOfIssue.SelectedDate;
        var IdPlaceOfIssue = txtIdPlaceOfIssue.Text;
        var HomeTownAddress = txtHomeTownAddress.Text;
        var HandPhone = txtHandPhone.Text;
        var WorkingPhone = txtWorkingPhone.Text;
        var Email = txtEmail.Text;


        var dayOfBirth = cpBirthday.SelectedDate.Day;
        var monthOfBirth = cpBirthday.SelectedDate.Month;
        var yearOfBirth = cpBirthday.SelectedDate.Year;

        //DateTime dtBirthday = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);


        var sex = false;
        if (ddlSex.SelectedValue == "1")
            sex = true;


        var Marriage = int.Parse(ddlMarriage.SelectedValue);


        var Salary_Present = txtSalary_Present.Text;
        var Salary_Offer = txtSalary_Offer.Text;

        var Contract_YesNo = int.Parse(ddlContract_YesNo.SelectedValue);
        var Contract_Present_Date = cpContract_Present_Date.SelectedDate;

        var Contract_Present_End = int.Parse(ddlContract_Present_End.SelectedValue);
        var Contract_New_StartDate = cpContract_New_StartDate.SelectedDate;

        var Health_Present = txtHealth_Present.Text;
        var Health_Body = txtHealth_Body.Text;

        var SAGS_Family = int.Parse(ddlSAGS_Family.SelectedValue);

        var CV_Content = txtCVContent.Text;

        var candidateNumber = int.Parse(txtCandidateNumber.Text.Trim().Length <= 0 ? "0" : txtCandidateNumber.Text);
        if (candidateNumber == 0)
            candidateNumber = 50000;
        var remark = txtRemark.Text;

        var BirthPlace = txtBirthPlace.Text;
        var Nation = txtNation.Text;
        var Nationality = txtNationality.Text;

        CandidatesBLL.UpdateForRegistration(LastName, FirstName, Height, Weight, Live, Resident, IdCard, IdDateOfIssue,
            IdPlaceOfIssue, HomeTownAddress, HandPhone, WorkingPhone, Email, dayOfBirth, monthOfBirth, yearOfBirth, sex,
            Marriage, Salary_Present, Salary_Offer, Contract_Present_Date, Contract_Present_End, Contract_New_StartDate,
            Health_Present, Health_Body, cpDateCV.SelectedDate, SAGS_Family, Contract_YesNo, CV_Content, CandidateId,
            remark, candidateNumber, BirthPlace, Nation, Nationality);
    }


    private string Bodau(string fullName)
    {
        string Tạm1, Tạm2;
        byte i, j, n;
        // Gán cho biến Tạm1 nội dung trong TxtViết 
        Tạm1 = fullName;
        //Tiến hành thay thế , lọc bỏ dấu cho chuỗi
        for (j = 0; j < 13; j++)
            for (i = 1; i < 17; i++)
            {
                Tạm2 = Tạm1.Replace(Mảng[j, i], Mảng[j, 0]);
                Tạm1 = Tạm2;
            }
        return Tạm1;
    }

    private void NapChuoiMau()
    {
        byte i, j, n;
        var Chuỗi = "";
        string Thga, Thge, Thgo, Thgu, Thgi, Thgd, Thgy;
        string HoaA, HoaE, HoaO, HoaU, HoaI, HoaD, HoaY;
        Chuỗi = "aAeEoOuUiIdDyY";
        Thga = "áàạảãâấầậẩẫăắằặẳẵ";
        HoaA = "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ";
        Thge = "éèẹẻẽêếềệểễeeeeee";
        HoaE = "ÉÈẸẺẼÊẾỀỆỂỄEEEEEE";
        Thgo = "óòọỏõôốồộổỗơớờợởỡ";
        HoaO = "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ";
        Thgu = "úùụủũưứừựửữuuuuuu";
        HoaU = "ÚÙỤỦŨƯỨỪỰỬỮUUUUUU";
        Thgi = "íìịỉĩiiiiiiiiiiii";
        HoaI = "ÍÌỊỈĨIIIIIIIIIIII";
        Thgd = "đdddddddddddddddd";
        HoaD = "ĐDDDDDDDDDDDDDDDD";
        Thgy = "ýỳỵỷỹyyyyyyyyyyyy";
        HoaY = "ÝỲỴỶỸYYYYYYYYYYYY";
        //Nạp vào trong Mảng các ký tự
        //Nạp vào từng đầu hàng các ký tự không dấu
        //Nạp vào cột đầu tiên
        for (i = 0; i <= 13; i++)
            Mảng[i, 0] = Chuỗi.Substring(i, 1);
        //Nạp vào từng ô các ký tự có dấu
        for (j = 1; j < 17; j++)
            for (i = 0; i < 17; i++)
            {
                Mảng[0, i + 1] = Thga.Substring(i, 1); //Nạp từng ký tự trong chuỗi Thga vào từng ô trong hàng 0
                Mảng[1, i + 1] = HoaA.Substring(i, 1); //Nạp từng ký tự trong chuỗi HoaA vào từng ô trong  hàng 1
                Mảng[2, i + 1] = Thge.Substring(i, 1); //Nạp từng ký tự trong chuỗi Thge vào từng ô trong  hàng 2
                Mảng[3, i + 1] = HoaE.Substring(i, 1); //Nạp từng ký tự trong chuỗi HoaE vào từng ô trong  hàng 3
                Mảng[4, i + 1] = Thgo.Substring(i, 1); //Nạp từng ký tự trong chuỗi Thgo vào từng ô trong  hàng 4
                Mảng[5, i + 1] = HoaO.Substring(i, 1); //Nạp từng ký tự trong chuỗi HoaO vào từng ô trong  hàng 5
                Mảng[6, i + 1] = Thgu.Substring(i, 1); //Nạp từng ký tự trong chuỗi Thgu vào từng ô trong  hàng 6
                Mảng[7, i + 1] = HoaU.Substring(i, 1); //Nạp từng ký tự trong chuỗi HoaU vào từng ô trong  hàng 7
                Mảng[8, i + 1] = Thgi.Substring(i, 1); //Nạp từng ký tự trong chuỗi Thgi vào từng ô trong  hàng 8
                Mảng[9, i + 1] = HoaI.Substring(i, 1); //Nạp từng ký tự trong chuỗi HoaI vào từng ô trong  hàng 9
                Mảng[10, i + 1] = Thgd.Substring(i, 1); //Nạp từng ký tự trong chuỗi Thgd vào từng ô trong  hàng 10
                Mảng[11, i + 1] = HoaD.Substring(i, 1); //Nạp từng ký tự trong chuỗi HoaD vào từng ô trong  hàng 11
                Mảng[12, i + 1] = Thgy.Substring(i, 1); //Nạp từng ký tự trong chuỗi Thgy vào từng ô trong  hàng 12
                Mảng[13, i + 1] = HoaY.Substring(i, 1); //Nạp từng ký tự trong chuỗi HoaY vào từng ô trong  hàng 13
            }
    }

    private bool CheckInvalid()
    {
        if (txtLastName.Text.Trim().Length <= 0)
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP HỌ TÊN LÓT";
            lbResult.Text = "BẠN PHẢI NHẬP HỌ TÊN LÓT";
            lbLastNameError.Text = "***";
            return false;
        }
        if (txtFirstName.Text.Trim().Length <= 0)
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP TÊN";
            lbResult.Text = "BẠN PHẢI NHẬP TÊN";
            lbFirstNameError.Text = "***";
            return false;
        }
        if (txtHeight.Text.Trim().Length <= 0)
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP CHIỀU CAO";
            lbResult.Text = "BẠN PHẢI NHẬP CHIỀU CAO";
            lbHeightError.Text = "***";
            return false;
        }
        if (txtWeight.Text.Trim().Length <= 0)
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP CÂN NẶNG";
            lbResult.Text = "BẠN PHẢI NHẬP CÂN NẶNG";
            lbWeightError.Text = "***";
            return false;
        }
        if (cpBirthday.SelectedDate.Equals(FormatDate.GetSQLDateMinValue))
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP NGÀY THÁNG NĂM SINH";
            lbResult.Text = "BẠN PHẢI NHẬP NGÀY THÁNG NĂM SINH";
            lbBirthdayError.Text = "***";
            return false;
        }
        try
        {
            double.Parse(txtHeight.Text);
        }
        catch
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP CHIỀU CAO LÀ KÝ TỰ SỐ";
            lbResult.Text = "BẠN PHẢI NHẬP CHIỀU CAO LÀ KÝ TỰ SỐ";
            lbHeightError.Text = "***";
            return false;
        }
        //if (ddlSex.SelectedValue == "0")
        //{
        //    if (double.Parse(txtHeight.Text) < 158)
        //    {
        //        UcTitle1.ErrorText = "BẠN LÀ NỮ PHẢI CÓ CHIỀU CAO TỪ 158cm TRỞ LÊN";
        //        lbResult.Text = "BẠN LÀ NỮ PHẢI CÓ CHIỀU CAO TỪ 158cm TRỞ LÊN";
        //        lbHeightError.Text = "***";
        //        return false;
        //    }
        //}
        //else
        //{
        //    if (double.Parse(txtHeight.Text) < 168)
        //    {
        //        UcTitle1.ErrorText = "BẠN LÀ NAM PHẢI CÓ CHIỀU CAO TỪ 168cm TRỞ LÊN";
        //        lbResult.Text = "BẠN LÀ NAM PHẢI CÓ CHIỀU CAO TỪ 168cm TRỞ LÊN";
        //        lbHeightError.Text = "***";
        //        return false;
        //    }
        //}
        try
        {
            double.Parse(txtWeight.Text);
        }
        catch
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP CÂN NẶNG LÀ KÝ TỰ SỐ";
            lbResult.Text = "BẠN PHẢI NHẬP CÂN NẶNG LÀ KÝ TỰ SỐ";
            lbWeightError.Text = "***";
            return false;
        }
        /*foreach (DataListItem item in dlFatherMother.Items)
        {
            var obj = new CandidateTrainingJobHistoryBLL();
            var _Year = (UserControls_CalendarPicker)item.FindControl("cpFamilyBirthday");
            var Year = "";
            try
            {
                Year = _Year.SelectedDate.ToString();
            }
            catch
            {
                _Year.SelectedDate = FormatDate.GetSQLDateMinValue;
            }
            if (CheckDate(Year) == true && _Year.SelectedDate.Year > 1753)
            {
            }
            else
            {
                UcTitle1.ErrorText = "BẠN PHẢI NHẬP ĐẦY ĐỦ NGÀY/ THÁNG/ NĂM SINH";
                lbResult.Text = "BẠN PHẢI NHẬP ĐẦY ĐỦ NGÀY/ THÁNG/ NĂM SINH";
                return false;
            }
        }*/
        foreach (DataListItem item in dlEnglishComputer.Items)
        {
            var ddlEducationLevel = (DropDownList) item.FindControl("ddlEducationLevel");
            var Training_Job = ddlEducationLevel.SelectedItem.Text;
            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");

            if (Training_Job.Equals("TOEIC"))
            {
                double Major_Salary = 0;
                try
                {
                    Major_Salary = double.Parse(txtMajor_Salary.Text);
                }
                catch
                {
                    UcTitle1.ErrorText = "BẠN PHẢI NHẬP TOEIC LÀ KÝ TỰ SỐ";
                    lbResult.Text = "BẠN PHẢI NHẬP TOEIC LÀ KÝ TỰ SỐ";
                    return false;
                }
                //if (Major_Salary < 550)
                //{
                //    UcTitle1.ErrorText = "BẠN PHẢI NHẬP TOEIC TỪ 550 ĐIỂM TRỞ LÊN";
                //    lbResult.Text = "BẠN PHẢI NHẬP TOEIC TỪ 550 ĐIỂM TRỞ LÊN";
                //    return false;
                //}
            }
            if (Training_Job.Equals("TOEFL/iBT"))
            {
                double Major_Salary = 0;
                try
                {
                    Major_Salary = double.Parse(txtMajor_Salary.Text);
                }
                catch
                {
                    UcTitle1.ErrorText = "BẠN PHẢI NHẬP TOEFL/iBT LÀ KÝ TỰ SỐ";
                    lbResult.Text = "BẠN PHẢI NHẬP TOEFL/iBT LÀ KÝ TỰ SỐ";
                    return false;
                }
                //if (Major_Salary < 50)
                //{
                //    UcTitle1.ErrorText = "BẠN PHẢI NHẬP TOEFL/iBT TỪ 50 ĐIỂM TRỞ LÊN";
                //    lbResult.Text = "BẠN PHẢI NHẬP TOEFL/iBT TỪ 50 ĐIỂM TRỞ LÊN";
                //    return false;
                //}
            }
            if (Training_Job.Equals("IELTS"))
            {
                double Major_Salary = 0;
                try
                {
                    Major_Salary = double.Parse(txtMajor_Salary.Text);
                }
                catch
                {
                    UcTitle1.ErrorText = "BẠN PHẢI NHẬP IELTS LÀ KÝ TỰ SỐ";
                    lbResult.Text = "BẠN PHẢI NHẬP IELTS LÀ KÝ TỰ SỐ";
                    return false;
                }
                //if (Major_Salary < 5)
                //{
                //    UcTitle1.ErrorText = "BẠN PHẢI NHẬP IELTS TỪ 5.0 ĐIỂM TRỞ LÊN";
                //    lbResult.Text = "BẠN PHẢI NHẬP IELTS TỪ 5.0 ĐIỂM TRỞ LÊN";
                //    return false;
                //}
            }
        }

        foreach (DataListItem item in dlJob.Items)
        {
            var obj = new CandidateTrainingJobHistoryBLL();
            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");

            try
            {
                double.Parse(txtMajor_Salary.Text.Trim().Length <= 0 ? "0" : txtMajor_Salary.Text.Trim());
            }
            catch
            {
                UcTitle1.ErrorText = "BẠN PHẢI NHẬP TIỀN LƯƠNG QUÁ TRÌNH LÀM VIỆC MỤC C LÀ KÝ TỰ SỐ";
                lbResult.Text = "BẠN PHẢI NHẬP TIỀN LƯƠNG QUÁ TRÌNH LÀM VIỆC MỤC C LÀ KÝ TỰ SỐ";
                return false;
            }
        }
        try
        {
            double.Parse(txtSalary_Present.Text.Trim().Length <= 0 ? "0" : txtSalary_Present.Text.Trim());
        }
        catch
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP TIỀN LƯƠNG HIỆN NAY/MỖI THÁNG MỤC E LÀ KÝ TỰ SỐ";
            lbResult.Text = "BẠN PHẢI NHẬP TIỀN LƯƠNG HIỆN NAY/MỖI THÁNG MỤC E LÀ KÝ TỰ SỐ";
            lbSalary_PresentError.Text = "***";
            return false;
        }
        try
        {
            double.Parse(txtSalary_Offer.Text.Trim().Length <= 0 ? "0" : txtSalary_Offer.Text.Trim());
        }
        catch
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP TIỀN LƯƠNG ĐỀ NGHỊ/MỖI THÁNG MỤC E LÀ KÝ TỰ SỐ";
            lbResult.Text = "BẠN PHẢI NHẬP TIỀN LƯƠNG ĐỀ NGHỊ/MỖI THÁNG MỤC E LÀ KÝ TỰ SỐ";
            lbSalary_OfferError.Text = "***";
            return false;
        }
        //if (txtCVContent.Text.Length < 50)
        //{
        //    UcTitle1.ErrorText = "HỒ SƠ ĐÍNH KÈM PHẢI TỐI THIỂU 50 KÝ TỰ";
        //    lbResult.Text = "HỒ SƠ ĐÍNH KÈM PHẢI TỐI THIỂU 50 KÝ TỰ";
        //    return false;
        //}
        return true;
    }

    private void BackList()
    {
        Response.Redirect("~/Recruitment/List.aspx?SID=" + SessionId);
    }

    #region properties

    public int CandidateId
    {
        get
        {
            if (ViewState["CandidateId"] != null)
                return int.Parse(ViewState["CandidateId"].ToString());
            return 0;
        }
        set { ViewState["CandidateId"] = value; }
    }

    public int SessionId
    {
        get
        {
            if (ViewState["SessionId"] != null)
                return int.Parse(ViewState["SessionId"].ToString());
            return 0;
        }
        set { ViewState["SessionId"] = value; }
    }


    private string DeleteIDsEducation
    {
        get
        {
            if (ViewState["DeleteIDsEducation"] != null)
                return ViewState["DeleteIDsEducation"].ToString();
            return string.Empty;
        }
        set { ViewState["DeleteIDsEducation"] = value; }
    }

    private string DeleteIDsTraining
    {
        get
        {
            if (ViewState["DeleteIDsTraining"] != null)
                return ViewState["DeleteIDsTraining"].ToString();
            return string.Empty;
        }
        set { ViewState["DeleteIDsTraining"] = value; }
    }

    private string DeleteIDsTrainingIncomplete
    {
        get
        {
            if (ViewState["DeleteIDsTrainingIncomplete"] != null)
                return ViewState["DeleteIDsTrainingIncomplete"].ToString();
            return string.Empty;
        }
        set { ViewState["DeleteIDsTrainingIncomplete"] = value; }
    }

    private string DeleteIDsEnglishComputer
    {
        get
        {
            if (ViewState["DeleteIDsEnglishComputer"] != null)
                return ViewState["DeleteIDsEnglishComputer"].ToString();
            return string.Empty;
        }
        set { ViewState["DeleteIDsEnglishComputer"] = value; }
    }

    private string DeleteIDsJob
    {
        get
        {
            if (ViewState["DeleteIDsJob"] != null)
                return ViewState["DeleteIDsJob"].ToString();
            return string.Empty;
        }
        set { ViewState["DeleteIDsJob"] = value; }
    }

    private string DeleteIDsExperience
    {
        get
        {
            if (ViewState["DeleteIDsExperience"] != null)
                return ViewState["DeleteIDsExperience"].ToString();
            return string.Empty;
        }
        set { ViewState["DeleteIDsExperience"] = value; }
    }

    private string DeleteIDsExperienceOther
    {
        get
        {
            if (ViewState["DeleteIDsExperienceOther"] != null)
                return ViewState["DeleteIDsExperienceOther"].ToString();
            return string.Empty;
        }
        set { ViewState["DeleteIDsExperienceOther"] = value; }
    }

    private string DeleteIDsFatherMother
    {
        get
        {
            if (ViewState["DeleteIDsFatherMother"] != null)
                return ViewState["DeleteIDsFatherMother"].ToString();
            return string.Empty;
        }
        set { ViewState["DeleteIDsFatherMother"] = value; }
    }

    private string DeleteIDsSAGSFamily
    {
        get
        {
            if (ViewState["DeleteIDsSAGSFamily"] != null)
                return ViewState["DeleteIDsSAGSFamily"].ToString();
            return string.Empty;
        }
        set { ViewState["DeleteIDsSAGSFamily"] = value; }
    }

    private string DeleteIDsInforConfirm
    {
        get
        {
            if (ViewState["DeleteIDsInforConfirm"] != null)
                return ViewState["DeleteIDsInforConfirm"].ToString();
            return string.Empty;
        }
        set { ViewState["DeleteIDsInforConfirm"] = value; }
    }

    #endregion

    #region insert dlEducation

    public void BindEducation()
    {
        var list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "EDU");
        if (list.Count == 0)
        {
            var obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        dlEducation.DataSource = list;
        dlEducation.DataBind();
    }

    protected void dlEducation_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        var item = e.Item;
        if ((item.ItemType == ListItemType.Item) || (item.ItemType == ListItemType.AlternatingItem))
        {
            var obj = (CandidateTrainingJobHistoryBLL) e.Item.DataItem;

            var txtTraining_Job = (TextBox)item.FindControl("txtTraining_Job");
            if (txtTraining_Job != null)
            {
                txtTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
                txtTraining_Job.Text = obj.Training_Job;
            }
            var ddlEdu = (DropDownList)item.FindControl("ddlEducationLevel");
            var txtSelectedEdu = (TextBox)item.FindControl("txtSelectedEdu");
            try
            {
                ddlEdu.SelectedValue =
                    CandidateTrainingJobHistoryBLL.GetDRById(obj.CandidateTrainingJobHistoryId)["Experience"].ToString();
            }
            catch
            {
                ddlEdu.SelectedValue = obj.Experience;
            }

            var txtYear = (TextBox) item.FindControl("txtYear");
            txtYear.Text = obj.Year;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            txtSchool_Position.Text = obj.School_Position;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            txtMajor_Salary.Text = obj.Major_Salary;

            var txtGraduateYear_LeaveReason = (TextBox) item.FindControl("txtGraduateYear_LeaveReason");
            txtGraduateYear_LeaveReason.Text = obj.GraduateYear_LeaveReason;


            var imgAddNewRow = (ImageButton) item.FindControl("imgAddNewRow");
            var imgDeleteRow = (ImageButton) item.FindControl("imgDeleteRow");
            if (item.ItemIndex == obj.LastItem - 1)
                imgAddNewRow.Visible = true;
            else
                imgAddNewRow.Visible = false;


            imgDeleteRow.OnClientClick = "return confirm('Bạn có muốn xóa thông tin dòng này ?');";
            if (obj.LastItem <= 1)
                imgDeleteRow.Visible = false;
            else
                imgDeleteRow.Visible = true;
        }
    }

    protected void imgDeleteRowdlEducation_Click(object sender, ImageClickEventArgs e)
    {
        var imgDeleteRow = (ImageButton) sender;
        var itemSelected = (DataListItem) imgDeleteRow.Parent;
        var txtTraining_JobSelected = (TextBox) itemSelected.FindControl("txtTraining_Job");

        ////////////////////////////////////////////////////////////////////////////////////////////
        var Id = txtTraining_JobSelected.ToolTip.Length == 0 ? 0 : int.Parse(txtTraining_JobSelected.ToolTip);
        if (Id > 0)
            if (DeleteIDsEducation.Length <= 0)
                DeleteIDsEducation = Id.ToString();
            else
                DeleteIDsEducation = DeleteIDsEducation + "," + Id;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlEducation.Items)
        {
            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");

            if (!txtTraining_Job.ClientID.Equals(txtTraining_JobSelected.ClientID))
            {
                var obj = new CandidateTrainingJobHistoryBLL();

                obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
                obj.Training_Job = txtTraining_Job.Text;


                var txtYear = (TextBox) item.FindControl("txtYear");
                obj.Year = txtYear.Text;

                var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
                obj.School_Position = txtSchool_Position.Text;

                var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
                obj.Major_Salary = txtMajor_Salary.Text;

                var txtGraduateYear_LeaveReason = (TextBox) item.FindControl("txtGraduateYear_LeaveReason");
                obj.GraduateYear_LeaveReason = txtGraduateYear_LeaveReason.Text;


                obj.LastItem = dlEducation.Items.Count - 1;

                list.Add(obj);
            }
        }
        dlEducation.DataSource = list;
        dlEducation.DataBind();
    }

    protected void imgAddNewRowdlEducation_Click(object sender, ImageClickEventArgs e)
    {
        var imgAddNewRowRouting = (ImageButton) sender;
        var itemBaggageRouting = (DataListItem) imgAddNewRowRouting.Parent;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlEducation.Items)
        {
            var obj = new CandidateTrainingJobHistoryBLL();

            var txtTraining_Job = (TextBox)item.FindControl("txtTraining_Job");
            obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
            //obj.Training_Job = txtTraining_Job.Text;
            //DropDownList ddl = (DropDownList)item.FindControl("ddlFamily");
            //obj.Training_Job = HRMBLL.H2.CandidateTrainingJobHistoryBLL.GetDRById(obj.CandidateTrainingJobHistoryId)["GraduateYear_LeaveReason"].ToString();

            var ddlEdu = (DropDownList)item.FindControl("ddlEducationLevel");
            var txtSelectedEdu = (TextBox)item.FindControl("txtSelectedEdu");
            if (txtSelectedEdu != null)
                txtSelectedEdu.Text = ddlEdu != null ? ddlEdu.SelectedValue : "";
            if (txtSelectedEdu.Text.Length > 0)
                ddlEdu.SelectedValue = txtSelectedEdu.Text;
            else
                ddlEdu.SelectedValue = "";

            obj.Experience = txtSelectedEdu.Text;
            obj.Training_Job = CandidateTrainingJobHistoryBLL.GetDRById(obj.CandidateTrainingJobHistoryId) == null
                ? ddlEdu.SelectedItem.Text
                : CandidateTrainingJobHistoryBLL.GetDRById(obj.CandidateTrainingJobHistoryId)["Experience"].ToString();

            var txtYear = (TextBox) item.FindControl("txtYear");
            obj.Year = txtYear.Text;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            obj.School_Position = txtSchool_Position.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            obj.Major_Salary = txtMajor_Salary.Text;

            var txtGraduateYear_LeaveReason = (TextBox) item.FindControl("txtGraduateYear_LeaveReason");
            obj.GraduateYear_LeaveReason = txtGraduateYear_LeaveReason.Text;

            obj.LastItem = dlEducation.Items.Count + 1;
            list.Add(obj);
        }
        var obj1 = new CandidateTrainingJobHistoryBLL();
        obj1.CandidateTrainingJobHistoryId = 0;
        obj1.LastItem = list.Count + 1;
        list.Add(obj1);
        dlEducation.DataSource = list;
        dlEducation.DataBind();
    }

    private void SaveEducation()
    {
        if (DeleteIDsEducation.Length > 0)
        {
            CandidateTrainingJobHistoryBLL.Delete(DeleteIDsEducation);
            DeleteIDsEducation = string.Empty;
        }

        foreach (DataListItem item in dlEducation.Items)
        {
            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            var CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);

            var txtYear = (TextBox) item.FindControl("txtYear");
            var Year = txtYear.Text;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            var School_Position = txtSchool_Position.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            var Major_Salary = txtMajor_Salary.Text;

            var txtGraduateYear_LeaveReason = (TextBox) item.FindControl("txtGraduateYear_LeaveReason");
            var GraduateYear_LeaveReason = txtGraduateYear_LeaveReason.Text;

            var _ddlEdu = (DropDownList)item.FindControl("ddlEducationLevel");
            var Training_Job = _ddlEdu.SelectedItem.Text;
            var Experience = _ddlEdu.SelectedValue;

            if (CandidateTrainingJobHistoryId == 0)
                CandidateTrainingJobHistoryBLL.Insert(CandidateId, Training_Job, Year, School_Position, Major_Salary,
                    GraduateYear_LeaveReason, Experience, "EDU");
            else
                CandidateTrainingJobHistoryBLL.Update(CandidateId, Training_Job, Year, School_Position, Major_Salary,
                    GraduateYear_LeaveReason, Experience, "EDU", CandidateTrainingJobHistoryId);
        }
    }

    #endregion

    #region insert dlTraining

    public void BindTraining()
    {
        var list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "TRN");
        if (list.Count == 0)
        {
            var obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        dlTraining.DataSource = list;
        dlTraining.DataBind();
    }

    protected void dlTraining_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        var item = e.Item;
        if ((item.ItemType == ListItemType.Item) || (item.ItemType == ListItemType.AlternatingItem))
        {
            var obj = (CandidateTrainingJobHistoryBLL) e.Item.DataItem;

            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            txtTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            txtTraining_Job.Text = obj.Training_Job;

            var txtYear = (TextBox) item.FindControl("txtYear");
            txtYear.Text = obj.Year;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            txtSchool_Position.Text = obj.School_Position;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            txtMajor_Salary.Text = obj.Major_Salary;


            var imgAddNewRow = (ImageButton) item.FindControl("imgAddNewRow");
            var imgDeleteRow = (ImageButton) item.FindControl("imgDeleteRow");
            if (item.ItemIndex == obj.LastItem - 1)
                imgAddNewRow.Visible = true;
            else
                imgAddNewRow.Visible = false;


            imgDeleteRow.OnClientClick = "return confirm('Bạn có muốn xóa thông tin dòng này ?');";
            if (obj.LastItem <= 1)
                imgDeleteRow.Visible = false;
            else
                imgDeleteRow.Visible = true;
        }
    }

    protected void imgDeleteRowdlTraining_Click(object sender, ImageClickEventArgs e)
    {
        var imgDeleteRow = (ImageButton) sender;
        var itemSelected = (DataListItem) imgDeleteRow.Parent;
        var txtTraining_JobSelected = (TextBox) itemSelected.FindControl("txtTraining_Job");

        ////////////////////////////////////////////////////////////////////////////////////////////
        var Id = txtTraining_JobSelected.ToolTip.Length == 0 ? 0 : int.Parse(txtTraining_JobSelected.ToolTip);
        if (Id > 0)
            if (DeleteIDsTraining.Length <= 0)
                DeleteIDsTraining = Id.ToString();
            else
                DeleteIDsTraining = DeleteIDsTraining + "," + Id;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlTraining.Items)
        {
            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");

            if (!txtTraining_Job.ClientID.Equals(txtTraining_JobSelected.ClientID))
            {
                var obj = new CandidateTrainingJobHistoryBLL();

                obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
                obj.Training_Job = txtTraining_Job.Text;

                var txtYear = (TextBox) item.FindControl("txtYear");
                obj.Year = txtYear.Text;

                var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
                obj.School_Position = txtSchool_Position.Text;

                var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
                obj.Major_Salary = txtMajor_Salary.Text;

                obj.LastItem = dlTraining.Items.Count - 1;

                list.Add(obj);
            }
        }
        dlTraining.DataSource = list;
        dlTraining.DataBind();
    }

    protected void imgAddNewRowdlTraining_Click(object sender, ImageClickEventArgs e)
    {
        var imgAddNewRowRouting = (ImageButton) sender;
        var itemBaggageRouting = (DataListItem) imgAddNewRowRouting.Parent;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlTraining.Items)
        {
            var obj = new CandidateTrainingJobHistoryBLL();

            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
            obj.Training_Job = txtTraining_Job.Text;

            var txtYear = (TextBox) item.FindControl("txtYear");
            obj.Year = txtYear.Text;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            obj.School_Position = txtSchool_Position.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            obj.Major_Salary = txtMajor_Salary.Text;

            obj.LastItem = dlTraining.Items.Count + 1;
            list.Add(obj);
        }
        var obj1 = new CandidateTrainingJobHistoryBLL();
        obj1.CandidateTrainingJobHistoryId = 0;
        obj1.LastItem = list.Count + 1;
        list.Add(obj1);
        dlTraining.DataSource = list;
        dlTraining.DataBind();
    }

    private void SaveTraining()
    {
        if (DeleteIDsTraining.Length > 0)
        {
            CandidateTrainingJobHistoryBLL.Delete(DeleteIDsTraining);
            DeleteIDsTraining = string.Empty;
        }

        foreach (DataListItem item in dlTraining.Items)
        {
            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            var CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
            var Training_Job = txtTraining_Job.Text;

            var txtYear = (TextBox) item.FindControl("txtYear");
            var Year = txtYear.Text;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            var School_Position = txtSchool_Position.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            var Major_Salary = txtMajor_Salary.Text;


            if (CandidateTrainingJobHistoryId == 0)
                CandidateTrainingJobHistoryBLL.Insert(CandidateId, Training_Job, Year, School_Position, Major_Salary, "",
                    "", "TRN");
            else
                CandidateTrainingJobHistoryBLL.Update(CandidateId, Training_Job, Year, School_Position, Major_Salary, "",
                    "", "TRN", CandidateTrainingJobHistoryId);
        }
    }

    #endregion

    #region insert dlTrainingIncomplete

    public void BindTrainingIncomplete()
    {
        var list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "TIC");
        if (list.Count == 0)
        {
            var obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        dlTrainingIncomplete.DataSource = list;
        dlTrainingIncomplete.DataBind();
    }

    protected void dlTrainingIncomplete_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        var item = e.Item;
        if ((item.ItemType == ListItemType.Item) || (item.ItemType == ListItemType.AlternatingItem))
        {
            var obj = (CandidateTrainingJobHistoryBLL) e.Item.DataItem;

            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            txtTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            txtTraining_Job.Text = obj.Training_Job;

            var txtYear = (TextBox) item.FindControl("txtYear");
            txtYear.Text = obj.Year;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            txtSchool_Position.Text = obj.School_Position;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            txtMajor_Salary.Text = obj.Major_Salary;


            var imgAddNewRow = (ImageButton) item.FindControl("imgAddNewRow");
            var imgDeleteRow = (ImageButton) item.FindControl("imgDeleteRow");
            if (item.ItemIndex == obj.LastItem - 1)
                imgAddNewRow.Visible = true;
            else
                imgAddNewRow.Visible = false;


            imgDeleteRow.OnClientClick = "return confirm('Bạn có muốn xóa thông tin dòng này ?');";
            if (obj.LastItem <= 1)
                imgDeleteRow.Visible = false;
            else
                imgDeleteRow.Visible = true;
        }
    }

    protected void imgDeleteRowdlTrainingIncomplete_Click(object sender, ImageClickEventArgs e)
    {
        var imgDeleteRow = (ImageButton) sender;
        var itemSelected = (DataListItem) imgDeleteRow.Parent;
        var txtTraining_JobSelected = (TextBox) itemSelected.FindControl("txtTraining_Job");

        ////////////////////////////////////////////////////////////////////////////////////////////
        var Id = txtTraining_JobSelected.ToolTip.Length == 0 ? 0 : int.Parse(txtTraining_JobSelected.ToolTip);
        if (Id > 0)
            if (DeleteIDsTrainingIncomplete.Length <= 0)
                DeleteIDsTrainingIncomplete = Id.ToString();
            else
                DeleteIDsTrainingIncomplete = DeleteIDsTrainingIncomplete + "," + Id;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlTrainingIncomplete.Items)
        {
            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");

            if (!txtTraining_Job.ClientID.Equals(txtTraining_JobSelected.ClientID))
            {
                var obj = new CandidateTrainingJobHistoryBLL();

                obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
                obj.Training_Job = txtTraining_Job.Text;

                var txtYear = (TextBox) item.FindControl("txtYear");
                obj.Year = txtYear.Text;

                var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
                obj.School_Position = txtSchool_Position.Text;

                var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
                obj.Major_Salary = txtMajor_Salary.Text;

                obj.LastItem = dlTrainingIncomplete.Items.Count - 1;

                list.Add(obj);
            }
        }
        dlTrainingIncomplete.DataSource = list;
        dlTrainingIncomplete.DataBind();
    }

    protected void imgAddNewRowdlTrainingIncomplete_Click(object sender, ImageClickEventArgs e)
    {
        var imgAddNewRowRouting = (ImageButton) sender;
        var itemBaggageRouting = (DataListItem) imgAddNewRowRouting.Parent;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlTrainingIncomplete.Items)
        {
            var obj = new CandidateTrainingJobHistoryBLL();

            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
            obj.Training_Job = txtTraining_Job.Text;

            var txtYear = (TextBox) item.FindControl("txtYear");
            obj.Year = txtYear.Text;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            obj.School_Position = txtSchool_Position.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            obj.Major_Salary = txtMajor_Salary.Text;

            obj.LastItem = dlTrainingIncomplete.Items.Count + 1;
            list.Add(obj);
        }
        var obj1 = new CandidateTrainingJobHistoryBLL();
        obj1.CandidateTrainingJobHistoryId = 0;
        obj1.LastItem = list.Count + 1;
        list.Add(obj1);
        dlTrainingIncomplete.DataSource = list;
        dlTrainingIncomplete.DataBind();
    }

    private void SaveTrainingIncomplete()
    {
        if (DeleteIDsTrainingIncomplete.Length > 0)
        {
            CandidateTrainingJobHistoryBLL.Delete(DeleteIDsTrainingIncomplete);
            DeleteIDsTrainingIncomplete = string.Empty;
        }

        foreach (DataListItem item in dlTrainingIncomplete.Items)
        {
            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            var CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
            var Training_Job = txtTraining_Job.Text;

            var txtYear = (TextBox) item.FindControl("txtYear");
            var Year = txtYear.Text;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            var School_Position = txtSchool_Position.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            var Major_Salary = txtMajor_Salary.Text;


            if (CandidateTrainingJobHistoryId == 0)
                CandidateTrainingJobHistoryBLL.Insert(CandidateId, Training_Job, Year, School_Position, Major_Salary, "",
                    "", "TIC");
            else
                CandidateTrainingJobHistoryBLL.Update(CandidateId, Training_Job, Year, School_Position, Major_Salary, "",
                    "", "TIC", CandidateTrainingJobHistoryId);
        }
    }

    #endregion

    #region insert dlEnglishComputer

    public void BindEnglishComputer()
    {
        var list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "ENC");
        if (list.Count == 0)
        {
            var obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        dlEnglishComputer.DataSource = list;
        dlEnglishComputer.DataBind();
    }

    protected void dlEnglishComputer_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        var item = e.Item;
        if ((item.ItemType == ListItemType.Item) || (item.ItemType == ListItemType.AlternatingItem))
        {
            var obj = (CandidateTrainingJobHistoryBLL) e.Item.DataItem;

            var ddlEducationLevel = (DropDownList) item.FindControl("ddlEducationLevel");
            ddlEducationLevel.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            ddlEducationLevel.SelectedItem.Text = obj.Training_Job;

            //TextBox txtTraining_Job = (TextBox)item.FindControl("txtTraining_Job");
            //txtTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            //txtTraining_Job.Text = obj.Training_Job;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            txtMajor_Salary.Text = obj.Major_Salary;


            var imgAddNewRow = (ImageButton) item.FindControl("imgAddNewRow");
            var imgDeleteRow = (ImageButton) item.FindControl("imgDeleteRow");
            if (item.ItemIndex == obj.LastItem - 1)
                imgAddNewRow.Visible = true;
            else
                imgAddNewRow.Visible = false;


            imgDeleteRow.OnClientClick = "return confirm('Bạn có muốn xóa thông tin dòng này ?');";
            if (obj.LastItem <= 1)
                imgDeleteRow.Visible = false;
            else
                imgDeleteRow.Visible = true;
        }
    }

    protected void imgDeleteRowdlEnglishComputer_Click(object sender, ImageClickEventArgs e)
    {
        var imgDeleteRow = (ImageButton) sender;
        var itemSelected = (DataListItem) imgDeleteRow.Parent;

        //TextBox txtTraining_JobSelected = (TextBox)itemSelected.FindControl("txtTraining_Job");

        var ddlEducationLevelSelected = (DropDownList) itemSelected.FindControl("ddlEducationLevel");
        ////////////////////////////////////////////////////////////////////////////////////////////
        //int Id = txtTraining_JobSelected.ToolTip.Length == 0 ? 0 : int.Parse(txtTraining_JobSelected.ToolTip);
        var Id = ddlEducationLevelSelected.ToolTip.Length == 0 ? 0 : int.Parse(ddlEducationLevelSelected.ToolTip);
        if (Id > 0)
            if (DeleteIDsEnglishComputer.Length <= 0)
                DeleteIDsEnglishComputer = Id.ToString();
            else
                DeleteIDsEnglishComputer = DeleteIDsEnglishComputer + "," + Id;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlEnglishComputer.Items)
        {
            //TextBox txtTraining_Job = (TextBox)item.FindControl("txtTraining_Job");
            var ddlEducationLevel = (DropDownList) item.FindControl("ddlEducationLevel");

            //if (!txtTraining_Job.ClientID.Equals(txtTraining_JobSelected.ClientID))
            //{
            if (!ddlEducationLevel.ClientID.Equals(ddlEducationLevelSelected.ClientID))
            {
                var obj = new CandidateTrainingJobHistoryBLL();

                //obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
                //obj.Training_Job = txtTraining_Job.Text;

                obj.CandidateTrainingJobHistoryId = int.Parse(ddlEducationLevel.ToolTip);
                obj.Training_Job = ddlEducationLevel.SelectedItem.Text;

                var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
                obj.Major_Salary = txtMajor_Salary.Text;

                obj.LastItem = dlEnglishComputer.Items.Count - 1;

                list.Add(obj);
            }
        }
        dlEnglishComputer.DataSource = list;
        dlEnglishComputer.DataBind();
    }

    protected void imgAddNewRowdlEnglishComputer_Click(object sender, ImageClickEventArgs e)
    {
        var imgAddNewRowRouting = (ImageButton) sender;
        var itemBaggageRouting = (DataListItem) imgAddNewRowRouting.Parent;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlEnglishComputer.Items)
        {
            var obj = new CandidateTrainingJobHistoryBLL();

            var ddlEducationLevel = (DropDownList) item.FindControl("ddlEducationLevel");
            //TextBox txtTraining_Job = (TextBox)item.FindControl("txtTraining_Job");
            //obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
            obj.CandidateTrainingJobHistoryId = int.Parse(ddlEducationLevel.ToolTip);
            obj.Training_Job = ddlEducationLevel.SelectedItem.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            obj.Major_Salary = txtMajor_Salary.Text;

            obj.LastItem = dlEnglishComputer.Items.Count + 1;
            list.Add(obj);
        }
        var obj1 = new CandidateTrainingJobHistoryBLL();
        obj1.CandidateTrainingJobHistoryId = 0;
        obj1.LastItem = list.Count + 1;
        list.Add(obj1);
        dlEnglishComputer.DataSource = list;
        dlEnglishComputer.DataBind();
    }

    private void SaveEnglishComputer()
    {
        if (DeleteIDsEnglishComputer.Length > 0)
        {
            CandidateTrainingJobHistoryBLL.Delete(DeleteIDsEnglishComputer);
            DeleteIDsEnglishComputer = string.Empty;
        }

        foreach (DataListItem item in dlEnglishComputer.Items)
        {
            var ddlEducationLevel = (DropDownList) item.FindControl("ddlEducationLevel");
            //TextBox txtTraining_Job = (TextBox)item.FindControl("txtTraining_Job");
            //obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
            var CandidateTrainingJobHistoryId = int.Parse(ddlEducationLevel.ToolTip);
            var Training_Job = ddlEducationLevel.SelectedItem.Text;

            //TextBox txtTraining_Job = (TextBox)item.FindControl("txtTraining_Job");
            //int CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
            //string Training_Job = txtTraining_Job.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            var Major_Salary = txtMajor_Salary.Text;

            if (CandidateTrainingJobHistoryId == 0)
                CandidateTrainingJobHistoryBLL.Insert(CandidateId, Training_Job, "", "", Major_Salary, "", "", "ENC");
            else
                CandidateTrainingJobHistoryBLL.Update(CandidateId, Training_Job, "", "", Major_Salary, "", "", "ENC",
                    CandidateTrainingJobHistoryId);
        }
    }

    #endregion

    #region insert dlJob

    public void BindJob()
    {
        var list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "JOB");
        if (list.Count == 0)
        {
            var obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        dlJob.DataSource = list;
        dlJob.DataBind();
    }

    protected void dlJob_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        var item = e.Item;
        if ((item.ItemType == ListItemType.Item) || (item.ItemType == ListItemType.AlternatingItem))
        {
            var obj = (CandidateTrainingJobHistoryBLL) e.Item.DataItem;

            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            txtTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            txtTraining_Job.Text = obj.Training_Job;

            var txtYear = (TextBox) item.FindControl("txtYear");
            txtYear.Text = obj.Year;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            txtSchool_Position.Text = obj.School_Position;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            txtMajor_Salary.Text = obj.Major_Salary;

            var txtGraduateYear_LeaveReason = (TextBox) item.FindControl("txtGraduateYear_LeaveReason");
            txtGraduateYear_LeaveReason.Text = obj.GraduateYear_LeaveReason;


            var imgAddNewRow = (ImageButton) item.FindControl("imgAddNewRow");
            var imgDeleteRow = (ImageButton) item.FindControl("imgDeleteRow");
            if (item.ItemIndex == obj.LastItem - 1)
                imgAddNewRow.Visible = true;
            else
                imgAddNewRow.Visible = false;


            imgDeleteRow.OnClientClick = "return confirm('Bạn có muốn xóa thông tin dòng này ?');";
            if (obj.LastItem <= 1)
                imgDeleteRow.Visible = false;
            else
                imgDeleteRow.Visible = true;
        }
    }

    protected void imgDeleteRowdlJob_Click(object sender, ImageClickEventArgs e)
    {
        var imgDeleteRow = (ImageButton) sender;
        var itemSelected = (DataListItem) imgDeleteRow.Parent;
        var txtTraining_JobSelected = (TextBox) itemSelected.FindControl("txtTraining_Job");

        ////////////////////////////////////////////////////////////////////////////////////////////
        var Id = txtTraining_JobSelected.ToolTip.Length == 0 ? 0 : int.Parse(txtTraining_JobSelected.ToolTip);
        if (Id > 0)
            if (DeleteIDsJob.Length <= 0)
                DeleteIDsJob = Id.ToString();
            else
                DeleteIDsJob = DeleteIDsJob + "," + Id;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlJob.Items)
        {
            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");

            if (!txtTraining_Job.ClientID.Equals(txtTraining_JobSelected.ClientID))
            {
                var obj = new CandidateTrainingJobHistoryBLL();

                obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
                obj.Training_Job = txtTraining_Job.Text;

                var txtYear = (TextBox) item.FindControl("txtYear");
                obj.Year = txtYear.Text;

                var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
                obj.School_Position = txtSchool_Position.Text;

                var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
                obj.Major_Salary = txtMajor_Salary.Text;

                var txtGraduateYear_LeaveReason = (TextBox) item.FindControl("txtGraduateYear_LeaveReason");
                obj.GraduateYear_LeaveReason = txtGraduateYear_LeaveReason.Text;


                obj.LastItem = dlJob.Items.Count - 1;

                list.Add(obj);
            }
        }
        dlJob.DataSource = list;
        dlJob.DataBind();
    }

    protected void imgAddNewRowdlJob_Click(object sender, ImageClickEventArgs e)
    {
        var imgAddNewRowRouting = (ImageButton) sender;
        var itemBaggageRouting = (DataListItem) imgAddNewRowRouting.Parent;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlJob.Items)
        {
            var obj = new CandidateTrainingJobHistoryBLL();

            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
            obj.Training_Job = txtTraining_Job.Text;

            var txtYear = (TextBox) item.FindControl("txtYear");
            obj.Year = txtYear.Text;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            obj.School_Position = txtSchool_Position.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            obj.Major_Salary = txtMajor_Salary.Text;

            var txtGraduateYear_LeaveReason = (TextBox) item.FindControl("txtGraduateYear_LeaveReason");
            obj.GraduateYear_LeaveReason = txtGraduateYear_LeaveReason.Text;

            obj.LastItem = dlJob.Items.Count + 1;
            list.Add(obj);
        }
        var obj1 = new CandidateTrainingJobHistoryBLL();
        obj1.CandidateTrainingJobHistoryId = 0;
        obj1.LastItem = list.Count + 1;
        list.Add(obj1);
        dlJob.DataSource = list;
        dlJob.DataBind();
    }

    private void SaveJob()
    {
        if (DeleteIDsJob.Length > 0)
        {
            CandidateTrainingJobHistoryBLL.Delete(DeleteIDsJob);
            DeleteIDsJob = string.Empty;
        }

        foreach (DataListItem item in dlJob.Items)
        {
            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            var CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
            var Training_Job = txtTraining_Job.Text;

            var txtYear = (TextBox) item.FindControl("txtYear");
            var Year = txtYear.Text;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            var School_Position = txtSchool_Position.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            var Major_Salary = txtMajor_Salary.Text;

            var txtGraduateYear_LeaveReason = (TextBox) item.FindControl("txtGraduateYear_LeaveReason");
            var GraduateYear_LeaveReason = txtGraduateYear_LeaveReason.Text;

            if (CandidateTrainingJobHistoryId == 0)
                CandidateTrainingJobHistoryBLL.Insert(CandidateId, Training_Job, Year, School_Position, Major_Salary,
                    GraduateYear_LeaveReason, "", "JOB");
            else
                CandidateTrainingJobHistoryBLL.Update(CandidateId, Training_Job, Year, School_Position, Major_Salary,
                    GraduateYear_LeaveReason, "", "JOB", CandidateTrainingJobHistoryId);
        }
    }

    #endregion

    #region insert dlExperience

    public void BindExperience()
    {
        var list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "EXP");
        if (list.Count == 0)
        {
            var obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        dlExperience.DataSource = list;
        dlExperience.DataBind();
    }

    protected void dlExperience_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        var item = e.Item;
        if ((item.ItemType == ListItemType.Item) || (item.ItemType == ListItemType.AlternatingItem))
        {
            var obj = (CandidateTrainingJobHistoryBLL) e.Item.DataItem;

            var txtExperience = (TextBox) item.FindControl("txtExperience");
            txtExperience.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            txtExperience.Text = obj.Experience;

            var imgAddNewRow = (ImageButton) item.FindControl("imgAddNewRow");
            var imgDeleteRow = (ImageButton) item.FindControl("imgDeleteRow");
            if (item.ItemIndex == obj.LastItem - 1)
                imgAddNewRow.Visible = true;
            else
                imgAddNewRow.Visible = false;


            imgDeleteRow.OnClientClick = "return confirm('Bạn có muốn xóa thông tin dòng này ?');";
            if (obj.LastItem <= 1)
                imgDeleteRow.Visible = false;
            else
                imgDeleteRow.Visible = true;
        }
    }

    protected void imgDeleteRowdlExperience_Click(object sender, ImageClickEventArgs e)
    {
        var imgDeleteRow = (ImageButton) sender;
        var itemSelected = (DataListItem) imgDeleteRow.Parent;
        var txtExperienceSelected = (TextBox) itemSelected.FindControl("txtExperience");

        ////////////////////////////////////////////////////////////////////////////////////////////
        var Id = txtExperienceSelected.ToolTip.Length == 0 ? 0 : int.Parse(txtExperienceSelected.ToolTip);
        if (Id > 0)
            if (DeleteIDsExperience.Length <= 0)
                DeleteIDsExperience = Id.ToString();
            else
                DeleteIDsExperience = DeleteIDsExperience + "," + Id;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlExperience.Items)
        {
            var txtExperience = (TextBox) item.FindControl("txtExperience");

            if (!txtExperience.ClientID.Equals(txtExperienceSelected.ClientID))
            {
                var obj = new CandidateTrainingJobHistoryBLL();

                obj.CandidateTrainingJobHistoryId = int.Parse(txtExperience.ToolTip);
                obj.Experience = txtExperience.Text;

                obj.LastItem = dlExperience.Items.Count - 1;

                list.Add(obj);
            }
        }
        dlExperience.DataSource = list;
        dlExperience.DataBind();
    }

    protected void imgAddNewRowdlExperience_Click(object sender, ImageClickEventArgs e)
    {
        var imgAddNewRowRouting = (ImageButton) sender;
        var itemBaggageRouting = (DataListItem) imgAddNewRowRouting.Parent;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlExperience.Items)
        {
            var obj = new CandidateTrainingJobHistoryBLL();

            var txtExperience = (TextBox) item.FindControl("txtExperience");
            obj.CandidateTrainingJobHistoryId = int.Parse(txtExperience.ToolTip);
            obj.Experience = txtExperience.Text;

            obj.LastItem = dlExperience.Items.Count + 1;
            list.Add(obj);
        }
        var obj1 = new CandidateTrainingJobHistoryBLL();
        obj1.CandidateTrainingJobHistoryId = 0;
        obj1.LastItem = list.Count + 1;
        list.Add(obj1);
        dlExperience.DataSource = list;
        dlExperience.DataBind();
    }

    private void SaveExperience()
    {
        if (DeleteIDsExperience.Length > 0)
        {
            CandidateTrainingJobHistoryBLL.Delete(DeleteIDsExperience);
            DeleteIDsExperience = string.Empty;
        }

        foreach (DataListItem item in dlExperience.Items)
        {
            var txtExperience = (TextBox) item.FindControl("txtExperience");
            var CandidateTrainingJobHistoryId = int.Parse(txtExperience.ToolTip);
            var Experience = txtExperience.Text;


            if (CandidateTrainingJobHistoryId == 0)
                CandidateTrainingJobHistoryBLL.Insert(CandidateId, "", "", "", "", "", Experience, "EXP");
            else
                CandidateTrainingJobHistoryBLL.Update(CandidateId, "", "", "", "", "", Experience, "EXP",
                    CandidateTrainingJobHistoryId);
        }
    }

    #endregion

    #region insert dlExperienceOther

    public void BindExperienceOther()
    {
        var list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "EXO");
        if (list.Count == 0)
        {
            var obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        dlExperienceOther.DataSource = list;
        dlExperienceOther.DataBind();
    }

    protected void dlExperienceOther_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        var item = e.Item;
        if ((item.ItemType == ListItemType.Item) || (item.ItemType == ListItemType.AlternatingItem))
        {
            var obj = (CandidateTrainingJobHistoryBLL) e.Item.DataItem;

            var txtExperience = (TextBox) item.FindControl("txtExperience");
            txtExperience.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            txtExperience.Text = obj.Experience;

            var imgAddNewRow = (ImageButton) item.FindControl("imgAddNewRow");
            var imgDeleteRow = (ImageButton) item.FindControl("imgDeleteRow");
            if (item.ItemIndex == obj.LastItem - 1)
                imgAddNewRow.Visible = true;
            else
                imgAddNewRow.Visible = false;


            imgDeleteRow.OnClientClick = "return confirm('Bạn có muốn xóa thông tin dòng này ?');";
            if (obj.LastItem <= 1)
                imgDeleteRow.Visible = false;
            else
                imgDeleteRow.Visible = true;
        }
    }

    protected void imgDeleteRowdlExperienceOther_Click(object sender, ImageClickEventArgs e)
    {
        var imgDeleteRow = (ImageButton) sender;
        var itemSelected = (DataListItem) imgDeleteRow.Parent;
        var txtExperienceSelected = (TextBox) itemSelected.FindControl("txtExperience");

        ////////////////////////////////////////////////////////////////////////////////////////////
        var Id = txtExperienceSelected.ToolTip.Length == 0 ? 0 : int.Parse(txtExperienceSelected.ToolTip);
        if (Id > 0)
            if (DeleteIDsExperienceOther.Length <= 0)
                DeleteIDsExperienceOther = Id.ToString();
            else
                DeleteIDsExperienceOther = DeleteIDsExperienceOther + "," + Id;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlExperienceOther.Items)
        {
            var txtExperience = (TextBox) item.FindControl("txtExperience");

            if (!txtExperience.ClientID.Equals(txtExperienceSelected.ClientID))
            {
                var obj = new CandidateTrainingJobHistoryBLL();

                obj.CandidateTrainingJobHistoryId = int.Parse(txtExperience.ToolTip);
                obj.Experience = txtExperience.Text;

                obj.LastItem = dlExperienceOther.Items.Count - 1;

                list.Add(obj);
            }
        }
        dlExperienceOther.DataSource = list;
        dlExperienceOther.DataBind();
    }

    protected void imgAddNewRowdlExperienceOther_Click(object sender, ImageClickEventArgs e)
    {
        var imgAddNewRowRouting = (ImageButton) sender;
        var itemBaggageRouting = (DataListItem) imgAddNewRowRouting.Parent;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlExperienceOther.Items)
        {
            var obj = new CandidateTrainingJobHistoryBLL();

            var txtExperience = (TextBox) item.FindControl("txtExperience");
            obj.CandidateTrainingJobHistoryId = int.Parse(txtExperience.ToolTip);
            obj.Experience = txtExperience.Text;

            obj.LastItem = dlExperienceOther.Items.Count + 1;
            list.Add(obj);
        }
        var obj1 = new CandidateTrainingJobHistoryBLL();
        obj1.CandidateTrainingJobHistoryId = 0;
        obj1.LastItem = list.Count + 1;
        list.Add(obj1);
        dlExperienceOther.DataSource = list;
        dlExperienceOther.DataBind();
    }

    private void SaveExperienceOther()
    {
        if (DeleteIDsExperienceOther.Length > 0)
        {
            CandidateTrainingJobHistoryBLL.Delete(DeleteIDsExperienceOther);
            DeleteIDsExperienceOther = string.Empty;
        }

        foreach (DataListItem item in dlExperienceOther.Items)
        {
            var txtExperience = (TextBox) item.FindControl("txtExperience");
            var CandidateTrainingJobHistoryId = int.Parse(txtExperience.ToolTip);
            var Experience = txtExperience.Text;

            if (CandidateTrainingJobHistoryId == 0)
                CandidateTrainingJobHistoryBLL.Insert(CandidateId, "", "", "", "", "", Experience, "EXO");
            else
                CandidateTrainingJobHistoryBLL.Update(CandidateId, "", "", "", "", "", Experience, "EXO",
                    CandidateTrainingJobHistoryId);
        }
    }

    #endregion

    #region insert dlFatherMother

    public void BindFatherMother()
    {
        var list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "FMT");
        if (list.Count == 0)
        {
            var obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        dlFatherMother.DataSource = list;
        dlFatherMother.DataBind();
    }

    protected void dlFatherMother_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        var item = e.Item;
        if ((item.ItemType == ListItemType.Item) || (item.ItemType == ListItemType.AlternatingItem))
        {
            var obj = (CandidateTrainingJobHistoryBLL) e.Item.DataItem;

            var txtTraining_Job = (TextBox)item.FindControl("txtTraining_Job");
            if (txtTraining_Job != null)
            {
                txtTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
                txtTraining_Job.Text = obj.Training_Job;
            }

            var txtRelationTypeName = (DropDownList)item.FindControl("ddlFamily");
            try
            {
                txtRelationTypeName.SelectedValue =
                    CandidateTrainingJobHistoryBLL.GetDRById(obj.CandidateTrainingJobHistoryId)[
                        "GraduateYear_LeaveReason"].ToString();
            }
            catch
            {
                txtRelationTypeName.SelectedValue = obj.GraduateYear_LeaveReason;
            }

            //var _Year = (UserControls_CalendarPicker)item.FindControl("cpFamilyBirthday");
            TextBox txtYear = (TextBox)item.FindControl("txtYear");
            txtYear.Text = obj.Year;

            //try
            //{
            //    _Year.SelectedDate = obj.Year;
            //}
            //catch
            //{
            //    _Year.SelectedDate = FormatDate.GetSQLDateMinValue;
            //}
            //var txtYear = (TextBox) item.FindControl("txtYear");
            //txtYear.Text = HRMUtil.StringFormat.FormatVNDate(Convert.ToDateTime(obj.Year));

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            txtSchool_Position.Text = obj.School_Position;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            txtMajor_Salary.Text = obj.Major_Salary;

            var imgAddNewRow = (ImageButton) item.FindControl("imgAddNewRow");
            var imgDeleteRow = (ImageButton) item.FindControl("imgDeleteRow");
            if (item.ItemIndex == obj.LastItem - 1)
                imgAddNewRow.Visible = true;
            else
                imgAddNewRow.Visible = false;


            imgDeleteRow.OnClientClick = "return confirm('Bạn có muốn xóa thông tin dòng này ?');";
            if (obj.LastItem <= 1)
                imgDeleteRow.Visible = false;
            else
                imgDeleteRow.Visible = true;
        }
    }

    protected void imgDeleteRowdlFatherMother_Click(object sender, ImageClickEventArgs e)
    {
        var imgDeleteRow = (ImageButton) sender;
        var itemSelected = (DataListItem) imgDeleteRow.Parent;
        var txtTraining_JobSelected = (TextBox) itemSelected.FindControl("txtTraining_Job");

        ////////////////////////////////////////////////////////////////////////////////////////////
        var Id = txtTraining_JobSelected.ToolTip.Length == 0 ? 0 : int.Parse(txtTraining_JobSelected.ToolTip);
        if (Id > 0)
            if (DeleteIDsFatherMother.Length <= 0)
                DeleteIDsFatherMother = Id.ToString();
            else
                DeleteIDsFatherMother = DeleteIDsFatherMother + "," + Id;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlFatherMother.Items)
        {
            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");

            if (!txtTraining_Job.ClientID.Equals(txtTraining_JobSelected.ClientID))
            {
                var obj = new CandidateTrainingJobHistoryBLL();

                obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
                obj.Training_Job = txtTraining_Job.Text;

                TextBox txtYear = (TextBox)item.FindControl("txtYear");
                //txtYear.Text = obj.Year;
                obj.Year = txtYear.Text.Trim();

                //var _Year = (UserControls_CalendarPicker)item.FindControl("cpFamilyBirthday");
                //obj.Year = _Year.SelectedDate.ToString();

                var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
                obj.School_Position = txtSchool_Position.Text;

                var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
                obj.Major_Salary = txtMajor_Salary.Text;

                obj.LastItem = dlFatherMother.Items.Count - 1;

                list.Add(obj);
            }
        }
        dlFatherMother.DataSource = list;
        dlFatherMother.DataBind();
    }

    protected void imgAddNewRowdlFatherMother_Click(object sender, ImageClickEventArgs e)
    {
        var imgAddNewRowRouting = (ImageButton) sender;
        var itemBaggageRouting = (DataListItem) imgAddNewRowRouting.Parent;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlFatherMother.Items)
        {
            var obj = new CandidateTrainingJobHistoryBLL();

            var txtTraining_Job = (TextBox)item.FindControl("txtTraining_Job");
            obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);

            var ddl = (DropDownList)item.FindControl("ddlFamily");
            var txtSelectedFamily = (TextBox)item.FindControl("txtSelectedFamily");
            if (txtSelectedFamily != null)
                txtSelectedFamily.Text = ddl != null ? ddl.SelectedValue : "";
            if (txtSelectedFamily.Text.Length > 0)
                ddl.SelectedValue = txtSelectedFamily.Text;
            else
                ddl.SelectedValue = "";

            obj.GraduateYear_LeaveReason = txtSelectedFamily.Text;
            obj.Training_Job = CandidateTrainingJobHistoryBLL.GetDRById(obj.CandidateTrainingJobHistoryId) == null
                ? ddl.SelectedItem.Text
                : CandidateTrainingJobHistoryBLL.GetDRById(obj.CandidateTrainingJobHistoryId)["GraduateYear_LeaveReason"
                ].ToString(); // obj.GraduateYear_LeaveReason; //ddl.SelectedValue.ToString();

            var txtYear = (TextBox) item.FindControl("txtYear");
            obj.Year = txtYear.Text;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            obj.School_Position = txtSchool_Position.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            obj.Major_Salary = txtMajor_Salary.Text;

            obj.LastItem = dlFatherMother.Items.Count + 1;
            list.Add(obj);
        }
        var obj1 = new CandidateTrainingJobHistoryBLL();
        obj1.CandidateTrainingJobHistoryId = 0;
        obj1.LastItem = list.Count + 1;
        list.Add(obj1);
        dlFatherMother.DataSource = list;
        dlFatherMother.DataBind();
    }

    private void SaveFatherMother()
    {
        if (DeleteIDsFatherMother.Length > 0)
        {
            CandidateTrainingJobHistoryBLL.Delete(DeleteIDsFatherMother);
            DeleteIDsFatherMother = string.Empty;
        }

        foreach (DataListItem item in dlFatherMother.Items)
        {
            var _RelationTypeName = (DropDownList)item.FindControl("ddlFamily");
            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            var CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
            var Training_Job = _RelationTypeName.SelectedItem.Text;

            var txtYear = (TextBox) item.FindControl("txtYear");
            var Year = txtYear.Text;
            //var _Year = (UserControls_CalendarPicker)item.FindControl("cpFamilyBirthday");
            //var Year = "";
            //try
            //{
            //    Year = _Year.SelectedDate.ToString();
            //}
            //catch
            //{
            //    _Year.SelectedDate = FormatDate.GetSQLDateMinValue;
            //}

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            var School_Position = txtSchool_Position.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            var Major_Salary = txtMajor_Salary.Text;

            var GraduateYear_LeaveReason = _RelationTypeName.SelectedValue;
            //if (CheckDate(Year) == true && !(Year.Contains("1753")))
            {
                if (CandidateTrainingJobHistoryId == 0)
                    CandidateTrainingJobHistoryBLL.Insert(CandidateId, Training_Job, Year, School_Position, Major_Salary, GraduateYear_LeaveReason,
                        "", "FMT");
                else
                    CandidateTrainingJobHistoryBLL.Update(CandidateId, Training_Job, Year, School_Position, Major_Salary, GraduateYear_LeaveReason,
                        "", "FMT", CandidateTrainingJobHistoryId);
            }
            //else
            //{
            //    UcTitle1.ErrorText = "Vui lòng nhập đầy đủ ngày/ tháng/ năm sinh trong phần thông tin gia đình";
            //}
        }
    }

    private bool CheckDate(String date)
    {
        try
        {
            DateTime dt = DateTime.Parse(date);
            return true;
        }
        catch
        {
            return false;
        }
    }

    #endregion

    #region insert dlSAGSFamily

    public void BindSAGSFamily()
    {
        var list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "SAG");
        if (list.Count == 0)
        {
            var obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        dlSAGSFamily.DataSource = list;
        dlSAGSFamily.DataBind();
    }

    protected void dlSAGSFamily_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        var item = e.Item;
        if ((item.ItemType == ListItemType.Item) || (item.ItemType == ListItemType.AlternatingItem))
        {
            var obj = (CandidateTrainingJobHistoryBLL) e.Item.DataItem;

            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            txtTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            txtTraining_Job.Text = obj.Training_Job;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            txtSchool_Position.Text = obj.School_Position;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            txtMajor_Salary.Text = obj.Major_Salary;

            var imgAddNewRow = (ImageButton) item.FindControl("imgAddNewRow");
            var imgDeleteRow = (ImageButton) item.FindControl("imgDeleteRow");
            if (item.ItemIndex == obj.LastItem - 1)
                imgAddNewRow.Visible = true;
            else
                imgAddNewRow.Visible = false;


            imgDeleteRow.OnClientClick = "return confirm('Bạn có muốn xóa thông tin dòng này ?');";
            if (obj.LastItem <= 1)
                imgDeleteRow.Visible = false;
            else
                imgDeleteRow.Visible = true;
        }
    }

    protected void imgDeleteRowdlSAGSFamily_Click(object sender, ImageClickEventArgs e)
    {
        var imgDeleteRow = (ImageButton) sender;
        var itemSelected = (DataListItem) imgDeleteRow.Parent;
        var txtTraining_JobSelected = (TextBox) itemSelected.FindControl("txtTraining_Job");

        ////////////////////////////////////////////////////////////////////////////////////////////
        var Id = txtTraining_JobSelected.ToolTip.Length == 0 ? 0 : int.Parse(txtTraining_JobSelected.ToolTip);
        if (Id > 0)
            if (DeleteIDsSAGSFamily.Length <= 0)
                DeleteIDsSAGSFamily = Id.ToString();
            else
                DeleteIDsSAGSFamily = DeleteIDsSAGSFamily + "," + Id;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlSAGSFamily.Items)
        {
            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");

            if (!txtTraining_Job.ClientID.Equals(txtTraining_JobSelected.ClientID))
            {
                var obj = new CandidateTrainingJobHistoryBLL();

                obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
                obj.Training_Job = txtTraining_Job.Text;

                var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
                obj.School_Position = txtSchool_Position.Text;

                var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
                obj.Major_Salary = txtMajor_Salary.Text;

                obj.LastItem = dlSAGSFamily.Items.Count - 1;

                list.Add(obj);
            }
        }
        dlSAGSFamily.DataSource = list;
        dlSAGSFamily.DataBind();
    }

    protected void imgAddNewRowdlSAGSFamily_Click(object sender, ImageClickEventArgs e)
    {
        var imgAddNewRowRouting = (ImageButton) sender;
        var itemBaggageRouting = (DataListItem) imgAddNewRowRouting.Parent;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlSAGSFamily.Items)
        {
            var obj = new CandidateTrainingJobHistoryBLL();

            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
            obj.Training_Job = txtTraining_Job.Text;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            obj.School_Position = txtSchool_Position.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            obj.Major_Salary = txtMajor_Salary.Text;

            obj.LastItem = dlSAGSFamily.Items.Count + 1;
            list.Add(obj);
        }
        var obj1 = new CandidateTrainingJobHistoryBLL();
        obj1.CandidateTrainingJobHistoryId = 0;
        obj1.LastItem = list.Count + 1;
        list.Add(obj1);
        dlSAGSFamily.DataSource = list;
        dlSAGSFamily.DataBind();
    }

    private void SaveSAGSFamily()
    {
        if (DeleteIDsSAGSFamily.Length > 0)
        {
            CandidateTrainingJobHistoryBLL.Delete(DeleteIDsSAGSFamily);
            DeleteIDsSAGSFamily = string.Empty;
        }

        foreach (DataListItem item in dlSAGSFamily.Items)
        {
            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            var CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
            var Training_Job = txtTraining_Job.Text;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            var School_Position = txtSchool_Position.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            var Major_Salary = txtMajor_Salary.Text;

            if (CandidateTrainingJobHistoryId == 0)
                CandidateTrainingJobHistoryBLL.Insert(CandidateId, Training_Job, "", School_Position, Major_Salary, "",
                    "", "SAG");
            else
                CandidateTrainingJobHistoryBLL.Update(CandidateId, Training_Job, "", School_Position, Major_Salary, "",
                    "", "SAG", CandidateTrainingJobHistoryId);
        }
    }

    #endregion

    #region insert dlInforConfirm

    public void BindInforConfirm()
    {
        var list = CandidateTrainingJobHistoryBLL.GetByCandidateId_Type(CandidateId, "ICF");
        if (list.Count == 0)
        {
            var obj1 = new CandidateTrainingJobHistoryBLL();
            obj1.CandidateTrainingJobHistoryId = 0;
            obj1.LastItem = list.Count + 1;
            list.Add(obj1);
        }

        dlInforConfirm.DataSource = list;
        dlInforConfirm.DataBind();
    }

    protected void dlInforConfirm_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        var item = e.Item;
        if ((item.ItemType == ListItemType.Item) || (item.ItemType == ListItemType.AlternatingItem))
        {
            var obj = (CandidateTrainingJobHistoryBLL) e.Item.DataItem;

            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            txtTraining_Job.ToolTip = obj.CandidateTrainingJobHistoryId.ToString();
            txtTraining_Job.Text = obj.Training_Job;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            txtSchool_Position.Text = obj.School_Position;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            txtMajor_Salary.Text = obj.Major_Salary;

            var txtYear = (TextBox) item.FindControl("txtYear");
            txtYear.Text = obj.Year;


            var imgAddNewRow = (ImageButton) item.FindControl("imgAddNewRow");
            var imgDeleteRow = (ImageButton) item.FindControl("imgDeleteRow");
            if (item.ItemIndex == obj.LastItem - 1)
                imgAddNewRow.Visible = true;
            else
                imgAddNewRow.Visible = false;


            imgDeleteRow.OnClientClick = "return confirm('Bạn có muốn xóa thông tin dòng này ?');";
            if (obj.LastItem <= 1)
                imgDeleteRow.Visible = false;
            else
                imgDeleteRow.Visible = true;
        }
    }

    protected void imgDeleteRowdlInforConfirm_Click(object sender, ImageClickEventArgs e)
    {
        var imgDeleteRow = (ImageButton) sender;
        var itemSelected = (DataListItem) imgDeleteRow.Parent;
        var txtTraining_JobSelected = (TextBox) itemSelected.FindControl("txtTraining_Job");

        ////////////////////////////////////////////////////////////////////////////////////////////
        var Id = txtTraining_JobSelected.ToolTip.Length == 0 ? 0 : int.Parse(txtTraining_JobSelected.ToolTip);
        if (Id > 0)
            if (DeleteIDsInforConfirm.Length <= 0)
                DeleteIDsInforConfirm = Id.ToString();
            else
                DeleteIDsInforConfirm = DeleteIDsInforConfirm + "," + Id;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlInforConfirm.Items)
        {
            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");

            if (!txtTraining_Job.ClientID.Equals(txtTraining_JobSelected.ClientID))
            {
                var obj = new CandidateTrainingJobHistoryBLL();

                obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
                obj.Training_Job = txtTraining_Job.Text;

                var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
                obj.School_Position = txtSchool_Position.Text;

                var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
                obj.Major_Salary = txtMajor_Salary.Text;

                var txtYear = (TextBox) item.FindControl("txtYear");
                obj.Year = txtYear.Text;

                obj.LastItem = dlInforConfirm.Items.Count - 1;

                list.Add(obj);
            }
        }
        dlInforConfirm.DataSource = list;
        dlInforConfirm.DataBind();
    }

    protected void imgAddNewRowdlInforConfirm_Click(object sender, ImageClickEventArgs e)
    {
        var imgAddNewRowRouting = (ImageButton) sender;
        var itemBaggageRouting = (DataListItem) imgAddNewRowRouting.Parent;

        var list = new List<CandidateTrainingJobHistoryBLL>();
        foreach (DataListItem item in dlInforConfirm.Items)
        {
            var obj = new CandidateTrainingJobHistoryBLL();

            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            obj.CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
            obj.Training_Job = txtTraining_Job.Text;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            obj.School_Position = txtSchool_Position.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            obj.Major_Salary = txtMajor_Salary.Text;

            var txtYear = (TextBox) item.FindControl("txtYear");
            obj.Year = txtYear.Text;

            obj.LastItem = dlInforConfirm.Items.Count + 1;
            list.Add(obj);
        }
        var obj1 = new CandidateTrainingJobHistoryBLL();
        obj1.CandidateTrainingJobHistoryId = 0;
        obj1.LastItem = list.Count + 1;
        list.Add(obj1);
        dlInforConfirm.DataSource = list;
        dlInforConfirm.DataBind();
    }

    private void SaveInforConfirm()
    {
        if (DeleteIDsInforConfirm.Length > 0)
        {
            CandidateTrainingJobHistoryBLL.Delete(DeleteIDsInforConfirm);
            DeleteIDsInforConfirm = string.Empty;
        }

        foreach (DataListItem item in dlInforConfirm.Items)
        {
            var txtTraining_Job = (TextBox) item.FindControl("txtTraining_Job");
            var CandidateTrainingJobHistoryId = int.Parse(txtTraining_Job.ToolTip);
            var Training_Job = txtTraining_Job.Text;

            var txtYear = (TextBox) item.FindControl("txtYear");
            var Year = txtYear.Text;

            var txtSchool_Position = (TextBox) item.FindControl("txtSchool_Position");
            var School_Position = txtSchool_Position.Text;

            var txtMajor_Salary = (TextBox) item.FindControl("txtMajor_Salary");
            var Major_Salary = txtMajor_Salary.Text;

            if (CandidateTrainingJobHistoryId == 0)
                CandidateTrainingJobHistoryBLL.Insert(CandidateId, Training_Job, Year, School_Position, Major_Salary, "",
                    "", "ICF");
            else
                CandidateTrainingJobHistoryBLL.Update(CandidateId, Training_Job, Year, School_Position, Major_Salary, "",
                    "", "ICF", CandidateTrainingJobHistoryId);
        }
    }

    #endregion

    protected void Button1_Click(object sender, EventArgs e)
    {
        CandidatesBLL.UpdateByCandidateBlack(CandidateId, 1);
        UcTitle1.ErrorText = "Thành công!";
        lbResult.Text = "Thành công!";
    }
}