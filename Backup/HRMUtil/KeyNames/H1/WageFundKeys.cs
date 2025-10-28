using System;
using System.Text;

namespace HRMUtil.KeyNames.H1
{
    sealed public class WageFundKeys
    {
        /// <summary>
        /// Some fields in H1_WageFunds table
        /// </summary>
        public const string Field_Wage_Fund_ID = "WageFundId";
        public const string Field_Wage_Fund_RootId = "RootId";
        public const string Field_Wage_Fund_RootName = "RootName";
        public const string Field_Wage_Fund_LNSOriginalWageFund = "LNSOriginalWageFund";
        public const string Field_Wage_Fund_LNSShortTermWageFund = "LNSShortTermWageFund";
        public const string Field_Wage_Fund_LNSNoKWageFund = "LNSNoKWageFund";
        public const string Field_Wage_Fund_BonusOriginalWageFund = "BonusOriginalWageFund";        
        public const string Field_Wage_Fund_LNSCoefficientNoKTotal = "LNSCoefficientNoKTotal";
        public const string Field_Wage_Fund_LNSPCTNCoefficientNoKTotal = "LNSPCTNCoefficientNoKTotal";
        public const string Field_Wage_Fund_LNSKWageFund = "LNSKWageFund";
        public const string Field_Wage_Fund_BonusKWageFund = "BonusKWageFund";
        public const string Field_Wage_Fund_LNSBalanceWageFund = "LNSBalanceWageFund";
        public const string Field_Wage_Fund_BonusBalanceWageFund = "BonusBalanceWageFund";
        public const string Field_Wage_Fund_ApportionmentType = "ApportionmentType";
        public const string Field_Wage_Fund_Remark = "Remark";
        public const string Field_Wage_Fund_CreateDate = "CreateDate";        

        /// <summary>
        /// store procedure for H1_WageFunds table
        /// </summary>
        /// 
        public const string Sp_Ins_H1_WageFund_By_Coefficient = "Ins_H1_WageFund_By_Coefficient";        
        public const string Sp_Del_H1_WageFund_By_Date = "Del_H1_WageFund_By_Date";
        public const string Sp_Upd_H1_WageFund_By_OriginalWageFund = "Upd_H1_WageFund_By_OriginalWageFund";
        public const string Sp_Upd_H1_WageFund_By_ShortTerm = "Upd_H1_WageFund_By_ShortTerm";
        public const string Sp_Upd_H1_WageFund_By_NoKWageFund = "Upd_H1_WageFund_By_NoKWageFund";
        public const string Sp_Upd_H1_WageFund_By_TotalPeriod_II = "Upd_H1_WageFund_By_TotalPeriod_II";
        public const string Sp_Upd_H1_WageFund_By_Apportionment = "Upd_H1_WageFund_By_Apportionment";

        public const string Sp_Sel_H1_WageFund_By_All = "Sel_H1_WageFund_By_All";
        public const string Sp_Sel_H1_WageFund_By_CreateDate = "Sel_H1_WageFund_By_CreateDate";
        
    }
}
