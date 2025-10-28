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
    public class HTCVEmployeeBLL
    {

        #region private fields


        private long _HTCVEmployeeId;
        private int _UserId;
        private int _HTCVCatalogueId;
        private string _HTCVCatalogueName;
        private double _Mark;
        private System.DateTime _MarkDate;
        private string _MarkDisplay; 
        private string _Remark;
        private int _TypeDisplay;

        private double _MinMark;
        private double _MaxMark;
        private int _ParentId;

        private string _FullName;
        private string _PositionName;
        private string _DepartmentName;
        private string _DepartmentFullName;

        #endregion

        #region properties

        public long HTCVEmployeeId
        {
            get { return _HTCVEmployeeId; }
            set { _HTCVEmployeeId = value; }
        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public int HTCVCatalogueId
        {
            get { return _HTCVCatalogueId; }
            set { _HTCVCatalogueId = value; }
        }
        public string HTCVCatalogueName
        {
            get { return _HTCVCatalogueName; }
            set { _HTCVCatalogueName = value; }
        }
        public double Mark
        {
            get { return _Mark; }
            set { _Mark = value; }
        }
        public int TypeDisplay
        {
            get { return _TypeDisplay; }
            set { _TypeDisplay = value; }
        }
        public System.DateTime MarkDate
        {
            get { return _MarkDate; }
            set { _MarkDate = value; }
        }
        public string MarkDisplay
        {
            get { return _MarkDisplay; }
            set { _MarkDisplay = value; }
        } 
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        public double MinMark
        {
            get { return _MinMark; }
            set { _MinMark = value; }
        }
        public double MaxMark
        {
            get { return _MaxMark; }
            set { _MaxMark = value; }
        }
        public int ParentId
        {
            get { return _ParentId; }
            set { _ParentId = value; }
        }

        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }
        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }
        public string DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }
        public string DepartmentFullName
        {
            get { return _DepartmentFullName; }
            set { _DepartmentFullName = value; }
        }

        #endregion

        #region public methods insert, update, delete

        public int Save()
        {
            HTCVEmployeeDAL objDAL = new HTCVEmployeeDAL();

            if (_HTCVEmployeeId <= 0)
            {
                return objDAL.Insert(UserId, HTCVCatalogueId, Mark, MarkDate, Remark);
            }
            else
            {
                return objDAL.Update(UserId, HTCVCatalogueId, Mark, MarkDate, Remark, HTCVEmployeeId);
            }

        }

        public static void Update(int userId, int hTCVCatalogueId, double mark, System.DateTime markDate, string remark, long hTCVEmployeeId)
        {
            new HTCVEmployeeDAL().Update(userId, hTCVCatalogueId, mark, markDate, remark, hTCVEmployeeId);
        }

        public static void Delete(int hTCVEmployeeId)
        {
            new HTCVEmployeeDAL().Delete(hTCVEmployeeId);
        }
        public static void DeleteByIds(string hTCVEmployeeIds)
        {
            new HTCVEmployeeDAL().DeleteByIds(hTCVEmployeeIds);
        }
        public static void DeleteByUserDate(int userId, DateTime markDate)
        {
            new HTCVEmployeeDAL().DeleteDate(userId, markDate);
        }

        #endregion

        #region public methods GET

        public static List<HTCVEmployeeBLL> GetByFilter(int userid, int hTCVCatalogueId, double mark, System.DateTime markdate)
        {
            return GenerateListHTCVEmployeeBLLFromDataTable(new HTCVEmployeeDAL().GetByFilter(userid, hTCVCatalogueId, mark, markdate));
        }

        public static string GetForAllRemarkByUserIdDate(int userid, int month, int year)
        {
            DataTable dt = new HTCVEmployeeDAL().GetForAllRemarkByUserIdDate(userid, month, year);
            return dt.Rows.Count > 0 ? dt.Rows[0]["AllRemark"].ToString() : "";
        }


        #endregion

        #region private methods

        private static List<HTCVEmployeeBLL> GenerateListHTCVEmployeeBLLFromDataTable(DataTable dt)
        {
            List<HTCVEmployeeBLL> list = new List<HTCVEmployeeBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateHTCVEmployeeBLLFromDataRow(dr));
            }

            return list;
        }

        private static HTCVEmployeeBLL GenerateHTCVEmployeeBLLFromDataRow(DataRow dr)
        {

            HTCVEmployeeBLL objBLL = new HTCVEmployeeBLL();

            objBLL._HTCVEmployeeId = dr[HTCVEmployeeKeys.Field_HTCVEmployee_ID] == DBNull.Value ? 0 : long.Parse(dr[HTCVEmployeeKeys.Field_HTCVEmployee_ID].ToString());
            objBLL._HTCVCatalogueId = dr[HTCVEmployeeKeys.Field_HTCVEmployee_HTCVCatalogueId] == DBNull.Value ? 0 : int.Parse(dr[HTCVEmployeeKeys.Field_HTCVEmployee_HTCVCatalogueId].ToString());
            objBLL._Mark = dr[HTCVEmployeeKeys.Field_HTCVEmployee_Mark] == DBNull.Value ? 0 : double.Parse(dr[HTCVEmployeeKeys.Field_HTCVEmployee_Mark].ToString());
            objBLL._MarkDate = dr[HTCVEmployeeKeys.Field_HTCVEmployee_MarkDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[HTCVEmployeeKeys.Field_HTCVEmployee_MarkDate].ToString());
            objBLL._Remark = dr[HTCVEmployeeKeys.Field_HTCVEmployee_Remark] == DBNull.Value ? string.Empty : dr[HTCVEmployeeKeys.Field_HTCVEmployee_Remark].ToString();
            objBLL._TypeDisplay = dr[HTCVCatalogueKeys.Field_HTCVCatalogue_TypeDisplay] == DBNull.Value ? 0 : int.Parse(dr[HTCVCatalogueKeys.Field_HTCVCatalogue_TypeDisplay].ToString());
            objBLL._UserId = dr[HTCVEmployeeKeys.Field_HTCVEmployee_UserId] == DBNull.Value ? 0 : int.Parse(dr[HTCVEmployeeKeys.Field_HTCVEmployee_UserId].ToString());
            try
            {
                objBLL._HTCVCatalogueName = dr[HTCVCatalogueKeys.Field_HTCVCatalogue_Name] == DBNull.Value ? string.Empty : dr[HTCVCatalogueKeys.Field_HTCVCatalogue_Name].ToString();
            }
            catch { }

            objBLL._MarkDisplay = dr[HTCVCatalogueKeys.Field_HTCVCatalogue_MarkDisplay] == DBNull.Value ? string.Empty : dr[HTCVCatalogueKeys.Field_HTCVCatalogue_MarkDisplay].ToString();
            objBLL._MinMark = dr[HTCVCatalogueKeys.Field_HTCVCatalogue_MinMark] == DBNull.Value ? 0 : double.Parse(dr[HTCVCatalogueKeys.Field_HTCVCatalogue_MinMark].ToString());
            objBLL._MaxMark = dr[HTCVCatalogueKeys.Field_HTCVCatalogue_MaxMark] == DBNull.Value ? 0 : double.Parse(dr[HTCVCatalogueKeys.Field_HTCVCatalogue_MaxMark].ToString());
            objBLL._ParentId = dr[HTCVCatalogueKeys.Field_HTCVCatalogue_ParentId] == DBNull.Value ? 0 : int.Parse(dr[HTCVCatalogueKeys.Field_HTCVCatalogue_ParentId].ToString());

            try
            {
                objBLL._FullName = dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME];
            }
            catch { }
            try
            {
                objBLL._PositionName = dr[PositionKeys.FIELD_POSITION_NAME] == DBNull.Value ? string.Empty : (string)dr[PositionKeys.FIELD_POSITION_NAME];
            }
            catch { }
           
            try
            {
                objBLL._DepartmentName = dr[DepartmentKeys.FIELD_DEPARTMENT_NAME] == DBNull.Value ? string.Empty : (string)dr[DepartmentKeys.FIELD_DEPARTMENT_NAME];
            }
            catch { }
            try
            {
                objBLL._DepartmentFullName = dr[DepartmentKeys.Field_Department_DepartmentFullName] == DBNull.Value ? string.Empty : (string)dr[DepartmentKeys.Field_Department_DepartmentFullName];
            }
            catch { }

            return objBLL;
        }

        #endregion

    }
}
