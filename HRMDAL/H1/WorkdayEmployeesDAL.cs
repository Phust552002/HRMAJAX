using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H1;

namespace HRMDAL.H1
{
    public class WorkdayEmployeesDAL : Dao
    {

        #region insert, update, delete
        public long InsertByDate_UserId(int UserId, System.Nullable<System.DateTime> WorkdayDate, string Day25, string Day26, string Day27, string Day28, string Day29, string Day30, string Day31,
                        System.Nullable<int> CreateUser, System.Nullable<int> Status, string writeUserIds, string readUserIds, System.Nullable<double> XQD, System.Nullable<int> Type, bool isOfficeHours)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@WorkdayDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@Day25", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day26", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day27", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day28", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day29", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day30", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day31", SqlDbType.VarChar, 20),
                    new SqlParameter("@CreateUser", SqlDbType.Int, 4),
                    new SqlParameter("@Status", SqlDbType.Int, 4),
                    new SqlParameter("@WriteUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@ReadUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@XQD", SqlDbType.Float),
                    new SqlParameter("@Type", SqlDbType.Float),
                    new SqlParameter("@isOfficeHours", SqlDbType.Bit)
                };

                param[0].Value = UserId;
                if ((WorkdayDate.HasValue == true))
                {
                    param[1].Value = ((System.DateTime)(WorkdayDate.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((Day25 == null) || (Day25 == ""))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = ((string)(Day25));
                }
                if ((Day26 == null) || (Day26 == ""))
                {
                    param[3].Value = System.DBNull.Value;
                }
                else
                {
                    param[3].Value = ((string)(Day26));
                }
                if ((Day27 == null) || (Day27 == ""))
                {
                    param[4].Value = System.DBNull.Value;
                }
                else
                {
                    param[4].Value = ((string)(Day27));
                }
                if ((Day28 == null) || (Day28 == ""))
                {
                    param[5].Value = System.DBNull.Value;
                }
                else
                {
                    param[5].Value = ((string)(Day28));
                }
                if ((Day29 == null) || (Day29 == ""))
                {
                    param[6].Value = System.DBNull.Value;
                }
                else
                {
                    param[6].Value = ((string)(Day29));
                }
                if ((Day30 == null) || (Day30 == ""))
                {
                    param[7].Value = System.DBNull.Value;
                }
                else
                {
                    param[7].Value = ((string)(Day30));
                }
                if ((Day31 == null) || (Day31 == ""))
                {
                    param[8].Value = System.DBNull.Value;
                }
                else
                {
                    param[8].Value = ((string)(Day31));
                }
                if ((CreateUser.HasValue == true))
                {
                    param[9].Value = ((int)(CreateUser.Value));
                }
                else
                {
                    param[9].Value = System.DBNull.Value;
                }
                if ((Status.HasValue == true))
                {
                    param[10].Value = ((int)(Status.Value));
                }
                else
                {
                    param[10].Value = System.DBNull.Value;
                }
                if ((writeUserIds == null) || (writeUserIds == ""))
                {
                    param[11].Value = System.DBNull.Value;
                }
                else
                {
                    param[11].Value = ((string)(writeUserIds));
                }
                if ((readUserIds == null) || (readUserIds == ""))
                {
                    param[12].Value = System.DBNull.Value;
                }
                else
                {
                    param[12].Value = ((string)(readUserIds));
                }
                if ((XQD.HasValue == true))
                {
                    if (XQD == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[13].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[13].Value = ((double)(XQD.Value));
                    }
                }
                else
                {
                    param[13].Value = System.DBNull.Value;
                }

                if ((Type.HasValue == true))
                {
                    if (Type == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[14].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[14].Value = ((double)(Type.Value));
                    }
                }
                else
                {
                    param[14].Value = System.DBNull.Value;
                }
                param[15].Value = isOfficeHours;

                sproc = new StoreProcedure("Ins_H1_WorkdayEmployees", param);
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
        public long InsertByDate_DeptIds(string Day25, string Day26, string Day27, string Day28, string Day29, string Day30, string Day31, string DepartmentIds, System.Nullable<System.DateTime> WorkdayDate, System.Nullable<int> CreateUser, System.Nullable<int> Status, string writeUserIds, string readUserIds, System.Nullable<double> XQD, System.Nullable<int> Type, bool isOfficeHours)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@Day25", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day26", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day27", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day28", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day29", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day30", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day31", SqlDbType.VarChar, 20),
                    new SqlParameter("@DeptIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@WorkdayDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@CreateUser", SqlDbType.Int, 4),
                    new SqlParameter("@Status", SqlDbType.Int, 4),
                    new SqlParameter("@WriteUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@ReadUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@XQD", SqlDbType.Float),
                    new SqlParameter("@Type", SqlDbType.Float),
                    new SqlParameter("@isOfficeHours", SqlDbType.Bit)
                };

                if ((Day25 == null) || (Day25 == ""))
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(Day25));
                }
                if ((Day26 == null) || (Day26 == ""))
                {
                    param[1].Value = System.DBNull.Value;
                }
                else
                {
                    param[1].Value = ((string)(Day26));
                }
                if ((Day27 == null) || (Day27 == ""))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = ((string)(Day27));
                }
                if ((Day28 == null) || (Day28 == ""))
                {
                    param[3].Value = System.DBNull.Value;
                }
                else
                {
                    param[3].Value = ((string)(Day28));
                }
                if ((Day29 == null) || (Day29 == ""))
                {
                    param[4].Value = System.DBNull.Value;
                }
                else
                {
                    param[4].Value = ((string)(Day29));
                }
                if ((Day30 == null) || (Day30 == ""))
                {
                    param[5].Value = System.DBNull.Value;
                }
                else
                {
                    param[5].Value = ((string)(Day30));
                }
                if ((Day31 == null) || (Day31 == ""))
                {
                    param[6].Value = System.DBNull.Value;
                }
                else
                {
                    param[6].Value = ((string)(Day31));
                }

                if ((DepartmentIds == null))
                {
                    param[7].Value = System.DBNull.Value;
                }
                else
                {
                    param[7].Value = ((string)(DepartmentIds));

                }
                if ((WorkdayDate.HasValue == true))
                {
                    param[8].Value = ((System.DateTime)(WorkdayDate.Value));
                }
                else
                {
                    param[8].Value = System.DBNull.Value;
                }
                if ((CreateUser.HasValue == true))
                {
                    param[9].Value = ((int)(CreateUser.Value));
                }
                else
                {
                    param[9].Value = System.DBNull.Value;
                }
                if ((Status.HasValue == true))
                {
                    param[10].Value = ((int)(Status.Value));
                }
                else
                {
                    param[10].Value = System.DBNull.Value;
                }
                if ((writeUserIds == null) || (writeUserIds == ""))
                {
                    param[11].Value = System.DBNull.Value;
                }
                else
                {
                    param[11].Value = ((string)(writeUserIds));
                }
                if ((readUserIds == null) || (readUserIds == ""))
                {
                    param[12].Value = System.DBNull.Value;
                }
                else
                {
                    param[12].Value = ((string)(readUserIds));
                }
                if ((XQD.HasValue == true))
                {
                    if (XQD == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[13].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[13].Value = ((double)(XQD.Value));
                    }
                }
                else
                {
                    param[13].Value = System.DBNull.Value;
                }

                if ((Type.HasValue == true))
                {
                    if (Type == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[14].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[14].Value = ((double)(Type.Value));
                    }
                }
                else
                {
                    param[14].Value = System.DBNull.Value;
                }
                param[15].Value = isOfficeHours;

                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Ins_H1_WorkdayEmployee_By_Date_DeptIds, param);
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

        public long InsertByDate_UserId(System.Nullable<int> UserId, System.Nullable<System.DateTime> WorkdayDate, string Day25, string Day26, string Day27, string Day28, string Day29, string Day30, string Day31, System.Nullable<int> CreateUser, System.Nullable<int> Status, string writeUserIds, string readUserIds, System.Nullable<double> XQD, System.Nullable<int> Type, bool isOfficeHours)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@WorkdayDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@Day25", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day26", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day27", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day28", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day29", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day30", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day31", SqlDbType.VarChar, 20),
                    new SqlParameter("@CreateUser", SqlDbType.Int, 4),
                    new SqlParameter("@Status", SqlDbType.Int, 4),
                    new SqlParameter("@WriteUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@ReadUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@XQD", SqlDbType.Float),
                    new SqlParameter("@Type", SqlDbType.Float),
                    new SqlParameter("@isOfficeHours", SqlDbType.Bit)
                };

                if ((UserId.HasValue == true))
                {
                    if (UserId == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[0].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[0].Value = ((double)(UserId.Value));
                    }
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }

                if ((WorkdayDate.HasValue == true))
                {
                    param[1].Value = ((System.DateTime)(WorkdayDate.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }

                if ((Day25 == null) || (Day25 == ""))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = ((string)(Day25));
                }
                if ((Day26 == null) || (Day26 == ""))
                {
                    param[3].Value = System.DBNull.Value;
                }
                else
                {
                    param[3].Value = ((string)(Day26));
                }
                if ((Day27 == null) || (Day27 == ""))
                {
                    param[4].Value = System.DBNull.Value;
                }
                else
                {
                    param[4].Value = ((string)(Day27));
                }
                if ((Day28 == null) || (Day28 == ""))
                {
                    param[5].Value = System.DBNull.Value;
                }
                else
                {
                    param[5].Value = ((string)(Day28));
                }
                if ((Day29 == null) || (Day29 == ""))
                {
                    param[6].Value = System.DBNull.Value;
                }
                else
                {
                    param[6].Value = ((string)(Day29));
                }
                if ((Day30 == null) || (Day30 == ""))
                {
                    param[7].Value = System.DBNull.Value;
                }
                else
                {
                    param[7].Value = ((string)(Day30));
                }
                if ((Day31 == null) || (Day31 == ""))
                {
                    param[8].Value = System.DBNull.Value;
                }
                else
                {
                    param[8].Value = ((string)(Day31));
                }

                if ((CreateUser.HasValue == true))
                {
                    param[9].Value = ((int)(CreateUser.Value));
                }
                else
                {
                    param[9].Value = System.DBNull.Value;
                }
                if ((Status.HasValue == true))
                {
                    param[10].Value = ((int)(Status.Value));
                }
                else
                {
                    param[10].Value = System.DBNull.Value;
                }
                if ((writeUserIds == null) || (writeUserIds == ""))
                {
                    param[11].Value = System.DBNull.Value;
                }
                else
                {
                    param[11].Value = ((string)(writeUserIds));
                }
                if ((readUserIds == null) || (readUserIds == ""))
                {
                    param[12].Value = System.DBNull.Value;
                }
                else
                {
                    param[12].Value = ((string)(readUserIds));
                }
                if ((XQD.HasValue == true))
                {
                    if (XQD == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[13].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[13].Value = ((double)(XQD.Value));
                    }
                }
                else
                {
                    param[13].Value = System.DBNull.Value;
                }

                if ((Type.HasValue == true))
                {
                    if (Type == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[14].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[14].Value = ((double)(Type.Value));
                    }
                }
                else
                {
                    param[14].Value = System.DBNull.Value;
                }
                param[15].Value = isOfficeHours;
                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Ins_H1_WorkdayEmployees, param);
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

        public long UpdateByDate_UserId(
                    System.Nullable<int> UserId,
                    System.Nullable<System.DateTime> WorkdayDate,
                    string Day1, string Day2, string Day3, string Day4, string Day5, string Day6, string Day7, string Day8, string Day9,
                    string Day10, string Day11, string Day12, string Day13, string Day14, string Day15, string Day16, string Day17, string Day18, string Day19,
                    string Day20, string Day21, string Day22, string Day23, string Day24, string Day25, string Day26, string Day27, string Day28, string Day29, string Day30, string Day31,
                    System.Nullable<double> NC_LamViec, System.Nullable<double> F_Om, System.Nullable<double> F_OmDaiNgay, System.Nullable<double> F_ThaiSan, System.Nullable<double> F_TNLD, System.Nullable<double> F_Nam,
                    System.Nullable<double> F_db, System.Nullable<double> F_KoLuongCLD, System.Nullable<double> F_KoLuongKLD, System.Nullable<double> F_DiDuong, System.Nullable<double> F_CongTac,
                    System.Nullable<double> F_HocSAGS, System.Nullable<double> F_Hoc1, System.Nullable<double> F_Hoc2, System.Nullable<double> F_Hoc3, System.Nullable<double> F_Hoc4, System.Nullable<double> F_Hoc5, System.Nullable<double> F_Hoc6, System.Nullable<double> F_Hoc7,
                    System.Nullable<double> F_Con_Om, System.Nullable<double> F_KHHDS, System.Nullable<double> F_SayThai, System.Nullable<double> F_KhamThai, System.Nullable<double> F_ConChet, System.Nullable<double> F_DinhChiCongTac,
                    System.Nullable<double> F_TamHoanHD, System.Nullable<double> F_HoiHop, System.Nullable<double> F_Le,
                    System.Nullable<double> NghiTuan, System.Nullable<double> NghiBu, System.Nullable<double> NghiViec, System.Nullable<double> NghiMat, System.Nullable<double> CongDu,
                    System.Nullable<double> GC_LamDem, System.Nullable<double> Mark,
                    string HTCV, System.Nullable<System.DateTime> LastUpdate, System.Nullable<int> UpdateUser, System.Nullable<int> Status,
                    System.Nullable<double> Night1, System.Nullable<double> Night2, System.Nullable<double> Night3, System.Nullable<double> Night4, System.Nullable<double> Night5, System.Nullable<double> Night6, System.Nullable<double> Night7, System.Nullable<double> Night8, System.Nullable<double> Night9, System.Nullable<double> Night10,
                    System.Nullable<double> Night11, System.Nullable<double> Night12, System.Nullable<double> Night13, System.Nullable<double> Night14, System.Nullable<double> Night15, System.Nullable<double> Night16, System.Nullable<double> Night17, System.Nullable<double> Night18, System.Nullable<double> Night19, System.Nullable<double> Night20,
                    System.Nullable<double> Night21, System.Nullable<double> Night22, System.Nullable<double> Night23, System.Nullable<double> Night24, System.Nullable<double> Night25, System.Nullable<double> Night26, System.Nullable<double> Night27, System.Nullable<double> Night28, System.Nullable<double> Night29, System.Nullable<double> Night30, System.Nullable<double> Night31,
                    string remark, System.Nullable<double> nc, System.Nullable<double> F_E0, System.Nullable<double> F_E1, System.Nullable<double> F_R1, System.Nullable<double> F_R2,
                    //20220713
                    System.Nullable<double> F_NK, System.Nullable<double> X_NT, System.Nullable<double> X_LE,
                    //20230525
                    System.Nullable<double> X_T,
                    //20230926
                    System.Nullable<double> F_BL,
                    System.Nullable<double> F_DS,
                    //20240105
                    System.Nullable<double> F_C,
                    //20240502
                    System.Nullable<double> F_BNN,
                    System.Nullable<double> F_O1
                    )
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {

                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@WorkdayDate", SqlDbType.DateTime, 8),
                    
                    #region day
                    new SqlParameter("@Day1", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day2", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day3", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day4", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day5", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day6", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day7", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day8", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day9", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day10", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day11", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day12", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day13", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day14", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day15", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day16", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day17", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day18", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day19", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day20", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day21", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day22", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day23", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day24", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day25", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day26", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day27", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day28", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day29", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day30", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day31", SqlDbType.VarChar, 20),

                    #endregion

                    
                    new SqlParameter("@NC_LamViec", SqlDbType.Float, 8),
                    new SqlParameter("@F_Om", SqlDbType.Float, 8),
                    new SqlParameter("@F_OmDaiNgay", SqlDbType.Float, 8),
                    new SqlParameter("@F_ThaiSan", SqlDbType.Float, 8),
                    new SqlParameter("@F_TNLD", SqlDbType.Float, 8),
                    new SqlParameter("@F_Nam", SqlDbType.Float, 8),
                    new SqlParameter("@F_db", SqlDbType.Float, 8),
                    new SqlParameter("@F_KoLuongCLD", SqlDbType.Float, 8),
                    new SqlParameter("@F_KoLuongKLD", SqlDbType.Float, 8),
                    new SqlParameter("@F_DiDuong", SqlDbType.Float, 8),
                    new SqlParameter("@F_CongTac", SqlDbType.Float, 8),
                    new SqlParameter("@F_HocSAGS", SqlDbType.Float, 8),
                    new SqlParameter("@F_Hoc1", SqlDbType.Float, 8),
                    new SqlParameter("@F_Hoc2", SqlDbType.Float, 8),
                    new SqlParameter("@F_Hoc3", SqlDbType.Float, 8),
                    new SqlParameter("@F_Hoc4", SqlDbType.Float, 8),
                    new SqlParameter("@F_Hoc5", SqlDbType.Float, 8),
                    new SqlParameter("@F_Hoc6", SqlDbType.Float, 8),
                    new SqlParameter("@F_Hoc7", SqlDbType.Float, 8),
                    new SqlParameter("@F_Con_Om", SqlDbType.Float, 8),
                    new SqlParameter("@F_KHHDS", SqlDbType.Float, 8),
                    new SqlParameter("@F_SayThai", SqlDbType.Float, 8),
                    new SqlParameter("@F_KhamThai", SqlDbType.Float, 8),
                    new SqlParameter("@F_ConChet", SqlDbType.Float, 8),
                    new SqlParameter("@F_DinhChiCongTac", SqlDbType.Float, 8),
                    new SqlParameter("@F_TamHoanHD", SqlDbType.Float, 8),
                    new SqlParameter("@F_HoiHop", SqlDbType.Float, 8),
                    new SqlParameter("@F_Le", SqlDbType.Float, 8),

                    new SqlParameter("@NghiTuan", SqlDbType.Float, 8),
                    new SqlParameter("@NghiBu", SqlDbType.Float, 8),
                    new SqlParameter("@NghiViec", SqlDbType.Float, 8),
                    new SqlParameter("@NghiMat", SqlDbType.Float, 8),
                    new SqlParameter("@CongDu", SqlDbType.Float, 8),
                    new SqlParameter("@GC_LamDem", SqlDbType.Float, 8),
                    new SqlParameter("@Mark", SqlDbType.Float, 8),
                    new SqlParameter("@HTCV", SqlDbType.VarChar, 50),

                    new SqlParameter("@LastUpdate", SqlDbType.DateTime, 8),
                    new SqlParameter("@UpdateUser", SqlDbType.Int, 4),
                    new SqlParameter("@Status", SqlDbType.Int, 4),

                    #region night

                    new SqlParameter("@Night1", SqlDbType.Float, 8),
                    new SqlParameter("@Night2", SqlDbType.Float, 8),
                    new SqlParameter("@Night3", SqlDbType.Float, 8),
                    new SqlParameter("@Night4", SqlDbType.Float, 8),
                    new SqlParameter("@Night5", SqlDbType.Float, 8),
                    new SqlParameter("@Night6", SqlDbType.Float, 8),
                    new SqlParameter("@Night7", SqlDbType.Float, 8),
                    new SqlParameter("@Night8", SqlDbType.Float, 8),
                    new SqlParameter("@Night9", SqlDbType.Float, 8),
                    new SqlParameter("@Night10", SqlDbType.Float, 8),
                    new SqlParameter("@Night11", SqlDbType.Float, 8),
                    new SqlParameter("@Night12", SqlDbType.Float, 8),
                    new SqlParameter("@Night13", SqlDbType.Float, 8),
                    new SqlParameter("@Night14", SqlDbType.Float, 8),
                    new SqlParameter("@Night15", SqlDbType.Float, 8),
                    new SqlParameter("@Night16", SqlDbType.Float, 8),
                    new SqlParameter("@Night17", SqlDbType.Float, 8),
                    new SqlParameter("@Night18", SqlDbType.Float, 8),
                    new SqlParameter("@Night19", SqlDbType.Float, 8),
                    new SqlParameter("@Night20", SqlDbType.Float, 8),
                    new SqlParameter("@Night21", SqlDbType.Float, 8),
                    new SqlParameter("@Night22", SqlDbType.Float, 8),
                    new SqlParameter("@Night23", SqlDbType.Float, 8),
                    new SqlParameter("@Night24", SqlDbType.Float, 8),
                    new SqlParameter("@Night25", SqlDbType.Float, 8),
                    new SqlParameter("@Night26", SqlDbType.Float, 8),
                    new SqlParameter("@Night27", SqlDbType.Float, 8),
                    new SqlParameter("@Night28", SqlDbType.Float, 8),
                    new SqlParameter("@Night29", SqlDbType.Float, 8),
                    new SqlParameter("@Night30", SqlDbType.Float, 8),
                    new SqlParameter("@Night31", SqlDbType.Float, 8),

                    #endregion

                    new SqlParameter("@Remark", SqlDbType.NVarChar, 1000),
                    new SqlParameter("@F_NC", SqlDbType.Float, 8),
                    //20200330
                    new SqlParameter("@F_E0", SqlDbType.Float, 8),
                    new SqlParameter("@F_E1", SqlDbType.Float, 8),
                    new SqlParameter("@F_R1", SqlDbType.Float, 8),
                    //20200908
                    new SqlParameter("@F_R2", SqlDbType.Float, 8),
                    //20220713
                    new SqlParameter("@F_NK", SqlDbType.Float, 8),
                    new SqlParameter("@X_NT", SqlDbType.Float, 8),
                    new SqlParameter("@X_LE", SqlDbType.Float, 8),
                    //20230525
                    new SqlParameter("@X_T", SqlDbType.Float, 8),
                    //20230926
                    new SqlParameter("@F_BL", SqlDbType.Float, 8),
                    new SqlParameter("@F_DS", SqlDbType.Float, 8),
                    //20240105
                    new SqlParameter("@F_C", SqlDbType.Float, 8),
                    //20240502
                    new SqlParameter("@F_BNN", SqlDbType.Float, 8),
                    new SqlParameter("@F_O1", SqlDbType.Float, 8)


                };

                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((WorkdayDate.HasValue == true))
                {
                    param[1].Value = ((System.DateTime)(WorkdayDate.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }

                #region Day

                if ((Day1 == null) || (Day1 == ""))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = ((string)(Day1));
                }
                if ((Day2 == null) || (Day2 == ""))
                {
                    param[3].Value = System.DBNull.Value;
                }
                else
                {
                    param[3].Value = ((string)(Day2));
                }
                if ((Day3 == null) || (Day3 == ""))
                {
                    param[4].Value = System.DBNull.Value;
                }
                else
                {
                    param[4].Value = ((string)(Day3));
                }
                if ((Day4 == null) || (Day4 == ""))
                {
                    param[5].Value = System.DBNull.Value;
                }
                else
                {
                    param[5].Value = ((string)(Day4));
                }
                if ((Day5 == null) || (Day5 == ""))
                {
                    param[6].Value = System.DBNull.Value;
                }
                else
                {
                    param[6].Value = ((string)(Day5));
                }
                if ((Day6 == null) || (Day6 == ""))
                {
                    param[7].Value = System.DBNull.Value;
                }
                else
                {
                    param[7].Value = ((string)(Day6));
                }
                if ((Day7 == null) || (Day7 == ""))
                {
                    param[8].Value = System.DBNull.Value;
                }
                else
                {
                    param[8].Value = ((string)(Day7));
                }
                if ((Day8 == null) || (Day8 == ""))
                {
                    param[9].Value = System.DBNull.Value;
                }
                else
                {
                    param[9].Value = ((string)(Day8));
                }
                if ((Day9 == null) || (Day9 == ""))
                {
                    param[10].Value = System.DBNull.Value;
                }
                else
                {
                    param[10].Value = ((string)(Day9));
                }
                if ((Day10 == null) || (Day10 == ""))
                {
                    param[11].Value = System.DBNull.Value;
                }
                else
                {
                    param[11].Value = ((string)(Day10));
                }
                if ((Day11 == null) || (Day11 == ""))
                {
                    param[12].Value = System.DBNull.Value;
                }
                else
                {
                    param[12].Value = ((string)(Day11));
                }
                if ((Day12 == null) || (Day12 == ""))
                {
                    param[13].Value = System.DBNull.Value;
                }
                else
                {
                    param[13].Value = ((string)(Day12));
                }
                if ((Day13 == null) || (Day13 == ""))
                {
                    param[14].Value = System.DBNull.Value;
                }
                else
                {
                    param[14].Value = ((string)(Day13));
                }
                if ((Day14 == null) || (Day14 == ""))
                {
                    param[15].Value = System.DBNull.Value;
                }
                else
                {
                    param[15].Value = ((string)(Day14));
                }
                if ((Day15 == null) || (Day15 == ""))
                {
                    param[16].Value = System.DBNull.Value;
                }
                else
                {
                    param[16].Value = ((string)(Day15));
                }
                if ((Day16 == null) || (Day16 == ""))
                {
                    param[17].Value = System.DBNull.Value;
                }
                else
                {
                    param[17].Value = ((string)(Day16));
                }
                if ((Day17 == null) || (Day17 == ""))
                {
                    param[18].Value = System.DBNull.Value;
                }
                else
                {
                    param[18].Value = ((string)(Day17));
                }
                if ((Day18 == null) || (Day18 == ""))
                {
                    param[19].Value = System.DBNull.Value;
                }
                else
                {
                    param[19].Value = ((string)(Day18));
                }
                if ((Day19 == null) || (Day19 == ""))
                {
                    param[20].Value = System.DBNull.Value;
                }
                else
                {
                    param[20].Value = ((string)(Day19));
                }
                if ((Day20 == null) || (Day20 == ""))
                {
                    param[21].Value = System.DBNull.Value;
                }
                else
                {
                    param[21].Value = ((string)(Day20));
                }
                if ((Day21 == null) || (Day21 == ""))
                {
                    param[22].Value = System.DBNull.Value;
                }
                else
                {
                    param[22].Value = ((string)(Day21));
                }
                if ((Day22 == null) || (Day22 == ""))
                {
                    param[23].Value = System.DBNull.Value;
                }
                else
                {
                    param[23].Value = ((string)(Day22));
                }
                if ((Day23 == null) || (Day23 == ""))
                {
                    param[24].Value = System.DBNull.Value;
                }
                else
                {
                    param[24].Value = ((string)(Day23));
                }
                if ((Day24 == null) || (Day24 == ""))
                {
                    param[25].Value = System.DBNull.Value;
                }
                else
                {
                    param[25].Value = ((string)(Day24));
                }
                if ((Day25 == null) || (Day25 == ""))
                {
                    param[26].Value = System.DBNull.Value;
                }
                else
                {
                    param[26].Value = ((string)(Day25));
                }
                if ((Day26 == null) || (Day26 == ""))
                {
                    param[27].Value = System.DBNull.Value;
                }
                else
                {
                    param[27].Value = ((string)(Day26));
                }
                if ((Day27 == null) || (Day27 == ""))
                {
                    param[28].Value = System.DBNull.Value;
                }
                else
                {
                    param[28].Value = ((string)(Day27));
                }
                if ((Day28 == null) || (Day28 == ""))
                {
                    param[29].Value = System.DBNull.Value;
                }
                else
                {
                    param[29].Value = ((string)(Day28));
                }
                if ((Day29 == null) || (Day29 == ""))
                {
                    param[30].Value = System.DBNull.Value;
                }
                else
                {
                    param[30].Value = ((string)(Day29));
                }
                if ((Day30 == null) || (Day30 == ""))
                {
                    param[31].Value = System.DBNull.Value;
                }
                else
                {
                    param[31].Value = ((string)(Day30));
                }
                if ((Day31 == null) || (Day31 == ""))
                {
                    param[32].Value = System.DBNull.Value;
                }
                else
                {
                    param[32].Value = ((string)(Day31));
                }

                #endregion

                #region Collect WorkdayEmplyee

                if ((NC_LamViec.HasValue == true))
                {
                    if (NC_LamViec == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[33].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[33].Value = ((double)(NC_LamViec.Value));
                    }
                }
                else
                {
                    param[33].Value = System.DBNull.Value;
                }
                if ((F_Om.HasValue == true))
                {
                    if (F_Om == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[34].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[34].Value = ((double)(F_Om.Value));
                    }
                }
                else
                {
                    param[34].Value = System.DBNull.Value;
                }
                if ((F_OmDaiNgay.HasValue == true))
                {
                    if (F_OmDaiNgay == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[35].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[35].Value = ((double)(F_OmDaiNgay.Value));
                    }
                }
                else
                {
                    param[35].Value = System.DBNull.Value;
                }
                if ((F_ThaiSan.HasValue == true))
                {
                    if (F_ThaiSan == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[36].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[36].Value = ((double)(F_ThaiSan.Value));
                    }
                }
                else
                {
                    param[36].Value = System.DBNull.Value;
                }
                if ((F_TNLD.HasValue == true))
                {
                    if (F_TNLD == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[37].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[37].Value = ((double)(F_TNLD.Value));
                    }
                }
                else
                {
                    param[37].Value = System.DBNull.Value;
                }
                if ((F_Nam.HasValue == true))
                {
                    if (F_Nam == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[38].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[38].Value = ((double)(F_Nam.Value));
                    }
                }
                else
                {
                    param[38].Value = System.DBNull.Value;
                }
                if ((F_db.HasValue == true))
                {
                    if (F_db == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[39].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[39].Value = ((double)(F_db.Value));
                    }
                }
                else
                {
                    param[39].Value = System.DBNull.Value;
                }
                if ((F_KoLuongCLD.HasValue == true))
                {
                    if (F_KoLuongCLD == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[40].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[40].Value = ((double)(F_KoLuongCLD.Value));
                    }
                }
                else
                {
                    param[40].Value = System.DBNull.Value;
                }
                if ((F_KoLuongKLD.HasValue == true))
                {
                    if (F_KoLuongKLD == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[41].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[41].Value = ((double)(F_KoLuongKLD.Value));
                    }
                }
                else
                {
                    param[41].Value = System.DBNull.Value;
                }
                if ((F_DiDuong.HasValue == true))
                {
                    if (F_DiDuong == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[42].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[42].Value = ((double)(F_DiDuong.Value));
                    }
                }
                else
                {
                    param[42].Value = System.DBNull.Value;
                }
                if ((F_CongTac.HasValue == true))
                {
                    if (F_CongTac == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[43].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[43].Value = ((double)(F_CongTac.Value));
                    }
                }
                else
                {
                    param[43].Value = System.DBNull.Value;
                }
                if ((F_HocSAGS.HasValue == true))
                {
                    if (F_HocSAGS == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[44].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[44].Value = ((double)(F_HocSAGS.Value));
                    }
                }
                else
                {
                    param[44].Value = System.DBNull.Value;
                }
                if ((F_Hoc1.HasValue == true))
                {
                    if (F_Hoc1 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[45].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[45].Value = ((double)(F_Hoc1.Value));
                    }
                }
                else
                {
                    param[45].Value = System.DBNull.Value;
                }
                if ((F_Hoc2.HasValue == true))
                {
                    if (F_Hoc2 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[46].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[46].Value = ((double)(F_Hoc2.Value));
                    }
                }
                else
                {
                    param[46].Value = System.DBNull.Value;
                }
                if ((F_Hoc3.HasValue == true))
                {
                    if (F_Hoc3 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[47].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[47].Value = ((double)(F_Hoc3.Value));
                    }
                }
                else
                {
                    param[47].Value = System.DBNull.Value;
                }
                if ((F_Hoc4.HasValue == true))
                {
                    if (F_Hoc4 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[48].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[48].Value = ((double)(F_Hoc4.Value));
                    }
                }
                else
                {
                    param[48].Value = System.DBNull.Value;
                }
                if ((F_Hoc5.HasValue == true))
                {
                    if (F_Hoc5 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[49].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[49].Value = ((double)(F_Hoc5.Value));
                    }
                }
                else
                {
                    param[49].Value = System.DBNull.Value;
                }
                if ((F_Hoc6.HasValue == true))
                {
                    if (F_Hoc6 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[50].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[50].Value = ((double)(F_Hoc6.Value));
                    }
                }
                else
                {
                    param[50].Value = System.DBNull.Value;
                }
                if ((F_Hoc7.HasValue == true))
                {
                    if (F_Hoc7 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[51].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[51].Value = ((double)(F_Hoc7.Value));
                    }
                }
                else
                {
                    param[51].Value = System.DBNull.Value;
                }
                if ((F_Con_Om.HasValue == true))
                {
                    if (F_Con_Om == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[52].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[52].Value = ((double)(F_Con_Om.Value));
                    }
                }
                else
                {
                    param[52].Value = System.DBNull.Value;
                }
                if ((F_KHHDS.HasValue == true))
                {
                    if (F_KHHDS == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[53].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[53].Value = ((double)(F_KHHDS.Value));
                    }
                }
                else
                {
                    param[53].Value = System.DBNull.Value;
                }
                if ((F_SayThai.HasValue == true))
                {
                    if (F_SayThai == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[54].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[54].Value = ((double)(F_SayThai.Value));
                    }
                }
                else
                {
                    param[54].Value = System.DBNull.Value;
                }
                if ((F_KhamThai.HasValue == true))
                {
                    if (F_KhamThai == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[55].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[55].Value = ((double)(F_KhamThai.Value));
                    }
                }
                else
                {
                    param[55].Value = System.DBNull.Value;
                }
                if ((F_ConChet.HasValue == true))
                {
                    if (F_ConChet == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[56].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[56].Value = ((double)(F_ConChet.Value));
                    }
                }
                else
                {
                    param[56].Value = System.DBNull.Value;
                }
                if ((F_DinhChiCongTac.HasValue == true))
                {
                    if (F_DinhChiCongTac == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[57].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[57].Value = ((double)(F_DinhChiCongTac.Value));
                    }
                }
                else
                {
                    param[57].Value = System.DBNull.Value;
                }
                if ((F_TamHoanHD.HasValue == true))
                {
                    if (F_TamHoanHD == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[58].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[58].Value = ((double)(F_TamHoanHD.Value));
                    }
                }
                else
                {
                    param[58].Value = System.DBNull.Value;
                }
                if ((F_HoiHop.HasValue == true))
                {
                    if (F_HoiHop == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[59].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[59].Value = ((double)(F_HoiHop.Value));
                    }
                }
                else
                {
                    param[59].Value = System.DBNull.Value;
                }
                if ((F_Le.HasValue == true))
                {
                    if (F_Le == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[60].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[60].Value = ((double)(F_Le.Value));
                    }
                }
                else
                {
                    param[60].Value = System.DBNull.Value;
                }
                if ((NghiTuan.HasValue == true))
                {
                    if (NghiTuan == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[61].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[61].Value = ((double)(NghiTuan.Value));
                    }
                }
                else
                {
                    param[61].Value = System.DBNull.Value;
                }
                if ((NghiBu.HasValue == true))
                {
                    if (NghiBu == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[62].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[62].Value = ((double)(NghiBu.Value));
                    }
                }
                else
                {
                    param[62].Value = System.DBNull.Value;
                }
                if ((NghiViec.HasValue == true))
                {
                    if (NghiViec == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[63].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[63].Value = ((double)(NghiViec.Value));
                    }
                }
                else
                {
                    param[63].Value = System.DBNull.Value;
                }
                if ((NghiMat.HasValue == true))
                {
                    if (NghiViec == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[64].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[64].Value = ((double)(NghiMat.Value));
                    }
                }
                else
                {
                    param[64].Value = System.DBNull.Value;
                }
                if ((CongDu.HasValue == true))
                {
                    param[65].Value = ((double)(CongDu.Value));
                }
                else
                {
                    param[65].Value = System.DBNull.Value;
                }

                if ((GC_LamDem.HasValue == true))
                {
                    if (GC_LamDem == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[66].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[66].Value = ((double)(GC_LamDem.Value));
                    }
                }
                else
                {
                    param[66].Value = System.DBNull.Value;
                }
                if ((Mark.HasValue == true))
                {
                    if (Mark == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[67].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[67].Value = ((double)(Mark.Value));
                    }
                }
                else
                {
                    param[67].Value = System.DBNull.Value;
                }
                if ((HTCV == null))
                {
                    param[68].Value = System.DBNull.Value;
                }
                else
                {
                    param[68].Value = ((string)(HTCV));
                }
                #endregion


                if ((LastUpdate.HasValue == true))
                {
                    param[69].Value = ((System.DateTime)(LastUpdate.Value));
                }
                else
                {
                    param[69].Value = System.DBNull.Value;
                }

                if ((UpdateUser.HasValue == true))
                {
                    param[70].Value = ((int)(UpdateUser.Value));
                }
                else
                {
                    param[70].Value = System.DBNull.Value;
                }
                if ((Status.HasValue == true))
                {
                    param[71].Value = ((int)(Status.Value));
                }
                else
                {
                    param[71].Value = System.DBNull.Value;
                }

                #region night

                if ((Night1.HasValue == true))
                {
                    if (Night1 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[72].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[72].Value = ((double)(Night1.Value));
                    }
                }
                else
                {
                    param[72].Value = System.DBNull.Value;
                }
                if ((Night2.HasValue == true))
                {
                    if (Night2 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[73].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[73].Value = ((double)(Night2.Value));
                    }
                }
                else
                {
                    param[73].Value = System.DBNull.Value;
                }
                if ((Night3.HasValue == true))
                {
                    if (Night3 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[74].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[74].Value = ((double)(Night3.Value));
                    }
                }
                else
                {
                    param[74].Value = System.DBNull.Value;
                }
                if ((Night4.HasValue == true))
                {
                    if (Night4 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[75].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[75].Value = ((double)(Night4.Value));
                    }
                }
                else
                {
                    param[75].Value = System.DBNull.Value;
                }
                if ((Night5.HasValue == true))
                {
                    if (Night5 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[76].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[76].Value = ((double)(Night5.Value));
                    }
                }
                else
                {
                    param[76].Value = System.DBNull.Value;
                }
                if ((Night6.HasValue == true))
                {
                    if (Night6 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[77].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[77].Value = ((double)(Night6.Value));
                    }
                }
                else
                {
                    param[77].Value = System.DBNull.Value;
                }
                if ((Night7.HasValue == true))
                {
                    if (Night7 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[78].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[78].Value = ((double)(Night7.Value));
                    }
                }
                else
                {
                    param[78].Value = System.DBNull.Value;
                }
                if ((Night8.HasValue == true))
                {
                    if (Night8 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[79].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[79].Value = ((double)(Night8.Value));
                    }
                }
                else
                {
                    param[79].Value = System.DBNull.Value;
                }
                if ((Night9.HasValue == true))
                {
                    if (Night9 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[80].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[80].Value = ((double)(Night9.Value));
                    }
                }
                else
                {
                    param[80].Value = System.DBNull.Value;
                }
                if ((Night10.HasValue == true))
                {
                    if (Night10 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[81].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[81].Value = ((double)(Night10.Value));
                    }
                }
                else
                {
                    param[81].Value = System.DBNull.Value;
                }
                if ((Night11.HasValue == true))
                {
                    if (Night11 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[82].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[82].Value = ((double)(Night11.Value));
                    }
                }
                else
                {
                    param[82].Value = System.DBNull.Value;
                }
                if ((Night12.HasValue == true))
                {
                    if (Night12 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[83].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[83].Value = ((double)(Night12.Value));
                    }
                }
                else
                {
                    param[83].Value = System.DBNull.Value;
                }
                if ((Night13.HasValue == true))
                {
                    if (Night13 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[84].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[84].Value = ((double)(Night13.Value));
                    }
                }
                else
                {
                    param[84].Value = System.DBNull.Value;
                }
                if ((Night14.HasValue == true))
                {
                    if (Night14 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[85].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[85].Value = ((double)(Night14.Value));
                    }
                }
                else
                {
                    param[85].Value = System.DBNull.Value;
                }
                if ((Night15.HasValue == true))
                {
                    if (Night15 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[86].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[86].Value = ((double)(Night15.Value));
                    }
                }
                else
                {
                    param[86].Value = System.DBNull.Value;
                }
                if ((Night16.HasValue == true))
                {
                    if (Night16 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[87].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[87].Value = ((double)(Night16.Value));
                    }
                }
                else
                {
                    param[87].Value = System.DBNull.Value;
                }
                if ((Night17.HasValue == true))
                {
                    if (Night17 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[88].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[88].Value = ((double)(Night17.Value));
                    }
                }
                else
                {
                    param[88].Value = System.DBNull.Value;
                }
                if ((Night18.HasValue == true))
                {
                    if (Night18 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[89].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[89].Value = ((double)(Night18.Value));
                    }
                }
                else
                {
                    param[89].Value = System.DBNull.Value;
                }
                if ((Night19.HasValue == true))
                {
                    if (Night19 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[90].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[90].Value = ((double)(Night19.Value));
                    }
                }
                else
                {
                    param[90].Value = System.DBNull.Value;
                }
                if ((Night20.HasValue == true))
                {
                    if (Night20 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[91].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[91].Value = ((double)(Night20.Value));
                    }
                }
                else
                {
                    param[91].Value = System.DBNull.Value;
                }
                if ((Night21.HasValue == true))
                {
                    if (Night21 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[92].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[92].Value = ((double)(Night21.Value));
                    }
                }
                else
                {
                    param[92].Value = System.DBNull.Value;
                }
                if ((Night22.HasValue == true))
                {
                    if (Night22 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[93].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[93].Value = ((double)(Night22.Value));
                    }
                }
                else
                {
                    param[93].Value = System.DBNull.Value;
                }
                if ((Night23.HasValue == true))
                {
                    if (Night23 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[94].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[94].Value = ((double)(Night23.Value));
                    }
                }
                else
                {
                    param[94].Value = System.DBNull.Value;
                }
                if ((Night24.HasValue == true))
                {
                    if (Night24 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[95].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[95].Value = ((double)(Night24.Value));
                    }
                }
                else
                {
                    param[95].Value = System.DBNull.Value;
                }
                if ((Night25.HasValue == true))
                {
                    if (Night25 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[96].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[96].Value = ((double)(Night25.Value));
                    }
                }
                else
                {
                    param[96].Value = System.DBNull.Value;
                }
                if ((Night26.HasValue == true))
                {
                    if (Night26 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[97].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[97].Value = ((double)(Night26.Value));
                    }
                }
                else
                {
                    param[97].Value = System.DBNull.Value;
                }
                if ((Night27.HasValue == true))
                {
                    if (Night27 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[98].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[98].Value = ((double)(Night27.Value));
                    }
                }
                else
                {
                    param[98].Value = System.DBNull.Value;
                }
                if ((Night28.HasValue == true))
                {
                    if (Night28 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[99].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[99].Value = ((double)(Night28.Value));
                    }
                }
                else
                {
                    param[99].Value = System.DBNull.Value;
                }
                if ((Night29.HasValue == true))
                {
                    if (Night29 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[100].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[100].Value = ((double)(Night29.Value));
                    }
                }
                else
                {
                    param[100].Value = System.DBNull.Value;
                }
                if ((Night30.HasValue == true))
                {
                    if (Night30 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[101].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[101].Value = ((double)(Night30.Value));
                    }
                }
                else
                {
                    param[101].Value = System.DBNull.Value;
                }
                if ((Night31.HasValue == true))
                {
                    if (Night31 == Constants.WorkdayEmployee_DefaultValue)
                    {
                        param[102].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[102].Value = ((double)(Night31.Value));
                    }
                }
                else
                {
                    param[102].Value = System.DBNull.Value;
                }

                #endregion

                if ((remark == null))
                {
                    param[103].Value = System.DBNull.Value;
                }
                else
                {
                    param[103].Value = ((string)(remark));
                }

                if ((nc == null))
                {
                    param[104].Value = System.DBNull.Value;
                }
                else
                {
                    param[104].Value = ((double)(nc));
                }

                //20200330
                if ((F_E0 == null))
                {
                    param[105].Value = System.DBNull.Value;
                }
                else
                {
                    param[105].Value = ((double)(F_E0));
                }
                if ((F_E1 == null))
                {
                    param[106].Value = System.DBNull.Value;
                }
                else
                {
                    param[106].Value = ((double)(F_E1));
                }
                if ((F_R1 == null))
                {
                    param[107].Value = System.DBNull.Value;
                }
                else
                {
                    param[107].Value = ((double)(F_R1));
                }
                //20200908
                if ((F_R2 == null))
                {
                    param[108].Value = System.DBNull.Value;
                }
                else
                {
                    param[108].Value = ((double)(F_R2));
                }
                //20220713
                if ((F_NK == null))
                {
                    param[109].Value = System.DBNull.Value;
                }
                else
                {
                    param[109].Value = ((double)(F_NK));
                }
                if ((X_NT == null))
                {
                    param[110].Value = System.DBNull.Value;
                }
                else
                {
                    param[110].Value = ((double)(X_NT));
                }
                if ((X_LE == null))
                {
                    param[111].Value = System.DBNull.Value;
                }
                else
                {
                    param[111].Value = ((double)(X_LE));
                }
                //20230525
                if ((X_T == null))
                {
                    param[112].Value = System.DBNull.Value;
                }
                else
                {
                    param[112].Value = ((double)(X_T));
                }
                //20230926
                if ((F_BL == null))
                {
                    param[113].Value = System.DBNull.Value;
                }
                else
                {
                    param[113].Value = ((double)(F_BL));
                }

                if ((F_DS == null))
                {
                    param[114].Value = System.DBNull.Value;
                }
                else
                {
                    param[114].Value = ((double)(F_DS));
                }
                //20230926
                if ((F_C == null))
                {
                    param[115].Value = System.DBNull.Value;
                }
                else
                {
                    param[115].Value = ((double)(F_C));
                }
                //20230926
                if ((F_BNN == null))
                {
                    param[116].Value = System.DBNull.Value;
                }
                else
                {
                    param[116].Value = ((double)(F_BNN));
                }
                if ((F_O1 == null))
                {
                    param[117].Value = System.DBNull.Value;
                }
                else
                {
                    param[117].Value = ((double)(F_O1));
                }

                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Upd_H1_WorkdayEmployee_By_UserId_Date, param);
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


        public int Update_By_Sends(string DeptIds, System.Nullable<int> Month, System.Nullable<int> Year, string ReadUserIds, string WriteUserIds, System.Nullable<int> Status)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {

                    new SqlParameter("@DeptIds", SqlDbType.VarChar, 254),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@ReadUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@WriteUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@Status", SqlDbType.Int)
                };
                if (DeptIds == null)
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(DeptIds));
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
                    param[2].Value = ((int)(Year.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if (ReadUserIds == null)
                {
                    param[3].Value = System.DBNull.Value;
                }
                else
                {
                    param[3].Value = ((string)(ReadUserIds));
                }
                if (WriteUserIds == null)
                {
                    param[4].Value = System.DBNull.Value;
                }
                else
                {
                    param[4].Value = ((string)(WriteUserIds));
                }
                if ((Status.HasValue == true))
                {
                    param[5].Value = ((int)(Status.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }


                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Upd_H1_WorkdayEmployee_By_Sends, param);
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

        public int Update_By_MarkHTCV(System.Nullable<int> UserId, System.Nullable<double> Mark, System.Nullable<DateTime> LastUpdate, System.Nullable<int> UpdateUser, System.Nullable<int> Month, System.Nullable<int> Year, string Remark)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {

                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@Mark", SqlDbType.Float),
                    new SqlParameter("@LastUpdate", SqlDbType.DateTime),
                    new SqlParameter("@UpdateUser", SqlDbType.Int),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@Remark", SqlDbType.NVarChar, 1000)
                };
                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((Mark.HasValue == true))
                {
                    param[1].Value = ((double)(Mark.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((LastUpdate.HasValue == true))
                {
                    param[2].Value = ((System.DateTime)(LastUpdate.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((UpdateUser.HasValue == true))
                {
                    param[3].Value = ((int)(UpdateUser.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((Month.HasValue == true))
                {
                    param[4].Value = ((int)(Month.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((Year.HasValue == true))
                {
                    param[5].Value = ((int)(Year.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                param[6].Value = Remark;


                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Upd_H1_WorkdayEmployee_By_MarkHTCV, param);
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

        public int Update_By_MarkHTCV_V2(System.Nullable<int> UserId, System.Nullable<double> Mark, System.Nullable<DateTime> LastUpdate, System.Nullable<int> UpdateUser, System.Nullable<int> Month, System.Nullable<int> Year)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {

                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@Mark", SqlDbType.Float),
                    new SqlParameter("@LastUpdate", SqlDbType.DateTime),
                    new SqlParameter("@UpdateUser", SqlDbType.Int),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int)
                };
                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((Mark.HasValue == true))
                {
                    param[1].Value = ((double)(Mark.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((LastUpdate.HasValue == true))
                {
                    param[2].Value = ((System.DateTime)(LastUpdate.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((UpdateUser.HasValue == true))
                {
                    param[3].Value = ((int)(UpdateUser.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((Month.HasValue == true))
                {
                    param[4].Value = ((int)(Month.Value));
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((Year.HasValue == true))
                {
                    param[5].Value = ((int)(Year.Value));
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure("Upd_H1_WorkdayEmployee_By_MarkHTCV_V2", param);
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

        public int Update_By_Send_UserId(string ReadUserIds, string WriteUserIds, System.Nullable<int> Month, System.Nullable<int> Year, System.Nullable<int> UserId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@ReadUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@WriteUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@UserId", SqlDbType.Int)
                };

                if (ReadUserIds == null)
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(ReadUserIds));
                }
                if (WriteUserIds == null)
                {
                    param[1].Value = System.DBNull.Value;
                }
                else
                {
                    param[1].Value = ((string)(WriteUserIds));
                }
                if ((Month.HasValue == true))
                {
                    param[2].Value = ((int)(Month.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((Year.HasValue == true))
                {
                    param[3].Value = ((int)(Year.Value));
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


                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Upd_H1_WorkdayEmployee_By_Send_UserId, param);
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

        public int Update_By_Send_Read(string ReadUserIds, System.Nullable<int> Month, System.Nullable<int> Year, System.Nullable<int> UserId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@ReadUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@UserId", SqlDbType.Int)
                };

                if (ReadUserIds == null)
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(ReadUserIds));
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
                    param[2].Value = ((int)(Year.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }

                if ((UserId.HasValue == true))
                {
                    param[3].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }


                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Upd_H1_WorkdayEmployee_By_SendRead, param);
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

        public int Update_By_Send_Write(string WriteUserIds, System.Nullable<int> Month, System.Nullable<int> Year, System.Nullable<int> UserId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@WriteUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@UserId", SqlDbType.Int)
                };

                if (WriteUserIds == null)
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(WriteUserIds));
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
                    param[2].Value = ((int)(Year.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }

                if ((UserId.HasValue == true))
                {
                    param[3].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }


                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Upd_H1_WorkdayEmployee_By_SendWrite, param);
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

        public int Update_By_Sends_Read(string ReadUserIds, System.Nullable<int> Month, System.Nullable<int> Year, string DeptIds)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@ReadUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@DeptIds", SqlDbType.VarChar, 254)
                };

                if (ReadUserIds == null)
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(ReadUserIds));
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
                    param[2].Value = ((int)(Year.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }

                param[3].Value = DeptIds;


                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Upd_H1_WorkdayEmployee_By_Sends_Read, param);
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

        public int Update_By_Sends_Write(string WriteUserIds, System.Nullable<int> Month, System.Nullable<int> Year, string DeptIds)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@WriteUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@DeptIds", SqlDbType.VarChar, 254)
                };

                if (WriteUserIds == null)
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(WriteUserIds));
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
                    param[2].Value = ((int)(Year.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }


                param[3].Value = DeptIds;



                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Upd_H1_WorkdayEmployee_By_Sends_Write, param);
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

        public int Update_By_Sharing_Read(string ReadUserIds, System.Nullable<int> Month, System.Nullable<int> Year, System.Nullable<int> UserId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@ReadUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@UserId", SqlDbType.Int)
                };

                if (ReadUserIds == null)
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(ReadUserIds));
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
                    param[2].Value = ((int)(Year.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }

                if ((UserId.HasValue == true))
                {
                    param[3].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }


                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Upd_H1_WorkdayEmployee_By_SharingRead, param);
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

        public int Update_By_Sharing_Write(string WriteUserIds, System.Nullable<int> Month, System.Nullable<int> Year, System.Nullable<int> UserId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@WriteUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@UserId", SqlDbType.Int)
                };

                if (WriteUserIds == null)
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(WriteUserIds));
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
                    param[2].Value = ((int)(Year.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }

                if ((UserId.HasValue == true))
                {
                    param[3].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }


                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Upd_H1_WorkdayEmployee_By_SharingWrite, param);
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

        public int Update_By_Sharings_Read(string ReadUserIds, System.Nullable<int> Month, System.Nullable<int> Year, string DeptIds)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@ReadUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@DeptIds", SqlDbType.VarChar, 254)
                };

                if (ReadUserIds == null)
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(ReadUserIds));
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
                    param[2].Value = ((int)(Year.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }

                param[3].Value = DeptIds;


                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Upd_H1_WorkdayEmployee_By_Sharings_Read, param);
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

        public int Update_By_Sharings_Write(string WriteUserIds, System.Nullable<int> Month, System.Nullable<int> Year, string DeptIds)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@WriteUserIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@DeptIds", SqlDbType.VarChar, 254)
                };

                if (WriteUserIds == null)
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)(WriteUserIds));
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
                    param[2].Value = ((int)(Year.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }


                param[3].Value = DeptIds;



                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Upd_H1_WorkdayEmployee_By_Sharings_Write, param);
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

        public int Update_ForCongDu(System.Nullable<int> UserId, System.Nullable<double> CongDu, System.Nullable<int> Month, System.Nullable<int> Year)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {

                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@CongDu", SqlDbType.Float),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int)
                };
                if ((UserId.HasValue == true))
                {
                    param[0].Value = ((int)(UserId.Value));
                }
                else
                {
                    param[0].Value = System.DBNull.Value;
                }
                if ((CongDu.HasValue == true))
                {
                    param[1].Value = ((double)(CongDu.Value));
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((Month.HasValue == true))
                {
                    param[2].Value = ((int)(Month.Value));
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((Year.HasValue == true))
                {
                    param[3].Value = ((int)(Year.Value));
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }

                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Upd_H1_WorkdayEmployee_For_CongDu, param);
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

        public long UpdateForOverTime(int UserId, int Month, int Year, double LamthemNTbngay, double LamthemCNbngay, double LamthemLTbngay, double LamthemNTbdem, double LamthemCNbdem, double LamthemLTbdem)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@LamthemNTbngay", SqlDbType.Float),
                    new SqlParameter("@LamthemCNbngay", SqlDbType.Float),
                    new SqlParameter("@LamthemLTbngay", SqlDbType.Float),
                    new SqlParameter("@LamthemNTbdem", SqlDbType.Float),
                    new SqlParameter("@LamthemCNbdem", SqlDbType.Float),
                    new SqlParameter("@LamthemLTbdem", SqlDbType.Float)
                };

                param[0].Value = UserId;
                param[1].Value = Month;
                param[2].Value = Year;
                param[3].Value = LamthemNTbngay;
                param[4].Value = LamthemCNbngay;
                param[5].Value = LamthemLTbngay;
                param[6].Value = LamthemNTbdem;
                param[7].Value = LamthemCNbdem;
                param[8].Value = LamthemLTbdem;


                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Upd_H1_WorkdayEmployee_For_OverTime, param);
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

        public int DeleteByDeptIdsDate(string deptIds, int month, int year)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DeptIds",SqlDbType.VarChar, 254),
                    new SqlParameter("@Month",SqlDbType.Int),
                    new SqlParameter("@Year",SqlDbType.Int)
                };

                param[0].Value = deptIds;
                param[1].Value = month;
                param[2].Value = year;

                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Del_H1_WorkdayEmployee_By_DeptIds_Date, param);

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

        public int Delete(long WorkdayEmployeeId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@WorkdayEmployeeId",SqlDbType.BigInt)
                };

                param[0].Value = WorkdayEmployeeId;

                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Del_H1_WorkdayEmployee, param);

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
        public DataTable GetAllByUserId(string fullName, string departmentIds, int month, int year, int status, int receivedUserId, int TypeSort, int userid)
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
                    new SqlParameter("@Status", SqlDbType.Int),
                    new SqlParameter("@ReceivedUserId", SqlDbType.Int),
                    new SqlParameter("@TypeSort", SqlDbType.Int),
                    new SqlParameter("@UserId", SqlDbType.Int),
                };

                param[0].Value = fullName;
                param[1].Value = departmentIds;
                param[2].Value = month;
                param[3].Value = year;
                param[4].Value = status;
                param[5].Value = receivedUserId;
                param[6].Value = TypeSort;
                param[7].Value = userid;

                sproc = new StoreProcedure("Sel_H1_WorkdayEmployee_By_FilterV1", param);
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
        public DataTable GetAllByFilter(string fullName, string departmentIds, int month, int year, int status, int receivedUserId, int TypeSort)
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
                    new SqlParameter("@Status", SqlDbType.Int),
                    new SqlParameter("@ReceivedUserId", SqlDbType.Int),
                    new SqlParameter("@TypeSort", SqlDbType.Int)

                };

                param[0].Value = fullName;
                param[1].Value = departmentIds;
                param[2].Value = month;
                param[3].Value = year;
                param[4].Value = status;
                param[5].Value = receivedUserId;
                param[6].Value = TypeSort;

                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Sel_H1_WorkdayEmployee_By_Filter, param);
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

                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Sel_H1_WorkdayEmployee_By_Id, param);
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

        public DataTable GetByUserId_Month_Year(int userId, int month, int year, int status)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = {
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@Status", SqlDbType.Int)
                };

                param[0].Value = userId;
                param[1].Value = month;
                param[2].Value = year;
                param[3].Value = status;

                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Sel_H1_WorkdayEmployee_By_UserId_Month_Year, param);
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

        public DataTable GetByUserId_Month_Year1(int userId, int month, int year)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = {
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int)
                };

                param[0].Value = userId;
                param[1].Value = month;
                param[2].Value = year;

                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Sel_H1_WorkdayEmployee_By_UserId_Month_Year1, param);
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

        public DataTable GetByStatistic1(string deptIds, int month, int year, int debit, string hTCV, int workdayType)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = {
                    new SqlParameter("@DeptIds", SqlDbType.VarChar, 254),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),
                    new SqlParameter("@Debit", SqlDbType.Int),
                    new SqlParameter("@HTCV", SqlDbType.VarChar, 10),
                    new SqlParameter("@WorkdayType", SqlDbType.Int)
                };

                param[0].Value = deptIds;
                param[1].Value = month;
                param[2].Value = year;
                param[3].Value = debit;
                if (hTCV.Trim().Length == 0)
                {
                    param[4].Value = DBNull.Value;
                }
                else
                {
                    param[4].Value = hTCV;
                }
                param[5].Value = workdayType;

                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Sel_H1_WorkdayEmployee_By_Statistic1, param);
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

        public DataTable GetByStatisticLeave(string fullName, string deptIds, string leaveCode, int month, int year)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = {

                    new SqlParameter("@FullName", SqlDbType.NVarChar, 254),
                    new SqlParameter("@DeptIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@LeaveCode", SqlDbType.VarChar, 50),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),

                };

                param[0].Value = fullName;
                param[1].Value = deptIds;
                if (leaveCode.Trim().Length == 0)
                {
                    param[2].Value = DBNull.Value;
                }
                else
                {
                    param[2].Value = leaveCode;
                }
                param[3].Value = month;
                param[4].Value = year;


                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Sel_H1_WorkdayEmployee_By_StatisticLeave, param);
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

        public DataTable GetAllByFilterHTCV(string fullName, string departmentIds, int minMark, int maxMark, int month, int year)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = {
                    new SqlParameter("@FullName", SqlDbType.NVarChar, 100),
                    new SqlParameter("@DeptIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@MinMark", SqlDbType.Float),
                    new SqlParameter("@MaxMark", SqlDbType.Float),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int),

                };

                param[0].Value = fullName;
                param[1].Value = departmentIds;
                param[2].Value = minMark;
                param[3].Value = maxMark;
                param[4].Value = month;
                param[5].Value = year;


                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Sel_H1_WorkdayEmployee_By_FilterHTCV, param);
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

                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Sel_H1_WorkdayEmployee_By_RootId, param);
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

        public DataTable CheckSend(int ReceivedUserId, int RootId, int Month, int Year)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = {
                    new SqlParameter("@ReceivedUserId", SqlDbType.Int),
                    new SqlParameter("@RootId", SqlDbType.Int),
                    new SqlParameter("@Month", SqlDbType.Int),
                    new SqlParameter("@Year", SqlDbType.Int)
                };

                param[0].Value = ReceivedUserId;
                param[1].Value = RootId;
                param[2].Value = Month;
                param[3].Value = Year;

                sproc = new StoreProcedure(WorkdayEmployeeKeys.Sp_Sel_H1_WorkdayEmployee_For_CheckSendToHRMAdmin, param);
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
