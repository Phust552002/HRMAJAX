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

namespace HRMBLL.H0
{
    public class EmployeeRelationBLL
    {
        #region private fields


        private long _UserRelationId = 0;
        private int _UserId = 0;
        private int _RelationTypeId = 0;
        private string _RFullName = string.Empty;
        private int _RDayOfBirth = 0;
        private int _RMonthOfBirth = 0;
        private int _RYearOfBirth = 0;
        private string _RNativePlace = string.Empty;
        private string _RResident = string.Empty;
        private string _RLive = string.Empty;
        private string _Before1975 = string.Empty;
        private string _After1975 = string.Empty;
        private string _Participate = string.Empty;
        private bool _Died = false;
        private string _DiedCause = string.Empty;
        private string _Others = string.Empty;

        private string _RelationTypeName;
        private int _Type;

        #endregion

        #region properties

        public long UserRelationId
        {
            get { return _UserRelationId; }
            set { _UserRelationId = value; }
        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public int RelationTypeId
        {
            get { return _RelationTypeId; }
            set { _RelationTypeId = value; }
        }
        public string RFullName
        {
            get { return _RFullName; }
            set { _RFullName = value; }
        }
        public int RDayOfBirth
        {
            get { return _RDayOfBirth; }
            set { _RDayOfBirth = value; }
        }
        public int RMonthOfBirth
        {
            get { return _RMonthOfBirth; }
            set { _RMonthOfBirth = value; }
        }
        public int RYearOfBirth
        {
            get { return _RYearOfBirth; }
            set { _RYearOfBirth = value; }
        }
        public string RNativePlace
        {
            get { return _RNativePlace; }
            set { _RNativePlace = value; }
        }
        public string RResident
        {
            get { return _RResident; }
            set { _RResident = value; }
        }
        public string RLive
        {
            get { return _RLive; }
            set { _RLive = value; }
        }
        public string Before1975
        {
            get { return _Before1975; }
            set { _Before1975 = value; }
        }
        public string After1975
        {
            get { return _After1975; }
            set { _After1975 = value; }
        }
        public string Participate
        {
            get { return _Participate; }
            set { _Participate = value; }
        }
        public bool Died
        {
            get { return _Died; }
            set { _Died = value; }
        }
        public string DiedCause
        {
            get { return _DiedCause; }
            set { _DiedCause = value; }
        }
        public string Others
        {
            get { return _Others; }
            set { _Others = value; }
        }

        public string RelationTypeName
        {
            get { return _RelationTypeName; }
            set { _RelationTypeName = value; }
        }
        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        #endregion

        #region public methods Get

        public static List<EmployeeRelationBLL> GetByFilter(System.Nullable<int> relationTypeId, System.Nullable<int> userId, System.Nullable<int> type)
        {
            return GenerateListEmployeeRelationBLLFromDataTable(new EmployeeRelationDAL().GetByFilter(relationTypeId, userId, type));
        }

        #endregion

        #region public methods Insert, Update, Delete

        public long Save()
        {
            EmployeeRelationDAL objDAL = new EmployeeRelationDAL();
            if (UserRelationId <= 0)
            {
                return objDAL.Insert(UserId, RelationTypeId, RFullName, RDayOfBirth, RMonthOfBirth, RYearOfBirth, RNativePlace,
                            RResident, RLive, Before1975, After1975, Participate, Died, DiedCause, Others);
            }
            else
            {
                return objDAL.Update(UserId, RelationTypeId, RFullName, RDayOfBirth, RMonthOfBirth, RYearOfBirth, RNativePlace,
                           RResident, RLive, Before1975, After1975, Participate, Died, DiedCause, Others, UserRelationId);
            }

        }

        public static void Update(System.Nullable<int> userId,
                    System.Nullable<int> relationTypeId,
                    string rFullName,
                    System.Nullable<int> rDayOfBirth,
                    System.Nullable<int> rMonthOfBirth,
                    System.Nullable<int> rYearOfBirth,
                    string rNativePlace,
                    string rResident,
                    string rLive,
                    string before1975,
                    string after1975,
                    string participate,
                    System.Nullable<bool> died,
                    string diedCause,
                    string others,
                    System.Nullable<long> userRelationId)
        {
            new EmployeeRelationDAL().Update(userId, relationTypeId, rFullName, rDayOfBirth, rMonthOfBirth, rYearOfBirth, rNativePlace,
                           rResident, rLive, before1975, after1975, participate, died, diedCause, others, userRelationId);
        }

        public static void Delete(System.Nullable<long> userRelationId)
        {
            new EmployeeRelationDAL().Delete(userRelationId);
        }


        #endregion

        #region private methods, generate helper methods

        private static List<EmployeeRelationBLL> GenerateListEmployeeRelationBLLFromDataTable(DataTable dt)
        {
            List<EmployeeRelationBLL> list = new List<EmployeeRelationBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateEmployeeRelationBLLFromDataRow(dr));
            }

