using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


using HRMDAL.Utilities;
using HRMDAL.H0;
using HRMUtil.KeyNames.H0;
using HRMUtil.KeyNames.H2;
using HRMUtil;

namespace HRMBLL.H0
{
    public class EmployeeEducationLevelsBLL
    {
        #region private fields

        private int _Id;
        private int _UserId;
        private int _EducationLevelId;
        private string _EducationLevelName;
        private string _EducationLevelValue;
        private string _Remark;

        private int _LastItem;
        

        #endregion

        #region properties

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public int EducationLevelId
        {
            get { return _EducationLevelId; }
            set { _EducationLevelId = value; }
        }
        public string EducationLevelValue
        {
            get { return _EducationLevelValue; }
            set { _EducationLevelValue = value; }
        }
        public string EducationLevelName
        {
            get { return _EducationLevelName; }
            set { _EducationLevelName = value; }
        }
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }
        public int LastItem
        {
            get { return _LastItem; }
            set { _LastItem = value; }
        }

        #endregion

        #region public methods

        public long Save()
        {
            EmployeeEducationLevelsDAL objDAL = new EmployeeEducationLevelsDAL();
            if (_Id <= 0)
            {
                return objDAL.Insert(_UserId, _EducationLevelId, _EducationLevelValue, _Remark);
            }
            else
            {
                return objDAL.Update(_UserId, _EducationLevelId, _EducationLevelValue, _Remark, _Id);
            }
        }


        public static long Update(int userId, int educationLevelId, string educationLevelValue, string remark, int id)
        {
            return new EmployeeEducationLevelsDAL().Update(userId, educationLevelId, educationLevelValue, remark, id);
        }

        public static long UpdateHighest(int userId, int educationLevelId)
        {
            return new EmployeeEducationLevelsDAL().UpdateHighest(userId, educationLevelId);
        }

        public static long Delete(int id)
        {
            return new EmployeeEducationLevelsDAL().Delete(id);
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

        #endregion

        #region public methods get
       
        public static List<EmployeeEducationLevelsBLL> GetById(int userId)
        {
            return GenerateListFromDataTable(new EmployeeEducationLevelsDAL().GetById(userId));
        }


        #endregion

        #region private methods

        private static List<EmployeeEducationLevelsBLL> GenerateListFromDataTable(DataTable dt)
        {
            List<EmployeeEducationLevelsBLL> list = new List<EmployeeEducationLevelsBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateFromDataTable(dr, dt.Rows.Count));
            }

            return list;
        }

        private static EmployeeEducationLevelsBLL GenerateFromDataTable(DataRow dr)
        {
            EmployeeEducationLevelsBLL c = new EmployeeEducationLevelsBLL();

            c._Id = dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_ID] == DBNull.Value ? 0 : int.Parse(dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_ID].ToString());
            c._UserId = dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_USER_ID] == DBNull.Value ? 0 : int.Parse(dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_USER_ID].ToString());
            c._EducationLevelId = dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_EDUCATION_LEVEL_ID] == DBNull.Value ? 0 : int.Parse(dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_EDUCATION_LEVEL_ID].ToString());
            c._EducationLevelValue = dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_VALUE] == DBNull.Value ? string.Empty : dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_VALUE].ToString();
            c._Remark = dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_REMARK] == DBNull.Value ? string.Empty : dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_REMARK].ToString();

            c._EducationLevelName = dr[EducationLevelKeys.FIELD_EDUCATION_LEVEL_NAME] == DBNull.Value ? string.Empty : dr[EducationLevelKeys.FIELD_EDUCATION_LEVEL_NAME].ToString();
            return c;
        }

        private static EmployeeEducationLevelsBLL GenerateFromDataTable(DataRow dr, int itemLastIndex)
        {
            EmployeeEducationLevelsBLL c = new EmployeeEducationLevelsBLL();

            c._Id = dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_ID] == DBNull.Value ? 0 : int.Parse(dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_ID].ToString());
            c._UserId = dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_USER_ID] == DBNull.Value ? 0 : int.Parse(dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_USER_ID].ToString());
            c._EducationLevelId = dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_EDUCATION_LEVEL_ID] == DBNull.Value ? 0 : int.Parse(dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_EDUCATION_LEVEL_ID].ToString());
            c._EducationLevelValue = dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_VALUE] == DBNull.Value ? string.Empty : dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_VALUE].ToString();
            c._Remark = dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_REMARK] == DBNull.Value ? string.Empty : dr[EmployeeEducationLevelKeys.FIELD_EMPLOYEE_EDUCATION_LEVEL_REMARK].ToString();

            c._EducationLevelName = dr[EducationLevelKeys.FIELD_EDUCATION_LEVEL_NAME] == DBNull.Value ? string.Empty : dr[EducationLevelKeys.FIELD_EDUCATION_LEVEL_NAME].ToString();

            c._LastItem = itemLastIndex;
            return c;
        }

        #endregion
    }
}
