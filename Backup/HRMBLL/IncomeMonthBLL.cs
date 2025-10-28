using System;
using System.Collections.Generic;
using System.Text;
using HRMDAL.HRMTableAdapters;
using HRMDAL;

namespace HRMBLL
{
    [System.ComponentModel.DataObject]
    public class IncomeMonthBLL
    {
        
        private IncomeMonthTableAdapter _IncomeMonthAdapter = null;
        private ViewIncomeTableAdapter _ViewIncomeAdapter = null;

        #region properties

        protected IncomeMonthTableAdapter Adapter
        {
            get
            {
                if (_IncomeMonthAdapter == null)
                    _IncomeMonthAdapter = new IncomeMonthTableAdapter();

                return _IncomeMonthAdapter;
            }
        }

        protected ViewIncomeTableAdapter AdapterViewIncome
        {
            get
            {
                if (_ViewIncomeAdapter == null)
                    _ViewIncomeAdapter = new ViewIncomeTableAdapter();

                return _ViewIncomeAdapter;
            }
        }

        #endregion

        #region Draff

        //[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        //public HRM.IncomeMonthDataTable GetPersonalMonthlyIncome(int userId)
        //{
        //    return Adapter.GetPersonalIncome(userId,DateTime.Now);
        //}
        //[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        //public HRM.IncomeMonthDataTable GetPersonalMonthlyContribution(int userId)
        //{
        //    return Adapter.GetPersonalContribution(userId, DateTime.Now);
        //}

        #endregion

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public HRM.ViewIncomeDataTable GetPersonalMonthlyIncome(int userId, DateTime date)
        {
            return AdapterViewIncome.GetPersonalMonthlyIncome(userId, date);
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public HRM.ViewIncomeDataTable GetPersonalMonthlyContribution(int userId, DateTime date)
        {
            return AdapterViewIncome.GetPersonalMonthlyContribution(userId, date);
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public HRM.ViewIncomeDataTable GetMonthlyIncome(string userCode, DateTime date)
        {
            return AdapterViewIncome.GetMonthlyIncome(userCode, date);
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public HRM.ViewIncomeDataTable GetMonthlyContribution(string userCode, DateTime date)
        {
            return AdapterViewIncome.GetMonthlyContribution(userCode, date);
        }        

    }
}
