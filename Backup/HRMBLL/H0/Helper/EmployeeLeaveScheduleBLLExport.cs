using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.IO;

using Excel;
using System.Reflection;
using HRMDAL.H0;
using HRMUtil.KeyNames.H0;
using HRMUtil.KeyNames.H2;
using HRMUtil;

namespace HRMBLL.H0.Helper
{
    public class EmployeeLeaveScheduleBLLExport
    {
        public static string ExcelByFilter(string deptIds, int rootId, string fullname, string pathName)
        {
            ///////////////////////////////////////////
            System.Data.DataTable dt = EmployeeLeaveScheduleBLL.DT_GetByFilter("", deptIds, 0, 0, "");

            ///////////////////////////////////////////

            if (dt != null && dt.Rows.Count > 0)
            {
                Excel._Application oExcel;
                Excel._Workbook oWorkBook;
                Excel._Worksheet oWorkSheet;

                string fileName = string.Empty;
                try
                {
                    GC.Collect();
                    oExcel = new Excel.Application();
                    oExcel.Visible = false;

                    // Get new workbook
                    oWorkBook = (Excel._Workbook)(oExcel.Workbooks.Add(Missing.Value));
                    oWorkSheet = (Excel._Worksheet)oWorkBook.Worksheets[1];

                    oWorkSheet.Name = "Excel";

                    InsertDataToWorkSheet(dt, ref oWorkSheet);

                    oExcel.Visible = false;
                    oExcel.UserControl = false;
                    fileName = pathName + "\\BangTheoDoiPhep.xls";
                    if (File.Exists(fileName))
                        File.Delete(fileName);
                    oWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, null, null, false, false, Excel.XlSaveAsAccessMode.xlShared, false, false, null, null, null);

                    // Need all following code to clean up and extingush all references!!!
                    oWorkBook.Close(null, null, null);
                    oExcel.Workbooks.Close();
                    oExcel.Quit();
                    //System.Runtime.InteropServices.Marshal.ReleaseComObject(oRange);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oExcel);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oWorkSheet);

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oWorkBook);
                    oWorkSheet = null;
                    oWorkSheet = null;
                    oExcel = null;
                    GC.Collect();  // force final cleanup!

                    return fileName;

                }
                catch (Exception ex)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, ex.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, ex.Source);
                    throw new Exception(errorMessage);
                }
            }
            else
            {
                return null;
            }
        }

        private static void InsertDataToWorkSheet(System.Data.DataTable dt, ref Excel._Worksheet oWorkSheet)
        {

            //int deparmentId = 0;
            //int departmentIdBefore = 0;
            int initTitleIndex = 7;
            // create Content
            int indexRow = initTitleIndex + 1;
            int orderNumber = 1;
            DateTime temp = DateTime.Now;

            CreateHeaderAndTitle(ref oWorkSheet, ref initTitleIndex);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];


                oWorkSheet.Cells[indexRow, 1] = orderNumber++;
                oWorkSheet.Cells[indexRow, 2] = dr["FullName"] == DBNull.Value ? string.Empty : dr["FullName"].ToString();
                int Seniority = dr["Seniority"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Seniority"]);
                oWorkSheet.Cells[indexRow, 3] = Seniority.ToString();
                int MaxF = dr["MaxF"] == DBNull.Value ? 0 : Convert.ToInt32(dr["MaxF"]);
                oWorkSheet.Cells[indexRow, 4] = MaxF;

                int Total = Seniority + MaxF;

                oWorkSheet.Cells[indexRow, 5] = Total.ToString();

                oWorkSheet.Cells[indexRow, 6] = dr["FromDate"] == DBNull.Value ? string.Empty : dr["FromDate"].ToString();
                oWorkSheet.Cells[indexRow, 7] = dr["ToDate"] == DBNull.Value ? string.Empty : dr["ToDate"].ToString();

                int Days = dr["Days"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Days"]);
                oWorkSheet.Cells[indexRow, 8] = Days.ToString();
                oWorkSheet.Cells[indexRow, 9] = (Total - Days).ToString();
                oWorkSheet.Cells[indexRow, 10] = dr["Time"] == DBNull.Value ? string.Empty : dr["Time"].ToString();

                indexRow++;
            }

            Range range = oWorkSheet.get_Range("A7", "J7" + indexRow);
            range.Font.Size = 10;
            range.Font.Name = "Times New Roman";
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            //range = oWorkSheet.get_Range("D7", "D" + indexRow);
            //range.Font.Size = 10;
            //range.Font.Name = "Times New Roman";
            //range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            //range = oWorkSheet.get_Range("E7", "E" + indexRow);
            //range.Font.Size = 10;
            //range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //range.Font.Name = "Times New Roman";

            //range = oWorkSheet.get_Range("L7", "O" + indexRow);
            //range.Font.Size = 10;
            //range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            //range.VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
            //range.Font.Name = "Times New Roman";
            indexRow++;
        }

        private static void CreateHeaderAndTitle(ref Excel._Worksheet oWorkSheet, ref int initTitleIndex)
        {

            #region create header for printing from oWorkSheet

            Range rangeHeader1 = oWorkSheet.get_Range("A1", "D1");
            rangeHeader1.Merge(Type.Missing);
            oWorkSheet.Cells[1, 1] = "CÔNG TY CỔ PHẦN pHỤC VỤ MẶT ĐẤT SÀI GÒN";
            rangeHeader1.Font.Size = 12;
            rangeHeader1.Font.Bold = true;
            rangeHeader1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            rangeHeader1.Font.Name = "Times New Roman";

            Range rangeHeader3 = oWorkSheet.get_Range("A4", "H4");
            rangeHeader3.Merge(Type.Missing);
            oWorkSheet.Cells[4, 1] = "BẢNG THEO DÕI PHÉP";
            rangeHeader3.Font.Size = 16;
            rangeHeader3.Font.Bold = true;
            rangeHeader3.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            rangeHeader3.Font.Name = "Times New Roman";


            #endregion


            #region Create Title for Account List from oWorkSheet

            /// inserting title
            oWorkSheet.Cells[initTitleIndex, 1] = "STT";
            ((Range)oWorkSheet.Cells[initTitleIndex, 1]).ColumnWidth = 5;
            oWorkSheet.Cells[initTitleIndex, 2] = "Họ tên";
            ((Range)oWorkSheet.Cells[initTitleIndex, 2]).ColumnWidth = 30;
            oWorkSheet.Cells[initTitleIndex, 3] = "Ngày\nthâm\nniên";
            ((Range)oWorkSheet.Cells[initTitleIndex, 3]).ColumnWidth = 7;
            oWorkSheet.Cells[initTitleIndex, 4] = "Số\nngày\nphép";
            ((Range)oWorkSheet.Cells[initTitleIndex, 4]).ColumnWidth = 7;
            oWorkSheet.Cells[initTitleIndex, 5] = "Tổng\nngày\nphép";
            ((Range)oWorkSheet.Cells[initTitleIndex, 5]).ColumnWidth = 7;
            oWorkSheet.Cells[initTitleIndex, 6] = "Ngày đi phép";
            ((Range)oWorkSheet.Cells[initTitleIndex, 6]).ColumnWidth = 10;
            oWorkSheet.Cells[initTitleIndex, 7] = "Ngày vào phép";
            ((Range)oWorkSheet.Cells[initTitleIndex, 7]).ColumnWidth = 10;
            oWorkSheet.Cells[initTitleIndex, 8] = "Số\nngày\nđi";
            ((Range)oWorkSheet.Cells[initTitleIndex, 8]).ColumnWidth = 7;
            oWorkSheet.Cells[initTitleIndex, 9] = "Còn lại";
            ((Range)oWorkSheet.Cells[initTitleIndex, 9]).ColumnWidth = 7;
            oWorkSheet.Cells[initTitleIndex, 10] = "Lần nghỉ";
            ((Range)oWorkSheet.Cells[initTitleIndex, 10]).ColumnWidth = 7;

            #endregion

        }
    }
}
