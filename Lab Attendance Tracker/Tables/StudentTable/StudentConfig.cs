using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Attendance_Tracker.Tables.StudentTable
{
    public class StudentConfig:EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            Property(s => s.StudentId)
                .HasColumnName("Student ID")
                .HasColumnOrder(1)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(s => s.LastName)
                .HasColumnName("Last Name")
                .HasColumnOrder(2)
                .HasMaxLength(16);
            Property(s => s.FirstName)
                .HasColumnName("First Name")
                .HasColumnOrder(3)
                .HasMaxLength(16);
            Property(s => s.LastCheckInDate)
                .HasColumnName("Last Check-in")
                .HasColumnOrder(4);
            Property(s => s.TotalCheckIns)
                .HasColumnName("Total Check-ins")
                .HasColumnOrder(5);
        }
    }
}
