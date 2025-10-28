using System;
using System.Net;
using System.Net.Mail;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using Excel;
using HRMBLL.H2;
using HRMUtil;
using Constants = HRMUtil.Constants;
using DataTable = System.Data.DataTable;

public partial class Recruitment_Registration : Page
{
    private readonly string[,] Mảng = new string[14, 18];
    //Tạo mảng có 14 hàng và 17 cột, mỗi hàng chứa các ký tự cùng nhóm

    private long registeredCandidateId = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        switch (WebConfigurationManager.AppSettings["BaseStation"])
        {
            case "DAD":
                lbCompanyName.Text = "CÔNG TY CỔ PHẦN PHỤC VỤ MẶT ĐẤT SÀI GÒN - ĐÀ NẴNG";
                break;
            case "LongThanh":
                lbCompanyName.Text = "CÔNG TY CỔ PHẦN PHỤC VỤ MẶT ĐẤT SÀI GÒN - LONG THÀNH";
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
            UcTitle1.Text = "ĐĂNG KÝ THÔNG TIN ĐĂNG NHẬP ĐỂ NỘP ĐƠN DỰ TUYỂN ĐÀO TẠO";
            //DataRow dr = SessionsBLL.GetSessionIsOpenForDataRow();
            var lst = SessionsBLL.GetSessionIsOpen();
            //if (dr != null)
            if (lst != null)
            {
                pnRegistration.Visible = true;
                lbError.Visible = false;
                //SessionId = int.Parse(dr["SessionId"].ToString());
                //SessionsBLL s = lst[0];
                //lbSession.Text = s.Name.ToUpper() + " - " + s.PositionName.ToUpper();
                //SessionId = s.Id;
                //PositionId = s.PositionId;

                BindDataToDDLPosition();
            }
            else
            {
                pnRegistration.Visible = false;
                lbError.Visible = true;

                lbError.Text = "ĐỢT TUYỂN DỤNG CHƯA ĐƯỢC MỞ NÊN BẠN KHÔNG THỂ ĐĂNG KÝ";
            }
            DisplayResetPasswordArea(false);
        }
    }


    //public int SessionId
    //{
    //    get
    //    {
    //        if (ViewState["SessionId"] != null)
    //        {
    //            return int.Parse(ViewState["SessionId"].ToString());
    //        }
    //        else
    //        {
    //            return 0;
    //        }
    //    }
    //    set
    //    {
    //        ViewState["SessionId"] = value;
    //    }
    //}
    ////public int PositionId
    //{
    //    get
    //    {
    //        if (ViewState["PositionId"] != null)
    //        {
    //            return int.Parse(ViewState["PositionId"].ToString());
    //        }
    //        else
    //        {
    //            return 0;
    //        }
    //    }
    //    set
    //    {
    //        ViewState["PositionId"] = value;
    //    }
    //}

    private void BindDataToDDLPosition()
    {
        ddlPositions.Items.Clear();
        ddlPositions.Items.Add(new ListItem("", "0"));
        //ddlPositions.DataSource = SessionsBLL.GetPositionBySessionIdForDataTable(SessionId);
        ddlPositions.DataSource = SessionsBLL.GetSessionIsOpenForDataTable();
        ddlPositions.DataTextField = "Description";
        ddlPositions.DataValueField = "Id";
        ddlPositions.DataBind();
    }

    protected void lnkRegistration_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Recruitment/SignIn.aspx");
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            btnSave.Enabled = false;
            if (CheckValid())
            {
                NapChuoiMau();

                var lastName1 = Bodau(txtLastName.Text.Trim());
                var firstName1 = Bodau(txtFirstName.Text.Trim());

                DataTable sessionPositionId = SessionsBLL.GetById(int.Parse(ddlPositions.SelectedValue));

                var sessionId = int.Parse(sessionPositionId.Rows[0]["SessionId"].ToString());
                var positionid = int.Parse(sessionPositionId.Rows[0]["PositionId"].ToString());// SessionsBLL.GetPositionBySessionId(sessionId)[0].PositionId;

                var candidateId = CandidatesBLL.InsertForRegistration(positionid, sessionId, txtLastName.Text.Trim(),
                    txtFirstName.Text.Trim(), int.Parse(txtDay.Text), int.Parse(txtMonth.Text), int.Parse(txtYear.Text),
                    lastName1, firstName1, txtEmail.Text, txtUserName.Text, txtPassword.Text, Constants.Candidate_Status_Unapproved_Id);

                if (candidateId == 24061991)
                {
                    UcTitle1.ErrorText = "Có lỗi trong quá trình đăng ký. Vui lòng liên hệ phòng Tổ chức hành chính để được giải quyết";
                }
                else if (candidateId < 0)
                {
                    UcTitle1.ErrorText = "Ứng viên này đã được đăng ký. Vui lòng click vào KIỂM TRA để đăng nhập hoặc Khôi phục mật khẩu nếu quên mật khẩu";
                    registeredCandidateId = candidateId * -1;
                    ViewState["registeredCandidateId"] = registeredCandidateId;
                    try
                    {
                        CandidatesBLL candidate = CandidatesBLL.GetById((int)registeredCandidateId);
                        if (candidate != null)
                        {
                            string email = candidate.Email;
                            if (email != null && email.Contains("@"))
                            {
                                string[] address = email.Split('@');
                                if (address.Length >= 2)
                                {
                                    lbRetypedEmailSuggestion.Text += "(" + address[0].Substring(0, 1) + "•••" + address[0].Substring(address[0].Length - 1, 1) + "@" + address[1] + ")";
                                    DisplayResetPasswordArea(true);
                                }
                            }
                        }
                    }
                    catch
                    { }
                }
                else
                {
                    Session.Add(Constants.KEY_CANDIDATE_CURRENT, candidateId);
                    Response.Redirect("~/Recruitment/RegistrationDetail.aspx");
                }
            }
            else
            {
                btnSave.Enabled = true;
            }
        }
        catch (HRMException he)
        {
            UcTitle1.ErrorText = he.Message;
        }
    }

    private void DisplayResetPasswordArea(bool isDisplayed)
    {
        lbRetypedEmail.Visible = isDisplayed;
        lbRetypedEmailError.Visible = isDisplayed;
        lbRetypedEmailSuggestion.Visible = isDisplayed;
        txtRetypedEmail.Visible = isDisplayed;
        btnResetPassword.Visible = isDisplayed;
    }

    private bool CheckValid()
    {
        if (int.Parse(ddlPositions.SelectedValue.Trim()) <= 0)
        {
            UcTitle1.ErrorText = "VUI LÒNG CHỌN CHỨC DANH ỨNG TUYỂN";
            lbPositionsError.Text = "***";
            return false;
        }
        if (txtLastName.Text.Trim().Length <= 0)
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP HỌ TÊN LÓT";
            lbLastNameError.Text = "***";
            return false;
        }
        if (txtFirstName.Text.Trim().Length <= 0)
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP TÊN";
            lbFirstNameError.Text = "***";
            return false;
        }
        else if (txtFirstName.Text.Trim().Contains(" "))
        {
            UcTitle1.ErrorText = "TÊN CHỈ BẢO GỒM 1 TỪ";
            lbFirstNameError.Text = "***";
            return false;
        }
        else if (txtFirstName.Text.Length > 10)
        {
            UcTitle1.ErrorText = "TÊN KHÔNG ĐƯỢC DÀI HƠN 10 KÝ TỰ";
            lbFirstNameError.Text = "***";
            return false;
        }
        if (txtUserName.Text.Trim().Length <= 0)
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP TÊN NGƯỜI DÙNG (UserName)";
            lbUserNameError.Text = "***";
            return false;
        }
        if (txtPassword.Text.Trim().Length <= 0)
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP MẬT KHẨU (password)";
            lbPasswordError.Text = "***";
            return false;
        }
        if ((txtDay.Text.Trim().Length <= 0) || (txtMonth.Text.Trim().Length <= 0) || (txtYear.Text.Trim().Length <= 0))
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP NGÀY THÁNG NĂM SINH";
            lbBirthdayError.Text = "***";
            return false;
        }
        try
        {
            int.Parse(txtDay.Text);
        }
        catch
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP NGÀY THÁNG NĂM SINH LÀ KÝ TỰ SỐ";
            lbBirthdayError.Text = "***";
            return false;
        }
        try
        {
            int.Parse(txtMonth.Text);
        }
        catch
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP NGÀY THÁNG NĂM SINH LÀ KÝ TỰ SỐ";
            lbBirthdayError.Text = "***";
            return false;
        }
        try
        {
            int.Parse(txtYear.Text);
        }
        catch
        {
            UcTitle1.ErrorText = "BẠN PHẢI NHẬP NGÀY THÁNG NĂM SINH LÀ KÝ TỰ SỐ";
            lbBirthdayError.Text = "***";
            return false;
        }

        var dt = CandidatesBLL.GetByUserName(txtUserName.Text.Trim());
        if (dt.Rows.Count > 0)
        {
            UcTitle1.ErrorText = "TÊN NGƯỜI DÙNG (UserName) BỊ TRÙNG";
            lbUserNameError.Text = "***";
            return false;
        }

        return true;
        //return CaptchaControl1.UserValidated;
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

    protected void btnBack_Click(object sender, EventArgs e)
    {
        //Response.Redirect("http://web.sags.vn/hrm/Recruitment/Location.aspx");
        Response.Redirect("https://www.sags.vn/recruitment.html");
    }

    protected void btnResetPassword_Click(object sender, EventArgs e)
    {
        try
        {
            CandidatesBLL candidate = CandidatesBLL.GetById(Convert.ToInt32(ViewState["registeredCandidateId"]));
            if (candidate != null)
            {
                if (candidate.Email.Trim().ToLower() == txtRetypedEmail.Text.Trim().ToLower())
                {
                    ResetPassword(txtRetypedEmail.Text.Trim().ToLower(), candidate.CandidateId);
                    lbRetypedEmailError.Text = "";
                    btnResetPassword.Enabled = false;
                }
                else
                {
                    lbRetypedEmailError.Text = "Email không giống với email đã đăng ký!";
                }
            }
        }
        catch
        { }
    }

    private void ResetPassword(string email, int candidateId)
    {
        try
        {
            CandidatesBLL candidate = CandidatesBLL.GetById(candidateId);

            CandidatesBLL.ChangePassword(candidate.UserName, candidate.Password, "Ss123456!");

            if (candidate != null)
            {
                using (MailMessage mm = new MailMessage())
                {
                    mm.From = new MailAddress("no-reply@sags.vn");
                    mm.To.Add(email);
                        
                    mm.Subject = "[SAGS] Khôi phục mật khẩu";

                    string body = "Bạn đã yêu cầu tạo lại mật khẩu cho tài khoản đăng ký nộp hồ sơ trên https://www.sags.vn/";
                    body += "<br /><br />Tên đăng nhập: " + candidate.UserName;
                    body += "<br /><br />Mật khẩu mới: " + "Ss123456!";
                    body += "<br /><br />Vui lòng thay đổi mật khẩu sau khi đăng nhập thành công.";

                    mm.Body = body;
                    mm.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "mail.sags.vn";
                    smtp.EnableSsl = false;
                    NetworkCredential NetworkCred = new NetworkCredential("no-reply@sags.vn", "Sags8485383");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 25;
                    smtp.Send(mm);
                }
            }

            UcTitle1.ErrorText = "Mật khẩu mới đã được gửi vào email. Vui lòng click vào KIỂM TRA để đăng nhập với mật khẩu mới và thay đổi mật khẩu";
        }
        catch
        {
            UcTitle1.ErrorText = "Có lỗi trong quá trình gửi mật khẩu mới!";
        }
    }
}    