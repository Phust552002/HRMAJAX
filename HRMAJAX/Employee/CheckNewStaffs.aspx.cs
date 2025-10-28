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

using HRMBLL.BLLHelper;

public partial class Employee_CheckNewStaffs : System.Web.UI.Page
{

    private string _FileName = string.Empty;

    private string _ExcelPath = string.Empty;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            AddDataToCboYear();
        }
    }    


    public string ExcelPath
    {
        get
        {
            if (_ExcelPath.Trim().Length <= 0)
            {
                return Server.MapPath(@"~\App_Data\ImportedExcels");
            }
            else
            {
                return _ExcelPath;
            }
        }
    }


    private void AddDataToCboYear()
    {
        for (int i = 2000; i <= DateTime.Now.Year; i++)
        {
            ListItem item = new ListItem(i.ToString(), i.ToString());
            cboYears.Items.Add(item);
        }
        
        if (DateTime.Now.Month == 1)
        {
            cboMonths.SelectedValue = Convert.ToString(12);
            cboYears.SelectedValue = Convert.ToString(DateTime.Now.Year - 1);
        }
        else
        {
            cboMonths.SelectedValue = Convert.ToString(DateTime.Now.Month - 1);
            cboYears.SelectedValue = DateTime.Now.Year.ToString();
        }
    }

    protected void btnCheck_Click(object sender, EventArgs e)
    {
        if (checkInvalid())
        {

            try
            {
                if (fuExcelFile.HasFile)
                {
                    this._FileName = cboMonths.SelectedValue + "_" + cboYears.SelectedValue + "" + fuExcelFile.FileName;

                    fuExcelFile.SaveAs(this.ExcelPath + "\\" + this._FileName);

                    gridNewStaffs.DataBind();
                }
            }
            catch (Exception ex)
            {
                lbError.Text = ex.Message;
            }
        }
    }

    private bool checkInvalid()
    {
        if (!fuExcelFile.FileName.Equals("nhanvienmoi.xls"))
        {
            lbError.Text = "Tên file phai la \"nhanvienmoi\"";
            return false;
        }
        else
        {
            return true;
        }
    }
    protected void obsNewStaffs_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        DataTable dt;
        ExcelHelper obj = new ExcelHelper(this.ExcelPath + "\\" + this._FileName);        
        dt = obj.ReadDataFromExcelToDataTable();
        e.InputParameters["tb"] = dt;
    }
}
