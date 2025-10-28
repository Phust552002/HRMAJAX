using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using HRMDAL.Utilities;
using HRMDAL.H1;
using HRMUtil.KeyNames.H1;
using HRMBLL.H1.Helper;

namespace HRMBLL.H1
{
    public class CoefficientNamesBLL
    {

        #region private fields

        private int _CoefficientNameId;
        private string _CoefficientName;
        private string _CoefficientNameDescription;

        private double _ValueLevel1;
        private double _Condition1;
        private double _ValueLevel2;
        private double _Condition2;
        private double _ValueLevel3;
        private double _Condition3;
        private double _ValueLevel4;
        private double _Condition4;
        private double _ValueLevel5;
        private double _Condition5;
        private double _ValueLevel6;
        private double _Condition6;
        private double _ValueLevel7;
        private double _Condition7;
        private double _ValueLevel8;
        private double _Condition8;
        private double _ValueLevel9;
        private double _Condition9;
        private double _ValueLevel10;
        private double _Condition10;
        private double _ValueLevel11;
        private double _Condition11;
        private double _ValueLevel12;
        private double _Condition12;

        #endregion

        #region properties

        public int CoefficientNameId
        {
            get { return _CoefficientNameId; }
            set { _CoefficientNameId = value; }
        }
        public string CoefficientName
        {
            get { return _CoefficientName; }
            set { _CoefficientName = value; }
        }
        public string CoefficientNameDescription
        {
            get { return _CoefficientNameDescription; }
            set { _CoefficientNameDescription = value; }
        }

        public double ValueLevel1
        {
            get { return _ValueLevel1; }
            set { _ValueLevel1 = value; }
        }

        public double Condition1
        {
            get { return _Condition1; }
            set { _Condition1 = value; }
        }

        public double ValueLevel2
        {
            get { return _ValueLevel2; }
            set { _ValueLevel2 = value; }
        }

        public double Condition2
        {
            get { return _Condition2; }
            set { _Condition2 = value; }
        }

        public double ValueLevel3
        {
            get { return _ValueLevel3; }
            set { _ValueLevel3 = value; }
        }

        public double Condition3
        {
            get { return _Condition3; }
            set { _Condition3 = value; }
        }

        public double ValueLevel4
        {
            get { return _ValueLevel4; }
            set { _ValueLevel4 = value; }
        }

        public double Condition4
        {
            get { return _Condition4; }
            set { _Condition4 = value; }
        }

        public double ValueLevel5
        {
            get { return _ValueLevel5; }
            set { _ValueLevel5 = value; }
        }

        public double Condition5
        {
            get { return _Condition5; }
            set { _Condition5 = value; }
        }

        public double ValueLevel6
        {
            get { return _ValueLevel6; }
            set { _ValueLevel6 = value; }
        }

        public double Condition6
        {
            get { return _Condition6; }
            set { _Condition6 = value; }
        }

        public double ValueLevel7
        {
            get { return _ValueLevel7; }
            set { _ValueLevel7 = value; }
        }

        public double Condition7
        {
            get { return _Condition7; }
            set { _Condition7 = value; }
        }

        public double ValueLevel8
        {
            get { return _ValueLevel8; }
            set { _ValueLevel8 = value; }
        }

        public double Condition8
        {
            get { return _Condition8; }
            set { _Condition8 = value; }
        }

        public double ValueLevel9
        {
            get { return _ValueLevel9; }
            set { _ValueLevel9 = value; }
        }

        public double Condition9
        {
            get { return _Condition9; }
            set { _Condition9 = value; }
        }

        public double ValueLevel10
        {
            get { return _ValueLevel10; }
            set { _ValueLevel10 = value; }
        }

        public double Condition10
        {
            get { return _Condition10; }
            set { _Condition10 = value; }
        }

        public double ValueLevel11
        {
            get { return _ValueLevel11; }
            set { _ValueLevel11 = value; }
        }

        public double Condition11
        {
            get { return _Condition11; }
            set { _Condition11 = value; }
        }

        public double ValueLevel12
        {
            get { return _ValueLevel12; }
            set { _ValueLevel12 = value; }
        }
        public double Condition12
        {
            get { return _Condition12; }
            set { _Condition12 = value; }
        }
       

        #endregion

        #region Constructor

        public CoefficientNamesBLL() { }

        public CoefficientNamesBLL(int coefficientNameId, string coefficientName, string coefficientNameDescription)
        {
            _CoefficientNameId = coefficientNameId;
            _CoefficientName = coefficientName;
            _CoefficientNameDescription = coefficientNameDescription;
        }

        #endregion

        #region public method Insert, Update, Delete

