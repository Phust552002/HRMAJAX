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

using HRMBLL.BLLHelper;
using HRMBLL.H0;
using HRMBLL.H5;
using HRMUtil;

public partial class Holiday_Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "ĐĂNG KÝ NGHỈ MÁT";

            EmployeesBLL objUser = ucPermission1.UserCurrent;

            lbFullName.Text = objUser.FullName;
            lbDepartment.Text = objUser.DepartmentFullName;
            BindDataToDropDownListTourStage();
            BindDataList();
            CheckEligiblityByUserId(objUser.UserId);
        }
    }

    private void CheckEligiblityByUserId(int userId)
    {
        try
        {
            if (!TravelerListBLL.CheckEligibilityByUserId(userId))
            {
                UcTitle1.ErrorText = "Bạn không nằm trong danh sách đủ điều kiện đi nghỉ mát";
                ddlTourStage.Enabled = false;
                dlTourStage.Enabled = false;
                txtKinName.Enabled = false;
                txtKinPhoneNumber.Enabled = false;
                txtKinType.Enabled = false;
                txtRemark.Enabled = false;
                cpKinBirthday.Enabled = false;
                btnAdd.Enabled = false;
                btnClean.Enabled = false;
                btnDelete.Enabled = false;
                btnSend.Enabled = false;
            }
            else
            {
                ddlTourStage.Enabled = true;
                dlTourStage.Enabled = true;
                txtKinName.Enabled = true;
                txtKinPhoneNumber.Enabled = true;
                txtKinType.Enabled = true;
                txtRemark.Enabled = true;
                cpKinBirthday.Enabled = true;
                btnAdd.Enabled = true;
                btnClean.Enabled = true;
                btnDelete.Enabled = true;
                btnSend.Enabled = true;
            }
        }
        catch (Exception ex)
        {
            UcTitle1.ErrorText = ex.Message;
        }
    }

    private void BindDataToDropDownListTourStage()
    {
        ddlTourStage.DataSource = TourStageBLL.GetByYear(0);
        ddlTourStage.DataTextField = "TourStageName";
        ddlTourStage.DataValueField = "TourStageId";
        ddlTourStage.DataBind();
        
    }

    private void BindDataList()
    {

        DataTable dt = TravelerListBLL.GetByUserIdYearForDistinctTourStageName(0, ucPermission1.UserId, 0, "",0,"");
        dlTourStage.DataSource = dt;
        dlTourStage.DataBind();

    }

    protected void dlTourStage_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        DataListItem item = e.Item;
        if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
        {
            Label lbTourStageName = (Label)item.FindControl("lbTourStageName");

            DataRowView dr = (DataRowView)item.DataItem;
            lbTourStageName.Text = "ĐỢT " + dr["TourStageName"].ToString().ToUpper();



            GridView grdHolidays = (GridView)item.FindControl("grdHolidays");
            int TourStageId = int.Parse(dr["TourStageId"].ToString());
            grdHolidays.DataSource = TravelerListBLL.GetByUserIdTourStageId(ucPermission1.UserId, TourStageId);
            grdHolidays.DataBind();


            //Label lbTotalRatioStock = (Label)item.FindControl("lbTotalRatioStock");
            //Label lbTotalRatioStockName = (Label)item.FindControl("lbTotalRatioStockName");
            //lbTotalRatioStockName.Text = "Tỉ lệ tán thành: 100 - " + StockRatioTotalByVoteType.ToString(StringFormat.FormatRepresentative);
            //lbTotalRatioStock.Text = (100 - StockRatioTotalByVoteType).ToString(StringFormat.FormatRepresentative) + "%";

            //DataList dlRepresentativeVote = (DataList)item.FindControl("dlRepresentativeVote");
            //int voteType = int.Parse(dr["VoteType"].ToString());
            //dlRepresentativeVote.DataSource = RepresentativeVoteBLL.GetByVoteType(voteType);
            //dlRepresentativeVote.DataBind();

        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            int TravelerId = int.Parse(btnAdd.ToolTip.Trim().Length <= 0 ? "0" : btnAdd.ToolTip.Trim());
            int tourStageId = int.Parse(ddlTourStage.SelectedValue);
            if (tourStageId > 0)
            {
                if (TravelerId <= 0)
                {
                    TravelerListBLL.Insert(ucPermission1.UserId, int.Parse(ddlTourStage.SelectedValue), txtKinName.Text, txtKinType.Text, cpKinBirthday.SelectedDate, txtKinPhoneNumber.Text, txtRemark.Text, TravelerListBLL.Status_Save);
                }
                else
                {
                    TravelerListBLL.Update(ucPermission1.UserId, int.Parse(ddlTourStage.SelectedValue), txtKinName.Text, txtKinType.Text, cpKinBirthday.SelectedDate, txtKinPhoneNumber.Text, txtRemark.Text, TravelerListBLL.Status_Save, TravelerId);
                }
                UcTitle1.ErrorText = "";
                setDefault();
                BindDataList();
            }
            else
            {
                UcTitle1.ErrorText = "Vui lòng chọn đợt nghỉ mát.....";
            }
        }
        catch (HRMException he)
        {
            UcTitle1.ErrorText = he.Message;
        }
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        try
        {
            int TravelerId = int.Parse(btnAdd.ToolTip.Trim().Length <= 0 ? "0" : btnAdd.ToolTip.Trim());
            int tourStageId = int.Parse(ddlTourStage.SelectedValue);

            if (tourStageId > 0)
            {
                if (TravelerId <= 0)
                {
                    TravelerListBLL.Insert(ucPermission1.UserId, tourStageId, txtKinName.Text, txtKinType.Text, cpKinBirthday.SelectedDate, txtKinPhoneNumber.Text, txtRemark.Text, TravelerListBLL.Status_Save);
                }
                else
                {
                    TravelerListBLL.Update(ucPermission1.UserId, tourStageId, txtKinName.Text, txtKinType.Text, cpKinBirthday.SelectedDate, txtKinPhoneNumber.Text, txtRemark.Text, TravelerListBLL.Status_Save, TravelerId);
                }
                TravelerListBLL.UpdateStatus(ucPermission1.UserId, tourStageId, TravelerListBLL.Status_Send, TravelerId);
                UcTitle1.ErrorText = "";
                setDefault();
                BindDataList();
            }
            else
            {
                UcTitle1.ErrorText = "Vui lòng chọn đợt nghỉ mát.....";
            }
        }
        catch (HRMException he)
        {
            UcTitle1.ErrorText = he.Message;
        }
    }
  

    private void setDefault()
    {
        txtKinName.Text = "";
        txtKinType.Text = "";
        txtKinPhoneNumber.Text = "";
        txtKinName.Text = "";
        txtRemark.Text = "";
        btnAdd.Text = "Thêm mới";
        btnAdd.ToolTip = "";
        btnDelete.Visible = false;
        btnSend.Visible = false;        
        btnClean.Visible = false;
    }

    protected void grdHolidays_RowDataBound(object sender, GridViewRowEventArgs e)
    {
         GridViewRow row = e.Row;
         if (row.RowType == DataControlRowType.DataRow)
         {

             DataRowView dr = (DataRowView)row.DataItem;

             Label lbFullName = (Label)row.FindControl("lbFullName");
             lbFullName.ToolTip = dr["TravelerId"].ToString();

             Label lbKinBirthday = (Label)row.FindControl("lbKinBirthday");
             lbKinBirthday.Text = dr["KinBirthday"] == DBNull.Value ? string.Empty : FormatDate.FormatVNDate(Convert.ToDateTime(dr["KinBirthday"]));

             string remark_temp = string.Empty;
             Literal ltRemark = (Literal)row.FindControl("ltRemark");
             remark_temp = dr["Remark"].ToString();


             LinkButton btnGridViewSelect = (LinkButton)row.FindControl("btnGridViewSelect");

             int status = dr["Status"] == DBNull.Value ? 0 : int.Parse(dr["Status"].ToString());

             btnGridViewSelect.Text = TravelerListBLL.GetStatusNameByStatus(status);

             if (status > TravelerListBLL.Status_Save)
             {
                 btnGridViewSelect.Enabled = false;
             }
             else
             {
                 btnGridViewSelect.Enabled = true;
             }

             btnGridViewSelect.ForeColor = System.Drawing.Color.White;
             row.Cells[6].BackColor = System.Drawing.Color.Red;

             if (status == TravelerListBLL.Status_Manager_Approved)
             {
                 btnGridViewSelect.Text = "Phòng đã duyệt (đồng ý)";                 

                 if (dr["ManagerApprovedRemark"].ToString().Trim().Length > 0)
                 {
                     remark_temp = remark_temp + "</br>" + "- Ý kiên cán bộ phòng/đội: " + dr["ManagerApprovedRemark"].ToString();
                 }

             }
             else if (status == TravelerListBLL.Status_Manager_Approved_NotAgree)
             {
                 btnGridViewSelect.Text = "Phòng đã duyệt (không đồng ý)";
                 if (dr["ManagerApprovedRemark"].ToString().Trim().Length > 0)
                 {
                     remark_temp = remark_temp + "</br>" + "- Ý kiên cán bộ phòng/đội:" + dr["ManagerApprovedRemark"].ToString();
                 }

             }
             else if (status == TravelerListBLL.Status_HRAdmin_Approved)
             {
                 btnGridViewSelect.Text = "TCHC đã duyệt (đồng ý)";
                 btnGridViewSelect.ForeColor = System.Drawing.Color.White;
                 row.Cells[6].BackColor = System.Drawing.Color.Green;
                 if (dr["HRDApprovedRemark"].ToString().Trim().Length > 0)
                 {
                     remark_temp = remark_temp + "</br>" + "- Ý kiến TCHC:" + dr["HRDApprovedRemark"].ToString();
                 }
             }
             else if (status == TravelerListBLL.Status_HRAdmin_Approved_NotAgree)
             {
                 btnGridViewSelect.Text = "TCHC đã duyệt (không đồng ý)";
                 if (dr["HRDApprovedRemark"].ToString().Trim().Length > 0)
                 {
                     remark_temp = remark_temp + "</br>" + "- Ý kiên TCHC:" + dr["HRDApprovedRemark"].ToString();
                 }

             }

             ltRemark.Text = remark_temp;

         }
        
    }
  
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            int TravelerId = int.Parse(btnAdd.ToolTip.Trim().Length <= 0 ? "0" : btnAdd.ToolTip.Trim());

            TravelerListBLL.Delete(TravelerId);
            UcTitle1.ErrorText = "";
            setDefault();
            BindDataList();
        }
        catch (HRMException he)
        {
            UcTitle1.ErrorText = he.Message;
        }
    }
    protected void btnGridViewSelect_Click(object sender, EventArgs e)
    {
        LinkButton btnGridViewSelect = (LinkButton)sender;
        DataControlFieldCell cell = (DataControlFieldCell)btnGridViewSelect.Parent;
        GridViewRow row = (GridViewRow)cell.Parent;
        Label lbFullName = (Label)row.FindControl("lbFullName");

        int TravelerId = int.Parse(lbFullName.ToolTip.Trim().Length <= 0 ? "0" : lbFullName.ToolTip.Trim());

        DataRow dr = TravelerListBLL.GetByTravelerId(TravelerId);

        if (dr != null)
        {
            ddlTourStage.SelectedValue = dr["TourStageId"].ToString();
            txtKinName.Text = dr["KinName"].ToString();
            txtKinType.Text = dr["KinType"].ToString();
            cpKinBirthday.SelectedDate = Convert.ToDateTime(dr["KinBirthday"]);
            txtKinPhoneNumber.Text = dr["KinPhoneNumber"].ToString();
            txtRemark.Text = dr["Remark"].ToString();

            btnAdd.Text = "Cập nhật";
            btnAdd.ToolTip = dr["TravelerId"].ToString();
            btnDelete.Visible = true;
            btnSend.Visible = true;
            btnClean.Visible = true;
        }
    }
    protected void btnClean_Click(object sender, EventArgs e)
    {
        setDefault();
    }
}