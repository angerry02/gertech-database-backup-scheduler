using DatabaseBackupScheduler.Shared.Commons;
using DatabaseBackupScheduler.Shared.Entities;
using DatabaseBackupScheduler.Shared.Enums;
using DatabaseBackupScheduler.Shared.Services;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseBackupScheduler
{
    public partial class frmBackupScheduleForm : Form
    {
        private int ID { get; set; }

        public frmBackupScheduleForm(int iD = 0)
        {
            InitializeComponent();

            ID = iD;
        }

        private async void btnBackupNow_Click(object sender, EventArgs e)
        {
            BackupSchedule backupSchedule = new(ID,
                txtName.Text.Trim(),
                txtConnectionString.Text.Trim(),
                (cboDatabaseType.SelectedIndex == 0 ? DatabaseType.MYSQL : DatabaseType.MSSQL),
                (cboIsEnable.SelectedIndex == 0),
                txtDatabaseName.Text.Trim(),
                txtBackupPath.Text.Trim());

            if (!IsOk2Save(backupSchedule))
                return;

            try
            {
                await BackupScheduleService.SaveBackupSchedule(backupSchedule);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save backup schedule. Error: {ex.Message}");
            }
        }

        private bool IsOk2Save(BackupSchedule backupSchedule)
        {
            List<string> errorLs = new();

            if (string.IsNullOrEmpty(backupSchedule.Name))
                errorLs.Add("Please set the schedule name.");

            if (string.IsNullOrEmpty(backupSchedule.ConnectionString))
                errorLs.Add("Please set the connection string.");

            if (string.IsNullOrEmpty(backupSchedule.DatabaseName))
                errorLs.Add("Please set the database name.");

            if (string.IsNullOrEmpty(backupSchedule.BackupPath))
                errorLs.Add("Please set the backup path.");

            if (errorLs.Any())
            {
                string messages = FunctionHelper.ErrorStringBuilder(Constants.AppMessages.MESSAGE_BULK_ERROR,
                    FunctionHelper.ErrorListToStringBuilder(errorLs));

                MessageBox.Show(messages);

                return false;
            }

            return true;
        }

        private void frmBackupScheduleForm_Load(object sender, EventArgs e)
        {

        }

        private async void frmBackupScheduleForm_Shown(object sender, EventArgs e)
        {
            if(ID > 0)
            {
                BackupSchedule? backupSchedule = await BackupScheduleService.GetBackupById(ID);

                if (backupSchedule == null)
                    return;

                txtName.Text = backupSchedule.Name;
                txtConnectionString.Text = backupSchedule.ConnectionString;
                cboDatabaseType.SelectedIndex = backupSchedule.DatabaseType == DatabaseType.MYSQL ?
                    0 : 1;
                cboIsEnable.SelectedIndex = backupSchedule.IsEnabled ?
                    0 : 1;
                txtDatabaseName.Text = backupSchedule.DatabaseName;
                txtBackupPath.Text = backupSchedule.BackupPath;
            }
        }
    }
}
