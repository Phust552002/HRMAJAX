using System;
using System.Collections.Generic;
using System.Text;

using HRMDAL.HRMTableAdapters;
using HRMDAL;


namespace HRMBLL
{
    [System.ComponentModel.DataObject]
    public class CoefficientsBLL
    {

        #region private fileds for adapter

        private ViewCoefficientTableAdapter _ViewCoefficientAdapter = null;

        #endregion

        #region properties

        protected ViewCoefficientTableAdapter AdapterViewCoefficient
        {
            get
            {
                if (_ViewCoefficientAdapter == null)
                    _ViewCoefficientAdapter = new ViewCoefficientTableAdapter();

                return _ViewCoefficientAdapter;
            }
        }


        #endregion


        #region getting methods

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public HRM.ViewCoefficientDataTable GetPersonalCoefficientMonthly(int UserId, DateTime date)
        {

            return AdapterViewCoefficient.GetPersonalCoefficientMonthly(UserId,date);
        }


        #endregion
    }
}
