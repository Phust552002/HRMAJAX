using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

using HRMBLL.H1.Helper;
using HRMDAL.Utilities;
using HRMDAL.H1;
using HRMUtil.KeyNames.H1;
using HRMUtil.KeyNames.H0;
using HRMUtil;

namespace HRMBLL.H1
{
    public class CoefficientEmployeeFinalBLL
    {

        #region private field

        private long _CoefficientEmployeeFinalId;
        private int _UserId;
        private DateTime _CreateDate;
        private double _LNS;
        private double _LNSPCTN;
        private double _LCB;
        private double _PCDH;
        private double _PCTN;
        private double _PCKV;
        private double _PCCV;
        private double _Special;
        private string _Remark;
        
        private string _FullName;
        private int _PositionId;
        private string _PositionName;
        private int _ContractTypeId;
        private string _ContractTypeCode;
        private string _ContractTypeName;


        private double _TotalLNS;
        private double _TotalLNSPCTN;
        private double _TotalLCB;
        private double _TotalPCDH;
        private double _TotalPCTN;
        private double _TotalPCKV;
        private double _TotalPCCV;

        #endregion

        #region properties

        public long CoefficientEmployeeFinalId
        {
            get { return _CoefficientEmployeeFinalId; }
            set { _CoefficientEmployeeFinalId = value; }
        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }
        public double LNS
        {
            get { return _LNS; }
            set { _LNS = value; }
        }
        public double LNSPCTN
        {
            get { return _LNSPCTN; }
            set { _LNSPCTN = value; }
        }
        public double LCB
        {
            get { return _LCB; }
            set { _LCB = value; }
        }
        public double PCDH
        {
            get { return _PCDH; }
            set { _PCDH = value; }
        }
        public double PCTN
        {
            get { return _PCTN; }
            set { _PCTN = value; }
        }
        public double PCKV
        {
            get { return _PCKV; }
            set { _PCKV = value; }
        }
        public double PCCV
        {
            get { return _PCCV; }
            set { _PCCV = value; }
        }
        public double Special
        {
            get { return _Special; }
            set { _Special = value; }
        }
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
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

        public int ContractTypeId
        {
            get { return _ContractTypeId; }
            set { _ContractTypeId = value; }
        }
        public string ContractTypeCode
        {
            get { return _ContractTypeCode; }
            set { _ContractTypeCode = value; }
        }
        public string ContractTypeName
        {
            get { return _ContractTypeName; }
            set { _ContractTypeName = value; }
        }


        public double TotalLNS
        {
            get { return _TotalLNS; }
            set { _TotalLNS = value; }
        }

        public double TotalLNSPCTN
        {
            get { return _TotalLNSPCTN; }
            set { _TotalLNSPCTN = value; }
        }

        public double TotalLCB
        {
            get { return _TotalLCB; }
            set { _TotalLCB = value; }
        }

        public double TotalPCDH
        {
            get { return _TotalPCDH; }
            set { _TotalPCDH = value; }
        }

        public double TotalPCTN
        {
            get { return _TotalPCTN; }
            set { _TotalPCTN = value; }
        }

        public double TotalPCKV
        {
            get { return _TotalPCKV; }
            set { _TotalPCKV = value; }
        }

        public double TotalPCCV
        {
            get { return _TotalPCCV; }
            set { _TotalPCCV = value; }
        }


        #endregion

        #region public methods : insert, update, delete

        public long Save()
        {
            CoefficientEmployeeFinalDAL objDAL = new CoefficientEmployeeFinalDAL();
            if (CoefficientEmployeeFinalId <= 0)
            {
                return objDAL.Insert(UserId, CreateDate, LNS, LNSPCTN, LCB, PCDH, PCTN, PCKV, PCCV);
            }
            else
            {
                return 0;//objDAL.Update(UserId, PCDH, PCTN, PCCV, PCKV, Description, ACTIVE, CREATEDATE, CoefficientEmployeeId);
            }
        }

        public static long Insert(int userId, DateTime createDate, double lNS, double lNSPCTN, double lCB, double pCDH, double pCTN, double pCKV, double pCCV)
        {
            return new CoefficientEmployeeFinalDAL().Insert(userId, createDate, lNS, lNSPCTN, lCB, pCDH, pCTN, pCKV, pCCV);
        }

        public static long UpdateForLNS(int userId, DateTime createDate, double lNS, double lNSPCTN)
        {
            return new CoefficientEmployeeFinalDAL().UpdateForLNS(userId, createDate, lNS, lNSPCTN);
        }
        public static long UpdateForLCB(int userId, DateTime createDate, double lCB)
        {
            return new CoefficientEmployeeFinalDAL().UpdateForLCB(userId, createDate, lCB);
        }
        public static long UpdateForOther(int userId, DateTime createDate, double pCDH, double pCTN, double pCKV, double pCCV)
        {
            return new CoefficientEmployeeFinalDAL().UpdateForOther(userId, createDate, pCDH, pCTN, pCKV, pCCV);
        }
        public static long UpdateForSpecial(int userId, DateTime createDate, double lCB, double lNS, double lNSPCTN, double pCDH, double pCTN, double pCKV, double pCCV)
        {
            return new CoefficientEmployeeFinalDAL().UpdateForSpecial(userId, createDate,lCB, lNS, lNSPCTN, pCDH, pCTN, pCKV, pCCV);
        }



        #endregion

        #region public methods GET

