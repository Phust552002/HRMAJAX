using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H3;
using HRMUtil.KeyNames.H3;
using HRMUtil.KeyNames.H0;
using HRMUtil;

namespace HRMBLL.H3
{
    public class DecisionEmployeesBLL
    {

        #region private filed

        private long _DecisionEmployeeId;
        private int _DecisionId;
        private int _UserId;
        private string _FullName;
        private int _PositionId;
        private int _RootId;
        private System.DateTime _FromDate;
        private System.DateTime _ToDate;
        private string _Level;
        private string _Form;
        private string _Title;
        private int _KeyPosition;

        #endregion

        #region properties

        public int DecisionId
        {
            get
            {
                return _DecisionId;
            }
            set
            {
                _DecisionId = value;
            }
        }


        public long DecisionEmployeeId
        {
            get
            {
                return _DecisionEmployeeId;
            }
            set
            {
                _DecisionEmployeeId = value;
            }
        }

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

        public int PositionId
        {
            get
            {
                return _PositionId;
            }
            set
            {
                _PositionId = value;
            }
        }
        public int RootId
        {
            get
            {
                return _RootId;
            }
            set
            {
                _RootId = value;
            }
        }
        public System.DateTime FromDate
        {
            get
            {
                return _FromDate;
            }
            set
            {
                _FromDate = value;
            }
        }

        public System.DateTime ToDate
        {
            get
            {
                return _ToDate;
            }
            set
            {
                _ToDate = value;
            }
        }

        public string Level
        {
            get
            {
                return _Level;
            }
            set
            {
                _Level = value;
            }
        }

        public string Form
        {
            get
            {
                return _Form;
            }
            set
            {
                _Form = value;
            }
        }

        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }

        public int KeyPosition
        {
            get
            {
                return _KeyPosition;
            }
            set
            {
                _KeyPosition = value;
            }
        }

        #endregion

        #region public method Get

        public static List<DecisionEmployeesBLL> GetByDecisionId(int decisionId)
        {
            return GenerateListDecisionEmployeesBLLFromDataTable(new DecisionEmployeesDAL().GetByDecisionId(decisionId));
        }

        #endregion

        #region methods Insert, update, delete

        public long Save()
        {
            DecisionEmployeesDAL objDAL = new DecisionEmployeesDAL();

            if (_DecisionEmployeeId <= 0)
            {
                return objDAL.Insert(DecisionId, UserId, PositionId, RootId, FromDate, ToDate, Level, Form, Title, KeyPosition);
            }
            else
            {
                return objDAL.Update(DecisionId, UserId, PositionId, RootId, FromDate, ToDate, Level, Form, Title, KeyPosition, DecisionEmployeeId);
            }

        }

        public static void InsertByList(List<DecisionEmployeesBLL> list)
        {
            DecisionEmployeesDAL objDAL = new DecisionEmployeesDAL();

            foreach (DecisionEmployeesBLL obj in list)
            {
                if (obj._DecisionEmployeeId <= 0)
                {
                    objDAL.Insert(obj.DecisionId, obj.UserId, obj.PositionId, obj.RootId, obj.FromDate, obj.ToDate, obj.Level, obj.Form, obj.Title, obj.KeyPosition);
                }
                else
                {
                    objDAL.Update(obj.DecisionId, obj.UserId, obj.PositionId, obj.RootId, obj.FromDate, obj.ToDate, obj.Level, obj.Form, obj.Title, obj.KeyPosition, obj.DecisionEmployeeId);
                }
            }
        }

        public static void Update(int decisionId, int userId, int positionId, int rootId, DateTime fromDate, DateTime toDate, string level, string form, string title, int keyPosition, long decisionEmployeeId)
        {
            new DecisionEmployeesDAL().Update(decisionId, userId, positionId, rootId, fromDate, toDate, level, form, title, keyPosition, decisionEmployeeId);
        }

        public static void Delete(int decisionEmployeeId)
        {
            new DecisionEmployeesDAL().Delete(decisionEmployeeId);
        }

        public static void DeleteByDecisionId(int decisionId)
        {
            new DecisionEmployeesDAL().DeleteByDecisionId(decisionId);
        }
        public static void DeleteByIds(string decisionIds)
        {
            new DecisionEmployeesDAL().DeleteByIds(decisionIds);
        }

        #endregion

        #region private methods

        private static List<DecisionEmployeesBLL> GenerateListDecisionEmployeesBLLFromDataTable(DataTable dt)
        {
            List<DecisionEmployeesBLL> list = new List<DecisionEmployeesBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateDecisionEmployeesBLLFromDataRow(dr));
            }

            return list;
        }

        private static DecisionEmployeesBLL GenerateDecisionEmployeesBLLFromDataRow(DataRow dr)
        {

            DecisionEmployeesBLL objBLL = new DecisionEmployeesBLL();

            objBLL._DecisionEmployeeId = dr[DecisionEmployeesKeys.Field_DecisionEmployees_DecisionEmployeeId] == DBNull.Value ? 0 : long.Parse(dr[DecisionEmployeesKeys.Field_DecisionEmployees_DecisionEmployeeId].ToString());
            objBLL._DecisionId = dr[DecisionEmployeesKeys.Field_DecisionEmployees_UserId] == DBNull.Value ? 0 : int.Parse(dr[DecisionEmployeesKeys.Field_DecisionEmployees_UserId].ToString());
            objBLL._RootId = dr[DecisionEmployeesKeys.Field_DecisionEmployees_RootId] == DBNull.Value ? 0 : int.Parse(dr[DecisionEmployeesKeys.Field_DecisionEmployees_RootId].ToString());
            objBLL._UserId = dr[DecisionEmployeesKeys.Field_DecisionEmployees_UserId] == DBNull.Value ? 0 : int.Parse(dr[DecisionEmployeesKeys.Field_DecisionEmployees_UserId].ToString());
            objBLL._FullName = dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME].ToString();
            objBLL._PositionId = dr[DecisionEmployeesKeys.Field_DecisionEmployees_PositionId] == DBNull.Value ? 0 : int.Parse(dr[DecisionEmployeesKeys.Field_DecisionEmployees_PositionId].ToString());
            objBLL._FromDate = dr[DecisionEmployeesKeys.Field_DecisionEmployees_FromDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[DecisionEmployeesKeys.Field_DecisionEmployees_FromDate].ToString());
            objBLL._ToDate = dr[DecisionEmployeesKeys.Field_DecisionEmployees_ToDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[DecisionEmployeesKeys.Field_DecisionEmployees_ToDate].ToString());
            objBLL._Level = dr[DecisionEmployeesKeys.Field_DecisionEmployees_Level] == DBNull.Value ? string.Empty : dr[DecisionEmployeesKeys.Field_DecisionEmployees_Level].ToString();
            objBLL._Form = dr[DecisionEmployeesKeys.Field_DecisionEmployees_Form] == DBNull.Value ? string.Empty : dr[DecisionEmployeesKeys.Field_DecisionEmployees_Form].ToString();
            objBLL._Title = dr[DecisionEmployeesKeys.Field_DecisionEmployees_Title] == DBNull.Value ? string.Empty : dr[DecisionEmployeesKeys.Field_DecisionEmployees_Title].ToString();
            objBLL._KeyPosition = dr[DecisionEmployeesKeys.Field_DecisionEmployees_KeyPosition] == DBNull.Value ? 0 : int.Parse(dr[DecisionEmployeesKeys.Field_DecisionEmployees_KeyPosition].ToString());

            return objBLL;

        }

        #endregion
    }
}
