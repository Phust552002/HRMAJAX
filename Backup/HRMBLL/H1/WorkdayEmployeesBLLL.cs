using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H1;
using HRMUtil.KeyNames.H1;
using HRMUtil.KeyNames.H0;
using HRMBLL.H1.Helper;
using HRMUtil;
using HRMBLL.H0;

namespace HRMBLL.H1
{
    public class WorkdayEmployeesBLLL
    {
        #region private fields

        private long _WorkdayEmployeeIdL;
        private int _UserId;
        private DateTime _WorkdayDateL;
        private int _TypeL;

        private string _EmployeeCode;
        private string _FullName;
        private int _RootId;
        private string _RootName;
        private int _DepartmentId;
        private string _DepartmentName;
        private string _DepartmentFullName;        
        private string _PositionName;
        
        #region TimeKeeping

        private string _Day1L = string.Empty;
        private string _Day2L = string.Empty;
        private string _Day3L = string.Empty;
        private string _Day4L = string.Empty;
        private string _Day5L = string.Empty;
        private string _Day6L = string.Empty;
        private string _Day7L = string.Empty;
        private string _Day8L = string.Empty;
        private string _Day9L = string.Empty;
        private string _Day10L = string.Empty;
        private string _Day11L = string.Empty;
        private string _Day12L = string.Empty;
        private string _Day13L = string.Empty;
        private string _Day14L = string.Empty;
        private string _Day15L = string.Empty;
        private string _Day16L = string.Empty;
        private string _Day17L = string.Empty;
        private string _Day18L = string.Empty;
        private string _Day19L = string.Empty;
        private string _Day20L = string.Empty;
        private string _Day21L = string.Empty;
        private string _Day22L = string.Empty;
        private string _Day23L = string.Empty;
        private string _Day24L = string.Empty;
        private string _Day25L = string.Empty;
        private string _Day26L = string.Empty;
        private string _Day27L = string.Empty;
        private string _Day28L = string.Empty;
        private string _Day29L = string.Empty;
        private string _Day30L = string.Empty;
        private string _Day31L = string.Empty;

        #endregion        

        #region To Collect WorkdayEmplyee

        private double _XQDL;
        private double _XL;
                
        private double _F_OmL;        
        private double _F_OmDaiNgayL;
        private double _F_ThaiSanL;
        private double _F_TNLDL;
        private double _F_NamL;
        private double _F_dbL;
        private double _F_KoLuongCLDL;
        private double _F_KoLuongKLDL;
        private double _F_DiDuongL;
        private double _F_CongTacL;
        private double _F_HocSAGSL;
        private double _F_Hoc1L;
        private double _F_Hoc2L;
        private double _F_Hoc3L;
        private double _F_Hoc4L;
        private double _F_Hoc5L;
        private double _F_Hoc6L;
        private double _F_Hoc7L;
        private double _F_Con_OmL;
        private double _F_KHHDSL;
        private double _F_SayThaiL;
        private double _F_KhamThaiL;
        private double _F_ConChetL;
        private double _F_DinhChiCongTacL;
        private double _F_TamHoanHDL;
        private double _F_HoiHopL;
        private double _F_LeL;
        private double _NghiTuanL;
        private double _NghiBuL;
        private double _NghiViecL;
        private double _ChuaDiLamL;

        #endregion

        private double _F_O_Co_KHHDS_TNLDL;
        private double _F_Nam_Fdb_DDL;
        private double _F_HocL;
        private double _F_KhacL;
        private double _NghiTuan_NghiBuL;

        private double _NightTimeL;
        private double _MarkL;
        private string _RankL;
        private DateTime _CreateDateL;
        private int _CreateUserL;
        private string _CreateUserNameL;
        private string _CreateFullNameL;
        private DateTime _LastUpdateL;
        private int _UpdateUserL;
        private string _UpdateUserNameL;
        private string _UpdateFullNameL;

        private string _RemarkL;
        private int _StatusL;

        private int _LeaveStatus;
        private DateTime _LeaveDate;

        #endregion

        #region properties

