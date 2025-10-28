using HRMDAL.Utilities;
using HRMUtil;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace HRMDAL.H0
{
    public class CityWardDAL : Dao
    {
        public DataTable GetAllCitys()
        {
            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                sproc = new StoreProcedure("Sel_H0_Citys_2025", null);
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
        public DataTable GetAllWards()
        {
            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {
                sproc = new StoreProcedure("Sel_H0_Wards_2025", null);
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
        public DataTable GetWardsByCityId(int cityId)
        {
            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {

                SqlParameter[] param =
                {
                    new SqlParameter("@CityId",SqlDbType.Int),
                };
                param[0].Value = cityId;
                sproc = new StoreProcedure("Sel_Wards_ByCityId", param);
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
