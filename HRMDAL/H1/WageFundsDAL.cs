using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H1;


namespace HRMDAL.H1
{
    public class WageFundsDAL : Dao
    {
        #region insert, update, delete

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns>int</returns>
        public int InsertByCoefficient(System.Nullable<int> RootId, System.Nullable<double> LNSCoefficientNoKTotal, System.Nullable<double> LNSPCTNCoefficientNoKTotal, System.Nullable<System.DateTime> CreateDate)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{					
                    new SqlParameter("@RootId", SqlDbType.Int, 4),
                    new SqlParameter("@LNSCoefficientNoKTotal", SqlDbType.Float, 8),
                    new SqlParameter("@LNSPCTNCoefficientNoKTotal", SqlDbType.Float, 8),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime, 8)
				};
                
                if ((RootId.HasValue == true))
                {
                    param[0].Value = ((int)(RootId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                if ((LNSCoefficientNoKTotal.HasValue == true))
                {
                    param[1].Value = ((double)(LNSCoefficientNoKTotal.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((LNSPCTNCoefficientNoKTotal.HasValue == true))
                {
                    param[2].Value = ((double)(LNSPCTNCoefficientNoKTotal.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }              
                if ((CreateDate.HasValue == true))
                {
                    param[3].Value = ((System.DateTime)(CreateDate.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(WageFundKeys.Sp_Ins_H1_WageFund_By_Coefficient, param);
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

        public int UpdateByApportionment(System.Nullable<int> Apportionment, System.Nullable<System.DateTime> CreateDate)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{					
                    new SqlParameter("@ApportionmentType", SqlDbType.Int, 4),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime, 8)
				};

                if ((Apportionment.HasValue == true))
                {
                    param[0].Value = ((int)(Apportionment.Value));
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


                sproc = new StoreProcedure(WageFundKeys.Sp_Upd_H1_WageFund_By_Apportionment, param);
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

        public int UpdateByOriginalWageFund(System.Nullable<decimal> LNSOriginalWageFund, System.Nullable<decimal> BonusOriginalWageFund, System.Nullable<System.DateTime> CreateDate, System.Nullable<int> WageFundId, System.Nullable<decimal> UnitPriceLCB, System.Nullable<decimal> UnitPriceLuch, string Remark)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{					
                    new SqlParameter("@LNSOriginalWageFund", SqlDbType.Money, 8),
                    new SqlParameter("@BonusOriginalWageFund", SqlDbType.Money, 8),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@WageFundId", SqlDbType.Int, 4),
                    new SqlParameter("@UnitPriceLCB", SqlDbType.Money, 8),
                    new SqlParameter("@UnitPriceLuch", SqlDbType.Money, 8),
                    new SqlParameter("@Remark", SqlDbType.NVarChar, 1000)

				};

                if ((LNSOriginalWageFund.HasValue == true))
                {
                    param[0].Value = ((decimal)(LNSOriginalWageFund.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }               
                if ((BonusOriginalWageFund.HasValue == true))
                {
                    param[1].Value = ((decimal)(BonusOriginalWageFund.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                
                if ((CreateDate.HasValue == true))
                {
                    param[2].Value = ((System.DateTime)(CreateDate.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((WageFundId.HasValue == true))
                {
                    param[3].Value = ((int)(WageFundId.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((UnitPriceLCB.HasValue == true))
                {
                    param[4].Value = ((decimal)(UnitPriceLCB.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((UnitPriceLuch.HasValue == true))
                {
                    param[5].Value = ((decimal)(UnitPriceLuch.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                param[6].Value = Remark == null ? "" : Remark;

                sproc = new StoreProcedure(WageFundKeys.Sp_Upd_H1_WageFund_By_OriginalWageFund, param);
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

        public int UpdateByShortTerm(System.Nullable<int> RootId, System.Nullable<System.DateTime> CreateDate)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{					
                    new SqlParameter("@RootId", SqlDbType.Int, 4),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime, 8)
                    
				};

                if ((RootId.HasValue == true))
                {
                    param[0].Value = ((decimal)(RootId.Value));
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


                sproc = new StoreProcedure(WageFundKeys.Sp_Upd_H1_WageFund_By_ShortTerm, param);
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

        public int UpdateByNoKWageFund(System.Nullable<System.DateTime> CreateDate)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{					
                    new SqlParameter("@CreateDate", SqlDbType.DateTime, 8)
				};

                if ((CreateDate.HasValue == true))
                {
                    param[0].Value = ((System.DateTime)(CreateDate.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }


                sproc = new StoreProcedure(WageFundKeys.Sp_Upd_H1_WageFund_By_NoKWageFund, param);
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

        public int UpdateByTotalPeriod_II(System.Nullable<int> RootId, System.Nullable<System.DateTime> CreateDate)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{					
                    new SqlParameter("@RootId", SqlDbType.Int, 4),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime, 8)
                    
				};

                if ((RootId.HasValue == true))
                {
                    param[0].Value = ((decimal)(RootId.Value));
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


                sproc = new StoreProcedure(WageFundKeys.Sp_Upd_H1_WageFund_By_TotalPeriod_II, param);
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

        //public int Delete(int wageFundId)
        //{
        //    int identity = 0;
        //    Debug.Assert(sproc == null);
        //    try
        //    {
        //        SqlParameter[] param = 
        //        {
        //            new SqlParameter("@WageFundId",SqlDbType.Int)
        //        };

        //        param[0].Value = wageFundId;
        //        sproc = new StoreProcedure(WageFundKeys.Sp_Del_H1_WageFund, param);
        //        sproc.Run();
        //        sproc.Commit();

        //    }
        //    catch (SqlException se)
        //    {
        //        sproc.RollBack();

        //        throw new HRMException(se.Message, se.Number);
        //    }
        //    finally
        //    {
        //        sproc.Dispose();
        //    }
        //    return identity;
        //}

        public int DeleteByDate(System.Nullable<int> Month, System.Nullable<int> Year)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@Month",SqlDbType.Int),
                    new SqlParameter("@Year",SqlDbType.Int)
				};

                if ((Month.HasValue == true))
                {
                    param[0].Value = ((int)(Month.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((Year.HasValue == true))
                {
                    param[1].Value = ((int)(Year.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(WageFundKeys.Sp_Del_H1_WageFund_By_Date, param);
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

        public DataTable GetAll()
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {

                sproc = new StoreProcedure(WageFundKeys.Sp_Sel_H1_WageFund_By_All, null);
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
        public DataTable GetByCreateDate(System.Nullable<int> Month, System.Nullable<int> Year, System.Nullable<int> ApportionmentType)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {

                SqlParameter[] param = 
				{
                    new SqlParameter("@Month",SqlDbType.Int),
                    new SqlParameter("@Year",SqlDbType.Int),
                    new SqlParameter("@ApportionmentType",SqlDbType.Int)
				};

                if ((Month.HasValue == true))
                {
                    param[0].Value = ((int)(Month.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((Year.HasValue == true))
                {
                    param[1].Value = ((int)(Year.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }

                if ((ApportionmentType.HasValue == true))
                {
                    param[2].Value = ((int)(ApportionmentType.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                
                sproc = new StoreProcedure(WageFundKeys.Sp_Sel_H1_WageFund_By_CreateDate, param);
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
