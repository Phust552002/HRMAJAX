using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H3;

namespace HRMDAL.H3
{
    public class DecisionEmployeesDAL : Dao
    {

        #region Methods Get

        public DataTable GetByDecisionId(System.Nullable<int> DecisionId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
                {                     
                    new SqlParameter("@DecisionId", SqlDbType.Int, 4)
                };
                
                if ((DecisionId.HasValue == true))
                {
                    param[0].Value = ((int)(DecisionId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                sproc = new StoreProcedure(DecisionEmployeesKeys.Sp_Sel_H3_DecisionEmployees_By_DecisionId, param);
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

        public long Insert(System.Nullable<int> DecisionId, System.Nullable<int> UserId, System.Nullable<int> PositionId, System.Nullable<int> RootId, System.Nullable<System.DateTime> FromDate, System.Nullable<System.DateTime> ToDate, string Level, string Form, string Title, System.Nullable<int> KeyPosition)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
                {                                         

                    new SqlParameter("@DecisionId", SqlDbType.Int, 4),
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@PositionId", SqlDbType.Int, 4),
                    new SqlParameter("@RootId", SqlDbType.Int, 4),
                    new SqlParameter("@FromDate", SqlDbType.SmallDateTime, 4),
                    new SqlParameter("@ToDate", SqlDbType.SmallDateTime, 4),
                    new SqlParameter("@Level", SqlDbType.NVarChar, 254),
                    new SqlParameter("@Form", SqlDbType.NVarChar, 254),
                    new SqlParameter("@Title", SqlDbType.NVarChar, 254),
                    new SqlParameter("@KeyPosition", SqlDbType.Int, 4)
                };
                if ((DecisionId.HasValue == true))
                {
                    param[0].Value = ((int)(DecisionId.Value));
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
                if ((PositionId.HasValue == true))
                {
                    param[2].Value = ((int)(PositionId.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((RootId.HasValue == true))
                {
                    param[3].Value = ((int)(RootId.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((FromDate.HasValue == true))
                {
                    param[4].Value = ((System.DateTime)(FromDate.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((ToDate.HasValue == true))
                {
                    param[5].Value = ((System.DateTime)(ToDate.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                if ((Level == null))
                {
                    param[6].Value = System.DBNull.Value;
                }
                else
                {
                    param[6].Value = ((string)(Level));
                }
                if ((Form == null))
                {
                    param[7].Value = System.DBNull.Value;
                }
                else
                {
                    param[7].Value = ((string)(Form));
                }
                if ((Title == null))
                {
                    param[8].Value = System.DBNull.Value;
                }
                else
                {
                    param[8].Value = ((string)(Title));
                }
                if ((KeyPosition.HasValue == true))
                {
                    param[9].Value = ((int)(KeyPosition.Value));
                }
                else
                {
                    param[9].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(DecisionEmployeesKeys.Sp_Ins_H3_DecisionEmployees, param);
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

        public long Update(System.Nullable<int> DecisionId, System.Nullable<int> UserId, System.Nullable<int> PositionId, System.Nullable<int> RootId, System.Nullable<System.DateTime> FromDate, System.Nullable<System.DateTime> ToDate, string Level, string Form, string Title, System.Nullable<int> KeyPosition, System.Nullable<long> DecisionEmployeeId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
                {                                         

                    new SqlParameter("@DecisionId", SqlDbType.Int, 4),
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@PositionId", SqlDbType.Int, 4),
                    new SqlParameter("@RootId", SqlDbType.Int, 4),
                    new SqlParameter("@FromDate", SqlDbType.SmallDateTime, 4),
                    new SqlParameter("@ToDate", SqlDbType.SmallDateTime, 4),
                    new SqlParameter("@Level", SqlDbType.NVarChar, 254),
                    new SqlParameter("@Form", SqlDbType.NVarChar, 254),
                    new SqlParameter("@Title", SqlDbType.NVarChar, 254),
                    new SqlParameter("@KeyPosition", SqlDbType.Int, 4),
                    new SqlParameter("@DecisionEmployeeId", SqlDbType.BigInt, 8)
                };

                if ((DecisionId.HasValue == true))
                {
                    param[0].Value = ((int)(DecisionId.Value));
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
                if ((PositionId.HasValue == true))
                {
                    param[2].Value = ((int)(PositionId.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((RootId.HasValue == true))
                {
                    param[3].Value = ((int)(RootId.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((FromDate.HasValue == true))
                {
                    param[4].Value = ((System.DateTime)(FromDate.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((ToDate.HasValue == true))
                {
                    param[5].Value = ((System.DateTime)(ToDate.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                if ((Level == null))
                {
                    param[6].Value = System.DBNull.Value;
                }
                else
                {
                    param[6].Value = ((string)(Level));
                }
                if ((Form == null))
                {
                    param[7].Value = System.DBNull.Value;
                }
                else
                {
                    param[7].Value = ((string)(Form));
                }
                if ((Title == null))
                {
                    param[8].Value = System.DBNull.Value;
                }
                else
                {
                    param[8].Value = ((string)(Title));
                }
                if ((KeyPosition.HasValue == true))
                {
                    param[9].Value = ((int)(KeyPosition.Value));
                }
                else
                {
                    param[9].Value = System.DBNull.Value;
                }
                if ((DecisionEmployeeId.HasValue == true))
                {
                    param[10].Value = ((long)(DecisionEmployeeId.Value));
                }
                else
                {
                    param[10].Value = System.DBNull.Value;
                }
                sproc = new StoreProcedure(DecisionEmployeesKeys.Sp_Upd_H3_DecisionEmployees, param);
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

        public long Delete(System.Nullable<int> DecisionEmployeeId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
                {                                
                    new SqlParameter("@DecisionEmployeeId", SqlDbType.BigInt, 8)
                };

                param[0].Value = DecisionEmployeeId;
                sproc = new StoreProcedure(DecisionEmployeesKeys.Sp_Del_H3_DecisionEmployees, param);
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

        public long DeleteByDecisionId(System.Nullable<int> DecisionId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
                {                                
                    new SqlParameter("@DecisionId", System.Data.SqlDbType.Int, 4)
                };

                param[0].Value = DecisionId;
                sproc = new StoreProcedure(DecisionEmployeesKeys.Sp_Del_H3_DecisionEmployees_By_DecisionId, param);
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

        public long DeleteByIds(string DecisionEmployeeIds)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
                {                                
                    new SqlParameter("@DecisionEmployeeIds", SqlDbType.VarChar, 1000)
                };

                param[0].Value = DecisionEmployeeIds;
                sproc = new StoreProcedure(DecisionEmployeesKeys.Sp_Del_H3_DecisionEmployees_By_Ids, param);
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
