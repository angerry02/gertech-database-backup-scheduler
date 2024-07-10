using DatabaseBackupScheduler.Shared.Entities;
using DatabaseBackupScheduler.Shared.Services;

Console.WriteLine("GERTech: Database Backup Scheduler");
Console.WriteLine("Automate and secure your database backups with flexible scheduling and encryption.");

Console.WriteLine();
Console.WriteLine("Backing up....");
Console.WriteLine();

List<BackupSchedule> backupSchedules = await BackupScheduleService.GetBackupSchedules(true);

try
{
    foreach (BackupSchedule backupSchedule in backupSchedules)
    {
        Console.WriteLine(backupSchedule.Name);

        string result = await Task.Run(() => BackupDatabaseService.RunBackupScheduledDatabase(backupSchedule));

        Console.WriteLine($"Result: {result}");
        Console.WriteLine();

        backupSchedule.SetLastResult(result);

        await BackupScheduleService.SaveBackupSchedule(backupSchedule);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error encountered during executing backup schedule. Details: {ex.Message}");
    Console.ReadLine();
}