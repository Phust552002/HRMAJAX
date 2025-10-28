using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H;
using System.Deployment.Internal;

namespace HRMDAL.H1
{
    public class BonusEmployeeConditionDAL : Dao
    {

        #region methods Get

        public DataTable GetByFilter(string fullName, int departmentId, int year, int month, int bonusTitleId)
        {

            Debug.Assert(sproc == null);
            DataTable dt = new DataTable();
            try
            {

                SqlParameter[] param = {
                    new SqlParameter("@FullName", SqlDbType.NVarChar, 254),
                    new SqlParameter("@DepartmentId", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@BonusTitleId", SqlDbType.Int)
                };

                param[0].Value = fullName;
                param[1].Value = departmentId;
                param[2].Value = year;
                param[3].Value = month;
                param[4].Value = bonusTitleId;

                sproc = new StoreProcedure("Sel_H0_BonusValue_By_Filter", param);
                sproc.RunFill(dt);

            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }
            return dt;
        }


        public DataTable GetStatisticTotalByFilter(int departmentId, int year, int month, int bonusTitleId)
        {

            Debug.Assert(sproc == null);
            DataTable dt = new DataTable();
            try
            {

                SqlParameter[] param = {
                    new SqlParameter("@DepartmentId", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@BonusTitleId", SqlDbType.Int)
                };

                param[0].Value = departmentId;
                param[1].Value = year;
                param[2].Value = month;
                param[3].Value = bonusTitleId;

                sproc = new StoreProcedure("Sel_H0_BonusValue_StatisticTotalBy_Filter_V2", param);
                sproc.RunFill(dt);

            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }
            return dt;
        }


        public long UpdateHideSetNullToZero(int bonusTitleId, int year, int month)
        {
            Debug.Assert(sproc == null);
            long identity = 0;
            try
            {
                SqlParameter[] param = {
                    new SqlParameter("@BonusTitleId", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@Month", SqlDbType.Int)
                };

                param[0].Value = bonusTitleId;
                param[1].Value = year;
                param[2].Value = month;

                sproc = new StoreProcedure("Upd_H1_BonusEmployeeCondition_SetNullToZero", param);
                identity = sproc.Run();
                sproc.Commit();
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }
            return identity;
        }
        //public DataTable GetBonusTitlesByYear(int year)
        //{
        //    Debug.Assert(sproc == null);
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        SqlParameter[] param = {
        //            new SqlParameter("@Year", SqlDbType.Int)
        //        };

        //        param[0].Value = year;

        //        sproc = new StoreProcedure("Sel_H1_BonusTitles_By_Year", param);
        //        sproc.RunFill(dt);
        //    }
        //    catch (SqlException se)
        //    {
        //        throw new HRMException(se.Message, se.Number);
        //    }
        //    finally
        //    {
        //        sproc.Dispose();
        //    }

        //    return dt;
        //}

        public DataTable GetBonusTitlesByPayDateYear(int year, int month)
        {
            Debug.Assert(sproc == null);
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = {
            new SqlParameter("@Year", SqlDbType.Int),
            new SqlParameter("@Month", SqlDbType.Int)
        };
                param[0].Value = year;
                param[1].Value = month;

                sproc = new StoreProcedure("Sel_H1_BonusTitle_By_PayDateYear", param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }
            return dt;
        }



        #endregion
    }
}
