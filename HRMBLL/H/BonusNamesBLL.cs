using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H;
using HRMUtil.KeyNames.H;


namespace HRMBLL.H
{
    public class BonusNamesBLL
    {

        #region private fields

        private int _BonusNameId;
        private string _BonusName;
        private string _Description;
        private int _Type;
        private bool _Visible;


        #endregion

        #region properties

        public  int BonusNameId
        {
            get{return _BonusNameId;}
            set{_BonusNameId = value;}
        }
        public  string BonusName
        {
            get{return _BonusName;}
            set{_BonusName = value;}
        }
        public  string Description
        {
            get{return _Description;}
            set{_Description = value;}
        }
        public  int Type
        {
            get{return _Type;}
            set{_Type = value;}
        }
        public  bool Visible
        {
            get{return _Visible;}
            set{_Visible = value;}
        }

        #endregion

        #region constructors

        public BonusNamesBLL(int bonusNameId, string bonusName, string description, int type, bool visible)
        {
            _BonusNameId = bonusNameId;
            _BonusName = bonusName;
            _Description = description;
            _Type = type;
            _Visible = visible;
        }

        #endregion

        #region public methods insert, update, delete

        public long Save()
        {
            BonusNamesDAL objDAL = new BonusNamesDAL();
            if (BonusNameId <= 0)
            {
                return objDAL.Insert(BonusName, Description, Type);
            }
            else
            {
                return -1;
            }
        }
       
        #endregion

        #region methods Get

        public static List<BonusNamesBLL> GetAll()
        {
            return GenerateListBonusNamesBLLFromDataTable(new BonusNamesDAL().GetAll());
        }

        public static List<BonusNamesBLL> GetByType(int type)
        {
            return GenerateListBonusNamesBLLFromDataTable(new BonusNamesDAL().GetByType(type));
        }

        public static List<BonusNamesBLL> GetByIds(string bonusNameIds)
        {
            return GenerateListBonusNamesBLLFromDataTable(new BonusNamesDAL().GetByIds(bonusNameIds));
        }

        #endregion

        #region private static methods

        private static List<BonusNamesBLL> GenerateListBonusNamesBLLFromDataTable(DataTable dt)
        {
            List<BonusNamesBLL> list = new List<BonusNamesBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateBonusNamesBLLFromDataRow(dr));
            }

            return list;
        }

        private static BonusNamesBLL GenerateBonusNamesBLLFromDataRow(DataRow dr)
        {
            BonusNamesBLL objBLL = new BonusNamesBLL(
                dr[BonusNameKeys.FIELD_BONUS_NAME_ID] == DBNull.Value ? 0 : int.Parse(dr[BonusNameKeys.FIELD_BONUS_NAME_ID].ToString()),
                dr[BonusNameKeys.FIELD_BONUS_NAME_NAME] == DBNull.Value ? string.Empty : dr[BonusNameKeys.FIELD_BONUS_NAME_NAME].ToString(),
                dr[BonusNameKeys.FIELD_BONUS_NAME_DESCRIPTION] == DBNull.Value ? string.Empty : dr[BonusNameKeys.FIELD_BONUS_NAME_DESCRIPTION].ToString(),
                dr[BonusNameKeys.FIELD_BONUS_NAME_TYPE] == DBNull.Value ? 0 : int.Parse(dr[BonusNameKeys.FIELD_BONUS_NAME_TYPE].ToString()),
                dr[BonusNameKeys.FIELD_BONUS_NAME_VISIBLE] == DBNull.Value ? false : Convert.ToBoolean(dr[BonusNameKeys.FIELD_BONUS_NAME_VISIBLE].ToString())
                );            

            return objBLL;
        }


        #endregion

    }
}
