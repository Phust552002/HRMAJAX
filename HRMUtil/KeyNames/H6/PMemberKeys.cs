using System;
using System.Collections.Generic;
using System.Text;

namespace HRMUtil.KeyNames.H6
{
    sealed public class PMemberKeys
    {
        public static string FIELD_PMEMBER_DATE_JOIN_P = "DateJoinP";
        public static string FIELD_PMEMBER_DATE_JOIN_P_OFFICIAL = "DateJoinPOfficial";
        public static string FIELD_PMEMBER_PLACE_JOIN_P = "PlaceJoinP";
        public static string FIELD_PMEMBER_CARD_NO = "PCardNo";
        public static string FIELD_PMEMBER_REMARKS = "PMemberRemarks";
        public static string FIELD_PMEMBER_STATUS = "PMemberStatus";
        public const string FIELD_PMEMBER_PMEMBERID = "PMemberId";
        public const string FIELD_PMEMBER_REFERENCE = "Reference";
        // phieu bo sung ho so dang vien
        public const string FIELD_PMEMBER_CHUCVUDANG = "ChucVuDang";
        public const string FIELD_PMEMBER_CHUCVUCQ = "ChucVuCQ";
        public const string FIELD_PMEMBER_CHUCVUDT = "ChucVuDT";
        public const string FIELD_PMEMBER_CHUCVUDN = "ChucVuDN";
        public const string FIELD_PMEMBER_TRINHDOTHPT = "TrinhDoTHPT";
        public const string FIELD_PMEMBER_CHUYENMONNV = "ChuyenMonNV";
        public const string FIELD_PMEMBER_HOCHAM = "HocHam";
        public const string FIELD_PMEMBER_HOCVI = "HocVi";
        public const string FIELD_PMEMBER_LYLUANCHINHTRI = "LyLuanChinhTri";
        public const string FIELD_PMEMBER_NGOAINGU = "NgoaiNgu";
        public const string FIELD_PMEMBER_KHENTHUONG = "KhenThuong";
        public const string FIELD_PMEMBER_KYLUAT = "KyLuat";
        public const string FIELD_PMEMBER_CHADE = "ChaDe";
        public const string FIELD_PMEMBER_MEDE = "MeDe";
        public const string FIELD_PMEMBER_CHAVC = "ChaVc";
        public const string FIELD_PMEMBER_MEVC = "MeVc";
        public const string FIELD_PMEMBER_VOCHONG = "VoChong";
        public const string FIELD_PMEMBER_CON = "Con";
        public const string FIELD_PMEMBER_VOCHONGNUOCNGOAICUACON = "VoChongNuocNgoaiCuaCon";
        public const string FIELD_PMEMBER_VCCONDINUOCNGOAI = "VCConDiNuocNgoai";
        public const string FIELD_PMEMBER_TONGTHUNHAPHGD = "TongThuNhapHGD";
        public const string FIELD_PMEMBER_BINHQUANNGUOI = "BinhQuanNguoi";
        public const string FIELD_PMEMBER_NHAO = "NhaO";
        public const string FIELD_PMEMBER_DATO = "DatO";
        public const string FIELD_PMEMBER_HOATDONGKINHTE = "HoatDongKinhTe";
        public const string FIELD_PMEMBER_TAISANMOI = "TaiSanMoi";
        public const string FIELD_PMEMBER_GIATRI = "GiaTri";
        public const string FIELD_PMEMBER_MIENCONGTACSHD = "MienCongTacSHD";
        public const string FIELD_PMEMBER_CLDANGVIEN = "CLDangVien";
        public const string FIELD_PMEMBER_NGHENGHIEPHIENNAY = "NgheNghiepHienNay";

        public const string FIELD_PMEMBER_NOICAPTHE = "NoiCapThe";
        public const string FIELD_PMEMBER_NGAYCAPTHE = "NgayCapThe";

        // procedure
        public static string Sp_Sel_H6_PMember_By_DeptIds = "Sel_H6_PMember_By_DeptIds";
        public static string Sp_Sel_H6_Employees_ToImport = "Sel_H6_Employees_ToImport";
        public static string Sp_Ins_H6_PMember = "Ins_H6_PMember";
        public static string Sp_Upd_H6_PMember = "Upd_H6_PMember";
        public static string Sp_Sel_H6_PMember_By_UserId = "Sel_H6_PMember_By_UserId";


        public static string Sp_Sel_H6_DocTypes_By_RecordType = "Sel_H6_DocTypes_By_RecordType";
        public static string Sp_Ins_H6_PMember_Docs = "Ins_H6_PMember_Docs";
        public static string Sp_Sel_H6_DocList_By_UserId = "Sel_H6_DocList_By_UserId";
        public static string Sp_Sel_H6_Doc_By_DocId = "Sel_H6_Doc_By_DocId";
        public static string Sp_Del_H6_PMember_Doc = "Del_H6_PMember_Doc";

        public const string Sp_Upd_H6_PMember_Infor_Detail = "Upd_H6_PMember_InforDetail";
        public const string Sp_Upd_H6_PMember_Infor_General = "Upd_H6_PMember_InforGeneral";

        public const string Sp_Upd_H6_PMember_Infor_Bonus = "Upd_H6_PMember_InforBonus";

        public static string Sp_Sel_H6_Quality_Year = "Sel_H6_Quality_Year";

        public static string Sp_Sel_H6_PMember_Quality_By_Year = "Sel_H6_PMember_Quality_By_Year";
        public static string Sp_Sel_H6_PMember_Leave_By_DeptIds = "Sel_H6_PMember_Leave_By_DeptIds";
    }
}
