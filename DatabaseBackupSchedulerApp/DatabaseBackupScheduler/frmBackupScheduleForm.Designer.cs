namespace DatabaseBackupScheduler
{
    partial class frmBackupScheduleForm
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
            txtName = new TextBox();
            lblName = new Label();
            label1 = new Label();
            txtConnectionString = new TextBox();
            label2 = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            cboDatabaseType = new ComboBox();
            label3 = new Label();
            txtDatabaseName = new TextBox();
            label4 = new Label();
            txtBackupPath = new TextBox();
            cboIsEnable = new ComboBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnBackupNow = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(30, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(412, 21);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.FromArgb(64, 64, 64);
            lblName.Location = new Point(30, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(98, 14);
            lblName.TabIndex = 1;
            lblName.Text = "Schedule Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(30, 119);
            label1.Name = "label1";
            label1.Size = new Size(110, 14);
            label1.TabIndex = 3;
            label1.Text = "Connection String";
            // 
            // txtConnectionString
            // 
            txtConnectionString.Location = new Point(30, 136);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.Size = new Size(412, 21);
            txtConnectionString.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(30, 71);
            label2.Name = "label2";
            label2.Size = new Size(96, 14);
            label2.TabIndex = 5;
            label2.Text = "Database Type";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // cboDatabaseType
            // 
            cboDatabaseType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDatabaseType.FormattingEnabled = true;
            cboDatabaseType.Items.AddRange(new object[] { "MY SQL", "MS SQL" });
            cboDatabaseType.Location = new Point(30, 88);
            cboDatabaseType.Name = "cboDatabaseType";
            cboDatabaseType.Size = new Size(412, 22);
            cboDatabaseType.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(30, 166);
            label3.Name = "label3";
            label3.Size = new Size(100, 14);
            label3.TabIndex = 8;
            label3.Text = "Database Name";
            // 
            // txtDatabaseName
            // 
            txtDatabaseName.Location = new Point(30, 183);
            txtDatabaseName.Name = "txtDatabaseName";
            txtDatabaseName.Size = new Size(412, 21);
            txtDatabaseName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(30, 213);
            label4.Name = "label4";
            label4.Size = new Size(81, 14);
            label4.TabIndex = 10;
            label4.Text = "Backup Path";
            // 
            // txtBackupPath
            // 
            txtBackupPath.Location = new Point(30, 230);
            txtBackupPath.Name = "txtBackupPath";
            txtBackupPath.Size = new Size(412, 21);
            txtBackupPath.TabIndex = 9;
            // 
            // cboIsEnable
            // 
            cboIsEnable.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIsEnable.FormattingEnabled = true;
            cboIsEnable.Items.AddRange(new object[] { "YES", "NO" });
            cboIsEnable.Location = new Point(30, 276);
            cboIsEnable.Name = "cboIsEnable";
            cboIsEnable.Size = new Size(412, 22);
            cboIsEnable.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(30, 259);
            label5.Name = "label5";
            label5.Size = new Size(68, 14);
            label5.TabIndex = 11;
            label5.Text = "Is Enable?";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(30, 319);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 10);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // btnBackupNow
            // 
            btnBackupNow.BackColor = Color.FromArgb(64, 64, 64);
            btnBackupNow.FlatAppearance.BorderColor = Color.White;
            btnBackupNow.FlatStyle = FlatStyle.Popup;
            btnBackupNow.ForeColor = Color.White;
            btnBackupNow.Location = new Point(236, 348);
            btnBackupNow.Margin = new Padding(3, 2, 3, 2);
            btnBackupNow.Name = "btnBackupNow";
            btnBackupNow.Size = new Size(207, 40);
            btnBackupNow.TabIndex = 14;
            btnBackupNow.Text = "SAVE BACKUP SCHEDULE";
            btnBackupNow.UseVisualStyleBackColor = false;
            btnBackupNow.Click += btnBackupNow_Click;
            // 
            // frmBackupScheduleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(470, 409);
            Controls.Add(btnBackupNow);
            Controls.Add(groupBox1);
            Controls.Add(cboIsEnable);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtBackupPath);
            Controls.Add(label3);
            Controls.Add(txtDatabaseName);
            Controls.Add(cboDatabaseType);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConnectionString);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBackupScheduleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GERTech: Backup Schedule Form";
            Load += frmBackupScheduleForm_Load;
            Shown += frmBackupScheduleForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private Label label1;
        private TextBox txtConnectionString;
        private Label label2;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private ComboBox cboDatabaseType;
        private Label label3;
        private TextBox txtDatabaseName;
        private Label label4;
        private TextBox txtBackupPath;
        private ComboBox cboIsEnable;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnBackupNow;
    }
}