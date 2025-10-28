using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H0;
using HRMUtil.KeyNames.H0;
using HRMUtil.KeyNames.H1;
using HRMBLL.H0.Helper;

namespace HRMBLL.H0
{
    public class SiteMapBLL
    {
        #region private fields

        private int _SiteMapId;
        private string _Title;
        private string _Url;
        private int _ParentId;
        private string _RoleIds;
        private string _Icon;

        #endregion

        #region properties

        public int SiteMapId
        {
            get { return _SiteMapId; }
            set { _SiteMapId = value; }
        }
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public string Url
        {
            get { return _Url; }
            set { _Url = value; }
        }
        public int ParentId
        {
            get { return _ParentId; }
            set { _ParentId = value; }
        }

        public string RoleIds
        {
            get { return _RoleIds; }
            set { _RoleIds = value; }
        }

        public string Icon
        {
            get { return _Icon; }
            set { _Icon = value; }
        }

        #endregion

        #region constructor

        public SiteMapBLL(int siteMapId, string title, int parentId)
        {
            _SiteMapId = siteMapId;
            _Title = title;
            _ParentId = parentId;
        }

        #endregion

        #region methods insert, update, delete

        #endregion

        #region public static method Get

        public static List<SiteMapBLL> GetAllRoots()
        {
            return GenerateListSiteMapBLLFromDataTable(new SiteMapDAL().GetAllRoots());
        }

        public static List<SiteMapBLL> GetByParentId(int parentId)
        {
            return GenerateListSiteMapBLLFromDataTable(new SiteMapDAL().GetByParentId(parentId));
        }

        //public static List<SiteMapBLL> GetByRoles(int roleId)
        //{
        //    return GenerateListSiteMapBLLFromDataTable(new SiteMapDAL().GetByRoles(roleId));
        //}
        public static List<SiteMapBLL> GetByRoles(string roleIds)
        {
            return GenerateListSiteMapBLLFromDataTable(new SiteMapDAL().GetByRoles(roleIds));
        }

        #endregion

        #region private static methods


        private static List<SiteMapBLL> GenerateListSiteMapBLLFromDataTable(DataTable dt)
        {
            List<SiteMapBLL> list = new List<SiteMapBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateSiteMapBLLFromDataRow(dr));
            }

            return list;
        }

        private static SiteMapBLL GenerateSiteMapBLLFromDataRow(DataRow dr)
        {
            SiteMapBLL objBLL = new SiteMapBLL(
                dr[SiteMapKeyNames.FIELD_SITE_MAP_ID] == DBNull.Value ? 0 : int.Parse(dr[SiteMapKeyNames.FIELD_SITE_MAP_ID].ToString()),
                dr[SiteMapKeyNames.FIELD_SITE_MAP_TITLE] == DBNull.Value ? string.Empty : dr[SiteMapKeyNames.FIELD_SITE_MAP_TITLE].ToString(),
                dr[SiteMapKeyNames.FIELD_SITE_MAP_PARENTID] == DBNull.Value ? 0 : int.Parse(dr[SiteMapKeyNames.FIELD_SITE_MAP_PARENTID].ToString()));

            objBLL._Url = dr[SiteMapKeyNames.FIELD_SITE_MAP_URL] == DBNull.Value ? string.Empty : dr[SiteMapKeyNames.FIELD_SITE_MAP_URL].ToString();
            objBLL._RoleIds = dr[SiteMapKeyNames.FIELD_SITE_MAP_ROLEIDS] == DBNull.Value ? string.Empty : dr[SiteMapKeyNames.FIELD_SITE_MAP_ROLEIDS].ToString();
            try
            {
                objBLL._Icon = dr[SiteMapKeyNames.Field_SiteMap_Icon] == DBNull.Value ? string.Empty : dr[SiteMapKeyNames.Field_SiteMap_Icon].ToString();
            }
            catch
            {
                objBLL._Icon = "";}
            return objBLL;
        }


        #endregion
    }
}
