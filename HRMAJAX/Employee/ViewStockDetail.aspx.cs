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

public partial class Employee_ViewStockDetail : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "THÔNG TIN MUA CỔ PHẦN";
            ShowInfor();            
        }
    }

   

   

    private void ShowInfor()
    {
        if (ucPermission1.UserId > 0)
        {
            //UcTitle1.Text = "CẬP NHẬT ỨNG CỬ VIÊN";
            DataRow row = EmployeesBLL.GetEmployeeByIdForDataRow(ucPermission1.UserId);
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
            int ConfirmStocks = Convert.ToInt32(row["ConfirmStocks"]);
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

            
        }

    }

    

}