        public long WorkdayEmployeeIdL
        {
            get { return _WorkdayEmployeeIdL; }
            set { _WorkdayEmployeeIdL = value; }
        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public DateTime WorkdayDateL
        {
            get { return _WorkdayDateL; }
            set { _WorkdayDateL = value; }
        }
        public int TypeL
        {
            get { return _TypeL; }
            set { _TypeL = value; }
        }

        public string EmployeeCode
        {
            get { return _EmployeeCode; }
            set { _EmployeeCode = value; }
        }
        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
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
        public int DepartmentId
        {
            get { return _DepartmentId; }
            set { _DepartmentId = value; }
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
        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }

        #region TimeKeeping

        public string Day1L
        {
            get { return _Day1L; }
            set { _Day1L = value; }
        }
        public string Day2L
        {
            get { return _Day2L; }
            set { _Day2L = value; }
        }
        public string Day3L
        {
            get { return _Day3L; }
            set { _Day3L = value; }
        }
        public string Day4L
        {
            get { return _Day4L; }
            set { _Day4L = value; }
        }
        public string Day5L
        {
            get { return _Day5L; }
            set { _Day5L = value; }
        }
        public string Day6L
        {
            get { return _Day6L; }
            set { _Day6L = value; }
        }
        public string Day7L
        {
            get { return _Day7L; }
            set { _Day7L = value; }
        }
        public string Day8L
        {
            get { return _Day8L; }
            set { _Day8L = value; }
        }
        public string Day9L
        {
            get { return _Day9L; }
            set { _Day9L = value; }
        }
        public string Day10L
        {
            get { return _Day10L; }
            set { _Day10L = value; }
        }
        public string Day11L
        {
            get { return _Day11L; }
            set { _Day11L = value; }
        }
        public string Day12L
        {
            get { return _Day12L; }
            set { _Day12L = value; }
        }
        public string Day13L
        {
            get { return _Day13L; }
            set { _Day13L = value; }
        }
        public string Day14L
        {
            get { return _Day14L; }
            set { _Day14L = value; }
        }
        public string Day15L
        {
            get { return _Day15L; }
            set { _Day15L = value; }
        }
        public string Day16L
        {
            get { return _Day16L; }
            set { _Day16L = value; }
        }
        public string Day17L
        {
            get { return _Day17L; }
            set { _Day17L = value; }
        }
        public string Day18L
        {
            get { return _Day18L; }
            set { _Day18L = value; }
        }
        public string Day19L
        {
            get { return _Day19L; }
            set { _Day19L = value; }
        }
        public string Day20L
        {
            get { return _Day20L; }
            set { _Day20L = value; }
        }
        public string Day21L
        {
            get { return _Day21L; }
            set { _Day21L = value; }
        }
        public string Day22L
        {
            get { return _Day22L; }
            set { _Day22L = value; }
        }
        public string Day23L
        {
            get { return _Day23L; }
            set { _Day23L = value; }
        }
        public string Day24L
        {
            get { return _Day24L; }
            set { _Day24L = value; }
        }
        public string Day25L
        {
            get { return _Day25L; }
            set { _Day25L = value; }
        }
        public string Day26L
        {
            get { return _Day26L; }
            set { _Day26L = value; }
        }
        public string Day27L
        {
            get { return _Day27L; }
            set { _Day27L = value; }
        }
        public string Day28L
        {
            get { return _Day28L; }
            set { _Day28L = value; }
        }
        public string Day29L
        {
            get { return _Day29L; }
            set { _Day29L = value; }
        }
        public string Day30L
        {
            get { return _Day30L; }
            set { _Day30L = value; }
        }
        public string Day31L
        {
            get { return _Day31L; }
            set { _Day31L = value; }
        }

        #endregion

        #region To Collect WorkdayEmplyee

        public double XQDL
        {
            get { return _XQDL; }
            set { _XQDL = value; }
        }
        public double XL
        {
            get { return _XL; }
            set { _XL = value; }
        }
        public double F_OmL
        {
            get { return _F_OmL; }
            set { _F_OmL = value; }
        }
        public double F_OmDaiNgayL
        {
            get { return _F_OmDaiNgayL; }
            set { _F_OmDaiNgayL = value; }
        }
        public double F_ThaiSanL
        {
            get { return _F_ThaiSanL; }
            set { _F_ThaiSanL = value; }
        }
        public double F_TNLDL
        {
            get { return _F_TNLDL; }
            set { _F_TNLDL = value; }
        }
        public double F_NamL
        {
            get { return _F_NamL; }
            set { _F_NamL = value; }
        }
        public double F_dbL
        {
            get { return _F_dbL; }
            set { _F_dbL = value; }
        }
        public double F_KoLuongCLDL
        {
            get { return _F_KoLuongCLDL; }
            set { _F_KoLuongCLDL = value; }
        }
        public double F_KoLuongKLDL
        {
            get { return _F_KoLuongKLDL; }
            set { _F_KoLuongKLDL = value; }
        }
        public double F_DiDuongL
        {
            get { return _F_DiDuongL; }
            set { _F_DiDuongL = value; }
        }
        public double F_CongTacL
        {
            get { return _F_CongTacL; }
            set { _F_CongTacL = value; }
        }
        public double F_HocSAGSL
        {
            get { return _F_HocSAGSL; }
            set { _F_HocSAGSL = value; }
        }
        public double F_Hoc1L
        {
            get { return _F_Hoc1L; }
            set { _F_Hoc1L = value; }
        }
        public double F_Hoc2L
        {
            get { return _F_Hoc2L; }
            set { _F_Hoc2L = value; }
        }
        public double F_Hoc3L
        {
            get { return _F_Hoc3L; }
            set { _F_Hoc3L = value; }
        }
        public double F_Hoc4L
        {
            get { return _F_Hoc4L; }
            set { _F_Hoc4L = value; }
        }
        public double F_Hoc5L
        {
            get { return _F_Hoc5L; }
            set { _F_Hoc5L = value; }
        }
        public double F_Hoc6L
        {
            get { return _F_Hoc6L; }
            set { _F_Hoc6L = value; }
        }
        public double F_Hoc7L
        {
            get { return _F_Hoc7L; }
            set { _F_Hoc7L = value; }
        }
        public double F_Con_OmL
        {
            get { return _F_Con_OmL; }
            set { _F_Con_OmL = value; }
        }
        public double F_KHHDSL
        {
            get { return _F_KHHDSL; }
            set { _F_KHHDSL = value; }
        }
        public double F_SayThaiL
        {
            get { return _F_SayThaiL; }
            set { _F_SayThaiL = value; }
        }
        public double F_KhamThaiL
        {
            get { return _F_KhamThaiL; }
            set { _F_KhamThaiL = value; }
        }
        public double F_ConChetL
        {
            get { return _F_ConChetL; }
            set { _F_ConChetL = value; }
        }
        public double F_DinhChiCongTacL
        {
            get { return _F_DinhChiCongTacL; }
            set { _F_DinhChiCongTacL = value; }
        }
        public double F_TamHoanHDL
        {
            get { return _F_TamHoanHDL; }
            set { _F_TamHoanHDL = value; }
        }
        public double F_HoiHopL
        {
            get { return _F_HoiHopL; }
            set { _F_HoiHopL = value; }
        }
        public double F_LeL
        {
            get { return _F_LeL; }
            set { _F_LeL = value; }
        }
        public double NghiTuanL
        {
            get { return _NghiTuanL; }
            set { _NghiTuanL = value; }
        }
        public double NghiBuL
        {
            get { return _NghiBuL; }
            set { _NghiBuL = value; }
        }
        public double NghiViecL
        {
            get { return _NghiViecL; }
            set { _NghiViecL = value; }
        }

        public double ChuaDiLamL
        {
            get { return _ChuaDiLamL; }
            set { _ChuaDiLamL = value; }
        }

        public int LeaveStatus
        {
            get { return _LeaveStatus; }
            set { _LeaveStatus = value; }
        }
        public DateTime LeaveDate
        {
            get { return _LeaveDate; }
            set { _LeaveDate = value; }
        }

        #endregion

        public double F_O_Co_KHHDS_TNLDL
        {
            get { return _F_O_Co_KHHDS_TNLDL; }
            set { _F_O_Co_KHHDS_TNLDL = value; }
        }
        public double F_Nam_Fdb_DDL
        {
            get { return _F_Nam_Fdb_DDL; }
            set { _F_Nam_Fdb_DDL = value; }
        }
        public double F_HocL
        {
            get { return _F_HocL; }
            set { _F_HocL = value; }
        }
        public double F_KhacL
        {
            get { return _F_KhacL; }
            set { _F_KhacL = value; }
        }
        public double NghiTuan_NghiBuL
        {
            get { return _NghiTuan_NghiBuL; }
            set { _NghiTuan_NghiBuL = value; }
        }

        public double NightTimeL
        {
            get { return _NightTimeL; }
            set { _NightTimeL = value; }
        }
        public double MarkL
        {
            get { return _MarkL; }
            set { _MarkL = value; }
        }
        public string RankL
        {
            get { return _RankL; }
            set { _RankL = value; }
        }
        public DateTime CreateDateL
        {
            get { return _CreateDateL; }
            set { _CreateDateL = value; }
        }
        public int CreateUserL
        {
            get { return _CreateUserL; }
            set { _CreateUserL = value; }
        }
        public string CreateUserNameL
        {
            get { return _CreateUserNameL; }
            set { _CreateUserNameL = value; }
        }
        public string CreateFullNameL
        {
            get { return _CreateFullNameL; }
            set { _CreateFullNameL = value; }
        }
        public DateTime LastUpdateL
        {
            get { return _LastUpdateL; }
            set { _LastUpdateL = value; }
        }
        public int UpdateUserL
        {
            get { return _UpdateUserL; }
            set { _UpdateUserL = value; }
        }
        public string UpdateUserNameL
        {
            get { return _UpdateUserNameL; }
            set { _UpdateUserNameL = value; }
        }
        public string UpdateFullNameL
        {
            get { return _UpdateFullNameL; }
            set { _UpdateFullNameL = value; }
        }

        public string RemarkL
        {
            get { return _RemarkL; }
            set { _RemarkL = value; }
        }

        public int StatusL
        {
            get { return _StatusL; }
            set { _StatusL = value; }
        }

        #endregion

        #region public methods insert, update, delete

        public static long InsertByDate_DeptId(string deptIds, DateTime workdayDateL, int createUserL, bool isOfficeHours, int statusL)
        {
            
            int dayInMonth = DateTime.DaysInMonth(workdayDateL.Year, workdayDateL.Month);
            string day25L = null; string day26L = null; string day27L = null; string day28L = null; string day29L = null; string day30L = null; string day31L = null;
            if (dayInMonth == 25)
            {
                day25L = "X";
            }
            else if (dayInMonth == 26)
            {
                day25L = "X";
                day26L = "X";
            }
            else if (dayInMonth == 27)
            {
                day25L = "X";
                day26L = "X";
                day27L = "X";
            }
            else if (dayInMonth == 28)
            {
                day25L = "X";
                day26L = "X";
                day27L = "X";
                day28L = "X";
            }
            else if (dayInMonth == 29)
            {
                day25L = "X";
                day26L = "X";
                day27L = "X";
                day28L = "X";
                day29L = "X";
            }
            else if (dayInMonth == 30)
            {
                day25L = "X";
                day26L = "X";
                day27L = "X";
                day28L = "X";
                day29L = "X";
                day30L = "X";
            }
            else
            {
                day25L = "X";
                day26L = "X";
                day27L = "X";
                day28L = "X";
                day29L = "X";
                day30L = "X";
                day31L = "X";
            }
            double XQDL = DefaultValues.XQDSalary(workdayDateL.Month, workdayDateL.Year);
            int typeL = 1;
            if (!isOfficeHours)
            {
                typeL = 0;
            }


            new WorkdayEmployeesDALL().InsertByDate_DeptId(day25L, day26L, day27L, day28L, day29L, day30L, day31L, deptIds, workdayDateL, createUserL, XQDL, XQDL, typeL, statusL);

            List<WorkdayEmployeesBLLL> listW = WorkdayEmployeesBLLL.GetByFilter(string.Empty, deptIds, workdayDateL.Month, workdayDateL.Year, 1);

            foreach (WorkdayEmployeesBLLL objWE in listW)
            {
                if (isOfficeHours)
                {
                    UpdateWorkdayEmployeeByOfficeHours(objWE);
                }
                else
                {
                    double x = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_X);

                    objWE.XL = x;
                    objWE.UpdateByDate_UserId();
                }

                //UpdateWorkdayEmployeeByHoliday(objWE);
            }

            return 0;
        }

