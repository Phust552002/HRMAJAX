using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


using HRMDAL.Utilities;
using HRMDAL.H2;
using HRMUtil.KeyNames.H2;

using HRMUtil;

namespace HRMBLL.H2
{
    public class CandidateTrainingJobHistoryBLL
    {

        private int _CandidateId = 0;
        private string _Training_Job = "";
        private string _Training_Job1 = "";
        private string _Year = "";
        private string _School_Position = "";
        private string _Major_Salary = "";
        private string _GraduateYear_LeaveReason = "";
        private string _Experience = "";
        private string _Type = "";
        private int _CandidateTrainingJobHistoryId = 0;

        private int _LastItem;

        public int CandidateId
        {
            get { return _CandidateId; }
            set { _CandidateId = value; }
        }
        public string Training_Job
        {
            get { return _Training_Job; }
            set { _Training_Job = value; }
        }
        public string Training_Job1
        {
            get { return _Training_Job1; }
            set { _Training_Job1 = value; }
        }
        public string Year
        {
            get { return _Year; }
            set { _Year = value; }
        }
        public string School_Position
        {
            get { return _School_Position; }
            set { _School_Position = value; }
        }
        public string Major_Salary
        {
            get { return _Major_Salary; }
            set { _Major_Salary = value; }
        }
        public string GraduateYear_LeaveReason
        {
            get { return _GraduateYear_LeaveReason; }
            set { _GraduateYear_LeaveReason = value; }
        }
        public string Experience
        {
            get { return _Experience; }
            set { _Experience = value; }
        }
        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        public int CandidateTrainingJobHistoryId
        {
            get { return _CandidateTrainingJobHistoryId; }
            set { _CandidateTrainingJobHistoryId = value; }
        }
        public int LastItem
        {
            get { return _LastItem; }
            set { _LastItem = value; }
        }
        public static List<CandidateTrainingJobHistoryBLL> GetById(int id)
        {
            return GenerateListFromDataTable(new CandidateTrainingJobHistoryDAL().GetById(id));
        }
        public static List<CandidateTrainingJobHistoryBLL> GetByCandidateId_Type(int CandidateId, string Type)
        {
            return GenerateListFromDataTable(new CandidateTrainingJobHistoryDAL().GetByCandidateId_Type(CandidateId, Type));
        }

        public static long Insert(int CandidateId, string Training_Job, string Year, string School_Position, string Major_Salary, string GraduateYear_LeaveReason, string Experience, string Type)
        {
            return new CandidateTrainingJobHistoryDAL().Insert(CandidateId, Training_Job, Year, School_Position, Major_Salary, GraduateYear_LeaveReason, Experience, Type);
        }

        public static long Update(int CandidateId, string Training_Job, string Year, string School_Position, string Major_Salary, string GraduateYear_LeaveReason, string Experience, string Type, int CandidateTrainingJobHistoryId)
        {
            return new CandidateTrainingJobHistoryDAL().Update(CandidateId, Training_Job, Year, School_Position, Major_Salary, GraduateYear_LeaveReason, Experience, Type, CandidateTrainingJobHistoryId);
        }

        public static string Delete(string ids)
        {
            string[] arr = ids.Split(',');
            foreach (string arrItem in arr)
            {
                if (arrItem.Length > 0)
                {
                    Delete(int.Parse(arrItem));
                }
            }
            return ids;
        }

        public static long Delete(int CandidateTrainingJobHistoryId)
        {
            return new CandidateTrainingJobHistoryDAL().Delete(CandidateTrainingJobHistoryId);
        }

        #region private methods

        private static List<CandidateTrainingJobHistoryBLL> GenerateListFromDataTable(DataTable dt)
        {
            List<CandidateTrainingJobHistoryBLL> list = new List<CandidateTrainingJobHistoryBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateFromDataTable(dr, dt.Rows.Count));
            }

            return list;
        }

        private static CandidateTrainingJobHistoryBLL GenerateFromDataTable(DataRow dr, int itemLastIndex)
        {
            CandidateTrainingJobHistoryBLL c = new CandidateTrainingJobHistoryBLL();

            c._CandidateId = dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_CandidateId] == DBNull.Value ? 0 : int.Parse(dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_CandidateId].ToString());
            c._Training_Job = dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_Training_Job] == DBNull.Value ? "" : dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_Training_Job].ToString();
            c._Training_Job1 = dr["Training_Job1"] == DBNull.Value ? "" : dr["Training_Job1"].ToString();
            c._Year = dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_Year] == DBNull.Value ? "" : dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_Year].ToString();
            c._School_Position = dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_School_Position] == DBNull.Value ? "" : dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_School_Position].ToString();
            c._Major_Salary = dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_Major_Salary] == DBNull.Value ? "" : dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_Major_Salary].ToString();
            c._GraduateYear_LeaveReason = dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_GraduateYear_LeaveReason] == DBNull.Value ? "" : dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_GraduateYear_LeaveReason].ToString();
            c._Experience = dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_Experience] == DBNull.Value ? "" : dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_Experience].ToString();
            c._Type = dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_Type] == DBNull.Value ? "" : dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_Type].ToString();
            c._CandidateTrainingJobHistoryId = dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_CandidateTrainingJobHistoryId] == DBNull.Value ? 0 : int.Parse(dr[CandidateTrainingJobHistoryKeys.Filed_CandidateTrainingJobHistory_CandidateTrainingJobHistoryId].ToString());


            c._LastItem = itemLastIndex;

            return c;
        }

        #endregion

    }
}
