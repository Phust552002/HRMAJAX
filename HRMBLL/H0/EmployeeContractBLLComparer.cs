using System;
using System.Collections.Generic;

using HRMUtil.KeyNames.H0;

namespace HRMBLL.H0
{
    public class EmployeeContractBLLComparer : IComparer<EmployeeContractBLL>
    {
         private string _sortColumn;
        private bool _reverse;

        public EmployeeContractBLLComparer(string sortEx)
        {
            if (!String.IsNullOrEmpty(sortEx))
            {
                _reverse = sortEx.ToLowerInvariant().EndsWith(" desc");
                if (_reverse)
                    _sortColumn = sortEx.Substring(0, sortEx.Length - 5);
                else
                    _sortColumn = sortEx.Substring(0, sortEx.Length - 4);
            }
        }

        public bool Equals(EmployeeContractBLL x, EmployeeContractBLL y)
        {
            if (x.EmployeeContractId == y.EmployeeContractId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Compare(EmployeeContractBLL x, EmployeeContractBLL y)
        {
            int retVal = 0;
            switch (_sortColumn)
            {

                case ContractTypeKeys.Field_ContractTypes_ContractTypeName:
                    retVal = String.Compare(x.ContractTypeName, y.ContractTypeName, StringComparison.InvariantCultureIgnoreCase);
                    break;
                case EmployeeKeys.FIELD_EMPLOYEES_FULLNAME:
                    retVal = String.Compare(x.FullName, y.FullName, StringComparison.InvariantCultureIgnoreCase);
                    break;
                case PositionKeys.FIELD_POSITION_NAME:
                    retVal = String.Compare(x.PositionName, y.PositionName, StringComparison.InvariantCultureIgnoreCase);
                    break;
                case EmployeeContractKeys.Field_EmployeeContract_FromDate:
                    retVal = DateTime.Compare(x.FromDate, y.FromDate);
                    break;
                case EmployeeContractKeys.Field_EmployeeContract_ToDate:
                    retVal = DateTime.Compare(x.ToDate, y.ToDate);
                    break;
            }
            return (retVal * (_reverse ? -1 : 1));
        }

        public int GetHashCode(EmployeeContractBLL obj)
        {
            // TODO: Implement this, but it's not necessary for sorting
            return 0;
        }
    }
}
