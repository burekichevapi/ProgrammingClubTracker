using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Attendance_Tracker.AttendanceTable;
using Lab_Attendance_Tracker.Tables.ProjectsTable;
using Lab_Attendance_Tracker.Tables.StudentTable;

namespace Lab_Attendance_Tracker
{
    public class LabAttendanceContext : DbContext
    {
        public LabAttendanceContext() : base("name = AttendanceTracker")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Projects> Project { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new StudentConfig());
            modelBuilder.Configurations.Add(new AttendanceConfig());
            modelBuilder.Configurations.Add(new ProjectsConfig());
        }
    }
}
