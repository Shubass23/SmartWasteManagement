namespace SmartWasteManagement.Main.View
{
    partial class RegisterUserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterUserPage));
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            LastNameTxtBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            FirstNameTxtBox = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            UserIDTxtBox = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label5 = new Label();
            PasswordTxtBox = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            CancelBtn = new Button();
            SaveBtn = new Button();
            ClearBtn = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0944214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.8755369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5965652F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5965652F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1673832F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7381973F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.93133044F));
            tableLayoutPanel1.Size = new Size(634, 444);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 3);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(217, 83);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 5;
            label1.Text = "User Register";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(LastNameTxtBox, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Controls.Add(FirstNameTxtBox, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(66, 131);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 46.7532463F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 53.2467537F));
            tableLayoutPanel2.Size = new Size(501, 72);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // LastNameTxtBox
            // 
            LastNameTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LastNameTxtBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTxtBox.Location = new Point(260, 36);
            LastNameTxtBox.Name = "LastNameTxtBox";
            LastNameTxtBox.PlaceholderText = "Eg. Max";
            LastNameTxtBox.Size = new Size(238, 31);
            LastNameTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 0;
            label2.Text = "First Name :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(412, 13);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 1;
            label3.Text = "Last Name :";
            // 
            // FirstNameTxtBox
            // 
            FirstNameTxtBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTxtBox.Location = new Point(3, 36);
            FirstNameTxtBox.Name = "FirstNameTxtBox";
            FirstNameTxtBox.PlaceholderText = "Eg. John";
            FirstNameTxtBox.Size = new Size(238, 31);
            FirstNameTxtBox.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(UserIDTxtBox, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(66, 209);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(501, 72);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 1;
            label4.Text = "User ID :";
            // 
            // UserIDTxtBox
            // 
            UserIDTxtBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            UserIDTxtBox.Location = new Point(3, 39);
            UserIDTxtBox.Name = "UserIDTxtBox";
            UserIDTxtBox.PlaceholderText = "Eg. 01234";
            UserIDTxtBox.Size = new Size(239, 31);
            UserIDTxtBox.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Controls.Add(PasswordTxtBox, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(66, 287);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(501, 70);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 15);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 1;
            label5.Text = "Password :";
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTxtBox.Location = new Point(3, 38);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PasswordChar = '*';
            PasswordTxtBox.Size = new Size(239, 31);
            PasswordTxtBox.TabIndex = 3;
            PasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.9594078F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.0405922F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 113F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111F));
            tableLayoutPanel5.Controls.Add(CancelBtn, 3, 1);
            tableLayoutPanel5.Controls.Add(SaveBtn, 2, 1);
            tableLayoutPanel5.Controls.Add(ClearBtn, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(66, 363);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel5.Size = new Size(501, 68);
            tableLayoutPanel5.TabIndex = 9;
            // 
            // CancelBtn
            // 
            CancelBtn.Dock = DockStyle.Fill;
            CancelBtn.Location = new Point(392, 22);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(106, 43);
            CancelBtn.TabIndex = 1;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Dock = DockStyle.Fill;
            SaveBtn.Location = new Point(279, 22);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(107, 43);
            SaveBtn.TabIndex = 0;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Dock = DockStyle.Fill;
            ClearBtn.Location = new Point(3, 22);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(107, 43);
            ClearBtn.TabIndex = 2;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(644, 454);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // RegisterUserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 454);
            Controls.Add(tableLayoutPanel6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterUserPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterUserPage";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox LastNameTxtBox;
        private Label label2;
        private Label label3;
        private TextBox FirstNameTxtBox;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox UserIDTxtBox;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox PasswordTxtBox;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel5;
        private Button SaveBtn;
        private Button CancelBtn;
        private Button ClearBtn;
        private TableLayoutPanel tableLayoutPanel6;
    }
}