        //public int Save()
        //{
        //    CoefficientNamesDAL objLNS_CoefficientNamesDAL = new CoefficientNamesDAL();
        //    if (LNS_CoefficientNameId <= 0)
        //    {                
        //        return objLNS_CoefficientNamesDAL.Insert(LNS_CoefficientName, LNS_CoefficientNameDescription);    
        //    }
        //    else 
        //    {
        //        return objLNS_CoefficientNamesDAL.Update(LNS_CoefficientNameId, LNS_CoefficientName, LNS_CoefficientNameDescription);    
        //    }
        //}

        //public static int Update(int lNS_CoefficientNameId, string lNS_CoefficientName, string lNS_CoefficientNameDescription)
        //{
        //    CoefficientNamesDAL objLNS_CoefficientNamesDAL = new CoefficientNamesDAL();
        //    return objLNS_CoefficientNamesDAL.Update(lNS_CoefficientNameId, lNS_CoefficientName, lNS_CoefficientNameDescription);    
        //}

        #endregion

        #region public method Get

        public static List<CoefficientNamesBLL> GetByFilter(int type, string coefficientName, int SalaryRegulationId)
        {
            CoefficientValuesDAL objDAL = new CoefficientValuesDAL();
            if (type == CoefficientNameKeys.CONST_LNS_COEFFICIENT_NAME_POSITION_TYPE || type == CoefficientNameKeys.CONST_LNS_COEFFICIENT_NAME_FIXEDRATE_TYPE)
            {
                return GenerateListLNSCoefficientNamesBLLFromDataTable(objDAL.GetByFilter(type, coefficientName, SalaryRegulationId));
            }
            else
            {
                return GenerateListLCBCoefficientNamesBLLFromDataTable(objDAL.GetByFilter(type, coefficientName, SalaryRegulationId));
            }
        }

        public static List<CoefficientNamesBLL> GetAll(int type)
        {
            CoefficientValuesDAL objDAL = new CoefficientValuesDAL();
            if (type == 0)
            {
                return GenerateListLNSCoefficientNamesBLLFromDataTable(objDAL.GetAll(type));
            }
            else
            {
                return GenerateListLCBCoefficientNamesBLLFromDataTable(objDAL.GetAll(type));
            }
        }

        public static List<CoefficientNamesBLL> GetAllNames(int type)
        {
            CoefficientNamesDAL objDAL = new CoefficientNamesDAL();
            return GenerateListCoefficientNamesBLLFromDataTable_AllNames(objDAL.GetAllNames(type));
        }
        public static List<CoefficientNamesBLL> GetByInUseTypeId(bool inUse, int typeId, int type)
        {
            CoefficientNamesDAL objDAL = new CoefficientNamesDAL();
            return GenerateListCoefficientNamesBLLFromDataTable_AllNames(objDAL.GetByInUseTypeId(inUse, typeId, type));
        }

        #endregion

        #region private method

