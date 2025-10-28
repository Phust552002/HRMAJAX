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
using System.Text;

using HRMBLL.H4;
using HRMUtil.KeyNames.H4;
using HRMUtil;
using HRMBLL.H1;

public partial class ShareHolder_RepresentativeCheck : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            UcTitle1.Text = "KIỂM TRA TƯ CÁCH ĐẠI BIỂU";
            grdShareHolder.DataBind();
        }
    }
    protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {

        e.InputParameters["InvestorNo"] = 0;
        e.InputParameters["FullName"] = StringFormat.TrimFullName(txtFullName.Text);
        e.InputParameters["IsOk"] = 10;
        e.InputParameters["KTTCDB"] = 0;
    }
    protected void grdShareHolder_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            DataRowView rv = (DataRowView)e.Row.DataItem;
            HyperLink lnk = (HyperLink)e.Row.FindControl("lnkFullName");
            Label lbIsOk = (Label)e.Row.FindControl("lbIsOk");
            
            try
            {
            lnk.Text = rv[RepresentativeKeys.Field_Representative_RepresentativeName].ToString();
            lnk.ToolTip = rv[RepresentativeKeys.Field_Representative_InvestorNo].ToString();
            }
            catch { }
            int IsOk = Convert.ToInt32(rv["IsOk"]);

            if (IsOk == 0)
            {
                lbIsOk.Text = "Không";
                lbIsOk.Font.Bold = true;
                lbIsOk.ForeColor = System.Drawing.Color.Red;
            }
            else if (IsOk == 1)
            {
                lbIsOk.Text = "Tham dự";
                lbIsOk.Font.Bold = true;
                lbIsOk.ForeColor = System.Drawing.Color.Green;
                lnk.Font.Bold = true;
                //lbConfirm.ForeColor = System.Drawing.Color.White;
                //row.BackColor = System.Drawing.Color.FromArgb(175, 232, 190);
            }
            else if (IsOk == 2)
            {
                lbIsOk.Text = "Ủy quyền";
                lbIsOk.Font.Bold = false;
                lnk.Font.Bold = false;
            }
        }
    }
    protected void grdShareHolder_Ok_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            DataRowView rv = (DataRowView)e.Row.DataItem;
            HyperLink lnk = (HyperLink)e.Row.FindControl("lnkFullNameOk");
            Label lbIsOk = (Label)e.Row.FindControl("lbIsOk");
            try
            {
                lnk.Text = rv[RepresentativeKeys.Field_Representative_RepresentativeName].ToString();
            }
            catch { }

            int IsOk = Convert.ToInt32(rv["IsOk"]);

            if (IsOk == 0)
            {
                lbIsOk.Text = "Không";
                lbIsOk.Font.Bold = true;
                lbIsOk.ForeColor = System.Drawing.Color.Red;
            }
            else if (IsOk == 1)
            {
                lbIsOk.Text = "Tham dự";
                lbIsOk.Font.Bold = true;
                lbIsOk.ForeColor = System.Drawing.Color.Green;
                lnk.Font.Bold = true;
                //lbConfirm.ForeColor = System.Drawing.Color.White;
                //row.BackColor = System.Drawing.Color.FromArgb(175, 232, 190);
            }
            else if (IsOk == 2)
            {
                lbIsOk.Text = "Ủy quyền";
                lbIsOk.Font.Bold = false;
                lnk.Font.Bold = false;
            }
        }
    }
    protected void btnCheck_Click(object sender, EventArgs e)
    {
        try
        {

            foreach (GridViewRow row in grdShareHolder.Rows)
            {
                CheckBox chkSelect = (CheckBox)row.FindControl("chkSelect");
                if (chkSelect.Checked)
                {
                    HyperLink lnk = (HyperLink)row.FindControl("lnkFullName");
                    RepresentativeBLL.UpdateForKTTCDB(int.Parse(lnk.ToolTip.Trim()), 1);                    
                }
            }

            ////if (checkData())
            ////{
            ////    int investorNo = int.Parse(txtFullName.Text.Trim());
            ////    RepresentativeBLL.UpdateForKTTCDB(investorNo, 1);
            ////    grdShareHolder.DataBind();
            ////    grdShareHolder_Ok.DataBind();
            ////    ////int investorNoTemp = 0;
            ////    ////int attorneyCodeTemp = 0;
            ////    ////DataTable dt = RepresentativeBLL.GetByAttorneyCode(investorNo);
            ////    ////for (int i = 0; i < dt.Rows.Count; i++)
            ////    ////{
            ////    ////    investorNoTemp = Convert.ToInt32(dt.Rows[i][RepresentativeKeys.Field_Representative_InvestorNo]);
            ////    ////    attorneyCodeTemp = Convert.ToInt32(dt.Rows[i][RepresentativeKeys.Field_Representative_AttorneyCode]);
            ////    ////    RepresentativeBLL.UpdateForCheck(investorNo, 1);
            ////    ////    //if (investorNoTemp == attorneyCodeTemp)
            ////    ////    //{
            ////    ////    //    RepresentativeBLL.UpdateForCheck(investorNo, 1);
            ////    ////    //}
            ////    ////    //else
            ////    ////    //{
            ////    ////    //    RepresentativeBLL.UpdateForCheck(investorNo, 2);
            ////    ////    //}
            ////    ////}
            ////}

            txtFullName.Text = "";
            GridView1.DataBind();
            grdShareHolder.DataBind();
            grdShareHolder_Ok.DataBind();
        }
        catch (HRMException ex)
        {
            UcTitle1.ErrorText = ex.Message;
        }
    }
    private bool checkData()
    {
        bool isCheck = true;
        if (txtFullName.Text.Trim().Length <= 0)
        {
            UcTitle1.ErrorText = "Vui lòng nhập mã cổ đông";
            isCheck = false;
        }
        try {

            int investorNo = int.Parse(txtFullName.Text.Trim());
        }
        catch
        {
            UcTitle1.ErrorText = "Mã cổ đông chỉ nhập ký tự Số";
            isCheck = false;
        }

        return isCheck;
    }
    protected void ObjectDataSource2_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["InvestorNo"] = 0;
        e.InputParameters["FullName"] = string.Empty;
        e.InputParameters["IsOk"] = 10;
        e.InputParameters["KTTCDB"] = 1;
    }
    protected void ObjectDataSource1_Selected(object sender, ObjectDataSourceStatusEventArgs e)
    {
        DataTable dt = (DataTable)e.ReturnValue;
        if (dt != null)
        {
            if (dt.Rows.Count > 0)
                lbShareHolder.Text = "CÒN LẠI : " + dt.Rows.Count.ToString();
            else
                lbShareHolder.Text = "CÒN LẠI : 0";
        }
        else
        {
            lbShareHolder.Text = "CÒN LẠI : 0";
        }
    }
    protected void ObjectDataSource2_Selected(object sender, ObjectDataSourceStatusEventArgs e)
    {
        DataTable dt = (DataTable)e.ReturnValue;
        if (dt != null)
        {
            if (dt.Rows.Count > 0)
                lbOk.Text = "THAM DỰ : " + dt.Rows.Count.ToString();
            else
                lbOk.Text = "THAM DỰ : 0";
        }
        else
        {
            lbOk.Text = "THAM DỰ : 0";
        }
    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        grdShareHolder.DataBind();
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridViewRow row = e.Row;
        if (row.RowType == DataControlRowType.DataRow)
        {
            //row.Cells[0].HorizontalAlign = HorizontalAlign.Center;
            //row.Cells[1].HorizontalAlign = HorizontalAlign.Left;
            
            //int a = int.Parse(row.Cells[2].Text.Trim());
            //row.Cells[2].Text = a.ToString("#,###0");
            //row.Cells[2].HorizontalAlign = HorizontalAlign.Right;

            //int b = int.Parse(row.Cells[3].Text.Trim());
            //row.Cells[3].Text = b.ToString("#,###0");
            //row.Cells[3].HorizontalAlign = HorizontalAlign.Right;

            //double c = double.Parse(row.Cells[4].Text.Trim());
            //row.Cells[4].Text = c.ToString("#,###0.000");
            //row.Cells[4].HorizontalAlign = HorizontalAlign.Right;
        }

    }
}