using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H0;
using HRMUtil.KeyNames.H0;
using HRMBLL.H0.Helper;
using HRMUtil;

namespace HRMBLL.H0
{
    public class DepartmentPositionBLL
    {

        #region private fields

        private int _DeptPositionId = 0;
        private int _DepartmentId = 0;
        private int _PositionId = 0;

        private string _PositionName = "";
        private string _DepartmentName = "";
        #endregion

        #region properties


        public int DeptPositionId
        {
            get { return _DeptPositionId; }
            set { _DeptPositionId = value; }
        }
        public int DepartmentId
        {
            get { return _DepartmentId; }
            set { _DepartmentId = value; }
        }
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
        public string DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }
        #endregion

        #region public methods insert, update, delete

        public long Save()
        {
            DepartmentPositionDAL objDAL = new DepartmentPositionDAL();
            if (_DeptPositionId <= 0)
                return objDAL.Insert(_DepartmentId, _PositionId);
            else
                return objDAL.Update(_DepartmentId, _PositionId, _DeptPositionId);
        }


        public static long Update(int departmentId, int positionId, int deptPositionId, string PositionName)
        {
            if (deptPositionId <= 0)
                return new DepartmentPositionDAL().Insert(departmentId, positionId);
            else
                return new DepartmentPositionDAL().Update(departmentId, positionId, deptPositionId);
        }

        public static long Delete(int deptPositionId)
        {
            return new DepartmentPositionDAL().Delete(deptPositionId);
        }

        #endregion

        #region public static Get methods


        public static List<DepartmentPositionBLL> GetByFilter(int departmentId, int positionId)
        {
            return GenerateListDepartmentPositionBLLFromDataTable(new DepartmentPositionDAL().GetByFilter(departmentId, positionId));
        }

        #endregion

        #region private methods

        private static List<DepartmentPositionBLL> GenerateListDepartmentPositionBLLFromDataTable(DataTable dt)
        {
            List<DepartmentPositionBLL> list = new List<DepartmentPositionBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateDepartmentPositionBLLFromDataRow(dr));
            }

            return list;
        }

        private static DepartmentPositionBLL GenerateDepartmentPositionBLLFromDataRow(DataRow dr)
        {
            DepartmentPositionBLL objBLL = new DepartmentPositionBLL();
            objBLL._DeptPositionId = dr[DepartmentPositionKeys.Field_DepartmentPosition_DeptPositionId] == DBNull.Value ? 0 : int.Parse(dr[DepartmentPositionKeys.Field_DepartmentPosition_DeptPositionId].ToString());
            objBLL._DepartmentId = dr[DepartmentPositionKeys.Field_DepartmentPosition_DepartmentId] == DBNull.Value ? 0 : int.Parse(dr[DepartmentPositionKeys.Field_DepartmentPosition_DepartmentId].ToString());
            objBLL._PositionId = dr[DepartmentPositionKeys.Field_DepartmentPosition_PositionId] == DBNull.Value ? 0 : int.Parse(dr[DepartmentPositionKeys.Field_DepartmentPosition_PositionId].ToString());
            try
            {
                objBLL._PositionName = dr[PositionKeys.FIELD_POSITION_NAME] == DBNull.Value ? "" : dr[PositionKeys.FIELD_POSITION_NAME].ToString();
            }
            catch { }
            try
            {
                objBLL._DepartmentName = dr[DepartmentKeys.FIELD_DEPARTMENT_NAME] == DBNull.Value ? "" : dr[DepartmentKeys.FIELD_DEPARTMENT_NAME].ToString();
            }
            catch { }
            return objBLL;
        }

        #endregion


    }
}