        public static long InsertByDate_UserId(int userId, DateTime workdayDateL, int createUserL, bool isOfficeHours, int statusL)
        {

            int daysInMonth = DateTime.DaysInMonth(workdayDateL.Year, workdayDateL.Month);
            string day25L = null; string day26L = null; string day27L = null; string day28L = null; string day29L = null; string day30L = null; string day31L = null;
            if (daysInMonth == 25)
            {
                day25L = "X";
            }
            else if (daysInMonth == 26)
            {
                day25L = "X";
                day26L = "X";
            }
            else if (daysInMonth == 27)
            {
                day25L = "X";
                day26L = "X";
                day27L = "X";
            }
            else if (daysInMonth == 28)
            {
                day25L = "X";
                day26L = "X";
                day27L = "X";
                day28L = "X";
            }
            else if (daysInMonth == 29)
            {
                day25L = "X";
                day26L = "X";
                day27L = "X";
                day28L = "X";
                day29L = "X";
            }
            else if (daysInMonth == 30)
            {
                day25L = "X";
                day26L = "X";
                day27L = "X";
                day28L = "X";
                day29L = "X";
                day30L = "X";
            }
            else
            {
                day25L = "X";
                day26L = "X";
                day27L = "X";
                day28L = "X";
                day29L = "X";
                day30L = "X";
                day31L = "X";
            }
            double XQDL = DefaultValues.XQDSalary(workdayDateL.Month, workdayDateL.Year);
            int typeL = 1;
            if (!isOfficeHours)
            {
                typeL = 0;
            }

            return new WorkdayEmployeesDALL().InsertByDate_UserId(userId, workdayDateL, day25L, day26L, day27L, day28L, day29L, day30L, day31L, createUserL, XQDL, XQDL, typeL, statusL);

        }

