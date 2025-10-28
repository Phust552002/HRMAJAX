using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace HRMDAL.Utilities
{
    sealed public class StoreProcedure
    {

        private SqlCommand command;
        private SqlTransaction tran;
        private SqlConnection con;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sprocName"></param>
        /// <param name="parameters"></param>
        public StoreProcedure(string sprocName, SqlParameter[] parameters)
        {
            con = new SqlConnection(HRMConfig.ConnectionString);
            con.Open();
            tran = con.BeginTransaction();
            command = new SqlCommand(sprocName, con, tran);
            command.CommandType = CommandType.StoredProcedure;

            if (parameters != null)
                foreach (SqlParameter param in parameters)
                    command.Parameters.Add(param);


            command.Parameters.Add(new SqlParameter("ReturnValue",
                SqlDbType.Int,
                4,
                ParameterDirection.ReturnValue,
                false,
                0,
                0,
                string.Empty,
                DataRowVersion.Default,
                null));

            

        }
        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            SqlConnection cn = command.Connection;
            Debug.Assert(cn != null);
            command.Dispose();
            command = null;
            cn.Close();
            cn.Dispose();
            con.Close();
            con.Dispose();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public long Run()
        {
            if (command == null)
                throw new ObjectDisposedException(GetType().FullName);
            command.ExecuteNonQuery();
            return Convert.ToInt64(command.Parameters["ReturnValue"].Value);
        }

        public int RunInt()
        {
            if (command == null)
                throw new ObjectDisposedException(GetType().FullName);
            command.ExecuteNonQuery();
            return (int)command.Parameters["ReturnValue"].Value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public int RunFill(DataTable table)
        {
            if (command == null)
                throw new ObjectDisposedException(GetType().FullName);
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = command;
            adap.Fill(table);
            return (int)command.Parameters["ReturnValue"].Value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader RunReader()
        {
            if (command == null)
                throw new ObjectDisposedException(GetType().FullName);
            return command.ExecuteReader();
        }       

        public void RollBack()
        {
            tran.Rollback();
        }

        public void Commit()
        {
            tran.Commit();
        }

    }
}
