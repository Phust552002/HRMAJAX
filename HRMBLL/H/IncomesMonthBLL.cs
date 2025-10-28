using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

using HRMDAL.Utilities;
using HRMDAL.H;
using HRMUtil.KeyNames.H;
using HRMBLL.H.Helper;

namespace HRMBLL.H
{
    public class IncomesMonthBLL
    {

        #region private fields

        private Int64 _IncomeMonthId;
        private int _IncomeTypeId;
        private string _IncomeName;
        private double _Value;
        private DateTime _Date;
        private string _Description;
        private string _UserCode;
        private bool _Type;
        private int _UserId;
        #endregion

        #region properties

        public Int64 IncomeMonthId
        {
            get { return _IncomeMonthId; }
            set { _IncomeMonthId = value; }
        }

        public double Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public int IncomeTypeId
        {
            get { return _IncomeTypeId; }
            set { _IncomeTypeId = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public string UserCode
        {
            get { return _UserCode; }
            set { _UserCode = value; }
        }
        public bool Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private string IncomeName
        {
            get { return _IncomeName; }
            set { _IncomeName = value; }
        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        #endregion

        #region constructor

        public IncomesMonthBLL(Int64 incomeMonthId, double value, DateTime date)
        {
            _IncomeMonthId = incomeMonthId;
            _Value = value;
            _Date = date;
        }

        #endregion

        #region public methods Get

        public static List<IncomesMonthBLL> GetByUserId_Monthly(int userId, int month, int year, bool type)
        {
            IncomesMonthDAL objDAL = new IncomesMonthDAL();
            return GenerateListIncomesMonthBLLFromDataTable(objDAL.GetByUserId_Monthly(userId, month, year, type));
        }

        public static List<IncomesMonthBLL> GetAllByUserId_Monthly(int userId, int month, int year)
        {
            IncomesMonthDAL objDAL = new IncomesMonthDAL();
            return GenerateListIncomesMonthBLLFromDataTable(objDAL.GetAllByUserId_Monthly(userId, month, year));
        }

        public static DataTable GetAllByUserId_Monthly_By_All(int userId, int month, int year)
        {
            IncomesMonthDAL objDAL = new IncomesMonthDAL();
            return (objDAL.GetAllByUserId_Monthly_By_All(userId, month, year));
        }

        public static DataTable GetAllByUserId_Paid_Monthly_By_All(int userId, int month, int year)
        {
            IncomesMonthDAL objDAL = new IncomesMonthDAL();
            return (objDAL.GetAllByUserId_Paid_Monthly_By_All(userId, month, year));
        }

        public static DataTable GetAllByUserId_Bonus_Monthly_By_All(int userId, int year)
        {
            IncomesMonthDAL objDAL = new IncomesMonthDAL();
            return (objDAL.GetAllByUserId_Bonus_Monthly_By_All(userId, year));
        }

        #endregion

        #region methods insert, update, delete

        public long Save()
        {
            if (IncomeMonthId <= 0)
            {
                IncomesMonthDAL objDAL = new IncomesMonthDAL();
                return objDAL.Insert(IncomeTypeId,Type, UserCode, Value, Date, UserId);
            }
            else
            {
                return -1;
            }
        }

        #endregion

        #region private methods, generate helper methods

        private static List<IncomesMonthBLL> GenerateListIncomesMonthBLLFromDataTable(DataTable dt)
        {
            List<IncomesMonthBLL> list = new List<IncomesMonthBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateIncomesMonthBLLFromDataRow(dr));
            }

            return list;
        }

        private static IncomesMonthBLL GenerateIncomesMonthBLLFromDataRow(DataRow dr)
        {
            IncomesMonthBLL objBLL = new IncomesMonthBLL(
            dr[IncomeMonthKeys.FIELD_INCOME_MONTH_ID] == DBNull.Value ? DefaultValues.IncomeMonthIdMinValue : Convert.ToInt64(dr[IncomeMonthKeys.FIELD_INCOME_MONTH_ID].ToString()),
            dr[IncomeMonthKeys.FIELD_INCOME_MONTH_VALUE] == DBNull.Value ? 0 : Convert.ToDouble(dr[IncomeMonthKeys.FIELD_INCOME_MONTH_VALUE].ToString()),
            dr[IncomeMonthKeys.FIELD_INCOME_MONTH_DATE] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr[IncomeMonthKeys.FIELD_INCOME_MONTH_DATE].ToString())
            );

            objBLL.IncomeName = dr[IncomeTypeKeys.FIELD_INCOME_TYPE_NAME] == DBNull.Value ? string.Empty : (string)dr[IncomeTypeKeys.FIELD_INCOME_TYPE_NAME];
            objBLL.Description = dr[IncomeTypeKeys.FIELD_INCOME_TYPE_DESCRIPTION] == DBNull.Value ? string.Empty : (string)dr[IncomeTypeKeys.FIELD_INCOME_TYPE_DESCRIPTION];

            try
            {
                objBLL.IncomeTypeId = dr[IncomeTypeKeys.FIELD_INCOME_TYPE_ID] == DBNull.Value ? DefaultValues.IncomeMonthIdMinValue : int.Parse(dr[IncomeTypeKeys.FIELD_INCOME_TYPE_ID].ToString());
            }
            catch { }

            return objBLL;
        }

        #endregion

    }
}
