using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.H;
using HRMUtil.KeyNames.H;
using HRMUtil;

namespace HRMBLL.H
{
    public class CommandLogBLL
    {

        #region private fields

        private long _CommandLogId;
        private int _CommandTypeId;
        private int _UserId;
        private string _OldValues;
        private string _NewValues;
        private DateTime _CommandLogDate;
        private int _ModuleId;

        private string _FullName;
        private string _DataName;
        private string _CommandTypeName;
        #endregion

        #region properties

        public long CommandLogId
        {
            get
            {
                return _CommandLogId;
            }
            set
            {
                _CommandLogId = value;
            }
        }
        public int CommandTypeId
        {
            get
            {
                return _CommandTypeId;
            }
            set
            {
                _CommandTypeId = value;
            }
        }

        public int UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                _UserId = value;
            }
        }
        public string OldValues
        {
            get
            {
                return _OldValues;
            }
            set
            {
                _OldValues = value;
            }
        }
        public string NewValues
        {
            get
            {
                return _NewValues;
            }
            set
            {
                _NewValues = value;
            }
        }
        public DateTime CommandLogDate
        {
            get
            {
                return _CommandLogDate;
            }
            set
            {
                _CommandLogDate = value;
            }
        }
        public int ModuleId
        {
            get
            {
                return _ModuleId;
            }
            set
            {
                _ModuleId = value;
            }
        }


        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }

        public string DataName
        {
            get { return _DataName; }
            set { _DataName = value; }
        }

        public string CommandTypeName
        {
            get { return _CommandTypeName; }
            set { _CommandTypeName = value; }
        }

        #endregion

        #region constructor

        public CommandLogBLL() { }

        public CommandLogBLL(long commandLogId, int commandTypeId, string dataName, int userId, string oldValues, string newValues, DateTime commandLogDate)
        {
            _CommandLogId = commandLogId;
            _CommandTypeId = commandTypeId;
            _DataName = dataName;
            _UserId = userId;
            _OldValues = oldValues;
            _NewValues = newValues;
            _CommandLogDate = commandLogDate;
        }

        #endregion

        #region methods insert, update, delete

        public long Save()
        {
            return new CommandLogDAL().Insert(_CommandTypeId, _DataName, _UserId, _OldValues, _NewValues, _CommandLogDate, _ModuleId);
        }

        #endregion

        #region public static method Get

        public static List<CommandLogBLL> GetByFilter(string dataName, int commandTypeId, int userId, int day, int month, int year, int moduleId)
        {
            return GenerateListCommandLogBLLFromDataTable(new CommandLogDAL().GetByFilter(dataName, commandTypeId, userId, day, month, year, moduleId));
        }

        public static List<CommandLogBLL> GetByDateName(string dataName)
        {
            return GenerateListCommandLogBLLFromDataTable(new CommandLogDAL().GetByDataName(dataName));
        }
        public static List<CommandLogBLL> GetByFromToDate(int CommandTypeId, DateTime FromDate, DateTime ToDate, int ModuleId)
        {
            return GenerateListCommandLogBLLFromDataTable(new CommandLogDAL().GetByFromToDateModule(CommandTypeId, FromDate, ToDate, ModuleId));
        }

        #endregion

        #region private static methods


        private static List<CommandLogBLL> GenerateListCommandLogBLLFromDataTable(DataTable dt)
        {
            List<CommandLogBLL> list = new List<CommandLogBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateListCommandLogBLLFromDataRow(dr));
            }

            return list;
        }

        private static CommandLogBLL GenerateListCommandLogBLLFromDataRow(DataRow dr)
        {
            CommandLogBLL objBLL = new CommandLogBLL(
            dr[CommandLogKeyNames.Field_Command_Log_Id] == DBNull.Value ? 0 : long.Parse(dr[CommandLogKeyNames.Field_Command_Log_Id].ToString()),
            dr[CommandLogKeyNames.Field_Command_Log_CommandTypeId] == DBNull.Value ? 0 : int.Parse(dr[CommandLogKeyNames.Field_Command_Log_CommandTypeId].ToString()),
            dr[CommandLogKeyNames.Field_Command_Log_DataName] == DBNull.Value ? string.Empty : dr[CommandLogKeyNames.Field_Command_Log_DataName].ToString(),
            dr[CommandLogKeyNames.Field_Command_Log_UserId] == DBNull.Value ? 0 : int.Parse(dr[CommandLogKeyNames.Field_Command_Log_UserId].ToString()),
            dr[CommandLogKeyNames.Field_Command_Log_OldValues] == DBNull.Value ? string.Empty : dr[CommandLogKeyNames.Field_Command_Log_OldValues].ToString(),
            dr[CommandLogKeyNames.Field_Command_Log_NewValues] == DBNull.Value ? string.Empty : dr[CommandLogKeyNames.Field_Command_Log_NewValues].ToString(),
            dr[CommandLogKeyNames.Field_Command_Log_CommandLogDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[CommandLogKeyNames.Field_Command_Log_CommandLogDate].ToString())
            );

            objBLL.ModuleId = dr[CommandLogKeyNames.Field_CommandLog_ModuleId] == DBNull.Value ? 0 : int.Parse(dr[CommandLogKeyNames.Field_CommandLog_ModuleId].ToString());

            objBLL.FullName = dr[CommandLogKeyNames.Field_Command_Log_FullName] == DBNull.Value ? string.Empty : dr[CommandLogKeyNames.Field_Command_Log_FullName].ToString();
            objBLL.CommandTypeName = Constants.GetlCommandTypeNameById(objBLL.CommandTypeId);

            return objBLL;
        }


        #endregion

    }
}
