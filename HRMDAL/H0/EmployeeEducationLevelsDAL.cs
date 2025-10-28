using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H0;

namespace HRMDAL.H0
{
    public class EmployeeEducationLevelsDAL : Dao
    {
        #region Methods Get       

        public DataTable GetById(int userId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {

                SqlParameter[] param = 
                {                     
                    new SqlParameter("@UserId",SqlDbType.Int)                    
                };

                param[0].Value = userId;

                sproc = new StoreProcedure(EmployeeEducationLevelKeys.SP_EMPLOYEE_EDUCATION_LEVEL_GET_BY_ID, param);
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

        #region methods inset, update , delete
        public long UpdateHighest(int userId, int educationLevelId)//, string trainingPlace, string trainingDepartment, string major, DateTime graduatingYear, string grade, string profession)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
                {                     
                    new SqlParameter("@UserId",SqlDbType.Int),                    
                    new SqlParameter("@EducationLevelId",SqlDbType.Int)

                };

                param[0].Value = userId;
                param[1].Value = educationLevelId;

                sproc = new StoreProcedure("Upd_H0_EmployeeEducationLevel_Highest_Candidate", param);
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
        public long Insert(int userId, int educationLevelId, string educationLevelValue, string remark)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
                {                     
                    new SqlParameter("@UserId",SqlDbType.Int),                    
                    new SqlParameter("@EducationLevelId",SqlDbType.Int),
                    new SqlParameter("@EducationLevelValue",SqlDbType.NVarChar, 254),
                    new SqlParameter("@Remark",SqlDbType.NVarChar, 1000),
                };

                param[0].Value = userId;
                param[1].Value = educationLevelId;
                param[2].Value = educationLevelValue;
                param[3].Value = remark;

                sproc = new StoreProcedure(EmployeeEducationLevelKeys.SP_EMPLOYEE_EDUCATION_LEVEL_INSERT, param);
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

        public long Update(int userId, int educationLevelId, string educationLevelValue, string remark, int id)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
                {                     
                    new SqlParameter("@UserId",SqlDbType.Int),                    
                    new SqlParameter("@EducationLevelId",SqlDbType.Int),
                    new SqlParameter("@EducationLevelValue",SqlDbType.NVarChar, 254),
                    new SqlParameter("@Remark",SqlDbType.NVarChar, 1000),
                    new SqlParameter("@Id",SqlDbType.Int)
                };

                param[0].Value = userId;
                param[1].Value = educationLevelId;
                param[2].Value = educationLevelValue;
                param[3].Value = remark == null ? string.Empty : remark;
                param[4].Value = id;

                sproc = new StoreProcedure(EmployeeEducationLevelKeys.SP_EMPLOYEE_EDUCATION_LEVEL_UPDATE, param);
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

        public long Delete(int id)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {
                SqlParameter[] param = 
                {                                
                    new SqlParameter("@Id",SqlDbType.Int),                    
                };

                param[0].Value = id;
                sproc = new StoreProcedure(EmployeeEducationLevelKeys.SP_EMPLOYEE_EDUCATION_LEVEL_DELETE, param);
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

        #endregion
    }
}
