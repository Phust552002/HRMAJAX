using System;
using System.Text;

namespace HRMUtil.KeyNames.H5
{
    public sealed class TourStageKeys
    {
        public const string Field_TourStage_TourStageId = "TourStageId";
        public const string Field_TourStage_TourStageName = "TourStageName";
        public const string Field_TourStage_FromDate = "FromDate";
        public const string Field_TourStage_ToDate = "ToDate";
        public const string Field_TourStage_Cost = "Cost";
        public const string Field_TourStage_MoreCost = "MoreCost";
        public const string Field_TourStage_Provider = "Provider";

        /// <summary>
        /// some store procedures H4_TourStage table
        /// </summary>

        public const string Sp_Sel_H5_TourStageByYear = "Sel_H5_TourStageByYear";
    }
}
