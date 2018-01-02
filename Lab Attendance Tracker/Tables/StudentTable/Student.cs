using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Attendance_Tracker.AttendanceTable;
using Lab_Attendance_Tracker.Tables.ProjectsTable;

namespace Lab_Attendance_Tracker.Tables.StudentTable
{
    public class Student
    {
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? LastCheckInDate { get; set; }
        public int TotalCheckIns { get; set; }
        public Attendance Attendance { get; set; }
        public ICollection<Projects> Projects { get; set; }
    }
}
