using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using HRMDAL.HRMTableAdapters;
using HRMDAL;

namespace HRMBLL
{
    [System.ComponentModel.DataObject]
    public class TimeKeepingBLL
    {
        private TimeKeepingTableAdapter _timeKeepingAdapter = null;
        private ViewTimeKeepingTableAdapter _ViewTimeKeepingAdapter = null;

        #region properties

        protected TimeKeepingTableAdapter Adapter
        {
            get
            {
                if (_timeKeepingAdapter == null)
                    _timeKeepingAdapter = new TimeKeepingTableAdapter();

                return _timeKeepingAdapter;
            }
        }

        protected ViewTimeKeepingTableAdapter AdapterViewTimeKeeping
        {
            get
            {
                if (_ViewTimeKeepingAdapter == null)
                    _ViewTimeKeepingAdapter = new ViewTimeKeepingTableAdapter();

                return _ViewTimeKeepingAdapter;
            }
        }

        #endregion
        

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public HRM.ViewTimeKeepingDataTable GetPersonalMonthlyTimeKeeping(int userId, DateTime date)
        {
            return AdapterViewTimeKeeping.GetPersonalTimeKeepingMonthly(userId, date);
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public HRM.ViewTimeKeepingDataTable GetPersonalMonthlyWorkHour(int userId, DateTime date)
        {
            return AdapterViewTimeKeeping.GetPersonalWorkHourMonthly(userId, date);
        }

        #region Draff

        //[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        //public HRM.Sel_PersonalTimeKeepingDataTable GetPersonalTimeKeeping2(int userId, DateTime timeKeepingDate)
        //{
        //    Sel_PersonalTimeKeepingTableAdapter _adapter = new Sel_PersonalTimeKeepingTableAdapter();
        //    return _adapter.GetPersonalTimeKeeping(userId, timeKeepingDate);
        //}


        //[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        //public HRM.Sel_DepartmentTimeKeepingDataTable GetDepartmentTimeKeeping(int deptId, DateTime timeKeepingDate)
        //{
        //    Sel_DepartmentTimeKeepingTableAdapter _adapter = new Sel_DepartmentTimeKeepingTableAdapter();
        //    return _adapter.GetDepartmentTimeKeeping(deptId, timeKeepingDate);            
        //}

        //[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        //public int UpdateNothing(int deptId)
        //{
        //    Sel_DepartmentTimeKeepingTableAdapter _adapter = new Sel_DepartmentTimeKeepingTableAdapter();
        //    return _adapter.UpdateNothing();
        //}

        //[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        //public int UpdateBlank()
        //{
        //    Sel_DepartmentTimeKeepingTableAdapter _adapter = new Sel_DepartmentTimeKeepingTableAdapter();
        //    return _adapter.UpdateBlank();
        //}

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public HRM.TimeKeepingDataTable GetPersonalTimeKeeping(int userId)
        {
            return Adapter.GetPersonalTimeKeeping(userId, DateTime.Now);
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public int UpdateTimeKeeping(int timeKeepingId, int workdayTypeId, int userId, int value, DateTime timeKeepingDate)
        {
            return (int)Adapter.UpdateTimeKeeping(timeKeepingId, workdayTypeId, userId, value, timeKeepingDate);
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public int UpdatePersonalTimeKeeping(string workdayCode, int userId, int value, DateTime timeKeepingDate)
        {
            return (int)Adapter.UpdatePersonalTimeKeeping(workdayCode, userId, value, timeKeepingDate);
        }

        #endregion

      
       
    }
}
