namespace DatabaseBackupScheduler
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBackupNow = new Button();
            lvSchedules = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBackupNow
            // 
            btnBackupNow.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBackupNow.BackColor = Color.FromArgb(64, 64, 64);
            btnBackupNow.FlatAppearance.BorderColor = Color.White;
            btnBackupNow.FlatStyle = FlatStyle.Popup;
            btnBackupNow.ForeColor = Color.White;
            btnBackupNow.Location = new Point(388, 498);
            btnBackupNow.Margin = new Padding(3, 2, 3, 2);
            btnBackupNow.Name = "btnBackupNow";
            btnBackupNow.Size = new Size(183, 40);
            btnBackupNow.TabIndex = 0;
            btnBackupNow.Text = "RUN BACKUP NOW";
            btnBackupNow.UseVisualStyleBackColor = false;
            btnBackupNow.Click += btnBackupNow_Click;
            // 
            // lvSchedules
            // 
            lvSchedules.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvSchedules.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvSchedules.FullRowSelect = true;
            lvSchedules.GridLines = true;
            lvSchedules.Location = new Point(25, 119);
            lvSchedules.Name = "lvSchedules";
            lvSchedules.Size = new Size(546, 354);
            lvSchedules.TabIndex = 1;
            lvSchedules.UseCompatibleStateImageBehavior = false;
            lvSchedules.View = View.Details;
            lvSchedules.MouseDoubleClick += lvSchedules_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "No.";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Type";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Enable";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Last Run";
            columnHeader5.Width = 250;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Id";
            columnHeader6.Width = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 91);
            label1.Name = "label1";
            label1.Size = new Size(546, 29);
            label1.TabIndex = 2;
            label1.Text = "Schedules";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Location = new Point(24, 479);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(548, 10);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(131, 12);
            label2.Name = "label2";
            label2.Size = new Size(321, 18);
            label2.TabIndex = 5;
            label2.Text = "GERTech: Database Backup Scheduler";
            // 
            // label3
            // 
            label3.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(131, 39);
            label3.Name = "label3";
            label3.Size = new Size(425, 28);
            label3.TabIndex = 6;
            label3.Text = "Automate and secure your database backups with flexible scheduling and encryption.\n\n\n\n\n\n\n";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.ForeColor = Color.FromArgb(64, 64, 64);
            btnAdd.Location = new Point(24, 498);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(71, 40);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.LOGO;
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(602, 559);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(lvSchedules);
            Controls.Add(btnBackupNow);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GERTech: Database Backup Scheduler v1.0.0.0";
            Load += Main_Load;
            Shown += Main_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackupNow;
        private ListView lvSchedules;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private PictureBox pictureBox1;
    }
}
