using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H0;

namespace HRMDAL.H0
{
    public class EmployeeJobHistoryDAL : Dao
    {
        #region Insert, Update, Delete

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns>int</returns>
        public long Insert( System.Nullable<int> UserId, 
                            System.Nullable<int> FromYear, 
                            System.Nullable<int> ToYear, 
                            string Infor, 
                            System.Nullable<int> Type)
        {

            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{                                                   
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@FromYear", SqlDbType.Int, 4),
                    new SqlParameter("@ToYear", SqlDbType.Int, 4),
                    new SqlParameter("@Infor", SqlDbType.NVarChar, 2000),
                    new SqlParameter("@Type", SqlDbType.Int, 4),
				};

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((FromYear.HasValue == true))
                {
                    param[1].Value = ((int)(FromYear.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((ToYear.HasValue == true))
                {
                    param[2].Value = ((int)(ToYear.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((Infor == null))
                {
                    param[3].Value = System.DBNull.Value;
                }
                else
                {
                    param[3].Value = ((string)(Infor));
                }
                if ((Type.HasValue == true))
                {
                    param[4].Value = ((int)(Type.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(EmployeeJobHistoryKeys.Sp_EmployeeJobHistory_Insert, param);
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

        public long Update(
                            System.Nullable<int> UserId, 
                            System.Nullable<int> FromYear, 
                            System.Nullable<int> ToYear, 
                            string Infor, 
                            System.Nullable<int> Type, 
                            System.Nullable<long> JobHistoryId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
					new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@FromYear", SqlDbType.Int, 4),
                    new SqlParameter("@ToYear", SqlDbType.Int, 4),
                    new SqlParameter("@Infor", SqlDbType.NVarChar, 2000),
                    new SqlParameter("@Type", SqlDbType.Int, 4),
                    new SqlParameter("@JobHistoryId", SqlDbType.BigInt, 8)
				};

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((FromYear.HasValue == true))
                {
                    param[1].Value = ((int)(FromYear.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((ToYear.HasValue == true))
                {
                    param[2].Value = ((int)(ToYear.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((Infor == null))
                {
                    param[3].Value = System.DBNull.Value;
                }
                else
                {
                    param[3].Value = ((string)(Infor));
                }
                if ((Type.HasValue == true))
                {
                    param[4].Value = ((int)(Type.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((JobHistoryId.HasValue == true))
                {
                    param[5].Value = ((long)(JobHistoryId.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(EmployeeJobHistoryKeys.Sp_EmployeeJobHistory_Update, param);
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


        public long Delete(System.Nullable<long> JobHistoryId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                                                      
                    new SqlParameter("@JobHistoryId", SqlDbType.BigInt)
				};

                if ((JobHistoryId.HasValue == true))
                {
                    param[0].Value = ((long)(JobHistoryId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(EmployeeJobHistoryKeys.Sp_EmployeeJobHistory_Delete, param);
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



        public DataTable GetByFilter(System.Nullable<int> Type, System.Nullable<int> UserId)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                                    
                    new SqlParameter("@Type",SqlDbType.Int, 4),
                    new SqlParameter("@UserId",SqlDbType.Int, 4)
				};

                if ((Type.HasValue == true))
                {
                    param[0].Value = ((int)(Type.Value));
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

                sproc = new StoreProcedure(EmployeeJobHistoryKeys.Sp_EmployeeJobHistory_Get_By_Filter, param);
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
