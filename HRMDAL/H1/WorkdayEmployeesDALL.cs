using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H1;

namespace HRMDAL.H1
{
    public class WorkdayEmployeesDALL : Dao
    {
        #region insert, update, delete

        public long InsertByDate_DeptId(string Day25L, string Day26L, string Day27L, string Day28L, string Day29L, string Day30L, string Day31L, string DepartmentIds, System.Nullable<System.DateTime> WorkdayDateL, System.Nullable<int> CreateUserL, System.Nullable<double> XQDL, System.Nullable<double> XL, System.Nullable<int> TypeL, System.Nullable<int> StatusL)
        {
            long identity = 0;
            //Debug.Assert(sproc == null);
            //try
            //{
            //    SqlParameter[] param = 
            //    {                   
            //        new SqlParameter("@Day25L", SqlDbType.VarChar, 20),
            //        new SqlParameter("@Day26L", SqlDbType.VarChar, 20),
            //        new SqlParameter("@Day27L", SqlDbType.VarChar, 20),
            //        new SqlParameter("@Day28L", SqlDbType.VarChar, 20),
            //        new SqlParameter("@Day29L", SqlDbType.VarChar, 20),
            //        new SqlParameter("@Day30L", SqlDbType.VarChar, 20),
            //        new SqlParameter("@Day31L", SqlDbType.VarChar, 20),                    
            //        new SqlParameter("@DeptIds", SqlDbType.VarChar, 1000),
            //        new SqlParameter("@WorkdayDateL", SqlDbType.DateTime, 8),
            //        new SqlParameter("@CreateUserL", SqlDbType.Int, 4),
            //        new SqlParameter("@XQDL", SqlDbType.Float),
            //        new SqlParameter("@XL", SqlDbType.Float),
            //        new SqlParameter("@TypeL", SqlDbType.Int),
            //        new SqlParameter("@StatusL", SqlDbType.Int)
            //    };

            //    if ((Day25L == null) || (Day25L == ""))
            //    {
            //        param[0].Value = System.DBNull.Value;
            //    }
            //    else
            //    {
            //        param[0].Value = ((string)(Day25L));
            //    }
            //    if ((Day26L == null) || (Day26L == ""))
            //    {
            //        param[1].Value = System.DBNull.Value;
            //    }
            //    else
            //    {
            //        param[1].Value = ((string)(Day26L));
            //    }
            //    if ((Day27L == null) || (Day27L == ""))
            //    {
            //        param[2].Value = System.DBNull.Value;
            //    }
            //    else
            //    {
            //        param[2].Value = ((string)(Day27L));
            //    }
            //    if ((Day28L == null) || (Day28L == ""))
            //    {
            //        param[3].Value = System.DBNull.Value;
            //    }
            //    else
            //    {
            //        param[3].Value = ((string)(Day28L));
            //    }
            //    if ((Day29L == null) || (Day29L == ""))
            //    {
            //        param[4].Value = System.DBNull.Value;
            //    }
            //    else
            //    {
            //        param[4].Value = ((string)(Day29L));
            //    }
            //    if ((Day30L == null) || (Day30L == ""))
            //    {
            //        param[5].Value = System.DBNull.Value;
            //    }
            //    else
            //    {
            //        param[5].Value = ((string)(Day30L));
            //    }
            //    if ((Day31L == null) || (Day31L == ""))
            //    {
            //        param[6].Value = System.DBNull.Value;
            //    }
            //    else
            //    {
            //        param[6].Value = ((string)(Day31L));
            //    }

            //    if ((DepartmentIds == null))
            //    {
            //        param[7].Value = System.DBNull.Value;
            //    }
            //    else
            //    {
            //        param[7].Value = ((string)(DepartmentIds));

            //    }
            //    if ((WorkdayDateL.HasValue == true))
            //    {
            //        param[8].Value = ((System.DateTime)(WorkdayDateL.Value));
            //    }
            //    else
            //    {
            //        param[8].Value = System.DBNull.Value;
            //    }
            //    if ((CreateUserL.HasValue == true))
            //    {
            //        param[9].Value = ((int)(CreateUserL.Value));
            //    }
            //    else
            //    {
            //        param[9].Value = System.DBNull.Value;
            //    }
            //    if ((XQDL.HasValue == true))
            //    {
            //        if (XQDL == Constants.WorkdayEmployee_DefaultValue)
            //        {
            //            param[10].Value = System.DBNull.Value;
            //        }
            //        else
            //        {
            //            param[10].Value = ((double)(XQDL.Value));
            //        }
            //    }
            //    else
            //    {
            //        param[10].Value = System.DBNull.Value;
            //    }
            //    if ((XL.HasValue == true))
            //    {
            //        if (XL == Constants.WorkdayEmployee_DefaultValue)
            //        {
            //            param[11].Value = System.DBNull.Value;
            //        }
            //        else
            //        {
            //            param[11].Value = ((double)(XL.Value));
            //        }
            //    }
            //    else
            //    {
            //        param[11].Value = System.DBNull.Value;
            //    }
            //    if ((TypeL.HasValue == true))
            //    {
            //        if (TypeL == Constants.WorkdayEmployee_DefaultValue)
            //        {
            //            param[12].Value = System.DBNull.Value;
            //        }
            //        else
            //        {
            //            param[12].Value = ((double)(TypeL.Value));
            //        }
            //    }
            //    else
            //    {
            //        param[12].Value = System.DBNull.Value;
            //    }
            //    if ((StatusL.HasValue == true))
            //    {
            //        if (StatusL == Constants.WorkdayEmployee_DefaultValue)
            //        {
            //            param[13].Value = System.DBNull.Value;
            //        }
            //        else
            //        {
            //            param[13].Value = ((double)(StatusL.Value));
            //        }
            //    }
            //    else
            //    {
            //        param[13].Value = System.DBNull.Value;
            //    }

            //    sproc = new StoreProcedure(WorkdayEmployeeLKeys.Sp_Ins_H1_WorkdayEmployeeL_By_Date_DeptIds, param);
            //    identity = sproc.Run();
            //    sproc.Commit();


            //}
            //catch (SqlException se)
            //{
            //    sproc.RollBack();
            //    throw new HRMException(se.Message, se.Number);
            //}
            //finally
            //{
            //    sproc.Dispose();
            //}
            return identity;
        }


