using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H0;
using HRMUtil.KeyNames.H0;
using HRMBLL.H0.Helper;
using HRMUtil;

namespace HRMBLL.H0
{
    public class RelationTypesBLL
    {
        
        #region private fields

        private int _RelationTypeId;
        private string _RelationTypeName;                
        private string _Description;
        private int _Type;
        private string _TypeName;

        #endregion


        #region properties

        public int RelationTypeId
        {
            get { return _RelationTypeId; }
            set { _RelationTypeId = value; }
        }

        public string RelationTypeName
        {
            get { return _RelationTypeName; }
            set { _RelationTypeName = value; }
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public int Type
        {
            get{return _Type;}
            set{_Type = value;}
        }
        public string TypeName
        {
            get { return _TypeName; }
            set { _TypeName = value; }
        }

        #endregion


        #region constructors

        public RelationTypesBLL(int relationType, string relationTypeName, string description, int type)
        {
            _RelationTypeId = relationType;
            _RelationTypeName = relationTypeName;                
            _Description = description;
            _Type = type;
        }

        #endregion


        #region public methods insert, update, delete

        public long Save()
        {
            RelationTypesDAL objDAL = new RelationTypesDAL();
            if (_RelationTypeId <= 0)
            {
                return objDAL.Insert(_RelationTypeName, _Description, _Type);
            }
            else
            {
                return objDAL.Update(_RelationTypeName, Description, _Type, _RelationTypeId);
            }

        }

        public static long Update(string relationTypeName, string description, int type, int relationTypeId)
        {
            RelationTypesDAL objDAL = new RelationTypesDAL();
            return objDAL.Update(relationTypeName, description, type, relationTypeId);
        }

        public static long Delete(int relationTypeId)
        {
            RelationTypesDAL objDAL = new RelationTypesDAL();
            return objDAL.Delete(relationTypeId);
        }

        #endregion


        #region public static Get methods

        public static List<RelationTypesBLL> GetByFilter(string relationTypeName, int type)
        {
            RelationTypesDAL objDAL = new RelationTypesDAL();
            return GenerateListRelationTypesBLLFromDataTable(objDAL.GetByFilter(relationTypeName, type));
        }


        public static List<RelationTypesBLL>GetAll()
        {
            RelationTypesDAL objDAL = new RelationTypesDAL();
            return GenerateListRelationTypesBLLFromDataTable(objDAL.GetAll());
        }

        public static List<RelationTypesBLL> GetAll_N()
        {
            RelationTypesDAL objDAL = new RelationTypesDAL();
            return GenerateListRelationTypesBLLFromDataTable_N(objDAL.GetAll());
        }

        #endregion


        #region private methods

        private static List<RelationTypesBLL> GenerateListRelationTypesBLLFromDataTable_N(DataTable dt)
        {
            List<RelationTypesBLL> list = new List<RelationTypesBLL>();

            list.Add(new RelationTypesBLL(0, "None", string.Empty, 0));

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateRelationTypesBLLFromDataRow(dr));
            }

            return list;
        }

        private static List<RelationTypesBLL> GenerateListRelationTypesBLLFromDataTable(DataTable dt)
        {
            List<RelationTypesBLL> list = new List<RelationTypesBLL>();            

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateRelationTypesBLLFromDataRow(dr));
            }

            return list;
        }

        private static RelationTypesBLL GenerateRelationTypesBLLFromDataRow(DataRow dr)
        {
            RelationTypesBLL objBLL = new RelationTypesBLL(
                dr[RelationTypeKeys.FIELD_RELATION_TYPE_ID] == DBNull.Value ? 0 : int.Parse(dr[RelationTypeKeys.FIELD_RELATION_TYPE_ID].ToString()),
                dr[RelationTypeKeys.FIELD_RELATION_TYPE_NAME] == DBNull.Value ? string.Empty : dr[RelationTypeKeys.FIELD_RELATION_TYPE_NAME].ToString(),
                dr[RelationTypeKeys.FIELD_RELATION_TYPE_DESCRIPTION] == DBNull.Value ? string.Empty : dr[RelationTypeKeys.FIELD_RELATION_TYPE_DESCRIPTION].ToString(),
                dr[RelationTypeKeys.FIELD_RELATION_TYPE_TYPE] == DBNull.Value ? 0 : int.Parse(dr[RelationTypeKeys.FIELD_RELATION_TYPE_TYPE].ToString())
                );
            objBLL._TypeName = Constants.GetRTypeName(objBLL._Type);

            return objBLL;
        }

        #endregion
    }
}
