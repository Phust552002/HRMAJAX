using System;
using System.Collections.Generic;
using System.Text;

using HRMDAL.HRMTableAdapters;
using HRMDAL;

namespace HRMBLL
{
    public class EmployeeIncomeBLL
    {

        #region Private Fields

        private EmployeeIncomeTableAdapter _EmployeeIncomeAdapter;
        private ViewEmployeeIncomesTableAdapter _ViewEmployeeIncomesAdapter;
        
        private DateTime _IncomeDate;
        private decimal  _TotalIncome = 0;
        private decimal _TotalContribution = 0;
        private decimal _TotalIncomeLk = 0;
        private decimal _TotalContributionLk = 0;

        #endregion

        #region Properties

        protected EmployeeIncomeTableAdapter Adapter
        {
            get
            {
                if (_EmployeeIncomeAdapter == null)
                    _EmployeeIncomeAdapter = new EmployeeIncomeTableAdapter();

                return _EmployeeIncomeAdapter;
            }
        }

        protected ViewEmployeeIncomesTableAdapter AdapterViewEmployeeIncomes
        {
            get
            {
                if (_ViewEmployeeIncomesAdapter == null)
                    _ViewEmployeeIncomesAdapter = new ViewEmployeeIncomesTableAdapter();

                return _ViewEmployeeIncomesAdapter;
            }
        }

        public DateTime ImcomeDate
        {
            get { return _IncomeDate; }
            set { _IncomeDate = value; }
        }

        public decimal TotalIncome
        {
            get { return _TotalIncome; }
            set { _TotalIncome = value; }
        }

        public decimal TotalContribution
        {
            get { return _TotalContribution; }
            set { _TotalContribution = value; }
        }

        public decimal TotalIncomeLk
        {
            get { return _TotalIncomeLk; }
            set { _TotalIncomeLk = value; }
        }

        public decimal TotalContributionLk
        {
            get { return _TotalContributionLk; }
            set { _TotalContributionLk = value; }
        }

        #endregion


        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public HRM.ViewEmployeeIncomesDataTable GetEmployeeAllIncomes(int departmentId, DateTime date, string fullName)
        {
            return AdapterViewEmployeeIncomes.GetEmployeeAllIncomes(departmentId,date, fullName);
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public EmployeeIncomeBLL GetTotalIncomeMonthly(int UserId, DateTime date)
        {
            try
            {
                return GenerateEmployeeIncomeBLLFromEmployeeIncomeDataTable(Adapter.GetTotalEmployeeIncome(UserId, date));
            }
            catch{ }
            return null;
        }


        private EmployeeIncomeBLL GenerateEmployeeIncomeBLLFromEmployeeIncomeDataTable(HRM.EmployeeIncomeDataTable objEDT)
        {
            EmployeeIncomeBLL objEmployeeIncomeBLL = new EmployeeIncomeBLL();
            if (objEDT.Rows.Count > 0)
            {
                objEmployeeIncomeBLL.ImcomeDate = Convert.ToDateTime(objEDT[0]["Date"] == DBNull.Value ? DateTime.Now.ToString() : objEDT[0]["Date"].ToString());
                objEmployeeIncomeBLL.TotalIncome = Convert.ToDecimal(objEDT[0]["Total_Inc"] == DBNull.Value ? "0" : objEDT[0]["Total_Inc"].ToString());
                objEmployeeIncomeBLL.TotalContribution = Convert.ToDecimal(objEDT[0]["Total_Cntr"] == DBNull.Value ? "0" : objEDT[0]["Total_Cntr"].ToString());
                objEmployeeIncomeBLL.TotalIncomeLk = Convert.ToDecimal(objEDT[0]["Total_Inc_LK"] == DBNull.Value ? "0" : objEDT[0]["Total_Inc_LK"].ToString());
                objEmployeeIncomeBLL.TotalContributionLk = Convert.ToDecimal(objEDT[0]["Total_Cntr_LK"] == DBNull.Value ? "0" : objEDT[0]["Total_Cntr_LK"].ToString());
            }
            return objEmployeeIncomeBLL;
        }

    }
}
