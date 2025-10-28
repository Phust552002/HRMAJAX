using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H6;

namespace HRMDAL.H6
{
    public class DepartmentsDAL : Dao
    {

        #region methods inset, update , delete

        public long Insert(int parentId, string departmentName, string description)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param =
                {
                    new SqlParameter("@ParentId",SqlDbType.Int),
                    
                    new SqlParameter("@DepartmentName",SqlDbType.NVarChar,254),
                    
                    new SqlParameter("@Description",SqlDbType.NVarChar,254),

                };

                param[0].Value = parentId;
                
                param[1].Value = departmentName;
              
                param[2].Value = description;

                sproc = new StoreProcedure(DepartmentKeys.SP_DEPARTMENT_INSERT, param);
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

        public long Update(string departmentName, string description, int departmentId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param =
                {

               
                    new SqlParameter("@DepartmentName",SqlDbType.NVarChar,254),                 
                    new SqlParameter("@Description",SqlDbType.NVarChar,254),
                    new SqlParameter("@DepartmentId",SqlDbType.Int)
                };

              
                param[0].Value = departmentName;
               
                param[1].Value = description;
                param[2].Value = departmentId;
                sproc = new StoreProcedure(DepartmentKeys.SP_DEPARTMENT_UPDATE, param);
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

        public long Delete(int departmentId)
        {

            Debug.Assert(sproc == null);
            long identity = 0;

            try
            {

                SqlParameter[] param =
                {
                    new SqlParameter("@DepartmentId",SqlDbType.Int)
                };

                param[0].Value = departmentId;

                sproc = new StoreProcedure(DepartmentKeys.SP_DEPARTMENT_DELETE, param);
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

                sproc = new StoreProcedure(DepartmentKeys.SP_DEPARTMENT_GET_ALL_ROOT, param);
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

        public DataTable GetAllDepartments()
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                sproc = new StoreProcedure(DepartmentKeys.SP_DEPARTMENT_GET_ALL, null);
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
                sproc = new StoreProcedure(DepartmentKeys.SP_DEPARTMENT_GET_ROOT, null);
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

        public DataTable GetDepartmentRootBySub(int subId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {

                SqlParameter[] param =
                {
                    new SqlParameter("@SubId",SqlDbType.Int),
                };
                param[0].Value = subId;
                sproc = new StoreProcedure(DepartmentKeys.SP_DEPARTMENT_GET_ROOT_BY_SUB_ID, param);
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
                sproc = new StoreProcedure(DepartmentKeys.SP_DEPARTMENT_GETALL_SUB_LEVEL, param);
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

                sproc = new StoreProcedure(DepartmentKeys.Sp_Departments_SubLevel_By_RootId_DepartmentId, param);
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

        public DataTable GetById(int departmentId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {

                SqlParameter[] param =
                {
                    new SqlParameter("@DepartmentId",SqlDbType.Int),
                };
                param[0].Value = departmentId;
                sproc = new StoreProcedure(DepartmentKeys.SP_DEPARTMENT_GET_BY_ID, param);
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

                sproc = new StoreProcedure(DepartmentKeys.Sp_Sel_H6_Departments_By_Ids, param);
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

        public DataTable GetByIdsRoot(string departmentIds, int rootId)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DepartmentIds",SqlDbType.VarChar, 254),
                    new SqlParameter("@RootId",SqlDbType.Int)
                };

                param[0].Value = departmentIds == null ? string.Empty : departmentIds;
                param[1].Value = rootId;
                sproc = new StoreProcedure(DepartmentKeys.SP_DEPARTMENT_GET_BY_IDS_ROOTID, param);
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


        public DataTable GetByRoot(int rootId)
        {

            Debug.Assert(sproc == null);

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@RootId",SqlDbType.Int)
                };

                param[0].Value = rootId;
                sproc = new StoreProcedure(DepartmentKeys.Sp_Sel_H6_Departments_By_RootId, param);
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
