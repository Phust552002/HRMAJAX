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
    public class PITDeductionBLL
    {
        #region private fields

        private int _PITDeductionId = 0;
        private int _UserId = 0;
        private long _UserRelationId = 0;
        private string _TaxNumber = string.Empty;
        private string _Id_Passport = string.Empty;
        private int _FromMonth = 0;
        private int _FromYear = 0;
        private int _ToMonth = 0;
        private int _ToYear = 0;
        private System.DateTime _CreateDate = FormatDate.GetSQLDateMinValue;
        private int _CreateUser = 0;
        private System.DateTime _UpdateDate = FormatDate.GetSQLDateMinValue;
        private int _UpdateUser = 0;

        private string _DepartmentFullName;
        private string _FullName;
        private string _DepartmentCode;
        private string _RootName;
        private string _RFullName;
        private string _RelationTypeName;

        #endregion

        #region properties

        public int PITDeductionId
        {
            get { return _PITDeductionId; }
            set { _PITDeductionId = value; }
        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public long UserRelationId
        {
            get { return _UserRelationId; }
            set { _UserRelationId = value; }
        }
        public string TaxNumber
        {
            get { return _TaxNumber; }
            set { _TaxNumber = value; }
        }
        public string Id_Passport
        {
            get { return _Id_Passport; }
            set { _Id_Passport = value; }
        }
        public int FromMonth
        {
            get { return _FromMonth; }
            set { _FromMonth = value; }
        }
        public int FromYear
        {
            get { return _FromYear; }
            set { _FromYear = value; }
        }
        public int ToMonth
        {
            get { return _ToMonth; }
            set { _ToMonth = value; }
        }
        public int ToYear
        {
            get { return _ToYear; }
            set { _ToYear = value; }
        }
        public System.DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }
        public int CreateUser
        {
            get { return _CreateUser; }
            set { _CreateUser = value; }
        }
        public System.DateTime UpdateDate
        {
            get { return _UpdateDate; }
            set { _UpdateDate = value; }
        }
        public int UpdateUser
        {
            get { return _UpdateUser; }
            set { _UpdateUser = value; }
        }

        public string DepartmentFullName
        {
            get { return _DepartmentFullName; }
            set { _DepartmentFullName = value; }
        }
        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }
        public string DepartmentCode
        {
            get { return _DepartmentCode; }
            set { _DepartmentCode = value; }
        }
        public string RFullName
        {
            get { return _RFullName; }
            set { _RFullName = value; }
        }
        public string RelationTypeName
        {
            get { return _RelationTypeName; }
            set { _RelationTypeName = value; }
        }
        public string RootName
        {
            get { return _RootName; }
            set { _RootName = value; }
        }
        #endregion

        #region public methods insert, update, delete

        public int Save()
        {
            PITDeductionDAL objDAL = new PITDeductionDAL();

            if (_PITDeductionId <= 0)
            {
                return objDAL.Insert(_UserId, _UserRelationId, _TaxNumber, _Id_Passport, _FromMonth, _FromYear, _ToMonth, _ToYear, _CreateDate, _CreateUser, _UpdateDate, _UpdateUser);
            }
            else
            {
                return objDAL.Update(_UserId, _UserRelationId, _TaxNumber, _Id_Passport, _FromMonth, _FromYear, _ToMonth, _ToYear, _UpdateDate, _UpdateUser, _PITDeductionId);
            }

        }

        public static void Update(int userId, long userRelationId, string taxNumber, string id_Passport, int fromMonth, int fromYear, int toMonth, int toYear, System.DateTime updateDate, int updateUser, int pITDeductionId)
        {
            new PITDeductionDAL().Update(userId, userRelationId, taxNumber, id_Passport, fromMonth, fromYear, toMonth, toYear, updateDate, updateUser, pITDeductionId);
        }

        public static void Delete(int pITDeductionId)
        {
            new PITDeductionDAL().Delete(pITDeductionId);
        }

        #endregion

        #region public methods GET

        public static List<PITDeductionBLL> GetByFilter(string fullName, int rootId)
        {
            return GenerateListPITDeductionBLLFromDataTable(new PITDeductionDAL().GetByFilter(fullName, rootId));
        }

        public static PITDeductionBLL GetByUserIdUserRelationId(int userId, long userRelationId)
        {
            List<PITDeductionBLL> list = GenerateListPITDeductionBLLFromDataTable(new PITDeductionDAL().GetByUserIdUserRelationId(userId, userRelationId));
            return list.Count != 1 ? null : list[0];
        }
        public static List<PITDeductionBLL> GetByUserDate(int userId, int month, int  year)
        {
            return GenerateListPITDeductionBLLFromDataTable(new PITDeductionDAL().GetByUserDate(userId, month, year));
        }
        #endregion

        #region private methods

        private static List<PITDeductionBLL> GenerateListPITDeductionBLLFromDataTable(DataTable dt)
        {
            List<PITDeductionBLL> list = new List<PITDeductionBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GeneratePITDeductionBLLFromDataRow(dr));
            }

            return list;
        }

        private static PITDeductionBLL GeneratePITDeductionBLLFromDataRow(DataRow dr)
        {

            PITDeductionBLL objBLL = new PITDeductionBLL();

            try
            {
                objBLL._PITDeductionId = dr[PITDeductionKeys.Field_PITDeduction_Id] == DBNull.Value ? 0 : int.Parse(dr[PITDeductionKeys.Field_PITDeduction_Id].ToString());
            }
            catch { }
            try
            {
                objBLL._UserId = dr[PITDeductionKeys.Field_PITDeduction_UserId] == DBNull.Value ? 0 : int.Parse(dr[PITDeductionKeys.Field_PITDeduction_UserId].ToString());
            }
            catch { }
            try
            {
                objBLL._UserRelationId = dr[PITDeductionKeys.Field_PITDeduction_UserRelationId] == DBNull.Value ? 0 : long.Parse(dr[PITDeductionKeys.Field_PITDeduction_UserRelationId].ToString());
            }
            catch { }
            try
            {
                objBLL._TaxNumber = dr[PITDeductionKeys.Field_PITDeduction_TaxNumber] == DBNull.Value ? string.Empty : dr[PITDeductionKeys.Field_PITDeduction_TaxNumber].ToString();
            }
            catch { }
            try
            {
                objBLL._Id_Passport = dr[PITDeductionKeys.Field_PITDeduction_Id_Passport] == DBNull.Value ? string.Empty : dr[PITDeductionKeys.Field_PITDeduction_Id_Passport].ToString();
            }
            catch { }
            try
            {
                objBLL._FromMonth = dr[PITDeductionKeys.Field_PITDeduction_FromMonth] == DBNull.Value ? 0 : int.Parse(dr[PITDeductionKeys.Field_PITDeduction_FromMonth].ToString());
            }
            catch { }
            try
            {
                objBLL._FromYear = dr[PITDeductionKeys.Field_PITDeduction_FromYear] == DBNull.Value ? 0 : int.Parse(dr[PITDeductionKeys.Field_PITDeduction_FromYear].ToString());
            }
            catch { }
            try
            {
                objBLL._ToMonth = dr[PITDeductionKeys.Field_PITDeduction_ToMonth] == DBNull.Value ? 0 : int.Parse(dr[PITDeductionKeys.Field_PITDeduction_ToMonth].ToString());
            }
            catch { }
            try
            {
                objBLL._ToYear = dr[PITDeductionKeys.Field_PITDeduction_ToYear] == DBNull.Value ? 0 : int.Parse(dr[PITDeductionKeys.Field_PITDeduction_ToYear].ToString());
            }
            catch { }
            try
            {
                objBLL._CreateDate = dr[PITDeductionKeys.Field_PITDeduction_CreateDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[PITDeductionKeys.Field_PITDeduction_CreateDate].ToString());
            }
            catch { }
            try
            {
                objBLL._CreateUser = dr[PITDeductionKeys.Field_PITDeduction_CreateUser] == DBNull.Value ? 0 : int.Parse(dr[PITDeductionKeys.Field_PITDeduction_CreateUser].ToString());
            }
            catch { }
            try
            {
                objBLL._UpdateDate = dr[PITDeductionKeys.Field_PITDeduction_UpdateDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[PITDeductionKeys.Field_PITDeduction_UpdateUser].ToString());
            }
            catch { }
            try
            {
                objBLL._UpdateUser = dr[PITDeductionKeys.Field_PITDeduction_UpdateUser] == DBNull.Value ? 0 : int.Parse(dr[PITDeductionKeys.Field_PITDeduction_UpdateUser].ToString());
            }
            catch { }
            try
            {
                objBLL._DepartmentFullName = dr[PITDeductionKeys.Field_PITDeduction_DepartmentFullName] == DBNull.Value ? string.Empty : dr[PITDeductionKeys.Field_PITDeduction_DepartmentFullName].ToString();
            }
            catch { }
            try
            {
                objBLL._FullName = dr[PITDeductionKeys.Field_PITDeduction_FullName] == DBNull.Value ? string.Empty : dr[PITDeductionKeys.Field_PITDeduction_FullName].ToString();
            }
            catch { }
            try
            {
                objBLL._DepartmentCode = dr[PITDeductionKeys.Field_PITDeduction_DepartmentCode] == DBNull.Value ? string.Empty : dr[PITDeductionKeys.Field_PITDeduction_DepartmentCode].ToString();
            }
            catch { }
            try
            {
                objBLL._RFullName = dr[PITDeductionKeys.Field_PITDeduction_RFullName] == DBNull.Value ? string.Empty : dr[PITDeductionKeys.Field_PITDeduction_RFullName].ToString();
            }
            catch { }
            try
            {
                objBLL._RelationTypeName = dr[PITDeductionKeys.Field_PITDeduction_RelationTypeName] == DBNull.Value ? string.Empty : dr[PITDeductionKeys.Field_PITDeduction_RelationTypeName].ToString();
            }
            catch { }
            try
            {
                objBLL._RootName = dr[PITDeductionKeys.Field_PITDeduction_RootName] == DBNull.Value ? string.Empty : dr[PITDeductionKeys.Field_PITDeduction_RootName].ToString();
            }
            catch { }

            return objBLL;
        }

        #endregion
    }
}
