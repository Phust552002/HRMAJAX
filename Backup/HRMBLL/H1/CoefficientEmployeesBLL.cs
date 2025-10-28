using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

using HRMBLL.H1.Helper;
using HRMDAL.Utilities;
using HRMDAL.H1;
using HRMUtil.KeyNames.H1;
using HRMUtil.KeyNames.H0;
using HRMUtil;

namespace HRMBLL.H1
{
    public class CoefficientEmployeesBLL
    {

        private double _TotalLCB = 0;
        private double _TotalLNS = 0;
        private double _TotalLCBP = 0;
        private double _TotalLNSP = 0;
        private double _TotalPCDH = 0;
        private double _TotalPCTN = 0;
        private double _TotalPCCV = 0;
        private double _TotalPCKV = 0;
        

        #region private fields
   
        private int _CoefficientEmployeeId;        
        private double _K;
        private double _LCB;
        private double _LNS;
        private double _PCDH;
        private double _PCTN;
        private double _PCCV;
        private double _PCKV;
        private double _LNSPCTN;
        private string _Description;
        private bool _ACTIVE;
        private bool _LOCK;
        private DateTime _CREATEDATE;

        
        private int _UserId;
        private string _UserCode;
        private string _UserName;
        private string _FullName;
        private string _PositionName;
        private string _DepartmentName;
        private string _DepartmentFullName;
        private string _RootName;
        private double _Wages;
        private int _Unit;
        private string _UnitName;
        private string _ContractTypeName;
        private string _ContractTypeCode;

        private double _LNSWages;
        private int _LNSUnit;
        private string _LNSUnitName;


        private double _LCBWages;
        private int _LCBUnit;
        private string _LCBUnitName;

        #endregion

        #region properties

        public double TotalLCB
        {
            get { return _TotalLCB; }
            set { _TotalLCB = value; }
        }
        public double TotalLNS
        {
            get { return _TotalLNS; }
            set { _TotalLNS = value; }
        }
        public double TotalLCBP
        {
            get { return _TotalLCBP; }
            set { _TotalLCBP = value; }
        }
        public double TotalLNSP
        {
            get { return _TotalLNSP; }
            set { _TotalLNSP = value; }
        }
        public double TotalPCDH
        {
            get { return _TotalPCDH; }
            set { _TotalPCDH = value; }
        }
        public double TotalPCTN
        {
            get { return _TotalPCTN; }
            set { _TotalPCTN = value; }
        }
        public double TotalPCCV
        {
            get { return _TotalPCCV; }
            set { _TotalPCCV = value; }
        }
        public double TotalPCKV
        {
            get { return _TotalPCKV; }
            set { _TotalPCKV = value; }
        }

        #region properties

        public int CoefficientEmployeeId
        {
            get { return _CoefficientEmployeeId; }
            set { _CoefficientEmployeeId = value; }
        }
        public double K
        {
            get { return _K; }
            set { _K = value; }
        }
        public double LCB
        {
            get { return _LCB; }
            set { _LCB = value; }
        }
        public double LNS
        {
            get { return _LNS; }
            set { _LNS = value; }
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

        public double LNSPCTN
        {
            get { return _LNSPCTN; }
            set { _LNSPCTN = value; }
        }
        
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public bool ACTIVE
        {
            get { return _ACTIVE; }
            set { _ACTIVE = value; }
        }
        public bool LOCK
        {
            get { return _LOCK; }
            set { _LOCK = value; }
        }
        public DateTime CREATEDATE
        {
            get { return _CREATEDATE; }
            set { _CREATEDATE = value; }
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


        public double Wages
        {
            get { return _Wages; }
            set { _Wages = value; }
        }
        public int Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }
        public string UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
        }

        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        public string UserCode
        {
            get { return _UserCode; }
            set { _UserCode = value; }
        }

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
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

        public string DepartmentFullName
        {
            get { return _DepartmentFullName; }
            set { _DepartmentFullName = value; }
        }
        public string RootName
        {
            get { return _RootName; }
            set { _RootName = value; }
        }
        /// <summary>
        /// 
        /// </summary>

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
        #endregion

        /// <summary>
        /// 
        /// </summary>
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

        #endregion

        #region constructor

