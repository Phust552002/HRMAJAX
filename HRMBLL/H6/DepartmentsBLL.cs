using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HRMDAL.H6;
using HRMUtil.KeyNames.H6;
using HRMBLL.H0.Helper;
namespace HRMBLL.H6
{
    public class DepartmentsBLL
    {
        #region private fields

        private int _DepartmentId;
       
        private string _DepartmentName;
       
        
        private string _Description;
        private int _ParentId;
        private int _ChildNodeCount;
        private int _RootId;
        private string _ChildNodeIds = "";
        private int _Level;

        private string _DepartmentFullName;
 
        private string _RootName;

        private int _Status = 0;
       

        #endregion


        #region properties

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
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public int ParentId
        {
            get { return _ParentId; }
            set { _ParentId = value; }
        }

        public int ChildNodeCount
        {
            get { return _ChildNodeCount; }
            set { _ChildNodeCount = value; }
        }
        public int Level
        {
            get { return _Level; }
            set { _Level = value; }
        }
        public int RootId
        {
            get { return _RootId; }
            set { _RootId = value; }
        }

        public string ChildNodeIds
        {
            get
            {
                string ids = _ChildNodeIds;
                if (ids != null && ids.Length > 0)
                {
                    ids = _ChildNodeIds.Substring(0, _ChildNodeIds.Length - 1);
                }
                return ids;
            }
            set { _ChildNodeIds = value; }
        }

        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }


        #endregion

        #region constructors

        public DepartmentsBLL() { }

        public DepartmentsBLL(int departmentId, string departmentName)
        {
            _DepartmentId = departmentId;
            _DepartmentName = departmentName;
        }

        #endregion

        #region public methods insert, update, delete

        public long Save()
        {
            DepartmentsDAL objDAL = new DepartmentsDAL();
            if (DepartmentId <= 0)
            {
                return objDAL.Insert(ParentId, DepartmentName, _Description);
            }
            else
            {
                return objDAL.Update(_DepartmentName, _Description, DepartmentId);
            }

        }

        public static long Delete(int departmentId)
        {
            DepartmentsDAL objDAL = new DepartmentsDAL();
            return objDAL.Delete(departmentId);
        }
        #endregion

        #region public static Get methods

        public static List<DepartmentsBLL> GetIndirectRoot()
        {
            return GenerateListDepartmentFromDataTable(new DepartmentsDAL().GetAllRoots(1));
        }

        public static List<DepartmentsBLL> GetAllRoots()
        {
            return GenerateListDepartmentFromDataTable(new DepartmentsDAL().GetAllRoots(0));
        }
        public static List<DepartmentsBLL> GetAllRootsNoSAGS()
        {
            return GenerateListDepartmentFromDataTableNoSAGS(new DepartmentsDAL().GetAllRoots(0));
        }


        public static List<DepartmentsBLL> GetAllDepartments()
        {
            return GenerateListDepartmentFromDataTable(new DepartmentsDAL().GetAllDepartments());
        }


        public static List<DepartmentsBLL> GetDepartmentRoot()
        {
            return GenerateListDepartmentFromDataTable(new DepartmentsDAL().GetDepartmentRoot());
        }

        public void GetAllChildId(int parentId)
        {
            DataTable dt = new DepartmentsDAL().GetDepartmentSubLevel(parentId);
            foreach (DataRow dr in dt.Rows)
            {            
                int id = dr[DepartmentKeys.FIELD_DEPARTMENT_ID] == DBNull.Value ? 0 : int.Parse(dr[DepartmentKeys.FIELD_DEPARTMENT_ID].ToString());
                _ChildNodeIds += id + ",";
                GetAllChildId(id);
            }

        }
        public void GetAllLeafId(int parentId)
        {
            DataTable dt = new DepartmentsDAL().GetDepartmentSubLevel(parentId);
            foreach (DataRow dr in dt.Rows)
            {
                int id = dr[DepartmentKeys.FIELD_DEPARTMENT_ID] == DBNull.Value ? 0 : int.Parse(dr[DepartmentKeys.FIELD_DEPARTMENT_ID].ToString());
                if (new DepartmentsDAL().GetDepartmentSubLevel(id).Rows.Count <= 0)
                    _ChildNodeIds += id + ",";

                GetAllChildId(id);
            }
        }

        public static List<DepartmentsBLL> GetAll_SubLevel(int parentId)
        {
            return GenerateListDepartmentFromDataTable(new DepartmentsDAL().GetDepartmentSubLevel(parentId));
        }
        public static List<DepartmentsBLL> GetAll_SubLevel_ByRootIdDepartmentId(int parentId, int rootId, int departmentId)
        {
            return GenerateListDepartmentFromDataTable(new DepartmentsDAL().GetDepartmentSubLevelByRootIdDepartmentId(parentId, rootId, departmentId));
        }

        public static string GetDepartmentNameByDeptId(int departmentId)
        {
            string departmentName = string.Empty;
            int parentId = 0;
            DepartmentsBLL objBLL = GetById(departmentId);
            if (objBLL != null)
            {
                parentId = objBLL.ParentId;
                departmentName += objBLL.DepartmentName;
                while (parentId != -1)
                {
                    objBLL = GetById(parentId);
                    parentId = objBLL.ParentId;
                    departmentName += objBLL.DepartmentName;
                }
            }
            return departmentName;
        }

