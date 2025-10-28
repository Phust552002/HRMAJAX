using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using HRMBLL.H1.Helper;
using HRMBLL.H0;
using HRMUtil;

namespace HRMBLL.H1.CalulateSalary
{
    public class ContributionsBLL
    {

        #region private fields

        private WorkdayEmployeesBLLL _ObjWorkdayEmployeesBLLL;
        private CoefficientEmployeeFinalBLL _ObjCoefficientEmployeeFinalBLL;        
        private List<EmployeeContractBLL> _ListEmployeeContractBLLCheck;
       
        private double _ValueKPCD;
        private double _ValueBHYT;
        private double _ValueBHXH;
        private double _ValueBHTN;
        private double _ValueBoSungLuong;

        private double _ValueLNS;
        private double _ValueLCB;
        private double _ValuePCDH;
        private double _ValuePCTN;
        private double _ValuePCCV;
        
        private double _DON_GIA_LCB;

        private string _Contributions_Log;      

        #endregion

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
        public List<EmployeeContractBLL> ListEmployeeContractBLLCheck
        {
            get { return _ListEmployeeContractBLLCheck; }
            set { _ListEmployeeContractBLLCheck = value; }
        }

        public double ValueKPCD
        {
            get { return _ValueKPCD; }
            set { _ValueKPCD = value; }
        }
        public double ValueBHYT
        {
            get { return _ValueBHYT; }
            set { _ValueBHYT = value; }
        }
        public double ValueBHTN
        {
            get { return _ValueBHTN; }
            set { _ValueBHTN = value; }
        }
        public double ValueBHXH
        {
            get { return _ValueBHXH; }
            set { _ValueBHXH = value; }
        }

        public double ValueBoSungLuong
        {
            get { return _ValueBoSungLuong; }
            set { _ValueBoSungLuong = value; }
        }

        /// <summary>
        /// Don gia luong can ban
        /// </summary>
        public double DON_GIA_LCB
        {
            get { return _DON_GIA_LCB; }
            set { _DON_GIA_LCB = value; }
        }

