using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H1;
using HRMUtil.KeyNames.H1;
using HRMUtil.KeyNames.H0;
using HRMBLL.H1.Helper;
using HRMUtil;

namespace HRMBLL.H1
{
    public class WorkdayOverTimeBLL
    {


        private int _OverTimeId = 0;
        private int _UserId = 0;
        private string _OverTimeType = "";
        private double _OverTimeHours = 0;
        private DateTime _OverTimeDate;
        private string _OverTimeRemark = "";
        private int _OTUpdatedUserId = 0;
        private DateTime _OTUpdatedDatetime;
        

        private int _LastItem;

        public int OverTimeId
        {
            get { return _OverTimeId; }
            set { _OverTimeId = value; }
        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public string OverTimeType
        {
            get { return _OverTimeType; }
            set { _OverTimeType = value; }
        }
        public double OverTimeHours
        {
            get { return _OverTimeHours; }
            set { _OverTimeHours = value; }
        }
        public DateTime OverTimeDate
        {
            get { return _OverTimeDate; }
            set { _OverTimeDate = value; }
        }
        public string OverTimeRemark
        {
            get { return _OverTimeRemark; }
            set { _OverTimeRemark = value; }
        }
        public int OTUpdatedUserId
        {
            get { return _OTUpdatedUserId; }
            set { _OTUpdatedUserId = value; }
        }
        public DateTime OTUpdatedDatetime
        {
            get { return _OTUpdatedDatetime; }
            set { _OTUpdatedDatetime = value; }
        }

        public int LastItem
        {
            get { return _LastItem; }
            set { _LastItem = value; }
        }


        #region public methods insert, update, delete


        public static void Insert(int UserId, string OverTimeType, double OverTimeHours, System.Nullable<DateTime> OverTimeDate, string OverTimeRemark, int OTUpdatedUserId, System.Nullable<DateTime> OTUpdatedDatetime)
        {
            new WorkdayOverTimeDAL().Insert(UserId, OverTimeType, OverTimeHours, OverTimeDate, OverTimeRemark, OTUpdatedUserId, OTUpdatedDatetime);
        }
        public static void Update(int UserId, string OverTimeType, double OverTimeHours, System.Nullable<DateTime> OverTimeDate, string OverTimeRemark, int OTUpdatedUserId, System.Nullable<DateTime> OTUpdatedDatetime, int OverTimeId)
        {
            new WorkdayOverTimeDAL().Update(UserId, OverTimeType, OverTimeHours, OverTimeDate, OverTimeRemark, OTUpdatedUserId, OTUpdatedDatetime, OverTimeId);
        }

        public static string Delete(string ids)
        {
            string[] arr = ids.Split(',');
            foreach (string arrItem in arr)
            {
                if (arrItem.Length > 0)
                {
                    Delete(int.Parse(arrItem));
                }
            }
            return ids;
        }
        public static void Delete(int OverTimeId)
        {
            new WorkdayOverTimeDAL().Delete(OverTimeId);
        }
        public static void DeleteDate(int UserId, DateTime OverTimeDate)
        {
            new WorkdayOverTimeDAL().DeleteDate(UserId, OverTimeDate);
        }

        #endregion

        #region public methods GET

        public static List<WorkdayOverTimeBLL> GetByFilter(int UserId, string OverTimeType, System.Nullable<DateTime> OverTimeDate)
        {
            return GenerateListFromDataTable(new WorkdayOverTimeDAL().GetByFilter(UserId, OverTimeType, OverTimeDate));
        }
        public static DataTable GetDataTableByFilter(int UserId, string OverTimeType, System.Nullable<DateTime> OverTimeDate)
        {
            return new WorkdayOverTimeDAL().GetByFilter(UserId, OverTimeType, OverTimeDate);
        }
     
        #endregion

        #region private methods

        private static List<WorkdayOverTimeBLL> GenerateListFromDataTable(DataTable dt)
        {
            List<WorkdayOverTimeBLL> list = new List<WorkdayOverTimeBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateFromDataTable(dr, dt.Rows.Count));
            }

            return list;
        }

        private static WorkdayOverTimeBLL GenerateFromDataTable(DataRow dr, int itemLastIndex)
        {
            WorkdayOverTimeBLL c = new WorkdayOverTimeBLL();

            c._OverTimeId = dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_OverTimeId] == DBNull.Value ? 0 : int.Parse(dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_OverTimeId].ToString());
            c._UserId = dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_UserId] == DBNull.Value ? 0 : int.Parse(dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_UserId].ToString());
            c._OverTimeType = dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_OverTimeType] == DBNull.Value ? string.Empty : dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_OverTimeType].ToString();
            c._OverTimeHours = dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_OverTimeHours] == DBNull.Value ? 0 : int.Parse(dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_OverTimeHours].ToString());
            c._OverTimeDate = dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_OverTimeDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_OverTimeDate]);
            c._OverTimeRemark = dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_OverTimeRemark] == DBNull.Value ? string.Empty : dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_OverTimeRemark].ToString();
            c._OTUpdatedUserId = dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_OTUpdatedUserId] == DBNull.Value ? 0 : int.Parse(dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_OTUpdatedUserId].ToString());
            c._OTUpdatedDatetime = dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_OTUpdatedDatetime] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[WorkdayOverTimeKeys.Field_WorkdayOverTime_OTUpdatedDatetime]);

            c._LastItem = itemLastIndex;

            return c;
        }

        #endregion

    }
}
