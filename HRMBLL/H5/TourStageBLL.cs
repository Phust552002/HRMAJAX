using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H5;
using HRMUtil.KeyNames.H5;
using HRMUtil.KeyNames.H0;
using HRMUtil;
namespace HRMBLL.H5
{
    public class TourStageBLL
    {

        #region Methods Get
      
        public static DataTable GetByYear(int Year)
        {

            return new TourStageDAL().GetByYear(Year);
        }

        #endregion
    }
}
