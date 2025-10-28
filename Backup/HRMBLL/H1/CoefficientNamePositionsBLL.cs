using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H1;
using HRMUtil.KeyNames.H1;
using HRMUtil.KeyNames.H0;
using HRMBLL.H1.Helper;


namespace HRMBLL.H1
{
    public class CoefficientNamePositionsBLL
    {

        #region private fields

        private int _CoefficientNamePositionId;
        private int _CoefficientNameId;
        private int _PositionId;
        private string _PositionName;

        #endregion

        #region properties

        public int CoefficientNamePositionId
        {
            get { return _CoefficientNamePositionId; }
            set { _CoefficientNamePositionId = value; }
        }

        public int CoefficientNameId
        {
            get { return _CoefficientNameId; }
            set { _CoefficientNameId = value; }
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

        #endregion

        #region Constructor

        public CoefficientNamePositionsBLL(int coefficientNamePositionId, int coefficientNameId, int positionId)
        {
            _CoefficientNamePositionId = coefficientNamePositionId;
            _CoefficientNameId = coefficientNameId;
            _PositionId = positionId;
        }
        

        #endregion      

        #region public method Get

        public static List<CoefficientNamePositionsBLL> GetByNameId(int coefficientNameId)
        {
            CoefficientNamePositionsDAL objDAL = new CoefficientNamePositionsDAL();
            return GenerateListCoefficientNamePositionsBLLFromDataTable(objDAL.GetByNameId(coefficientNameId));
        }

        public static CoefficientNamePositionsBLL GetByPositionId(int positionId, int type)
        {
            CoefficientNamePositionsDAL objDAL = new CoefficientNamePositionsDAL();
            DataTable dt = objDAL.GetByPositionId(positionId, type);
            if (dt.Rows.Count == 1)
            {
                return GenerateCoefficientNamePositionsBLLFromDataRow(dt.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        #endregion      

        #region private methods

        private static List<CoefficientNamePositionsBLL> GenerateListCoefficientNamePositionsBLLFromDataTable(DataTable dt)
        {
            List<CoefficientNamePositionsBLL> list = new List<CoefficientNamePositionsBLL>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateCoefficientNamePositionsBLLFromDataRow(dr));
            }

            return list;
        }

        private static CoefficientNamePositionsBLL GenerateCoefficientNamePositionsBLLFromDataRow(DataRow dr)
        {
            CoefficientNamePositionsBLL objBLL = new CoefficientNamePositionsBLL(
                dr[CoefficientNamePositionKeys.FIELD_COEFFICIENT_NAME_POSITION_ID] == DBNull.Value ? 0 : int.Parse(dr[CoefficientNamePositionKeys.FIELD_COEFFICIENT_NAME_POSITION_ID].ToString()),
                dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId] == DBNull.Value ? 0 : int.Parse(dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId].ToString()),
                dr[PositionKeys.FIELD_POSITION_ID] == DBNull.Value ? 0 : int.Parse(dr[PositionKeys.FIELD_POSITION_ID].ToString())
                );

            objBLL.PositionName = dr[PositionKeys.FIELD_POSITION_NAME] == DBNull.Value ? string.Empty : dr[PositionKeys.FIELD_POSITION_NAME].ToString();

            return objBLL;
        }

        #endregion

    }
}
