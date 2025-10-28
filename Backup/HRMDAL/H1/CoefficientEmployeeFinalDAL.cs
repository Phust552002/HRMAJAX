using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H1;

namespace HRMDAL.H1
{
    public class CoefficientEmployeeFinalDAL :Dao
    {
        #region Insert, Update, Delete

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns>int</returns>
        public long Insert(System.Nullable<int> UserId, System.Nullable<System.DateTime> CreateDate, System.Nullable<double> LNS, System.Nullable<double> LNSPCTN, System.Nullable<double> LCB, System.Nullable<double> PCDH, System.Nullable<double> PCTN, System.Nullable<double> PCKV, System.Nullable<double> PCCV)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
            					
					new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@CreateDate", SqlDbType.SmallDateTime, 4),
                    new SqlParameter("@LNS", SqlDbType.Float, 8),
                    new SqlParameter("@LNSPCTN", SqlDbType.Float, 8),
                    new SqlParameter("@LCB", SqlDbType.Float, 8),
                    new SqlParameter("@PCDH", SqlDbType.Float, 8),
                    new SqlParameter("@PCTN", SqlDbType.Float, 8),
                    new SqlParameter("@PCKV", SqlDbType.Float, 8),
                    new SqlParameter("@PCCV", SqlDbType.Float, 8)
				};
                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((CreateDate.HasValue == true))
                {
                    param[1].Value = ((System.DateTime)(CreateDate.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((LNS.HasValue == true))
                {
                    param[2].Value = ((double)(LNS.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((LNSPCTN.HasValue == true))
                {
                    param[3].Value = ((double)(LNSPCTN.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((LCB.HasValue == true))
                {
                    param[4].Value = ((double)(LCB.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((PCDH.HasValue == true))
                {
                    param[5].Value = ((double)(PCDH.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                if ((PCTN.HasValue == true))
                {
                    param[6].Value = ((double)(PCTN.Value));
                }
                else
                {
                    param[6].Value = System.DBNull.Value;
                }
                if ((PCKV.HasValue == true))
                {
                    param[7].Value = ((double)(PCKV.Value));
                }
                else
                {
                    param[7].Value = System.DBNull.Value;
                }
                if ((PCCV.HasValue == true))
                {
                    param[8].Value = ((double)(PCCV.Value));
                }
                else
                {
                    param[8].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(CoefficientEmployeeFinalKeys.Sp_Ins_H1_CoefficientEmployeeFinal, param);
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

        public long UpdateForLNS(System.Nullable<int> UserId, System.Nullable<System.DateTime> CreateDate, System.Nullable<double> LNS, System.Nullable<double> LNSPCTN)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
            					
					new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@CreateDate", SqlDbType.SmallDateTime, 4),
                    new SqlParameter("@LNS", SqlDbType.Float, 8),
                    new SqlParameter("@LNSPCTN", SqlDbType.Float, 8)
				};
                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((CreateDate.HasValue == true))
                {
                    param[1].Value = ((System.DateTime)(CreateDate.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((LNS.HasValue == true))
                {
                    param[2].Value = ((double)(LNS.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((LNSPCTN.HasValue == true))
                {
                    param[3].Value = ((double)(LNSPCTN.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                

                sproc = new StoreProcedure(CoefficientEmployeeFinalKeys.Sp_Upd_H1_CoefficientEmployeeFinal_ForLNS, param);
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

        public long UpdateForLCB(System.Nullable<int> UserId, System.Nullable<System.DateTime> CreateDate, System.Nullable<double> LCB)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
            					
					new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@CreateDate", SqlDbType.SmallDateTime, 4),
                    new SqlParameter("@LCB", SqlDbType.Float, 8)
				};
                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((CreateDate.HasValue == true))
                {
                    param[1].Value = ((System.DateTime)(CreateDate.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((LCB.HasValue == true))
                {
                    param[2].Value = ((double)(LCB.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
               

                sproc = new StoreProcedure(CoefficientEmployeeFinalKeys.Sp_Upd_H1_CoefficientEmployeeFinal_ForLCB, param);
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

        public long UpdateForOther(System.Nullable<int> UserId, System.Nullable<System.DateTime> CreateDate, System.Nullable<double> PCDH, System.Nullable<double> PCTN, System.Nullable<double> PCKV, System.Nullable<double> PCCV)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
            					
					new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@CreateDate", SqlDbType.SmallDateTime, 4),
                    new SqlParameter("@PCDH", SqlDbType.Float, 8),
                    new SqlParameter("@PCTN", SqlDbType.Float, 8),
                    new SqlParameter("@PCKV", SqlDbType.Float, 8),
                    new SqlParameter("@PCCV", SqlDbType.Float, 8)
				};
                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((CreateDate.HasValue == true))
                {
                    param[1].Value = ((System.DateTime)(CreateDate.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((PCDH.HasValue == true))
                {
                    param[2].Value = ((double)(PCDH.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((PCTN.HasValue == true))
                {
                    param[3].Value = ((double)(PCTN.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((PCKV.HasValue == true))
                {
                    param[4].Value = ((double)(PCKV.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((PCCV.HasValue == true))
                {
                    param[5].Value = ((double)(PCCV.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(CoefficientEmployeeFinalKeys.Sp_Upd_H1_CoefficientEmployeeFinal_ForOther, param);
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

        public long UpdateForSpecial(System.Nullable<int> UserId, System.Nullable<System.DateTime> CreateDate, System.Nullable<double> LCB, System.Nullable<double> LNS, System.Nullable<double> LNSPCTN, System.Nullable<double> PCDH, System.Nullable<double> PCTN, System.Nullable<double> PCKV, System.Nullable<double> PCCV)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
            					
					new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@CreateDate", SqlDbType.SmallDateTime, 4),
                    new SqlParameter("@LCB", SqlDbType.Float, 8),
                    new SqlParameter("@LNS", SqlDbType.Float, 8),
                    new SqlParameter("@LNSPCTN", SqlDbType.Float, 8),
                    new SqlParameter("@PCDH", SqlDbType.Float, 8),
                    new SqlParameter("@PCTN", SqlDbType.Float, 8),
                    new SqlParameter("@PCKV", SqlDbType.Float, 8),
                    new SqlParameter("@PCCV", SqlDbType.Float, 8)
				};
                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((CreateDate.HasValue == true))
                {
                    param[1].Value = ((System.DateTime)(CreateDate.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((LCB.HasValue == true))
                {
                    param[2].Value = ((double)(LCB.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((LNS.HasValue == true))
                {
                    param[3].Value = ((double)(LNS.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((LNSPCTN.HasValue == true))
                {
                    param[4].Value = ((double)(LNSPCTN.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((PCDH.HasValue == true))
                {
                    param[5].Value = ((double)(PCDH.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                if ((PCTN.HasValue == true))
                {
                    param[6].Value = ((double)(PCTN.Value));
                }
                else
                {
                    param[6].Value = System.DBNull.Value;
                }
                if ((PCKV.HasValue == true))
                {
                    param[7].Value = ((double)(PCKV.Value));
                }
                else
                {
                    param[7].Value = System.DBNull.Value;
                }
                if ((PCCV.HasValue == true))
                {
                    param[8].Value = ((double)(PCCV.Value));
                }
                else
                {
                    param[8].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(CoefficientEmployeeFinalKeys.Sp_Upd_H1_CoefficientEmployeeFinal_For_Special, param);
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

        #region GET

        public DataTable GetByFilter(string FullName, int RootId, int Month, int Year)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable(); ;
            try
            {
                SqlParameter[] param = 
                {
                    new SqlParameter("@FullName",SqlDbType.NVarChar, 100),
                    new SqlParameter("@RootId",SqlDbType.Int),
                    new SqlParameter("@Month",SqlDbType.Int),
                    new SqlParameter("@Year",SqlDbType.Int)
                };
                param[0].Value = FullName;
                param[1].Value = RootId;
                param[2].Value = Month;
                param[3].Value = Year;

                sproc = new StoreProcedure(CoefficientEmployeeFinalKeys.Sp_Sel_H1_CoefficientEmployeeFinal_By_Filter, param);
                sproc.RunFill(dt);
                sproc.Dispose();
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }

        public DataTable GetByRootDateForTotal(int RootId, int Month, int Year)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable(); ;
            try
            {
                SqlParameter[] param = 
                {
                    new SqlParameter("@RootId",SqlDbType.Int),
                    new SqlParameter("@Month",SqlDbType.Int),
                    new SqlParameter("@Year",SqlDbType.Int)
                };
                param[0].Value = RootId;
                param[1].Value = Month;
                param[2].Value = Year;

                sproc = new StoreProcedure(CoefficientEmployeeFinalKeys.Sp_Sel_H1_CoefficientEmployeeFinal_By_RootDate_ForTotal, param);
                sproc.RunFill(dt);
                sproc.Dispose();
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;
        }

        public DataTable GetByUserDate(int UserId, int Month, int Year)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable(); ;
            try
            {
                SqlParameter[] param = 
                {
                    new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@Month",SqlDbType.Int),
                    new SqlParameter("@Year",SqlDbType.Int)
                };
                param[0].Value = UserId;
                param[1].Value = Month;
                param[2].Value = Year;

                sproc = new StoreProcedure(CoefficientEmployeeFinalKeys.Sp_Sel_H1_CoefficientEmployeeFinal_By_UserDate, param);
                sproc.RunFill(dt);
                sproc.Dispose();
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return dt;

        }

        #endregion
    }
}
