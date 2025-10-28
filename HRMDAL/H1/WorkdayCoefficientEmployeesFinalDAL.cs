using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H1;

namespace HRMDAL.H1
{
    public class WorkdayCoefficientEmployeesFinalDAL : Dao
    {

        #region insert, update, delete
        public long InsertByDate_UserId(int UserId, DateTime DataDate,
                                string Day25, string Day26, string Day27, string Day28, string Day29, string Day30, string Day31,
                                double XQD, double X, DateTime CreateDate, int CreateUser, string Remark)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@DataDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@Day25", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day26", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day27", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day28", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day29", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day30", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day31", SqlDbType.VarChar, 20),
                    new SqlParameter("@NCQD", SqlDbType.Float),
                    new SqlParameter("@NCDC", SqlDbType.Float),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@CreateUserId", SqlDbType.Int, 4),
                    new SqlParameter("@Remark", SqlDbType.NVarChar, 1000)
                };

                param[0].Value = UserId;
                param[1].Value = DataDate;
                if ((Day25 == null) || (Day25 == ""))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = ((string)Day25);
                }
                if ((Day26 == null) || (Day26 == ""))
                {
                    param[3].Value = System.DBNull.Value;
                }
                else
                {
                    param[3].Value = Day26;
                }
                if ((Day27 == null) || (Day27 == ""))
                {
                    param[4].Value = System.DBNull.Value;
                }
                else
                {
                    param[4].Value = Day27;
                }
                if ((Day28 == null) || (Day28 == ""))
                {
                    param[5].Value = System.DBNull.Value;
                }
                else
                {
                    param[5].Value = Day28;
                }
                if ((Day29 == null) || (Day29 == ""))
                {
                    param[6].Value = System.DBNull.Value;
                }
                else
                {
                    param[6].Value = Day29;
                }
                if ((Day30 == null) || (Day30 == ""))
                {
                    param[7].Value = System.DBNull.Value;
                }
                else
                {
                    param[7].Value = Day30;
                }
                if ((Day31 == null) || (Day31 == ""))
                {
                    param[8].Value = System.DBNull.Value;
                }
                else
                {
                    param[8].Value = Day31;
                }
                param[9].Value = XQD;
                param[10].Value = X;
                param[11].Value = DateTime.Now;
                param[12].Value = CreateUser;
                param[13].Value = Remark;

                sproc = new StoreProcedure("Ins_H1_WorkdayCoefficientEmployeesFinal_By_UserId_Date_For_Workday", param);
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
        public long InsertByDate_DeptId(string Day25, string Day26, string Day27, string Day28, string Day29, string Day30, string Day31, string DeptIds, DateTime DataDate, int CreateUser, double XQD, double X, string Remark)
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
                    new SqlParameter("@DataDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@CreateUser", SqlDbType.Int, 4),
                    new SqlParameter("@XQD", SqlDbType.Float),
                    new SqlParameter("@X", SqlDbType.Float),
                    new SqlParameter("@Remark", SqlDbType.NVarChar, 1000)
                };

                if ((Day25 == null) || (Day25 == ""))
                {
                    param[0].Value = System.DBNull.Value;
                }
                else
                {
                    param[0].Value = ((string)Day25);
                }
                if ((Day26 == null) || (Day26 == ""))
                {
                    param[1].Value = System.DBNull.Value;
                }
                else
                {
                    param[1].Value = Day26;
                }
                if ((Day27 == null) || (Day27 == ""))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = Day27;
                }
                if ((Day28 == null) || (Day28 == ""))
                {
                    param[3].Value = System.DBNull.Value;
                }
                else
                {
                    param[3].Value = Day28;
                }
                if ((Day29 == null) || (Day29 == ""))
                {
                    param[4].Value = System.DBNull.Value;
                }
                else
                {
                    param[4].Value = Day29;
                }
                if ((Day30 == null) || (Day30 == ""))
                {
                    param[5].Value = System.DBNull.Value;
                }
                else
                {
                    param[5].Value = Day30;
                }
                if ((Day31 == null) || (Day31 == ""))
                {
                    param[6].Value = System.DBNull.Value;
                }
                else
                {
                    param[6].Value = Day31;
                }

                param[7].Value = DeptIds;
                param[8].Value = DataDate;
                param[9].Value = CreateUser;
                param[10].Value = XQD;
                param[11].Value = X;
                param[12].Value = Remark;

                sproc = new StoreProcedure(WorkdayCoefficientEmployeesFinalKeys.Sp_Ins_H1_WorkdayCoefficientEmployeesFinal_By_Date_DeptIds, param);
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


        public long Insert(int UserId, DateTime DataDate,
                           string Day25, string Day26, string Day27, string Day28, string Day29, string Day30, string Day31,
                           double NCQD, double NCDC, DateTime CreateDate, int CreateUserId, string Remark)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@DataDate", SqlDbType.DateTime, 8),

                    new SqlParameter("@Day25", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day26", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day27", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day28", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day29", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day30", SqlDbType.VarChar, 20),
                    new SqlParameter("@Day31", SqlDbType.VarChar, 20),

                    new SqlParameter("@NCQD", SqlDbType.Float),
                    new SqlParameter("@NCDC", SqlDbType.Float),

                    new SqlParameter("@CreateDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@CreateUserId", SqlDbType.Int),
                    new SqlParameter("@Remark", SqlDbType.NVarChar,1000),
                };



                param[0].Value = UserId;
                param[1].Value = DataDate;

                if ((Day25 == null) || (Day25 == ""))
                {
                    param[2].Value = System.DBNull.Value;
                }
                else
                {
                    param[2].Value = ((string)Day25);
                }
                if ((Day26 == null) || (Day26 == ""))
                {
                    param[3].Value = System.DBNull.Value;
                }
                else
                {
                    param[3].Value = Day26;
                }
                if ((Day27 == null) || (Day27 == ""))
                {
                    param[4].Value = System.DBNull.Value;
                }
                else
                {
                    param[4].Value = Day27;
                }
                if ((Day28 == null) || (Day28 == ""))
                {
                    param[5].Value = System.DBNull.Value;
                }
                else
                {
                    param[5].Value = Day28;
                }
                if ((Day29 == null) || (Day29 == ""))
                {
                    param[6].Value = System.DBNull.Value;
                }
                else
                {
                    param[6].Value = Day29;
                }
                if ((Day30 == null) || (Day30 == ""))
                {
                    param[7].Value = System.DBNull.Value;
                }
                else
                {
                    param[7].Value = Day30;
                }
                if ((Day31 == null) || (Day31 == ""))
                {
                    param[8].Value = System.DBNull.Value;
                }
                else
                {
                    param[8].Value = Day31;
                }


                param[9].Value = NCQD;
                param[10].Value = NCDC;

                param[11].Value = CreateDate;
                param[12].Value = CreateUserId;
                param[13].Value = Remark;

                sproc = new StoreProcedure(WorkdayCoefficientEmployeesFinalKeys.Sp_Ins_H1_WorkdayCoefficientEmployeesFinal_By_UserId_Date_For_Workday, param);
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


        public long UpdateByUserId_DateForWorkday(int UserId, DateTime DataDate,
                            string Day1, string Day2, string Day3, string Day4, string Day5, string Day6, string Day7, string Day8, string Day9, string Day10,
                            string Day11, string Day12, string Day13, string Day14, string Day15, string Day16, string Day17, string Day18, string Day19, string Day20,
                            string Day21, string Day22, string Day23, string Day24, string Day25, string Day26, string Day27, string Day28, string Day29, string Day30, string Day31,
                            double NCQD, double NCDC, double X, double OmDNBHXH, double Om, double OmDN, double KHH, double Co, double TS, double ST, double Khamthai, double TNLD, double F, double Diduong, double CTac, double Fdb,
                            double H1, double H2, double H3, double H4, double h5, double H6, double H7, double DinhChiCT, double Ro, double Ko, double nghiTuan, double nghiBu, double chuaDiLam, double nghiViec, double nghiMat,
                            double LamthemNTbngay, double LamthemCNbngay, double LamthemLTbngay, double LamthemNTbdem, double LamthemCNbdem, double LamthemLTbdem, double Lamdem,
                            double HSK, DateTime UpdateDate, int UpdateUserId, string Remark, double nc, double E0, double E1, double R1, double R2, double Le,
                            //20220713
                            double NK, double XNT, double XLE,
                            //20230525
                            double T,
                            //20230926
                            double BL,
                            double DS,
                            //20240105
                            double FC,
                            double Ho,
                            //20240502
                            double BNN,
                            double CC,
                            double O1)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@DataDate", SqlDbType.DateTime, 8),

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

                    new SqlParameter("@NCQD", SqlDbType.Float),
                    new SqlParameter("@NCDC", SqlDbType.Float),
                    new SqlParameter("@X", SqlDbType.Float),
                    new SqlParameter("@OmDNBHXH", SqlDbType.Float),
                    new SqlParameter("@Om", SqlDbType.Float),
                    new SqlParameter("@OmDN", SqlDbType.Float),
                    new SqlParameter("@KHH", SqlDbType.Float),
                    new SqlParameter("@Co", SqlDbType.Float),
                    new SqlParameter("@TS", SqlDbType.Float),
                    new SqlParameter("@ST", SqlDbType.Float),
                    new SqlParameter("@Khamthai", SqlDbType.Float),
                    new SqlParameter("@TNLD", SqlDbType.Float),
                    new SqlParameter("@F", SqlDbType.Float),
                    new SqlParameter("@Diduong", SqlDbType.Float),
                    new SqlParameter("@CTac", SqlDbType.Float),
                    new SqlParameter("@Fdb", SqlDbType.Float),

                    new SqlParameter("@H1", SqlDbType.Float),
                    new SqlParameter("@H2", SqlDbType.Float),
                    new SqlParameter("@H3", SqlDbType.Float),
                    new SqlParameter("@H4", SqlDbType.Float),
                    new SqlParameter("@h5", SqlDbType.Float),
                    new SqlParameter("@H6", SqlDbType.Float),
                    new SqlParameter("@H7", SqlDbType.Float),
                    new SqlParameter("@DinhChiCT", SqlDbType.Float),
                    new SqlParameter("@Ro", SqlDbType.Float),
                    new SqlParameter("@Ko", SqlDbType.Float),


                    new SqlParameter("@nghiTuan", SqlDbType.Float),
                    new SqlParameter("@nghiBu", SqlDbType.Float),
                    new SqlParameter("@chuaDiLam", SqlDbType.Float),
                    new SqlParameter("@nghiViec", SqlDbType.Float),
                    new SqlParameter("@nghiMat", SqlDbType.Float),

                    new SqlParameter("@LamthemNTbngay", SqlDbType.Float),
                    new SqlParameter("@LamthemCNbngay", SqlDbType.Float),
                    new SqlParameter("@LamthemLTbngay", SqlDbType.Float),
                    new SqlParameter("@LamthemNTbdem", SqlDbType.Float),
                    new SqlParameter("@LamthemCNbdem", SqlDbType.Float),
                    new SqlParameter("@LamthemLTbdem", SqlDbType.Float),
                    new SqlParameter("@Lamdem", SqlDbType.Float),

                    new SqlParameter("@HSK", SqlDbType.Float),
                    new SqlParameter("@UpdateDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@UpdateUserId", SqlDbType.Int),
                    new SqlParameter("@Remark", SqlDbType.NVarChar,1000),
                    new SqlParameter("@NC", SqlDbType.Float),
                    //20200330
                    new SqlParameter("@E0", SqlDbType.Float),
                    new SqlParameter("@E1", SqlDbType.Float),
                    new SqlParameter("@R1", SqlDbType.Float),
                    //20200908
                    new SqlParameter("@R2", SqlDbType.Float),
                    //20201013
                    new SqlParameter("@Le", SqlDbType.Float),
                    //20220713
                    new SqlParameter("@NK", SqlDbType.Float),
                    new SqlParameter("@XNT", SqlDbType.Float),
                    new SqlParameter("@XLE", SqlDbType.Float),
                    //20230525
                    new SqlParameter("@T", SqlDbType.Float),
                    //20230926
                    new SqlParameter("@BL", SqlDbType.Float),
                    new SqlParameter("@DS", SqlDbType.Float),
                    //20240105
                    new SqlParameter("@FC", SqlDbType.Float),
                    new SqlParameter("@Ho", SqlDbType.Float),
                    //20240502
                    new SqlParameter("@BNN", SqlDbType.Float),
                    new SqlParameter("@CC", SqlDbType.Float),
                    new SqlParameter("@O1", SqlDbType.Float)
                };



                param[0].Value = UserId;
                param[1].Value = DataDate;

                param[2].Value = Day1;
                param[3].Value = Day2;
                param[4].Value = Day3;
                param[5].Value = Day4;
                param[6].Value = Day5;
                param[7].Value = Day6;
                param[8].Value = Day7;
                param[9].Value = Day8;
                param[10].Value = Day9;
                param[11].Value = Day10;
                param[12].Value = Day11;
                param[13].Value = Day12;
                param[14].Value = Day13;
                param[15].Value = Day14;
                param[16].Value = Day15;
                param[17].Value = Day16;
                param[18].Value = Day17;
                param[19].Value = Day18;
                param[20].Value = Day19;
                param[21].Value = Day20;
                param[22].Value = Day21;
                param[23].Value = Day22;
                param[24].Value = Day23;
                param[25].Value = Day24;
                param[26].Value = Day25;
                param[27].Value = Day26;
                param[28].Value = Day27;
                param[29].Value = Day28;
                param[30].Value = Day29;
                param[31].Value = Day30;
                param[32].Value = Day31;

                param[33].Value = NCQD;
                param[34].Value = NCDC;
                param[35].Value = X;
                param[36].Value = OmDNBHXH;
                param[37].Value = Om;
                param[38].Value = OmDN;
                param[39].Value = KHH;
                param[40].Value = Co;
                param[41].Value = TS;
                param[42].Value = ST;
                param[43].Value = Khamthai;
                param[44].Value = TNLD;
                param[45].Value = F;



                param[46].Value = Diduong;
                param[47].Value = CTac;
                param[48].Value = Fdb;

                param[49].Value = H1;
                param[50].Value = H2;
                param[51].Value = H3;
                param[52].Value = H4;
                param[53].Value = h5;
                param[54].Value = H6;
                param[55].Value = H7;
                param[56].Value = DinhChiCT;
                param[57].Value = Ro;
                param[58].Value = Ko;


                param[59].Value = nghiTuan;
                param[60].Value = nghiBu;
                param[61].Value = chuaDiLam;
                param[62].Value = nghiViec;
                param[63].Value = nghiMat;


                param[64].Value = LamthemNTbngay;
                param[65].Value = LamthemCNbngay;
                param[66].Value = LamthemLTbngay;
                param[67].Value = LamthemNTbdem;
                param[68].Value = LamthemCNbdem;
                param[69].Value = LamthemLTbdem;
                param[70].Value = Lamdem;

                param[71].Value = HSK;
                param[72].Value = UpdateDate;
                param[73].Value = UpdateUserId;
                param[74].Value = Remark;
                param[75].Value = nc;
                //20200330
                param[76].Value = E0;
                param[77].Value = E1;
                param[78].Value = R1;
                //20200908
                param[79].Value = R2;
                //20201013
                param[80].Value = Le;
                //20220713
                param[81].Value = NK;
                param[82].Value = XNT;
                param[83].Value = XLE;
                //20230525
                param[84].Value = T;
                //20230926
                param[85].Value = BL;
                param[86].Value = DS;
                //20230926
                param[87].Value = FC;
                param[88].Value = Ho;
                //20240502
                param[89].Value = BNN;
                param[90].Value = CC;
                param[91].Value = O1;
                sproc = new StoreProcedure(WorkdayCoefficientEmployeesFinalKeys.Sp_Upd_H1_WorkdayCoefficientEmployeesFinal_By_UserId_Date_For_Workday, param);
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

        public long ImportFromExcelACV(string ACVId, DateTime DataDate, string Day1, string Day2, string Day3, string Day4, string Day5, string Day6, string Day7, string Day8, string Day9, string Day10,
                          string Day11, string Day12, string Day13, string Day14, string Day15, string Day16, string Day17, string Day18, string Day19, string Day20,
                          string Day21, string Day22, string Day23, string Day24, string Day25, string Day26, string Day27, string Day28, string Day29, string Day30, string Day31,
                          double NCQD, double NCDC, double X, double OmDNBHXH, double Om, double OmDN, double KHH, double Co, double TS, double ST, double Khamthai, double TNLD, double F, double Diduong, double CTac, double Fdb,
                          double H1, double H2, double H3, double H4, double H5, double H6, double H7, double DinhChiCT, double Ro, double Ko, double LamthemNTbngay, double LamthemCNbngay, double LamthemLTbngay, double LamthemNTbdem,
                          double LamthemCNbdem, double LamthemLTbdem, double Lamdem,
                          double HSLNS, double HSLNSPCTN, double HSLCB, double HSPCDH, double HSPCTN, double HSPCKV, double HSPCCV, double HSK, double DTNopThue, double NguoiPThuoc,
                          DateTime CreateDate, int CreateUserId, DateTime UpdateDate, int UpdateUserId, string Remark, int UserId,
                          string Contract, double BSLNgayCong, double BSLHSLNS, double BSLQHSLNS, double ThuongNgayCong, double ThuongHSLNS, double ThuongQHSLNS, double ATHKNgayCong, double ATHKHSLNS, double ATHKQHSLNS, double ThangCongLeTet)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@ACVId", SqlDbType.VarChar, 50),
                    new SqlParameter("@DataDate", SqlDbType.DateTime, 8),
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
                    new SqlParameter("@NCQD", SqlDbType.Float),
                    new SqlParameter("@NCDC", SqlDbType.Float),
                    new SqlParameter("@X", SqlDbType.Float),
                    new SqlParameter("@OmDNBHXH", SqlDbType.Float),
                    new SqlParameter("@Om", SqlDbType.Float),
                    new SqlParameter("@OmDN", SqlDbType.Float),
                    new SqlParameter("@KHH", SqlDbType.Float),
                    new SqlParameter("@Co", SqlDbType.Float),
                    new SqlParameter("@TS", SqlDbType.Float),
                    new SqlParameter("@ST", SqlDbType.Float),
                    new SqlParameter("@Khamthai", SqlDbType.Float),
                    new SqlParameter("@TNLD", SqlDbType.Float),
                    new SqlParameter("@F", SqlDbType.Float),
                    new SqlParameter("@Diduong", SqlDbType.Float),
                    new SqlParameter("@CTac", SqlDbType.Float),
                    new SqlParameter("@Fdb", SqlDbType.Float),
                    new SqlParameter("@H1", SqlDbType.Float),
                    new SqlParameter("@H2", SqlDbType.Float),
                    new SqlParameter("@H3", SqlDbType.Float),
                    new SqlParameter("@H4", SqlDbType.Float),
                    new SqlParameter("@H5", SqlDbType.Float),
                    new SqlParameter("@H6", SqlDbType.Float),
                    new SqlParameter("@H7", SqlDbType.Float),
                    new SqlParameter("@DinhChiCT", SqlDbType.Float),
                    new SqlParameter("@Ro", SqlDbType.Float),
                    new SqlParameter("@Ko", SqlDbType.Float),
                    new SqlParameter("@LamthemNTbngay", SqlDbType.Float),
                    new SqlParameter("@LamthemCNbngay", SqlDbType.Float),
                    new SqlParameter("@LamthemLTbngay", SqlDbType.Float),
                    new SqlParameter("@LamthemNTbdem", SqlDbType.Float),
                    new SqlParameter("@LamthemCNbdem", SqlDbType.Float),
                    new SqlParameter("@LamthemLTbdem", SqlDbType.Float),
                    new SqlParameter("@Lamdem", SqlDbType.Float),
                    new SqlParameter("@HSLNS", SqlDbType.Float),
                    new SqlParameter("@HSLNSPCTN", SqlDbType.Float),
                    new SqlParameter("@HSLCB", SqlDbType.Float),
                    new SqlParameter("@HSPCDH", SqlDbType.Float),
                    new SqlParameter("@HSPCTN", SqlDbType.Float),
                    new SqlParameter("@HSPCKV", SqlDbType.Float),
                    new SqlParameter("@HSPCCV", SqlDbType.Float),
                    new SqlParameter("@HSK", SqlDbType.Float),
                    new SqlParameter("@DTNopThue", SqlDbType.Float),
                    new SqlParameter("@NguoiPThuoc", SqlDbType.Float),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@CreateUserId", SqlDbType.Int),
                    new SqlParameter("@UpdateDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@UpdateUserId", SqlDbType.Int),
                    new SqlParameter("@Remark", SqlDbType.NVarChar,1000),
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@Contract", SqlDbType.VarChar,50),
                    new SqlParameter("@BSLNgayCong", SqlDbType.Float),
                    new SqlParameter("@BSLHSLNS", SqlDbType.Float),
                    new SqlParameter("@BSLQHSLNS", SqlDbType.Float),
                    new SqlParameter("@ThuongNgayCong", SqlDbType.Float),
                    new SqlParameter("@ThuongHSLNS", SqlDbType.Float),
                    new SqlParameter("@ThuongQHSLNS", SqlDbType.Float),
                    new SqlParameter("@ATHKNgayCong", SqlDbType.Float),
                    new SqlParameter("@ATHKHSLNS", SqlDbType.Float),
                    new SqlParameter("@ATHKQHSLNS", SqlDbType.Float),
                    new SqlParameter("@ThangCongLeTet", SqlDbType.Float)
                };



                param[0].Value = ACVId;
                param[1].Value = DataDate;
                param[2].Value = Day1;
                param[3].Value = Day2;
                param[4].Value = Day3;
                param[5].Value = Day4;
                param[6].Value = Day5;
                param[7].Value = Day6;
                param[8].Value = Day7;
                param[9].Value = Day8;
                param[10].Value = Day9;
                param[11].Value = Day10;
                param[12].Value = Day11;
                param[13].Value = Day12;
                param[14].Value = Day13;
                param[15].Value = Day14;
                param[16].Value = Day15;
                param[17].Value = Day16;
                param[18].Value = Day17;
                param[19].Value = Day18;
                param[20].Value = Day19;
                param[21].Value = Day20;
                param[22].Value = Day21;
                param[23].Value = Day22;
                param[24].Value = Day23;
                param[25].Value = Day24;
                param[26].Value = Day25;
                param[27].Value = Day26;
                param[28].Value = Day27;
                param[29].Value = Day28;
                param[30].Value = Day29;
                param[31].Value = Day30;
                param[32].Value = Day31;
                param[33].Value = NCQD;
                param[34].Value = NCDC;
                param[35].Value = X;
                param[36].Value = OmDNBHXH;
                param[37].Value = Om;
                param[38].Value = OmDN;
                param[39].Value = KHH;
                param[40].Value = Co;
                param[41].Value = TS;
                param[42].Value = ST;
                param[43].Value = Khamthai;
                param[44].Value = TNLD;
                param[45].Value = F;
                param[46].Value = Diduong;
                param[47].Value = CTac;
                param[48].Value = Fdb;
                param[49].Value = H1;
                param[50].Value = H2;
                param[51].Value = H3;
                param[52].Value = H4;
                param[53].Value = H5;
                param[54].Value = H6;
                param[55].Value = H7;
                param[56].Value = DinhChiCT;
                param[57].Value = Ro;
                param[58].Value = Ko;
                param[59].Value = LamthemNTbngay;
                param[60].Value = LamthemCNbngay;
                param[61].Value = LamthemLTbngay;
                param[62].Value = LamthemNTbdem;
                param[63].Value = LamthemCNbdem;
                param[64].Value = LamthemLTbdem;
                param[65].Value = Lamdem;
                param[66].Value = HSLNS;
                param[67].Value = HSLNSPCTN;
                param[68].Value = HSLCB;
                param[69].Value = HSPCDH;
                param[70].Value = HSPCTN;
                param[71].Value = HSPCKV;
                param[72].Value = HSPCCV;
                param[73].Value = HSK;
                param[74].Value = DTNopThue;
                param[75].Value = NguoiPThuoc;
                param[76].Value = CreateDate;
                param[77].Value = CreateUserId;
                param[78].Value = UpdateDate;
                param[79].Value = UpdateUserId;
                param[80].Value = Remark;
                param[81].Value = UserId;
                param[82].Value = Contract;
                param[83].Value = BSLNgayCong;
                param[84].Value = BSLHSLNS;
                param[85].Value = BSLQHSLNS;
                param[86].Value = ThuongNgayCong;
                param[87].Value = ThuongHSLNS;
                param[88].Value = ThuongQHSLNS;
                param[89].Value = ATHKNgayCong;
                param[90].Value = ATHKHSLNS;
                param[91].Value = ATHKQHSLNS;
                param[92].Value = ThangCongLeTet;
                sproc = new StoreProcedure(WorkdayCoefficientEmployeesFinalKeys.Sp_Imp_H1_WorkdayCoefficientEmployeeFinal, param);
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

        public long UpdateByCalculateConversionCoefficient(double NCHLNS, double HSQDNCHL, double HSTLNS, double NCHLCB, double NANGC, DateTime DataDate, DateTime UpdateDate, int UpdateUserId, string Remark, int UserId,
            double BSLNgayCong, double BSLHSLNS, double BSLQHSLNS, double ThuongNgayCong, double ThuongHSLNS, double ThuongQHSLNS, double ATHKNgayCong, double ATHKHSLNS, double ATHKQHSLNS, double ThangCongLeTet, int CountBlank_1_15, int CountBlank_16_31)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@NCHLNS", SqlDbType.Float),
                    new SqlParameter("@HSQDNCHL", SqlDbType.Float),
                    new SqlParameter("@HSTLNS", SqlDbType.Float),
                    new SqlParameter("@NCHLCB", SqlDbType.Float),
                    new SqlParameter("@NANGC", SqlDbType.Float),
                    new SqlParameter("@DataDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@UpdateDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@UpdateUserId", SqlDbType.Int),
                    new SqlParameter("@Remark", SqlDbType.NVarChar,1000),
                    new SqlParameter("@UserId", SqlDbType.Int),
                    new SqlParameter("@BSLNgayCong", SqlDbType.Float),
                    new SqlParameter("@BSLHSLNS", SqlDbType.Float),
                    new SqlParameter("@BSLQHSLNS", SqlDbType.Float),
                    new SqlParameter("@ThuongNgayCong", SqlDbType.Float),
                    new SqlParameter("@ThuongHSLNS", SqlDbType.Float),
                    new SqlParameter("@ThuongQHSLNS", SqlDbType.Float),
                    new SqlParameter("@ATHKNgayCong", SqlDbType.Float),
                    new SqlParameter("@ATHKHSLNS", SqlDbType.Float),
                    new SqlParameter("@ATHKQHSLNS", SqlDbType.Float),
                    new SqlParameter("@ThangCongLeTet", SqlDbType.Float),
                    new SqlParameter("@CountBlank_1_15", SqlDbType.Int),
                    new SqlParameter("@CountBlank_16_31", SqlDbType.Int)

                };



                param[0].Value = NCHLNS;
                param[1].Value = HSQDNCHL;
                param[2].Value = HSTLNS;
                param[3].Value = NCHLCB;
                param[4].Value = NANGC;
                param[5].Value = DataDate;
                param[6].Value = UpdateDate;
                param[7].Value = UpdateUserId;
                param[8].Value = Remark;
                param[9].Value = UserId;
                param[10].Value = BSLNgayCong;
                param[11].Value = BSLHSLNS;
                param[12].Value = BSLQHSLNS;
                param[13].Value = ThuongNgayCong;
                param[14].Value = ThuongHSLNS;
                param[15].Value = ThuongQHSLNS;
                param[16].Value = ATHKNgayCong;
                param[17].Value = ATHKHSLNS;
                param[18].Value = ATHKQHSLNS;
                param[19].Value = ThangCongLeTet;

                param[20].Value = CountBlank_1_15;
                param[21].Value = CountBlank_16_31;

                sproc = new StoreProcedure(WorkdayCoefficientEmployeesFinalKeys.Sp_Upd_H1_WorkdayCoefficientEmployeeFinalByCalculateConversionCoefficient, param);
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

        public long UpdateForContract(DateTime DataDate, string contract, int UserId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DataDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@Contract", SqlDbType.VarChar, 50),
                    new SqlParameter("@UserId", SqlDbType.Int)
                };


                param[0].Value = DataDate;
                param[1].Value = contract;
                param[2].Value = UserId;

                sproc = new StoreProcedure(WorkdayCoefficientEmployeesFinalKeys.Sp_Upd_H1_WorkdayCoefficientEmployeeFinalForContract, param);
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

        public long UpdateForHSK(DateTime DataDate, double HSK, int UserId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DataDate", SqlDbType.DateTime, 8),
                    new SqlParameter("@HSK", SqlDbType.VarChar, 50),
                    new SqlParameter("@UserId", SqlDbType.Int)
                };


                param[0].Value = DataDate;
                param[1].Value = HSK;
                param[2].Value = UserId;

                sproc = new StoreProcedure(WorkdayCoefficientEmployeesFinalKeys.Sp_Upd_H1_WorkdayCoefficientEmployeeFinalForHSK, param);
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


                sproc = new StoreProcedure(WorkdayCoefficientEmployeesFinalKeys.Sp_Upd_H1_WorkdayCoefficientEmployeesFinal_For_OverTime, param);
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

                sproc = new StoreProcedure(WorkdayCoefficientEmployeesFinalKeys.Sp_Del_H1_WorkdayCoefficientEmployeesFinal_By_DeptIds_Date, param);

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

        #region GET       

        public DataTable GetByDataDateV1(DateTime DataDate, int isVCQLNN, string DepartmentIds)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable(); ;
            try
            {
                SqlParameter[] param =
                {
                   new SqlParameter("@DataDate",SqlDbType.DateTime),
                   new SqlParameter("@IsVCQLNC",SqlDbType.Int, 4),
                   new SqlParameter("@DepartmentIds",SqlDbType.VarChar, 254),
                };
                param[0].Value = DataDate.ToShortDateString();
                param[1].Value = isVCQLNN;
                param[2].Value = DepartmentIds;

                sproc = new StoreProcedure(WorkdayCoefficientEmployeesFinalKeys.Sp_Sel_H1_WorkdayCoefficientEmployeesFinal_By_DataDateV1, param);
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
        public DataTable GetDataTableByDataDateForWorkingDay(DateTime DataDate, int isVCQLNN, string DepartmentIds)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable(); ;
            try
            {
                SqlParameter[] param =
                {
                   new SqlParameter("@DataDate",SqlDbType.DateTime),
                   new SqlParameter("@IsVCQLNC",SqlDbType.Int, 4),
                   new SqlParameter("@DepartmentIds",SqlDbType.VarChar, 254),
                };
                param[0].Value = DataDate.ToShortDateString();
                param[1].Value = isVCQLNN;
                param[2].Value = DepartmentIds;

                sproc = new StoreProcedure(WorkdayCoefficientEmployeesFinalKeys.Sp_Sel_H1_WorkdayCoefficientEmployeesFinal_By_DataDate_For_WorkingDay, param);
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

        public DataTable GetByDataDate(DateTime dataDate, int IsVCQLNC)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable(); ;
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DataDate",SqlDbType.DateTime),
                    new SqlParameter("@IsVCQLNC",SqlDbType.Int)

                };
                param[0].Value = dataDate;
                param[1].Value = IsVCQLNC;

                sproc = new StoreProcedure(WorkdayCoefficientEmployeesFinalKeys.Sp_Sel_H1_WorkdayCoefficientEmployeesFinal_By_DataDate, param);
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

        public DataTable GetWorkday(int userId, int month, int year)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
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

                sproc = new StoreProcedure("Sel_H1_WorkdayCoefficientEmployeesFinal_Workday_ByUserId_Monthly", param);
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

        public DataTable GetWorktime(int userId, int month, int year)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
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

                sproc = new StoreProcedure("Sel_H1_WorkdayCoefficientEmployeesFinal_Worktime_ByUserId_Monthly", param);
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

        public DataTable GetCoefficient(int userId, int month, int year)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
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

                sproc = new StoreProcedure("Sel_H1_WorkdayCoefficientEmployeesFinal_Coefficient_ByUserId_Monthly", param);
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

        public DataTable GetPIT(int userId, int month, int year)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
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

                sproc = new StoreProcedure("Sel_H1_WorkdayCoefficientEmployeesFinal_PIT_ByUserId_Monthly", param);
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

        public DataTable GetByDataDateForDetail(DateTime dataDate, int IsVCQLNC)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable(); ;
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DataDate",SqlDbType.DateTime),
                    new SqlParameter("@IsVCQLNC",SqlDbType.Int)

                };
                param[0].Value = dataDate;
                param[1].Value = IsVCQLNC;

                sproc = new StoreProcedure(WorkdayCoefficientEmployeesFinalKeys.Sp_Sel_H1_WorkdayCoefficientEmployeesFinal_By_DataDate_For_Detail, param);
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
        public DataTable GetByDataDateForTotal(DateTime dataDate, int IsVCQLNC)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable(); ;
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DataDate",SqlDbType.DateTime),
                    new SqlParameter("@IsVCQLNC",SqlDbType.Int)

                };
                param[0].Value = dataDate;
                param[1].Value = IsVCQLNC;

                sproc = new StoreProcedure(WorkdayCoefficientEmployeesFinalKeys.Sp_Sel_H1_WorkdayCoefficientEmployeesFinal_By_DataDate_For_Total, param);
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

        public DataTable GetByUserIdDataDate(int UserId, DateTime DataDate, int DataType, string DepartmentId)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable(); ;
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@DataDate",SqlDbType.DateTime),
                    new SqlParameter("@DataType",SqlDbType.Int),
                    new SqlParameter("DepartmentId",SqlDbType.VarChar, 254)
                };
                param[0].Value = UserId;
                param[1].Value = DataDate;
                param[2].Value = DataType;
                param[3].Value = DepartmentId;

                sproc = new StoreProcedure(WorkdayCoefficientEmployeesFinalKeys.Sp_Sel_H1_WorkdayCoefficientEmployeesFinal_By_UserId_DataDate, param);
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
