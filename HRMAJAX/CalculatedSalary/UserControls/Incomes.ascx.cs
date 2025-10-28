using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using HRMBLL.H1;
using HRMUtil;

public partial class CalculatedSalary_UserControls_Incomes : System.Web.UI.UserControl
{

    private int _Month;
    private int _Year;
    private int _UserId;

    private List<IncomesBLL> _DataSource;

    public event EventHandler IncomesLoad;

    void OnIncomesLoad(EventArgs e)
    {
        if (IncomesLoad != null)
        {
            IncomesLoad(this, e);
        }
    }   

    public List<IncomesBLL> DataSource
    {
        get { return _DataSource; }
        set { _DataSource = value; }
    }

    public void BindDataToGridView()
    {

        DataList1.DataSource = DataSource;
        DataList1.DataBind();

        DataList2.DataSource = DataSource;
        DataList2.DataBind();

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        OnIncomesLoad(e);
    }
   
    
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        DataListItem row = e.Item;
        
        if (row.ItemType == ListItemType.Item || row.ItemType == ListItemType.AlternatingItem)
        {
            IncomesBLL obj = (IncomesBLL)row.DataItem;

            Label lbLNS = (Label)row.FindControl("lbLNS");
            lbLNS.Text = obj.LNS <= 0 ? string.Empty : obj.LNS.ToString(StringFormat.FormatCurrency);

            Label lbLCBNN = (Label)row.FindControl("lbLCBNN");
            lbLCBNN.Text = obj.LCBNN <= 0 ? string.Empty : obj.LCBNN.ToString(StringFormat.FormatCurrency);

            Label lbPCCV = (Label)row.FindControl("lbPCCV");
            lbPCCV.Text = obj.PCCV <= 0 ? string.Empty : obj.PCCV.ToString(StringFormat.FormatCurrency);

            Label lbPCTN = (Label)row.FindControl("lbPCTN");
            lbPCTN.Text = obj.PCTN <= 0 ? string.Empty : obj.PCTN.ToString(StringFormat.FormatCurrency);

            Label lbPCDH = (Label)row.FindControl("lbPCDH");
            lbPCDH.Text = obj.PCDH <= 0 ? string.Empty : obj.PCDH.ToString(StringFormat.FormatCurrency);

            Label lbTCBHXH = (Label)row.FindControl("lbTCBHXH");
            lbTCBHXH.Text = obj.TCBHXH <= 0 ? string.Empty : obj.TCBHXH.ToString(StringFormat.FormatCurrency);

            Label lbBoSungLuong = (Label)row.FindControl("lbBoSungLuong");
            lbBoSungLuong.Text = obj.BoSungLuong <= 0 ? string.Empty : obj.BoSungLuong.ToString(StringFormat.FormatCurrency);

            Label lbTienAn = (Label)row.FindControl("lbTienAn");
            lbTienAn.Text = obj.TienAn <= 0 ? string.Empty : obj.TienAn.ToString(StringFormat.FormatCurrency);

            //Label lbTienThuong = (Label)row.FindControl("lbTienThuong");
            //lbTienThuong.Text = obj.TienThuong <= 0 ? string.Empty : obj.TienThuong.ToString(StringFormat.FormatCurrency);

            Label lbTienLamDem = (Label)row.FindControl("lbTienLamDem");
            lbTienLamDem.Text = obj.TienLamDem <= 0 ? string.Empty : obj.TienLamDem.ToString(StringFormat.FormatCurrency);

            Label lbTienThemGio = (Label)row.FindControl("lbTienThemGio");
            lbTienThemGio.Text = obj.TienThemGio <= 0 ? string.Empty : obj.TienThemGio.ToString(StringFormat.FormatCurrency);

        }
    }
    protected void DataList2_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        DataListItem row = e.Item;
        if (row.ItemType == ListItemType.Item || row.ItemType == ListItemType.AlternatingItem)
        {
            IncomesBLL obj = (IncomesBLL)row.DataItem;

            Label lbTrBHYT = (Label)row.FindControl("lbTrBHYT");
            lbTrBHYT.Text = obj.TrBHYT <= 0 ? string.Empty : obj.TrBHYT.ToString(StringFormat.FormatCurrency);

            Label lbTrBHXH = (Label)row.FindControl("lbTrBHXH");
            lbTrBHXH.Text = obj.TrBHXH <= 0 ? string.Empty : obj.TrBHXH.ToString(StringFormat.FormatCurrency);

            Label lbTrDoanPhi = (Label)row.FindControl("lbTrDoanPhi");
            lbTrDoanPhi.Text = obj.TrDoanPhi <= 0 ? string.Empty : obj.TrDoanPhi.ToString(StringFormat.FormatCurrency);

            Label lbTrBHTN = (Label)row.FindControl("lbTrBHTN");
            lbTrBHTN.Text = obj.TrBHTN <= 0 ? string.Empty : obj.TrBHTN.ToString(StringFormat.FormatCurrency);
            

            Label lbThueThuNhap = (Label)row.FindControl("lbThueThuNhap");
            lbThueThuNhap.Text = obj.ThueThuNhap <= 0 ? string.Empty : obj.ThueThuNhap.ToString(StringFormat.FormatCurrency);

        }
    }
}
