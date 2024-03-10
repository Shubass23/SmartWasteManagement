namespace SmartWasteManagement.Main.View
{
    partial class SensorsLogPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SensorsLogPage));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            startDatePicker = new DateTimePicker();
            label3 = new Label();
            endDatePicker = new DateTimePicker();
            ShowBtn = new Button();
            SensorsGridView = new DataGridView();
            DatetimeCol = new DataGridViewTextBoxColumn();
            DepthCol = new DataGridViewTextBoxColumn();
            MethaneCol = new DataGridViewTextBoxColumn();
            AmmoniaCol = new DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            ExportBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SensorsGridView).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(SensorsGridView, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.524272F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.886518F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.263158F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.25456F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.8592911F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.292352F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1363, 953);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            label1.Location = new Point(528, 86);
            label1.Name = "label1";
            label1.Size = new Size(306, 32);
            label1.TabIndex = 5;
            label1.Text = "Sensors Reading Log";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 3);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(475, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
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
            tableLayoutPanel2.Location = new Point(3, 137);
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
            // SensorsGridView
            // 
            SensorsGridView.AllowUserToAddRows = false;
            SensorsGridView.AllowUserToDeleteRows = false;
            SensorsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SensorsGridView.Columns.AddRange(new DataGridViewColumn[] { DatetimeCol, DepthCol, MethaneCol, AmmoniaCol });
            SensorsGridView.Dock = DockStyle.Fill;
            SensorsGridView.Location = new Point(3, 186);
            SensorsGridView.Name = "SensorsGridView";
            SensorsGridView.ReadOnly = true;
            SensorsGridView.RowHeadersWidth = 51;
            SensorsGridView.RowTemplate.Height = 29;
            SensorsGridView.Size = new Size(1357, 676);
            SensorsGridView.TabIndex = 12;
            // 
            // DatetimeCol
            // 
            DatetimeCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatetimeCol.HeaderText = "DateTime";
            DatetimeCol.MinimumWidth = 6;
            DatetimeCol.Name = "DatetimeCol";
            DatetimeCol.ReadOnly = true;
            // 
            // DepthCol
            // 
            DepthCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DepthCol.HeaderText = "Ultrasonic Sensor (Depth)";
            DepthCol.MinimumWidth = 6;
            DepthCol.Name = "DepthCol";
            DepthCol.ReadOnly = true;
            // 
            // MethaneCol
            // 
            MethaneCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MethaneCol.HeaderText = "MQ4 Sensor (Methane)";
            MethaneCol.MinimumWidth = 6;
            MethaneCol.Name = "MethaneCol";
            MethaneCol.ReadOnly = true;
            // 
            // AmmoniaCol
            // 
            AmmoniaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AmmoniaCol.HeaderText = "MQ135 Sensor (Ammonia)";
            AmmoniaCol.MinimumWidth = 6;
            AmmoniaCol.Name = "AmmoniaCol";
            AmmoniaCol.ReadOnly = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.53061F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.4693871F));
            tableLayoutPanel4.Controls.Add(ExportBtn, 0, 0);
            tableLayoutPanel4.Location = new Point(1164, 876);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(196, 52);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // ExportBtn
            // 
            ExportBtn.Dock = DockStyle.Fill;
            ExportBtn.Location = new Point(3, 3);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(143, 46);
            ExportBtn.TabIndex = 0;
            ExportBtn.Text = "Export";
            ExportBtn.UseVisualStyleBackColor = true;
            ExportBtn.Click += ExportBtn_Click;
            // 
            // SensorsLogPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 953);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SensorsLogPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SensorsLogPage";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SensorsGridView).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private Button ExportBtn;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private DateTimePicker startDatePicker;
        private Label label3;
        private DateTimePicker endDatePicker;
        private Button ShowBtn;
        private DataGridView SensorsGridView;
        private DataGridViewTextBoxColumn DatetimeCol;
        private DataGridViewTextBoxColumn DepthCol;
        private DataGridViewTextBoxColumn MethaneCol;
        private DataGridViewTextBoxColumn AmmoniaCol;
    }
}