using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H4;
using HRMUtil.KeyNames.H4;
using HRMUtil.KeyNames.H0;
using HRMUtil;

namespace HRMBLL.H4
{
    public class RepresentativeBLL
    {

        #region public method Get

        public static DataTable GetByFilter(int InvestorNo, string FullName, int IsOk, int KTTCDB)
        {
            return new RepresentativeDAL().GetByFilter(InvestorNo, FullName, IsOk, KTTCDB);
        }
        public static DataRow GetForTotal(int InvestorNo, string FullName, int IsOk, int KTTCDB)
        {
            DataTable dt = new RepresentativeDAL().GetForTotal(InvestorNo, FullName, IsOk, KTTCDB);

            if(dt.Rows.Count == 1)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetByAttorneyCode(int AttorneyCode)
        {
            return new RepresentativeDAL().GetByAttorneyCode(AttorneyCode);
        }


        public static DataTable GetForStatisticByHDQT()
        {
            return new RepresentativeDAL().GetForStatisticByHDQT();
        }
        public static DataTable GetForStatisticByHDQT2()
        {
            return new RepresentativeDAL().GetForStatisticByHDQT2();
        }

        public static DataTable GetForStatisticByBKS()
        {
            return new RepresentativeDAL().GetForStatisticByBKS();
        }
        public static DataTable GetForStatisticByBKS2()
        {
            return new RepresentativeDAL().GetForStatisticByBKS2();
        }

        public static DataTable GetForStatisticByBQ_DL()
        {
            return new RepresentativeDAL().GetForStatisticByBQ_DL();
        }
        public static DataTable GetForStatisticByBQ_DL2()
        {
            return new RepresentativeDAL().GetForStatisticByBQ_DL2();
        }

        public static DataTable GetForStatisticByBQ_SLHDQT()
        {
            return new RepresentativeDAL().GetForStatisticByBQ_SLHDQT();
        }
        public static DataTable GetForStatisticByBQ_SLHDQT2()
        {
            return new RepresentativeDAL().GetForStatisticByBQ_SLHDQT2();
        }

        public static DataTable GetForStatisticByBQ_KDTLKTNY()
        {
            return new RepresentativeDAL().GetForStatisticByBQ_KDTLKTNY();
        }
        public static DataTable GetForStatisticByBQ_KDTLKTNY2()
        {
            return new RepresentativeDAL().GetForStatisticByBQ_KDTLKTNY2();
        }

        public static DataTable GetForStatisticByBQ_CTTGD()
        {
            return new RepresentativeDAL().GetForStatisticByBQ_CTTGD();
        }
        public static DataTable GetForStatisticByKTTCDB()
        {
            return new RepresentativeDAL().GetForStatisticByKTTCDB();
        }

        #endregion

        #region methods Insert, update, delete

        public static void Insert(int InvestorNo, string RepresentativeName, string RepresentativeName2, double Stock, double StockRatio, double AttorneyCode, double HDQT_Vote, double HDQT_A, double HDQT_B, double HDQT_C, double HDQT_D, double HDQT_E, double HDQT_F, double HDQT_G, double BKS_Vote, double BKS_A, double BKS_B, double BKS_C, int IsOk, string Remark)
        {
            new RepresentativeDAL().Insert(InvestorNo, RepresentativeName, RepresentativeName2, Stock, StockRatio, AttorneyCode, HDQT_Vote, HDQT_A, HDQT_B, HDQT_C, HDQT_D, HDQT_E, HDQT_F, HDQT_G, BKS_Vote, BKS_A, BKS_B, BKS_C, IsOk, Remark);
        }


        public static void UpdateForKTTCDB(int InvestorNo, int KTTCDB)
        {
            new RepresentativeDAL().UpdateForKTTCDB(InvestorNo, KTTCDB);
        }
        public static void UpdateForCheck(int InvestorNo, int IsOk)
        {
            new RepresentativeDAL().UpdateForCheck(InvestorNo, IsOk);
        }


        public static void UpdateForHDQT(int RepresentativeId, double HDQT_A, double HDQT_B, double HDQT_C, double HDQT_D, double HDQT_E, double HDQT_F, double HDQT_G, int HDQT_IsValid)
        {
            new RepresentativeDAL().UpdateForHDQT(RepresentativeId, HDQT_A, HDQT_B, HDQT_C, HDQT_D, HDQT_E, HDQT_F, HDQT_G, HDQT_IsValid);
        }
        public static void UpdateForBKS(int RepresentativeId, double BKS_A, double BKS_B, double BKS_C, int BKS_IsValid)
        {
            new RepresentativeDAL().UpdateForBKS(RepresentativeId, BKS_A, BKS_B, BKS_C, BKS_IsValid);
        }
        public static void UpdateForBQ_DL(int RepresentativeId, int BQ_DL, int BQ_DL_IsValid)
        {
            new RepresentativeDAL().UpdateForBQ_DL(RepresentativeId, BQ_DL, BQ_DL_IsValid);
        }

        public static void UpdateForBQ_KDTLKTNY(int RepresentativeId, int BQ_KD, int BQ_TL, int BQ_KT, int BQ_NY, int BQ_CTTGD, int BQ_KDTLKTNY_IsValid)
        {
            new RepresentativeDAL().UpdateForBQ_KDTLKTNY(RepresentativeId, BQ_KD, BQ_TL, BQ_KT, BQ_NY, BQ_CTTGD, BQ_KDTLKTNY_IsValid);
        }

        public static void UpdateForBQ_CTTGD(int RepresentativeId, int BQ_CTTGD)
        {
            new RepresentativeDAL().UpdateForBQ_CTTGD(RepresentativeId, BQ_CTTGD);
        }

        public static void UpdateForBQ_SLHDQT(int RepresentativeId, int BQ_SLHDQT, int BQ_SLHDQT_IsValid)
        {
            new RepresentativeDAL().UpdateForBQ_SLHDQT(RepresentativeId, BQ_SLHDQT, BQ_SLHDQT_IsValid);
        }

        //public static void Delete(int decisionId)
        //{
        //    new RepresentativeDAL().Delete(decisionId);
        //}

        #endregion
    }
}
