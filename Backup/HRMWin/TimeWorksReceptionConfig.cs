using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRMWin
{
    public partial class TimeWorksReceptionConfig : Form
    {
        public TimeWorksReceptionConfig()
        {
            InitializeComponent();
        }

        private void btnBackgroundImage_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPathBackground.Text = openFileDialog1.FileName;
            }
        }

        private void btnLogFile_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPathLogFile.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            clsGlobal.TimeWorkdBackgroundImage = txtPathBackground.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}