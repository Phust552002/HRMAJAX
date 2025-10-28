using System;
using System.Text;

namespace HRMUtil.KeyNames.H0
{
    public sealed class UnofficialDepartmentKeys
    {
        #region some field names of UnofficialDepartments table

        public const string FIELD_UNOFFICIAL_DEPARTMENT_ID = "DepartmentId";
        public const string FIELD_UNOFFICIAL_DEPARTMENT_CODE = "DepartmentCode";
        public const string FIELD_UNOFFICIAL_DEPARTMENT_NAME = "DepartmentName";
        public const string FIELD_UNOFFICIAL_DEPARTMENT_NAME_E = "DepartmentNameE";
        public const string FIELD_UNOFFICIAL_DEPARTMENT_DESCRIPTION = "Description";
        public const string FIELD_UNOFFICIAL_DEPARTMENT_LEVEL = "Level";
        public const string FIELD_UNOFFICIAL_DEPARTMENT_PARENT_ID = "ParentId";
        public const string FIELD_UNOFFICIAL_DEPARTMENT_ROOT_ID = "RootId";
        public const string FIELD_UNOFFICIAL_DEPARTMENT_ROOTNAME = "RootName";
        public const string FIELD_UNOFFICIAL_DEPARTMENT_STATUS = "Status";
        public const string FIELD_UNOFFICIAL_DEPARTMENT_CHILD_NODE_COUNT = "ChildNodeCount";
        public const string FIELD_UNOFFICIAL_DEPARTMENT_DEPARTMENTFULLNAME = "DepartmentFullName";
        public const string FIELD_UNOFFICIAL_DEPARTMENT_DEPARTMENTFULLNAME2 = "DepartmentFullName2";
        public const string FIELD_UNOFFICIAL_DEPARTMENT_DIRECT = "DirectWorking";

        #endregion

        #region some store procedures of UnofficialDepartment table

        public const string SP_UNOFFICIAL_DEPARTMENT_GET_ALL_ROOT = "Sel_H0_Unofficial_Departments_All_Root";
        public const string SP_UNOFFICIAL_DEPARTMENT_GET_ROOT = "Sel_H0_Unofficial_Departments_Root";
        public const string SP_UNOFFICIAL_DEPARTMENT_GETALL_SUB_LEVEL = "Sel_H0_Unofficial_Departments_SubLevel";
        public const string SP_UNOFFICIAL_DEPARTMENTS_SUBLEVEL_BY_ROOTID_DEPARTMENTID = "Sel_H0_Unofficial_Departments_SubLevel_By_RootId_DepartmentId";
        public const string SP_SEL_H0_UNOFFICIAL_DEPARTMENTS_BY_IDS = "Sel_H0_Unofficial_Departments_By_Ids";

        #endregion

    }
}
