using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H0;

namespace HRMDAL.H0
{
    public class PositionsDAL : Dao
    {

        #region Methods Get

        public DataTable GetAll()
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                sproc = new StoreProcedure(PositionKeys.Sp_Sel_H0_Positions_All, null);
                sproc.RunFill(datatable);
                sproc.Dispose();
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return datatable;

        }
        public DataTable GetByFilter(string positionName, int LevelPosition, int DepartmentId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
				{                                
					new SqlParameter("@PositionName",SqlDbType.NVarChar,100),					
                    new SqlParameter("@LevelPosition",SqlDbType.Int,4),
                    new SqlParameter("@DepartmentId",SqlDbType.Int,4)
				};

                param[0].Value = positionName;                
                param[1].Value = LevelPosition;
                param[2].Value = DepartmentId;

                sproc = new StoreProcedure(PositionKeys.Sp_Sel_H0_Positions_ByFilter, param);
                sproc.RunFill(datatable);
                sproc.Dispose();
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return datatable;

        }
        //public DataTable GetByIds(string positionIds)
        //{

        //    Debug.Assert(sproc == null);
        //    DataTable datatable = new DataTable();
        //    try
        //    {
        //        SqlParameter[] param = 
        //        {                                
        //            new SqlParameter("@PositionIds",SqlDbType.VarChar,1000),					
        //        };

        //        param[0].Value = positionIds;

        //        sproc = new StoreProcedure(PositionKeys.SP_POSITION_GET_BY_IDs, param);
        //        sproc.RunFill(datatable);
        //        sproc.Dispose();
        //    }
        //    catch (SqlException se)
        //    {
        //        throw new HRMException(se.Message, se.Number);
        //    }

        //    return datatable;

        //}

        
        //public DataTable GetIsRecruitment()
        //{

        //    Debug.Assert(sproc == null);
        //    DataTable datatable = new DataTable();
        //    try
        //    {
        //        sproc = new StoreProcedure(PositionKeys.SP_POSITION_IS_RECRUITMENT, null);
        //        sproc.RunFill(datatable);
        //        sproc.Dispose();
        //    }
        //    catch (SqlException se)
        //    {
        //        throw new HRMException(se.Message, se.Number);
        //    }

        //    return datatable;

        //}

        #endregion


        #region methods inset, update , delete

        public long Insert(string positionName, string description, int LevelPosition, int DepartmentId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
					new SqlParameter("@PositionName",SqlDbType.NVarChar,100),
					new SqlParameter("@Description",SqlDbType.NVarChar,1000),
                    new SqlParameter("@LevelPosition",SqlDbType.Int,4),
                    new SqlParameter("@DepartmentId",SqlDbType.Int,4)
				};

                param[0].Value = positionName;
                param[1].Value = description;
                param[2].Value = LevelPosition;
                param[3].Value = DepartmentId;

                sproc = new StoreProcedure(PositionKeys.Sp_Ins_H0_Position, param);
                identity = sproc.Run();
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

        public long Update(int positionId, string positionName, string description, int LevelPosition, int DepartmentId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
                    new SqlParameter("@PositionId",SqlDbType.Int),
					new SqlParameter("@PositionName",SqlDbType.NVarChar,100),
					new SqlParameter("@Description",SqlDbType.NVarChar,1000),
                    new SqlParameter("@LevelPosition",SqlDbType.Int,4),
                    new SqlParameter("@DepartmentId",SqlDbType.Int,4)
				};

                param[0].Value = positionId;
                param[1].Value = positionName;
                param[2].Value = description;
                param[3].Value = LevelPosition;
                param[4].Value = DepartmentId;

                sproc = new StoreProcedure(PositionKeys.Sp_Upd_H0_Position, param);
                identity = sproc.Run();
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

        public long Delete(int positionId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param = 
				{                                
                    new SqlParameter("@PositionId",SqlDbType.Int)
				};

                param[0].Value = positionId;

                sproc = new StoreProcedure(PositionKeys.SP_POSITION_DELETE, param);
                identity = sproc.Run();
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
