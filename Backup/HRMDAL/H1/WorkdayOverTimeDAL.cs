using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H1;

namespace HRMDAL.H1
{
    public class WorkdayOverTimeDAL : Dao
    {
        #region insert, update, delete

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns>int</returns>
        public int Insert(int UserId, string OverTimeType, double OverTimeHours, System.Nullable<DateTime> OverTimeDate, string OverTimeRemark, int OTUpdatedUserId, System.Nullable<DateTime> OTUpdatedDatetime)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
             
                SqlParameter[] param = 
				{					
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@OverTimeType", SqlDbType.VarChar, 6),
                    new SqlParameter("@OverTimeHours", SqlDbType.Float),
                    new SqlParameter("@OverTimeDate", SqlDbType.DateTime),
                    new SqlParameter("@OverTimeRemark", SqlDbType.NVarChar, 250),
                    new SqlParameter("@OTUpdatedUserId", SqlDbType.Int),
                    new SqlParameter("@OTUpdatedDatetime", SqlDbType.SmallDateTime)
				};
                
                param[0].Value = UserId;
                param[1].Value = OverTimeType;
                param[2].Value = OverTimeHours;


                if ((OverTimeDate.HasValue == true))
                {
                    param[3].Value = ((System.DateTime)(OverTimeDate.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                param[4].Value = OverTimeRemark;
                param[5].Value = OTUpdatedUserId;

                if ((OTUpdatedDatetime.HasValue == true))
                {
                    param[6].Value = ((System.DateTime)(OTUpdatedDatetime.Value));
                }
                else
                {
                    param[6].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(WorkdayOverTimeKeys.Sp_Ins_H1_WorkdayOverTime, param);
                identity = sproc.RunInt();
                sproc.Commit();


            }
            catch (SqlException se)
            {
                sproc.RollBack();
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }
            return identity;
        }

        public int Update(int UserId, string OverTimeType, double OverTimeHours, System.Nullable<DateTime> OverTimeDate, string OverTimeRemark, int OTUpdatedUserId, System.Nullable<DateTime> OTUpdatedDatetime, int OverTimeId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {

                SqlParameter[] param = 
				{					
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@OverTimeType", SqlDbType.VarChar, 6),
                    new SqlParameter("@OverTimeHours", SqlDbType.Float),
                    new SqlParameter("@OverTimeDate", SqlDbType.DateTime),
                    new SqlParameter("@OverTimeRemark", SqlDbType.NVarChar, 250),
                    new SqlParameter("@OTUpdatedUserId", SqlDbType.Int),
                    new SqlParameter("@OTUpdatedDatetime", SqlDbType.SmallDateTime),
                    new SqlParameter("@OverTimeId", SqlDbType.Int)
				};

                param[0].Value = UserId;
                param[1].Value = OverTimeType;
                param[2].Value = OverTimeHours;


                if ((OverTimeDate.HasValue == true))
                {
                    param[3].Value = ((System.DateTime)(OverTimeDate.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                param[4].Value = OverTimeRemark;
                param[5].Value = OTUpdatedUserId;

                if ((OTUpdatedDatetime.HasValue == true))
                {
                    param[6].Value = ((System.DateTime)(OTUpdatedDatetime.Value));
                }
                else
                {
                    param[6].Value = System.DBNull.Value;
                }
                param[7].Value = OverTimeId;

                sproc = new StoreProcedure(WorkdayOverTimeKeys.Sp_Upd_H1_WorkdayOverTime, param);
                identity = sproc.RunInt();
                sproc.Commit();

            }
            catch (SqlException se)
            {
                sproc.RollBack();
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }
            return identity;
        }

        public int Delete(int OverTimeId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@OverTimeId", System.Data.SqlDbType.Int, 4)
				};

                param[0].Value = OverTimeId;

                sproc = new StoreProcedure(WorkdayOverTimeKeys.Sp_Del_H1_WorkdayOverTimeById, param);
                sproc.Run();
                sproc.Commit();

            }
            catch (SqlException se)
            {
                sproc.RollBack();

                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }
            return identity;
        }

        //public int DeleteByIds(string HTCVEmployeeIds)
        //{
        //    int identity = 0;
        //    Debug.Assert(sproc == null);
        //    try
        //    {
        //        SqlParameter[] param = 
        //        {
        //            new SqlParameter("@HTCVEmployeeIds", System.Data.SqlDbType.VarChar, 1000)
        //        };

        //        if ((HTCVEmployeeIds == null))
        //        {
        //            param[0].Value = System.DBNull.Value;
        //        }
        //        else
        //        {
        //            param[0].Value = ((string)(HTCVEmployeeIds));
        //        }

        //        sproc = new StoreProcedure(HTCVEmployeeKeys.Sp_Del_H1_HTCVEmployeeByIds, param);
        //        sproc.Run();
        //        sproc.Commit();

        //    }
        //    catch (SqlException se)
        //    {
        //        sproc.RollBack();

        //        throw new HRMException(se.Message, se.Number);
        //    }
        //    finally
        //    {
        //        sproc.Dispose();
        //    }
        //    return identity;
        //}


        public int DeleteDate(int UserId, DateTime OverTimeDate)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@UserId", System.Data.SqlDbType.Int, 4),
                    new SqlParameter("@OverTimeDate", System.Data.SqlDbType.DateTime)
				};

                param[0].Value = UserId;
                param[1].Value = OverTimeDate;

                sproc = new StoreProcedure(WorkdayOverTimeKeys.Sp_Del_H1_WorkdayOverTimeByUserDate, param);
                sproc.Run();
                sproc.Commit();

            }
            catch (SqlException se)
            {
                sproc.RollBack();

                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }
            return identity;
        }

        #endregion

        #region Methods GET

        public DataTable GetByFilter(int UserId, string OverTimeType, System.Nullable<DateTime> OverTimeDate)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
				{					
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@OverTimeType", SqlDbType.VarChar, 6),
                    new SqlParameter("@OverTimeDate", SqlDbType.DateTime),
				};

                param[0].Value = UserId;
                param[1].Value = OverTimeType;
                param[2].Value = OverTimeDate;

                sproc = new StoreProcedure(WorkdayOverTimeKeys.Sp_Sel_H1_WorkdayOverTimeByFilter, param);
                sproc.RunFill(datatable);
                sproc.Dispose();
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return datatable;

        }

       

        #endregion
    }
}
