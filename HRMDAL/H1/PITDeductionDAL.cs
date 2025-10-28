using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H1;

namespace HRMDAL.H1
{
    public class PITDeductionDAL : Dao
    {

        #region insert, update, delete

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns>int</returns>
        public int Insert(System.Nullable<int> UserId, System.Nullable<long> UserRelationId, string TaxNumber, string Id_Passport, System.Nullable<int> FromMonth, System.Nullable<int> FromYear, System.Nullable<int> ToMonth, System.Nullable<int> ToYear, System.Nullable<System.DateTime> CreateDate, System.Nullable<int> CreateUser, System.Nullable<System.DateTime> UpdateDate, System.Nullable<int> UpdateUser)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
					                    
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@UserRelationId", SqlDbType.BigInt, 8),
                    new SqlParameter("@TaxNumber", SqlDbType.VarChar, 50),
                    new SqlParameter("@Id_Passport", SqlDbType.VarChar, 50),
                    new SqlParameter("@FromMonth", SqlDbType.Int, 4),
                    new SqlParameter("@FromYear", SqlDbType.Int, 4),
                    new SqlParameter("@ToMonth", SqlDbType.Int, 4),                    
                    new SqlParameter("@ToYear", SqlDbType.Int, 4),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@CreateUser", SqlDbType.Int, 4),
                    new SqlParameter("@UpdateDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@UpdateUser", SqlDbType.Int, 4)
				};

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((UserRelationId.HasValue == true))
                {
                    param[1].Value = ((long)(UserRelationId.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((TaxNumber == null))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = ((string)(TaxNumber));
                }
                if ((Id_Passport == null))
                {
                    param[3].Value = System.DBNull.Value;
                }
                else
                {
                    param[3].Value = ((string)(Id_Passport));
                }
                if ((FromMonth.HasValue == true))
                {
                    param[4].Value = ((int)(FromMonth.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((FromYear.HasValue == true))
                {
                    param[5].Value = ((int)(FromYear.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                if ((ToMonth.HasValue == true))
                {
                    param[6].Value = ((int)(ToMonth.Value));
                }
                else
                {
                    param[6].Value = System.DBNull.Value;
                }
                if ((ToYear.HasValue == true))
                {
                    param[7].Value = ((int)(ToYear.Value));
                }
                else
                {
                    param[7].Value = System.DBNull.Value;
                }
                if ((CreateDate.HasValue == true))
                {
                    param[8].Value = ((System.DateTime)(CreateDate.Value));
                }
                else
                {
                    param[8].Value = System.DBNull.Value;
                }
                if ((CreateUser.HasValue == true))
                {
                    param[9].Value = ((int)(CreateUser.Value));
                }
                else
                {
                    param[9].Value = System.DBNull.Value;
                }
                if ((UpdateDate.HasValue == true))
                {
                    param[10].Value = ((System.DateTime)(UpdateDate.Value));
                }
                else
                {
                    param[10].Value = System.DBNull.Value;
                }
                if ((UpdateUser.HasValue == true))
                {
                    param[11].Value = ((int)(UpdateUser.Value));
                }
                else
                {
                    param[11].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(PITDeductionKeys.Sp_Ins_H1_PITDeduction, param);
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

        public int Update(System.Nullable<int> UserId, System.Nullable<long> UserRelationId, string TaxNumber, string Id_Passport, System.Nullable<int> FromMonth, System.Nullable<int> FromYear, System.Nullable<int> ToMonth, System.Nullable<int> ToYear, System.Nullable<System.DateTime> UpdateDate, System.Nullable<int> UpdateUser, System.Nullable<int> PITDeductionId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
					                    
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@UserRelationId", SqlDbType.BigInt, 8),
                    new SqlParameter("@TaxNumber", SqlDbType.VarChar, 50),
                    new SqlParameter("@Id_Passport", SqlDbType.VarChar, 50),
                    new SqlParameter("@FromMonth", SqlDbType.Int, 4),
                    new SqlParameter("@FromYear", SqlDbType.Int, 4),
                    new SqlParameter("@ToMonth", SqlDbType.Int, 4),
                    new SqlParameter("@ToYear", SqlDbType.Int, 4),
                    new SqlParameter("@UpdateDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@UpdateUser", SqlDbType.Int, 4),
                    new SqlParameter("@PITDeductionId", SqlDbType.Int, 4)
				};

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((UserRelationId.HasValue == true))
                {
                    param[1].Value = ((long)(UserRelationId.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((TaxNumber == null))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = ((string)(TaxNumber));
                }
                if ((Id_Passport == null))
                {
                    param[3].Value = System.DBNull.Value;
                }
                else
                {
                    param[3].Value = ((string)(Id_Passport));
                }
                if ((FromMonth.HasValue == true))
                {
                    param[4].Value = ((int)(FromMonth.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((FromYear.HasValue == true))
                {
                    param[5].Value = ((int)(FromYear.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                if ((ToMonth.HasValue == true))
                {
                    param[6].Value = ((int)(ToMonth.Value));
                }
                else
                {
                    param[6].Value = System.DBNull.Value;
                }
                if ((ToYear.HasValue == true))
                {
                    param[7].Value = ((int)(ToYear.Value));
                }
                else
                {
                    param[7].Value = System.DBNull.Value;
                }                
                if ((UpdateDate.HasValue == true))
                {
                    param[8].Value = ((System.DateTime)(UpdateDate.Value));
                }
                else
                {
                    param[8].Value = System.DBNull.Value;
                }
                if ((UpdateUser.HasValue == true))
                {
                    param[9].Value = ((int)(UpdateUser.Value));
                }
                else
                {
                    param[9].Value = System.DBNull.Value;
                }
                if ((PITDeductionId.HasValue == true))
                {
                    param[10].Value = ((int)(PITDeductionId.Value));
                }
                else
                {
                    param[10].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(PITDeductionKeys.Sp_Upd_H1_PITDeduction, param);
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

        public int Delete(System.Nullable<int> PITDeductionId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@PITDeductionId", SqlDbType.Int, 4)
				};

                if ((PITDeductionId.HasValue == true))
                {
                    param[0].Value = ((int)(PITDeductionId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(PITDeductionKeys.Sp_Del_H1_PITDeduction, param);
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

        public DataTable GetByFilter(string FullName, System.Nullable<int> RootId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
                {
					
                    new SqlParameter("@FullName", SqlDbType.NVarChar, 100),
                    new SqlParameter("@RootId", SqlDbType.Int, 4)
                };
                if ((FullName == null))
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(FullName));
                }
                
                if ((RootId.HasValue == true))
                {
                    param[1].Value = ((int)(RootId.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(PITDeductionKeys.Sp_Sel_H1_PITDeduction_By_Filter, param);
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

        public DataTable GetByUserIdUserRelationId(System.Nullable<int> UserId, System.Nullable<long> UserRelationId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
                {					                    
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@UserRelationId", SqlDbType.BigInt)
                    
                };
                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((UserRelationId.HasValue == true))
                {
                    param[1].Value = ((int)(UserRelationId.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(PITDeductionKeys.Sp_Sel_H1_PITDeduction_By_UserRelation, param);
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

        public DataTable GetByUserDate(System.Nullable<int> UserId, System.Nullable<int> Month, System.Nullable<int> Year)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
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

                sproc = new StoreProcedure(PITDeductionKeys.Sp_Sel_H1_PITDeduction_By_UserDate, param);
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
    }
}
