using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H1;

namespace HRMDAL.H1
{
    public class HTCVEmployeeDAL : Dao
    {

        #region insert, update, delete

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns>int</returns>
        public int Insert(System.Nullable<int> UserId, System.Nullable<int> HTCVCatalogueId, System.Nullable<double> Mark, System.Nullable<System.DateTime> MarkDate, string Remark)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{					
                    new SqlParameter("@UserId", System.Data.SqlDbType.Int, 4),
                    new SqlParameter("@HTCVCatalogueId", System.Data.SqlDbType.Int, 4),
                    new SqlParameter("@Mark", System.Data.SqlDbType.Float, 8),
                    new SqlParameter("@MarkDate", System.Data.SqlDbType.DateTime, 8),
                    new SqlParameter("@Remark", System.Data.SqlDbType.NVarChar, 1000)
				};
                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((HTCVCatalogueId.HasValue == true))
                {
                    param[1].Value = ((int)(HTCVCatalogueId.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((Mark.HasValue == true))
                {
                    param[2].Value = ((double)(Mark.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((MarkDate.HasValue == true))
                {
                    param[3].Value = ((System.DateTime)(MarkDate.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((Remark == null))
                {
                    param[4].Value = System.DBNull.Value;
                }
                else
                {
                    param[4].Value = ((string)(Remark));
                }

                sproc = new StoreProcedure(HTCVEmployeeKeys.Sp_Ins_H1_HTCVEmployee, param);
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

        public int Update(System.Nullable<int> UserId, System.Nullable<int> HTCVCatalogueId, System.Nullable<double> Mark, System.Nullable<System.DateTime> MarkDate, string Remark, System.Nullable<long> HTCVEmployeeId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                   new SqlParameter("@UserId", System.Data.SqlDbType.Int, 4),
                    new SqlParameter("@HTCVCatalogueId", System.Data.SqlDbType.Int, 4),
                    new SqlParameter("@Mark", System.Data.SqlDbType.Float, 8),
                    new SqlParameter("@MarkDate", System.Data.SqlDbType.DateTime, 8),
                    new SqlParameter("@Remark", System.Data.SqlDbType.NVarChar, 1000),
                    new SqlParameter("@HTCVEmployeeId", System.Data.SqlDbType.BigInt, 8)
				};

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((HTCVCatalogueId.HasValue == true))
                {
                    param[1].Value = ((int)(HTCVCatalogueId.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((Mark.HasValue == true))
                {
                    param[2].Value = ((double)(Mark.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((MarkDate.HasValue == true))
                {
                    param[3].Value = ((System.DateTime)(MarkDate.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((Remark == null))
                {
                    param[4].Value = System.DBNull.Value;
                }
                else
                {
                    param[4].Value = ((string)(Remark));
                }
                if ((HTCVEmployeeId.HasValue == true))
                {
                    param[5].Value = ((long)(HTCVEmployeeId.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(HTCVEmployeeKeys.Sp_Upd_H1_HTCVEmployee, param);
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

        public int Delete(System.Nullable<int> HTCVEmployeeId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@HTCVEmployeeId", System.Data.SqlDbType.Int, 4)
				};

                if ((HTCVEmployeeId.HasValue == true))
                {
                    param[0].Value = ((int)(HTCVEmployeeId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(HTCVEmployeeKeys.Sp_Del_H1_HTCVEmployee, param);
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

        public int DeleteByIds(string HTCVEmployeeIds)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@HTCVEmployeeIds", System.Data.SqlDbType.VarChar, 1000)
				};

                if ((HTCVEmployeeIds == null))
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(HTCVEmployeeIds));
                }

                sproc = new StoreProcedure(HTCVEmployeeKeys.Sp_Del_H1_HTCVEmployeeByIds, param);
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


        public int DeleteDate(System.Nullable<int> UserId, System.Nullable<System.DateTime> MarkDate)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@UserId", System.Data.SqlDbType.Int, 4),
                    new SqlParameter("@MarkDate", System.Data.SqlDbType.DateTime, 8)
				};

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((MarkDate.HasValue == true))
                {
                    param[1].Value = ((System.DateTime)(MarkDate.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                sproc = new StoreProcedure(HTCVEmployeeKeys.Sp_Del_H1_HTCVEmployeeByUserDate, param);
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

        public DataTable GetByFilter(System.Nullable<int> userid, System.Nullable<int> HTCVCatalogueId, System.Nullable<double> Mark, System.Nullable<System.DateTime> Markdate)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
				{
					new SqlParameter("@userid", System.Data.SqlDbType.Int, 4),
                    new SqlParameter("@HTCVCatalogueId", System.Data.SqlDbType.Int, 4),
                    new SqlParameter("@Mark", System.Data.SqlDbType.Float, 8),
                    new SqlParameter("@Markdate", System.Data.SqlDbType.DateTime, 8)
				};
                if ((userid.HasValue == true))
                {
                    param[0].Value = ((int)(userid.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((HTCVCatalogueId.HasValue == true))
                {
                    param[1].Value = ((int)(HTCVCatalogueId.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((Mark.HasValue == true))
                {
                    param[2].Value = ((double)(Mark.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((Markdate.HasValue == true))
                {
                    param[3].Value = ((System.DateTime)(Markdate.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(HTCVEmployeeKeys.Sp_Sel_H1_HTCVEmployeeByFilter, param);
                sproc.RunFill(datatable);
                sproc.Dispose();
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return datatable;

        }

        public DataTable GetForAllRemarkByUserIdDate(System.Nullable<int> Userid, System.Nullable<int> Month, System.Nullable<int> Year)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
				{
					new SqlParameter("@Userid", SqlDbType.Int, 4),
                    new SqlParameter("@Month", SqlDbType.Int, 4),
                    new SqlParameter("@Year", SqlDbType.Int, 4)
				};
                if ((Userid.HasValue == true))
                {
                    param[0].Value = ((int)(Userid.Value));
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
                    param[2].Value = ((double)(Year.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }


                sproc = new StoreProcedure(HTCVEmployeeKeys.Sp_Sel_H1_HTCVEmployeeForAllRemarkByUserIdDate, param);
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

    }
}
