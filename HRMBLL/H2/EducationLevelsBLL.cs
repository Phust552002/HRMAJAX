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
    public class EducationLevelsBLL
    {
        #region private fields

        private int _Id;
        private string _Name;
        private string _Remark;

        #endregion

        #region properties

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        #endregion

        #region public methods

        public long Save()
        {
            EducationLevelsDAL objDAL = new EducationLevelsDAL();
            if (_Id <= 0)
            {
                return objDAL.Insert(_Name, _Remark);
            }
            else
            {
                return objDAL.Update(_Name, _Remark, _Id);
            }
        }

        public static long Update(string name, string remark, int id)
        {
            return new EducationLevelsDAL().Update(name, remark, id);
        }

        public static long Delete(int id)
        {
            return new EducationLevelsDAL().Delete(id);
        }

       

        #endregion

        #region public methods get
        public static DataRow GetById(int id)
        {
            var dt = new EducationLevelsDAL().GetById(id);
            if (dt.Rows.Count > 0)
                return dt.Rows[0];
            return null;
        }

        public static DataTable GetForForeignLanguageComputerDrivingLicense()
        {
            return new EducationLevelsDAL().GetForForeignLanguageComputerDrivingLicense();
        }

        public static List<EducationLevelsBLL> GetAll()
        {
            return GenerateListFromDataTable(new EducationLevelsDAL().GetAll());
        }

        public static DataTable GetDT_All()
        {
            return (new EducationLevelsDAL().GetAll());
        }

        public static List<EducationLevelsBLL> GetByFilter(string name, int orderByType)
        {
            return GenerateListFromDataTable(new EducationLevelsDAL().GetByFilter(name, orderByType));
        }


        #endregion

        #region private methods

        private static List<EducationLevelsBLL> GenerateListFromDataTable(DataTable dt)
        {
            List<EducationLevelsBLL> list = new List<EducationLevelsBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateFromDataTable(dr));
            }

            return list;
        }

        private static EducationLevelsBLL GenerateFromDataTable(DataRow dr)
        {
            EducationLevelsBLL e = new EducationLevelsBLL();
            e._Id = dr[EducationLevelKeys.FIELD_EDUCATION_LEVEL_ID] == DBNull.Value ? 0 : int.Parse(dr[EducationLevelKeys.FIELD_EDUCATION_LEVEL_ID].ToString());
            e._Name = dr[EducationLevelKeys.FIELD_EDUCATION_LEVEL_NAME] == DBNull.Value ? string.Empty : dr[EducationLevelKeys.FIELD_EDUCATION_LEVEL_NAME].ToString();
            e._Remark = dr[EducationLevelKeys.FIELD_EDUCATION_LEVEL_REMARK] == DBNull.Value ? string.Empty : dr[EducationLevelKeys.FIELD_EDUCATION_LEVEL_REMARK].ToString();

            return e;
        }

        #endregion
    }
}