        public CoefficientEmployeesBLL() { }
        public CoefficientEmployeesBLL(int coefficientEmployeeId, int userId,
                                        double pCDH, double pCTN, double pCCV, double pCKV, string description, DateTime createDate, bool active) 
        {
            _CoefficientEmployeeId = coefficientEmployeeId; 
            _UserId = userId; 
            _PCDH = pCDH;
            _PCTN = pCTN;
            _PCCV = pCCV;
            _PCKV = pCKV;
            _Description = description;
            _CREATEDATE = createDate;
            _ACTIVE = active;
        }

      
        public CoefficientEmployeesBLL(int userId, string userName, string userCode, string fullName, string deparmentName, string positionName)
        {            
            _UserId = userId;
            _UserName = userName;
            _UserCode = userCode;           
            _PositionName = positionName;
            _FullName = fullName;
            _DepartmentName = deparmentName;

        }

        #endregion


        #region public methods : insert, update, delete

        public long Save()
        {
            CoefficientEmployeesDAL objDAL = new CoefficientEmployeesDAL();
            if (CoefficientEmployeeId <= 0)
            {
                return objDAL.Insert(UserId, PCDH, PCTN, PCCV, PCKV, Description, ACTIVE, CREATEDATE);
            }
            else 
            {
                return objDAL.Update(UserId, PCDH, PCTN, PCCV, PCKV, Description, ACTIVE, CREATEDATE, CoefficientEmployeeId);
            }
        }

        public static long Update(int coefficientEmployeeId, int userId, double lCB, double lNS, double pCDH, double pCTN,
                          double pCCV, double pCKV, string description, bool active, DateTime createDate)
        {
            CoefficientEmployeesDAL objDAL = new CoefficientEmployeesDAL();

            if (description == null)
                description = string.Empty;   
            return objDAL.Update(userId, pCDH, pCTN, pCCV, pCKV, description, active, createDate, coefficientEmployeeId);
        }

        public static long Delete(int coefficientEmployeeId)
        {
            CoefficientEmployeesDAL objDAL = new CoefficientEmployeesDAL();
            return objDAL.Delete(coefficientEmployeeId);  
        }

        

        #endregion


        #region public static methods : GET

        //public static List<CoefficientEmployeesBLL> AllCoefficientEmployeeGetByFilter(string fullName, int departmentId, int LNSwages, string LNSstrOperator, int LCBwages, string LCBstrOperator, string sortParameter)
        //{
        //    List<CoefficientEmployeesBLL> list = GenerateListCoefficientBLLFromDataTableAll(new CoefficientEmployeesDAL().AllCoefficientEmployeeGetByFilter(fullName, departmentId, LNSstrOperator,LNSwages, LCBstrOperator, LCBwages));
        //    if (!String.IsNullOrEmpty(sortParameter))
        //        list.Sort(new CoefficientEmployeesBLLComparer(sortParameter));
        //    return list;
        //}
        //public static CoefficientEmployeesBLL AllCoefficientEmployeeGetTotalByFilter(string fullName, int departmentId, int LNSwages, string LNSstrOperator, int LCBwages, string LCBstrOperator, string sortParameter)
        //{
        //    List<CoefficientEmployeesBLL> list = GenerateListCoefficientBLLFromDataTableAllTotal(new CoefficientEmployeesDAL().AllCoefficientEmployeeGetTotalByFilter(fullName, departmentId, LNSstrOperator, LNSwages, LCBstrOperator, LCBwages));
        //    if (list.Count == 1)
        //    {
        //        return list[0];
        //    }
        //    else
        //    {
        //        return null;
        //    }            
        //}
        //public static CoefficientEmployeesBLL AllCoefficientEmployeeGetByUserId(int userId)
        //{
        //    List<CoefficientEmployeesBLL> list = GenerateListCoefficientBLLFromDataTableAll(new CoefficientEmployeesDAL().AllCoefficientEmployeeGetByUserId(userId));
        //    if (list.Count == 1)
        //    {
        //        return list[0];
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}


