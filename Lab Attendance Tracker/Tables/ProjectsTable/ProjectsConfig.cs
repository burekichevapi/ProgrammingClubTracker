using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Attendance_Tracker.Tables.ProjectsTable
{
    public class ProjectsConfig:EntityTypeConfiguration<Projects>
    {
        public ProjectsConfig()
        {
            HasKey(p => p.ProjectName);

            Property(p => p.ProjectName)
                .HasColumnName("Project Name")
                .HasColumnOrder(1)
                .IsRequired()
                .HasMaxLength(32)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.Description)
                .HasColumnName("Description")
                .HasColumnOrder(2)
                .IsMaxLength()
                .IsOptional();

            HasMany(p => p.Students)
                .WithMany(s => s.Projects)
                .Map(m =>
                {
                    m.ToTable("Students Projects");
                    m.MapLeftKey("Project Name");
                    m.MapRightKey("Student ID");
                });
        }
    }
}
