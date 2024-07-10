using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupScheduler.Execute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BackupSchedule
            //try
            //{
            //    List< BackupSchedule >
            //    foreach (ListViewItem item in lvSchedules.Items)
            //    {
            //        int Id = int.Parse(item.SubItems[(int)Columns.ID].Text);

            //        BackupSchedule? backupSchedule = BackupSchedules.FirstOrDefault(s => s.Id == Id);

            //        item.SubItems[(int)Columns.LAST_RUN].Text = "Start backing up...";
            //        string result = await Task.Run(() => BackupDatabaseService.BackupScheduledDatabase(backupSchedule));

            //        item.SubItems[(int)Columns.LAST_RUN].Text = result;

            //        backupSchedule.SetLastResult(result);

            //        await BackupScheduleService.SaveBackupSchedule(backupSchedule);
            //    }

            //    MessageBox.Show($"Done executing all backup schedules.",
            //        "Success",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error encountered during executing backup schedule. Details: {ex.Message}",
            //        "Error",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //}
        }
    }
}
