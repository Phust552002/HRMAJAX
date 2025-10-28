using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

using HRMDAL.Utilities;
using HRMDAL.H;
using HRMUtil.KeyNames.H;
using HRMUtil.KeyNames.H0;
using HRMBLL.H.Helper;

namespace HRMBLL.H
{
    public class EmployeeIncomeBLL
    {
        
        #region private fields

        private int _EmployeeIncomeId;
        private int _UserId;
       
        private string _UserName;
        private string _EmployeeCode;
       
        private string _FullName;
        private DateTime  _Date;
        private decimal _Total_Inc;
        private decimal _Total_Cntr;
        private decimal _Total_Real;
        private decimal _Total_Inc_LK;
        private decimal _Total_Cntr_LK;
        private decimal _RealIncome;

        private string _AccountNo;
        private string _CardNo;

        private int _DepartmentId;

        private string _DepartmentName;
        /// <summary>
        /// //////////////////
        /// </summary>
        /// 


        private decimal _LNS;
        private decimal _TienAn;
        private decimal _BoSungLuong;
        private decimal _TienThuong;
        private decimal _ThueThuNhap;

        #endregion

        #region properties

        public int EmployeeIncomeId
        {
            get { return _EmployeeIncomeId; }
            set { _EmployeeIncomeId = value; }
        }

        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
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
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public decimal Total_Inc
        {
            get { return _Total_Inc; }
            set { _Total_Inc = value; }
        }
        public decimal Total_Cntr
        {
            get { return _Total_Cntr; }
            set { _Total_Cntr = value; }
        }
        public decimal Total_Real
        {
            get { return _Total_Real; }
            set { _Total_Real = value; }
        }

        public decimal Total_Inc_LK
        {
            get { return _Total_Inc_LK; }
            set { _Total_Inc_LK = value; }
        }
        public decimal Total_Cntr_LK
        {
            get { return _Total_Cntr_LK; }
            set { _Total_Cntr_LK = value; }
        }
        public decimal RealIncome
        {
            get { return _RealIncome; }
            set { _RealIncome = value; }
        }

