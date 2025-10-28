using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H0;
using HRMUtil.KeyNames.H0;
using HRMBLL.H0.Helper;
using HRMUtil;

namespace HRMBLL.H0
{
    public class DepartmentEmployeeBLL
    {

        #region private fields

        private int _DepartmentId;
        private string _DepartmentName;
        private int _UserId;
        private string _UserName;
        private string _EmployeeCode;
        private string _FullName;
        private DateTime _Birthday;
        private int _RootId;

        public int RootId
        {
            get { return _RootId; }
            set { _RootId = value; }
        }
        #endregion

        #region properties

        public int DepartmentId
        {
            get { return _DepartmentId; }
            set { _DepartmentId = value; }
        }

        public string DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }

     
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        public string UserName
        {
            get
            {
                if (String.IsNullOrEmpty(_UserName))
                    return string.Empty;
                else
                    return _UserName;
            }
            set { _UserName = value; }
        }

        public String EmployeeCode
        {
            get
            {
                if (String.IsNullOrEmpty(_EmployeeCode))
                    return string.Empty;
                else
                    return _EmployeeCode;
            }
            set { _EmployeeCode = value; }
        }
       
        public string FullName
        {
            get
            {
                if (String.IsNullOrEmpty(_FullName))
                    return string.Empty;
                else
                    return _FullName;
            }
            set { _FullName = value; }
        }
        public DateTime Birthday
        {
            get { return _Birthday; }
            set { _Birthday = value; }
        }

        #endregion

        #region constructors

        public DepartmentEmployeeBLL(int departmentId, int userId)
        {
            _DepartmentId = departmentId;
            _UserId = userId;
        }

        #endregion

        #region public methods insert, update, delete

        public long Insert()
        {
            return new DepartmentEmployeeDAL().Insert(_DepartmentId, _UserId);
        }

        public static long Insert(int departmentId, string userIds)
        {
            return new DepartmentEmployeeDAL().Insert(departmentId, userIds);
        }

        public static long Update(int departmentId, int userId)
        {
            return new DepartmentEmployeeDAL().Update(departmentId, userId);
        }

        public static long DeleteDeptIdUserIds(int departmentId, string userIds)
        {
            return new DepartmentEmployeeDAL().DeleteDeptIdUserIds(departmentId, userIds);
        }
       
        #endregion

        #region public static Get methods

        public static List<DepartmentEmployeeBLL> GetByDeptId(int departmentId)
        {
            string name = DepartmentsBLL.GetDepartmentNameByDeptId(departmentId);
            return GenerateListDepartmentEmployeeBLLFromDataTable(new DepartmentEmployeeDAL().GetByDeptId(departmentId));
        }

        public static List<DepartmentEmployeeBLL> GetByRoot(int rootId)
        {
            return GenerateListDepartmentEmployeeBLLFromDataTable(new DepartmentEmployeeDAL().GetByRoot(rootId));
        }
        public static List<DepartmentEmployeeBLL> GetByRootLeaveDate(int rootId, DateTime leaveDate)
        {
            return GenerateListDepartmentEmployeeBLLFromDataTable(new DepartmentEmployeeDAL().GetByRootLeaveDate(rootId, leaveDate));
        }

        public static List<DepartmentEmployeeBLL> GetByUserId(int userId)
        {
            return GenerateListDepartmentEmployeeBLLFromDataTable(new DepartmentEmployeeDAL().GetByUserId(userId));
        }

        public static List<DepartmentEmployeeBLL> GetAll()
        {
            return GenerateListDepartmentEmployeeBLLFromDataTable(new DepartmentEmployeeDAL().GetAll());
        }

        #endregion

        #region private methods

        private static List<DepartmentEmployeeBLL> GenerateListDepartmentEmployeeBLLFromDataTable(DataTable dt)
        {
            List<DepartmentEmployeeBLL> list = new List<DepartmentEmployeeBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateDepartmentEmployeeBLLFromDataRow(dr));
            }

            return list;
        }

        private static DepartmentEmployeeBLL GenerateDepartmentEmployeeBLLFromDataRow(DataRow dr)
        {
            DepartmentEmployeeBLL objBLL = new DepartmentEmployeeBLL(
                dr[DepartmentKeys.FIELD_DEPARTMENT_ID] == DBNull.Value ? 0 : int.Parse(dr[DepartmentKeys.FIELD_DEPARTMENT_ID].ToString()),
                dr[EmployeeKeys.FIELD_EMPLOYEES_USERID] == DBNull.Value ? 0 : int.Parse(dr[EmployeeKeys.FIELD_EMPLOYEES_USERID].ToString())
                );

            try
            {

                objBLL._DepartmentName = dr[DepartmentKeys.FIELD_DEPARTMENT_NAME] == DBNull.Value ? string.Empty : dr[DepartmentKeys.FIELD_DEPARTMENT_NAME].ToString();
                objBLL._EmployeeCode = dr[EmployeeKeys.FIELD_EMPLOYEES_EMPLOYEE_CODE] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_EMPLOYEE_CODE].ToString();
                objBLL._FullName = dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME].ToString();
                objBLL._UserName = dr[EmployeeKeys.FIELD_EMPLOYEES_USERNAME] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_USERNAME].ToString();
                objBLL._Birthday = dr[EmployeeKeys.FIELD_EMPLOYEES_BIRTHDAY] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[EmployeeKeys.FIELD_EMPLOYEES_BIRTHDAY].ToString());
                objBLL._RootId = dr["RootId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["RootId"]);
            }
            catch { }

            return objBLL;
        }

        #endregion

    }
}
