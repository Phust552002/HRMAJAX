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
using HRMBLL.H0;

namespace HRMBLL.H1
{
    public class WorkDayPrivilegeBLL
    {

        #region private fields

        private int _UserId = 0;
        private int _DepartmentId = 0;
        private bool _IsInit;
        private int _PrivilegeType;
        
        private string _EmployeeCode;
        private string _FullName;
        private string _DepartmentFullName;        

        #endregion

        #region properties

        public int UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                _UserId = value;
            }
        }

        public int DepartmentId
        {
            get
            {
                return _DepartmentId;
            }
            set
            {
                _DepartmentId = value;
            }
        }       

        public int PrivilegeType
        {
            get
            {
                return _PrivilegeType;
            }
            set
            {
                _PrivilegeType = value;
            }
        }

        public bool IsInit
        {
            get
            {
                return _IsInit;
            }
            set
            {
                _IsInit = value;
            }
        }
        public string EmployeeCode
        {
            get
            {
                return _EmployeeCode;
            }
            set
            {
                _EmployeeCode = value;
            }
        }
        
        public string FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                _FullName = value;
            }
        }
        
        public string DepartmentFullName
        {
            get
            {
                return _DepartmentFullName;
            }
            set
            {
                _DepartmentFullName = value;
            }
        }
        

        #endregion


        #region methods insert, update , delete

        public static long Insert(int userId, int departmentId, bool isInit, int privilegeType)
        {           
            return new WorkdayPrivilegeDAL().Insert(userId, departmentId, isInit, privilegeType);
        }

        public static long Update(int userId, bool isInit, int privilegeType, int departmentId)
        {
            return new WorkdayPrivilegeDAL().Update(userId, isInit, privilegeType, departmentId);
        }

        public static long Delete(int userId, int departmentId, int privilegeType)
        {
            return new WorkdayPrivilegeDAL().Delete(userId, departmentId, privilegeType);
        }

        #endregion


        #region public method GET

        public static bool IsPrivilegeTimeKeeping(int userId, int departmentId, int privilegeType)
        {
            List<WorkDayPrivilegeBLL> list = GenerateWorkDayPrivilegeBLLFromDataTable(new WorkdayPrivilegeDAL().GetByUserIdDeptId(userId, departmentId, privilegeType));

            if (list.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        public static WorkDayPrivilegeBLL GetByUserIdDeptId(int userId, int departmentId, int privilegeType)
        {
            List<WorkDayPrivilegeBLL> list = GenerateWorkDayPrivilegeBLLFromDataTable(new WorkdayPrivilegeDAL().GetByUserIdDeptId(userId, departmentId, privilegeType));

            if (list.Count == 1)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public static List<WorkDayPrivilegeBLL> GetByUserId(int userId, int privilegeType)
        {
            return GenerateWorkDayPrivilegeBLLFromDataTable(new WorkdayPrivilegeDAL().GetByUserId(userId, privilegeType));
        }
        public static string GetDepartmentIDsByUserId(int userId, int privilegeType)
        {
            List<WorkDayPrivilegeBLL> list = GenerateWorkDayPrivilegeBLLFromDataTable(new WorkdayPrivilegeDAL().GetByUserId(userId, privilegeType));

            string deptIds = string.Empty;
            foreach (WorkDayPrivilegeBLL obj in list)
            {
                deptIds += obj.DepartmentId + ",";
            }

            if (deptIds.Length > 0)
                deptIds = Util.RejectLastComma(deptIds);

            return deptIds;
        }

        public static string GetUserIDsByDeptId(int deptId, int privilegeType)
        {
            List<WorkDayPrivilegeBLL> list = GenerateWorkDayPrivilegeBLLFromDataTable(new WorkdayPrivilegeDAL().GetByDeptId(deptId, privilegeType));

            string userIds = ",";
            foreach (WorkDayPrivilegeBLL obj in list)
            {
                userIds += obj.UserId + ",";
            }

            return userIds;
        }

        public static string GetUserIdsByDeptIdIsInit(string deptIds, bool isInit, int privilegeType)
        {
            List<WorkDayPrivilegeBLL> list = GenerateWorkDayPrivilegeBLLFromDataTable(new WorkdayPrivilegeDAL().GetByDeptIdIsInit(deptIds, isInit, privilegeType));

            string userIds = ",";
            foreach (WorkDayPrivilegeBLL obj in list)
            {
                userIds += obj.UserId + ",";
            }

            //if (deptIds.Length > 0)
            //    deptIds = Util.RejectLastComma(deptIds);

            return userIds;
        }
        
        public static List<WorkDayPrivilegeBLL> GetUserIdsByDeptIdIsInit_(string deptIds, bool isInit, int privilegeType)
        {
            return GenerateWorkDayPrivilegeBLLFromDataTable(new WorkdayPrivilegeDAL().GetByDeptIdIsInit(deptIds, isInit, privilegeType));
        }

        public static List<WorkDayPrivilegeBLL> GetByDeptId(int deptId, int privilegeType)
        {
            return GenerateWorkDayPrivilegeBLLFromDataTable(new WorkdayPrivilegeDAL().GetByDeptId(deptId, privilegeType));
        }

        public static List<WorkDayPrivilegeBLL> GetByDeptIds(string deptIds, int privilegeType, string fullName)
        {
            return GenerateWorkDayPrivilegeBLLFromDataTable(new WorkdayPrivilegeDAL().GetByDeptIds(deptIds, privilegeType, fullName));
        }

        #endregion

        #region private methods

        private static List<WorkDayPrivilegeBLL> GenerateWorkDayPrivilegeBLLFromDataTable(DataTable dt)
        {
            List<WorkDayPrivilegeBLL> list = new List<WorkDayPrivilegeBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateWorkDayPrivilegeBLLFromDataRow(dr));
            }

            return list;
        }

        private static WorkDayPrivilegeBLL GenerateWorkDayPrivilegeBLLFromDataRow(DataRow dr)
        {
            WorkDayPrivilegeBLL objBLL = new WorkDayPrivilegeBLL();
            objBLL._UserId = dr[WorkdayPrivilageKeys.Field_Workday_Privilege_UserId] == DBNull.Value ? 0 : int.Parse(dr[WorkdayPrivilageKeys.Field_Workday_Privilege_UserId].ToString().Trim());
            objBLL._IsInit = dr[WorkdayPrivilageKeys.Field_Workday_Privilege_IsInit] == DBNull.Value ? false : Convert.ToBoolean(dr[WorkdayPrivilageKeys.Field_Workday_Privilege_IsInit].ToString());

            try
            {
                objBLL._DepartmentId = dr[WorkdayPrivilageKeys.Field_Workday_Privilege_DepartmentId] == DBNull.Value ? 0 : int.Parse(dr[WorkdayPrivilageKeys.Field_Workday_Privilege_DepartmentId].ToString());
            }
            catch { }

            try
            {
                objBLL._PrivilegeType = dr[WorkdayPrivilageKeys.Field_Workday_Privilege_PrivilegeType] == DBNull.Value ? 0 : int.Parse(dr[WorkdayPrivilageKeys.Field_Workday_Privilege_PrivilegeType].ToString());
            }
            catch { }

            try
            {
                objBLL._EmployeeCode = dr[WorkdayPrivilageKeys.Field_Workday_Privilege_EmployeeCode] == DBNull.Value ? string.Empty : dr[WorkdayPrivilageKeys.Field_Workday_Privilege_EmployeeCode].ToString();
            }
            catch { }
            try
            {
                objBLL._FullName = dr[WorkdayPrivilageKeys.Field_Workday_Privilege_FullName] == DBNull.Value ? string.Empty : dr[WorkdayPrivilageKeys.Field_Workday_Privilege_FullName].ToString();
            }
            catch { }
            try
            {
                objBLL._DepartmentFullName = dr[WorkdayPrivilageKeys.Field_Workday_Privilege_DepartmentFullName] == DBNull.Value ? string.Empty : dr[WorkdayPrivilageKeys.Field_Workday_Privilege_DepartmentFullName].ToString();
            }
            catch { }

            return objBLL;
        }

        #endregion
    }
}
