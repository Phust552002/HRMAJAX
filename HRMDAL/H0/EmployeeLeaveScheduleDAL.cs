using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H0;

namespace HRMDAL.H0
{
    public class EmployeeLeaveScheduleDAL : Dao
    {
        public DataTable GetByFilter(string FullName, string DepartmentIds, int UserId, int Time, string Status, int RootId, int LevelPosition, DateTime RangeFrom, DateTime RangeTo)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                					
                    new SqlParameter("@FullName", SqlDbType.NVarChar, 254),
                    new SqlParameter("@DepartmentIds", SqlDbType.VarChar, 3000),
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@Time", SqlDbType.Int),
                    new SqlParameter("@Status", SqlDbType.VarChar, 3000),
                    new SqlParameter("@RootId", SqlDbType.Int),
                    new SqlParameter("@LevelPosition", SqlDbType.Int),
                    new SqlParameter("@RangeFrom", SqlDbType.DateTime),
                    new SqlParameter("@RangeTo", SqlDbType.DateTime),
				};
                param[0].Value = FullName;
                param[1].Value = DepartmentIds;
                param[2].Value = UserId;
                param[3].Value = Time;
                param[4].Value = Status;
                param[5].Value = RootId;
                param[6].Value = LevelPosition;
                param[7].Value = RangeFrom;
                param[8].Value = RangeTo;

