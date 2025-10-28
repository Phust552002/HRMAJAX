using HRMBLL.BLLHelper;
using HRMDAL.H1;
using HRMDAL.Utilities;
using HRMUtil;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace HRMBLL.H1
{
    public class BonusEmployeeConditionBLL
    {

        #region private fields

        //private double _BonusValue;            
        private int _BonusYear;

        private int _BonusTitleId;
        private string _BonusTitle;
        private string _BonusTitleDetail;
        private double _ThucLinh;
        private DateTime _PayDate = FormatDate.GetSQLDateMinValue;
        private int _UserId;

        private string _FullName;
        private string _PositionName;
        private int _DepartmentId;
        private string _DepartmentName;
        private int? _Hide;

        #endregion

        #region properties

        //public double BonusValue
        //{
        //    get { return _BonusValue; }
        //    set { _BonusValue = value; }
        //}

        public double ThucLinh
        {
            get { return _ThucLinh; }
            set { _ThucLinh = value; }
        }
        public DateTime PayDate
        {
            get { return _PayDate; }
            set { _PayDate = value; }
        }
        public int BonusYear
        {
            get { return _BonusYear; }
            set { _BonusYear = value; }
        }

        public int BonusTitleId
        {
            get { return _BonusTitleId; }
            set { _BonusTitleId = value; }
        }

        public string BonusTitle
        {
            get { return _BonusTitle; }
            set { _BonusTitle = value; }
        }

        public string BonusTitleDetail
        {
            get { return _BonusTitleDetail; }
            set { _BonusTitleDetail = value; }
        }

        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
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
        public int? Hide
        {
            get { return _Hide; }
            set { _Hide = value; }
        }
        #endregion
        #region constructors

        public BonusEmployeeConditionBLL(int bonusTitleId, string bonusTitle, string bonusTitleDetail,DateTime payDate, double thucLinh, int bonusYear)
        {
            _BonusTitleId = bonusTitleId;
            _BonusTitle = bonusTitle;
            _BonusTitleDetail = bonusTitleDetail;
            _PayDate = payDate;
            _ThucLinh = thucLinh;
            _BonusYear = bonusYear;
        }
        #endregion

        #region methods Update




        #endregion
        #region methods Get

        //public static List<BonusValuesBLL> GetAll(int userId, int year, int type)
        //{
        //    return GenerateListBonusValuesBLLFromDataTable(new BonusValuesDAL().GetByUserId_Year(userId, year, type));
        //}

        //public static List<BonusValuesBLL> GetByYearBonusNameIdsUserId(int year, string bonusNameIds, int userId)
        //{
        //    return GenerateListBonusValuesBLLFromDataTable(new BonusValuesDAL().GetByYearBonusNameIdsUserId(year, bonusNameIds, userId));
        //}

        public static List<BonusEmployeeConditionBLL> GetByFilter(string fullName, int departmentId, int year, int month, int bonusTitleId)
        {
            return GenerateListBonusEmployeeConditionBLLFromDataTable(new BonusEmployeeConditionDAL().GetByFilter(fullName, departmentId, year, month, bonusTitleId));
        }

        public static DataTable GetStatisticTotalByFilter(int departmentId, int year, int month, int bonusTitleId)
        {
            return new BonusEmployeeConditionDAL().GetStatisticTotalByFilter(departmentId, year, month, bonusTitleId);
        }

        public static DataTable GetBonusTitlesByPayDateYear(int year, int month)
        {
            try
            {
                BonusEmployeeConditionDAL dal = new BonusEmployeeConditionDAL();
                return dal.GetBonusTitlesByPayDateYear(year, month);
            }
            catch (Exception ex)
            {
                throw new HRMException(ex.Message);
            }
        }

        public static long UpdateHide(int bonusTitleId, int year, int month)
        {
            try
            {

                long dal = new BonusEmployeeConditionDAL().UpdateHideSetNullToZero(bonusTitleId, year, month);
                return dal;
            }
            catch (Exception ex)
            {
                throw new HRMException(ex.Message);
            }
        }

        #endregion

        #region private static methods

        private static List<BonusEmployeeConditionBLL> GenerateListBonusEmployeeConditionBLLFromDataTable(DataTable dt)
        {
            List<BonusEmployeeConditionBLL> list = new List<BonusEmployeeConditionBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateBonusValuesBLLFromDataRow(dr));
            }

            return list;
        }

        private static BonusEmployeeConditionBLL GenerateBonusValuesBLLFromDataRow(DataRow dr)
        {
            BonusEmployeeConditionBLL objBLL = new BonusEmployeeConditionBLL(

                    //dr["BonusValue"] == DBNull.Value ? 0 : Convert.ToDouble(dr["BonusValue"].ToString()),
                    dr["BonusTitleId"] == DBNull.Value ? 0 : int.Parse(dr["BonusTitleId"].ToString()),
                    dr["BonusTitle"] == DBNull.Value ? string.Empty : dr["BonusTitle"].ToString(),
                    dr["BonusTitleDetail"] == DBNull.Value ? string.Empty : dr["BonusTitleDetail"].ToString(),
                    dr["PayDate"] == DBNull.Value ? FormatDate.GetSQLDateMinValue : (DateTime)dr["PayDate"],
                    dr["ThucLinh"] == DBNull.Value ? 0 : Convert.ToDouble(dr["ThucLinh"].ToString()),
                    dr["BonusYear"] == DBNull.Value ? 0 : int.Parse(dr["BonusYear"].ToString())
                );

            //objBLL._BonusTitleId = dr["BonusTitleId"] == DBNull.Value ? 0 : int.Parse(dr["BonusTitleId"].ToString());
            //objBLL._BonusTitle = dr["BonusTitle"] == DBNull.Value ? string.Empty : dr["BonusTitle"].ToString();

            objBLL._UserId = dr["UserId"] == DBNull.Value ? 0 : int.Parse(dr["UserId"].ToString());
            objBLL._FullName = dr["FullName"] == DBNull.Value ? string.Empty : dr["FullName"].ToString();
            //objBLL._PayDate = dr["PayDate"] == DBNull.Value ? FormatDate.GetSQLDateMinValue : (DateTime)dr["PayDate"];
            try
            {
                objBLL._PositionName = dr["PositionName"] == DBNull.Value ? string.Empty : dr["PositionName"].ToString();
            }
            catch { }
            objBLL._DepartmentId = dr["DepartmentId"] == DBNull.Value ? 0 : int.Parse(dr["DepartmentId"].ToString());
            objBLL._DepartmentName = dr["DepartmentName"] == DBNull.Value ? string.Empty : dr["DepartmentName"].ToString();
            objBLL._Hide = dr.Table.Columns.Contains("Hide") && dr["Hide"] != DBNull.Value
                ? Convert.ToInt32(dr["Hide"])
                : (int?)null;
            //objBLL._ATMNo = dr["ATMNo"] == DBNull.Value ? string.Empty : dr["ATMNo"].ToString();

            return objBLL;
        }


        #endregion

    }
}
