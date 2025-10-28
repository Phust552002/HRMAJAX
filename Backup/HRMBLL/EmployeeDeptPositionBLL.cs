using System;
using System.Collections.Generic;
using System.Text;
using HRMDAL.HRMTableAdapters;
using HRMDAL;


namespace HRMBLL
{
   [System.ComponentModel.DataObject]
    public class EmployeeDeptPositionBLL
    {

        private EmployeeDeptPositionTableAdapter _employeeDeptPositionAdapter = null;
        protected EmployeeDeptPositionTableAdapter Adapter
        {
            get
            {
                if (_employeeDeptPositionAdapter == null)
                    _employeeDeptPositionAdapter = new EmployeeDeptPositionTableAdapter();

                return _employeeDeptPositionAdapter;
            }
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public HRM.EmployeeDeptPositionDataTable GetDepartmentStaffs(int departmentId)
        {
            return Adapter.GetDepartmentStaffs(departmentId);
        }

        public void DeleteEmployeeDeptPositionByUserId(int userId)
        {
            Adapter.Delete_EmployeeDeptPositionByUserId(userId);
        }
        public void UpdateEmployeeDeptPositionByUserId(int userId, int departmentId, int positionId)
        {
            Adapter.Update_EmployeeDeptPositionByUserId(departmentId, positionId, userId);
        }
        //public void AddNewEmployeeDeptPosition(int userId, int departmentId, int positionId)
        //{
        //    Adapter.AddNew_EmployeeDeptPosition(userId, departmentId, positionId);
        //}

        
    }
}
