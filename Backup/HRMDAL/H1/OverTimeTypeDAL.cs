using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using HRMUtil;
using HRMDAL.Utilities;
using HRMUtil.KeyNames.H1;

namespace HRMDAL.H1
{
    public class OverTimeTypeDAL : Dao
    {

        #region Methods GET               

        public DataTable GetAll()
        {

            Debug.Assert(sproc == null);
            DataTable datatable = new DataTable();
            try
            {

                sproc = new StoreProcedure(OverTimeTypeKeys.Sp_Sel_View_H1_OverTimeTypeByAll, null);
                sproc.RunFill(datatable);
                sproc.Dispose();
            }
            catch (SqlException se)
            {
                throw new HRMException(se.Message, se.Number);
            }

            return datatable;

        }

        #endregion

    }
}
