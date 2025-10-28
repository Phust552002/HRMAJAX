using HRMBLL.H0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRMBLL.H6;

public partial class PMember_PMemberDetail : System.Web.UI.Page
{
    private int UserId
    {
        get
        {
            if (ViewState["UserId"] == null)
                return 0;
            else
                return int.Parse(ViewState["UserId"].ToString());
        }
        set
        {
            if (ViewState["UserId"] == null)
                ViewState["UserId"] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UcTitle1.Text = "THÔNG TIN CHI TIẾT CỦA ĐẢNG VIÊN";
            UserId = int.Parse(Request.QueryString["Id"]);
            SetEmployeeInfor();
            SetPMemberInfor();
        }
        Tabs1.TabLoad += new EventHandler(Tabs1_TabLoad);
        Tabs1.TabItemClick += new EventHandler(Tabs1_TabItemClick);
        Tabs1.BackClick += new EventHandler(Tabs1_BackClick);

        Tabs2.TabSubLoad += new EventHandler(Tabs2_TabLoad);
        Tabs2.TabSubItemClick += new EventHandler(Tabs2_TabItemClick);
    }
    private void SetEmployeeInfor()
    {
        bool editable = false;
        if(UcPermission1.IsPMemberAdmin)
        {
            editable = true;
        }
        EmployeesBLL objEmployee = EmployeesBLL.GetEmployeeById(UserId);
        

        Family1.ObjEmployeesBLL = objEmployee;
        Family1.SetPersonalInfor();
        Family1.ReadOnly = false;

        Working1.ObjEmployeesBLL = objEmployee;
        Working1.SetPersonalInfor();
        Working1.ReadOnly = false;

        PMembersBLL obj = PMembersBLL.GetPMemberByEmployeeId(UserId);
        Personal1.ObjPmembersBLL = obj;
        Personal1.SetPersonalPmemberInfor();
        Personal1.ReadOnly = editable;
        //Personal1.ReadOnlyForPMemberAdmin = true;
        //Family1.ObjPmembersBLL = obj;
        //Family1.SetPersonalInfor();
        //Family1.ReadOnly = false;

        //Working1.ObjPmembersBLL = obj;
        //Working1.SetPersonalInfor();
        //Working1.ReadOnly = false;


    }
    private void SetPMemberInfor()
    {
        PMemberInfo1.UserId = UserId;
        PMemberInfo1.SetPersonalInfor();

    }
    #region methods for Tabs1
    void Tabs1_BackClick(object sender, EventArgs e)
    {
        Response.Redirect("~/PMember/PMemberList.aspx");
    }

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
        Tabs1.SourceTab.Items.Add(new MenuItem("Hồ sơ Đảng viên", "0"));
        Tabs1.SourceTab.Items.Add(new MenuItem("Tài liệu Đảng viên", "1"));
        MultiTabs.ActiveViewIndex = 0;
        Tabs1.SourceTab.Items[0].Selected = true;
    }

    #endregion
    #region methods for Tabs2


    void Tabs2_TabItemClick(object sender, EventArgs e)
    {
        MenuEventArgs me = (MenuEventArgs)e;
        int indexItem = int.Parse(me.Item.Value);
        MultiTabs2.ActiveViewIndex = indexItem;
    }

    void Tabs2_TabLoad(object sender, EventArgs e)
    {
        LoadTab2();
    }

    private void LoadTab2()
    {
        Tabs2.SourceTabSub.Items.Add(new MenuItem("Lý Lịch Bản Thân", "0"));
        Tabs2.SourceTabSub.Items.Add(new MenuItem("Tình Hình Chính Trị - Kinh Tế", "1"));
        Tabs2.SourceTabSub.Items.Add(new MenuItem("Quá Trình Công Tác", "2"));
        MultiTabs2.ActiveViewIndex = 0;
        Tabs2.SourceTabSub.Items[0].Selected = true;
    }

    #endregion
}