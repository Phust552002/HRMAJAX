using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShareHolder_BQDLReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            UcTitle1.Text = "KẾT QUẢ BIỂU QUYẾT THÔNG QUA ĐIỀU LỆ TỔ CHỨC VÀ HOẠT ĐỘNG CỦA CÔNG TY CỔ PHẦN PVMĐ SÀI GÒN";

            //   DisplayPersonalInformation();
            GridView1.DataBind();
        }
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;

        if (row.RowType == DataControlRowType.DataRow)
        {
            try
            {
                double result2 = double.Parse(row.Cells[2].Text.Trim().Length <= 0 ? "0" : row.Cells[2].Text.Trim());
                row.Cells[2].Text = result2.ToString("#,###0.000") + "%";
            }
            catch { row.Cells[2].Text = "0%"; }

            //try
            //{
            //    double result3 = double.Parse(row.Cells[3].Text.Trim().Length <= 0 ? "0" : row.Cells[3].Text.Trim());
            //    row.Cells[3].Text = result3.ToString("##0.000") + "%";
            //}
            //catch { row.Cells[3].Text = "0%"; }
        }

    }
    protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            if (row.RowIndex == 5)
            {
                try
                {
                    double result = double.Parse(row.Cells[2].Text.Trim().Length <= 0 ? "0" : row.Cells[2].Text.Trim());
                    row.Cells[2].Text = result.ToString("##0.000");
                }
                catch { row.Cells[2].Text = "0"; }
            }
            else
            {
                try
                {
                    double result = double.Parse(row.Cells[2].Text.Trim().Length <= 0 ? "0" : row.Cells[2].Text.Trim());
                    row.Cells[2].Text = result.ToString("#,###0");
                }
                catch { row.Cells[2].Text = "0"; }
            }
        }
    }
}