using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Attendance_Tracker.AttendanceTable;
using Lab_Attendance_Tracker.Tables.StudentTable;

namespace Lab_Attendance_Tracker
{
    public class AttendanceManager
    {
        private readonly LabAttendanceContext context = new LabAttendanceContext();
        private Attendance attendance;

        public void AddAttendance(int id)
        {
            attendance = new Attendance
            {
                Date = DateTime.Today.ToString("MM/dd/yyyy"),
                StudentId = id
            };
            context.Attendance.Add(attendance);
            context.SaveChanges();
        }

        public void UpdateDate(int id)
        {
            attendance = context.Attendance.Single(a => a.StudentId == id);
            attendance.Date = DateTime.Today.ToString("MM/dd/yyyy");
            context.SaveChanges();
        }
    }
}