        public static List<CoefficientEmployeeFinalBLL> GetByFilter(string fullName, int rootId, int month, int year)
        {
            return GenerateListCoefficientEmployeeFinalBLLFromDataTable(new CoefficientEmployeeFinalDAL().GetByFilter(fullName, rootId, month, year));
        }

        public static CoefficientEmployeeFinalBLL GetByRootDateForTotal(int rootId, int month, int year)
        {
            List<CoefficientEmployeeFinalBLL> list = GenerateListCoefficientEmployeeFinalBLLFromDataTableForTotal(new CoefficientEmployeeFinalDAL().GetByRootDateForTotal(rootId, month, year));
            if (list.Count == 1)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }
        public static CoefficientEmployeeFinalBLL GetByUserDate(int userId, int month, int year)
        {
            List<CoefficientEmployeeFinalBLL> list = GenerateListCoefficientEmployeeFinalBLLFromDataTable(new CoefficientEmployeeFinalDAL().GetByUserDate(userId, month, year));
            if (list.Count == 1)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }
        
        #endregion

        #region private methods

        private static List<CoefficientEmployeeFinalBLL> GenerateListCoefficientEmployeeFinalBLLFromDataTable(DataTable dt)
        {
            List<CoefficientEmployeeFinalBLL> list = new List<CoefficientEmployeeFinalBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateCoefficientEmployeeFinalBLLFromDataRow(dr));
            }

            return list;
        }

        private static CoefficientEmployeeFinalBLL GenerateCoefficientEmployeeFinalBLLFromDataRow(DataRow dr)
        {
            CoefficientEmployeeFinalBLL objBLL = new CoefficientEmployeeFinalBLL();

            objBLL._CoefficientEmployeeFinalId = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_Id] == DBNull.Value ? 0 : long.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_Id].ToString());
            objBLL._UserId = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_UserId] == DBNull.Value ? 0 : int.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_UserId].ToString());
            objBLL._FullName = dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME] == DBNull.Value ? string.Empty : dr[EmployeeKeys.FIELD_EMPLOYEES_FULLNAME].ToString();
            objBLL._CreateDate = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_CreateDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_CreateDate].ToString());

            objBLL._LNS = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_LNS] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_LNS].ToString());
            objBLL._LNSPCTN = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_LNSPCTN] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_LNSPCTN].ToString());
            objBLL._LCB = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_LCB] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_LCB].ToString());
            objBLL._PCDH = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_PCDH] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_PCDH].ToString());
            objBLL._PCTN = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_PCTN] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_PCTN].ToString());
            objBLL._PCKV = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_PCKV] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_PCKV].ToString());
            objBLL._PCCV = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_PCCV] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_PCCV].ToString());
            objBLL._Special = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_Special] == DBNull.Value ? 0 : int.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_Special].ToString());
            objBLL._Remark = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_Remark] == DBNull.Value ? string.Empty : dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_Special].ToString();

            objBLL._PositionId = dr[PositionKeys.FIELD_POSITION_ID] == DBNull.Value ? 0 : int.Parse(dr[PositionKeys.FIELD_POSITION_ID].ToString());
            objBLL._PositionName = dr[PositionKeys.FIELD_POSITION_NAME] == DBNull.Value ? string.Empty : dr[PositionKeys.FIELD_POSITION_NAME].ToString();            
            objBLL._ContractTypeId = dr[ContractTypeKeys.Field_ContractTypes_ContractTypeId] == DBNull.Value ? 0 : int.Parse(dr[ContractTypeKeys.Field_ContractTypes_ContractTypeId].ToString());
            objBLL._ContractTypeCode = dr[ContractTypeKeys.Field_ContractTypes_ContractTypeCode] == DBNull.Value ? string.Empty : dr[ContractTypeKeys.Field_ContractTypes_ContractTypeCode].ToString();
            objBLL._ContractTypeName = dr[ContractTypeKeys.Field_ContractTypes_ContractTypeName] == DBNull.Value ? string.Empty : dr[ContractTypeKeys.Field_ContractTypes_ContractTypeName].ToString();

            return objBLL;
        }

        private static List<CoefficientEmployeeFinalBLL> GenerateListCoefficientEmployeeFinalBLLFromDataTableForTotal(DataTable dt)
        {
            List<CoefficientEmployeeFinalBLL> list = new List<CoefficientEmployeeFinalBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateCoefficientEmployeeFinalBLLFromDataRowForTotal(dr));
            }

            return list;
        }

        private static CoefficientEmployeeFinalBLL GenerateCoefficientEmployeeFinalBLLFromDataRowForTotal(DataRow dr)
        {
            CoefficientEmployeeFinalBLL objBLL = new CoefficientEmployeeFinalBLL();

            objBLL._TotalLNS = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_TotalLNS] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_TotalLNS].ToString());
            objBLL._TotalLNSPCTN = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_TotalLNSPCTN] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_TotalLNSPCTN].ToString());
            objBLL._TotalLCB = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_TotalLCB] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_TotalLCB].ToString());
            objBLL._TotalPCDH = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_TotalPCDH] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_TotalPCDH].ToString());
            objBLL._TotalPCTN = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_TotalPCTN] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_TotalPCTN].ToString());
            objBLL._TotalPCKV = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_TotalPCKV] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_TotalPCKV].ToString());
            objBLL._TotalPCCV = dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_TotalPCCV] == DBNull.Value ? 0 : double.Parse(dr[CoefficientEmployeeFinalKeys.Field_CoefficientEmployeeFinal_TotalPCCV].ToString());

            return objBLL;
        }      

        #endregion

    }
}
