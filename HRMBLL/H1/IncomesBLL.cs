using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H1;
using HRMUtil.KeyNames.H1;
using HRMUtil.KeyNames.H0;
using HRMUtil;

namespace HRMBLL.H1
{
    public class IncomesBLL
    {

        #region private fields

        private long _IncomeId;
        private int _UserId;
	    private decimal _LNS;        
	    private decimal _LCBNN;        
	    private decimal _PCCV;        
        private decimal _PCTN;
        private decimal _PCDH;
        private decimal _TCBHXH;
        private decimal _TCOm;
        private decimal _TCTS1Lan;
        private decimal _TienAn;
        private decimal _BoSungLuong;
        private decimal _TienThemGio;
        private decimal _TienLamDem;
        private decimal _TienThuong;
        private decimal _TrBHXH;
        private decimal _TrBHYT;
        private decimal _TrBHTN;
        private decimal _TrDoanPhi;
        private decimal _ThueThuNhap;
        private decimal _TotalIncome;        
        private decimal _TotalIncomeForTax;
        private int _IsChangeContract;
        private decimal _TotalShortTerm;
        private decimal _TotalPeriod_I;
        private decimal _TotalPeriod_II;
        private string _CalculatingLog1;
        private string _CalculatingLog2;
        private string _CalculatingLog3;
        private double _FinalConversionLNSCoefficient;
        private string _FinalConversionLNSCoefficientLog;
        private decimal _LNSBalance;
        private decimal _BonusBalance;
        private DateTime _CreateDate;
        private bool _Lock;               
        private string _Remark;
        private int _Type;

        private decimal _TotalContributions;
        private decimal _RealIncome;

        private string _EmployeeCode;
        private string _UserName;
        private string _FullName;
        private int _PositionId;
        private string _PositionName;
        private int _DepartmentId;
        private string _DepartmentName;
        private string _DepartmentFullName;
        private string _RootName;

        private decimal _TotalLNS;
        private decimal _TotalLCBNN;
        private decimal _TotalPCCV;
        private decimal _TotalPCTN;
        private decimal _TotalPCDH;
        private decimal _TotalTCBHXH;
        private decimal _TotalTCOm;
        private decimal _TotalTCTS1Lan;
        private decimal _TotalTienAn;
        private decimal _TotalBoSungLuong;
        private decimal _TotalTienThemGio;
        private decimal _TotalTienLamDem;
        private decimal _TotalTienThuong;
        private decimal _TotalTrBHXH;
        private decimal _TotalTrBHYT;
        private decimal _TotalTrBHTN;
        private decimal _TotalTrDoanPhi;
        private decimal _TotalThueThuNhap;
        private decimal _TotalTotalIncome;
        private decimal _TotalTotalIncomeForTax;
        private decimal _TotalTotalShortTerm;
        private decimal _TotalTotalPeriod_I;
        private decimal _TotalTotalPeriod_II;
        private decimal _TotalLNSBalance;
        private decimal _TotalBonusBalance;
        private decimal _TotalTotalContributions;
        private decimal _TotalRealIncome;

        #endregion

        #region properties


        public long IncomeId
        {
            get{return _IncomeId;}
            set{_IncomeId = value;}
        }

        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public decimal LNS
        {
            get { return _LNS; }
            set { _LNS = value; }
        }
        public decimal LCBNN
        {
            get { return _LCBNN; }
            set { _LCBNN = value; }
        }
        public decimal PCCV
        {
            get { return _PCCV; }
            set { _PCCV = value; }
        }
        public decimal PCTN
        {
            get { return _PCTN; }
            set { _PCTN = value; }
        }
        public decimal PCDH
        {
            get { return _PCDH; }
            set { _PCDH = value; }
        }
        public decimal TCBHXH
        {
            get { return _TCBHXH; }
            set { _TCBHXH = value; }
        }
        public decimal TotalTCOm
        {
            get { return _TotalTCOm; }
            set { _TotalTCOm = value; }
        }
        public decimal TotalTCTS1Lan
        {
            get { return _TotalTCTS1Lan; }
            set { _TotalTCTS1Lan = value; }
        }
        public decimal TCOm
        {
            get { return _TCOm; }
            set { _TCOm = value; }
        }
        public decimal TCTS1Lan
        {
            get { return _TCTS1Lan; }
            set { _TCTS1Lan = value; }
        }

