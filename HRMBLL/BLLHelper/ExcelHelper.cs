using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace HRMBLL.BLLHelper
{
    public class ExcelHelper
    {

        #region private fields

        private string _FileName;

        #endregion


        #region properties

        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value; }
        }

        #endregion

        #region constructor

        public ExcelHelper(string fileName)
        {
            _FileName = fileName;
        }

        #endregion

        public DataTable ReadDataFromExcelToDataTable()
        {
            string strConn;
            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + this.FileName + "; Extended Properties=Excel 8.0;";
            //You must use the $ after the object you reference in the spreadsheet
            OleDbDataAdapter myCommand = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", strConn);
            DataSet myDataSet = new DataSet();
            myCommand.Fill(myDataSet, "ExcelInfo");

            return myDataSet.Tables["ExcelInfo"];
        }

        public DataTable ReadDataFromExcelToDataTable(string sheetName)
        {
            string strConn;
            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + this.FileName + "; Extended Properties=Excel 8.0;";
            //You must use the $ after the object you reference in the spreadsheet
            OleDbDataAdapter myCommand = new OleDbDataAdapter("SELECT * FROM [" + sheetName + "$]", strConn);
            DataSet myDataSet = new DataSet();
            myCommand.Fill(myDataSet, "ExcelInfo");

            return myDataSet.Tables["ExcelInfo"];
        }
    }
}