        public long InsertByDate_UserId(System.Nullable<int> UserId, System.Nullable<System.DateTime> WorkdayDateL, string Day25L, string Day26L, string Day27L, string Day28L, string Day29L, string Day30L, string Day31L, System.Nullable<int> CreateUser, System.Nullable<double> XQDL, System.Nullable<double> XL, System.Nullable<int> TypeL, System.Nullable<int> StatusL)
        {
            long identity = 0;
            //Debug.Assert(sproc == null);
            //try
            //{
            //    SqlParameter[] param = 
            //    {                   
            //        new SqlParameter("@UserId", SqlDbType.Int),
            //        new SqlParameter("@WorkdayDateL", SqlDbType.DateTime, 8),

            //        new SqlParameter("@Day25L", SqlDbType.VarChar, 20),
            //        new SqlParameter("@Day26L", SqlDbType.VarChar, 20),
            //        new SqlParameter("@Day27L", SqlDbType.VarChar, 20),
            //        new SqlParameter("@Day28L", SqlDbType.VarChar, 20),
            //        new SqlParameter("@Day29L", SqlDbType.VarChar, 20),
            //        new SqlParameter("@Day30L", SqlDbType.VarChar, 20),
            //        new SqlParameter("@Day31L", SqlDbType.VarChar, 20),                    
            //        new SqlParameter("@CreateUserL", SqlDbType.Int, 4),
            //        new SqlParameter("@XQDL", SqlDbType.Float),
            //        new SqlParameter("@XL", SqlDbType.Float),
            //        new SqlParameter("@TypeL", SqlDbType.Int),
            //        new SqlParameter("@StatusL", SqlDbType.Int)
            //    };

            //    if ((UserId.HasValue == true))
            //    {
            //        if (UserId == Constants.WorkdayEmployee_DefaultValue)
            //        {
            //            param[0].Value = System.DBNull.Value;
            //        }
            //        else
            //        {
            //            param[0].Value = ((double)(UserId.Value));
            //        }
            //    }
            //    else
            //    {
            //        param[0].Value = System.DBNull.Value;
            //    }

            //    if ((WorkdayDateL.HasValue == true))
            //    {
            //        param[1].Value = ((System.DateTime)(WorkdayDateL.Value));
            //    }
            //    else
            //    {
            //        param[1].Value = System.DBNull.Value;
            //    }

            //    if ((Day25L == null) || (Day25L == ""))
            //    {
            //        param[2].Value = System.DBNull.Value;
            //    }
            //    else
            //    {
            //        param[2].Value = ((string)(Day25L));
            //    }
            //    if ((Day26L == null) || (Day26L == ""))
            //    {
            //        param[3].Value = System.DBNull.Value;
            //    }
            //    else
            //    {
            //        param[3].Value = ((string)(Day26L));
            //    }
            //    if ((Day27L == null) || (Day27L == ""))
            //    {
            //        param[4].Value = System.DBNull.Value;
            //    }
            //    else
            //    {
            //        param[4].Value = ((string)(Day27L));
            //    }
            //    if ((Day28L == null) || (Day28L == ""))
            //    {
            //        param[5].Value = System.DBNull.Value;
            //    }
            //    else
            //    {
            //        param[5].Value = ((string)(Day28L));
            //    }
            //    if ((Day29L == null) || (Day29L == ""))
            //    {
            //        param[6].Value = System.DBNull.Value;
            //    }
            //    else
            //    {
            //        param[6].Value = ((string)(Day29L));
            //    }
            //    if ((Day30L == null) || (Day30L == ""))
            //    {
            //        param[7].Value = System.DBNull.Value;
            //    }
            //    else
            //    {
            //        param[7].Value = ((string)(Day30L));
            //    }
            //    if ((Day31L == null) || (Day31L == ""))
            //    {
            //        param[8].Value = System.DBNull.Value;
            //    }
            //    else
            //    {
            //        param[8].Value = ((string)(Day31L));
            //    }
            //    if ((CreateUser.HasValue == true))
            //    {
            //        if (CreateUser == Constants.WorkdayEmployee_DefaultValue)
            //        {
            //            param[9].Value = System.DBNull.Value;
            //        }
            //        else
            //        {
            //            param[9].Value = ((double)(CreateUser.Value));
            //        }
            //    }
            //    else
            //    {
            //        param[9].Value = System.DBNull.Value;
            //    }
                
            //    if ((XQDL.HasValue == true))
            //    {
            //        if (XQDL == Constants.WorkdayEmployee_DefaultValue)
            //        {
            //            param[10].Value = System.DBNull.Value;
            //        }
            //        else
            //        {
            //            param[10].Value = ((double)(XQDL.Value));
            //        }
            //    }
            //    else
            //    {
            //        param[10].Value = System.DBNull.Value;
            //    }
            //    if ((XL.HasValue == true))
            //    {
            //        if (XL == Constants.WorkdayEmployee_DefaultValue)
            //        {
            //            param[11].Value = System.DBNull.Value;
            //        }
            //        else
            //        {
            //            param[11].Value = ((double)(XL.Value));
            //        }
            //    }
            //    else
            //    {
            //        param[11].Value = System.DBNull.Value;
            //    }
            //    if ((TypeL.HasValue == true))
            //    {
            //        if (TypeL == Constants.WorkdayEmployee_DefaultValue)
            //        {
            //            param[12].Value = System.DBNull.Value;
            //        }
            //        else
            //        {
            //            param[12].Value = ((double)(TypeL.Value));
            //        }
            //    }
            //    else
            //    {
            //        param[12].Value = System.DBNull.Value;
            //    }
            //    if ((StatusL.HasValue == true))
            //    {
            //        if (StatusL == Constants.WorkdayEmployee_DefaultValue)
            //        {
            //            param[13].Value = System.DBNull.Value;
            //        }
            //        else
            //        {
            //            param[13].Value = ((double)(StatusL.Value));
            //        }
            //    }
            //    else
            //    {
            //        param[13].Value = System.DBNull.Value;
            //    }

            //    sproc = new StoreProcedure(WorkdayEmployeeLKeys.Sp_Ins_H1_WorkdayEmployeesL, param);
            //    identity = sproc.Run();
            //    sproc.Commit();


            //}
            //catch (SqlException se)
            //{
            //    sproc.RollBack();
            //    throw new HRMException(se.Message, se.Number);
            //}
            //finally
            //{
            //    sproc.Dispose();
            //}
            return identity;
        }

