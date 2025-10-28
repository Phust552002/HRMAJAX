using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H5;

namespace HRMDAL.H5
{
    public class TravelerListDAL : Dao
    {

        #region Methods Get

        public DataTable GetByUserIdYearForDistinctTourStageName(int Year, int UserId, int TourStageId, string deptIds, int RootId, string FullName)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {

                SqlParameter[] param = 
                {                     
                    new SqlParameter("@Year", SqlDbType.Int, 4),                                       
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@TourStageId", SqlDbType.Int, 4),
                    new SqlParameter("@deptIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@RootId", SqlDbType.Int, 4),
                    new SqlParameter("@FullName", SqlDbType.NVarChar, 254)
                };

                param[0].Value = Year;
                param[1].Value = UserId;
                param[2].Value = TourStageId;
                param[3].Value = deptIds;
                param[4].Value = RootId;
                param[5].Value = FullName;

                sproc = new StoreProcedure(TravelerListKeys.Sp_Sel_H5_TravelerListByUserIdYearForDistinctTourStageName, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;

        }

        public DataTable GetByTourStageIdDept(int TourStageId, string deptIds, int RootId, string FullName)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {

                SqlParameter[] param = 
                {                     
                    new SqlParameter("@TourStageId", SqlDbType.Int, 4),
                    new SqlParameter("@deptIds", SqlDbType.VarChar, 1000),
                    new SqlParameter("@RootId", SqlDbType.Int, 4),
                    new SqlParameter("@FullName", SqlDbType.NVarChar, 254)
                };

                param[0].Value = TourStageId;
                param[1].Value = deptIds;
                param[2].Value = RootId;
                param[3].Value = FullName;

                sproc = new StoreProcedure(TravelerListKeys.Sp_Sel_H5_TravelerListByTourStageIdDept, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;

        }

        public DataTable GetByUserIdTourStageId(int UserId, int TourStageId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {

                SqlParameter[] param = 
                {                                         
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@TourStageId", SqlDbType.Int, 4)
                };

                param[0].Value = UserId;
                param[1].Value = TourStageId;


                sproc = new StoreProcedure(TravelerListKeys.Sp_Sel_H5_TravelerListByUserIdTourStageId, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;

        }

        public bool CheckEligibilityByUserId(int userId)
        {
            Debug.Assert(sproc == null);
            bool ok = false;
            DataTable datatable = new DataTable();
            try
            {

                SqlParameter[] param =
                {
                    new SqlParameter("@UserId", SqlDbType.Int, 4)
                };

                param[0].Value = userId;


                sproc = new StoreProcedure(TravelerListKeys.Sp_Sel_H5_TravelEligibilityByUserId, param);
                sproc.RunFill(datatable);

                if (datatable != null && datatable.Rows.Count > 0)
                    ok = true;
                else
                    ok = false;
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }
            return ok;
        }

        public DataTable GetByTravelerId(int TravelerId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {

                SqlParameter[] param = 
                {                                         
                    new SqlParameter("@TravelerId", SqlDbType.Int, 4)
                };

                param[0].Value = TravelerId;


                sproc = new StoreProcedure(TravelerListKeys.Sp_Sel_H5_TravelerListByTravelerId, param);
                sproc.RunFill(datatable);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return datatable;

        }

        #endregion


        #region methods inset, update , delete

        public int Insert(int UserId, int TourStageId, string KinName, string KinType, DateTime KinBirthday, string KinPhoneNumber, string Remark, int Status)
        {

            Debug.Assert(sproc == null);
            int identity = 0;

            try
            {

                SqlParameter[] param = 
                {                                                        
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@TourStageId", SqlDbType.Int, 4),
                    new SqlParameter("@KinName", SqlDbType.NVarChar, 254),
                    new SqlParameter("@KinType", SqlDbType.NVarChar, 50),
                    new SqlParameter("@KinBirthday",SqlDbType.DateTime2),
                    new SqlParameter("@KinPhoneNumber", SqlDbType.NVarChar, 50),
                    new SqlParameter("@Remark", SqlDbType.NVarChar, 1000),
                    new SqlParameter("@Status", SqlDbType.Int, 4)
                };


                param[0].Value = UserId;
                param[1].Value = TourStageId;
                param[2].Value = KinName;
                param[3].Value = KinType;
                param[4].Value = KinBirthday;
                param[5].Value = KinPhoneNumber;
                param[6].Value = Remark;
                param[7].Value = Status;
                
                sproc = new StoreProcedure(TravelerListKeys.Sp_Ins_H5_TravelerList, param);
                identity = sproc.RunInt();
                sproc.Commit();

            }
            catch (SqlException se)
            {
                sproc.RollBack();
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return identity;

        }

        public int Update(int UserId, int TourStageId, string KinName, string KinType, DateTime KinBirthday, string KinPhoneNumber, string Remark, int Status, int TravelerId)
        {

            Debug.Assert(sproc == null);
            int identity = 0;

            try
            {

                SqlParameter[] param = 
                {                                                        
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@TourStageId", SqlDbType.Int, 4),
                    new SqlParameter("@KinName", SqlDbType.NVarChar, 254),
                    new SqlParameter("@KinType", SqlDbType.NVarChar, 50),
                    new SqlParameter("@KinBirthday",SqlDbType.DateTime2),
                    new SqlParameter("@KinPhoneNumber", SqlDbType.NVarChar, 50),
                    new SqlParameter("@Remark", SqlDbType.NVarChar, 1000),
                    new SqlParameter("@Status", SqlDbType.Int, 4),
                    new SqlParameter("@TravelerId", SqlDbType.Int, 4)
                };


                param[0].Value = UserId;
                param[1].Value = TourStageId;
                param[2].Value = KinName;
                param[3].Value = KinType;
                param[4].Value = KinBirthday;
                param[5].Value = KinPhoneNumber;
                param[6].Value = Remark;
                param[7].Value = Status;
                param[8].Value = TravelerId;

                sproc = new StoreProcedure(TravelerListKeys.Sp_Upd_H5_TravelerList, param);
                identity = sproc.RunInt();
                sproc.Commit();

            }
            catch (SqlException se)
            {
                sproc.RollBack();
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return identity;

        }

        public int UpdateStatus(int UserId, int TourStageId, int Status, int TravelerId)
        {

            Debug.Assert(sproc == null);
            int identity = 0;

            try
            {

                SqlParameter[] param = 
                {                                                        
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@TourStageId", SqlDbType.Int, 4),
                    new SqlParameter("@Status", SqlDbType.Int, 4),
                    new SqlParameter("@TravelerId", SqlDbType.Int, 4)
                };


                param[0].Value = UserId;
                param[1].Value = TourStageId;
                param[2].Value = Status;
                param[3].Value = TravelerId;

                sproc = new StoreProcedure(TravelerListKeys.Sp_Upd_H5_TravelerListForStatus, param);
                identity = sproc.RunInt();
                sproc.Commit();

            }
            catch (SqlException se)
            {
                sproc.RollBack();
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return identity;

        }

        public int UpdateStatusByManager(int UserId, int TourStageId, int Status, int ManagerApprovedId, string ManagerApprovedRemark)
        {

            Debug.Assert(sproc == null);
            int identity = 0;

            try
            {

                SqlParameter[] param = 
                {                                                        
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@TourStageId", SqlDbType.Int, 4),
                    new SqlParameter("@Status", SqlDbType.Int, 4),
                    new SqlParameter("@ManagerApprovedId", SqlDbType.Int, 4),
                    new SqlParameter("@ManagerApprovedRemark", SqlDbType.NVarChar, 250)
                };


                param[0].Value = UserId;
                param[1].Value = TourStageId;
                param[2].Value = Status;
                param[3].Value = ManagerApprovedId;
                param[4].Value = ManagerApprovedRemark;

                sproc = new StoreProcedure(TravelerListKeys.Sp_Upd_H5_TravelerListByManagerForStatus, param);
                identity = sproc.RunInt();
                sproc.Commit();

            }
            catch (SqlException se)
            {
                sproc.RollBack();
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return identity;

        }

        public int UpdateStatusByHRD(int UserId, int TourStageId, int Status, int HRDApprovedId, string HRDApprovedRemark)
        {

            Debug.Assert(sproc == null);
            int identity = 0;

            try
            {

                SqlParameter[] param = 
                {                                                        
                    new SqlParameter("@UserId", SqlDbType.Int, 4),
                    new SqlParameter("@TourStageId", SqlDbType.Int, 4),
                    new SqlParameter("@Status", SqlDbType.Int, 4),
                    new SqlParameter("@HRDApprovedId", SqlDbType.Int, 4),
                    new SqlParameter("@HRDApprovedRemark", SqlDbType.NVarChar, 250)
                };


                param[0].Value = UserId;
                param[1].Value = TourStageId;
                param[2].Value = Status;
                param[3].Value = HRDApprovedId;
                param[4].Value = HRDApprovedRemark;

                sproc = new StoreProcedure(TravelerListKeys.Sp_Upd_H5_TravelerListByHRDForStatus, param);
                identity = sproc.RunInt();
                sproc.Commit();

            }
            catch (SqlException se)
            {
                sproc.RollBack();
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return identity;

        }

        public long Delete(int TravelerId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
                {                                                        
                    new SqlParameter("@TravelerId", SqlDbType.Int, 4)
                };


                param[0].Value = TravelerId;
                

                sproc = new StoreProcedure(TravelerListKeys.Sp_Del_H5_TravelerList, param);
                identity = sproc.RunInt();
                sproc.Commit();

            }
            catch (SqlException se)
            {
                sproc.RollBack();
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return identity;

        }

        #endregion
    }
}
