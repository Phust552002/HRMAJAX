using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H5;
using HRMUtil.KeyNames.H5;
using HRMUtil.KeyNames.H0;
using HRMUtil;

namespace HRMBLL.H5
{
    public class TravelerListBLL
    {

        public static int Status_Save = 0;
        public static string Status_Save_Name = "Cập nhật/Gửi";
        public static int Status_Send = 1;
        public static string Status_Send_Name = "Đã gửi";
        public static int Status_Manager_Approved = 2;
        public static string Status_Manager_Approved_Name = "Phòng đã duyệt";
        
        public static int Status_Manager_Approved_NotAgree = -2;
        public static string Status_Manager_Approved_NotAgree_Name = "Phòng đã duyệt (Không đồng ý)";

        public static int Status_HRAdmin_Approved = 3;
        public static string Status_HRAdmin_Approved_Name = "TCHC đã duyệt";

        public static int Status_HRAdmin_Approved_NotAgree = -3;
        public static string Status_HRAdmin_Approved_NotAgree_Name = "TCHC đã duyệt (Không đồng ý)";

        

        #region Methods Get

        public static string GetStatusNameByStatus(int status)
        {

            if (status == Status_Save)
                return Status_Save_Name;
            else if (status == Status_Send)
                return Status_Send_Name;
            else if (status == Status_Manager_Approved)
                return Status_Manager_Approved_Name;
            else if (status == Status_HRAdmin_Approved)
                return Status_HRAdmin_Approved_Name;
            else if (status == Status_Manager_Approved_NotAgree)
                return Status_Manager_Approved_NotAgree_Name;
            else
                return "";
        }

        public static DataTable GetByUserIdYearForDistinctTourStageName(int Year, int UserId, int TourStageId, string deptIds, int RootId, string fullName)
        {

            return new TravelerListDAL().GetByUserIdYearForDistinctTourStageName(Year, UserId, TourStageId, deptIds, RootId, fullName);
        }

        public static DataTable GetByTourStageIdDept(int TourStageId, string deptIds, int RootId, string fullName)
        {

            return new TravelerListDAL().GetByTourStageIdDept(TourStageId, deptIds, RootId, fullName);
        }

        public static DataTable GetByUserIdTourStageId(int UserId, int TourStageId)
        {

            return new TravelerListDAL().GetByUserIdTourStageId(UserId, TourStageId);
        }

        public static DataRow GetByTravelerId(int TravelerId)
        {
            DataTable dr = new TravelerListDAL().GetByTravelerId(TravelerId);
            if (dr.Rows.Count==1)
            {
                return dr.Rows[0];
            }
            else
            {
                return null;
            }
        }
        public static bool CheckEligibilityByUserId(int UserId)
        {
            return new TravelerListDAL().CheckEligibilityByUserId(UserId);
        }

        #endregion


        #region methods inset, update , delete

        public static void Insert(int UserId, int TourStageId, string KinName, string KinType, DateTime KinBirthday, string KinPhoneNumber, string Remark, int Status)
        {

            new TravelerListDAL().Insert(UserId, TourStageId, KinName, KinType, KinBirthday, KinPhoneNumber, Remark, Status);
        }

        public static void Update(int UserId, int TourStageId, string KinName, string KinType, DateTime KinBirthday, string KinPhoneNumber, string Remark, int Status, int @TravelerId)
        {

            new TravelerListDAL().Update(UserId, TourStageId, KinName, KinType, KinBirthday, KinPhoneNumber, Remark, Status, TravelerId);

        }
        public static void UpdateStatus(int UserId, int TourStageId, int Status, int TravelerId)
        {
            new TravelerListDAL(). UpdateStatus(UserId, TourStageId, Status, TravelerId);
        }

        public static void UpdateStatusByManager(int UserId, int TourStageId, int Status, int ManagerApprovedId, string ManagerApprovedRemark)
        {
            new TravelerListDAL().UpdateStatusByManager(UserId, TourStageId, Status, ManagerApprovedId, ManagerApprovedRemark);
        }
        public static void UpdateStatusUpdateStatusByHRD(int UserId, int TourStageId, int Status, int HRDApprovedId, string HRDApprovedRemark)
        {
            new TravelerListDAL().UpdateStatusByHRD(UserId, TourStageId, Status, HRDApprovedId, HRDApprovedRemark);
        }

        public static void Delete(int TravelerId)
        {

            new TravelerListDAL().Delete(TravelerId);

        }

        #endregion
    }
}
