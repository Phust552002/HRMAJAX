using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

using HRMDAL.Utilities;
using HRMDAL.H;
using HRMUtil.KeyNames.H;
using HRMBLL.H.Helper;

namespace HRMBLL.H
{
    public class TimeKeepingBLL
    {
        #region private fields

        private Int64 _TimeKeepingId;
        private int _TimeKeepingTypeId;
        private double _Value;
        private DateTime _TimeKeepingDate;
        private string _Description;
        private string _UserCode;
        private string _TimeKeepingCode;
        private int _UserId;
        #endregion

        #region properties

        public Int64 TimeKeepingId
        {
            get { return _TimeKeepingId; }
            set { _TimeKeepingId = value; }
        }

        public double Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        public DateTime TimeKeepingDate
        {
            get { return _TimeKeepingDate; }
            set { _TimeKeepingDate = value; }
        }

        public int TimeKeepingTypeId
        {
            get { return _TimeKeepingTypeId; }
            set { _TimeKeepingTypeId = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public string UserCode
        {
            get { return _UserCode; }
            set { _UserCode = value; }
        }

        public string TimeKeepingCode
        {
            get { return _TimeKeepingCode; }
            set { _TimeKeepingCode = value; }

        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        #endregion

        #region constructor

        public TimeKeepingBLL(Int64 timeKeepingId, double value, DateTime timeKeepingDate)
        {
            _TimeKeepingId = timeKeepingId;
            _Value = value;
            _TimeKeepingDate = timeKeepingDate;
        }

        #endregion

        #region methods insert, update, delete

        public long Save()
        {
            if (TimeKeepingId <= 0)
            {
                TimeKeepingDAL objDAL = new TimeKeepingDAL();
                return objDAL.Insert(TimeKeepingTypeId, UserCode, Value, TimeKeepingDate, UserId);
            }
            else
            {
                return -1;
            }
        }

        #endregion

        #region public methods Get

        public static List<TimeKeepingBLL> GetByUserId_Monthly(int userId, int month, int year, int type)
        {
            TimeKeepingDAL objDAL = new TimeKeepingDAL();
            return GenerateListTimeKeepingBLLFromDataTable(objDAL.GetByUserId_Monthly(userId, month, year, type));
        }

        #endregion


        #region private methods, generate helper methods

        private static List<TimeKeepingBLL> GenerateListTimeKeepingBLLFromDataTable(DataTable dt)
        {
            List<TimeKeepingBLL> list = new List<TimeKeepingBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateTimeKeepingBLLFromDataRow(dr));
            }

            return list;
        }

        private static TimeKeepingBLL GenerateTimeKeepingBLLFromDataRow(DataRow dr)
        {
            TimeKeepingBLL objBLL = new TimeKeepingBLL(
            dr[TimeKeepingKeys.FIELD_TIME_KEEPING_ID] == DBNull.Value ? DefaultValues.TimeKeepingIdMinValue : Convert.ToInt64(dr[TimeKeepingKeys.FIELD_TIME_KEEPING_ID].ToString()),
            dr[TimeKeepingKeys.FIELD_TIME_KEEPING_VALUE] == DBNull.Value ? 0 : Convert.ToDouble(dr[TimeKeepingKeys.FIELD_TIME_KEEPING_VALUE].ToString()),
            dr[TimeKeepingKeys.FIELD_TIME_KEEPING_DATE] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr[TimeKeepingKeys.FIELD_TIME_KEEPING_DATE].ToString())
            );

            objBLL.TimeKeepingCode = dr[TimeKeepingTypeKeys.FIELD_TIME_KEEPING_TYPE_CODE] == DBNull.Value ? string.Empty : (string)dr[TimeKeepingTypeKeys.FIELD_TIME_KEEPING_TYPE_CODE];
            objBLL.Description = dr[TimeKeepingTypeKeys.FIELD_TIME_KEEPING_TYPE_DESCRIPTION] == DBNull.Value ? string.Empty : (string)dr[TimeKeepingTypeKeys.FIELD_TIME_KEEPING_TYPE_DESCRIPTION];
            return objBLL;
        }

        #endregion


    }
}
