using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Employee_StockReport : System.Web.UI.Page
{
    int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            UcTitle1.Text = "BÁO CÁO CHI TIẾT VÊ VIỆC NỘP TIỀN MUA CỔ PHẦN ƯU ĐÃI CHO CB-CNV";

         //   DisplayPersonalInformation();
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            row.Cells[0].HorizontalAlign = HorizontalAlign.Center;
            row.Cells[1].HorizontalAlign = HorizontalAlign.Left;
        }
        if (row.RowType == DataControlRowType.DataRow)
        {
            i++;
            row.Cells[0].Text = i.ToString();
            row.Cells[0].HorizontalAlign = HorizontalAlign.Center;
            row.Cells[1].HorizontalAlign = HorizontalAlign.Left;
            if (i == 10)
            {
                row.CssClass = "grid-footer";
            }
        }
    }
}