        public static long UpdateByDate_UserId(
                    int userId,
                    DateTime workdayDate,

                    string day1L, string day2L, string day3L, string day4L, string day5L, string day6L, string day7L, string day8L, string day9L, string day10L,
                    string day11L, string day12L, string day13L, string day14L, string day15L, string day16L, string day17L, string day18L, string day19L, string day20L,
                    string day21L, string day22L, string day23L, string day24L, string day25L, string day26L, string day27L, string day28L, string day29L, string day30L, string day31L,
                    double XL,
                    double f_OmL, double f_OmDaiNgayL, double f_ThaiSanL, double f_TNLDL, double f_NamL,
                    double f_dbL, double f_KoLuongCLDL, double f_KoLuongKLDL, double f_DiDuongL, double f_CongTacL,
                    double f_HocSAGS, double f_Hoc1L, double f_Hoc2L, double f_Hoc3L, double f_Hoc4L, double f_Hoc5L, double f_Hoc6L, double f_Hoc7L,
                    double f_Con_OmL, double f_KHHDSL, double f_SayThaiL, double f_KhamThaiL, double f_ConChetL, double f_DinhChiCongTacL,
                    double f_TamHoanHDL, double f_HoiHopL, double f_LeL, double nghiTuanL, double nghiBuL, double nghiViecL, double chuaDiLamL,
                    double nightTimeL, double markL, string rankL, DateTime lastUpdateL, double updateUserL, string remarkL
            )
        {
            return new WorkdayEmployeesDALL().UpdateByDate_UserId(
                    userId, workdayDate,

                    day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L,
                    day11L, day12L, day13L, day14L, day15L, day16L, day17L, day18L, day19L, day20L,
                    day21L, day22L, day23L, day24L, day25L, day26L, day27L, day28L, day29L, day30L, day31L,
                    XL,
                    f_OmL, f_OmDaiNgayL, f_ThaiSanL, f_TNLDL, f_NamL,
                    f_dbL, f_KoLuongCLDL, f_KoLuongKLDL, f_DiDuongL, f_CongTacL,
                    f_HocSAGS, f_Hoc1L, f_Hoc2L, f_Hoc3L, f_Hoc4L, f_Hoc5L, f_Hoc6L, f_Hoc7L,
                    f_Con_OmL, f_KHHDSL, f_SayThaiL, f_KhamThaiL, f_ConChetL, f_DinhChiCongTacL,
                    f_TamHoanHDL, f_HoiHopL, f_LeL, nghiTuanL, nghiBuL, nghiViecL, chuaDiLamL,
                    nightTimeL, markL, rankL, lastUpdateL, updateUserL, remarkL
                    );
        }

        public long UpdateByDate_UserId()
        {
            return UpdateByDate_UserId(UserId, WorkdayDateL,
                    Day1L, Day2L, Day3L, Day4L, Day5L, Day6L, Day7L, Day8L, Day9L, Day10L,
                    Day11L, Day12L, Day13L, Day14L, Day15L, Day16L, Day17L, Day18L, Day19L, Day20L,
                    Day21L, Day22L, Day23L, Day24L, Day25L, Day26L, Day27L, Day28L, Day29L, Day30L, Day31L,                    
                    MarkL,NightTimeL, LastUpdateL, UpdateUserL, RemarkL);
        }

        public static long UpdateByDate_UserId(
                    int userId,
                    DateTime workdayDate,
                    string day1L, string day2L, string day3L, string day4L, string day5L, string day6L, string day7L, string day8L, string day9L, string day10L,
                    string day11L, string day12L, string day13L, string day14L, string day15L, string day16L, string day17L, string day18L, string day19L, string day20L,
                    string day21L, string day22L, string day23L, string day24L, string day25L, string day26L, string day27L, string day28L, string day29L, string day30L, string day31L,
                    double mark, double nightTime, DateTime lastUpdateL, double updateUserL, string remarkL
            )
        {

            double XL = Constants.WorkdayEmployee_DefaultValue, f_OmL = Constants.WorkdayEmployee_DefaultValue, f_OmDaiNgayL = Constants.WorkdayEmployee_DefaultValue;
            double f_ThaiSanL = Constants.WorkdayEmployee_DefaultValue, f_TNLDL = Constants.WorkdayEmployee_DefaultValue, f_NamL = Constants.WorkdayEmployee_DefaultValue;
            double f_dbL = Constants.WorkdayEmployee_DefaultValue, f_KoLuongCLDL = Constants.WorkdayEmployee_DefaultValue, f_KoLuongKLDL = Constants.WorkdayEmployee_DefaultValue;
            double f_DiDuongL = Constants.WorkdayEmployee_DefaultValue, f_CongTacL = Constants.WorkdayEmployee_DefaultValue;

            double f_HocSAGSL = Constants.WorkdayEmployee_DefaultValue, f_Hoc1L = Constants.WorkdayEmployee_DefaultValue, f_Hoc2L = Constants.WorkdayEmployee_DefaultValue, f_Hoc3L = Constants.WorkdayEmployee_DefaultValue;
            double f_Hoc4L = Constants.WorkdayEmployee_DefaultValue, f_Hoc5L = Constants.WorkdayEmployee_DefaultValue, f_Hoc6L = Constants.WorkdayEmployee_DefaultValue;
            double f_Hoc7L = Constants.WorkdayEmployee_DefaultValue;

            double f_Con_OmL = Constants.WorkdayEmployee_DefaultValue, f_KHHDSL = Constants.WorkdayEmployee_DefaultValue;
            double f_SayThaiL = Constants.WorkdayEmployee_DefaultValue, f_KhamThaiL = Constants.WorkdayEmployee_DefaultValue, f_ConChetL = Constants.WorkdayEmployee_DefaultValue;
            double f_DinhChiCongTacL = Constants.WorkdayEmployee_DefaultValue, f_TamHoanHDL = Constants.WorkdayEmployee_DefaultValue, f_HoiHopL = Constants.WorkdayEmployee_DefaultValue;
            double f_LeL = Constants.WorkdayEmployee_DefaultValue, nghiTuanL = Constants.WorkdayEmployee_DefaultValue, nghiBuL = Constants.WorkdayEmployee_DefaultValue;
            double nghiViecL = Constants.WorkdayEmployee_DefaultValue;
            double chuaDiLamL = Constants.WorkdayEmployee_DefaultValue;


            f_OmL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_O_BAN_THAN);

            f_OmDaiNgayL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_O_DAI_NGAY);

