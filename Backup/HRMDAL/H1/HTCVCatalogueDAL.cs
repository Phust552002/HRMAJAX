using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H1;

namespace HRMDAL.H1
{
    public class HTCVCatalogueDAL : Dao
    {

        #region insert, update, delete

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns>int</returns>
        public int Insert(string HTCVCatalogueName, string MarkDisplay, System.Nullable<double> MarkDefault, System.Nullable<int> TypeDisplay)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
					
                    new SqlParameter("@HTCVCatalogueName", System.Data.SqlDbType.NVarChar, 4000),
                    new SqlParameter("@MarkDisplay", System.Data.SqlDbType.VarChar, 50),
                    new SqlParameter("@MarkDefault", System.Data.SqlDbType.Float, 8),
                    new SqlParameter("@TypeDisplay", System.Data.SqlDbType.Int, 4)
				};
                if ((HTCVCatalogueName == null))
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(HTCVCatalogueName));
                }
                if ((MarkDisplay == null))
                {
                    param[1].Value = System.DBNull.Value;
                }
                else
                {
                    param[1].Value = ((string)(MarkDisplay));
                }
                if ((MarkDefault.HasValue == true))
                {
                    param[2].Value = ((double)(MarkDefault.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((TypeDisplay.HasValue == true))
                {
                    param[3].Value = ((int)(TypeDisplay.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(HTCVCatalogueKeys.Sp_Ins_H1_HTCVCatalogue, param);
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

        public int Update(string HTCVCatalogueName, string MarkDisplay, System.Nullable<double> MarkDefault, System.Nullable<int> TypeDisplay, System.Nullable<int> HTCVCatalogueId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                   new SqlParameter("@HTCVCatalogueName", System.Data.SqlDbType.NVarChar, 4000),
                   new SqlParameter("@MarkDisplay", System.Data.SqlDbType.VarChar, 50),
                   new SqlParameter("@MarkDefault", System.Data.SqlDbType.Float, 8),
                   new SqlParameter("@TypeDisplay", System.Data.SqlDbType.Int, 4),
                   new SqlParameter("@HTCVCatalogueId", System.Data.SqlDbType.Int, 4)
				};

                if ((HTCVCatalogueName == null))
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(HTCVCatalogueName));
                }
                if ((MarkDisplay == null))
                {
                    param[1].Value = System.DBNull.Value;
                }
                else
                {
                    param[1].Value = ((string)(MarkDisplay));
                }
                if ((MarkDefault.HasValue == true))
                {
                    param[2].Value = ((double)(MarkDefault.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((TypeDisplay.HasValue == true))
                {
                    param[3].Value = ((int)(TypeDisplay.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((HTCVCatalogueId.HasValue == true))
                {
                    param[4].Value = ((int)(HTCVCatalogueId.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(HTCVCatalogueKeys.Sp_Upd_H1_HTCVCatalogue, param);
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

        public int Delete(System.Nullable<int> HTCVCatalogueId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@HTCVCatalogueId", System.Data.SqlDbType.Int, 4)
				};

                if ((HTCVCatalogueId.HasValue == true))
                {
                    param[0].Value = ((int)(HTCVCatalogueId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(HTCVCatalogueKeys.Sp_Del_H1_HTCVCatalogue, param);
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

        public DataTable GetByFilter(string HTCVCatalogueName, string MarkDisplay, System.Nullable<double> MarkDefault, System.Nullable<int> TypeDisplay)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
				{
					
                    new SqlParameter("@HTCVCatalogueName", System.Data.SqlDbType.NVarChar, 4000),
                    new SqlParameter("@MarkDisplay", System.Data.SqlDbType.VarChar, 50),
                    new SqlParameter("@MarkDefault", System.Data.SqlDbType.Float, 8),
                    new SqlParameter("@TypeDisplay", System.Data.SqlDbType.Int, 4)
				};
                if ((HTCVCatalogueName == null))
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(HTCVCatalogueName));
                }
                if ((MarkDisplay == null))
                {
                    param[1].Value = System.DBNull.Value;
                }
                else
                {
                    param[1].Value = ((string)(MarkDisplay));
                }
                if ((MarkDefault.HasValue == true))
                {
                    param[2].Value = ((double)(MarkDefault.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((TypeDisplay.HasValue == true))
                {
                    param[3].Value = ((int)(TypeDisplay.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(HTCVCatalogueKeys.SP_Sel_H1_HTCVCatalogueByFilter, param);
                sproc.RunFill(datatable);
                sproc.Dispose();
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return datatable;

        }

        public DataTable GetById(System.Nullable<int> HTCVCatalogueId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
				{					
                    new SqlParameter("@HTCVCatalogueId", System.Data.SqlDbType.Int, 4)
				};
                if ((HTCVCatalogueId.HasValue == true))
                {
                    param[0].Value = ((int)(HTCVCatalogueId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(HTCVCatalogueKeys.SP_Sel_H1_HTCVCatalogueById, param);
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
