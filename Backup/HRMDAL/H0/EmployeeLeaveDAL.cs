using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H0;


namespace HRMDAL.H0
{
    public class EmployeeLeaveDAL : Dao
    {

        #region Insert, Update, Delete

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns>int</returns>
        public long Insert(int userId, int leaveTypeId, DateTime fromDate, DateTime toDate, double days, long groupId, string remark, int Status)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{                                
					new SqlParameter("@LeaveTypeId",SqlDbType.Int),
                    new SqlParameter("@UserId",SqlDbType.Int),					
					new SqlParameter("@FromDate",SqlDbType.DateTime),					
                    new SqlParameter("@ToDate",SqlDbType.DateTime),
                    new SqlParameter("@Days",SqlDbType.Float),
                    new SqlParameter("@GroupId",SqlDbType.BigInt),
                    new SqlParameter("@Remark",SqlDbType.NVarChar,1000),
                    new SqlParameter("@Status",SqlDbType.Int)
				};

                param[0].Value = leaveTypeId;
                param[1].Value = userId;
                param[2].Value = fromDate;
                param[3].Value = toDate;
                param[4].Value = days;
                param[5].Value = groupId;
                param[6].Value = remark == null ? string.Empty : remark;
                param[7].Value = Status;

                sproc = new StoreProcedure("Ins_H0_EmployeeLeaveV1", param);
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
        public long InsertV1(int userId, int leaveTypeId, DateTime fromDate, DateTime toDate, double days, long groupId, string remark, int Status, int ScheduleId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{                                
					new SqlParameter("@LeaveTypeId",SqlDbType.Int),
                    new SqlParameter("@UserId",SqlDbType.Int),					
					new SqlParameter("@FromDate",SqlDbType.DateTime),					
                    new SqlParameter("@ToDate",SqlDbType.DateTime),
                    new SqlParameter("@Days",SqlDbType.Float),
                    new SqlParameter("@GroupId",SqlDbType.BigInt),
                    new SqlParameter("@Remark",SqlDbType.NVarChar,1000),
                    new SqlParameter("@Status",SqlDbType.Int),
                    new SqlParameter("@ScheduleId",SqlDbType.Int),
				};

                param[0].Value = leaveTypeId;
                param[1].Value = userId;
                param[2].Value = fromDate;
                param[3].Value = toDate;
                param[4].Value = days;
                param[5].Value = groupId;
                param[6].Value = remark == null ? string.Empty : remark;
                param[7].Value = Status;
                param[8].Value = ScheduleId;

                sproc = new StoreProcedure("Ins_H0_EmployeeLeaveV1", param);
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
        public long InsertInWeb(int userId, int leaveTypeId, DateTime fromDate, DateTime toDate, double days, long groupId, string remark, int Status, int ScheduleId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{                                
					new SqlParameter("@LeaveTypeId",SqlDbType.Int),
                    new SqlParameter("@UserId",SqlDbType.Int),					
					new SqlParameter("@FromDate",SqlDbType.DateTime),					
                    new SqlParameter("@ToDate",SqlDbType.DateTime),
                    new SqlParameter("@Days",SqlDbType.Float),
                    new SqlParameter("@GroupId",SqlDbType.BigInt),
                    new SqlParameter("@Remark",SqlDbType.NVarChar,1000),
                    new SqlParameter("@Status",SqlDbType.Int),
                    new SqlParameter("@ScheduleId",SqlDbType.Int),
				};

                param[0].Value = leaveTypeId;
                param[1].Value = userId;
                param[2].Value = fromDate;
                param[3].Value = toDate;
                param[4].Value = days;
                param[5].Value = groupId;
                param[6].Value = remark == null ? string.Empty : remark;
                param[7].Value = Status;
                param[8].Value = ScheduleId;

                sproc = new StoreProcedure("Ins_H0_EmployeeLeave_InWeb", param);
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
        public long UpdateInWeb(int userId, DateTime fromDate, DateTime toDate, double days, string remark, int ScheduleId, int EmployeeLeaveId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{                                
                    new SqlParameter("@UserId",SqlDbType.Int),					
					new SqlParameter("@FromDate",SqlDbType.DateTime),					
                    new SqlParameter("@ToDate",SqlDbType.DateTime),
                    new SqlParameter("@Days",SqlDbType.Float),
                    new SqlParameter("@Remark",SqlDbType.NVarChar,1000),
                    new SqlParameter("@ScheduleId",SqlDbType.Int),
                    new SqlParameter("@EmployeeLeaveId",SqlDbType.Int),
				};

                param[0].Value = userId;
                param[1].Value = fromDate;
                param[2].Value = toDate;
                param[3].Value = days;
                param[4].Value = remark == null ? string.Empty : remark;
                param[5].Value = ScheduleId;
                param[6].Value = EmployeeLeaveId;

                sproc = new StoreProcedure("Upd_H0_EmployeeLeave_InWeb", param);
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
        public long UpdateV1(int userId, int leaveTypeId, DateTime fromDate, DateTime toDate, double days, long groupId, string remark, long employeeLeaveId, int Status)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
                   new SqlParameter("@LeaveTypeId",SqlDbType.Int),
                   new SqlParameter("@UserId",SqlDbType.Int),					
				   new SqlParameter("@FromDate",SqlDbType.DateTime),					
                   new SqlParameter("@ToDate",SqlDbType.DateTime),
                   new SqlParameter("@Days",SqlDbType.Float),
                   new SqlParameter("@GroupId",SqlDbType.BigInt),
                   new SqlParameter("@Remark",SqlDbType.NVarChar,1000),
	               new SqlParameter("@EmployeeLeaveId",SqlDbType.BigInt),
	               new SqlParameter("@Status",SqlDbType.BigInt),
				};

                param[0].Value = leaveTypeId;
                param[1].Value = userId;
                param[2].Value = fromDate;
                param[3].Value = toDate;
                param[4].Value = days;
                param[5].Value = groupId;
                param[6].Value = remark == null ? string.Empty : remark;
                param[7].Value = employeeLeaveId;
                param[8].Value = Status == null ? 0 : Status;

                sproc = new StoreProcedure(EmployeeLeaveKeys.SP_EMPLOYEE_LEAVE_UPDATE, param);
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
        public long UpdateStatus(long employeeLeaveId, int status)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
	               new SqlParameter("@EmployeeLeaveId",SqlDbType.BigInt),
	               new SqlParameter("@Status",SqlDbType.BigInt),
				};

                param[0].Value = employeeLeaveId;
                param[1].Value = status;

                sproc = new StoreProcedure("Upd_H0_EmployeeLeave_Status", param);
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
        public long Update(int userId, int leaveTypeId, DateTime fromDate, DateTime toDate, double days, long groupId, string remark, long employeeLeaveId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
                   new SqlParameter("@LeaveTypeId",SqlDbType.Int),
                   new SqlParameter("@UserId",SqlDbType.Int),					
				   new SqlParameter("@FromDate",SqlDbType.DateTime),					
                   new SqlParameter("@ToDate",SqlDbType.DateTime),
                   new SqlParameter("@Days",SqlDbType.Float),
                   new SqlParameter("@GroupId",SqlDbType.BigInt),
                   new SqlParameter("@Remark",SqlDbType.NVarChar,1000),
	               new SqlParameter("@EmployeeLeaveId",SqlDbType.BigInt)	
				};

                param[0].Value = leaveTypeId;
                param[1].Value = userId;
                param[2].Value = fromDate;
                param[3].Value = toDate;
                param[4].Value = days;
                param[5].Value = groupId;
                param[6].Value = remark == null ? string.Empty : remark;
                param[7].Value = employeeLeaveId;

                sproc = new StoreProcedure(EmployeeLeaveKeys.SP_EMPLOYEE_LEAVE_UPDATE, param);
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

        public long DeleteByGroupId(long groupId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
                   new SqlParameter("@GroupId",SqlDbType.BigInt)
				};

                param[0].Value = groupId;

                sproc = new StoreProcedure(EmployeeLeaveKeys.SP_EMPLOYEE_LEAVE_DELETE_BY_GROUPID, param);
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


        public long Delete(long employeeLeaveId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
                   new SqlParameter("@EmployeeLeaveId",SqlDbType.BigInt)
				};

                param[0].Value = employeeLeaveId;

                sproc = new StoreProcedure(EmployeeLeaveKeys.SP_EMPLOYEE_LEAVE_DELETE, param);
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

        public long DeleteByMonthLeaveType(int month, int leaveType)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
                   new SqlParameter("@Month",SqlDbType.Int),
                   new SqlParameter("@LeaveType",SqlDbType.Int)
				};

