using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


using HRMDAL.Utilities;
using HRMDAL.H2;
using HRMUtil.KeyNames.H2;

using HRMUtil;

namespace HRMBLL.H2
{
    public class SessionsBLL
    {

        #region private fields

        private int _Id;
        private DateTime _FromDate;
        private DateTime _ToDate;
        private string _Name;
        private string _Remark;
        private int _SessionType;
        private string _SessionTypeName;

        private int _PositionId;
        private string _PositionName;

        #endregion

        #region properties

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public DateTime FromDate
        {
            get { return _FromDate; }
            set { _FromDate = value; }
        }
        public DateTime ToDate
        {
            get { return _ToDate; }
            set { _ToDate = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }
        public int SessionType
        {
            get { return _SessionType; }
            set { _SessionType = value; }
        }
        public string SessionTypeName
        {
            get { return _SessionTypeName; }
            set { _SessionTypeName = value; }
        }
        public int PositionId
        {
            get { return _PositionId; }
            set { _PositionId = value; }
        }

        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }


        #endregion

        #region public methods

        public long Save()
        {
            SessionsDAL objDAL = new SessionsDAL();
            if (_Id <= 0)
            {
                return objDAL.Insert( _FromDate, _ToDate, _Name, _Remark, _SessionType);
            }
            else
            {
                return objDAL.Update(_Name, _FromDate, _ToDate, _Remark, _SessionType, _Id);
            }
        }

        public static long Update(string name, string fromDate, string toDate, string remark, int sessionType, int id)
        {
            return new SessionsDAL().Update(name, FormatDate.FormatUSDate(fromDate), FormatDate.FormatUSDate(toDate), remark, sessionType, id);
        }

        public static long Delete(int id)
        {
            return new SessionsDAL().Delete(id);
        }

        public static List<SessionsBLL> GetAll()
        {
            return GenerateListFromDataTable(new SessionsDAL().GetAll());
        }


        public static List<SessionsBLL> GetSessionIsOpen()
        {
            return GenerateListFromDataTable(new SessionsDAL().GetSessionIsOpen());
        }

        public static DataTable GetSessionIsOpenForDataTable()
        {
            return new SessionsDAL().GetSessionIsOpen();
        }

        

        public static DataRow GetSessionIsOpenForDataRow()
        {
            DataTable dt = new SessionsDAL().GetSessionIsOpen();
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }

        }
        public static List<SessionsBLL> GetPositionBySessionId(int sessionId)
        {
            return GenerateListFromDataTable(new SessionsDAL().GetSessionPositionBySessionId(sessionId));
        }
        public static DataTable GetPositionBySessionIdForDataTable(int sessionId)
        {
            return new SessionsDAL().GetSessionPositionBySessionId(sessionId);
        }
        public static List<SessionsBLL> GetIsActive()
        {
            return GenerateListFromDataTable(new SessionsDAL().GetIsActive());
        }

        #endregion


        #region Insert SessionPosition

        public static long InsertSessionPosition(int PositionId, int SessionId, string Remark)
        {
            return new SessionsDAL().InsertSessionPosition(PositionId, SessionId, Remark);
        }

        public static long DeleteBySessionId(int SessionId)
        {
            return new SessionsDAL().DeleteBySessionId(SessionId);
        }
        #endregion

        #region private methods

        private static List<SessionsBLL> GenerateListFromDataTable(DataTable dt)
        {
            List<SessionsBLL> list = new List<SessionsBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateFromDataTable(dr));
            }

            return list;
        }

        

        private static SessionsBLL GenerateFromDataTable(DataRow dr)
        {
            SessionsBLL s = new SessionsBLL();
            s._Id = dr[SessionKeys.FIELD_SESSION_ID] == DBNull.Value ? 0 : int.Parse(dr[SessionKeys.FIELD_SESSION_ID].ToString());
            s._Name = dr[SessionKeys.FIELD_SESSION_SESSION_NAME] == DBNull.Value ? string.Empty : dr[SessionKeys.FIELD_SESSION_SESSION_NAME].ToString();
            s._FromDate = dr[SessionKeys.FIELD_SESSION_FROM_DATE] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[SessionKeys.FIELD_SESSION_FROM_DATE].ToString());
            s._ToDate = dr[SessionKeys.FIELD_SESSION_TO_DATE] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[SessionKeys.FIELD_SESSION_TO_DATE].ToString());
            s._Remark = dr[SessionKeys.FIELD_SESSION_REMARK] == DBNull.Value ? string.Empty : dr[SessionKeys.FIELD_SESSION_REMARK].ToString();
            s._SessionType = dr[SessionKeys.FIELD_SESSION_SESSION_TYPE] == DBNull.Value ? 0 : int.Parse(dr[SessionKeys.FIELD_SESSION_SESSION_TYPE].ToString());
            s._SessionTypeName = Constants.GetNameBySessionType(s._SessionType);
            try
            {
                s._PositionId = dr[SessionKeys.FIELD_SESSION_POSITION_ID] == DBNull.Value ? 0 : int.Parse(dr[SessionKeys.FIELD_SESSION_POSITION_ID].ToString());
                s._PositionName = dr[SessionKeys.FIELD_SESSION_POSITION_NAME] == DBNull.Value ? string.Empty : dr[SessionKeys.FIELD_SESSION_POSITION_NAME].ToString();
            }
            catch { }

            return s;
        }

        #endregion

    }
}
