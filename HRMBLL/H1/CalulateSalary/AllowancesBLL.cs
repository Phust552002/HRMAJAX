using System;
using System.Text;
using HRMBLL.H1.Helper;

namespace HRMBLL.H1.CalulateSalary
{
    public class AllowancesBLL
    {

        private string _PCLog = string.Empty;
        private string _TCBHXHLog = string.Empty;

        #region private fields

        private WorkdayEmployeesBLLL _ObjWorkdayEmployeesBLLL;
        private CoefficientEmployeeFinalBLL _ObjCoefficientEmployeeFinalBLL;        
        
        private double _DON_GIA_LCB;

        private double _ValuePCTN;
        private double _ValuePCDH;
        private double _ValuePCCV;

        private double _ValueTCBHXH;
        private double _ValueTCOm;
        private double _ValueTCTS1Lan;
        

        #endregion

        public string PCLog
        {
            set { _PCLog = value; }
            get { return _PCLog; }
        }
        public string TCBHXHLog
        {
            set { _TCBHXHLog = value; }
            get { return _TCBHXHLog; }
        }

        #region properties

        public WorkdayEmployeesBLLL ObjWorkdayEmployeesBLLL
        {
            get { return _ObjWorkdayEmployeesBLLL; }
            set { _ObjWorkdayEmployeesBLLL = value; }
        }

        public CoefficientEmployeeFinalBLL ObjCoefficientEmployeeFinalBLL
        {
            get { return _ObjCoefficientEmployeeFinalBLL; }
            set { _ObjCoefficientEmployeeFinalBLL = value; }
        }

        public double ValuePCDH
        {
            get { return _ValuePCDH; }
            set { _ValuePCDH = value; }
        }

        public double ValuePCTN
        {
            get { return _ValuePCTN; }
            set { _ValuePCTN = value; }
        }

        public double ValuePCCV
        {
            get { return _ValuePCCV; }
            set { _ValuePCCV = value; }
        }

        public double ValueTCBHXH
        {
            get { return _ValueTCBHXH; }
            set { _ValueTCBHXH = value; }
        }
        public double ValueTCOm
        {
            get { return _ValueTCOm; }
            set { _ValueTCOm = value; }
        }
        public double ValueTCTS1Lan
        {
            get { return _ValueTCTS1Lan; }
            set { _ValueTCTS1Lan = value; }
        }

        /// <summary>
        /// Don gia luong can ban
        /// </summary>
        public double DON_GIA_LCB
        {
            get { return _DON_GIA_LCB; }
            set { _DON_GIA_LCB = value; }
        }

        #endregion

        /// <summary>
        /// tinh khoan phu cap trach nhiem
        ///     DonGiaLCB * HeSoPCTN
        /// 
        /// tinh khoan phu cap doc hai
        ///     (DonGiaLCB * HeSoPCHD * NC_LamViecThucTe)/ NgayCongQDTrongThang
        /// 
        /// tinh khoan phu cap chuc vu
        ///     DonGiaLCB * HesoPCCV
        ///          
       
        /// </summary>
        /// <returns></returns>
        public void CalculatePC()
        {
            if (ObjCoefficientEmployeeFinalBLL != null)
            {
                _ValuePCCV = DON_GIA_LCB * ObjCoefficientEmployeeFinalBLL.PCCV;
                _PCLog += "PCCV = DonGiaLCB:" + DON_GIA_LCB + " x HeSoPCCV:" + ObjCoefficientEmployeeFinalBLL.PCCV + ")=" + _ValuePCCV + "<br/>";

                _ValuePCTN = DON_GIA_LCB * ObjCoefficientEmployeeFinalBLL.PCTN;
                _PCLog += "PCTN = DonGiaLCB:" + DON_GIA_LCB + " x HeSoPCTN:" + ObjCoefficientEmployeeFinalBLL.PCTN + ")=" + _ValuePCTN + "<br/>";

                _ValuePCDH = (DON_GIA_LCB * ObjCoefficientEmployeeFinalBLL.PCDH * ObjWorkdayEmployeesBLLL.XL) / ObjWorkdayEmployeesBLLL.XQDL;
                _PCLog += "PCDH = (DonGiaLCB:" + DON_GIA_LCB + " x HeSoPCDH:" + ObjCoefficientEmployeeFinalBLL.PCTN + " x X:" + ObjWorkdayEmployeesBLLL.XL + ")/XQD:" + ObjWorkdayEmployeesBLLL.XQDL + ")=" + _ValuePCDH + "<br/>";
            }           

        }

