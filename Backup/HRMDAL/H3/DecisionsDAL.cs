using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H3;

namespace HRMDAL.H3
{
    public class DecisionsDAL : Dao
    {

        #region Methods Get

        public DataTable GetByFilter(System.Nullable<int> DecisionTypeId, string DecisionNo, string DecisionName, System.Nullable<System.DateTime> DecisionDate)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {

                SqlParameter[] param = 
                {                     
                    new SqlParameter("@DecisionTypeId", SqlDbType.Int, 4),
                    new SqlParameter("@DecisionNo", SqlDbType.VarChar, 50),
                    new SqlParameter("@DecisionName", SqlDbType.NVarChar, 254),
                    new SqlParameter("@DecisionDate", SqlDbType.SmallDateTime, 4)
                };

                if ((DecisionTypeId.HasValue == true))
                {
                    param[0].Value = ((int)(DecisionTypeId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((DecisionNo == null))
                {
                    param[1].Value = System.DBNull.Value;
                }
                else
                {
                    param[1].Value = ((string)(DecisionNo));
                }
                if ((DecisionName == null))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = ((string)(DecisionName));
                }
                if ((DecisionDate.HasValue == true))
                {
                    param[3].Value = ((System.DateTime)(DecisionDate.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(DecisionsKeys.Sp_Sel_H3_Decisions_By_Filter, param);
                sproc.RunFill(datatable);
                sproc.Dispose();
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return datatable;

        }

        public DataTable GetById(System.Nullable<int> DecisionId)
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


                sproc = new StoreProcedure(DecisionsKeys.Sp_Sel_H3_Decision_By_Id, param);
                sproc.RunFill(datatable);
                sproc.Dispose();
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return datatable;

        }

        #endregion


        #region methods inset, update , delete

        public int Insert(System.Nullable<int> DecisionTypeId, string DecisionNo, System.Nullable<System.DateTime> DecisionDate, string DecisionName, string BringOutDept, string SignUser, string Remark)
        {

            Debug.Assert(sproc == null);
            int identity = 0;

            try
            {

                SqlParameter[] param = 
                {                     
                    new SqlParameter("@DecisionTypeId", SqlDbType.Int, 4),
                    new SqlParameter("@DecisionNo", SqlDbType.VarChar, 50),
                    new SqlParameter("@DecisionDate", SqlDbType.SmallDateTime, 4),
                    new SqlParameter("@DecisionName", SqlDbType.NVarChar, 254),
                    new SqlParameter("@BringOutDept", SqlDbType.NVarChar, 254),
                    new SqlParameter("@SignUser", SqlDbType.NVarChar, 254),
                    new SqlParameter("@Remark", SqlDbType.NVarChar, 1000)
                };
                
                if ((DecisionTypeId.HasValue == true))
                {
                    param[0].Value = ((int)(DecisionTypeId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((DecisionNo == null))
                {
                    param[1].Value = System.DBNull.Value;
                }
                else
                {
                    param[1].Value = ((string)(DecisionNo));
                }
                if ((DecisionDate.HasValue == true))
                {
                    param[2].Value = ((System.DateTime)(DecisionDate.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((DecisionName == null))
                {
                    param[3].Value = System.DBNull.Value;
                }
                else
                {
                    param[3].Value = ((string)(DecisionName));
                }
                if ((BringOutDept == null))
                {
                    param[4].Value = System.DBNull.Value;
                }
                else
                {
                    param[4].Value = ((string)(BringOutDept));
                }
                if ((SignUser == null))
                {
                    param[5].Value = System.DBNull.Value;
                }
                else
                {
                    param[5].Value = ((string)(SignUser));
                }
                if ((Remark == null))
                {
                    param[6].Value = System.DBNull.Value;
                }
                else
                {
                    param[6].Value = ((string)(Remark));
                }

                sproc = new StoreProcedure(DecisionsKeys.Sp_Ins_H3_Decisions, param);
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

        public int Update(System.Nullable<int> DecisionTypeId, string DecisionNo, System.Nullable<System.DateTime> DecisionDate, string DecisionName, string BringOutDept, string SignUser, string Remark, System.Nullable<int> DecisionId)
        {

            Debug.Assert(sproc == null);
            int identity = 0;

            try
            {

                SqlParameter[] param = 
                {                     
                    new SqlParameter("@DecisionTypeId", SqlDbType.Int, 4),
                    new SqlParameter("@DecisionNo", SqlDbType.VarChar, 50),
                    new SqlParameter("@DecisionDate", SqlDbType.SmallDateTime, 4),
                    new SqlParameter("@DecisionName", SqlDbType.NVarChar, 254),
                    new SqlParameter("@BringOutDept", SqlDbType.NVarChar, 254),
                    new SqlParameter("@SignUser", SqlDbType.NVarChar, 254),
                    new SqlParameter("@Remark", SqlDbType.NVarChar, 1000),
                    new SqlParameter("@DecisionId", SqlDbType.Int, 4)
                };

                if ((DecisionTypeId.HasValue == true))
                {
                    param[0].Value = ((int)(DecisionTypeId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((DecisionNo == null))
                {
                    param[1].Value = System.DBNull.Value;
                }
                else
                {
                    param[1].Value = ((string)(DecisionNo));
                }
                if ((DecisionDate.HasValue == true))
                {
                    param[2].Value = ((System.DateTime)(DecisionDate.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((DecisionName == null))
                {
                    param[3].Value = System.DBNull.Value;
                }
                else
                {
                    param[3].Value = ((string)(DecisionName));
                }
                if ((BringOutDept == null))
                {
                    param[4].Value = System.DBNull.Value;
                }
                else
                {
                    param[4].Value = ((string)(BringOutDept));
                }
                if ((SignUser == null))
                {
                    param[5].Value = System.DBNull.Value;
                }
                else
                {
                    param[5].Value = ((string)(SignUser));
                }
                if ((Remark == null))
                {
                    param[6].Value = System.DBNull.Value;
                }
                else
                {
                    param[6].Value = ((string)(Remark));
                }
                if ((DecisionId.HasValue == true))
                {
                    param[7].Value = ((int)(DecisionId.Value));
                }
                else
                {
                    param[7].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(DecisionsKeys.Sp_Upd_H3_Decisions, param);
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

        public long Delete(System.Nullable<int> DecisionId)
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
                sproc = new StoreProcedure(DecisionsKeys.Sp_Del_H3_Decisions, param);
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
