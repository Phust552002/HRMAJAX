using HRMBLL.H6;
using HRMUtil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PMember_UserControls_PMemberInfo : System.Web.UI.UserControl
{
    public string Path
    {
        get
        {
            return Server.MapPath(@"~\Employee\Images\");
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
    public void SetPersonalInfor()
    {
        PMembersBLL objPMembersBLL = PMembersBLL.GetPMemberByEmployeeId(UserId);
        lbFullName.Text = objPMembersBLL.FullName;
        ddlPMemberStatus.SelectedValue = objPMembersBLL.PMemberStatus.ToString();
        cpDateJoinP.SelectedDate = objPMembersBLL.DateJoinP;
        cpDateJoinPOfficial.SelectedDate = objPMembersBLL.DateJoinPOfficial;
        txtPlaceJoinP.Text = objPMembersBLL.PlaceJoinP;
        txtPCardNo.Text = objPMembersBLL.PCardNo;
        txtRemarks.Text = objPMembersBLL.PMemberRemarks;
        
        SetDataToSubTab();
    }

    private void SetDataToSubTab()
    {
        DocumentList0.UserId = UserId;
        DocumentList0.RecordType = 1;

        DocumentList1.UserId = UserId;
        DocumentList1.RecordType = 2;

        DocumentList2.UserId = UserId;
        DocumentList2.RecordType = 3;

        DocumentList3.UserId = UserId;
        DocumentList3.RecordType = 4;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (!UcPermission1.IsPMemberAdmin)
            {
                btnAdd.Visible = false;             
            }

        }

        string userImageURL = Path + StringFormat.GetUserCode(UserId) + ".jpg";

        if (File.Exists(userImageURL))
        {
            ImgUser.ImageUrl = @"~/Employee/Images/" + StringFormat.GetUserCode(UserId) + ".jpg";
        }
        else
        {
            ImgUser.ImageUrl = "~/Employee/Images/no_image.gif";
        }
        Tabs1.TabSubLoad += new EventHandler(Tabs1_TabLoad);
        Tabs1.TabSubItemClick += new EventHandler(Tabs1_TabItemClick);
    }
    
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            PMembersBLL objPMembersBLL = PMembersBLL.GetPMemberByEmployeeId(UserId);
            objPMembersBLL.DateJoinP = cpDateJoinP.SelectedDate;
            objPMembersBLL.DateJoinPOfficial = cpDateJoinPOfficial.SelectedDate;
            objPMembersBLL.PlaceJoinP = txtPlaceJoinP.Text;
            objPMembersBLL.PCardNo = txtPCardNo.Text;
            objPMembersBLL.PMemberRemarks = txtRemarks.Text;
            objPMembersBLL.PMemberStatus = Convert.ToInt32(ddlPMemberStatus.SelectedValue);

            objPMembersBLL.Update();

            UcMessageError1.ErrorText = "Cập nhập thành công";
            LoadTab();
        }
        catch (Exception ex)
        {
            UcMessageError1.ErrorText = ex.Message;
        }
    }
    #region methods for Tabs1


    void Tabs1_TabItemClick(object sender, EventArgs e)
    {
        MenuEventArgs me = (MenuEventArgs)e;
        int indexItem = int.Parse(me.Item.Value);
        MultiTabs.ActiveViewIndex = indexItem;
    }

    void Tabs1_TabLoad(object sender, EventArgs e)
    {
        LoadTab();
    }

    private void LoadTab()
    {
        Tabs1.SourceTabSub.Items.Clear();
        if (ddlPMemberStatus.SelectedValue == "0")
            Tabs1.SourceTabSub.Items.Add(new MenuItem("Hồ sơ xem xét kết nạp Đảng", "0"));
        else if (ddlPMemberStatus.SelectedValue == "1")
        {
            Tabs1.SourceTabSub.Items.Add(new MenuItem("Hồ sơ xem xét kết nạp Đảng", "0"));
            Tabs1.SourceTabSub.Items.Add(new MenuItem("Hồ sơ Đảng viên dự bị", "1"));
        }
        else
        {
            Tabs1.SourceTabSub.Items.Add(new MenuItem("Hồ sơ xem xét kết nạp Đảng", "0"));
            Tabs1.SourceTabSub.Items.Add(new MenuItem("Hồ sơ Đảng viên dự bị", "1"));
            Tabs1.SourceTabSub.Items.Add(new MenuItem("Hồ sơ Đảng viên chính thức", "2"));
            Tabs1.SourceTabSub.Items.Add(new MenuItem("Hồ sơ Đảng viên chính thức (hàng năm)", "3"));
        }
            
        MultiTabs.ActiveViewIndex = 0;
        Tabs1.SourceTabSub.Items[0].Selected = true;
    }

    #endregion
}