        public static List<CoefficientEmployeesBLL> GetByUserId(int userId)
        {
            return GenerateListCoefficientBLLFromDataTable(new CoefficientEmployeesDAL().GetByUserId(userId));
        }
        public static List<CoefficientEmployeesBLL> GetByUserIdDate(int userId, DateTime createDate)
        {
            return GenerateListCoefficientBLLFromDataTable(new CoefficientEmployeesDAL().GetByUserIdDate(userId, createDate));
        }
        public static CoefficientEmployeesBLL GetByUserIdDateFinal(int userId, DateTime createDate, int XQD)
        {
            List<CoefficientEmployeesBLL> list = GenerateListCoefficientBLLFinalFromDataTable(new CoefficientEmployeesDAL().GetByUserIdDateFinal(userId, createDate, XQD));

            if(list.Count == 1)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }
        public static CoefficientEmployeesBLL GetByUserIdForNew(int userId)
        {
            List<CoefficientEmployeesBLL> list = GenerateListCoefficientBLLFinalFromDataTable(new CoefficientEmployeesDAL().GetByUserIdForNew(userId));

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


        #region private methods, generate helper methods                                     

        private static List<CoefficientEmployeesBLL> GenerateListCoefficientBLLFromDataTable(DataTable dt)
        {
            List<CoefficientEmployeesBLL> list = new List<CoefficientEmployeesBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateCoefficientBLLFromDataRow(dr));
            }

