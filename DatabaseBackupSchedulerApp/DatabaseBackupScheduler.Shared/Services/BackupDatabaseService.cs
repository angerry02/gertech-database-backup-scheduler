using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseBackupScheduler.Shared.Entities;
using MySql.Data.MySqlClient;

namespace DatabaseBackupScheduler.Shared.Services
{
    public class BackupDatabaseService
    {
        public static string BackupScheduledDatabase(BackupSchedule backupSchedule)
        {
            switch(backupSchedule.DatabaseType)
            {
                case Enums.DatabaseType.MYSQL:
                    return ProcessMySqlBackup(backupSchedule);
                default:
                    throw new NotImplementedException("MS Sql backup is currently not supported.");
            }
        }

        private static string ProcessMySqlBackup(BackupSchedule backupSchedule)
        {
            try
            {
                string fileName = $"{backupSchedule.DatabaseName}-{DateTime.Now:MMddyyyy-HHmmss}.sql";
                string path = $"{backupSchedule.BackupPath}\\{backupSchedule.DatabaseName}";

                if(!System.IO.File.Exists(fileName))
                    System.IO.Directory.CreateDirectory(path);

                string file = $"{backupSchedule.BackupPath}\\{backupSchedule.DatabaseName}\\{fileName}";

                using MySqlConnection conn = new(backupSchedule.ConnectionString);
                using MySqlCommand cmd = new();
                using MySqlBackup mb = new(cmd);
                cmd.Connection = conn;
                conn.Open();
                mb.ExportToFile(file);
                conn.Close();

                return $"[{DateTime.Now}] Success: {fileName}";
            }
            catch (Exception ex)
            {
                return $"[{DateTime.Now}] Failed: {ex.Message}";
            }
        }
    }
}
