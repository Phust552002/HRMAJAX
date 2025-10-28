using System;
using System.Collections.Generic;

using HRMUtil.KeyNames.H0;

namespace HRMBLL.H0
{
    public class UnofficialEmployeesBLLComparer : IComparer<UnofficialEmployeesBLL>
    {
        private string _sortColumn;
        private bool _reverse;

        public UnofficialEmployeesBLLComparer(string sortEx)
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

        public bool Equals(UnofficialEmployeesBLL x, UnofficialEmployeesBLL y)
        {
            if (x.UserId == y.UserId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Compare(UnofficialEmployeesBLL x, UnofficialEmployeesBLL y)
        {
            int retVal = 0;
            switch (_sortColumn)
            {

                case EmployeeKeys.FIELD_EMPLOYEES_USERID:
                    retVal = (x.UserId - y.UserId);
                    break;
                case EmployeeKeys.FIELD_EMPLOYEES_FULLNAME:
                    retVal = String.Compare(x.FullName, y.FullName, StringComparison.InvariantCultureIgnoreCase);
                    break;
                case DepartmentKeys.Field_Department_DepartmentFullName:
                    retVal = String.Compare(x.DepartmentFullName, y.DepartmentFullName, StringComparison.InvariantCultureIgnoreCase);
                    break;
                case DepartmentKeys.FIELD_DEPARTMENT_ROOT_ID:
                    retVal = (x.RootId - y.RootId);
                    break;
                case EmployeeKeys.FIELD_EMPLOYEES_JOINDATE:
                    retVal = DateTime.Compare(x.JoinDate, y.JoinDate);
                    break;
                case EmployeeKeys.FIELD_EMPLOYEES_LeaveDate:
                    retVal = DateTime.Compare(x.LeaveDate, y.LeaveDate);
                    break;
            }
            return (retVal * (_reverse ? -1 : 1));
        }

        public int GetHashCode(UnofficialEmployeesBLL obj)
        {
            // TODO: Implement this, but it's not necessary for sorting
            return 0;
        }
    }
}
