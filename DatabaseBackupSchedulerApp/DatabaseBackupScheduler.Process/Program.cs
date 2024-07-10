using DatabaseBackupScheduler.Shared.Entities;
using DatabaseBackupScheduler.Shared.Services;

Console.WriteLine("GERTech: Database Backup Scheduler");
Console.WriteLine("Automate and secure your database backups with flexible scheduling and encryption.");

Console.WriteLine();
Console.WriteLine("Backing up....");
Console.WriteLine();

try
{
    List<BackupSchedule> backupSchedules = await BackupScheduleService.GetBackupSchedules(true);

    foreach (BackupSchedule backupSchedule in backupSchedules)
    {
        Console.WriteLine(backupSchedule.Name);

        backupSchedule.SetLastResult($"[{DateTime.Now}] Backing up started...");
        await BackupScheduleService.SaveBackupSchedule(backupSchedule);

        string result = await Task.Run(() => BackupDatabaseService.RunBackupScheduledDatabase(backupSchedule));

        Console.WriteLine($"Result: {result}");
        Console.WriteLine();

        backupSchedule.SetLastResult(result);
        await BackupScheduleService.SaveBackupSchedule(backupSchedule);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error encountered during executing backup schedule. \n\nDetails: {ex.Message}\n\nPath: {System.Configuration.ConfigurationManager.ConnectionStrings["Data"].ConnectionString}");
    Console.ReadLine();
}