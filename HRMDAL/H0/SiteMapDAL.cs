using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H0;

namespace HRMDAL.H0
{
    public class SiteMapDAL : Dao
    {
        #region get

        public DataTable GetAllRoots()
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {

                sproc = new StoreProcedure(SiteMapKeyNames.SP_SITE_MAP_GET_BY_ROOTS, null);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return dt;

        }

        public DataTable GetByParentId(int parentId)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
                {                                
                    new SqlParameter("@ParentId",SqlDbType.Int)                    
                };

                param[0].Value = parentId;

                sproc = new StoreProcedure(SiteMapKeyNames.SP_SITE_MAP_GET_BY_PARENT_ID, param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }
                        return dt;

        }

        public DataTable GetByRoles(string roleIds)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@RoleId",SqlDbType.Int)
                };

                param[0].Value = roleIds;

                sproc = new StoreProcedure("Sel_SiteMap_By_RoleId", param);
                sproc.RunFill(dt);
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }
            finally
            {
                sproc.Dispose();
            }

            return dt;

        }

        #endregion
    }
}
