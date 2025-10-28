using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H;
using HRMUtil.KeyNames.H;
using HRMUtil;

namespace HRMBLL.H
{
    public class BulletinBLL
    {
        #region private fields

        private int _BulletinId;
        private string _BulletinTitle;
        private string _BulletinDetail;
        private DateTime _BulletinDate;


        #endregion

        #region properties

        public int BulletinId
        {
            get { return _BulletinId; }
            set { _BulletinId = value; }
        }
        public string BulletinTitle
        {
            get { return _BulletinTitle; }
            set { _BulletinTitle = value; }
        }
        public string BulletinDetail
        {
            get { return _BulletinDetail; }
            set { _BulletinDetail = value; }
        }
        public DateTime BulletinDate
        {
            get { return _BulletinDate; }
            set { _BulletinDate = value; }
        }

        #endregion

        #region methods Get


        public static List<BulletinBLL> GetByNumberday(int numberOfDay)
        {
            return GenerateListBulletinBLLFromDataTable(new BulletinDAL().GetByNumberday(numberOfDay));
        }

        #endregion

        #region private static methods

        private static List<BulletinBLL> GenerateListBulletinBLLFromDataTable(DataTable dt)
        {
            List<BulletinBLL> list = new List<BulletinBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateBulletinBLLFromDataRow(dr));
            }

            return list;
        }

        private static BulletinBLL GenerateBulletinBLLFromDataRow(DataRow dr)
        {
            BulletinBLL objBLL = new BulletinBLL();

            objBLL._BulletinId = dr[BulletinKeyNames.Field_Bulletin_BulletinId] == DBNull.Value ? 0 : int.Parse(dr[BulletinKeyNames.Field_Bulletin_BulletinId].ToString());
            objBLL._BulletinTitle = dr[BulletinKeyNames.Field_Bulletin_BulletinTitle] == DBNull.Value ? string.Empty : dr[BulletinKeyNames.Field_Bulletin_BulletinTitle].ToString();
            objBLL._BulletinDetail = dr[BulletinKeyNames.Field_Bulletin_BulletinDetail] == DBNull.Value ? string.Empty : dr[BulletinKeyNames.Field_Bulletin_BulletinDetail].ToString();
            objBLL._BulletinDate = dr[BulletinKeyNames.Field_Bulletin_BulletinDate] == DBNull.Value ? FormatDate.GetSQLDateMinValue : Convert.ToDateTime(dr[BulletinKeyNames.Field_Bulletin_BulletinDate].ToString());

            return objBLL;
        }


        #endregion
    }
}