        private static List<CoefficientNamesBLL> GenerateListLNSCoefficientNamesBLLFromDataTable(DataTable dt)
        {
            List<CoefficientNamesBLL> list = new List<CoefficientNamesBLL>();
            bool flag = false;
            double v1 = 0, v2 = 0, v3 = 0, v4 = 0, v5 = 0;
            int level = 0;

            for (int i = 0; i < dt.Rows.Count-1; i++)
            {
                int idF = 0;
                int idA = 0;                

                DataRow drF = dt.Rows[i];
                idF = drF[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId] == DBNull.Value ? DefaultValues.CoefficientNameIdMinValue : int.Parse(drF[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId].ToString());
                level = drF[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_ID] == DBNull.Value ? DefaultValues.CoefficientLevelIdMinValue : int.Parse(drF[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_ID].ToString());               

                DataRow drA = dt.Rows[i + 1];
                idA = drA[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId] == DBNull.Value ? DefaultValues.CoefficientNameIdMinValue : int.Parse(drA[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId].ToString());
                
                if (idF > 0 && idA > 0)
                {

                    if (idF == idA)
                    {
                        if (level == CoefficientLevelKeys.CONST_LNS_LEVEL_1 || level == CoefficientLevelKeys.CONST_LNS_KHOAN_LEVEL_1)
                        {
                            v1 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                            continue;
                        }
                        else if (level == CoefficientLevelKeys.CONST_LNS_LEVEL_2 || level == CoefficientLevelKeys.CONST_LNS_KHOAN_LEVEL_2)
                        {
                            v2 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                            continue;
                        }
                        else if (level == CoefficientLevelKeys.CONST_LNS_LEVEL_3 || level == CoefficientLevelKeys.CONST_LNS_KHOAN_LEVEL_3)
                        {
                            v3 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                            continue;
                        }
                        if (i == dt.Rows.Count - 2)
                        {
                            if (level == CoefficientLevelKeys.CONST_LNS_LEVEL_4 || level == CoefficientLevelKeys.CONST_LNS_KHOAN_LEVEL_4)
                            {
                                v4 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());                                
                            }

                            DataRow drLast = dt.Rows[dt.Rows.Count - 1];
                            idA = drLast[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId] == DBNull.Value ? DefaultValues.CoefficientNameIdMinValue : int.Parse(drLast[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId].ToString());
                            level = drLast[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_ID] == DBNull.Value ? DefaultValues.CoefficientLevelIdMinValue : int.Parse(drLast[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_ID].ToString());

                            if (level == CoefficientLevelKeys.CONST_LNS_LEVEL_5 || level == CoefficientLevelKeys.CONST_LNS_KHOAN_LEVEL_5)
                            {
                                v5 = drLast[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drLast[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                                flag = true;
                            }
                        }
                        else
                        {
                            if (level == CoefficientLevelKeys.CONST_LNS_LEVEL_4 || level == CoefficientLevelKeys.CONST_LNS_KHOAN_LEVEL_4)
                            {
                                v4 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                                continue;
                            }
                            
                        }

                    }
                    else
                    {
                        if (level == CoefficientLevelKeys.CONST_LNS_LEVEL_5 || level == CoefficientLevelKeys.CONST_LNS_KHOAN_LEVEL_5)
                        {
                            v5 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                            flag = true;
                        }
                    }

                    if (flag)
                    {
                        CoefficientNamesBLL objBLL = new CoefficientNamesBLL(idF,
                            drF[CoefficientNameKeys.Field_CoefficientNames_CoefficientName] == DBNull.Value ? string.Empty : (string)drF[CoefficientNameKeys.Field_CoefficientNames_CoefficientName],
                            string.Empty);

                        objBLL.ValueLevel1 = v1;
                        objBLL.ValueLevel2 = v2;
                        objBLL.ValueLevel3 = v3;
                        objBLL.ValueLevel4 = v4;
                        objBLL.ValueLevel5 = v5;
                        list.Add(objBLL);
                        flag = false;
                    }
                    

                }

            }// for

            return list;
        }

        private static List<CoefficientNamesBLL> GenerateListLCBCoefficientNamesBLLFromDataTable(DataTable dt)
        {
            List<CoefficientNamesBLL> list = new List<CoefficientNamesBLL>();
            bool flag = false;
            double v1 = 0, v2 = 0, v3 = 0, v4 = 0, v5 = 0;
            double v6 = 0, v7 = 0, v8 = 0, v9 = 0, v10 = 0, v11 = 0, v12 = 0;
            double c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0;
            double c6 = 0, c7 = 0, c8 = 0, c9 = 0, c10 = 0, c11 = 0, c12 = 0;

            int level = 0;

            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                int idF = 0;
                int idA = 0;

                DataRow drF = dt.Rows[i];
                idF = drF[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId] == DBNull.Value ? DefaultValues.CoefficientNameIdMinValue : int.Parse(drF[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId].ToString());
                level = drF[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_ID] == DBNull.Value ? DefaultValues.CoefficientLevelIdMinValue : int.Parse(drF[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_ID].ToString());

                DataRow drA = dt.Rows[i + 1];
                idA = drA[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId] == DBNull.Value ? DefaultValues.CoefficientNameIdMinValue : int.Parse(drA[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId].ToString());

                if (idF > 0 && idA > 0)
                {

                    if (idF == idA)
                    {
                        if (level == CoefficientLevelKeys.CONST_LCB_LEVEL_1)
                        {
                            v1 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                            c1 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS].ToString());
                            continue;
                        }
                        else if (level == CoefficientLevelKeys.CONST_LCB_LEVEL_2)
                        {
                            v2 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                            c2 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS].ToString());
                            continue;
                        }
                        else if (level == CoefficientLevelKeys.CONST_LCB_LEVEL_3)
                        {
                            v3 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                            c3 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS].ToString());
                            continue;
                        }
                        else if (level == CoefficientLevelKeys.CONST_LCB_LEVEL_4)
                        {
                            v4 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                            c4 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS].ToString());
                            continue;
                        }
                        else if (level == CoefficientLevelKeys.CONST_LCB_LEVEL_5)
                        {
                            v5 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                            c5 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS].ToString());
                            continue;
                        }
                        else if (level == CoefficientLevelKeys.CONST_LCB_LEVEL_6)
                        {
                            v6 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                            c6 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS].ToString());
                            continue;
                        }
                        else if (level == CoefficientLevelKeys.CONST_LCB_LEVEL_7)
                        {
                            v7 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                            c7 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS].ToString());
                            continue;
                        }
                        else if (level == CoefficientLevelKeys.CONST_LCB_LEVEL_8)
                        {
                            v8 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                            c8 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS].ToString());
                            continue;
                        }
                        else if (level == CoefficientLevelKeys.CONST_LCB_LEVEL_9)
                        {
                            v9 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                            c9 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS].ToString());
                            continue;
                        }
                        else if (level == CoefficientLevelKeys.CONST_LCB_LEVEL_10)
                        {
                            v10 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                            c10 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS].ToString());
                            continue;
                        }

                        if (i == dt.Rows.Count - 2)
                        {
                            if (level == CoefficientLevelKeys.CONST_LCB_LEVEL_11)
                            {
                                v11 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                                c11 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS].ToString());
                            }

                            DataRow drLast = dt.Rows[dt.Rows.Count - 1];
                            idA = drLast[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId] == DBNull.Value ? DefaultValues.CoefficientNameIdMinValue : int.Parse(drLast[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId].ToString());
                            level = drLast[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_ID] == DBNull.Value ? DefaultValues.CoefficientLevelIdMinValue : int.Parse(drLast[CoefficientLevelKeys.FIELD_COEFFICIENT_LEVEL_ID].ToString());

                            if (level == CoefficientLevelKeys.CONST_LCB_LEVEL_12)
                            {
                                v12 = drLast[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drLast[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                                c12 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS].ToString());
                                flag = true;
                            }
                        }
                        else
                        {
                            if (level == CoefficientLevelKeys.CONST_LCB_LEVEL_11)
                            {
                                v11 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                                c11 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS].ToString());
                                continue;
                            }

                        }

                    }
                    else
                    {
                        if (level == CoefficientLevelKeys.CONST_LCB_LEVEL_12)
                        {
                            v12 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_VALUE].ToString());
                            c12 = drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS] == DBNull.Value ? 0 : double.Parse(drF[CoefficientValueKeys.FIELD_COEFFICIENT_CONDITIONS].ToString());
                            flag = true;
                        }
                    }

                    if (flag)
                    {
                        CoefficientNamesBLL objBLL = new CoefficientNamesBLL(idF,
                            drF[CoefficientNameKeys.Field_CoefficientNames_CoefficientName] == DBNull.Value ? string.Empty : (string)drF[CoefficientNameKeys.Field_CoefficientNames_CoefficientName],
                            string.Empty);

                        objBLL.ValueLevel1 = v1;
                        objBLL.Condition1 = c1;
                        objBLL.ValueLevel2 = v2;
                        objBLL.Condition2 = c2;
                        objBLL.ValueLevel3 = v3;
                        objBLL.Condition3 = c3;
                        objBLL.ValueLevel4 = v4;
                        objBLL.Condition4 = c4;
                        objBLL.ValueLevel5 = v5;
                        objBLL.Condition5 = c5;

                        objBLL.ValueLevel6 = v6;
                        objBLL.Condition6 = c6;
                        objBLL.ValueLevel7 = v7;
                        objBLL.Condition7 = c7;
                        objBLL.ValueLevel8 = v8;
                        objBLL.Condition8 = c8;
                        objBLL.ValueLevel9 = v9;
                        objBLL.Condition9 = c9;
                        objBLL.ValueLevel10 = v10;
                        objBLL.Condition10 = c10;
                        objBLL.ValueLevel11 = v11;
                        objBLL.Condition11 = c11;
                        objBLL.ValueLevel12 = v12;
                        objBLL.Condition12 = c12;

                        list.Add(objBLL);
                        flag = false;
                    }


                }

            }// for

            return list;
        }

        private static List<CoefficientNamesBLL> GenerateListCoefficientNamesBLLFromDataTable_AllNames(DataTable dt)
        {
            List<CoefficientNamesBLL> list = new List<CoefficientNamesBLL>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(GenerateCoefficientNamesBLLFromDataRow(dr));
            }

            return list;
        }

        private static CoefficientNamesBLL GenerateCoefficientNamesBLLFromDataRow(DataRow dr)
        {
            CoefficientNamesBLL objBLL = new CoefficientNamesBLL(
                dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId] == DBNull.Value ? DefaultValues.CoefficientNameIdMinValue : int.Parse(dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameId].ToString()),
                dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientName] == DBNull.Value ? string.Empty : (string)dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientName],
                dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameDescription] == DBNull.Value ? string.Empty : (string)dr[CoefficientNameKeys.Field_CoefficientNames_CoefficientNameDescription]
            );

            return objBLL;
        }

        #endregion


    }
}
