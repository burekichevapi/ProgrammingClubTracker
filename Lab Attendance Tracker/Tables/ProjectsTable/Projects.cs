using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Attendance_Tracker.Tables.StudentTable;

namespace Lab_Attendance_Tracker.Tables.ProjectsTable
{
    public class Projects
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
