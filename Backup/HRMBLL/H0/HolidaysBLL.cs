using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H0;
using HRMUtil.KeyNames.H0;
using HRMBLL.H0.Helper;

namespace HRMBLL.H0
{
    public class HolidaysBLL
    {
        
        #region private fields

        private int _HolidayId;
        private string _HolidayName;
        private DateTime _HolidayDate;
        

        #endregion


        #region properties

        public int HolidayId
        {
            get { return _HolidayId; }
            set { _HolidayId = value; }
        }

        public string HolidayName
        {
            get { return _HolidayName; }
            set { _HolidayName = value; }
        }

        public DateTime HolidayDate
        {
            get { return _HolidayDate; }
            set { _HolidayDate = value; }
        }      

        #endregion


        #region constructors

        public HolidaysBLL(int holidayId, string holidayName, DateTime holidayDate)
        {
            _HolidayId = holidayId;
            _HolidayName = holidayName;
            _HolidayDate = holidayDate;
        }

        #endregion


        #region public methods insert, update, delete

        public long Save()
        {
            HolidaysDAL objDAL = new HolidaysDAL();
            if (HolidayId <= 0)
            {
                return objDAL.Insert(HolidayName, HolidayDate);
            }
            else
            {
                return objDAL.Update(HolidayId, HolidayName, HolidayDate);
            }

        }

        public static long Update(int holidayId, string holidayName, DateTime holidayDate)
        {
            HolidaysDAL objDAL = new HolidaysDAL();
            return objDAL.Update(holidayId, holidayName, holidayDate);
        }

        public static long Delete(int holidayId)
        {
            HolidaysDAL objDAL = new HolidaysDAL();
            return objDAL.Delete(holidayId);
        }
        #endregion


        #region public static Get methods

        public static List<HolidaysBLL> GetAll()
        {
            HolidaysDAL objDAL = new HolidaysDAL();
            return GenerateListHolidayFromDataTable(objDAL.GetAll());
        }

        public static List<HolidaysBLL> GetByDate(int month, int year)
        {
            HolidaysDAL objDAL = new HolidaysDAL();
            return GenerateListHolidayFromDataTable(objDAL.GetByDate(month, year));
        }       


        #endregion


        #region private methods       

        private static List<HolidaysBLL> GenerateListHolidayFromDataTable(DataTable dt)
        {
            List<HolidaysBLL> list = new List<HolidaysBLL>();
            
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateHolidayFromDataRow(dr));
            }

            return list;
        }

        private static HolidaysBLL GenerateHolidayFromDataRow(DataRow dr)
        {
            HolidaysBLL objBLL = new HolidaysBLL(
                dr[HolidayKeys.FIELD_HOLIDAY_ID] == DBNull.Value ? 0 : int.Parse(dr[HolidayKeys.FIELD_HOLIDAY_ID].ToString()),
                dr[HolidayKeys.FIELD_HOLIDAY_NAME] == DBNull.Value ? string.Empty : dr[HolidayKeys.FIELD_HOLIDAY_NAME].ToString(),
                dr[HolidayKeys.FIELD_HOLIDAY_NAME] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr[HolidayKeys.FIELD_HOLIDAY_DATE].ToString()));

            return objBLL;
        }

        #endregion
    }
}
