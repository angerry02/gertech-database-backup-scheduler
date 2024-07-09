using DatabaseBackupScheduler.Shared.Entities;
using DatabaseBackupScheduler.Shared.Services;
using Org.BouncyCastle.Asn1.Cmp;

namespace DatabaseBackupScheduler
{
    public partial class Main : Form
    {
        private List<BackupSchedule>? backupSchedules { get; set; }

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
            try
            {
                foreach (ListViewItem item in lvSchedules.Items)
                {
                    int Id = int.Parse(item.SubItems[(int)Columns.ID].Text);

                    BackupSchedule? backupSchedule = backupSchedules.FirstOrDefault(s => s.Id == Id);

                    item.SubItems[(int)Columns.LAST_RUN].Text = "Start backing up...";
                    item.SubItems[(int)Columns.LAST_RUN].Text = await Task.Run(() => BackupDatabaseService.BackupScheduledDatabase(backupSchedule));
                }

                MessageBox.Show($"Done running all backup schedules.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while running backup schedule. Details: {ex.Message}");
            }
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
            backupSchedules = await BackupScheduleService.GetBackupSchedules();

            lvSchedules.Items.Clear();

            int rowNo = 0;
            foreach (var schedule in backupSchedules)
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
            if (lvSchedules.SelectedItems.Count == 0)
                return;

            int id = int.Parse(lvSchedules.SelectedItems[0].SubItems[(int)Columns.ID].Text);
            new frmBackupScheduleForm(id).ShowDialog();

            await DisplaySchedule();
        }
    }
}
