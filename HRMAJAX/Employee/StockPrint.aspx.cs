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

public partial class Employee_StockPrint : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["Id"] != null)
        {
            UserId = int.Parse(Request.QueryString["Id"]);
            ShowInfor();
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

    private void ShowInfor()
    {
        if (UserId > 0)
        {

            lbDate.Text = "TP.HCM, Ngày " + DateTime.Now.Day + " Tháng " + DateTime.Now.Month + " Năm " + DateTime.Now.Year;
            //UcTitle1.Text = "CẬP NHẬT ỨNG CỬ VIÊN";


            DataRow row = EmployeesBLL.GetEmployeeByIdForDataRow(UserId);
            lbInvestorNo.Text = "SAG" + Convert.ToInt32(row["InvestorNo"]).ToString("000000000#");
            lbFullName.Text = row["FullName"].ToString();

            lbHandPhone.Text = row["HandPhone"].ToString();
            lbIdCard.Text = row["IdCard"].ToString();
            lbDateOfIssue.Text = FormatDate.FormatVNDate(Convert.ToDateTime(row["DateOfIssue"]));
            lbPlaceOfIssue.Text = row["PlaceOfIssue"].ToString();
            lbLive.Text = row["Live"].ToString();


            int SeniorStockBought = Convert.ToInt32(row["SeniorStockBought"]);
            lbSeniorStockBought.Text = SeniorStockBought.ToString("####0");
            double SeniorStockBoughtMoney = SeniorStockBought * 8400;
            lbSeniorStockBoughtMoney.Text = SeniorStockBoughtMoney.ToString("#,###0");
            lbSeniorStockBoughtMoneyChar.Text = StringFormat.GetStringByNumber(SeniorStockBoughtMoney);

            int UnderTakingStockBought = Convert.ToInt32(row["UnderTakingStockBought"]);
            lbUnderTakingStockBought.Text = UnderTakingStockBought.ToString("####0");
            double UnderTakingStockBoughtMoney = UnderTakingStockBought * 14000;
            lbUnderTakingStockBoughtMoney.Text = UnderTakingStockBoughtMoney.ToString("#,###0");
            lbUnderTakingStockBoughtMoneyChar.Text = StringFormat.GetStringByNumber(UnderTakingStockBoughtMoney);


            int TotalStock = SeniorStockBought + UnderTakingStockBought;
            lbTotalStock.Text = TotalStock.ToString("#,###0");
            

            decimal TotalStockMoney = 0;//;SeniorStockBoughtMoney + UnderTakingStockBoughtMoney;
            try
            {
                TotalStockMoney = Convert.ToDecimal(row["TotalMoneyBought"]);
            }
            catch { TotalStockMoney = 0; }
            
            lbTotalMoneyBought.Text = TotalStockMoney.ToString("#,###0");
            lbTotalMoneyBought0.Text = TotalStockMoney.ToString("#,###0")+" đồng";
            lbTotalMoneyBoughtChar.Text = StringFormat.GetStringByNumber(TotalStockMoney);
            lbTotalMoneyBoughtChar0.Text = "Bằng chữ: "+StringFormat.GetStringByNumber(TotalStockMoney);

        }
    }
}