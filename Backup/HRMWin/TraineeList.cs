using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HRMBLL.H0;
using HRMBLL.H2;

namespace HRMWin
{
    public partial class TraineeList : Form
    {

        public TraineeList()
        {
            InitializeComponent();
           
            
        }

        private void BindDropDownListDepartment()
        {
            ddlDepartments.DataSource = SessionsBLL.GetAll();
            ddlDepartments.DisplayMember = "Name";
            ddlDepartments.ValueMember = "Id";
        }

        private void BindGrid()
        {
            grdEmployees.DataSource = CandidatesBLL.GetForTrainingByFilter("", int.Parse(ddlDepartments.SelectedValue.ToString()));
            //grdEmployees.DataSource = EmployeesBLL.GetByDeptIds("",int.Parse(ddlDepartments.SelectedValue.ToString()),txtFullName.Text,"");
            
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
                string candidateId = grdEmployees.Rows[e.RowIndex].Cells[0].Value.ToString();
                ShowEmployeeDetail(candidateId);
            }
        }

        private void ShowEmployeeDetail(string candidateId)
        {
            TraineeDetail dlg = new TraineeDetail();
            dlg.CandidateId = int.Parse(candidateId);
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