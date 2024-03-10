namespace SmartWasteManagement.Main.View
{
    partial class ReportingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportingPage));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            ExportBtn = new Button();
            wasteChart = new ScottPlot.FormsPlot();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label4 = new Label();
            PaperCountLabel = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            label6 = new Label();
            CardboardCountLabel = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            label8 = new Label();
            PlasticCountLabel = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            label10 = new Label();
            MetalCountLabel = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            label12 = new Label();
            GlassCountLabel = new Label();
            tableLayoutPanel12 = new TableLayoutPanel();
            label14 = new Label();
            TrashCountLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            startDatePicker = new DateTimePicker();
            label3 = new Label();
            endDatePicker = new DateTimePicker();
            ShowBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 5);
            tableLayoutPanel1.Controls.Add(wasteChart, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.524272F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.625606F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.141658F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.6873F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.45645332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.19097567F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.30220366F));
            tableLayoutPanel1.Size = new Size(1363, 953);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            label1.Location = new Point(575, 81);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 5;
            label1.Text = "Inspection Log";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 3);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(475, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.53061F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.4693871F));
            tableLayoutPanel4.Controls.Add(ExportBtn, 0, 0);
            tableLayoutPanel4.Location = new Point(1164, 854);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(196, 53);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // ExportBtn
            // 
            ExportBtn.Dock = DockStyle.Fill;
            ExportBtn.Location = new Point(3, 3);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(143, 47);
            ExportBtn.TabIndex = 0;
            ExportBtn.Text = "Export";
            ExportBtn.UseVisualStyleBackColor = true;
            ExportBtn.Click += ExportBtn_Click;
            // 
            // wasteChart
            // 
            wasteChart.Dock = DockStyle.Fill;
            wasteChart.Location = new Point(5, 177);
            wasteChart.Margin = new Padding(5, 4, 5, 4);
            wasteChart.Name = "wasteChart";
            wasteChart.Size = new Size(1353, 618);
            wasteChart.TabIndex = 9;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 6;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel8, 1, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel9, 2, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel10, 3, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel11, 4, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel12, 5, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 802);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1357, 46);
            tableLayoutPanel6.TabIndex = 10;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(label4, 0, 0);
            tableLayoutPanel7.Controls.Add(PaperCountLabel, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(220, 40);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 40);
            label4.TabIndex = 0;
            label4.Text = "Paper : ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PaperCountLabel
            // 
            PaperCountLabel.AutoSize = true;
            PaperCountLabel.Dock = DockStyle.Fill;
            PaperCountLabel.Location = new Point(113, 0);
            PaperCountLabel.Name = "PaperCountLabel";
            PaperCountLabel.Size = new Size(104, 40);
            PaperCountLabel.TabIndex = 1;
            PaperCountLabel.Text = "0";
            PaperCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(label6, 0, 0);
            tableLayoutPanel8.Controls.Add(CardboardCountLabel, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(229, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(220, 40);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 40);
            label6.TabIndex = 0;
            label6.Text = "Cardboard :";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CardboardCountLabel
            // 
            CardboardCountLabel.AutoSize = true;
            CardboardCountLabel.Dock = DockStyle.Fill;
            CardboardCountLabel.Location = new Point(113, 0);
            CardboardCountLabel.Name = "CardboardCountLabel";
            CardboardCountLabel.Size = new Size(104, 40);
            CardboardCountLabel.TabIndex = 1;
            CardboardCountLabel.Text = "0";
            CardboardCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(label8, 0, 0);
            tableLayoutPanel9.Controls.Add(PlasticCountLabel, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(455, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(220, 40);
            tableLayoutPanel9.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(104, 40);
            label8.TabIndex = 0;
            label8.Text = "Plastic : ";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PlasticCountLabel
            // 
            PlasticCountLabel.AutoSize = true;
            PlasticCountLabel.Dock = DockStyle.Fill;
            PlasticCountLabel.Location = new Point(113, 0);
            PlasticCountLabel.Name = "PlasticCountLabel";
            PlasticCountLabel.Size = new Size(104, 40);
            PlasticCountLabel.TabIndex = 1;
            PlasticCountLabel.Text = "0";
            PlasticCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(label10, 0, 0);
            tableLayoutPanel10.Controls.Add(MetalCountLabel, 1, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(681, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(220, 40);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(104, 40);
            label10.TabIndex = 0;
            label10.Text = "Metal : ";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MetalCountLabel
            // 
            MetalCountLabel.AutoSize = true;
            MetalCountLabel.Dock = DockStyle.Fill;
            MetalCountLabel.Location = new Point(113, 0);
            MetalCountLabel.Name = "MetalCountLabel";
            MetalCountLabel.Size = new Size(104, 40);
            MetalCountLabel.TabIndex = 1;
            MetalCountLabel.Text = "0";
            MetalCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(label12, 0, 0);
            tableLayoutPanel11.Controls.Add(GlassCountLabel, 1, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(907, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(220, 40);
            tableLayoutPanel11.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(104, 40);
            label12.TabIndex = 0;
            label12.Text = "Glass : ";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // GlassCountLabel
            // 
            GlassCountLabel.AutoSize = true;
            GlassCountLabel.Dock = DockStyle.Fill;
            GlassCountLabel.Location = new Point(113, 0);
            GlassCountLabel.Name = "GlassCountLabel";
            GlassCountLabel.Size = new Size(104, 40);
            GlassCountLabel.TabIndex = 1;
            GlassCountLabel.Text = "0";
            GlassCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(label14, 0, 0);
            tableLayoutPanel12.Controls.Add(TrashCountLabel, 1, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(1133, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(221, 40);
            tableLayoutPanel12.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(104, 40);
            label14.TabIndex = 0;
            label14.Text = "Trash : ";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TrashCountLabel
            // 
            TrashCountLabel.AutoSize = true;
            TrashCountLabel.Dock = DockStyle.Fill;
            TrashCountLabel.Location = new Point(113, 0);
            TrashCountLabel.Name = "TrashCountLabel";
            TrashCountLabel.Size = new Size(105, 40);
            TrashCountLabel.TabIndex = 1;
            TrashCountLabel.Text = "0";
            TrashCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.50552678F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0854826F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.7074432F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.210759F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.854826F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.5895357F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.56227F));
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(startDatePicker, 2, 0);
            tableLayoutPanel2.Controls.Add(label3, 3, 0);
            tableLayoutPanel2.Controls.Add(endDatePicker, 4, 0);
            tableLayoutPanel2.Controls.Add(ShowBtn, 6, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 127);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1357, 43);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(36, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 43);
            label2.TabIndex = 0;
            label2.Text = "Choose Date Range : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startDatePicker
            // 
            startDatePicker.Dock = DockStyle.Fill;
            startDatePicker.Location = new Point(199, 3);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(273, 27);
            startDatePicker.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(478, 0);
            label3.Name = "label3";
            label3.Size = new Size(23, 43);
            label3.TabIndex = 2;
            label3.Text = "-";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(507, 3);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(275, 27);
            endDatePicker.TabIndex = 3;
            // 
            // ShowBtn
            // 
            ShowBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ShowBtn.Location = new Point(795, 3);
            ShowBtn.Name = "ShowBtn";
            ShowBtn.Size = new Size(94, 37);
            ShowBtn.TabIndex = 4;
            ShowBtn.Text = "Show";
            ShowBtn.UseVisualStyleBackColor = true;
            ShowBtn.Click += ShowBtn_Click;
            // 
            // ReportingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 953);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReportingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportingPage";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private Button ExportBtn;
        private ScottPlot.FormsPlot wasteChart;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label4;
        private Label PaperCountLabel;
        private Label label6;
        private Label CardboardCountLabel;
        private Label label8;
        private Label PlasticCountLabel;
        private Label label10;
        private Label MetalCountLabel;
        private Label label12;
        private Label GlassCountLabel;
        private Label label14;
        private Label TrashCountLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private DateTimePicker startDatePicker;
        private Label label3;
        private DateTimePicker endDatePicker;
        private Button ShowBtn;
    }
}