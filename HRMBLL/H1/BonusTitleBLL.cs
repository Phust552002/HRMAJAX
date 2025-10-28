using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H1;


namespace HRMBLL.H1
{
    public class BonusTitleBLL
    {

        #region private fields

        private int _BonusTitleId;
        private string _BonusTitle;
        private string _BonusDescription;
        private int _BonusType;
        private bool _BonusVisible;
        private bool _IsTax;

        #endregion

        #region properties

        public int BonusTitleId
        {
            get { return _BonusTitleId; }
            set { _BonusTitleId = value; }
        }
        public string BonusTitle
        {
            get { return _BonusTitle; }
            set { _BonusTitle = value; }
        }
        public string BonusDescription
        {
            get { return _BonusDescription; }
            set { _BonusDescription = value; }
        }
        public int BonusType
        {
            get { return _BonusType; }
            set { _BonusType = value; }
        }
        public bool BonusVisible
        {
            get { return _BonusVisible; }
            set { _BonusVisible = value; }
        }
        public bool IsTax
        {
            get { return _IsTax; }
            set { _IsTax = value; }
        }

        #endregion

        #region constructors

        public BonusTitleBLL(int bonusTitleId, string bonusTitle, string bonusDescription, int bonusType, bool bonusVisible, bool isTax)
        {
            _BonusTitleId = bonusTitleId;
            _BonusTitle = bonusTitle;
            _BonusDescription = bonusDescription;
            _BonusType = bonusType;
            _BonusVisible = bonusVisible;
            _IsTax = isTax;
        }

        #endregion

        #region public methods insert, update, delete

        //public long Save()
        //{
        //    BonusNamesDAL objDAL = new BonusNamesDAL();
        //    if (BonusNameId <= 0)
        //    {
        //        return objDAL.Insert(BonusName, Description, Type);
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}

        #endregion

        #region methods Get

        //public static List<BonusNamesBLL> GetAll()
        //{
        //    return GenerateListBonusNamesBLLFromDataTable(new BonusNamesDAL().GetAll());
        //}

        //public static List<BonusNamesBLL> GetByType(int type)
        //{
        //    return GenerateListBonusNamesBLLFromDataTable(new BonusNamesDAL().GetByType(type));
        //}

        public static List<BonusTitleBLL> GetByIds(string bonusTitleIds)
        {
            return GenerateListBonusNamesBLLFromDataTable(new BonusTitleDAL().GetByIds(bonusTitleIds));
        }

        //public static List<BonusTitleBLL> GetAllTitle(int bonusVisible)
        //{
        //    return GenerateListBonusNamesBLLFromDataTable(new BonusTitleDAL().GetAllTitle(bonusVisible));
        //}

        #endregion

        #region private static methods

        private static List<BonusTitleBLL> GenerateListBonusNamesBLLFromDataTable(DataTable dt)
        {
            List<BonusTitleBLL> list = new List<BonusTitleBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateBonusNamesBLLFromDataRow(dr));
            }

            return list;
        }

        private static BonusTitleBLL GenerateBonusNamesBLLFromDataRow(DataRow dr)
        {
            BonusTitleBLL objBLL = new BonusTitleBLL(
                    //dr[BonusNameKeys.FIELD_BONUS_NAME_ID] == DBNull.Value ? 0 : int.Parse(dr[BonusNameKeys.FIELD_BONUS_NAME_ID].ToString()),
                    //dr[BonusNameKeys.FIELD_BONUS_NAME_NAME] == DBNull.Value ? string.Empty : dr[BonusNameKeys.FIELD_BONUS_NAME_NAME].ToString(),
                    //dr[BonusNameKeys.FIELD_BONUS_NAME_DESCRIPTION] == DBNull.Value ? string.Empty : dr[BonusNameKeys.FIELD_BONUS_NAME_DESCRIPTION].ToString(),
                    //dr[BonusNameKeys.FIELD_BONUS_NAME_TYPE] == DBNull.Value ? 0 : int.Parse(dr[BonusNameKeys.FIELD_BONUS_NAME_TYPE].ToString()),
                    //dr[BonusNameKeys.FIELD_BONUS_NAME_VISIBLE] == DBNull.Value ? false : Convert.ToBoolean(dr[BonusNameKeys.FIELD_BONUS_NAME_VISIBLE].ToString())
                    dr["BonusTitleId"] == DBNull.Value ? 0 : int.Parse(dr["BonusTitleId"].ToString()),
                    dr["BonusTitle"] == DBNull.Value ? string.Empty : dr["BonusTitle"].ToString(),
                    dr["BonusDescription"] == DBNull.Value ? string.Empty : dr["BonusDescription"].ToString(),
                    dr["BonusType"] == DBNull.Value ? 0 : int.Parse(dr["BonusType"].ToString()),
                    dr["BonusVisible"] == DBNull.Value ? false : Convert.ToBoolean(dr["BonusVisible"].ToString()),
                    dr["IsTax"] == DBNull.Value ? false : Convert.ToBoolean(dr["IsTax"].ToString())
                );

            return objBLL;
        }


        #endregion

    }
}
