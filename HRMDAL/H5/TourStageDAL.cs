using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H5;

namespace HRMDAL.H5
{
    public class TourStageDAL : Dao
    {


        #region Methods Get
        
        public DataTable GetByYear(int Year)
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {

                SqlParameter[] param = 
                {                     
                    new SqlParameter("@Year", SqlDbType.Int, 4)
                };

                param[0].Value = Year;

                sproc = new StoreProcedure(TourStageKeys.Sp_Sel_H5_TourStageByYear, param);
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

        
    }
}
