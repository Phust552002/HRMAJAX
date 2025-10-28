using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H0;

namespace HRMDAL.H0
{
    public class UnofficialEmployeesDAL : Dao
    {

        #region method Get

        //////////////////////////////////////////////////////////////////
      

        //////////////////////////////////////////////////////////////////
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>


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
                sproc = new StoreProcedure(UnofficialEmployeeKeys.SP_UNOFFICIAL_EMPLOYEES_GETONE, param);
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

        public DataTable GetByDeptIds(string deptIds, int rootId, string fullname, int TypeSort)
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
                };

                param[0].Value = deptIds;
                param[1].Value = rootId;
                param[2].Value = fullname;
                param[3].Value = TypeSort;

                sproc = new StoreProcedure(UnofficialEmployeeKeys.Sp_Sel_H0_Unofficial_Employee_By_DeptIds, param);
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


        public long InsertDefault(string FullName, string fullName2, DateTime BirthDay, bool Sex, string HandPhone, int DepartmentId)
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
	                new SqlParameter("@DepartmentId",SqlDbType.Int)

					
                };

                param[0].Value = FullName;
                param[1].Value = fullName2;
                param[2].Value = BirthDay;
                param[3].Value = Sex;
                param[4].Value = HandPhone;
                param[5].Value = DepartmentId;


                sproc = new StoreProcedure(UnofficialEmployeeKeys.Sp_Ins_H0_UNOFFICIAL_EMPLOYEES_Default, param);
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

        public long UpdateInforGeneral(int sex, System.Nullable<System.DateTime> joinDate, string taxCode, string idCard, string resident, string live,
                    int status, System.Nullable<System.DateTime> leaveDate, int userId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {                
	
                SqlParameter[] param = 
				{
                    new SqlParameter("@Sex",SqlDbType.Int),
	                new SqlParameter("@JoinDate",SqlDbType.DateTime),
                    new SqlParameter("@TaxCode",SqlDbType.VarChar,50),	                
	                new SqlParameter("@IdCard",SqlDbType.VarChar, 50),
                    new SqlParameter("@Resident",SqlDbType.NVarChar, 254),
                    new SqlParameter("@Live",SqlDbType.NVarChar, 254),
                    new SqlParameter("@Status",SqlDbType.Int),
                    new SqlParameter("@LeaveDate",SqlDbType.SmallDateTime),
                    new SqlParameter("@UserId",SqlDbType.Int)
				};
                param[0].Value = sex;               

                if ((joinDate.HasValue == true))
                {
                    if (joinDate.Equals(FormatDate.GetSQLDateMinValue))
                    {
                        param[1].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[1].Value = ((System.DateTime)(joinDate.Value));
                    }
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                
                param[2].Value = taxCode;
                param[3].Value = idCard;
                param[4].Value = resident;
                param[5].Value = live;
                param[6].Value = status;
                
                if ((leaveDate.HasValue == true))
                {
                    if (leaveDate.Equals(FormatDate.GetSQLDateMinValue))
                    {
                        param[7].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[7].Value = ((System.DateTime)(leaveDate.Value));
                    }
                }
                else
                {
                    param[7].Value = System.DBNull.Value;
                }

                param[8].Value = userId;

                sproc = new StoreProcedure(UnofficialEmployeeKeys.Sp_Upd_H0_Unofficial_Employee_InforGeneral, param);
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
