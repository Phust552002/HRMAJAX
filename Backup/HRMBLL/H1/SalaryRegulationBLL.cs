using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H1;
using HRMUtil.KeyNames.H1;
using HRMUtil.KeyNames.H0;
using HRMBLL.H1.Helper;
using HRMUtil;

namespace HRMBLL.H1
{
    public class SalaryRegulationBLL
    {

        #region private fields

        private int _SalaryRegulationId;
        private string _SalaryRegulationName;        
        private System.DateTime _BeginingDate;
        private string _Description;
        private bool _InUse;
        private int _TypeId;
        private string _TypeName;
        #endregion

        #region properties
        
        public int SalaryRegulationId
        {
            get { return _SalaryRegulationId; }
            set { _SalaryRegulationId = value; }
        }
        public string SalaryRegulationName
        {
            get { return _SalaryRegulationName; }
            set { _SalaryRegulationName = value; }
        }       
        public System.DateTime BeginingDate
        {
            get { return _BeginingDate; }
            set { _BeginingDate = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public bool InUse
        {
            get { return _InUse; }
            set { _InUse = value; }
        }
        public int TypeId
        {
            get { return _TypeId; }
            set { _TypeId = value; }
        }
        public string TypeName
        {
            get { return _TypeName; }
            set { _TypeName = value; }
        }

        #endregion

        #region public methods insert, update, delete

        public int Save()
        {
            SalaryRegulationDAL objDAL = new SalaryRegulationDAL();

            if (_SalaryRegulationId <= 0)
            {
                return objDAL.Insert(_SalaryRegulationName, _BeginingDate, _Description, _InUse, _TypeId);
            }
            else
            {
                return objDAL.Update(_SalaryRegulationName, _BeginingDate, _Description, _InUse, _TypeId, _SalaryRegulationId);
            }
        }

        public static void Update(string salaryRegulationName, System.DateTime beginingDate, string description, bool inUse, int typeId, int salaryRegulationId)
        {
            new SalaryRegulationDAL().Update(salaryRegulationName, beginingDate, description, inUse, typeId, salaryRegulationId);
        }

        public static void Delete(int salaryRegulationId)
        {
            new SalaryRegulationDAL().Delete(salaryRegulationId);
        }

        #endregion

        #region public methods GET

        public static List<SalaryRegulationBLL> GetByInUse(bool inUse)
        {
            return GenerateListSalaryRegulationBLLFromDataTable(new SalaryRegulationDAL().GetByInUse(inUse));
        }
        public static List<SalaryRegulationBLL> GetByFilter(int typeId)
        {
            return GenerateListSalaryRegulationBLLFromDataTable(new SalaryRegulationDAL().GetByFilter(typeId));
        }

        #endregion

        #region private methods

        private static List<SalaryRegulationBLL> GenerateListSalaryRegulationBLLFromDataTable(DataTable dt)
        {
            List<SalaryRegulationBLL> list = new List<SalaryRegulationBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateSalaryRegulationBLLFromDataRow(dr));
            }

            return list;
        }

        private static SalaryRegulationBLL GenerateSalaryRegulationBLLFromDataRow(DataRow dr)
        {

            SalaryRegulationBLL objBLL = new SalaryRegulationBLL();

            objBLL._SalaryRegulationId = dr[SalaryRegulationKeys.Field_SalaryRegulation_SalaryRegulationId] == DBNull.Value ? 0 : int.Parse(dr[SalaryRegulationKeys.Field_SalaryRegulation_SalaryRegulationId].ToString());
            objBLL._SalaryRegulationName = dr[SalaryRegulationKeys.Field_SalaryRegulation_SalaryRegulationName] == DBNull.Value ? string.Empty : dr[SalaryRegulationKeys.Field_SalaryRegulation_SalaryRegulationName].ToString();
            objBLL._BeginingDate = dr[SalaryRegulationKeys.Field_SalaryRegulation_BeginingDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[SalaryRegulationKeys.Field_SalaryRegulation_BeginingDate].ToString());
            objBLL._Description = dr[SalaryRegulationKeys.Field_SalaryRegulation_Description] == DBNull.Value ? "" : dr[SalaryRegulationKeys.Field_SalaryRegulation_Description].ToString();
            objBLL._InUse = dr[SalaryRegulationKeys.Field_SalaryRegulation_InUse] == DBNull.Value ? false : Convert.ToBoolean(dr[SalaryRegulationKeys.Field_SalaryRegulation_InUse].ToString());
            objBLL._TypeId = dr[SalaryRegulationKeys.Field_SalaryRegulation_TypeId] == DBNull.Value ? 0 : int.Parse(dr[SalaryRegulationKeys.Field_SalaryRegulation_TypeId].ToString());
            objBLL._TypeName = Constants.GetSalaryRegulationTypeName(objBLL._TypeId);
            return objBLL;
        }

        #endregion

    }
}
