using System;
using System.Text;
using System.Collections.Generic;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H0;
using HRMDAL.H1;
using HRMUtil.KeyNames.H1;
using HRMUtil.KeyNames.H0;
using HRMUtil;
using HRMBLL.BLLHelper;
using HRMBLL.H1;

namespace HRMBLL.H0
{
    public class EmployeeLeaveScheduleBLL
    {
        private int _EmployeeLeaveScheduleId;
        public int EmployeeLeaveScheduleId
        {
            get { return _EmployeeLeaveScheduleId; }
            set { _EmployeeLeaveScheduleId = value; }
        }
        private int _UserId;
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        private DateTime _FromDate;
        public DateTime FromDate
        {
            get { return _FromDate; }
            set { _FromDate = value; }
        }
        private DateTime _ToDate;
        public DateTime ToDate
        {
            get { return _ToDate; }
            set { _ToDate = value; }
        }
        private int _Days;
        public int Days
        {
            get { return _Days; }
            set { _Days = value; }
        }
        private int _Time;
        public int Time
        {
            get { return _Time; }
            set { _Time = value; }
        }
        private string _FullName;
        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }
        private string _DepartmentName;
        public string DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }
        private string _DepartmentFullName;
        public string DepartmentFullName
        {
            get { return _DepartmentFullName; }
            set { _DepartmentFullName = value; }
        }
        private string _RootName;
        public string RootName
        {
            get { return _RootName; }
            set { _RootName = value; }
        }
        private int _Seniority;
        public int Seniority
        {
            get { return _Seniority; }
            set { _Seniority = value; }
        }
        private int _MaxF;
        public int MaxF
        {
            get { return _MaxF; }
            set { _MaxF = value; }
        }
        private string _PositionName;
        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }
        private DateTime _JoinDate;
        private int _Status;
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        private string _StrStatus;
        private string _WriteIds;
        private string _ReadIds;
        private int _NotInSchedule;
        private string _Place;
        private string _DenyReason;

        public string DenyReason
        {
            get { return _DenyReason; }
            set { _DenyReason = value; }
        }
        public string Place
        {
            get { return _Place; }
            set { _Place = value; }
        }
        public int NotInSchedule
        {
            get { return _NotInSchedule; }
            set { _NotInSchedule = value; }
        }
        public string ReadIds
        {
            get { return _ReadIds; }
            set { _ReadIds = value; }
        }
        public string WriteIds
        {
            get { return _WriteIds; }
            set { _WriteIds = value; }
        }
        public string StrStatus
        {
            get { return _StrStatus; }
            set { _StrStatus = value; }
        }
        public DateTime JoinDate
        {
            get { return _JoinDate; }
            set { _JoinDate = value; }
        }
        private string _LastApprovedBy;
        private string _LastDeniedBy;

        public string LastDeniedBy
        {
            get { return _LastDeniedBy; }
            set { _LastDeniedBy = value; }
        }
        public string LastApprovedBy
        {
            get { return _LastApprovedBy; }
            set { _LastApprovedBy = value; }
        }

        public EmployeeLeaveScheduleBLL(int employeeLeaveScheduleId, int userId, DateTime fromDate, DateTime toDate, int days, int time)
        {
            _EmployeeLeaveScheduleId = employeeLeaveScheduleId;
            _UserId = userId;
            _FromDate = fromDate;
            _ToDate = toDate;
            _Time = time;
        }
        public static List<EmployeeLeaveScheduleBLL> GetByFilter(string fullName, string departmentIds, int UserId, int Time, string Status, int RootId, int LevelPosition, DateTime RangeFrom, DateTime RangeTo)
        {
            return GenerateListEmployeeLeaveScheduleBLLFromDataTable(new EmployeeLeaveScheduleDAL().GetByFilter(fullName, departmentIds, UserId, Time, Status, RootId, LevelPosition, RangeFrom, RangeTo));
        }
        public static List<EmployeeLeaveScheduleBLL> GetByFilterV1(string fullName, string departmentIds)
        {
            return GenerateListEmployeeLeaveScheduleBLLFromDataTable(new EmployeeLeaveScheduleDAL().GetByFilterV1(fullName, departmentIds));
        }
        public static List<EmployeeLeaveScheduleBLL> GetByScheduleId(int EmployeeLeaveScheduleId)
        {
            return GenerateListEmployeeLeaveScheduleBLLFromDataTable(new EmployeeLeaveScheduleDAL().GetByScheduleId(EmployeeLeaveScheduleId));
        }
        public static List<EmployeeLeaveScheduleBLL> GetByEmployeeLeaveScheduleId(int id)
        {
            return GenerateListEmployeeLeaveScheduleBLLFromDataTable(new EmployeeLeaveScheduleDAL().GetByEmployeeLeaveScheduleId(id));
        }
        public static DataRow GetById(string fullName, string departmentIds, int UserId)
        {
            DataTable dt = new EmployeeLeaveScheduleDAL().GetById(fullName, departmentIds, UserId);
            if (dt.Rows.Count > 0)
            {
                return (dt.Rows[0]);
            }
            else
            {
                return null;
            }
        }
        public static DataTable DT_GetByFilter(string fullName, string departmentIds, int UserId, int Time, string Status)
        {
            return new EmployeeLeaveScheduleDAL().GetByFilter(fullName, departmentIds, UserId, Time, Status, 0, 0, HRMUtil.FormatDate.GetSQLDateMinValue, HRMUtil.FormatDate.GetSQLDateMinValue);
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static long Delete(int EmployeeLeaveScheduleId)
        {
            EmployeeLeaveScheduleDAL objDAL = new EmployeeLeaveScheduleDAL();
            return objDAL.Delete(EmployeeLeaveScheduleId);
        }
        public static long Insert(int UserId, DateTime FromDate, DateTime ToDate, int Days, int Time)
        {
            return new EmployeeLeaveScheduleDAL().Insert(UserId, FromDate, ToDate, Days, Time);
        }
        public static long Update(int EmployeeLeaveScheduleId, DateTime FromDate, DateTime ToDate)
        {
            return new EmployeeLeaveScheduleDAL().Update(EmployeeLeaveScheduleId, FromDate, ToDate);
        }
        public static long Update_Status(int EmployeeLeaveScheduleId, int Status)
        {
            return new EmployeeLeaveScheduleDAL().Update_Status(EmployeeLeaveScheduleId, Status);
        }
        public static long Update_ApprovedDenied(int EmployeeLeaveScheduleId, string UserIds, int Type)
        {
            return new EmployeeLeaveScheduleDAL().Update_ApprovedDenied(EmployeeLeaveScheduleId, UserIds, Type);
        }
        public static long UpdateWriteIds(long employeeLeaveId, string writeIds)
        {
            return new EmployeeLeaveScheduleDAL().UpdateWriteIds(employeeLeaveId, writeIds);
        }
        public static long UpdateDenyReason(long employeeLeaveId, string denyReason)
        {
            return new EmployeeLeaveScheduleDAL().UpdateDenyReason(employeeLeaveId, denyReason);
        }
        public static long UpdateReadIds(long employeeLeaveId, string readIds)
        {
            return new EmployeeLeaveScheduleDAL().UpdateReadIds(employeeLeaveId, readIds);
        }
        public static long UpdateRemark1(long employeeLeaveId, string remark, int notInSchedule)
        {
            return new EmployeeLeaveScheduleDAL().UpdateRemark1(employeeLeaveId, remark, notInSchedule);
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private static List<EmployeeLeaveScheduleBLL> GenerateListEmployeeLeaveScheduleBLLFromDataTable(DataTable dt)
        {
            List<EmployeeLeaveScheduleBLL> list = new List<EmployeeLeaveScheduleBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateListEmployeeLeaveScheduleBLLFromDataRow(dr));
            }

            return list;
        }
        private static EmployeeLeaveScheduleBLL GenerateListEmployeeLeaveScheduleBLLFromDataRow(DataRow dr)
        {
            EmployeeLeaveScheduleBLL objBLL = new EmployeeLeaveScheduleBLL(
                dr["EmployeeLeaveScheduleId"] == DBNull.Value ? 0 : int.Parse(dr["EmployeeLeaveScheduleId"].ToString()),
                dr["UserId"] == DBNull.Value ? 0 : int.Parse(dr["UserId"].ToString()),
                dr["FromDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["FromDate"]),
                dr["ToDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["ToDate"]),
                dr["Days"] == DBNull.Value ? 0 : int.Parse(dr["Days"].ToString()),
                dr["Time"] == DBNull.Value ? 0 : int.Parse(dr["Time"].ToString())
                );

            try
            {
                objBLL.FullName = dr["FullName"] == DBNull.Value ? string.Empty : (string)dr["FullName"];
            }
            catch { }
            try
            {
                objBLL.DepartmentName = dr[DepartmentKeys.FIELD_DEPARTMENT_NAME] == DBNull.Value ? string.Empty : (string)dr[DepartmentKeys.FIELD_DEPARTMENT_NAME];
            }
            catch { }
            try
            {
                objBLL._DepartmentName = dr[DepartmentKeys.FIELD_DEPARTMENT_NAME] == DBNull.Value ? string.Empty : dr[DepartmentKeys.FIELD_DEPARTMENT_NAME].ToString();
            }
            catch { }
            try
            {
                objBLL._DepartmentFullName = dr[DepartmentKeys.Field_Department_DepartmentFullName] == DBNull.Value ? string.Empty : dr[DepartmentKeys.Field_Department_DepartmentFullName].ToString();
            }
            catch { }
            try
            {
                objBLL._RootName = dr[DepartmentKeys.Field_Department_RootName] == DBNull.Value ? string.Empty : dr[DepartmentKeys.Field_Department_RootName].ToString();
            }
            catch { }
            try
            {
                objBLL.Seniority = dr["Seniority"] == DBNull.Value ? 0 : int.Parse(dr["Seniority"].ToString());
            }
            catch { }
            try
            {
                objBLL.MaxF = dr["MaxF"] == DBNull.Value ? 0 : int.Parse(dr["MaxF"].ToString());
            }
            catch { }
            try
            {
                objBLL.FromDate = dr["FromDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["FromDate"]);
            }
            catch { }
            try
            {
                objBLL.ToDate = dr["ToDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["ToDate"]);
            }
            catch { }
            try
            {
                objBLL.Time = dr["Time"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Time"]);
            }
            catch { }
            try
            {
                objBLL.Days = dr["Days"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Days"]);
            }
            catch { }
            try
            {
                objBLL.PositionName = dr["PositionName"] == DBNull.Value ? string.Empty : dr["PositionName"].ToString();
            }
            catch { }
            try
            {
                objBLL.JoinDate = dr["JoinDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["JoinDate"]);
            }
            catch { }
            try
            {
                objBLL.Status = dr["EmployeeLeaveScheduleStatus"] == DBNull.Value ? 0 : Convert.ToInt32(dr["EmployeeLeaveScheduleStatus"]);
            }
            catch { }
            try
            {
                objBLL._WriteIds = dr["WriteIds"] == DBNull.Value ? "" : dr["WriteIds"].ToString();
            }
            catch { }
            try
            {
                objBLL._ReadIds = dr["ReadIds"] == DBNull.Value ? "" : dr["ReadIds"].ToString();
            }
            catch { }
            try
            {
                objBLL.NotInSchedule = dr["NotInSchedule"] == DBNull.Value ? 0 : Convert.ToInt32(dr["NotInSchedule"]);
            }
            catch { }
            try
            {
                objBLL.Place = dr["Remark1"] == DBNull.Value ? "" : dr["Remark1"].ToString();
            }
            catch { }
            try
            {
                objBLL.DenyReason = dr["DenyReason"] == DBNull.Value ? "" : dr["DenyReason"].ToString();
            }
            catch { }
            return objBLL;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Registration
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    }
}
