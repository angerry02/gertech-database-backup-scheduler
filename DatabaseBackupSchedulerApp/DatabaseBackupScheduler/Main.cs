using DatabaseBackupScheduler.Shared.Entities;
using DatabaseBackupScheduler.Shared.Services;
using Org.BouncyCastle.Asn1.Cmp;

namespace DatabaseBackupScheduler
{
    public partial class Main : Form
    {
        private List<BackupSchedule>? BackupSchedules { get; set; }
        private bool IsRunning { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private enum Columns
        {
            NO,
            NAME,
            TYPE,
            ENABLE,
            LAST_RUN,
            ID
        }

        private async void btnBackupNow_Click(object sender, EventArgs e)
        {
            SetState(true);

            try
            {
                foreach (ListViewItem item in lvSchedules.Items)
                {
                    int Id = int.Parse(item.SubItems[(int)Columns.ID].Text);

                    BackupSchedule? backupSchedule = BackupSchedules.FirstOrDefault(s => s.Id == Id);
                    if (!backupSchedule.IsEnabled)
                        continue;

                    item.SubItems[(int)Columns.LAST_RUN].Text = "Start backing up...";
                    string result = await Task.Run(() => BackupDatabaseService.RunBackupScheduledDatabase(backupSchedule));

                    item.SubItems[(int)Columns.LAST_RUN].Text = result;

                    backupSchedule.SetLastResult(result);

                    await BackupScheduleService.SaveBackupSchedule(backupSchedule);
                }

                MessageBox.Show($"Done executing all backup schedules.", 
                    "Success", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error encountered during executing backup schedule. Details: {ex.Message}", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

            SetState(false);
        }

        private void SetState(bool isBackingUp = false)
        {
            IsRunning = isBackingUp;

            btnBackupNow.Enabled = !isBackingUp;
            btnBackupNow.Text = isBackingUp ? "EXECUTING..." : "RUN BACKUP NOW";

            btnAdd.Enabled = !isBackingUp;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            new frmBackupScheduleForm().ShowDialog();
            await DisplaySchedule();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private async Task DisplaySchedule()
        {
            BackupSchedules = await BackupScheduleService.GetBackupSchedules();

            lvSchedules.Items.Clear();

            int rowNo = 0;
            foreach (var schedule in BackupSchedules)
            {
                ListViewItem listView = new((++rowNo).ToString());
                listView.SubItems.Add(schedule.Name);
                listView.SubItems.Add(schedule.DatabaseType.ToString());
                listView.SubItems.Add(schedule.IsEnabled.ToString());
                listView.SubItems.Add(schedule.LastRun);
                listView.SubItems.Add(schedule.Id.ToString());

                lvSchedules.Items.Add(listView);
            }
        }

        private async void Main_Shown(object sender, EventArgs e)
        {
            await DisplaySchedule();
        }

        private async void lvSchedules_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvSchedules.SelectedItems.Count == 0
                && !IsRunning)
                return;

            int id = int.Parse(lvSchedules.SelectedItems[0].SubItems[(int)Columns.ID].Text);
            new frmBackupScheduleForm(id).ShowDialog();

            await DisplaySchedule();
        }
    }
}
