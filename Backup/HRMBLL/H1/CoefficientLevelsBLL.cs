using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H1;
using HRMUtil.KeyNames.H1;
using HRMBLL.H1.Helper; 

namespace HRMBLL.H1
{
    public class CoefficientLevelsBLL
    {

        #region private fields

        private int _CoefficientLevelId;
        private string _CoefficientLevelName;        

        #endregion

        #region properties

        public int CoefficientLevelId
        {
            get { return _CoefficientLevelId; }
            set { _CoefficientLevelId = value; }
        }
        public string CoefficientLevelName
        {
            get { return _CoefficientLevelName; }
            set { _CoefficientLevelName = value; }
        }

        #endregion

        #region Constructor

        public CoefficientLevelsBLL(int coefficientLevelId, string coefficientLevelName)
        {
            _CoefficientLevelId = coefficientLevelId;
            _CoefficientLevelName = coefficientLevelName;
            
        }

        #endregion

        #region public methods GET

        public static List<CoefficientLevelsBLL> GetAll(int type)
        {
            CoefficientLevelsDAL objDAL = new CoefficientLevelsDAL();

            return GenerateListCoefficientLevelsBLLFromDataTable(objDAL.GetAll(type));
        }

        #endregion

        #region private methods

        private static List<CoefficientLevelsBLL> GenerateListCoefficientLevelsBLLFromDataTable(DataTable dt)
        {
            List<CoefficientLevelsBLL> list = new List<CoefficientLevelsBLL>();

            CoefficientLevelsBLL objNone = new CoefficientLevelsBLL(0, "");

            list.Add(objNone);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateCoefficientLevelsBLLFromDataRow(dr));            
            }

            return list;
        }

        private static CoefficientLevelsBLL GenerateCoefficientLevelsBLLFromDataRow(DataRow dr)
        {
            CoefficientLevelsBLL obj = new CoefficientLevelsBLL(
                dr[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_ID] == DBNull.Value ? DefaultValues.CoefficientLevelIdMinValue : int.Parse(dr[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_ID].ToString()),
                dr[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_NAME] == DBNull.Value ? string.Empty : (string)dr[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_NAME]);

            return obj;
        }

        #endregion

    }
}