                param[0].Value = month;
                param[1].Value = leaveType;

                sproc = new StoreProcedure(EmployeeLeaveKeys.Sp_Del_H0_EmployeeLeave_By_Month_LeaveType, param);
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
        public DataTable GetByFilterV1(int UserId, DateTime FromDate, DateTime ToDate)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                					
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@FromDate", SqlDbType.DateTime),
                    new SqlParameter("@ToDate", SqlDbType.DateTime),
				};

                param[0].Value = UserId;
                param[1].Value = FromDate;
                param[2].Value = ToDate;

                sproc = new StoreProcedure("Sel_H0_Employee_Leave_By_Filter", param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }
        public DataTable GetByFilterV2(int UserId, int EmployeeLeaveScheduleId, string Status)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                					
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@EmployeeLeaveScheduleId", SqlDbType.Int),
                    new SqlParameter("@Status", SqlDbType.VarChar, 50),
				};

                param[0].Value = UserId;
                param[1].Value = EmployeeLeaveScheduleId;
                param[2].Value = Status;

                sproc = new StoreProcedure("Sel_H0_Employee_Leave_By_FilterV1", param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }
        public DataTable GetByDeptId_Total(int UserId, int Month, int Year)
        {
            Debug.Assert(base.sproc == null);
            DataTable table = new DataTable();
            try
            {
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@UserId", SqlDbType.VarChar, 0xbb8), new SqlParameter("@Month", SqlDbType.Int), new SqlParameter("@Year", SqlDbType.Int) };
                parameters[0].Value = UserId;
                parameters[1].Value = Month;
                parameters[2].Value = Year;
                base.sproc = new StoreProcedure("Sel_H0_EmployeeLeave_By_DeptId_Include_Total_UserId", parameters);
                base.sproc.RunFill(table);
            }
            catch (SqlException exception)
            {
                throw new HRMException(exception.Message, (long)exception.Number);
            }
            return table;
        }
        public DataTable GetByFilter(string FullName, string DepartmentIds, System.Nullable<int> LeaveTypeId, System.Nullable<int> Month, System.Nullable<int> Year)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                					
                    new SqlParameter("@FullName", SqlDbType.NVarChar, 254),
                    new SqlParameter("@DepartmentIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@LeaveTypeId", SqlDbType.Int, 4),
                    new SqlParameter("@Date", SqlDbType.SmallDateTime)
				};

                if ((FullName == null))
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(FullName));
                }
                if ((DepartmentIds != null))
                {
                    param[1].Value = ((string)(DepartmentIds));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((LeaveTypeId.HasValue == true))
                {
                    param[2].Value = ((int)(LeaveTypeId.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if (Month > 0 && Year > 0)
                {
                    DateTime date = new DateTime((int)Year, (int)Month, 1);
                    param[3].Value = date;
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                //if ((Year.HasValue == true))
                //{
                //    param[4].Value = ((int)(Year.Value));
                //}
                //else
                //{
                //    param[4].Value = System.DBNull.Value;
                //}

                sproc = new StoreProcedure(EmployeeLeaveKeys.SP_EMPLOYEE_LEAVE_GET_BY_FILTER, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }
        public DataTable GetScheduleByFilter(string fullName, string departmentIds)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                					
                    new SqlParameter("@FullName", SqlDbType.NVarChar, 254),
                    new SqlParameter("@DepartmentIds", SqlDbType.VarChar, 1000)
				};

                if ((fullName == null))
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(fullName));
                }
                if ((departmentIds != null))
                {
                    param[1].Value = ((string)(departmentIds));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                
                sproc = new StoreProcedure("Sel_H0_EmployeeLeave_By_Filter_Schedule", param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }
        public DataTable GetById(long employeeLeaveId)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
					new SqlParameter("@EmployeeLeaveId",SqlDbType.Int)
				};

                param[0].Value = employeeLeaveId;

                sproc = new StoreProcedure(EmployeeLeaveKeys.SP_EMPLOYEE_LEAVE_GET_BY_ID, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }
        public DataTable GetByScheduleId(int ScheduleId)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
					new SqlParameter("@ScheduleId",SqlDbType.Int)
				};

                param[0].Value = ScheduleId;

                sproc = new StoreProcedure("Sel_H0_EmployeeLeave_By_ScheduleId", param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }
        public DataTable GetAllById(long employeeLeaveId)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
					new SqlParameter("@EmployeeLeaveId",SqlDbType.Int)
				};

                param[0].Value = employeeLeaveId;

                sproc = new StoreProcedure(EmployeeLeaveKeys.Sp_EmployeeLeave_All_By_Id, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }

        public DataTable GetByUserId_Date(int userId, int month, int year)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
					new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@Month",SqlDbType.Int),					
					new SqlParameter("@Year",SqlDbType.Int),					                
				};

                param[0].Value = userId;
                param[1].Value = month;
                param[2].Value = year;

                sproc = new StoreProcedure(EmployeeLeaveKeys.SP_EMPLOYEE_LEAVE_GET_BY_USERID_DATE, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }
        public DataTable GetAll_By_UserId_MaxF(int userId)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
					new SqlParameter("@UserId",SqlDbType.Int),				                
				};

                param[0].Value = userId;

                sproc = new StoreProcedure("Sel_H0_Employee_Max_Allowance_F", param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }
        public DataTable GetByUserIds_Date(int userId, int empLeaveId)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
					new SqlParameter("@UserId",SqlDbType.Int),				                
					new SqlParameter("@EmployeeLeaveId",SqlDbType.Int),
				};

                param[0].Value = userId;
                param[1].Value = empLeaveId;

                sproc = new StoreProcedure("Sel_H0_EmployeeLeave_By_Ids", param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }

        public DataTable GetByRecordTotal(int userId, int month, int year, int leaveTypeId, long groupId)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
					new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@Month",SqlDbType.Int),					
					new SqlParameter("@Year",SqlDbType.Int),					                
                    new SqlParameter("@LeaveTypeId",SqlDbType.Int),					
					new SqlParameter("@GroupId",SqlDbType.BigInt)					                
				};

                param[0].Value = userId;
                param[1].Value = month;
                param[2].Value = year;
                param[3].Value = leaveTypeId;
                param[4].Value = groupId;

                sproc = new StoreProcedure(EmployeeLeaveKeys.SP_EMPLOYEE_LEAVE_GET_BY_RECORD_TOTAL, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }

        public DataTable GetByUserId_LeaveType_Year(int userId, int leaveTypeId, int year, long groupId)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
					new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@LeaveTypeId",SqlDbType.Int),
					new SqlParameter("@Year",SqlDbType.Int),					                                    					
					new SqlParameter("@GroupId",SqlDbType.BigInt)					                
				};

                param[0].Value = userId;
                param[1].Value = leaveTypeId;
                param[2].Value = year;
                param[3].Value = groupId;

                sproc = new StoreProcedure(EmployeeLeaveKeys.SP_EMPLOYEE_LEAVE_GET_BY_USERID_LEAVETYPE_YEAR, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }

        public DataTable GetByUserId_LeaveType_Date(int userId, int leaveTypeId, int month, int year)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                             
					new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@LeaveTypeId",SqlDbType.Int),
                    new SqlParameter("@Month",SqlDbType.Int),
					new SqlParameter("@Year",SqlDbType.Int),					                                    					
										                
				};

                param[0].Value = userId;
                param[1].Value = leaveTypeId;
                param[2].Value = month;
                param[3].Value = year;


                sproc = new StoreProcedure(EmployeeLeaveKeys.SP_EMPLOYEE_LEAVE_GET_BY_USERID_LEAVETYPE_DATE, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }

        public DataTable GetByUserId_LeaveType_DateV1(int userId, int leaveTypeId, DateTime fromDate, DateTime toDate)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                             
					new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@LeaveTypeId",SqlDbType.Int),
                    new SqlParameter("@FromDate",SqlDbType.DateTime),
					new SqlParameter("@ToDate",SqlDbType.DateTime),					                                    					
										                
				};

                param[0].Value = userId;
                param[1].Value = leaveTypeId;
                param[2].Value = fromDate;
                param[3].Value = toDate;


                sproc = new StoreProcedure("Sel_H0_EmployeeLeave_By_UserId_LeaveType_DateV1", param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }

        public DataTable GetByDeptId_Date(string deptIds, int month, int year, int leaveCode)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                             
					new SqlParameter("@DeptIds",SqlDbType.VarChar, 1000),                    
                    new SqlParameter("@Month",SqlDbType.Int),
					new SqlParameter("@Year",SqlDbType.Int),					                                    					
					new SqlParameter("@LeaveCodeId",SqlDbType.Int),
										                
				};

                param[0].Value = deptIds;
                param[1].Value = month;
                param[2].Value = year;
                param[3].Value = leaveCode;

                sproc = new StoreProcedure(EmployeeLeaveKeys.Sp_Sel_H0_EmployeeLeave_By_DeptId_Date, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }

        public DataTable GetDTByDeptId_DateForExporting(string deptIds, int month, int year, int leaveCode)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                             
					new SqlParameter("@DeptIds",SqlDbType.VarChar, 1000),                    
                    new SqlParameter("@Month",SqlDbType.Int),
					new SqlParameter("@Year",SqlDbType.Int),					                                    					
					new SqlParameter("@LeaveCodeId",SqlDbType.Int),
										                
				};

                param[0].Value = deptIds;
                param[1].Value = month;
                param[2].Value = year;
                param[3].Value = leaveCode;

                sproc = new StoreProcedure("Sel_H0_EmployeeLeave_By_DeptId_Date_For_Exporting", param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }

        public DataTable GetMaxNP()
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                sproc = new StoreProcedure("Sel_H0_Employee_Leave_By_MaxLeaveNumber", null);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }
        public DataTable DT_GetAll(string Status)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                                 
                    new SqlParameter("@Status",SqlDbType.VarChar, 25),
										                
				};

                param[0].Value = Status;

                sproc = new StoreProcedure("Sel_H0_EmployeeLeave_By_All", param);
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