            return list;
        }
        private static List<CoefficientEmployeesBLL> GenerateListCoefficientBLLFinalFromDataTable(DataTable dt)
        {
            List<CoefficientEmployeesBLL> list = new List<CoefficientEmployeesBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateCoefficientBLLFinalFromDataRow(dr));
            }

            return list;
        }
        
        private static List<CoefficientEmployeesBLL> GenerateListCoefficientBLLFromDataTableAll(DataTable dt)
        {
            List<CoefficientEmployeesBLL> list = new List<CoefficientEmployeesBLL>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateCoefficientBLLFromDataRowAll(dr));
            }

            return list;
        }
        private static List<CoefficientEmployeesBLL> GenerateListCoefficientBLLFromDataTableAllTotal(DataTable dt)
        {
            List<CoefficientEmployeesBLL> list = new List<CoefficientEmployeesBLL>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateCoefficientBLLFromDataRowAllTotal(dr));
            }

            return list;
        }

        private static CoefficientEmployeesBLL GenerateCoefficientBLLFromDataRow(DataRow dr)
        {
            CoefficientEmployeesBLL objBLL = new CoefficientEmployeesBLL(
            dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_ID] == DBNull.Value ? 0 : int.Parse(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_ID].ToString()),
            dr[EmployeeKeys.FIELD_EMPLOYEES_USERID] == DBNull.Value ? 0 : int.Parse(dr[EmployeeKeys.FIELD_EMPLOYEES_USERID].ToString()),
            dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCDH] == DBNull.Value ? 0 : Convert.ToDouble(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCDH].ToString()),
            dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCTN] == DBNull.Value ? 0 : Convert.ToDouble(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCTN].ToString()),
            dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCCV] == DBNull.Value ? 0 : Convert.ToDouble(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCCV].ToString()),
            dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCKV] == DBNull.Value ? 0 : Convert.ToDouble(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCKV].ToString()),
            dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_DESCRIPTION] == DBNull.Value ? string.Empty : dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_DESCRIPTION].ToString(),
            dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_CREATEDATE] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_CREATEDATE].ToString()),
            dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_ACTIVE] == DBNull.Value ? false : Convert.ToBoolean(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_ACTIVE].ToString())
            );
            return objBLL;
        }
        private static CoefficientEmployeesBLL GenerateCoefficientBLLFinalFromDataRow(DataRow dr)
        {
            CoefficientEmployeesBLL objBLL = new CoefficientEmployeesBLL();
            objBLL.UserId = dr[EmployeeKeys.FIELD_EMPLOYEES_USERID] == DBNull.Value ? 0 : int.Parse(dr[EmployeeKeys.FIELD_EMPLOYEES_USERID].ToString());
            objBLL.PCDH = dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCDH] == DBNull.Value ? 0 : Convert.ToDouble(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCDH].ToString());
            objBLL.PCTN = dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCTN] == DBNull.Value ? 0 : Convert.ToDouble(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCTN].ToString());
            objBLL.PCCV = dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCCV] == DBNull.Value ? 0 : Convert.ToDouble(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCCV].ToString());
            objBLL.PCKV = dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCKV] == DBNull.Value ? 0 : Convert.ToDouble(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCKV].ToString());
            return objBLL;
        }

        private static CoefficientEmployeesBLL GenerateCoefficientBLLFromDataRowAll(DataRow dr)
        {
            CoefficientEmployeesBLL objBLL = new CoefficientEmployeesBLL();
            try
            {
                objBLL._UserId = dr[EmployeeKeys.FIELD_EMPLOYEES_USERID] == DBNull.Value ? DefaultValues.UserIdMinValue : Convert.ToInt32(dr[EmployeeKeys.FIELD_EMPLOYEES_USERID].ToString());
            }
            catch { }
            try
            {
                objBLL._UserCode = dr[EmployeeKeys.FIELD_EMPLOYEES_EMPLOYEE_CODE] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_EMPLOYEE_CODE].ToString();
            }
            catch { }
            try
            {
                objBLL._FullName = dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME].ToString();
            }
            catch { }
            try
            {
                objBLL._PositionName = dr[PositionKeys.FIELD_POSITION_NAME] == DBNull.Value ? string.Empty : dr[PositionKeys.FIELD_POSITION_NAME].ToString();
            }
            catch { }
            try
            {
                objBLL._DepartmentName = dr[DepartmentKeys.FIELD_DEPARTMENT_NAME] == DBNull.Value ? string.Empty : dr[DepartmentKeys.FIELD_DEPARTMENT_NAME].ToString();
            }
            catch { }
            try
            {
                objBLL._DepartmentFullName = dr[DepartmentKeys.Field_Department_DepartmentFullName] == DBNull.Value ? string.Empty : dr[DepartmentKeys.Field_Department_DepartmentFullName].ToString();
            }
            catch { }
            try
            {
                objBLL._RootName = dr[DepartmentKeys.Field_Department_RootName] == DBNull.Value ? string.Empty : dr[DepartmentKeys.Field_Department_RootName].ToString();
            }
            catch { }

            try
            {
                objBLL._Wages = dr[EmployeeContractKeys.Field_EmployeeContract_Wages] == DBNull.Value ? 0 : double.Parse(dr[EmployeeContractKeys.Field_EmployeeContract_Wages].ToString());
            }
            catch { }
            try
            {
                objBLL._Unit = dr[EmployeeContractKeys.Field_EmployeeContract_Unit] == DBNull.Value ? 0 : int.Parse(dr[EmployeeContractKeys.Field_EmployeeContract_Unit].ToString());
                objBLL._UnitName = Constants.GetUnitNameById(objBLL._Unit);
            }
            catch { }
            try
            {
                objBLL._ContractTypeName = dr[ContractTypeKeys.Field_ContractTypes_ContractTypeName] == DBNull.Value ? string.Empty : dr[ContractTypeKeys.Field_ContractTypes_ContractTypeName].ToString();
            }
            catch { }
            try
            {
                objBLL._ContractTypeCode = dr[ContractTypeKeys.Field_ContractTypes_ContractTypeCode] == DBNull.Value ? string.Empty : dr[ContractTypeKeys.Field_ContractTypes_ContractTypeCode].ToString();
            }
            catch { }


            objBLL._CoefficientEmployeeId = dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_ID] == DBNull.Value ? 0 : int.Parse(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_ID].ToString());
            objBLL._PCDH = dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCDH] == DBNull.Value ? 0 : Convert.ToDouble(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCDH].ToString());
            objBLL._PCTN = dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCTN] == DBNull.Value ? 0 : Convert.ToDouble(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCTN].ToString());
            objBLL._PCCV = dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCCV] == DBNull.Value ? 0 : Convert.ToDouble(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCCV].ToString());
            objBLL._PCKV = dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCKV] == DBNull.Value ? 0 : Convert.ToDouble(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_PCKV].ToString());
            objBLL._Description = dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_DESCRIPTION] == DBNull.Value ? string.Empty : dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_DESCRIPTION].ToString();
            objBLL._CREATEDATE = dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_CREATEDATE] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_CREATEDATE].ToString());
            objBLL._ACTIVE = dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_ACTIVE] == DBNull.Value ? false : Convert.ToBoolean(dr[CoefficientEmployeeKeys.FIELD_COEFFICIENT_EMPLOYEE_ACTIVE].ToString());

            try
            {
                objBLL._LNS = dr[CoefficientEmployeeKeys.Field_Coeficient_Employee_LNSCoefficientValue] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeKeys.Field_Coeficient_Employee_LNSCoefficientValue].ToString());
            }
            catch { }
            try
            {
                objBLL._LNSWages = dr[CoefficientEmployeeKeys.Field_Coeficient_Employee_LNSWages] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeKeys.Field_Coeficient_Employee_LNSWages].ToString());
            }
            catch { }
            try
            {
                objBLL._LNSUnit = dr[CoefficientEmployeeKeys.Field_Coeficient_Employee_LNSUnit] == DBNull.Value ? 0 : int.Parse(dr[CoefficientEmployeeKeys.Field_Coeficient_Employee_LNSUnit].ToString());
            }
            catch { }
            try
            {
                objBLL._LNSUnitName = Constants.GetUnitNameById(objBLL._LNSUnit);
            }
            catch { }
            try
            {
                objBLL._LNSPCTN = dr[CoefficientEmployeeKeys.Field_Coeficient_Employee_LNSPCTN] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeKeys.Field_Coeficient_Employee_LNSPCTN].ToString());
            }
            catch { }
            try
            {
                objBLL._LCB = dr[CoefficientEmployeeKeys.Field_Coeficient_Employee_LCBCoefficientValue] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeKeys.Field_Coeficient_Employee_LCBCoefficientValue].ToString());
            }
            catch { }
            try
            {
                objBLL._LCBWages = dr[CoefficientEmployeeKeys.Field_Coeficient_Employee_LCBWages] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeKeys.Field_Coeficient_Employee_LCBWages].ToString());
            }
            catch { }
            try
            {
                objBLL._LCBUnit = dr[CoefficientEmployeeKeys.Field_Coeficient_Employee_LCBUnit] == DBNull.Value ? 0 : int.Parse(dr[CoefficientEmployeeKeys.Field_Coeficient_Employee_LCBUnit].ToString());
            }
            catch { }
            try
            {
                objBLL._LCBUnitName = Constants.GetUnitNameById(objBLL._LCBUnit);
            }
            catch { }


            return objBLL;
        }
        private static CoefficientEmployeesBLL GenerateCoefficientBLLFromDataRowAllTotal(DataRow dr)
        {
            CoefficientEmployeesBLL objBLL = new CoefficientEmployeesBLL();

            objBLL._TotalLNS = dr[LNS_CoefficientEmployeeKeys.Field_LNS_Coefficeint_TotalLNS] == DBNull.Value ? 0 : double.Parse(dr[LNS_CoefficientEmployeeKeys.Field_LNS_Coefficeint_TotalLNS].ToString());
            objBLL._TotalLNSP = dr[LNS_CoefficientEmployeeKeys.Field_LNS_Coefficeint_TotalLNSP] == DBNull.Value ? 0 : double.Parse(dr[LNS_CoefficientEmployeeKeys.Field_LNS_Coefficeint_TotalLNSP].ToString());

            objBLL._TotalLCB = dr[LCB_CoefficientEmployeeKeys.Field_LCB_Coefficeint_TotalLCB] == DBNull.Value ? 0 : double.Parse(dr[LCB_CoefficientEmployeeKeys.Field_LCB_Coefficeint_TotalLCB].ToString());
            objBLL._TotalLCBP = dr[LCB_CoefficientEmployeeKeys.Field_LCB_Coefficeint_TotalLCBP] == DBNull.Value ? 0 : double.Parse(dr[LCB_CoefficientEmployeeKeys.Field_LCB_Coefficeint_TotalLCBP].ToString());

            objBLL._TotalPCDH = dr[CoefficientEmployeeKeys.Field_Coefficient_Employee_TotalPCDH] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeKeys.Field_Coefficient_Employee_TotalPCDH].ToString());
            objBLL._TotalPCTN = dr[CoefficientEmployeeKeys.Field_Coefficient_Employee_TotalPCTN] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeKeys.Field_Coefficient_Employee_TotalPCTN].ToString());
            objBLL._TotalPCKV = dr[CoefficientEmployeeKeys.Field_Coefficient_Employee_TotalPCKV] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeKeys.Field_Coefficient_Employee_TotalPCKV].ToString());
            objBLL._TotalPCCV = dr[CoefficientEmployeeKeys.Field_Coefficient_Employee_TotalPCCV] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeKeys.Field_Coefficient_Employee_TotalPCCV].ToString());
            


            return objBLL;
        }

        #endregion

    }
}
