using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H0;

namespace HRMDAL.H0
{
    public class EmployeeTimeBillDAL: Dao
    {
        #region Insert, Update, Delete

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns>int</returns>
        public long Insert(System.Nullable<System.DateTime> WorkDate, System.Nullable<int> UserId, System.Nullable<System.DateTime> TimeIn, System.Nullable<System.DateTime> TimeOut, System.Nullable<double> TotalMinutes, System.Nullable<double> TotalHours, System.Nullable<int> Status)
        {

            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{                                					                    
                    new SqlParameter("@WorkDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@TimeIn", SqlDbType.DateTime, 8),
                    new SqlParameter("@TimeOut", SqlDbType.DateTime, 8),
                    new SqlParameter("@TotalMinutes", SqlDbType.Float, 8),
	                new SqlParameter("@TotalHours", SqlDbType.Float, 8),
                    new SqlParameter("@Status", SqlDbType.Int, 4)
				};

                if ((WorkDate.HasValue == true))
                {
                    param[0].Value = ((System.DateTime)(WorkDate.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((UserId.HasValue == true))
                {
                    param[1].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((TimeIn.HasValue == true))
                {
                    param[2].Value = ((System.DateTime)(TimeIn.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((TimeOut.HasValue == true))
                {
                    param[3].Value = ((System.DateTime)(TimeOut.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((TotalMinutes.HasValue == true))
                {
                    param[4].Value = ((double)(TotalMinutes.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((TotalHours.HasValue == true))
                {
                    param[5].Value = ((double)(TotalHours.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                if ((Status.HasValue == true))
                {
                    param[6].Value = ((int)(Status.Value));
                }
                else
                {
                    param[6].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(EmployeeTimeBillKeys.Sp_Ins_H0_EmployeeTimeBill, param);
                identity = sproc.Run();
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

        public long Update(System.Nullable<System.DateTime> WorkDate, System.Nullable<int> UserId, System.Nullable<System.DateTime> TimeIn, System.Nullable<System.DateTime> TimeOut, System.Nullable<double> TotalMinutes, System.Nullable<double> TotalHours, System.Nullable<int> Status, System.Nullable<int> UserTimeBillId)
        {

            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{                                					                    
                    new SqlParameter("@WorkDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@TimeIn", SqlDbType.DateTime, 8),
                    new SqlParameter("@TimeOut", SqlDbType.DateTime, 8),
                    new SqlParameter("@TotalMinutes", SqlDbType.Float, 8),
	                new SqlParameter("@TotalHours", SqlDbType.Float, 8),
                    new SqlParameter("@Status", SqlDbType.Int, 4),
                    new SqlParameter("@UserTimeBillId", SqlDbType.Int, 4)
				};

                if ((WorkDate.HasValue == true))
                {
                    param[0].Value = ((System.DateTime)(WorkDate.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((UserId.HasValue == true))
                {
                    param[1].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((TimeIn.HasValue == true))
                {
                    param[2].Value = ((System.DateTime)(TimeIn.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((TimeOut.HasValue == true))
                {
                    param[3].Value = ((System.DateTime)(TimeOut.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                
                if ((TotalMinutes.HasValue == true))
                {
                    param[4].Value = ((double)(TotalMinutes.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((TotalHours.HasValue == true))
                {
                    param[5].Value = ((double)(TotalHours.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                if ((Status.HasValue == true))
                {
                    param[6].Value = ((int)(Status.Value));
                }
                else
                {
                    param[6].Value = System.DBNull.Value;
                }
                if ((UserTimeBillId.HasValue == true))
                {
                    param[7].Value = ((int)(UserTimeBillId.Value));
                }
                else
                {
                    param[7].Value = System.DBNull.Value;
                }
                sproc = new StoreProcedure(EmployeeTimeBillKeys.Sp_Upd_H0_EmployeeTimeBill, param);
                identity = sproc.Run();
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




        public long Delete(System.Nullable<int> UserTimeBillId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
                   
                   new SqlParameter("@UserTimeBillId", SqlDbType.Int, 4)
				};

                if ((UserTimeBillId.HasValue == true))
                {
                    param[0].Value = ((int)(UserTimeBillId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(EmployeeTimeBillKeys.Sp_Del_H0_EmployeeTimeBill, param);
                identity = sproc.Run();
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

        #region Get



        public DataTable GetByUserStatus(System.Nullable<int> UserId, System.Nullable<int> Status)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@Status", SqlDbType.Int, 4)
				};

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((Status.HasValue == true))
                {
                    param[1].Value = ((int)(Status.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                
                sproc = new StoreProcedure(EmployeeTimeBillKeys.Sp_Sel_H0_EmployeeTimeBillByUserStatus, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }
        public DataTable GetForDistinctWorkdateByUserId(System.Nullable<int> UserId, System.Nullable<int> Month, System.Nullable<int> Year)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
                    new SqlParameter("@UserId", SqlDbType.Int, 4),                    
                    new SqlParameter("@Month", SqlDbType.Int, 4),
                    new SqlParameter("@Year", SqlDbType.Int, 4)
				};

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((Month.HasValue == true))
                {
                    param[1].Value = ((int)(Month.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }

                if ((Year.HasValue == true))
                {
                    param[2].Value = ((int)(Year.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(EmployeeTimeBillKeys.Sp_Sel_H0_EmployeeTimeBillForDistinctWorkdateByUserId, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }

        public DataTable GetByFilter(System.Nullable<int> UserId, System.Nullable<int> Status, System.Nullable<int> Day, System.Nullable<int> Month, System.Nullable<int> Year)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@Status", SqlDbType.Int, 4),
                    new SqlParameter("@Day", SqlDbType.Int, 4),
                    new SqlParameter("@Month", SqlDbType.Int, 4),
                    new SqlParameter("@Year", SqlDbType.Int, 4)
				};

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((Status.HasValue == true))
                {
                    param[1].Value = ((int)(Status.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }

                if ((Day.HasValue == true))
                {
                    param[2].Value = ((int)(Day.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }

                if ((Month.HasValue == true))
                {
                    param[3].Value = ((int)(Month.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }

                if ((Year.HasValue == true))
                {
                    param[4].Value = ((int)(Year.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(EmployeeTimeBillKeys.Sp_Sel_H0_EmployeeTimeBillByFilter, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }
        public DataTable GetByFilterByHo(System.Nullable<int> UserId, System.Nullable<int> Status, System.Nullable<int> Day, System.Nullable<int> Month, System.Nullable<int> Year)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@Status", SqlDbType.Int, 4),
                    new SqlParameter("@Day", SqlDbType.Int, 4),
                    new SqlParameter("@Month", SqlDbType.Int, 4),
                    new SqlParameter("@Year", SqlDbType.Int, 4)
				};

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((Status.HasValue == true))
                {
                    param[1].Value = ((int)(Status.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }

                if ((Day.HasValue == true))
                {
                    param[2].Value = ((int)(Day.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }

                if ((Month.HasValue == true))
                {
                    param[3].Value = ((int)(Month.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }

                if ((Year.HasValue == true))
                {
                    param[4].Value = ((int)(Year.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(EmployeeTimeBillKeys.Sp_Sel_H0_EmployeeTimeBillByFilterForHo, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }
        public DataTable GetByUserDateForWorkingHo(System.Nullable<int> UserId, System.Nullable<int> Day, System.Nullable<int> Month, System.Nullable<int> Year)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
                    new SqlParameter("@UserId", SqlDbType.Int, 4),                    
                    new SqlParameter("@Day", SqlDbType.Int, 4),
                    new SqlParameter("@Month", SqlDbType.Int, 4),
                    new SqlParameter("@Year", SqlDbType.Int, 4)
				};

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                if ((Day.HasValue == true))
                {
                    param[1].Value = ((int)(Day.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }

                if ((Month.HasValue == true))
                {
                    param[2].Value = ((int)(Month.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }

                if ((Year.HasValue == true))
                {
                    param[3].Value = ((int)(Year.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(EmployeeTimeBillKeys.Sp_Sel_H0_EmployeeTimeBillByUserDateForWorkingAndHo, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }

        public DataTable GetForDistinctWorkdateByFromToWorkDate(System.Nullable<int> UserId, DateTime FromDate, DateTime ToDate)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@FromDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@ToDate", SqlDbType.DateTime, 8)
				};

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                param[1].Value = FromDate;
                param[2].Value = ToDate;

                sproc = new StoreProcedure(EmployeeTimeBillKeys.Sp_Sel_H0_EmployeeTimeBillForDistinctWorkdateByUserIdFromToWorkDate, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }

        public DataTable GetByDateRootId(System.Nullable<int> RootId, DateTime InputDate)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
                    new SqlParameter("@RootId", SqlDbType.Int, 4),
                    new SqlParameter("@InputDate", SqlDbType.DateTime, 8)
				};

                if ((RootId.HasValue == true))
                {
                    param[0].Value = ((int)(RootId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                param[1].Value = InputDate;                

                sproc = new StoreProcedure(EmployeeTimeBillKeys.Sp_Sel_H0_EmployeeTimeBillByRootDate, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }

        public DataTable GetDateTimeNowFromServer()
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {

                sproc = new StoreProcedure(EmployeeTimeBillKeys.Sp_Sel_DateTimeNow, null);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }
        #endregion
    }
}
