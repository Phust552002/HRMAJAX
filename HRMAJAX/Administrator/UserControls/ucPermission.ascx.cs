using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using HRMBLL.H0;
using HRMUtil;


public partial class Administrator_UserControls_ucPermission : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    

    public EmployeesBLL UserCurrent
    {
        get
        {
            if (Session[Constants.KEY_USER_CURRENT] != null)
            {
                return (EmployeesBLL)Session[Constants.KEY_USER_CURRENT];
            }
            else
            {
                return null;
            }
        }
    }

    public int UserId
    {
        get
        {
            if (Session[Constants.KEY_USER_CURRENT] != null)
            {
                EmployeesBLL em = (EmployeesBLL)Session[Constants.KEY_USER_CURRENT];
                return em.UserId;
            }
            else
            {
                return 0;
            }
        }
    }
    
    public int RootId
    {
        get
        {
            if (Session[Constants.KEY_USER_CURRENT] != null)
            {
                EmployeesBLL em = (EmployeesBLL)Session[Constants.KEY_USER_CURRENT];
                return em.RootId;
            }
            else
            {
                return 0;
            }
        }
    }
    public int DepartmentId
    {
        get
        {
            if (Session[Constants.KEY_USER_CURRENT] != null)
            {
                EmployeesBLL em = (EmployeesBLL)Session[Constants.KEY_USER_CURRENT];
                return em.DepartmentId;
            }
            else
            {
                return 0;
            }
        }
    }
    public int ParentId
    {
        get
        {
            if (Session[Constants.KEY_USER_CURRENT] != null)
            {
                EmployeesBLL em = (EmployeesBLL)Session[Constants.KEY_USER_CURRENT];
                return em.ParentId;
            }
            else
            {
                return 0;
            }
        }
    }
    public int DepartmentLevel
    {
        get
        {
            if (Session[Constants.KEY_USER_CURRENT] != null)
            {
                EmployeesBLL em = (EmployeesBLL)Session[Constants.KEY_USER_CURRENT];
                return em.DepartmentLevel;
            }
            else
            {
                return 0;
            }
        }
    }

    public string FullName
    {
        get
        {
            if (Session[Constants.KEY_USER_CURRENT] != null)
            {
                EmployeesBLL em = (EmployeesBLL)Session[Constants.KEY_USER_CURRENT];
                return em.FullName;
            }
            else
            {
                return string.Empty;
            }
        }
    }
   

    public bool IsAdmin
    {
        get 
        {
            if (Session[Constants.KEY_IS_ADMINISTRATOR] != null)
            {
                return Convert.ToBoolean(Session[Constants.KEY_IS_ADMINISTRATOR].ToString());
            }
            else
            {
                return false;
            }
        }
    }

    public bool IsHRAdmin
    {
        get
        {
            if (Session[Constants.KEY_IS_HR_ADMINISTRATOR] != null)
            {
                return Convert.ToBoolean(Session[Constants.KEY_IS_HR_ADMINISTRATOR].ToString());
            }
            else
            {
                return false;
            }
        }
    }
    public bool IsPMemberAdmin
    {
        get
        {
            if (Session[Constants.KEY_IS_PMEMBER_ADMIN] != null)
            {
                return Convert.ToBoolean(Session[Constants.KEY_IS_PMEMBER_ADMIN].ToString());
            }
            else
            {
                return false;
            }
        }
    }


    public bool IsUserNameChecker
    {
        get
        {
            if (Session[Constants.KEY_IS_HR_USERNAMECHECKER] != null)
            {
                return Convert.ToBoolean(Session[Constants.KEY_IS_HR_USERNAMECHECKER].ToString());
            }
            else
            {
                return false;
            }
        }
    }

    public bool IsHRManager
    {
        get
        {
            if (Session[Constants.KEY_IS_HR_MANAGER] != null)
            {
                return Convert.ToBoolean(Session[Constants.KEY_IS_HR_MANAGER].ToString());
            }
            else
            {
                return false;
            }
        }
    }

    public bool IsHRMember
    {
        get
        {
            if (Session[Constants.KEY_IS_HR_MEMBER] != null)
            {
                return Convert.ToBoolean(Session[Constants.KEY_IS_HR_MEMBER].ToString());
            }
            else
            {
                return false;
            }
        }
    }

    public bool IsFinancial_Accounting
    {
        get
        {
            if (Session[Constants.KEY_IS_FINANCIAL_ACCOUNTING] != null)
            {
                return Convert.ToBoolean(Session[Constants.KEY_IS_FINANCIAL_ACCOUNTING].ToString());
            }
            else
            {
                return false;
            }
        }
    }

    public bool IsTimeKeepingManager
    {
        get
        {
            if (Session[Constants.KeyIsTimeKeepingManager] != null)
            {
                return Convert.ToBoolean(Session[Constants.KeyIsTimeKeepingManager].ToString());
            }
            else
            {
                return false;
            }
        }
    }

    public bool IsTimeKeepingLeader
    {
        get
        {
            if (Session[Constants.KeyIsTimeKeepingLeader] != null)
            {
                return Convert.ToBoolean(Session[Constants.KeyIsTimeKeepingLeader].ToString());
            }
            else
            {
                return false;
            }
        }
    }

    public bool IsTimeKeepingSuperVisor
    {
        get
        {
            if (Session[Constants.KeyIsTimeKeepingSuppervisor] != null)
            {
                return Convert.ToBoolean(Session[Constants.KeyIsTimeKeepingSuppervisor].ToString());
            }
            else
            {
                return false;
            }
        }
    }
    public bool IsTimeKeepingGroup
    {
        get
        {
            if (Session[Constants.KeyIsTimeKeepingGroup] != null)
            {
                return Convert.ToBoolean(Session[Constants.KeyIsTimeKeepingGroup].ToString());
            }
            else
            {
                return false;
            }
        }
    }

    
    public bool IsTrainingManager
    {
        get
        {
            if (Session[Constants.KeyIsTrainingManager] != null)
            {
                return Convert.ToBoolean(Session[Constants.KeyIsTrainingManager].ToString());
            }
            else
            {
                return false;
            }
        }
    }
    public bool IsQAManager
    {
        get
        {
            if (Session[Constants.KeyIsQAManager] != null)
            {
                return Convert.ToBoolean(Session[Constants.KeyIsQAManager].ToString());
            }
            else
            {
                return false;
            }
        }
    }

    public bool IsLeaveManagerApproved
    {
        get
        {
            if (Session[Constants.KeyIsLeaveManagerApproved] != null)
            {
                return Convert.ToBoolean(Session[Constants.KeyIsLeaveManagerApproved].ToString());
            }
            else
            {
                return false;
            }
        }
    }


    public bool IsHolidayManagerApproved
    {
        get
        {
            if (Session[Constants.KeyIsHolidayManagerApproved] != null)
            {
                return Convert.ToBoolean(Session[Constants.KeyIsHolidayManagerApproved].ToString());
            }
            else
            {
                return false;
            }
        }
    }

    public bool IsHolidayHRDApproved
    {
        get
        {
            if (Session[Constants.KeyIsHolidayHRDApproved] != null)
            {
                return Convert.ToBoolean(Session[Constants.KeyIsHolidayHRDApproved].ToString());
            }
            else
            {
                return false;
            }
        }
    }
   
}
