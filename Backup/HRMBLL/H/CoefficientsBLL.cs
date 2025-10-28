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
    public class CoefficientsBLL
    {

        #region private fields

        private Int64 _CoefficientId;
        private double _Value;
        private DateTime _Date;
        private int _CoefficientTypeId;
        private string _CoefficientName;
        private string _Description;
        private string _UserCode;
        private int _UserId;

        #endregion

        #region properties

        public Int64 CoefficientId
        {
            get { return _CoefficientId; }
            set { _CoefficientId = value; }
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

        public int CoefficientTypeId
        {
            get { return _CoefficientTypeId; }
            set { _CoefficientTypeId = value; }
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
        public string CoefficientName
        {
            get { return _CoefficientName; }
            set { _CoefficientName = value; }
        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        #endregion

        #region constructor

        public CoefficientsBLL(Int64 coefficientId, double value, DateTime date)
        {
            _CoefficientId = coefficientId;
            _Value = value;
            _Date = date;
        }

        #endregion

        #region methods insert, update, delete

        public long Save()
        {
            if (CoefficientId <= 0)
            {
                CoefficientsDAL objDAL = new CoefficientsDAL();
                return objDAL.Insert(CoefficientTypeId, UserCode, Value, Date, UserId);
            }
            else
            {
                return -1;
            }
        }

        #endregion

        #region public methods Get

        public static List<CoefficientsBLL> GetByUserId_Monthly(int userId, int month, int year)
        {
            CoefficientsDAL objDAL = new CoefficientsDAL();
            return GenerateListCoefficientBLLFromDataTable(objDAL.GetByUserId_Monthly(userId, month, year));
        }

        #endregion


        #region private methods, generate helper methods

        private static List<CoefficientsBLL> GenerateListCoefficientBLLFromDataTable(DataTable dt)
        {
            List<CoefficientsBLL> list = new List<CoefficientsBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateCoefficientBLLFromDataRow(dr));
            }

            return list;
        }

        private static CoefficientsBLL GenerateCoefficientBLLFromDataRow(DataRow dr)
        {
            CoefficientsBLL objCoefficientsBLL = new CoefficientsBLL(
            dr[CoefficientKeys.FIELD_COEFFICIENT_ID] == DBNull.Value ? DefaultValues.CoefficientIdMinValue : Convert.ToInt64(dr[CoefficientKeys.FIELD_COEFFICIENT_ID].ToString()),
            dr[CoefficientKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : Convert.ToDouble(dr[CoefficientKeys.FIELD_COEFFICIENT_VALUE].ToString()),
            dr[CoefficientKeys.FIELD_COEFFICIENT_DATE] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr[CoefficientKeys.FIELD_COEFFICIENT_DATE].ToString())
            );

            objCoefficientsBLL.CoefficientName = dr[CoefficientTypeKeys.FIELD_COEFFICIENT_TYPE_NAME] == DBNull.Value ? string.Empty  : (string)dr[CoefficientTypeKeys.FIELD_COEFFICIENT_TYPE_NAME];
            objCoefficientsBLL.Description = dr[CoefficientTypeKeys.FIELD_COEFFICIENT_TYPE_DESCRIPTION] == DBNull.Value ? string.Empty : (string)dr[CoefficientTypeKeys.FIELD_COEFFICIENT_TYPE_DESCRIPTION];
            return objCoefficientsBLL;
        }

        #endregion
    }
}
