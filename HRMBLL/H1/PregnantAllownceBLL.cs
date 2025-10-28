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
    public class PregnantAllownceBLL
    {

        #region private fields

        private int _PregnantAllownceId=0;
        private int _UserId = 0;
        private DateTime _AllownceDate = FormatDate.GetSQLDateMinValue;
        private double _AllownceValue = 0;
        private int _IsCount = 0;

        private int _RootId = 0;
        private string _FullName = string.Empty;

        #endregion

        #region properties

        public int PregnantAllownceId
        {
            get { return _PregnantAllownceId; }
            set { _PregnantAllownceId = value; }
        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public System.DateTime AllownceDate
        {
            get { return _AllownceDate; }
            set { _AllownceDate = value; }
        }
        public double AllownceValue
        {
            get { return _AllownceValue; }
            set { _AllownceValue = value; }
        }
        public int IsCount
        {
            get { return _IsCount; }
            set { _IsCount = value; }
        }

        public int RootId
        {
            get { return _RootId; }
            set { _RootId = value; }
        }

        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }

        #endregion

        #region public methods insert, update, delete

        public int Save()
        {
            PregnantAllownceDAL objDAL = new PregnantAllownceDAL();

            if (_PregnantAllownceId <= 0)
            {
                return objDAL.Insert(_UserId, _AllownceDate, _AllownceValue, _IsCount);
            }
            else
            {
                return objDAL.Update(_UserId, _AllownceDate, _AllownceValue, _IsCount, _PregnantAllownceId);
            }
        }

        public static void Update(int userId, DateTime allownceDate, double allownceValue, int isCount, int pregnantAllownceId)
        {
            new PregnantAllownceDAL().Update(userId, allownceDate, allownceValue, isCount, pregnantAllownceId);
        }

        public static void Delete(int pregnantAllownceId)
        {
            new PregnantAllownceDAL().Delete(pregnantAllownceId);
        }
        public static void DeleteByUserId(int userId)
        {
            new PregnantAllownceDAL().DeleteByUserId(userId);
        }
        

        #endregion

        #region public methods GET

        public static List<PregnantAllownceBLL> GetByFilter(string fullName, int rootId, DateTime allownceDate)
        {
            return GenerateListPregnantAllownceBLLFromDataTable(new PregnantAllownceDAL().GetByFilter(fullName, rootId, allownceDate));
        }
        public static PregnantAllownceBLL GetById(int pregnantAllownceId)
        {
            List<PregnantAllownceBLL> list = GenerateListPregnantAllownceBLLFromDataTable(new PregnantAllownceDAL().GetById(pregnantAllownceId));
            if(list.Count ==1)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }
        public static PregnantAllownceBLL GetByUserAllownceDate(int userId, DateTime allownceDate)
        {
            List<PregnantAllownceBLL> list = GenerateListPregnantAllownceBLLFromDataTable(new PregnantAllownceDAL().GetByUserAllownceDate(userId, allownceDate));
            if (list.Count == 1)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }
        public static List<PregnantAllownceBLL> GetByUserId(int userId)
        {
            return GenerateListPregnantAllownceBLLFromDataTable(new PregnantAllownceDAL().GetByUserId(userId));
        }

        #endregion

        #region private methods

        private static List<PregnantAllownceBLL> GenerateListPregnantAllownceBLLFromDataTable(DataTable dt)
        {
            List<PregnantAllownceBLL> list = new List<PregnantAllownceBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GeneratePregnantAllownceBLLFromDataRow(dr));
            }

            return list;
        }

        private static PregnantAllownceBLL GeneratePregnantAllownceBLLFromDataRow(DataRow dr)
        {

            PregnantAllownceBLL objBLL = new PregnantAllownceBLL();

            objBLL._PregnantAllownceId = dr[PregnantAllownceKeys.Field_PregnantAllownce_PregnantAllownceId] == DBNull.Value ? 0 : int.Parse(dr[PregnantAllownceKeys.Field_PregnantAllownce_PregnantAllownceId].ToString());
            objBLL._UserId = dr[PregnantAllownceKeys.Field_PregnantAllownce_UserId] == DBNull.Value ? 0 : int.Parse(dr[PregnantAllownceKeys.Field_PregnantAllownce_UserId].ToString());
            objBLL._AllownceDate = dr[PregnantAllownceKeys.Field_PregnantAllownce_AllownceDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[PregnantAllownceKeys.Field_PregnantAllownce_AllownceDate].ToString());
            objBLL._AllownceValue = dr[PregnantAllownceKeys.Field_PregnantAllownce_AllownceValue] == DBNull.Value ? 0 : double.Parse(dr[PregnantAllownceKeys.Field_PregnantAllownce_AllownceValue].ToString());
            objBLL._IsCount = dr[PregnantAllownceKeys.Field_PregnantAllownce_IsCount] == DBNull.Value ? 0 : int.Parse(dr[PregnantAllownceKeys.Field_PregnantAllownce_IsCount].ToString());

            try
            {
                objBLL._FullName = dr[PregnantAllownceKeys.Field_PregnantAllownce_FullName] == DBNull.Value ? string.Empty : dr[PregnantAllownceKeys.Field_PregnantAllownce_FullName].ToString();
            }
            catch { }
            try
            {
                objBLL._RootId = dr[DepartmentKeys.FIELD_DEPARTMENT_ROOT_ID] == DBNull.Value ? 0 : int.Parse(dr[DepartmentKeys.FIELD_DEPARTMENT_ROOT_ID].ToString());
            }
            catch { }
            return objBLL;
        }

        #endregion

    }
}
