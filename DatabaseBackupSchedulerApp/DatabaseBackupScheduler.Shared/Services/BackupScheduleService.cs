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
        public static async Task AddNewSchedule(BackupSchedule request)
        {
            using var db = new ApplicationDBContext();

            // Ensure database is created
            db.Database.EnsureCreated();

            if(request.Id == 0)
                db.BackupSchedules.Add(request);
            else
            {
                //BackupSchedule? schedule = await db.BackupSchedules
                //    .FirstOrDefaultAsync(s => s.Id == request.Id);

                //schedule.Name = request.Name;

                db.BackupSchedules.Update(request);
            }

            await db.SaveChangesAsync();
        }

        public static async Task<List<BackupSchedule>> GetBackupSchedules()
        {
            try
            {
                using var db = new ApplicationDBContext();
                return await db.BackupSchedules.ToListAsync();
            }
            catch (Exception ex)
            {
                return new();
            }
        }

        public static async Task<BackupSchedule?> GetBackupById(int id)
        {
            using var db = new ApplicationDBContext();
            return await db.BackupSchedules
                .FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
