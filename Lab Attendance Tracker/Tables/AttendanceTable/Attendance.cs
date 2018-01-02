using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Attendance_Tracker.Tables.StudentTable;

namespace Lab_Attendance_Tracker.AttendanceTable
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int StudentId { get; set; }
        public string Date { get; set; }
        public Student Student { get; set; }
    }
}
