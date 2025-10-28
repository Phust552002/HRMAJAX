using System;
using System.Text;

namespace HRMUtil.KeyNames.H1
{
    sealed public class IncomeKeys
    {

        /// <summary>
        /// Some field names of Incomes table
        /// </summary>
        /// 

        public const string Field_Income_ID = "IncomeId";
        public const string Field_Income_LNS = "LNS";
        public const string Field_Income_LCBNN = "LCBNN";
        public const string Field_Income_PCCV = "PCCV";
        public const string Field_Income_PCTN = "PCTN";
        public const string Field_Income_PCDH = "PCDH";
        public const string Field_Income_TCBHXH = "TCBHXH";
        public const string Field_Income_TCOm = "TCOm";
        public const string Field_Income_TCTS1Lan = "TCTS1Lan";
        public const string Field_Income_TienAn = "TienAn";
        public const string Field_Income_BoSungLuong = "BoSungLuong";
        public const string Field_Income_TienThemGio = "TienThemGio";
        public const string Field_Income_TienLamDem = "TienLamDem";
        public const string Field_Income_TienThuong = "TienThuong";
        public const string Field_Income_TrBHXH = "TrBHXH";
        public const string Field_Income_TrBHYT = "TrBHYT";
        public const string Field_Income_TrBHTN = "TrBHTN";
        public const string Field_Income_TrDoanPhi = "TrDoanPhi";
        public const string Field_Income_ThueThuNhap = "ThueThuNhap";
        public const string Field_Income_TotalIncome = "TotalIncome";
        public const string Field_Income_TotalIncomeForTax = "TotalIncomeForTax";
        public const string Field_Income_IsChangeContract = "IsChangeContract";
        public const string Field_Income_TotalShortTerm = "TotalShortTerm";
        public const string Field_Income_TotalPeriod_I = "TotalPeriod_I";
        public const string Field_Income_TotalPeriod_II = "TotalPeriod_II";
        public const string Field_Income_CalculatingLog1 = "CalculatingLog1";
        public const string Field_Income_CalculatingLog2 = "CalculatingLog2";
        public const string Field_Income_CalculatingLog3 = "CalculatingLog3";
        public const string Field_Income_FinalConversionLNSCoefficient = "FinalConversionLNSCoefficient";
        public const string Field_Income_FinalConversionLNSCoefficientLog = "FinalConversionLNSCoefficientLog";
        public const string Field_Income_LNSBalance = "LNSBalance";
        public const string Field_Income_BonusBalance = "BonusBalance";
        public const string Field_Income_CREATE_DATE = "CreateDate";
        public const string Field_Income_LOCK = "Lock";              
        public const string Field_Income_Remark = "Remark";
        public const string Field_Income_Type = "Type";



        public const string Field_Income_TotalLNS = "TotalLNS";
        public const string Field_Income_TotalLCBNN = "TotalLCBNN";
        public const string Field_Income_TotalPCCV = "TotalPCCV";
        public const string Field_Income_TotalPCTN = "TotalPCTN";
        public const string Field_Income_TotalPCDH = "TotalPCDH";
        public const string Field_Income_TotalTCBHXH = "TotalTCBHXH";
        public const string Field_Income_TotalTCOm = "TotalTCOm";
        public const string Field_Income_TotalTCTS1Lan = "TotalTCTS1Lan";
        public const string Field_Income_TotalTienAn = "TotalTienAn";
        public const string Field_Income_TotalBoSungLuong = "TotalBoSungLuong";
        public const string Field_Income_TotalTienThemGio = "TotalTienThemGio";
        public const string Field_Income_TotalTienLamDem = "TotalTienLamDem";
        public const string Field_Income_TotalTienThuong = "TotalTienThuong";
        public const string Field_Income_TotalTrBHXH = "TotalTrBHXH";
        public const string Field_Income_TotalTrBHYT = "TotalTrBHYT";
        public const string Field_Income_TotalTrBHTN = "TotalTrBHTN";
        public const string Field_Income_TotalTrDoanPhi = "TotalTrDoanPhi";
        public const string Field_Income_TotalThueThuNhap = "TotalThueThuNhap";
        public const string Field_Income_TotalTotalIncome = "TotalTotalIncome";
        public const string Field_Income_TotalTotalIncomeForTax = "TotalTotalIncomeForTax";
        public const string Field_Income_TotalTotalShortTerm = "TotalTotalShortTerm";
        public const string Field_Income_TotalTotalPeriod_I = "TotalTotalPeriod_I";
        public const string Field_Income_TotalTotalPeriod_II = "TotalTotalPeriod_II";
        public const string Field_Income_TotalLNSBalance = "TotalLNSBalance";
        public const string Field_Income_TotalBonusBalance = "TotalBonusBalance";


        /// <summary>
        /// StoreProcedure name of Incomes object.
        /// </summary>
        public const string Sp_Ins_H1_Income_ShortTerm = "Ins_H1_Income_ShortTerm";
        public const string Sp_Del_H1_Incomes_By_Root_Date = "Del_H1_Incomes_By_Root_Date";
        public const string Sp_Upd_H1_Income_By_Period_II = "Upd_H1_Income_By_Period_II";
        public const string Sp_Upd_H1_Income_By_Period_III = "Upd_H1_Income_By_Period_III";

        public const string SP_INCOME_GET_BY_FILTER = "Sel_H1_EmployeeIncomeByFilter";
        public const string Sp_Sel_H1_EmployeeIncomeByFilter1 = "Sel_H1_EmployeeIncomeByFilter1";
        public const string Sp_Sel_H1_EmployeeIncome_By_UserId_Date = "Sel_H1_EmployeeIncome_By_UserId_Date";

        public const string Sp_Sel_H1_EmployeeIncome_By_RootDate_ForTotal = "Sel_H1_EmployeeIncome_By_RootDate_ForTotal";

    }
}
