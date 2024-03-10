using ClosedXML.Excel;
using ScottPlot;
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
using Orientation = ScottPlot.Orientation;

namespace SmartWasteManagement.Main.View
{
    public partial class ReportingPage : Form
    {
        public InspectionResultQuery inspectionQuery;
        public DateTime startDate;
        public DateTime endDate;
        public Dictionary<string, int> wastesCount = new Dictionary<string, int>() {
            {"Paper", 0},
            {"Cardboard" , 0},
            {"Plastic", 0},
            {"Glass", 0},
            {"Metal", 0},
            {"Biodegradable", 0}
        };

        public ReportingPage(DateTime startDate, DateTime endDate, MongoDBHandler dbHandler)
        {
            InitializeComponent();
            this.startDate = startDate;
            this.endDate = endDate;
            this.inspectionQuery = new InspectionResultQuery(dbHandler);
            startDatePicker.Value = startDate;
            endDatePicker.Value = endDate;

            getWasteData();
        }

        public void getWasteData()
        {
            List<InspectionResultModel> inspectionResults = inspectionQuery.GetResultListByDate(startDate, endDate);
            if (inspectionResults.Count == 0)
            {
                MessageBox.Show("No results found within the specified timeframe.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            displayInspectionCounts(inspectionResults);
            displayChart(inspectionResults);
        }

        public void displayChart(List<InspectionResultModel> inspectionResults)
        {
            double[] x_vals = inspectionResults.Select(x => x.CreatedDate.Value.Date.ToOADate()).ToArray();

            // 0 - Paper, 1 - Cardboard, 2 - Plastic, 3 - Glass, 4 - Metal, 5 - Biodegradable
            double[,] y_vals = new double[6, x_vals.Length];

            for (int i = 0; i < x_vals.Length; i++)
            {
                for (int j = 0; j < inspectionResults.Count; j++)
                {
                    if (x_vals[i] == inspectionResults[j].CreatedDate.Value.Date.ToOADate())
                    {
                        if (inspectionResults[j].Result == "PAPER") y_vals[0, i] += 1;
                        if (inspectionResults[j].Result == "CARDBOARD") y_vals[1, i] += 1;
                        if (inspectionResults[j].Result == "PLASTIC") y_vals[2, i] += 1;
                        if (inspectionResults[j].Result == "GLASS") y_vals[3, i] += 1;
                        if (inspectionResults[j].Result == "METAL") y_vals[4, i] += 1;
                        if (inspectionResults[j].Result == "BIODEGRADABLE") y_vals[5, i] += 1;
                    }
                }
            }

            wasteChart.Plot.AddScatter(x_vals, Enumerable.Range(0, y_vals.GetLength(1)).Select(x => y_vals[0, x]).ToArray(), label: "Paper");
            wasteChart.Plot.AddScatter(x_vals, Enumerable.Range(0, y_vals.GetLength(1)).Select(x => y_vals[1, x]).ToArray(), label: "Cardboard");
            wasteChart.Plot.AddScatter(x_vals, Enumerable.Range(0, y_vals.GetLength(1)).Select(x => y_vals[2, x]).ToArray(), label: "Plastic");
            wasteChart.Plot.AddScatter(x_vals, Enumerable.Range(0, y_vals.GetLength(1)).Select(x => y_vals[3, x]).ToArray(), label: "Glass");
            wasteChart.Plot.AddScatter(x_vals, Enumerable.Range(0, y_vals.GetLength(1)).Select(x => y_vals[4, x]).ToArray(), label: "Metal");
            wasteChart.Plot.AddScatter(x_vals, Enumerable.Range(0, y_vals.GetLength(1)).Select(x => y_vals[5, x]).ToArray(), label: "Trash");

            // indicate the horizontal axis tick labels should display DateTime units
            wasteChart.Plot.XAxis.DateTimeFormat(true);

            // Set title and legend
            wasteChart.Plot.Title("Number of Waste Inspected According to its Type");
            var legend = wasteChart.Plot.Legend(enable: true);
            legend.Orientation = Orientation.Horizontal;
            legend.Location = Alignment.UpperCenter;

            if (x_vals.Count() != 0)
            {
                wasteChart.Refresh();
            }
            else
            {
                wasteChart.Reset();
                wasteChart.Refresh();
                MessageBox.Show("Clear");
            }
        }

        public void displayInspectionCounts(List<InspectionResultModel> inspectionResults)
        {
            foreach (string wasteType in wastesCount.Keys)
            {
                wastesCount[wasteType] = 0;
            }

            foreach (InspectionResultModel inspectionResult in inspectionResults)
            {
                string wasteType = inspectionResult.Result[0].ToString().ToUpper() + inspectionResult.Result.Substring(1).ToLower();
                wastesCount[wasteType] += 1;
            }

            PaperCountLabel.Text = wastesCount["Paper"].ToString();
            CardboardCountLabel.Text = wastesCount["Cardboard"].ToString();
            PlasticCountLabel.Text = wastesCount["Plastic"].ToString();
            GlassCountLabel.Text = wastesCount["Glass"].ToString();
            MetalCountLabel.Text = wastesCount["Metal"].ToString();
            TrashCountLabel.Text = wastesCount["Biodegradable"].ToString();
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

            getWasteData();
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string originalFilePath = Filepath.inspectionTemplatePath;
                string newFilePath = Filepath.reportPath + $"\\Inspection Report {startDate.ToString("dddd, dd MMMM yyyy")}.xlsx";

                // Load the existing Excel file
                using (var workbook = new XLWorkbook(originalFilePath))
                {
                    // Get the first worksheet
                    var worksheet = workbook.Worksheet(1);

                    // Add data to the worksheet
                    worksheet.Cell("C3").Value = startDate.ToString("dddd, dd MMMM yyyy");
                    worksheet.Cell("C4").Value = endDate.ToString("dddd, dd MMMM yyyy");
                    worksheet.Cell("E7").Value = wastesCount["Plastic"].ToString();
                    worksheet.Cell("E8").Value = wastesCount["Cardboard"].ToString();
                    worksheet.Cell("E9").Value = wastesCount["Paper"].ToString();
                    worksheet.Cell("E10").Value = wastesCount["Glass"].ToString();
                    worksheet.Cell("E11").Value = wastesCount["Metal"].ToString();
                    worksheet.Cell("E12").Value = wastesCount["Biodegradable"].ToString();
                    worksheet.Cell("E13").Value = wastesCount.Sum(x => x.Value);

                    // Save the workbook as a new file
                    workbook.SaveAs(newFilePath);
                }
                MessageBox.Show("Report successfully export!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
