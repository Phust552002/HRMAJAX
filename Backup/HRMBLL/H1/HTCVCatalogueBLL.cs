using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H1;
using HRMUtil.KeyNames.H1;
using HRMUtil.KeyNames.H0;
using HRMBLL.H1.Helper;
using HRMUtil;

namespace HRMBLL.H1
{
    public class HTCVCatalogueBLL
    {
        #region private fields

        private int _HTCVCatalogueId;
        private string _HTCVCatalogueName;
        private string _MarkDisplay; 
        private double _MarkDefault; 
        private int _TypeDisplay;
        private string _TypeDisplayName;

        private double _MinMark;
        private double _MaxMark;
        private double _ParentId;

        #endregion

        #region properties

        public int HTCVCatalogueId
        {
            get { return _HTCVCatalogueId; }
            set { _HTCVCatalogueId = value; }
        }
        public string HTCVCatalogueName
        {
            get { return _HTCVCatalogueName; }
            set { _HTCVCatalogueName = value; }
        }
        public string MarkDisplay
        {
            get { return _MarkDisplay; }
            set { _MarkDisplay = value; }
        } 
        public double MarkDefault
        {
            get { return _MarkDefault; }
            set { _MarkDefault = value; }
        } 
        public int TypeDisplay
        {
            get { return _TypeDisplay; }
            set { _TypeDisplay = value; }
        }
        public string TypeDisplayName
        {
            get { return _TypeDisplayName; }
            set { _TypeDisplayName = value; }
        }

        public double MinMark
        {
            get { return _MinMark; }
            set { _MinMark = value; }
        }
        public double MaxMark
        {
            get { return _MaxMark; }
            set { _MaxMark = value; }
        }
        public double ParentId
        {
            get { return _ParentId; }
            set { _ParentId = value; }
        }

        #endregion
       
        #region public methods insert, update, delete

        public int Save()
        {
            HTCVCatalogueDAL objDAL = new HTCVCatalogueDAL();

            if (_HTCVCatalogueId <= 0)
            {
                return objDAL.Insert(HTCVCatalogueName, MarkDisplay, MarkDefault, TypeDisplay);
            }
            else
            {
                return objDAL.Update(HTCVCatalogueName, MarkDisplay, MarkDefault, TypeDisplay, HTCVCatalogueId);
            }

        }

        public static void Update(string hTCVCatalogueName, string markDisplay, double markDefault, int typeDisplay, int hTCVCatalogueId)
        {
            new HTCVCatalogueDAL().Update(hTCVCatalogueName, markDisplay, markDefault, typeDisplay, hTCVCatalogueId);
        }

        public static void Delete(int hTCVCatalogueId)
        {
            new HTCVCatalogueDAL().Delete(hTCVCatalogueId);
        }

        #endregion

        #region public methods GET

        public static List<HTCVCatalogueBLL> GetByFilter(string hTCVCatalogueName, string markDisplay, double markDefault, int typeDisplay)
        {
            return GenerateListHTCVCatalogueBLLFromDataTable(new HTCVCatalogueDAL().GetByFilter(hTCVCatalogueName, markDisplay, markDefault, typeDisplay));
        }
        public static HTCVCatalogueBLL GetById(int hTCVCatalogueId)
        {
            List<HTCVCatalogueBLL> list = GenerateListHTCVCatalogueBLLFromDataTable(new HTCVCatalogueDAL().GetById(hTCVCatalogueId));
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

        private static List<HTCVCatalogueBLL> GenerateListHTCVCatalogueBLLFromDataTable(DataTable dt)
        {
            List<HTCVCatalogueBLL> list = new List<HTCVCatalogueBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateHTCVCatalogueBLLFromDataRow(dr));
            }

            return list;
        }

        private static HTCVCatalogueBLL GenerateHTCVCatalogueBLLFromDataRow(DataRow dr)
        {

            HTCVCatalogueBLL objBLL = new HTCVCatalogueBLL();

            objBLL._HTCVCatalogueId = dr[HTCVCatalogueKeys.Field_HTCVCatalogue_ID] == DBNull.Value ? 0 : int.Parse(dr[HTCVCatalogueKeys.Field_HTCVCatalogue_ID].ToString());
            objBLL._HTCVCatalogueName = dr[HTCVCatalogueKeys.Field_HTCVCatalogue_Name] == DBNull.Value ? string.Empty : dr[HTCVCatalogueKeys.Field_HTCVCatalogue_Name].ToString();
            objBLL._MarkDisplay = dr[HTCVCatalogueKeys.Field_HTCVCatalogue_MarkDisplay] == DBNull.Value ? string.Empty : dr[HTCVCatalogueKeys.Field_HTCVCatalogue_MarkDisplay].ToString();
            objBLL._MarkDefault = dr[HTCVCatalogueKeys.Field_HTCVCatalogue_MarkDefault] == DBNull.Value ? 0 : double.Parse(dr[HTCVCatalogueKeys.Field_HTCVCatalogue_MarkDefault].ToString());
            objBLL._TypeDisplay = dr[HTCVCatalogueKeys.Field_HTCVCatalogue_TypeDisplay] == DBNull.Value ? 0 : int.Parse(dr[HTCVCatalogueKeys.Field_HTCVCatalogue_TypeDisplay].ToString());
            objBLL._TypeDisplayName = Constants.GetHTCVCatalogueTypeName(objBLL._TypeDisplay);

            objBLL._MinMark = dr[HTCVCatalogueKeys.Field_HTCVCatalogue_MinMark] == DBNull.Value ? 0 : double.Parse(dr[HTCVCatalogueKeys.Field_HTCVCatalogue_MinMark].ToString());
            objBLL._MaxMark = dr[HTCVCatalogueKeys.Field_HTCVCatalogue_MaxMark] == DBNull.Value ? 0 : double.Parse(dr[HTCVCatalogueKeys.Field_HTCVCatalogue_MaxMark].ToString());
            objBLL._ParentId = dr[HTCVCatalogueKeys.Field_HTCVCatalogue_ParentId] == DBNull.Value ? 0 : int.Parse(dr[HTCVCatalogueKeys.Field_HTCVCatalogue_ParentId].ToString());

            return objBLL;
        }

        #endregion
    }
}
