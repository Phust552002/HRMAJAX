using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H1;
using HRMUtil.KeyNames.H1;
using HRMUtil.KeyNames.H0;
using HRMBLL.H1.Helper;
using HRMUtil;

namespace HRMBLL.H1
{
    public class OverTimeTypeBLL
    {
        
        #region public methods GET

        public static DataTable GetAll()
        {
            return new OverTimeTypeDAL().GetAll();
        }
      
        #endregion

    }
}