            return list;
        }

        private static EmployeeRelationBLL GenerateEmployeeRelationBLLFromDataRow(DataRow dr)
        {
            EmployeeRelationBLL objBLL = new EmployeeRelationBLL();

            objBLL._UserRelationId = dr[EmployeeRelationKeys.Field_EmployeeRelation_UserRelationId] == DBNull.Value ? 0 : (long)dr[EmployeeRelationKeys.Field_EmployeeRelation_UserRelationId];
            objBLL._UserId = dr[EmployeeRelationKeys.Field_EmployeeRelation_UserId] == DBNull.Value ? 0 : (int)dr[EmployeeRelationKeys.Field_EmployeeRelation_UserId];
            objBLL._RelationTypeId = dr[EmployeeRelationKeys.Field_EmployeeRelation_RelationTypeId] == DBNull.Value ? 0 : (int)dr[EmployeeRelationKeys.Field_EmployeeRelation_RelationTypeId];
            objBLL._RFullName = dr[EmployeeRelationKeys.Field_EmployeeRelation_RFullName] == DBNull.Value ? string.Empty : (string)dr[EmployeeRelationKeys.Field_EmployeeRelation_RFullName];
            objBLL._RDayOfBirth = dr[EmployeeRelationKeys.Field_EmployeeRelation_RDayOfBirth] == DBNull.Value ? 0 : (int)dr[EmployeeRelationKeys.Field_EmployeeRelation_RDayOfBirth];
            objBLL._RMonthOfBirth = dr[EmployeeRelationKeys.Field_EmployeeRelation_RMonthOfBirth] == DBNull.Value ? 0 : (int)dr[EmployeeRelationKeys.Field_EmployeeRelation_RMonthOfBirth];
            objBLL._RYearOfBirth = dr[EmployeeRelationKeys.Field_EmployeeRelation_RYearOfBirth] == DBNull.Value ? 0 : (int)dr[EmployeeRelationKeys.Field_EmployeeRelation_RYearOfBirth];
            objBLL._RNativePlace = dr[EmployeeRelationKeys.Field_EmployeeRelation_RNativePlace] == DBNull.Value ? string.Empty : (string)dr[EmployeeRelationKeys.Field_EmployeeRelation_RNativePlace];
            objBLL._RResident = dr[EmployeeRelationKeys.Field_EmployeeRelation_RResident] == DBNull.Value ? string.Empty : (string)dr[EmployeeRelationKeys.Field_EmployeeRelation_RResident];
            objBLL._RLive = dr[EmployeeRelationKeys.Field_EmployeeRelation_RLive] == DBNull.Value ? string.Empty : (string)dr[EmployeeRelationKeys.Field_EmployeeRelation_RLive];
            objBLL._Before1975 = dr[EmployeeRelationKeys.Field_EmployeeRelation_Before1975] == DBNull.Value ? string.Empty : (string)dr[EmployeeRelationKeys.Field_EmployeeRelation_Before1975];
            objBLL._After1975 = dr[EmployeeRelationKeys.Field_EmployeeRelation_After1975] == DBNull.Value ? string.Empty : (string)dr[EmployeeRelationKeys.Field_EmployeeRelation_After1975];
            objBLL._Participate = dr[EmployeeRelationKeys.Field_EmployeeRelation_Participate] == DBNull.Value ? string.Empty : (string)dr[EmployeeRelationKeys.Field_EmployeeRelation_Participate];
            objBLL._Died = dr[EmployeeRelationKeys.Field_EmployeeRelation_Died] == DBNull.Value ? false : Convert.ToBoolean(dr[EmployeeRelationKeys.Field_EmployeeRelation_Died]);
            objBLL._DiedCause = dr[EmployeeRelationKeys.Field_EmployeeRelation_DiedCause] == DBNull.Value ? string.Empty : (string)dr[EmployeeRelationKeys.Field_EmployeeRelation_DiedCause];
            objBLL._Others = dr[EmployeeRelationKeys.Field_EmployeeRelation_Others] == DBNull.Value ? string.Empty : (string)dr[EmployeeRelationKeys.Field_EmployeeRelation_Others];

            try
            {
                objBLL._RelationTypeName = dr[RelationTypeKeys.FIELD_RELATION_TYPE_NAME] == DBNull.Value ? string.Empty : (string)dr[RelationTypeKeys.FIELD_RELATION_TYPE_NAME];
            }
            catch { }
            try
            {
                objBLL._Type = dr[RelationTypeKeys.FIELD_RELATION_TYPE_TYPE] == DBNull.Value ? -1 : (int)dr[RelationTypeKeys.FIELD_RELATION_TYPE_TYPE];
            }
            catch { }

            return objBLL;
        }




        #endregion
    }
}