        public long UpdateByDate_UserId(
                    System.Nullable<int> UserId,
                    System.Nullable<System.DateTime> WorkdayDateL,
                    string Day1L, string Day2L, string Day3L, string Day4L, string Day5L, string Day6L, string Day7L, string Day8L, string Day9L,
                    string Day10L, string Day11L, string Day12L, string Day13L, string Day14L, string Day15L, string Day16L, string Day17L, string Day18L, string Day19L,
                    string Day20L, string Day21L, string Day22L, string Day23L, string Day24L, string Day25L, string Day26L, string Day27L, string Day28L, string Day29L, string Day30L, string Day31L,
                   
                    System.Nullable<double> XL,
                    System.Nullable<double> F_OmL, System.Nullable<double> F_OmDaiNgayL, System.Nullable<double> F_ThaiSanL, System.Nullable<double> F_TNLDL, System.Nullable<double> F_NamL,
                    System.Nullable<double> F_dbL, System.Nullable<double> F_KoLuongCLDL, System.Nullable<double> F_KoLuongKLDL, System.Nullable<double> F_DiDuongL, System.Nullable<double> F_CongTacL,
                    System.Nullable<double> F_HocSAGS, System.Nullable<double> F_Hoc1L, System.Nullable<double> F_Hoc2L, System.Nullable<double> F_Hoc3L, System.Nullable<double> F_Hoc4L, System.Nullable<double> F_Hoc5L, System.Nullable<double> F_Hoc6L, System.Nullable<double> F_Hoc7L,
                    System.Nullable<double> F_Con_OmL, System.Nullable<double> F_KHHDSL, System.Nullable<double> F_SayThaiL, System.Nullable<double> F_KhamThaiL, System.Nullable<double> F_ConChetL, System.Nullable<double> F_DinhChiCongTacL,
                    System.Nullable<double> F_TamHoanHDL, System.Nullable<double> F_HoiHopL, System.Nullable<double> F_LeL, System.Nullable<double> NghiTuanL, System.Nullable<double> NghiBuL, System.Nullable<double> NghiViecL, System.Nullable<double> ChuaDiLamL,
                    System.Nullable<double> NightTimeL, System.Nullable<double> MarkL, string RankL, System.Nullable<DateTime> LastUpdateL, System.Nullable<double> UpdateUserL, string Remark
                    )
        {
            long identity = 0;
//            Debug.Assert(sproc == null);
//            try
//            {
//                SqlParameter[] param = 
//                {                   
                    
//                    new SqlParameter("@UserId", SqlDbType.Int),
//                    new SqlParameter("@WorkdayDateL", SqlDbType.DateTime, 8),

//                    #region day

//                    new SqlParameter("@Day1L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day2L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day3L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day4L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day5L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day6L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day7L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day8L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day9L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day10L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day11L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day12L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day13L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day14L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day15L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day16L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day17L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day18L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day19L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day20L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day21L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day22L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day23L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day24L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day25L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day26L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day27L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day28L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day29L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day30L", SqlDbType.VarChar, 20),
//                    new SqlParameter("@Day31L", SqlDbType.VarChar, 20),                                     
//#endregion

//                    new SqlParameter("@XL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_OmL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_OmDaiNgayL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_ThaiSanL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_TNLDL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_NamL", SqlDbType.Float, 8),

//                    new SqlParameter("@F_dbL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_KoLuongCLDL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_KoLuongKLDL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_DiDuongL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_CongTacL", SqlDbType.Float, 8),

//                    new SqlParameter("@F_HocSAGSL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_Hoc1L", SqlDbType.Float, 8),
//                    new SqlParameter("@F_Hoc2L", SqlDbType.Float, 8),
//                    new SqlParameter("@F_Hoc3L", SqlDbType.Float, 8),
//                    new SqlParameter("@F_Hoc4L", SqlDbType.Float, 8),
//                    new SqlParameter("@F_Hoc5L", SqlDbType.Float, 8),
//                    new SqlParameter("@F_Hoc6L", SqlDbType.Float, 8),
//                    new SqlParameter("@F_Hoc7L", SqlDbType.Float, 8),

//                    new SqlParameter("@F_Con_OmL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_KHHDSL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_SayThaiL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_KhamThaiL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_ConChetL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_DinhChiCongTacL", SqlDbType.Float, 8),

//                    new SqlParameter("@F_TamHoanHDL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_HoiHopL", SqlDbType.Float, 8),
//                    new SqlParameter("@F_LeL", SqlDbType.Float, 8),
//                    new SqlParameter("@NghiTuanL", SqlDbType.Float, 8),
//                    new SqlParameter("@NghiBuL", SqlDbType.Float, 8),
//                    new SqlParameter("@NghiViecL", SqlDbType.Float, 8),
                    
//                    new SqlParameter("@NightTimeL", SqlDbType.Float, 8),
//                    new SqlParameter("@MarkL", SqlDbType.Float, 8),
//                    new SqlParameter("@RankL", SqlDbType.NVarChar, 50),

//                    new SqlParameter("@LastUpdateL", SqlDbType.DateTime, 8),
//                    new SqlParameter("@UpdateUserL", SqlDbType.Int, 4),

//                    new SqlParameter("@Remark", SqlDbType.NVarChar, 1000),

//                    new SqlParameter("@ChuaDiLamL", SqlDbType.Float, 8)
//                };

//                param[0].Value = ((int)(UserId.Value));
//                param[1].Value = ((System.DateTime)(WorkdayDateL.Value));

//                #region Day

//                param[2].Value = ((string)(Day1L));
//                param[3].Value = ((string)(Day2L));
//                param[4].Value = ((string)(Day3L));
//                param[5].Value = ((string)(Day4L));
//                param[6].Value = ((string)(Day5L));
//                param[7].Value = ((string)(Day6L));
//                param[8].Value = ((string)(Day7L));
//                param[9].Value = ((string)(Day8L));
//                param[10].Value = ((string)(Day9L));
//                param[11].Value = ((string)(Day10L));
//                param[12].Value = ((string)(Day11L));
//                param[13].Value = ((string)(Day12L));
//                param[14].Value = ((string)(Day13L));
//                param[15].Value = ((string)(Day14L));
//                param[16].Value = ((string)(Day15L));
//                param[17].Value = ((string)(Day16L));
//                param[18].Value = ((string)(Day17L));
//                param[19].Value = ((string)(Day18L));
//                param[20].Value = ((string)(Day19L));
//                param[21].Value = ((string)(Day20L));
//                param[22].Value = ((string)(Day21L));
//                param[23].Value = ((string)(Day22L));
//                param[24].Value = ((string)(Day23L));
//                param[25].Value = ((string)(Day24L));
//                param[26].Value = ((string)(Day25L));
//                param[27].Value = ((string)(Day26L));
//                param[28].Value = ((string)(Day27L));
//                param[29].Value = ((string)(Day28L));
//                param[30].Value = ((string)(Day29L));
//                param[31].Value = ((string)(Day30L));
//                param[32].Value = ((string)(Day31L));

//                #endregion

//                #region workdayEmployees Luong

//                if ((XL.HasValue == true))
//                {
//                    if (XL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[33].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[33].Value = ((double)(XL.Value));
//                    }
//                }
//                else
//                {
//                    param[33].Value = System.DBNull.Value;
//                }

//                if ((F_OmL.HasValue == true))
//                {
//                    if (F_OmL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[34].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[34].Value = ((double)(F_OmL.Value));
//                    }
//                }
//                else
//                {
//                    param[34].Value = System.DBNull.Value;
//                }
//                if ((F_OmDaiNgayL.HasValue == true))
//                {
//                    if (F_OmDaiNgayL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[35].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[35].Value = ((double)(F_OmDaiNgayL.Value));
//                    }
//                }
//                else
//                {
//                    param[35].Value = System.DBNull.Value;
//                }
//                if ((F_ThaiSanL.HasValue == true))
//                {
//                    if (F_ThaiSanL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[36].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[36].Value = ((double)(F_ThaiSanL.Value));
//                    }
//                }
//                else
//                {
//                    param[36].Value = System.DBNull.Value;
//                }
//                if ((F_TNLDL.HasValue == true))
//                {
//                    if (F_TNLDL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[37].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[37].Value = ((double)(F_TNLDL.Value));
//                    }
//                }
//                else
//                {
//                    param[37].Value = System.DBNull.Value;
//                }
//                if ((F_NamL.HasValue == true))
//                {
//                    if (F_NamL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[38].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[38].Value = ((double)(F_NamL.Value));
//                    }
//                }
//                else
//                {
//                    param[38].Value = System.DBNull.Value;
//                }


//                if ((F_dbL.HasValue == true))
//                {
//                    if (F_dbL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[39].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[39].Value = ((double)(F_dbL.Value));
//                    }
//                }
//                else
//                {
//                    param[39].Value = System.DBNull.Value;
//                }
//                if ((F_KoLuongCLDL.HasValue == true))
//                {
//                    if (F_KoLuongCLDL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[40].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[40].Value = ((double)(F_KoLuongCLDL.Value));
//                    }
//                }
//                else
//                {
//                    param[40].Value = System.DBNull.Value;
//                }
//                if ((F_KoLuongKLDL.HasValue == true))
//                {
//                    if (F_KoLuongKLDL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[41].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[41].Value = ((double)(F_KoLuongKLDL.Value));
//                    }
//                }
//                else
//                {
//                    param[41].Value = System.DBNull.Value;
//                }
//                if ((F_DiDuongL.HasValue == true))
//                {
//                    if (F_DiDuongL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[42].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[42].Value = ((double)(F_DiDuongL.Value));
//                    }
//                }
//                else
//                {
//                    param[42].Value = System.DBNull.Value;
//                }
//                if ((F_CongTacL.HasValue == true))
//                {
//                    if (F_CongTacL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[43].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[43].Value = ((double)(F_CongTacL.Value));
//                    }
//                }
//                else
//                {
//                    param[43].Value = System.DBNull.Value;
//                }

//                if ((F_HocSAGS.HasValue == true))
//                {
//                    if (F_HocSAGS == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[44].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[44].Value = ((double)(F_HocSAGS.Value));
//                    }
//                }
//                else
//                {
//                    param[44].Value = System.DBNull.Value;
//                }
//                if ((F_Hoc1L.HasValue == true))
//                {
//                    if (F_Hoc1L == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[45].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[45].Value = ((double)(F_Hoc1L.Value));
//                    }
//                }
//                else
//                {
//                    param[45].Value = System.DBNull.Value;
//                }
//                if ((F_Hoc2L.HasValue == true))
//                {
//                    if (F_Hoc2L == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[46].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[46].Value = ((double)(F_Hoc2L.Value));
//                    }
//                }
//                else
//                {
//                    param[46].Value = System.DBNull.Value;
//                }
//                if ((F_Hoc3L.HasValue == true))
//                {
//                    if (F_Hoc3L == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[47].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[47].Value = ((double)(F_Hoc3L.Value));
//                    }
//                }
//                else
//                {
//                    param[47].Value = System.DBNull.Value;
//                }
//                if ((F_Hoc4L.HasValue == true))
//                {
//                    if (F_Hoc4L == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[48].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[48].Value = ((double)(F_Hoc4L.Value));
//                    }
//                }
//                else
//                {
//                    param[48].Value = System.DBNull.Value;
//                }
//                if ((F_Hoc5L.HasValue == true))
//                {
//                    if (F_Hoc5L == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[49].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[49].Value = ((double)(F_Hoc5L.Value));
//                    }
//                }
//                else
//                {
//                    param[49].Value = System.DBNull.Value;
//                }
//                if ((F_Hoc6L.HasValue == true))
//                {
//                    if (F_Hoc6L == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[50].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[50].Value = ((double)(F_Hoc6L.Value));
//                    }
//                }
//                else
//                {
//                    param[50].Value = System.DBNull.Value;
//                }
//                if ((F_Hoc7L.HasValue == true))
//                {
//                    if (F_Hoc7L == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[51].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[51].Value = ((double)(F_Hoc7L.Value));
//                    }
//                }
//                else
//                {
//                    param[51].Value = System.DBNull.Value;
//                }

//                if ((F_Con_OmL.HasValue == true))
//                {
//                    if (F_Con_OmL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[52].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[52].Value = ((double)(F_Con_OmL.Value));
//                    }
//                }
//                else
//                {
//                    param[52].Value = System.DBNull.Value;
//                }
//                if ((F_KHHDSL.HasValue == true))
//                {
//                    if (F_KHHDSL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[53].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[53].Value = ((double)(F_KHHDSL.Value));
//                    }
//                }
//                else
//                {
//                    param[53].Value = System.DBNull.Value;
//                }
//                if ((F_SayThaiL.HasValue == true))
//                {
//                    if (F_SayThaiL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[54].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[54].Value = ((double)(F_SayThaiL.Value));
//                    }
//                }
//                else
//                {
//                    param[54].Value = System.DBNull.Value;
//                }
//                if ((F_KhamThaiL.HasValue == true))
//                {
//                    if (F_KhamThaiL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[55].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[55].Value = ((double)(F_KhamThaiL.Value));
//                    }
//                }
//                else
//                {
//                    param[55].Value = System.DBNull.Value;
//                }
//                if ((F_ConChetL.HasValue == true))
//                {
//                    if (F_ConChetL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[56].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[56].Value = ((double)(F_ConChetL.Value));
//                    }
//                }
//                else
//                {
//                    param[56].Value = System.DBNull.Value;
//                }
//                if ((F_DinhChiCongTacL.HasValue == true))
//                {
//                    if (F_DinhChiCongTacL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[57].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[57].Value = ((double)(F_DinhChiCongTacL.Value));
//                    }
//                }
//                else
//                {
//                    param[57].Value = System.DBNull.Value;
//                }


//                if ((F_TamHoanHDL.HasValue == true))
//                {
//                    if (F_TamHoanHDL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[58].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[58].Value = ((double)(F_TamHoanHDL.Value));
//                    }
//                }
//                else
//                {
//                    param[58].Value = System.DBNull.Value;
//                }
//                if ((F_HoiHopL.HasValue == true))
//                {
//                    if (F_HoiHopL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[59].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[59].Value = ((double)(F_HoiHopL.Value));
//                    }
//                }
//                else
//                {
//                    param[59].Value = System.DBNull.Value;
//                }
//                if ((F_LeL.HasValue == true))
//                {
//                    if (F_LeL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[60].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[60].Value = ((double)(F_LeL.Value));
//                    }
//                }
//                else
//                {
//                    param[60].Value = System.DBNull.Value;
//                }
//                if ((NghiTuanL.HasValue == true))
//                {
//                    if (NghiTuanL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[61].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[61].Value = ((double)(NghiTuanL.Value));
//                    }
//                }
//                else
//                {
//                    param[61].Value = System.DBNull.Value;
//                }

//                if ((NghiBuL.HasValue == true))
//                {
//                    if (NghiBuL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[62].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[62].Value = ((double)(NghiBuL.Value));
//                    }
//                }
//                else
//                {
//                    param[62].Value = System.DBNull.Value;
//                }
//                if ((NghiViecL.HasValue == true))
//                {
//                    if (NghiViecL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[63].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[63].Value = ((double)(NghiViecL.Value));
//                    }
//                }
//                else
//                {
//                    param[63].Value = System.DBNull.Value;
//                }


//                if ((NightTimeL.HasValue == true))
//                {
//                    if (NightTimeL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[64].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[64].Value = ((double)(NightTimeL.Value));
//                    }
//                }
//                else
//                {
//                    param[64].Value = System.DBNull.Value;
//                }



//                #endregion

//                if ((MarkL.HasValue == true))
//                {
//                    if (MarkL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[65].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[65].Value = ((double)(MarkL.Value));
//                    }
//                }
//                else
//                {
//                    param[65].Value = System.DBNull.Value;
//                }

//                if ((RankL == null) || (RankL == ""))
//                {
//                    param[66].Value = System.DBNull.Value;
//                }
//                else
//                {
//                    param[66].Value = ((string)(RankL));
//                }

//                if ((LastUpdateL.HasValue == true))
//                {
//                    param[67].Value = ((System.DateTime)(LastUpdateL.Value));
//                }
//                else
//                {
//                    param[67].Value = System.DBNull.Value;
//                }
//                if ((UpdateUserL.HasValue == true))
//                {
//                    if (UpdateUserL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[68].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[68].Value = ((double)(UpdateUserL.Value));
//                    }
//                }
//                else
//                {
//                    param[68].Value = System.DBNull.Value;
//                }

//                param[69].Value = ((string)(Remark));

//                if ((ChuaDiLamL.HasValue == true))
//                {
//                    if (ChuaDiLamL == Constants.WorkdayEmployee_DefaultValue)
//                    {
//                        param[70].Value = System.DBNull.Value;
//                    }
//                    else
//                    {
//                        param[70].Value = ((double)(ChuaDiLamL.Value));
//                    }
//                }
//                else
//                {
//                    param[70].Value = System.DBNull.Value;
//                }

//                sproc = new StoreProcedure(WorkdayEmployeeLKeys.Sp_Upd_H1_WorkdayEmployeeL_By_UserId_Date, param);
//                identity = sproc.Run();
//                sproc.Commit();


//            }
//            catch (SqlException se)
//            {
//                sproc.RollBack();
//                throw new HRMException(se.Message, se.Number);
//            }
//            finally
//            {
//                sproc.Dispose();
//            }
            return identity;
        }


