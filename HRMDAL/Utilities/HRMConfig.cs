using System;
using System.Configuration;
using System.Web.Configuration;
using HRMUtil;

namespace HRMDAL.Utilities
{
    public class HRMConfig
    {
        public static string ConnectionString
        {

            get
            {
                string mConnectionString = string.Empty;
                string baseStation = WebConfigurationManager.AppSettings["BaseStation"];
                switch (baseStation)
                {
                    default:
                        mConnectionString = "Data Source=ITD-IS-PHUCHT; Initial Catalog=HRM;User ID=sa;Password=123;";
                        break;
                }
                if (mConnectionString == null || mConnectionString.Length == 0)
                    throw new HRMException("HRMConnectionString is missed....");
                else
                    return mConnectionString;
            }

        }
    }
}
