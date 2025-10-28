using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H1;

namespace HRMDAL.H1
{
    public class SalaryRegulationDAL : Dao
    {
        #region insert, update, delete

        public int Insert(string SalaryRegulationName, System.Nullable<System.DateTime> BeginingDate, string Description, System.Nullable<bool> InUse, System.Nullable<int> TypeId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{					                    
                    new SqlParameter("@SalaryRegulationName", SqlDbType.NVarChar, 100),                    
                    new SqlParameter("@BeginingDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@Description", SqlDbType.NVarChar, 1000),
                    new SqlParameter("@InUse", SqlDbType.Bit, 1),
                    new SqlParameter("@TypeId", SqlDbType.Int, 4)
                };
                if ((SalaryRegulationName == null))
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(SalaryRegulationName));
                }
                
                if ((BeginingDate.HasValue == true))
                {
                    param[1].Value = ((System.DateTime)(BeginingDate.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((Description == null))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = ((string)(Description));
                }
                if ((InUse.HasValue == true))
                {
                    param[3].Value = ((bool)(InUse.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((TypeId.HasValue == true))
                {
                    param[4].Value = ((int)(TypeId.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                sproc = new StoreProcedure(SalaryRegulationKeys.Sp_Ins_H1_SalaryRegulation, param);
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

        public int Update(string SalaryRegulationName, System.Nullable<System.DateTime> BeginingDate, string Description, System.Nullable<bool> InUse, System.Nullable<int> TypeId, System.Nullable<int> SalaryRegulationId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{					                    
                    new SqlParameter("@SalaryRegulationName", SqlDbType.NVarChar, 100),                    
                    new SqlParameter("@BeginingDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@Description", SqlDbType.NVarChar, 1000),
                    new SqlParameter("@InUse", SqlDbType.Bit, 1),
                    new SqlParameter("@TypeId", SqlDbType.Int, 4),
                    new SqlParameter("@SalaryRegulationId", SqlDbType.Int, 4)
                };
                if ((SalaryRegulationName == null))
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(SalaryRegulationName));
                }
                
                if ((BeginingDate.HasValue == true))
                {
                    param[1].Value = ((System.DateTime)(BeginingDate.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((Description == null))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = ((string)(Description));
                }
                if ((InUse.HasValue == true))
                {
                    param[3].Value = ((bool)(InUse.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((TypeId.HasValue == true))
                {
                    param[4].Value = ((int)(TypeId.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((SalaryRegulationId.HasValue == true))
                {
                    param[5].Value = ((int)(SalaryRegulationId.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                sproc = new StoreProcedure(SalaryRegulationKeys.Sp_Upd_H1_SalaryRegulation, param);
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

        public int Delete(System.Nullable<int> SalaryRegulationId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@SalaryRegulationId", SqlDbType.Int, 4)
				};

                if ((SalaryRegulationId.HasValue == true))
                {
                    param[0].Value = ((int)(SalaryRegulationId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(SalaryRegulationKeys.Sp_Del_H1_SalaryRegulation, param);
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

        public DataTable GetByInUse(System.Nullable<bool> InUse)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@InUse", SqlDbType.Int, 4)
				};

                if ((InUse.HasValue == true))
                {
                    param[0].Value = ((bool)(InUse.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(SalaryRegulationKeys.Sp_Sel_H1_SalaryRegulationByInUse, param);
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

        public DataTable GetByFilter(System.Nullable<int> TypeId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
                {
                    new SqlParameter("@TypeId", SqlDbType.Int, 4)
                };

                if ((TypeId.HasValue == true))
                {
                    param[0].Value = ((int)(TypeId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(SalaryRegulationKeys.Sp_Sel_H1_SalaryRegulationByFilter, param);
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
