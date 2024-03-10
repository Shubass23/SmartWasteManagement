using ClosedXML.Excel;
using SmartWasteManagement.Main.Database;
using SmartWasteManagement.Main.Database.Model;
using SmartWasteManagement.Main.Database.Query;
using SmartWasteManagement.Main.Path;
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
    public partial class SensorsLogPage : Form
    {
        public SensorsReadingQuery sensorReadingQuery;
        public List<SensorsReadingModel> sensorReadingResults;
        public DateTime startDate;
        public DateTime endDate;

        public SensorsLogPage(DateTime startDate, DateTime endDate, MongoDBHandler dbHandler)
        {
            InitializeComponent();
            this.startDate = startDate;
            this.endDate = endDate;
            this.sensorReadingQuery = new SensorsReadingQuery(dbHandler);

            getSensorsReadingData();
        }

        public void getSensorsReadingData()
        {
            sensorReadingResults = sensorReadingQuery.GetResultListByDate(startDate, endDate);
            if (sensorReadingResults.Count == 0)
            {
                MessageBox.Show("No results found within the specified timeframe.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            displaySensorsReading(sensorReadingResults);
        }

        public void displaySensorsReading(List<SensorsReadingModel> sensorReadingResults)
        {
            for (int i = 0; i < sensorReadingResults.Count; i++)
            {
                SensorsGridView.Rows.Add(sensorReadingResults[i].CreatedDate, sensorReadingResults[i].Reading.UltrasonicSensorVal, sensorReadingResults[i].Reading.MethaneSensorVal, sensorReadingResults[i].Reading.AmmoniaSensorVal);
            }
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string originalFilePath = Filepath.logTemplatePath;
                string newFilePath = Filepath.reportPath + $"\\Log Report {startDate.ToString("dddd, dd MMMM yyyy")}.xlsx";

                // Load the existing Excel file
                using (var workbook = new XLWorkbook(originalFilePath))
                {
                    // Get the first worksheet
                    var worksheet = workbook.Worksheet(1);

                    // Add data to the worksheet
                    worksheet.Cell("C3").Value = startDate.ToString("dddd, dd MMMM yyyy");
                    worksheet.Cell("C4").Value = endDate.ToString("dddd, dd MMMM yyyy");

                    for (int i = 0; i < sensorReadingResults.Count; i++)
                    {
                        worksheet.Cell($"A{i + 8}").Value = sensorReadingResults[i].CreatedDate.ToString("MM/dd/yyyy HH:mm:ss");
                        worksheet.Range($"A{i + 8}:B{i + 8}").Row(1).Merge();
                        worksheet.Cell($"C{i + 8}").Value = sensorReadingResults[i].Reading.UltrasonicSensorVal;
                        worksheet.Range($"C{i + 8}:D{i + 8}").Row(1).Merge();
                        worksheet.Cell($"E{i + 8}").Value = sensorReadingResults[i].Reading.MethaneSensorVal;
                        worksheet.Range($"E{i + 8}:F{i + 8}").Row(1).Merge();
                        worksheet.Cell($"G{i + 8}").Value = sensorReadingResults[i].Reading.AmmoniaSensorVal;
                        worksheet.Range($"G{i + 8}:H{i + 8}").Row(1).Merge();
                    }

                    // Save the workbook as a new file
                    workbook.SaveAs(newFilePath);

                    MessageBox.Show("Report successfully export!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            DateTime startDatePickerValue = startDatePicker.Value.Date;
            DateTime endDatePickerValue = endDatePicker.Value.Date.AddHours(23).AddMinutes(59);

            if (startDatePickerValue > endDatePickerValue)
            {
                MessageBox.Show("Pick a correct time. Make sure the end date is after start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            startDate = startDatePickerValue;
            endDate = endDatePickerValue;

            getSensorsReadingData();
        }
    }
}
