using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H1;


namespace HRMDAL.H1
{
    public class IncomesDAL : Dao
    {

        #region  insert, update, delete

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns>int</returns>
        /// 
        public long InsertShortTerm(int UserId, decimal LNS, decimal LCBNN, decimal PCCV, decimal PCTN,
	            decimal PCDH, decimal TCBHXH, decimal TienAn, decimal TienThemGio, decimal TienLamDem,
                decimal TotalShortTerm, string CalculatingLog1, int IsChangeContract, string Remark, DateTime CreateDate,
                decimal TCOm, decimal TCTS1Lan, int Type)
                
        {

            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@LNS",SqlDbType.Money),
                    new SqlParameter("@LCBNN",SqlDbType.Money),
                    new SqlParameter("@PCCV",SqlDbType.Money),
                    new SqlParameter("@PCTN",SqlDbType.Money),
                    new SqlParameter("@PCDH",SqlDbType.Money),
                    new SqlParameter("@TCBHXH",SqlDbType.Money),
                    new SqlParameter("@TienAn",SqlDbType.Money),
                    new SqlParameter("@TienThemGio",SqlDbType.Money),
                    new SqlParameter("@TienLamDem",SqlDbType.Money),
                    new SqlParameter("@TotalShortTerm",SqlDbType.Money),                    
                    new SqlParameter("@CalculatingLog1",SqlDbType.NText),
                    new SqlParameter("@IsChangeContract",SqlDbType.Int),                    
                    new SqlParameter("@Remark",SqlDbType.NVarChar, 1000),
                	new SqlParameter("@CreateDate",SqlDbType.DateTime),
                    new SqlParameter("@TCOm",SqlDbType.Money),
                    new SqlParameter("@TCTS1Lan",SqlDbType.Money),
                    new SqlParameter("@Type",SqlDbType.Int)
				};
                param[0].Value = UserId;
                param[1].Value = LNS;
                param[2].Value = LCBNN;
                param[3].Value = PCCV;
                param[4].Value = PCTN;
                param[5].Value = PCDH;
                param[6].Value = TCBHXH;
                param[7].Value = TienAn;
                param[8].Value = TienThemGio;
                param[9].Value = TienLamDem;
                param[10].Value = TotalShortTerm;
                param[11].Value = CalculatingLog1;                                
                param[12].Value = IsChangeContract;                
                param[13].Value = Remark == null ? string.Empty : Remark;
                param[14].Value = CreateDate;
                param[15].Value = TCOm;
                param[16].Value = TCTS1Lan;
                param[17].Value = Type;

                sproc = new StoreProcedure(IncomeKeys.Sp_Ins_H1_Income_ShortTerm, param);
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


        public int DeleteByRootDate(int rootId, int month, int year)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@RootId",SqlDbType.Int),
                    new SqlParameter("@Month",SqlDbType.Int),
                    new SqlParameter("@Year",SqlDbType.Int)
				};

                param[0].Value = rootId;
                param[1].Value = month;
                param[2].Value = year;

                sproc = new StoreProcedure(IncomeKeys.Sp_Del_H1_Incomes_By_Root_Date, param);

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