        public static DepartmentsBLL GetRootBySubId(int subId)
        {
            List<DepartmentsBLL> list = GenerateListDepartmentFromDataTable(new DepartmentsDAL().GetDepartmentRootBySub(subId));
            if (list.Count == 1)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public static DepartmentsBLL GetById(int departmentId)
        {
            List<DepartmentsBLL> list = GenerateListDepartmentFromDataTable(new DepartmentsDAL().GetById(departmentId));
            if (list.Count == 1)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public static List<DepartmentsBLL> GetByIds(string departmentIds)
        {
            return GenerateListDepartmentFromDataTable(new DepartmentsDAL().GetByIds(departmentIds));
        }

        public static string GetDepartmentNamesByIdsRootId(string departmentIds, int rootId, string dash, string separator)
        {
            List<DepartmentsBLL> list = new List<DepartmentsBLL>();
            list = GenerateListDepartmentFromDataTable(new DepartmentsDAL().GetByIdsRoot(departmentIds, rootId));
            return GetDepartmentNames(list, dash, separator);
        }

        private static string GetDepartmentNames(List<DepartmentsBLL> list, string dash, string separator)
        {

            string departmentNames = string.Empty;
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    DepartmentsBLL obj = list[i];
                    if (i < list.Count - 1)
                    {
                        departmentNames += dash + obj.DepartmentName + separator;
                    }
                    else
                    {
                        departmentNames += dash + obj.DepartmentName;
                    }
                }
            }
            return departmentNames;
        }

        public static List<DepartmentsBLL> GetByRoot(int rootId)
        {
            return GenerateListDepartmentFromDataTable(new DepartmentsDAL().GetByRoot(rootId));
        }

        #endregion

        #region private methods


        private static List<DepartmentsBLL> GenerateListDepartmentFromDataTableNoSAGS(DataTable dt)
        {
            List<DepartmentsBLL> lstDepartments = new List<DepartmentsBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                DepartmentsBLL obj = GenerateDepartmentFromDataRow(dr);
                if (obj.DepartmentId > 0)
                {
                    lstDepartments.Add(obj);
                }
            }

            return lstDepartments;
        }

        private static List<DepartmentsBLL> GenerateListDepartmentFromDataTable(DataTable dt)
        {
            List<DepartmentsBLL> lstDepartments = new List<DepartmentsBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                lstDepartments.Add(GenerateDepartmentFromDataRow(dr));
            }

            return lstDepartments;
        }

        private static DepartmentsBLL GenerateDepartmentFromDataRow(DataRow dr)
        {
            DepartmentsBLL objBLL = new DepartmentsBLL(
                dr[DepartmentKeys.FIELD_DEPARTMENT_ID] == DBNull.Value ? DefaultValues.DepartmentIdMinValue : int.Parse(dr[DepartmentKeys.FIELD_DEPARTMENT_ID].ToString()),
                dr[DepartmentKeys.FIELD_DEPARTMENT_NAME] == DBNull.Value ? string.Empty : dr[DepartmentKeys.FIELD_DEPARTMENT_NAME].ToString()
                );

            objBLL._ParentId = dr[DepartmentKeys.FIELD_DEPARTMENT_PARENT_ID] == DBNull.Value ? 0 : int.Parse(dr[DepartmentKeys.FIELD_DEPARTMENT_PARENT_ID].ToString());
            objBLL._Description = dr[DepartmentKeys.FIELD_DEPARTMENT_DESCRIPTION] == DBNull.Value ? string.Empty : dr[DepartmentKeys.FIELD_DEPARTMENT_DESCRIPTION].ToString();
            objBLL._Level = dr[DepartmentKeys.Field_Department_Level] == DBNull.Value ? 0 : int.Parse(dr[DepartmentKeys.Field_Department_Level].ToString());

            try
            {
                objBLL._RootId = dr[DepartmentKeys.FIELD_DEPARTMENT_ROOT_ID] == DBNull.Value ? 0 : int.Parse(dr[DepartmentKeys.FIELD_DEPARTMENT_ROOT_ID].ToString());
            }
            catch { }
            try
            {
                objBLL._ChildNodeCount = dr[DepartmentKeys.FIELD_DEPARTMENT_CHILD_NODE_COUNT] == DBNull.Value ? 0 : int.Parse(dr[DepartmentKeys.FIELD_DEPARTMENT_CHILD_NODE_COUNT].ToString());
            }
            catch { }
            try
            {
                objBLL._DepartmentFullName = dr[DepartmentKeys.Field_Department_DepartmentFullName] == DBNull.Value ? string.Empty : dr[DepartmentKeys.Field_Department_DepartmentFullName].ToString();
                string[] arr = objBLL._DepartmentFullName.Split('-');

            }
            catch { }
            try
            {
                objBLL._RootName = dr[DepartmentKeys.Field_Department_RootName] == DBNull.Value ? string.Empty : dr[DepartmentKeys.Field_Department_RootName].ToString();
            }
            catch { }
            try
            {
                objBLL._Status = dr[DepartmentKeys.Field_Department_Status] == DBNull.Value ? 0 : int.Parse(dr[DepartmentKeys.Field_Department_Status].ToString());
            }
            catch { }
          
            return objBLL;
        }

        private static string GetDash(int a, string departmentName)
        {
            string returnValue = string.Empty;
            switch (a)
            {
                case 0:
                    returnValue = departmentName.ToUpper();
                    break;
                case 1:
                    returnValue = " - " + departmentName.ToUpper();
                    break;
                case 2:
                    returnValue = " -- " + departmentName;
                    break;
                case 3:
                    returnValue = " --- " + departmentName;
                    break;
            }
            return returnValue;
        }

        #endregion

    }
}
