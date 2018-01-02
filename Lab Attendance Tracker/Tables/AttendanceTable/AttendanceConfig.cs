using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Attendance_Tracker.AttendanceTable
{
    public class AttendanceConfig:EntityTypeConfiguration<Attendance>
    {
        public AttendanceConfig()
        {
            Property(a => a.AttendanceId)
                .HasColumnName("Attendance ID")
                .HasColumnOrder(1)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Date)
                .HasColumnName("Date")
                .HasColumnOrder(3)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            HasRequired(a => a.Student)
                .WithMany()
                .HasForeignKey(a => a.StudentId);
        }
    }
}
