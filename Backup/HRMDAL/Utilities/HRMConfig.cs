using System;
using System.Configuration;
using HRMUtil;

namespace HRMDAL.Utilities
{
    public class HRMConfig
    {
        public static string ConnectionString
        {

            get
            {
                string mConnectionString = global::HRMDAL.Properties.Settings.Default.s;
                if (mConnectionString == null || mConnectionString.Length == 0)
                    throw new HRMException("HRMConnectionString is missed....");
                else
                    return mConnectionString;
            }

        }
    }
}
