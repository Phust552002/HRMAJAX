using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H3;
using HRMUtil.KeyNames.H3;
using HRMUtil.KeyNames.H0;
using HRMUtil;

namespace HRMBLL.H3
{
    public class DecisionsBLL
    {
        
        #region private filed

        private int _DecisionId;
        private int _DecisionTypeId;
        private string _DecisionTypeName;
        private string _DecisionNo;
        private System.DateTime _DecisionDate;
        private string _DecisionName;
        private string _BringOutDept;
        private string _SignUser;
        private string _Remark;

        #endregion

        #region properties

        public int DecisionId
        {
            get
            {
                return _DecisionId;
            }
            set
            {
                _DecisionId = value;
            }
        }        

        public int DecisionTypeId
        {
            get
            {
                return _DecisionTypeId;
            }
            set
            {
                _DecisionTypeId = value;
            }
        }
        public string DecisionTypeName
        {
            get
            {
                return _DecisionTypeName;
            }
            set
            {
                _DecisionTypeName = value;
            }
        }
        
        public string DecisionNo
        {
            get
            {
                return _DecisionNo;
            }
            set
            {
                _DecisionNo = value;
            }
        }

        
        public System.DateTime DecisionDate
        {
            get
            {
                return _DecisionDate;
            }
            set
            {
                _DecisionDate = value;
            }
        }

        
        public string DecisionName
        {
            get
            {
                return _DecisionName;
            }
            set
            {
                _DecisionName = value;
            }
        }

        
        public string BringOutDept
        {
            get
            {
                return _BringOutDept;
            }
            set
            {
                _BringOutDept = value;
            }
        }

        
        public string SignUser
        {
            get
            {
                return _SignUser;
            }
            set
            {
                _SignUser = value;
            }
        }

        
        public string Remark
        {
            get
            {
                return _Remark;
            }
            set
            {
                _Remark = value;
            }
        }

        #endregion

        #region public method Get

        public static List<DecisionsBLL> GetByFilter(int decisionTypeId, string decisionNo, string decisionName, DateTime decisionDate)
        {
            return GenerateListDecisionsBLLFromDataTable(new DecisionsDAL().GetByFilter(decisionTypeId, decisionNo, decisionName, decisionDate));
        }

        public static DecisionsBLL GetById(int decisionId)
        {
            List<DecisionsBLL> list = GenerateListDecisionsBLLFromDataTable(new DecisionsDAL().GetById(decisionId));
            if (list.Count == 1)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region methods Insert, update, delete

        public int Save()
        {
            DecisionsDAL objDAL = new DecisionsDAL();

            if (_DecisionId <= 0)
            {
                return objDAL.Insert(DecisionTypeId, DecisionNo, DecisionDate, DecisionName, BringOutDept, SignUser, Remark);
            }
            else
            {
                return objDAL.Update(DecisionTypeId, DecisionNo, DecisionDate, DecisionName, BringOutDept, SignUser, Remark, DecisionId);
            }

        }

        public static void Update(int decisionTypeId, string decisionNo, DateTime decisionDate, string decisionName, string bringOutDept, string signUser, string remark, int decisionId)
        {
            new DecisionsDAL().Update(decisionTypeId, decisionNo, decisionDate, decisionName, bringOutDept, signUser, remark, decisionId);
        }

        public static void Delete(int decisionId)
        {
            new DecisionsDAL().Delete(decisionId);
        }

        #endregion

        #region private methods

        private static List<DecisionsBLL> GenerateListDecisionsBLLFromDataTable(DataTable dt)
        {
            List<DecisionsBLL> list = new List<DecisionsBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateDecisionsBLLFromDataRow(dr));
            }

            return list;
        }

        private static DecisionsBLL GenerateDecisionsBLLFromDataRow(DataRow dr)
        {

            DecisionsBLL objBLL = new DecisionsBLL();

            objBLL._DecisionId = dr[DecisionsKeys.Field_Decisions_DecisionId] == DBNull.Value ? 0 : int.Parse(dr[DecisionsKeys.Field_Decisions_DecisionId].ToString());
            objBLL._DecisionTypeId = dr[DecisionsKeys.Field_Decisions_DecisionTypeId] == DBNull.Value ? 0 : int.Parse(dr[DecisionsKeys.Field_Decisions_DecisionTypeId].ToString());
            objBLL._DecisionNo = dr[DecisionsKeys.Field_Decisions_DecisionNo] == DBNull.Value ? string.Empty : dr[DecisionsKeys.Field_Decisions_DecisionNo].ToString();
            objBLL._DecisionDate = dr[DecisionsKeys.Field_Decisions_DecisionDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[DecisionsKeys.Field_Decisions_DecisionDate].ToString());
            objBLL._DecisionName = dr[DecisionsKeys.Field_Decisions_DecisionName] == DBNull.Value ? string.Empty : dr[DecisionsKeys.Field_Decisions_DecisionName].ToString();
            objBLL._BringOutDept = dr[DecisionsKeys.Field_Decisions_BringOutDept] == DBNull.Value ? string.Empty : dr[DecisionsKeys.Field_Decisions_BringOutDept].ToString();
            objBLL._SignUser = dr[DecisionsKeys.Field_Decisions_SignUser] == DBNull.Value ? string.Empty : dr[DecisionsKeys.Field_Decisions_SignUser].ToString();
            objBLL._Remark = dr[DecisionsKeys.Field_Decisions_Remark] == DBNull.Value ? string.Empty : dr[DecisionsKeys.Field_Decisions_Remark].ToString();
            try
            {
                objBLL._DecisionTypeName = dr[ContractTypeKeys.Field_ContractTypes_ContractTypeName] == DBNull.Value ? string.Empty : dr[ContractTypeKeys.Field_ContractTypes_ContractTypeName].ToString();
            }
            catch { }
            return objBLL;

        }

        #endregion
    }
}
