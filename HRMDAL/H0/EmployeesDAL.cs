using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H0;

namespace HRMDAL.H0
{
    public class EmployeesDAL : Dao
    {

        #region method Get

        //////////////////////////////////////////////////////////////////
        public DataTable GetEmployeeDeptPositionByDeptId(int deptId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DepartmentId",SqlDbType.Int,4)
                };
                param[0].Value = deptId;
                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_DEPT_POSITION_GET_BY_DEPT_ID, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }

        public DataTable GetEmployeeDeptPositionByFilter(int deptId, string fullName)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@FullName",SqlDbType.NVarChar,100),
                    new SqlParameter("@DepartmentId",SqlDbType.Int,4)

                };
                param[0].Value = fullName;
                param[1].Value = deptId;
                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_DEPT_POSITION_GET_BY_FILTER, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }

        public DataTable GetEmployeeLeaveJobByFilter(int deptId, string fullName, int status)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@FullName",SqlDbType.NVarChar,100),
                    new SqlParameter("@DepartmentId",SqlDbType.Int,4),
                    new SqlParameter("@Status",SqlDbType.Int,4)
                };
                param[0].Value = fullName;
                param[1].Value = deptId;
                param[2].Value = status;
                sproc = new StoreProcedure(EmployeeKeys.Sp_Sel_H0_Employee_LeaveJob_By_Filter, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }

        //////////////////////////////////////////////////////////////////
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>


        public DataTable GetAll()
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_GETALL, null);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }
            return datatable;

        }

        public DataTable GetAll2()
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                sproc = new StoreProcedure("Sel_H0_Employee_By_All2", null);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }
            return datatable;

        }

        public DataTable GetByRootId(int rootId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@RootId",SqlDbType.Int,4)
                };
                param[0].Value = rootId;
                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_GET_BY_ROOT_ID, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }

        public DataTable GetByDeptId(int deptId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DeptId",SqlDbType.Int,4)
                };
                param[0].Value = deptId;
                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_GET_BY_DEPT_ID, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }

        public DataTable GetByDeptIds(string deptIds, int rootId, string fullname, int TypeSort, string AirlinesWorking)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DeptIds",SqlDbType.VarChar,1000),
                    new SqlParameter("@RootId",SqlDbType.Int),
                    new SqlParameter("@FullName",SqlDbType.NVarChar,254),
                    new SqlParameter("@TypeSort",SqlDbType.Int),
                    new SqlParameter("@AirlinesWorking",SqlDbType.VarChar,100)
                };

                param[0].Value = deptIds;
                param[1].Value = rootId;
                param[2].Value = fullname;
                param[3].Value = TypeSort;
                param[4].Value = AirlinesWorking;

                sproc = new StoreProcedure(EmployeeKeys.Sp_Sel_H0_Employee_By_DeptIds, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }

        public DataTable GetOne(int userId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId",SqlDbType.Int,4)
                };
                param[0].Value = userId;
                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_GETONE, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }
        public DataTable GetDeactiveUser(int userId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId",SqlDbType.Int,4)
                };
                param[0].Value = userId;
                sproc = new StoreProcedure("Sel_H0_UserDeactivation_by_Userid", param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }
        public DataTable GetUserByFilter(int deptId, string fullName)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@FullName",SqlDbType.NVarChar,100),
                    new SqlParameter("@DepartmentId",SqlDbType.Int,4)

                };
                param[0].Value = fullName;
                param[1].Value = deptId;
                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_GET_BY_FILTER, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }

        public DataTable GetByIds(string userIds)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserIds",SqlDbType.VarChar,1000),
                };
                param[0].Value = userIds;
                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_GET_BY_IDs, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }

        public DataTable Login(string userName, string password)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserName",SqlDbType.VarChar, 50),
                    new SqlParameter("@Password",SqlDbType.VarChar, 50)

                };
                param[0].Value = userName;
                param[1].Value = password;

                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_LOGIN, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }

        public DataTable GetByUserCodeIsNull()
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_GET_BY_USERCODE_IS_NULL, null);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }
            return datatable;

        }

        public DataTable GetByFilterAccountBank(string fullName, int rootId, string accountNo, string CardNo, int IsExists)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@FullName",SqlDbType.NVarChar,100),
                    new SqlParameter("@RootId",SqlDbType.Int,4),
                    new SqlParameter("@AccountNo",SqlDbType.VarChar, 50),
                    new SqlParameter("@CardNo",SqlDbType.VarChar, 50),
                    new SqlParameter("@IsExists",SqlDbType.Int)
                };

                param[0].Value = fullName;
                param[1].Value = rootId;
                param[2].Value = accountNo;
                param[3].Value = CardNo;
                param[4].Value = IsExists;

                sproc = new StoreProcedure(EmployeeKeys.Sp_Sel_H0_Employee_By_FilterAccountBank, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }

        public DataTable GetByStatus(string fullname, int status)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@FullName",SqlDbType.NVarChar, 254),
                    new SqlParameter("@Status",SqlDbType.Int)
                };

                param[0].Value = fullname;
                param[1].Value = status;

                sproc = new StoreProcedure(EmployeeKeys.Sp_Sel_H0_Employee_By_Status, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }

        public DataTable GetByMoreSearch(System.Nullable<int> UserId, string UserName, string EmployeeCode, string FullName,
            System.Nullable<int> Status, System.Nullable<int> MonthOfLeave, System.Nullable<int> YearOfLeave,
            System.Nullable<int> MonthOfBirth, System.Nullable<int> YearOfBirth, System.Nullable<int> MonthOfJoinDate,
            System.Nullable<int> YearOfJoinDate, System.Nullable<int> MonthOfJoinCompanyDate, System.Nullable<int> YearOfJoinCompanyDate,
            System.Nullable<int> RootId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@UserName", SqlDbType.VarChar, 50),
                    new SqlParameter("@EmployeeCode", SqlDbType.VarChar, 50),
                    new SqlParameter("@FullName", SqlDbType.NVarChar, 100),
                    new SqlParameter("@Status", SqlDbType.Int, 4),
                    new SqlParameter("@MonthOfLeave", SqlDbType.Int, 4),
                    new SqlParameter("@YearOfLeave", SqlDbType.Int, 4),
                    new SqlParameter("@MonthOfBirth", SqlDbType.Int, 4),
                    new SqlParameter("@YearOfBirth", SqlDbType.Int, 4),
                    new SqlParameter("@MonthOfJoinDate", SqlDbType.Int, 4),
                    new SqlParameter("@YearOfJoinDate", SqlDbType.Int, 4),
                    new SqlParameter("@MonthOfJoinCompanyDate", SqlDbType.Int, 4),
                    new SqlParameter("@YearOfJoinCompanyDate", SqlDbType.Int, 4),
                    new SqlParameter("@RootId", SqlDbType.Int, 4)

                };

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((UserName == null))
                {
                    param[1].Value = System.DBNull.Value;
                }
                else
                {
                    param[1].Value = ((string)(UserName));
                }
                if ((EmployeeCode == null))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = ((string)(EmployeeCode));
                }
                if ((FullName == null))
                {
                    param[3].Value = System.DBNull.Value;
                }
                else
                {
                    param[3].Value = ((string)(FullName));
                }
                if ((Status.HasValue == true))
                {
                    param[4].Value = ((int)(Status.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((MonthOfLeave.HasValue == true))
                {
                    param[5].Value = ((int)(MonthOfLeave.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                if ((YearOfLeave.HasValue == true))
                {
                    param[6].Value = ((int)(YearOfLeave.Value));
                }
                else
                {
                    param[6].Value = System.DBNull.Value;
                }
                if ((MonthOfBirth.HasValue == true))
                {
                    param[7].Value = ((int)(MonthOfBirth.Value));
                }
                else
                {
                    param[7].Value = System.DBNull.Value;
                }
                if ((YearOfBirth.HasValue == true))
                {
                    param[8].Value = ((int)(YearOfBirth.Value));
                }
                else
                {
                    param[8].Value = System.DBNull.Value;
                }
                if ((MonthOfJoinDate.HasValue == true))
                {
                    param[9].Value = ((int)(MonthOfJoinDate.Value));
                }
                else
                {
                    param[9].Value = System.DBNull.Value;
                }
                if ((YearOfJoinDate.HasValue == true))
                {
                    param[10].Value = ((int)(YearOfJoinDate.Value));
                }
                else
                {
                    param[10].Value = System.DBNull.Value;
                }
                if ((MonthOfJoinCompanyDate.HasValue == true))
                {
                    param[11].Value = ((int)(MonthOfJoinCompanyDate.Value));
                }
                else
                {
                    param[11].Value = System.DBNull.Value;
                }
                if ((YearOfJoinCompanyDate.HasValue == true))
                {
                    param[12].Value = ((int)(YearOfJoinCompanyDate.Value));
                }
                else
                {
                    param[12].Value = System.DBNull.Value;
                }
                if ((RootId.HasValue == true))
                {
                    param[13].Value = ((int)(RootId.Value));
                }
                else
                {
                    param[13].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(EmployeeKeys.Sp_Sel_H0_Employee_By_MoreSearch, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }

        /// <summary>
        /// Dung them vao ngay 26MAR10
        /// </summary>
        /// <returns></returns>
        public DataTable GetTodayBirthdayEmployees()
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = { };
                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_GET_TODAY_BIRTHDAY_LIST, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }


        public DataTable GetByEmployeeCode(string employeeCode)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@EmployeeCode", SqlDbType.VarChar, 50)
                };
                param[0].Value = employeeCode;
                sproc = new StoreProcedure(EmployeeKeys.Sp_Sel_H0_Employee_By_EmployeeCode, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }
        public DataTable GetByStocks(string deptIds, int rootId, string fullname, int TypeSort, int StockDayOfPayment, int StockMonthOfPayment, int StockYearOfPayment, int ConfirmStocks)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DeptIds",SqlDbType.VarChar,254),
                    new SqlParameter("@RootId",SqlDbType.Int),
                    new SqlParameter("@FullName",SqlDbType.NVarChar,254),
                    new SqlParameter("@TypeSort",SqlDbType.Int),
                    new SqlParameter("@StockDayOfPayment",SqlDbType.Int),
                    new SqlParameter("@StockMonthOfPayment",SqlDbType.Int),
                    new SqlParameter("@StockYearOfPayment",SqlDbType.Int),
                    new SqlParameter("@ConfirmStocks",SqlDbType.Int)
                };

                param[0].Value = deptIds;
                param[1].Value = rootId;
                param[2].Value = fullname;
                param[3].Value = TypeSort;
                param[4].Value = StockDayOfPayment;
                param[5].Value = StockMonthOfPayment;
                param[6].Value = StockYearOfPayment;
                param[7].Value = ConfirmStocks;

                sproc = new StoreProcedure(EmployeeKeys.Sp_Sel_H0_EmployeeByStock, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }
        public DataTable GetByStocksForTotal(string deptIds, int rootId, string fullname, int TypeSort, int StockDayOfPayment, int StockMonthOfPayment, int StockYearOfPayment, int ConfirmStocks)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DeptIds",SqlDbType.VarChar,254),
                    new SqlParameter("@RootId",SqlDbType.Int),
                    new SqlParameter("@FullName",SqlDbType.NVarChar,254),
                    new SqlParameter("@TypeSort",SqlDbType.Int),
                    new SqlParameter("@StockDayOfPayment",SqlDbType.Int),
                    new SqlParameter("@StockMonthOfPayment",SqlDbType.Int),
                    new SqlParameter("@StockYearOfPayment",SqlDbType.Int),
                    new SqlParameter("@ConfirmStocks",SqlDbType.Int)
                };

                param[0].Value = deptIds;
                param[1].Value = rootId;
                param[2].Value = fullname;
                param[3].Value = TypeSort;
                param[4].Value = StockDayOfPayment;
                param[5].Value = StockMonthOfPayment;
                param[6].Value = StockYearOfPayment;
                param[7].Value = ConfirmStocks;

                sproc = new StoreProcedure(EmployeeKeys.Sp_Sel_H0_EmployeeByStockForTotal, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;
        }

        public DataTable GetStockForReport()
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                sproc = new StoreProcedure(EmployeeKeys.Sp_Sel_H0_EmployeeByStockForReport, null);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }
            return datatable;

        }
        #endregion


        #region methods insert, update, delete
        public long UpdateDirectWorking(int directWorking, int userId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {

                SqlParameter[] param =
                {
                    new SqlParameter("@DirectWorking",SqlDbType.Int),
                    new SqlParameter("@UserId",SqlDbType.Int),
                };

                param[0].Value = directWorking;
                param[1].Value = userId;


                sproc = new StoreProcedure("Upd_H0_Employee_DirectWorking", param);
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

        public long InsertByImporting(string userCode, string fullName, string departmentName, string positionName)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserCode",SqlDbType.VarChar, 50),
                    new SqlParameter("@FullName",SqlDbType.NVarChar, 100),
                    new SqlParameter("@DepartmentName",SqlDbType.NVarChar, 100),
                    new SqlParameter("@PositionName",SqlDbType.NVarChar, 100)
                };
                param[0].Value = userCode;
                param[1].Value = fullName;
                param[2].Value = departmentName;
                param[3].Value = positionName;


                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_INSERT_BY_IMPORTING, param);
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

        #region draft

        public long InsertDefault(string FullName, string fullName2, DateTime BirthDay, bool Sex, string HandPhone, string HomePhone, int Status, int DepartmentId, int educationLevelId, string educationLevelValue, string remark)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@FullName",SqlDbType.NVarChar, 100),
                    new SqlParameter("@FullName2",SqlDbType.NVarChar, 100),
                    new SqlParameter("@BirthDay",SqlDbType.DateTime),
                    new SqlParameter("@Sex",SqlDbType.Bit),
                    new SqlParameter("@HandPhone",SqlDbType.VarChar, 50),
                    new SqlParameter("@HomePhone",SqlDbType.VarChar, 50),
                    new SqlParameter("@Status",SqlDbType.Int),
                    new SqlParameter("@DepartmentId",SqlDbType.Int),
                    new SqlParameter("@EducationLevelId",SqlDbType.Int),
                    new SqlParameter("@EducationLevelValue",SqlDbType.NVarChar, 4000),
                    new SqlParameter("@Remark",SqlDbType.NVarChar, 4000),


                };

                param[0].Value = FullName;
                param[1].Value = fullName2;
                param[2].Value = BirthDay;
                param[3].Value = Sex;
                param[4].Value = HandPhone;
                param[5].Value = HomePhone;
                param[6].Value = Status;
                param[7].Value = DepartmentId;
                param[8].Value = educationLevelId;
                param[9].Value = educationLevelValue;
                param[10].Value = remark;

                sproc = new StoreProcedure(EmployeeKeys.Sp_Ins_H0_Employees_Default, param);
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

        public long UpdateInforGeneral(int sex, bool marriage, System.Nullable<System.DateTime> joinDate, System.Nullable<System.DateTime> joinCompanyDate,
                    string workingPhone, string businessEmail, string taxCode, string healthInsuranceAddress, string socialInsuranceNo,
                    int status, System.Nullable<System.DateTime> leaveDate, int userId, string healthInsuranceCardNo)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {

                SqlParameter[] param =
                {
                    new SqlParameter("@Sex",SqlDbType.Int),
                    new SqlParameter("@Marriage",SqlDbType.Bit),
                    new SqlParameter("@JoinDate",SqlDbType.DateTime),
                    new SqlParameter("@JoinCompanyDate",SqlDbType.DateTime),
                    new SqlParameter("@WorkingPhone",SqlDbType.VarChar,50),
                    new SqlParameter("@BusinessEmail",SqlDbType.VarChar,50),
                    new SqlParameter("@TaxCode",SqlDbType.VarChar, 50),
                    new SqlParameter("@HealthInsuranceAddress",SqlDbType.NVarChar, 100),
                    new SqlParameter("@SocialInsuranceNo",SqlDbType.VarChar, 50),
                    new SqlParameter("@Status",SqlDbType.Int),
                    new SqlParameter("@LeaveDate",SqlDbType.SmallDateTime),
                    new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@HealthInsuranceCardNo",SqlDbType.VarChar, 50),
                };
                param[0].Value = sex;
                param[1].Value = marriage;

                if ((joinDate.HasValue == true))
                {
                    if (joinDate.Equals(FormatDate.GetSQLDateMinValue))
                    {
                        param[2].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[2].Value = ((System.DateTime)(joinDate.Value));
                    }
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((joinCompanyDate.HasValue == true))
                {
                    if (joinCompanyDate.Equals(FormatDate.GetSQLDateMinValue))
                    {
                        param[3].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[3].Value = ((System.DateTime)(joinCompanyDate.Value));
                    }
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }

                param[4].Value = workingPhone;
                param[5].Value = businessEmail;
                param[6].Value = taxCode;
                param[7].Value = healthInsuranceAddress;
                param[8].Value = socialInsuranceNo;
                param[9].Value = status;

                if ((leaveDate.HasValue == true))
                {
                    if (leaveDate.Equals(FormatDate.GetSQLDateMinValue))
                    {
                        param[10].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[10].Value = ((System.DateTime)(leaveDate.Value));
                    }
                }
                else
                {
                    param[10].Value = System.DBNull.Value;
                }

                param[11].Value = userId;
                param[12].Value = healthInsuranceCardNo;

                sproc = new StoreProcedure(EmployeeKeys.Sp_Upd_H0_Employee_InforGeneral, param);
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

        public long UpdateInforDetail(string fullName, string otherNames, string normalNames, int sex,
            DateTime birthday, string birthPlace, string nativePlaceVneid, string handPhone, string homePhone,
            string idCard, DateTime dateOfIssue, string placeOfIssue, string nation, string nationality,
            string religion, string origin, DateTime dateJoinParty, string placeJoinParty, DateTime dateJoinCYU, string placeJoinCYU,
            DateTime dateOfEnlisted, DateTime dateOfDemobilized, string armyRank, string workedCompany, string residentstreet,
            string residentcity, string residentward, string livestreet, string livecity, string liveward, int userId)
        {

            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {

                SqlParameter[] param =
                {

                    new SqlParameter("@FullName",SqlDbType.NVarChar, 100),
                    new SqlParameter("@OtherNames",SqlDbType.NVarChar, 100),
                    new SqlParameter("@NormalNames",SqlDbType.NVarChar, 100),
                    new SqlParameter("@Sex",SqlDbType.Int),
                    new SqlParameter("@Birthday",SqlDbType.DateTime),
                    new SqlParameter("@BirthPlace",SqlDbType.NVarChar,254),
                    new SqlParameter("@NativePlace_Vneid",SqlDbType.NVarChar,254),
                    new SqlParameter("@HandPhone",SqlDbType.VarChar,50),
                    new SqlParameter("@HomePhone",SqlDbType.VarChar,50),
                    new SqlParameter("@IdCard",SqlDbType.VarChar, 50),
                    new SqlParameter("@DateOfIssue",SqlDbType.DateTime),
                    new SqlParameter("@PlaceOfIssue",SqlDbType.NVarChar,254),
                    new SqlParameter("@Nation",SqlDbType.NVarChar, 50),
                    new SqlParameter("@Nationality",SqlDbType.NVarChar, 50),
                    new SqlParameter("@Religion",SqlDbType.NVarChar, 50),
                    new SqlParameter("@Origin",SqlDbType.NVarChar, 254),
                    new SqlParameter("@DateJoinParty",SqlDbType.DateTime),
                    new SqlParameter("@PlaceJoinParty",SqlDbType.NVarChar, 254),
                    new SqlParameter("@DateJoinCYU",SqlDbType.DateTime),
                    new SqlParameter("@PlaceJoinCYU",SqlDbType.NVarChar, 254),
                    new SqlParameter("@DateOfEnlisted",SqlDbType.DateTime),
                    new SqlParameter("@DateOfDemobilized",SqlDbType.DateTime),
                    new SqlParameter("@ArmyRank",SqlDbType.NVarChar, 254),
                    new SqlParameter("@WorkedCompany",SqlDbType.NText),
                    new SqlParameter("@Resident_street",SqlDbType.NVarChar, 254),
                    new SqlParameter("@Resident_city",SqlDbType.NVarChar, 254),
                    new SqlParameter("@Resident_ward",SqlDbType.NVarChar, 254),
                    new SqlParameter("@Live_street",SqlDbType.NVarChar, 254),
                    new SqlParameter("@Live_city",SqlDbType.NVarChar, 254),
                    new SqlParameter("@Live_ward",SqlDbType.NVarChar, 254),
                    new SqlParameter("@UserId",SqlDbType.Int),
                };

                param[0].Value = fullName;
                param[1].Value = otherNames;
                param[2].Value = normalNames;
                param[3].Value = sex;
                param[4].Value = birthday;
                param[5].Value = birthPlace;
                param[6].Value = nativePlaceVneid;
                param[7].Value = handPhone;
                param[8].Value = homePhone;
                param[9].Value = idCard;
                param[10].Value = dateOfIssue;
                param[11].Value = placeOfIssue;
                param[12].Value = nation;
                param[13].Value = nationality;
                param[14].Value = religion;
                param[15].Value = origin;
                param[16].Value = dateJoinParty;
                param[17].Value = placeJoinParty;
                param[18].Value = dateJoinCYU;
                param[19].Value = placeJoinCYU;
                param[20].Value = dateOfEnlisted;
                param[21].Value = dateOfDemobilized;
                param[22].Value = armyRank;
                param[23].Value = workedCompany;
                param[24].Value = residentstreet;
                param[25].Value = residentcity;
                param[26].Value = residentward;
                param[27].Value = livestreet;
                param[28].Value = livecity;
                param[29].Value = liveward;
                param[30].Value = userId;


                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_UPDATE_INFOR_DETAIL, param);
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

        public long UpdateEmployeeCode(string employeeCode, int userId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@EmployeeCode",SqlDbType.VarChar, 50),
                    new SqlParameter("@UserId",SqlDbType.Int),

                };

                param[0].Value = employeeCode;
                param[1].Value = userId;

                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_UPDATE_EMPLOYEE_CODE, param);
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

        public long UpdateAccountBank(string AccountNo, string CardNo, string BankName, int userId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@AccountNo",SqlDbType.VarChar, 50),
                    new SqlParameter("@CardNo",SqlDbType.VarChar, 50),
                    new SqlParameter("@BankName",SqlDbType.NVarChar, 254),
                    new SqlParameter("@UserId",SqlDbType.Int),

                };

                param[0].Value = AccountNo;
                param[1].Value = CardNo;
                param[2].Value = BankName;
                param[3].Value = userId;

                sproc = new StoreProcedure(EmployeeKeys.Sp_Upd_H0_Employee_AccountBank, param);
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

        public long UpdateStatus(int Status, System.Nullable<DateTime> LeaveDate, string LeaveRemark, int userId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@Status",SqlDbType.Int),
                    new SqlParameter("@LeaveDate",SqlDbType.DateTime),
                    new SqlParameter("@LeaveRemark",SqlDbType.NVarChar,1000),
                    new SqlParameter("@UserId",SqlDbType.Int),

                };

                param[0].Value = Status;

                if ((LeaveDate.HasValue == true))
                {
                    param[1].Value = LeaveDate;
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                param[2].Value = LeaveRemark;
                param[3].Value = userId;

                sproc = new StoreProcedure(EmployeeKeys.Sp_Upd_H0_Employee_Status, param);
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

        public long UpdateEmployeeInfoFromCandidate(int userId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId",SqlDbType.Int),

                };

                param[0].Value = userId;

                sproc = new StoreProcedure("Upd_H0_EmployeeInfo_FromCandidate", param);
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

        public long UpdateFullName2(string fullName2, int userId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@FullName2",SqlDbType.VarChar, 100),
                    new SqlParameter("@UserId",SqlDbType.Int),

                };

                param[0].Value = fullName2;
                param[1].Value = userId;

                sproc = new StoreProcedure(EmployeeKeys.Sp_Upd_H0_EmployeeForFullName2, param);
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
        
        public long UpdateEmployeeAddress(int userId, string livestreet, string livecity, string liveward)
         {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@Live_street",SqlDbType.NVarChar,254),
                    new SqlParameter("@Live_city",SqlDbType.NVarChar,254),
                    new SqlParameter("@Live_ward",SqlDbType.NVarChar,254)
                    
                };

                param[0].Value = userId;
                param[1].Value = livestreet;
                param[2].Value = livecity;
                param[3].Value = liveward; 

                 sproc = new StoreProcedure("Upd_H0_Employee_Address", param);
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

        public long UpdateEmployeeAddress2(int userId, string residentstreet, string residentcity, string residentward)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@Resident_street",SqlDbType.NVarChar,254),
                    new SqlParameter("@Resident_city",SqlDbType.NVarChar,254),
                    new SqlParameter("@Resident_ward",SqlDbType.NVarChar,254)

                };

                param[0].Value = userId;
                param[1].Value = residentstreet;
                param[2].Value = residentcity;
                param[3].Value = residentward;

                sproc = new StoreProcedure("Upd_H0_Employee_Address2", param);
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
        public long UpdateTaxCode(string taxCode, int userId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@TaxCode",SqlDbType.VarChar, 50),
                    new SqlParameter("@UserId",SqlDbType.Int)

                };

                param[0].Value = taxCode;
                param[1].Value = userId;

                sproc = new StoreProcedure(EmployeeKeys.Sp_Upd_H0_Employee_TaxCode, param);
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
        public long UpdatePassword(string Password, int UserId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@Password",SqlDbType.VarChar, 1000),
                    new SqlParameter("@UserId",SqlDbType.Int)

                };

                param[0].Value = Password;
                param[1].Value = UserId;

                sproc = new StoreProcedure(EmployeeKeys.Sp_Upd_H0_Employee_Password, param);
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

        public long UpdateStock(string HandPhone, string HomePhone, string Resident, string Live, string IdCard, DateTime DateOfIssue, string PlaceOfIssue,
                                int InvestorNo, int SeniorStock, int UndertakingYear, int UnderTakingStock, int SeniorStockBought, int UnderTakingStockBought, decimal TotalMoneyBought, int UpdatedUserid,
                                DateTime UpdatedDate, int ConfirmStocks, DateTime StockDateOfPayment, string StockRemark, int UserId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {

                SqlParameter[] param =
                {

                    new SqlParameter("@HandPhone",SqlDbType.VarChar,50),
                    new SqlParameter("@HomePhone",SqlDbType.VarChar,50),
                    new SqlParameter("@Resident",SqlDbType.NVarChar,254),
                    new SqlParameter("@Live",SqlDbType.NVarChar,254),
                    new SqlParameter("@IdCard",SqlDbType.VarChar,50),
                    new SqlParameter("@DateOfIssue",SqlDbType.DateTime),
                    new SqlParameter("@PlaceOfIssue",SqlDbType.NVarChar,254),
                    new SqlParameter("@InvestorNo",SqlDbType.Int),
                    new SqlParameter("@SeniorStock",SqlDbType.Int),
                    new SqlParameter("@UndertakingYear",SqlDbType.Int),
                    new SqlParameter("@UnderTakingStock",SqlDbType.Int),
                    new SqlParameter("@SeniorStockBought",SqlDbType.Int),
                    new SqlParameter("@UnderTakingStockBought",SqlDbType.Int),
                    new SqlParameter("@TotalMoneyBought",SqlDbType.Float),
                    new SqlParameter("@UpdatedUserid",SqlDbType.Int),
                    new SqlParameter("@UpdatedDate",SqlDbType.DateTime),
                    new SqlParameter("@ConfirmStocks",SqlDbType.Int),
                    new SqlParameter("@StockDateOfPayment",SqlDbType.DateTime),
                    new SqlParameter("@StockRemark",SqlDbType.NVarChar, 1000),
                    new SqlParameter("@UserId",SqlDbType.Int)

                };

                param[0].Value = HandPhone;
                param[1].Value = HomePhone;
                param[2].Value = Resident;
                param[3].Value = Live;
                param[4].Value = IdCard;
                param[5].Value = DateOfIssue;
                param[6].Value = PlaceOfIssue;
                param[7].Value = InvestorNo;
                param[8].Value = SeniorStock;
                param[9].Value = UndertakingYear;
                param[10].Value = UnderTakingStock;
                param[11].Value = SeniorStockBought;
                param[12].Value = UnderTakingStockBought;
                param[13].Value = TotalMoneyBought;
                param[14].Value = UpdatedUserid;
                param[15].Value = UpdatedDate;
                param[16].Value = ConfirmStocks;
                param[17].Value = StockDateOfPayment;
                param[18].Value = StockRemark;
                param[19].Value = UserId;


                sproc = new StoreProcedure(EmployeeKeys.Sp_Upd_EmployeeStock, param);
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


        #region other methods

        public long ChangePassword(string userName, string oldPassword, string newPassword)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserName",SqlDbType.VarChar, 50),
                    new SqlParameter("@OldPassword",SqlDbType.VarChar, 50),
                    new SqlParameter("@NewPassword",SqlDbType.NVarChar, 100)
                };
                param[0].Value = userName;
                param[1].Value = oldPassword;
                param[2].Value = newPassword;


                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_UPDATE_CHANGE_PASSWORD, param);
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
        public long DeactiveUser(int userId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId",SqlDbType.Int)
                };
                param[0].Value = userId;


                sproc = new StoreProcedure("sp_ResetUserPassword", param);
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
        public long Delete(int userId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId",SqlDbType.Int)
                };
                param[0].Value = userId;

                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_DELETE, param);
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

        public long CheckNewEmployee(string userCode)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserCode",SqlDbType.VarChar)
                };
                param[0].Value = userCode;

                sproc = new StoreProcedure(EmployeeKeys.SP_EMPLOYEES_CHECK_NEW_EMPLOYEE, param);
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

    }
}
