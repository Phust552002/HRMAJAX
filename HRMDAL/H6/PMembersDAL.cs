using HRMDAL.Utilities;
using HRMUtil;
using HRMUtil.KeyNames.H6;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace HRMDAL.H6
{
    public class PMembersDAL : Dao
    {
        public DataTable GetByDeptIds(string deptIds, int rootId, string fullname, int TypeSort, string AirlinesWorking)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DeptIds",SqlDbType.VarChar,1000),
                    new SqlParameter("@RootId",SqlDbType.Int),
                    new SqlParameter("@FullName",SqlDbType.NVarChar,254),
                    new SqlParameter("@TypeSort",SqlDbType.Int),
                    new SqlParameter("@AirlinesWorking",SqlDbType.VarChar,100)
                };

                param[0].Value = deptIds;
                param[1].Value = rootId;
                param[2].Value = fullname;
                param[3].Value = TypeSort;
                param[4].Value = AirlinesWorking;

                sproc = new StoreProcedure(PMemberKeys.Sp_Sel_H6_PMember_By_DeptIds, param);
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

        public DataTable GetEmployeesForImport(string fullname)
        {
            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@FullName",SqlDbType.NVarChar,254),
                };
                
                param[0].Value = fullname;

                sproc = new StoreProcedure(PMemberKeys.Sp_Sel_H6_Employees_ToImport, param);
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

        public DataTable GetOne(int userId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId",SqlDbType.Int,4)
                };
                param[0].Value = userId;
                sproc = new StoreProcedure(PMemberKeys.Sp_Sel_H6_PMember_By_UserId, param);
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

        public long Update(int userId, System.Nullable<DateTime> dateJoinP, System.Nullable<DateTime> dateJoinPOfficial, string placeJoinP, string pCardNo, string pMemberRemarks, int pMemberStatus)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@DateJoinP",SqlDbType.DateTime),
                    new SqlParameter("@DateJoinPOfficial",SqlDbType.DateTime),
                    new SqlParameter("@PlaceJoinP",SqlDbType.NVarChar,254),
                    new SqlParameter("@PCardNo",SqlDbType.NVarChar,50),
                    new SqlParameter("@PMemberRemarks",SqlDbType.NVarChar,254),
                    new SqlParameter("@PMemberStatus",SqlDbType.Int),

                };

                param[0].Value = userId;

                if ((dateJoinP.HasValue == true))
                {
                    param[1].Value = dateJoinP;
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((dateJoinPOfficial.HasValue == true))
                {
                    param[2].Value = dateJoinPOfficial;
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                param[3].Value = placeJoinP;
                param[4].Value = pCardNo;
                param[5].Value = pMemberRemarks;
                param[6].Value = pMemberStatus;

                sproc = new StoreProcedure(PMemberKeys.Sp_Upd_H6_PMember, param);
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

        public long UpdateInforGeneral(int sex, bool marriage, System.Nullable<System.DateTime> joinDate, System.Nullable<System.DateTime> joinCompanyDate,
                    string workingPhone, string healthInsuranceNo, string healthInsuranceAddress, string socialInsuranceNo,
                    int status, System.Nullable<System.DateTime> leaveDate, int userId, string healthInsuranceCardNo)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {

                SqlParameter[] param =
                {
                    new SqlParameter("@Sex",SqlDbType.Int),
                    new SqlParameter("@Marriage",SqlDbType.Bit),
                    new SqlParameter("@JoinDate",SqlDbType.DateTime),
                    new SqlParameter("@JoinCompanyDate",SqlDbType.DateTime),
                    new SqlParameter("@WorkingPhone",SqlDbType.VarChar,50),
                    new SqlParameter("@HealthInsuranceNo",SqlDbType.VarChar, 50),
                    new SqlParameter("@HealthInsuranceAddress",SqlDbType.NVarChar, 100),
                    new SqlParameter("@SocialInsuranceNo",SqlDbType.VarChar, 50),
                    new SqlParameter("@Status",SqlDbType.Int),
                    new SqlParameter("@LeaveDate",SqlDbType.SmallDateTime),
                    new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@HealthInsuranceCardNo",SqlDbType.VarChar, 50),
                };
                param[0].Value = sex;
                param[1].Value = marriage;

                if ((joinDate.HasValue == true))
                {
                    if (joinDate.Equals(FormatDate.GetSQLDateMinValue))
                    {
                        param[2].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[2].Value = ((System.DateTime)(joinDate.Value));
                    }
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                if ((joinCompanyDate.HasValue == true))
                {
                    if (joinCompanyDate.Equals(FormatDate.GetSQLDateMinValue))
                    {
                        param[3].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[3].Value = ((System.DateTime)(joinCompanyDate.Value));
                    }
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }

                param[4].Value = workingPhone;
                param[5].Value = healthInsuranceNo;
                param[6].Value = healthInsuranceAddress;
                param[7].Value = socialInsuranceNo;
                param[8].Value = status;

                if ((leaveDate.HasValue == true))
                {
                    if (leaveDate.Equals(FormatDate.GetSQLDateMinValue))
                    {
                        param[9].Value = System.DBNull.Value;
                    }
                    else
                    {
                        param[9].Value = ((System.DateTime)(leaveDate.Value));
                    }
                }
                else
                {
                    param[9].Value = System.DBNull.Value;
                }

                param[10].Value = userId;
                param[11].Value = healthInsuranceCardNo;

                sproc = new StoreProcedure(PMemberKeys.Sp_Upd_H6_PMember_Infor_General, param);
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

        public long UpdateInforDetail(string fullName, string otherNames, string normalNames, int sex,
            DateTime birthday, string birthPlace, string nativePlace, string resident, string live, string handPhone, string homePhone,
            string idCard, DateTime dateOfIssue, string placeOfIssue, string nation, string nationality,
            string religion, string origin, DateTime dateJoinParty, string placeJoinParty, DateTime dateJoinCYU, string placeJoinCYU,
            DateTime dateOfEnlisted, DateTime dateOfDemobilized, string armyRank, string reference, string workedCompany, int userId,
            string NgheNghiepHienNay, string TrinhDoTHPT, string ChuyenMonNV,
            string HocVi, string HocHam, string LyLuanChinhTri, string NgoaiNgu, DateTime dateJoinPOfficial,string pCardNo,string noiCapThe,DateTime ngayCapThe)
        {

            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {

                SqlParameter[] param =
                {

                    new SqlParameter("@FullName",SqlDbType.NVarChar, 100),
                    new SqlParameter("@OtherNames",SqlDbType.NVarChar, 100),
                    new SqlParameter("@NormalNames",SqlDbType.NVarChar, 100),
                    new SqlParameter("@Sex",SqlDbType.Int),
                    new SqlParameter("@Birthday",SqlDbType.DateTime),
                    new SqlParameter("@BirthPlace",SqlDbType.NVarChar,254),
                    new SqlParameter("@NativePlace",SqlDbType.NVarChar,254),
                    new SqlParameter("@Resident",SqlDbType.NVarChar,254),
                    new SqlParameter("@Live",SqlDbType.NVarChar,254),
                    new SqlParameter("@HandPhone",SqlDbType.VarChar,50),
                    new SqlParameter("@HomePhone",SqlDbType.VarChar,50),
                    new SqlParameter("@IdCard",SqlDbType.VarChar, 50),
                    new SqlParameter("@DateOfIssue",SqlDbType.DateTime),
                    new SqlParameter("@PlaceOfIssue",SqlDbType.NVarChar,254),
                    new SqlParameter("@Nation",SqlDbType.NVarChar, 50),
                    new SqlParameter("@Nationality",SqlDbType.NVarChar, 50),
                    new SqlParameter("@Religion",SqlDbType.NVarChar, 50),
                    new SqlParameter("@Origin",SqlDbType.NVarChar, 254),
                    new SqlParameter("@DateJoinParty",SqlDbType.DateTime),
                    new SqlParameter("@PlaceJoinParty",SqlDbType.NVarChar, 254),
                    new SqlParameter("@DateJoinCYU",SqlDbType.DateTime),
                    new SqlParameter("@PlaceJoinCYU",SqlDbType.NVarChar, 254),
                    new SqlParameter("@DateOfEnlisted",SqlDbType.DateTime),
                    new SqlParameter("@DateOfDemobilized",SqlDbType.DateTime),
                    new SqlParameter("@ArmyRank",SqlDbType.NVarChar, 254),
                    new SqlParameter("@Reference",SqlDbType.NVarChar, 254),
                    new SqlParameter("@WorkedCompany",SqlDbType.NText),
                    new SqlParameter("@UserId",SqlDbType.Int),

                    new SqlParameter("@NgheNghiepHienNay",SqlDbType.NVarChar),
                    new SqlParameter("@TrinhDoTHPT",SqlDbType.NVarChar),
                    new SqlParameter("@ChuyenMonNV",SqlDbType.NVarChar),
                    new SqlParameter("@HocVi",SqlDbType.NVarChar),
                    new SqlParameter("@HocHam",SqlDbType.NVarChar),
                    new SqlParameter("@LyLuanChinhTri",SqlDbType.NVarChar),
                    new SqlParameter("@NgoaiNgu",SqlDbType.NVarChar),
                    new SqlParameter("@DateJoinPOfficial",SqlDbType.DateTime),

                    new SqlParameter("@PCardNo",SqlDbType.NVarChar),
                    new SqlParameter("@NoiCapThe",SqlDbType.NVarChar),
                    new SqlParameter("@NgayCapThe",SqlDbType.DateTime),

                };

                param[0].Value = fullName;
                param[1].Value = otherNames;
                param[2].Value = normalNames;
                param[3].Value = sex;
                param[4].Value = birthday;
                param[5].Value = birthPlace;
                param[6].Value = nativePlace;
                param[7].Value = resident;
                param[8].Value = live;
                param[9].Value = handPhone;
                param[10].Value = homePhone;
                param[11].Value = idCard;
                param[12].Value = dateOfIssue;
                param[13].Value = placeOfIssue;
                param[14].Value = nation;
                param[15].Value = nationality;
                param[16].Value = religion;
                param[17].Value = origin;
                param[18].Value = dateJoinParty;
                param[19].Value = placeJoinParty;
                param[20].Value = dateJoinCYU;
                param[21].Value = placeJoinCYU;
                param[22].Value = dateOfEnlisted;
                param[23].Value = dateOfDemobilized;
                param[24].Value = armyRank;
                param[25].Value = reference;
                param[26].Value = workedCompany;
                param[27].Value = userId;

                param[28].Value = NgheNghiepHienNay;
                param[29].Value = TrinhDoTHPT;
                param[30].Value = ChuyenMonNV;
                param[31].Value = HocVi;
                param[32].Value = HocHam;
                param[33].Value = LyLuanChinhTri;
                param[34].Value = NgoaiNgu;
                param[35].Value = dateJoinPOfficial;

                param[36].Value = pCardNo;
                param[37].Value = noiCapThe;
                param[38].Value = ngayCapThe;

                sproc = new StoreProcedure(PMemberKeys.Sp_Upd_H6_PMember_Infor_Detail, param);
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

        public long UpdateInforBonus(string normalNames, DateTime birthDay, string live, string chucVuDang, string chucVuCQ, 
            string chucVuDT, string chucVuDN, string ngheNghiepHienNay, string trinhDoTHPT, string chuyenMonNV,
            string hocVi, string hocHam, string lyLuanChinhTri, string ngoaiNgu, string khenThuong, string kyLuat, 
            string chaDe, string meDe, string chaVc, string meVc, string voChong, string con, string voChongNuocNgoaiCuaCon,
            string vCConDiNuocNgoai, string tongThuNhapHGD, string binhQuanNguoi, string nhaO, string datO, 
            string hoatDongKinhTe, string taiSanMoi, string giaTri, string mienCongTacSHD, string cLDangVien, int userId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {

                SqlParameter[] param =
                {

                    new SqlParameter("@NormalNames",SqlDbType.NVarChar),
                    new SqlParameter("@BirthDay",SqlDbType.DateTime),
                    new SqlParameter("@Live",SqlDbType.NVarChar),
                    new SqlParameter("@ChucVuDang",SqlDbType.NVarChar),
                    new SqlParameter("@ChucVuCQ",SqlDbType.NVarChar),
                    new SqlParameter("@ChucVuDT",SqlDbType.NVarChar),
                    new SqlParameter("@ChucVuDN",SqlDbType.NVarChar),
                    new SqlParameter("@NgheNghiepHienNay",SqlDbType.NVarChar),
                    new SqlParameter("@TrinhDoTHPT",SqlDbType.NVarChar),
                    new SqlParameter("@ChuyenMonNV",SqlDbType.NVarChar),
                    new SqlParameter("@HocVi",SqlDbType.NVarChar),
                    new SqlParameter("@HocHam",SqlDbType.NVarChar),
                    new SqlParameter("@LyLuanChinhTri",SqlDbType.NVarChar),
                    new SqlParameter("@NgoaiNgu",SqlDbType.NVarChar),
                    new SqlParameter("@KhenThuong",SqlDbType.NVarChar),
                    new SqlParameter("@KyLuat",SqlDbType.NVarChar),
                    new SqlParameter("@ChaDe",SqlDbType.NVarChar),
                    new SqlParameter("@MeDe",SqlDbType.NVarChar),
                    new SqlParameter("@ChaVc",SqlDbType.NVarChar),
                    new SqlParameter("@MeVc",SqlDbType.NVarChar),
                    new SqlParameter("@VoChong",SqlDbType.NVarChar),
                    new SqlParameter("@Con",SqlDbType.NVarChar),
                    new SqlParameter("@VoChongNuocNgoaiCuaCon",SqlDbType.NVarChar),
                    new SqlParameter("@VCConDiNuocNgoai",SqlDbType.NVarChar),
                    new SqlParameter("@TongThuNhapHGD",SqlDbType.NVarChar),
                    new SqlParameter("@BinhQuanNguoi",SqlDbType.NVarChar),
                    new SqlParameter("@NhaO",SqlDbType.NVarChar),
                    new SqlParameter("@DatO",SqlDbType.NVarChar),
                    new SqlParameter("@HoatDongKinhTe",SqlDbType.NVarChar),
                    new SqlParameter("@TaiSanMoi",SqlDbType.NVarChar),
                    new SqlParameter("@GiaTri",SqlDbType.NVarChar),
                    new SqlParameter("@MienCongTacSHD",SqlDbType.NVarChar),
                    new SqlParameter("@CLDangVien",SqlDbType.NVarChar),
                    new SqlParameter("@UserId",SqlDbType.Int),
                };

                param[0].Value = normalNames;
                param[1].Value = birthDay;
                param[2].Value = live;
                param[3].Value = chucVuDang;
                param[4].Value = chucVuCQ;
                param[5].Value = chucVuDT;
                param[6].Value = chucVuDN;
                param[7].Value = ngheNghiepHienNay;
                param[8].Value = trinhDoTHPT;
                param[9].Value = chuyenMonNV;
                param[10].Value = hocVi;
                param[11].Value = hocHam;
                param[12].Value = lyLuanChinhTri;
                param[13].Value = ngoaiNgu;
                param[14].Value = khenThuong;
                param[15].Value = kyLuat;
                param[16].Value = chaDe;
                param[17].Value = meDe;
                param[18].Value = chaVc;
                param[19].Value = meVc;
                param[20].Value = voChong;
                param[21].Value = con;
                param[22].Value = voChongNuocNgoaiCuaCon;
                param[23].Value = vCConDiNuocNgoai;
                param[24].Value = tongThuNhapHGD;
                param[25].Value = binhQuanNguoi;
                param[26].Value = nhaO;
                param[27].Value = datO;
                param[28].Value = hoatDongKinhTe;
                param[29].Value = taiSanMoi;
                param[30].Value = giaTri;
                param[31].Value = mienCongTacSHD;
                param[32].Value = cLDangVien;
                param[33].Value = userId;

                sproc = new StoreProcedure(PMemberKeys.Sp_Upd_H6_PMember_Infor_Bonus, param);
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

        public long Add(int userId, System.Nullable<DateTime> dateJoinP, System.Nullable<DateTime> dateJoinPOfficial, string placeJoinP, string pCardNo, int pMemberStatus,string fullName,int sex)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@DateJoinP",SqlDbType.DateTime),
                    new SqlParameter("@DateJoinPOfficial",SqlDbType.DateTime),
                    new SqlParameter("@PlaceJoinP",SqlDbType.NVarChar,254),
                    new SqlParameter("@PCardNo",SqlDbType.NVarChar,50),
                    new SqlParameter("@PMemberStatus",SqlDbType.Int),
                    new SqlParameter("@FullName",SqlDbType.NVarChar,50),
                    new SqlParameter("@Sex",SqlDbType.Int),
                };

                param[0].Value = userId;

                if ((dateJoinP.HasValue == true))
                {
                    param[1].Value = dateJoinP;
                }
                else
                {
                    param[1].Value = System.DBNull.Value;
                }
                if ((dateJoinPOfficial.HasValue == true))
                {
                    param[2].Value = dateJoinPOfficial;
                }
                else
                {
                    param[2].Value = System.DBNull.Value;
                }
                param[3].Value = placeJoinP;
                param[4].Value = pCardNo;
                param[5].Value = pMemberStatus;
                param[6].Value = fullName;
                param[7].Value = sex;

                sproc = new StoreProcedure(PMemberKeys.Sp_Ins_H6_PMember, param);
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

        public DataTable GetDocTypes(int recordType)
        {
            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@RecordType",SqlDbType.Int)
                };
                param[0].Value = recordType;
                sproc = new StoreProcedure(PMemberKeys.Sp_Sel_H6_DocTypes_By_RecordType, param);
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

        public long AddDoc(int userId, int docTypeId, string docName, string docName2, string fileName, int year, string remarks)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@DocTypeId",SqlDbType.Int),
                    new SqlParameter("@DocName",SqlDbType.NVarChar, 254),
                    new SqlParameter("@DocName2",SqlDbType.VarChar, 254),
                    new SqlParameter("@FileName",SqlDbType.NVarChar,500),
                    new SqlParameter("@DocYear",SqlDbType.Int),
                    new SqlParameter("@Remarks",SqlDbType.NVarChar, 1000),

                };

                param[0].Value = userId;
                param[1].Value = docTypeId;
                param[2].Value = docName;
                param[3].Value = docName2;

                param[4].Value = fileName;
                param[5].Value = year;
                param[6].Value = remarks;

                sproc = new StoreProcedure(PMemberKeys.Sp_Ins_H6_PMember_Docs, param);
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



        public DataTable GetPMembersLeaveByDeptIds(string deptIds, int rootId, string fullname, int TypeSort, string AirlinesWorking)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DeptIds",SqlDbType.VarChar,1000),
                    new SqlParameter("@RootId",SqlDbType.Int),
                    new SqlParameter("@FullName",SqlDbType.NVarChar,254),
                    new SqlParameter("@TypeSort",SqlDbType.Int),
                    new SqlParameter("@AirlinesWorking",SqlDbType.VarChar,100)
                };

                param[0].Value = deptIds;
                param[1].Value = rootId;
                param[2].Value = fullname;
                param[3].Value = TypeSort;
                param[4].Value = AirlinesWorking;

                sproc = new StoreProcedure(PMemberKeys.Sp_Sel_H6_PMember_Leave_By_DeptIds, param);
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

        public DataTable GetDocLists(int userId, int recordType, int docTypeId, string docName, int docYear)
        {
            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@RecordType",SqlDbType.Int),
                    new SqlParameter("@DocTypeId",SqlDbType.Int),
                    new SqlParameter("@DocName",SqlDbType.NVarChar, 254),
                    new SqlParameter("@DocYear",SqlDbType.Int),
                };
                param[0].Value = userId;
                param[1].Value = recordType;
                param[2].Value = docTypeId;
                param[3].Value = docName;
                param[4].Value = docYear;
                sproc = new StoreProcedure(PMemberKeys.Sp_Sel_H6_DocList_By_UserId, param);
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

        public DataTable GetDoc(int docId)
        {
            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DocId",SqlDbType.Int)
                };
                param[0].Value = docId;
                sproc = new StoreProcedure(PMemberKeys.Sp_Sel_H6_Doc_By_DocId, param);
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

        public long DeleteDoc(int docId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DocId",SqlDbType.Int)

                };

                param[0].Value = docId;
                sproc = new StoreProcedure(PMemberKeys.Sp_Del_H6_PMember_Doc, param);
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

        public DataTable GetYearQuality()
        {
            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                   
                };
              
                sproc = new StoreProcedure(PMemberKeys.Sp_Sel_H6_Quality_Year, param);
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

        public DataTable GetPMembersQualityByYear(int year)
        {
            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@Year",SqlDbType.Int)
                };
                param[0].Value = year;
                sproc = new StoreProcedure(PMemberKeys.Sp_Sel_H6_PMember_Quality_By_Year, param);
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
    }
}