        public string AccountNo
        {
            get { return _AccountNo; }
            set { _AccountNo = value; }
        }
        public string CardNo
        {
            get { return _CardNo; }
            set { _CardNo = value; }
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

        public decimal LNS
        {
            get { return _LNS; }
            set { _LNS = value; }
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
        public decimal TienThuong
        {
            get { return _TienThuong; }
            set { _TienThuong = value; }
        }
        public decimal ThueThuNhap
        {
            get { return _ThueThuNhap; }
            set { _ThueThuNhap = value; }
        }

        #endregion

        #region constructor

        public EmployeeIncomeBLL(int employeeIncomeId, int userId, DateTime date, decimal total_Inc, decimal total_Cntr, decimal total_Inc_LK, decimal total_Cntr_LK)
        {
            _EmployeeIncomeId = employeeIncomeId;
            _UserId = userId;
            _Date = date;
            _Total_Inc = total_Inc;
            _Total_Cntr = total_Cntr;
            _Total_Inc_LK = total_Inc_LK;
            _Total_Cntr_LK = total_Cntr_LK;
        }

        #endregion

        #region Import total

        public static long InsertByImporting(string userCode, double total_Inc, double total_Cntr, double total_Real, double total_Inc_LK, double total_Cntr_LK, DateTime date, int userId)
        {
            EmployeeIncomeDAL objDAL = new EmployeeIncomeDAL();
            return objDAL.Insert(userCode, total_Inc, total_Cntr, total_Real, total_Inc_LK, total_Cntr_LK, date, userId);
        }

        #endregion

        #region public methods Get

        public static EmployeeIncomeBLL GetByUserId_Monthly(int userId, int month, int year)
        {
            EmployeeIncomeDAL objDAL = new EmployeeIncomeDAL();

            DataTable dt = objDAL.GetByUserId_Monthly(userId, month, year);
            if (dt.Rows.Count > 0)
            {
                return GenerateEmployeeIncomeBLLFromDataRow(dt.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public static List<EmployeeIncomeBLL> GetByFilter(string fullName,int departmentId, int month, int year)
        {

            return GenerateListEmployeeIncomeBLLFromDataTable(new EmployeeIncomeDAL().GetByFilter(fullName, departmentId, month, year));
           
        }

        public static DataTable GetDTByFilter(string fullName, int departmentId, int month, int year)
        {

            return (new EmployeeIncomeDAL().GetByFilter(fullName, departmentId, month, year));

        }

        public static DataTable GetDTByFilter(string fullName, string departmentIds, int rootId, int month, int year)
        {
            return (new EmployeeIncomeDAL().GetByFilter(fullName, departmentIds, rootId, month, year));
        }

        public static List<EmployeeIncomeBLL> GetAllByFilter(string fullName, int departmentId, int month, int year)
        {

            return GenerateAllListEmployeeIncomeBLLFromDataTable(new EmployeeIncomeDAL().GetByFilter(fullName, departmentId, month, year));

        }


        public static DataTable GetStatisticTotalByFilter(string departmentIds, int rootId, int month, int year)
        {

            return new EmployeeIncomeDAL().GetStatisticTotalByFilter(departmentIds, rootId, month, year);

        }

        #endregion

        #region private methods, generate helper methods

        private static List<EmployeeIncomeBLL> GenerateAllListEmployeeIncomeBLLFromDataTable(DataTable dt)
        {
            List<EmployeeIncomeBLL> list = new List<EmployeeIncomeBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                EmployeeIncomeBLL obj = GenerateEmployeeIncomeBLLFromDataRow(dr);
                List<IncomesMonthBLL> listIM = IncomesMonthBLL.GetAllByUserId_Monthly(obj.UserId, obj.Date.Month, obj.Date.Year);
                foreach (IncomesMonthBLL objIM in listIM)
                {
                    switch (objIM.IncomeTypeId)
                    {
                        case 1:
                            obj.LNS = (decimal)objIM.Value;
                            break;
                        case 7:
                            obj.TienAn = (decimal)objIM.Value;
                            break;
                        case 8:
                            obj.BoSungLuong = (decimal)objIM.Value;
                            break;
                        case 11:
                            obj.TienThuong = (decimal)objIM.Value;
                            break;
                        case 18:
                            obj.ThueThuNhap = (decimal)objIM.Value;
                            break;
                    }

                    
                }
                list.Add(obj);
            }

            return list;
        }

        private static List<EmployeeIncomeBLL> GenerateListEmployeeIncomeBLLFromDataTable(DataTable dt)
        {
            List<EmployeeIncomeBLL> list = new List<EmployeeIncomeBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateEmployeeIncomeBLLFromDataRow(dr));
            }

            return list;
        }

        private static EmployeeIncomeBLL GenerateEmployeeIncomeBLLFromDataRow(DataRow dr)
        {
            EmployeeIncomeBLL objBLL = new EmployeeIncomeBLL(
            dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_ID] == DBNull.Value ? DefaultValues.EmployeeIncomeIdMinValue : Convert.ToInt32(dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_ID].ToString()),
            dr[EmployeeKeys.FIELD_EMPLOYEES_USERID] == DBNull.Value ? DefaultValues.UserIdMinValue : Convert.ToInt32(dr[EmployeeKeys.FIELD_EMPLOYEES_USERID].ToString()),
            dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_DATE] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_DATE].ToString()),
            dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_TOTAL_INC] == DBNull.Value ? 0 : Convert.ToDecimal(dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_TOTAL_INC].ToString()),
            dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_TOTAL_CNTR] == DBNull.Value ? 0 : Convert.ToDecimal(dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_TOTAL_CNTR].ToString()),
            dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_TOTAL_INC_LK] == DBNull.Value ? 0 : Convert.ToDecimal(dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_TOTAL_INC_LK].ToString()),
            dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_TOTAL_CNTR_LK] == DBNull.Value ? 0 : Convert.ToDecimal(dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_TOTAL_CNTR_LK].ToString())
            );

            objBLL.Total_Real = dr[EmployeeIncomeKeys.Field_Employee_Income_Total_Real] == DBNull.Value ? 0 : Convert.ToDecimal(dr[EmployeeIncomeKeys.Field_Employee_Income_Total_Real].ToString());

            objBLL.UserName = dr[EmployeeKeys.FIELD_EMPLOYEES_USERNAME] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_USERNAME].ToString();
            objBLL.FullName = dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME].ToString();
            objBLL.EmployeeCode = dr[EmployeeKeys.FIELD_EMPLOYEES_EMPLOYEE_CODE] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_EMPLOYEE_CODE].ToString();


            objBLL.RealIncome = dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_REAL_INCOME] == DBNull.Value ? 0 : Convert.ToDecimal(dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_REAL_INCOME].ToString());

            objBLL.AccountNo = dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_ACCOUNT_NO] == DBNull.Value ? string.Empty : dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_ACCOUNT_NO].ToString();
            objBLL.CardNo = dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_CARD_NO] == DBNull.Value ? string.Empty : dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_CARD_NO].ToString();

            objBLL.DepartmentId = dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_DEPARTMENT_ID] == DBNull.Value ? 0 : int.Parse(dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_DEPARTMENT_ID].ToString());
            objBLL.DepartmentName = dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_DEPARTMENT_NAME] == DBNull.Value ? string.Empty : dr[EmployeeIncomeKeys.FIELD_EMPLOYEE_INCOME_DEPARTMENT_NAME].ToString();
            
            return objBLL;
        }

        #endregion

    }
}
