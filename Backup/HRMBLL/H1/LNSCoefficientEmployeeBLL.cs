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
    public class LNSCoefficientEmployeeBLL
    {

        #region private fields

        private int _LNS_CoefficientEmployeeId;
        private int _UserId;
        private int _CoefficientValueId;
        private string _LNS_CoefficientEmployeeDescription;
        private DateTime _CreateDate;
        private double _LNSWages;
        private int _LNSUnit;
        private string _LNSUnitName;

        private int _EmployeeContractId;
        private string _ContractTypeName;

        private int _CoefficientNameId;
        private string _CoefficientName;

        private int _CoefficientLevelId;
        private string _CoefficientLevelName;

        private double _CoefficientValue;

        private bool _Active;

        private int _PositionId;
        private string _PositionName;        
        private double _PCTN;
        private int _CoefficientNameType;

        /// <summary>
        /// ////////////
        /// cac he so da duoc tinh ra he so cuoi cung bao gom muc huong, 2 he so trong thang
        /// </summary>
        private double _LNS;
        private double _LNSPCTN;

        private int _SalaryRegulationId = 0;

        #endregion

        #region properties

        public int LNS_CoefficientEmployeeId
        {
            get { return _LNS_CoefficientEmployeeId; }
            set { _LNS_CoefficientEmployeeId = value; }
        }
        public int EmployeeContractId
        {
            get { return _EmployeeContractId; }
            set { _EmployeeContractId = value; }
        }

        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        public string ContractTypeName
        {
            get { return _ContractTypeName; }
            set { _ContractTypeName = value; }
        }

        public int CoefficientValueId
        {
            get { return _CoefficientValueId; }
            set { _CoefficientValueId = value; }
        }

        public string LNS_CoefficientEmployeeDescription
        {
            get { return _LNS_CoefficientEmployeeDescription; }
            set { _LNS_CoefficientEmployeeDescription = value; }
        }
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }
        public double LNSWages
        {
            get { return _LNSWages; }
            set { _LNSWages = value; }
        }
        public int LNSUnit
        {
            get { return _LNSUnit; }
            set { _LNSUnit = value; }
        }
        public string LNSUnitName
        {
            get { return _LNSUnitName; }
            set { _LNSUnitName = value; }
        }


        public int CoefficientNameId
        {
            get { return _CoefficientNameId; }
            set { _CoefficientNameId = value; }
        }
        public string CoefficientName
        {
            get { return _CoefficientName; }
            set { _CoefficientName = value; }
        }


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

        public double CoefficientValue
        {
            get { return _CoefficientValue; }
            set { _CoefficientValue = value; }
        }

        public bool Active
        {
            get { return _Active; }
            set { _Active = value; }
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
        //public double Wages
        //{
        //    get { return _Wages; }
        //    set { _Wages = value; }
        //}

        //public int Unit
        //{
        //    get { return _Unit; }
        //    set { _Unit = value; }
        //}

        //public string UnitName
        //{
        //    get { return _UnitName; }
        //    set { _UnitName = value; }
        //}

        public double PCTN
        {
            get { return _PCTN; }
            set { _PCTN = value; }
        }

        public int SalaryRegulationId
        {
            get { return _SalaryRegulationId; }
            set { _SalaryRegulationId = value; }
        }
        public int CoefficientNameType
        {
            get { return _CoefficientNameType; }
            set { _CoefficientNameType = value; }
        }
        #endregion

        public double LNS
        {
            get { return _LNS; }
            set { _LNS = value; }
        }
        public double LNSPCTN
        {
            get { return _LNSPCTN; }
            set { _LNSPCTN = value; }
        }    

        #region public methods insert, update, delete

        public long Save()
        {
            LNSCoefficientEmployeesDAL objDAL = new LNSCoefficientEmployeesDAL();

            if (LNS_CoefficientEmployeeId <= 0)
            {
                return objDAL.Insert(EmployeeContractId, UserId, CoefficientValueId, PCTN, LNSWages, LNSUnit, LNS_CoefficientEmployeeDescription, CreateDate);
            }
            else
            {
                return objDAL.Update(LNS_CoefficientEmployeeId, UserId, EmployeeContractId, CoefficientValueId, PCTN, LNSWages, LNSUnit, LNS_CoefficientEmployeeDescription, CreateDate, Active);
            }
            
        }


        public static int Update(int lNS_CoefficientEmployeeId, int userId, int employeeContractId, string contractTypeName, string positionName, int coefficientNameId, int coefficientLevelId, string coefficientValue, double lNSWages, int lNSUnit, DateTime createDate, string lNS_CoefficientEmployeeDescription,  bool active, double pCTN)
        {

            LNSCoefficientEmployeesDAL objDAL = new LNSCoefficientEmployeesDAL();

            CoefficientValuesBLL objBLL = CoefficientValuesBLL.GetByName_Level(coefficientNameId, coefficientLevelId);
            int coefficientValueId = 0;
            if (objBLL != null)
                coefficientValueId = objBLL.CoefficientValueId;

            if (lNS_CoefficientEmployeeDescription == null)
                lNS_CoefficientEmployeeDescription = string.Empty;

            int successful = objDAL.Update(lNS_CoefficientEmployeeId, userId, employeeContractId, coefficientValueId, pCTN, lNSWages, lNSUnit, lNS_CoefficientEmployeeDescription, createDate, active);
            

            return successful;
        }

        public static int Delete(int lNS_CoefficientEmployeeId)
        {
            LNSCoefficientEmployeesDAL objDAL = new LNSCoefficientEmployeesDAL();
            return objDAL.Delete(lNS_CoefficientEmployeeId);
        }

        public static int DeleteByEmployeeContractId(int employeeContractId)
        {
            return new LNSCoefficientEmployeesDAL().DeleteByEmployeeContractId(employeeContractId);
        }


        #endregion

        #region public methods GET

        public static List<LNSCoefficientEmployeeBLL> GetByUserId(int userId, int InUse)
        {
            return GenerateListLNS_CoefficientEmployeeBLLFromDataTable(new LNSCoefficientEmployeesDAL().GetByUserId(userId, InUse));
        }

        public static LNSCoefficientEmployeeBLL GetByEmployeeContractId(int employeeContractId)
        {

            List<LNSCoefficientEmployeeBLL> list = GenerateListLNS_CoefficientEmployeeBLLFromDataTable(new LNSCoefficientEmployeesDAL().GetByEmployeeContractId(employeeContractId));

            if (list.Count >0)
            {
                return list[list.Count-1];
            }
            else
            {
                return null;
            }
        }

        public static LNSCoefficientEmployeeBLL GetByUserIdForNew(int userId)
        {

            List<LNSCoefficientEmployeeBLL> list = GenerateListLNS_CoefficientEmployeeBLLFromDataTable(new LNSCoefficientEmployeesDAL().GetByUserIdForNew(userId));

            if (list.Count == 1)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public static LNSCoefficientEmployeeBLL GetByUserIdDate(int userId, DateTime createDate)
        {
            int XQD = int.Parse(DefaultValues.XQDSalary(createDate.Month, createDate.Year).ToString());
            List<LNSCoefficientEmployeeBLL> list = GenerateFinalListLNS_CoefficientEmployeeBLLFromDataTable(new LNSCoefficientEmployeesDAL().GetByUserIdDate(userId, createDate, XQD));
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

        #region private methods

        private static List<LNSCoefficientEmployeeBLL> GenerateListLNS_CoefficientEmployeeBLLFromDataTable(DataTable dt)
        {
            List<LNSCoefficientEmployeeBLL> list = new List<LNSCoefficientEmployeeBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateLNS_CoefficientEmployeeBLLFromDataRow(dr));
            }

            return list;
        }

        private static LNSCoefficientEmployeeBLL GenerateLNS_CoefficientEmployeeBLLFromDataRow(DataRow dr)
        {
            LNSCoefficientEmployeeBLL objBLL = new LNSCoefficientEmployeeBLL();
            objBLL._LNS_CoefficientEmployeeId = dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_ID] == DBNull.Value ? DefaultValues.LNS_CoefficientEmployeeIdMinValue : int.Parse(dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_ID].ToString());
            objBLL._EmployeeContractId = dr[EmployeeContractKeys.Field_EmployeeContract_EmployeeContractId] == DBNull.Value ? 0 : int.Parse(dr[EmployeeContractKeys.Field_EmployeeContract_EmployeeContractId].ToString());
            objBLL._CoefficientValueId = dr[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE_ID] == DBNull.Value ? 0 : int.Parse(dr[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE_ID].ToString());
            objBLL._LNS_CoefficientEmployeeDescription = dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_DESCRIPTION] == DBNull.Value ? string.Empty : dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_DESCRIPTION].ToString();
            
            objBLL.UserId = dr[EmployeeKeys.FIELD_EMPLOYEES_USERID] == DBNull.Value ? 0 : int.Parse(dr[EmployeeKeys.FIELD_EMPLOYEES_USERID].ToString());

            objBLL.LNSWages = dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_LNSWages] == DBNull.Value ? 0 : double.Parse(dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_LNSWages].ToString());
            objBLL.LNSUnit = dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_LNSUnit] == DBNull.Value ? 0 : int.Parse(dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_LNSUnit].ToString());


            objBLL.CoefficientNameId = dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId] == DBNull.Value ? DefaultValues.CoefficientNameIdMinValue : int.Parse(dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId].ToString());
            objBLL.CoefficientName = dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientName] == DBNull.Value ? string.Empty : dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientName].ToString();

            objBLL.CoefficientLevelId = dr[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_ID] == DBNull.Value ? DefaultValues.CoefficientNameIdMinValue : int.Parse(dr[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_ID].ToString());
            objBLL.CoefficientLevelName = dr[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_NAME] == DBNull.Value ? string.Empty : dr[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_NAME].ToString();

            objBLL.CoefficientValue = dr[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(dr[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());

            objBLL.CreateDate = dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_CREATEDATE] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_CREATEDATE].ToString());

            objBLL.Active = dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_ACTIVE] == DBNull.Value ? false : Convert.ToBoolean(dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_ACTIVE].ToString());

            //objBLL.PositionId = dr[PositionKeys.FIELD_POSITION_ID] == DBNull.Value ? 0 : int.Parse(dr[PositionKeys.FIELD_POSITION_ID].ToString());
            //objBLL.PositionName = dr[PositionKeys.FIELD_POSITION_NAME] == DBNull.Value ? string.Empty : dr[PositionKeys.FIELD_POSITION_NAME].ToString();
            //objBLL.ContractTypeName = dr[ContractTypeKeys.Field_ContractTypes_ContractTypeName] == DBNull.Value ? string.Empty : dr[ContractTypeKeys.Field_ContractTypes_ContractTypeName].ToString();            
            objBLL.PCTN = dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_PCTN] == DBNull.Value ? 0 : (double)dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_PCTN];

            objBLL.LNSWages = dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_LNSWages] == DBNull.Value ? 0 : (double)dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_LNSWages];
            objBLL.LNSUnit = dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_LNSUnit] == DBNull.Value ? 0 : (int)dr[LNS_CoefficientEmployeeKeys.FIELD_LNS_COEFFICIENT_EMPLOYEE_LNSUnit];

            objBLL.LNSUnitName = Constants.GetUnitNameById(objBLL.LNSUnit);

            try
            {
                objBLL.SalaryRegulationId = dr[SalaryRegulationKeys.Field_SalaryRegulation_SalaryRegulationId] == DBNull.Value ? 0 : (int)dr[SalaryRegulationKeys.Field_SalaryRegulation_SalaryRegulationId];
            }
            catch { }
            try
            {
                objBLL.CoefficientNameType = dr["Type"] == DBNull.Value ? 0 : (int)dr["Type"];
            }
            catch { }
            

            return objBLL;
        }


        private static List<LNSCoefficientEmployeeBLL> GenerateFinalListLNS_CoefficientEmployeeBLLFromDataTable(DataTable dt)
        {
            List<LNSCoefficientEmployeeBLL> list = new List<LNSCoefficientEmployeeBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateFinalLNS_CoefficientEmployeeBLLFromDataRow(dr));
            }

            return list;
        }
        private static LNSCoefficientEmployeeBLL GenerateFinalLNS_CoefficientEmployeeBLLFromDataRow(DataRow dr)
        {
            LNSCoefficientEmployeeBLL objBLL = new LNSCoefficientEmployeeBLL();

            objBLL.UserId = dr[EmployeeKeys.FIELD_EMPLOYEES_USERID] == DBNull.Value ? 0 : int.Parse(dr[EmployeeKeys.FIELD_EMPLOYEES_USERID].ToString());
            objBLL.LNS = dr[LNS_CoefficientEmployeeKeys.Field_LNS_Coefficeint_LNS] == DBNull.Value ? 0 : double.Parse(dr[LNS_CoefficientEmployeeKeys.Field_LNS_Coefficeint_LNS].ToString());
            objBLL.LNSPCTN = dr[LNS_CoefficientEmployeeKeys.Field_LNS_Coefficeint_LNSPCTN] == DBNull.Value ? 0 : double.Parse(dr[LNS_CoefficientEmployeeKeys.Field_LNS_Coefficeint_LNSPCTN].ToString());
            return objBLL;
        }

        #endregion

    }
}
