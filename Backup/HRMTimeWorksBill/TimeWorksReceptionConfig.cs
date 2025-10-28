using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Itworks.Idworks;

namespace HRMTimeWorksBill
{
    public partial class TimeWorksReceptionConfig : Form
    {
        private int sensor_count = 0;
        private IslWrapper.DeviceInfo[] sensor_infos;

        public TimeWorksReceptionConfig()
        {
            InitializeComponent();
        }

        private void CheckDevice()
        {
            IslWrapper.InitModule();
            
            try
            {

                IslResultTypes result_code = IslWrapper.GetDeviceCount(ref sensor_count);

                if (sensor_count > 0)
                {
                    
                    if (IslResultTypes.Ok == IslWrapper.GetDeviceList(out sensor_infos, sensor_count))
                    {
                        for (int i = 0; i < sensor_count; i++)
                        {
                            clsGlobal.SensorId = sensor_infos[i].SensorId.ToString();
                            clsGlobal.DeviceName = sensor_infos[i].DeviceName;                                                        
                            clsGlobal.DeviceType = sensor_infos[i].DeviceType.ToString();
                        }
                    }
                }

            }
            finally
            {
                IslWrapper.FinalizeModule();
            }
        }
        private void RegisterDevice()
        {
            if (sensor_count > 0)
            {
                txtSensorID.Text = clsGlobal.SensorId;
                txtDeviceType.Text = clsGlobal.DeviceType;
                txtDeviceName.Text = clsGlobal.DeviceName;
                txtDeviceSerial.Text = clsGlobal.SerialNumber;
                txtDeviceRegistrationKey.Text = clsGlobal.RegistrationKey;
            }
          
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
            clsGlobal.ClearTimeReceptionForm = Convert.ToInt32(nudClearTimeReceptionForm.Value);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimeWorksReceptionConfig_Load(object sender, EventArgs e)
        {
            CheckDevice();
            RegisterDevice();
            cboLanguage.SelectedIndex = 0;
            cboResolution.SelectedIndex = 0;
        }

       
    }
}