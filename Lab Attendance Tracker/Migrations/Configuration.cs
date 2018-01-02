
namespace Lab_Attendance_Tracker.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AttendanceTable;
    using Tables.StudentTable;

    internal sealed class Configuration : DbMigrationsConfiguration<Lab_Attendance_Tracker.LabAttendanceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Lab_Attendance_Tracker.LabAttendanceContext context)
        {
/*            Student Amer = new Student
            {
                StudentId = 2122550,
                FirstName = "Amer",
                LastName = "Delic",
                LastCheckInDate = DateTime.Now,
                TotalCheckIns = 3
            };
            Student JohnDoe= new Student
            {
                StudentId = 9999999,
                FirstName = "John",
                LastName = "Doe",
                LastCheckInDate = DateTime.Now,
                TotalCheckIns = 1
            };

            context.Students.AddOrUpdate(s => s.StudentId, Amer, JohnDoe);

            Attendance a1 = new Attendance
            {
                Date = DateTime.Today,
                StudentId = Amer.StudentId
            };
            Attendance a2 = new Attendance
            {
                Date = DateTime.Today,
                StudentId = JohnDoe.StudentId
            };

            context.Attendance.AddOrUpdate(a => a.StudentId, a1, a2);*/
        }
    }
}
