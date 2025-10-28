using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using HRMDAL.HRMTableAdapters;
using HRMDAL;

namespace HRMBLL
{
    [System.ComponentModel.DataObject]
    public class UserRolesBLL
    {

        #region private fields

        private ViewUserRolesTableAdapter _ViewUserRolesAdapter = null;
        private int _UserId =0;
        private string _UserName = string.Empty;
        private string _UserCode = string.Empty;
        private string _FullName = string.Empty;
        private int _RoleId = 0;
        private string _RoleName = string.Empty;
        private int _RoleLevel = 0;
        private string _Description = string.Empty;

        #endregion

        #region properties

        protected ViewUserRolesTableAdapter Adapter
        {
            get
            {
                if (_ViewUserRolesAdapter == null)
                    _ViewUserRolesAdapter = new ViewUserRolesTableAdapter();

                return _ViewUserRolesAdapter;
            }
        }

        public int UserId
        {
            get 
            {
                return _UserId;
            }
            set 
            {
                _UserId = value;
            }
        }

        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }

        public string UserCode
        {
            get
            {
                return _UserCode;
            }
            set
            {
                _UserCode = value;
            }
        }

        public string FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                _FullName = value;
            }
        }

        public int RoleId
        {
            get
            {
                return _RoleId;
            }
            set
            {
                _RoleId = value;
            }
        }

        public String RoleName
        {
            get
            {
                return _RoleName;
            }
            set
            {
                _RoleName = value;
            }
        }
        public int RoleLevel
        {
            get
            {
                return _RoleLevel;
            }
            set
            {
                _RoleLevel = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }

        #endregion


        public UserRolesBLL GetUserRolesByUserId(int userId)
        {
            HRMDAL.HRM.ViewUserRolesDataTable dtUserRoles = Adapter.GetUserIdById(userId);
            if (dtUserRoles != null)
            {
                if (dtUserRoles.Rows.Count > 0)
                {
                    return GenerateUserRolesBLLFromDataTable(dtUserRoles);
                }
            }
            return null;
            
        }
        public static DataTable GetByFilter(int RoleId, int RootId)
        {
            return new HRMDAL.H0.RoleUsersDAL().GetByRoleId_RootId(RoleId, RootId);
        }

        private UserRolesBLL GenerateUserRolesBLLFromDataTable(HRM.ViewUserRolesDataTable objDT)
        {
            UserRolesBLL objUserRolesBLL = new UserRolesBLL();
            objUserRolesBLL.UserId = int.Parse(objDT[0]["UserId"].ToString().Trim());
            objUserRolesBLL.UserName = objDT[0]["UserName"].ToString();
            objUserRolesBLL.FullName = objDT[0]["FullName"].ToString();
            objUserRolesBLL.UserCode = objDT[0]["EmployeeCode"].ToString();
            objUserRolesBLL.RoleId = int.Parse(objDT[0]["RoleId"] == DBNull.Value ? "0" : objDT[0]["RoleId"].ToString());
            objUserRolesBLL.RoleName = objDT[0]["RoleName"] == DBNull.Value ? "" : objDT[0]["RoleName"].ToString();
            objUserRolesBLL.RoleLevel = int.Parse(objDT[0]["RoleLevel"] == DBNull.Value ? "0" : objDT[0]["RoleLevel"].ToString());
            objUserRolesBLL.Description = objDT[0]["Description"] == DBNull.Value ? "0" : objDT[0]["Description"].ToString();
            return objUserRolesBLL;
        }
    }
}