        public int Update_By_MarkHTCV(System.Nullable<int> UserId, System.Nullable<double> MarkL, System.Nullable<DateTime> LastUpdateL, System.Nullable<int> UpdateUserL, System.Nullable<int> MonthL, System.Nullable<int> YearL, string Remark)
        {
            int identity = 0;
            //Debug.Assert(sproc == null);
            //try
            //{
            //    SqlParameter[] param =    
            //    {                    					

            //        new SqlParameter("@UserId", SqlDbType.Int),
            //        new SqlParameter("@MarkL", SqlDbType.Float),
            //        new SqlParameter("@LastUpdateL", SqlDbType.DateTime),
            //        new SqlParameter("@UpdateUserL", SqlDbType.Int),
            //        new SqlParameter("@MonthL", SqlDbType.Int),
            //        new SqlParameter("@YearL", SqlDbType.Int),
            //        new SqlParameter("@Remark", SqlDbType.NVarChar, 1000)
            //    };
            //    if ((UserId.HasValue == true))
            //    {
            //        param[0].Value = ((int)(UserId.Value));
            //    }
            //    else
            //    {
            //        param[0].Value = System.DBNull.Value;
            //    }
            //    if ((MarkL.HasValue == true))
            //    {
            //        param[1].Value = ((double)(MarkL.Value));
            //    }
            //    else
            //    {
            //        param[1].Value = System.DBNull.Value;
            //    }
            //    if ((LastUpdateL.HasValue == true))
            //    {
            //        param[2].Value = ((System.DateTime)(LastUpdateL.Value));
            //    }
            //    else
            //    {
            //        param[2].Value = System.DBNull.Value;
            //    }
            //    if ((UpdateUserL.HasValue == true))
            //    {
            //        param[3].Value = ((int)(UpdateUserL.Value));
            //    }
            //    else
            //    {
            //        param[3].Value = System.DBNull.Value;
            //    }
            //    if ((MonthL.HasValue == true))
            //    {
            //        param[4].Value = ((int)(MonthL.Value));
            //    }
            //    else
            //    {
            //        param[4].Value = System.DBNull.Value;
            //    }
            //    if ((YearL.HasValue == true))
            //    {
            //        param[5].Value = ((int)(YearL.Value));
            //    }
            //    else
            //    {
            //        param[5].Value = System.DBNull.Value;
            //    }
            //    param[6].Value = Remark;


            //    sproc = new StoreProcedure(WorkdayEmployeeLKeys.Sp_Upd_H1_WorkdayEmployeeL_By_MarkHTCV, param);
            //    sproc.Run();
            //    sproc.Commit();

            //}
            //catch (SqlException se)
            //{
            //    sproc.RollBack();
            //    throw new HRMException(se.Message, se.Number);
            //}
            //finally
            //{
            //    sproc.Dispose();
            //}

            return identity;
        }


