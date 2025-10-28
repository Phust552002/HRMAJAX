using System;
using System.Text;

namespace HRMUtil.KeyNames.H1
{
    sealed public class WorkdayOverTimeKeys
    {

        /// <summary>
        /// Some fields in H1_WorkdayOverTime table
        /// </summary>
        /// 

        public const string Field_WorkdayOverTime_OverTimeId = "OverTimeId";
        public const string Field_WorkdayOverTime_UserId = "UserId";
        public const string Field_WorkdayOverTime_OverTimeDate = "OverTimeDate";
        public const string Field_WorkdayOverTime_OverTimeType = "OverTimeType";
        public const string Field_WorkdayOverTime_OverTimeHours = "OverTimeHours";
        public const string Field_WorkdayOverTime_OverTimeRemark = "OverTimeRemark";
        public const string Field_WorkdayOverTime_OTUpdatedUserId = "OTUpdatedUserId";
        public const string Field_WorkdayOverTime_OTUpdatedDatetime = "OTUpdatedDatetime";


        /// <summary>
        /// store procedure for 
        /// </summary>
        /// 
        public const string Sp_Ins_H1_WorkdayOverTime = "Ins_H1_WorkdayOverTime";
        public const string Sp_Upd_H1_WorkdayOverTime = "Upd_H1_WorkdayOverTime";        
        public const string Sp_Del_H1_WorkdayOverTimeByUserDate = "Del_H1_WorkdayOverTimeByUserDate";
        public const string Sp_Del_H1_WorkdayOverTimeById = "Del_H1_WorkdayOverTimeById";

        public const string Sp_Sel_H1_WorkdayOverTimeByFilter = "Sel_H1_WorkdayOverTimeByFilter";

    }
}
