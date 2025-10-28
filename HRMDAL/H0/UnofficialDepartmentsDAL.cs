using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H0;

namespace HRMDAL.H0
{
    public class UnofficialDepartmentsDAL : Dao
    {


        #region Methods Get       

        public DataTable GetAllRoots(int DirectOrInDirect)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param = 
				{
					new SqlParameter("@DirectOrInDirect",SqlDbType.Int),
				};
                param[0].Value = DirectOrInDirect;

                sproc = new StoreProcedure(UnofficialDepartmentKeys.SP_UNOFFICIAL_DEPARTMENT_GET_ALL_ROOT, param);
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

        
        public DataTable GetDepartmentRoot()
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                sproc = new StoreProcedure(UnofficialDepartmentKeys.SP_UNOFFICIAL_DEPARTMENT_GET_ROOT, null);
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


        public DataTable GetDepartmentSubLevel(int parentId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {

                SqlParameter[] param = 
				{
					new SqlParameter("@ParentId",SqlDbType.Int),
				};
                param[0].Value = parentId;
                sproc = new StoreProcedure(UnofficialDepartmentKeys.SP_UNOFFICIAL_DEPARTMENT_GETALL_SUB_LEVEL, param);
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

        public DataTable GetDepartmentSubLevelByRootIdDepartmentId(int parentId, int rootId, int departmentId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {

                SqlParameter[] param =
                {
                    new SqlParameter("@ParentId",SqlDbType.Int),
                    new SqlParameter("@RootId",SqlDbType.Int),
                    new SqlParameter("@DepartmentId",SqlDbType.Int),
                };
                param[0].Value = parentId;
                param[1].Value = rootId;
                param[2].Value = departmentId;

                sproc = new StoreProcedure(UnofficialDepartmentKeys.SP_UNOFFICIAL_DEPARTMENTS_SUBLEVEL_BY_ROOTID_DEPARTMENTID, param);
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


        public DataTable GetByIds(string departmentIds)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param = 
                {                                
                    new SqlParameter("@DepartmentIds",SqlDbType.VarChar, 254)                    
                };

                param[0].Value = departmentIds == null ? string.Empty : departmentIds;

                sproc = new StoreProcedure(UnofficialDepartmentKeys.SP_SEL_H0_UNOFFICIAL_DEPARTMENTS_BY_IDS, param);
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