        public int DeleteByDeptIdsDate(string deptIds, int month, int year)
        {
            int identity = 0;
            //Debug.Assert(sproc == null);
            //try
            //{
            //    SqlParameter[] param = 
            //    {
            //        new SqlParameter("@DeptIds",SqlDbType.VarChar, 254),
            //        new SqlParameter("@Month",SqlDbType.Int),
            //        new SqlParameter("@Year",SqlDbType.Int)
            //    };

            //    param[0].Value = deptIds;
            //    param[1].Value = month;
            //    param[2].Value = year;

            //    sproc = new StoreProcedure(WorkdayEmployeeLKeys.Sp_Del_H1_WorkdayEmployeeL_By_DeptIds_Date, param);

            //    sproc.Run();
            //    sproc.Commit();

            //}
            //catch (SqlException se)
            //{
            //    sproc.RollBack();

            //    throw new HRMException(se.Message, se.Number);
            //}
            //finally
            //{
            //    sproc.Dispose();
            //}
            return identity;
        }


        #endregion

        #region Methods GET

        public DataTable GetByFilter(string fullName, string departmentIds, int month, int year, int TypeSort)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = { 
                    new SqlParameter("@FullName", SqlDbType.NVarChar, 100),
                    new SqlParameter("@DeptIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@TypeSort", SqlDbType.Int)
                };

