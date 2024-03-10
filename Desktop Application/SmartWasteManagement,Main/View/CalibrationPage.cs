using SmartWasteManagement.Main.Vision;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartWasteManagement.Main.Database.Model;
using SmartWasteManagement.Main.Database.Query;
using SmartWasteManagement.Main.Database;

namespace SmartWasteManagement.Main.View
{
    public partial class CalibrationPage : Form
    {
        public Camera camera;

        public SensorCalibrationQuery query;
        public CalibrationPage(Camera camera, MongoDBHandler db_handler)
        {
            this.camera = camera;
            this.query = new SensorCalibrationQuery(db_handler);

            InitializeComponent();
            GetAvailableCameras();
        }

        public void GetAvailableCameras()
        {
            CameraComboBox.Items.AddRange(camera.GetDeviceList().ToArray());
        }

        private void ViewCalibrationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SensorCalibrationModel SensorsCalib = query.GetLatestSensorsCalibration();

                // open sensor threshold page
                SensorsThresholdPage thresholdPage = new SensorsThresholdPage(SensorsCalib);
                thresholdPage.Show();
                Enabled = false;
                thresholdPage.FormClosed += (innerSender, innerE) =>
                {
                    Enabled = true;
                    thresholdPage.Dispose();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveCalibrationBtn_Click(object sender, EventArgs e)
        {
            SensorCalibrationModel calibVal = new SensorCalibrationModel
            {
                CalibrationDate = DateTime.Now,
                ThresholdVal = new Sensor
                {
                    UltrasonicSensorVal = Double.Parse(UltrasonicSensorValTxtBox.Text),
                    MethaneSensorVal = Double.Parse(MQ4SensorValTxtBox.Text),
                    AmmoniaSensorVal = Double.Parse(MQ135SensorValTxtBox.Text),
                }
            };

            // Display confirmation message and calibration data
            var confirm_save = MessageBox.Show(
                $"Depth Level Threshold : {calibVal.ThresholdVal.UltrasonicSensorVal} cm\n" +
                $"Methane Level Threshold : {calibVal.ThresholdVal.MethaneSensorVal} cm\n" +
                $"Ammonia Level Threshold : {calibVal.ThresholdVal.AmmoniaSensorVal} cm\n",
                "Calibration Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (confirm_save == DialogResult.No)
            {
                return;
            }

            try
            {
                query.PushSensorCalibration(calibVal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
