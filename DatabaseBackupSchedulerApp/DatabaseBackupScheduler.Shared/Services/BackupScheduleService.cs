using DatabaseBackupScheduler.Shared.Data;
using DatabaseBackupScheduler.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupScheduler.Shared.Services
{
    public class BackupScheduleService
    {
        public static async Task SaveBackupSchedule(BackupSchedule request)
        {
            using var db = new ApplicationDBContext();

            // Ensure database is created
            db.Database.EnsureCreated();

            if(request.Id == 0)
                db.BackupSchedules.Add(request);
            else
                db.BackupSchedules.Update(request);

            await db.SaveChangesAsync();
        }

        public static async Task<List<BackupSchedule>> GetBackupSchedules(bool enableOnly = false)
        {
            try
            {
                using var db = new ApplicationDBContext();
                if(enableOnly)
                    return await db.BackupSchedules.Where(x => x.IsEnabled)
                        .ToListAsync();
                return await db.BackupSchedules.ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public static async Task<BackupSchedule?> GetBackupById(int id)
        {
            using var db = new ApplicationDBContext();
            return await db.BackupSchedules
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public static async Task DeleteBackupSchedule(BackupSchedule request)
        {
            using var db = new ApplicationDBContext();
            db.BackupSchedules.Remove(request);
            await db.SaveChangesAsync();
        }
    }
}
