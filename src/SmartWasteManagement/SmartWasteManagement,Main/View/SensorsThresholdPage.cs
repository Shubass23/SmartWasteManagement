using SmartWasteManagement.Main.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWasteManagement.Main.View
{
    public partial class SensorsThresholdPage : Form
    {
        SensorCalibrationModel SensorsCalib { get; set; }
        public SensorsThresholdPage(SensorCalibrationModel SensorsCalib)
        {
            this.SensorsCalib = SensorsCalib;

            InitializeComponent();
            DisplayThresholdReadings();
        }

        public void DisplayThresholdReadings()
        {
            if (SensorsCalib != null)
            {
                Ultrasonic2Label.Text = SensorsCalib.ThresholdVal.UltrasonicSensorVal.ToString();
                MQ4Label.Text = SensorsCalib.ThresholdVal.MethaneSensorVal.ToString();
                MQ135Label.Text = SensorsCalib.ThresholdVal.AmmoniaSensorVal.ToString();
            }
            else
            {
                DialogResult res = MessageBox.Show("No sensors calibration found", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