        public decimal TienAn
        {
            get { return _TienAn; }
            set { _TienAn = value; }
        }
        public decimal BoSungLuong
        {
            get { return _BoSungLuong; }
            set { _BoSungLuong = value; }
        }
        public decimal TienThemGio
        {
            get { return _TienThemGio; }
            set { _TienThemGio = value; }
        }
        public decimal TienLamDem
        {
            get { return _TienLamDem; }
            set { _TienLamDem = value; }
        }
        public decimal TienThuong
        {
            get { return _TienThuong; }
            set { _TienThuong = value; }
        }
        public decimal TrBHXH
        {
            get { return _TrBHXH; }
            set { _TrBHXH = value; }
        }
        public decimal TrBHYT
        {
            get { return _TrBHYT; }
            set { _TrBHYT = value; }
        }
        public decimal TrBHTN
        {
            get { return _TrBHTN; }
            set { _TrBHTN = value; }
        }
        
        public decimal TrDoanPhi
        {
            get { return _TrDoanPhi; }
            set { _TrDoanPhi = value; }
        }
        public decimal ThueThuNhap
        {
            get { return _ThueThuNhap; }
            set { _ThueThuNhap = value; }
        }
        public decimal TotalIncome
        {
            get { return _TotalIncome; }
            set { _TotalIncome = value; }
        }        
        public decimal TotalIncomeForTax
        {
            get { return _TotalIncomeForTax; }
            set { _TotalIncomeForTax = value; }
        }
        public int IsChangeContract
        {
            get { return _IsChangeContract; }
            set { _IsChangeContract = value; }
        }
        public decimal TotalShortTerm
        {
            get { return _TotalShortTerm; }
            set { _TotalShortTerm = value; }
        }
        public decimal TotalPeriod_I
        {
            get { return _TotalPeriod_I; }
            set { _TotalPeriod_I = value; }
        }
        public decimal TotalPeriod_II
        {
            get { return _TotalPeriod_II; }
            set { _TotalPeriod_II = value; }
        }
        public string CalculatingLog1
        {
            get { return _CalculatingLog1; }
            set { _CalculatingLog1 = value; }
        }
        public string CalculatingLog2
        {
            get { return _CalculatingLog2; }
            set { _CalculatingLog2 = value; }
        }
        public string CalculatingLog3
        {
            get { return _CalculatingLog3; }
            set { _CalculatingLog3 = value; }
        }
        public double FinalConversionLNSCoefficient
        {
            get { return _FinalConversionLNSCoefficient; }
            set { _FinalConversionLNSCoefficient = value; }
        }
        public string FinalConversionLNSCoefficientLog
        {
            get { return _FinalConversionLNSCoefficientLog; }
            set { _FinalConversionLNSCoefficientLog = value; }
        }
        public decimal LNSBalance
        {
            get { return _LNSBalance; }
            set { _LNSBalance = value; }
        }
        public decimal BonusBalance
        {
            get { return _BonusBalance; }
            set { _BonusBalance = value; }
        }
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }
        public bool Lock
        {
            get { return _Lock; }
            set { _Lock = value; }
        }               
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }
        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }


        public decimal TotalContributions
        {
            get { return _TotalContributions; }
            set { _TotalContributions = value; }
        }
        public decimal RealIncome
        {
            get { return _RealIncome; }
            set { _RealIncome = value; }
        }



        public string UserName
        {
            get
            {
                if (String.IsNullOrEmpty(_UserName))
                    return string.Empty;
                else
                    return _UserName;
            }
            set { _UserName = value; }
        }

        public String EmployeeCode
        {
            get
            {
                if (String.IsNullOrEmpty(_EmployeeCode))
                    return string.Empty;
                else
                    return _EmployeeCode;
            }
            set { _EmployeeCode = value; }
        }
      
        public string FullName
        {
            get
            {
                if (String.IsNullOrEmpty(_FullName))
                    return string.Empty;
                else
                    return _FullName;
            }
            set { _FullName = value; }
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



        public decimal TotalLNS
        {
            get { return _TotalLNS; }
            set { _TotalLNS = value; }
        }

        public decimal TotalLCBNN
        {
            get { return _TotalLCBNN; }
            set { _TotalLCBNN = value; }
        }

        public decimal TotalPCCV
        {
            get { return _TotalPCCV; }
            set { _TotalPCCV = value; }
        }

        public decimal TotalPCTN
        {
            get { return _TotalPCTN; }
            set { _TotalPCTN = value; }
        }

        public decimal TotalPCDH
        {
            get { return _TotalPCDH; }
            set { _TotalPCDH = value; }
        }

        public decimal TotalTCBHXH
        {
            get { return _TotalTCBHXH; }
            set { _TotalTCBHXH = value; }
        }

        public decimal TotalTienAn
        {
            get { return _TotalTienAn; }
            set { _TotalTienAn = value; }
        }

        public decimal TotalBoSungLuong
        {
            get { return _TotalBoSungLuong; }
            set { _TotalBoSungLuong = value; }
        }

        public decimal TotalTienThemGio
        {
            get { return _TotalTienThemGio; }
            set { _TotalTienThemGio = value; }
        }

        public decimal TotalTienLamDem
        {
            get { return _TotalTienLamDem; }
            set { _TotalTienLamDem = value; }
        }

        public decimal TotalTienThuong
        {
            get { return _TotalTienThuong; }
            set { _TotalTienThuong = value; }
        }

        public decimal TotalTrBHXH
        {
            get { return _TotalTrBHXH; }
            set { _TotalTrBHXH = value; }
        }

        public decimal TotalTrBHYT
        {
            get { return _TotalTrBHYT; }
            set { _TotalTrBHYT = value; }
        }
        public decimal TotalTrBHTN
        {
            get { return _TotalTrBHTN; }
            set { _TotalTrBHTN = value; }
        }
        public decimal TotalTrDoanPhi
        {
            get { return _TotalTrDoanPhi; }
            set { _TotalTrDoanPhi = value; }
        }

        public decimal TotalThueThuNhap
        {
            get { return _TotalThueThuNhap; }
            set { _TotalThueThuNhap = value; }
        }

        public decimal TotalTotalIncome
        {
            get { return _TotalTotalIncome; }
            set { _TotalTotalIncome = value; }
        }

        public decimal TotalTotalIncomeForTax
        {
            get { return _TotalTotalIncomeForTax; }
            set { _TotalTotalIncomeForTax = value; }
        }

        public decimal TotalTotalShortTerm
        {
            get { return _TotalTotalShortTerm; }
            set { _TotalTotalShortTerm = value; }
        }

        public decimal TotalTotalPeriod_I
        {
            get { return _TotalTotalPeriod_I; }
            set { _TotalTotalPeriod_I = value; }
        }

        public decimal TotalTotalPeriod_II
        {
            get { return _TotalTotalPeriod_II; }
            set { _TotalTotalPeriod_II = value; }
        }

        public decimal TotalLNSBalance
        {
            get { return _TotalLNSBalance; }
            set { _TotalLNSBalance = value; }
        }

        public decimal TotalBonusBalance
        {
            get { return _TotalBonusBalance; }
            set { _TotalBonusBalance = value; }
        }

        public decimal TotalTotalContributions
        {
            get { return _TotalTotalContributions; }
            set { _TotalTotalContributions = value; }
        }

        public decimal TotalRealIncome
        {
            get { return _TotalRealIncome; }
            set { _TotalRealIncome = value; }
        }


        #endregion
      
        
        #region methods insert, update, delete

        public static long InsertShortTerm(int userId, decimal lNS, decimal lCBNN, decimal pCCV, decimal pCTN,
                decimal pCDH, decimal tCBHXH, decimal tienAn, decimal tienThemGio, decimal tienLamDem, decimal TotalShortTerm,
                string calculatingLog1, int isChangeContract, string remark, DateTime createDate, decimal tCOm, decimal tCTS1Lan, int type)
        {
            return new IncomesDAL().InsertShortTerm(userId, lNS, lCBNN, pCCV, pCTN,
                pCDH, tCBHXH, tienAn, tienThemGio, tienLamDem, TotalShortTerm,
                calculatingLog1, isChangeContract, remark, createDate, tCOm, tCTS1Lan, type);
        }

        public static long UpdateByPeriod_II(decimal lNS,
                    decimal boSungLuong,
                    decimal tienThuong,
                    decimal trBHXH,
                    decimal trBHYT,
                    decimal trDoanPhi,
                    decimal thueThuNhap,
                    decimal totalIncome,
                    decimal totalIncomeForTax,
                    string calculatingLog2,
                    bool Lock,
                    string remark,                    
                    long incomeId,
                    int userId,
                    System.DateTime createDate,
                    decimal totalPeriod_I,
                    double finalConversionLNSCoefficient,
                    string finalConversionLNSCoefficientLog,
                    decimal trBHTN
                    )
        {
            return new IncomesDAL().UpdateByPeriod_II(lNS, boSungLuong, tienThuong, trBHXH, trBHYT, trDoanPhi, thueThuNhap, totalIncome,
                    totalIncomeForTax, calculatingLog2, Lock, remark, incomeId, userId, createDate, totalPeriod_I, finalConversionLNSCoefficient, finalConversionLNSCoefficientLog, trBHTN);
        }

        public static long UpdateByPeriod_III(decimal lNSBalance,
                    decimal bonusBalance,                   
                    string calculatingLog3,
                    long incomeId,
                    int userId,
                    System.DateTime createDate)
        {
            return new IncomesDAL().UpdateByPeriod_III(lNSBalance, bonusBalance, calculatingLog3, incomeId, userId, createDate);
        }

        public static long DeleteByDeptIdsDate(int rootId, int month, int year)
        {
            return new IncomesDAL().DeleteByRootDate(rootId, month, year);
        }

        #endregion


        #region methods get

        public static List<IncomesBLL> GetAllByFilter(string fullName, int departmentId, int month, int year, string sortParameter)
        {           
            List<IncomesBLL> list = GenerateListIncomesBLLFromDataTable(new IncomesDAL().GetByFilter(fullName, departmentId, month, year));

            if (!String.IsNullOrEmpty(sortParameter))
                list.Sort(new IncomesBLLComparer(sortParameter));

            return list;
        }

        public static List<IncomesBLL> GetByFilter1(int rootId, int month, int year, int type)
        {
            List<IncomesBLL> list = GenerateListIncomesBLLFromDataTable(new IncomesDAL().GetByFilter1(rootId, month, year, type));
            return list;
        }

        public static IncomesBLL GetByUserIdAndDate(int userId, int month, int year)
        {
            List<IncomesBLL> list = GenerateListIncomesBLLFromDataTable(new IncomesDAL().GetByUserIdAndDate(userId, month, year));
            if (list.Count == 1)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public static List<IncomesBLL> GetByUserIdAndDate1(int userId, int month, int year)
        {
            return GenerateListIncomesBLLFromDataTable(new IncomesDAL().GetByUserIdAndDate(userId, month, year));
        }

        public static IncomesBLL GetByRootDateForTotal(int rootId, int month, int year)
        {
            List<IncomesBLL> list = GenerateListIncomesBLLFromDataTableForTotal(new IncomesDAL().GetByRootDateForTotal(rootId, month, year));

            return list.Count == 1 ? list[0] : null;
        }

        #endregion


        #region private methods

        private static List<IncomesBLL> GenerateListIncomesBLLFromDataTable(DataTable dt)
        {
            List<IncomesBLL> list = new List<IncomesBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateIncomesBLLFromDataRow(dr));
            }

            return list;
        }
        
        private static IncomesBLL GenerateIncomesBLLFromDataRow(DataRow dr)
        {
            IncomesBLL objBLL = new IncomesBLL();

            #region infor for employees

            try
            {
                objBLL.UserId = dr[EmployeeKeys.FIELD_EMPLOYEES_USERID] == DBNull.Value ? 0 : Convert.ToInt32(dr[EmployeeKeys.FIELD_EMPLOYEES_USERID].ToString());
            }
            catch { }
            try
            {
                objBLL.EmployeeCode = dr[EmployeeKeys.FIELD_EMPLOYEES_EMPLOYEE_CODE] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_EMPLOYEE_CODE].ToString();
            }
            catch { }
            try
            {
                objBLL.UserName = dr[EmployeeKeys.FIELD_EMPLOYEES_USERNAME] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_USERNAME].ToString();
            }
            catch { }
            try
            {
                objBLL.FullName = dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME].ToString();
            }
            catch { }
            try
            {
                objBLL.PositionName = dr[PositionKeys.FIELD_POSITION_NAME] == DBNull.Value ? string.Empty : dr[PositionKeys.FIELD_POSITION_NAME].ToString();
            }
            catch { }
            try
            {
                objBLL.DepartmentName = dr[DepartmentKeys.FIELD_DEPARTMENT_NAME] == DBNull.Value ? string.Empty : dr[DepartmentKeys.FIELD_DEPARTMENT_NAME].ToString();
            }
            catch { }
            try
            {
                objBLL.DepartmentFullName = dr[DepartmentKeys.Field_Department_DepartmentFullName] == DBNull.Value ? string.Empty : dr[DepartmentKeys.Field_Department_DepartmentFullName].ToString();
            }
            catch { }
            try
            {
                objBLL.RootName = dr[DepartmentKeys.Field_Department_RootName] == DBNull.Value ? string.Empty : dr[DepartmentKeys.Field_Department_RootName].ToString();
            }
            catch { }

            #endregion

            objBLL.IncomeId = dr[IncomeKeys.Field_Income_ID] == DBNull.Value ? 0 : long.Parse(dr[IncomeKeys.Field_Income_ID].ToString());
            objBLL.LNS = dr[IncomeKeys.Field_Income_LNS] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_LNS].ToString());
            objBLL.LCBNN = dr[IncomeKeys.Field_Income_LCBNN] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_LCBNN].ToString());
            objBLL.PCCV = dr[IncomeKeys.Field_Income_PCCV] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_PCCV].ToString());
            objBLL.PCTN = dr[IncomeKeys.Field_Income_PCTN] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_PCTN].ToString());
            objBLL.PCDH = dr[IncomeKeys.Field_Income_PCDH] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_PCDH].ToString());

            objBLL.TCBHXH = dr[IncomeKeys.Field_Income_TCBHXH] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TCBHXH].ToString());
            objBLL.TCOm = dr[IncomeKeys.Field_Income_TCOm] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TCOm].ToString());
            objBLL.TCTS1Lan = dr[IncomeKeys.Field_Income_TCTS1Lan] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TCTS1Lan].ToString());

            objBLL.TienAn = dr[IncomeKeys.Field_Income_TienAn] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TienAn].ToString());
            objBLL.BoSungLuong = dr[IncomeKeys.Field_Income_BoSungLuong] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_BoSungLuong].ToString());
            
            objBLL.TienThemGio = dr[IncomeKeys.Field_Income_TienThemGio] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TienThemGio].ToString());
            objBLL.TienLamDem = dr[IncomeKeys.Field_Income_TienLamDem] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TienLamDem].ToString());
            objBLL.TienThuong = dr[IncomeKeys.Field_Income_TienThuong] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TienThuong].ToString());

            objBLL.TrBHXH = dr[IncomeKeys.Field_Income_TrBHXH] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TrBHXH].ToString());
            objBLL.TrBHYT = dr[IncomeKeys.Field_Income_TrBHYT] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TrBHYT].ToString());
            objBLL.TrBHTN = dr[IncomeKeys.Field_Income_TrBHTN] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TrBHTN].ToString());
            objBLL.TrDoanPhi = dr[IncomeKeys.Field_Income_TrDoanPhi] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TrDoanPhi].ToString());
            objBLL.ThueThuNhap = dr[IncomeKeys.Field_Income_ThueThuNhap] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_ThueThuNhap].ToString());                       
            
            objBLL.TotalIncome = dr[IncomeKeys.Field_Income_TotalIncome] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalIncome].ToString());
            objBLL.TotalIncomeForTax = dr[IncomeKeys.Field_Income_TotalIncomeForTax] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalIncomeForTax].ToString());
                                    
            objBLL.TotalContributions = objBLL.TrBHXH + objBLL.TrBHYT + objBLL.TrDoanPhi + objBLL.ThueThuNhap;
            //objBLL.RealIncome = objBLL.TotalIncome - (objBLL.TotalContributions);

            objBLL.IsChangeContract = dr[IncomeKeys.Field_Income_IsChangeContract] == DBNull.Value ? 0 : int.Parse(dr[IncomeKeys.Field_Income_IsChangeContract].ToString());
            objBLL.TotalShortTerm = dr[IncomeKeys.Field_Income_TotalShortTerm] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalShortTerm].ToString());
            objBLL.TotalPeriod_I = dr[IncomeKeys.Field_Income_TotalPeriod_I] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalPeriod_I].ToString());
            objBLL.TotalPeriod_II = dr[IncomeKeys.Field_Income_TotalPeriod_II] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalPeriod_II].ToString());

            objBLL.CalculatingLog1 = dr[IncomeKeys.Field_Income_CalculatingLog1] == DBNull.Value ? string.Empty : dr[IncomeKeys.Field_Income_CalculatingLog1].ToString();
            objBLL.CalculatingLog2 = dr[IncomeKeys.Field_Income_CalculatingLog2] == DBNull.Value ? string.Empty : dr[IncomeKeys.Field_Income_CalculatingLog2].ToString();
            objBLL.CalculatingLog3 = dr[IncomeKeys.Field_Income_CalculatingLog3] == DBNull.Value ? string.Empty : dr[IncomeKeys.Field_Income_CalculatingLog3].ToString();

            objBLL.LNSBalance = dr[IncomeKeys.Field_Income_LNSBalance] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_LNSBalance].ToString());
            objBLL.BonusBalance = dr[IncomeKeys.Field_Income_BonusBalance] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_BonusBalance].ToString());

            objBLL.FinalConversionLNSCoefficient = dr[IncomeKeys.Field_Income_FinalConversionLNSCoefficient] == DBNull.Value ? 0 : double.Parse(dr[IncomeKeys.Field_Income_FinalConversionLNSCoefficient].ToString());
            objBLL.FinalConversionLNSCoefficientLog = dr[IncomeKeys.Field_Income_FinalConversionLNSCoefficientLog] == DBNull.Value ? string.Empty : dr[IncomeKeys.Field_Income_FinalConversionLNSCoefficientLog].ToString();

            objBLL.CreateDate = dr[IncomeKeys.Field_Income_CREATE_DATE] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[IncomeKeys.Field_Income_CREATE_DATE].ToString());
            objBLL.Lock = dr[IncomeKeys.Field_Income_LOCK] == DBNull.Value ? false : Convert.ToBoolean(dr[IncomeKeys.Field_Income_LOCK].ToString());                        
            objBLL.Remark = dr[IncomeKeys.Field_Income_Remark] == DBNull.Value ? string.Empty : dr[IncomeKeys.Field_Income_Remark].ToString();
            objBLL.Type = dr[IncomeKeys.Field_Income_Type] == DBNull.Value ? 0 : int.Parse(dr[IncomeKeys.Field_Income_Type].ToString());

            return objBLL;
        }

        private static List<IncomesBLL> GenerateListIncomesBLLFromDataTableForTotal(DataTable dt)
        {
            List<IncomesBLL> list = new List<IncomesBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateIncomesBLLFromDataRowForTotal(dr));
            }

            return list;
        }


        private static IncomesBLL GenerateIncomesBLLFromDataRowForTotal(DataRow dr)
        {
            IncomesBLL objBLL = new IncomesBLL();


            objBLL.TotalLNS = dr[IncomeKeys.Field_Income_TotalLNS] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalLNS].ToString());
            objBLL.TotalLCBNN = dr[IncomeKeys.Field_Income_TotalLCBNN] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalLCBNN].ToString());
            objBLL.TotalPCCV = dr[IncomeKeys.Field_Income_TotalPCCV] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalPCCV].ToString());
            objBLL.TotalPCTN = dr[IncomeKeys.Field_Income_TotalPCTN] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalPCTN].ToString());
            objBLL.TotalPCDH = dr[IncomeKeys.Field_Income_TotalPCDH] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalPCDH].ToString());

            objBLL.TotalTCBHXH = dr[IncomeKeys.Field_Income_TotalTCBHXH] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTCBHXH].ToString());
            objBLL.TotalTCOm = dr[IncomeKeys.Field_Income_TotalTCOm] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTCOm].ToString());
            objBLL.TotalTCTS1Lan = dr[IncomeKeys.Field_Income_TotalTCTS1Lan] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTCTS1Lan].ToString());

            objBLL.TotalTienAn = dr[IncomeKeys.Field_Income_TotalTienAn] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTienAn].ToString());
            objBLL.TotalBoSungLuong = dr[IncomeKeys.Field_Income_TotalBoSungLuong] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalBoSungLuong].ToString());

            objBLL.TotalTienThemGio = dr[IncomeKeys.Field_Income_TotalTienThemGio] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTienThemGio].ToString());
            objBLL.TotalTienLamDem = dr[IncomeKeys.Field_Income_TotalTienLamDem] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTienLamDem].ToString());
            objBLL.TotalTienThuong = dr[IncomeKeys.Field_Income_TotalTienThuong] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTienThuong].ToString());

            objBLL.TotalTrBHXH = dr[IncomeKeys.Field_Income_TotalTrBHXH] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTrBHXH].ToString());
            objBLL.TotalTrBHYT = dr[IncomeKeys.Field_Income_TotalTrBHYT] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTrBHYT].ToString());
            objBLL.TotalTrBHTN = dr[IncomeKeys.Field_Income_TotalTrBHTN] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTrBHTN].ToString());
            objBLL.TotalTrDoanPhi = dr[IncomeKeys.Field_Income_TotalTrDoanPhi] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTrDoanPhi].ToString());
            objBLL.TotalThueThuNhap = dr[IncomeKeys.Field_Income_TotalThueThuNhap] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalThueThuNhap].ToString());

            objBLL.TotalTotalIncome = dr[IncomeKeys.Field_Income_TotalTotalIncome] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTotalIncome].ToString());
            objBLL.TotalTotalIncomeForTax = dr[IncomeKeys.Field_Income_TotalTotalIncomeForTax] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTotalIncomeForTax].ToString());

            //objBLL.TotalTotalContributions = objBLL.TrBHXH + objBLL.TrBHYT + objBLL.TrDoanPhi + objBLL.ThueThuNhap;

            objBLL.TotalTotalShortTerm = dr[IncomeKeys.Field_Income_TotalTotalShortTerm] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTotalShortTerm].ToString());
            objBLL.TotalTotalPeriod_I = dr[IncomeKeys.Field_Income_TotalTotalPeriod_I] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTotalPeriod_I].ToString());
            objBLL.TotalTotalPeriod_II = dr[IncomeKeys.Field_Income_TotalTotalPeriod_II] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalTotalPeriod_II].ToString());


            objBLL.TotalLNSBalance = dr[IncomeKeys.Field_Income_TotalLNSBalance] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalLNSBalance].ToString());
            objBLL.TotalBonusBalance = dr[IncomeKeys.Field_Income_TotalBonusBalance] == DBNull.Value ? 0 : Convert.ToDecimal(dr[IncomeKeys.Field_Income_TotalBonusBalance].ToString());


            return objBLL;
        }

        #endregion

    }
}