        /// Tinh tro cap BHXH
        ///     ((DonGiaLCB * HeSoLCB)/XQD) * NC_OM * 0.75
        /// 
        public void CalculateTCBHXH()
        {
            if (ObjWorkdayEmployeesBLLL.F_OmL > 0 ||
                ObjWorkdayEmployeesBLLL.F_Con_OmL > 0 ||
                ObjWorkdayEmployeesBLLL.F_KHHDSL > 0 ||
                ObjWorkdayEmployeesBLLL.F_ThaiSanL > 0)
            {

                if (ObjCoefficientEmployeeFinalBLL != null)
                {                    
                    double tCBHXH_1_Ngay = (DON_GIA_LCB * ObjCoefficientEmployeeFinalBLL.LCB) / 26;
                    _TCBHXHLog += "TCBHXH_1_Ngay = (DonGiaLCB:" + DON_GIA_LCB + " x HeSoLCB:" + ObjCoefficientEmployeeFinalBLL.LCB + ")/26" + tCBHXH_1_Ngay + "<br/>";

                    if (ObjWorkdayEmployeesBLLL.F_OmL > 0)
                    {
                        if (ObjWorkdayEmployeesBLLL.F_OmL == ObjWorkdayEmployeesBLLL.XQDL)
                        {
                            _TCBHXHLog += "TCBHXHTemp = TCBHXHTemp :" + _ValueTCBHXH;
                            _ValueTCBHXH = _ValueTCBHXH + (DON_GIA_LCB * ObjCoefficientEmployeeFinalBLL.LCB * 0.75);
                            _TCBHXHLog += " + (DonGiaLCB:" + DON_GIA_LCB + " x HeSoLCB:" + ObjCoefficientEmployeeFinalBLL.LCB + " x 0.75)=" + _ValueTCBHXH + "<br/>";
                        }
                        else
                        {
                            _TCBHXHLog += "TCBHXHTemp = TCBHXHTemp :" + _ValueTCBHXH;
                            _ValueTCBHXH = _ValueTCBHXH + (tCBHXH_1_Ngay * ObjWorkdayEmployeesBLLL.F_OmL * 0.75);
                            _TCBHXHLog += " + (TCBHXH_1_Ngay:" + tCBHXH_1_Ngay + " x Ô:" + ObjWorkdayEmployeesBLLL.F_OmL + " x 0.75)=" + _ValueTCBHXH + "<br/>";
                        }
                    }
                    if (ObjWorkdayEmployeesBLLL.F_Con_OmL > 0)
                    {
                        if (ObjWorkdayEmployeesBLLL.F_Con_OmL == ObjWorkdayEmployeesBLLL.XQDL)
                        {
                            _TCBHXHLog += "TCBHXHTemp = TCBHXHTemp :" + _ValueTCBHXH;
                            _ValueTCBHXH = _ValueTCBHXH + (DON_GIA_LCB * ObjCoefficientEmployeeFinalBLL.LCB * 0.75);
                            _TCBHXHLog += " + (DonGiaLCB:" + DON_GIA_LCB + " x HeSoLCB:" + ObjCoefficientEmployeeFinalBLL.LCB + " x 0.75)=" + _ValueTCBHXH + "<br/>";
                        }
                        else
                        {
                            _TCBHXHLog += "TCBHXHTemp = TCBHXHTemp :" + _ValueTCBHXH;
                            _ValueTCBHXH = _ValueTCBHXH + (tCBHXH_1_Ngay * ObjWorkdayEmployeesBLLL.F_Con_OmL * 0.75);
                            _TCBHXHLog += " + (TCBHXH_1_Ngay:" + tCBHXH_1_Ngay + " x Co:" + ObjWorkdayEmployeesBLLL.F_Con_OmL + " x 0.75)=" + _ValueTCBHXH + "<br/>";
                        }
                    }
                    if (ObjWorkdayEmployeesBLLL.F_KHHDSL > 0)
                    {
                        if (ObjWorkdayEmployeesBLLL.F_KHHDSL == ObjWorkdayEmployeesBLLL.XQDL)
                        {
                            _TCBHXHLog += "TCBHXHTemp = TCBHXHTemp :" + _ValueTCBHXH;
                            _ValueTCBHXH = _ValueTCBHXH + (DON_GIA_LCB * ObjCoefficientEmployeeFinalBLL.LCB * 0.75);
                            _TCBHXHLog += " + (DonGiaLCB:" + DON_GIA_LCB + " x HeSoLCB:" + ObjCoefficientEmployeeFinalBLL.LCB + " x 0.75)=" + _ValueTCBHXH + "<br/>";
                        }
                        else
                        {
                            _TCBHXHLog += "TCBHXHTemp = TCBHXHTemp :" + _ValueTCBHXH;
                            _ValueTCBHXH = _ValueTCBHXH + (tCBHXH_1_Ngay * ObjWorkdayEmployeesBLLL.F_KHHDSL * 0.75);
                            _TCBHXHLog += " + (TCBHXH_1_Ngay:" + tCBHXH_1_Ngay + " x KHH:" + ObjWorkdayEmployeesBLLL.F_KHHDSL + " x 0.75)=" + _ValueTCBHXH + "<br/>";
                        }
                    }
                    if (ObjWorkdayEmployeesBLLL.F_ThaiSanL > 0)
                    {
                        if (ObjWorkdayEmployeesBLLL.F_ThaiSanL == ObjWorkdayEmployeesBLLL.XQDL)
                        {
                            _TCBHXHLog += "TCBHXHTemp = TCBHXHTemp :" + _ValueTCBHXH;
                            _ValueTCBHXH = _ValueTCBHXH + (DON_GIA_LCB * ObjCoefficientEmployeeFinalBLL.LCB);
                            _TCBHXHLog += " + (DonGiaLCB:" + DON_GIA_LCB + " x HeSoLCB:" + ObjCoefficientEmployeeFinalBLL.LCB + ")=" + _ValueTCBHXH + "<br/>";
                        }
                        else
                        {
                            _TCBHXHLog += "TCBHXHTemp = TCBHXHTemp :" + _ValueTCBHXH;
                            _ValueTCBHXH = _ValueTCBHXH + (tCBHXH_1_Ngay * ObjWorkdayEmployeesBLLL.F_ThaiSanL);
                            _TCBHXHLog += " + (TCBHXH_1_Ngay:" + tCBHXH_1_Ngay + " x TS:" + ObjWorkdayEmployeesBLLL.F_ThaiSanL + ")=" + _ValueTCBHXH + "<br/>";
                        }
                    }
                    if (ObjWorkdayEmployeesBLLL.F_SayThaiL > 0)
                    {
                        if (ObjWorkdayEmployeesBLLL.F_SayThaiL == ObjWorkdayEmployeesBLLL.XQDL)
                        {
                            _TCBHXHLog += "TCBHXHTemp = TCBHXHTemp :" + _ValueTCBHXH;
                            _ValueTCBHXH = _ValueTCBHXH + (DON_GIA_LCB * ObjCoefficientEmployeeFinalBLL.LCB);
                            _TCBHXHLog += " + (DonGiaLCB:" + DON_GIA_LCB + " x HeSoLCB:" + ObjCoefficientEmployeeFinalBLL.LCB + " =" + _ValueTCBHXH + "<br/>";
                        }
                        else
                        {
                            _TCBHXHLog += "TCBHXHTemp = TCBHXHTemp :" + _ValueTCBHXH;
                            _ValueTCBHXH = _ValueTCBHXH + (tCBHXH_1_Ngay * ObjWorkdayEmployeesBLLL.F_SayThaiL);
                            _TCBHXHLog += " + (TCBHXH_1_Ngay:" + tCBHXH_1_Ngay + " x ST:" + ObjWorkdayEmployeesBLLL.F_SayThaiL + ")=" + _ValueTCBHXH + "<br/>";
                        }
                    }
                    if (ObjWorkdayEmployeesBLLL.F_KhamThaiL > 0)
                    {
                        if (ObjWorkdayEmployeesBLLL.F_KhamThaiL == ObjWorkdayEmployeesBLLL.XQDL)
                        {
                            _TCBHXHLog += "TCBHXHTemp = TCBHXHTemp :" + _ValueTCBHXH;
                            _ValueTCBHXH = _ValueTCBHXH + (DON_GIA_LCB * ObjCoefficientEmployeeFinalBLL.LCB);
                            _TCBHXHLog += " + (DonGiaLCB:" + DON_GIA_LCB + " x HeSoLCB:" + ObjCoefficientEmployeeFinalBLL.LCB + " =" + _ValueTCBHXH + "<br/>";
                        }
                        else
                        {
                            _TCBHXHLog += "TCBHXHTemp = TCBHXHTemp :" + _ValueTCBHXH;
                            _ValueTCBHXH = _ValueTCBHXH + (tCBHXH_1_Ngay * ObjWorkdayEmployeesBLLL.F_KhamThaiL);
                            _TCBHXHLog += " + (TCBHXH_1_Ngay:" + tCBHXH_1_Ngay + " x KT:" + ObjWorkdayEmployeesBLLL.F_KhamThaiL + ")=" + _ValueTCBHXH + "<br/>";
                        }
                    }
                    if (ObjWorkdayEmployeesBLLL.F_ConChetL > 0)
                    {
                        if (ObjWorkdayEmployeesBLLL.F_ConChetL == ObjWorkdayEmployeesBLLL.XQDL)
                        {
                            _TCBHXHLog += "TCBHXHTemp = TCBHXHTemp :" + _ValueTCBHXH;
                            _ValueTCBHXH = _ValueTCBHXH + (DON_GIA_LCB * ObjCoefficientEmployeeFinalBLL.LCB);
                            _TCBHXHLog += " + (DonGiaLCB:" + DON_GIA_LCB + " x HeSoLCB:" + ObjCoefficientEmployeeFinalBLL.LCB + " =" + _ValueTCBHXH + "<br/>";
                        }
                        else
                        {
                            _TCBHXHLog += "TCBHXHTemp = TCBHXHTemp :" + _ValueTCBHXH;
                            _ValueTCBHXH = _ValueTCBHXH + (tCBHXH_1_Ngay * ObjWorkdayEmployeesBLLL.F_ConChetL);
                            _TCBHXHLog += " + (TCBHXH_1_Ngay:" + tCBHXH_1_Ngay + " x CC:" + ObjWorkdayEmployeesBLLL.F_ConChetL + ")=" + _ValueTCBHXH + "<br/>";
                        }
                    }

                    _ValueTCOm = _ValueTCBHXH;
                    _TCBHXHLog += "TroCapOm = TCBHXHTemp = " + _ValueTCBHXH + "<br/>";

                }
            }

            PregnantAllownceBLL objpa = PregnantAllownceBLL.GetByUserAllownceDate(ObjWorkdayEmployeesBLLL.UserId, ObjWorkdayEmployeesBLLL.WorkdayDateL);
            if (objpa != null)
            {
                _ValueTCTS1Lan = objpa.AllownceValue;
                _TCBHXHLog += "TroCapThaiSan1Lan = " + _ValueTCTS1Lan + "<br/>";
                _ValueTCBHXH = 0;
                _ValueTCBHXH = _ValueTCOm + _ValueTCTS1Lan;                
                _TCBHXHLog += "TroCapBHXH = TroCapOm:" + _ValueTCOm + " + TroCapThaiSan1Lan:" + _ValueTCTS1Lan + " = " + _ValueTCBHXH + "<br/>";
            }
            else
            {
                _ValueTCTS1Lan = 0;
                _TCBHXHLog += "TroCapThaiSan1Lan = 0 <br/>";
                _ValueTCBHXH = _ValueTCOm;
                _TCBHXHLog += "TroCapBHXH = TroCapOm:" + _ValueTCOm + "<br/>";

            }

        }//end method
    }
}
