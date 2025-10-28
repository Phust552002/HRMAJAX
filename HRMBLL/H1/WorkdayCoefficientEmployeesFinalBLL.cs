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
using HRMBLL.H;

namespace HRMBLL.H1
{
    public class WorkdayCoefficientEmployeesFinalBLL
    {

        #region private fields
        private long _WorkdayEmployeeIdFinal;
        private int _UserId;
        System.DateTime _DataDate;
        private string _Day1;
        private string _Day2;
        private string _Day3;
        private string _Day4;
        private string _Day5;
        private string _Day6;
        private string _Day7;
        private string _Day8;
        private string _Day9;
        private string _Day10;
        private string _Day11;
        private string _Day12;
        private string _Day13;
        private string _Day14;
        private string _Day15;
        private string _Day16;
        private string _Day17;
        private string _Day18;
        private string _Day19;
        private string _Day20;
        private string _Day21;
        private string _Day22;
        private string _Day23;
        private string _Day24;
        private string _Day25;
        private string _Day26;
        private string _Day27;
        private string _Day28;
        private string _Day29;
        private string _Day30;
        private string _Day31;

        private double _NCQD;
        private double _NCDC;
        private double _X;
        private double _OmDNBHXH;
        private double _Om;
        private double _OmDN;
        private double _KHH;
        private double _Co;
        private double _TS;
        private double _ST;
        private double _Khamthai;
        private double _TNLD;
        private double _F;
        private double _Diduong;
        private double _CTac;
        private double _Fdb;
        private double _H1;
        private double _H2;
        private double _H3;
        private double _H4;
        private double _H5;
        private double _H6;
        private double _H7;
        private double _DinhChiCT;
        private double _Ro;
        private double _Ko;
        private double _LamthemNTbngay;
        private double _LamthemCNbngay;
        private double _LamthemLTbngay;
        private double _LamthemNTbdem;
        private double _LamthemCNbdem;
        private double _LamthemLTbdem;
        private double _Lamdem;

        private double _HSLNS;
        private double _HSLNSPCTN;
        private double _HSLCB;
        private double _HSPCDH;
        private double _HSPCTN;
        private double _HSPCKV;
        private double _HSPCCV;
        private double _HSK;
        private double _DTNopThue;
        private double _NguoiPThuoc;

        private DateTime _CreateDate;
        private int _CreateUserId;
        private DateTime _UpdateDate;
        private int _UpdateUserId;
        private string _Remark;
        private double _NC;
        private double _BNN;
        private double _CC;
        private double _O1;
        #endregion

        #region properties

        public long WorkdayEmployeeIdFinal
        {
            get
            {
                return _WorkdayEmployeeIdFinal;
            }
            set
            {
                _WorkdayEmployeeIdFinal = value;
            }
        }



