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

using HRMBLL.H2;
using HRMBLL.H0;
using HRMUtil;
public partial class Employee_StockDetail : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "XÁC NHẬN THÔNG TIN CỔ ĐÔNG";

            if (Request.QueryString["Id"] != null)
            {
                UserId = int.Parse(Request.QueryString["Id"]);
                DepartmentId = int.Parse(Request.QueryString["d"]);
                PageIndex = int.Parse(Request.QueryString["i"]);
                ShowInfor();
            }
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
   
    private int PageIndex
    {
        get
        {
            if (ViewState["PageIndex"] == null)
                return 0;
            else
                return int.Parse(ViewState["PageIndex"].ToString());
        }
        set
        {
            if (ViewState["PageIndex"] == null)
                ViewState["PageIndex"] = value;
        }
    }

    private int DepartmentId
    {
        get
        {
            if (ViewState["DepartmentId"] == null)
                return 0;
            else
                return int.Parse(ViewState["DepartmentId"].ToString());
        }
        set
        {
            if (ViewState["DepartmentId"] == null)
                ViewState["DepartmentId"] = value;
        }
    }
    
    private void ShowInfor()
    {
        if (UserId > 0)
        {
            //UcTitle1.Text = "CẬP NHẬT ỨNG CỬ VIÊN";
            DataRow row = EmployeesBLL.GetEmployeeByIdForDataRow(UserId);
            lbInvestorNo.Text = "SAG" + Convert.ToInt32(row["InvestorNo"]).ToString("000000000#");
            lbFullName.Text = row["FullName"].ToString();

            txtHandPhone.Text = row["HandPhone"].ToString();
            txtIDCard.Text = row["IdCard"].ToString();
            cpDateOfIssue.SelectedDate = Convert.ToDateTime(row["DateOfIssue"]);
            txtPlaceOfIssue.Text = row["PlaceOfIssue"].ToString();
            txtLive.Text = row["Live"].ToString();
            try
            {
                cpStockDateOfPayment.SelectedDate = Convert.ToDateTime(row["StockDateOfPayment"]);
            }
            catch { cpStockDateOfPayment.SelectedDate = DateTime.Now; }
            try
            {
            txtStockRemark.Text = row["StockRemark"].ToString();
            }
            catch { txtStockRemark.Text = ""; }
            int ConfirmStocks = 0;
            try
            {
                ConfirmStocks = Convert.ToInt32(row["ConfirmStocks"]);
            }
            catch
            { ConfirmStocks = 0; }
            if (ConfirmStocks == 1)
            {
                chkCash.Checked = true;
                chkBanking.Checked = false;
            }
            else if (ConfirmStocks == 2)
            {
                chkCash.Checked = false;
                chkBanking.Checked = true;
            }
            else
            {
                chkCash.Checked = false;
                chkBanking.Checked = false;
            }
            

            int SeniorStockBought = Convert.ToInt32(row["SeniorStockBought"]);
            txtSeniorStockBought.Text = SeniorStockBought.ToString("####0");
            double SeniorStockBoughtMoney = SeniorStockBought * 8400;
            txtSeniorStockBoughtMoney.Text = SeniorStockBoughtMoney.ToString("#,###0");

            int UnderTakingStockBought = Convert.ToInt32(row["UnderTakingStockBought"]);
            txtUnderTakingStockBought.Text = UnderTakingStockBought.ToString("####0");
            double UnderTakingStockBoughtMoney = UnderTakingStockBought * 14000;
            txtUnderTakingStockBoughtMoney.Text = UnderTakingStockBoughtMoney.ToString("#,###0");

            int TotalStock = SeniorStockBought + UnderTakingStockBought;
            txtTotalStock.Text = TotalStock.ToString("#,###0");
            double TotalStockMoney = SeniorStockBoughtMoney + UnderTakingStockBoughtMoney;
            txtTotalStockMoney.Text = TotalStockMoney.ToString("#,###0");

            //txtDay.Text = cBLL.DayOfBirth.ToString();
            //txtMonth.Text = cBLL.MonthOfBirth.ToString();
            //txtYear.Text = cBLL.YearOfBirth.ToString();

            //if (cBLL.Sex)
            //{
            //    rdoMale.Checked = true;
            //}
            //else
            //{
            //    rdoFemale.Checked = true;
            //}

            //ddlPosition.SelectedValue = cBLL.PositionId.ToString();
            //ddlStandards.SelectedValue = cBLL.Type.ToString();
            //txtExperience.Text = cBLL.Experience;
            //txtHeight.Text = cBLL.Height.ToString();
            //txtHomePhone.Text = cBLL.HomePhone;
            //txtHandPhone.Text = cBLL.HandPhone;
            //txtRemark.Text = cBLL.Remark;
            //txtEmail.Text = cBLL.Email;
            //txtReson.Text = cBLL.Reson;
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        BackList();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Save())
        {
            ShowInfor();
            UcTitle1.ErrorText = "LƯU THÀNH CÔNG.";
        }
        else
        {
            UcTitle1.ErrorText = "LỖI KHÔNG THỂ LƯU...................................!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
        }
    }

    private bool Save()
    {
        bool isValue = false;
        if (CheckInvalid())
        {
            try
            {
                string HandPhone = string.Empty; string Live = string.Empty; string IdCard = string.Empty;
                DateTime DateOfIssue = DateTime.Now; string PlaceOfIssue = string.Empty;
                int SeniorStockBought = 0; int UnderTakingStockBought = 0; decimal TotalStockMoney = 0;
                int ConfirmStocks = 0;
                DateTime StockDateOfPayment = DateTime.Now; string StockRemark = "";


                HandPhone = txtHandPhone.Text;
                IdCard = txtIDCard.Text;
                DateOfIssue = cpDateOfIssue.SelectedDate;
                PlaceOfIssue = txtPlaceOfIssue.Text;
                Live = txtLive.Text;
                SeniorStockBought = Convert.ToInt32(txtSeniorStockBought.Text.Trim().Length < 0 ? "0" : txtSeniorStockBought.Text.Trim());
                UnderTakingStockBought = Convert.ToInt32(txtUnderTakingStockBought.Text.Trim().Length < 0 ? "0" : txtUnderTakingStockBought.Text.Trim());

                StockDateOfPayment = cpStockDateOfPayment.SelectedDate;
                StockRemark = txtStockRemark.Text;
                TotalStockMoney = Convert.ToDecimal(txtTotalStockMoney.Text.Trim().Length < 0 ? "0" : txtTotalStockMoney.Text.Trim());
                if (chkCash.Checked)
                {
                    ConfirmStocks = 1;
                }
                else if (chkBanking.Checked)
                {
                    ConfirmStocks = 2;
                }
                else
                {
                    ConfirmStocks = 0;
                }

                EmployeesBLL.UpdateStock(HandPhone, "", "", Live, IdCard, DateOfIssue, PlaceOfIssue, 0, 0, 0, 0, SeniorStockBought, UnderTakingStockBought, TotalStockMoney, UcPermission1.UserId, DateTime.Now, ConfirmStocks, StockDateOfPayment, StockRemark, UserId);                
                isValue = true;                
            }
            catch (HRMException he)
            {
                UcTitle1.ErrorText = he.Message;
                isValue = false;
            }            
        }
        return isValue;
    }

    private void BackList()
    {
        Response.Redirect("~/Employee/StockList.aspx");
    }

    private bool CheckInvalid()
    {
        bool valuereturn = true;
        if ((chkBanking.Checked && chkCash.Checked) || (!chkBanking.Checked && !chkCash.Checked))
        {
            valuereturn = false;
            UcTitle1.ErrorText="Vui lòng chọn tiền mặt hoặc chuyển khoảng";
        }
        return valuereturn;
    }

    protected void btnPrint_Click(object sender, EventArgs e)
    {
        if (Save())
        {
            Server.Transfer("~/Employee/StockPrint.aspx?Id=" + UserId);
        }
        else
        {
            UcTitle1.ErrorText = "LỖI KHÔNG THỂ LƯU...................................!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
        }
        
    }

}