using System;
using System.Text;

namespace HRMUtil.KeyNames.H0
{
    public sealed class EmployeeContractKeys
    {
        /// <summary>
        /// Some field names of H0_EmployeeContract table
        /// </summary>
        /// 
        public const string Field_EmployeeContract_EmployeeContractId = "EmployeeContractId";
        public const string Field_EmployeeContract_PreviousEmployeeContractId = "PreviousEmployeeContractId";
        public const string Field_EmployeeContract_Wages = "Wages";
        public const string Field_EmployeeContract_Unit = "Unit";
        public const string Field_EmployeeContract_FromDate = "FromDate";
        public const string Field_EmployeeContract_ToDate = "ToDate";
        public const string Field_EmployeeContract_Description = "Description";
        public const string Field_EmployeeContract_Active = "Active";
        public const string Field_EmployeeContract_ContractNo = "ContractNo";
        public const string Field_EmployeeContract_ContractName = "ContractName";
        public const string Field_EmployeeContract_RepresentativeOfCompany = "RepresentativeOfCompany";
        public const string Field_EmployeeContract_CompanyName = "CompanyName";
        public const string Field_EmployeeContract_AttachFileName = "AttachFileName";
        public const string Field_EmployeeContract_WorkingName = "WorkingName";
        public const string Field_EmployeeContract_WorkingHour = "WorkingHour";
        public const string Field_EmployeeContract_Overtime = "Overtime";
        public const string Field_EmployeeContract_SalaryType = "SalaryType";

        

        /// <summary>
        /// StoreProcedure name of H0_EmployeeContract object.
        /// </summary>
        public const string Sp_Ins_H0_EmployeeContract = "Ins_H0_EmployeeContract";
        public const string Sp_Upd_H0_EmployeeContract = "Upd_H0_EmployeeContract";
        public const string Sp_Del_H0_EmployeeContract = "Del_H0_EmployeeContract";
        public const string Sp_Del_H0_EmployeeContractByIds = "Del_H0_EmployeeContractByIds";

        public const string Sp_Ins_H0_EmployeeContractDecisions = "Ins_H0_EmployeeContractDecisions";
        public const string Sp_Upd_H0_EmployeeContractDecisions = "Upd_H0_EmployeeContractDecisions";

        public const string Sp_Sel_H0_EmployeeContractById = "Sel_H0_EmployeeContractById";
        public const string Sp_Sel_H0_EmployeeContractByDecisionId = "Sel_H0_EmployeeContractByDecisionId";
        public const string Sp_Sel_H0_EmployeeContractByFilter = "Sel_H0_EmployeeContractByFilter";        
        public const string Sp_Sel_H0_EmployeeContract_Active_By_UserId = "Sel_H0_EmployeeContract_Active_By_UserId";
        public const string Sp_H0_EmployeeContract_By_UserId_Date_Active = "Sel_H0_EmployeeContract_By_UserId_Date_Active";
        public const string Sp_Sel_H0_EmployeeContractByRemind = "Sel_H0_EmployeeContractByRemind";
        public const string Sp_Sel_H0_EmployeeContractByChanged = "Sel_H0_EmployeeContractByChanged";
        public const string Sp_Sel_H0_EmployeeContract_By_UserId_FromToDate = "Sel_H0_EmployeeContract_By_UserId_FromToDate";

        public const string Sp_Sel_H0_EmployeeContractByUserId = "Sel_H0_EmployeeContractByUserId";
    }
}