        public int UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                _UserId = value;
            }
        }



        public System.DateTime DataDate
        {
            get
            {
                return _DataDate;
            }
            set
            {
                _DataDate = value;
            }
        }



        public string Day1
        {
            get
            {
                return _Day1;
            }
            set
            {
                _Day1 = value;
            }
        }



        public string Day2
        {
            get
            {
                return _Day2;
            }
            set
            {
                _Day2 = value;
            }
        }



        public string Day3
        {
            get
            {
                return _Day3;
            }
            set
            {
                _Day3 = value;
            }
        }



        public string Day4
        {
            get
            {
                return _Day4;
            }
            set
            {
                _Day4 = value;
            }
        }



        public string Day5
        {
            get
            {
                return _Day5;
            }
            set
            {
                _Day5 = value;
            }
        }


        public string Day6
        {
            get
            {
                return _Day6;
            }
            set
            {
                _Day6 = value;
            }
        }

        public string Day7
        {
            get
            {
                return _Day7;
            }
            set
            {
                _Day7 = value;
            }
        }


        public string Day8
        {
            get
            {
                return _Day8;
            }
            set
            {
                _Day8 = value;
            }
        }

        public string Day9
        {
            get
            {
                return _Day9;
            }
            set
            {
                _Day9 = value;
            }
        }

        public string Day10
        {
            get
            {
                return _Day10;
            }
            set
            {
                _Day10 = value;
            }
        }


        public string Day11
        {
            get
            {
                return _Day11;
            }
            set
            {
                _Day11 = value;
            }
        }

        public string Day12
        {
            get
            {
                return _Day12;
            }
            set
            {
                _Day12 = value;
            }
        }

        public string Day13
        {
            get
            {
                return _Day13;
            }
            set
            {
                _Day13 = value;
            }
        }

        public string Day14
        {
            get
            {
                return _Day14;
            }
            set
            {
                _Day14 = value;
            }
        }

        public string Day15
        {
            get
            {
                return _Day15;
            }
            set
            {
                _Day15 = value;
            }
        }

        public string Day16
        {
            get
            {
                return _Day16;
            }
            set
            {
                _Day16 = value;
            }
        }

        public string Day17
        {
            get
            {
                return _Day17;
            }
            set
            {
                _Day17 = value;
            }
        }

        public string Day18
        {
            get
            {
                return _Day18;
            }
            set
            {
                _Day18 = value;
            }
        }

        public string Day19
        {
            get
            {
                return _Day19;
            }
            set
            {
                _Day19 = value;
            }
        }

        public string Day20
        {
            get
            {
                return _Day20;
            }
            set
            {
                _Day20 = value;
            }
        }

        public string Day21
        {
            get
            {
                return _Day21;
            }
            set
            {
                _Day21 = value;
            }
        }

        public string Day22
        {
            get
            {
                return _Day22;
            }
            set
            {
                _Day22 = value;
            }
        }



        public string Day23
        {
            get
            {
                return _Day23;
            }
            set
            {
                _Day23 = value;
            }
        }

        public string Day24
        {
            get
            {
                return _Day24;
            }
            set
            {
                _Day24 = value;
            }
        }


        public string Day25
        {
            get
            {
                return _Day25;
            }
            set
            {
                _Day25 = value;
            }
        }

        public string Day26
        {
            get
            {
                return _Day26;
            }
            set
            {
                _Day26 = value;
            }
        }

        public string Day27
        {
            get
            {
                return _Day27;
            }
            set
            {
                _Day27 = value;
            }
        }

        public string Day28
        {
            get
            {
                return _Day28;
            }
            set
            {
                _Day28 = value;
            }
        }

        public string Day29
        {
            get
            {
                return _Day29;
            }
            set
            {
                _Day29 = value;
            }
        }

        public string Day30
        {
            get
            {
                return _Day30;
            }
            set
            {
                _Day30 = value;
            }
        }



        public string Day31
        {
            get
            {
                return _Day31;
            }
            set
            {
                _Day31 = value;
            }
        }

        public double NCQD
        {
            get
            {
                return _NCQD;
            }
            set
            {
                _NCQD = value;
            }
        }

        public double NCDC
        {
            get
            {
                return _NCDC;
            }
            set
            {
                _NCDC = value;
            }
        }

        public double X
        {
            get
            {
                return _X;
            }
            set
            {
                _X = value;
            }
        }

        public double OmDNBHXH
        {
            get
            {
                return _OmDNBHXH;
            }
            set
            {
                _OmDNBHXH = value;
            }
        }

        public double Om
        {
            get
            {
                return _Om;
            }
            set
            {
                _Om = value;
            }
        }

        public double OmDN
        {
            get
            {
                return _OmDN;
            }
            set
            {
                _OmDN = value;
            }
        }

        public double KHH
        {
            get
            {
                return _KHH;
            }
            set
            {
                _KHH = value;
            }
        }

        public double Co
        {
            get
            {
                return _Co;
            }
            set
            {
                _Co = value;
            }
        }

        public double TS
        {
            get
            {
                return _TS;
            }
            set
            {
                _TS = value;
            }
        }

        public double ST
        {
            get
            {
                return _ST;
            }
            set
            {
                _ST = value;
            }
        }

        public double Khamthai
        {
            get
            {
                return _Khamthai;
            }
            set
            {
                _Khamthai = value;
            }
        }

        public double TNLD
        {
            get
            {
                return _TNLD;
            }
            set
            {
                _TNLD = value;
            }
        }

        public double F
        {
            get
            {
                return _F;
            }
            set
            {
                _F = value;
            }
        }

        public double Diduong
        {
            get
            {
                return _Diduong;
            }
            set
            {
                _Diduong = value;
            }
        }

        public double CTac
        {
            get
            {
                return _CTac;
            }
            set
            {
                _CTac = value;
            }
        }

        public double Fdb
        {
            get
            {
                return _Fdb;
            }
            set
            {
                _Fdb = value;
            }
        }


        public double H1
        {
            get
            {
                return _H1;
            }
            set
            {
                _H1 = value;
            }
        }

        public double H2
        {
            get
            {
                return _H2;
            }
            set
            {
                _H2 = value;
            }
        }

        public double H3
        {
            get
            {
                return _H3;

            }
            set
            {
                _H3 = value;
            }
        }

        public double H4
        {
            get
            {
                return _H4;
            }
            set
            {
                _H4 = value;
            }
        }

        public double H5
        {
            get
            {
                return _H5;
            }
            set
            {
                _H5 = value;
            }
        }

        public double H6
        {
            get
            {
                return _H6;
            }
            set
            {
                _H6 = value;
            }
        }



        public double H7
        {
            get
            {
                return _H7;
            }
            set
            {
                _H7 = value;
            }
        }

        public double DinhChiCT
        {
            get
            {
                return _DinhChiCT;
            }
            set
            {
                _DinhChiCT = value;
            }
        }

        public double Ro
        {
            get
            {
                return _Ro;
            }
            set
            {
                _Ro = value;
            }
        }

        public double Ko
        {
            get
            {
                return _Ko;
            }
            set
            {
                _Ko = value;
            }
        }

        public double LamthemNTbngay
        {
            get
            {
                return _LamthemNTbngay;
            }
            set
            {
                _LamthemNTbngay = value;
            }
        }

        public double LamthemCNbngay
        {
            get
            {
                return _LamthemCNbngay;
            }
            set
            {
                _LamthemCNbngay = value;
            }
        }

        public double LamthemLTbngay
        {
            get
            {
                return _LamthemLTbngay;
            }
            set
            {
                _LamthemLTbngay = value;
            }
        }

        public double LamthemNTbdem
        {
            get
            {
                return _LamthemNTbdem;
            }
            set
            {
                _LamthemNTbdem = value;
            }
        }

        public double LamthemCNbdem
        {
            get
            {
                return _LamthemCNbdem;
            }
            set
            {
                _LamthemCNbdem = value;
            }
        }

        public double LamthemLTbdem
        {
            get
            {
                return _LamthemLTbdem;
            }
            set
            {
                _LamthemLTbdem = value;
            }
        }

        public double Lamdem
        {
            get
            {
                return _Lamdem;
            }
            set
            {
                _Lamdem = value;
            }
        }

        public double HSLNS
        {
            get
            {
                return _HSLNS;
            }
            set
            {
                _HSLNS = value;
            }
        }

        public double HSLNSPCTN
        {
            get
            {
                return _HSLNSPCTN;
            }
            set
            {
                _HSLNSPCTN = value;
            }
        }

        public double HSLCB
        {
            get
            {
                return _HSLCB;
            }
            set
            {
                _HSLCB = value;
            }
        }

        public double HSPCDH
        {
            get
            {
                return _HSPCDH;
            }
            set
            {
                _HSPCDH = value;
            }
        }

        public double HSPCTN
        {
            get
            {
                return _HSPCTN;
            }
            set
            {
                _HSPCTN = value;
            }
        }

        public double HSPCKV
        {
            get
            {
                return _HSPCKV;
            }
            set
            {
                _HSPCKV = value;
            }
        }

        public double HSPCCV
        {
            get
            {
                return _HSPCCV;
            }
            set
            {
                _HSPCCV = value;
            }
        }

        public double HSK
        {
            get
            {
                return _HSK;
            }
            set
            {
                _HSK = value;
            }
        }

        public double DTNopThue
        {
            get
            {
                return _DTNopThue;
            }
            set
            {
                _DTNopThue = value;
            }
        }

        public double NguoiPThuoc
        {
            get
            {
                return _NguoiPThuoc;
            }
            set
            {
                _NguoiPThuoc = value;
            }
        }


        public System.DateTime CreateDate
        {
            get
            {
                return _CreateDate;
            }
            set
            {
                _CreateDate = value;
            }
        }

        public int CreateUserId
        {
            get
            {
                return _CreateUserId;
            }
            set
            {
                _CreateUserId = value;
            }
        }

        public System.DateTime UpdateDate
        {
            get
            {
                return _UpdateDate;
            }
            set
            {
                _UpdateDate = value;
            }
        }

        public int UpdateUserId
        {
            get
            {
                return -UpdateUserId;
            }
            set
            {
                _UpdateUserId = value;
            }
        }

        public string Remark
        {
            get
            {
                return _Remark;
            }
            set
            {
                _Remark = value;
            }
        }

        public double NC
        {
            get
            {
                return _NC;
            }

            set
            {
                _NC = value;
            }
        }

        #endregion

        public static long InsertByDate_UserId(int UserId, DateTime dataDate, int createUser, string remark, bool isOfficeHours, int UserUpdate, string UserFullName)
        {

            int dayInMonth = DateTime.DaysInMonth(dataDate.Year, dataDate.Month);
            string day25 = null; string day26 = null; string day27 = null; string day28 = null; string day29 = null; string day30 = null; string day31 = null;
            if (dayInMonth == 25)
            {
                day25 = "X";
            }
            else if (dayInMonth == 26)
            {
                day25 = "X";
                day26 = "X";
            }
            else if (dayInMonth == 27)
            {
                day25 = "X";
                day26 = "X";
                day27 = "X";
            }
            else if (dayInMonth == 28)
            {
                day25 = "X";
                day26 = "X";
                day27 = "X";
                day28 = "X";
            }
            else if (dayInMonth == 29)
            {
                day25 = "X";
                day26 = "X";
                day27 = "X";
                day28 = "X";
                day29 = "X";
            }
            else if (dayInMonth == 30)
            {
                day25 = "X";
                day26 = "X";
                day27 = "X";
                day28 = "X";
                day29 = "X";
                day30 = "X";
            }
            else
            {
                day25 = "X";
                day26 = "X";
                day27 = "X";
                day28 = "X";
                day29 = "X";
                day30 = "X";
                day31 = "X";
            }
            double XQD = DefaultValues.XQD(dataDate.Month, dataDate.Year, isOfficeHours);
            double XDC = DefaultValues.XDuocCham(dataDate.Month, dataDate.Year, isOfficeHours);
            //int typeL = 1;
            //if (!isOfficeHours)
            //{
            //    typeL = 0;
            //}


            new WorkdayCoefficientEmployeesFinalDAL().InsertByDate_UserId(UserId, dataDate, day25, day26, day27, day28, day29, day30, day31, XQD, XDC, DateTime.Now, createUser, remark);
            string _ChangedWD = "UserId: " + UserId + ", DataDate: " + dataDate + ", Day25: " + day25 + ", Day26: " + day26 + ", Day27: " + day27 + ", Day28: " + day28 + ", Day29: " + day29 + ", Day30: " + day30 + ", Day31: " + day31 + ", XQD: " + XQD + ", XDC: " + XDC + ", CreateDate: " + DateTime.Now + ", CreateUser: " + createUser + ", Remark: " + remark;
            SaveHRMLog("H1_WorkdayCoefficientEmployeesFinal", "Ins_H1_WorkdayCoefficientEmployeesFinal_By_UserId_Date_For_Workday", _ChangedWD, "", UserUpdate, UserFullName);
            //List<WorkdayEmployeesBLLL> listW = WorkdayEmployeesBLLL.GetByFilter(string.Empty, deptIds, workdayDateL.Month, workdayDateL.Year, 1);

            //foreach (WorkdayEmployeesBLLL objWE in listW)
            //{
            //    if (isOfficeHours)
            //    {
            //        UpdateWorkdayEmployeeByOfficeHours(objWE);
            //    }
            //    else
            //    {
            //        double x = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
            //        objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
            //        objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_X);

            //        objWE.XL = x;
            //        objWE.UpdateByDate_UserId();
            //    }

            //    //UpdateWorkdayEmployeeByHoliday(objWE);
            //}

            return 0;
        }
        public static void SaveHRMLog(string InfluencedTable, string StoredProcedures, string ChangedContent,
            string OldContent, int UserUpdateId, string UserUpdateFullName)
        {
            var _HistoryId = 0;
            var _UserId = UserUpdateId;
            var _FullName = UserUpdateFullName;
            //Get IPAddress
            var _IPAddress = "";
            //Get MACAddress
            var _MACAddress = "";
            var _ServerName = "Web";
            var _InfluencedTable = InfluencedTable;
            var _StoredProcedures = StoredProcedures;
            var _ChangedContent = ChangedContent;
            var _OldContent = OldContent;
            var _ChangedDate = DateTime.Now;

            AdministrationBLL.Save(_HistoryId, _UserId, _FullName, _IPAddress, _MACAddress, _ServerName,
                _InfluencedTable, _StoredProcedures, _ChangedContent, _ChangedDate, _OldContent);
        }
        public static long InsertByDate_DeptIds(string deptIds, DateTime dataDate, int createUser, string remark, bool isOfficeHours)
        {

            int dayInMonth = DateTime.DaysInMonth(dataDate.Year, dataDate.Month);
            string day25 = null; string day26 = null; string day27 = null; string day28 = null; string day29 = null; string day30 = null; string day31 = null;
            if (dayInMonth == 25)
            {
                day25 = "X";
            }
            else if (dayInMonth == 26)
            {
                day25 = "X";
                day26 = "X";
            }
            else if (dayInMonth == 27)
            {
                day25 = "X";
                day26 = "X";
                day27 = "X";
            }
            else if (dayInMonth == 28)
            {
                day25 = "X";
                day26 = "X";
                day27 = "X";
                day28 = "X";
            }
            else if (dayInMonth == 29)
            {
                day25 = "X";
                day26 = "X";
                day27 = "X";
                day28 = "X";
                day29 = "X";
            }
            else if (dayInMonth == 30)
            {
                day25 = "X";
                day26 = "X";
                day27 = "X";
                day28 = "X";
                day29 = "X";
                day30 = "X";
            }
            else
            {
                day25 = "X";
                day26 = "X";
                day27 = "X";
                day28 = "X";
                day29 = "X";
                day30 = "X";
                day31 = "X";
            }
            double XQD = DefaultValues.XQD(dataDate.Month, dataDate.Year, isOfficeHours);
            double XDC = DefaultValues.XDuocCham(dataDate.Month, dataDate.Year, isOfficeHours);
            //int typeL = 1;
            //if (!isOfficeHours)
            //{
            //    typeL = 0;
            //}


            new WorkdayCoefficientEmployeesFinalDAL().InsertByDate_DeptId(day25, day26, day27, day28, day29, day30, day31, deptIds, dataDate, createUser, XQD, XDC, remark);

            //List<WorkdayEmployeesBLLL> listW = WorkdayEmployeesBLLL.GetByFilter(string.Empty, deptIds, workdayDateL.Month, workdayDateL.Year, 1);

            //foreach (WorkdayEmployeesBLLL objWE in listW)
            //{
            //    if (isOfficeHours)
            //    {
            //        UpdateWorkdayEmployeeByOfficeHours(objWE);
            //    }
            //    else
            //    {
            //        double x = HRMBLL.H1.Helper.DefaultValues.CalculateLeaveDayL(objWE.Day1L, objWE.Day2L, objWE.Day3L, objWE.Day4L, objWE.Day5L, objWE.Day6L, objWE.Day7L, objWE.Day8L, objWE.Day9L, objWE.Day10L, objWE.Day11L, objWE.Day12L, objWE.Day13L,
            //        objWE.Day14L, objWE.Day15L, objWE.Day16L, objWE.Day17L, objWE.Day18L, objWE.Day19L, objWE.Day20L, objWE.Day21L, objWE.Day22L, objWE.Day23L, objWE.Day24L, objWE.Day25L, objWE.Day26L,
            //        objWE.Day27L, objWE.Day28L, objWE.Day29L, objWE.Day30L, objWE.Day31L, Constants.LEAVE_TYPE_X);

            //        objWE.XL = x;
            //        objWE.UpdateByDate_UserId();
            //    }

            //    //UpdateWorkdayEmployeeByHoliday(objWE);
            //}

            return 0;
        }

        public static long Insert(int UserId, DateTime DataDate, DateTime CreateDate, int CreateUserId, string Remark, bool isOfficeHours)
        {

            int daysInMonth = DateTime.DaysInMonth(DataDate.Year, DataDate.Month);
            string day25 = null; string day26 = null; string day27 = null; string day28 = null; string day29 = null; string day30 = null; string day31 = null;
            if (daysInMonth == 25)
            {
                day25 = "X";
            }
            else if (daysInMonth == 26)
            {
                day25 = "X";
                day26 = "X";
            }
            else if (daysInMonth == 27)
            {
                day25 = "X";
                day26 = "X";
                day27 = "X";
            }
            else if (daysInMonth == 28)
            {
                day25 = "X";
                day26 = "X";
                day27 = "X";
                day28 = "X";
            }
            else if (daysInMonth == 29)
            {
                day25 = "X";
                day26 = "X";
                day27 = "X";
                day28 = "X";
                day29 = "X";
            }
            else if (daysInMonth == 30)
            {
                day25 = "X";
                day26 = "X";
                day27 = "X";
                day28 = "X";
                day29 = "X";
                day30 = "X";
            }
            else
            {
                day25 = "X";
                day26 = "X";
                day27 = "X";
                day28 = "X";
                day29 = "X";
                day30 = "X";
                day31 = "X";
            }

            double XQD = DefaultValues.XQD(DataDate.Month, DataDate.Year, isOfficeHours);
            double XDC = DefaultValues.XDuocCham(DataDate.Month, DataDate.Year, isOfficeHours);

            return new WorkdayCoefficientEmployeesFinalDAL().Insert(UserId, DataDate,
                           day25, day26, day27, day28, day29, day30, day31,
                           XQD, XDC, CreateDate, CreateUserId, Remark);
        }

        public static long UpdateByUserId_DateForWorkday(int userId, DateTime DataDate,
                           string day1, string day2, string day3, string day4, string day5, string day6, string day7, string day8, string day9, string day10,
                           string day11, string day12, string day13, string day14, string day15, string day16, string day17, string day18, string day19, string day20,
                           string day21, string day22, string day23, string day24, string day25, string day26, string day27, string day28, string day29, string day30, string day31,
                           double Lamdem, double HSK, DateTime UpdateDate, int UpdateUserId, string Remark, bool isOfficeHours)
        {

            double X = 0;
            double OmDNBHXH = 0; double Om = 0; double OmDN = 0; double KHH = 0; double Co = 0; double TS = 0; double ST = 0; double Khamthai = 0; double TNLD = 0; double F = 0; double Diduong = 0; double CTac = 0; double Fdb = 0;
            double H1 = 0; double H2 = 0; double H3 = 0; double H4 = 0; double H5 = 0; double H6 = 0; double H7 = 0; double DinhChiCT = 0; double Ro = 0; double Ko = 0;
            double LamthemNTbngay = 0; double LamthemCNbngay = 0; double LamthemLTbngay = 0; double LamthemNTbdem = 0; double LamthemCNbdem = 0; double LamthemLTbdem = 0;

            double nghiTuan = 0; double nghiBu = 0; double chuaDiLam = 0; double nghiViec = 0; double nghiMat = 0;
            double nc = 0;

            ///20200330
            ///
            double E0 = 0; double E1 = 0; double R1 = 0;
            //20200908
            double R2 = 0;
            //20201013
            double Le = 0;
            //20220713
            double NK = 0;
            double XNT = 0;
            double XLE = 0;
            //20230525
            double T = 0;
            //20230926
            double BL = 0;
            double DS = 0;
            //20240501
            double FC = 0;
            double Ho = 0;
            double BNN = 0;
            double CC = 0;
            double O1 = 0;

            //OmDNBHXH = -1; 
            nc = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_NUOI_CON_SO_SINH);

            Om = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_O_BAN_THAN);
            OmDN = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_O_DAI_NGAY);
            Co = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                 day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                 day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_CON_OM);




            TS = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_THAI_SAN);

            ST = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_SAY_THAI);
            KHH = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                  day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                  day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_KHHDS);
            Khamthai = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_KHAM_THAI);



            TNLD = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_TNLD);


            F = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_F_NAM);
            Diduong = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                  day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                  day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_F_DI_DUONG);



            CTac = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_F_CONG_TAC);
            Fdb = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_FDB);
            H1 = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_HOC_1);
            H2 = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_HOC_2);
            H3 = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_HOC_3);
            H4 = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_HOC_4);
            H5 = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_HOC_5);
            H6 = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_HOC_6);
            H7 = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_HOC_7);

            DinhChiCT = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_DINH_CHI_CONG_TAC);
            Ro = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_NGHI_KO_LUONG_CO_LYDO);
            Ko = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_NGHI_KO_LUONG_KO_LYDO);

            Ko = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_NGHI_KO_LUONG_KO_LYDO);


            ///20200330
            ///
            E0 = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_CACHLY_KHONGLUONG);

            E1 = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_CACHLY_COLUONG);

            R1 = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_KHONGLUONG_YEUCAU);
            //20200908
            R2 = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_LUANPHIEN_KHONGLUONG);

            //20220713
            NK = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_TAM_HOAN_HOP_DONG);
            XNT = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_LAM_NGHI_TUAN);
            XLE = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_LAM_NGHI_LE);
            //20230525
            T = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_DI_DAY);
            //20230926
            BL = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_NGHI_BU_LE);
            DS = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_DUONG_SUC);
            //20240105
            FC = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_PHEP_CU);

            Ho = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_HOC_SAGS);
            //20240502
            BNN = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_BENH_NGHE_NGHIEP);
            CC = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_CON_CHET_SAU_KHI_SINH);
            O1 = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_NGHI_DO_COVID);

            //f_ConChetL = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
            //       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
            //       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_CON_CHET_SAU_KHI_SINH);

            //f_TamHoanHDL = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
            //       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
            //       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_TAM_HOAN_HOP_DONG);
            //f_HoiHop = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
            //       day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
            //       day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_HOI_HOP);

            Le = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_LE_TET);

            nghiTuan = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_NGHI_TUAN);

            nghiMat = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_NGHI_MAT);

            nghiBu = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_NGHI_BU);

            nghiViec = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_NGHI_VIEC);

            chuaDiLam = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_CHUA_DI_LAM);

            double om = OmDNBHXH + Om + OmDN + Co + nc;

            double thaisan = TS + ST + KHH + Khamthai;

            double phep_DiDuong = F + Diduong;

            double khac = CTac + Fdb + H1 + H2 + H3 + H4 + H5 + H6 + H7 + DinhChiCT + Ro + Ko + E0 + E1 + R1 + R2 + Le + NK;

            double totalLeave = om + thaisan + phep_DiDuong + khac + nghiBu;

            double XQD = DefaultValues.XQD(DataDate.Month, DataDate.Year, isOfficeHours);



            //int daysInNow = DateTime.DaysInMonth(DataDate.Year, DataDate.Month);

            //X = XDC - totalLeave;
            X = DefaultValues.CalculateLeaveDayL(DataDate.Month, DataDate.Year, userId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
                   day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26,
                   day27, day28, day29, day30, day31, Constants.LEAVE_TYPE_X);
            double XDC = totalLeave + X + XNT + XLE;
            //string hTCV = DefaultValues.HTCV(mark); 

            return new WorkdayCoefficientEmployeesFinalDAL().UpdateByUserId_DateForWorkday(userId, DataDate,
                           day1, day2, day3, day4, day5, day6, day7, day8, day9, day10,
                           day11, day12, day13, day14, day15, day16, day17, day18, day19, day20,
                           day21, day22, day23, day24, day25, day26, day27, day28, day29, day30, day31,
                           XQD, XDC, X, OmDNBHXH, Om, OmDN, KHH, Co, TS, ST, Khamthai, TNLD, F, Diduong, CTac, Fdb,
                           H1, H2, H3, H4, H5, H6, H7, DinhChiCT, Ro, Ko, nghiTuan, nghiBu, chuaDiLam, nghiViec, nghiMat,
                           LamthemNTbngay, LamthemCNbngay, LamthemLTbngay, LamthemNTbdem, LamthemCNbdem, LamthemLTbdem, Lamdem,
                           HSK, UpdateDate, UpdateUserId, Remark, nc, E0, E1, R1, R2, Le, NK, XNT, XLE, T, BL, DS, FC, Ho, BNN, CC, O1);
        }

        public static long ImportFromExcelACV(string ACVId, DateTime DataDate, string Day1, string Day2, string Day3, string Day4, string Day5, string Day6, string Day7, string Day8, string Day9, string Day10,
                          string Day11, string Day12, string Day13, string Day14, string Day15, string Day16, string Day17, string Day18, string Day19, string Day20,
                          string Day21, string Day22, string Day23, string Day24, string Day25, string Day26, string Day27, string Day28, string Day29, string Day30, string Day31,
                          double NCQD, double NCDC, double X, double OmDNBHXH, double Om, double OmDN, double KHH, double Co, double TS, double ST, double Khamthai, double TNLD, double F, double Diduong, double CTac, double Fdb,
                          double H1, double H2, double H3, double H4, double H5, double H6, double H7, double DinhChiCT, double Ro, double Ko, double LamthemNTbngay, double LamthemCNbngay, double LamthemLTbngay, double LamthemNTbdem,
                          double LamthemCNbdem, double LamthemLTbdem, double Lamdem,
                          double HSLNS, double HSLNSPCTN, double HSLCB, double HSPCDH, double HSPCTN, double HSPCKV, double HSPCCV, double HSK, double DTNopThue, double NguoiPThuoc,
                          DateTime CreateDate, int CreateUserId, DateTime UpdateDate, int UpdateUserId, string Remark, int UserId,
                          string Contract, double BSLNgayCong, double BSLHSLNS, double BSLQHSLNS, double ThuongNgayCong, double ThuongHSLNS, double ThuongQHSLNS, double ATHKNgayCong, double ATHKHSLNS, double ATHKQHSLNS, double ThangCongLeTet)
        {
            return new WorkdayCoefficientEmployeesFinalDAL().ImportFromExcelACV(ACVId, DataDate, Day1, Day2, Day3, Day4, Day5, Day6, Day7, Day8, Day9, Day10,
                          Day11, Day12, Day13, Day14, Day15, Day16, Day17, Day18, Day19, Day20, Day21, Day22, Day23, Day24, Day25, Day26, Day27, Day28, Day29, Day30, Day31,
                          NCQD, NCDC, X, OmDNBHXH, Om, OmDN, KHH, Co, TS, ST, Khamthai, TNLD, F, Diduong, CTac, Fdb, H1, H2, H3, H4, H5, H6, H7, DinhChiCT, Ro, Ko, LamthemNTbngay, LamthemCNbngay, LamthemLTbngay, LamthemNTbdem,
                          LamthemCNbdem, LamthemLTbdem, Lamdem, HSLNS, HSLNSPCTN, HSLCB, HSPCDH, HSPCTN, HSPCKV, HSPCCV, HSK, DTNopThue, NguoiPThuoc, CreateDate, CreateUserId, UpdateDate, UpdateUserId, Remark, UserId,
                          Contract, BSLNgayCong, BSLHSLNS, BSLQHSLNS, ThuongNgayCong, ThuongHSLNS, ThuongQHSLNS, ATHKNgayCong, ATHKHSLNS, ATHKQHSLNS, ThangCongLeTet);
        }

        public static long UpdateByCalculateConversionCoefficient(double NCHLNS, double HSQDNCHL, double HSTLNS, double NCHLCB, double NANGC, DateTime DataDate, DateTime UpdateDate, int UpdateUserId, string Remark, int UserId,
            double BSLNgayCong, double BSLHSLNS, double BSLQHSLNS, double ThuongNgayCong, double ThuongHSLNS, double ThuongQHSLNS, double ATHKNgayCong, double ATHKHSLNS, double ATHKQHSLNS, double ThangCongLeTet, int CountBlank_1_15, int CountBlank_16_31)
        {
            return new WorkdayCoefficientEmployeesFinalDAL().UpdateByCalculateConversionCoefficient(NCHLNS, HSQDNCHL, HSTLNS, NCHLCB, NANGC, DataDate, UpdateDate, UpdateUserId, Remark, UserId, BSLNgayCong, BSLHSLNS, BSLQHSLNS, ThuongNgayCong, ThuongHSLNS, ThuongQHSLNS, ATHKNgayCong, ATHKHSLNS, ATHKQHSLNS, ThangCongLeTet, CountBlank_1_15, CountBlank_16_31);
        }

        public static long UpdateForContract(DateTime DataDate, string contract, int UserId)
        {
            return new WorkdayCoefficientEmployeesFinalDAL().UpdateForContract(DataDate, contract, UserId);
        }

        public static long UpdateForHSK(DateTime DataDate, double HSK, int UserId)
        {
            return new WorkdayCoefficientEmployeesFinalDAL().UpdateForHSK(DataDate, HSK, UserId);
        }
        public static long UpdateForOverTime(int UserId, int Month, int Year, double LamthemNTbngay, double LamthemCNbngay, double LamthemLTbngay, double LamthemNTbdem, double LamthemCNbdem, double LamthemLTbdem)
        {
            return new WorkdayCoefficientEmployeesFinalDAL().UpdateForOverTime(UserId, Month, Year, LamthemNTbngay, LamthemCNbngay, LamthemLTbngay, LamthemNTbdem, LamthemCNbdem, LamthemLTbdem);
        }

        public static long DeleteByDeptIdsDate(string deptIds, int month, int year)
        {
            return new WorkdayCoefficientEmployeesFinalDAL().DeleteByDeptIdsDate(deptIds, month, year);
        }

        public static DataTable GetByDataDate(DateTime dataDate, int IsVCQLNC)
        {
            return new WorkdayCoefficientEmployeesFinalDAL().GetByDataDate(dataDate, IsVCQLNC);
        }

        public static DataTable GetByDataDateForDetail(DateTime dataDate, int IsVCQLNC)
        {
            return new WorkdayCoefficientEmployeesFinalDAL().GetByDataDateForDetail(dataDate, IsVCQLNC);
        }

        public static DataTable GetByDataDateForTotal(DateTime dataDate, int IsVCQLNC)
        {
            return new WorkdayCoefficientEmployeesFinalDAL().GetByDataDateForTotal(dataDate, IsVCQLNC);
        }

        public static DataTable GetDataTableByDataDate(DateTime dataDate, int isVCQLNN, string departments)
        {
            return new WorkdayCoefficientEmployeesFinalDAL().GetByDataDateV1(dataDate, isVCQLNN, departments);
        }

        public static DataTable GetDataTableByDataDateForWorkingDay(DateTime dataDate, int isVCQLNN, string departments)
        {
            return new WorkdayCoefficientEmployeesFinalDAL().GetDataTableByDataDateForWorkingDay(dataDate, isVCQLNN, departments);

        }

        public static DataRow GetByUserIdDataDate(int UserId, DateTime dataDate, int DataType, string DepartmentId)
        {
            DataTable dt = new WorkdayCoefficientEmployeesFinalDAL().GetByUserIdDataDate(UserId, dataDate, DataType, DepartmentId);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }

        }

        public static DataTable GetWorkday(int UserId, int Month, int Year)
        {
            return new WorkdayCoefficientEmployeesFinalDAL().GetWorkday(UserId, Month, Year);
        }

        public static DataTable GetWorktime(int UserId, int Month, int Year)
        {
            return new WorkdayCoefficientEmployeesFinalDAL().GetWorktime(UserId, Month, Year);
        }

        public static DataTable GetCoefficient(int UserId, int Month, int Year)
        {
            return new WorkdayCoefficientEmployeesFinalDAL().GetCoefficient(UserId, Month, Year);
        }

        public static DataTable GetPIT(int UserId, int Month, int Year)
        {
            return new WorkdayCoefficientEmployeesFinalDAL().GetPIT(UserId, Month, Year);
        }

        #region private methods


        private static List<WorkdayCoefficientEmployeesFinalBLL> GenerateListWorkdayEmployeesBLLFinalFromDataTable(DataTable dt)
        {
            List<WorkdayCoefficientEmployeesFinalBLL> list = new List<WorkdayCoefficientEmployeesFinalBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateWorkdayEmployeesBLLFinalFromDataRow(dr));
            }

            return list;
        }

        private static WorkdayCoefficientEmployeesFinalBLL GenerateWorkdayEmployeesBLLFinalFromDataRow(DataRow dr)
        {

            WorkdayCoefficientEmployeesFinalBLL objBLL = new WorkdayCoefficientEmployeesFinalBLL();

            objBLL._WorkdayEmployeeIdFinal = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_WorkdayCoefficientEmployeeFinalId] == DBNull.Value ? 0 : long.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_WorkdayCoefficientEmployeeFinalId].ToString());
            objBLL._UserId = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_UserId] == DBNull.Value ? 0 : int.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_UserId].ToString());
            objBLL._DataDate = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_DataDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_DataDate].ToString());

            //try
            //{
            //    objBLL._EmployeeCode = dr[EmployeeKeys.FIELD_EMPLOYEES_EMPLOYEE_CODE] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_EMPLOYEE_CODE].ToString();
            //}
            //catch { }
            //objBLL._FullName = dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME].ToString();
            //objBLL._DepartmentId = dr[DepartmentKeys.FIELD_DEPARTMENT_ID] == DBNull.Value ? 0 : int.Parse(dr[DepartmentKeys.FIELD_DEPARTMENT_ID].ToString());
            //objBLL._DepartmentName = dr[DepartmentKeys.FIELD_DEPARTMENT_NAME] == DBNull.Value ? string.Empty : dr[DepartmentKeys.FIELD_DEPARTMENT_NAME].ToString();
            //objBLL._DepartmentFullName = dr[DepartmentKeys.Field_Department_DepartmentFullName] == DBNull.Value ? string.Empty : dr[DepartmentKeys.Field_Department_DepartmentFullName].ToString();
            //objBLL._RootId = dr[DepartmentKeys.FIELD_DEPARTMENT_ROOT_ID] == DBNull.Value ? 0 : int.Parse(dr[DepartmentKeys.FIELD_DEPARTMENT_ROOT_ID].ToString());
            //try
            //{
            //    objBLL._RootName = dr[DepartmentKeys.Field_Department_RootName] == DBNull.Value ? string.Empty : dr[DepartmentKeys.Field_Department_RootName].ToString();
            //}
            //catch { }
            //try
            //{
            //    objBLL._PositionName = dr[PositionKeys.FIELD_POSITION_NAME] == DBNull.Value ? string.Empty : dr[PositionKeys.FIELD_POSITION_NAME].ToString();
            //}
            //catch { }

            #region TimeKeeping

            objBLL._Day1 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day1] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day1].ToString();
            objBLL._Day2 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day2] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day2].ToString();
            objBLL._Day3 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day3] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day3].ToString();
            objBLL._Day4 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day4] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day4].ToString();
            objBLL._Day5 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day5] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day5].ToString();
            objBLL._Day6 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day6] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day6].ToString();
            objBLL._Day7 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day7] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day7].ToString();
            objBLL._Day8 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day8] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day8].ToString();
            objBLL._Day9 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day9] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day9].ToString();
            objBLL._Day10 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day10] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day10].ToString();
            objBLL._Day11 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day11] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day11].ToString();
            objBLL._Day12 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day12] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day12].ToString();
            objBLL._Day13 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day13] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day13].ToString();
            objBLL._Day14 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day14] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day14].ToString();
            objBLL._Day15 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day15] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day15].ToString();
            objBLL._Day16 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day16] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day16].ToString();
            objBLL._Day17 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day17] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day17].ToString();
            objBLL._Day18 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day18] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day18].ToString();
            objBLL._Day19 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day19] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day19].ToString();
            objBLL._Day20 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day20] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day20].ToString();
            objBLL._Day21 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day21] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day21].ToString();
            objBLL._Day22 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day22] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day22].ToString();
            objBLL._Day23 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day23] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day23].ToString();
            objBLL._Day24 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day24] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day24].ToString();
            objBLL._Day25 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day25] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day25].ToString();
            objBLL._Day26 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day26] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day26].ToString();
            objBLL._Day27 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day27] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day27].ToString();
            objBLL._Day28 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day28] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day28].ToString();
            objBLL._Day29 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day29] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day29].ToString();
            objBLL._Day30 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day30] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day30].ToString();
            objBLL._Day31 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day31] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Day31].ToString();


            #endregion

            #region To Collect WorkdayEmplyee
            objBLL._NC = dr["NC"] == DBNull.Value ? 0 : double.Parse(dr["NC"].ToString());
            objBLL._NCQD = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_NCQD] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_NCQD].ToString());
            objBLL._NCDC = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_NCDC] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_NCDC].ToString());
            objBLL._X = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_X] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_X].ToString());
            objBLL._OmDNBHXH = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_OmDNBHXH] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_OmDNBHXH].ToString());
            objBLL._Om = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Om] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Om].ToString());
            objBLL._OmDN = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_OmDN] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_OmDN].ToString());
            objBLL._KHH = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_KHH] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_KHH].ToString());
            objBLL._Co = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Co] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Co].ToString());
            objBLL._TS = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_TS] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_TS].ToString());
            objBLL._ST = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_ST] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_ST].ToString());
            objBLL._Khamthai = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Khamthai] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Khamthai].ToString());
            objBLL._TNLD = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_TNLD] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_TNLD].ToString());
            objBLL._F = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_F] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_F].ToString());
            objBLL._Diduong = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Diduong] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Diduong].ToString());
            objBLL._CTac = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_CTac] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_CTac].ToString());
            objBLL._Fdb = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Fdb] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Fdb].ToString());
            objBLL._H1 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_H1] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_H1].ToString());
            objBLL._H2 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_H2] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_H2].ToString());
            objBLL._H3 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_H3] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_H3].ToString());
            objBLL._H4 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_H4] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_H4].ToString());
            objBLL._H5 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_H5] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_H5].ToString());
            objBLL._H6 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_H6] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_H6].ToString());
            objBLL._H7 = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_H7] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_H7].ToString());
            objBLL._DinhChiCT = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_DinhChiCT] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_DinhChiCT].ToString());
            objBLL._Ro = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Ro] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Ro].ToString());
            objBLL._Ko = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Ko] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Ko].ToString());
            objBLL._LamthemNTbngay = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_LamthemNTbngay] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_LamthemNTbngay].ToString());
            objBLL._LamthemCNbngay = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_LamthemCNbngay] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_LamthemCNbngay].ToString());
            objBLL._LamthemLTbngay = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_LamthemLTbngay] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_LamthemLTbngay].ToString());
            objBLL._LamthemNTbdem = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_LamthemNTbdem] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_LamthemNTbdem].ToString());
            objBLL._LamthemCNbdem = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_LamthemCNbdem] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_LamthemCNbdem].ToString());
            objBLL._LamthemLTbdem = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_LamthemLTbdem] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_LamthemLTbdem].ToString());
            objBLL._Lamdem = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Lamdem] == DBNull.Value ? 0 : double.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Lamdem].ToString());
            #endregion


            //objBLL._NightTimeL = dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_NightTimeL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_NightTimeL].ToString());
            //objBLL._MarkL = dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_MarkL] == DBNull.Value ? 0 : double.Parse(dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_MarkL].ToString());
            //objBLL._RankL = DefaultValues.HTCV(objBLL._MarkL);//dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_RankL] == DBNull.Value ? string.Empty : dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Rank].ToString();

            objBLL._CreateDate = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_CreateDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_CreateDate].ToString());
            objBLL._CreateUserId = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_CreateUserId] == DBNull.Value ? 0 : int.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_CreateUserId].ToString());
            //objBLL._CreateUserNameL = dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_CreateUserNameL] == DBNull.Value ? "" : dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_CreateUserName].ToString();
            //objBLL._CreateFullNameL = dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_CreateFullNameL] == DBNull.Value ? "" : dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_CreateFullName].ToString();

            objBLL._UpdateDate = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_UpdateDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_UpdateDate].ToString());
            objBLL._UpdateUserId = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_UpdateUserId] == DBNull.Value ? 0 : int.Parse(dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_UpdateUserId].ToString());
            //objBLL._UpdateUserNameL = dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_UpdateUserNameL] == DBNull.Value ? "" : dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_UpdateUserName].ToString();
            //objBLL._UpdateFullNameL = dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_UpdateFullNameL] == DBNull.Value ? "" : dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_UpdateFullName].ToString();

            //objBLL._TypeL = dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_TypeL] == DBNull.Value ? 0 : int.Parse(dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_TypeL].ToString());


            //objBLL._F_O_Co_KHHDS_TNLDL = objBLL._F_OmL + objBLL._F_Con_OmL + objBLL._F_KHHDSL + objBLL._F_TNLDL;
            //objBLL._F_Nam_Fdb_DDL = objBLL._F_NamL + objBLL._F_dbL + objBLL._F_DiDuongL;
            //objBLL._F_HocL = objBLL._F_HocSAGSL + objBLL._F_Hoc1L + objBLL._F_Hoc2L + objBLL._F_Hoc3L + objBLL._F_Hoc4L + objBLL._F_Hoc5L + objBLL._F_Hoc6L + objBLL._F_Hoc7L;
            //objBLL._F_KhacL = objBLL._F_LeL + objBLL._F_KoLuongCLDL + objBLL._F_KoLuongKLDL + objBLL._ChuaDiLamL + objBLL._F_SayThaiL;

            //objBLL._NghiTuan_NghiBuL = objBLL._NghiTuanL + objBLL._NghiBuL;

            objBLL._Remark = dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Remark] == DBNull.Value ? string.Empty : dr[WorkdayCoefficientEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_Remark].ToString();

            //objBLL._StatusL = dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_StatusL] == DBNull.Value ? 0 : int.Parse(dr[WorkdayEmployeesFinalKeys.Field_WorkdayCoefficientEmployeesFinal_StatusL].ToString());

            //try
            //{
            //    objBLL._LeaveStatus = dr["LeaveStatus"] == DBNull.Value ? 0 : int.Parse(dr["LeaveStatus"].ToString());
            //}
            //catch { }
            //try
            //{
            //    objBLL._LeaveDate = dr["LeaveDate"] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr["LeaveDate"].ToString());
            //}
            //catch { }


            return objBLL;
        }


        #endregion

    }
}
