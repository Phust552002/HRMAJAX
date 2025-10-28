using System;
using System.Collections.Generic;
using System.Text;
using HRMDAL.HRMTableAdapters;
using HRMDAL;

namespace HRMBLL
{
    [System.ComponentModel.DataObject]
    public class DepartmentsBLL
    {

        private DepartmentsTableAdapter _DepartmentsAdapter = null;
        protected DepartmentsTableAdapter Adapter

        {
            get
            {
                if (_DepartmentsAdapter == null)
                    _DepartmentsAdapter = new DepartmentsTableAdapter();

                return _DepartmentsAdapter;
            }
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public HRM.DepartmentsDataTable GetAllDepartments()
        {
            return Adapter.GetAllDepartments();
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public int AddNewDepartment(string departmentName, string description)
        {
            return Adapter.AddNewDepartment(departmentName, description);
        }

    }
}
