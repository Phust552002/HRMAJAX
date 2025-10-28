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
    public class LCBCoefficientEmployeeBLL
    {
        #region private fields

        private int _LCB_CoefficientEmployeeId;
        private int _UserId;
        private int _CoefficientValueId;
        private string _LCB_CoefficientEmployeeDescription;
        private DateTime _FromDate;
        private DateTime _ToDate;
        private double _LCBWages;
        private int _LCBUnit;
        private string _LCBUnitName;

        private int _CoefficientNameId;
        private string _CoefficientName;
        private int _Conditions;

        private int _CoefficientLevelId;
        private string _CoefficientLevelName;

        private int _EmployeeContractId;
        private string _ContractTypeName;
        private string _ContractTypeCode;
        private int _ContractTypeId;

        private double _CoefficientValue;
        private double _LCB;

        private bool _Active;

        private int _PositionId;
        private string _PositionName;

        private string _FullName;

        private int _SalaryRegulationId;

        private double _PCDH;
        private double _PCTN;
        private double _PCCV;
        private double _PCKV;

        #endregion

        #region properties

        public int LCB_CoefficientEmployeeId
        {
            get { return _LCB_CoefficientEmployeeId; }
            set { _LCB_CoefficientEmployeeId = value; }
        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }
        public int CoefficientValueId
        {
            get { return _CoefficientValueId; }
            set { _CoefficientValueId = value; }
        }

        public int Conditions
        {
            get { return _Conditions; }
            set { _Conditions = value; }
        }

        public string LCB_CoefficientEmployeeDescription
        {
            get { return _LCB_CoefficientEmployeeDescription; }
            set { _LCB_CoefficientEmployeeDescription = value; }
        }
        public DateTime FromDate
        {
            get { return _FromDate; }
            set { _FromDate = value; }
        }
        public DateTime ToDate
        {
            get { return _ToDate; }
            set { _ToDate = value; }
        }
        public double LCBWages
        {
            get { return _LCBWages; }
            set { _LCBWages = value; }
        }
        public int LCBUnit
        {
            get { return _LCBUnit; }
            set { _LCBUnit = value; }
        }
        public string LCBUnitName
        {
            get { return _LCBUnitName; }
            set { _LCBUnitName = value; }
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

        public int EmployeeContractId
        {
            get { return _EmployeeContractId; }
            set { _EmployeeContractId = value; }
        }
        public string ContractTypeName
        {
            get { return _ContractTypeName; }
            set { _ContractTypeName = value; }
        }
        public string ContractTypeCode
        {
            get { return _ContractTypeCode; }
            set { _ContractTypeCode = value; }
        }
        public int ContractTypeId
        {
            get { return _ContractTypeId; }
            set { _ContractTypeId = value; }
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
        public double LCB
        {
            get { return _LCB; }
            set { _LCB = value; }
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

        public int SalaryRegulationId
        {
            get { return _SalaryRegulationId; }
            set { _SalaryRegulationId = value; }
        }
        public double PCDH
        {
            get { return _PCDH; }
            set { _PCDH = value; }
        }
        public double PCTN
        {
            get { return _PCTN; }
            set { _PCTN = value; }
        }
        public double PCCV
        {
            get { return _PCCV; }
            set { _PCCV = value; }
        }
        public double PCKV
        {
            get { return _PCKV; }
            set { _PCKV = value; }
        }

        #endregion

        #region Constructor

        public LCBCoefficientEmployeeBLL() { }
        public LCBCoefficientEmployeeBLL(int LCB_CoefficientEmployeeId, int employeeContractId, int coefficientValueId, DateTime fromDate, DateTime toDate , string LCB_CoefficientEmployeeDescription)
        {
            _LCB_CoefficientEmployeeId = LCB_CoefficientEmployeeId;
            _EmployeeContractId = employeeContractId;
            _CoefficientValueId = coefficientValueId;
            _LCB_CoefficientEmployeeDescription = LCB_CoefficientEmployeeDescription;
            _FromDate = fromDate;
            _ToDate = toDate;
        }

        #endregion

        #region public methods insert, update, delete

        public long Save()
        {
            LCBCoefficientEmployeesDAL objDAL = new LCBCoefficientEmployeesDAL();            

            if (LCB_CoefficientEmployeeId <= 0)
            {
                return objDAL.Insert(EmployeeContractId, UserId, CoefficientValueId, LCBWages, LCBUnit, FromDate, ToDate, LCB_CoefficientEmployeeDescription, PCDH, PCTN, PCCV, PCKV);
            }
            else
            {
                return objDAL.Update(LCB_CoefficientEmployeeId, UserId, EmployeeContractId, CoefficientValueId, LCBWages, LCBUnit, FromDate, ToDate, LCB_CoefficientEmployeeDescription, Active, PCDH, PCTN, PCCV, PCKV);
            }
        }


        //public static long Update(int lCB_CoefficientEmployeeId, int userId, int employeeContractId, string positionName, int coefficientNameId, int coefficientLevelId, string coefficientValue, double lCBWages, int lCBUnit, DateTime fromDate, DateTime toDate, string lCB_CoefficientEmployeeDescription, bool active, string contractTypeName, string conditions, int contractTypeId)
        //{

        //    LCBCoefficientEmployeesDAL objDAL = new LCBCoefficientEmployeesDAL();

        //    CoefficientValuesBLL objBLL = CoefficientValuesBLL.GetByName_Level(coefficientNameId, coefficientLevelId);
        //    int coefficientValueId = 0;
        //    if (objBLL != null)
        //    {
        //        coefficientValueId = objBLL.CoefficientValueId;
        //    }
        //    if (lCB_CoefficientEmployeeDescription == null)
        //        lCB_CoefficientEmployeeDescription = string.Empty;
        //    int successful = objDAL.Update(lCB_CoefficientEmployeeId, userId, employeeContractId, coefficientValueId, lCBWages, lCBUnit, fromDate, toDate, lCB_CoefficientEmployeeDescription, active);            

        //    return successful;
        //}

        public static long Delete(int lCB_CoefficientEmployeeId)
        {
            LCBCoefficientEmployeesDAL objDAL = new LCBCoefficientEmployeesDAL();
            return objDAL.Delete(lCB_CoefficientEmployeeId);
        }
        public static long DeleteByEmployeeContractId(int employeeContractId)
        {
            return new LCBCoefficientEmployeesDAL().DeleteByEmployeeContractId(employeeContractId);
        }

        #endregion

        #region public methods GET

        public static List<LCBCoefficientEmployeeBLL> GetByUserId(int userId)
        {
            return GenerateListLCB_CoefficientEmployeeBLLFromDataTable(new LCBCoefficientEmployeesDAL().GetByUserId(userId));
        }

        public static List<LCBCoefficientEmployeeBLL> RemindLCBCoefficient(string fullName, int deptId, int day, int month, int year)
        {
            return GenerateListLCB_CoefficientEmployeeBLLFromDataTable(new LCBCoefficientEmployeesDAL().RemindLCBCoefficient(fullName, deptId, day, month, year));
        }
        public static List<LCBCoefficientEmployeeBLL> ChangedLCBCoefficient(string fullName, int deptId, int day, int month, int year)
        {
            return GenerateListLCB_CoefficientEmployeeBLLFromDataTable(new LCBCoefficientEmployeesDAL().ChangedLCBCoefficient(fullName, deptId, day, month, year));
        }

        public static LCBCoefficientEmployeeBLL GetByUserIdFromToDateFinal(int userId, DateTime fromDate, DateTime toDate, int XQD)
        {
            List<LCBCoefficientEmployeeBLL> list = GenerateListLCB_CoefficientEmployeeBLLFinalFromDataTable(new LCBCoefficientEmployeesDAL().GetByUserIdFromToDateFinal(userId, fromDate, toDate, XQD));
            if (list.Count == 1)
            {
                return list[0];
            }
            else
            {
                return null;
            }

        }

        public static LCBCoefficientEmployeeBLL GetByEmployeeContractId(int employeeContractId)
        {
            List<LCBCoefficientEmployeeBLL> list = GenerateListLCB_CoefficientEmployeeBLLFromDataTable(new LCBCoefficientEmployeesDAL().GetByEmployeeContractId(employeeContractId));

            if (list.Count == 1)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public static LCBCoefficientEmployeeBLL GetByUserIdForNew(int userId)
        {

            List<LCBCoefficientEmployeeBLL> list = GenerateListLCB_CoefficientEmployeeBLLFromDataTable(new LCBCoefficientEmployeesDAL().GetByUserIdForNew(userId));
            if (list.Count == 1)
            {
                return list[0];
            }
            else
            {
                return null;
            }

        }

        //public static LCBCoefficientEmployeeBLL GetCurrentByUserIdDate(int userId, DateTime fromDate)
        //{

        //    List<LCBCoefficientEmployeeBLL> list = GenerateListLCB_CoefficientEmployeeBLLFromDataTable(new LCBCoefficientEmployeesDAL().GetCurrentByUserIdDate(userId, fromDate));

        //    if (list.Count == 1)
        //    {
        //        return list[0];
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //public static LCBCoefficientEmployeeBLL GetByUserIdToDateContractType(int userId, DateTime fromDate, int contractTypeId)
        //{

        //    List<LCBCoefficientEmployeeBLL> list = GenerateListLCB_CoefficientEmployeeBLLFromDataTable(new LCBCoefficientEmployeesDAL().GetByUserIdToDateContractType(userId, fromDate, contractTypeId));

        //    if (list.Count == 1)
        //    {
        //        return list[0];
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        

        #endregion

        #region private methods

        private static List<LCBCoefficientEmployeeBLL> GenerateListLCB_CoefficientEmployeeBLLFromDataTable(DataTable dt)
        {
            List<LCBCoefficientEmployeeBLL> list = new List<LCBCoefficientEmployeeBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateLCB_CoefficientEmployeeBLLFromDataRow(dr));
            }

            return list;
        }

        private static LCBCoefficientEmployeeBLL GenerateLCB_CoefficientEmployeeBLLFromDataRow(DataRow dr)
        {
            LCBCoefficientEmployeeBLL objBLL = new LCBCoefficientEmployeeBLL(
                dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_LCB_CoefficientEmployeeId] == DBNull.Value ? DefaultValues.LCB_CoefficientEmployeeIdMinValue : int.Parse(dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_LCB_CoefficientEmployeeId].ToString()),
                dr[EmployeeContractKeys.Field_EmployeeContract_EmployeeContractId] == DBNull.Value ? DefaultValues.UserIdMinValue : int.Parse(dr[EmployeeContractKeys.Field_EmployeeContract_EmployeeContractId].ToString()),
                dr[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE_ID] == DBNull.Value ? DefaultValues.CoefficientValueIdMinValue : int.Parse(dr[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE_ID].ToString()),
                dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_FromDate] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_FromDate].ToString()),
                dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_ToDate] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_ToDate].ToString()),
                dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_LCB_CoefficientEmployeeDescription] == DBNull.Value ? string.Empty : dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_LCB_CoefficientEmployeeDescription].ToString()
                );

            objBLL.UserId = dr[EmployeeKeys.FIELD_EMPLOYEES_USERID] == DBNull.Value ? 0 : int.Parse(dr[EmployeeKeys.FIELD_EMPLOYEES_USERID].ToString());
            try
            {
                objBLL.FullName = dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME].ToString();
            }
            catch { }

            objBLL.LCBWages = dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_LCBWages] == DBNull.Value ? 0 : double.Parse(dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_LCBWages].ToString());
            objBLL.LCBUnit = dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_LCBUnit] == DBNull.Value ? 0 : int.Parse(dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_LCBUnit].ToString());
            objBLL.LCBUnitName = Constants.GetUnitNameById(objBLL.LCBUnit);

            objBLL.CoefficientNameId = dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId] == DBNull.Value ? DefaultValues.CoefficientNameIdMinValue : int.Parse(dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId].ToString());
            objBLL.CoefficientName = dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientName] == DBNull.Value ? string.Empty : dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientName].ToString();

            objBLL.CoefficientLevelId = dr[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_ID] == DBNull.Value ? DefaultValues.CoefficientNameIdMinValue : int.Parse(dr[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_ID].ToString());
            objBLL.CoefficientLevelName = dr[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_NAME] == DBNull.Value ? string.Empty : dr[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_NAME].ToString();

            objBLL.CoefficientValue = dr[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(dr[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
            objBLL.Conditions = dr[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS] == DBNull.Value ? 0 : int.Parse(dr[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS].ToString());            

            objBLL.Active = dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_Active] == DBNull.Value ? false : Convert.ToBoolean(dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_Active].ToString());

            //objBLL.PositionId = dr[PositionKeys.FIELD_POSITION_ID] == DBNull.Value ? 0 : int.Parse(dr[PositionKeys.FIELD_POSITION_ID].ToString());
            //objBLL.PositionName = dr[PositionKeys.FIELD_POSITION_NAME] == DBNull.Value ? string.Empty : dr[PositionKeys.FIELD_POSITION_NAME].ToString();
            //objBLL.ContractTypeName = dr[ContractTypeKeys.Field_ContractTypes_ContractTypeName] == DBNull.Value ? string.Empty : dr[ContractTypeKeys.Field_ContractTypes_ContractTypeName].ToString();
            //objBLL.ContractTypeCode = dr[ContractTypeKeys.Field_ContractTypes_ContractTypeCode] == DBNull.Value ? string.Empty : dr[ContractTypeKeys.Field_ContractTypes_ContractTypeCode].ToString();
            //objBLL.ContractTypeId = dr[ContractTypeKeys.Field_ContractTypes_ContractTypeId] == DBNull.Value ? 0 : int.Parse(dr[ContractTypeKeys.Field_ContractTypes_ContractTypeId].ToString());
            try
            {
                objBLL.SalaryRegulationId = dr[SalaryRegulationKeys.Field_SalaryRegulation_SalaryRegulationId] == DBNull.Value ? 0 : (int)dr[SalaryRegulationKeys.Field_SalaryRegulation_SalaryRegulationId];
            }
            catch { }

            objBLL._PCDH = dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_PCDH] == DBNull.Value ? 0 : Convert.ToDouble(dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_PCDH].ToString());
            objBLL._PCTN = dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_PCTN] == DBNull.Value ? 0 : Convert.ToDouble(dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_PCTN].ToString());
            objBLL._PCCV = dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_PCCV] == DBNull.Value ? 0 : Convert.ToDouble(dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_PCCV].ToString());
            objBLL._PCKV = dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_PCKV] == DBNull.Value ? 0 : Convert.ToDouble(dr[LCB_CoefficientEmployeeKeys.Field_LCB_CoefficientEmployees_PCKV].ToString());


            return objBLL;
        }

        private static List<LCBCoefficientEmployeeBLL> GenerateListLCB_CoefficientEmployeeBLLFinalFromDataTable(DataTable dt)
        {
            List<LCBCoefficientEmployeeBLL> list = new List<LCBCoefficientEmployeeBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateLCB_CoefficientEmployeeBLLFinalFromDataRow(dr));
            }

            return list;
        }

        private static LCBCoefficientEmployeeBLL GenerateLCB_CoefficientEmployeeBLLFinalFromDataRow(DataRow dr)
        {
            LCBCoefficientEmployeeBLL objBLL = new LCBCoefficientEmployeeBLL();

            objBLL.UserId = dr[EmployeeKeys.FIELD_EMPLOYEES_USERID] == DBNull.Value ? 0 : int.Parse(dr[EmployeeKeys.FIELD_EMPLOYEES_USERID].ToString());

            objBLL.LCB = dr[CoefficientValueKeys.Field_Coefficient_LCB] == DBNull.Value ? 0 : double.Parse(dr[CoefficientValueKeys.Field_Coefficient_LCB].ToString());

            return objBLL;
        }

        #endregion

    }
}
