using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H0;

namespace HRMDAL.H0
{
    public class EmployeeIdiFingerPrintDAL : Dao
    {
        #region insert, update, delete

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns>int</returns>
        public long Insert(System.Nullable<int> UserId, System.Nullable<int> FingerIndex, System.Nullable<int> IndexValue, byte[] Features)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{					
					new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@FingerIndex", SqlDbType.Int, 4),
                    new SqlParameter("@IndexValue", SqlDbType.Int, 4),
                    new SqlParameter("@Features", SqlDbType.Binary, 4000)
            
				};

                param[0].Value = UserId;
                param[1].Value = FingerIndex;
                param[2].Value = IndexValue;
                param[3].Value = Features;
                
                sproc = new StoreProcedure(EmployeeIdiFingerPrintKeys.Sp_Ins_H0_EmployeeIdiFingerPrint, param);
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

        public long Update(System.Nullable<int> UserId, System.Nullable<int> FingerIndex, System.Nullable<int> IndexValue, byte[] Features, System.Nullable<int> PK_UserFingerPrintId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =  
				{
                    
					new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@FingerIndex", SqlDbType.Int, 4),
                    new SqlParameter("@IndexValue", SqlDbType.Int, 4),
                    new SqlParameter("@Features", SqlDbType.Binary, 4000),
                    new SqlParameter("@PK_UserFingerPrintId", SqlDbType.Int)
				};

                param[0].Value = UserId;
                param[1].Value = FingerIndex;
                param[2].Value = IndexValue;
                param[3].Value = Features;
                param[4].Value = PK_UserFingerPrintId;

                sproc = new StoreProcedure(EmployeeIdiFingerPrintKeys.Sp_Upd_H0_EmployeeIdiFingerPrint, param);
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

        public int Delete(System.Nullable<int> PK_UserFingerPrintId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@PK_UserFingerPrintId",SqlDbType.Int)
				};

                param[0].Value = PK_UserFingerPrintId;

                sproc = new StoreProcedure(EmployeeIdiFingerPrintKeys.Sp_Del_H0_EmployeeIdiFingerPrint, param);
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

        public int DeleteByUserId(System.Nullable<int> UserId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@UserId",SqlDbType.Int, 4)
				};

                param[0].Value = UserId;

                sproc = new StoreProcedure(EmployeeIdiFingerPrintKeys.Sp_Del_H0_EmployeeIdiFingerPrintByUserId, param);
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

        public int DeleteByUserIdFingerIndex(System.Nullable<int> UserId, System.Nullable<int> FingerIndex)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@UserId",SqlDbType.Int, 4),
                    new SqlParameter("@FingerIndex",SqlDbType.Int, 4)
				};

                param[0].Value = UserId;
                param[1].Value = FingerIndex;

                sproc = new StoreProcedure(EmployeeIdiFingerPrintKeys.Sp_Del_H0_EmployeeIdiFingerPrintByUserIdFingerIndex, param);
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

        #region get

        public DataTable GetByFilter(System.Nullable<int> UserId, System.Nullable<int> FingerIndex, System.Nullable<int> RootId)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{
					new SqlParameter("@UserId",SqlDbType.Int,4),
                    new SqlParameter("@FingerIndex",SqlDbType.Int,4),
                    new SqlParameter("@RootId",SqlDbType.Int,4)
				};
                param[0].Value = UserId;
                param[1].Value = FingerIndex;
                param[2].Value = RootId;

                sproc = new StoreProcedure(EmployeeIdiFingerPrintKeys.Sp_Sel_H0_EmployeeIdiFingerPrintByFilter, param);
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
