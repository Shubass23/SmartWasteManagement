using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using SmartWasteManagement.Main.Vision;
using SmartWasteManagement.InferenceModel.Yolov5.App;
using Emgu.CV.Structure;
using Emgu.CV;
using SmartWasteManagement.Main.Database;
using SmartWasteManagement.Main.IoT;
using System.IO.Ports;
using SmartWasteManagement.Main.Database.Model;
using SmartWasteManagement.Main.Database.Query;
using SmartWasteManagement.InferenceModel.Yolov5.Scorer;
using Microsoft.Extensions.Logging.Abstractions;
using SmartWasteManagement.Main.Path;
using System.Diagnostics;
using System.Security;

namespace SmartWasteManagement.Main.View
{
    public partial class HomePage : Form
    {
        public Camera camera { get; set; }
        public MongoDBHandler db_handler { get; set; }
        public UserCredentialModel current_user { get; set; }
        public InspectionResultQuery inspection_query { get; set; }

        public HomePage(MongoDBHandler db_handler)
        {
            InitializeComponent();
            InitializeRandom();

            camera = new Camera();
            this.db_handler = db_handler;
            inspection_query = new InspectionResultQuery(db_handler);

            // Initiaize combo box
            string[] ports = SerialPort.GetPortNames();
            portComboBox.Items.AddRange(ports);
            portComboBox.SelectedIndex = 0;

            //Initialize arduino conection
            getArduinoConnection();
        }

        public void getArduinoConnection()
        {
            bool connectionStatus = Arduino.getConnection(portComboBox.SelectedItem.ToString(), 9600);
            if (connectionStatus)
            {
                int[] senso
            }
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to exit ?", "Quit Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Application.Exit();
                Close();
            }
        }

        public void InitializeRandom()
        {
            // Random bin level
            BinLevelLabel.Text = "10cm (50% Used)";
            BinLevelProgressBar.Value = 60;

            // Random Methane Gas Level
            MethaneLevelLabel.Text = "20.00 mm";
            MethaneGasProgressBar.Value = 20;

            // Random Ammonia Gas Level
            AmmoniaLevelLabel.Text = "50.00mm";
            AmmoniaGasProgressBar.Value = 40;
        }

        private void sensorsCalibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalibrationPage calibration = new CalibrationPage(camera, db_handler);
            calibration.Show();
            Enabled = false;
            calibration.FormClosed += (innerSender, innerE) =>
            {
                Enabled = true;
                calibration.Dispose();
            };
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current_user != null)
            {
                DialogResult = MessageBox.Show("Are you sure want to logout ?", "Attempt to logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    current_user = null;
                    logoutToolStripMenuItem.Text = "Login";
                    MessageBox.Show("User successfully logout of the system!", "Logout Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                LoginPage loginPage = new LoginPage(this, db_handler);
                loginPage.Show();
                Enabled = false;
                loginPage.FormClosed += (sender, e) =>
                {
                    Enabled = true;
                    loginPage.Dispose();
                };
            }
        }

        public void setLoggedInUser(UserCredentialModel LoggedInUser)
        {
            current_user = LoggedInUser;
            logoutToolStripMenuItem.Text = "Logout";
        }

        private void InspectionBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap;
            try
            {
                bitmap = camera.GrabImage(0).ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to capture image with the selected camera. Ensure the camera is available.", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                (Image inferenced_img, List<YoloPrediction> predictions) = YoloInference.DrawBoundingBox(bitmap);
                Bitmap final_bitmap = (Bitmap)inferenced_img;
                CapturedImagePicBox.Image = final_bitmap;

                foreach (YoloPrediction prediction in predictions)
                {
                    ResultDataGrid.Rows.Add(DateTime.Now, prediction.Label.Name);
                    InspectionResultLbl.Text = prediction.Label.Name;
                    inspection_query.AddResult(new InspectionResultModel(DateTime.Now, null, prediction.Label.Name));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Model failed to predict. Ensure that you have load the model correctly.", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void openInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(Filepath.reportPath))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        Arguments = Filepath.reportPath,
                        FileName = "explorer.exe",
                    };

                    Process.Start(startInfo);
                }
                else
                {
                    MessageBox.Show("Directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Access denied: {ex.Message}", "Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error: {ex.Message}", "Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutSmartWasteBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutPage aboutPage = new AboutPage();
            aboutPage.Show();
            Enabled = false;
            aboutPage.FormClosed += (sender, e) =>
            {
                Enabled = true;
                aboutPage.Dispose();
            };
        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportingPage reportPage = new ReportingPage(DateTime.Now.AddDays(-60), DateTime.Now, db_handler);
            reportPage.Show();
            Enabled = false;
            reportPage.FormClosed += (sender, e) =>
            {
                Enabled = true;
                reportPage.Dispose();
            };
        }

        private void viewLogReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SensorsLogPage sensorPage = new SensorsLogPage(DateTime.Now.AddDays(-60), DateTime.Now, db_handler);
            sensorPage.Show();
            Enabled = false;
            sensorPage.FormClosed += (sender, e) =>
            {
                Enabled = true;
                sensorPage.Dispose();
            };
        }

        private void portComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getArduinoConnection();
        }
    }
}


