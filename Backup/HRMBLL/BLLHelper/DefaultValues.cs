using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;

namespace HRMBLL.BLLHelper
{
    public static class DefaultValues
    {

        public static DateTime GetBirthdayMinValue()
        {
            DateTime MinValue = (DateTime)SqlDateTime.MinValue;
            MinValue.AddYears(30);
            return (MinValue);
        }

        public static DateTime GetJoinDateMinValue()
        {
            DateTime MinValue = (DateTime)SqlDateTime.MinValue;
            MinValue.AddYears(30);
            return (MinValue);
        }
        public static DateTime GetSQLDateMinValue()
        {
            DateTime MinValue = (DateTime)SqlDateTime.MinValue;
            MinValue.AddYears(30);
            return (MinValue);
        }
        public static int GetStandardLeaveMinValue()
        {
            return (12);
        }
     }

}
