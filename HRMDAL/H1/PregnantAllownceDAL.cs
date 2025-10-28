using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H1;

namespace HRMDAL.H1
{
    public class PregnantAllownceDAL : Dao
    {

        #region insert, update, delete

        public int Insert(System.Nullable<int> UserId, System.Nullable<System.DateTime> AllownceDate, System.Nullable<double> AllownceValue, System.Nullable<int> IsCount)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{					                    
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@AllownceDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@AllownceValue", SqlDbType.Float, 8),
                    new SqlParameter("@IsCount", SqlDbType.Int, 4)
                };
                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((AllownceDate.HasValue == true))
                {
                    param[1].Value = ((System.DateTime)(AllownceDate.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((AllownceValue.HasValue == true))
                {
                    param[2].Value = ((double)(AllownceValue.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((IsCount.HasValue == true))
                {
                    param[3].Value = ((int)(IsCount.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(PregnantAllownceKeys.Sp_Ins_H1_PregnantAllownce, param);
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

        public int Update(System.Nullable<int> UserId, System.Nullable<System.DateTime> AllownceDate, System.Nullable<double> AllownceValue, System.Nullable<int> IsCount, System.Nullable<int> PregnantAllownceId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{					                    
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@AllownceDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@AllownceValue", SqlDbType.Float, 8),
                    new SqlParameter("@IsCount", SqlDbType.Int, 4),
                    new SqlParameter("@PregnantAllownceId", SqlDbType.Int, 4)
                };
                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((AllownceDate.HasValue == true))
                {
                    param[1].Value = ((System.DateTime)(AllownceDate.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((AllownceValue.HasValue == true))
                {
                    param[2].Value = ((double)(AllownceValue.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((IsCount.HasValue == true))
                {
                    param[3].Value = ((int)(IsCount.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((PregnantAllownceId.HasValue == true))
                {
                    param[4].Value = ((int)(PregnantAllownceId.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(PregnantAllownceKeys.Sp_Upd_H1_PregnantAllownce, param);
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

        public int Delete(System.Nullable<int> PregnantAllownceId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@PregnantAllownceId", System.Data.SqlDbType.Int, 4)
				};

                if ((PregnantAllownceId.HasValue == true))
                {
                    param[0].Value = ((int)(PregnantAllownceId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(PregnantAllownceKeys.Sp_Del_H1_PregnantAllownce, param);
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
                    new SqlParameter("@UserId", System.Data.SqlDbType.Int, 4)
				};

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(PregnantAllownceKeys.Sp_Del_H1_PregnantAllownce_By_UserId, param);
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

        public DataTable GetByFilter(string FullName, System.Nullable<int> RootId, System.Nullable<System.DateTime> AllownceDate)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@FullName", SqlDbType.NVarChar, 254),
                    new SqlParameter("@RootId", SqlDbType.Int, 4),
					new SqlParameter("@AllownceDate", SqlDbType.DateTime, 8)
				};

               
                param[0].Value = FullName;

                if ((RootId.HasValue == true))
                {
                    param[1].Value = ((int)(RootId.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }

                if ((!AllownceDate.Equals(FormatDate.GetSQLDateMinValue)))
                {
                    param[2].Value = ((System.DateTime)(AllownceDate.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(PregnantAllownceKeys.Sp_Sel_H1_PregnantAllownce_By_Filter, param);
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

        public DataTable GetByUserId(System.Nullable<int> UserId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
				{
					new SqlParameter("@UserId", SqlDbType.Int, 4)
				};
                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(PregnantAllownceKeys.Sp_Sel_H1_PregnantAllownce_By_UserId, param);
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

        public DataTable GetById(System.Nullable<int> PregnantAllownceId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
				{
					new SqlParameter("@PregnantAllownceId", SqlDbType.Int, 4)
				};
                if ((PregnantAllownceId.HasValue == true))
                {
                    param[0].Value = ((int)(PregnantAllownceId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(PregnantAllownceKeys.Sp_Sel_H1_PregnantAllownce_By_Id, param);
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

        public DataTable GetByUserAllownceDate(System.Nullable<int> UserId, System.Nullable<System.DateTime> AllownceDate)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
					new SqlParameter("@AllownceDate", SqlDbType.DateTime, 8)                    
				};

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((AllownceDate.HasValue == true))
                {
                    param[1].Value = ((System.DateTime)(AllownceDate.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                

                sproc = new StoreProcedure(PregnantAllownceKeys.Sp_Sel_H1_PregnantAllownce_By_UserId_Date, param);
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
