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
    public class EmployeeJobHistoryBLL
    {
        #region private fields

        private long _JobHistoryId = 0;
        private int _UserId = 0;
        private int _FromYear = 0;
        private int _ToYear = 0;
        private string _Infor = string.Empty;
        private int _Type = 0;

        private int _LastItem;

        #endregion

        #region properties

        public long JobHistoryId
        {
            get{return _JobHistoryId;}
            set{_JobHistoryId = value;}
        }
        
        public int UserId
        {
            get{return _UserId;}
            set{_UserId = value;}
        }
        
        public int FromYear
        {
            get{return _FromYear;}
            set{_FromYear = value;}
        }
        
        public int ToYear
        {
            get{return _ToYear;}
            set{_ToYear = value;}
        }

        public string Infor
        {
            get{return _Infor;}
            set{_Infor = value;}
        }

        public int Type
        {
            get{return _Type;}
            set{_Type = value;}
        }

        public int LastItem
        {
            get { return _LastItem; }
            set { _LastItem = value; }
        }
        #endregion

        #region public methods Get

        public static List<EmployeeJobHistoryBLL> GetByFilter(System.Nullable<int> type, System.Nullable<int> userId)
        {
            return GenerateListEmployeeJobHistoryBLLFromDataTable(new EmployeeJobHistoryDAL().GetByFilter(type, userId));
        }

        #endregion

        #region public methods Insert, Update, Delete

        public long Save()
        {
            EmployeeJobHistoryDAL objDAL = new EmployeeJobHistoryDAL();
            if (JobHistoryId <= 0)
            {
                return objDAL.Insert(UserId, FromYear, ToYear, Infor, Type);
            }
            else
            {
                return objDAL.Update(UserId, FromYear, ToYear, Infor, Type, JobHistoryId);
            }

        }

        public static void Update(
                            System.Nullable<int> userId,
                            System.Nullable<int> fromYear,
                            System.Nullable<int> toYear,
                            string infor,
                            System.Nullable<int> type,
                            System.Nullable<long> jobHistoryId)
        {
            new EmployeeJobHistoryDAL().Update(userId, fromYear, toYear, infor, type, jobHistoryId);
        }

        public static void Delete(System.Nullable<long> jobHistoryId)
        {
            new EmployeeJobHistoryDAL().Delete(jobHistoryId);
        }

        public static string Delete(string jobHistoryIds)
        {
            string[] arr = jobHistoryIds.Split(',');
            foreach (string arrItem in arr)
            {
                if (arrItem.Length > 0)
                {
                    Delete(int.Parse(arrItem));
                }
            }
            return jobHistoryIds;
            
        }


        #endregion

        #region private methods, generate helper methods

        private static List<EmployeeJobHistoryBLL> GenerateListEmployeeJobHistoryBLLFromDataTable(DataTable dt)
        {
            List<EmployeeJobHistoryBLL> list = new List<EmployeeJobHistoryBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateEmployeeJobHistoryBLLFromDataRow(dr, dt.Rows.Count));
            }

            return list;
        }

        private static EmployeeJobHistoryBLL GenerateEmployeeJobHistoryBLLFromDataRow(DataRow dr)
        {
            EmployeeJobHistoryBLL objBLL = new EmployeeJobHistoryBLL();

            objBLL._JobHistoryId = dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_Id] == DBNull.Value ? 0 : (long)dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_Id];
            objBLL._UserId = dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_UserId] == DBNull.Value ? 0 : (int)dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_UserId];
            objBLL._FromYear = dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_FromYear] == DBNull.Value ? 0 : (int)dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_FromYear];
            objBLL._ToYear = dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_ToYear] == DBNull.Value ? 0 : (int)dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_ToYear];
            objBLL._Infor = dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_Infor] == DBNull.Value ? string.Empty : dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_Infor].ToString();            
            try
            {
                objBLL._Type = dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_Type] == DBNull.Value ? 0 : (int)dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_Type];
            }
            catch { }

            return objBLL;
        }

        private static EmployeeJobHistoryBLL GenerateEmployeeJobHistoryBLLFromDataRow(DataRow dr, int itemLastIndex)
        {
            EmployeeJobHistoryBLL objBLL = new EmployeeJobHistoryBLL();

            objBLL._JobHistoryId = dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_Id] == DBNull.Value ? 0 : (long)dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_Id];
            objBLL._UserId = dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_UserId] == DBNull.Value ? 0 : (int)dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_UserId];
            objBLL._FromYear = dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_FromYear] == DBNull.Value ? 0 : (int)dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_FromYear];
            objBLL._ToYear = dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_ToYear] == DBNull.Value ? 0 : (int)dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_ToYear];
            objBLL._Infor = dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_Infor] == DBNull.Value ? string.Empty : dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_Infor].ToString();
            try
            {
                objBLL._Type = dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_Type] == DBNull.Value ? 0 : (int)dr[EmployeeJobHistoryKeys.Field_EmployeeJobHistory_Type];
            }
            catch { }

            objBLL._LastItem = itemLastIndex;

            return objBLL;
        }


        #endregion
    }
}
