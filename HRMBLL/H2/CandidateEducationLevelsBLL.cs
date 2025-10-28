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
    public class CandidateEducationLevelsBLL
    {
        #region private fields

        private int _Id;
        private int _CandidateId;
        private int _EducationLevelId;
        private string _EducationLevelName;
        private string _EducationLevelValue;
        private string _Remark;

        private int _LastItem;

        #endregion

        #region properties

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public int CandidateId
        {
            get { return _CandidateId; }
            set { _CandidateId = value; }
        }
        public int EducationLevelId
        {
            get { return _EducationLevelId; }
            set { _EducationLevelId = value; }
        }
        public string EducationLevelValue
        {
            get { return _EducationLevelValue; }
            set { _EducationLevelValue = value; }
        }
        public string EducationLevelName
        {
            get { return _EducationLevelName; }
            set { _EducationLevelName = value; }
        }
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }
        public int LastItem
        {
            get { return _LastItem; }
            set { _LastItem = value; }
        }

        #endregion

        #region public methods

        public long Save()
        {
            CandidateEducationLevelsDAL objDAL = new CandidateEducationLevelsDAL();
            if (_Id <= 0)
            {
                return objDAL.Insert(_CandidateId, _EducationLevelId, _EducationLevelValue, _Remark);
            }
            else
            {
                return objDAL.Update(_CandidateId, _EducationLevelId, _EducationLevelValue, _Remark, _Id);
            }
        }


        public static long Update(int candidateId, int educationLevelId, string educationLevelValue, string remark, int id)
        {
            return new CandidateEducationLevelsDAL().Update(candidateId, educationLevelId, educationLevelValue, remark, id);
        }

        public static long Delete(int id)
        {
            return new CandidateEducationLevelsDAL().Delete(id);
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
       
        #endregion

        #region public methods get


        public static List<CandidateEducationLevelsBLL> GetById(int candidateId)
        {
            return GenerateListFromDataTable(new CandidateEducationLevelsDAL().GetById(candidateId));
        }


        #endregion

        #region private methods

        private static List<CandidateEducationLevelsBLL> GenerateListFromDataTable(DataTable dt)
        {
            List<CandidateEducationLevelsBLL> list = new List<CandidateEducationLevelsBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateFromDataTable(dr,dt.Rows.Count));
            }

            return list;
        }

        private static CandidateEducationLevelsBLL GenerateFromDataTable(DataRow dr, int itemLastIndex)
        {
            CandidateEducationLevelsBLL c = new CandidateEducationLevelsBLL();

            c._Id = dr[CandidateEducationLevelKeys.FIELD_CANDIDATE_EDUCATION_LEVEL_ID] == DBNull.Value ? 0 : int.Parse(dr[CandidateEducationLevelKeys.FIELD_CANDIDATE_EDUCATION_LEVEL_ID].ToString());
            c._CandidateId = dr[CandidateEducationLevelKeys.FIELD_CANDIDATE_EDUCATION_LEVEL_CANDIDATE_ID] == DBNull.Value ? 0 : int.Parse(dr[CandidateEducationLevelKeys.FIELD_CANDIDATE_EDUCATION_LEVEL_CANDIDATE_ID].ToString());
            c._EducationLevelId = dr[CandidateEducationLevelKeys.FIELD_CANDIDATE_EDUCATION_LEVEL_EDUCATION_LEVEL_ID] == DBNull.Value ? 0 : int.Parse(dr[CandidateEducationLevelKeys.FIELD_CANDIDATE_EDUCATION_LEVEL_EDUCATION_LEVEL_ID].ToString());
            c._EducationLevelValue = dr[CandidateEducationLevelKeys.FIELD_CANDIDATE_EDUCATION_LEVEL_VALUE] == DBNull.Value ? string.Empty : dr[CandidateEducationLevelKeys.FIELD_CANDIDATE_EDUCATION_LEVEL_VALUE].ToString();
            c._Remark = dr[CandidateEducationLevelKeys.FIELD_CANDIDATE_EDUCATION_LEVEL_REMARK] == DBNull.Value ? string.Empty : dr[CandidateEducationLevelKeys.FIELD_CANDIDATE_EDUCATION_LEVEL_REMARK].ToString();

            c._EducationLevelName = dr[EducationLevelKeys.FIELD_EDUCATION_LEVEL_NAME] == DBNull.Value ? string.Empty : dr[EducationLevelKeys.FIELD_EDUCATION_LEVEL_NAME].ToString();

            c._LastItem = itemLastIndex;

            return c;
        }

        #endregion
    }
}
