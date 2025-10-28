using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H0;

namespace HRMDAL.H0
{
    public class EmployeeRelationDAL : Dao
    {
        #region Insert, Update, Delete

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns>int</returns>
        public long Insert( System.Nullable<int> UserId, 
                            System.Nullable<int> RelationTypeId, 
                            string RFullName, 
                            System.Nullable<int> RDayOfBirth, 
                            System.Nullable<int> RMonthOfBirth, 
                            System.Nullable<int> RYearOfBirth, 
                            string RNativePlace, 
                            string RResident, 
                            string RLive, 
                            string Before1975, 
                            string After1975, 
                            string Participate, 
                            System.Nullable<bool> Died, 
                            string DiedCause, 
                            string Others)
        {

            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{                                
					
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@RelationTypeId", SqlDbType.Int, 4),
                    new SqlParameter("@RFullName", SqlDbType.NVarChar, 254),
                    new SqlParameter("@RDayOfBirth", SqlDbType.Int, 4),
                    new SqlParameter("@RMonthOfBirth", SqlDbType.Int, 4),
                    new SqlParameter("@RYearOfBirth", SqlDbType.Int, 4),
                    new SqlParameter("@RNativePlace", SqlDbType.NVarChar, 254),
                    new SqlParameter("@RResident", SqlDbType.NVarChar, 254),
                    new SqlParameter("@RLive", SqlDbType.NVarChar, 254),
                    new SqlParameter("@Before1975", SqlDbType.NText),
                    new SqlParameter("@After1975", SqlDbType.NText),
                    new SqlParameter("@Participate", SqlDbType.NVarChar),
                    new SqlParameter("@Died", SqlDbType.Bit, 1),
                    new SqlParameter("@DiedCause", SqlDbType.NVarChar, 254),
                    new SqlParameter("@Others", SqlDbType.NVarChar, 254)
				};
                
                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((RelationTypeId.HasValue == true))
                {
                    param[1].Value = ((int)(RelationTypeId.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((RFullName == null))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = ((string)(RFullName));
                }
                if ((RDayOfBirth.HasValue == true))
                {
                    param[3].Value = ((int)(RDayOfBirth.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((RMonthOfBirth.HasValue == true))
                {
                    param[4].Value = ((int)(RMonthOfBirth.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((RYearOfBirth.HasValue == true))
                {
                    param[5].Value = ((int)(RYearOfBirth.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                if ((RNativePlace == null))
                {
                    param[6].Value = System.DBNull.Value;
                }
                else
                {
                    param[6].Value = ((string)(RNativePlace));
                }
                if ((RResident == null))
                {
                    param[7].Value = System.DBNull.Value;
                }
                else
                {
                    param[7].Value = ((string)(RResident));
                }
                if ((RLive == null))
                {
                    param[8].Value = System.DBNull.Value;
                }
                else
                {
                    param[8].Value = ((string)(RLive));
                }
                if ((Before1975 == null))
                {
                    param[9].Value = System.DBNull.Value;
                }
                else
                {
                    param[9].Value = ((string)(Before1975));
                }
                if ((After1975 == null))
                {
                    param[10].Value = System.DBNull.Value;
                }
                else
                {
                    param[10].Value = ((string)(After1975));
                }
                if ((Participate == null))
                {
                    param[11].Value = System.DBNull.Value;
                }
                else
                {
                    param[11].Value = ((string)(Participate));
                }
                if ((Died.HasValue == true))
                {
                    param[12].Value = ((bool)(Died.Value));
                }
                else
                {
                    param[12].Value = System.DBNull.Value;
                }
                if ((DiedCause == null))
                {
                    param[13].Value = System.DBNull.Value;
                }
                else
                {
                    param[13].Value = ((string)(DiedCause));
                }
                if ((Others == null))
                {
                    param[14].Value = System.DBNull.Value;
                }
                else
                {
                    param[14].Value = ((string)(Others));
                }

                sproc = new StoreProcedure(EmployeeRelationKeys.Sp_EmployeeRelation_Insert, param);
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

        public long Update(System.Nullable<int> UserId,
                    System.Nullable<int> RelationTypeId,
                    string RFullName,
                    System.Nullable<int> RDayOfBirth,
                    System.Nullable<int> RMonthOfBirth,
                    System.Nullable<int> RYearOfBirth,
                    string RNativePlace,
                    string RResident,
                    string RLive,
                    string Before1975,
                    string After1975,
                    string Participate,
                    System.Nullable<bool> Died,
                    string DiedCause,
                    string Others,
                    System.Nullable<long> UserRelationId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
					
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@RelationTypeId", SqlDbType.Int, 4),
                    new SqlParameter("@RFullName", SqlDbType.NVarChar, 254),
                    new SqlParameter("@RDayOfBirth", SqlDbType.Int, 4),
                    new SqlParameter("@RMonthOfBirth", SqlDbType.Int, 4),
                    new SqlParameter("@RYearOfBirth", SqlDbType.Int, 4),
                    new SqlParameter("@RNativePlace", SqlDbType.NVarChar, 254),
                    new SqlParameter("@RResident", SqlDbType.NVarChar, 254),
                    new SqlParameter("@RLive", SqlDbType.NVarChar, 254),
                    new SqlParameter("@Before1975", SqlDbType.NText),
                    new SqlParameter("@After1975", SqlDbType.NText),
                    new SqlParameter("@Participate", SqlDbType.NVarChar),
                    new SqlParameter("@Died", SqlDbType.Bit, 1),
                    new SqlParameter("@DiedCause", SqlDbType.NVarChar, 254),
                    new SqlParameter("@Others", SqlDbType.NVarChar, 254),
                    new SqlParameter("@UserRelationId", SqlDbType.BigInt, 8)
				};

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((RelationTypeId.HasValue == true))
                {
                    param[1].Value = ((int)(RelationTypeId.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((RFullName == null))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = ((string)(RFullName));
                }
                if ((RDayOfBirth.HasValue == true))
                {
                    param[3].Value = ((int)(RDayOfBirth.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((RMonthOfBirth.HasValue == true))
                {
                    param[4].Value = ((int)(RMonthOfBirth.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((RYearOfBirth.HasValue == true))
                {
                    param[5].Value = ((int)(RYearOfBirth.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                if ((RNativePlace == null))
                {
                    param[6].Value = System.DBNull.Value;
                }
                else
                {
                    param[6].Value = ((string)(RNativePlace));
                }
                if ((RResident == null))
                {
                    param[7].Value = System.DBNull.Value;
                }
                else
                {
                    param[7].Value = ((string)(RResident));
                }
                if ((RLive == null))
                {
                    param[8].Value = System.DBNull.Value;
                }
                else
                {
                    param[8].Value = ((string)(RLive));
                }
                if ((Before1975 == null))
                {
                    param[9].Value = System.DBNull.Value;
                }
                else
                {
                    param[9].Value = ((string)(Before1975));
                }
                if ((After1975 == null))
                {
                    param[10].Value = System.DBNull.Value;
                }
                else
                {
                    param[10].Value = ((string)(After1975));
                }
                if ((Participate == null))
                {
                    param[11].Value = System.DBNull.Value;
                }
                else
                {
                    param[11].Value = ((string)(Participate));
                }
                if ((Died.HasValue == true))
                {
                    param[12].Value = ((bool)(Died.Value));
                }
                else
                {
                    param[12].Value = System.DBNull.Value;
                }
                if ((DiedCause == null))
                {
                    param[13].Value = System.DBNull.Value;
                }
                else
                {
                    param[13].Value = ((string)(DiedCause));
                }
                if ((Others == null))
                {
                    param[14].Value = System.DBNull.Value;
                }
                else
                {
                    param[14].Value = ((string)(Others));
                }
                if ((UserRelationId.HasValue == true))
                {
                    param[15].Value = ((long)(UserRelationId.Value));
                }
                else
                {
                    param[15].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(EmployeeRelationKeys.Sp_EmployeeRelation_Update, param);
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




        public long Delete(System.Nullable<long> UserRelationId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
                   
                   new SqlParameter("@UserRelationId", SqlDbType.BigInt, 8)
				};

                if ((UserRelationId.HasValue == true))
                {
                    param[0].Value = ((long)(UserRelationId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(EmployeeRelationKeys.Sp_EmployeeRelation_Delete, param);
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



        public DataTable GetByFilter(System.Nullable<int> RelationTypeId, System.Nullable<int> UserId, System.Nullable<int> Type)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
                    new SqlParameter("@RelationTypeId", SqlDbType.Int, 4),
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@Type",SqlDbType.Int, 4)
				};               

                if ((RelationTypeId.HasValue == true))
                {
                    param[0].Value = ((int)(RelationTypeId.Value));
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
                if ((Type.HasValue == true))
                {
                    param[2].Value = ((int)(Type.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(EmployeeRelationKeys.Sp_EmployeeRelation_Get_By_Filter, param);
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
