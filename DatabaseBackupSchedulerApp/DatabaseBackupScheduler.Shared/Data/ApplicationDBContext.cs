using DatabaseBackupScheduler.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupScheduler.Shared.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<BackupSchedule> BackupSchedules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={System.Configuration.ConfigurationManager.ConnectionStrings["Data"].ConnectionString}");
        }
    }
}
