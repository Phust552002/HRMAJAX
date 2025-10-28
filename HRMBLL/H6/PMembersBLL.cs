using HRMDAL.H6;
using HRMUtil;
using HRMUtil.KeyNames.H0;
using HRMUtil.KeyNames.H6;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HRMBLL.H6
{
    public class PMembersBLL
    {
        private int _PMemberId = 0;
        private DateTime _DateJoinP = FormatDate.GetSQLDateMinValue;
        private DateTime _DateJoinPOfficial = FormatDate.GetSQLDateMinValue;
        private string _PlaceJoinP = string.Empty;
        private string _PCardNo = string.Empty;
        private string _PMemberRemarks = string.Empty;
        private int _PMemberStatus = 0;
        private int _UserId = 0;
        private string _UserName = string.Empty;
        private string _EmployeeCode = string.Empty;
        private string _Password = string.Empty;
        private DateTime _JoinDate = FormatDate.GetSQLDateMinValue;
        private DateTime _JoinCompanyDate = FormatDate.GetSQLDateMinValue;
        private bool _Marriage = false;
        private string _WorkingPhone = string.Empty;
        private string _HandPhone = string.Empty;
        private string _HomePhone = string.Empty;
        private string _AccountNo = string.Empty;
        private string _ATMNo = string.Empty;
        private string _BankName = string.Empty;
        private string _HealthInsuranceNo = string.Empty;
        private string _HealthInsuranceAddress = string.Empty;
        private string _SocialInsuranceNo = string.Empty;
        private string _HealthInsuranceCardNo = string.Empty;
        private string _Reference = string.Empty;
        private int _Status = 0;
        private DateTime _LeaveDate = FormatDate.GetSQLDateMinValue;
        /// <summary>
        /// CV
        /// </summary>
        ///      

        private string _FullName = string.Empty;
        private string _FullName2 = string.Empty;
        private string _OtherName = string.Empty;
        private string _NormalNames = string.Empty;
        private int _Sex = 0;
        private string _SexName = "";
        private DateTime _Birthday = FormatDate.GetSQLDateMinValue;

        private int _DayOfBirth;
        private int _MonthOfBirth;
        private int _YearOfBirth;

        private string _BirthPlace = string.Empty;
        private string _NativePlace = string.Empty;
        private string _NativePlace_Vneid = string.Empty;
        private string _Resident = string.Empty;
        private string _Live = string.Empty;
        private string _Live_street = string.Empty;
        private string _Live_city = string.Empty;
        private string _Live_ward = string.Empty;
        private string _Resident_street = string.Empty;
        private string _Resident_city = string.Empty;
        private string _Resident_ward = string.Empty;
        private string _IdCard = string.Empty;
        private DateTime _DateOfIssue = FormatDate.GetSQLDateMinValue;
        private string _PlaceOfIssue = string.Empty;
        private string _Nation = string.Empty;
        private string _Nationality = string.Empty;
        private string _Religion = string.Empty;
        private string _Origin = string.Empty;
        //private DateTime _DateJoinParty = FormatDate.GetSQLDateMinValue;
        //private string _PlaceJoinParty = string.Empty;
        private DateTime _DateJoinCYU = FormatDate.GetSQLDateMinValue;
        private string _PlaceJoinCYU = string.Empty;
        private DateTime _DateOfEnlisted = FormatDate.GetSQLDateMinValue;
        private DateTime _DateOfDemobilized = FormatDate.GetSQLDateMinValue;
        private string _ArmyRank = string.Empty;
        private string _WorkedCompany = string.Empty;
        private string _NoiCapThe = string.Empty;
        private DateTime _NgayCapThe = FormatDate.GetSQLDateMinValue;

        /// <summary>
        /// 
        /// </summary>
        /// 
        private int _PositionId = 0;
        private string _PositionName = string.Empty;
        private int _LevelPosition = 0;
        private string _DepartmentName = string.Empty;
        private string _DepartmentFullName = string.Empty;
        private string _DepartmentCode;
        private int _DepartmentId = 0;
        private int _RootId = 0;
        private string _RootName = string.Empty;
        private int _ParentId = 0;

        private string _TaxCode = string.Empty;

        private int _DepartmentLevel = 0;

        //phieu bo sung ho so dang vien
        private string _ChucVuDang = string.Empty;
        private string _ChucVuCQ = string.Empty;
        private string _ChucVuDT = string.Empty;
        private string _ChucVuDN = string.Empty;
        private string _TrinhDoTHPT = string.Empty;
        private string _ChuyenMonNV = string.Empty;
        private string _HocHam = string.Empty;
        private string _HocVi = string.Empty;
        private string _LyLuanChinhTri = string.Empty;
        private string _NgoaiNgu = string.Empty;
        private string _KhenThuong = string.Empty;
        private string _KyLuat = string.Empty;
        private string _ChaDe = string.Empty;
        private string _MeDe = string.Empty;
        private string _ChaVc = string.Empty;
        private string _MeVc = string.Empty;
        private string _VoChong = string.Empty;
        private string _Con = string.Empty;
        private string _VoChongNuocNgoaiCuaCon = string.Empty;
        private string _VCConDiNuocNgoai = string.Empty;
        private string _TongThuNhapHGD = string.Empty;
        private string _BinhQuanNguoi = string.Empty;
        private string _NhaO = string.Empty;
        private string _DatO = string.Empty;
        private string _HoatDongKinhTe = string.Empty;
        private string _TaiSanMoi = string.Empty;
        private string _GiaTri = string.Empty;
        private string _MienCongTacSHD = string.Empty;
        private string _CLDangVien = string.Empty;
        private string _NgheNghiepHienNay = string.Empty;
        /// <summary>
        /// 
        /// </summary>


        #region Properties Gerneral

        public int PMemberId
        {
            get { return _PMemberId; }
            set { _PMemberId = value; }
        }

        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public String EmployeeCode
        {
            get { return _EmployeeCode; }
            set { _EmployeeCode = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public DateTime JoinDate
        {
            get { return _JoinDate; }
            set { _JoinDate = value; }
        }
        public DateTime JoinCompanyDate
        {
            get { return _JoinCompanyDate; }
            set { _JoinCompanyDate = value; }
        }
        public bool Marriage
        {
            get { return _Marriage; }
            set { _Marriage = value; }
        }
        public string WorkingPhone
        {
            get { return _WorkingPhone; }
            set { _WorkingPhone = value; }
        }
        public string HandPhone
        {
            get { return _HandPhone; }
            set { _HandPhone = value; }
        }
        public string HomePhone
        {
            get { return _HomePhone; }
            set { _HomePhone = value; }
        }

        public string AccountNo
        {
            get { return _AccountNo; }
            set { _AccountNo = value; }
        }

        public string ATMNo
        {
            get { return _ATMNo; }
            set { _ATMNo = value; }
        }
        //Live Vneid
        public string Live_street
        {
            get { return _Live_street; }
            set { _Live_street = value; }
        }

        public string Live_city
        {
            get { return _Live_city; }
            set { _Live_city = value; }
        }

        public string Live_ward
        {
            get { return _Live_ward; }
            set { _Live_ward = value; }
        }
        //Resident
        public string Resident_street
        {
            get { return _Resident_street; }
            set { _Resident_street = value; }
        }

        public string Resident_city
        {
            get { return _Resident_city; }
            set { _Resident_city = value; }
        }

        public string Resident_ward
        {
            get { return _Resident_ward; }
            set { _Resident_ward = value; }
        }
        public static long UpdateInforGeneral(int sex, bool marriage, System.Nullable<System.DateTime> joinDate, System.Nullable<System.DateTime> joinCompanyDate,
                    string workingPhone, string healthInsuranceNo, string healthInsuranceAddress, string socialInsuranceNo,
                    int status, System.Nullable<System.DateTime> leaveDate, int userId, string healthInsuranceCardNo)
        {
            return new PMembersDAL().UpdateInforGeneral(sex, marriage, joinDate, joinCompanyDate,
                    workingPhone, healthInsuranceNo, healthInsuranceAddress, socialInsuranceNo,
                    status, leaveDate, userId, healthInsuranceCardNo);
        }

        public static long UpdateInforDetail(string fullName, string otherNames, string normalNames, int sex,
            DateTime birthday, string birthPlace, string nativePlace, string resident, string live, string handPhone, string homePhone,
            string idCard, DateTime dateOfIssue, string placeOfIssue, string nation, string nationality,
            string religion, string origin, DateTime dateJoinParty, string placeJoinParty, DateTime dateJoinCYU, string placeJoinCYU,
            DateTime dateOfEnlisted, DateTime dateOfDemobilized, string armyRank, string reference, string workedCompany, int userId,
            string NgheNghiepHienNay,  string TrinhDoTHPT, string ChuyenMonNV,
            string HocVi, string HocHam, string LyLuanChinhTri, string NgoaiNgu, DateTime dateJoinPOfficcial,string pCardNo, string noiCapThe, DateTime ngayCapThe)
        {
            long idReturn = new PMembersDAL().UpdateInforDetail(fullName, otherNames, normalNames, sex,
            birthday, birthPlace, nativePlace, resident, live, handPhone, homePhone, idCard, dateOfIssue, placeOfIssue,
            nation, nationality, religion, origin, dateJoinParty, placeJoinParty, dateJoinCYU, placeJoinCYU,
            dateOfEnlisted, dateOfDemobilized, armyRank, reference, workedCompany, userId, NgheNghiepHienNay, TrinhDoTHPT,
                         ChuyenMonNV, HocVi, HocHam, LyLuanChinhTri, NgoaiNgu, dateJoinPOfficcial,pCardNo,noiCapThe,ngayCapThe);

            //CommandLogBLL objCL = new CommandLogBLL();
            //objCL.DataName = userId.ToString();
            //objCL.UserId = updateUserId;
            //objCL.ModuleId = Constants.CommandLog_Form_UpdateEmployeeDetailInforId;
            //objCL.CommandTypeId = Constants.CommandLog_Update_Id;
            //objCL.OldValues = "birthday:" + birthday.ToString() + "; birthPlace: " + birthPlace + "; nativePlace: " + nativePlace;
            //objCL.NewValues = "TK:" + accountNo + "; ATM: " + ATMNo + "; NH: " + bankName;
            //objCL.CommandLogDate = DateTime.Now;
            //objCL.Save();

            return idReturn;
        }
       
        public static long UpdateInforBonus(string NormalNames, DateTime BirthDay, string Live, string ChucVuDang, string ChucVuCQ
                                            , string ChucVuDT, string ChucVuDN, string NgheNghiepHienNay, string TrinhDoTHPT, string ChuyenMonNV, string HocVi
                                            , string HocHam, string LyLuanChinhTri, string NgoaiNgu, string KhenThuong, string KyLuat
                                            , string ChaDe, string MeDe, string ChaVc, string MeVc, string VoChong, string Con
                                            , string VoChongNuocNgoaiCuaCon, string VCConDiNuocNgoai, string TongThuNhapHGD, string BinhQuanNguoi
                                            , string NhaO, string DatO, string HoatDongKinhTe, string TaiSanMoi, string GiaTri
                                            , string MienCongTacSHD, string CLDangVien, int userId)
        {
            long idReturn = new PMembersDAL().UpdateInforBonus(NormalNames, BirthDay, Live, ChucVuDang, ChucVuCQ
                                            , ChucVuDT, ChucVuDN, NgheNghiepHienNay, TrinhDoTHPT
                                            , ChuyenMonNV, HocVi, HocHam, LyLuanChinhTri, NgoaiNgu
                                            , KhenThuong, KyLuat, ChaDe, MeDe, ChaVc, MeVc
                                            , VoChong, Con, VoChongNuocNgoaiCuaCon, VCConDiNuocNgoai
                                            , TongThuNhapHGD, BinhQuanNguoi, NhaO, DatO, HoatDongKinhTe
                                            , TaiSanMoi, GiaTri, MienCongTacSHD, CLDangVien, userId);

            return idReturn;
        }


        public string BankName
        {
            get { return _BankName; }
            set { _BankName = value; }
        }
        public string HealthInsuranceNo
        {
            get { return _HealthInsuranceNo; }
            set { _HealthInsuranceNo = value; }
        }

        public string HealthInsuranceAddress
        {
            get { return _HealthInsuranceAddress; }
            set { _HealthInsuranceAddress = value; }
        }

        public string SocialInsuranceNo
        {
            get { return _SocialInsuranceNo; }
            set { _SocialInsuranceNo = value; }
        }

        public string HealthInsuranceCardNo
        {
            get { return _HealthInsuranceCardNo; }
            set { _HealthInsuranceCardNo = value; }
        }

        public string Reference
        {
            get { return _Reference; }
            set { _Reference = value; }
        }

        public string NgheNghiepHienNay
        {
            get { return _NgheNghiepHienNay; }
            set { _NgheNghiepHienNay = value; }
        }

        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public DateTime LeaveDate
        {
            get { return _LeaveDate; }
            set { _LeaveDate = value; }
        }

        public string TaxCode
        {
            get { return _TaxCode; }
            set { _TaxCode = value; }
        }


        #endregion

        #region CV

        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }
        public string FullName2
        {
            get { return _FullName2; }
            set { _FullName2 = value; }
        }
        public string OtherName
        {
            get { return _OtherName; }
            set { _OtherName = value; }
        }
        public string NormalNames
        {
            get { return _NormalNames; }
            set { _NormalNames = value; }
        }
        public int Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }
        public string SexName
        {
            get { return _SexName; }
            set { _SexName = value; }
        }
        public DateTime Birthday
        {
            get { return _Birthday; }
            set { _Birthday = value; }
        }

        public int DayOfBirth
        {
            get { return _DayOfBirth; }
            set { _DayOfBirth = value; }
        }
        public int MonthOfBirth
        {
            get { return _MonthOfBirth; }
            set { _MonthOfBirth = value; }
        }
        public int YearOfBirth
        {
            get { return _YearOfBirth; }
            set { _YearOfBirth = value; }
        }

        public string BirthPlace
        {
            get { return _BirthPlace; }
            set { _BirthPlace = value; }
        }
        public string NativePlace
        {
            get { return _NativePlace; }
            set { _NativePlace = value; }
        }
        public string NativePlace_Vneid
        {
            get { return _NativePlace_Vneid; }
            set { _NativePlace_Vneid = value; }
        }
        public string Resident
        {
            get { return _Resident; }
            set { _Resident = value; }
        }
        public string Live
        {
            get { return _Live; }
            set { _Live = value; }
        }
        public string IdCard
        {
            get { return _IdCard; }
            set { _IdCard = value; }
        }
        public DateTime DateOfIssue
        {
            get { return _DateOfIssue; }
            set { _DateOfIssue = value; }
        }
        public string PlaceOfIssue
        {
            get { return _PlaceOfIssue; }
            set { _PlaceOfIssue = value; }
        }
        public string Nation
        {
            get { return _Nation; }
            set { _Nation = value; }
        }
        public string Nationality
        {
            get { return _Nationality; }
            set { _Nationality = value; }
        }
        public string Religion
        {
            get { return _Religion; }
            set { _Religion = value; }
        }
        public string Origin
        {
            get { return _Origin; }
            set { _Origin = value; }
        }

        public DateTime DateJoinCYU
        {
            get { return _DateJoinCYU; }
            set { _DateJoinCYU = value; }
        }
        public string PlaceJoinCYU
        {
            get { return _PlaceJoinCYU; }
            set { _PlaceJoinCYU = value; }
        }
        public DateTime DateOfEnlisted
        {
            get { return _DateOfEnlisted; }
            set { _DateOfEnlisted = value; }
        }
        public DateTime DateOfDemobilized
        {
            get { return _DateOfDemobilized; }
            set { _DateOfDemobilized = value; }
        }
        public string ArmyRank
        {
            get { return _ArmyRank; }
            set { _ArmyRank = value; }
        }

        public string WorkedCompany
        {
            get { return _WorkedCompany; }
            set { _WorkedCompany = value; }
        }

        #endregion

        #region other

        public int PositionId
        {
            get { return _PositionId; }
            set { _PositionId = value; }
        }

        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }
        public int LevelPosition
        {
            get { return _LevelPosition; }
            set { _LevelPosition = value; }
        }
        public int DepartmentId
        {
            get { return _DepartmentId; }
            set { _DepartmentId = value; }
        }
        public string DepartmentCode
        {
            get { return _DepartmentCode; }
            set { _DepartmentCode = value; }
        }
        public string DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }
        public string DepartmentFullName
        {
            get { return _DepartmentFullName; }
            set { _DepartmentFullName = value; }
        }
        public int RootId
        {
            get { return _RootId; }
            set { _RootId = value; }
        }
        public string RootName
        {
            get { return _RootName; }
            set { _RootName = value; }
        }
        public int ParentId
        {
            get { return _ParentId; }
            set { _ParentId = value; }
        }

        public int DepartmentLevel
        {
            get { return _DepartmentLevel; }
            set { _DepartmentLevel = value; }
        }

        #endregion

        #region Constructors

        public PMembersBLL(int pMemberId, int userId, string userName, string employeeCode, string password, string fullName, DateTime birthday)
        {
            _PMemberId = pMemberId;
            _UserId = userId;
            _UserName = userName;
            _EmployeeCode = employeeCode;
            _Password = password;
            _FullName = fullName;
            _Birthday = birthday;
        }
        #endregion

        #region properties
        public DateTime DateJoinP
        {
            get { return _DateJoinP; }
            set { _DateJoinP = value; }
        }
        public DateTime DateJoinPOfficial
        {
            get { return _DateJoinPOfficial; }
            set { _DateJoinPOfficial = value; }
        }
        public string PlaceJoinP
        {
            get { return _PlaceJoinP; }
            set { _PlaceJoinP = value; }
        }



        public string PCardNo
        {
            get { return _PCardNo; }
            set { _PCardNo = value; }
        }
        public string PMemberRemarks
        {
            get { return _PMemberRemarks; }
            set { _PMemberRemarks = value; }
        }
        public int PMemberStatus
        {
            get { return _PMemberStatus; }
            set { _PMemberStatus = value; }
        }

        public string NoiCapThe
        {
            get { return _NoiCapThe; }
            set { _NoiCapThe = value; }
        }
        public DateTime NgayCapThe
        {
            get { return _NgayCapThe; }
            set { _NgayCapThe = value; }
        }

        public string ChucVuDang { get => _ChucVuDang; set => _ChucVuDang = value; }
        public string ChucVuCQ { get => _ChucVuCQ; set => _ChucVuCQ = value; }
        public string ChucVuDT { get => _ChucVuDT; set => _ChucVuDT = value; }
        public string ChucVuDN { get => _ChucVuDN; set => _ChucVuDN = value; }
        public string TrinhDoTHPT { get => _TrinhDoTHPT; set => _TrinhDoTHPT = value; }
        public string ChuyenMonNV { get => _ChuyenMonNV; set => _ChuyenMonNV = value; }
        public string HocHam { get => _HocHam; set => _HocHam = value; }
        public string HocVi { get => _HocVi; set => _HocVi = value; }
        public string LyLuanChinhTri { get => _LyLuanChinhTri; set => _LyLuanChinhTri = value; }
        public string NgoaiNgu { get => _NgoaiNgu; set => _NgoaiNgu = value; }
        public string KhenThuong { get => _KhenThuong; set => _KhenThuong = value; }
        public string KyLuat { get => _KyLuat; set => _KyLuat = value; }
        public string ChaDe { get => _ChaDe; set => _ChaDe = value; }
        public string MeDe { get => _MeDe; set => _MeDe = value; }
        public string ChaVc { get => _ChaVc; set => _ChaVc = value; }
        public string MeVc { get => _MeVc; set => _MeVc = value; }
        public string VoChong { get => _VoChong; set => _VoChong = value; }
        public string Con { get => _Con; set => _Con = value; }
        public string VoChongNuocNgoaiCuaCon { get => _VoChongNuocNgoaiCuaCon; set => _VoChongNuocNgoaiCuaCon = value; }
        public string VCConDiNuocNgoai { get => _VCConDiNuocNgoai; set => _VCConDiNuocNgoai = value; }
        public string TongThuNhapHGD { get => _TongThuNhapHGD; set => _TongThuNhapHGD = value; }
        public string BinhQuanNguoi { get => _BinhQuanNguoi; set => _BinhQuanNguoi = value; }
        public string NhaO { get => _NhaO; set => _NhaO = value; }
        public string DatO { get => _DatO; set => _DatO = value; }
        public string HoatDongKinhTe { get => _HoatDongKinhTe; set => _HoatDongKinhTe = value; }
        public string TaiSanMoi { get => _TaiSanMoi; set => _TaiSanMoi = value; }
        public string GiaTri { get => _GiaTri; set => _GiaTri = value; }
        public string MienCongTacSHD { get => _MienCongTacSHD; set => _MienCongTacSHD = value; }
        public string CLDangVien { get => _CLDangVien; set => _CLDangVien = value; }
       


        #endregion


        #region public methods Get
        public static PMembersBLL GetPMemberByEmployeeId(int userId)
        {
            PMembersDAL objPMembersDAL = new PMembersDAL();
            DataTable dt = objPMembersDAL.GetOne(userId);
            if (dt.Rows.Count > 0)
            {
                return GeneratePMemberFromDataRow(dt.Rows[0]);
            }
            else
            {
                return null;
            }

        }



        public static List<PMembersBLL> GetPMembersByDeptIds(string deptIds, int rootId, string fullname, string sortParameter, string AirlinesWorking)
        {
            List<PMembersBLL> list = GenerateListPMembersFromDataTable(new PMembersDAL().GetByDeptIds(deptIds, rootId, fullname, 0, AirlinesWorking));

            //if (!String.IsNullOrEmpty(sortParameter))
            //    list.Sort(new EmployeesBLLComparer(sortParameter));

            return list;
        }
        
        public static List<PMembersBLL> GetPMembersLeaveByDeptIds(string deptIds, int rootId, string fullname, string sortParameter, string AirlinesWorking)
        {
            List<PMembersBLL> list = GenerateListPMembersFromDataTable(new PMembersDAL().GetPMembersLeaveByDeptIds(deptIds, rootId, fullname, 0, AirlinesWorking));

            //if (!String.IsNullOrEmpty(sortParameter))
            //    list.Sort(new EmployeesBLLComparer(sortParameter));

            return list;
        }

        public void Update()
        {
            new PMembersDAL().Update(UserId, DateJoinP, DateJoinPOfficial, PlaceJoinP, PCardNo, PMemberRemarks, PMemberStatus);
        }

        private static List<PMembersBLL> GenerateListPMembersFromDataTable(DataTable dt)
        {
            List<PMembersBLL> lstPMembers = new List<PMembersBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                lstPMembers.Add(GeneratePMemberFromDataRow(dr));
            }

            return lstPMembers;
        }
        private static PMembersBLL GeneratePMemberFromDataRow(DataRow dr)
        {
            #region PMember
            PMembersBLL objPMembersBLL = new PMembersBLL(
                dr[PMemberKeys.FIELD_PMEMBER_PMEMBERID] == DBNull.Value ? 0 : (int)dr[PMemberKeys.FIELD_PMEMBER_PMEMBERID],
                dr[EmployeeKeys.FIELD_EMPLOYEES_USERID] == DBNull.Value ? 0 : (int)dr[EmployeeKeys.FIELD_EMPLOYEES_USERID],
                dr[EmployeeKeys.FIELD_EMPLOYEES_USERNAME] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_USERNAME],
                dr[EmployeeKeys.FIELD_EMPLOYEES_EMPLOYEE_CODE] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_EMPLOYEE_CODE],
                dr[EmployeeKeys.FIELD_EMPLOYEES_PASSWORD] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_PASSWORD],
                dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME],
                dr[EmployeeKeys.FIELD_EMPLOYEES_BIRTHDAY] == DBNull.Value ? FormatDate.GetSQLDateMinValue : (DateTime)dr[EmployeeKeys.FIELD_EMPLOYEES_BIRTHDAY]
                );

            /// General
            objPMembersBLL.Marriage = dr[EmployeeKeys.FIELD_EMPLOYEES_MARRIAGE] == DBNull.Value ? false : (bool)dr[EmployeeKeys.FIELD_EMPLOYEES_MARRIAGE];
            objPMembersBLL.Sex = dr[EmployeeKeys.FIELD_EMPLOYEES_SEX] == DBNull.Value ? 2 : (int)dr[EmployeeKeys.FIELD_EMPLOYEES_SEX];
            objPMembersBLL.JoinDate = dr[EmployeeKeys.FIELD_EMPLOYEES_JOINDATE] == DBNull.Value ? FormatDate.GetSQLDateMinValue : (DateTime)dr[EmployeeKeys.FIELD_EMPLOYEES_JOINDATE];
            objPMembersBLL.JoinCompanyDate = dr[EmployeeKeys.Field_Employees_JoinCompanyDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : (DateTime)dr[EmployeeKeys.Field_Employees_JoinCompanyDate];
            objPMembersBLL.WorkingPhone = dr[EmployeeKeys.FIELD_EMPLOYEES_WORKING_PHONE] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_WORKING_PHONE];
            objPMembersBLL.HandPhone = dr[EmployeeKeys.FIELD_EMPLOYEES_HAND_PHONE] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_HAND_PHONE];
            objPMembersBLL.HomePhone = dr[EmployeeKeys.FIELD_EMPLOYEES_HOME_PHONE] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_HOME_PHONE];
            objPMembersBLL.AccountNo = dr[EmployeeKeys.FIELD_EMPLOYEES_ACCOUNT_NO] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_ACCOUNT_NO];
            objPMembersBLL.ATMNo = dr[EmployeeKeys.FIELD_EMPLOYEES_ATM_NO] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_ATM_NO];
            objPMembersBLL.BankName = dr[EmployeeKeys.FIELD_EMPLOYEES_BANK_NAME] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_BANK_NAME];
            objPMembersBLL.HealthInsuranceNo = dr[EmployeeKeys.FIELD_EMPLOYEES_HEALTH_INSURANCE_NO] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_HEALTH_INSURANCE_NO];
            objPMembersBLL.HealthInsuranceAddress = dr[EmployeeKeys.FIELD_EMPLOYEES_HEALTH_INSURANCE_ADDRESS] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_HEALTH_INSURANCE_ADDRESS];
            objPMembersBLL.SocialInsuranceNo = dr[EmployeeKeys.FIELD_EMPLOYEES_SOCIAL_INSURANCE_NO] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_SOCIAL_INSURANCE_NO];
            objPMembersBLL.Status = dr[EmployeeKeys.FIELD_EMPLOYEES_STATUS] == DBNull.Value ? 0 : (int)dr[EmployeeKeys.FIELD_EMPLOYEES_STATUS];

            objPMembersBLL.LeaveDate = dr[EmployeeKeys.FIELD_EMPLOYEES_LeaveDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : (DateTime)dr[EmployeeKeys.FIELD_EMPLOYEES_LeaveDate];

            /// CV
            /// 
            objPMembersBLL.FullName = dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME];
            objPMembersBLL.FullName2 = dr[EmployeeKeys.Field_Employees_FullName2] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.Field_Employees_FullName2];
            objPMembersBLL.OtherName = dr[EmployeeKeys.FIELD_EMPLOYEES_OTHERNAMES] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_OTHERNAMES];
            objPMembersBLL.NormalNames = dr[EmployeeKeys.FIELD_EMPLOYEES_NORMALNAMES] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_NORMALNAMES];
            objPMembersBLL.Sex = dr[EmployeeKeys.FIELD_EMPLOYEES_SEX] == DBNull.Value ? -1 : (int)dr[EmployeeKeys.FIELD_EMPLOYEES_SEX];
            if (objPMembersBLL.Sex == 1)
            {
                objPMembersBLL.SexName = "Nam";
            }
            else if (objPMembersBLL.Sex == 0)
            {
                objPMembersBLL.SexName = "Nữ";
            }
            else
            {
                objPMembersBLL.SexName = "";
            }
            objPMembersBLL.Birthday = dr[EmployeeKeys.FIELD_EMPLOYEES_BIRTHDAY] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[EmployeeKeys.FIELD_EMPLOYEES_BIRTHDAY].ToString());

            objPMembersBLL.DayOfBirth = dr[EmployeeKeys.Field_Employees_DayOfBirth] == DBNull.Value ? 0 : (int)dr[EmployeeKeys.Field_Employees_DayOfBirth];
            objPMembersBLL.MonthOfBirth = dr[EmployeeKeys.Field_Employees_MonthOfBirth] == DBNull.Value ? 0 : (int)dr[EmployeeKeys.Field_Employees_MonthOfBirth];
            objPMembersBLL.YearOfBirth = dr[EmployeeKeys.Field_Employees_YearOfBirth] == DBNull.Value ? 0 : (int)dr[EmployeeKeys.Field_Employees_YearOfBirth];

            objPMembersBLL.BirthPlace = dr[EmployeeKeys.FIELD_EMPLOYEES_BIRTHPLACE] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_BIRTHPLACE];
            objPMembersBLL.NativePlace = dr[EmployeeKeys.FIELD_EMPLOYEES_NATIVEPLACE] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_NATIVEPLACE];
            objPMembersBLL.NativePlace_Vneid = dr[EmployeeKeys.FIELD_EMPLOYEES_NATIVEPLACE_VNEID] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_NATIVEPLACE_VNEID];
            objPMembersBLL.Resident = dr[EmployeeKeys.FIELD_EMPLOYEES_RESIDENT] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_RESIDENT];
            objPMembersBLL.Live = dr[EmployeeKeys.FIELD_EMPLOYEES_LIVE] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_LIVE];
            //Resident Vneid
            objPMembersBLL._Resident_street = dr[EmployeeKeys.FIELD_EMPLOYEES_RESIDENT_STREET] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_RESIDENT_STREET];
            objPMembersBLL._Resident_city = dr[EmployeeKeys.FIELD_EMPLOYEES_RESIDENT_CITY] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_RESIDENT_CITY];
            objPMembersBLL._Resident_ward = dr[EmployeeKeys.FIELD_EMPLOYEES_RESIDENT_WARD] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_RESIDENT_WARD];
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Live Vneid
            objPMembersBLL._Live_street = dr[EmployeeKeys.FIELD_EMPLOYEES_LIVE_STREET] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_LIVE_STREET];
            objPMembersBLL._Live_city = dr[EmployeeKeys.FIELD_EMPLOYEES_LIVE_CITY] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_LIVE_CITY];
            objPMembersBLL._Live_ward = dr[EmployeeKeys.FIELD_EMPLOYEES_LIVE_WARD] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_LIVE_WARD];
            objPMembersBLL.IdCard = dr[EmployeeKeys.FIELD_EMPLOYEES_IDCARD] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_IDCARD];
            objPMembersBLL.DateOfIssue = dr[EmployeeKeys.FIELD_EMPLOYEES_DATE_OF_ISSUE] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[EmployeeKeys.FIELD_EMPLOYEES_DATE_OF_ISSUE].ToString());
            objPMembersBLL.PlaceOfIssue = dr[EmployeeKeys.FIELD_EMPLOYEES_PLACE_OF_ISSUE] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_PLACE_OF_ISSUE];
            objPMembersBLL.Nation = dr[EmployeeKeys.FIELD_EMPLOYEES_NATION] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_NATION];
            objPMembersBLL.Nationality = dr[EmployeeKeys.FIELD_EMPLOYEES_NATIONALITY] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_NATIONALITY];
            objPMembersBLL.Religion = dr[EmployeeKeys.FIELD_EMPLOYEES_RELIGION] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_RELIGION];
            objPMembersBLL.Origin = dr[EmployeeKeys.FIELD_EMPLOYEES_ORIGIN] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_ORIGIN];
            //objPMembersBLL.DateJoinParty = dr[EmployeeKeys.FIELD_EMPLOYEES_DATE_JOIN_PARTY] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[EmployeeKeys.FIELD_EMPLOYEES_DATE_JOIN_PARTY]);
            //objPMembersBLL.PlaceJoinParty = dr[EmployeeKeys.FIELD_EMPLOYEES_PLACE_JOIN_PARTY] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_PLACE_JOIN_PARTY];
            objPMembersBLL.DateOfEnlisted = dr[EmployeeKeys.FIELD_EMPLOYEES_DATE_OF_ENLISTED] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[EmployeeKeys.FIELD_EMPLOYEES_DATE_OF_ENLISTED].ToString());
            objPMembersBLL.DateOfDemobilized = dr[EmployeeKeys.FIELD_EMPLOYEES_DATE_OF_DEMOBILIZED] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[EmployeeKeys.FIELD_EMPLOYEES_DATE_OF_DEMOBILIZED].ToString());
            objPMembersBLL.ArmyRank = dr[EmployeeKeys.FIELD_EMPLOYEES_ARMYRANK] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_ARMYRANK];
           


            objPMembersBLL.Reference = dr[PMemberKeys.FIELD_PMEMBER_REFERENCE] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_REFERENCE];
            objPMembersBLL.ChucVuDang = dr[PMemberKeys.FIELD_PMEMBER_CHUCVUDANG] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_CHUCVUDANG];
            objPMembersBLL.ChucVuCQ = dr[PMemberKeys.FIELD_PMEMBER_CHUCVUCQ] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_CHUCVUCQ];
            objPMembersBLL.ChucVuDT = dr[PMemberKeys.FIELD_PMEMBER_CHUCVUDT] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_CHUCVUDT];
            objPMembersBLL.ChucVuDN = dr[PMemberKeys.FIELD_PMEMBER_CHUCVUDN] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_CHUCVUDN];
            objPMembersBLL.TrinhDoTHPT = dr[PMemberKeys.FIELD_PMEMBER_TRINHDOTHPT] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_TRINHDOTHPT];
            objPMembersBLL.ChuyenMonNV = dr[PMemberKeys.FIELD_PMEMBER_CHUYENMONNV] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_CHUYENMONNV];
            objPMembersBLL.HocHam = dr[PMemberKeys.FIELD_PMEMBER_HOCHAM] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_HOCHAM];
            objPMembersBLL.HocVi = dr[PMemberKeys.FIELD_PMEMBER_HOCVI] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_HOCVI];
            objPMembersBLL.LyLuanChinhTri = dr[PMemberKeys.FIELD_PMEMBER_LYLUANCHINHTRI] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_LYLUANCHINHTRI];
            objPMembersBLL.NgoaiNgu = dr[PMemberKeys.FIELD_PMEMBER_NGOAINGU] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_NGOAINGU];
            objPMembersBLL.KhenThuong = dr[PMemberKeys.FIELD_PMEMBER_KHENTHUONG] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_KHENTHUONG];
            objPMembersBLL.KyLuat = dr[PMemberKeys.FIELD_PMEMBER_KYLUAT] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_KYLUAT];
            objPMembersBLL.ChaDe = dr[PMemberKeys.FIELD_PMEMBER_CHADE] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_CHADE];
            objPMembersBLL.MeDe = dr[PMemberKeys.FIELD_PMEMBER_MEDE] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_MEDE];
            objPMembersBLL.ChaVc = dr[PMemberKeys.FIELD_PMEMBER_CHAVC] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_CHAVC];
            objPMembersBLL.MeVc = dr[PMemberKeys.FIELD_PMEMBER_MEVC] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_MEVC];
            objPMembersBLL.VoChong = dr[PMemberKeys.FIELD_PMEMBER_VOCHONG] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_VOCHONG];
            objPMembersBLL.Con = dr[PMemberKeys.FIELD_PMEMBER_CON] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_CON];
            objPMembersBLL.VoChongNuocNgoaiCuaCon = dr[PMemberKeys.FIELD_PMEMBER_VOCHONGNUOCNGOAICUACON] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_VOCHONGNUOCNGOAICUACON];
            objPMembersBLL.VCConDiNuocNgoai = dr[PMemberKeys.FIELD_PMEMBER_VCCONDINUOCNGOAI] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_VCCONDINUOCNGOAI];
            objPMembersBLL.TongThuNhapHGD = dr[PMemberKeys.FIELD_PMEMBER_TONGTHUNHAPHGD] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_TONGTHUNHAPHGD];
            objPMembersBLL.BinhQuanNguoi = dr[PMemberKeys.FIELD_PMEMBER_BINHQUANNGUOI] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_BINHQUANNGUOI];
            objPMembersBLL.NhaO = dr[PMemberKeys.FIELD_PMEMBER_NHAO] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_NHAO];
            objPMembersBLL.DatO = dr[PMemberKeys.FIELD_PMEMBER_DATO] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_DATO];
            objPMembersBLL.HoatDongKinhTe = dr[PMemberKeys.FIELD_PMEMBER_HOATDONGKINHTE] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_HOATDONGKINHTE];
            objPMembersBLL.TaiSanMoi = dr[PMemberKeys.FIELD_PMEMBER_TAISANMOI] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_TAISANMOI];
            objPMembersBLL.GiaTri = dr[PMemberKeys.FIELD_PMEMBER_GIATRI] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_GIATRI];
            objPMembersBLL.MienCongTacSHD = dr[PMemberKeys.FIELD_PMEMBER_MIENCONGTACSHD] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_MIENCONGTACSHD];
            objPMembersBLL.CLDangVien = dr[PMemberKeys.FIELD_PMEMBER_CLDANGVIEN] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_CLDANGVIEN];
            objPMembersBLL.NgheNghiepHienNay = dr[PMemberKeys.FIELD_PMEMBER_NGHENGHIEPHIENNAY] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_NGHENGHIEPHIENNAY];
           //
            try
            {
                objPMembersBLL.DateJoinCYU = dr[EmployeeKeys.FIELD_EMPLOYEES_DATE_JOIN_CYU] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[EmployeeKeys.FIELD_EMPLOYEES_DATE_JOIN_CYU]);
                objPMembersBLL.PlaceJoinCYU = dr[EmployeeKeys.FIELD_EMPLOYEES_PLACE_JOIN_CYU] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_PLACE_JOIN_CYU];
              
            }
            catch { }

            try
            {
                objPMembersBLL.WorkedCompany = dr[EmployeeKeys.FIELD_EMPLOYEES_WORKED_COMPANY] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.FIELD_EMPLOYEES_WORKED_COMPANY];
            }
            catch { }
            try
            {
                objPMembersBLL.PositionName = dr[PositionKeys.FIELD_POSITION_NAME] == DBNull.Value ? string.Empty : (string)dr[PositionKeys.FIELD_POSITION_NAME];
            }
            catch { }
            try
            {
                objPMembersBLL.LevelPosition = dr[PositionKeys.Field_Position_LevelPosition] == DBNull.Value ? 0 : (int)dr[PositionKeys.Field_Position_LevelPosition];
            }
            catch { } 
            try
            {
                objPMembersBLL.DepartmentName = dr[HRMUtil.KeyNames.H6.DepartmentKeys.FIELD_DEPARTMENT_NAME] == DBNull.Value ? string.Empty : (string)dr[HRMUtil.KeyNames.H6.DepartmentKeys.FIELD_DEPARTMENT_NAME];
            }
            catch { }
            try
            {
                objPMembersBLL.DepartmentFullName = dr[HRMUtil.KeyNames.H6.DepartmentKeys.Field_Department_DepartmentFullName] == DBNull.Value ? string.Empty : (string)dr[HRMUtil.KeyNames.H6.DepartmentKeys.Field_Department_DepartmentFullName];
            }
            catch { }
            try
            {
                objPMembersBLL.DepartmentId = dr[HRMUtil.KeyNames.H6.DepartmentKeys.FIELD_DEPARTMENT_ID] == DBNull.Value ? 0 : (int)dr[HRMUtil.KeyNames.H6.DepartmentKeys.FIELD_DEPARTMENT_ID];
            }
            catch { }
            try
            {
                objPMembersBLL.RootId = dr[HRMUtil.KeyNames.H6.DepartmentKeys.FIELD_DEPARTMENT_ROOT_ID] == DBNull.Value ? 0 : (int)dr[HRMUtil.KeyNames.H6.DepartmentKeys.FIELD_DEPARTMENT_ROOT_ID];
            }
            catch { }
            try
            {
                objPMembersBLL.RootName = dr[HRMUtil.KeyNames.H6.DepartmentKeys.Field_Department_RootName] == DBNull.Value ? string.Empty : (string)dr[HRMUtil.KeyNames.H6.DepartmentKeys.Field_Department_RootName];
            }
            catch { }
            try
            {
                objPMembersBLL.ParentId = dr[HRMUtil.KeyNames.H6.DepartmentKeys.FIELD_DEPARTMENT_PARENT_ID] == DBNull.Value ? 0 : (int)dr[HRMUtil.KeyNames.H6.DepartmentKeys.FIELD_DEPARTMENT_PARENT_ID];
            }
            catch { }
            try
            {
                objPMembersBLL.DepartmentLevel = dr[HRMUtil.KeyNames.H6.DepartmentKeys.Field_Department_Level] == DBNull.Value ? 0 : (int)dr[HRMUtil.KeyNames.H6.DepartmentKeys.Field_Department_Level];
            }
            catch { }

            try
            {
                objPMembersBLL.TaxCode = dr[EmployeeKeys.Field_Employees_TaxCode] == DBNull.Value ? string.Empty : (string)dr[EmployeeKeys.Field_Employees_TaxCode];
            }
            catch { }

            #endregion
            try
            {
                objPMembersBLL._DateJoinP = dr[PMemberKeys.FIELD_PMEMBER_DATE_JOIN_P] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[PMemberKeys.FIELD_PMEMBER_DATE_JOIN_P]);
            }
            catch { }
            try
            {
                objPMembersBLL._DateJoinPOfficial = dr[PMemberKeys.FIELD_PMEMBER_DATE_JOIN_P_OFFICIAL] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[PMemberKeys.FIELD_PMEMBER_DATE_JOIN_P_OFFICIAL]);
            }
            catch { }
            try
            {
                objPMembersBLL._PlaceJoinP = dr[PMemberKeys.FIELD_PMEMBER_PLACE_JOIN_P] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_PLACE_JOIN_P];
            }
            catch { }
            try
            {
                objPMembersBLL._PCardNo = dr[PMemberKeys.FIELD_PMEMBER_CARD_NO] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_CARD_NO];           
            }
            catch { }
            try
            {
                objPMembersBLL._PMemberRemarks = dr[PMemberKeys.FIELD_PMEMBER_REMARKS] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_REMARKS];
            }
            catch { }
            try
            {
                objPMembersBLL._PMemberStatus = dr[PMemberKeys.FIELD_PMEMBER_STATUS] == DBNull.Value ? 0 : Convert.ToInt32(dr[PMemberKeys.FIELD_PMEMBER_STATUS]);
            }
            catch { }
            try
            {
                objPMembersBLL._NoiCapThe = dr[PMemberKeys.FIELD_PMEMBER_NOICAPTHE] == DBNull.Value ? string.Empty : (string)dr[PMemberKeys.FIELD_PMEMBER_NOICAPTHE];
            }
            catch { }
            try
            {
                objPMembersBLL._NgayCapThe = dr[PMemberKeys.FIELD_PMEMBER_NGAYCAPTHE] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[PMemberKeys.FIELD_PMEMBER_NGAYCAPTHE].ToString());
            }
            catch { }

            return objPMembersBLL;
        }



        public static long Add(int userId, DateTime dateJoinP, DateTime dateJoinPOfficial, string placeJoinP, string pCardNo, int pMemberStatus,string fullName,int sex)
        {
            return new PMembersDAL().Add(userId, dateJoinP, dateJoinPOfficial, placeJoinP, pCardNo, pMemberStatus, fullName,sex);
        }

        public static DataTable GetEmployeesForImport(string fullname)
        {
            return new PMembersDAL().GetEmployeesForImport(fullname);
        }
        public static DataTable GetDocTypes(int recordType)
        {
            return new PMembersDAL().GetDocTypes(recordType);
        }
        public static long AddDoc(int userId, int docTypeId, string docName, string docName2, string fileName, int year, string remarks)
        {
            return new PMembersDAL().AddDoc(userId, docTypeId, docName, docName2, fileName, year, remarks);
        }
        public static DataTable GetDocLists(int userId, int recordType, int docTypeId, string docName, int docYear)
        {
            return new PMembersDAL().GetDocLists(userId, recordType, docTypeId, docName, docYear);
        }
        public static DataTable GetDoc(int docId)
        {
            return new PMembersDAL().GetDoc(docId);
        }
        public static long DeleteDoc(int docId)
        {
            return new PMembersDAL().DeleteDoc(docId);
        }

        public static DataTable GetYearQuality()
        {
            return new PMembersDAL().GetYearQuality();
        }

        public static DataTable GetPMembersQualityByYear(int year)
        {
            return new PMembersDAL().GetPMembersQualityByYear(year);
        }
        #endregion


    }
}
