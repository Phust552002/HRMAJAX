using HRMDAL.Utilities;
using HRMUtil;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace HRMDAL.H8
{
    public class Covid19DAL : Dao
    {
        public int Save(int covidVictimId, int userId, string type, System.Nullable<DateTime> testContactDate, System.Nullable<DateTime> quarantineBeginDate, System.Nullable<DateTime> quarantineEndDate, string remarks, int place)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@CovidVictimId",SqlDbType.Int),
                    new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@Type",SqlDbType.VarChar),
                    new SqlParameter("@TestApproachDate",SqlDbType.DateTime),
                    new SqlParameter("@QuarantineBeginDate",SqlDbType.DateTime),
                    new SqlParameter("@QuarantineEndDate",SqlDbType.DateTime),
                    new SqlParameter("@Remarks",SqlDbType.NVarChar),
                    new SqlParameter("@Place",SqlDbType.Int),
                };

                param[0].Value = covidVictimId;
                param[1].Value = userId;
                param[2].Value = type;

                if ((testContactDate.HasValue == true))
                {
                    param[3].Value = testContactDate;
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                if ((quarantineBeginDate.HasValue == true))
                {
                    param[4].Value = quarantineBeginDate;
                }
                else
                {
                    param[4].Value = System.DBNull.Value;
                }
                if ((quarantineEndDate.HasValue == true))
                {
                    param[5].Value = quarantineEndDate;
                }
                else
                {
                    param[5].Value = System.DBNull.Value;
                }
                param[6].Value = remarks;
                param[7].Value = place;

                sproc = new StoreProcedure("Upd_H8_CovidVictim_ByCovidVictimId", param);
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

        public int SaveApproach(int userId, int covidVictimId, string remarks, System.Nullable<DateTime> approachDate, int approachedCovidVictimId)
        {
            int identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId",SqlDbType.Int),
                    new SqlParameter("@CovidVictimId",SqlDbType.Int),
                    new SqlParameter("@Remarks",SqlDbType.NVarChar),
                    new SqlParameter("@ApproachDate",SqlDbType.DateTime),
                    new SqlParameter("@ApproachedCovidVictimId",SqlDbType.Int),
                };

                param[0].Value = userId;
                param[1].Value = covidVictimId;
                param[2].Value = remarks;
                if ((approachDate.HasValue == true))
                {
                    param[3].Value = approachDate;
                }
                else
                {
                    param[3].Value = System.DBNull.Value;
                }
                param[4].Value = approachedCovidVictimId;

                sproc = new StoreProcedure("Upd_H8_Approach", param);
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

        public DataTable GetF0ByCovidVictimId(object covidVictimId)
        {
            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@ApproachedCovidVictimId",SqlDbType.Int)
                };
                param[0].Value = covidVictimId;
                sproc = new StoreProcedure("Sel_H8_F0_ByApproachedCovidVictimId", param);
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

        public long Delete(int covidVictimId)
        {
            long identity = 0;
            Debug.Assert(sproc == null);
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@CovidVictimId",SqlDbType.Int),

                };

                param[0].Value = covidVictimId;

                sproc = new StoreProcedure("Del_H8_CovidVictim_ByCovidVictimId", param);
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

        public DataTable GetByDeptIds(string deptIds, int rootId, string fullname, string type)
        {
            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DeptIds",SqlDbType.VarChar,1000),
                    new SqlParameter("@RootId",SqlDbType.Int),
                    new SqlParameter("@FullName",SqlDbType.NVarChar,254),
                    new SqlParameter("@Type",SqlDbType.VarChar,2),
                };

                param[0].Value = deptIds;
                param[1].Value = rootId;
                param[2].Value = fullname;
                param[3].Value = type;

                sproc = new StoreProcedure("Sel_H8_CovidVictims_By_DeptIds", param);
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
        public DataTable GetVaccinationInfoByDeptIds(string deptIds, int rootId, string fullname, int type)
        {
            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@DeptIds",SqlDbType.VarChar,1000),
                    new SqlParameter("@RootId",SqlDbType.Int),
                    new SqlParameter("@FullName",SqlDbType.NVarChar,254),
                    new SqlParameter("@Type",SqlDbType.VarChar,2),
                };

                param[0].Value = deptIds;
                param[1].Value = rootId;
                param[2].Value = fullname;
                param[3].Value = type;

                sproc = new StoreProcedure("Sel_H8_VaccinationInfo_By_DeptIds", param);
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
        public DataTable GetHistory(int userId)
        {
            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@UserId",SqlDbType.Int),
                };

                param[0].Value = userId;

                sproc = new StoreProcedure("Sel_H8_CovidHistory_By_UserId", param);
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

        public DataTable GetOne(int covid19VictimId)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                SqlParameter[] param =
                {
                    new SqlParameter("@CovidVictimId",SqlDbType.Int)
                };
                param[0].Value = covid19VictimId;
                sproc = new StoreProcedure("Sel_H8_CovidVictim_ById", param);
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
    }
}
