using System;
using System.Text;

using HRMBLL.H1.Helper;

namespace HRMBLL.H1.CalulateSalary
{
    public class OverTimeSalaryBLL
    {

        private string _TienAnLog = string.Empty;
        private string _TienDemLog = string.Empty;

        #region private fields

        private CoefficientEmployeeFinalBLL _ObjCoefficientEmployeeFinalBLL;        
        private WorkdayEmployeesBLLL _ObjWorkdayEmployeesBLLL;

        private double _ValueTIENDEM;
        private double _ValueTIENAN;

        private double _DON_GIA_LCB;
        private double _DON_GIA_TIENAN;

        #endregion

        public string TienAnLog
        {
            get { return _TienAnLog; }
            set { _TienAnLog = value; }
        }

        public string TienDemLog
        {
            get { return _TienDemLog; }
            set { _TienDemLog = value; }
        }

        #region properties

        public CoefficientEmployeeFinalBLL ObjCoefficientEmployeeFinalBLL
        {
            get { return _ObjCoefficientEmployeeFinalBLL; }
            set { _ObjCoefficientEmployeeFinalBLL = value; }
        }   
        public WorkdayEmployeesBLLL ObjWorkdayEmployeesBLLL
        {
            get { return _ObjWorkdayEmployeesBLLL; }
            set { _ObjWorkdayEmployeesBLLL = value; }
        }

        public double ValueTIENDEM
        {
            get { return _ValueTIENDEM; }
            set { _ValueTIENDEM = value; }
        }

        public double ValueTIENAN
        {
            get { return _ValueTIENAN; }
            set { _ValueTIENAN = value; }
        }

        /// <summary>
        /// Don gia luong can ban
        /// </summary>
        public double DON_GIA_LCB
        {
            get { return _DON_GIA_LCB; }
            set { _DON_GIA_LCB = value; }
        }

        /// <summary>
        /// Don gia tien an
        /// </summary>
        public double DON_GIA_TIENAN
        {
            get { return _DON_GIA_TIENAN; }
            set { _DON_GIA_TIENAN = value; }
        }

        #endregion

        /// <summary>
        /// TInh tien an giua ca
        ///    (tien an trong 1 thang * NC_LamViecThucTe)/NgayCongQDTrongThang 
        /// </summary>
        /// <returns></returns>
        public void CalculateTienAn()
        {

            double tienAnMotNgay = DON_GIA_TIENAN / ObjWorkdayEmployeesBLLL.XQDL;
            TienAnLog += "tienAnMotNgay = DonGiaTienAn:" + DON_GIA_TIENAN + "/XQD:" + ObjWorkdayEmployeesBLLL.XQDL + "=" + tienAnMotNgay + "<br/>";
            if (ObjWorkdayEmployeesBLLL.F_LeL > 0)
            {
                TienAnLog += "TienAnTemp = TienAnTemp:" + _ValueTIENAN;
                _ValueTIENAN += tienAnMotNgay * ObjWorkdayEmployeesBLLL.F_LeL;
                TienAnLog += " + tienAnMotNgay:" + tienAnMotNgay + " x LE:" + ObjWorkdayEmployeesBLLL.F_LeL + "=" + _ValueTIENAN + "<br/>";
            }
            if (ObjWorkdayEmployeesBLLL.XL > 0)
            {
                TienAnLog += "TienAnTemp = TienAnTemp:" + _ValueTIENAN;
                _ValueTIENAN += tienAnMotNgay * ObjWorkdayEmployeesBLLL.XL;
                TienAnLog += " + tienAnMotNgay:" + tienAnMotNgay + " x X:" + ObjWorkdayEmployeesBLLL.XL + "=" + _ValueTIENAN + "<br/>";
            }

        }
        /// <summary>
        /// Tinh tien lam dem
        ///    tien1giodem  = (HeSoLCB  + HeSoPCTN + HeSoPCCV + HeSoPCKV + HeSoPCDH) * DonGiaLCB * 0.3/ (8*XQDL);
        ///  tienlamdem = tien1giodem * giodem;
        /// </summary>
        /// <returns></returns>
        public void CalculateTienDem()
        {
            // Tinh tien lam dem

            if (!DefaultValues.IsNotCalculateNightTimeDepartment(ObjWorkdayEmployeesBLLL.DepartmentId))
            {
                double totalCoe = 0;               
                if (ObjCoefficientEmployeeFinalBLL != null)
                {
                    totalCoe = ObjCoefficientEmployeeFinalBLL.LCB + ObjCoefficientEmployeeFinalBLL.PCTN + ObjCoefficientEmployeeFinalBLL.PCCV + ObjCoefficientEmployeeFinalBLL.PCKV + ObjCoefficientEmployeeFinalBLL.PCDH;
                    TienDemLog += "TongHeSo = LCB:" + ObjCoefficientEmployeeFinalBLL.LCB + " + PCTN:" + ObjCoefficientEmployeeFinalBLL.PCTN + " + PCCV:" + ObjCoefficientEmployeeFinalBLL.PCCV + " + PCKV:" + ObjCoefficientEmployeeFinalBLL.PCKV + " + PCKV:" + ObjCoefficientEmployeeFinalBLL.PCKV;
                }                                
                if (totalCoe > 0)
                {
                    double tienMotGioDem = (totalCoe * DON_GIA_LCB * 0.3) / (ObjWorkdayEmployeesBLLL.XQDL * 8);                    
                    TienDemLog += "tienMotGioDem = (TongHeSo:" + totalCoe + " x DonGiaLCB:" + DON_GIA_LCB + " x 0.3)/(XQD:" + ObjWorkdayEmployeesBLLL.XQDL + " x 8)=" + tienMotGioDem;
                    _ValueTIENDEM = tienMotGioDem * ObjWorkdayEmployeesBLLL.NightTimeL;
                    TienDemLog += "tienMotGioDem:" + tienMotGioDem + " x GioDem:" + ObjWorkdayEmployeesBLLL.NightTimeL + " = " + _ValueTIENDEM;
                }
            }

        }

    }
}