        public long UpdateByPeriod_II(System.Nullable<decimal> LNS,
                    System.Nullable<decimal> BoSungLuong,
                    System.Nullable<decimal> TienThuong,
                    System.Nullable<decimal> TrBHXH,
                    System.Nullable<decimal> TrBHYT,
                    System.Nullable<decimal> TrDoanPhi,
                    System.Nullable<decimal> ThueThuNhap,
                    System.Nullable<decimal> TotalIncome,
                    System.Nullable<decimal> TotalIncomeForTax,
                    string CalculatingLog2,
                    System.Nullable<bool> Lock,
                    string Remark,                    
                    System.Nullable<long> IncomeId,
                    System.Nullable<int> UserId,
                    System.Nullable<System.DateTime> CreateDate,
                    System.Nullable<decimal> TotalPeriod_I,
                    System.Nullable<double> FinalConversionLNSCoefficient,
                    string FinalConversionLNSCoefficientLog,
                    System.Nullable<decimal> TrBHTN)
        {

            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@LNS", SqlDbType.Money, 8),
                    new SqlParameter("@BoSungLuong", SqlDbType.Money, 8),
                    new SqlParameter("@TienThuong", SqlDbType.Money, 8),
                    new SqlParameter("@TrBHXH", SqlDbType.Money, 8),
                    new SqlParameter("@TrBHYT", SqlDbType.Money, 8),
                    new SqlParameter("@TrDoanPhi", SqlDbType.Money, 8),
                    new SqlParameter("@ThueThuNhap", SqlDbType.Money, 8),
                    new SqlParameter("@TotalIncome", SqlDbType.Money, 8),
                    new SqlParameter("@TotalIncomeForTax", SqlDbType.Money, 8),
                    new SqlParameter("@CalculatingLog2", SqlDbType.NText, 1073741823),
                    new SqlParameter("@Lock", SqlDbType.Bit, 1),
                    new SqlParameter("@Remark", SqlDbType.NVarChar, 1000),                    
                    new SqlParameter("@IncomeId", SqlDbType.BigInt, 8),
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@TotalPeriod_I", SqlDbType.Money, 8),
                    new SqlParameter("@FinalConversionLNSCoefficient", SqlDbType.Float, 8),
                    new SqlParameter("@FinalConversionLNSCoefficientLog", SqlDbType.NText, 1073741823),
                    new SqlParameter("@TrBHTN", SqlDbType.Money, 8)
                    
				};
                if ((LNS.HasValue == true))
                {
                    param[0].Value = ((decimal)(LNS.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((BoSungLuong.HasValue == true))
                {
                    param[1].Value = ((decimal)(BoSungLuong.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((TienThuong.HasValue == true))
                {
                    param[2].Value = ((decimal)(TienThuong.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((TrBHXH.HasValue == true))
                {
                    param[3].Value = ((decimal)(TrBHXH.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((TrBHYT.HasValue == true))
                {
                    param[4].Value = ((decimal)(TrBHYT.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((TrDoanPhi.HasValue == true))
                {
                    param[5].Value = ((decimal)(TrDoanPhi.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                if ((ThueThuNhap.HasValue == true))
                {
                    param[6].Value = ((decimal)(ThueThuNhap.Value));
                }
                else
                {
                    param[6].Value = System.DBNull.Value;
                }
                if ((TotalIncome.HasValue == true))
                {
                    param[7].Value = ((decimal)(TotalIncome.Value));
                }
                else
                {
                    param[7].Value = System.DBNull.Value;
                }
                if ((TotalIncomeForTax.HasValue == true))
                {
                    param[8].Value = ((decimal)(TotalIncomeForTax.Value));
                }
                else
                {
                    param[8].Value = System.DBNull.Value;
                }
                if ((CalculatingLog2 == null))
                {
                    param[9].Value = System.DBNull.Value;
                }
                else
                {
                    param[9].Value = ((string)(CalculatingLog2));
                }
                if ((Lock.HasValue == true))
                {
                    param[10].Value = ((bool)(Lock.Value));
                }
                else
                {
                    param[10].Value = System.DBNull.Value;
                }
                if ((Remark == null))
                {
                    param[11].Value = System.DBNull.Value;
                }
                else
                {
                    param[11].Value = ((string)(Remark));
                }
                if ((IncomeId.HasValue == true))
                {
                    param[12].Value = ((long)(IncomeId.Value));
                }
                else
                {
                    param[12].Value = System.DBNull.Value;
                }
                if ((UserId.HasValue == true))
                {
                    param[13].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[13].Value = System.DBNull.Value;
                }
                if ((CreateDate.HasValue == true))
                {
                    param[14].Value = ((System.DateTime)(CreateDate.Value));
                }
                else
                {
                    param[14].Value = System.DBNull.Value;
                }
                if ((TotalPeriod_I.HasValue == true))
                {
                    param[15].Value = ((decimal)(TotalPeriod_I.Value));
                }
                else
                {
                    param[15].Value = System.DBNull.Value;
                }
                if ((FinalConversionLNSCoefficient.HasValue == true))
                {
                    param[16].Value = ((decimal)(FinalConversionLNSCoefficient.Value));
                }
                else
                {
                    param[16].Value = System.DBNull.Value;
                }
                if ((FinalConversionLNSCoefficientLog == null))
                {
                    param[17].Value = System.DBNull.Value;
                }
                else
                {
                    param[17].Value = ((string)(FinalConversionLNSCoefficientLog));
                }
                if ((TrBHTN.HasValue == true))
                {
                    param[18].Value = ((decimal)(TrBHTN.Value));
                }
                else
                {
                    param[18].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(IncomeKeys.Sp_Upd_H1_Income_By_Period_II, param);
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


        public long UpdateByPeriod_III(System.Nullable<decimal> LNSBalance,
                    System.Nullable<decimal> BonusBalance,
                    string @CalculatingLog3,
                    System.Nullable<long> IncomeId,
                    System.Nullable<int> UserId,
                    System.Nullable<System.DateTime> CreateDate)
        {

            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param = 
				{
                    new SqlParameter("@LNSBalance", SqlDbType.Money, 8),
                    new SqlParameter("@BonusBalance", SqlDbType.Money, 8),
                    new SqlParameter("@CalculatingLog3", SqlDbType.NText, 1073741823),
                    new SqlParameter("@IncomeId", SqlDbType.BigInt, 8),
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime, 8)                    
				};
                if ((LNSBalance.HasValue == true))
                {
                    param[0].Value = ((decimal)(LNSBalance.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((BonusBalance.HasValue == true))
                {
                    param[1].Value = ((decimal)(BonusBalance.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }                
                if ((CalculatingLog3 == null))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = ((string)(CalculatingLog3));
                }                
                if ((IncomeId.HasValue == true))
                {
                    param[3].Value = ((long)(IncomeId.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((UserId.HasValue == true))
                {
                    param[4].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((CreateDate.HasValue == true))
                {
                    param[5].Value = ((System.DateTime)(CreateDate.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                

                sproc = new StoreProcedure(IncomeKeys.Sp_Upd_H1_Income_By_Period_III, param);
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

        #region method get

        public DataTable GetByFilter(string fullName, int departmentId, int month, int year)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable(); ;
            try
            {
                SqlParameter[] param = 
                {
                    new SqlParameter("@FullName",SqlDbType.NVarChar,100),
                    new SqlParameter("@DepartmentId",SqlDbType.Int,4),
                    new SqlParameter("@Month",SqlDbType.Int,4),
                    new SqlParameter("@Year",SqlDbType.Int,4)
                };
                param[0].Value = fullName;
                param[1].Value = departmentId;
                param[2].Value = month;
                param[3].Value = year;
                sproc = new StoreProcedure(IncomeKeys.SP_INCOME_GET_BY_FILTER, param);
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
        public DataTable GetByFilter1(int RootId, int Month, int Year, int Type)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable(); ;
            try
            {
                SqlParameter[] param = 
                {                    
                    new SqlParameter("@RootId",SqlDbType.Int,4),
                    new SqlParameter("@Month",SqlDbType.Int,4),
                    new SqlParameter("@Year",SqlDbType.Int,4),
                    new SqlParameter("@Type",SqlDbType.Int,4)
                };

                param[0].Value = RootId;
                param[1].Value = Month;
                param[2].Value = Year;
                param[3].Value = Type;

                sproc = new StoreProcedure(IncomeKeys.Sp_Sel_H1_EmployeeIncomeByFilter1, param);
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

        public DataTable GetByUserIdAndDate(int userId, int month, int year)
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
                param[0].Value = userId;
                param[1].Value = month;
                param[2].Value = year;
                sproc = new StoreProcedure(IncomeKeys.Sp_Sel_H1_EmployeeIncome_By_UserId_Date, param);
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


        public DataTable GetByRootDateForTotal(int RootId, int Month, int Year)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable(); ;
            try
            {
                SqlParameter[] param = 
                {                    
                    new SqlParameter("@RootId",SqlDbType.Int,4),
                    new SqlParameter("@Month",SqlDbType.Int,4),
                    new SqlParameter("@Year",SqlDbType.Int,4)
                };

                param[0].Value = RootId;
                param[1].Value = Month;
                param[2].Value = Year;                

                sproc = new StoreProcedure(IncomeKeys.Sp_Sel_H1_EmployeeIncome_By_RootDate_ForTotal, param);
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
