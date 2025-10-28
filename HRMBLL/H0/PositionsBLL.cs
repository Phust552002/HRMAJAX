using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H0;
using HRMUtil;
using HRMUtil.KeyNames.H0;
using HRMBLL.H0.Helper;

namespace HRMBLL.H0
{
    public class PositionsBLL
    {

        #region private fields

        private int _PositionId;
        private string _PositionName;
        private int _QualificationId;
        private string _QualificationName;
        private string _Description;
        private int _LevelPosition;
        private string _LevelPositionName = "";
        private int _DepartmentId;
        private string _DepartmentName = "";
        #endregion


        #region properties

        public int PositionId
        {
            get { return _PositionId; }
            set { _PositionId = value; }
        }

        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }

        public int QualificationId
        {
            get { return _QualificationId; }
            set { _QualificationId = value; }
        }

        public string QualificationName
        {
            get { return _QualificationName; }
            set { _QualificationName = value; }
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public int LevelPosition
        {
            get { return _LevelPosition; }
            set { _LevelPosition = value; }
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
        public string LevelPositionName
        {
            get { return _LevelPositionName; }
            set { _LevelPositionName = value; }
        }
        
        #endregion


        #region constructors

        public PositionsBLL(int positionId, string positionName, string description)
        {
            _PositionId = positionId;
            _PositionName = positionName;
            _Description = description;
        }

        #endregion


        #region public methods insert, update, delete

        public long Save()
        {
            PositionsDAL objPositionsDAL = new PositionsDAL();
            if (PositionId <= 0)
            {
                return objPositionsDAL.Insert(PositionName, Description, LevelPosition, DepartmentId);
            }
            else
            {
                return objPositionsDAL.Update(PositionId, PositionName, Description, LevelPosition, DepartmentId);
            }

        }

        public static long Update(int positionId, string positionName, string description, int levelPosition, int departmentId)
        {
            PositionsDAL objPositionsDAL = new PositionsDAL();
            if(description == null)
            {
                description = string.Empty;
            }
            return objPositionsDAL.Update(positionId, positionName, description, levelPosition, departmentId);
        }

        public static long Delete(int positionId)
        {
            PositionsDAL objPositionsDAL = new PositionsDAL();
            return objPositionsDAL.Delete(positionId);
        }
        #endregion


        #region public static Get methods

        public static List<PositionsBLL>GetAll()
        {
            PositionsDAL objPositionsDAL = new PositionsDAL();
            return GenerateListPositionFromDataTable(objPositionsDAL.GetAll());
        }
        public static List<PositionsBLL> GetByFilter(string positionName, int levelPosition, int departmentId)
        {            
            return GenerateListPositionFromDataTable(new PositionsDAL().GetByFilter(positionName, levelPosition, departmentId));
        }

        public static DataRow GetAllToDataRow()
        {
            var one = new PositionsDAL().GetAll();
            if (one.Rows.Count > 0)
            {
                return one.Rows[0];
            }
            return null;
        }

        public static DataRow GetAllToDataRowById(int Id)
        {
            var dt = new PositionsDAL().GetPositionId(Id);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0];
            }
            return null;
        }

        public static List<PositionsBLL> GetAll_N()
        {
            PositionsDAL objPositionsDAL = new PositionsDAL();
            return GenerateListPositionFromDataTable_N(objPositionsDAL.GetAll());
        }
        //public static List<PositionsBLL> GetAllByIds(string positionIds)
        //{
        //    PositionsDAL objPositionsDAL = new PositionsDAL();
        //    return GenerateListPositionFromDataTable(objPositionsDAL.GetByIds(positionIds));
        //}

        //public static List<PositionsBLL> GetIsRecruitment()
        //{
        //    return GenerateListPositionFromDataTable(new PositionsDAL().GetIsRecruitment());
        //}

        #endregion


        #region private methods

        private static List<PositionsBLL> GenerateListPositionFromDataTable_N(DataTable dt)
        {
            List<PositionsBLL> lstPositions = new List<PositionsBLL>();

            lstPositions.Add(new PositionsBLL(0, "", string.Empty));

            foreach (DataRow dr in dt.Rows)
            {
                lstPositions.Add(GeneratePositionFromDataRow(dr));
            }

            return lstPositions;
        }

        private static List<PositionsBLL> GenerateListPositionFromDataTable(DataTable dt)
        {
            List<PositionsBLL> lstPositions = new List<PositionsBLL>();
            
            foreach (DataRow dr in dt.Rows)
            {
                lstPositions.Add(GeneratePositionFromDataRow(dr));
            }

            return lstPositions;
        }

        private static PositionsBLL GeneratePositionFromDataRow(DataRow dr)
        {
            PositionsBLL objBLL = new PositionsBLL(
                dr[PositionKeys.FIELD_POSITION_ID] == DBNull.Value ? DefaultValues.PositionIdMinValue : int.Parse(dr[PositionKeys.FIELD_POSITION_ID].ToString()),
                dr[PositionKeys.FIELD_POSITION_NAME] == DBNull.Value ? string.Empty : dr[PositionKeys.FIELD_POSITION_NAME].ToString(),
                dr[PositionKeys.FIELD_POSITION_DESCRIPTION] == DBNull.Value ? string.Empty : dr[PositionKeys.FIELD_POSITION_DESCRIPTION].ToString());

            objBLL.LevelPosition = dr[PositionKeys.Field_Position_LevelPosition] == DBNull.Value ? 0 : int.Parse(dr[PositionKeys.Field_Position_LevelPosition].ToString());
            objBLL.DepartmentId = dr[PositionKeys.Field_Position_DepartmentId] == DBNull.Value ? 0: int.Parse(dr[PositionKeys.Field_Position_DepartmentId].ToString());
            try
            {
                objBLL.DepartmentName = dr[DepartmentKeys.FIELD_DEPARTMENT_NAME] == DBNull.Value ? "" : dr[DepartmentKeys.FIELD_DEPARTMENT_NAME].ToString();
            }
            catch { }
            objBLL.LevelPositionName = Constants.GetLevelPositionNameById(objBLL.LevelPosition);
            return objBLL;
        }

        #endregion

    }
}