                param[0].Value = fullName;
                param[1].Value = departmentIds;
                param[2].Value = month;
                param[3].Value = year;
                param[4].Value = TypeSort;

                sproc = new StoreProcedure(WorkdayEmployeeLKeys.Sp_Sel_H1_WorkdayEmployeeL_By_Filter, param);
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

        public DataTable GetById(long workdayEmployeeId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = { 
                    new SqlParameter("@WorkdayEmployeeId", SqlDbType.BigInt),
                };

                param[0].Value = workdayEmployeeId;

                sproc = new StoreProcedure(WorkdayEmployeeLKeys.Sp_Sel_H1_WorkdayEmployeeL_By_Id, param);
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

        public DataTable GetByUserId_Month_Year(int userId, int month, int year, int statusL)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = { 
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@StatusL", SqlDbType.Int)
                };

                param[0].Value = userId;
                param[1].Value = month;
                param[2].Value = year;
                param[3].Value = statusL;

                sproc = new StoreProcedure(WorkdayEmployeeLKeys.Sp_Sel_H1_WorkdayEmployeeL_By_UserId_Month_Year, param);
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

        public DataTable GetByRootId(int rootId, int month, int year)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = { 
                    new SqlParameter("@RootId", SqlDbType.Int),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int)
                };

                param[0].Value = rootId;
                param[1].Value = month;
                param[2].Value = year;

                sproc = new StoreProcedure(WorkdayEmployeeLKeys.Sp_Sel_H1_WorkdayEmployeeL_By_RootId, param);
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
