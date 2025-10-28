using System;
using System.Text;

namespace HRMUtil.KeyNames.H0
{
    public sealed class DepartmentKeys
    {
        #region some field names of Departments table

        public const string FIELD_DEPARTMENT_ID = "DepartmentId";
        public const string FIELD_DEPARTMENT_CODE = "DepartmentCode";
        public const string FIELD_DEPARTMENT_NAME = "DepartmentName";
        public const string FIELD_DEPARTMENT_NAME_E = "DepartmentNameE";
        public const string FIELD_DEPARTMENT_DESCRIPTION = "Description";
        public const string Field_Department_Level = "Level";
        public const string FIELD_DEPARTMENT_PARENT_ID = "ParentId";
        public const string FIELD_DEPARTMENT_ROOT_ID = "RootId";
        public const string Field_Department_RootName = "RootName";
        public const string Field_Department_Status = "Status";
        public const string FIELD_DEPARTMENT_CHILD_NODE_COUNT = "ChildNodeCount";
        public const string Field_Department_DepartmentFullName = "DepartmentFullName";
        public const string Field_Department_DepartmentFullName2 = "DepartmentFullName2";
        public const string Field_Department_Direct = "Direct";

        #endregion

        #region some store procedures of Department table

        public const string SP_DEPARTMENT_INSERT = "Ins_H0_Department";
        public const string SP_DEPARTMENT_UPDATE = "Upd_H0_Department";
        public const string SP_DEPARTMENT_DELETE = "Del_H0_Department";


        //public const string SP_DEPARTMENT_GETALL = "Sel_H0_Departments_All";

        public const string SP_DEPARTMENT_GET_ALL = "Sel_H0_Departments_All";
        public const string SP_DEPARTMENT_GET_ALL_ROOT = "Sel_H0_Departments_All_Root";
        public const string SP_DEPARTMENT_GET_ROOT = "Sel_H0_Departments_Root";
        public const string SP_DEPARTMENT_GETALL_SUB_LEVEL = "Sel_H0_Departments_SubLevel";
        public const string Sp_Departments_SubLevel_By_RootId_DepartmentId = "Sel_H0_Departments_SubLevel_By_RootId_DepartmentId";
        public const string SP_DEPARTMENT_GET_ROOT_BY_SUB_ID = "Sel_H0_Departments_Root_BySubId";
        public const string SP_DEPARTMENT_GET_BY_ID = "Sel_H0_Departments_By_Id";
        public const string Sp_Sel_H0_Departments_By_Ids = "Sel_H0_Departments_By_Ids";
        public const string SP_DEPARTMENT_GET_BY_IDS_ROOTID = "Sel_H0_Departments_By_Ids_RootId";

        public const string Sp_Sel_H0_Departments_By_RootId = "Sel_H0_Departments_By_RootId";

        #endregion

    }
}