        public double ValueLNS
        {
            get { return _ValueLNS; }
            set { _ValueLNS = value; }
        }
        public double ValueLCB
        {
            get { return _ValueLCB; }
            set { _ValueLCB = value; }
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

        public string Contributions_Log
        {
            get { return _Contributions_Log; }
            set { _Contributions_Log = value; }
        }

        #endregion

        /// <summary>
        /// Tinh khoan trich BHXH.
        /// **********************************************************************************
        /// CONG THUC CU:  
        /// (HeSoPCCV + HeSoPCDH + HeSoLCB) * DonGiaLCB * 0.05(dong 5%)
        /// *****************
        /// CONG THUC MOI ngay 24/06/2008                
        /// if(TS, ODN>=NCQD)thi TrBHXH = 0
        /// else if(O,Co,KHDS >=14 )thi TrBHXH = 0
        /// else IF X> 0 thi TrBHXH = (HeSoPCCV + HesoPCKV+ HeSoLCB) * DonGiaLCB * 0.05(dong 5%)    
        /// CONG THUC bosung ngay 27/10/2008                
        /// Hop dong thu viec khong trich cac khoan : BHXH, BHYT
        /// **********************************************************************************
        /// Tinh khoan trich BHYT.
        /// CONG THUC CU: (HeSoPCCV + HeSoPCDH + HeSoLCB) * DonGiaLCB * 0.01(dong 1%)    
        /// ****************
        /// CONG THUC MOI ngay 24/06/2008      
        /// if(TS, ODN>=NCQD)thi TrBHYT = 0        
        /// else IF X> 0 thi TrBHYT = (HeSoPCCV + HesoPCKV+ HeSoLCB) * DonGiaLCB * 0.01(dong 1%)    
        /// **********************************************************************************
        /// Tinh Bo sung luong
        /// CONG THUC CU : BosungLuong = TrBHXH + TrBHYT
        /// *******************
        /// CONG THUC MOI
        /// Neu Ro, Ko, DC thi bo sung luong =0 
        ///**********************************************************************************
        /// Tinh khoan trich Kinh Phi cong doan.
        ///     
        ///     Neu ((Luong NS + LCB + PCCV +PCTN +PCDH) * 0.01) > 54000 thi dong 54000
        ///     Nguoc lai thi dong ((Luong NS + LCB + PCCV +PCTN +PCDH) * 0.01)
        /// 
       
        /// Tinh tien bo sung luong
        /// tien bo sung luong = trich nop BHXH + BHYT (tuy theo loai hop dong va nghi om dai ngay)
        ///
        /// </summary>
        /// <returns></returns>
        public void Calculate()
        {
            if (ListEmployeeContractBLLCheck.Count > 1)
            {
                if (ListEmployeeContractBLLCheck[1].FromDate.Day <= 15 || CheckIsContractHaveBHXH_BHYT(ListEmployeeContractBLLCheck[0]))
                {
                    CalculateByCondition();
                }
                else
                {
                    Contributions_Log += "Hop dong: " + ListEmployeeContractBLLCheck[0].ContractTypeName + " chuyen sang hop dong: " + ListEmployeeContractBLLCheck[1].ContractTypeName;
                    Contributions_Log += "Ngay chuyen hop dong la : " + ListEmployeeContractBLLCheck[1].FromDate +" >15 nen : <br/>";
                    _ValueBHXH = 0;
                    _ValueBHYT = 0;
                    _ValueBoSungLuong = 0;
                    Contributions_Log += "ValueBHXH=0 <br/>";
                    Contributions_Log += "ValueBHYT=0 <br/>";
                    Contributions_Log += "ValueBoSungLuong=0 <br/>";
                    CalculateDPCD();
                }

            }
            else if(ListEmployeeContractBLLCheck.Count == 1)
            {
                if (CheckIsContractHaveBHXH_BHYT(ListEmployeeContractBLLCheck[0]))
                {
                    Contributions_Log += "Hop dong thu viec nen : <br/>";
                    _ValueBHXH = 0;
                    _ValueBHYT = 0;
                    _ValueBoSungLuong = 0;
                    Contributions_Log += "ValueBHXH=0 <br/>";
                    Contributions_Log += "ValueBHYT=0 <br/>";
                    Contributions_Log += "ValueBoSungLuong=0 <br/>";
                    CalculateDPCD();
                }
                else
                {
                    CalculateByCondition();
                }
            }

        }

        private void CalculateByCondition()
        {
            if (ObjWorkdayEmployeesBLLL.F_ThaiSanL >= ObjWorkdayEmployeesBLLL.XQDL || ObjWorkdayEmployeesBLLL.F_OmDaiNgayL >= ObjWorkdayEmployeesBLLL.XQDL)
            {
                Contributions_Log += "TS:" + ObjWorkdayEmployeesBLLL.F_ThaiSanL + " OR ODN:" + ObjWorkdayEmployeesBLLL.F_OmDaiNgayL;
                _ValueBHXH = 0;
                _ValueBHYT = 0;
                _ValueBHTN = 0;
                _ValueBoSungLuong = 0;
                Contributions_Log += "ValueBHXH=0 <br/>";
                Contributions_Log += "ValueBHYT=0 <br/>";
                Contributions_Log += "ValueBHTN=0 <br/>";
                Contributions_Log += "ValueBoSungLuong=0 <br/>";
            }
            else if (ObjWorkdayEmployeesBLLL.F_OmL >= 14 || ObjWorkdayEmployeesBLLL.F_Con_OmL >= 14 || ObjWorkdayEmployeesBLLL.F_KHHDSL >= 14)
            {
                double pccv = 0;
                double pckv = 0;
                double lcb = 0;
                _ValueBHXH = 0;
                if (ObjCoefficientEmployeeFinalBLL != null)
                {
                    pccv = ObjCoefficientEmployeeFinalBLL.PCCV;
                    pckv = ObjCoefficientEmployeeFinalBLL.PCKV;
                    lcb = ObjCoefficientEmployeeFinalBLL.LCB;
                    _ValueBHYT = (pccv + pckv + lcb) * DON_GIA_LCB * 0.01;
                    _ValueBHTN = (pccv + pckv + lcb) * DON_GIA_LCB * 0.01;
                    Contributions_Log += "ValueBHYT=(PCCV:" + pccv + "+PCKV:" + pckv + "+lcb) * DonGiaLCB:" + DON_GIA_LCB + " 0.01 <br/>";
                    Contributions_Log += "ValueBHTN=(PCCV:" + pccv + "+PCKV:" + pckv + "+lcb) * DonGiaLCB:" + DON_GIA_LCB + " 0.01 <br/>";
                    if (ObjWorkdayEmployeesBLLL.F_KoLuongCLDL >= ObjWorkdayEmployeesBLLL.XQDL || ObjWorkdayEmployeesBLLL.F_KoLuongKLDL >= ObjWorkdayEmployeesBLLL.XQDL
                        || ObjWorkdayEmployeesBLLL.F_DinhChiCongTacL >= ObjWorkdayEmployeesBLLL.XQDL)
                    {
                        _ValueBoSungLuong = 0;
                        Contributions_Log += "Ro:" + ObjWorkdayEmployeesBLLL.F_KoLuongCLDL + " >= XQD:" + ObjWorkdayEmployeesBLLL.XQDL + "<br/>";
                        Contributions_Log += " hoac Ko:" + ObjWorkdayEmployeesBLLL.F_KoLuongKLDL + " >= XQD:" + ObjWorkdayEmployeesBLLL.XQDL + "<br/>";
                        Contributions_Log += " hoac DC:" + ObjWorkdayEmployeesBLLL.F_DinhChiCongTacL + " >= XQD:" + ObjWorkdayEmployeesBLLL.XQDL + "<br/>";

                        Contributions_Log += " BoSungLuong = 0 <br/>";
                    }
                    else
                    {
                        _ValueBoSungLuong = _ValueBHXH + _ValueBHYT + _ValueBHTN;
                        Contributions_Log += " TienBoSungLuong = TienBHXH:" + _ValueBHXH + "+TienBHYT:" + _ValueBHYT + "+TienBHTN:" + _ValueBHTN + "=" + _ValueBoSungLuong + "<br/>";
                    }
                }
            }
            else
            {
                CalculateByLCBCoefficient();
            }
            CalculateDPCD();
            
        }

        private void CalculateDPCD()
        {
            Contributions_Log += "/******************** Tính tien dinh phi cong doan **************************************/<br/>";

            double totalKPCongDoan = ValueLCB + ValueLNS + ValuePCDH + ValuePCTN + ValuePCCV;

            Contributions_Log += "TongTienChiuKPCD= TienLCB:" + ValueLCB + "+TienLNS:" + ValueLNS + "+TienPCDH:" + ValuePCDH + "+TienPCTN:" + ValuePCTN + "+TienPCCV:" + ValuePCCV + "=" + totalKPCongDoan + "<br/>"; ;

            double kpcd = totalKPCongDoan * 0.01;
            Contributions_Log += "kpcd:" + totalKPCongDoan + " * 0.01 <br/>";
            if (kpcd > Constants.MAX_KPCD)
            {
                Contributions_Log += "kpcd:" + totalKPCongDoan + " > " + Constants.MAX_KPCD;
                _ValueKPCD = Constants.MAX_KPCD;
                Contributions_Log += "TienKPCD=" + Constants.MAX_KPCD + "<br/>"; ;
            }
            else
            {
                Contributions_Log += "TienKPCD:" + kpcd + "<br/>"; ;
                _ValueKPCD = kpcd;
            }
        }

        private void CalculateByLCBCoefficient()
        {
            double pccv = 0;
            double pckv = 0;
            double lcb = 0;
            if (ObjCoefficientEmployeeFinalBLL != null)
            {
                pccv = ObjCoefficientEmployeeFinalBLL.PCCV;
                pckv = ObjCoefficientEmployeeFinalBLL.PCKV;
                lcb = ObjCoefficientEmployeeFinalBLL.LCB;
                _ValueBHXH = (pccv + pckv + lcb) * DON_GIA_LCB * 0.05;
                Contributions_Log += "ValueBHXH=(PCCV:" + pccv + "+PCKV:" + pckv + "+lcb) * DonGiaLCB:" + DON_GIA_LCB + " 0.05 <br/>";
                _ValueBHYT = (pccv + pckv + lcb) * DON_GIA_LCB * 0.01;
                Contributions_Log += "ValueBHYT=(PCCV:" + pccv + "+PCKV:" + pckv + "+lcb) * DonGiaLCB:" + DON_GIA_LCB + " 0.01 <br/>";
                _ValueBHTN = (pccv + pckv + lcb) * DON_GIA_LCB * 0.01;
                Contributions_Log += "ValueBHTN=(PCCV:" + pccv + "+PCKV:" + pckv + "+lcb) * DonGiaLCB:" + DON_GIA_LCB + " 0.01 <br/>";
            }

            if (ObjWorkdayEmployeesBLLL.F_KoLuongCLDL >= ObjWorkdayEmployeesBLLL.XQDL || ObjWorkdayEmployeesBLLL.F_KoLuongKLDL >= ObjWorkdayEmployeesBLLL.XQDL
                || ObjWorkdayEmployeesBLLL.F_DinhChiCongTacL >= ObjWorkdayEmployeesBLLL.XQDL)
            {
                _ValueBoSungLuong = 0;
                Contributions_Log += "Ro:" + ObjWorkdayEmployeesBLLL.F_KoLuongCLDL + " >= XQD:" + ObjWorkdayEmployeesBLLL.XQDL + "<br/>";
                Contributions_Log += " hoac Ko:" + ObjWorkdayEmployeesBLLL.F_KoLuongKLDL + " >= XQD:" + ObjWorkdayEmployeesBLLL.XQDL + "<br/>";
                Contributions_Log += " hoac DC:" + ObjWorkdayEmployeesBLLL.F_DinhChiCongTacL + " >= XQD:" + ObjWorkdayEmployeesBLLL.XQDL + "<br/>";

                Contributions_Log += " BoSungLuong = 0 <br/>";
            }
            else
            {
                _ValueBoSungLuong = _ValueBHXH + _ValueBHYT + _ValueBHTN;
                Contributions_Log += " TienBoSungLuong = TienBHXH:" + _ValueBHXH + "+TienBHYT:" + _ValueBHYT + "+TienBHTN:" + _ValueBHTN + "=" + _ValueBoSungLuong + "<br/>"; 
            }
        }

        private bool CheckIsContractHaveBHXH_BHYT(EmployeeContractBLL objEC)
        {
            if (objEC.ContractTypeId == Constants.HopDong_HocNghe ||
                objEC.ContractTypeId == Constants.HopDong_ThoiVu_3T ||
                objEC.ContractTypeId == Constants.HopDong_ThoiVu_6T ||
                objEC.ContractTypeId == Constants.HopDong_ThuViec_DaiHoc ||
                objEC.ContractTypeId == Constants.HopDong_ThuViec_Khac)
            {
                return true;
            }
            else            
            {
                return false;
            }
        }
    }
}
