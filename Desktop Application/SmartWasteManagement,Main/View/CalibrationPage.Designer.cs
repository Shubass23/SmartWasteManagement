namespace SmartWasteManagement.Main.View
{
    partial class CalibrationPage
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            ViewCalibrationBtn = new Button();
            SaveCalibrationBtn = new Button();
            CameraComboBox = new ComboBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label10 = new Label();
            UltrasonicSensorValTxtBox = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            label11 = new Label();
            MQ4SensorValTxtBox = new TextBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            label12 = new Label();
            MQ135SensorValTxtBox = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label8 = new Label();
            textBox2 = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label9 = new Label();
            textBox5 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4160585F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.9416046F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.82481754F));
            tableLayoutPanel1.Size = new Size(947, 548);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(226, 17);
            label1.Name = "label1";
            label1.Size = new Size(494, 43);
            label1.TabIndex = 0;
            label1.Text = "SENSORS CALIBRATION";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.00375F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.83895135F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.1573029F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(label6, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 2, 4);
            tableLayoutPanel2.Controls.Add(CameraComboBox, 2, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 2, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel8, 2, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel9, 2, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 81);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.4819279F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.4819279F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.4819279F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.4819279F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.0722885F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(941, 453);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(334, 30);
            label2.Name = "label2";
            label2.Size = new Size(105, 31);
            label2.TabIndex = 0;
            label2.Text = "Camera :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(145, 122);
            label4.Name = "label4";
            label4.Size = new Size(294, 31);
            label4.TabIndex = 2;
            label4.Text = "Ultrasonic Sensor (Depth) :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(172, 214);
            label5.Name = "label5";
            label5.Size = new Size(267, 31);
            label5.TabIndex = 3;
            label5.Text = "MQ4 Sensor (Methane) :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(135, 306);
            label6.Name = "label6";
            label6.Size = new Size(304, 31);
            label6.TabIndex = 4;
            label6.Text = "MQ 135 Sensor (Ammonia) :";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.8452F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.1548F));
            tableLayoutPanel3.Controls.Add(ViewCalibrationBtn, 0, 0);
            tableLayoutPanel3.Controls.Add(SaveCalibrationBtn, 1, 0);
            tableLayoutPanel3.Location = new Point(615, 371);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(323, 79);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // ViewCalibrationBtn
            // 
            ViewCalibrationBtn.Dock = DockStyle.Fill;
            ViewCalibrationBtn.Location = new Point(3, 3);
            ViewCalibrationBtn.Name = "ViewCalibrationBtn";
            ViewCalibrationBtn.Size = new Size(154, 73);
            ViewCalibrationBtn.TabIndex = 0;
            ViewCalibrationBtn.Text = "View Calibrations";
            ViewCalibrationBtn.UseVisualStyleBackColor = true;
            ViewCalibrationBtn.Click += ViewCalibrationBtn_Click;
            // 
            // SaveCalibrationBtn
            // 
            SaveCalibrationBtn.Dock = DockStyle.Fill;
            SaveCalibrationBtn.Location = new Point(163, 3);
            SaveCalibrationBtn.Name = "SaveCalibrationBtn";
            SaveCalibrationBtn.Size = new Size(157, 73);
            SaveCalibrationBtn.TabIndex = 1;
            SaveCalibrationBtn.Text = "Save Calibrations";
            SaveCalibrationBtn.UseVisualStyleBackColor = true;
            SaveCalibrationBtn.Click += SaveCalibrationBtn_Click;
            // 
            // CameraComboBox
            // 
            CameraComboBox.Anchor = AnchorStyles.Left;
            CameraComboBox.FormattingEnabled = true;
            CameraComboBox.Location = new Point(481, 32);
            CameraComboBox.Name = "CameraComboBox";
            CameraComboBox.Size = new Size(235, 28);
            CameraComboBox.TabIndex = 10;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Left;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31F));
            tableLayoutPanel7.Controls.Add(label10, 1, 0);
            tableLayoutPanel7.Controls.Add(UltrasonicSensorValTxtBox, 0, 0);
            tableLayoutPanel7.Location = new Point(481, 121);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(236, 34);
            tableLayoutPanel7.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(165, 0);
            label10.Name = "label10";
            label10.Size = new Size(68, 34);
            label10.TabIndex = 1;
            label10.Text = "cm";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UltrasonicSensorValTxtBox
            // 
            UltrasonicSensorValTxtBox.Dock = DockStyle.Fill;
            UltrasonicSensorValTxtBox.Location = new Point(3, 3);
            UltrasonicSensorValTxtBox.Name = "UltrasonicSensorValTxtBox";
            UltrasonicSensorValTxtBox.Size = new Size(156, 27);
            UltrasonicSensorValTxtBox.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.Left;
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31F));
            tableLayoutPanel8.Controls.Add(label11, 1, 0);
            tableLayoutPanel8.Controls.Add(MQ4SensorValTxtBox, 0, 0);
            tableLayoutPanel8.Location = new Point(481, 213);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(236, 34);
            tableLayoutPanel8.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(165, 0);
            label11.Name = "label11";
            label11.Size = new Size(68, 34);
            label11.TabIndex = 0;
            label11.Text = "ppm";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MQ4SensorValTxtBox
            // 
            MQ4SensorValTxtBox.Dock = DockStyle.Fill;
            MQ4SensorValTxtBox.Location = new Point(3, 3);
            MQ4SensorValTxtBox.Name = "MQ4SensorValTxtBox";
            MQ4SensorValTxtBox.Size = new Size(156, 27);
            MQ4SensorValTxtBox.TabIndex = 14;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = AnchorStyles.Left;
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31F));
            tableLayoutPanel9.Controls.Add(label12, 1, 0);
            tableLayoutPanel9.Controls.Add(MQ135SensorValTxtBox, 0, 0);
            tableLayoutPanel9.Location = new Point(481, 305);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(236, 34);
            tableLayoutPanel9.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(165, 0);
            label12.Name = "label12";
            label12.Size = new Size(68, 34);
            label12.TabIndex = 1;
            label12.Text = "ppm";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MQ135SensorValTxtBox
            // 
            MQ135SensorValTxtBox.Dock = DockStyle.Fill;
            MQ135SensorValTxtBox.Location = new Point(3, 3);
            MQ135SensorValTxtBox.Name = "MQ135SensorValTxtBox";
            MQ135SensorValTxtBox.Size = new Size(156, 27);
            MQ135SensorValTxtBox.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Left;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.0677948F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.9322033F));
            tableLayoutPanel5.Controls.Add(label8, 1, 0);
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(141, 0);
            label8.Name = "label8";
            label8.Size = new Size(56, 100);
            label8.TabIndex = 0;
            label8.Text = "cm";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 27);
            textBox2.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Left;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.0677948F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.9322033F));
            tableLayoutPanel6.Controls.Add(label9, 1, 0);
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(141, 0);
            label9.Name = "label9";
            label9.Size = new Size(56, 100);
            label9.TabIndex = 0;
            label9.Text = "CM";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Fill;
            textBox5.Location = new Point(3, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(132, 27);
            textBox5.TabIndex = 1;
            // 
            // CalibrationPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 548);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CalibrationPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalibrationPage";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox CameraComboBox;
        private Button ViewCalibrationBtn;
        private Button SaveCalibrationBtn;
        private TextBox MQ4SensorValTxtBox;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label8;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
        private TextBox UltrasonicSensorValTxtBox;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label12;
        private TextBox MQ135SensorValTxtBox;
    }
}