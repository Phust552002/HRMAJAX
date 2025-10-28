using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HRMBLL.H0;

namespace HRMWin
{
    public partial class EmployeesList : Form
    {

        public EmployeesList()
        {
            InitializeComponent();
           
            
        }

        private void BindDropDownListDepartment()
        {
            List<DepartmentsBLL> list = null;
            //if (clsGlobal.UserId == 6 || clsGlobal.UserId == 9)
            //{
                list = DepartmentsBLL.GetAllRoots();
            //}
            //else
            //{
            //    list = DepartmentsBLL.GetByIds("5,6,7");
            //}
            ddlDepartments.DataSource = list;
            ddlDepartments.DisplayMember = "RootName";
            ddlDepartments.ValueMember = "RootId";

        }

        private void BindGrid()
        {            
            grdEmployees.DataSource = EmployeesBLL.GetByDeptIds("",int.Parse(ddlDepartments.SelectedValue.ToString()),txtFullName.Text,"");
            
        }

        private void EmployeesList_Load(object sender, EventArgs e)
        {
            BindDropDownListDepartment();
            BindGrid();
        }

        private void grdEmployees_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           

            if (grdEmployees.SelectedRows.Count > 0)
            {
                string userId = grdEmployees.SelectedRows[0].Cells[0].Value.ToString();
                ShowEmployeeDetail(userId);
            }
            
            
        }

        private void grdEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (grdEmployees.SelectedCells.Count > 0)
            {
                string userId = grdEmployees.Rows[e.RowIndex].Cells[0].Value.ToString();
                ShowEmployeeDetail(userId);
            }
        }

        private void ShowEmployeeDetail(string userId)
        {
            EmployeeDetail dlg = new EmployeeDetail();
            dlg.UserId = int.Parse(userId);
            dlg.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (int.Parse(e.KeyValue.ToString()) == 13)
            {
                BindGrid();
            }
        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (int.Parse(e.KeyValue.ToString()) == 13)
            {
                BindGrid();
            }
        }

       
       
    }
}