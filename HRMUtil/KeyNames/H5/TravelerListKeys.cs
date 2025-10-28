using System;
using System.Text;

namespace HRMUtil.KeyNames.H5
{
    public sealed class TravelerListKeys
    {

        public const string Field_TravelerList_UserId = "UserId";
        public const string Field_TravelerList_TourStageId = "TourStageId";
        public const string Field_TravelerList_KinName = "KinName";
        public const string Field_TravelerList_KinType = "KinType";
        public const string Field_TravelerList_KinBirthday = "KinBirthday";
        public const string Field_TravelerList_KinPhoneNumber = "KinPhoneNumber";
        public const string Field_TravelerList_Remark = "Remark";

        /// <summary>
        /// some store procedures H4_TravelerList table
        /// </summary>

        public const string Sp_Ins_H5_TravelerList = "Ins_H5_TravelerList";
        public const string Sp_Upd_H5_TravelerList = "Upd_H5_TravelerList";
        public const string Sp_Del_H5_TravelerList = "Del_H5_TravelerList";
        public const string Sp_Upd_H5_TravelerListForStatus = "Upd_H5_TravelerListForStatus";
        public const string Sp_Upd_H5_TravelerListByManagerForStatus = "Upd_H5_TravelerListByManagerForStatus";
        public const string Sp_Upd_H5_TravelerListByHRDForStatus = "Upd_H5_TravelerListByHRDForStatus";

        

        public const string Sp_Sel_H5_TravelerListByUserIdYearForDistinctTourStageName = "Sel_H5_TravelerListByUserIdYearForDistinctTourStageName";
        public const string Sp_Sel_H5_TravelerListByUserIdTourStageId = "Sel_H5_TravelerListByUserIdTourStageId";
        public const string Sp_Sel_H5_TravelerListByTravelerId = "Sel_H5_TravelerListByTravelerId";

        public const string Sp_Sel_H5_TravelerListByTourStageIdDept = "Sel_H5_TravelerListByTourStageIdDept";
        public const string Sp_Sel_H5_TravelEligibilityByUserId = "Sel_H5_TravelEligibilityByUserId";
    }
}
