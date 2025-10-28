using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H0;
using HRMUtil.KeyNames.H0;
using HRMDAL.H1;
using HRMUtil.KeyNames.H1;
using HRMBLL.H0.Helper;
using HRMUtil;
namespace HRMBLL.H0
{
    public class EmployeeContractCoefficientBLL
    {

        private int _EmployeeContractId;
        private int _LCB_CoefficientEmployeeId;
        private int _LNS_CoefficientEmployeeId;


        public int EmployeeContractId
        {
            get { return _EmployeeContractId; }
            set { _EmployeeContractId = value; }
        }
        public int LCB_CoefficientEmployeeId
        {
            get { return _LCB_CoefficientEmployeeId; }
            set { _LCB_CoefficientEmployeeId = value; }
        }
        public int LNS_CoefficientEmployeeId
        {
            get { return _LNS_CoefficientEmployeeId; }
            set { _LNS_CoefficientEmployeeId = value; }
        }

        public static long Insert(int employeeContractId, int lCB_CoefficientEmployeeId, int lNS_CoefficientEmployeeId)
        {
            return new EmployeeContractCoefficientDAL().Insert(employeeContractId, lCB_CoefficientEmployeeId, lNS_CoefficientEmployeeId);
        }

        public static long Delete(int employeeContractId, int lCB_CoefficientEmployeeId, int lNS_CoefficientEmployeeId)
        {
            return new EmployeeContractCoefficientDAL().Delete(employeeContractId, lCB_CoefficientEmployeeId, lNS_CoefficientEmployeeId);
        }
    }
}
