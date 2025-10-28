using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using HRMBLL.H0;
using HRMUtil.KeyNames.H0;
using HRMUtil;

public partial class Employee_UserControls_Family_Others : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlTypeFilter.DataSource = RelationTypesBLL.GetByFilter("", Constants.RELATION_NGUOI_THAN_KHAC_ID);
            ddlTypeFilter.DataTextField = RelationTypeKeys.FIELD_RELATION_TYPE_NAME;
            ddlTypeFilter.DataValueField = RelationTypeKeys.FIELD_RELATION_TYPE_ID;
            ddlTypeFilter.DataBind();

            BindDataListMyFamily();
        }
    }

    public int UserId
    {
        set
        {
            ViewState["UserId"] = value;
        }
        get
        {
            if (ViewState["UserId"] != null)
            {
                return int.Parse(ViewState["UserId"].ToString());
            }
            else
            {
                return 0;
            }
        }
    }

    public bool IsEdit
    {
        set
        {
            ViewState["IsEdit"] = value;
        }
        get
        {
            if (ViewState["IsEdit"] != null)
            {
                return bool.Parse(ViewState["IsEdit"].ToString());
            }
            else
            {
                return false;
            }
        }
    }

    private void BindDataListMyFamily()
    {
        dlMyFamily.DataSource = EmployeeRelationBLL.GetByFilter(int.Parse(ddlTypeFilter.SelectedValue), UserId, Constants.RELATION_NGUOI_THAN_KHAC_ID);
        dlMyFamily.DataBind();
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (IsEdit)
        {
            try
            {
                EmployeeRelationBLL objBLL = new EmployeeRelationBLL();

                objBLL.UserId = UserId;
                objBLL.RelationTypeId = int.Parse(ddlRelationType.SelectedValue);
                objBLL.RFullName = txtRFullName.Text;
                objBLL.RDayOfBirth = txtRDayOfBirth.Text.Length == 0 ? 0 : int.Parse(txtRDayOfBirth.Text);
                objBLL.RMonthOfBirth = txtMonthOfBirth.Text.Length == 0 ? 0 : int.Parse(txtMonthOfBirth.Text);
                objBLL.RYearOfBirth = txtRYearOfBirth.Text.Length == 0 ? 0 : int.Parse(txtRYearOfBirth.Text);
                objBLL.RNativePlace = txtRNativePlace.Text;
                objBLL.RResident = txtRResident.Text;
                objBLL.RLive = txtRLive.Text;
                objBLL.Before1975 = txtBefore1975.Text;
                objBLL.After1975 = txtAfter1975.Text;
                objBLL.Participate = txtParticipate.Text;
                objBLL.Died = chkDied.Checked;
                objBLL.DiedCause = txtDiedCause.Text;
                objBLL.Others = txtOthers.Text;

                objBLL.Save();
                BindDataListMyFamily();
                SetDefaultValue();
            }
            catch (HRMException he)
            {
                UcMessageError1.ErrorText = he.Message;
            }
        }
    }

    private void SetDefaultValue()
    {
        txtRFullName.Text = string.Empty;
        txtRDayOfBirth.Text = string.Empty;
        txtMonthOfBirth.Text = string.Empty;
        txtRYearOfBirth.Text = string.Empty;
        txtRNativePlace.Text = string.Empty;
        txtRResident.Text = string.Empty;
        txtRLive.Text = string.Empty;
        txtBefore1975.Text = string.Empty;
        txtAfter1975.Text = string.Empty;
        txtParticipate.Text = string.Empty;
        chkDied.Checked = false;
        txtDiedCause.Text = string.Empty;
        txtOthers.Text = string.Empty;
    }

    //protected void btnSearch_Click(object sender, EventArgs e)
    //{
    //    BindDataListMyFamily();
    //}
    protected void chkHide_CheckedChanged(object sender, EventArgs e)
    {
        pnAdd.Visible = chkHide.Checked;
    }
    protected void dlMyFamily_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        DataListItem item = e.Item;
        if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
        {
            EmployeeRelationBLL objBLL = (EmployeeRelationBLL)item.DataItem;

            Label lbRelationType = (Label)item.FindControl("lbRelationType");
            lbRelationType.Text = objBLL.RelationTypeName.ToUpper();

            Label lbRFullName = (Label)item.FindControl("lbRFullName");
            lbRFullName.Text = objBLL.RFullName;

            Label lbRBirthday = (Label)item.FindControl("lbRBirthday");
            lbRBirthday.Text = Util.GetFormatVNDate(objBLL.RDayOfBirth, objBLL.RMonthOfBirth, objBLL.RYearOfBirth);

            Label lbRNativePlace = (Label)item.FindControl("lbRNativePlace");
            lbRNativePlace.Text = objBLL.RNativePlace;

            Label lbRResident = (Label)item.FindControl("lbRResident");
            lbRResident.Text = objBLL.RResident;

            Label lbRLive = (Label)item.FindControl("lbRLive");
            lbRLive.Text = objBLL.RLive;

            Label lbBefore1975 = (Label)item.FindControl("lbBefore1975");
            lbBefore1975.Text = objBLL.Before1975;

            Label lbAfter1975 = (Label)item.FindControl("lbAfter1975");
            lbAfter1975.Text = objBLL.After1975;

            Label lbParticipate = (Label)item.FindControl("lbParticipate");
            lbParticipate.Text = objBLL.Participate;

            CheckBox chkDied = (CheckBox)item.FindControl("chkDied");
            chkDied.Checked = objBLL.Died;

            Label lbDiedCause = (Label)item.FindControl("lbDiedCause");
            lbDiedCause.Text = objBLL.DiedCause;

            Label lbOthers = (Label)item.FindControl("lbOthers");
            lbOthers.Text = objBLL.Others;


            Label lbEdit = (Label)item.FindControl("lbEdit");
            lbEdit.Visible = IsEdit;
            ImageButton imgEdit = (ImageButton)item.FindControl("imgEdit");
            imgEdit.Visible = IsEdit;

            Label lbDelete = (Label)item.FindControl("lbDelete");
            lbDelete.Visible = IsEdit;
            ImageButton imgDelete = (ImageButton)item.FindControl("imgDelete");
            imgDelete.Visible = IsEdit;

            Panel pnDied = (Panel)item.FindControl("pnDied");
            pnDied.Visible = objBLL.Died;
        }
        else if (item.ItemType == ListItemType.EditItem)
        {

            EmployeeRelationBLL objBLL = (EmployeeRelationBLL)item.DataItem;

            DropDownList ddlRelationTypeEdit = (DropDownList)item.FindControl("ddlRelationTypeEdit");
            ddlRelationTypeEdit.SelectedValue = objBLL.RelationTypeId.ToString();

            TextBox txtRFullNameEdit = (TextBox)item.FindControl("txtRFullNameEdit");
            txtRFullNameEdit.Text = objBLL.RFullName;

            if (objBLL.RDayOfBirth > 0)
            {
                TextBox txtRDayOfBirthEdit = (TextBox)item.FindControl("txtRDayOfBirthEdit");
                txtRDayOfBirthEdit.Text = objBLL.RDayOfBirth.ToString();
            }
            if (objBLL.RMonthOfBirth > 0)
            {
                TextBox txtMonthOfBirthEdit = (TextBox)item.FindControl("txtMonthOfBirthEdit");
                txtMonthOfBirthEdit.Text = objBLL.RMonthOfBirth.ToString();
            }

            if (objBLL.RYearOfBirth > 0)
            {
                TextBox txtRYearOfBirthEdit = (TextBox)item.FindControl("txtRYearOfBirthEdit");
                txtRYearOfBirthEdit.Text = objBLL.RYearOfBirth.ToString();
            }

            TextBox txtRNativePlaceEdit = (TextBox)item.FindControl("txtRNativePlaceEdit");
            txtRNativePlaceEdit.Text = objBLL.RNativePlace;

            TextBox txtRResidentEdit = (TextBox)item.FindControl("txtRResidentEdit");
            txtRResidentEdit.Text = objBLL.RResident;

            TextBox txtRLiveEdit = (TextBox)item.FindControl("txtRLiveEdit");
            txtRLiveEdit.Text = objBLL.RLive;

            TextBox txtBefore1975Edit = (TextBox)item.FindControl("txtBefore1975Edit");
            txtBefore1975Edit.Text = objBLL.Before1975;

            TextBox txtAfter1975Edit = (TextBox)item.FindControl("txtAfter1975Edit");
            txtAfter1975Edit.Text = objBLL.After1975;

            TextBox txtParticipateEdit = (TextBox)item.FindControl("txtParticipateEdit");
            txtParticipateEdit.Text = objBLL.Participate;

            CheckBox chkDiedEdit = (CheckBox)item.FindControl("chkDiedEdit");
            chkDiedEdit.Checked = objBLL.Died;

            TextBox txtDiedCauseEdit = (TextBox)item.FindControl("txtDiedCauseEdit");
            txtDiedCauseEdit.Text = objBLL.DiedCause;

            TextBox txtOthersEdit = (TextBox)item.FindControl("txtOthersEdit");
            txtOthersEdit.Text = objBLL.Others;


        }
    }
    protected void dlMyFamily_EditCommand(object source, DataListCommandEventArgs e)
    {
        if (IsEdit)
        {
            dlMyFamily.EditItemIndex = e.Item.ItemIndex;
            BindDataListMyFamily();
        }
    }
    protected void dlMyFamily_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        if (IsEdit)
        {
            long UserRelationId = Convert.ToInt32(dlMyFamily.DataKeys[e.Item.ItemIndex]);
            EmployeeRelationBLL.Delete(UserRelationId);
            BindDataListMyFamily();
        }
    }
    protected void dlMyFamily_CancelCommand(object source, DataListCommandEventArgs e)
    {
        if (IsEdit)
        {
            dlMyFamily.EditItemIndex = -1;
            BindDataListMyFamily();
        }
    }
    protected void dlMyFamily_UpdateCommand(object source, DataListCommandEventArgs e)
    {
        if (IsEdit)
        {
            DataListItem item = (DataListItem)e.Item;
            // Read in the UserRelationId from the DataKeys collection
            long UserRelationId = Convert.ToInt32(dlMyFamily.DataKeys[e.Item.ItemIndex]);

            EmployeeRelationBLL objBLL = new EmployeeRelationBLL();

            objBLL.UserId = UserId;
            objBLL.UserRelationId = UserRelationId;

            DropDownList ddlRelationTypeEdit = (DropDownList)item.FindControl("ddlRelationTypeEdit");
            objBLL.RelationTypeId = int.Parse(ddlRelationTypeEdit.SelectedValue);

            TextBox txtRFullNameEdit = (TextBox)item.FindControl("txtRFullNameEdit");
            objBLL.RFullName = txtRFullNameEdit.Text;

            TextBox txtRDayOfBirthEdit = (TextBox)item.FindControl("txtRDayOfBirthEdit");
            objBLL.RDayOfBirth = txtRDayOfBirthEdit.Text.Length == 0 ? 0 : int.Parse(txtRDayOfBirthEdit.Text);

            TextBox txtMonthOfBirthEdit = (TextBox)item.FindControl("txtMonthOfBirthEdit");
            objBLL.RMonthOfBirth = txtMonthOfBirthEdit.Text.Length == 0 ? 0 : int.Parse(txtMonthOfBirthEdit.Text);

            TextBox txtRYearOfBirthEdit = (TextBox)item.FindControl("txtRYearOfBirthEdit");
            objBLL.RYearOfBirth = txtRYearOfBirthEdit.Text.Length == 0 ? 0 : int.Parse(txtRYearOfBirthEdit.Text);

            TextBox txtRNativePlaceEdit = (TextBox)item.FindControl("txtRNativePlaceEdit");
            objBLL.RNativePlace = txtRNativePlaceEdit.Text;

            TextBox txtRResidentEdit = (TextBox)item.FindControl("txtRResidentEdit");
            objBLL.RResident = txtRResidentEdit.Text;

            TextBox txtRLiveEdit = (TextBox)item.FindControl("txtRLiveEdit");
            objBLL.RLive = txtRLiveEdit.Text;

            TextBox txtBefore1975Edit = (TextBox)item.FindControl("txtBefore1975Edit");
            objBLL.Before1975 = txtBefore1975Edit.Text;

            TextBox txtAfter1975Edit = (TextBox)item.FindControl("txtAfter1975Edit");
            objBLL.After1975 = txtAfter1975Edit.Text;

            TextBox txtParticipateEdit = (TextBox)item.FindControl("txtParticipateEdit");
            objBLL.Participate = txtParticipateEdit.Text;

            CheckBox chkDiedEdit = (CheckBox)item.FindControl("chkDiedEdit");
            objBLL.Died = chkDiedEdit.Checked;

            TextBox txtDiedCauseEdit = (TextBox)item.FindControl("txtDiedCauseEdit");
            objBLL.DiedCause = txtDiedCauseEdit.Text;

            TextBox txtOthersEdit = (TextBox)item.FindControl("txtOthersEdit");
            objBLL.Others = txtOthersEdit.Text;

            objBLL.Save();

            dlMyFamily.EditItemIndex = -1;
            BindDataListMyFamily();
        }
    }

    public bool ReadOnly
    {
        set
        {
            chkHide.Visible = value;
            IsEdit = value;
        }
    }
    protected void ddlTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDataListMyFamily();
    }
}