                sproc = new StoreProcedure("Sel_H0_EmployeeLeaveSchedule", param);
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
        public DataTable GetByFilterV1(string FullName, string DepartmentIds)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                					
                    new SqlParameter("@FullName", SqlDbType.NVarChar, 254),
                    new SqlParameter("@DepartmentIds", SqlDbType.VarChar, 3000)
				};
                param[0].Value = FullName;
                param[1].Value = DepartmentIds;

                sproc = new StoreProcedure("Sel_H0_EmployeeLeaveSchedule_ByFilter", param);
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
        public DataTable GetByScheduleId(int EmployeeLeaveScheduleId)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                					
                    new SqlParameter("@EmployeeLeaveScheduleId", SqlDbType.Int),
				};
                param[0].Value = EmployeeLeaveScheduleId;

                sproc = new StoreProcedure("Sel_H0_EmployeeLeaveSchedule_By_ScheduleId", param);
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
        public DataTable GetByEmployeeLeaveScheduleId(int id)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                					
                    new SqlParameter("@EmployeeLeaveScheduleId", SqlDbType.Int),
				};
                param[0].Value = id;

                sproc = new StoreProcedure("Sel_H0_EmployeeLeaveSchedule_By_Id", param);
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
        public long Delete(int EmployeeLeaveScheduleId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
                    new SqlParameter("@EmployeeLeaveScheduleId",SqlDbType.Int)
				};

                param[0].Value = EmployeeLeaveScheduleId;

                sproc = new StoreProcedure("Del_H0_EmployeeLeaveSchedule", param);
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
        public long Insert(int UserId, DateTime FromDate, DateTime ToDate, int Days, int Time)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{   
                    new SqlParameter("@UserId",SqlDbType.Int),					         
					new SqlParameter("@FromDate",SqlDbType.DateTime),
					new SqlParameter("@ToDate",SqlDbType.DateTime),
					new SqlParameter("@Days",SqlDbType.Int),
					new SqlParameter("@Time",SqlDbType.Int),
				};

                param[0].Value = UserId;
                param[1].Value = FromDate;
                param[2].Value = ToDate;
                param[3].Value = Days;
                param[4].Value = Time;

                sproc = new StoreProcedure("Ins_H0_EmployeeLeaveSchedule", param);
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
        public long Update(int EmployeeLeaveScheduleId, DateTime FromDate, DateTime ToDate)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{   
                    new SqlParameter("@EmployeeLeaveScheduleId",SqlDbType.Int),
					new SqlParameter("@FromDate",SqlDbType.DateTime),
					new SqlParameter("@ToDate",SqlDbType.DateTime)
				};

                param[0].Value = EmployeeLeaveScheduleId;
                param[1].Value = FromDate;
                param[2].Value = ToDate;

                sproc = new StoreProcedure("Upd_H0_EmployeeLeaveSchedule", param);
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
        public long Update_Status(int EmployeeLeaveScheduleId, int Status)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{   
                    new SqlParameter("@EmployeeLeaveScheduleId",SqlDbType.Int),
                    new SqlParameter("@Status",SqlDbType.Int),
				};

                param[0].Value = EmployeeLeaveScheduleId;
                param[1].Value = Status;

                sproc = new StoreProcedure("Upd_H0_EmployeeLeaveSchedule_Status", param);
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
        public long Update_ApprovedDenied(int EmployeeLeaveScheduleId, string UserIds, int Type)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{   
                    new SqlParameter("@EmployeeLeaveScheduleId",SqlDbType.Int),
                    new SqlParameter("@UserIds",SqlDbType.VarChar, 25),
                    new SqlParameter("@Type",SqlDbType.Int),
				};

                param[0].Value = EmployeeLeaveScheduleId;
                param[1].Value = UserIds;
                param[2].Value = Type;

                sproc = new StoreProcedure("Upd_H0_EmployeeLeaveSchedule_LastApprovedDenied", param);
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
        public long UpdateWriteIds(long employeeLeaveId, string writeIds)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
	               new SqlParameter("@EmployeeLeaveScheduleId",SqlDbType.BigInt),
	               new SqlParameter("@WriteIds",SqlDbType.NVarChar, 4000),
				};

                param[0].Value = employeeLeaveId;
                param[1].Value = writeIds;

                sproc = new StoreProcedure("Upd_H0_EmployeeLeaveSchedule_WriteIds", param);
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
        public long UpdateDenyReason(long employeeLeaveId, string denyReason)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
	               new SqlParameter("@EmployeeLeaveScheduleId",SqlDbType.BigInt),
	               new SqlParameter("@DenyReason",SqlDbType.NVarChar, 4000),
				};

                param[0].Value = employeeLeaveId;
                param[1].Value = denyReason;

                sproc = new StoreProcedure("Upd_H0_EmployeeLeaveSchedule_DenyReason", param);
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
        public long UpdateReadIds(long employeeLeaveId, string readIds)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
	               new SqlParameter("@EmployeeLeaveScheduleId",SqlDbType.BigInt),
	               new SqlParameter("@ReadIds",SqlDbType.NVarChar, 4000),
				};

                param[0].Value = employeeLeaveId;
                param[1].Value = readIds;

                sproc = new StoreProcedure("Upd_H0_EmployeeLeaveSchedule_ReadIds", param);
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
        public long UpdateRemark1(long employeeLeaveId, string remark, int notInSchedule)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
	               new SqlParameter("@EmployeeLeaveScheduleId",SqlDbType.BigInt),
	               new SqlParameter("@Remark",SqlDbType.NVarChar, 4000),
	               new SqlParameter("@NotInSchedule",SqlDbType.Int),
				};

                param[0].Value = employeeLeaveId;
                param[1].Value = remark;
                param[2].Value = notInSchedule;

                sproc = new StoreProcedure("Upd_H0_EmployeeLeaveSchedule_Remark1", param);
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
        public DataTable GetById(string FullName, string DepartmentIds, int UserId)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                					
                    new SqlParameter("@FullName", SqlDbType.NVarChar, 254),
                    new SqlParameter("@DepartmentIds", SqlDbType.VarChar, 3000),
                    new SqlParameter("@UserId", SqlDbType.Int),
				};
                param[0].Value = FullName;
                param[1].Value = DepartmentIds;
                param[2].Value = UserId;

                sproc = new StoreProcedure("Sel_H0_EmployeeLeave_By_UserId", param);
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
    }
}
