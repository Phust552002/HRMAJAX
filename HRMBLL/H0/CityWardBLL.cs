using HRMDAL.H0;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HRMBLL.H0
{
    public class CityWardBLL
    {
        public static DataTable GetAllCitys()
        {
            CityWardDAL dal = new CityWardDAL();
            return dal.GetAllCitys(); 
        }
        public static DataTable GetAllWards()
        {
            CityWardDAL dal = new CityWardDAL();
            return dal.GetAllWards();
        }
        public static DataTable GetWardsByCityId(int cityId)
        {
            CityWardDAL dal = new CityWardDAL();
            return dal.GetWardsByCityId(cityId);
        }
    }
}
