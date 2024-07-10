using DatabaseBackupScheduler.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupScheduler.Shared.Entities
{
    public class BackupSchedule
    {
        public BackupSchedule()
        {
            
        }

        public BackupSchedule(int _id,
            string _name,
            string _connectionString,
            DatabaseType _databaseType,
            bool _isEnabled,
            string _databaseName,
            string _backupPath)
        {
            Id = _id;
            Name = _name;
            ConnectionString = _connectionString;
            DatabaseType = _databaseType;
            IsEnabled = _isEnabled;
            DatabaseName = _databaseName;
            BackupPath = _backupPath;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; private set; }

        [MaxLength(100)]
        public string Name { get; private set; }

        [MaxLength(500)]
        public string ConnectionString { get; private set; }

        public DatabaseType DatabaseType { get; private set; } = DatabaseType.MYSQL;

        public bool IsEnabled { get; private set; } = true;

        public string DatabaseName { get; private set; }

        public string BackupPath { get; private set; }

        public string? LastRun { get; private set; }

        public void SetLastResult(string value)
        {
            LastRun = value;
        }
    }
}
