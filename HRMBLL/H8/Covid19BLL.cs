using HRMDAL.H8;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HRMBLL.H8
{
    public class Covid19BLL
    {
        public static int Save(int covidVictimId, int userId, string type, DateTime testContactDate, DateTime quarantineBeginDate, DateTime quarantineEndDate, string remarks, int place)
        {
            return new Covid19DAL().Save(covidVictimId, userId, type, testContactDate, quarantineBeginDate, quarantineEndDate, remarks, place);
        }
        public static void Delete(int covidVictimId)
        {
            new Covid19DAL().Delete(covidVictimId);
        }
        public static DataRow GetCovid19VictimByIdForDataRow(int covid19Victim)
        {

            DataTable dt = new Covid19DAL().GetOne(covid19Victim);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }

        }

        public static DataTable GetByDeptIds(string deptIds, int rootId, string fullname, string type)
        {
            return new Covid19DAL().GetByDeptIds(deptIds, rootId, fullname, type);
        }
        public static DataTable GetVaccinationInfoByDeptIds(string deptIds, int rootId, string fullname, int type)
        {
            return new Covid19DAL().GetVaccinationInfoByDeptIds(deptIds, rootId, fullname, type);
        }
        public static DataTable GetHistory(int userId)
        {
            return new Covid19DAL().GetHistory(userId);
        }

        public static DataRow GetF0ByCovidVictimId(int covidVictimId)
        {
            DataTable dt = new Covid19DAL().GetF0ByCovidVictimId(covidVictimId);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }

        public static void SaveApproach(int userId, int covidVictimId, string remarks, DateTime approachDate, int approachedCovidVictimId)
        {
            new Covid19DAL().SaveApproach(userId, covidVictimId, remarks, approachDate, approachedCovidVictimId);
        }
    }
}
