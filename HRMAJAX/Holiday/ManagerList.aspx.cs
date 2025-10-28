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
using HRMBLL.H1;
using HRMBLL.H5;
using HRMUtil;
using HRMUtil.KeyNames.H0;

public partial class Holiday_ManagerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "ĐĂNG KÝ NGHỈ MÁT";

            BindDataToDDLDepartment();
            BindDataToDropDownListTourStage();
            BindDataList();
        }
    }

    private string departmentIds
    {
        get
        {
            if (ViewState["departmentIds"] != null)
                return ViewState["departmentIds"].ToString();
            else
                return "";
        }
        set
        {
            ViewState["departmentIds"] = value;
        }
    }

    private int departmentId
    {
        get
        {
            if (ViewState["departmentId"] != null)
                return int.Parse(ViewState["departmentId"].ToString());
            else
                return 0;
        }
        set
        {
            ViewState["departmentId"] = value;
        }
    }

    private void BindDataToDDLDepartment()
    {

        string deptIds = WorkDayPrivilegeBLL.GetDepartmentIDsByUserId(ucPermission1.UserId, Constants.WorkdayPrivilege_CV);

        List<DepartmentsBLL> list = DepartmentsBLL.GetByIds(deptIds);
        if (ucPermission1.IsAdmin || ucPermission1.IsHRAdmin || ucPermission1.IsHRMember || ucPermission1.IsTrainingManager || ucPermission1.UserId == 341)
        {
            list = DepartmentsBLL.GetAllRoots();
        }
        ddlDepartment.DataSource = list;
        ddlDepartment.DataTextField = "DepartmentName";
        ddlDepartment.DataValueField = DepartmentKeys.FIELD_DEPARTMENT_ID;
        ddlDepartment.DataBind();

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

        departmentIds = string.Empty;
        departmentId = 0;
        if (ddlDepartment.SelectedValue != "")
        {
            departmentId = int.Parse(ddlDepartment.SelectedValue);
            if (ucPermission1.IsAdmin || ucPermission1.IsHRAdmin || ucPermission1.IsHRManager || ucPermission1.IsHRMember)
            {
                departmentIds = string.Empty;
                //departmentId = 0;
            }
            else
            {
                DepartmentsBLL obj = new DepartmentsBLL();
                obj.ChildNodeIds = departmentId.ToString() + ",";
                obj.GetAllChildId(departmentId);
                departmentIds = obj.ChildNodeIds;
                departmentId = 0;
            }
        }
        else
        {
            departmentIds = "-1";
        }


        DataTable dt = TravelerListBLL.GetByUserIdYearForDistinctTourStageName(0, 0, int.Parse(ddlTourStage.SelectedValue), departmentIds, departmentId, txtFullName.Text);
        dlTourStage.DataSource = dt;
        dlTourStage.DataBind();

    }

    protected void dlTourStage_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        DataListItem item = e.Item;
        if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
        {
            Label lbTourStageName = (Label)item.FindControl("lbTourStageName");
            Label lbCount = (Label)item.FindControl("lbCount");

            DataRowView dr = (DataRowView)item.DataItem;
            lbTourStageName.Text = "ĐỢT " + dr["TourStageName"].ToString().ToUpper();



            GridView grdHolidays = (GridView)item.FindControl("grdHolidays");
            int TourStageId = int.Parse(dr["TourStageId"].ToString());

            DataTable dt= TravelerListBLL.GetByTourStageIdDept(TourStageId, departmentIds, departmentId, txtFullName.Text);
            lbCount.Text = "Số lượng: "+dt.Rows.Count.ToString();
            grdHolidays.DataSource = TravelerListBLL.GetByTourStageIdDept(TourStageId, departmentIds, departmentId, txtFullName.Text);
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

            btnGridViewSelect.ForeColor = System.Drawing.Color.White;
            row.Cells[7].BackColor = System.Drawing.Color.Red;


            if (dr["ManagerApprovedRemark"].ToString().Trim().Length > 0)
            {
                remark_temp = remark_temp + "</br>" + "- Ý kiên cán bộ phòng/đội:" + dr["ManagerApprovedRemark"].ToString();
            }
            if (dr["HRDApprovedRemark"].ToString().Trim().Length > 0)
            {
                remark_temp = remark_temp + "</br>" + "- Ý kiến TCHC:" + dr["HRDApprovedRemark"].ToString();
            }

            if (ucPermission1.IsHolidayManagerApproved)
            {
                if (status == TravelerListBLL.Status_Send)
                {
                    btnGridViewSelect.Text = "Chưa duyệt";
                    btnGridViewSelect.Enabled = true;
                }
                else if (status == TravelerListBLL.Status_Manager_Approved)
                {                    
                    btnGridViewSelect.Enabled = false;
                    btnGridViewSelect.Text = "Phòng/Đội đã duyệt (Đồng ý)";
                    //if (dr["ManagerApprovedRemark"].ToString().Trim().Length > 0)
                    //{
                    //    remark_temp = remark_temp + "</br>" + "- Ý kiên cán bộ phòng/đội:" + dr["ManagerApprovedRemark"].ToString();
                    //}

                }
                else if (status == TravelerListBLL.Status_Manager_Approved_NotAgree)
                {
                    btnGridViewSelect.Enabled = true;
                    btnGridViewSelect.Text = "Phòng/Đội đã duyệt (Không đồng ý)";
                    //if (dr["ManagerApprovedRemark"].ToString().Trim().Length > 0)
                    //{
                    //    remark_temp = remark_temp + "</br>" + "- Ý kiên cán bộ phòng/đội:" + dr["ManagerApprovedRemark"].ToString();
                    //}

                }
                else if (status == TravelerListBLL.Status_HRAdmin_Approved)
                {
                    btnGridViewSelect.Text = "TCHC đã duyệt (Đồng ý)";
                    btnGridViewSelect.Enabled = false;
                    btnGridViewSelect.ForeColor = System.Drawing.Color.White;
                    row.Cells[7].BackColor = System.Drawing.Color.Green;
                    //if (dr["HRDApprovedRemark"].ToString().Trim().Length > 0)
                    //{
                    //    remark_temp = remark_temp + "</br>" + "- Ý kiến TCHC:" + dr["HRDApprovedRemark"].ToString();
                    //}
                }
                else if (status == TravelerListBLL.Status_HRAdmin_Approved_NotAgree)
                {
                    btnGridViewSelect.Enabled = false;
                    btnGridViewSelect.Text = "TCHC đã duyệt (không đồng ý)";
                    //if (dr["HRDApprovedRemark"].ToString().Trim().Length > 0)
                    //{
                    //    remark_temp = remark_temp + "</br>" + "- Ý kiên TCHC:" + dr["HRDApprovedRemark"].ToString();
                    //}

                }
                else
                {
                    btnGridViewSelect.Enabled = false;
                }
            }
            else if (ucPermission1.IsHolidayHRDApproved)
            {
                if (status == TravelerListBLL.Status_Manager_Approved)
                {
                    btnGridViewSelect.Text = "Chưa duyệt";
                    btnGridViewSelect.Enabled = true;
                }
                else if (status == TravelerListBLL.Status_HRAdmin_Approved)
                {
                    btnGridViewSelect.Text = "TCHC đã duyệt (Đồng ý)";
                    btnGridViewSelect.Enabled = false;
                    btnGridViewSelect.ForeColor = System.Drawing.Color.White;
                    row.Cells[7].BackColor = System.Drawing.Color.Green;
                    //if (dr["HRDApprovedRemark"].ToString().Trim().Length > 0)
                    //{
                    //    remark_temp = remark_temp + "</br>" + "- Ý kiến TCHC:" + dr["HRDApprovedRemark"].ToString();
                    //}
                }
                else if (status == TravelerListBLL.Status_HRAdmin_Approved_NotAgree)
                {
                    btnGridViewSelect.Enabled = true;
                    btnGridViewSelect.Text = "TCHC đã duyệt (không đồng ý)";
                    //if (dr["HRDApprovedRemark"].ToString().Trim().Length > 0)
                    //{
                    //    remark_temp = remark_temp + "</br>" + "- Ý kiên TCHC:" + dr["HRDApprovedRemark"].ToString();
                    //}

                }
                else
                {
                    btnGridViewSelect.Text = "Chưa gửi";
                    btnGridViewSelect.Enabled = false;
                }
            }
            else
            {
                if (status == TravelerListBLL.Status_Manager_Approved)
                {
                    btnGridViewSelect.Text = "Chưa duyệt";
                    btnGridViewSelect.Enabled = false;
                }
                else if (status == TravelerListBLL.Status_HRAdmin_Approved)
                {
                    btnGridViewSelect.Text = "TCHC đã duyệt (Đồng ý)";
                    btnGridViewSelect.Enabled = false;
                    btnGridViewSelect.ForeColor = System.Drawing.Color.White;
                    row.Cells[7].BackColor = System.Drawing.Color.Green;
                    //if (dr["HRDApprovedRemark"].ToString().Trim().Length > 0)
                    //{
                    //    remark_temp = remark_temp + "</br>" + "- Ý kiến TCHC:" + dr["HRDApprovedRemark"].ToString();
                    //}
                }
                else if (status == TravelerListBLL.Status_HRAdmin_Approved_NotAgree)
                {
                    btnGridViewSelect.Enabled = false;
                    btnGridViewSelect.Text = "TCHC đã duyệt (không đồng ý)";
                    //if (dr["HRDApprovedRemark"].ToString().Trim().Length > 0)
                    //{
                    //    remark_temp = remark_temp + "</br>" + "- Ý kiên TCHC:" + dr["HRDApprovedRemark"].ToString();
                    //}

                }
                else
                {
                    btnGridViewSelect.Text = "Chưa gửi";
                    btnGridViewSelect.Enabled = false;
                }
            }

            ltRemark.Text = remark_temp;


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
            pnlManagerApproved.Visible = true;
            int status = int.Parse(dr["Status"].ToString());
            lbFullNameSelected.Text = dr["FullName"].ToString();
            lbFullNameSelected.ToolTip = dr["UserId"].ToString();
            rdoAgree.ToolTip = dr["TourStageId"].ToString();
            rdoNotAgree.ToolTip = status.ToString();

            if (status == TravelerListBLL.Status_Manager_Approved_NotAgree)
            {
                rdoNotAgree.Checked = true;
                txtRemark.Text = dr["ManagerApprovedRemark"].ToString();
            }

        //    ddlTourStage.SelectedValue = dr["TourStageId"].ToString();
        //    txtKinName.Text = dr["KinName"].ToString();
        //    txtKinType.Text = dr["KinType"].ToString();
        //    cpKinBirthday.SelectedDate = Convert.ToDateTime(dr["KinBirthday"]);
        //    txtKinPhoneNumber.Text = dr["KinPhoneNumber"].ToString();
        //    txtRemark.Text = dr["Remark"].ToString();

        //    btnAdd.Text = "Cập nhật";
        //    btnAdd.ToolTip = dr["TravelerId"].ToString();
        //    btnDelete.Visible = true;
        //    btnSend.Visible = true;
        //    btnClean.Visible = true;
        }
    }
    protected void imgSearch_Click(object sender, EventArgs e)
    {
        BindDataList();
    }

    protected void btnApproved_Click(object sender, EventArgs e)
    {

        try
        {
            int userId = int.Parse(lbFullNameSelected.ToolTip);            
            int tourStageId = int.Parse(rdoAgree.ToolTip);
            int status = int.Parse(rdoNotAgree.ToolTip);
            

            if (ucPermission1.IsHolidayManagerApproved)
            {
                if (status == TravelerListBLL.Status_Send || status == TravelerListBLL.Status_Manager_Approved_NotAgree)
                {

                    if (rdoAgree.Checked)
                    {
                        TravelerListBLL.UpdateStatusByManager(userId, tourStageId, TravelerListBLL.Status_Manager_Approved, ucPermission1.UserId, txtRemark.Text);
                    }
                    else if (rdoNotAgree.Checked)
                    {
                        TravelerListBLL.UpdateStatusByManager(userId, tourStageId, TravelerListBLL.Status_Manager_Approved_NotAgree, ucPermission1.UserId, txtRemark.Text);
                    }
                    else
                    {
                        TravelerListBLL.UpdateStatusByManager(userId, tourStageId, TravelerListBLL.Status_Save, ucPermission1.UserId, txtRemark.Text);
                    }
                    BindDataList();
                    pnlManagerApproved.Visible = false;
                }
                else
                {
                    UcTitle1.ErrorText = "Cán bộ Phòng/Đội duyệt không thành công.";
                    pnlManagerApproved.Visible = true;
                }
              
            }
            else if (ucPermission1.IsHolidayHRDApproved)
            {
                if (status == TravelerListBLL.Status_Manager_Approved)
                {
                    TravelerListBLL.UpdateStatusUpdateStatusByHRD(userId, tourStageId, TravelerListBLL.Status_HRAdmin_Approved, ucPermission1.UserId, txtRemark.Text);
                    BindDataList();
                    pnlManagerApproved.Visible = false;
                }
                else
                {
                    UcTitle1.ErrorText = "Phòng TCHC duyệt không thành công.";
                    pnlManagerApproved.Visible = true;
                }
            }
            else
            {
                UcTitle1.ErrorText = "Duyệt không thành công.";
                pnlManagerApproved.Visible = true;
            }

        }
        catch (HRMException he)
        {
            UcTitle1.ErrorText = he.Message;
            pnlManagerApproved.Visible = true;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        pnlManagerApproved.Visible = false;
    }
   
}