            f_ThaiSanL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_THAI_SAN);

            f_TNLDL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_TNLD);

            f_NamL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_F_NAM);

            f_dbL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_FDB);

            f_KoLuongCLDL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_NGHI_KO_LUONG_CO_LYDO);

            f_KoLuongKLDL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_NGHI_KO_LUONG_KO_LYDO);

            f_DiDuongL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_F_DI_DUONG);

            f_CongTacL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_F_CONG_TAC);

            f_HocSAGSL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_HOC_SAGS);
            f_Hoc1L = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_HOC_1);
            f_Hoc2L = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_HOC_2);
            f_Hoc3L = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_HOC_3);
            f_Hoc4L = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_HOC_4);
            f_Hoc5L = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_HOC_5);
            f_Hoc6L = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_HOC_6);
            f_Hoc7L = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_HOC_7);
            f_Con_OmL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_CON_OM);
            f_KHHDSL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_KHHDS);
            f_SayThaiL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_SAY_THAI);
            f_KhamThaiL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_KHAM_THAI);
            f_ConChetL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_CON_CHET_SAU_KHI_SINH);
            f_DinhChiCongTacL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_DINH_CHI_CONG_TAC);
            f_TamHoanHDL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_TAM_HOAN_HOP_DONG);
            f_HoiHopL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_HOI_HOP);

            f_LeL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_LE_TET);

            nghiTuanL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_NGHI_TUAN);

            nghiBuL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_NGHI_BU);

            nghiViecL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_NGHI_VIEC);

            chuaDiLamL = DefaultValues.CalculateLeaveDayL(workdayDate.Month, workdayDate.Year, userId, day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L, Constants.LEAVE_TYPE_CHUA_DI_LAM);

            double hoc = f_HocSAGSL + f_Hoc1L + f_Hoc2L + f_Hoc3L+ f_Hoc4L+ f_Hoc5L+ f_Hoc6L+ f_Hoc7L;
            double om = f_OmL + f_OmDaiNgayL + f_Con_OmL;
            double thaisan = f_ThaiSanL + f_SayThaiL + f_KhamThaiL + f_ConChetL + f_KHHDSL;
            double phep = f_NamL + f_dbL + f_TNLDL + f_HoiHopL + f_CongTacL + f_DiDuongL;
            double khac = f_KoLuongCLDL + f_KoLuongKLDL + f_DinhChiCongTacL + f_TamHoanHDL + chuaDiLamL + nghiViecL;

            double totalLeave = hoc + om + thaisan + phep + khac;
            double XQDL = DefaultValues.XQDSalary(workdayDate.Month, workdayDate.Year);

            int daysInNow = DateTime.DaysInMonth(workdayDate.Year, workdayDate.Month);

            XL = daysInNow - (nghiTuanL + totalLeave);

            string hTCV = DefaultValues.HTCV(mark); 

            return UpdateByDate_UserId(userId, workdayDate,
                    day1L, day2L, day3L, day4L, day5L, day6L, day7L, day8L, day9L, day10L, day11L, day12L, day13L,
                   day14L, day15L, day16L, day17L, day18L, day19L, day20L, day21L, day22L, day23L, day24L, day25L, day26L,
                   day27L, day28L, day29L, day30L, day31L,

                    XL, f_OmL, f_OmDaiNgayL, f_ThaiSanL, f_TNLDL, f_NamL, f_dbL, f_KoLuongCLDL,
                    f_KoLuongKLDL, f_DiDuongL, f_CongTacL, f_HocSAGSL, f_Hoc1L, f_Hoc2L, f_Hoc3L, f_Hoc4L, f_Hoc5L, f_Hoc6L, f_Hoc7L, f_Con_OmL,
                    f_KHHDSL, f_SayThaiL, f_KhamThaiL, f_ConChetL, f_DinhChiCongTacL, f_TamHoanHDL, f_HoiHopL,
                    f_LeL, nghiTuanL, nghiBuL, nghiViecL, chuaDiLamL, nightTime, mark, hTCV, lastUpdateL, updateUserL, remarkL
                    );

        }

        public static void UpdateWorkdayByLeave(int userId, DateTime fromDate, DateTime toDate, int leaveTypeId, int status)
        {
            string symbolTimekeeping = Constants.GetSymbolTimekeeping(leaveTypeId);
            WorkdayEmployeesBLLL objWE = WorkdayEmployeesBLLL.GetByUserId_Month_Year(userId, fromDate.Month, fromDate.Year, status);

            if (objWE != null)
            {
                DateTime dateTemp = fromDate;

                #region while
                while (dateTemp.CompareTo(toDate) <= 0)
                {
                    switch (dateTemp.Day)
                    {
                        case 1:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day1L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day1L = symbolTimekeeping;
                            }
                            break;
                        case 2:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day2L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day2L = symbolTimekeeping;
                            }
                            break;
                        case 3:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day3L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day3L = symbolTimekeeping;
                            }
                            break;
                        case 4:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day4L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day4L = symbolTimekeeping;
                            }
                            break;
                        case 5:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day5L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day5L = symbolTimekeeping;
                            }
                            break;
                        case 6:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day6L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day6L = symbolTimekeeping;
                            }
                            break;
                        case 7:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day7L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day7L = symbolTimekeeping;
                            }
                            break;
                        case 8:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day8L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day8L = symbolTimekeeping;
                            }
                            break;
                        case 9:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day9L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day9L = symbolTimekeeping;
                            }
                            break;
                        case 10:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day10L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day10L = symbolTimekeeping;
                            }
                            break;
                        case 11:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day11L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day11L = symbolTimekeeping;
                            }
                            break;
                        case 12:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day12L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day12L = symbolTimekeeping;
                            }
                            break;
                        case 13:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day13L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day13L = symbolTimekeeping;
                            }
                            break;
                        case 14:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day14L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day14L = symbolTimekeeping;
                            }
                            break;
                        case 15:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day15L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day15L = symbolTimekeeping;
                            }
                            break;
                        case 16:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day16L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day16L = symbolTimekeeping;
                            }
                            break;
                        case 17:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day17L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day17L = symbolTimekeeping;
                            }
                            break;
                        case 18:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day18L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day18L = symbolTimekeeping;
                            }
                            break;
                        case 19:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day19L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day19L = symbolTimekeeping;
                            }
                            break;
                        case 20:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day20L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day20L = symbolTimekeeping;
                            }
                            break;
                        case 21:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day21L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day21L = symbolTimekeeping;
                            }
                            break;
                        case 22:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day22L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day22L = symbolTimekeeping;
                            }
                            break;
                        case 23:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day23L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day23L = symbolTimekeeping;
                            }
                            break;
                        case 24:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day24L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day24L = symbolTimekeeping;
                            }
                            break;
                        case 25:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day25L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day25L = symbolTimekeeping;
                            }
                            break;
                        case 26:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day26L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day26L = symbolTimekeeping;
                            }
                            break;
                        case 27:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day27L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day27L = symbolTimekeeping;
                            }
                            break;
                        case 28:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day28L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day28L = symbolTimekeeping;
                            }
                            break;
                        case 29:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day29L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day29L = symbolTimekeeping;
                            }
                            break;
                        case 30:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day30L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day30L = symbolTimekeeping;
                            }
                            break;
                        case 31:
                            if (dateTemp.DayOfWeek == DayOfWeek.Sunday)
                            {
                                objWE.Day31L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            }
                            else
                            {
                                objWE.Day31L = symbolTimekeeping;
                            }
                            break;
                    }
                    dateTemp = dateTemp.AddDays(1);
                }
                #endregion

                ////////////////////////////////////////////////
                //objWE.F_OmL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_O_BAN_THAN);

                //objWE.F_OmDaiNgayL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_O_DAI_NGAY);

                //objWE.F_ThaiSanL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_THAI_SAN);

                //objWE.F_TNLDL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_TNLD);

                //objWE.F_NamL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_F_NAM);

                //objWE.F_dbL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_FDB);

                //objWE.F_KoLuongCLDL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_NGHI_KO_LUONG_CO_LYDO);

                //objWE.F_KoLuongKLDL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_NGHI_KO_LUONG_KO_LYDO);

                //objWE.F_DiDuongL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_F_DI_DUONG);

                //objWE.F_CongTacL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_F_CONG_TAC);

                //objWE.F_Hoc1L = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_HOC_1);
                //objWE.F_Hoc2L = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_HOC_2);
                //objWE.F_Hoc3L = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_HOC_3);
                //objWE.F_Hoc4L = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_HOC_4);
                //objWE.F_Hoc5L = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_HOC_5);
                //objWE.F_Hoc6L = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_HOC_6);
                //objWE.F_Hoc7L = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_HOC_7);

                //objWE.F_Con_OmL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_CON_OM);

                //objWE.F_KHHDSL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_KHHDS);

                //objWE.F_SayThaiL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_SAY_THAI);

                //objWE.F_KhamThaiL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_KHAM_THAI);

                //objWE.F_ConChetL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_CON_CHET_SAU_KHI_SINH);

                //objWE.F_DinhChiCongTacL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_DINH_CHI_CONG_TAC);

                //objWE.F_TamHoanHDL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_TAM_HOAN_HOP_DONG);

                //objWE.F_HoiHopL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_HOI_HOP);

                //objWE.F_LeL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_LE_TET);

                //objWE.NghiTuanL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_NGHI_TUAN);

                //objWE.NghiBuL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_NGHI_BU);

                //objWE.NghiViecL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_NGHI_VIEC);

                //objWE.XL = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
                //    objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
                //    objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_X);               

                objWE.UpdateByDate_UserId();
                ///////////////////////////////////////////////
            }
        }

        public static long Update_By_MarkHTCV(int userId, double markL, DateTime lastUpdateL, int updateUserL, int monthL, int yearL, string remarkL)
        {
            return new WorkdayEmployeesDALL().Update_By_MarkHTCV(userId, markL, lastUpdateL, updateUserL, monthL, yearL, remarkL);
        }

        public static long DeleteByDeptIdsDate(string deptIds, int month, int year)
        {
            return new WorkdayEmployeesDALL().DeleteByDeptIdsDate(deptIds, month, year);
        }


        #endregion

        #region public methods GET

        public static List<WorkdayEmployeesBLLL> GetByFilter(string fullName, string departmentIds, int month, int year, int typeSort)
        {
            return GenerateListWorkdayEmployeesBLLLFromDataTable(new WorkdayEmployeesDALL().GetByFilter(fullName, departmentIds, month, year, typeSort));
        }

        public static WorkdayEmployeesBLLL GetById(long workdayEmployeeIdL)
        {
            List<WorkdayEmployeesBLLL> list = GenerateListWorkdayEmployeesBLLLFromDataTable(new WorkdayEmployeesDALL().GetById(workdayEmployeeIdL));

            if (list.Count > 0)
                return list[0];
            else
                return null;
        }
      

        public static WorkdayEmployeesBLLL GetByUserId_Month_Year(int userId, int month, int year, int statusL)
        {
            List<WorkdayEmployeesBLLL> list = GenerateListWorkdayEmployeesBLLLFromDataTable(new WorkdayEmployeesDALL().GetByUserId_Month_Year(userId, month, year, statusL));

            if (list.Count > 0)
                return list[0];
            else
                return null;
        }

        public static List<WorkdayEmployeesBLLL> GetByRoot(int rootId, int month, int year)
        {
            return GenerateListWorkdayEmployeesBLLLFromDataTable(new WorkdayEmployeesDALL().GetByRootId(rootId, month, year));
        }

        #endregion

        #region private methods
        

        private static List<WorkdayEmployeesBLLL> GenerateListWorkdayEmployeesBLLLFromDataTable(DataTable dt)
        {
            List<WorkdayEmployeesBLLL> list = new List<WorkdayEmployeesBLLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateWorkdayEmployeesBLLLFromDataRow(dr));
            }

            return list;
        }

        private static WorkdayEmployeesBLLL GenerateWorkdayEmployeesBLLLFromDataRow(DataRow dr)
        {

            WorkdayEmployeesBLLL objBLL = new WorkdayEmployeesBLLL();

            objBLL._WorkdayEmployeeIdL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_IDL] == DBNull.Value ? 0 : int.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_IDL].ToString());
            objBLL._UserId = dr[EmployeeKeys.FIELD_EMPLOYEES_USERID] == DBNull.Value ? 0 : int.Parse(dr[EmployeeKeys.FIELD_EMPLOYEES_USERID].ToString());
            objBLL._WorkdayDateL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_WorkdayDateL] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_WorkdayDateL].ToString());

            try
            {
                objBLL._EmployeeCode = dr[EmployeeKeys.FIELD_EMPLOYEES_EMPLOYEE_CODE] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_EMPLOYEE_CODE].ToString();
            }
            catch { }
            objBLL._FullName = dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME].ToString();            
            objBLL._DepartmentId = dr[DepartmentKeys.FIELD_DEPARTMENT_ID] == DBNull.Value ? 0 : int.Parse(dr[DepartmentKeys.FIELD_DEPARTMENT_ID].ToString());
            objBLL._DepartmentName = dr[DepartmentKeys.FIELD_DEPARTMENT_NAME] == DBNull.Value ? string.Empty : dr[DepartmentKeys.FIELD_DEPARTMENT_NAME].ToString();
            objBLL._DepartmentFullName = dr[DepartmentKeys.Field_Department_DepartmentFullName] == DBNull.Value ? string.Empty : dr[DepartmentKeys.Field_Department_DepartmentFullName].ToString();
            objBLL._RootId = dr[DepartmentKeys.FIELD_DEPARTMENT_ROOT_ID] == DBNull.Value ? 0 : int.Parse(dr[DepartmentKeys.FIELD_DEPARTMENT_ROOT_ID].ToString());
            try
            {
                objBLL._RootName = dr[DepartmentKeys.Field_Department_RootName] == DBNull.Value ? string.Empty : dr[DepartmentKeys.Field_Department_RootName].ToString();
            }
            catch { }
            try
            {
                objBLL._PositionName = dr[PositionKeys.FIELD_POSITION_NAME] == DBNull.Value ? string.Empty : dr[PositionKeys.FIELD_POSITION_NAME].ToString();
            }
            catch { }

            #region TimeKeeping

            objBLL._Day1L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day1L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day1L].ToString();
            objBLL._Day2L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day2L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day2L].ToString();
            objBLL._Day3L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day3L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day3L].ToString();
            objBLL._Day4L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day4L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day4L].ToString();
            objBLL._Day5L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day5L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day5L].ToString();
            objBLL._Day6L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day6L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day6L].ToString();
            objBLL._Day7L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day7L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day7L].ToString();
            objBLL._Day8L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day8L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day8L].ToString();
            objBLL._Day9L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day9L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day9L].ToString();
            objBLL._Day10L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day10L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day10L].ToString();
            objBLL._Day11L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day11L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day11L].ToString();
            objBLL._Day12L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day12L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day12L].ToString();
            objBLL._Day13L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day13L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day13L].ToString();
            objBLL._Day14L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day14L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day14L].ToString();
            objBLL._Day15L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day15L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day15L].ToString();
            objBLL._Day16L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day16L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day16L].ToString();
            objBLL._Day17L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day17L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day17L].ToString();
            objBLL._Day18L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day18L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day18L].ToString();
            objBLL._Day19L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day19L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day19L].ToString();
            objBLL._Day20L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day20L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day20L].ToString();
            objBLL._Day21L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day21L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day21L].ToString();
            objBLL._Day22L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day22L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day22L].ToString();
            objBLL._Day23L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day23L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day23L].ToString();
            objBLL._Day24L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day24L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day24L].ToString();
            objBLL._Day25L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day25L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day25L].ToString();
            objBLL._Day26L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day26L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day26L].ToString();
            objBLL._Day27L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day27L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day27L].ToString();
            objBLL._Day28L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day28L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day28L].ToString();
            objBLL._Day29L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day29L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day29L].ToString();
            objBLL._Day30L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day30L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day30L].ToString();
            objBLL._Day31L = dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day31L] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_Workday_Employee_Day31L].ToString();


            #endregion            

            #region To Collect WorkdayEmplyee

            objBLL._XQDL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_XQDL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_XQDL].ToString());

            objBLL._XL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_XL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_XL].ToString());

            objBLL._F_OmL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_OmL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_OmL].ToString());
            objBLL._F_OmDaiNgayL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_OM_DaiNgayL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_OM_DaiNgayL].ToString());
            objBLL._F_ThaiSanL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_ThaiSanL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_ThaiSanL].ToString());
            objBLL._F_TNLDL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_TNLDL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_TNLDL].ToString());
            objBLL._F_NamL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_NamL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_NamL].ToString());            

            objBLL._F_dbL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_dbL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_dbL].ToString());
            objBLL._F_KoLuongCLDL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_KoLuongCLDL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_KoLuongCLDL].ToString());
            objBLL._F_KoLuongKLDL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_KoLuongKLDL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_KoLuongKLDL].ToString());
            objBLL._F_DiDuongL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_DiDuongL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_DiDuongL].ToString());            
            objBLL._F_CongTacL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_CongTacL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_CongTacL].ToString());

            objBLL._F_HocSAGSL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_HocSAGSL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_HocSAGSL].ToString());
            objBLL._F_Hoc1L = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Hoc1L] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Hoc1L].ToString());
            objBLL._F_Hoc2L = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Hoc2L] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Hoc2L].ToString());
            objBLL._F_Hoc3L = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Hoc3L] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Hoc3L].ToString());
            objBLL._F_Hoc4L = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Hoc4L] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Hoc4L].ToString());
            objBLL._F_Hoc5L = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Hoc5L] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Hoc5L].ToString());
            objBLL._F_Hoc6L = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Hoc6L] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Hoc6L].ToString());
            objBLL._F_Hoc7L = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Hoc7L] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Hoc7L].ToString());


            objBLL._F_Con_OmL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Con_OmL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_Con_OmL].ToString());
            objBLL._F_KHHDSL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_KHHDSL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_KHHDSL].ToString());
            objBLL._F_SayThaiL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_SayThaiL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_SayThaiL].ToString());
            objBLL._F_KhamThaiL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_KhamThaiL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_KhamThaiL].ToString());
            objBLL._F_ConChetL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_ConChetL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_ConChetL].ToString());
            objBLL._F_DinhChiCongTacL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_DinhChiCongTacL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_DinhChiCongTacL].ToString());

            objBLL._F_TamHoanHDL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_TamHoanHDL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_TamHoanHDL].ToString());
            objBLL._F_HoiHopL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_HoiHopL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_HoiHopL].ToString());
            objBLL._F_LeL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_LEL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_LEL].ToString());            
            objBLL._NghiTuanL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_NghiTuanL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_NghiTuanL].ToString());
            objBLL._NghiBuL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_NghiBuL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_NghiBuL].ToString());                                                
            objBLL._NghiViecL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_NghiViecL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_NghiViecL].ToString());
            objBLL._ChuaDiLamL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_ChuaDilam] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_F_ChuaDilam].ToString());

            #endregion


            objBLL._NightTimeL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_NightTimeL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_NightTimeL].ToString());
            objBLL._MarkL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_MarkL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_MarkL].ToString());
            objBLL._RankL = DefaultValues.HTCV(objBLL._MarkL);//dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_RankL] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_RankL].ToString();

            objBLL._CreateDateL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_CreateDateL] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_CreateDateL].ToString());
            objBLL._CreateUserL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_CreateUserL] == DBNull.Value ? 0 : int.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_CreateUserL].ToString());
            objBLL._CreateUserNameL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_CreateUserNameL] == DBNull.Value ? "" : dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_CreateUserNameL].ToString();
            objBLL._CreateFullNameL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_CreateFullNameL] == DBNull.Value ? "" : dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_CreateFullNameL].ToString();

            objBLL._LastUpdateL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_LastUpdateL] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_LastUpdateL].ToString());
            objBLL._UpdateUserL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_UpdateUserL] == DBNull.Value ? 0 : int.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_UpdateUserL].ToString());
            objBLL._UpdateUserNameL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_UpdateUserNameL] == DBNull.Value ? "" : dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_UpdateUserNameL].ToString();
            objBLL._UpdateFullNameL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_UpdateFullNameL] == DBNull.Value ? "" : dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_UpdateFullNameL].ToString();

            objBLL._TypeL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_TypeL] == DBNull.Value ? 0 : int.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_TypeL].ToString());


            objBLL._F_O_Co_KHHDS_TNLDL = objBLL._F_OmL + objBLL._F_Con_OmL + objBLL._F_KHHDSL + objBLL._F_TNLDL;
            objBLL._F_Nam_Fdb_DDL = objBLL._F_NamL + objBLL._F_dbL + objBLL._F_DiDuongL;
            objBLL._F_HocL = objBLL._F_HocSAGSL + objBLL._F_Hoc1L + objBLL._F_Hoc2L + objBLL._F_Hoc3L + objBLL._F_Hoc4L + objBLL._F_Hoc5L + objBLL._F_Hoc6L + objBLL._F_Hoc7L;
            objBLL._F_KhacL = objBLL._F_LeL + objBLL._F_KoLuongCLDL + objBLL._F_KoLuongKLDL + objBLL._ChuaDiLamL + objBLL._F_SayThaiL;

            objBLL._NghiTuan_NghiBuL = objBLL._NghiTuanL + objBLL._NghiBuL;

            objBLL._RemarkL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_RemarkL] == DBNull.Value ? string.Empty : dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_RemarkL].ToString();

            objBLL._StatusL = dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_StatusL] == DBNull.Value ? 0 : int.Parse(dr[WorkdayEmployeeLKeys.Field_WorkdayEmployee_StatusL].ToString());

            try
            {
                objBLL._LeaveStatus = dr["LeaveStatus"] == DBNull.Value ? 0 : int.Parse(dr["LeaveStatus"].ToString());
            }
            catch { }
            try
            {
                objBLL._LeaveDate = dr["LeaveDate"] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr["LeaveDate"].ToString());
            }
            catch { }


            return objBLL;
        }
        

        public static void UpdateWorkdayEmployeeByOfficeHours(WorkdayEmployeesBLLL objWE)
        {

            if (objWE != null)
            {
                DateTime dt;
                int daysInNow = DateTime.DaysInMonth(objWE.WorkdayDateL.Year, objWE.WorkdayDateL.Month);
                int i = 1;
                while (i <= daysInNow)
                {
                    dt = new DateTime(objWE.WorkdayDateL.Year, objWE.WorkdayDateL.Month, i);
                    switch (i)
                    {
                        case 1:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day1L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 2:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day2L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 3:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day3L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 4:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day4L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 5:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day5L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 6:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day6L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 7:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day7L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 8:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day8L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 9:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day9L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 10:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day10L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 11:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day11L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 12:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day12L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 13:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day13L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 14:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day14L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 15:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day15L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 16:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day16L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 17:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day17L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 18:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day18L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 19:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day19L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 20:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day20L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 21:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day21L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 22:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day22L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 23:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day23L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 24:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day24L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 25:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day25L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 26:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day26L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 27:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day27L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 28:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day28L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 29:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day29L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 30:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day30L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;
                        case 31:
                            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                                objWE.Day31L = Constants.LEAVE_TYPE_NGHI_TUAN_CODE;
                            break;

                    }

                    i++;
                }
                ////////////////////////////////////////////////                                           
                objWE.UpdateByDate_UserId();
                ///////////////////////////////////////////////
            }
        }

        private static void UpdateWorkdayEmployeeByHoliday(WorkdayEmployeesBLLL objWE)
        {

            if (objWE != null)
            {

                List<HolidaysBLL> listHoliday = HolidaysBLL.GetByDate(objWE.WorkdayDateL.Month, objWE.WorkdayDateL.Year);

                foreach (HolidaysBLL obj in listHoliday)
                {
                    switch (obj.HolidayDate.Day)
                    {
                        case 1:
                            objWE.Day1L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 2:
                            objWE.Day2L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 3:
                            objWE.Day3L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 4:
                            objWE.Day4L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 5:
                            objWE.Day5L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 6:
                            objWE.Day6L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 7:
                            objWE.Day7L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 8:
                            objWE.Day8L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 9:
                            objWE.Day9L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 10:
                            objWE.Day10L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 11:
                            objWE.Day11L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 12:
                            objWE.Day12L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 13:
                            objWE.Day13L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 14:
                            objWE.Day14L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 15:
                            objWE.Day15L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 16:
                            objWE.Day16L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 17:
                            objWE.Day17L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 18:
                            objWE.Day18L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 19:
                            objWE.Day19L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 20:
                            objWE.Day20L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 21:
                            objWE.Day21L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 22:
                            objWE.Day22L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 23:
                            objWE.Day23L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 24:
                            objWE.Day24L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 25:
                            objWE.Day25L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 26:
                            objWE.Day26L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 27:
                            objWE.Day27L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 28:
                            objWE.Day28L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 29:
                            objWE.Day29L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 30:
                            objWE.Day30L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;
                        case 31:
                            objWE.Day31L = Constants.LEAVE_TYPE_LE_TET_CODE;
                            break;

                    }
                }
               
                objWE.UpdateByDate_UserId();
                ///////////////////////////////////////////////
            }
        }



        #endregion
    }
}
